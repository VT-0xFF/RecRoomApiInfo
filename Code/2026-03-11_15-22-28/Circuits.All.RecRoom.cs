using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Circuits.All.Api;
using Circuits.All.RecRoom.Dependencies;
using Circuits.All.RecRoom.Injection;
using Circuits.All.RecRoom.Integration;
using Circuits.All.RecRoom.Payload;
using Circuits.Dynamic.Api;
using Circuits.Dynamic.RecRoom.Api;
using Circuits.Shared.Api;
using Circuits.Shared.RecRoom.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Api;
using Circuits.Static.Core.NetSystem;
using Circuits.Static.Core.RequestReduce;
using Circuits.Static.Core.TypeSystem;
using Circuits.Static.RecRoom;
using Circuits.Static.RecRoom.Api;
using Circuits.Static.RecRoom.Dependencies;
using Circuits.Static.RecRoom.GraphDefs;
using Circuits.Static.RecRoom.Protobuf;
using Circuits.Static.Utilities;
using CircuitsV2;
using CircuitsV2.Dependencies;
using CircuitsV2.DynamicNetSystem;
using CircuitsV2.Lang;
using CircuitsV2.Lang.Graphs;
using CircuitsV2.Lang.Messages;
using CircuitsV2.Lang.Nodes;
using CircuitsV2.Lang.Nodes.Audio;
using CircuitsV2.Lang.Nodes.ChatAI;
using CircuitsV2.Lang.Nodes.CreationObject;
using CircuitsV2.Lang.Nodes.DataTable;
using CircuitsV2.Lang.Nodes.Econ;
using CircuitsV2.Lang.Nodes.GameAI;
using CircuitsV2.Lang.Nodes.Locomotion;
using CircuitsV2.Lang.Nodes.Messages;
using CircuitsV2.Lang.Nodes.StudioNodes;
using CircuitsV2.Lang.Nodes.Variable;
using CircuitsV2.LegacyError;
using CircuitsV2.Persistence;
using CircuitsV2.Persistence.Payload;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28C6730", Offset = "0x28C5730", VA = "0x1828C6730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.Circuits_All_RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28BB760", Offset = "0x28BA760", VA = "0x1828BB760", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class UOILJAPMYSC : IDisposable, YXWIBOYZOAX, XBNNPGFTCSK, OFJJMNAWHNF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class ZEHBKVBQRWN : OAIZGCDVQOY
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int QQLXBANJEMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x28D84C0", Offset = "0x28D74C0", VA = "0x1828D84C0", Slot = "5")]
			public EIQLKIGJKVE NPVNRUQAFRD(UIREVXYUNXH.OAIZGCDVQOY a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void FCXSSATHXXR();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void JRIUYTIFPSW();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x28ACE90", Offset = "0x28ABE90", VA = "0x1828ACE90", Slot = "13")]
			public virtual void HBXDSCFKEGS(UOILJAPMYSC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x28D82E0", Offset = "0x28D72E0", VA = "0x1828D82E0", Slot = "14")]
			public virtual void BDVCVIUYBIX(UOILJAPMYSC a, PQYWNUACEKJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			protected ZEHBKVBQRWN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface OAIZGCDVQOY
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int QQLXBANJEMF
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			EIQLKIGJKVE NPVNRUQAFRD(UIREVXYUNXH.OAIZGCDVQOY a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void FCXSSATHXXR();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void JRIUYTIFPSW();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void HBXDSCFKEGS(UOILJAPMYSC a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void BDVCVIUYBIX(UOILJAPMYSC a, PQYWNUACEKJ b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, PQYWNUACEKJ, UOILJAPMYSC, FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x104DAA0", Offset = "0x104CAA0", VA = "0x18104DAA0")]
			internal Reducer(Reducer<ActionKind, PQYWNUACEKJ, UOILJAPMYSC, FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class DAAXGYBMJHB : FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly DAAXGYBMJHB QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private DAAXGYBMJHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x12B1310", Offset = "0x12B0310", VA = "0x1812B1310", Slot = "4")]
			public ActionKind FIEUTOTGZEL(PQYWNUACEKJ a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x28B7E30", Offset = "0x28B6E30", VA = "0x1828B7E30", Slot = "5")]
			public void HBXDSCFKEGS(UOILJAPMYSC a, PQYWNUACEKJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x28B7D20", Offset = "0x28B6D20", VA = "0x1828B7D20", Slot = "6")]
			public void BDVCVIUYBIX(UOILJAPMYSC a, PQYWNUACEKJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, PQYWNUACEKJ, UOILJAPMYSC, FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x28C8090", Offset = "0x28C7090", VA = "0x1828C8090")]
			internal ReducerFactory(ReducerFactory<ActionKind, PQYWNUACEKJ, UOILJAPMYSC, FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x28C8040", Offset = "0x28C7040", VA = "0x1828C8040")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : NKGUVMYRRNL.QYWHQDXZBHN<PQYWNUACEKJ, UOILJAPMYSC>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private struct <ReceiveAction>d__2 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public AsyncTaskMethodBuilder<Result<object?, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public UOILJAPMYSC receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public PQYWNUACEKJ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x28CD0A0", Offset = "0x28CC0A0", VA = "0x1828CD0A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x28CD280", Offset = "0x28CC280", VA = "0x1828CD280", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB311F0", Offset = "0xB301F0", VA = "0x180B311F0", Slot = "4")]
			public Id32<OFTCEQFRRMD> SDFJROKLFJC(UOILJAPMYSC a)
			{
				return default(Id32<OFTCEQFRRMD>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x28CC270", Offset = "0x28CB270", VA = "0x1828CC270", Slot = "5")]
			public void SNLPBIBSKLJ(UOILJAPMYSC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x28CC120", Offset = "0x28CB120", VA = "0x1828CC120", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, WENLUTALDTF>> GYVMBXXLYIG(UOILJAPMYSC a, PQYWNUACEKJ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x28CC250", Offset = "0x28CB250", VA = "0x1828CC250", Slot = "7")]
			public PQYWNUACEKJ[] ILZYHQHQMHK(UOILJAPMYSC a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__36 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Result<object?, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public UOILJAPMYSC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public PQYWNUACEKJ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x28CD2F0", Offset = "0x28CC2F0", VA = "0x1828CD2F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x28CD4E0", Offset = "0x28CC4E0", VA = "0x1828CD4E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <RequestInitializeFromSave>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<Result<bool, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public UOILJAPMYSC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x28CEA20", Offset = "0x28CDA20", VA = "0x1828CEA20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x28CECA0", Offset = "0x28CDCA0", VA = "0x1828CECA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <RequestRefreshLifecycle>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public UOILJAPMYSC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x28CED10", Offset = "0x28CDD10", VA = "0x1828CED10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x28CEEF0", Offset = "0x28CDEF0", VA = "0x1828CEEF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<OFTCEQFRRMD> GGOHDYLAGYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer LSQOJACFGTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 AJSQJKXCEVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly DPGTGQXFVAL OXXSTAAPQTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly THPTAACPNZD.CreationArgs XTWUKUVUYQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly DUGXFDUFSFY ATHOFBYZGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly YQUZKKNPTDH TIJQXLKEMKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly WPNWJJFNAJE XLZKTAMLOSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly QQFDBEWOQNZ QUWPIZIWKYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly HZRQNDYNBBX XFYJXHZXLDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly ZHDUPJLBPZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly UYAHMYZQAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest FVKEUSFESVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended KVTDBLTOWRS;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal OAIZGCDVQOY DBQLGDYEGJB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x28D3A80", Offset = "0x28D2A80", VA = "0x1828D3A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal EIQLKIGJKVE XTEKXDOMUNH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x28D3AD0", Offset = "0x28D2AD0", VA = "0x1828D3AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x28D3AE0", Offset = "0x28D2AE0", VA = "0x1828D3AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool PEMCKZEQQUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x28D2A40", Offset = "0x28D1A40", VA = "0x1828D2A40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x28D2850", Offset = "0x28D1850", VA = "0x1828D2850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public BALOETBZKJH DUGXFDUFSFY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x28D3DF0", Offset = "0x28D2DF0", VA = "0x1828D3DF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RZAFZPKPPOH WPNWJJFNAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x28D3E00", Offset = "0x28D2E00", VA = "0x1828D3E00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CDGWYKPACEI HZRQNDYNBBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x28D3E20", Offset = "0x28D2E20", VA = "0x1828D3E20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public AYKBPIRHSRG YQUZKKNPTDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x28D3A20", Offset = "0x28D2A20", VA = "0x1828D3A20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public YFUDWZWXTDG QQFDBEWOQNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x28D3E10", Offset = "0x28D2E10", VA = "0x1828D3E10", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public THPTAACPNZD? THPTAACPNZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x28D2CD0", Offset = "0x28D1CD0", VA = "0x1828D2CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28D3B00", Offset = "0x28D2B00", VA = "0x1828D3B00")]
		private UOILJAPMYSC(DPGTGQXFVAL a, Id32<OFTCEQFRRMD> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, EIQLKIGJKVE b, [In] THPTAACPNZD.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28D3670", Offset = "0x28D2670", VA = "0x1828D3670")]
		public static UOILJAPMYSC New(DPGTGQXFVAL deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<OFTCEQFRRMD> actorId, Id32<UYHKNYSICNO> rootNetworkObjectId, BKAMUOKSWTC staticNetSys, SPVIFMMAWWI dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28D33B0", Offset = "0x28D23B0", VA = "0x1828D33B0")]
		public static UOILJAPMYSC New(DPGTGQXFVAL dependencies, [In] RegistryV2 registryV2, Id32<OFTCEQFRRMD> actorId, Id32<UYHKNYSICNO> rootNetworkObjectId, BKAMUOKSWTC staticNetSys, SPVIFMMAWWI dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28D2860", Offset = "0x28D1860", VA = "0x1828D2860", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28D31B0", Offset = "0x28D21B0", VA = "0x1828D31B0")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, WENLUTALDTF>> KJYJPAJDSHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28D3930", Offset = "0x28D2930", VA = "0x1828D3930")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, WENLUTALDTF>> OKGJJWNLCBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28D2A50", Offset = "0x28D1A50", VA = "0x1828D2A50")]
		internal void FXXYCVKPAUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28D2C50", Offset = "0x28D1C50", VA = "0x1828D2C50")]
		internal Option<PQYWNUACEKJ> GHVXFLRUSUT([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<PQYWNUACEKJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28D3740", Offset = "0x28D2740", VA = "0x1828D3740")]
		internal bool OCOQAPHWNBG([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28D37B0", Offset = "0x28D27B0", VA = "0x1828D37B0")]
		internal Result<PQYWNUACEKJ, WENLUTALDTF> ODHNVOEILOP([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<PQYWNUACEKJ, WENLUTALDTF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28D3A30", Offset = "0x28D2A30", VA = "0x1828D3A30")]
		private void SNLPBIBSKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28D32A0", Offset = "0x28D22A0", VA = "0x1828D32A0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, WENLUTALDTF>> MLSNZDHNTMX(PQYWNUACEKJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28D2DB0", Offset = "0x28D1DB0", VA = "0x1828D2DB0")]
		private PQYWNUACEKJ[] ILZYHQHQMHK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class LMBUEUNQLFA<a> : DEINNYDYQPE, CIUFJAXBKGI, IMZVXBWNFZH where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<QYHWLOYXTJM>? BDCASIKTNVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string BPUHFNVKSFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a TNFSBSIRYTJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<QYHWLOYXTJM>? ERKZJAJVQWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9300", Offset = "0x2BA8300", VA = "0x182BA9300", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x554A900", Offset = "0x5549900", VA = "0x18554A900")]
		internal LMBUEUNQLFA([In] Id128<QYHWLOYXTJM>? lastNode, Id32<IBLIHIPUJYN>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class LCFEYNBOPZK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28BB2C0", Offset = "0x28BA2C0", VA = "0x1828BB2C0")]
		public static Result<DebugExecutionResult, CIUFJAXBKGI> ECCEIPHNUWD([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, CIUFJAXBKGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x38194C0", Offset = "0x38184C0", VA = "0x1838194C0")]
		public static Result<TOk, CIUFJAXBKGI> ROBLWGPEKSN<TOk>([In] this Result<TOk, CIUFJAXBKGI> self, [In] Id128<QYHWLOYXTJM>? lastNode, Id32<IBLIHIPUJYN>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, CIUFJAXBKGI>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface DPGTGQXFVAL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		UIREVXYUNXH.OAIZGCDVQOY QQRVOEQPRMH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		UOILJAPMYSC.OAIZGCDVQOY SDBIWRFJWSE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		YDXEBHQLRCV.OAIZGCDVQOY BDDWPDEHHVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC> DAAXGYBMJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.OAIZGCDVQOY WDCGBECLVNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		QDTLTHTSXNH CHLMVZKAAGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		GHEKOECVSUE ORWRCEUNBON
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		YHJIQBACQBQ VOBKBRFJJRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		GQQCNTKRUZA LGTNDZQQNBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		ZOCCJHRAKXK IAIREJBMFXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}
	}
}
namespace Circuits.All.RecRoom.Payload
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class UNVJFPUDZYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28D2670", Offset = "0x28D1670", VA = "0x1828D2670")]
		public static PQYWNUACEKJ DCDCUDFHFQX(this PQYWNUACEKJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28D2780", Offset = "0x28D1780", VA = "0x1828D2780")]
		public static PQYWNUACEKJ NSWFFHXWRQU(this CompressedPayload a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct CompressedPayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AsyncTaskMethodBuilder<Result<object?, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public UOILJAPMYSC root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x28CD550", Offset = "0x28CC550", VA = "0x1828CD550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x28CDC80", Offset = "0x28CCC80", VA = "0x1828CDC80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28B7AA0", Offset = "0x28B6AA0", VA = "0x1828B7AA0")]
		public static PQYWNUACEKJ BNFBJREUBKF(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28B7B60", Offset = "0x28B6B60", VA = "0x1828B7B60")]
		public static ReduceAction<ActionKind, CompressedPayload> GJWDSZLKQWM(PQYWNUACEKJ actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28B7C10", Offset = "0x28B6C10", VA = "0x1828B7C10")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, WENLUTALDTF>> MLSNZDHNTMX(UOILJAPMYSC a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x28B8140", Offset = "0x28B7140", VA = "0x1828B8140")]
		public static PQYWNUACEKJ BNFBJREUBKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28B81E0", Offset = "0x28B71E0", VA = "0x1828B81E0")]
		public static ReduceAction<ActionKind, DestroyPayload> GJWDSZLKQWM(PQYWNUACEKJ actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x28B80C0", Offset = "0x28B70C0", VA = "0x1828B80C0")]
		public static Result<None, DBVSZHNUYXO> BCBNDGZRWKV(UOILJAPMYSC a, [In] DestroyPayload self)
		{
			return default(Result<None, DBVSZHNUYXO>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct FullInitializePayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder<Result<None, DBVSZHNUYXO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public UOILJAPMYSC root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, DBVSZHNUYXO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x28CDD60", Offset = "0x28CCD60", VA = "0x1828CDD60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x28CE300", Offset = "0x28CD300", VA = "0x1828CE300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly CircuitRootData? CircuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly SuperRoomData? SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public readonly CircuitStudioUnitySubAssetUsageData? StudioUnitySubAssetUsageData;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1CB02F0", Offset = "0x1CAF2F0", VA = "0x181CB02F0")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x28B8530", Offset = "0x28B7530", VA = "0x1828B8530")]
		public static PQYWNUACEKJ? BNFBJREUBKF(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28B8630", Offset = "0x28B7630", VA = "0x1828B8630")]
		public static ReduceAction<ActionKind, FullInitializePayload> GJWDSZLKQWM(PQYWNUACEKJ actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28B8740", Offset = "0x28B7740", VA = "0x1828B8740")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, DBVSZHNUYXO>> MLSNZDHNTMX(UOILJAPMYSC a, FullInitializePayload b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct MultiPayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public AsyncTaskMethodBuilder<Result<MultiResult, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public UOILJAPMYSC root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, WENLUTALDTF> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, IMZVXBWNFZH>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, IMZVXBWNFZH> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, IMZVXBWNFZH>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x28CD810", Offset = "0x28CC810", VA = "0x1828CD810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x28CDCF0", Offset = "0x28CCCF0", VA = "0x1828CDCF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<PQYWNUACEKJ> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
		private MultiPayload(IReadOnlyList<PQYWNUACEKJ> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28C61B0", Offset = "0x28C51B0", VA = "0x1828C61B0")]
		public static PQYWNUACEKJ BNFBJREUBKF(IReadOnlyList<PQYWNUACEKJ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28C6270", Offset = "0x28C5270", VA = "0x1828C6270")]
		public static ReduceAction<ActionKind, MultiPayload> GJWDSZLKQWM(PQYWNUACEKJ actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x28C6310", Offset = "0x28C5310", VA = "0x1828C6310")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, WENLUTALDTF>> MLSNZDHNTMX(UOILJAPMYSC a, MultiPayload b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public readonly struct PartialActionPayload
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class IAADXXIOWVK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> IODXCBFHHLW;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public IAADXXIOWVK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x28BABE0", Offset = "0x28B9BE0", VA = "0x1828BABE0")]
			internal PQYWNUACEKJ WCFCOFOOFNO(int a, int b, [In] ReadOnlySpan<byte> span)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly Id128<M> ActionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly int Count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly byte[] Data;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28C71E0", Offset = "0x28C61E0", VA = "0x1828C71E0")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28C6E80", Offset = "0x28C5E80", VA = "0x1828C6E80")]
		public static PQYWNUACEKJ BNFBJREUBKF(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28C6F90", Offset = "0x28C5F90", VA = "0x1828C6F90")]
		public static PQYWNUACEKJ[] CRRXQXHUSRK(PQYWNUACEKJ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28C7090", Offset = "0x28C6090", VA = "0x1828C7090")]
		public static ReduceAction<ActionKind, PartialActionPayload> GJWDSZLKQWM(PQYWNUACEKJ actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28C6CF0", Offset = "0x28C5CF0", VA = "0x1828C6CF0")]
		public static Result<PQYWNUACEKJ, WENLUTALDTF> BCBNDGZRWKV(UOILJAPMYSC a, [In] PartialActionPayload self)
		{
			return default(Result<PQYWNUACEKJ, WENLUTALDTF>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public readonly struct PartialInitializePayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AsyncTaskMethodBuilder<Result<bool, DBVSZHNUYXO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public UOILJAPMYSC root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, DBVSZHNUYXO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, DBVSZHNUYXO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x28CE370", Offset = "0x28CD370", VA = "0x1828CE370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x28CE9B0", Offset = "0x28CD9B0", VA = "0x1828CE9B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly int Count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly byte[] Data;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB34A60", Offset = "0xB33A60", VA = "0x180B34A60")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28C7200", Offset = "0x28C6200", VA = "0x1828C7200")]
		public static PQYWNUACEKJ BNFBJREUBKF(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28C73C0", Offset = "0x28C63C0", VA = "0x1828C73C0")]
		public static PQYWNUACEKJ?[]? LJRAVXQINQG(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28C72E0", Offset = "0x28C62E0", VA = "0x1828C72E0")]
		public static ReduceAction<ActionKind, PartialInitializePayload> GJWDSZLKQWM(PQYWNUACEKJ actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C65B0", VA = "0x1828C75B0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, DBVSZHNUYXO>> MLSNZDHNTMX(UOILJAPMYSC a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class DUGXFDUFSFY : BALOETBZKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly UOILJAPMYSC HHSEEZECAYH;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public BVSIINNVXBA? QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x28B7FB0", Offset = "0x28B6FB0", VA = "0x1828B7FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		internal DUGXFDUFSFY(UOILJAPMYSC a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class ZXTXENDIWRT : BVSIINNVXBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly UOILJAPMYSC HHSEEZECAYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly THPTAACPNZD IEBOMHSLGGR;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xACA870", Offset = "0xAC9870", VA = "0x180ACA870")]
		public ZXTXENDIWRT(UOILJAPMYSC a, THPTAACPNZD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28D8D60", Offset = "0x28D7D60", VA = "0x1828D8D60", Slot = "4")]
		public Result<DebugExecutionResult, CIUFJAXBKGI> IDFTSSDCVVL(Id128<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId, Id32<FTMQHXHFOAQ> inputId)
		{
			return default(Result<DebugExecutionResult, CIUFJAXBKGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28D9310", Offset = "0x28D8310", VA = "0x1828D9310", Slot = "5")]
		public Result<DebugExecutionResult, CIUFJAXBKGI> TDFOHXGYGRG(Id128<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId, Id32<CCYGKVMNTMH> outputId)
		{
			return default(Result<DebugExecutionResult, CIUFJAXBKGI>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UIREVXYUNXH : EIQLKIGJKVE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface OAIZGCDVQOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<NZDCYEHGQGM> DOQTRTGCMPP(UOILJAPMYSC a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void VWDSSIPUNTV(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class ZEHBKVBQRWN : OAIZGCDVQOY
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000029")]
			[CompilerGenerated]
			private struct <DeserializeInstance>d__0 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				public AsyncTaskMethodBuilder<NZDCYEHGQGM> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public UOILJAPMYSC circuitsManager;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				public CircuitRootData cv2RoomData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				public SuperRoomData cv2SuperRoomData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400006D")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400006E")]
				private TaskAwaiter<YDXEBHQLRCV> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x28CC650", Offset = "0x28CB650", VA = "0x1828CC650", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x28CC820", Offset = "0x28CB820", VA = "0x1828CC820", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x28D8360", Offset = "0x28D7360", VA = "0x1828D8360", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<NZDCYEHGQGM> DOQTRTGCMPP(UOILJAPMYSC a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void VWDSSIPUNTV(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			protected ZEHBKVBQRWN()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct <GetInstanceAsync>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AsyncTaskMethodBuilder<NZDCYEHGQGM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public UIREVXYUNXH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28CC890", Offset = "0x28CB890", VA = "0x1828CC890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28CCA90", Offset = "0x28CBA90", VA = "0x1828CCA90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <InitializeAsync>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public UIREVXYUNXH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public UOILJAPMYSC circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<NZDCYEHGQGM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x28CCB00", Offset = "0x28CBB00", VA = "0x1828CCB00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x28CD040", Offset = "0x28CC040", VA = "0x1828CD040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly OAIZGCDVQOY USEUOEMXTCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> MZXGOIGLQSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> KDNWDQBKCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource PGMXSNLTSOK;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool PEMCKZEQQUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB25800", Offset = "0xB24800", VA = "0x180B25800", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB25890", Offset = "0xB24890", VA = "0x180B25890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCE9450", Offset = "0xCE8450", VA = "0x180CE9450", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD233E0", Offset = "0xD223E0", VA = "0x180D233E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool EGAKNONAWNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1848990", Offset = "0x1847990", VA = "0x181848990")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1898DB0", Offset = "0x1897DB0", VA = "0x181898DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public NZDCYEHGQGM? QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAD3540", Offset = "0xAD2540", VA = "0x180AD3540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28D2420", Offset = "0x28D1420", VA = "0x1828D2420", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<NZDCYEHGQGM> KQGUZBTQVWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28D2510", Offset = "0x28D1510", VA = "0x1828D2510")]
		public UIREVXYUNXH(OAIZGCDVQOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28D22E0", Offset = "0x28D12E0", VA = "0x1828D22E0", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task IKTNKHSRCTZ(UOILJAPMYSC a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28D2170", Offset = "0x28D1170", VA = "0x1828D2170", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class AFNVVMHBIIY : DWXCQSAYODB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly FYLRPLOTYZY JLYWSQPTUER;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public AFNVVMHBIIY(FYLRPLOTYZY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class YCRVPLYIQKL
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class DQJKLZHJCNF<a> : KBQIDJEAJVG where a : XQGXKQNGDGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a ATOFLOURNXK;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? MWIRJVDPXIO
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xC95020", Offset = "0xC94020", VA = "0x180C95020", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<QYHWLOYXTJM>? OVEADMNPRZE
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x4239CC0", Offset = "0x4238CC0", VA = "0x184239CC0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<YHQFEYRJQPY> NCYNZJTAPLW
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2BB88A0", Offset = "0x2BB78A0", VA = "0x182BB88A0", Slot = "5")]
				get
				{
					return default(Id32<YHQFEYRJQPY>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<YHQFEYRJQPY>? FIQYMCVGDYE
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x4239D70", Offset = "0x4238D70", VA = "0x184239D70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
			public DQJKLZHJCNF(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class HQZNZHPAXNZ : DQJKLZHJCNF<EYIDLDDAXLR>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? MWIRJVDPXIO
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xDD2280", Offset = "0xDD1280", VA = "0x180DD2280", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x28BAB10", Offset = "0x28B9B10", VA = "0x1828BAB10")]
			public HQZNZHPAXNZ(EYIDLDDAXLR a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x28D8160", Offset = "0x28D7160", VA = "0x1828D8160")]
		public static KBQIDJEAJVG New(XQGXKQNGDGG graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class SQIEFOYBQJN : XZKGHBWPPMK, YKZVLCJWURS, ADJDNATJUCX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class QUCIZNCJVUR
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000033")]
			private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000089")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400008A")]
				public QUCIZNCJVUR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public QDTLTHTSXNH errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x28D00F0", Offset = "0x28CF0F0", VA = "0x1828D00F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x28D0360", Offset = "0x28CF360", VA = "0x1828D0360", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public SQIEFOYBQJN SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool XVWHNYMVRGE;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public QUCIZNCJVUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x28C77B0", Offset = "0x28C67B0", VA = "0x1828C77B0")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task ATAGKBVUKTL(QDTLTHTSXNH a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ZJPXWKIVNCR
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public ZJPXWKIVNCR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x28D03C0", Offset = "0x28CF3C0", VA = "0x1828D03C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x28D06A0", Offset = "0x28CF6A0", VA = "0x1828D06A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public SQIEFOYBQJN SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int XVWHNYMVRGE;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ZJPXWKIVNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x28D85F0", Offset = "0x28D75F0", VA = "0x1828D85F0")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task OHCQFVVYJKP(QDTLTHTSXNH a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class VQXJMTHRJLS
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			private struct <<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public VQXJMTHRJLS <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x28D0C10", Offset = "0x28CFC10", VA = "0x1828D0C10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x28D10C0", Offset = "0x28D00C0", VA = "0x1828D10C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string XVWHNYMVRGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public SQIEFOYBQJN SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int WQCNGYCMDEU;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public VQXJMTHRJLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x28D6270", Offset = "0x28D5270", VA = "0x1828D6270")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task VLPZNNQFZRL(QDTLTHTSXNH a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class QEABJPDWHPV
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private struct <<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400009D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400009E")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400009F")]
				public QEABJPDWHPV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x28D0700", Offset = "0x28CF700", VA = "0x1828D0700", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x28D0BB0", Offset = "0x28CFBB0", VA = "0x1828D0BB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string XVWHNYMVRGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public SQIEFOYBQJN SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int WQCNGYCMDEU;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public QEABJPDWHPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x28C76E0", Offset = "0x28C66E0", VA = "0x1828C76E0")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task GVHFFKAKCSV(QDTLTHTSXNH a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private struct <RequestSetDefaultValue>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public bool checkStringPurity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public SQIEFOYBQJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x28CEF60", Offset = "0x28CDF60", VA = "0x1828CEF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x28CF460", Offset = "0x28CE460", VA = "0x1828CF460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly PURXATKNAFM EISGHRFPJEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<CGHNBIIQIGQ> HOSUXFLMOLX;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private DPGTGQXFVAL ZEHBKVBQRWN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x28CB690", Offset = "0x28CA690", VA = "0x1828CB690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<FTMQHXHFOAQ> HDUWOWRDWST
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xBA0FC0", Offset = "0xB9FFC0", VA = "0x180BA0FC0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<FTMQHXHFOAQ>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xCA0E60", Offset = "0xC9FE60", VA = "0x180CA0E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<KRDUNWCYLJD> KKHXPXHNWQB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x28559F0", Offset = "0x28549F0", VA = "0x1828559F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<SUVSOCRKLLI> EEOMTCDRTMU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1026460", Offset = "0x1025460", VA = "0x181026460", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<SUVSOCRKLLI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<IBLIHIPUJYN> JVCKDADCBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x28C96D0", Offset = "0x28C86D0", VA = "0x1828C96D0", Slot = "22")]
			get
			{
				return default(Id32<IBLIHIPUJYN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool VKHKCTBEOGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x28CB240", Offset = "0x28CA240", VA = "0x1828CB240", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x28CBF00", Offset = "0x28CAF00", VA = "0x1828CBF00")]
		private SQIEFOYBQJN(UOILJAPMYSC a, TYZPRJYTRRB b, PURXATKNAFM c, Id32<JPZDQKXUTWI> portGroupId, Id32<FTMQHXHFOAQ> inputId, Id32<KRDUNWCYLJD> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x28C9CE0", Offset = "0x28C8CE0", VA = "0x1828C9CE0")]
		public static SQIEFOYBQJN New(UOILJAPMYSC circuitsManager, TYZPRJYTRRB node, PURXATKNAFM input, Id32<JPZDQKXUTWI> portGroupId, Id32<KRDUNWCYLJD> inputDefId, Id32<FTMQHXHFOAQ> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x28C95B0", Offset = "0x28C85B0", VA = "0x1828C95B0", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x28C8E90", Offset = "0x28C7E90", VA = "0x1828C8E90", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x28C8A00", Offset = "0x28C7A00", VA = "0x1828C8A00", Slot = "32")]
		public void CVDQBUIDTHE(CGHNBIIQIGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x28CB8D0", Offset = "0x28CA8D0", VA = "0x1828CB8D0", Slot = "29")]
		public void TLGFLIRLBFP(TGTDWGPCXQE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x28CA090", Offset = "0x28C9090", VA = "0x1828CA090", Slot = "30")]
		public void ODXWDJDFAFG(UMHYZWGZBXE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x28C9AB0", Offset = "0x28C8AB0", VA = "0x1828C9AB0", Slot = "25")]
		protected override void JRTJHCQHGZU(YTNVHBLQUIV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x28CB0D0", Offset = "0x28CA0D0", VA = "0x1828CB0D0", Slot = "34")]
		public string OVPGSOKIBYH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x28C80A0", Offset = "0x28C70A0", VA = "0x1828C80A0", Slot = "31")]
		public string BCXERZGXRYN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x28CB6B0", Offset = "0x28CA6B0", VA = "0x1828CB6B0")]
		private void TJNMMYBPGEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x28CB010", Offset = "0x28CA010", VA = "0x1828CB010", Slot = "33")]
		public void OKBUAXHFNCN(CGHNBIIQIGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28C92B0", Offset = "0x28C82B0", VA = "0x1828C92B0")]
		private void GIEQTARNJUW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x28C88F0", Offset = "0x28C78F0", VA = "0x1828C88F0", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task CHUSXRFOONA(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x28C9B90", Offset = "0x28C8B90", VA = "0x1828C9B90")]
		public void LOBBMSSIWWD(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x28CBC90", Offset = "0x28CAC90", VA = "0x1828CBC90")]
		private void WJZFISDQVLB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x28C8F30", Offset = "0x28C7F30", VA = "0x1828C8F30")]
		private void EIDLNTYRABJ(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x28C90F0", Offset = "0x28C80F0", VA = "0x1828C90F0")]
		private void ELLTFQPJDAQ(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28C9470", Offset = "0x28C8470", VA = "0x1828C9470")]
		private string HSMXSYFOBFB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28C8360", Offset = "0x28C7360", VA = "0x1828C8360")]
		private string BEWDZORYPFY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xCA0E60", Offset = "0xC9FE60", VA = "0x180CA0E60")]
		internal void LZGJQZQFKHH(Id32<FTMQHXHFOAQ> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28C8670", Offset = "0x28C7670", VA = "0x1828C8670")]
		[CompilerGenerated]
		private void CDDZINSYKMO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28C8680", Offset = "0x28C7680", VA = "0x1828C8680")]
		[CompilerGenerated]
		private bool CDJGFUMVTXX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28C85B0", Offset = "0x28C75B0", VA = "0x1828C85B0")]
		[CompilerGenerated]
		private bool CCYSLGZBBBF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28C8810", Offset = "0x28C7810", VA = "0x1828C8810")]
		[CompilerGenerated]
		private int CDZAXOUNWFY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28C8860", Offset = "0x28C7860", VA = "0x1828C8860")]
		[CompilerGenerated]
		private bool CEEHUVOLFRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28C8740", Offset = "0x28C7740", VA = "0x1828C8740")]
		[CompilerGenerated]
		private void CDONDBGTDJG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28C8750", Offset = "0x28C7750", VA = "0x1828C8750")]
		[CompilerGenerated]
		private bool CDTUAIAQMUP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28C84D0", Offset = "0x28C74D0", VA = "0x1828C84D0")]
		[CompilerGenerated]
		private bool CBNWELPTMZU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28C8520", Offset = "0x28C7520", VA = "0x1828C8520")]
		[CompilerGenerated]
		private bool CBTDBSJQWLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28C8810", Offset = "0x28C7810", VA = "0x1828C8810")]
		[CompilerGenerated]
		private int DEUIFQFJOQT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28C8A60", Offset = "0x28C7A60", VA = "0x1828C8A60")]
		[CompilerGenerated]
		private bool DEPBIJLMFFK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28C8B80", Offset = "0x28C7B80", VA = "0x1828C8B80")]
		[CompilerGenerated]
		private object DFEWADTEHNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28C8B30", Offset = "0x28C7B30", VA = "0x1828C8B30")]
		[CompilerGenerated]
		private void DEZPCWZGYCC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28C8BE0", Offset = "0x28C7BE0", VA = "0x1828C8BE0")]
		[CompilerGenerated]
		private bool DFKCXKNBQYU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28C8CC0", Offset = "0x28C7CC0", VA = "0x1828C8CC0")]
		[CompilerGenerated]
		private string DFZXPEUTTGV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28C8CB0", Offset = "0x28C7CB0", VA = "0x1828C8CB0")]
		[CompilerGenerated]
		private void DFUQRYAWJVM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28C8DC0", Offset = "0x28C7DC0", VA = "0x1828C8DC0")]
		[CompilerGenerated]
		private bool DGKLJSIOMDN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28C8D40", Offset = "0x28C7D40", VA = "0x1828C8D40")]
		[CompilerGenerated]
		private string DGFEMLORCSE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28C9720", Offset = "0x28C8720", VA = "0x1828C9720")]
		[CompilerGenerated]
		private void JJFENDSVVJC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28C9730", Offset = "0x28C8730", VA = "0x1828C9730")]
		[CompilerGenerated]
		private bool JJKLKKMTEUL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28C9800", Offset = "0x28C8800", VA = "0x1828C9800")]
		[CompilerGenerated]
		private string JJPSHRGQOFU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x28C9880", Offset = "0x28C8880", VA = "0x1828C9880")]
		[CompilerGenerated]
		private void JJUZEYANXRD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28C9890", Offset = "0x28C8890", VA = "0x1828C9890")]
		[CompilerGenerated]
		private bool JKAGCEULHCM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28C9960", Offset = "0x28C8960", VA = "0x1828C9960")]
		[CompilerGenerated]
		private string JKFMZLOIQNV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28C99D0", Offset = "0x28C89D0", VA = "0x1828C99D0")]
		[CompilerGenerated]
		private void JKKTWSIFZZE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28C99E0", Offset = "0x28C89E0", VA = "0x1828C99E0")]
		[CompilerGenerated]
		private bool JKQATZCDJKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x28C9650", Offset = "0x28C8650", VA = "0x1828C9650")]
		[CompilerGenerated]
		private string JHPBJBPQXWI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28C96C0", Offset = "0x28C86C0", VA = "0x1828C96C0")]
		[CompilerGenerated]
		private void JHUIGIJOHHR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28CB410", Offset = "0x28CA410", VA = "0x1828CB410")]
		[CompilerGenerated]
		private bool PJYKYOBXZFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28CB3A0", Offset = "0x28CA3A0", VA = "0x1828CB3A0")]
		[CompilerGenerated]
		private string PJTEBHIAPTU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28CB390", Offset = "0x28CA390", VA = "0x1828CB390")]
		[CompilerGenerated]
		private void PJNXEAODGIL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28CB2C0", Offset = "0x28CA2C0", VA = "0x1828CB2C0")]
		[CompilerGenerated]
		private bool PJIQGTUFWXC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28CB620", Offset = "0x28CA620", VA = "0x1828CB620")]
		[CompilerGenerated]
		private string PKTMNPDNKYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28CB610", Offset = "0x28CA610", VA = "0x1828CB610")]
		[CompilerGenerated]
		private void PKOFQIJQBNE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28CB540", Offset = "0x28CA540", VA = "0x1828CB540")]
		[CompilerGenerated]
		private bool PKIYTBPSSBV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28CB4E0", Offset = "0x28CA4E0", VA = "0x1828CB4E0")]
		[CompilerGenerated]
		private object PKDRVUVVIQM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28C8B30", Offset = "0x28C7B30", VA = "0x1828C8B30")]
		[CompilerGenerated]
		private void PIIHULYTBSJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28CBE30", Offset = "0x28CAE30", VA = "0x1828CBE30")]
		[CompilerGenerated]
		private bool XGVYOLEQXXM()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class WPEAOBHTLFR
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class FDXCVOWVFBD : KLVIYETWZOR<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public FDXCVOWVFBD SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x28B9140", Offset = "0x28B8140", VA = "0x1828B9140")]
				internal object CRZAXRVQDNF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x28B8F30", Offset = "0x28B7F30", VA = "0x1828B8F30")]
				internal void CRTUALBSUBW(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x28B84C0", Offset = "0x28B74C0", VA = "0x1828B84C0")]
			public FDXCVOWVFBD(UOILJAPMYSC a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x28B8250", Offset = "0x28B7250", VA = "0x1828B8250", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class GNKHYDGMYOQ : NNKLACTSBLY<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType FLMUMUJCRKF
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xBE14C0", Offset = "0xBE04C0", VA = "0x180BE14C0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x28B8880", Offset = "0x28B7880", VA = "0x1828B8880")]
			public GNKHYDGMYOQ(UOILJAPMYSC a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class ZROBDMFAXLE : KLVIYETWZOR<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x28D8CF0", Offset = "0x28D7CF0", VA = "0x1828D8CF0")]
			public ZROBDMFAXLE(UOILJAPMYSC a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x28D8A10", Offset = "0x28D7A10", VA = "0x1828D8A10", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x28D8CA0", Offset = "0x28D7CA0", VA = "0x1828D8CA0")]
			[CompilerGenerated]
			private bool RUKABHFFYQP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x28D8B70", Offset = "0x28D7B70", VA = "0x1828D8B70")]
			[CompilerGenerated]
			private void RUETEALIPFG(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class TJVXVFQOXAK : KLVIYETWZOR<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public TJVXVFQOXAK SULNKEFFSGR;

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x28B91A0", Offset = "0x28B81A0", VA = "0x1828B91A0")]
				internal void CRZAXRVQDNF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x28B8DB0", Offset = "0x28B7DB0", VA = "0x1828B8DB0")]
				internal bool CRTUALBSUBW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x28B9370", Offset = "0x28B8370", VA = "0x1828B9370")]
				internal bool CSJOSFJKWJX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x28B91F0", Offset = "0x28B81F0", VA = "0x1828B91F0")]
				internal void CSEHUYPNMYO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x28B95A0", Offset = "0x28B85A0", VA = "0x1828B95A0")]
				internal bool CSUCMSXFPGP()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x28CC5E0", Offset = "0x28CB5E0", VA = "0x1828CC5E0")]
			public TJVXVFQOXAK(UOILJAPMYSC a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x28CC2D0", Offset = "0x28CB2D0", VA = "0x1828CC2D0", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class VMMCOIOEHBI : KLVIYETWZOR<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public VMMCOIOEHBI SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> VCTLNARFPBB;

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x28B9000", Offset = "0x28B8000", VA = "0x1828B9000")]
				internal object? CRZAXRVQDNF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x28B9660", Offset = "0x28B8660", VA = "0x1828B9660")]
				internal bool CSZJJZRCYRY(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x28B8B60", Offset = "0x28B7B60", VA = "0x1828B8B60")]
				internal void CRTUALBSUBW(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x28B93C0", Offset = "0x28B83C0", VA = "0x1828B93C0")]
				internal string CSJOSFJKWJX(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x28B9320", Offset = "0x28B8320", VA = "0x1828B9320")]
				internal IReadOnlyList<object> CSEHUYPNMYO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x28B95F0", Offset = "0x28B85F0", VA = "0x1828B95F0")]
				internal bool CSUCMSXFPGP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x28B9550", Offset = "0x28B8550", VA = "0x1828B9550")]
				internal bool CSOVPMDIFVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x28B96E0", Offset = "0x28B86E0", VA = "0x1828B96E0")]
				internal void CTEQHGLAIDH(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x28D6200", Offset = "0x28D5200", VA = "0x1828D6200")]
			public VMMCOIOEHBI(UOILJAPMYSC a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x28D5B00", Offset = "0x28D4B00", VA = "0x1828D5B00", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class GXFNFGSBKMJ : KLVIYETWZOR<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public GXFNFGSBKMJ SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x28B90F0", Offset = "0x28B80F0", VA = "0x1828B90F0")]
				internal bool CRZAXRVQDNF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x28B8E00", Offset = "0x28B7E00", VA = "0x1828B8E00")]
				internal void CRTUALBSUBW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x28B9500", Offset = "0x28B8500", VA = "0x1828B9500")]
				internal bool CSJOSFJKWJX()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x28B8AF0", Offset = "0x28B7AF0", VA = "0x1828B8AF0")]
			public GXFNFGSBKMJ(UOILJAPMYSC a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x28B88E0", Offset = "0x28B78E0", VA = "0x1828B88E0", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class HQPYHXCRSFE : KLVIYETWZOR<VCSBXVVKIEH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class ORMYCPIHDTW
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000048")]
				private struct <<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public ORMYCPIHDTW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<NNLJHAUAWWE>, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x28CF8A0", Offset = "0x28CE8A0", VA = "0x1828CF8A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x28CFC80", Offset = "0x28CEC80", VA = "0x1828CFC80", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000049")]
				private struct <<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000BC")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40000BD")]
					public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public ORMYCPIHDTW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x28CFCF0", Offset = "0x28CECF0", VA = "0x1828CFCF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x28D0080", Offset = "0x28CF080", VA = "0x1828D0080", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task TZRRMGBRRFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string GERFSOLUZRM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public UPRRQQRREYW.DHAPXLJCZOA YWKNSKTJRXB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool IRGVFVXACOT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public HQPYHXCRSFE SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public UPRRQQRREYW MDUXMIMTBEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action KZUPBHLTGHB;

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ORMYCPIHDTW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x28C6BD0", Offset = "0x28C5BD0", VA = "0x1828C6BD0")]
				internal bool TQSNTMTDXSV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
				internal string FFLKLMICNNQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x28C68F0", Offset = "0x28C58F0", VA = "0x1828C68F0")]
				internal void FFGDOFOFECH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x28C68A0", Offset = "0x28C58A0", VA = "0x1828C68A0")]
				internal void FFAWQYUHUQY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x137A580", Offset = "0x1379580", VA = "0x18137A580")]
				internal bool FGLSXUDPISJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x28C69B0", Offset = "0x28C59B0", VA = "0x1828C69B0")]
				internal void FGGMANJRZHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x28C6970", Offset = "0x28C5970", VA = "0x1828C6970")]
				internal bool FGBFDGPUPVR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x28C67B0", Offset = "0x28C57B0", VA = "0x1828C67B0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, WENLUTALDTF>> ELBBWJWNDYV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x28C6C00", Offset = "0x28C5C00", VA = "0x1828C6C00")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, WENLUTALDTF>> YXSELFZEWYO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class RMSRXUIDDBM
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200004B")]
				private struct <<BuildConfigMenuInternal>g__CreateNewVersion|0>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000C6")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40000C7")]
					public AsyncTaskMethodBuilder<Result<Id32<NNLJHAUAWWE>, WENLUTALDTF>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<NNLJHAUAWWE>, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x28CF4C0", Offset = "0x28CE4C0", VA = "0x1828CF4C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x28CF830", Offset = "0x28CE830", VA = "0x1828CF830", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public HQPYHXCRSFE SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public VVHHZIOZHKI KWNLFKHWYOR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool TKEOZNUIRIR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public UPRRQQRREYW MDUXMIMTBEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public YTKSAACLSFG BBUAFGZCKCX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action VDTTZIMSKFU;

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public RMSRXUIDDBM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x28C78A0", Offset = "0x28C68A0", VA = "0x1828C78A0")]
				internal object? CRTUALBSUBW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x28C7A00", Offset = "0x28C6A00", VA = "0x1828C7A00")]
				internal void CSJOSFJKWJX(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x28C7910", Offset = "0x28C6910", VA = "0x1828C7910")]
				internal string CSEHUYPNMYO(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x28C7C50", Offset = "0x28C6C50", VA = "0x1828C7C50")]
				internal IReadOnlyList<object> CSUCMSXFPGP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x28C7AF0", Offset = "0x28C6AF0", VA = "0x1828C7AF0")]
				internal void CSOVPMDIFVG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x28C7DB0", Offset = "0x28C6DB0", VA = "0x1828C7DB0")]
				internal bool CTEQHGLAIDH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x28C7CF0", Offset = "0x28C6CF0", VA = "0x1828C7CF0")]
				internal void CSZJJZRCYRY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x28C7EA0", Offset = "0x28C6EA0", VA = "0x1828C7EA0")]
				internal void CTPEBTYVAZZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x28C7E20", Offset = "0x28C6E20", VA = "0x1828C7E20")]
				internal void CTJXENEXROQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000146")]
				[Cpp2IlInjected.Address(RVA = "0x28C7FE0", Offset = "0x28C6FE0", VA = "0x1828C7FE0")]
				internal bool FPSAZKBCJLO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x28C7EF0", Offset = "0x28C6EF0", VA = "0x1828C7EF0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<NNLJHAUAWWE>, WENLUTALDTF>> CZGEJUQOWWM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<YHQFEYRJQPY>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x28BAAD0", Offset = "0x28B9AD0", VA = "0x1828BAAD0", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool GFDBLYOGKCZ
			{
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x28BAA60", Offset = "0x28B9A60", VA = "0x1828BAA60")]
			public HQPYHXCRSFE(UOILJAPMYSC a, VCSBXVVKIEH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x28B9A60", Offset = "0x28B8A60", VA = "0x1828B9A60", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x28BA3E0", Offset = "0x28B93E0", VA = "0x1828BA3E0")]
			private void VYHRQGGBRPF(UPRRQQRREYW a, Id32<NNLJHAUAWWE>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class UNPALDEBLTZ : BTHOSFIMDYS<EKCIZUNYKAM>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x1CD9B50", Offset = "0x1CD8B50", VA = "0x181CD9B50", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool CFKTIRTWINA
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool RWBGNQQAXNH
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool KOXRIXDNEBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool GFDBLYOGKCZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x28D2610", Offset = "0x28D1610", VA = "0x1828D2610")]
			public UNPALDEBLTZ(UOILJAPMYSC a, EKCIZUNYKAM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class RMUYWMZQYJZ<a> : KLVIYETWZOR<a> where a : notnull, OZJRUCIRPCZ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200004E")]
			[CompilerGenerated]
			private struct <AddPortGroup>d__7 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public AsyncTaskMethodBuilder<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public RMUYWMZQYJZ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x4FD1130", Offset = "0x4FD0130", VA = "0x184FD1130", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x4FD1480", Offset = "0x4FD0480", VA = "0x184FD1480", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200004F")]
			[CompilerGenerated]
			private struct <RemovePortGroup>d__11 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public RMUYWMZQYJZ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<JPZDQKXUTWI> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x539C0C0", Offset = "0x539B0C0", VA = "0x18539C0C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x539C410", Offset = "0x539B410", VA = "0x18539C410", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<JPZDQKXUTWI>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x5E80CE0", Offset = "0x5E7FCE0", VA = "0x185E80CE0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x5E80CB0", Offset = "0x5E7FCB0", VA = "0x185E80CB0")]
			protected RMUYWMZQYJZ(UOILJAPMYSC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x5E80B90", Offset = "0x5E7FB90", VA = "0x185E80B90", Slot = "122")]
			[AsyncStateMachine(typeof(RMUYWMZQYJZ<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> WZAWIAUKFGU(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x5E808A0", Offset = "0x5E7F8A0", VA = "0x185E808A0", Slot = "149")]
			public sealed override bool DATVROKQPSF(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x5E80940", Offset = "0x5E7F940", VA = "0x185E80940", Slot = "134")]
			protected sealed override bool MBVVBRBIDHF(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5E809E0", Offset = "0x5E7F9E0", VA = "0x185E809E0", Slot = "135")]
			protected override bool TDMMHQANVXG(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x5E80A80", Offset = "0x5E7FA80", VA = "0x185E80A80", Slot = "123")]
			[AsyncStateMachine(typeof(RMUYWMZQYJZ<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, WENLUTALDTF>> WOUPKRCEETZ(Id32<JPZDQKXUTWI> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class NQNHIJMMKSO : QRDIPWEKUPP<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public NQNHIJMMKSO SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x28B9890", Offset = "0x28B8890", VA = "0x1828B9890")]
				internal bool DVMQUSIPWTM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x28B99B0", Offset = "0x28B89B0", VA = "0x1828B99B0")]
				internal void DVRXRZCNGEV(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x28C66D0", Offset = "0x28C56D0", VA = "0x1828C66D0")]
			public NQNHIJMMKSO(UOILJAPMYSC a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x28C6490", Offset = "0x28C5490", VA = "0x1828C6490", Slot = "151")]
			protected override void GQGAZNHWGEO(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class KBGCFJEHNFF : KLVIYETWZOR<JKTBISWPAJK>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class NMXMBBMJYRH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int WRXJKXNIDFE;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public NMXMBBMJYRH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x28C6450", Offset = "0x28C5450", VA = "0x1828C6450")]
				internal bool NTYLMBNPTRE(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class ZOAXUNZKSXA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public KBGCFJEHNFF SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> EQKUGPTVABK;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZOAXUNZKSXA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x28D88C0", Offset = "0x28D78C0", VA = "0x1828D88C0")]
				internal int CRZAXRVQDNF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x28D87A0", Offset = "0x28D77A0", VA = "0x1828D87A0")]
				internal void CRTUALBSUBW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x28D8960", Offset = "0x28D7960", VA = "0x1828D8960")]
				internal string? CSJOSFJKWJX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x28BB250", Offset = "0x28BA250", VA = "0x1828BB250")]
			public KBGCFJEHNFF(UOILJAPMYSC a, JKTBISWPAJK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x28BB1C0", Offset = "0x28BA1C0", VA = "0x1828BB1C0")]
			private int HLFYDLXSRGM(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x28BAD50", Offset = "0x28B9D50", VA = "0x1828BAD50")]
			private void AOGVSJYMCVU(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x28BAE70", Offset = "0x28B9E70", VA = "0x1828BAE70", Slot = "145")]
			protected sealed override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class CJFIRUEOIPD : BTHOSFIMDYS<DRONYFLSJOO>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x28B7A40", Offset = "0x28B6A40", VA = "0x1828B7A40")]
			public CJFIRUEOIPD(UOILJAPMYSC a, DRONYFLSJOO b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class BTHOSFIMDYS<a> : KLVIYETWZOR<a> where a : notnull, NIAGAZQTLJM
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class IIKXUJMZJZI
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000059")]
				private struct <<BuildConfigMenuInternal>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000E7")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000E8")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000E9")]
					public IIKXUJMZJZI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x3D08BE0", Offset = "0x3D07BE0", VA = "0x183D08BE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public UPRRQQRREYW MDUXMIMTBEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public BTHOSFIMDYS<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action VCOEPTXIFPS;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public IIKXUJMZJZI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x5186BA0", Offset = "0x5185BA0", VA = "0x185186BA0")]
				internal void CRZAXRVQDNF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x5186E30", Offset = "0x5185E30", VA = "0x185186E30")]
				[AsyncStateMachine(typeof(BTHOSFIMDYS<>.IIKXUJMZJZI.<<BuildConfigMenuInternal>b__6>d))]
				internal void CTEQHGLAIDH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x51867E0", Offset = "0x51857E0", VA = "0x1851867E0")]
				internal bool CRTUALBSUBW()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class IIQERQGWTKR
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200005B")]
				private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F0")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F1")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F2")]
					public IIQERQGWTKR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x3D087E0", Offset = "0x3D077E0", VA = "0x183D087E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string LAYWOQKPCUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public IIKXUJMZJZI PYDAXWOHYEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> VBYJXZPQDHR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> VCYSKHLCYMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action VDDZHOFAHXT;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public IIQERQGWTKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x5186ED0", Offset = "0x5185ED0", VA = "0x185186ED0")]
				internal void CSJOSFJKWJX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				internal string CSEHUYPNMYO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
				internal void CSUCMSXFPGP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x5187240", Offset = "0x5186240", VA = "0x185187240")]
				[AsyncStateMachine(typeof(BTHOSFIMDYS<>.IIQERQGWTKR.<<BuildConfigMenuInternal>b__5>d))]
				internal void CSOVPMDIFVG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class NBRPOBUZKGT
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200005D")]
				private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000102")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000103")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000104")]
					public NBRPOBUZKGT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<DSRIXMVNJVY>, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x3D05E80", Offset = "0x3D04E80", VA = "0x183D05E80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200005E")]
				private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000106")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000107")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000108")]
					public NBRPOBUZKGT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x3D065D0", Offset = "0x3D055D0", VA = "0x183D065D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200005F")]
				private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010A")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010B")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010C")]
					public NBRPOBUZKGT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<KRDUNWCYLJD>, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x3D067B0", Offset = "0x3D057B0", VA = "0x183D067B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public BTHOSFIMDYS<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<JPZDQKXUTWI> TRLTSKQXENE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public UPRRQQRREYW MDUXMIMTBEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public BOUENRSVMUK EOJTNIFJAGZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int YWPFPJJRMBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int MKJGUDNURQW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public NIWXUTPBRAL MPVWSJKZWBQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string GCMFSDAPBUL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<SHFRTCUNHQZ> BDJQNHBTBNU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public NIWXUTPBRAL QMAXSQJUFOX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string GPUBNJDTRCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<SHFRTCUNHQZ> QXHTJZCMFKT;

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public NBRPOBUZKGT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x5B02CB0", Offset = "0x5B01CB0", VA = "0x185B02CB0")]
				internal bool NDQDHBZNGRM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x5B02D20", Offset = "0x5B01D20", VA = "0x185B02D20")]
				internal void NDVKEITKQCV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x5B02A00", Offset = "0x5B01A00", VA = "0x185B02A00")]
				internal bool FXRTGMCRHKG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x5B02BD0", Offset = "0x5B01BD0", VA = "0x185B02BD0")]
				[AsyncStateMachine(typeof(BTHOSFIMDYS<>.NBRPOBUZKGT.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void NDFPMOLSNUU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x5B02C70", Offset = "0x5B01C70", VA = "0x185B02C70")]
				internal bool NDKWJVFPXGD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x5B02A40", Offset = "0x5B01A40", VA = "0x185B02A40")]
				internal void FYMUVNEGTDQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x5B02840", Offset = "0x5B01840", VA = "0x185B02840")]
				internal bool FVWJFDFPAMD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x5B02760", Offset = "0x5B01760", VA = "0x185B02760")]
				internal void FVRCHWLRRAU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x5B02B20", Offset = "0x5B01B20", VA = "0x185B02B20")]
				internal bool KVMXNCKMCVW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x5B02E90", Offset = "0x5B01E90", VA = "0x185B02E90")]
				internal bool NELEWDBCSKW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x5B02F00", Offset = "0x5B01F00", VA = "0x185B02F00")]
				internal void NEQLTJVABWF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x5B02D90", Offset = "0x5B01D90", VA = "0x185B02D90")]
				[AsyncStateMachine(typeof(BTHOSFIMDYS<>.NBRPOBUZKGT.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void NEARBPNHZOE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x5B02E30", Offset = "0x5B01E30", VA = "0x185B02E30")]
				internal bool NEFXYWHFIZN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x5B02F70", Offset = "0x5B01F70", VA = "0x185B02F70")]
				internal bool NFGGLECSEEG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x5B02FE0", Offset = "0x5B01FE0", VA = "0x185B02FE0")]
				internal void NFLNIKWPNPP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x5B02950", Offset = "0x5B01950", VA = "0x185B02950")]
				[AsyncStateMachine(typeof(BTHOSFIMDYS<>.NBRPOBUZKGT.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void FXMMJFITXYX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x5B028F0", Offset = "0x5B018F0", VA = "0x185B028F0")]
				internal bool FXHFLYOWONO()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class NBMIQVBCAVK
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000061")]
				private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000113")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000114")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000115")]
					public NBMIQVBCAVK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x3D06170", Offset = "0x3D05170", VA = "0x183D06170", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string AEXBOLUETXS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public NBRPOBUZKGT PYDAXWOHYEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> OVCJAQOSIHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> OUXCDJUUYVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action OVMWVECNBDT;

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public NBMIQVBCAVK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x5B02350", Offset = "0x5B01350", VA = "0x185B02350")]
				internal void FXXADSWOQVP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				internal string FYHNYGKJJSH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
				internal void FYCHAZQMAGY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0x5B026C0", Offset = "0x5B016C0", VA = "0x185B026C0")]
				[AsyncStateMachine(typeof(BTHOSFIMDYS<>.NBMIQVBCAVK.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void FYSBSTYECOZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class QUKDXSWDNXS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool BDJQNHBTBNU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public BOUENRSVMUK EOJTNIFJAGZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<SHFRTCUNHQZ> GJDALWUQSZF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public BTHOSFIMDYS<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<JPZDQKXUTWI> TRLTSKQXENE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int IRJTZJJKQXJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> VCIXSNDKWEJ;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public QUKDXSWDNXS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x5E3B170", Offset = "0x5E3A170", VA = "0x185E3B170")]
				internal bool BPMLLZNLGGS()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class QUPKUZQAXJB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public ADJDNATJUCX CWOZSCSUZAM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public QUKDXSWDNXS PYDAXWOHYEE;

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public QUPKUZQAXJB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x5E3B220", Offset = "0x5E3A220", VA = "0x185E3B220")]
				internal void BPHEOSTNWVJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x5E3B1D0", Offset = "0x5E3A1D0", VA = "0x185E3B1D0")]
				internal bool BPBXRLZQNKA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x5E3B3F0", Offset = "0x5E3A3F0", VA = "0x185E3B3F0")]
				internal void BQMTYHIYBLL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x5E3B390", Offset = "0x5E3A390", VA = "0x185E3B390")]
				internal bool BQHNBAPASAC()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class QUURSGJYGUK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public SHFRTCUNHQZ PYYLFOECWEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public QUPKUZQAXJB PYSVPQWAAMF;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public QUURSGJYGUK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x5E3B580", Offset = "0x5E3A580", VA = "0x185E3B580")]
				internal void BPRSJGHIPSB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class NFFYHPSGXQJ
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000066")]
				private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012A")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012B")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012C")]
					public NFFYHPSGXQJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x3D09A90", Offset = "0x3D08A90", VA = "0x183D09A90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> NLKBAXOCXDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public NIWXUTPBRAL ZNMKEVUKUSS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool BDJQNHBTBNU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public BOUENRSVMUK EOJTNIFJAGZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public ADJDNATJUCX CWOZSCSUZAM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string AEXBOLUETXS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public NFFYHPSGXQJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x5B3D240", Offset = "0x5B3C240", VA = "0x185B3D240")]
				internal int XZCCZDWSWND()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x5B3CFF0", Offset = "0x5B3BFF0", VA = "0x185B3CFF0")]
				internal void XYWWBXCVNBU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40")]
				internal string XYRPEQIYDQL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x5B3CF30", Offset = "0x5B3BF30", VA = "0x185B3CF30")]
				[AsyncStateMachine(typeof(BTHOSFIMDYS<>.NFFYHPSGXQJ.<<CreatePortItemV2>b__3>d))]
				internal void XYMIHJPAUFC(string a)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000067")]
			[CompilerGenerated]
			private struct <AddPortGroup>d__20 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public AsyncTaskMethodBuilder<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public BTHOSFIMDYS<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x4FD0D10", Offset = "0x4FCFD10", VA = "0x184FD0D10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x4FD10C0", Offset = "0x4FD00C0", VA = "0x184FD10C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000068")]
			[CompilerGenerated]
			private struct <RemovePortGroup>d__21 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public BTHOSFIMDYS<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<JPZDQKXUTWI> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x539C480", Offset = "0x539B480", VA = "0x18539C480", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x539C7C0", Offset = "0x539B7C0", VA = "0x18539C7C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000069")]
			[CompilerGenerated]
			private struct <RequestDeleteAllBoardContent>d__26 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				public AsyncTaskMethodBuilder<Result<MultiResult, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public BTHOSFIMDYS<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x53A1920", Offset = "0x53A0920", VA = "0x1853A1920", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x53A1ED0", Offset = "0x53A0ED0", VA = "0x1853A1ED0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<JPZDQKXUTWI>, bool> VVVEWIKCBIW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<JPZDQKXUTWI>, bool> AYCYBWIZQFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<JPZDQKXUTWI>, bool> AWYHKBECKYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<JPZDQKXUTWI>, bool> OMJVMWURBUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<JPZDQKXUTWI>, bool> ZGSMULNHCJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<JPZDQKXUTWI>, bool> KGIVKMRBUNT;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool CFKTIRTWINA
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool RWBGNQQAXNH
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool KOXRIXDNEBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<YHQFEYRJQPY>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x3D77DD0", Offset = "0x3D76DD0", VA = "0x183D77DD0", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<JPZDQKXUTWI>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x3D78040", Offset = "0x3D77040", VA = "0x183D78040", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<QYHWLOYXTJM>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x3D77E50", Offset = "0x3D76E50", VA = "0x183D77E50", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3D77C00", Offset = "0x3D76C00", VA = "0x183D77C00")]
			public BTHOSFIMDYS(UOILJAPMYSC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "154")]
			protected virtual bool WIVIJGCLHPJ(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "155")]
			protected virtual bool UOHMDWVPXOI(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "156")]
			protected virtual bool JROGRSIJIKB(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "157")]
			protected virtual void YZMPWJFBFEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3D733A0", Offset = "0x3D723A0", VA = "0x183D733A0", Slot = "149")]
			public override bool DATVROKQPSF(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3D77650", Offset = "0x3D76650", VA = "0x183D77650", Slot = "122")]
			[AsyncStateMachine(typeof(BTHOSFIMDYS<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> WZAWIAUKFGU(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3D77540", Offset = "0x3D76540", VA = "0x183D77540", Slot = "123")]
			[AsyncStateMachine(typeof(BTHOSFIMDYS<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, WENLUTALDTF>> WOUPKRCEETZ(Id32<JPZDQKXUTWI> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3D77770", Offset = "0x3D76770", VA = "0x183D77770", Slot = "124")]
			public override void XEVVQFJYPHF(Id32<JPZDQKXUTWI> index, Id32<JPZDQKXUTWI> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3D744D0", Offset = "0x3D734D0", VA = "0x183D744D0", Slot = "125")]
			public override IEnumerable<PQYWNUACEKJ> GBONWSLYBOA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3D77B00", Offset = "0x3D76B00", VA = "0x183D77B00")]
			[AsyncStateMachine(typeof(BTHOSFIMDYS<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, WENLUTALDTF>> ZGCVDLYPCBF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "158")]
			protected virtual bool WLRPRTBQEOO(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "159")]
			protected virtual bool GIQMKJHTSXK(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "160")]
			protected virtual bool YNXMJRLPYLD(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "161")]
			protected virtual bool AGHMUJGWWJD(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "162")]
			protected virtual bool LKKDREQFDER(Id32<JPZDQKXUTWI> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "163")]
			protected virtual bool WXSAMHBKGSK(Id32<JPZDQKXUTWI> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "164")]
			protected virtual bool EIPXIBIQUMI(Id32<JPZDQKXUTWI> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "165")]
			protected virtual bool JGGNLRXINLT(Id32<JPZDQKXUTWI> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "166")]
			protected virtual bool UMVMYBOSEBP(Id32<JPZDQKXUTWI> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "167")]
			protected virtual bool JXHAESYGECA(Id32<JPZDQKXUTWI> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3D772B0", Offset = "0x3D762B0", VA = "0x183D772B0", Slot = "168")]
			protected virtual List<NIWXUTPBRAL> WEUJHKDYEES(Id32<JPZDQKXUTWI> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "169")]
			protected virtual void VQFXTMUYNSL(UPRRQQRREYW a, NKJDITYMVKI b, BOUENRSVMUK c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x3D74730", Offset = "0x3D73730", VA = "0x183D74730", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3D75B00", Offset = "0x3D74B00", VA = "0x183D75B00")]
			private NKJDITYMVKI TBPUUCDVMDE(UPRRQQRREYW a, BOUENRSVMUK b, Id32<JPZDQKXUTWI> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3D73440", Offset = "0x3D72440", VA = "0x183D73440")]
			private List<SHFRTCUNHQZ> DXNERXDUNCX(UPRRQQRREYW a, BOUENRSVMUK b, NKJDITYMVKI c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3D75150", Offset = "0x3D74150", VA = "0x183D75150")]
			private List<SHFRTCUNHQZ> OMGAKALCAID(UPRRQQRREYW a, BOUENRSVMUK b, ADJDNATJUCX c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x3D77910", Offset = "0x3D76910", VA = "0x183D77910")]
			private NIWXUTPBRAL YNDWUGEOEGD(List<NIWXUTPBRAL> a, ADJDNATJUCX b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x3D750F0", Offset = "0x3D740F0", VA = "0x183D750F0")]
			[CompilerGenerated]
			private PQYWNUACEKJ IAEHTWCIFTF(TYZPRJYTRRB a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class XIGQBQQFJWR : KLVIYETWZOR<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class ZKMPBACDFNK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public XIGQBQQFJWR SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZKMPBACDFNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x28D8750", Offset = "0x28D7750", VA = "0x1828D8750")]
				internal int CRZAXRVQDNF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x28D86C0", Offset = "0x28D76C0", VA = "0x1828D86C0")]
				internal Task<bool> CRTUALBSUBW(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x28D8080", Offset = "0x28D7080", VA = "0x1828D8080")]
			public XIGQBQQFJWR(UOILJAPMYSC a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x28D7ED0", Offset = "0x28D6ED0", VA = "0x1828D7ED0", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class BSEWVUXJLXX : QRDIPWEKUPP<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public BSEWVUXJLXX SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x28B9810", Offset = "0x28B8810", VA = "0x1828B9810")]
				internal int DVMQUSIPWTM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x28B9910", Offset = "0x28B8910", VA = "0x1828B9910")]
				internal Task<bool> DVRXRZCNGEV(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x28B79E0", Offset = "0x28B69E0", VA = "0x1828B79E0")]
			public BSEWVUXJLXX(UOILJAPMYSC a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x28B77C0", Offset = "0x28B67C0", VA = "0x1828B77C0", Slot = "151")]
			protected override void GQGAZNHWGEO(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class XLXSQXHSERZ : KLVIYETWZOR<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xCB6EC0", Offset = "0xCB5EC0", VA = "0x180CB6EC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x28D80F0", Offset = "0x28D70F0", VA = "0x1828D80F0")]
			public XLXSQXHSERZ(UOILJAPMYSC a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class VKBIQAGVHZB : KLVIYETWZOR<WYPTQOJGMLK>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class MJLEUFQBZLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public VKBIQAGVHZB SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public UPRRQQRREYW MDUXMIMTBEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> RCRATQZJWGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> RCBGBWRRTYI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> RBVZEPXUKMZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> RBGEMVQCIEY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> RBLLKCJZRQH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> REBXAMIRKHU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> REHDXTCOTTD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> XDFAHUOOQRB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> XCZTKNURHFS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> XDPOCICJJNT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> XDKHFBIMACK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> XEABWVQECKL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> XDUUZOWGSZC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> XEKPRJDYVHD;

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public MJLEUFQBZLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x28BC550", Offset = "0x28BB550", VA = "0x1828BC550")]
				internal bool CRZAXRVQDNF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x28BC4F0", Offset = "0x28BB4F0", VA = "0x1828BC4F0")]
				internal void CRTUALBSUBW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x28BC5F0", Offset = "0x28BB5F0", VA = "0x1828BC5F0")]
				internal bool CSUCMSXFPGP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x28BC5A0", Offset = "0x28BB5A0", VA = "0x1828BC5A0")]
				internal bool CSOVPMDIFVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x28BC640", Offset = "0x28BB640", VA = "0x1828BC640")]
				internal void CTEQHGLAIDH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x28BC6A0", Offset = "0x28BB6A0", VA = "0x1828BC6A0")]
				internal bool CTJXENEXROQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x28BCD90", Offset = "0x28BBD90", VA = "0x1828BCD90")]
				internal bool FPSAZKBCJLO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x28BCDE0", Offset = "0x28BBDE0", VA = "0x1828BCDE0")]
				internal void FPXHWQUZSWX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x28BCE40", Offset = "0x28BBE40", VA = "0x1828BCE40")]
				internal bool FQNCOLCRVEY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x28BCE90", Offset = "0x28BBE90", VA = "0x1828BCE90")]
				internal bool FQSJLRWPEQH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x28BCEE0", Offset = "0x28BBEE0", VA = "0x1828BCEE0")]
				internal void FQXQIYQMOBQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x28BCF40", Offset = "0x28BBF40", VA = "0x1828BCF40")]
				internal bool FRNLASYEQJR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x28C4AD0", Offset = "0x28C3AD0", VA = "0x1828C4AD0")]
				internal bool SQHKULQRRGO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x28C4B20", Offset = "0x28C3B20", VA = "0x1828C4B20")]
				internal bool SQMRRSKPARX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x28C4A80", Offset = "0x28C3A80", VA = "0x1828C4A80")]
				internal bool SPWWZYCWYJW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x28C4C20", Offset = "0x28C3C20", VA = "0x1828C4C20")]
				internal bool SSSPNOVMAMS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x28C4C70", Offset = "0x28C3C70", VA = "0x1828C4C70")]
				internal bool SSXWKVPJJYB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x28C5F60", Offset = "0x28C4F60", VA = "0x1828C5F60")]
				internal bool ZRTRIFAJSSH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x28C5F10", Offset = "0x28C4F10", VA = "0x1828C5F10")]
				internal bool ZROKKYGMJGY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x28C6000", Offset = "0x28C5000", VA = "0x1828C6000")]
				internal void ZSEFCSOELOZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x28C4010", Offset = "0x28C3010", VA = "0x1828C4010")]
				internal bool MSYVVAXRCVI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x28C3FC0", Offset = "0x28C2FC0", VA = "0x1828C3FC0")]
				internal bool MSTOXUDTTJZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x28C3F70", Offset = "0x28C2F70", VA = "0x1828C3F70")]
				internal bool MSOIANJWJYQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x28C3F20", Offset = "0x28C2F20", VA = "0x1828C3F20")]
				internal bool MSDUFZWBRBY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x28C3ED0", Offset = "0x28C2ED0", VA = "0x1828C3ED0")]
				internal bool MRYNITCEHQP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x28C5FB0", Offset = "0x28C4FB0", VA = "0x1828C5FB0")]
				internal bool ZRYYFLUHCDQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x28C60C0", Offset = "0x28C50C0", VA = "0x1828C60C0")]
				internal bool ZSOSXGBZELR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x28C6060", Offset = "0x28C5060", VA = "0x1828C6060")]
				internal void ZSJLZZIBVAI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x28C6160", Offset = "0x28C5160", VA = "0x1828C6160")]
				internal bool ZSZGRTPTXIJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x28C6110", Offset = "0x28C5110", VA = "0x1828C6110")]
				internal bool ZSTZUMVWNXA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x28C5EB0", Offset = "0x28C4EB0", VA = "0x1828C5EB0")]
				internal void ZQDOECXEVFN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x28C5E60", Offset = "0x28C4E60", VA = "0x1828C5E60")]
				internal bool ZPYHGWDHLUE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x28C4B70", Offset = "0x28C3B70", VA = "0x1828C4B70")]
				internal bool SRCMJMSHCZY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x28C4BC0", Offset = "0x28C3BC0", VA = "0x1828C4BC0")]
				internal void SRHTGTMEMLH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x28BDD20", Offset = "0x28BCD20", VA = "0x1828BDD20")]
				internal List<SHFRTCUNHQZ> KETNPAUFGEC(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x28C3E80", Offset = "0x28C2E80", VA = "0x1828C3E80")]
				internal bool MRTGLMIGYFG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x28C3E30", Offset = "0x28C2E30", VA = "0x1828C3E30")]
				internal int MRNZOFOJOTX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x28C3DA0", Offset = "0x28C2DA0", VA = "0x1828C3DA0")]
				internal Task<bool> MRISQYUMFIO(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x28BD160", Offset = "0x28BC160", VA = "0x1828BD160")]
				internal bool GSKWGXIMIKQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x28BD1B0", Offset = "0x28BC1B0", VA = "0x1828BD1B0")]
				internal bool GSQDEECJRVZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x28BD200", Offset = "0x28BC200", VA = "0x1828BD200")]
				internal bool GSVKBKWHBHI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x28BD250", Offset = "0x28BC250", VA = "0x1828BD250")]
				internal int GTAQYRQEKSR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x28BCFE0", Offset = "0x28BBFE0", VA = "0x1828BCFE0")]
				internal Task<bool> GRPURWGWWRG(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x28BD070", Offset = "0x28BC070", VA = "0x1828BD070")]
				internal bool GRVBPDAUGCP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x28BD0C0", Offset = "0x28BC0C0", VA = "0x1828BD0C0")]
				internal bool GSAIMJURPNY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x28BD110", Offset = "0x28BC110", VA = "0x1828BD110")]
				internal bool GSFPJQOOYZH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x28BCF90", Offset = "0x28BBF90", VA = "0x1828BCF90")]
				internal bool GRAAABZEUJF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x28BBF20", Offset = "0x28BAF20", VA = "0x1828BBF20")]
				internal bool ANZZZJVABSH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x28BD2A0", Offset = "0x28BC2A0", VA = "0x1828BD2A0")]
				internal string GXDDAXBCIRG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x28BD340", Offset = "0x28BC340", VA = "0x1828BD340")]
				internal void GXSXSRIUKZH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x28BD3B0", Offset = "0x28BC3B0", VA = "0x1828BD3B0")]
				internal int GXYEPYCRUKQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x28BD450", Offset = "0x28BC450", VA = "0x1828BD450")]
				internal void GYNZHSKJWSR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x28BD400", Offset = "0x28BC400", VA = "0x1828BD400")]
				internal bool GYISKLQMNHI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x28BD500", Offset = "0x28BC500", VA = "0x1828BD500")]
				internal bool GYYNCFYEPPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x28BD4B0", Offset = "0x28BC4B0", VA = "0x1828BD4B0")]
				internal bool GYTGEZEHGEA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x28BB990", Offset = "0x28BA990", VA = "0x1828BB990")]
				internal float ADDRPTZQSJI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x28BB9E0", Offset = "0x28BA9E0", VA = "0x1828BB9E0")]
				internal void ADIYNATOBUR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x28BB8F0", Offset = "0x28BA8F0", VA = "0x1828BB8F0")]
				internal bool ACTDVGLVZMQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x28BB940", Offset = "0x28BA940", VA = "0x1828BB940")]
				internal bool ACYKSNFTIXZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x28BB850", Offset = "0x28BA850", VA = "0x1828BB850")]
				internal bool ACIQASYBGPY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x28BBFC0", Offset = "0x28BAFC0", VA = "0x1828BBFC0")]
				internal bool AOKNTXIUUOZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x28BBF70", Offset = "0x28BAF70", VA = "0x1828BBF70")]
				internal bool AOFGWQOXLDQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x28BBE30", Offset = "0x28BAE30", VA = "0x1828BBE30")]
				internal bool ANEYKITKPYX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x28BBA40", Offset = "0x28BAA40", VA = "0x1828BBA40")]
				internal void AMZRNBZNGNO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x28BB8A0", Offset = "0x28BA8A0", VA = "0x1828BB8A0")]
				internal string ACNWXZRYQBH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x28BB7E0", Offset = "0x28BA7E0", VA = "0x1828BB7E0")]
				internal void ABYCGFKGNTG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x28BBED0", Offset = "0x28BAED0", VA = "0x1828BBED0")]
				internal bool ANPMEWHFIVP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x28BBE80", Offset = "0x28BAE80", VA = "0x1828BBE80")]
				internal bool ANKFHPNHZKG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x28BC2B0", Offset = "0x28BB2B0", VA = "0x1828BC2B0")]
				internal bool APQDDLYEZFB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x28BC010", Offset = "0x28BB010", VA = "0x1828BC010")]
				internal void APKWGFEHPTS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x28C5070", Offset = "0x28C4070", VA = "0x1828C5070")]
				internal bool TNIVARMXLZY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x28C50C0", Offset = "0x28C40C0", VA = "0x1828C50C0")]
				internal bool TNOBXYGUVLH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x28C4FD0", Offset = "0x28C3FD0", VA = "0x1828C4FD0")]
				internal bool TMYHGDZCTDG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x28C5020", Offset = "0x28C4020", VA = "0x1828C5020")]
				internal bool TNDODKTACOP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x28C51B0", Offset = "0x28C41B0", VA = "0x1828C51B0")]
				internal void TODWPSOMXTI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x28C5210", Offset = "0x28C4210", VA = "0x1828C5210")]
				internal bool TOJDMZIKHER()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x28C5110", Offset = "0x28C4110", VA = "0x1828C5110")]
				internal bool TNTIVFASEWQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x28C5160", Offset = "0x28C4160", VA = "0x1828C5160")]
				internal bool TNYPSLUPOHZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x28C5260", Offset = "0x28C4260", VA = "0x1828C5260")]
				internal bool TOYYETQCJMS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x28C52B0", Offset = "0x28C42B0", VA = "0x1828C52B0")]
				internal void TPEFCAJZSYB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x28C4290", Offset = "0x28C3290", VA = "0x1828C4290")]
				internal bool OPIJWULFHCZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x28C4240", Offset = "0x28C3240", VA = "0x1828C4240")]
				internal bool OPDCZNRHXRQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x28C41F0", Offset = "0x28C31F0", VA = "0x1828C41F0")]
				internal bool OOXWCGXKOGH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x28C41A0", Offset = "0x28C31A0", VA = "0x1828C41A0")]
				internal bool OOSPFADNEUY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x28C4370", Offset = "0x28C3370", VA = "0x1828C4370")]
				internal object OPSXRHYZZZR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x28C42E0", Offset = "0x28C32E0", VA = "0x1828C42E0")]
				internal void OPNQUBFCQOI(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x28C4150", Offset = "0x28C3150", VA = "0x1828C4150")]
				internal bool ONSGSSIAJQF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x28C4100", Offset = "0x28C3100", VA = "0x1828C4100")]
				internal bool ONMZVLODAEW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x28BD5A0", Offset = "0x28BC5A0", VA = "0x1828BD5A0")]
				internal int HOWLVIXAAVZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x28BD5F0", Offset = "0x28BC5F0", VA = "0x1828BD5F0")]
				internal void HPBSSPQXKHI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x28BD650", Offset = "0x28BC650", VA = "0x1828BD650")]
				internal bool HPRNKJYPMPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x28BD6A0", Offset = "0x28BC6A0", VA = "0x1828BD6A0")]
				internal bool HPWUHQSMWAS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x28BD550", Offset = "0x28BC550", VA = "0x1828BD550")]
				internal int HNGIRGTVDJF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x28C55B0", Offset = "0x28C45B0", VA = "0x1828C55B0")]
				internal void UXNOUFEZTQM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x28C5610", Offset = "0x28C4610", VA = "0x1828C5610")]
				internal bool UXSVRLYXDBV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x28C5660", Offset = "0x28C4660", VA = "0x1828C5660")]
				internal bool UXYCOSSUMNE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x28C56B0", Offset = "0x28C46B0", VA = "0x1828C56B0")]
				internal bool UYDJLZMRVYN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x28C5700", Offset = "0x28C4700", VA = "0x1828C5700")]
				internal int UYTEDTUJYGO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x28C5750", Offset = "0x28C4750", VA = "0x1828C5750")]
				internal void UYYLBAOHHRX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x28C57B0", Offset = "0x28C47B0", VA = "0x1828C57B0")]
				internal bool UZDRYHIERDG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x28C5800", Offset = "0x28C4800", VA = "0x1828C5800")]
				internal bool UZIYVOCCAOP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x28BC300", Offset = "0x28BB300", VA = "0x1828BC300")]
				internal bool BYETSXNCJIV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x28BC3E0", Offset = "0x28BB3E0", VA = "0x1828BC3E0")]
				internal object BYUOKRUULQW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x28BC350", Offset = "0x28BB350", VA = "0x1828BC350")]
				internal void BYPHNLAXCFN(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x28BC4A0", Offset = "0x28BB4A0", VA = "0x1828BC4A0")]
				internal bool BZUWWZQHGVP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x28BC450", Offset = "0x28BB450", VA = "0x1828BC450")]
				internal bool BZPPZSWJXKG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x28BD840", Offset = "0x28BC840", VA = "0x1828BD840")]
				internal object? HYYAEHWENEW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x28BD8B0", Offset = "0x28BC8B0", VA = "0x1828BD8B0")]
				internal void HZDHBOQBWQF(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x28BD7A0", Offset = "0x28BC7A0", VA = "0x1828BD7A0")]
				internal bool HYCYPGUPBLM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x28BD7F0", Offset = "0x28BC7F0", VA = "0x1828BD7F0")]
				internal int HYIFMNOMKWV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x28BD6F0", Offset = "0x28BC6F0", VA = "0x1828BD6F0")]
				internal void HXSKUTGUIOU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x28BD750", Offset = "0x28BC750", VA = "0x1828BD750")]
				internal bool HXXRSAARSAD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x28BD940", Offset = "0x28BC940", VA = "0x1828BD940")]
				internal bool IAODIJZJKRQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x28BD990", Offset = "0x28BC990", VA = "0x1828BD990")]
				internal bool IATKFQTGUCZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x28C44E0", Offset = "0x28C34E0", VA = "0x1828C44E0")]
				internal int OZPFDAEHCXF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x28C4480", Offset = "0x28C3480", VA = "0x1828C4480")]
				internal void OZJYFTKJTLW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x28C4580", Offset = "0x28C3580", VA = "0x1828C4580")]
				internal bool OZZSXNSBVTX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x28C4530", Offset = "0x28C3530", VA = "0x1828C4530")]
				internal bool OZUMAGYEMIO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x28C4620", Offset = "0x28C3620", VA = "0x1828C4620")]
				internal bool PAKGSBFWOQP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x28C45D0", Offset = "0x28C35D0", VA = "0x1828C45D0")]
				internal float PAEZUULZFFG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x28C46C0", Offset = "0x28C36C0", VA = "0x1828C46C0")]
				internal void PAUUMOTRHNH(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x28C4670", Offset = "0x28C3670", VA = "0x1828C4670")]
				internal bool PAPNPHZTYBY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x28C4430", Offset = "0x28C3430", VA = "0x1828C4430")]
				internal bool OXZBYYBCFKL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x28C43E0", Offset = "0x28C33E0", VA = "0x1828C43E0")]
				internal bool OXTVBRHEVZC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x28C5A00", Offset = "0x28C4A00", VA = "0x1828C5A00")]
				internal float WAGKBSMJSPO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x28C5A50", Offset = "0x28C4A50", VA = "0x1828C5A50")]
				internal void WALQYZGHCAX(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x28C5AB0", Offset = "0x28C4AB0", VA = "0x1828C5AB0")]
				internal bool WAQXWGAELMG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x28C58F0", Offset = "0x28C48F0", VA = "0x1828C58F0")]
				internal bool VZQPJYERQHN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x28C5940", Offset = "0x28C4940", VA = "0x1828C5940")]
				internal string VZVWHEYOZSW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x28C5990", Offset = "0x28C4990", VA = "0x1828C5990")]
				internal void WABDELSMJEF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x28C5850", Offset = "0x28C4850", VA = "0x1828C5850")]
				internal bool VYQGXQJEVCU(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x28C58A0", Offset = "0x28C48A0", VA = "0x1828C58A0")]
				internal bool VYVNUXDCEOD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x28BCA00", Offset = "0x28BBA00", VA = "0x1828BCA00")]
				internal bool DAXPAKUMIHX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x28BC9B0", Offset = "0x28BB9B0", VA = "0x1828BC9B0")]
				internal bool DASIDEAOYWO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x28BC960", Offset = "0x28BB960", VA = "0x1828BC960")]
				internal string DANBFXGRPLF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x28BC8F0", Offset = "0x28BB8F0", VA = "0x1828BC8F0")]
				internal void DAHUIQMUFZW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x28BC8A0", Offset = "0x28BB8A0", VA = "0x1828BC8A0")]
				internal bool DACNLJSWWON(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x28BC850", Offset = "0x28BB850", VA = "0x1828BC850")]
				internal bool CZXGOCYZNDE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x28BC800", Offset = "0x28BB800", VA = "0x1828BC800")]
				internal bool CZRZQWFCDRV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x28BC7B0", Offset = "0x28BB7B0", VA = "0x1828BC7B0")]
				internal bool CZMSTPLEUGM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x28BC760", Offset = "0x28BB760", VA = "0x1828BC760")]
				internal string CZHLWIRHKVD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x28BC6F0", Offset = "0x28BB6F0", VA = "0x1828BC6F0")]
				internal void CZCEZBXKBJU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x28BDA80", Offset = "0x28BCA80", VA = "0x1828BDA80")]
				internal bool JVCHIUPVIBE(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x28BDAD0", Offset = "0x28BCAD0", VA = "0x1828BDAD0")]
				internal bool JVHOGBJSRMN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x28BD9E0", Offset = "0x28BC9E0", VA = "0x1828BD9E0")]
				internal bool JURTOHCAPEM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x28BDA30", Offset = "0x28BCA30", VA = "0x1828BDA30")]
				internal bool JUXALNVXYPV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x28BDBC0", Offset = "0x28BCBC0", VA = "0x1828BDBC0")]
				internal string JVXIXVRKTUO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x28BDC10", Offset = "0x28BCC10", VA = "0x1828BDC10")]
				internal void JWCPVCLIDFX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x28BDB20", Offset = "0x28BCB20", VA = "0x1828BDB20")]
				internal bool JVMVDIDQAXW(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x28BDB70", Offset = "0x28BCB70", VA = "0x1828BDB70")]
				internal bool JVSCAOXNKJF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x28BDC80", Offset = "0x28BCC80", VA = "0x1828BDC80")]
				internal bool JWSKMWTAFNY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x28BDCD0", Offset = "0x28BCCD0", VA = "0x1828BDCD0")]
				internal bool JWXRKDMXOZH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x28C48F0", Offset = "0x28C38F0", VA = "0x1828C48F0")]
				internal string PVVNUEYXLXF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x28C4880", Offset = "0x28C3880", VA = "0x1828C4880")]
				internal void PVQGWYFACLW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x28C4990", Offset = "0x28C3990", VA = "0x1828C4990")]
				internal bool PWGBOSMSETX(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x28C4940", Offset = "0x28C3940", VA = "0x1828C4940")]
				internal bool PWAURLSUVIO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x28C4770", Offset = "0x28C3770", VA = "0x1828C4770")]
				internal bool PVAMFDXIADV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x28C4720", Offset = "0x28C3720", VA = "0x1828C4720")]
				internal bool PUVFHXDKQSM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x28C4830", Offset = "0x28C3830", VA = "0x1828C4830")]
				internal string PVKZZRLCTAN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x28C47C0", Offset = "0x28C37C0", VA = "0x1828C47C0")]
				internal void PVFTCKRFJPE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x28C4A30", Offset = "0x28C3A30", VA = "0x1828C4A30")]
				internal bool PXLQYHCCJJZ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x28C49E0", Offset = "0x28C39E0", VA = "0x1828C49E0")]
				internal bool PXGKBAIEZYQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x28C5BC0", Offset = "0x28C4BC0", VA = "0x1828C5BC0")]
				internal bool WWMSSXHABPO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x28C5C10", Offset = "0x28C4C10", VA = "0x1828C5C10")]
				internal bool WWRZQEAXLAX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x28C5C60", Offset = "0x28C4C60", VA = "0x1828C5C60")]
				internal string WWXGNKUUUMG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x28C5CB0", Offset = "0x28C4CB0", VA = "0x1828C5CB0")]
				internal void WXCNKROSDXP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x28C5D20", Offset = "0x28C4D20", VA = "0x1828C5D20")]
				internal bool WXHUHYIPNIY(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x28C5D70", Offset = "0x28C4D70", VA = "0x1828C5D70")]
				internal bool WXNBFFCMWUH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x28C5DC0", Offset = "0x28C4DC0", VA = "0x1828C5DC0")]
				internal bool WXSICLWKGFQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x28C5E10", Offset = "0x28C4E10", VA = "0x1828C5E10")]
				internal bool WXXOZSQHPQZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x28C5B00", Offset = "0x28C4B00", VA = "0x1828C5B00")]
				internal string WUWPOVDVECU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x28C5B50", Offset = "0x28C4B50", VA = "0x1828C5B50")]
				internal void WVBWMBXSNOD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x28BCBE0", Offset = "0x28BBBE0", VA = "0x1828BCBE0")]
				internal bool DXDXRPPCRHX(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x28BCB90", Offset = "0x28BBB90", VA = "0x1828BCB90")]
				internal bool DWYQUIVFHWO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x28BCB40", Offset = "0x28BBB40", VA = "0x1828BCB40")]
				internal bool DWTJXCBHYLF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x28BCAF0", Offset = "0x28BBAF0", VA = "0x1828BCAF0")]
				internal bool DWOCZVHKOZW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x28BCD40", Offset = "0x28BBD40", VA = "0x1828BCD40")]
				internal string DXYZGQQSDBH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x28BCCD0", Offset = "0x28BBCD0", VA = "0x1828BCCD0")]
				internal void DXTSJJWUTPY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x28BCC80", Offset = "0x28BBC80", VA = "0x1828BCC80")]
				internal bool DXOLMDCXKEP(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x28BCC30", Offset = "0x28BBC30", VA = "0x1828BCC30")]
				internal bool DXJEOWJAATG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x28BCAA0", Offset = "0x28BBAA0", VA = "0x1828BCAA0")]
				internal bool DVNUNNLXTVD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x28BCA50", Offset = "0x28BBA50", VA = "0x1828BCA50")]
				internal bool DVINQGSAKJU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x28C4E20", Offset = "0x28C3E20", VA = "0x1828C4E20")]
				internal string TCMMRBROCQZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x28C4DB0", Offset = "0x28C3DB0", VA = "0x1828C4DB0")]
				internal void TCHFTUXQTFQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x28C4D60", Offset = "0x28C3D60", VA = "0x1828C4D60")]
				internal bool TBWRZHJWAIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x28C4F80", Offset = "0x28C3F80", VA = "0x1828C4F80")]
				internal bool TDHOGCTDOKJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x28C4F30", Offset = "0x28C3F30", VA = "0x1828C4F30")]
				internal bool TDCHIVZGEZA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x28C4EE0", Offset = "0x28C3EE0", VA = "0x1828C4EE0")]
				internal string TCXALPFIVNR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x28C4E70", Offset = "0x28C3E70", VA = "0x1828C4E70")]
				internal void TCRTOILLMCI(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x28C4D10", Offset = "0x28C3D10", VA = "0x1828C4D10")]
				internal bool TAWJMZOJFEF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x28C4CC0", Offset = "0x28C3CC0", VA = "0x1828C4CC0")]
				internal bool TARCPSULVSW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x28C3AE0", Offset = "0x28C2AE0", VA = "0x1828C3AE0")]
				internal bool MBVHSJJLMYQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x28C3B30", Offset = "0x28C2B30", VA = "0x1828C3B30")]
				internal string MCAOPQDIWJZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x28C3B80", Offset = "0x28C2B80", VA = "0x1828C3B80")]
				internal void MCFVMWXGFVI(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x28C3BF0", Offset = "0x28C2BF0", VA = "0x1828C3BF0")]
				internal bool MCLCKDRDPGR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x28C3C40", Offset = "0x28C2C40", VA = "0x1828C3C40")]
				internal bool MCQJHKLAYSA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x28C3C90", Offset = "0x28C2C90", VA = "0x1828C3C90")]
				internal bool MCVQEREYIDJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x28C3CE0", Offset = "0x28C2CE0", VA = "0x1828C3CE0")]
				internal string MDAXBXYVROS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x28C3D30", Offset = "0x28C2D30", VA = "0x1828C3D30")]
				internal void MDGDZESTBAB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x28C3A90", Offset = "0x28C2A90", VA = "0x1828C3A90")]
				internal bool MAKLLOADYXF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x28BD2F0", Offset = "0x28BC2F0", VA = "0x1828BD2F0")]
				internal bool GXIJYDUZSCP(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x28C54B0", Offset = "0x28C44B0", VA = "0x1828C54B0")]
				internal float TYIHNSYJSUH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x28C5450", Offset = "0x28C4450", VA = "0x1828C5450")]
				internal void TYDAQMEMJIY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x28C5400", Offset = "0x28C4400", VA = "0x1828C5400")]
				internal bool TXXTTFKOZXP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x28C53B0", Offset = "0x28C43B0", VA = "0x1828C53B0")]
				internal bool TXSMVYQRQMG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x28C5360", Offset = "0x28C4360", VA = "0x1828C5360")]
				internal bool TXNFYRWUHAX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x28C5310", Offset = "0x28C4310", VA = "0x1828C5310")]
				internal int TXHZBLCWXPO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x28C5550", Offset = "0x28C4550", VA = "0x1828C5550")]
				internal void UAIYMIPJJDT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x28C5500", Offset = "0x28C4500", VA = "0x1828C5500")]
				internal bool UADRPBVLZSK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x28C4060", Offset = "0x28C3060", VA = "0x1828C4060")]
				internal bool NXZOWWDCHUY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x28C40B0", Offset = "0x28C30B0", VA = "0x1828C40B0")]
				internal bool NYEVUCWZRGH()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class MJFXWYWEQAA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string RYARXHMTJUX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public MJLEUFQBZLJ PYDAXWOHYEE;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public MJFXWYWEQAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x28DF2A0", Offset = "0x28DE2A0", VA = "0x1828DF2A0")]
				internal void ANUTCDBCSGY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class MJVSOTDWSIB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] KEXCCMIQHAY;

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public MJVSOTDWSIB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x28E0110", Offset = "0x28DF110", VA = "0x1828E0110")]
				internal bool TYNOKZSHCFQ(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers AESFZUTBKMZ;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x28D59A0", Offset = "0x28D49A0", VA = "0x1828D59A0")]
			public VKBIQAGVHZB(UOILJAPMYSC a, WYPTQOJGMLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x28D3E30", Offset = "0x28D2E30", VA = "0x1828D3E30", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class JUORSEJNPDG : KLVIYETWZOR<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool GFDBLYOGKCZ
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x28DEE30", Offset = "0x28DDE30", VA = "0x1828DEE30")]
			public JUORSEJNPDG(UOILJAPMYSC a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x28DEA80", Offset = "0x28DDA80", VA = "0x1828DEA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x28DED30", Offset = "0x28DDD30", VA = "0x1828DED30")]
			private static string IJPIIESAXRS(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x28DE6A0", Offset = "0x28DD6A0", VA = "0x1828DE6A0")]
			[CompilerGenerated]
			private object? DTMAWVODEDF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x28DE590", Offset = "0x28DD590", VA = "0x1828DE590")]
			[CompilerGenerated]
			private void DTGTZOUFURW(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x28DE7E0", Offset = "0x28DD7E0", VA = "0x1828DE7E0")]
			[CompilerGenerated]
			private string DTWORJBXWZX(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x28DE740", Offset = "0x28DD740", VA = "0x1828DE740")]
			[CompilerGenerated]
			private IReadOnlyList<object> DTRHUCIANOO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x28DEA20", Offset = "0x28DDA20", VA = "0x1828DEA20")]
			[CompilerGenerated]
			private string? DUHCLWPSPWP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x28DE9E0", Offset = "0x28DD9E0", VA = "0x1828DE9E0")]
			[CompilerGenerated]
			private bool DUBVOPVVGLG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class HWTNOPCCMMG : KLVIYETWZOR<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class ZKMPBACDFNK
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000077")]
				private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000180")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000181")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x4000182")]
					public ZKMPBACDFNK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000300")]
					[Cpp2IlInjected.Address(RVA = "0x28ED4E0", Offset = "0x28EC4E0", VA = "0x1828ED4E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000301")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public HWTNOPCCMMG SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZKMPBACDFNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x28F3800", Offset = "0x28F2800", VA = "0x1828F3800")]
				internal string CRZAXRVQDNF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x28F3530", Offset = "0x28F2530", VA = "0x1828F3530")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void CRTUALBSUBW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x28F3CD0", Offset = "0x28F2CD0", VA = "0x1828F3CD0")]
				internal int CSJOSFJKWJX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x28F38A0", Offset = "0x28F28A0", VA = "0x1828F38A0")]
				internal void CSEHUYPNMYO(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x28DD920", Offset = "0x28DC920", VA = "0x1828DD920")]
			public HWTNOPCCMMG(UOILJAPMYSC a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x28DD5F0", Offset = "0x28DC5F0", VA = "0x1828DD5F0", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class CLFPRIYFOJN : KLVIYETWZOR<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class NMXMBBMJYRH
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200007A")]
				private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000188")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000189")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400018A")]
					public NMXMBBMJYRH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x28ED1A0", Offset = "0x28EC1A0", VA = "0x1828ED1A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200007B")]
				private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400018E")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400018F")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x4000190")]
					public NMXMBBMJYRH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000317")]
					[Cpp2IlInjected.Address(RVA = "0x28EDA90", Offset = "0x28ECA90", VA = "0x1828EDA90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000318")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public CLFPRIYFOJN SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public NMXMBBMJYRH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x28E0250", Offset = "0x28DF250", VA = "0x1828E0250")]
				internal string CRZAXRVQDNF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x28E0180", Offset = "0x28DF180", VA = "0x1828E0180")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void CRTUALBSUBW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x28E0330", Offset = "0x28DF330", VA = "0x1828E0330")]
				internal int CSJOSFJKWJX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x28E02A0", Offset = "0x28DF2A0", VA = "0x1828E02A0")]
				internal Task<bool> CSEHUYPNMYO(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x28E0450", Offset = "0x28DF450", VA = "0x1828E0450")]
				internal string CSUCMSXFPGP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x28E0380", Offset = "0x28DF380", VA = "0x1828E0380")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void CSOVPMDIFVG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x28E0530", Offset = "0x28DF530", VA = "0x1828E0530")]
				internal bool CTEQHGLAIDH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x28E04A0", Offset = "0x28DF4A0", VA = "0x1828E04A0")]
				internal void CSZJJZRCYRY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x28E0610", Offset = "0x28DF610", VA = "0x1828E0610")]
				internal bool CTPEBTYVAZZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x28E0580", Offset = "0x28DF580", VA = "0x1828E0580")]
				internal void CTJXENEXROQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x28E0660", Offset = "0x28DF660", VA = "0x1828E0660")]
				internal float FPSAZKBCJLO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x28E06B0", Offset = "0x28DF6B0", VA = "0x1828E06B0")]
				internal void FPXHWQUZSWX(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x28E0740", Offset = "0x28DF740", VA = "0x1828E0740")]
				internal int FQCOTXOXCIG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x28E07A0", Offset = "0x28DF7A0", VA = "0x1828E07A0")]
				internal void FQHVREIULTP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x28E0840", Offset = "0x28DF840", VA = "0x1828E0840")]
				internal bool FQNCOLCRVEY()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x28DA4D0", Offset = "0x28D94D0", VA = "0x1828DA4D0")]
			public CLFPRIYFOJN(UOILJAPMYSC a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x28D9B70", Offset = "0x28D8B70", VA = "0x1828D9B70", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class DQTCDADVVEG : KLVIYETWZOR<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class ZKMPBACDFNK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public DQTCDADVVEG SULNKEFFSGR;

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZKMPBACDFNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x28F3760", Offset = "0x28F2760", VA = "0x1828F3760")]
				internal Dictionary<string, EnumChoiceData> CRZAXRVQDNF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x28F3200", Offset = "0x28F2200", VA = "0x1828F3200")]
				internal int CRTUALBSUBW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x28F3BA0", Offset = "0x28F2BA0", VA = "0x1828F3BA0")]
				internal void CSJOSFJKWJX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x28F39D0", Offset = "0x28F29D0", VA = "0x1828F39D0")]
				internal bool CSEHUYPNMYO()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x28DAA60", Offset = "0x28D9A60", VA = "0x1828DAA60")]
			public DQTCDADVVEG(UOILJAPMYSC a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x28DA7B0", Offset = "0x28D97B0", VA = "0x1828DA7B0", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class CPSDETSJKEH : KLVIYETWZOR<URNYJAERYNO>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class ZKMPBACDFNK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public CPSDETSJKEH SULNKEFFSGR;

				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZKMPBACDFNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x28F3650", Offset = "0x28F2650", VA = "0x1828F3650")]
				internal void CRZAXRVQDNF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x28DA6C0", Offset = "0x28D96C0", VA = "0x1828DA6C0")]
			public CPSDETSJKEH(UOILJAPMYSC a, URNYJAERYNO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x28DA540", Offset = "0x28D9540", VA = "0x1828DA540", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class ONSMFLKMHWN<a> : BTHOSFIMDYS<a> where a : notnull, WCJRBTEITFN
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override FBFCVJCOWNI? SKCJCLUBCOH
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x5CA3CE0", Offset = "0x5CA2CE0", VA = "0x185CA3CE0", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x5CA3D40", Offset = "0x5CA2D40", VA = "0x185CA3D40", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xCB8410", Offset = "0xCB7410", VA = "0x180CB8410", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x5CA3D20", Offset = "0x5CA2D20", VA = "0x185CA3D20")]
			public ONSMFLKMHWN(UOILJAPMYSC a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class TCNLGKWXJSR : ONSMFLKMHWN<BVGFUFXJEDA>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class MJLEUFQBZLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public TCNLGKWXJSR SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public MJLEUFQBZLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x28DFF30", Offset = "0x28DEF30", VA = "0x1828DFF30")]
				internal object CRZAXRVQDNF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x28DFE70", Offset = "0x28DEE70", VA = "0x1828DFE70")]
				internal void CRTUALBSUBW(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x28E0020", Offset = "0x28DF020", VA = "0x1828E0020")]
				internal void CSJOSFJKWJX()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? HKSYCYIATCJ;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x28E7D20", Offset = "0x28E6D20", VA = "0x1828E7D20")]
			public TCNLGKWXJSR(UOILJAPMYSC a, BVGFUFXJEDA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x28E77B0", Offset = "0x28E67B0", VA = "0x1828E77B0", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class FJHBOGNTXVC : KLVIYETWZOR<RYALSNKWXOB>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public FJHBOGNTXVC SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<VAFNDYWQNCG>> LNWPBJVJCNC;

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0x28DC080", Offset = "0x28DB080", VA = "0x1828DC080")]
				internal int CRTUALBSUBW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x28DCBD0", Offset = "0x28DBBD0", VA = "0x1828DCBD0")]
				internal void CSJOSFJKWJX(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class HQJTXUBZIPH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<VAFNDYWQNCG> OZFBAKWUWSK;

				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQJTXUBZIPH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600033B")]
				[Cpp2IlInjected.Address(RVA = "0x28DD5A0", Offset = "0x28DC5A0", VA = "0x1828DD5A0")]
				internal bool CSUCMSXFPGP(Id32<VAFNDYWQNCG> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x28DB660", Offset = "0x28DA660", VA = "0x1828DB660")]
			public FJHBOGNTXVC(UOILJAPMYSC a, RYALSNKWXOB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x28DB150", Offset = "0x28DA150", VA = "0x1828DB150", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class UHDCHFDDTWY : KLVIYETWZOR<CVKOZCWYNRL>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0xAFD470", Offset = "0xAFC470", VA = "0x180AFD470", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x28EE470", Offset = "0x28ED470", VA = "0x1828EE470")]
			public UHDCHFDDTWY(UOILJAPMYSC a, CVKOZCWYNRL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class NOQTWVXGZCL : KLVIYETWZOR<PUXJDDSAZAY>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0xBD70D0", Offset = "0xBD60D0", VA = "0x180BD70D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x28E08F0", Offset = "0x28DF8F0", VA = "0x1828E08F0")]
			public NOQTWVXGZCL(UOILJAPMYSC a, PUXJDDSAZAY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "134")]
			protected override bool MBVVBRBIDHF(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class QHXTWNBXMFZ : KLVIYETWZOR<SVUZOYNNVLC>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xBD3770", Offset = "0xBD2770", VA = "0x180BD3770", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000344")]
				[Cpp2IlInjected.Address(RVA = "0x28E1530", Offset = "0x28E0530", VA = "0x1828E1530", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool GFDBLYOGKCZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x28E14C0", Offset = "0x28E04C0", VA = "0x1828E14C0")]
			public QHXTWNBXMFZ(UOILJAPMYSC a, SVUZOYNNVLC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class GMORAQTCLFJ : KLVIYETWZOR<WHIKHGQQWII>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xBE14C0", Offset = "0xBE04C0", VA = "0x180BE14C0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x28DBC40", Offset = "0x28DAC40", VA = "0x1828DBC40", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool GFDBLYOGKCZ
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x28DBBD0", Offset = "0x28DABD0", VA = "0x1828DBBD0")]
			public GMORAQTCLFJ(UOILJAPMYSC a, WHIKHGQQWII b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class ZFQQUIAYJTI : QRDIPWEKUPP<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public ZFQQUIAYJTI SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x28DD390", Offset = "0x28DC390", VA = "0x1828DD390")]
				internal float DVMQUSIPWTM()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0x28DD4B0", Offset = "0x28DC4B0", VA = "0x1828DD4B0")]
				internal void DVRXRZCNGEV(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x28F31A0", Offset = "0x28F21A0", VA = "0x1828F31A0")]
			public ZFQQUIAYJTI(UOILJAPMYSC a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x28F2F30", Offset = "0x28F1F30", VA = "0x1828F2F30", Slot = "151")]
			protected override void GQGAZNHWGEO(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class PUIXQBFDNLF : KLVIYETWZOR<QMOREGHDPAE>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x28E0EE0", Offset = "0x28DFEE0", VA = "0x1828E0EE0")]
			public PUIXQBFDNLF(UOILJAPMYSC a, QMOREGHDPAE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class CJVPEZNKCLB : KLVIYETWZOR<ONFXMJKTYNW>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x28D9B00", Offset = "0x28D8B00", VA = "0x1828D9B00")]
			public CJVPEZNKCLB(UOILJAPMYSC a, ONFXMJKTYNW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class ERZRHJFQKVM : KLVIYETWZOR<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public ERZRHJFQKVM SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x28DCA40", Offset = "0x28DBA40", VA = "0x1828DCA40")]
				internal bool CRZAXRVQDNF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0x28DC1C0", Offset = "0x28DB1C0", VA = "0x1828DC1C0")]
				internal void CRTUALBSUBW(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x28DAD60", Offset = "0x28D9D60", VA = "0x1828DAD60")]
			public ERZRHJFQKVM(UOILJAPMYSC a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x28DAAD0", Offset = "0x28D9AD0", VA = "0x1828DAAD0", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class YJKLXXGVZWG : KLVIYETWZOR<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public YJKLXXGVZWG SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> VCTLNARFPBB;

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x28DC8C0", Offset = "0x28DB8C0", VA = "0x1828DC8C0")]
				internal object? CRZAXRVQDNF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x28DD090", Offset = "0x28DC090", VA = "0x1828DD090")]
				internal bool CSZJJZRCYRY(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x28DC2F0", Offset = "0x28DB2F0", VA = "0x1828DC2F0")]
				internal void CRTUALBSUBW(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x28DCE90", Offset = "0x28DBE90", VA = "0x1828DCE90")]
				internal string CSJOSFJKWJX(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x28DCB80", Offset = "0x28DBB80", VA = "0x1828DCB80")]
				internal IReadOnlyList<object> CSEHUYPNMYO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x28DD020", Offset = "0x28DC020", VA = "0x1828DD020")]
				internal bool CSUCMSXFPGP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0x28DCFD0", Offset = "0x28DBFD0", VA = "0x1828DCFD0")]
				internal bool CSOVPMDIFVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x28DD110", Offset = "0x28DC110", VA = "0x1828DD110")]
				internal void CTEQHGLAIDH(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x28F2DB0", Offset = "0x28F1DB0", VA = "0x1828F2DB0")]
			public YJKLXXGVZWG(UOILJAPMYSC a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x28F26C0", Offset = "0x28F16C0", VA = "0x1828F26C0", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class PUUPMKPOQSI : KLVIYETWZOR<DYIQNYGACFT>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class NMXMBBMJYRH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int WRXJKXNIDFE;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public NMXMBBMJYRH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x28E08B0", Offset = "0x28DF8B0", VA = "0x1828E08B0")]
				internal bool NTYLMBNPTRE(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class ZOAXUNZKSXA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public PUUPMKPOQSI SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> EQKUGPTVABK;

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZOAXUNZKSXA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x28F4FB0", Offset = "0x28F3FB0", VA = "0x1828F4FB0")]
				internal int CRZAXRVQDNF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0x28F4E90", Offset = "0x28F3E90", VA = "0x1828F4E90")]
				internal void CRTUALBSUBW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0x28F5050", Offset = "0x28F4050", VA = "0x1828F5050")]
				internal string? CSJOSFJKWJX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000369")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x28E1450", Offset = "0x28E0450", VA = "0x1828E1450")]
			public PUUPMKPOQSI(UOILJAPMYSC a, DYIQNYGACFT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x28E13C0", Offset = "0x28E03C0", VA = "0x1828E13C0")]
			private int HLFYDLXSRGM(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x28E0F50", Offset = "0x28DFF50", VA = "0x1828E0F50")]
			private void AOGVSJYMCVU(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x28E1070", Offset = "0x28E0070", VA = "0x1828E1070", Slot = "145")]
			protected sealed override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class OYICULMUDPT : RMUYWMZQYJZ<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0xCB0D70", Offset = "0xCAFD70", VA = "0x180CB0D70", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x28E0E10", Offset = "0x28DFE10", VA = "0x1828E0E10")]
			public OYICULMUDPT(UOILJAPMYSC a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class HLOLBBWVKWP : QRDIPWEKUPP<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public HLOLBBWVKWP SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x28DD310", Offset = "0x28DC310", VA = "0x1828DD310")]
				internal int DVMQUSIPWTM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x28DD410", Offset = "0x28DC410", VA = "0x1828DD410")]
				internal void DVRXRZCNGEV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x28DC020", Offset = "0x28DB020", VA = "0x1828DC020")]
			public HLOLBBWVKWP(UOILJAPMYSC a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x28DBDB0", Offset = "0x28DADB0", VA = "0x1828DBDB0", Slot = "151")]
			protected override void GQGAZNHWGEO(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class SSIXODTSZTH : KLVIYETWZOR<NGEFOCIJCMC>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public SSIXODTSZTH SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<VAFNDYWQNCG>> LNWPBJVJCNC;

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0x28DC5D0", Offset = "0x28DB5D0", VA = "0x1828DC5D0")]
				internal int CRTUALBSUBW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x28DCD30", Offset = "0x28DBD30", VA = "0x1828DCD30")]
				internal void CSJOSFJKWJX(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class HQJTXUBZIPH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<VAFNDYWQNCG> OZFBAKWUWSK;

				[Cpp2IlInjected.Token(Token = "0x6000383")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQJTXUBZIPH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0x28DD550", Offset = "0x28DC550", VA = "0x1828DD550")]
				internal bool CSUCMSXFPGP(Id32<VAFNDYWQNCG> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x28E7740", Offset = "0x28E6740", VA = "0x1828E7740")]
			public SSIXODTSZTH(UOILJAPMYSC a, NGEFOCIJCMC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x28E7230", Offset = "0x28E6230", VA = "0x1828E7230", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class AOIBPCYQVLZ : KLVIYETWZOR<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public AOIBPCYQVLZ SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000388")]
				[Cpp2IlInjected.Address(RVA = "0x28DCAE0", Offset = "0x28DBAE0", VA = "0x1828DCAE0")]
				internal bool CRZAXRVQDNF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x28DC7A0", Offset = "0x28DB7A0", VA = "0x1828DC7A0")]
				internal void CRTUALBSUBW(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x28D9A90", Offset = "0x28D8A90", VA = "0x1828D9A90")]
			public AOIBPCYQVLZ(UOILJAPMYSC a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x28D98C0", Offset = "0x28D88C0", VA = "0x1828D98C0", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class TPXPXUVTNUT : KLVIYETWZOR<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public TPXPXUVTNUT SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0x28DC9F0", Offset = "0x28DB9F0", VA = "0x1828DC9F0")]
				internal bool CRZAXRVQDNF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x28DC830", Offset = "0x28DB830", VA = "0x1828DC830")]
				internal void CRTUALBSUBW(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x28E8040", Offset = "0x28E7040", VA = "0x1828E8040")]
			public TPXPXUVTNUT(UOILJAPMYSC a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x28E7E70", Offset = "0x28E6E70", VA = "0x1828E7E70", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class WYBLUGLOSXP : KLVIYETWZOR<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public WYBLUGLOSXP SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000392")]
				[Cpp2IlInjected.Address(RVA = "0x28DCB30", Offset = "0x28DBB30", VA = "0x1828DCB30")]
				internal int CRZAXRVQDNF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x28DC710", Offset = "0x28DB710", VA = "0x1828DC710")]
				internal void CRTUALBSUBW(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x28EFCC0", Offset = "0x28EECC0", VA = "0x1828EFCC0")]
			public WYBLUGLOSXP(UOILJAPMYSC a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x28EFA70", Offset = "0x28EEA70", VA = "0x1828EFA70", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class DFBTHXUSHRA
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log HRODLTCIOIP;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class ICONWVDWCZH<a> : KLVIYETWZOR<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class EXLFJINJVOA
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000A7")]
				private struct <<AddMessageNamePicker>g__TryCommitMessageSelection|5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CA")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CB")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CC")]
					public EXLFJINJVOA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C8")]
					[Cpp2IlInjected.Address(RVA = "0x3D06AA0", Offset = "0x3D05AA0", VA = "0x183D06AA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C9")]
					[Cpp2IlInjected.Address(RVA = "0x3D06DE0", Offset = "0x3D05DE0", VA = "0x183D06DE0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload IJYKQRUFMEX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public ICONWVDWCZH<a> SULNKEFFSGR;

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public EXLFJINJVOA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x48E9F40", Offset = "0x48E8F40", VA = "0x1848E9F40")]
				[AsyncStateMachine(typeof(ICONWVDWCZH<>.EXLFJINJVOA.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task XYATQXZDZMF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0x48E9E20", Offset = "0x48E8E20", VA = "0x1848E9E20")]
				internal void FICISWRELNI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class UMUXJEDNZLQ
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000A9")]
				private struct <<OnAddOrEditMessageButtonClicked>b__8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001D9")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DA")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DB")]
					public UMUXJEDNZLQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x3D1A460", Offset = "0x3D19460", VA = "0x183D1A460", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000AA")]
				private struct <<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DD")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DE")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DF")]
					public UMUXJEDNZLQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DD")]
					[Cpp2IlInjected.Address(RVA = "0x3D1BBF0", Offset = "0x3D1ABF0", VA = "0x183D1BBF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DE")]
					[Cpp2IlInjected.Address(RVA = "0x3D1C300", Offset = "0x3D1B300", VA = "0x183D1C300", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public UPRRQQRREYW.DHAPXLJCZOA YWKNSKTJRXB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string OFUZSPGLNAU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string REVZNOYESRI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public ICONWVDWCZH<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper EKVBNTVBVNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool PXQYJPYMQWC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action LCCISNMXTUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool TFTUUCTXFWY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string DZCYBNLCWPS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action OSLXKGQAPPO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action USFRCUNVNGY;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public UMUXJEDNZLQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x63D6C40", Offset = "0x63D5C40", VA = "0x1863D6C40")]
				internal void OXQFZZAGHAB(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x63D6BD0", Offset = "0x63D5BD0", VA = "0x1863D6BD0")]
				internal void OXKZCSGIXOS(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
				internal string HERXWEHBBNO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x63D66A0", Offset = "0x63D56A0", VA = "0x1863D66A0")]
				internal void HEXETLAYKYX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0x5C6CE10", Offset = "0x5C6BE10", VA = "0x185C6CE10")]
				internal bool HFCLQRUVUKG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0x63D6830", Offset = "0x63D5830", VA = "0x1863D6830")]
				internal char HFHSNYOTDVP((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
				internal string? HDWWHDFLPUE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0xCB9D70", Offset = "0xCB8D70", VA = "0x180CB9D70")]
				internal bool HECDEJZIZFN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x63D65E0", Offset = "0x63D55E0", VA = "0x1863D65E0")]
				internal void HEHKBQTGIQW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x5C6CE10", Offset = "0x5C6BE10", VA = "0x185C6CE10")]
				internal bool HEMQYXNDSCF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x63D68D0", Offset = "0x63D58D0", VA = "0x1863D68D0")]
				[AsyncStateMachine(typeof(ICONWVDWCZH<>.UMUXJEDNZLQ.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void HGIBAGKFZAI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x63D69B0", Offset = "0x63D59B0", VA = "0x1863D69B0")]
				internal void MBGYCKWKUGE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x63D6510", Offset = "0x63D5510", VA = "0x1863D6510")]
				[AsyncStateMachine(typeof(ICONWVDWCZH<>.UMUXJEDNZLQ.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task DCSGLBZYLGR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x63D6AB0", Offset = "0x63D5AB0", VA = "0x1863D6AB0")]
				internal void OVUVYQDEABY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x63D6C90", Offset = "0x63D5C90", VA = "0x1863D6C90")]
				internal void VRUYIIVPGTI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x63D6970", Offset = "0x63D5970", VA = "0x1863D6970")]
				internal bool HGNHXNEDILR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class ZGBPCWLNZTB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter JSRRNSXDVSG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public ICONWVDWCZH<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<UPRRQQRREYW.QNZUETIJPRE> OUHHLPNCWNR;

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZGBPCWLNZTB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x3F36510", Offset = "0x3F35510", VA = "0x183F36510")]
				internal bool DQKNVOHRCTD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x3F36550", Offset = "0x3F35550", VA = "0x183F36550")]
				internal void KYWWXKGRDJZ(UPRRQQRREYW.QNZUETIJPRE a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class ZFWIFPRQQHS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool GQVDAKSQZFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public SHFRTCUNHQZ IXFOQKCKQTA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public SHFRTCUNHQZ SGMGMZKXGEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public SHFRTCUNHQZ WGMDYMTUOFW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string HQZFXQVQZIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public ZGBPCWLNZTB PYDAXWOHYEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action VDZAWPGPTRD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action OUMOIWHAFZA;

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZFWIFPRQQHS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0xCD4A10", Offset = "0xCD3A10", VA = "0x180CD4A10")]
				internal bool MWYJKDEXQDF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x3F36410", Offset = "0x3F35410", VA = "0x183F36410")]
				internal void VFYZKYXXZWW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x3F35570", Offset = "0x3F34570", VA = "0x183F35570")]
				internal void DPUTDTZZALC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x3F35550", Offset = "0x3F34550", VA = "0x183F35550")]
				internal void DPPMGNGBQZT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x3F36020", Offset = "0x3F35020", VA = "0x183F36020")]
				internal void DQVBQBVLVPV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0x3F359D0", Offset = "0x3F349D0", VA = "0x183F359D0")]
				internal void DQFGYHNTTHU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x3F35550", Offset = "0x3F34550", VA = "0x183F35550")]
				internal void KZCDURAOMVI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class ZGMCXJZISPT
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000AE")]
				private struct <<UpdateParameterFoldout>g__TryCommitToggle|7>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001EE")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001EF")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F0")]
					public ZGMCXJZISPT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003ED")]
					[Cpp2IlInjected.Address(RVA = "0x3D2B750", Offset = "0x3D2A750", VA = "0x183D2B750", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EE")]
					[Cpp2IlInjected.Address(RVA = "0x3D2BD90", Offset = "0x3D2AD90", VA = "0x183D2BD90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool XVWHNYMVRGE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public ZFWIFPRQQHS PYSVPQWAAMF;

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZGMCXJZISPT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x3F36830", Offset = "0x3F35830", VA = "0x183F36830")]
				[AsyncStateMachine(typeof(ICONWVDWCZH<>.ZGMCXJZISPT.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task MIHFTQUCONA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0x3F367C0", Offset = "0x3F357C0", VA = "0x183F367C0")]
				internal void DPKFJGMEHOK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class ZGGWADFLJEK
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000B0")]
				private struct <<UpdateParameterFoldout>g__TryCommitDeletion|11>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F4")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F5")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F6")]
					public ZGGWADFLJEK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F2")]
					[Cpp2IlInjected.Address(RVA = "0x3D2B140", Offset = "0x3D2A140", VA = "0x183D2B140", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F3")]
					[Cpp2IlInjected.Address(RVA = "0x3D2B6F0", Offset = "0x3D2A6F0", VA = "0x183D2B6F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload XYOAGNAHYOX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public ZFWIFPRQQHS PYNOSKCCRAW;

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZGGWADFLJEK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F0")]
				[Cpp2IlInjected.Address(RVA = "0x3F36690", Offset = "0x3F35690", VA = "0x183F36690")]
				[AsyncStateMachine(typeof(ICONWVDWCZH<>.ZGGWADFLJEK.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task UZKQRXYZARL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0x3F36620", Offset = "0x3F35620", VA = "0x183F36620")]
				internal void KZHKRXULWGR()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class MEEVMWIDDFQ
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000B2")]
				private struct <<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FB")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FC")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FD")]
					public MEEVMWIDDFQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F9")]
					[Cpp2IlInjected.Address(RVA = "0x3D2AC60", Offset = "0x3D29C60", VA = "0x183D2AC60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003FA")]
					[Cpp2IlInjected.Address(RVA = "0x3D2B0E0", Offset = "0x3D2A0E0", VA = "0x183D2B0E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public ICONWVDWCZH<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload TYOHMFWUPRB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public UPRRQQRREYW.QNZUETIJPRE YWKNSKTJRXB;

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public MEEVMWIDDFQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x5A7E3D0", Offset = "0x5A7D3D0", VA = "0x185A7E3D0")]
				[AsyncStateMachine(typeof(ICONWVDWCZH<>.MEEVMWIDDFQ.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task JMYQXSJJXLF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x5A7E610", Offset = "0x5A7D610", VA = "0x185A7E610")]
				internal bool ZJANTLZYAHD(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F7")]
				[Cpp2IlInjected.Address(RVA = "0x5A7E4A0", Offset = "0x5A7D4A0", VA = "0x185A7E4A0")]
				internal void ZIKTBRSFXZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F8")]
				[Cpp2IlInjected.Address(RVA = "0x5A7E5C0", Offset = "0x5A7D5C0", VA = "0x185A7E5C0")]
				internal void ZIPZYYMDHKL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class ZJPXWKIVNCR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string PNMAWASGAKW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public SHFRTCUNHQZ ZWOWJWHAAFP;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZJPXWKIVNCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x3F41520", Offset = "0x3F40520", VA = "0x183F41520")]
				internal string? NQPKVMJZGLW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xC6C9F0", Offset = "0xC6B9F0", VA = "0x180C6C9F0")]
				internal bool NQURSTDWPXF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FE")]
				[Cpp2IlInjected.Address(RVA = "0x3F41540", Offset = "0x3F40540", VA = "0x183F41540")]
				internal void NQZYPZXTZIO(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool JMMNVNWGNKT;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log HRODLTCIOIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x517F870", Offset = "0x517E870", VA = "0x18517F870")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool GFDBLYOGKCZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000398")]
				[Cpp2IlInjected.Address(RVA = "0x5181980", Offset = "0x5180980", VA = "0x185181980", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected UPRRQQRREYW MDUXMIMTBEF
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xAD3F30", Offset = "0xAD2F30", VA = "0x180AD3F30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xAD4240", Offset = "0xAD3240", VA = "0x180AD4240")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> GSLJPQCUYIE
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xB50C80", Offset = "0xB4FC80", VA = "0x180B50C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0xE9CBB0", Offset = "0xE9BBB0", VA = "0x180E9CBB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected YTKSAACLSFG IFYUBAVQGTJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xD064B0", Offset = "0xD054B0", VA = "0x180D064B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x14B1340", Offset = "0x14B0340", VA = "0x1814B1340")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected NKJDITYMVKI QSGOHOXAXWH
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xD064C0", Offset = "0xD054C0", VA = "0x180D064C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x14B0AF0", Offset = "0x14AFAF0", VA = "0x1814B0AF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x5181950", Offset = "0x5180950", VA = "0x185181950")]
			protected ICONWVDWCZH(UOILJAPMYSC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x517D460", Offset = "0x517C460", VA = "0x18517D460", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x517D400", Offset = "0x517C400", VA = "0x18517D400", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x517D4C0", Offset = "0x517C4C0", VA = "0x18517D4C0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x517D520", Offset = "0x517C520", VA = "0x18517D520")]
			private void GECDHNCNZBI(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x517D800", Offset = "0x517C800", VA = "0x18517D800", Slot = "145")]
			protected sealed override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x517E4E0", Offset = "0x517D4E0", VA = "0x18517E4E0")]
			private void GTEZVDFXTGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x517ED70", Offset = "0x517DD70", VA = "0x18517ED70")]
			private void LPAUWSAVCZK(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "151")]
			protected virtual void DRPRTQXWVFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x5180690", Offset = "0x517F690", VA = "0x185180690")]
			private void QOSOTLMWFYH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x517DA20", Offset = "0x517CA20", VA = "0x18517DA20")]
			private void GLJYERRLLQG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x517F8C0", Offset = "0x517E8C0", VA = "0x18517F8C0")]
			private void NFFWZAVSJLU(UPRRQQRREYW.QNZUETIJPRE a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x517EB60", Offset = "0x517DB60", VA = "0x18517EB60")]
			private void HXCNSMPTOAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x51817F0", Offset = "0x51807F0", VA = "0x1851817F0")]
			protected void WTZHFCOJUAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x517D390", Offset = "0x517C390", VA = "0x18517D390")]
			private void AADPULAYNMQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x51817D0", Offset = "0x51807D0", VA = "0x1851817D0")]
			private void WMTYFQCCTSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x5181860", Offset = "0x5180860", VA = "0x185181860")]
			private void ZDDZZQBUVRR(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x5180840", Offset = "0x517F840", VA = "0x185180840")]
			private string RQVWVFUXAXD((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x51818C0", Offset = "0x51808C0", VA = "0x1851818C0")]
			private string ZNAHEJGLCJM(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x5180F80", Offset = "0x517FF80", VA = "0x185180F80")]
			[CompilerGenerated]
			private object? TLSZBKKNPIK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x5180FB0", Offset = "0x517FFB0", VA = "0x185180FB0")]
			[CompilerGenerated]
			private void TLYFYREKYTT(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x5180F00", Offset = "0x517FF00", VA = "0x185180F00")]
			[CompilerGenerated]
			private IReadOnlyList<object> TLNSEDQQFXB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x5181740", Offset = "0x5180740", VA = "0x185181740")]
			[CompilerGenerated]
			private void TMOAQLMDBBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x5180EB0", Offset = "0x517FEB0", VA = "0x185180EB0")]
			[CompilerGenerated]
			private void TKICUPBGBGZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x5181820", Offset = "0x5180820", VA = "0x185181820")]
			[CompilerGenerated]
			private void YGMSMRFLMJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x5180B40", Offset = "0x517FB40", VA = "0x185180B40")]
			[CompilerGenerated]
			private void SNCHAMCUKTF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x5180E70", Offset = "0x517FE70", VA = "0x185180E70")]
			[CompilerGenerated]
			private void SXRUDCKYINC(UPRRQQRREYW.QNZUETIJPRE a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class IDBKNCLJROC : ICONWVDWCZH<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xBD3770", Offset = "0xBD2770", VA = "0x180BD3770", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x28DD990", Offset = "0x28DC990", VA = "0x1828DD990")]
			public IDBKNCLJROC(UOILJAPMYSC a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class XPCDVHIQSBQ : ICONWVDWCZH<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type DDMUNNSBCXX
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0x28E6BC0", Offset = "0x28E5BC0", VA = "0x1828E6BC0", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope UZYESHWXOHI
				{
					[Cpp2IlInjected.Token(Token = "0x6000408")]
					[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string FNGOSZEZHYU
				{
					[Cpp2IlInjected.Token(Token = "0x6000409")]
					[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0x11C1A70", Offset = "0x11C0A70", VA = "0x1811C1A70")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x28E6C10", Offset = "0x28E5C10", VA = "0x1828E6C10", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x28E6AF0", Offset = "0x28E5AF0", VA = "0x1828E6AF0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool NMSVUJMASRP(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x28E69E0", Offset = "0x28E59E0", VA = "0x1828E69E0", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x28E6800", Offset = "0x28E5800", VA = "0x1828E6800", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x28E6890", Offset = "0x28E5890", VA = "0x1828E6890", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(ReceiverScopeSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B7")]
			private class TargetPlayersSelection : IEquatable<TargetPlayersSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000064")]
				[CompilerGenerated]
				protected virtual Type DDMUNNSBCXX
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0x28E8470", Offset = "0x28E7470", VA = "0x1828E8470", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers PUPCKRCLLUU
				{
					[Cpp2IlInjected.Token(Token = "0x6000411")]
					[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string FNGOSZEZHYU
				{
					[Cpp2IlInjected.Token(Token = "0x6000412")]
					[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0x11C1A70", Offset = "0x11C0A70", VA = "0x1811C1A70")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x28E84C0", Offset = "0x28E74C0", VA = "0x1828E84C0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x28E83A0", Offset = "0x28E73A0", VA = "0x1828E83A0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool NMSVUJMASRP(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x28E8290", Offset = "0x28E7290", VA = "0x1828E8290", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000416")]
				[Cpp2IlInjected.Address(RVA = "0x28E80B0", Offset = "0x28E70B0", VA = "0x1828E80B0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x28E8140", Offset = "0x28E7140", VA = "0x1828E8140", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class ZKMPBACDFNK
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000BA")]
				private struct <<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000210")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000211")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x4000212")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000213")]
					public ZKMPBACDFNK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x28EC480", Offset = "0x28EB480", VA = "0x1828EC480", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000BB")]
				private struct <<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000215")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000216")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x4000217")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000218")]
					public ZKMPBACDFNK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000427")]
					[Cpp2IlInjected.Address(RVA = "0x28EC8A0", Offset = "0x28EB8A0", VA = "0x1828EC8A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000428")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public XPCDVHIQSBQ SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public YTKSAACLSFG RXSLJFMFWZT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> VDTTZIMSKFU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> VDZAWPGPTRD;

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZKMPBACDFNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x28F4870", Offset = "0x28F3870", VA = "0x1828F4870")]
				internal object? QQJCGBFWKAJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x28F4740", Offset = "0x28F3740", VA = "0x1828F4740")]
				internal bool QOSZBZCRMNP(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x28F47A0", Offset = "0x28F37A0", VA = "0x1828F47A0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void QQDVIULZAPA(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x28F4630", Offset = "0x28F3630", VA = "0x1828F4630")]
				internal IReadOnlyList<TargetPlayersSelection> JPLZYXWLJLZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x28F4A20", Offset = "0x28F3A20", VA = "0x1828F4A20")]
				internal object? QQYWXVNOMIK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x28F46E0", Offset = "0x28F36E0", VA = "0x1828F46E0")]
				internal bool QONSESIUDCG(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x28F4950", Offset = "0x28F3950", VA = "0x1828F4950")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void QQTQAOTRCXB(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> BTMCVTNWNTP;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> VYEBDKYBRFB;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> FXLQXOKWUXB;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000401")]
				[Cpp2IlInjected.Address(RVA = "0xBE14C0", Offset = "0xBE04C0", VA = "0x180BE14C0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x28F08A0", Offset = "0x28EF8A0", VA = "0x1828F08A0")]
			public XPCDVHIQSBQ(UOILJAPMYSC a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x28EFD30", Offset = "0x28EED30", VA = "0x1828EFD30", Slot = "151")]
			protected override void DRPRTQXWVFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x28F0290", Offset = "0x28EF290", VA = "0x1828F0290")]
			private static IReadOnlyList<TargetPlayersSelection> LJWVLYWBIEE(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class GUSEBEDXTTF : NNKLACTSBLY<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType FLMUMUJCRKF
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x28DBC90", Offset = "0x28DAC90", VA = "0x1828DBC90")]
			public GUSEBEDXTTF(UOILJAPMYSC a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class WVDWHQJQIGC : KLVIYETWZOR<TYZPRJYTRRB>
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x28E0E70", Offset = "0x28DFE70", VA = "0x1828E0E70")]
			public WVDWHQJQIGC(UOILJAPMYSC a, TYZPRJYTRRB b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class KLVIYETWZOR<a> : YYVRREXPLEY, IDisposable where a : notnull, TYZPRJYTRRB
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class ORMYCPIHDTW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public KLVIYETWZOR<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public UOILJAPMYSC MKNJDHGQNKO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a FRFZLZEZYJF;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ORMYCPIHDTW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0x5CF18B0", Offset = "0x5CF08B0", VA = "0x185CF18B0")]
				internal RPUELYKVFON VASIVJXOSSI(RYAFFIWWYUG a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class HZVREWBHEYA
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000C1")]
				private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023C")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023D")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023E")]
					public HZVREWBHEYA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BD")]
					[Cpp2IlInjected.Address(RVA = "0x3D09670", Offset = "0x3D08670", VA = "0x183D09670", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BE")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string AEXBOLUETXS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, WENLUTALDTF>> ONXKVQYBWDT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public KLVIYETWZOR<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> XWNXJHYVMTV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public UPRRQQRREYW MDUXMIMTBEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> UTAHCPWZEIP;

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HZVREWBHEYA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				internal string NXYYSJBERCW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
				internal void NYEFPPVCAOF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x50C76D0", Offset = "0x50C66D0", VA = "0x1850C76D0")]
				[AsyncStateMachine(typeof(KLVIYETWZOR<>.HZVREWBHEYA.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void NXOKXVNJYGE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class LSOFONCLIOZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public LSOFONCLIOZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x55737C0", Offset = "0x55727C0", VA = "0x1855737C0")]
				internal Result<string, WENLUTALDTF> FMOMWCTVGSE(string a)
				{
					return default(Result<string, WENLUTALDTF>);
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000C3")]
			[CompilerGenerated]
			private struct <RequestLocalTransformChange>d__82 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000241")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000242")]
				public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public KLVIYETWZOR<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x53A1F40", Offset = "0x53A0F40", VA = "0x1853A1F40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x53A2190", Offset = "0x53A1190", VA = "0x1853A2190", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000C4")]
			[CompilerGenerated]
			private struct <RequestNameChange>d__224 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000247")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000248")]
				public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public KLVIYETWZOR<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0x53A2200", Offset = "0x53A1200", VA = "0x1853A2200", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C4")]
				[Cpp2IlInjected.Address(RVA = "0x53A2480", Offset = "0x53A1480", VA = "0x1853A2480", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly UOILJAPMYSC HHSEEZECAYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool PFRORHUHUSX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<JPZDQKXUTWI, RPUELYKVFON> OBBVNPABIWH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<JPZDQKXUTWI, BOUENRSVMUK> YBDBBIXRQZU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> CHTLOPZREXD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<JPZDQKXUTWI>>? HMOVMSRZLMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<JPZDQKXUTWI>, BOUENRSVMUK>? XPDNNJCPPLI;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected ONSXKYCMZAP FYLRPLOTYZY
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x54531C0", Offset = "0x54521C0", VA = "0x1854531C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected MLJAAVCGGXT MLJAAVCGGXT
			{
				[Cpp2IlInjected.Token(Token = "0x600042D")]
				[Cpp2IlInjected.Address(RVA = "0x5453560", Offset = "0x5452560", VA = "0x185453560")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected VVHHZIOZHKI TZIRJUJERFV
			{
				[Cpp2IlInjected.Token(Token = "0x600042E")]
				[Cpp2IlInjected.Address(RVA = "0x5456860", Offset = "0x5455860", VA = "0x185456860")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a TYZPRJYTRRB
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<XWYEQLTFQES> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0x1403180", Offset = "0x1402180", VA = "0x181403180", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<XWYEQLTFQES>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<ZLSSORBCQRX> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0x54574B0", Offset = "0x54564B0", VA = "0x1854574B0", Slot = "6")]
				get
				{
					return default(Id32<ZLSSORBCQRX>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000436")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x5457320", Offset = "0x5456320", VA = "0x185457320", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x5457300", Offset = "0x5456300", VA = "0x185457300", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x5457610", Offset = "0x5456610", VA = "0x185457610", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool GFDBLYOGKCZ
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<RPECEFKJJZZ> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xD8F670", Offset = "0xD8E670", VA = "0x180D8F670", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<RPECEFKJJZZ>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xD8F8D0", Offset = "0xD8E8D0", VA = "0x180D8F8D0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0xB1C770", Offset = "0xB1B770", VA = "0x180B1C770", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x54571D0", Offset = "0x54561D0", VA = "0x1854571D0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x5457200", Offset = "0x5456200", VA = "0x185457200", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x5457230", Offset = "0x5456230", VA = "0x185457230", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x5457490", Offset = "0x5456490", VA = "0x185457490", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x54573C0", Offset = "0x54563C0", VA = "0x1854573C0", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x54572A0", Offset = "0x54562A0", VA = "0x1854572A0", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x5457270", Offset = "0x5456270", VA = "0x185457270", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0xE44370", Offset = "0xE43370", VA = "0x180E44370", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x15957C0", Offset = "0x15947C0", VA = "0x1815957C0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x5457260", Offset = "0x5456260", VA = "0x185457260", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x5457370", Offset = "0x5456370", VA = "0x185457370", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x5457430", Offset = "0x5456430", VA = "0x185457430", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x5457460", Offset = "0x5456460", VA = "0x185457460", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000453")]
				[Cpp2IlInjected.Address(RVA = "0x54573A0", Offset = "0x54563A0", VA = "0x1854573A0", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual IBACQFAHXGP? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual FBFCVJCOWNI? SKCJCLUBCOH
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<QYHWLOYXTJM>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x54572D0", Offset = "0x54562D0", VA = "0x1854572D0", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<YHQFEYRJQPY> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x54573E0", Offset = "0x54563E0", VA = "0x1854573E0", Slot = "68")]
				get
				{
					return default(Id128<YHQFEYRJQPY>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<YHQFEYRJQPY> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x5457340", Offset = "0x5456340", VA = "0x185457340", Slot = "59")]
				get
				{
					return default(Id32<YHQFEYRJQPY>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<YHQFEYRJQPY>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<YHQFEYRJQPY>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x54552C0", Offset = "0x54542C0", VA = "0x1854552C0", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xAD82C0", Offset = "0xAD72C0", VA = "0x180AD82C0", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xAD8360", Offset = "0xAD7360", VA = "0x180AD8360")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0xAD8310", Offset = "0xAD7310", VA = "0x180AD8310", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0xAD82E0", Offset = "0xAD72E0", VA = "0x180AD82E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<QYHWLOYXTJM> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x54574F0", Offset = "0x54564F0", VA = "0x1854574F0", Slot = "69")]
				get
				{
					return default(Id32<QYHWLOYXTJM>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<QYHWLOYXTJM> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x5457410", Offset = "0x5456410", VA = "0x185457410", Slot = "70")]
				get
				{
					return default(Id128<QYHWLOYXTJM>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<QYHWLOYXTJM>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0x5457510", Offset = "0x5456510", VA = "0x185457510", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<JPZDQKXUTWI, BOUENRSVMUK> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x54575D0", Offset = "0x54565D0", VA = "0x1854575D0", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<JPZDQKXUTWI, BOUENRSVMUK>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<JPZDQKXUTWI>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action SWYIKQLMLXU
			{
				[Cpp2IlInjected.Token(Token = "0x600045A")]
				[Cpp2IlInjected.Address(RVA = "0x5454120", Offset = "0x5453120", VA = "0x185454120", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x5454320", Offset = "0x5453320", VA = "0x185454320", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate ALSRENTXGVR
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x54541C0", Offset = "0x54531C0", VA = "0x1854541C0", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x5454B60", Offset = "0x5453B60", VA = "0x185454B60", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate BSCAPPXYYQE
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x5453920", Offset = "0x5452920", VA = "0x185453920", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x5456700", Offset = "0x5455700", VA = "0x185456700", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action TYPYETTUBNS
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x5453A20", Offset = "0x5452A20", VA = "0x185453A20", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x5456C90", Offset = "0x5455C90", VA = "0x185456C90", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action UBAGYZVCUKN
			{
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0x54561E0", Offset = "0x54551E0", VA = "0x1854561E0", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000464")]
				[Cpp2IlInjected.Address(RVA = "0x5456140", Offset = "0x5455140", VA = "0x185456140", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<JPZDQKXUTWI>, BOUENRSVMUK> SEKGCXJTFIQ
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x5454F40", Offset = "0x5453F40", VA = "0x185454F40", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x5454260", Offset = "0x5453260", VA = "0x185454260", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<JPZDQKXUTWI>, BOUENRSVMUK> YCRALAVEHGD
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x5455C40", Offset = "0x5454C40", VA = "0x185455C40", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x5456BD0", Offset = "0x5455BD0", VA = "0x185456BD0", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<JPZDQKXUTWI>> NGSYIAEGBRH
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x5455B10", Offset = "0x5454B10", VA = "0x185455B10", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x5453860", Offset = "0x5452860", VA = "0x185453860", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<JPZDQKXUTWI>, Id32<JPZDQKXUTWI>> QUTPFTSVDOA
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x5453F90", Offset = "0x5452F90", VA = "0x185453F90", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x54537A0", Offset = "0x54527A0", VA = "0x1854537A0", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<JPZDQKXUTWI>, BOUENRSVMUK> IICOZFWBNTW
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x54534A0", Offset = "0x54524A0", VA = "0x1854534A0", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x5456A10", Offset = "0x5455A10", VA = "0x185456A10", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<JPZDQKXUTWI>, Id32<JPZDQKXUTWI>> CNDLWOVEETF
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x5453650", Offset = "0x5452650", VA = "0x185453650", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x54543C0", Offset = "0x54533C0", VA = "0x1854543C0", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> VHFPXYRVXWQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x54555C0", Offset = "0x54545C0", VA = "0x1854555C0", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x5456640", Offset = "0x5455640", VA = "0x185456640", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x5456D60", Offset = "0x5455D60", VA = "0x185456D60")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected KLVIYETWZOR(UOILJAPMYSC a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x5454990", Offset = "0x5453990", VA = "0x185454990", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x5453C50", Offset = "0x5452C50", VA = "0x185453C50", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x5455AA0", Offset = "0x5454AA0", VA = "0x185455AA0", Slot = "9")]
			public Task<Result<None, WENLUTALDTF>> PUTQOIXIDYP(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x5454050", Offset = "0x5453050", VA = "0x185454050")]
			public bool UOZFRAUOORR([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x5452C40", Offset = "0x5451C40", VA = "0x185452C40")]
			public bool IDQORPWWLCG([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x54560A0", Offset = "0x54550A0", VA = "0x1854560A0", Slot = "34")]
			public void TOGABTLIMPE(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x5456AD0", Offset = "0x5455AD0", VA = "0x185456AD0", Slot = "35")]
			public Task XUOAWGTHZFA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x5455300", Offset = "0x5454300", VA = "0x185455300", Slot = "36")]
			[AsyncStateMachine(typeof(KLVIYETWZOR<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, WENLUTALDTF>> MXWQIFQJOHX(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "119")]
			public virtual void MTCANDERELQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xE29A00", Offset = "0xE28A00", VA = "0x180E29A00")]
			protected void NYWUAGMIXTY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x1ED5960", Offset = "0x1ED4960", VA = "0x181ED5960")]
			protected void QLFQMADWAFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x1EB1440", Offset = "0x1EB0440", VA = "0x181EB1440")]
			private void PWYBAJBAXHN([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x5456950", Offset = "0x5455950", VA = "0x185456950", Slot = "122")]
			public virtual Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> WZAWIAUKFGU(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x54567A0", Offset = "0x54557A0", VA = "0x1854567A0", Slot = "123")]
			public virtual Task<Result<None, WENLUTALDTF>> WOUPKRCEETZ(Id32<JPZDQKXUTWI> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "124")]
			public virtual void XEVVQFJYPHF(Id32<JPZDQKXUTWI> sourceId, Id32<JPZDQKXUTWI> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x5454080", Offset = "0x5453080", VA = "0x185454080", Slot = "125")]
			public virtual IEnumerable<PQYWNUACEKJ> GBONWSLYBOA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x54539E0", Offset = "0x54529E0", VA = "0x1854539E0", Slot = "126")]
			public Result<None, WENLUTALDTF> CSLIRHFXVBP(string a)
			{
				return default(Result<None, WENLUTALDTF>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x5454480", Offset = "0x5453480", VA = "0x185454480", Slot = "50")]
			public bool IULGNUHGZEN([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x5453220", Offset = "0x5452220", VA = "0x185453220")]
			public bool ATNZPSBXKWO([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "128")]
			public virtual void MBQDFIGVYHS(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "129")]
			public virtual OLKRNLCWDIX DTQZTNWAYNK([In] RRHRQUJCQYK audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x5453AD0", Offset = "0x5452AD0", VA = "0x185453AD0")]
			protected void DGPOTXFXSTQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x54552C0", Offset = "0x54542C0", VA = "0x1854552C0", Slot = "134")]
			protected virtual bool MBVVBRBIDHF(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x5455C10", Offset = "0x5454C10", VA = "0x185455C10", Slot = "96")]
			public bool SOVKFZNKNRH(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "135")]
			protected virtual bool TDMMHQANVXG(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected virtual void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x5455D00", Offset = "0x5454D00", VA = "0x185455D00")]
			protected void TKMHNPAVGXQ(UPRRQQRREYW a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, WENLUTALDTF>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x54550C0", Offset = "0x54540C0", VA = "0x1854550C0")]
			protected void MAUTKITQZTG(UPRRQQRREYW a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x54545A0", Offset = "0x54535A0", VA = "0x1854545A0", Slot = "146")]
			protected virtual void IVLYYJIYLTT(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x5455570", Offset = "0x5454570", VA = "0x185455570", Slot = "90")]
			public void ODXWDJDFAFG(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x5454920", Offset = "0x5453920", VA = "0x185454920", Slot = "91")]
			public CircuitsRigidTransform IYEQNIJEYVL()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "149")]
			public virtual bool DATVROKQPSF(Id32<JPZDQKXUTWI> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x5453C30", Offset = "0x5452C30", VA = "0x185453C30")]
			private void DJSGUJPGDBC([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x5455000", Offset = "0x5454000", VA = "0x185455000")]
			private void LVVYPZQSLUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0xE29A00", Offset = "0xE28A00", VA = "0x180E29A00", Slot = "97")]
			private void MYLCPARANFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x5452C70", Offset = "0x5451C70", VA = "0x185452C70", Slot = "99")]
			private void AKDKJQTQAXT(Id32<JPZDQKXUTWI> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x3D7DE50", Offset = "0x3D7CE50", VA = "0x183D7DE50", Slot = "101")]
			private void MEITFEZGIKC(Id32<JPZDQKXUTWI> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x5454E00", Offset = "0x5453E00", VA = "0x185454E00", Slot = "103")]
			private void JWGVVIAVTMA(Id32<JPZDQKXUTWI> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x5456280", Offset = "0x5455280", VA = "0x185456280", Slot = "104")]
			private void VONBCZHXCPG(Id32<JPZDQKXUTWI> sourceId, Id32<JPZDQKXUTWI> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x5455BD0", Offset = "0x5454BD0", VA = "0x185455BD0", Slot = "105")]
			private void RMXXLPKZBPP(Id32<JPZDQKXUTWI> sourceId, Id32<JPZDQKXUTWI> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x1505560", Offset = "0x1504560", VA = "0x181505560", Slot = "98")]
			private void NPODXQRNZKY(Id32<JPZDQKXUTWI> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x5455680", Offset = "0x5454680", VA = "0x185455680", Slot = "100")]
			private void PITTTKWFCEZ(Id32<JPZDQKXUTWI> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x5456CF0", Offset = "0x5455CF0", VA = "0x185456CF0", Slot = "102")]
			private void ZGKMDYATMCD(Id32<JPZDQKXUTWI> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x5455BF0", Offset = "0x5454BF0", VA = "0x185455BF0", Slot = "106")]
			private void RRTBCJNLKEJ(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x5455450", Offset = "0x5454450", VA = "0x185455450", Slot = "150")]
			[AsyncStateMachine(typeof(KLVIYETWZOR<>.<RequestNameChange>d__224))]
			public Task<Result<None, WENLUTALDTF>> MYOCADFAJNJ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x5454D70", Offset = "0x5453D70", VA = "0x185454D70", Slot = "57")]
			private void JWBPWUKOXFH(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x5453710", Offset = "0x5452710", VA = "0x185453710", Slot = "58")]
			private void BTQLFKCEWEO(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x5454050", Offset = "0x5453050", VA = "0x185454050", Slot = "30")]
			private bool FNYBWMBQOVM([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x5452C40", Offset = "0x5451C40", VA = "0x185452C40", Slot = "32")]
			private bool AILQYSOHTJF([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x54539C0", Offset = "0x54529C0", VA = "0x1854539C0", Slot = "51")]
			private bool CRPWYAUAKFJ([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xAD82C0", Offset = "0xAD72C0", VA = "0x180AD82C0")]
			[CompilerGenerated]
			private string JNFHCXXFIOX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x5454C00", Offset = "0x5453C00", VA = "0x185454C00")]
			[CompilerGenerated]
			private void JNAAFRDHZDO(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class XQHJLXDXMJC : RMUYWMZQYJZ<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0xCB13B0", Offset = "0xCB03B0", VA = "0x180CB13B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x28F0900", Offset = "0x28EF900", VA = "0x1828F0900")]
			public XQHJLXDXMJC(UOILJAPMYSC a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class FRRNZKXRZQW : KLVIYETWZOR<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class ZKMPBACDFNK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> HGNQFQYAFCN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public FRRNZKXRZQW SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> XFYELIUBIQT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> ZEWPGKCHRGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZKMPBACDFNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> CRZAXRVQDNF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x28F3410", Offset = "0x28F2410", VA = "0x1828F3410")]
				internal int CRTUALBSUBW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x28F3A50", Offset = "0x28F2A50", VA = "0x1828F3A50")]
				internal void CSJOSFJKWJX(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x28DB9B0", Offset = "0x28DA9B0", VA = "0x1828DB9B0")]
			public FRRNZKXRZQW(UOILJAPMYSC a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x28DB6D0", Offset = "0x28DA6D0", VA = "0x1828DB6D0", Slot = "145")]
			protected sealed override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class NZAJKMVOOEM : BTHOSFIMDYS<LZMAONPIYRD>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x28E0D50", Offset = "0x28DFD50", VA = "0x1828E0D50")]
			public NZAJKMVOOEM(UOILJAPMYSC a, LZMAONPIYRD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class XRYWXUQEDPY : KLVIYETWZOR<YGPXJZTOEOX>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public XRYWXUQEDPY SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x28DCA90", Offset = "0x28DBA90", VA = "0x1828DCA90")]
				internal bool CRZAXRVQDNF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x28DC540", Offset = "0x28DB540", VA = "0x1828DC540")]
				internal void CRTUALBSUBW(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x28F0B30", Offset = "0x28EFB30", VA = "0x1828F0B30")]
			public XRYWXUQEDPY(UOILJAPMYSC a, YGPXJZTOEOX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x28F0960", Offset = "0x28EF960", VA = "0x1828F0960", Slot = "145")]
			protected sealed override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class VUMKRLAAXAD : KLVIYETWZOR<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class ZKMPBACDFNK
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000CD")]
				private struct <<BuildConfigMenuInternal>b__4>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000258")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000259")]
					public AsyncTaskMethodBuilder<bool> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x400025A")]
					public ZKMPBACDFNK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F5")]
					[Cpp2IlInjected.Address(RVA = "0x28ED7F0", Offset = "0x28EC7F0", VA = "0x1828ED7F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F6")]
					[Cpp2IlInjected.Address(RVA = "0x28EDA20", Offset = "0x28ECA20", VA = "0x1828EDA20", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> RNOXMUXFFIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public VUMKRLAAXAD SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> GTYVSTJOIEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> EXRXDXXXKAD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZKMPBACDFNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> CRZAXRVQDNF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x28F3250", Offset = "0x28F2250", VA = "0x1828F3250")]
				internal int CRTUALBSUBW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x28F3D20", Offset = "0x28F2D20", VA = "0x1828F3D20")]
				internal void CSJOSFJKWJX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x28F3850", Offset = "0x28F2850", VA = "0x1828F3850")]
				internal int CSEHUYPNMYO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x28F3F10", Offset = "0x28F2F10", VA = "0x1828F3F10")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> CSUCMSXFPGP(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x28F45E0", Offset = "0x28F35E0", VA = "0x1828F45E0")]
				internal int FRNLASYEQJR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x28F4BB0", Offset = "0x28F3BB0", VA = "0x1828F4BB0")]
				internal void ZRTRIFAJSSH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x28F4B60", Offset = "0x28F3B60", VA = "0x1828F4B60")]
				internal int ZROKKYGMJGY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x28F4C90", Offset = "0x28F3C90", VA = "0x1828F4C90")]
				internal void ZSEFCSOELOZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x28F4C40", Offset = "0x28F3C40", VA = "0x1828F4C40")]
				internal int ZRYYFLUHCDQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x28F4D70", Offset = "0x28F3D70", VA = "0x1828F4D70")]
				internal void ZSOSXGBZELR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x28F4D20", Offset = "0x28F3D20", VA = "0x1828F4D20")]
				internal int ZSJLZZIBVAI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x28F4E00", Offset = "0x28F3E00", VA = "0x1828F4E00")]
				internal void ZSZGRTPTXIJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x28F3EC0", Offset = "0x28F2EC0", VA = "0x1828F3EC0")]
				internal float CSOVPMDIFVG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x28F4060", Offset = "0x28F3060", VA = "0x1828F4060")]
				internal void CTEQHGLAIDH(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x28F4010", Offset = "0x28F3010", VA = "0x1828F4010")]
				internal float CSZJJZRCYRY()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x28F4140", Offset = "0x28F3140", VA = "0x1828F4140")]
				internal void CTPEBTYVAZZ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x28F40F0", Offset = "0x28F30F0", VA = "0x1828F40F0")]
				internal bool CTJXENEXROQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x28F41D0", Offset = "0x28F31D0", VA = "0x1828F41D0")]
				internal void FPSAZKBCJLO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x28F4260", Offset = "0x28F3260", VA = "0x1828F4260")]
				internal int FPXHWQUZSWX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x28F42B0", Offset = "0x28F32B0", VA = "0x1828F42B0")]
				internal void FQCOTXOXCIG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x28F4340", Offset = "0x28F3340", VA = "0x1828F4340")]
				internal float FQHVREIULTP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x28F4390", Offset = "0x28F3390", VA = "0x1828F4390")]
				internal void FQNCOLCRVEY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x28F4420", Offset = "0x28F3420", VA = "0x1828F4420")]
				internal float FQSJLRWPEQH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x28F4470", Offset = "0x28F3470", VA = "0x1828F4470")]
				internal void FQXQIYQMOBQ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0x28F4500", Offset = "0x28F3500", VA = "0x1828F4500")]
				internal bool FRCXGFKJXMZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x28F4550", Offset = "0x28F3550", VA = "0x1828F4550")]
				internal void FRIEDMEHGYI(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x28EF9A0", Offset = "0x28EE9A0", VA = "0x1828EF9A0")]
			public VUMKRLAAXAD(UOILJAPMYSC a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x28EE8A0", Offset = "0x28ED8A0", VA = "0x1828EE8A0", Slot = "145")]
			protected sealed override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class SPYUENDWVZI : QRDIPWEKUPP<RecNetImageNode>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000CF")]
			[CompilerGenerated]
			private struct <<AddHomeValueSetting>b__1_1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400025D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400025E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400025F")]
				public SPYUENDWVZI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004FB")]
				[Cpp2IlInjected.Address(RVA = "0x28ED020", Offset = "0x28EC020", VA = "0x1828ED020", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x28E71D0", Offset = "0x28E61D0", VA = "0x1828E71D0")]
			public SPYUENDWVZI(UOILJAPMYSC a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x28E6D00", Offset = "0x28E5D00", VA = "0x1828E6D00", Slot = "151")]
			protected override void GQGAZNHWGEO(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x28E7030", Offset = "0x28E6030", VA = "0x1828E7030")]
			[CompilerGenerated]
			private string? YOLMXFVOYNQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x28E7100", Offset = "0x28E6100", VA = "0x1828E7100")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void YOQTUMPMHYZ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class NNKLACTSBLY<a> : KLVIYETWZOR<a> where a : notnull, REFNMXRHZSW
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class ZOAXUNZKSXA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> RNOXMUXFFIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public NNKLACTSBLY<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> GTYVSTJOIEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> EXRXDXXXKAD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType SHKLNRFAHQN;

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZOAXUNZKSXA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> CRZAXRVQDNF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x3F47820", Offset = "0x3F46820", VA = "0x183F47820")]
				internal int CRTUALBSUBW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x3F47990", Offset = "0x3F46990", VA = "0x183F47990")]
				internal void CSJOSFJKWJX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x3F47940", Offset = "0x3F46940", VA = "0x183F47940")]
				internal void CSEHUYPNMYO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x3F47BE0", Offset = "0x3F46BE0", VA = "0x183F47BE0")]
				internal void CSUCMSXFPGP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x3F47B80", Offset = "0x3F46B80", VA = "0x183F47B80")]
				internal bool CSOVPMDIFVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x3F47CF0", Offset = "0x3F46CF0", VA = "0x183F47CF0")]
				internal void CTEQHGLAIDH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x3F47B80", Offset = "0x3F46B80", VA = "0x183F47B80")]
				internal bool CSZJJZRCYRY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x3F47DD0", Offset = "0x3F46DD0", VA = "0x183F47DD0")]
				internal float CTPEBTYVAZZ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x3F47D40", Offset = "0x3F46D40", VA = "0x183F47D40")]
				internal void CTJXENEXROQ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x3F48890", Offset = "0x3F47890", VA = "0x183F48890")]
				internal float FPSAZKBCJLO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x3F488C0", Offset = "0x3F478C0", VA = "0x183F488C0")]
				internal void FPXHWQUZSWX(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x3F48950", Offset = "0x3F47950", VA = "0x183F48950")]
				internal float FQCOTXOXCIG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x3F48980", Offset = "0x3F47980", VA = "0x183F48980")]
				internal void FQHVREIULTP(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType FLMUMUJCRKF
			{
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x5181950", Offset = "0x5180950", VA = "0x185181950")]
			public NNKLACTSBLY(UOILJAPMYSC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x5B68450", Offset = "0x5B67450", VA = "0x185B68450", Slot = "145")]
			protected sealed override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class JJOPHBIACFU : KLVIYETWZOR<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0xCB62E0", Offset = "0xCB52E0", VA = "0x180CB62E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x28DDE80", Offset = "0x28DCE80", VA = "0x1828DDE80")]
			public JJOPHBIACFU(UOILJAPMYSC a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class ZYWGNNDWXAT : PJSMULPQPQD<HFLNMJQUJEV>
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x28F5100", Offset = "0x28F4100", VA = "0x1828F5100")]
			public ZYWGNNDWXAT(UOILJAPMYSC a, HFLNMJQUJEV b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class GYHGTQMWMQL : PJSMULPQPQD<QXLVUXVRZHG>
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x28DBCF0", Offset = "0x28DACF0", VA = "0x1828DBCF0")]
			public GYHGTQMWMQL(UOILJAPMYSC a, QXLVUXVRZHG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class PJSMULPQPQD<a> : KLVIYETWZOR<a> where a : notnull, JBARVCWOVHT
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000D6")]
			[CompilerGenerated]
			private struct <<BuildConfigMenuInternal>b__8_1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026C")]
				public PJSMULPQPQD<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0x3D09470", Offset = "0x3D08470", VA = "0x183D09470", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051D")]
				[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class EKVYHUESGOB
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000D9")]
				private struct <<BuildConfigMenuInternal>b__11>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000275")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000276")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000277")]
					public EKVYHUESGOB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x3D08140", Offset = "0x3D07140", VA = "0x183D08140", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DA")]
				private struct <<BuildConfigMenuInternal>b__12>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027B")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027C")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027D")]
					public EKVYHUESGOB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x3D08520", Offset = "0x3D07520", VA = "0x183D08520", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DB")]
				private struct <<BuildConfigMenuInternal>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027F")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000280")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000281")]
					public EKVYHUESGOB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x3D08DA0", Offset = "0x3D07DA0", VA = "0x183D08DA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DC")]
				private struct <<BuildConfigMenuInternal>b__8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000285")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000286")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000287")]
					public EKVYHUESGOB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000533")]
					[Cpp2IlInjected.Address(RVA = "0x3D09180", Offset = "0x3D08180", VA = "0x183D09180", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000534")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int EGJQZYNDVNP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry FLQNIFDKFIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public PJSMULPQPQD<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<GAOEGFJDZSW, bool> OUMOIWHAFZA;

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public EKVYHUESGOB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0x48C0220", Offset = "0x48BF220", VA = "0x1848C0220")]
				internal bool CSEHUYPNMYO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x48C0280", Offset = "0x48BF280", VA = "0x1848C0280")]
				internal void CSUCMSXFPGP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
				internal string CSOVPMDIFVG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x48C0400", Offset = "0x48BF400", VA = "0x1848C0400")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.EKVYHUESGOB.<<BuildConfigMenuInternal>b__6>d))]
				internal void CTEQHGLAIDH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x48C02F0", Offset = "0x48BF2F0", VA = "0x1848C02F0")]
				internal int CSZJJZRCYRY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0x48C06D0", Offset = "0x48BF6D0", VA = "0x1848C06D0")]
				internal bool FQHVREIULTP(GAOEGFJDZSW a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x48C04C0", Offset = "0x48BF4C0", VA = "0x1848C04C0")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.EKVYHUESGOB.<<BuildConfigMenuInternal>b__8>d))]
				internal void CTPEBTYVAZZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
				internal string FPSAZKBCJLO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0x48C0570", Offset = "0x48BF570", VA = "0x1848C0570")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.EKVYHUESGOB.<<BuildConfigMenuInternal>b__11>d))]
				internal void FPXHWQUZSWX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x48C0630", Offset = "0x48BF630", VA = "0x1848C0630")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.EKVYHUESGOB.<<BuildConfigMenuInternal>b__12>d))]
				internal void FQCOTXOXCIG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class RMSRXUIDDBM
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DE")]
				private struct <<AddConstraintOptions>b__10>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028C")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028D")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028E")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x3D02460", Offset = "0x3D01460", VA = "0x183D02460", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DF")]
				private struct <<AddConstraintOptions>b__13>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000291")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000292")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000293")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x3D027F0", Offset = "0x3D017F0", VA = "0x183D027F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E0")]
				private struct <<AddConstraintOptions>b__15>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000296")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000297")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000298")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000299")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x3D02BC0", Offset = "0x3D01BC0", VA = "0x183D02BC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E1")]
				private struct <<AddConstraintOptions>b__18>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029B")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029C")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029D")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x3D031A0", Offset = "0x3D021A0", VA = "0x183D031A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E2")]
				private struct <<AddConstraintOptions>b__20>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A0")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A1")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A2")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x3D03430", Offset = "0x3D02430", VA = "0x183D03430", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E3")]
				private struct <<AddConstraintOptions>b__23>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A5")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A6")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A7")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x3D037C0", Offset = "0x3D027C0", VA = "0x183D037C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E4")]
				private struct <<AddConstraintOptions>b__26>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AA")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AB")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AC")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x3D03B50", Offset = "0x3D02B50", VA = "0x183D03B50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E5")]
				private struct <<AddConstraintOptions>b__28>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AF")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B0")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B1")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x3D03DE0", Offset = "0x3D02DE0", VA = "0x183D03DE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				private struct <<AddConstraintOptions>b__31>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B4")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B5")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B6")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x3D04170", Offset = "0x3D03170", VA = "0x183D04170", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E7")]
				private struct <<AddConstraintOptions>b__34>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B9")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BA")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BB")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x3D04500", Offset = "0x3D03500", VA = "0x183D04500", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E8")]
				private struct <<AddConstraintOptions>b__37>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C0")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x3D04890", Offset = "0x3D03890", VA = "0x183D04890", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				private struct <<AddConstraintOptions>b__39>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C3")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C4")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C5")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x3D04B20", Offset = "0x3D03B20", VA = "0x183D04B20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000EA")]
				private struct <<AddConstraintOptions>b__3>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C8")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C9")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CA")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x3D04EB0", Offset = "0x3D03EB0", VA = "0x183D04EB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000EB")]
				private struct <<AddConstraintOptions>b__42>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CD")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x3D05140", Offset = "0x3D04140", VA = "0x183D05140", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				private struct <<AddConstraintOptions>b__45>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D4")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x3D054D0", Offset = "0x3D044D0", VA = "0x183D054D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000ED")]
				private struct <<AddConstraintOptions>b__5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D7")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D8")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x3D05860", Offset = "0x3D04860", VA = "0x183D05860", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000EE")]
				private struct <<AddConstraintOptions>b__8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DC")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DD")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DE")]
					public RMSRXUIDDBM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000585")]
					[Cpp2IlInjected.Address(RVA = "0x3D05BF0", Offset = "0x3D04BF0", VA = "0x183D05BF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000586")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public PJSMULPQPQD<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int EGJQZYNDVNP;

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public RMSRXUIDDBM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DC20", Offset = "0x5E7CC20", VA = "0x185E7DC20")]
				internal bool LUNIMFFCOPB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DBB0", Offset = "0x5E7CBB0", VA = "0x185E7DBB0")]
				internal void LUIBOYLFFDS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D3C0", Offset = "0x5E7C3C0", VA = "0x185E7D3C0")]
				internal object DGZFVIQLCZQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D460", Offset = "0x5E7C460", VA = "0x185E7D460")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__13>d))]
				internal void DHEMSPKIMKZ(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D010", Offset = "0x5E7C010", VA = "0x185E7D010")]
				internal string DFTQLUBAYJO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D0B0", Offset = "0x5E7C0B0", VA = "0x185E7D0B0")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__15>d))]
				internal void DFYXJAUYHUX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D170", Offset = "0x5E7C170", VA = "0x185E7D170")]
				internal bool DGEEGHOVRGG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D1F0", Offset = "0x5E7C1F0", VA = "0x185E7D1F0")]
				internal bool DGJLDOITARP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x5E7CEB0", Offset = "0x5E7BEB0", VA = "0x185E7CEB0")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__18>d))]
				internal void DEYOWSZLMQE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x5E7CF60", Offset = "0x5E7BF60", VA = "0x185E7CF60")]
				internal int DFDVTZTIWBN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E820", Offset = "0x5E7D820", VA = "0x185E7E820")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__20>d))]
				internal void XCDVTHPEDKP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E790", Offset = "0x5E7D790", VA = "0x185E7E790")]
				internal bool XBYOWAVGTZG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E990", Offset = "0x5E7D990", VA = "0x185E7E990")]
				internal float XCOJNVCYWHH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E8D0", Offset = "0x5E7D8D0", VA = "0x185E7E8D0")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__23>d))]
				internal void XCJCQOJBMVY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E5C0", Offset = "0x5E7D5C0", VA = "0x185E7E5C0")]
				internal bool XBIUEGNORRF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E530", Offset = "0x5E7D530", VA = "0x185E7E530")]
				internal bool XBDNGZTRIFW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E6E0", Offset = "0x5E7D6E0", VA = "0x185E7E6E0")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__26>d))]
				internal void XBTHYUBJKNX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E650", Offset = "0x5E7D650", VA = "0x185E7E650")]
				internal int XBOBBNHMBCO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x5E7EAD0", Offset = "0x5E7DAD0", VA = "0x185E7EAD0")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__28>d))]
				internal void XDTYXJSJAXJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x5E7EA40", Offset = "0x5E7DA40", VA = "0x185E7EA40")]
				internal bool XDOSACYLRMA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E020", Offset = "0x5E7D020", VA = "0x185E7E020")]
				internal float QBMQUPHBNSG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E0B0", Offset = "0x5E7D0B0", VA = "0x185E7E0B0")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__31>d))]
				internal void QBRXRWAYXDP(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DF10", Offset = "0x5E7CF10", VA = "0x185E7DF10")]
				internal bool QBCDABTGUVO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DFA0", Offset = "0x5E7CFA0", VA = "0x185E7DFA0")]
				internal bool QBHJXINEEGX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E2B0", Offset = "0x5E7D2B0", VA = "0x185E7E2B0")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__34>d))]
				internal void QCHSJQIQZLQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E360", Offset = "0x5E7D360", VA = "0x185E7E360")]
				internal bool QCMZGXCOIWZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E170", Offset = "0x5E7D170", VA = "0x185E7E170")]
				internal bool QBXEPCUWGOY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E200", Offset = "0x5E7D200", VA = "0x185E7E200")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__37>d))]
				internal void QCCLMJOTQAH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E3F0", Offset = "0x5E7D3F0", VA = "0x185E7E3F0")]
				internal int QDCTYRKGLFA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x5E7E480", Offset = "0x5E7D480", VA = "0x185E7E480")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__39>d))]
				internal void QDIAVYEDUQJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D700", Offset = "0x5E7C700", VA = "0x185E7D700")]
				internal bool IEPDESEIOZX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D670", Offset = "0x5E7C670", VA = "0x185E7D670")]
				internal float IEJWHLKLFOO()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D5B0", Offset = "0x5E7C5B0", VA = "0x185E7D5B0")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__42>d))]
				internal void IEEPKEQNWDF(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D520", Offset = "0x5E7C520", VA = "0x185E7D520")]
				internal bool IDZIMXWQMRW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D8D0", Offset = "0x5E7C8D0", VA = "0x185E7D8D0")]
				internal bool IFKETTFYATH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D820", Offset = "0x5E7C820", VA = "0x185E7D820")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__45>d))]
				internal void IFEXWMMARHY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D790", Offset = "0x5E7C790", VA = "0x185E7D790")]
				internal bool IEZQZFSDHWP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DD30", Offset = "0x5E7CD30", VA = "0x185E7DD30")]
				internal bool LUXWGSSXHLT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DC80", Offset = "0x5E7CC80", VA = "0x185E7DC80")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__3>d))]
				internal void LUSPJLYZYAK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DA00", Offset = "0x5E7CA00", VA = "0x185E7DA00")]
				internal int LTSGXEDNCVR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D950", Offset = "0x5E7C950", VA = "0x185E7D950")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__5>d))]
				internal void LTMZZXJPTKI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DB20", Offset = "0x5E7CB20", VA = "0x185E7DB20")]
				internal bool LUCURRRHVSJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DA90", Offset = "0x5E7CA90", VA = "0x185E7DA90")]
				internal bool LTXNUKXKMHA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DE60", Offset = "0x5E7CE60", VA = "0x185E7DE60")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__8>d))]
				internal void LWDLQHIHMBV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x5E7DDC0", Offset = "0x5E7CDC0", VA = "0x185E7DDC0")]
				internal int LVYETAOKCQM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D280", Offset = "0x5E7C280", VA = "0x185E7D280")]
				[AsyncStateMachine(typeof(PJSMULPQPQD<>.RMSRXUIDDBM.<<AddConstraintOptions>b__10>d))]
				internal void DGOSAVCQKCY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D330", Offset = "0x5E7C330", VA = "0x185E7D330")]
				internal bool DGTYYBWNTOH()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> YFKESLOSGHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> DFCWYRXQYTE;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000516")]
				[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<GAOEGFJDZSW> PBSEOMORQBW
			{
				[Cpp2IlInjected.Token(Token = "0x6000517")]
				[Cpp2IlInjected.Address(RVA = "0x5DC3800", Offset = "0x5DC2800", VA = "0x185DC3800")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x5DC50C0", Offset = "0x5DC40C0", VA = "0x185DC50C0")]
			public PJSMULPQPQD(UOILJAPMYSC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x5DC26E0", Offset = "0x5DC16E0", VA = "0x185DC26E0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x5DC2790", Offset = "0x5DC1790", VA = "0x185DC2790", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x5DC3850", Offset = "0x5DC2850", VA = "0x185DC3850")]
			private NKJDITYMVKI QNQOMVYEFTH(UPRRQQRREYW a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x5DC4FB0", Offset = "0x5DC3FB0", VA = "0x185DC4FB0")]
			[AsyncStateMachine(typeof(PJSMULPQPQD<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void XWYITODSOBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x5DC5060", Offset = "0x5DC4060", VA = "0x185DC5060")]
			[CompilerGenerated]
			private bool XXDPQUXPXMO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class VDQGATDCSBH : KLVIYETWZOR<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class MJLEUFQBZLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public VDQGATDCSBH SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public MJLEUFQBZLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x28DFE20", Offset = "0x28DEE20", VA = "0x1828DFE20")]
				internal int CRTUALBSUBW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x28DFF90", Offset = "0x28DEF90", VA = "0x1828DFF90")]
				internal void CSJOSFJKWJX(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? JZYXNETFNCU;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x28EE830", Offset = "0x28ED830", VA = "0x1828EE830")]
			public VDQGATDCSBH(UOILJAPMYSC a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x28EE4E0", Offset = "0x28ED4E0", VA = "0x1828EE4E0", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class HFIFSZGXFVB : NNKLACTSBLY<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType FLMUMUJCRKF
			{
				[Cpp2IlInjected.Token(Token = "0x6000590")]
				[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x28DBD50", Offset = "0x28DAD50", VA = "0x1828DBD50")]
			public HFIFSZGXFVB(UOILJAPMYSC a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class JLSDRPEHNAY : BTHOSFIMDYS<JDQWCHGYZRX>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000591")]
				[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x28DDEF0", Offset = "0x28DCEF0", VA = "0x1828DDEF0")]
			public JLSDRPEHNAY(UOILJAPMYSC a, JDQWCHGYZRX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class JFXJMONJBOT : BTHOSFIMDYS<RKFHTLUWZOE>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000594")]
				[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x28DDE20", Offset = "0x28DCE20", VA = "0x1828DDE20")]
			public JFXJMONJBOT(UOILJAPMYSC a, RKFHTLUWZOE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class LNHOTIVKQRT : QRDIPWEKUPP<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000F7")]
				private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E8")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E9")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40002EA")]
					public HQENANIBZDY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600059B")]
					[Cpp2IlInjected.Address(RVA = "0x28ECD10", Offset = "0x28EBD10", VA = "0x1828ECD10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059C")]
					[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public LNHOTIVKQRT SULNKEFFSGR;

				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x28DD240", Offset = "0x28DC240", VA = "0x1828DD240")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void DVMQUSIPWTM(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x28DF1A0", Offset = "0x28DE1A0", VA = "0x1828DF1A0")]
			public LNHOTIVKQRT(UOILJAPMYSC a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x28DEEA0", Offset = "0x28DDEA0", VA = "0x1828DEEA0", Slot = "151")]
			protected override void GQGAZNHWGEO(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class OFURVJIVUJG : NNKLACTSBLY<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType FLMUMUJCRKF
			{
				[Cpp2IlInjected.Token(Token = "0x600059E")]
				[Cpp2IlInjected.Address(RVA = "0xBD3770", Offset = "0xBD2770", VA = "0x180BD3770", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x28E0DB0", Offset = "0x28DFDB0", VA = "0x1828E0DB0")]
			public OFURVJIVUJG(UOILJAPMYSC a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class NTFSQLOQUIF : KLVIYETWZOR<SFWBEYSFALB>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0xCB98F0", Offset = "0xCB88F0", VA = "0x180CB98F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x28E0CE0", Offset = "0x28DFCE0", VA = "0x1828E0CE0")]
			public NTFSQLOQUIF(UOILJAPMYSC a, SFWBEYSFALB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class IKDCEQIHFDO : KLVIYETWZOR<OWDWCAIBQLT>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A3")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool GFDBLYOGKCZ
			{
				[Cpp2IlInjected.Token(Token = "0x60005A4")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x28DDDB0", Offset = "0x28DCDB0", VA = "0x1828DDDB0")]
			public IKDCEQIHFDO(UOILJAPMYSC a, OWDWCAIBQLT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x28DDA60", Offset = "0x28DCA60", VA = "0x1828DDA60", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x28DDD70", Offset = "0x28DCD70", VA = "0x1828DDD70")]
			private int SJLQQQTZOBQ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x28DD9F0", Offset = "0x28DC9F0", VA = "0x1828DD9F0")]
			private void ARZGDZJSTNA(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class PKUXJJFYXBF : WVDWHQJQIGC
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x28E0E70", Offset = "0x28DFE70", VA = "0x1828E0E70")]
			public PKUXJJFYXBF(UOILJAPMYSC a, TYZPRJYTRRB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class NSQWYDEYMAZ : KLVIYETWZOR<BCVQYNFIDNM>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class ZKMPBACDFNK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public NSQWYDEYMAZ SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public ZKMPBACDFNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x28F3600", Offset = "0x28F2600", VA = "0x1828F3600")]
				internal int CRZAXRVQDNF()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x28F3370", Offset = "0x28F2370", VA = "0x1828F3370")]
				internal void CRTUALBSUBW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B1")]
				[Cpp2IlInjected.Address(RVA = "0x28F3E70", Offset = "0x28F2E70", VA = "0x1828F3E70")]
				internal int CSJOSFJKWJX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0x28F3930", Offset = "0x28F2930", VA = "0x1828F3930")]
				internal void CSEHUYPNMYO(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xB043E0", Offset = "0xB033E0", VA = "0x180B043E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x28E0C70", Offset = "0x28DFC70", VA = "0x1828E0C70")]
			public NSQWYDEYMAZ(UOILJAPMYSC a, BCVQYNFIDNM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x28E0960", Offset = "0x28DF960", VA = "0x1828E0960", Slot = "145")]
			protected sealed override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class WXFNJXLKMBY : QRDIPWEKUPP<ADVENQOGOLV>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x28EFA10", Offset = "0x28EEA10", VA = "0x1828EFA10")]
			public WXFNJXLKMBY(UOILJAPMYSC a, ADVENQOGOLV b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class QRDIPWEKUPP<a> : KLVIYETWZOR<a> where a : notnull, ADVENQOGOLV
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class EHHPOGHKTEL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public QRDIPWEKUPP<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public EHHPOGHKTEL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x48B5540", Offset = "0x48B4540", VA = "0x1848B5540")]
				internal bool CRZAXRVQDNF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x48B54B0", Offset = "0x48B44B0", VA = "0x1848B54B0")]
				internal void CRTUALBSUBW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x48B5600", Offset = "0x48B4600", VA = "0x1848B5600")]
				internal bool CSJOSFJKWJX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0x48B5570", Offset = "0x48B4570", VA = "0x1848B5570")]
				internal void CSEHUYPNMYO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x48B5630", Offset = "0x48B4630", VA = "0x1848B5630")]
				internal bool CSUCMSXFPGP()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class IAADXXIOWVK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public VVHHZIOZHKI SWAWXXEXJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public QRDIPWEKUPP<a> SULNKEFFSGR;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public IAADXXIOWVK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x517A1E0", Offset = "0x51791E0", VA = "0x18517A1E0")]
				internal void DVMQUSIPWTM(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0xBDB790", Offset = "0xBDA790", VA = "0x180BDB790", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x5E3A910", Offset = "0x5E39910", VA = "0x185E3A910", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E3A800", Offset = "0x5E39800", VA = "0x185E3A800")]
			protected QRDIPWEKUPP(UOILJAPMYSC a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x5E3A050", Offset = "0x5E39050", VA = "0x185E3A050", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x5E3A150", Offset = "0x5E39150", VA = "0x185E3A150", Slot = "145")]
			protected override void GFOUQRGMBHH(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x5E3A4D0", Offset = "0x5E394D0", VA = "0x185E3A4D0", Slot = "151")]
			protected virtual void GQGAZNHWGEO(UPRRQQRREYW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x5E3A7C0", Offset = "0x5E397C0", VA = "0x185E3A7C0", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x28D6340", Offset = "0x28D5340", VA = "0x1828D6340")]
		public static YYVRREXPLEY New(UOILJAPMYSC circuitsManager, TYZPRJYTRRB node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class JOYPMYCCQQI : XZKGHBWPPMK, IFKMKUBSZWF, ADJDNATJUCX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<JZMHXBKSKRV> EUJMTKWVNKX
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xC951D0", Offset = "0xC941D0", VA = "0x180C951D0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<JZMHXBKSKRV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<CCYGKVMNTMH> UABPADDJWWG
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x12A63B0", Offset = "0x12A53B0", VA = "0x1812A63B0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<CCYGKVMNTMH>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x2153600", Offset = "0x2152600", VA = "0x182153600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<DSRIXMVNJVY> ZHLWTKSQRWE
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x11DF960", Offset = "0x11DE960", VA = "0x1811DF960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<IBLIHIPUJYN> JVCKDADCBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x28DDF50", Offset = "0x28DCF50", VA = "0x1828DDF50", Slot = "22")]
			get
			{
				return default(Id32<IBLIHIPUJYN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x28DE2F0", Offset = "0x28DD2F0", VA = "0x1828DE2F0")]
		private JOYPMYCCQQI(UOILJAPMYSC a, TYZPRJYTRRB b, BYGUODQULIZ c, Id32<JPZDQKXUTWI> portGroupId, Id32<CCYGKVMNTMH> outputId, Id32<DSRIXMVNJVY> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x28DDFA0", Offset = "0x28DCFA0", VA = "0x1828DDFA0")]
		public static JOYPMYCCQQI New(UOILJAPMYSC circuitsManager, TYZPRJYTRRB node, BYGUODQULIZ output, Id32<JPZDQKXUTWI> portGroupId, Id32<DSRIXMVNJVY> outputDefId, Id32<CCYGKVMNTMH> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x2153600", Offset = "0x2152600", VA = "0x182153600")]
		internal void XNCSFCRGHAY(Id32<CCYGKVMNTMH> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class XZKGHBWPPMK : ADJDNATJUCX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private JBPPBFQJGTI? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x28DF200", Offset = "0x28DE200", VA = "0x1828DF200")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x28DF210", Offset = "0x28DE210", VA = "0x1828DF210")]
			public JBPPBFQJGTI ZMDMVCJIEMA(XZKGHBWPPMK a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly UOILJAPMYSC HHSEEZECAYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly TYZPRJYTRRB FYTUKZGWGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter TWYOFLWEAWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly ZFEJWTQREGB PODUMBBWOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<SIFOENWESLR> SFYEDSKGWYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<STHMSISMVOF> JQNPENWMPUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool HGWDQSGHCGI;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> SYIEMCBONOU
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x28F1780", Offset = "0x28F0780", VA = "0x1828F1780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind DEWWDDMWUIF
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xAE9570", Offset = "0xAE8570", VA = "0x180AE9570", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<YHQFEYRJQPY> NCYNZJTAPLW
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x28F1700", Offset = "0x28F0700", VA = "0x1828F1700", Slot = "6")]
			get
			{
				return default(Id32<YHQFEYRJQPY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<YHQFEYRJQPY> EFNCSGOLWCV
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x28F1750", Offset = "0x28F0750", VA = "0x1828F1750", Slot = "7")]
			get
			{
				return default(Id128<YHQFEYRJQPY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public GAOEGFJDZSW XFBNBDFXNJN
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x28F1730", Offset = "0x28F0730", VA = "0x1828F1730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public KDUAUZXMWOM MSKSAEQNIVW
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x28F0DB0", Offset = "0x28EFDB0", VA = "0x1828F0DB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected JBPPBFQJGTI WOGVOGMEAXR
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x28F0DB0", Offset = "0x28EFDB0", VA = "0x1828F0DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage LAOJZEUWRZP
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x28F22A0", Offset = "0x28F12A0", VA = "0x1828F22A0", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xAD32E0", Offset = "0xAD22E0", VA = "0x180AD32E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<QYHWLOYXTJM> ZUANMURWWDL
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x28F14D0", Offset = "0x28F04D0", VA = "0x1828F14D0", Slot = "9")]
			get
			{
				return default(Id128<QYHWLOYXTJM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<JPZDQKXUTWI> GIJWDDKKYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xC3AF70", Offset = "0xC39F70", VA = "0x180C3AF70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<JPZDQKXUTWI>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x1836E50", Offset = "0x1835E50", VA = "0x181836E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<IBLIHIPUJYN> JVCKDADCBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool FEKNTXPQSQB
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xCEB8E0", Offset = "0xCEA8E0", VA = "0x180CEB8E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x28F23E0", Offset = "0x28F13E0", VA = "0x1828F23E0")]
		protected XZKGHBWPPMK(UOILJAPMYSC a, TYZPRJYTRRB b, ZFEJWTQREGB c, Id32<JPZDQKXUTWI> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x28F0E40", Offset = "0x28EFE40", VA = "0x1828F0E40", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x28F0C50", Offset = "0x28EFC50", VA = "0x1828F0C50", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x28F0BA0", Offset = "0x28EFBA0", VA = "0x1828F0BA0", Slot = "14")]
		public void AJBMJJLQMWO(SIFOENWESLR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x28F0F20", Offset = "0x28EFF20", VA = "0x1828F0F20", Slot = "15")]
		public void JHUAJKCKXJS(STHMSISMVOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x28F11B0", Offset = "0x28F01B0", VA = "0x1828F11B0")]
		private bool KTONBTEFZTN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x28F18C0", Offset = "0x28F08C0", VA = "0x1828F18C0", Slot = "17")]
		public void XAAMFGMJJTG(YTNVHBLQUIV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x28F0FD0", Offset = "0x28EFFD0", VA = "0x1828F0FD0", Slot = "25")]
		protected virtual void JRTJHCQHGZU(YTNVHBLQUIV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x28F1030", Offset = "0x28F0030", VA = "0x1828F1030", Slot = "20")]
		private void JUZGBQZYREB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x28F1550", Offset = "0x28F0550", VA = "0x1828F1550")]
		private void PPDDYFRXXIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x28F2100", Offset = "0x28F1100", VA = "0x1828F2100")]
		private void YPSFQPAXIXE([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x28F14F0", Offset = "0x28F04F0", VA = "0x1828F14F0", Slot = "18")]
		public void NEKVZJUZJCP(SIFOENWESLR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x28F0D50", Offset = "0x28EFD50", VA = "0x1828F0D50", Slot = "19")]
		public void HXQBDQYTGXX(STHMSISMVOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xAD32E0", Offset = "0xAD22E0", VA = "0x180AD32E0")]
		internal void JOQLFUCXDGO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x28F0D30", Offset = "0x28EFD30", VA = "0x1828F0D30")]
		internal void FVZPQDMMXFH(MLJAAVCGGXT a, GAOEGFJDZSW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1836E50", Offset = "0x1835E50", VA = "0x181836E50")]
		internal void NQREFCZGZUY(Id32<JPZDQKXUTWI> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class RPUELYKVFON : BOUENRSVMUK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class GBPIGEAKVRX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public UOILJAPMYSC MKNJDHGQNKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public TYZPRJYTRRB FRFZLZEZYJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<JPZDQKXUTWI> TRLTSKQXENE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool LANGKSMJUNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool XQKEQFUAKRQ;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public GBPIGEAKVRX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x28DBAF0", Offset = "0x28DAAF0", VA = "0x1828DBAF0")]
			internal SQIEFOYBQJN YPCRSTMCYQN((int PortDescIndex, int PortIndex, PURXATKNAFM InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x28DBA20", Offset = "0x28DAA20", VA = "0x1828DBA20")]
			internal JOYPMYCCQQI YOXKVMSFPFE(BYGUODQULIZ a, int b)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[CompilerGenerated]
		private struct <AddInputPort>d__86 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x28E85B0", Offset = "0x28E75B0", VA = "0x1828E85B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x28E8A20", Offset = "0x28E7A20", VA = "0x1828E8A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[CompilerGenerated]
		private struct <RemoveInputDef>d__108 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<KRDUNWCYLJD> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x28E9CD0", Offset = "0x28E8CD0", VA = "0x1828E9CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x28EA020", Offset = "0x28E9020", VA = "0x1828EA020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[CompilerGenerated]
		private struct <RemoveInputPort>d__112 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x28EA090", Offset = "0x28E9090", VA = "0x1828EA090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x28EA510", Offset = "0x28E9510", VA = "0x1828EA510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[CompilerGenerated]
		private struct <RemoveOutputDef>d__109 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<DSRIXMVNJVY> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x28EA580", Offset = "0x28E9580", VA = "0x1828EA580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x28EA8D0", Offset = "0x28E98D0", VA = "0x1828EA8D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[CompilerGenerated]
		private struct <Rename>d__113 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x28EB100", Offset = "0x28EA100", VA = "0x1828EB100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x28EB450", Offset = "0x28EA450", VA = "0x1828EB450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[CompilerGenerated]
		private struct <RenameInputDef>d__114 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<KRDUNWCYLJD> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x28EA940", Offset = "0x28E9940", VA = "0x1828EA940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x28EACB0", Offset = "0x28E9CB0", VA = "0x1828EACB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[CompilerGenerated]
		private struct <RenameOutputDef>d__115 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<DSRIXMVNJVY> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x28EAD20", Offset = "0x28E9D20", VA = "0x1828EAD20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x28EB090", Offset = "0x28EA090", VA = "0x1828EB090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[CompilerGenerated]
		private struct <RetypeInputDef>d__116 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public NIWXUTPBRAL type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<KRDUNWCYLJD> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x28EB4C0", Offset = "0x28EA4C0", VA = "0x1828EB4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x28EB860", Offset = "0x28EA860", VA = "0x1828EB860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private struct <RetypeOutputDef>d__117 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public NIWXUTPBRAL type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<DSRIXMVNJVY> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x28EB8D0", Offset = "0x28EA8D0", VA = "0x1828EB8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x28EBC70", Offset = "0x28EAC70", VA = "0x1828EBC70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[CompilerGenerated]
		private struct <SetInputDefIndex>d__110 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<KRDUNWCYLJD> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<KRDUNWCYLJD> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x28EBCE0", Offset = "0x28EACE0", VA = "0x1828EBCE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x28EC040", Offset = "0x28EB040", VA = "0x1828EC040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		[CompilerGenerated]
		private struct <SetOutputDefIndex>d__111 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public RPUELYKVFON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<DSRIXMVNJVY> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<DSRIXMVNJVY> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private QDTLTHTSXNH <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x28EC0B0", Offset = "0x28EB0B0", VA = "0x1828EC0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x28EC410", Offset = "0x28EB410", VA = "0x1828EC410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool ZQOUCSKNTFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly UOILJAPMYSC HHSEEZECAYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool SLHFKLGYSGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<FTMQHXHFOAQ, SQIEFOYBQJN> CTVALWSLFEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<FTMQHXHFOAQ, YKZVLCJWURS> QLCUCIFAAUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly TYZPRJYTRRB FYTUKZGWGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<CCYGKVMNTMH, JOYPMYCCQQI> UOBMEIMRNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<CCYGKVMNTMH, IFKMKUBSZWF> WOOMQDMIOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? CXSKNZTCKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly RYAFFIWWYUG RGLPSJQLOUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<JPZDQKXUTWI> DPGTRMIGBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool PFRORHUHUSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? NZXGBVVJXGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? URYKSDSJIRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<FTMQHXHFOAQ>>? STMERWZSTNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<CCYGKVMNTMH>>? EINRNWFQWSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private BOUENRSVMUK.PortGroupIdChangeDelegate? WRBZVPVWZAT;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool IEVCXBUTUZR
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x28E4D70", Offset = "0x28E3D70", VA = "0x1828E4D70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool KHXLDCBHMLW
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x28E1810", Offset = "0x28E0810", VA = "0x1828E1810", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool BBJTRHASRSK
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x28E37D0", Offset = "0x28E27D0", VA = "0x1828E37D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<YHQFEYRJQPY> EFNCSGOLWCV
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x28E52F0", Offset = "0x28E42F0", VA = "0x1828E52F0", Slot = "7")]
			get
			{
				return default(Id128<YHQFEYRJQPY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool DDZGXAFBALW
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x28E57B0", Offset = "0x28E47B0", VA = "0x1828E57B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<FTMQHXHFOAQ, YKZVLCJWURS> GSQSJEAOLXA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<FTMQHXHFOAQ, YKZVLCJWURS>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x28E63A0", Offset = "0x28E53A0", VA = "0x1828E63A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<QYHWLOYXTJM> ZUANMURWWDL
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x28E41B0", Offset = "0x28E31B0", VA = "0x1828E41B0", Slot = "11")]
			get
			{
				return default(Id128<QYHWLOYXTJM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<CCYGKVMNTMH, IFKMKUBSZWF> UBRAJECOLLR
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<CCYGKVMNTMH, IFKMKUBSZWF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<JPZDQKXUTWI> GIJWDDKKYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0xD9C630", Offset = "0xD9B630", VA = "0x180D9C630", Slot = "13")]
			get
			{
				return default(Id32<JPZDQKXUTWI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? SPIVMBPMMKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x28E3CC0", Offset = "0x28E2CC0", VA = "0x1828E3CC0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x28E1580", Offset = "0x28E0580", VA = "0x1828E1580", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? XOKBMWYCHSP
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x28E3700", Offset = "0x28E2700", VA = "0x1828E3700", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x28E3AC0", Offset = "0x28E2AC0", VA = "0x1828E3AC0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<FTMQHXHFOAQ?>, Id32<FTMQHXHFOAQ?>>? WTKLTGUBITW
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x28E1620", Offset = "0x28E0620", VA = "0x1828E1620", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x28E5050", Offset = "0x28E4050", VA = "0x1828E5050", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<FTMQHXHFOAQ?>, Id32<FTMQHXHFOAQ?>>? JTDFIEBOPWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x28E5830", Offset = "0x28E4830", VA = "0x1828E5830", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x28E6580", Offset = "0x28E5580", VA = "0x1828E6580", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<CCYGKVMNTMH?>, Id32<CCYGKVMNTMH?>>? KXZRNYKPZAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x28E62E0", Offset = "0x28E52E0", VA = "0x1828E62E0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x28E3500", Offset = "0x28E2500", VA = "0x1828E3500", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<CCYGKVMNTMH?>, Id32<CCYGKVMNTMH?>>? SWRYVXRGIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x28E6640", Offset = "0x28E5640", VA = "0x1828E6640", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x28E56F0", Offset = "0x28E46F0", VA = "0x1828E56F0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<FTMQHXHFOAQ?>, YKZVLCJWURS?>? QITBKBWBTYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x28E1F10", Offset = "0x28E0F10", VA = "0x1828E1F10", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x28E2EA0", Offset = "0x28E1EA0", VA = "0x1828E2EA0", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<FTMQHXHFOAQ?>>? IYWZTKJGXRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x28E5230", Offset = "0x28E4230", VA = "0x1828E5230", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x28E4640", Offset = "0x28E3640", VA = "0x1828E4640", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<FTMQHXHFOAQ?>, YKZVLCJWURS?>? WOTHVGTQAMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x28E4580", Offset = "0x28E3580", VA = "0x1828E4580", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x28E3890", Offset = "0x28E2890", VA = "0x1828E3890", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<CCYGKVMNTMH?>, IFKMKUBSZWF?>? LUTEGBVEBMI
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x28E5A20", Offset = "0x28E4A20", VA = "0x1828E5A20", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x28E63D0", Offset = "0x28E53D0", VA = "0x1828E63D0", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<CCYGKVMNTMH?>>? LCFOXPEFZJH
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x28E6130", Offset = "0x28E5130", VA = "0x1828E6130", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x28E2BF0", Offset = "0x28E1BF0", VA = "0x1828E2BF0", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<CCYGKVMNTMH?>, IFKMKUBSZWF?>? QDQPXFZENKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x28E3C00", Offset = "0x28E2C00", VA = "0x1828E3C00", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x28E2DE0", Offset = "0x28E1DE0", VA = "0x1828E2DE0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x28E6700", Offset = "0x28E5700", VA = "0x1828E6700")]
		private RPUELYKVFON(bool a, UOILJAPMYSC b, bool c, ReadOnlyIdArray<FTMQHXHFOAQ, SQIEFOYBQJN> inputs, ReadOnlyIdArray<FTMQHXHFOAQ, YKZVLCJWURS> inputsAsStaticInputs, TYZPRJYTRRB d, ReadOnlyIdArray<CCYGKVMNTMH, JOYPMYCCQQI> outputs, ReadOnlyIdArray<CCYGKVMNTMH, IFKMKUBSZWF> outputsAsStaticOutputs, string? overrideName, RYAFFIWWYUG e, Id32<JPZDQKXUTWI> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x28E4700", Offset = "0x28E3700", VA = "0x1828E4700")]
		public static RPUELYKVFON New(bool canInteract, UOILJAPMYSC circuitsManager, bool hasFunctionHeader, TYZPRJYTRRB node, RYAFFIWWYUG portGroup, Id32<JPZDQKXUTWI> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x28E2870", Offset = "0x28E1870", VA = "0x1828E2870", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x28E61F0", Offset = "0x28E51F0", VA = "0x1828E61F0", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, WENLUTALDTF?>>? YIHAEAICXYV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x28E1FD0", Offset = "0x28E0FD0", VA = "0x1828E1FD0")]
		private (ARGIKCKPUNW?, int)? CROGRXLGZCR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x28E1E00", Offset = "0x28E0E00", VA = "0x1828E1E00", Slot = "58")]
		private void BZJBBOJCGIX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x211B1D0", Offset = "0x211A1D0", VA = "0x18211B1D0", Slot = "57")]
		private void JTSHYMXHDMC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x28E2200", Offset = "0x28E1200", VA = "0x1828E2200", Slot = "61")]
		private void DLMJEYHQIEE(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x28E5AE0", Offset = "0x28E4AE0", VA = "0x1828E5AE0", Slot = "63")]
		private void VMDILCWWBFJ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x28E1850", Offset = "0x28E0850", VA = "0x1828E1850", Slot = "50")]
		private void BNSNSEUTYQW(int a, Id32<FTMQHXHFOAQ> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x28E5CA0", Offset = "0x28E4CA0", VA = "0x1828E5CA0", Slot = "54")]
		private void WGNQVUOPFDN(int a, Id32<FTMQHXHFOAQ> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x28E35C0", Offset = "0x28E25C0", VA = "0x1828E35C0", Slot = "49")]
		private void ICWRFASTIVT(int a, Id32<FTMQHXHFOAQ> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x28E3D60", Offset = "0x28E2D60", VA = "0x1828E3D60", Slot = "53")]
		private void LZBAZSGYBIW(int a, Id32<FTMQHXHFOAQ> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x28E25D0", Offset = "0x28E15D0", VA = "0x1828E25D0", Slot = "66")]
		private void DOSXOVSMXIA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xE9AF00", Offset = "0xE99F00", VA = "0x180E9AF00", Slot = "65")]
		private void YDAHGSHQMYV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x28E4F40", Offset = "0x28E3F40", VA = "0x1828E4F40", Slot = "60")]
		private void OLVTQXXDBPY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x211B1D0", Offset = "0x211A1D0", VA = "0x18211B1D0", Slot = "59")]
		private void PZBRKQQNIKR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x28E5320", Offset = "0x28E4320", VA = "0x1828E5320", Slot = "62")]
		private void RWIPCHDNBPB(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x28E3B70", Offset = "0x28E2B70", VA = "0x1828E3B70", Slot = "64")]
		private void KOBVYZXWKOC(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x28E2F60", Offset = "0x28E1F60", VA = "0x1828E2F60", Slot = "52")]
		private void GBYNVQWTZGF(int a, Id32<CCYGKVMNTMH> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x28E58F0", Offset = "0x28E48F0", VA = "0x1828E58F0", Slot = "56")]
		private void TIVJPQSAKRY(int a, Id32<CCYGKVMNTMH> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x28E37B0", Offset = "0x28E27B0", VA = "0x1828E37B0", Slot = "51")]
		private void JKVVXZWANAY(int a, Id32<CCYGKVMNTMH> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x28E5CC0", Offset = "0x28E4CC0", VA = "0x1828E5CC0", Slot = "55")]
		private void WZOZYSTJWJL(int a, Id32<CCYGKVMNTMH> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x28E3950", Offset = "0x28E2950", VA = "0x1828E3950", Slot = "68")]
		private void KMMIDVCQLOB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xE9AF00", Offset = "0xE99F00", VA = "0x180E9AF00", Slot = "67")]
		private void MMAIIQFAVPU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x28E4E30", Offset = "0x28E3E30", VA = "0x1828E4E30", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, WENLUTALDTF?>>? OILSIESMPAU(Id32<KRDUNWCYLJD> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x28E5910", Offset = "0x28E4910", VA = "0x1828E5910", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, WENLUTALDTF?>>? UEVIKXSAHPL(Id32<DSRIXMVNJVY> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x28E35E0", Offset = "0x28E25E0", VA = "0x1828E35E0", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, WENLUTALDTF?>>? ITWOUWOXNUC(Id32<KRDUNWCYLJD> inputDefId, Id32<KRDUNWCYLJD> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x28E4C50", Offset = "0x28E3C50", VA = "0x1828E4C50", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, WENLUTALDTF?>>? OBCYEOTVPIV(Id32<DSRIXMVNJVY> outputDefId, Id32<DSRIXMVNJVY> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x28E6490", Offset = "0x28E5490", VA = "0x1828E6490", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, WENLUTALDTF?>>? YQBRJVWMYFY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x28E5110", Offset = "0x28E4110", VA = "0x1828E5110", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, WENLUTALDTF>> PRZYVMQXJVP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x28E2CB0", Offset = "0x28E1CB0", VA = "0x1828E2CB0", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, WENLUTALDTF>> EGFXZESFNDY(Id32<KRDUNWCYLJD> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x28E5B70", Offset = "0x28E4B70", VA = "0x1828E5B70", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, WENLUTALDTF>> VSGGPHWWRJF(Id32<DSRIXMVNJVY> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x28E16E0", Offset = "0x28E06E0", VA = "0x1828E16E0", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, WENLUTALDTF>> ARNDONEHSYJ(Id32<KRDUNWCYLJD> inputDefId, NIWXUTPBRAL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x28E2740", Offset = "0x28E1740", VA = "0x1828E2740", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, WENLUTALDTF>> DYPGTGPOOUW(Id32<DSRIXMVNJVY> outputDefId, NIWXUTPBRAL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x28E41D0", Offset = "0x28E31D0", VA = "0x1828E41D0")]
		internal void NQREFCZGZUY(Id32<JPZDQKXUTWI> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class YDXEBHQLRCV : NZDCYEHGQGM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface OAIZGCDVQOY
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<YHQFEYRJQPY>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065F")]
				[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<YHQFEYRJQPY>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			MLJAAVCGGXT MLJAAVCGGXT
			{
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> BQBDJCANAKW(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> SRVDFHVZAKJ(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<ZWCOPVGGMMD> IOCUVRXFQSC(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<DLNBIGPDDFF> CIBEUZABCPN(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> UVHCKDTOPEI(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> LIMCKFWVZUT(CancellationToken a);
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[CompilerGenerated]
		private struct <DeserializeAsync>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public AsyncTaskMethodBuilder<YDXEBHQLRCV> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public UOILJAPMYSC circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public CircuitRootData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public SuperRoomData superRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			private OAIZGCDVQOY <selfDeps>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			private CircuitRootData <downloadedRoomData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			private CircuitRootData <actualRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			private StaticCircuitsConfig <actualStaticConfig>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			private SuperRoomData <finalSuperRoomData>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private ZWCOPVGGMMD <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private DLNBIGPDDFF <playerSaveData>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			private CircuitRootData <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			private TaskAwaiter<SuperRoomData> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			private TaskAwaiter<ZWCOPVGGMMD> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<DLNBIGPDDFF> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<OAIZGCDVQOY.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<THPTAACPNZD> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x28E8A90", Offset = "0x28E7A90", VA = "0x1828E8A90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x28E9C60", Offset = "0x28E8C60", VA = "0x1828E9C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public THPTAACPNZD THPTAACPNZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public ZXTXENDIWRT ZXTXENDIWRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public THKZBYEIUDY THKZBYEIUDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public FYLRPLOTYZY FYLRPLOTYZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xEB7540", Offset = "0xEB6540", VA = "0x180EB7540")]
		private YDXEBHQLRCV(THPTAACPNZD a, ZXTXENDIWRT b, THKZBYEIUDY c, FYLRPLOTYZY d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x28F2530", Offset = "0x28F1530", VA = "0x1828F2530")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<YDXEBHQLRCV> DPFGLWSQECK(UOILJAPMYSC a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x28F26A0", Offset = "0x28F16A0", VA = "0x1828F26A0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class YQUZKKNPTDH : AYKBPIRHSRG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly UOILJAPMYSC HHSEEZECAYH;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public EUJFGHKAUFZ? QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x28F2E20", Offset = "0x28F1E20", VA = "0x1828F2E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		internal YQUZKKNPTDH(UOILJAPMYSC a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class THKZBYEIUDY : EUJFGHKAUFZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly UOILJAPMYSC HHSEEZECAYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly THPTAACPNZD IEBOMHSLGGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly YQUZKKNPTDH GENPOLYEZQW;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> JWMKSQHNJWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x28E7E30", Offset = "0x28E6E30", VA = "0x1828E7E30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xB525B0", Offset = "0xB515B0", VA = "0x180B525B0")]
		public THKZBYEIUDY(UOILJAPMYSC a, THPTAACPNZD b, YQUZKKNPTDH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x28E7D80", Offset = "0x28E6D80", VA = "0x1828E7D80", Slot = "5")]
		public string HQCNUNXEZFS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x28E7DD0", Offset = "0x28E6DD0", VA = "0x1828E7DD0", Slot = "6")]
		public void MNETCDNLUIT(string a, string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	public readonly struct EVRequestExtended
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		[CompilerGenerated]
		private struct <Destroy>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2903A30", Offset = "0x2902A30", VA = "0x182903A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2903C70", Offset = "0x2902C70", VA = "0x182903C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011C")]
		[CompilerGenerated]
		private struct <MultipartInitialize>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public AsyncTaskMethodBuilder<Result<bool, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public int splitSizeBytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public CircuitRootData circuitRootData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public SuperRoomData superRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			private PQYWNUACEKJ[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x2904480", Offset = "0x2903480", VA = "0x182904480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x2904850", Offset = "0x2903850", VA = "0x182904850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011D")]
		[CompilerGenerated]
		private struct <Request>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public AsyncTaskMethodBuilder<Result<object, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public PQYWNUACEKJ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x2908B80", Offset = "0x2907B80", VA = "0x182908B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x2909000", Offset = "0x2908000", VA = "0x182909000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly BKAMUOKSWTC _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
		public EVRequestExtended(BKAMUOKSWTC staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x28DB020", Offset = "0x28DA020", VA = "0x1828DB020")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, WENLUTALDTF>> TUJNFMUNDGY(PQYWNUACEKJ a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x28DAEC0", Offset = "0x28D9EC0", VA = "0x1828DAEC0")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, WENLUTALDTF?>>? TLTCWTMXGVZ(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x28DADD0", Offset = "0x28D9DD0", VA = "0x1828DADD0")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, WENLUTALDTF>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface EIQLKIGJKVE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		NZDCYEHGQGM? QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool PEMCKZEQQUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<NZDCYEHGQGM?>? KQGUZBTQVWC();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task IKTNKHSRCTZ(UOILJAPMYSC a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface NZDCYEHGQGM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		THPTAACPNZD THPTAACPNZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		ZXTXENDIWRT ZXTXENDIWRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		THKZBYEIUDY THKZBYEIUDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		FYLRPLOTYZY FYLRPLOTYZY
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class MWVXRKFCSSD
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x29029A0", Offset = "0x29019A0", VA = "0x1829029A0")]
		public static ReducerFactory<ActionKind, PQYWNUACEKJ, UOILJAPMYSC, FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>> JCCRBYWQVDC([In] this ReducerFactory<ActionKind, PQYWNUACEKJ, UOILJAPMYSC, FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, PQYWNUACEKJ, UOILJAPMYSC, FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class WPNWJJFNAJE : RZAFZPKPPOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly UOILJAPMYSC HHSEEZECAYH;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool PEMCKZEQQUR
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x2909B50", Offset = "0x2908B50", VA = "0x182909B50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		internal WPNWJJFNAJE(UOILJAPMYSC a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class QQFDBEWOQNZ : YFUDWZWXTDG
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x29031E0", Offset = "0x29021E0", VA = "0x1829031E0", Slot = "4")]
		public XVNRGWBKEIW? ZSJZQZBBLXL(string? a, string? b, string? c, RoomDoorData.FZNFAKTBVRO.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2903110", Offset = "0x2902110", VA = "0x182903110", Slot = "5")]
		public RRZDPNREULO XEOHOBTOJIR(string a, string b, List<string> c, int d, int e, int f, int g, UNIBTHIMABE h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x2903070", Offset = "0x2902070", VA = "0x182903070", Slot = "6")]
		public UNIBTHIMABE LBLOMTVZXBD(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public QQFDBEWOQNZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class HZRQNDYNBBX : CDGWYKPACEI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000125")]
		[CompilerGenerated]
		private struct <GetInstanceAsync>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public AsyncTaskMethodBuilder<ONSXKYCMZAP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public HZRQNDYNBBX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<NZDCYEHGQGM?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2903CE0", Offset = "0x2902CE0", VA = "0x182903CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2903F80", Offset = "0x2902F80", VA = "0x182903F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly UOILJAPMYSC HHSEEZECAYH;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public ONSXKYCMZAP? QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x28FD6E0", Offset = "0x28FC6E0", VA = "0x1828FD6E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public FYLRPLOTYZY? ISQDBPFGERD
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x28FD760", Offset = "0x28FC760", VA = "0x1828FD760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool XISERSGUUOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x28FD810", Offset = "0x28FC810", VA = "0x1828FD810", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool TDXNYYFMDHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x28FD960", Offset = "0x28FC960", VA = "0x1828FD960", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x28FDF10", Offset = "0x28FCF10", VA = "0x1828FDF10")]
		internal HZRQNDYNBBX(UOILJAPMYSC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x28FD870", Offset = "0x28FC870", VA = "0x1828FD870", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<ONSXKYCMZAP> KQGUZBTQVWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x28FD9C0", Offset = "0x28FC9C0", VA = "0x1828FD9C0", Slot = "9")]
		public IReadOnlyDictionary<Id128<YHQFEYRJQPY>, Guid> THJEEZDOIFG(IEnumerable<YQOGBIMEPLB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x28FD560", Offset = "0x28FC560", VA = "0x1828FD560", Slot = "10")]
		public CircuitGraphToolMappingRegistryData ANOBOSUGTSO(IEnumerable<YQOGBIMEPLB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x28FDD40", Offset = "0x28FCD40", VA = "0x1828FDD40")]
		public Result<CircuitsRoomData, IMZVXBWNFZH> XUZDNMIKTAO([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, IMZVXBWNFZH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x28FD7E0", Offset = "0x28FC7E0", VA = "0x1828FD7E0", Slot = "8")]
		private Result<CircuitsRoomData, IMZVXBWNFZH> DAOFNTPLFHF([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, IMZVXBWNFZH>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class FYLRPLOTYZY : ONSXKYCMZAP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class IORYBHCZCNP
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class HQENANIBZDY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int BSROEULIOFU;

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public HQENANIBZDY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x28FD540", Offset = "0x28FC540", VA = "0x1828FD540")]
				internal void NJWOXSFOQXN(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x28FE340", Offset = "0x28FD340", VA = "0x1828FE340")]
			public static Result<ONSXKYCMZAP.PrepareTemplateForCloneResult, KTXQESFTWLM> LQQMVHZWOPS(FYLRPLOTYZY a, [In] ONSXKYCMZAP.PrepareTemplateForCloneArgs args)
			{
				return default(Result<ONSXKYCMZAP.PrepareTemplateForCloneResult, KTXQESFTWLM>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x28FECE0", Offset = "0x28FDCE0", VA = "0x1828FECE0")]
			internal static Result<(KAGFAPACVFV, CircuitTemplateRootData), KTXQESFTWLM> QXUNLZNTLVE(FYLRPLOTYZY a, CircuitTemplateRootData b, bool c, [In] Id128<YHQFEYRJQPY> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(KAGFAPACVFV, CircuitTemplateRootData), KTXQESFTWLM>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x28FE850", Offset = "0x28FD850", VA = "0x1828FE850")]
			private static void QMFADLYCDAA(bool a, YQOGBIMEPLB b, KAGFAPACVFV c, [In] Id128<YHQFEYRJQPY> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x28FFFD0", Offset = "0x28FEFD0", VA = "0x1828FFFD0")]
			public static void TQLDPFOLKCN(ZTDPOXWSYTQ a, [In] ONSXKYCMZAP.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x28FFA40", Offset = "0x28FEA40", VA = "0x1828FFA40")]
			[CompilerGenerated]
			internal static bool THKOIDAZZBG(THPTAACPNZD a, XQGXKQNGDGG b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x28FFA10", Offset = "0x28FEA10", VA = "0x1828FFA10")]
			[CompilerGenerated]
			internal static bool SYSQCRFLOVH(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class NQULOZZHSDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public FYLRPLOTYZY SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<YHQFEYRJQPY> ORJUNUEBMEX;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public NQULOZZHSDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x2902DE0", Offset = "0x2901DE0", VA = "0x182902DE0")]
			internal Id128<QYHWLOYXTJM> BHLAERGCPOE(Id32<QYHWLOYXTJM> a)
			{
				return default(Id128<QYHWLOYXTJM>);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		[CompilerGenerated]
		private struct <RequestAddEdge>d__101 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<JZMHXBKSKRV> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<SUVSOCRKLLI> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x29048C0", Offset = "0x29038C0", VA = "0x1829048C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x2904E90", Offset = "0x2903E90", VA = "0x182904E90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		[CompilerGenerated]
		private struct <RequestAddInputPort>d__150 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<QYHWLOYXTJM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<JPZDQKXUTWI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<KRDUNWCYLJD> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x2904F00", Offset = "0x2903F00", VA = "0x182904F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2905250", Offset = "0x2904250", VA = "0x182905250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[CompilerGenerated]
		private struct <RequestAddNode>d__103 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public AsyncTaskMethodBuilder<Result<Id32<QYHWLOYXTJM>, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<ZLSSORBCQRX> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private THPTAACPNZD <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x29055A0", Offset = "0x29045A0", VA = "0x1829055A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x29059D0", Offset = "0x29049D0", VA = "0x1829059D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012F")]
		[CompilerGenerated]
		private struct <RequestAddNodeDesc>d__104 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public AsyncTaskMethodBuilder<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<QYHWLOYXTJM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x29052C0", Offset = "0x29042C0", VA = "0x1829052C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x2905530", Offset = "0x2904530", VA = "0x182905530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000130")]
		[CompilerGenerated]
		private struct <RequestDeleteAllNodes>d__141 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2905A40", Offset = "0x2904A40", VA = "0x182905A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2905C30", Offset = "0x2904C30", VA = "0x182905C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		[CompilerGenerated]
		private struct <RequestGroupNodesIntoCircuitBoard>d__83 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<YHQFEYRJQPY> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<QYHWLOYXTJM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<QYHWLOYXTJM>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public CircuitsVec3 localBoardPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public CircuitsQuat localBoardRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2905CA0", Offset = "0x2904CA0", VA = "0x182905CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2905F40", Offset = "0x2904F40", VA = "0x182905F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		[CompilerGenerated]
		private struct <RequestGroupNodesIntoObjectBoard>d__87 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<YHQFEYRJQPY> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<QYHWLOYXTJM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<QYHWLOYXTJM>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<JPZDQKXUTWI>, Id32<FTMQHXHFOAQ>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<JPZDQKXUTWI>, Id32<CCYGKVMNTMH>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2905FB0", Offset = "0x2904FB0", VA = "0x182905FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2906590", Offset = "0x2905590", VA = "0x182906590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		[CompilerGenerated]
		private struct <RequestMoveToBoard>d__84 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<YHQFEYRJQPY> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<QYHWLOYXTJM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<QYHWLOYXTJM>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x29065F0", Offset = "0x29055F0", VA = "0x1829065F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2906800", Offset = "0x2905800", VA = "0x182906800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		[CompilerGenerated]
		private struct <RequestRemoveInputPortConnections>d__112 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<QYHWLOYXTJM> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<JPZDQKXUTWI> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<FTMQHXHFOAQ> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2906870", Offset = "0x2905870", VA = "0x182906870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2906BC0", Offset = "0x2905BC0", VA = "0x182906BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000135")]
		[CompilerGenerated]
		private struct <RequestRemoveLastInputPort>d__151 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<QYHWLOYXTJM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<JPZDQKXUTWI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<KRDUNWCYLJD> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2906C30", Offset = "0x2905C30", VA = "0x182906C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2907010", Offset = "0x2906010", VA = "0x182907010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000136")]
		[CompilerGenerated]
		private struct <RequestRemoveNode>d__115 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<QYHWLOYXTJM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2907080", Offset = "0x2906080", VA = "0x182907080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2907300", Offset = "0x2906300", VA = "0x182907300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000137")]
		[CompilerGenerated]
		private struct <RequestRemoveOutputPortConnections>d__113 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<QYHWLOYXTJM> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<JPZDQKXUTWI> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<CCYGKVMNTMH> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2907370", Offset = "0x2906370", VA = "0x182907370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x29076C0", Offset = "0x29066C0", VA = "0x1829076C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000138")]
		[CompilerGenerated]
		private struct <RequestSetNodeLocalTransform>d__155 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<QYHWLOYXTJM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2907730", Offset = "0x2906730", VA = "0x182907730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2907A70", Offset = "0x2906A70", VA = "0x182907A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000139")]
		[CompilerGenerated]
		private struct <RequestSetNodeName>d__142 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<QYHWLOYXTJM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2907AE0", Offset = "0x2906AE0", VA = "0x182907AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2907D70", Offset = "0x2906D70", VA = "0x182907D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013A")]
		[CompilerGenerated]
		private struct <RequestSetVariableHomeValue>d__154 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<QYHWLOYXTJM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2907DE0", Offset = "0x2906DE0", VA = "0x182907DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2908070", Offset = "0x2907070", VA = "0x182908070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013B")]
		[CompilerGenerated]
		private struct <RequestSpawnTemplate>d__121 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<QYHWLOYXTJM>>, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<YHQFEYRJQPY> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<YQOGBIMEPLB> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<TYZPRJYTRRB>, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x29080E0", Offset = "0x29070E0", VA = "0x1829080E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2908880", Offset = "0x2907880", VA = "0x182908880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013C")]
		[CompilerGenerated]
		private struct <RequestSplitFromBoard>d__85 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<YHQFEYRJQPY> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<QYHWLOYXTJM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<QYHWLOYXTJM>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x29088F0", Offset = "0x29078F0", VA = "0x1829088F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2908B10", Offset = "0x2907B10", VA = "0x182908B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013D")]
		[CompilerGenerated]
		private struct <RequestUngroupBoard>d__82 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public FYLRPLOTYZY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<YHQFEYRJQPY> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<QYHWLOYXTJM> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x2909070", Offset = "0x2908070", VA = "0x182909070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x2909290", Offset = "0x2908290", VA = "0x182909290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly UOILJAPMYSC HHSEEZECAYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly THPTAACPNZD IEBOMHSLGGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers AESFZUTBKMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly HZRQNDYNBBX EFYRRABBXBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<QYHWLOYXTJM>, YYVRREXPLEY> NIXAWLGVXOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<QYHWLOYXTJM>>? TYPYETTUBNS;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<YHQFEYRJQPY> LBKVGOHPLOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x28FB590", Offset = "0x28FA590", VA = "0x1828FB590", Slot = "4")]
			get
			{
				return default(Id128<YHQFEYRJQPY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers OECYNYNYBEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x28F6790", Offset = "0x28F5790", VA = "0x1828F6790", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> QNOEPJRVPWP
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x28F9310", Offset = "0x28F8310", VA = "0x1828F9310", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action WERIDDZTSAW
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x28F77D0", Offset = "0x28F67D0", VA = "0x1828F77D0", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x28F9AD0", Offset = "0x28F8AD0", VA = "0x1828F9AD0", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> TONNXDFMAUK
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x28F77F0", Offset = "0x28F67F0", VA = "0x1828F77F0", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x28F95F0", Offset = "0x28F85F0", VA = "0x1828F95F0", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x28FD0E0", Offset = "0x28FC0E0", VA = "0x1828FD0E0")]
		public FYLRPLOTYZY(UOILJAPMYSC a, THPTAACPNZD b, HZRQNDYNBBX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x28F69E0", Offset = "0x28F59E0", VA = "0x1828F69E0", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x28FB2A0", Offset = "0x28FA2A0", VA = "0x1828FB2A0", Slot = "100")]
		public Id32<ZLABBFMSBFQ> TGQPZROJQAB(Id32<YHQFEYRJQPY> graphId, Id32<SUVSOCRKLLI> inputId)
		{
			return default(Id32<ZLABBFMSBFQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x28F7F50", Offset = "0x28F6F50", VA = "0x1828F7F50", Slot = "101")]
		public Id32<NNQGKRNHNRX> GNOQCOURQWU(Id32<YHQFEYRJQPY> graphId, Id32<JZMHXBKSKRV> outputId)
		{
			return default(Id32<NNQGKRNHNRX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x28FB660", Offset = "0x28FA660", VA = "0x1828FB660", Slot = "6")]
		public (bool, bool) VRSRPIWPGVN(Id32<YHQFEYRJQPY> graphId, Id32<JZMHXBKSKRV> srcId, Id32<SUVSOCRKLLI> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x28F9610", Offset = "0x28F8610", VA = "0x1828F9610")]
		public bool LYSODEPLOKS(Id32<YHQFEYRJQPY> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x28FA340", Offset = "0x28F9340", VA = "0x1828FA340", Slot = "8")]
		public bool OVAAHOGDLRG(YKZVLCJWURS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x28F5BA0", Offset = "0x28F4BA0", VA = "0x1828F5BA0", Slot = "9")]
		public bool ABFAHGNOFAX(IFKMKUBSZWF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x28FA040", Offset = "0x28F9040", VA = "0x1828FA040", Slot = "10")]
		public AbsoluteLegacyInputId? OLSCHMAOYWM(Id32<YHQFEYRJQPY> graphId, Id32<SUVSOCRKLLI> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x28FB340", Offset = "0x28FA340", VA = "0x1828FB340", Slot = "11")]
		public AbsoluteLegacyOutputId? UBOTDTWLPQL(Id32<YHQFEYRJQPY> graphId, Id32<JZMHXBKSKRV> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x28FBBD0", Offset = "0x28FABD0", VA = "0x1828FBBD0", Slot = "12")]
		public Id32<JZMHXBKSKRV>? WEAMCHGRBQJ(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId, Id32<CCYGKVMNTMH> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x28F9FC0", Offset = "0x28F8FC0", VA = "0x1828F9FC0", Slot = "13")]
		public Id32<SUVSOCRKLLI>? NLZUECVAVJM(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId, Id32<FTMQHXHFOAQ> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x28FC170", Offset = "0x28FB170", VA = "0x1828FC170", Slot = "14")]
		public IEnumerable<Id32<YHQFEYRJQPY>> XLXERQIZASK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x28F6700", Offset = "0x28F5700", VA = "0x1828F6700", Slot = "15")]
		public IEnumerable<Id32<EXITAREBDLY>> CZKXXHMYBQN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x28FB310", Offset = "0x28FA310", VA = "0x1828FB310", Slot = "22")]
		public string TVMIKQXQTSR(Id32<EXITAREBDLY> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x28F9050", Offset = "0x28F8050", VA = "0x1828F9050", Slot = "16")]
		public Id32<EXITAREBDLY>? KFGFBQAWMRN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x28FA640", Offset = "0x28F9640", VA = "0x1828FA640", Slot = "17")]
		public int ROTECPSPBOK(Id32<EXITAREBDLY> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x28FBF80", Offset = "0x28FAF80", VA = "0x1828FBF80", Slot = "18")]
		public int WSGSWRXACUD(Id32<EXITAREBDLY> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x28F9910", Offset = "0x28F8910", VA = "0x1828F9910", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] MEETRWICSGM(Id32<EXITAREBDLY> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x28F9970", Offset = "0x28F8970", VA = "0x1828F9970", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] MEMSCJJIRSV(Id32<EXITAREBDLY> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3738B20", Offset = "0x3737B20", VA = "0x183738B20")]
		private static (CircuitTypeIdWrapper, string?)[]? EABBDECPXWW<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x28FC480", Offset = "0x28FB480", VA = "0x1828FC480", Slot = "21")]
		public string ZCXDCLFJSPZ(Id32<EXITAREBDLY> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x28FA4E0", Offset = "0x28F94E0", VA = "0x1828FA4E0", Slot = "23")]
		public string PYQVNRFVCGS(Id32<EXITAREBDLY> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x28F65A0", Offset = "0x28F55A0", VA = "0x1828F65A0")]
		public YYVRREXPLEY? CMMRGIZOUXD([In] Id128<QYHWLOYXTJM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x28F5C20", Offset = "0x28F4C20", VA = "0x1828F5C20", Slot = "30")]
		public Id32<ZLSSORBCQRX> AIRRXXLNMBL(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId)
		{
			return default(Id32<ZLSSORBCQRX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x28F5C80", Offset = "0x28F4C80", VA = "0x1828F5C80")]
		public Id32<QYHWLOYXTJM> SHBUGXYHQUM(Id32<YHQFEYRJQPY> graphId, [In] Id128<QYHWLOYXTJM> legacyNodeId)
		{
			return default(Id32<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x28F7BC0", Offset = "0x28F6BC0", VA = "0x1828F7BC0", Slot = "40")]
		public Id32<QYHWLOYXTJM> FROXUWOESZT(Id32<YHQFEYRJQPY> graphId, Id32<SUVSOCRKLLI> inputId)
		{
			return default(Id32<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x28FA660", Offset = "0x28F9660", VA = "0x1828FA660", Slot = "41")]
		public Id32<QYHWLOYXTJM> RPLBOEZJFJG(Id32<YHQFEYRJQPY> graphId, Id32<JZMHXBKSKRV> outputId)
		{
			return default(Id32<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x28FB2E0", Offset = "0x28FA2E0", VA = "0x1828FB2E0")]
		public Id32<QYHWLOYXTJM>? TRKLKQEVGUY(Id32<YHQFEYRJQPY> graphId, [In] Id128<QYHWLOYXTJM> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x28F9480", Offset = "0x28F8480", VA = "0x1828F9480", Slot = "32")]
		public AbsoluteNodeId? LIRJFWIVPRU(Id32<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x28F95D0", Offset = "0x28F85D0", VA = "0x1828F95D0", Slot = "33")]
		public long LRKXIQJTSNB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x28FA520", Offset = "0x28F9520", VA = "0x1828FA520")]
		private void RFPSTKNUYZJ(Id128<QYHWLOYXTJM> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x28F93F0", Offset = "0x28F83F0", VA = "0x1828F93F0", Slot = "38")]
		public IEnumerable<(Id32<YHQFEYRJQPY>, Id32<QYHWLOYXTJM>)> KRCGQOFMKMB(Id32<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x28F9FF0", Offset = "0x28F8FF0", VA = "0x1828F9FF0", Slot = "39")]
		public Id32<SUVSOCRKLLI> NLZUECVAVJM(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<ZLABBFMSBFQ> inputIndex)
		{
			return default(Id32<SUVSOCRKLLI>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x28FBBA0", Offset = "0x28FABA0", VA = "0x1828FBBA0", Slot = "42")]
		public Id32<JZMHXBKSKRV> WEAMCHGRBQJ(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<NNQGKRNHNRX> outputIndex)
		{
			return default(Id32<JZMHXBKSKRV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x28F86C0", Offset = "0x28F76C0", VA = "0x1828F86C0")]
		private YYVRREXPLEY? HNXZLNMSUXC([In] Id128<QYHWLOYXTJM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x28FB3C0", Offset = "0x28FA3C0", VA = "0x1828FB3C0")]
		public TYZPRJYTRRB? UGFIVLFDFQW([In] Id128<QYHWLOYXTJM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x28F7B90", Offset = "0x28F6B90", VA = "0x1828F7B90")]
		public KBQIDJEAJVG? LJMGJBDWFHZ([In] Id128<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x28F9580", Offset = "0x28F8580", VA = "0x1828F9580", Slot = "25")]
		public KBQIDJEAJVG? LJMGJBDWFHZ(Id32<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x28FBB00", Offset = "0x28FAB00", VA = "0x1828FBB00", Slot = "34")]
		public IEnumerable<NewStaticEdge> VVXHFUOFOCN(Id32<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x28FA3C0", Offset = "0x28F93C0", VA = "0x1828FA3C0", Slot = "35")]
		public bool OWQJUOTXUFP(Id32<EXITAREBDLY> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x28F8A20", Offset = "0x28F7A20", VA = "0x1828F8A20", Slot = "36")]
		public IEnumerable<StableStaticEdge> JGMIODWFOLP(Id32<YHQFEYRJQPY> graphId, Id32<JZMHXBKSKRV> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x28F7810", Offset = "0x28F6810", VA = "0x1828F7810", Slot = "37")]
		public IEnumerable<StableStaticEdge> EWOZLVRKXFS(Id32<YHQFEYRJQPY> graphId, Id32<SUVSOCRKLLI> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x28F66D0", Offset = "0x28F56D0", VA = "0x1828F66D0")]
		public Id32<YHQFEYRJQPY> COZMDCHIGDY([In] Id128<YHQFEYRJQPY> graphId)
		{
			return default(Id32<YHQFEYRJQPY>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x28F8EA0", Offset = "0x28F7EA0", VA = "0x1828F8EA0")]
		public Id32<YHQFEYRJQPY>? VMWJJFSWFAC([In] Id128<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x28FA5A0", Offset = "0x28F95A0", VA = "0x1828FA5A0")]
		private XQGXKQNGDGG? RGVQOBPGHJI([In] Id128<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x28F7B90", Offset = "0x28F6B90", VA = "0x1828F7B90")]
		private KBQIDJEAJVG? FKHZVYAYPXL([In] Id128<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x28FC4B0", Offset = "0x28FB4B0", VA = "0x1828FC4B0", Slot = "28")]
		public Id32<YHQFEYRJQPY>? ZGBPJDOUYXT(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x28F7B70", Offset = "0x28F6B70", VA = "0x1828F7B70", Slot = "46")]
		public Id128<YHQFEYRJQPY> FEAIKWEIKDR(Id32<YHQFEYRJQPY> graphId)
		{
			return default(Id128<YHQFEYRJQPY>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x28FB3A0", Offset = "0x28FA3A0", VA = "0x1828FB3A0", Slot = "47")]
		public Id128<QYHWLOYXTJM> UEECXGAETDZ(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId)
		{
			return default(Id128<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x28F9AF0", Offset = "0x28F8AF0", VA = "0x1828F9AF0", Slot = "43")]
		public IEnumerable<NIWXUTPBRAL> NFHTOTXLFWR(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x28F8390", Offset = "0x28F7390", VA = "0x1828F8390", Slot = "44")]
		public NIWXUTPBRAL HFJYHACCWTG(RoomVersion a, ADJDNATJUCX b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x28F67A0", Offset = "0x28F57A0", VA = "0x1828F67A0")]
		public NewStaticEdge DDIRRCGADJQ(Id32<YHQFEYRJQPY> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x28FA0A0", Offset = "0x28F90A0", VA = "0x1828FA0A0", Slot = "48")]
		public StableStaticEdge ORNJIRLDMLN(Id32<YHQFEYRJQPY> graphId, Id32<JZMHXBKSKRV> srcId, Id32<SUVSOCRKLLI> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x28F8240", Offset = "0x28F7240", VA = "0x1828F8240", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, WENLUTALDTF>> GSPNLGECTAG(Id32<YHQFEYRJQPY> parentGraphId, Id32<QYHWLOYXTJM> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x28F8ED0", Offset = "0x28F7ED0", VA = "0x1828F8ED0", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, WENLUTALDTF>> KBTVHVTFJYH(Id32<YHQFEYRJQPY> parentGraphId, Id128<QYHWLOYXTJM> boardNodeId, List<Id32<QYHWLOYXTJM>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x28F6890", Offset = "0x28F5890", VA = "0x1828F6890", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, WENLUTALDTF>> DOEXKBSGZAI(Id32<YHQFEYRJQPY> parentGraphId, Id128<QYHWLOYXTJM> boardNodeId, List<Id32<QYHWLOYXTJM>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x28F6360", Offset = "0x28F5360", VA = "0x1828F6360", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, WENLUTALDTF>> CFZFBASDWTK(Id32<YHQFEYRJQPY> parentGraphId, Id128<QYHWLOYXTJM> boardNodeId, Id32<YHQFEYRJQPY> graphId, List<Id32<QYHWLOYXTJM>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x28FB400", Offset = "0x28FA400", VA = "0x1828FB400", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<JPZDQKXUTWI>, Id32<FTMQHXHFOAQ>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<JPZDQKXUTWI>, Id32<CCYGKVMNTMH>)>) UHKPPMHPFNP(Id128<YHQFEYRJQPY> legacyGraphId, Id32<QYHWLOYXTJM> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<JPZDQKXUTWI>, Id32<FTMQHXHFOAQ>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<JPZDQKXUTWI>, Id32<CCYGKVMNTMH>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x28FBC00", Offset = "0x28FAC00", VA = "0x1828FBC00", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task WIDLUQBUXNJ(Id128<YHQFEYRJQPY> legacyGraphId, Id128<QYHWLOYXTJM> boardNodeId, IReadOnlyList<Id128<QYHWLOYXTJM>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<JPZDQKXUTWI>, Id32<FTMQHXHFOAQ>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<JPZDQKXUTWI>, Id32<CCYGKVMNTMH>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x28FA500", Offset = "0x28F9500", VA = "0x1828FA500", Slot = "55")]
		public bool QWZWTIIRIBV(Id32<YHQFEYRJQPY> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x28FA020", Offset = "0x28F9020", VA = "0x1828FA020", Slot = "56")]
		public bool NRWVWWNZLVF(Id32<YHQFEYRJQPY> graphId, Id32<SUVSOCRKLLI> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x28F6A80", Offset = "0x28F5A80", VA = "0x1828F6A80", Slot = "57")]
		public bool ECAMUWHMVLS(Id32<YHQFEYRJQPY> graphId, Id32<JZMHXBKSKRV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x28F8690", Offset = "0x28F7690", VA = "0x1828F8690")]
		public Result<ONSXKYCMZAP.PrepareTemplateForCloneResult, KTXQESFTWLM> HNVDLNXAQBG([In] ONSXKYCMZAP.PrepareTemplateForCloneArgs args)
		{
			return default(Result<ONSXKYCMZAP.PrepareTemplateForCloneResult, KTXQESFTWLM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x28F5CB0", Offset = "0x28F4CB0", VA = "0x1828F5CB0", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, WENLUTALDTF>> AWVFEXHJMWC(Id32<YHQFEYRJQPY> graphId, Id32<JZMHXBKSKRV> srcId, Id32<SUVSOCRKLLI> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x28FC320", Offset = "0x28FB320", VA = "0x1828FC320", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<QYHWLOYXTJM>, WENLUTALDTF>> ZAKXYUQHDIX(Id32<YHQFEYRJQPY> graphId, Id32<ZLSSORBCQRX> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x28F8100", Offset = "0x28F7100", VA = "0x1828F8100", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> GPNDLEBBUIO(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x28F7450", Offset = "0x28F6450", VA = "0x1828F7450", Slot = "62")]
		public Result<ControlPanelRootData, IMZVXBWNFZH> ELKTUQYFSWQ(Id128<YHQFEYRJQPY> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, IMZVXBWNFZH>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1E0", Offset = "0x28F91E0", VA = "0x1828FA1E0", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, WENLUTALDTF>> OUAIMVLODEY(Id128<YHQFEYRJQPY> graphId, Id128<QYHWLOYXTJM> inputNodeId, Id32<JPZDQKXUTWI> inputPortGroupId, Id32<FTMQHXHFOAQ> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x28F6200", Offset = "0x28F5200", VA = "0x1828F6200", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, WENLUTALDTF>> CCLTRTKIBEP(Id128<YHQFEYRJQPY> graphId, Id128<QYHWLOYXTJM> outputNodeId, Id32<JPZDQKXUTWI> outputPortGroupId, Id32<CCYGKVMNTMH> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x28F7A60", Offset = "0x28F6A60", VA = "0x1828F7A60", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, WENLUTALDTF>> FCOYOPHICNS(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x28F8730", Offset = "0x28F7730", VA = "0x1828F8730", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<QYHWLOYXTJM>>, WENLUTALDTF>> HVDHCHDJIEV(Id128<YHQFEYRJQPY> intoGraphId, CircuitTemplateRootData a, IEnumerable<YQOGBIMEPLB> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x28FB5D0", Offset = "0x28FA5D0", VA = "0x1828FB5D0", Slot = "67")]
		public CircuitsData VPTVLPZZJLZ()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x28FBFA0", Offset = "0x28FAFA0", VA = "0x1828FBFA0", Slot = "68")]
		public CircuitsData XCVYRTKSLWS()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x28F6060", Offset = "0x28F5060", VA = "0x1828F6060", Slot = "71")]
		public CircuitsTemplateData CBRGZNHFZJD(TemplateSerializationReason a, Id32<YHQFEYRJQPY> sourceGraphId, IEnumerable<Id128<YHQFEYRJQPY>> graphIds, IEnumerable<Id128<QYHWLOYXTJM>> nodeIds, ISet<Id128<URSCSJBQKKC>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x28F7F70", Offset = "0x28F6F70", VA = "0x1828F7F70")]
		private CircuitsTemplateData GNXQCYUZIFC(TemplateSerializationReason a, Id32<YHQFEYRJQPY> sourceGraphId, IEnumerable<Id128<YHQFEYRJQPY>> graphIds, IEnumerable<Id128<QYHWLOYXTJM>> nodeIds, ISet<Id128<URSCSJBQKKC>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x28F7CF0", Offset = "0x28F6CF0", VA = "0x1828F7CF0", Slot = "69")]
		public CircuitsTemplateData GCCRBJIMQJG(TemplateSerializationReason a, Id32<YHQFEYRJQPY> sourceGraphId, IEnumerable<Id128<QYHWLOYXTJM>> nodeIds, IEnumerable<YQOGBIMEPLB> b, ISet<Id128<URSCSJBQKKC>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x28F7BE0", Offset = "0x28F6BE0", VA = "0x1828F7BE0", Slot = "70")]
		public CircuitsTemplateData GCCRBJIMQJG(TemplateSerializationReason a, Id32<YHQFEYRJQPY> sourceGraphId, IEnumerable<Id32<QYHWLOYXTJM>> nodeIds, IEnumerable<YQOGBIMEPLB> b, ISet<Id128<URSCSJBQKKC>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x28F9BF0", Offset = "0x28F8BF0", VA = "0x1828F9BF0")]
		private static IEnumerable<Id128<YHQFEYRJQPY>> NLTZEUTGSOA(IEnumerable<YQOGBIMEPLB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x28FADA0", Offset = "0x28F9DA0", VA = "0x1828FADA0")]
		private IEnumerable<Id128<QYHWLOYXTJM>> SQZMEBBYDYW(IEnumerable<YQOGBIMEPLB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x28F5C40", Offset = "0x28F4C40", VA = "0x1828F5C40", Slot = "72")]
		public List<NBPWEXQAHRP> ANSIYRKWASV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x28FA740", Offset = "0x28F9740", VA = "0x1828FA740")]
		public (List<NBPWEXQAHRP>, bool) SDINBFTGGJW([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, IBJTCLVNPXN b, ONVTNJKXENL c)
		{
			return default((List<NBPWEXQAHRP>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x28F5E00", Offset = "0x28F4E00", VA = "0x1828F5E00", Slot = "74")]
		public bool BNVUYJDVERX(Id32<YHQFEYRJQPY> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x28F9A40", Offset = "0x28F8A40", VA = "0x1828F9A40", Slot = "75")]
		public bool MIBXKOSWCNV(Id32<YHQFEYRJQPY> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x28F5DE0", Offset = "0x28F4DE0", VA = "0x1828F5DE0")]
		internal void BLZJDCJUKXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x28FB2C0", Offset = "0x28FA2C0", VA = "0x1828FB2C0")]
		internal Task TOFJNMURVYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x28FC730", Offset = "0x28FB730", VA = "0x1828FC730", Slot = "76")]
		public Result<Id32<JZMHXBKSKRV>?, WENLUTALDTF> ZSAZJOYYSMG(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<SUVSOCRKLLI> inputId)
		{
			return default(Result<Id32<JZMHXBKSKRV>?, WENLUTALDTF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x28F6AA0", Offset = "0x28F5AA0", VA = "0x1828F6AA0", Slot = "77")]
		public Result<Id32<SUVSOCRKLLI>?, WENLUTALDTF> EEJUSAQCPUC(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<JZMHXBKSKRV> outputId)
		{
			return default(Result<Id32<SUVSOCRKLLI>?, WENLUTALDTF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x28FBE90", Offset = "0x28FAE90", VA = "0x1828FBE90", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, WENLUTALDTF>> WNNEPNDMXBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x28FC030", Offset = "0x28FB030", VA = "0x1828FC030", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, WENLUTALDTF>> XLKYDXTDICT(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x28FA680", Offset = "0x28F9680", VA = "0x1828FA680", Slot = "80")]
		public Id32<QYHWLOYXTJM>? RXJGZWWBYUJ(Id32<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x28F9330", Offset = "0x28F8330", VA = "0x1828F9330", Slot = "81")]
		public Id32<QYHWLOYXTJM>? KOOYHNWQDQK(Id32<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x28F5E90", Offset = "0x28F4E90", VA = "0x1828F5E90", Slot = "82")]
		public int BORNPXDELDO(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x28F8DD0", Offset = "0x28F7DD0", VA = "0x1828F8DD0", Slot = "83")]
		public int JNNZZJZBSDX(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x28F64C0", Offset = "0x28F54C0", VA = "0x1828F64C0", Slot = "84")]
		public int CJVQPNHEBCK(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId, Id32<KRDUNWCYLJD> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x28FC1E0", Offset = "0x28FB1E0", VA = "0x1828FC1E0", Slot = "85")]
		public int YQHMWZEMGTS(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId, Id32<KRDUNWCYLJD> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x28F5F20", Offset = "0x28F4F20", VA = "0x1828F5F20", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, WENLUTALDTF>> BZIWQTBJTQW(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId, Id32<KRDUNWCYLJD> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x28FBD50", Offset = "0x28FAD50", VA = "0x1828FBD50", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, WENLUTALDTF>> WMLSMJHJKKL(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId, Id32<KRDUNWCYLJD> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x28FA420", Offset = "0x28F9420", VA = "0x1828FA420", Slot = "88")]
		public int POXNILOERGO(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x28F5A60", Offset = "0x28F4A60", VA = "0x1828F5A60", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, WENLUTALDTF>> AANTYLHBWTG(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x28F8C70", Offset = "0x28F7C70", VA = "0x1828F8C70", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, WENLUTALDTF>> JHPHNGVEZFL(Id32<YHQFEYRJQPY> graphId, Id32<QYHWLOYXTJM> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x28FC5C0", Offset = "0x28FB5C0", VA = "0x1828FC5C0", Slot = "91")]
		public bool ZLMRWRCWJNS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x28FB570", Offset = "0x28FA570", VA = "0x1828FB570", Slot = "97")]
		public IEnumerable<Id32<NNLJHAUAWWE>> USUBEEQCVTS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x28FB5B0", Offset = "0x28FA5B0", VA = "0x1828FB5B0", Slot = "98")]
		public string? UYUJBRAUGDK(Id32<NNLJHAUAWWE> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x28F89B0", Offset = "0x28F79B0", VA = "0x1828F89B0", Slot = "7")]
		private bool IXTPVGVMHEO(Id32<YHQFEYRJQPY> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x28F7B90", Offset = "0x28F6B90", VA = "0x1828F7B90", Slot = "24")]
		private KBQIDJEAJVG NREOAYDVHVZ([In] Id128<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x28F66D0", Offset = "0x28F56D0", VA = "0x1828F66D0", Slot = "26")]
		private Id32<YHQFEYRJQPY> SMZJXLIRUGO([In] Id128<YHQFEYRJQPY> graphId)
		{
			return default(Id32<YHQFEYRJQPY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x28F8EA0", Offset = "0x28F7EA0", VA = "0x1828F8EA0", Slot = "27")]
		private Id32<YHQFEYRJQPY>? JXULZRGTNWK([In] Id128<YHQFEYRJQPY> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x28F8890", Offset = "0x28F7890", VA = "0x1828F8890", Slot = "29")]
		private YYVRREXPLEY IADEFJMHPQB([In] Id128<QYHWLOYXTJM> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x28F5C80", Offset = "0x28F4C80", VA = "0x1828F5C80", Slot = "31")]
		private Id32<QYHWLOYXTJM> APCUYXKKJXG(Id32<YHQFEYRJQPY> graphId, [In] Id128<QYHWLOYXTJM> legacyNodeId)
		{
			return default(Id32<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x28F67A0", Offset = "0x28F57A0", VA = "0x1828F67A0", Slot = "45")]
		private NewStaticEdge IMWXKJASOHE(Id32<YHQFEYRJQPY> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x28F8690", Offset = "0x28F7690", VA = "0x1828F8690", Slot = "58")]
		private Result<ONSXKYCMZAP.PrepareTemplateForCloneResult, KTXQESFTWLM> RRMKSUXDQGA([In] ONSXKYCMZAP.PrepareTemplateForCloneArgs args)
		{
			return default(Result<ONSXKYCMZAP.PrepareTemplateForCloneResult, KTXQESFTWLM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x28FC2C0", Offset = "0x28FB2C0", VA = "0x1828FC2C0", Slot = "73")]
		private (List<NBPWEXQAHRP>, bool) YYZIVLOJLHC([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, IBJTCLVNPXN b, ONVTNJKXENL c)
		{
			return default((List<NBPWEXQAHRP>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x28F99D0", Offset = "0x28F89D0", VA = "0x1828F99D0")]
		[CompilerGenerated]
		private WHXCBDSEQVC MHGRXPRJMLT(GAOEGFJDZSW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x28F89F0", Offset = "0x28F79F0", VA = "0x1828F89F0")]
		[CompilerGenerated]
		private TYZPRJYTRRB JCRCFEUGDWR(Id128<QYHWLOYXTJM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x28F89C0", Offset = "0x28F79C0", VA = "0x1828F89C0")]
		[CompilerGenerated]
		private XQGXKQNGDGG JCLVHYAIULI(Id128<YHQFEYRJQPY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x28F89F0", Offset = "0x28F79F0", VA = "0x1828F89F0")]
		[CompilerGenerated]
		private TYZPRJYTRRB ZENGBPIPMPT(Id128<QYHWLOYXTJM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x28F89C0", Offset = "0x28F79C0", VA = "0x1828F89C0")]
		[CompilerGenerated]
		private XQGXKQNGDGG ZEHZEIOSDEK(Id128<YHQFEYRJQPY> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class WHXCBDSEQVC : NIWXUTPBRAL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		[CompilerGenerated]
		private struct <AddInputDef>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public AsyncTaskMethodBuilder<Result<Id32<KRDUNWCYLJD>, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public WHXCBDSEQVC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<QYHWLOYXTJM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<JPZDQKXUTWI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<KRDUNWCYLJD>, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x29034B0", Offset = "0x29024B0", VA = "0x1829034B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2903700", Offset = "0x2902700", VA = "0x182903700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		[CompilerGenerated]
		private struct <AddOutputDef>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public AsyncTaskMethodBuilder<Result<Id32<DSRIXMVNJVY>, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public WHXCBDSEQVC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<YHQFEYRJQPY> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<QYHWLOYXTJM> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<JPZDQKXUTWI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<DSRIXMVNJVY>, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x2903770", Offset = "0x2902770", VA = "0x182903770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x29039C0", Offset = "0x29029C0", VA = "0x1829039C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly GAOEGFJDZSW BYCPIGYUTCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly THPTAACPNZD IEBOMHSLGGR;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey EBKZISHOFNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string HHODNGIDXAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x29007E0", Offset = "0x28FF7E0", VA = "0x1829007E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public GAOEGFJDZSW GAOEGFJDZSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2909AB0", Offset = "0x2908AB0", VA = "0x182909AB0")]
		public WHXCBDSEQVC(GAOEGFJDZSW a, THPTAACPNZD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x29097D0", Offset = "0x29087D0", VA = "0x1829097D0", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<KRDUNWCYLJD>, WENLUTALDTF>> GQIOGGGJMND(Id128<YHQFEYRJQPY> graphId, Id128<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2909940", Offset = "0x2908940", VA = "0x182909940", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<DSRIXMVNJVY>, WENLUTALDTF>> ICYKGDIAEVA(Id128<YHQFEYRJQPY> graphId, Id128<QYHWLOYXTJM> nodeId, Id32<JPZDQKXUTWI> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class JBPPBFQJGTI : KDUAUZXMWOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly GAOEGFJDZSW WMRFDFDZTOW;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<GAOEGFJDZSW> QFDNAYQLKLS;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<GAOEGFJDZSW> ZDGWQMXUGQV;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<GAOEGFJDZSW> PJIQWKKONVG;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public GAOEGFJDZSW GLAENVNETGX
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x29020F0", Offset = "0x29010F0", VA = "0x1829020F0", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x29020E0", Offset = "0x29010E0", VA = "0x1829020E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x2902140", Offset = "0x2901140", VA = "0x182902140", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2902060", Offset = "0x2901060", VA = "0x182902060", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x29003E0", Offset = "0x28FF3E0", VA = "0x1829003E0")]
		public bool FMGGDPLVGDZ(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public JBPPBFQJGTI(GAOEGFJDZSW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2900650", Offset = "0x28FF650", VA = "0x182900650")]
		internal static TypeKey QRIMZCSLEGY(GAOEGFJDZSW a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x29007E0", Offset = "0x28FF7E0", VA = "0x1829007E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Injection
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	public readonly struct ActionDeps : NKGUVMYRRNL.BOCBJLBYSGU<PQYWNUACEKJ, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x28F5860", Offset = "0x28F4860", VA = "0x1828F5860", Slot = "4")]
		public int NMRVQWIJNRQ(None a, PQYWNUACEKJ b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x28F5810", Offset = "0x28F4810", VA = "0x1828F5810", Slot = "5")]
		public PQYWNUACEKJ IMTROEHHFNH(None a, PQYWNUACEKJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x28F58A0", Offset = "0x28F48A0", VA = "0x1828F58A0", Slot = "6")]
		public PQYWNUACEKJ SPOWPPWBHSS(None a, PQYWNUACEKJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x28F58F0", Offset = "0x28F48F0", VA = "0x1828F58F0", Slot = "7")]
		public IReadOnlyList<PQYWNUACEKJ> XBENKHUDVIM(None a, PQYWNUACEKJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x28F57E0", Offset = "0x28F47E0", VA = "0x1828F57E0", Slot = "8")]
		public PQYWNUACEKJ[] FEXXDJBACRJ(None a, PQYWNUACEKJ b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x28F57F0", Offset = "0x28F47F0", VA = "0x1828F57F0", Slot = "9")]
		public bool GAVHTDUZTNW(None a, PQYWNUACEKJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x28F57C0", Offset = "0x28F47C0", VA = "0x1828F57C0", Slot = "10")]
		public bool DXAYXPVWGAC(None a, PQYWNUACEKJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x28F5880", Offset = "0x28F4880", VA = "0x1828F5880", Slot = "11")]
		public bool PLUWQGLLDCI(None a, PQYWNUACEKJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x28F58D0", Offset = "0x28F48D0", VA = "0x1828F58D0", Slot = "12")]
		public bool UQJJSFTTLJA(None a, PQYWNUACEKJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x28F5820", Offset = "0x28F4820", VA = "0x1828F5820", Slot = "13")]
		public bool KDNHNKUMDWY(None a, PQYWNUACEKJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x28F5840", Offset = "0x28F4840", VA = "0x1828F5840", Slot = "14")]
		public bool KHHRVNUCKLH(None a, PQYWNUACEKJ b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class DFUZZGMLPKX : DPGTGQXFVAL
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract UIREVXYUNXH.OAIZGCDVQOY QQRVOEQPRMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract UOILJAPMYSC.OAIZGCDVQOY SDBIWRFJWSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract YDXEBHQLRCV.OAIZGCDVQOY BDDWPDEHHVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC> DAAXGYBMJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x28F5910", Offset = "0x28F4910", VA = "0x1828F5910", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.OAIZGCDVQOY WDCGBECLVNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract QDTLTHTSXNH CHLMVZKAAGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract GHEKOECVSUE ORWRCEUNBON
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract YHJIQBACQBQ VOBKBRFJJRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract GQQCNTKRUZA LGTNDZQQNBP
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract ZOCCJHRAKXK IAIREJBMFXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected DFUZZGMLPKX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class INJRZEHGHZB : VEAPDZSAPDH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		[CompilerGenerated]
		private struct <Multi>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public AsyncTaskMethodBuilder<Result<MultiResult, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<PQYWNUACEKJ> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public INJRZEHGHZB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2903FF0", Offset = "0x2902FF0", VA = "0x182903FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2904410", Offset = "0x2903410", VA = "0x182904410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000146")]
		[CompilerGenerated]
		private struct <Request>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public AsyncTaskMethodBuilder<Result<object, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public INJRZEHGHZB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public PQYWNUACEKJ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x2908D80", Offset = "0x2907D80", VA = "0x182908D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2908F90", Offset = "0x2907F90", VA = "0x182908F90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly BKAMUOKSWTC JPFLNFZWVGK;

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public INJRZEHGHZB(BKAMUOKSWTC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x28FE210", Offset = "0x28FD210", VA = "0x1828FE210")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, WENLUTALDTF>> TUJNFMUNDGY(PQYWNUACEKJ a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x28FE0E0", Offset = "0x28FD0E0", VA = "0x1828FE0E0", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, WENLUTALDTF>> KISJWMYTSGU(IReadOnlyList<PQYWNUACEKJ> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PQYWNUACEKJ, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x104DAA0", Offset = "0x104CAA0", VA = "0x18104DAA0")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PQYWNUACEKJ, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2903010", Offset = "0x2902010", VA = "0x182903010")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class BLQESLAYXOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xB95CC0", Offset = "0xB94CC0", VA = "0x180B95CC0")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PQYWNUACEKJ, PartialActionReassemblyDeps> SKNXRLRNMAN(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PQYWNUACEKJ, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : AKDRVDSWNXV.GJLSAJUAVJH<PartialActionPayload, Id128<PartialActionPayload.M>, PQYWNUACEKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2902E30", Offset = "0x2901E30", VA = "0x182902E30", Slot = "7")]
		public PQYWNUACEKJ HRVUZKATJAD(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x10431A0", Offset = "0x10421A0", VA = "0x1810431A0")]
		public Id128<PartialActionPayload.M> RXCKFXHIGIP([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0xDADE20", Offset = "0xDACE20", VA = "0x180DADE20")]
		public int DHERHNXXBEN([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2902E20", Offset = "0x2901E20", VA = "0x182902E20")]
		public int HLYBDOZDVVA([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xDADE20", Offset = "0xDACE20", VA = "0x180DADE20", Slot = "4")]
		private int SYZCMHLWEFZ([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2902E20", Offset = "0x2901E20", VA = "0x182902E20", Slot = "5")]
		private int SFBFGGOHEKE([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x10431A0", Offset = "0x10421A0", VA = "0x1810431A0", Slot = "6")]
		private Id128<PartialActionPayload.M> BWOEJGRVITT([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, PQYWNUACEKJ, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x104DAA0", Offset = "0x104CAA0", VA = "0x18104DAA0")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, PQYWNUACEKJ, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2903450", Offset = "0x2902450", VA = "0x182903450")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class TPMUHWQQNER
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xB95CC0", Offset = "0xB94CC0", VA = "0x180B95CC0")]
		public static SnapshotReassembly<PartialInitializePayload, PQYWNUACEKJ, SnapshotReassemblyDeps> SKNXRLRNMAN(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, PQYWNUACEKJ, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : YTZQFQWBTDM.GJGLDDADLXY<PartialInitializePayload, PQYWNUACEKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xDADDD0", Offset = "0xDACDD0", VA = "0x180DADDD0")]
		public int ZVUUEANAWHN([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2903270", Offset = "0x2902270", VA = "0x182903270", Slot = "5")]
		public PQYWNUACEKJ DIINAYAZWPH(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xDADDD0", Offset = "0xDACDD0", VA = "0x180DADDD0", Slot = "4")]
		private int MXYLXHZOHQF([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class YGSVIGNBMAH : DEINNYDYQPE, KTXQESFTWLM, WENLUTALDTF, IMZVXBWNFZH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly IMZVXBWNFZH? XZHVHTOPCYX;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind GMGTQKAJVHL
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xAD12C0", Offset = "0xAD02C0", VA = "0x180AD12C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override IMZVXBWNFZH? STVFFCVWZWU
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2909B70", Offset = "0x2908B70", VA = "0x182909B70", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2909DA0", Offset = "0x2908DA0", VA = "0x182909DA0")]
		private YGSVIGNBMAH(PrepareTemplateForCloneErrKind a, IMZVXBWNFZH? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2909D30", Offset = "0x2908D30", VA = "0x182909D30")]
		public static YGSVIGNBMAH WJQSQHLDJTN(IMZVXBWNFZH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x2909CD0", Offset = "0x2908CD0", VA = "0x182909CD0")]
		public static YGSVIGNBMAH TMABNRZIRVV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x2909C70", Offset = "0x2908C70", VA = "0x182909C70")]
		public static YGSVIGNBMAH JTHCMVRIBNH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class LVWFIFKRZNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x3820F90", Offset = "0x381FF90", VA = "0x183820F90")]
		public static Result<TOk, KTXQESFTWLM> FWUUALTLVUY<TOk>([In] this Result<TOk, KTXQESFTWLM> self, IMZVXBWNFZH a) where TOk : notnull
		{
			return default(Result<TOk, KTXQESFTWLM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x38211D0", Offset = "0x38201D0", VA = "0x1838211D0")]
		public static Result<a?, KTXQESFTWLM?> IRBECATLRDE<a>([In] this Result<a, KTXQESFTWLM> self)
		{
			return default(Result<a, KTXQESFTWLM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x3820F10", Offset = "0x381FF10", VA = "0x183820F10")]
		public static Result<b?, KTXQESFTWLM?> DFVNAZVOXXG<b>([In] this Result<b, KTXQESFTWLM> self)
		{
			return default(Result<b, KTXQESFTWLM>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface QDTLTHTSXNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LCWVCBXQFQD([In] Result<None, IMZVXBWNFZH> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class GANNEPKHFRF
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x3748750", Offset = "0x3747750", VA = "0x183748750")]
		public static bool LCWVCBXQFQD<TOk, TErr>(this QDTLTHTSXNH a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, IMZVXBWNFZH
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface GHEKOECVSUE
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		TNNPXTPLORO XMLXBJXETJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface YHJIQBACQBQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor EMGOVBGHJTJ(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface CKQWSGIEVHF
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface VPBEDTVFQOY
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YJGLKQMHZDM? CUTHBUPKQJD(Id32<JPZDQKXUTWI> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface ISWNGJWJXTS
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface YJGLKQMHZDM
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ISWNGJWJXTS? MOUUEWRCAPN(Id32<KRDUNWCYLJD> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CKQWSGIEVHF? QVYKRMCIPZE(Id32<DSRIXMVNJVY> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface GQQCNTKRUZA
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> WBLDKQQFFJW(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface ZOCCJHRAKXK
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		VPBEDTVFQOY? SKNPNFFFYUZ([In] Id128<XWYEQLTFQES> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class LXFVFDEQLXJ
	{
		[Cpp2IlInjected.Token(Token = "0x200015C")]
		private struct Diagnostic
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public int Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public CircuitRootData? BaseState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public CircuitRootData? FinalState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public readonly List<PQYWNUACEKJ> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x28F5A10", Offset = "0x28F4A10", VA = "0x1828F5A10")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<PQYWNUACEKJ> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x28F5960", Offset = "0x28F4960", VA = "0x1828F5960")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly FREAHRMXRMQ<Diagnostic> WJWPTJIISDH;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static LXFVFDEQLXJ QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x2902260", Offset = "0x2901260", VA = "0x182902260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool BJCNYSGZVGR
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xB21140", Offset = "0xB20140", VA = "0x180B21140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xBA8E20", Offset = "0xBA7E20", VA = "0x180BA8E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2902750", Offset = "0x2901750", VA = "0x182902750")]
		public void ZSTJCRNKBVK(THPTAACPNZD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x29022B0", Offset = "0x29012B0", VA = "0x1829022B0")]
		public void KTHAHRZOQWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2902590", Offset = "0x2901590", VA = "0x182902590")]
		private static string? NQQCUHDNBVH([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2902900", Offset = "0x2901900", VA = "0x182902900")]
		public LXFVFDEQLXJ()
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
