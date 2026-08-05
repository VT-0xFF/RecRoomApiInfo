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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B26B40", Offset = "0x2B25B40", VA = "0x182B26B40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B265D0", Offset = "0x2B255D0", VA = "0x182B265D0", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class COWOBFPVIKZ : IDisposable, WDIPXWWJJAG, NIHRXRZWCDF, WZIUJKNCAHY
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class EMEDYSEXMVG : UYPXTMTCQYP
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int TGLERDWXTFW
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2B17DF0", Offset = "0x2B16DF0", VA = "0x182B17DF0", Slot = "5")]
			public RZKCOKFPWZF UGOFEYAQNZW(VWOBBTEHFZU.UYPXTMTCQYP a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void PIUMIAWMBPW();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void DCEQZLTZWHR();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B6F0", Offset = "0x2B0A6F0", VA = "0x182B0B6F0", Slot = "13")]
			public virtual void FGQGFVNGOBH(COWOBFPVIKZ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2B17D70", Offset = "0x2B16D70", VA = "0x182B17D70", Slot = "14")]
			public virtual void OIMJRSDSENM(COWOBFPVIKZ a, PYPEGOPZPPS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			protected EMEDYSEXMVG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface UYPXTMTCQYP
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int TGLERDWXTFW
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			RZKCOKFPWZF UGOFEYAQNZW(VWOBBTEHFZU.UYPXTMTCQYP a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void PIUMIAWMBPW();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void DCEQZLTZWHR();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void FGQGFVNGOBH(COWOBFPVIKZ a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void OIMJRSDSENM(COWOBFPVIKZ a, PYPEGOPZPPS b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ, XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
			internal Reducer(Reducer<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ, XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class WKZLHXAPLUY : XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly WKZLHXAPLUY CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private WKZLHXAPLUY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1529E50", Offset = "0x1528E50", VA = "0x181529E50", Slot = "4")]
			public ActionKind ZHNLJWSSYKM(PYPEGOPZPPS a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2B366F0", Offset = "0x2B356F0", VA = "0x182B366F0", Slot = "5")]
			public void FGQGFVNGOBH(COWOBFPVIKZ a, PYPEGOPZPPS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2B367F0", Offset = "0x2B357F0", VA = "0x182B367F0", Slot = "6")]
			public void OIMJRSDSENM(COWOBFPVIKZ a, PYPEGOPZPPS b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ, XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2B29AF0", Offset = "0x2B28AF0", VA = "0x182B29AF0")]
			internal ReducerFactory(ReducerFactory<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ, XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2B29AA0", Offset = "0x2B28AA0", VA = "0x182B29AA0")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : DZRBQUPXGSQ.PFCXERMDFKQ<PYPEGOPZPPS, COWOBFPVIKZ>
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
				public AsyncTaskMethodBuilder<Result<object?, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public COWOBFPVIKZ receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public PYPEGOPZPPS action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B430", Offset = "0x2B2A430", VA = "0x182B2B430", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B610", Offset = "0x2B2A610", VA = "0x182B2B610", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD5A510", Offset = "0xD59510", VA = "0x180D5A510", Slot = "4")]
			public Id32<WNPWZNYIVVQ> FDVHIIAJUMT(COWOBFPVIKZ a)
			{
				return default(Id32<WNPWZNYIVVQ>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2B29EF0", Offset = "0x2B28EF0", VA = "0x182B29EF0", Slot = "5")]
			public void SIMZEIXXWZK(COWOBFPVIKZ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2B29F50", Offset = "0x2B28F50", VA = "0x182B29F50", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, MCRZZCNKUJE>> VCNDPOOUIXD(COWOBFPVIKZ a, PYPEGOPZPPS b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A080", Offset = "0x2B29080", VA = "0x182B2A080", Slot = "7")]
			public PYPEGOPZPPS[] YGJNXDIJIND(COWOBFPVIKZ a)
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
			public AsyncTaskMethodBuilder<Result<object?, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public COWOBFPVIKZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public PYPEGOPZPPS action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2B2B680", Offset = "0x2B2A680", VA = "0x182B2B680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2B2B870", Offset = "0x2B2A870", VA = "0x182B2B870", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public COWOBFPVIKZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2B2CDA0", Offset = "0x2B2BDA0", VA = "0x182B2CDA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D020", Offset = "0x2B2C020", VA = "0x182B2D020", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public COWOBFPVIKZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D090", Offset = "0x2B2C090", VA = "0x182B2D090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D270", Offset = "0x2B2C270", VA = "0x182B2D270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<WNPWZNYIVVQ> JXAVPSBARQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer NHKANDYJDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 BJECMKCETEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly ITTJCCLXRJK TAKVDJEVSET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly SEQOFYDKXBO.CreationArgs DCZORRUVJSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly WICVOEHUFCF KVHFEAZQSBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly FFEMUSLXLUQ SKWFLGREOZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly BHCANWTTFHZ WCDGANZKHZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly YCFMSDYLAVK IVTKXQOHZFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly EHTXORRPEAU CBISQMZAJXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly HCBSQHGXZYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly IKZTFXSXTVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest JMDJWTKAOJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended SUONEOUUINN;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal UYPXTMTCQYP VJJOCRQLJQC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2B16DD0", Offset = "0x2B15DD0", VA = "0x182B16DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal RZKCOKFPWZF GTLHRVHKXZM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2B16BE0", Offset = "0x2B15BE0", VA = "0x182B16BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2B15FF0", Offset = "0x2B14FF0", VA = "0x182B15FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool NVUMPXNIFEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2B165D0", Offset = "0x2B155D0", VA = "0x182B165D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B16DC0", Offset = "0x2B15DC0", VA = "0x182B16DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public JMQPTJPXSVC WICVOEHUFCF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B17520", Offset = "0x2B16520", VA = "0x182B17520", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public QMWLHXUPTRG BHCANWTTFHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2B17530", Offset = "0x2B16530", VA = "0x182B17530", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FMQLZJSTKGH EHTXORRPEAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2B17550", Offset = "0x2B16550", VA = "0x182B17550", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public KXLSTNRBYUL FFEMUSLXLUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B16E20", Offset = "0x2B15E20", VA = "0x182B16E20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JATPSMBYSGN YCFMSDYLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2B17540", Offset = "0x2B16540", VA = "0x182B17540", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public SEQOFYDKXBO? SEQOFYDKXBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2B165E0", Offset = "0x2B155E0", VA = "0x182B165E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B17230", Offset = "0x2B16230", VA = "0x182B17230")]
		private COWOBFPVIKZ(ITTJCCLXRJK a, Id32<WNPWZNYIVVQ> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, RZKCOKFPWZF b, [In] SEQOFYDKXBO.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B16850", Offset = "0x2B15850", VA = "0x182B16850")]
		public static COWOBFPVIKZ New(ITTJCCLXRJK deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<WNPWZNYIVVQ> actorId, Id32<ZKEUEWDMUHX> rootNetworkObjectId, SWFQECRPDPB staticNetSys, BAULKDCDPAL dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B16920", Offset = "0x2B15920", VA = "0x182B16920")]
		public static COWOBFPVIKZ New(ITTJCCLXRJK dependencies, [In] RegistryV2 registryV2, Id32<WNPWZNYIVVQ> actorId, Id32<ZKEUEWDMUHX> rootNetworkObjectId, SWFQECRPDPB staticNetSys, BAULKDCDPAL dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B16010", Offset = "0x2B15010", VA = "0x182B16010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B164E0", Offset = "0x2B154E0", VA = "0x182B164E0")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, MCRZZCNKUJE>> FKCJBJSNDWE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B163F0", Offset = "0x2B153F0", VA = "0x182B163F0")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, MCRZZCNKUJE>> EYNUYLLELCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B161F0", Offset = "0x2B151F0", VA = "0x182B161F0")]
		internal void EWTAVOIRBID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B15F70", Offset = "0x2B14F70", VA = "0x182B15F70")]
		internal Option<PYPEGOPZPPS> CKVGNFAYELW([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<PYPEGOPZPPS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B16D00", Offset = "0x2B15D00", VA = "0x182B16D00")]
		internal bool SGJOQSXTHML([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B166C0", Offset = "0x2B156C0", VA = "0x182B166C0")]
		internal Result<PYPEGOPZPPS, MCRZZCNKUJE> IRBOAKOKKAQ([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<PYPEGOPZPPS, MCRZZCNKUJE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B16D70", Offset = "0x2B15D70", VA = "0x182B16D70")]
		private void SIMZEIXXWZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B16BF0", Offset = "0x2B15BF0", VA = "0x182B16BF0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, MCRZZCNKUJE>> RMXULWHUQSU(PYPEGOPZPPS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B16E30", Offset = "0x2B15E30", VA = "0x182B16E30")]
		private PYPEGOPZPPS[] YGJNXDIJIND()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class JTLYBJBIJHP<a> : SIEDSHFPKXL, WWQASFLRMAZ, YCREHOYWOHO where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<ISSDUATOTVT>? EFIUGHSYRZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a YTUTJGBWUDQ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<ISSDUATOTVT>? YBOALRVUMPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2E1F4F0", Offset = "0x2E1E4F0", VA = "0x182E1F4F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6748F80", Offset = "0x6747F80", VA = "0x186748F80")]
		internal JTLYBJBIJHP([In] Id128<ISSDUATOTVT>? lastNode, Id32<GWVCCMPWDTY>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class YBPOVNGBPTT
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B36970", Offset = "0x2B35970", VA = "0x182B36970")]
		public static Result<DebugExecutionResult, WWQASFLRMAZ> MXFGHAKUJSO([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, WWQASFLRMAZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4116350", Offset = "0x4115350", VA = "0x184116350")]
		public static Result<TOk, WWQASFLRMAZ> EKCFJILXEXY<TOk>([In] this Result<TOk, WWQASFLRMAZ> self, [In] Id128<ISSDUATOTVT>? lastNode, Id32<GWVCCMPWDTY>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, WWQASFLRMAZ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ITTJCCLXRJK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		VWOBBTEHFZU.UYPXTMTCQYP XXRHGSDVDGM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		COWOBFPVIKZ.UYPXTMTCQYP NRNPGXXKVKX
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		ZJXORRQKNEA.UYPXTMTCQYP BTQPUYQWRZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ> WKZLHXAPLUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.UYPXTMTCQYP RPJYXJCXWYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		MTGSWKHGETU KUVBRNXXCXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		RYRAUZOHXNB PTRPROVCCXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		HRTUZVSWSVJ VZLAGHYLIGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		ETFDRUOMIST HJOPHRGSYEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		STIVPCHXXDL CHTEPJGYIBK
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
	public static class TQDGUTYBIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A800", Offset = "0x2B29800", VA = "0x182B2A800")]
		public static PYPEGOPZPPS GNOOKESNHUK(this PYPEGOPZPPS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A910", Offset = "0x2B29910", VA = "0x182B2A910")]
		public static PYPEGOPZPPS GPMURNMGHLH(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public COWOBFPVIKZ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B2B8E0", Offset = "0x2B2A8E0", VA = "0x182B2B8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B2C000", Offset = "0x2B2B000", VA = "0x182B2C000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B178B0", Offset = "0x2B168B0", VA = "0x182B178B0")]
		public static PYPEGOPZPPS OHCKXPLPMXU(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B17800", Offset = "0x2B16800", VA = "0x182B17800")]
		public static ReduceAction<ActionKind, CompressedPayload> LCNVIMUENEL(PYPEGOPZPPS actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B17970", Offset = "0x2B16970", VA = "0x182B17970")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, MCRZZCNKUJE>> RMXULWHUQSU(COWOBFPVIKZ a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B17B70", Offset = "0x2B16B70", VA = "0x182B17B70")]
		public static PYPEGOPZPPS OHCKXPLPMXU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B17B00", Offset = "0x2B16B00", VA = "0x182B17B00")]
		public static ReduceAction<ActionKind, DestroyPayload> LCNVIMUENEL(PYPEGOPZPPS actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B17A80", Offset = "0x2B16A80", VA = "0x182B17A80")]
		public static Result<None, HCFARDHKLRV> EIBQIVIMYOY(COWOBFPVIKZ a, [In] DestroyPayload self)
		{
			return default(Result<None, HCFARDHKLRV>);
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
			public AsyncTaskMethodBuilder<Result<None, HCFARDHKLRV>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public COWOBFPVIKZ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, HCFARDHKLRV> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B2C0E0", Offset = "0x2B2B0E0", VA = "0x182B2C0E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B2C680", Offset = "0x2B2B680", VA = "0x182B2C680", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F2E2E0", Offset = "0x1F2D2E0", VA = "0x181F2E2E0")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B18030", Offset = "0x2B17030", VA = "0x182B18030")]
		public static PYPEGOPZPPS? OHCKXPLPMXU(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B17F20", Offset = "0x2B16F20", VA = "0x182B17F20")]
		public static ReduceAction<ActionKind, FullInitializePayload> LCNVIMUENEL(PYPEGOPZPPS actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B18130", Offset = "0x2B17130", VA = "0x182B18130")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, HCFARDHKLRV>> RMXULWHUQSU(COWOBFPVIKZ a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public COWOBFPVIKZ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, MCRZZCNKUJE> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, YCREHOYWOHO>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, YCREHOYWOHO> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, YCREHOYWOHO>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BBA0", Offset = "0x2B2ABA0", VA = "0x182B2BBA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B2C070", Offset = "0x2B2B070", VA = "0x182B2C070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<PYPEGOPZPPS> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		private MultiPayload(IReadOnlyList<PYPEGOPZPPS> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B267C0", Offset = "0x2B257C0", VA = "0x182B267C0")]
		public static PYPEGOPZPPS OHCKXPLPMXU(IReadOnlyList<PYPEGOPZPPS> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B26720", Offset = "0x2B25720", VA = "0x182B26720")]
		public static ReduceAction<ActionKind, MultiPayload> LCNVIMUENEL(PYPEGOPZPPS actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B26880", Offset = "0x2B25880", VA = "0x182B26880")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, MCRZZCNKUJE>> RMXULWHUQSU(COWOBFPVIKZ a, MultiPayload b)
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
		private sealed class PEUYNJHNJIR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> WBRTUWUYZNT;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public PEUYNJHNJIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B26E40", Offset = "0x2B25E40", VA = "0x182B26E40")]
			internal PYPEGOPZPPS NGIXECYJOJL(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x2B27F50", Offset = "0x2B26F50", VA = "0x182B27F50")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B27E40", Offset = "0x2B26E40", VA = "0x182B27E40")]
		public static PYPEGOPZPPS OHCKXPLPMXU(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B27BF0", Offset = "0x2B26BF0", VA = "0x182B27BF0")]
		public static PYPEGOPZPPS[] GMHTYOABCUV(PYPEGOPZPPS a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B27CF0", Offset = "0x2B26CF0", VA = "0x182B27CF0")]
		public static ReduceAction<ActionKind, PartialActionPayload> LCNVIMUENEL(PYPEGOPZPPS actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B27A50", Offset = "0x2B26A50", VA = "0x182B27A50")]
		public static Result<PYPEGOPZPPS, MCRZZCNKUJE> EIBQIVIMYOY(COWOBFPVIKZ a, [In] PartialActionPayload self)
		{
			return default(Result<PYPEGOPZPPS, MCRZZCNKUJE>);
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
			public AsyncTaskMethodBuilder<Result<bool, HCFARDHKLRV>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public COWOBFPVIKZ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, HCFARDHKLRV> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, HCFARDHKLRV>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2B2C6F0", Offset = "0x2B2B6F0", VA = "0x182B2C6F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B2CD30", Offset = "0x2B2BD30", VA = "0x182B2CD30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xD9F570", Offset = "0xD9E570", VA = "0x180D9F570")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B28250", Offset = "0x2B27250", VA = "0x182B28250")]
		public static PYPEGOPZPPS OHCKXPLPMXU(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B27F70", Offset = "0x2B26F70", VA = "0x182B27F70")]
		public static PYPEGOPZPPS?[]? AJWPCWFIZPL(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B28170", Offset = "0x2B27170", VA = "0x182B28170")]
		public static ReduceAction<ActionKind, PartialInitializePayload> LCNVIMUENEL(PYPEGOPZPPS actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B28330", Offset = "0x2B27330", VA = "0x182B28330")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, HCFARDHKLRV>> RMXULWHUQSU(COWOBFPVIKZ a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class WICVOEHUFCF : JMQPTJPXSVC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly COWOBFPVIKZ YTSLYIPCPMW;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public WHMIZMGZCGD? CIARLSLMHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B365F0", Offset = "0x2B355F0", VA = "0x182B365F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		internal WICVOEHUFCF(COWOBFPVIKZ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class QQTZTXNHSNY : WHMIZMGZCGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly COWOBFPVIKZ YTSLYIPCPMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly SEQOFYDKXBO MATSITTHXMY;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2A0", Offset = "0xCFA2A0", VA = "0x180CFB2A0")]
		public QQTZTXNHSNY(COWOBFPVIKZ a, SEQOFYDKXBO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B28C80", Offset = "0x2B27C80", VA = "0x182B28C80", Slot = "4")]
		public Result<DebugExecutionResult, WWQASFLRMAZ> XGIVHRIBLFG(Id128<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<FBIPJIAHSMB> inputId)
		{
			return default(Result<DebugExecutionResult, WWQASFLRMAZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B286D0", Offset = "0x2B276D0", VA = "0x182B286D0", Slot = "5")]
		public Result<DebugExecutionResult, WWQASFLRMAZ> LEGDMENLJCP(Id128<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<HDSUEKONMVO> outputId)
		{
			return default(Result<DebugExecutionResult, WWQASFLRMAZ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class VWOBBTEHFZU : RZKCOKFPWZF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface UYPXTMTCQYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<GIIFHFQKBOL> DXNFTVSWGVQ(COWOBFPVIKZ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void TXLETOGGZNA(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class EMEDYSEXMVG : UYPXTMTCQYP
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
				public AsyncTaskMethodBuilder<GIIFHFQKBOL> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public COWOBFPVIKZ circuitsManager;

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
				private TaskAwaiter<ZJXORRQKNEA> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A9E0", Offset = "0x2B299E0", VA = "0x182B2A9E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2ABB0", Offset = "0x2B29BB0", VA = "0x182B2ABB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B17C10", Offset = "0x2B16C10", VA = "0x182B17C10", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<GIIFHFQKBOL> DXNFTVSWGVQ(COWOBFPVIKZ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void TXLETOGGZNA(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			protected EMEDYSEXMVG()
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
			public AsyncTaskMethodBuilder<GIIFHFQKBOL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public VWOBBTEHFZU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B2AC20", Offset = "0x2B29C20", VA = "0x182B2AC20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B2AE20", Offset = "0x2B29E20", VA = "0x182B2AE20", Slot = "5")]
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
			public VWOBBTEHFZU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public COWOBFPVIKZ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<GIIFHFQKBOL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2B2AE90", Offset = "0x2B29E90", VA = "0x182B2AE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B2B3D0", Offset = "0x2B2A3D0", VA = "0x182B2B3D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly UYPXTMTCQYP BIQCNNIQICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> VYEKKUFZEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> DUVZACVJSIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource RRLOCOOJVPH;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool NVUMPXNIFEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD4F720", Offset = "0xD4E720", VA = "0x180D4F720", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD4F620", Offset = "0xD4E620", VA = "0x180D4F620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF4DE70", Offset = "0xF4CE70", VA = "0x180F4DE70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xF93080", Offset = "0xF92080", VA = "0x180F93080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool CSIFBKDXKAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1AC1550", Offset = "0x1AC0550", VA = "0x181AC1550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1B17890", Offset = "0x1B16890", VA = "0x181B17890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public GIIFHFQKBOL? CIARLSLMHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCFC360", Offset = "0xCFB360", VA = "0x180CFC360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B362C0", Offset = "0x2B352C0", VA = "0x182B362C0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<GIIFHFQKBOL> IRXCRXKOKEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B364F0", Offset = "0x2B354F0", VA = "0x182B364F0")]
		public VWOBBTEHFZU(UYPXTMTCQYP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B363B0", Offset = "0x2B353B0", VA = "0x182B363B0", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task LZKVPNWDWAI(COWOBFPVIKZ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B36150", Offset = "0x2B35150", VA = "0x182B36150", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class BQOBYOYTSZR : NBJCCMNYJBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly DNGQBKSNALR UUDDBPOCJZI;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public BQOBYOYTSZR(DNGQBKSNALR a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class NSOBJHLNZDW
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class EZRIJBDTEJY<a> : OOFXQBZYQXD where a : FDUYIFBBDJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a GGQWZEEHFOZ;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? TRBWWAHQKJV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xF0CAC0", Offset = "0xF0BAC0", VA = "0x180F0CAC0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<ISSDUATOTVT>? SLTCHIIEJVB
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x5B62940", Offset = "0x5B61940", VA = "0x185B62940", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<YUFXTHDQAZB> TPKSAYVBGKX
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2E05230", Offset = "0x2E04230", VA = "0x182E05230", Slot = "5")]
				get
				{
					return default(Id32<YUFXTHDQAZB>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<YUFXTHDQAZB>? XMSHELJNAXN
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x5B629F0", Offset = "0x5B619F0", VA = "0x185B629F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
			public EZRIJBDTEJY(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class HBPSFSHKOUA : EZRIJBDTEJY<SKRRRKTHRNM>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? TRBWWAHQKJV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x1052E50", Offset = "0x1051E50", VA = "0x181052E50", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B19260", Offset = "0x2B18260", VA = "0x182B19260")]
			public HBPSFSHKOUA(SKRRRKTHRNM a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B269C0", Offset = "0x2B259C0", VA = "0x182B269C0")]
		public static OOFXQBZYQXD New(FDUYIFBBDJV graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class UOHKHVUFXJC : HGSUVJRLAFJ, RHMKGKFUMBP, YKOXFKAMQGI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class HNWBLYUHVKC
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
				public HNWBLYUHVKC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public MTGSWKHGETU errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B2E470", Offset = "0x2B2D470", VA = "0x182B2E470", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x2B2E6E0", Offset = "0x2B2D6E0", VA = "0x182B2E6E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public UOHKHVUFXJC NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool ZRDYZWJLLET;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public HNWBLYUHVKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B19330", Offset = "0x2B18330", VA = "0x182B19330")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task OAJLYYFURZQ(MTGSWKHGETU a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class RECYFJRDOZU
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
				public RECYFJRDOZU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x2B2E740", Offset = "0x2B2D740", VA = "0x182B2E740", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EA20", Offset = "0x2B2DA20", VA = "0x182B2EA20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public UOHKHVUFXJC NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int ZRDYZWJLLET;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public RECYFJRDOZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B299D0", Offset = "0x2B289D0", VA = "0x182B299D0")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task KDYAJNTABTO(MTGSWKHGETU a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class MOFKSSWWWKT
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
				public MOFKSSWWWKT <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EF90", Offset = "0x2B2DF90", VA = "0x182B2EF90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F440", Offset = "0x2B2E440", VA = "0x182B2F440", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string ZRDYZWJLLET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public UOHKHVUFXJC NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int LTXGUXIWLKV;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public MOFKSSWWWKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B26650", Offset = "0x2B25650", VA = "0x182B26650")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task GXGIXXFQWSS(MTGSWKHGETU a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class AQACWAZIEUM
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
				public AQACWAZIEUM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EA80", Offset = "0x2B2DA80", VA = "0x182B2EA80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EF30", Offset = "0x2B2DF30", VA = "0x182B2EF30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string ZRDYZWJLLET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public UOHKHVUFXJC NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int LTXGUXIWLKV;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public AQACWAZIEUM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B14D90", Offset = "0x2B13D90", VA = "0x182B14D90")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task MSLHJWVUYRE(MTGSWKHGETU a)
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
			public UOHKHVUFXJC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D2E0", Offset = "0x2B2C2E0", VA = "0x182B2D2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D7E0", Offset = "0x2B2C7E0", VA = "0x182B2D7E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly TCRFCJQUXOV EXCBAADDJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<LVPTAXVPRRH> RYMHGFCMJRU;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private ITTJCCLXRJK EMEDYSEXMVG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B31450", Offset = "0x2B30450", VA = "0x182B31450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<FBIPJIAHSMB> WXNDRMFCONW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE07080", Offset = "0xE06080", VA = "0x180E07080", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<FBIPJIAHSMB>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xF10950", Offset = "0xF0F950", VA = "0x180F10950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<IWUJLJYSQDA> OFQSRSQJWXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1180", Offset = "0x2AB0180", VA = "0x182AB1180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<EXUEQGJGLLV> NKAVFHLQNTP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1297EE0", Offset = "0x1296EE0", VA = "0x181297EE0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<EXUEQGJGLLV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<GWVCCMPWDTY> AFFBDDUUGFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B31030", Offset = "0x2B30030", VA = "0x182B31030", Slot = "22")]
			get
			{
				return default(Id32<GWVCCMPWDTY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool RUXYJSOALPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B30530", Offset = "0x2B2F530", VA = "0x182B30530", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B343A0", Offset = "0x2B333A0", VA = "0x182B343A0")]
		private UOHKHVUFXJC(COWOBFPVIKZ a, BNPRQWVLIYC b, TCRFCJQUXOV c, Id32<HPGFUJBLNSN> portGroupId, Id32<FBIPJIAHSMB> inputId, Id32<IWUJLJYSQDA> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B31A80", Offset = "0x2B30A80", VA = "0x182B31A80")]
		public static UOHKHVUFXJC New(COWOBFPVIKZ circuitsManager, BNPRQWVLIYC node, TCRFCJQUXOV input, Id32<HPGFUJBLNSN> portGroupId, Id32<IWUJLJYSQDA> inputDefId, Id32<FBIPJIAHSMB> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B31690", Offset = "0x2B30690", VA = "0x182B31690", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B30B80", Offset = "0x2B2FB80", VA = "0x182B30B80", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B325B0", Offset = "0x2B315B0", VA = "0x182B325B0", Slot = "32")]
		public void RSYRZOMTRNJ(LVPTAXVPRRH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B321F0", Offset = "0x2B311F0", VA = "0x182B321F0", Slot = "29")]
		public void QZMLABTSDIQ(FXFFITNOXVR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B332A0", Offset = "0x2B322A0", VA = "0x182B332A0", Slot = "30")]
		public void YPZZVWFEZJZ(CHYFRJTXHOB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B327D0", Offset = "0x2B317D0", VA = "0x182B327D0", Slot = "25")]
		protected override void UVBJQFMSZWL(IHFZGDSWCHG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B328B0", Offset = "0x2B318B0", VA = "0x182B328B0", Slot = "34")]
		public string WPOJDINUOUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B30C20", Offset = "0x2B2FC20", VA = "0x182B30C20", Slot = "31")]
		public string EKTQCHJBUVO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B31470", Offset = "0x2B30470", VA = "0x182B31470")]
		private void INTNZZMMSJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B319C0", Offset = "0x2B309C0", VA = "0x182B319C0", Slot = "33")]
		public void LAERSIBIQSC(LVPTAXVPRRH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B31800", Offset = "0x2B30800", VA = "0x182B31800")]
		private void KVYGPPGXNWT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B33190", Offset = "0x2B32190", VA = "0x182B33190", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task YNDJXTPMHJF(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B30EE0", Offset = "0x2B2FEE0", VA = "0x182B30EE0")]
		public void EMSRSYCGMWO(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B32AA0", Offset = "0x2B31AA0", VA = "0x182B32AA0")]
		private void XBUJCNJORXK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B32610", Offset = "0x2B31610", VA = "0x182B32610")]
		private void TWLPDCMPTEG(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B32FD0", Offset = "0x2B31FD0", VA = "0x182B32FD0")]
		private void XKYESRQXZCN(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B305B0", Offset = "0x2B2F5B0", VA = "0x182B305B0")]
		private string ALMTMMCDHPU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B34230", Offset = "0x2B33230", VA = "0x182B34230")]
		private string YTERZQDIEJR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xF10950", Offset = "0xF0F950", VA = "0x180F10950")]
		internal void ZGPSRMHUBLW(Id32<FBIPJIAHSMB> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B31140", Offset = "0x2B30140", VA = "0x182B31140")]
		[CompilerGenerated]
		private void HXEOFMGZEMT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B31080", Offset = "0x2B30080", VA = "0x182B31080")]
		[CompilerGenerated]
		private bool HWZHIFNBVBK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B31150", Offset = "0x2B30150", VA = "0x182B31150")]
		[CompilerGenerated]
		private bool HXJVCTAWNYC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B306F0", Offset = "0x2B2F6F0", VA = "0x182B306F0")]
		[CompilerGenerated]
		private int HXZPUNIOQGD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B31210", Offset = "0x2B30210", VA = "0x182B31210")]
		[CompilerGenerated]
		private bool HXUIXGORGUU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B31360", Offset = "0x2B30360", VA = "0x182B31360")]
		[CompilerGenerated]
		private void HYKDPAWJJCV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B312A0", Offset = "0x2B302A0", VA = "0x182B312A0")]
		[CompilerGenerated]
		private bool HYEWRUCLZRM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B31400", Offset = "0x2B30400", VA = "0x182B31400")]
		[CompilerGenerated]
		private bool HYURJOKEBZN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B31370", Offset = "0x2B30370", VA = "0x182B31370")]
		[CompilerGenerated]
		private bool HYPKMHQGSOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B306F0", Offset = "0x2B2F6F0", VA = "0x182B306F0")]
		[CompilerGenerated]
		private int CAHJABVNFDG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B30740", Offset = "0x2B2F740", VA = "0x182B30740")]
		[CompilerGenerated]
		private bool CAMPXIPKOOP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B30810", Offset = "0x2B2F810", VA = "0x182B30810")]
		[CompilerGenerated]
		private object CARWUPJHXZY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B30870", Offset = "0x2B2F870", VA = "0x182B30870")]
		[CompilerGenerated]
		private void CAXDRWDFHLH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B308D0", Offset = "0x2B2F8D0", VA = "0x182B308D0")]
		[CompilerGenerated]
		private bool CBHRMJRAAHZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B309A0", Offset = "0x2B2F9A0", VA = "0x182B309A0")]
		[CompilerGenerated]
		private string CBMYJQKXJTI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B30A20", Offset = "0x2B2FA20", VA = "0x182B30A20")]
		[CompilerGenerated]
		private void CBSFGXEUTER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B30A30", Offset = "0x2B2FA30", VA = "0x182B30A30")]
		[CompilerGenerated]
		private bool CBXMEDYSCQA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B30B00", Offset = "0x2B2FB00", VA = "0x182B30B00")]
		[CompilerGenerated]
		private string CCCTBKSPMBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B32D10", Offset = "0x2B31D10", VA = "0x182B32D10")]
		[CompilerGenerated]
		private void XCGXWETVAGH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B32C40", Offset = "0x2B31C40", VA = "0x182B32C40")]
		[CompilerGenerated]
		private bool XCBQYXZXQUY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B32D30", Offset = "0x2B31D30", VA = "0x182B32D30")]
		[CompilerGenerated]
		private string XCRLQSHPTCZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B32D20", Offset = "0x2B31D20", VA = "0x182B32D20")]
		[CompilerGenerated]
		private void XCMETLNSJRQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B32E20", Offset = "0x2B31E20", VA = "0x182B32E20")]
		[CompilerGenerated]
		private bool XDBZLFVKLZR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B32DB0", Offset = "0x2B31DB0", VA = "0x182B32DB0")]
		[CompilerGenerated]
		private string XCWSNZBNCOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B32FC0", Offset = "0x2B31FC0", VA = "0x182B32FC0")]
		[CompilerGenerated]
		private void XDMNFTJFEWJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B32EF0", Offset = "0x2B31EF0", VA = "0x182B32EF0")]
		[CompilerGenerated]
		private bool XDHGIMPHVLA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B32A30", Offset = "0x2B31A30", VA = "0x182B32A30")]
		[CompilerGenerated]
		private string XAQUSCQQCTN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B32A20", Offset = "0x2B31A20", VA = "0x182B32A20")]
		[CompilerGenerated]
		private void XALNUVWSTIE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B320B0", Offset = "0x2B310B0", VA = "0x182B320B0")]
		[CompilerGenerated]
		private bool QBPSXMLSKNY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B32180", Offset = "0x2B31180", VA = "0x182B32180")]
		[CompilerGenerated]
		private string QBUZUTFPTZH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B31FD0", Offset = "0x2B30FD0", VA = "0x182B31FD0")]
		[CompilerGenerated]
		private void QBFFCYXXRRG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B31FE0", Offset = "0x2B30FE0", VA = "0x182B31FE0")]
		[CompilerGenerated]
		private bool QBKMAFRVBCP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B31F50", Offset = "0x2B30F50", VA = "0x182B31F50")]
		[CompilerGenerated]
		private string QAURILKCYUO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B31FC0", Offset = "0x2B30FC0", VA = "0x182B31FC0")]
		[CompilerGenerated]
		private void QAZYFSEAIFX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B31E20", Offset = "0x2B30E20", VA = "0x182B31E20")]
		[CompilerGenerated]
		private bool QAKDNXWIFXW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B31EF0", Offset = "0x2B30EF0", VA = "0x182B31EF0")]
		[CompilerGenerated]
		private object QAPKLEQFPJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B30870", Offset = "0x2B2F870", VA = "0x182B30870")]
		[CompilerGenerated]
		private void QDFWBOOXIAS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B31730", Offset = "0x2B30730", VA = "0x182B31730")]
		[CompilerGenerated]
		private bool KDRJGHKZTUR()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class VTPUVOOADJE
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class PIPHMUTNTDA : VEKHZDNAXTU<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public PIPHMUTNTDA NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x2B187A0", Offset = "0x2B177A0", VA = "0x182B187A0")]
				internal object FYWQLBYJBCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x2B18800", Offset = "0x2B17800", VA = "0x182B18800")]
				internal void FZBXIISGKNV(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x2B27220", Offset = "0x2B26220", VA = "0x182B27220")]
			public PIPHMUTNTDA(COWOBFPVIKZ a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x2B26FB0", Offset = "0x2B25FB0", VA = "0x182B26FB0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class YHWWACHUBUD : BJCKGDSUYRP<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType LLUOFWMONXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2B36E10", Offset = "0x2B35E10", VA = "0x182B36E10")]
			public YHWWACHUBUD(COWOBFPVIKZ a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class LRZCXKSCIYH : VEKHZDNAXTU<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2B26560", Offset = "0x2B25560", VA = "0x182B26560")]
			public LRZCXKSCIYH(COWOBFPVIKZ a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2B26400", Offset = "0x2B25400", VA = "0x182B26400", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2B26280", Offset = "0x2B25280", VA = "0x182B26280")]
			[CompilerGenerated]
			private bool PZTRQMRJKVO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2B262D0", Offset = "0x2B252D0", VA = "0x182B262D0")]
			[CompilerGenerated]
			private void PZYYNTLGUGX(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class SCXACHIOGSD : VEKHZDNAXTU<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public SCXACHIOGSD NJJCUEUTHZM;

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x2B18750", Offset = "0x2B17750", VA = "0x182B18750")]
				internal void FYWQLBYJBCM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x2B18C50", Offset = "0x2B17C50", VA = "0x182B18C50")]
				internal bool FZBXIISGKNV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2B18E40", Offset = "0x2B17E40", VA = "0x182B18E40")]
				internal bool FZHEFPMDTZE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2B18EE0", Offset = "0x2B17EE0", VA = "0x182B18EE0")]
				internal void FZMLCWGBDKN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x2B183C0", Offset = "0x2B173C0", VA = "0x182B183C0")]
				internal bool FYBOWAWTPJC()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2B29E10", Offset = "0x2B28E10", VA = "0x182B29E10")]
			public SCXACHIOGSD(COWOBFPVIKZ a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2B29B00", Offset = "0x2B28B00", VA = "0x182B29B00", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class TLPXOKDOQHF : VEKHZDNAXTU<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public TLPXOKDOQHF NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> CUYNSKJNOQS;

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x2B18660", Offset = "0x2B17660", VA = "0x182B18660")]
				internal object? FYWQLBYJBCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x2B18590", Offset = "0x2B17590", VA = "0x182B18590")]
				internal bool FYRJNVELRRD(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2B18A00", Offset = "0x2B17A00", VA = "0x182B18A00")]
				internal void FZBXIISGKNV(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x2B18CF0", Offset = "0x2B17CF0", VA = "0x182B18CF0")]
				internal string FZHEFPMDTZE(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x2B18E90", Offset = "0x2B17E90", VA = "0x182B18E90")]
				internal IReadOnlyList<object> FZMLCWGBDKN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x2B18350", Offset = "0x2B17350", VA = "0x182B18350")]
				internal bool FYBOWAWTPJC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x2B18410", Offset = "0x2B17410", VA = "0x182B18410")]
				internal bool FYGVTHQQYUL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x2B18460", Offset = "0x2B17460", VA = "0x182B18460")]
				internal void FYMCQOKOIFU(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A790", Offset = "0x2B29790", VA = "0x182B2A790")]
			public TLPXOKDOQHF(COWOBFPVIKZ a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A0A0", Offset = "0x2B290A0", VA = "0x182B2A0A0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class PVGRZLAMSLM : VEKHZDNAXTU<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public PVGRZLAMSLM NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x2B18610", Offset = "0x2B17610", VA = "0x182B18610")]
				internal bool FYWQLBYJBCM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x2B188D0", Offset = "0x2B178D0", VA = "0x182B188D0")]
				internal void FZBXIISGKNV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x2B18CA0", Offset = "0x2B17CA0", VA = "0x182B18CA0")]
				internal bool FZHEFPMDTZE()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2B279E0", Offset = "0x2B269E0", VA = "0x182B279E0")]
			public PVGRZLAMSLM(COWOBFPVIKZ a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2B277D0", Offset = "0x2B267D0", VA = "0x182B277D0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class CMRCLPQUQRV : VEKHZDNAXTU<SGLJRJKWBXO>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class PUKJSNNOUVN
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
					public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public PUKJSNNOUVN <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<QSUPKMQDXBF>, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x2B2DC20", Offset = "0x2B2CC20", VA = "0x182B2DC20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x2B2E000", Offset = "0x2B2D000", VA = "0x182B2E000", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public PUKJSNNOUVN <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x2B2E070", Offset = "0x2B2D070", VA = "0x182B2E070", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x2B2E400", Offset = "0x2B2D400", VA = "0x182B2E400", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task ZYSZIUYEICZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string QTWVCLONPCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public YAVKDLMCPYL.OJOLWQHPXVX QCBZJKMZKLQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool XXVHLFBMLKO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public CMRCLPQUQRV NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public YAVKDLMCPYL ZXMLSLTRIQW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action GVNQHKSIJKY;

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public PUKJSNNOUVN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2B27290", Offset = "0x2B26290", VA = "0x182B27290")]
				internal bool HXMYIWWPNMO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
				internal string OPZQNDORZEH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x2B273B0", Offset = "0x2B263B0", VA = "0x182B273B0")]
				internal void OQEXKKIPIPQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2B27430", Offset = "0x2B26430", VA = "0x182B27430")]
				internal void OQKEHRCMSAZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x1610090", Offset = "0x160F090", VA = "0x181610090")]
				internal bool OQPLEXWKBMI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2B27480", Offset = "0x2B26480", VA = "0x182B27480")]
				internal void OQUSCEQHKXR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x2B276A0", Offset = "0x2B266A0", VA = "0x182B276A0")]
				internal bool OQZYZLKEUJA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x2B276E0", Offset = "0x2B266E0", VA = "0x182B276E0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, MCRZZCNKUJE>> OSBLEMLLFXW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x2B272C0", Offset = "0x2B262C0", VA = "0x182B272C0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, MCRZZCNKUJE>> KZQIEPCTXYN()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class QWHKHWJLEJV
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
					public AsyncTaskMethodBuilder<Result<Id32<QSUPKMQDXBF>, MCRZZCNKUJE>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<QSUPKMQDXBF>, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x2B2D840", Offset = "0x2B2C840", VA = "0x182B2D840", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x2B2DBB0", Offset = "0x2B2CBB0", VA = "0x182B2DBB0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public CMRCLPQUQRV NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public ZTOKIRXYVVD QEKNTHLDTNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool HZQCKAZQQEM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public YAVKDLMCPYL ZXMLSLTRIQW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public ABVKJWGLWKH ZDSIPBVSNYG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action CVOIKERFQYT;

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public QWHKHWJLEJV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2B29560", Offset = "0x2B28560", VA = "0x182B29560")]
				internal object? FZBXIISGKNV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2B295D0", Offset = "0x2B285D0", VA = "0x182B295D0")]
				internal void FZHEFPMDTZE(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2B296C0", Offset = "0x2B286C0", VA = "0x182B296C0")]
				internal string FZMLCWGBDKN(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2B29230", Offset = "0x2B28230", VA = "0x182B29230")]
				internal IReadOnlyList<object> FYBOWAWTPJC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x2B292D0", Offset = "0x2B282D0", VA = "0x182B292D0")]
				internal void FYGVTHQQYUL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2B29430", Offset = "0x2B28430", VA = "0x182B29430")]
				internal bool FYMCQOKOIFU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2B294A0", Offset = "0x2B284A0", VA = "0x182B294A0")]
				internal void FYRJNVELRRD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2B297B0", Offset = "0x2B287B0", VA = "0x182B297B0")]
				internal void GAMTPEBNYPG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2B29800", Offset = "0x2B28800", VA = "0x182B29800")]
				internal void GASAMKVLIAP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000146")]
				[Cpp2IlInjected.Address(RVA = "0x2B29970", Offset = "0x2B28970", VA = "0x182B29970")]
				internal bool TDXJLPKCQRT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x2B29880", Offset = "0x2B28880", VA = "0x182B29880")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<QSUPKMQDXBF>, MCRZZCNKUJE>> OYGBZJMYPYF()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<YUFXTHDQAZB>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x2B15F30", Offset = "0x2B14F30", VA = "0x182B15F30", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool XCHAFNGAKCC
			{
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2B15EC0", Offset = "0x2B14EC0", VA = "0x182B15EC0")]
			public CMRCLPQUQRV(COWOBFPVIKZ a, SGLJRJKWBXO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2B14EA0", Offset = "0x2B13EA0", VA = "0x182B14EA0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x2B15830", Offset = "0x2B14830", VA = "0x182B15830")]
			private void WMLCDXRTWBA(YAVKDLMCPYL a, Id32<QSUPKMQDXBF>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class HOFZLQUHWTI : GBWBBWFEMCJ<SXFZHEIRQSD>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x1F5B670", Offset = "0x1F5A670", VA = "0x181F5B670", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool MXULGXUNSOF
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool AGEGGFLYLOY
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool YJYAVOJDHYJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool XCHAFNGAKCC
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2B19420", Offset = "0x2B18420", VA = "0x182B19420")]
			public HOFZLQUHWTI(COWOBFPVIKZ a, SXFZHEIRQSD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class WXDTCCTCLXO<a> : VEKHZDNAXTU<a> where a : notnull, ZIWFKRZYKWQ
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
				public AsyncTaskMethodBuilder<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public WXDTCCTCLXO<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x6537FC0", Offset = "0x6536FC0", VA = "0x186537FC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x6538310", Offset = "0x6537310", VA = "0x186538310", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public WXDTCCTCLXO<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<HPGFUJBLNSN> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x6B8A6C0", Offset = "0x6B896C0", VA = "0x186B8A6C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x6B8AA10", Offset = "0x6B89A10", VA = "0x186B8AA10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<HPGFUJBLNSN>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x8735870", Offset = "0x8734870", VA = "0x188735870", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8735840", Offset = "0x8734840", VA = "0x188735840")]
			protected WXDTCCTCLXO(COWOBFPVIKZ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x87355E0", Offset = "0x87345E0", VA = "0x1887355E0", Slot = "122")]
			[AsyncStateMachine(typeof(WXDTCCTCLXO<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> ONIENZMFOPL(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8735700", Offset = "0x8734700", VA = "0x188735700", Slot = "149")]
			public sealed override bool OORBJXIZJQY(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8735540", Offset = "0x8734540", VA = "0x188735540", Slot = "134")]
			protected sealed override bool BKHDIZADVTQ(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x87357A0", Offset = "0x87347A0", VA = "0x1887357A0", Slot = "135")]
			protected override bool RDNJLYLREQN(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8735430", Offset = "0x8734430", VA = "0x188735430", Slot = "123")]
			[AsyncStateMachine(typeof(WXDTCCTCLXO<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, MCRZZCNKUJE>> AZHEBKRWDQA(Id32<HPGFUJBLNSN> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class CWLEPCROUNL : SUTGBCUJVSK<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public CWLEPCROUNL NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x2B191E0", Offset = "0x2B181E0", VA = "0x182B191E0")]
				internal bool HYJRWBINHOV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x2B190B0", Offset = "0x2B180B0", VA = "0x182B190B0")]
				internal void HYEKYUOPYDM(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x2B177A0", Offset = "0x2B167A0", VA = "0x182B177A0")]
			public CWLEPCROUNL(COWOBFPVIKZ a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2B17560", Offset = "0x2B16560", VA = "0x182B17560", Slot = "151")]
			protected override void DZVYKMORJUZ(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class JJJSTSQCIJI : VEKHZDNAXTU<AASCJFYFMHN>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class CCYEXJECMVG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int UHZROLPZFTL;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public CCYEXJECMVG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x2B14E60", Offset = "0x2B13E60", VA = "0x182B14E60")]
				internal bool IZYFLRMOOEV(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class QBUTDWRBSPN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public JJJSTSQCIJI NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> JGMWSFLGNGV;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public QBUTDWRBSPN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x2B28460", Offset = "0x2B27460", VA = "0x182B28460")]
				internal int FYWQLBYJBCM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x2B28500", Offset = "0x2B27500", VA = "0x182B28500")]
				internal void FZBXIISGKNV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x2B28620", Offset = "0x2B27620", VA = "0x182B28620")]
				internal string? FZHEFPMDTZE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2B19980", Offset = "0x2B18980", VA = "0x182B19980")]
			public JJJSTSQCIJI(COWOBFPVIKZ a, AASCJFYFMHN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2B195A0", Offset = "0x2B185A0", VA = "0x182B195A0")]
			private int JEBXXYKHMXL(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x2B19480", Offset = "0x2B18480", VA = "0x182B19480")]
			private void EITZQLHCYKJ(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2B19630", Offset = "0x2B18630", VA = "0x182B19630", Slot = "145")]
			protected sealed override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class JYEHWJYIDGO : GBWBBWFEMCJ<EFBEFTLZNWH>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x2B1B750", Offset = "0x2B1A750", VA = "0x182B1B750")]
			public JYEHWJYIDGO(COWOBFPVIKZ a, EFBEFTLZNWH b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class GBWBBWFEMCJ<a> : VEKHZDNAXTU<a> where a : notnull, CKNAMVAGPAH
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class WQWJRRGQZRD
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
					public WQWJRRGQZRD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x41B36B0", Offset = "0x41B26B0", VA = "0x1841B36B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public YAVKDLMCPYL ZXMLSLTRIQW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public GBWBBWFEMCJ<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action CVDUPRDKYCB;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public WQWJRRGQZRD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x872D3B0", Offset = "0x872C3B0", VA = "0x18872D3B0")]
				internal void FYWQLBYJBCM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x872D310", Offset = "0x872C310", VA = "0x18872D310")]
				[AsyncStateMachine(typeof(GBWBBWFEMCJ<>.WQWJRRGQZRD.<<BuildConfigMenuInternal>b__6>d))]
				internal void FYMCQOKOIFU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x872D690", Offset = "0x872C690", VA = "0x18872D690")]
				internal bool FZBXIISGKNV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class WQRCUKMTQFU
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
					public WQRCUKMTQFU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x41B32B0", Offset = "0x41B22B0", VA = "0x1841B32B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string SFKDGLAARXJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public WQWJRRGQZRD LWPGXDDEGGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> CUDMDJHYCXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> CUTGVDPQFFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action CUNZXWVSVUA;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public WQRCUKMTQFU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x872CE00", Offset = "0x872BE00", VA = "0x18872CE00")]
				internal void FZHEFPMDTZE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				internal string FZMLCWGBDKN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				internal void FYBOWAWTPJC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x872CD60", Offset = "0x872BD60", VA = "0x18872CD60")]
				[AsyncStateMachine(typeof(GBWBBWFEMCJ<>.WQRCUKMTQFU.<<BuildConfigMenuInternal>b__5>d))]
				internal void FYGVTHQQYUL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class BHKCBBITDAI
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
					public BHKCBBITDAI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<RGHHVUNUSGT>, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x41B0950", Offset = "0x41AF950", VA = "0x1841B0950", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public BHKCBBITDAI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x41B10A0", Offset = "0x41B00A0", VA = "0x1841B10A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public BHKCBBITDAI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<IWUJLJYSQDA>, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x41B1280", Offset = "0x41B0280", VA = "0x1841B1280", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public GBWBBWFEMCJ<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<HPGFUJBLNSN> ISFSNOZTJPL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public YAVKDLMCPYL ZXMLSLTRIQW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public XAZCQBDUMDJ GOQKABAWCGY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int WKMDUEZOIFR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int LICKCYRFRXX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public PJVLKDMUVJA WTOLZBRBOAN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string FLTICOYAXWW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<DBTVNXLTCIC> LFPMZKFUMGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public PJVLKDMUVJA MODLRTKTDLY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string MUIVKUSVJZZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<DBTVNXLTCIC> BBHOFBOCOZK;

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public BHKCBBITDAI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x4EDD8A0", Offset = "0x4EDC8A0", VA = "0x184EDD8A0")]
				internal bool HRGFCLDCIHF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x4EDD830", Offset = "0x4EDC830", VA = "0x184EDD830")]
				internal void HRAYFEJEYVW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x4EDDE70", Offset = "0x4EDCE70", VA = "0x184EDDE70")]
				internal bool KEVZYHCXNWZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x4EDD950", Offset = "0x4EDC950", VA = "0x184EDD950")]
				[AsyncStateMachine(typeof(GBWBBWFEMCJ<>.BHKCBBITDAI.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void HRQSWYQXBDX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x4EDD910", Offset = "0x4EDC910", VA = "0x184EDD910")]
				internal bool HRLLZRWZRSO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x4EDDEB0", Offset = "0x4EDCEB0", VA = "0x184EDDEB0")]
				internal void KFRBNIEMZQJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x4EDDBD0", Offset = "0x4EDCBD0", VA = "0x184EDDBD0")]
				internal bool KCQCCKSAOCE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x4EDDC80", Offset = "0x4EDCC80", VA = "0x184EDDC80")]
				internal void KCVIZRLXXNN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x4EDD6A0", Offset = "0x4EDC6A0", VA = "0x184EDD6A0")]
				internal bool DZVIYZHTEWP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x4EDDA60", Offset = "0x4EDCA60", VA = "0x184EDDA60")]
				internal bool HSBGRMERUAP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x4EDD9F0", Offset = "0x4EDC9F0", VA = "0x184EDD9F0")]
				internal void HRVZUFKUKPG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x4EDDB30", Offset = "0x4EDCB30", VA = "0x184EDDB30")]
				[AsyncStateMachine(typeof(GBWBBWFEMCJ<>.BHKCBBITDAI.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void HSLULZSMMXH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x4EDDAD0", Offset = "0x4EDCAD0", VA = "0x184EDDAD0")]
				internal bool HSGNOSYPDLY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x4EDD7C0", Offset = "0x4EDC7C0", VA = "0x184EDD7C0")]
				internal bool HPQBYIZXKUL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x4EDD750", Offset = "0x4EDC750", VA = "0x184EDD750")]
				internal void HPKVBCGABJC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x4EDDD60", Offset = "0x4EDCD60", VA = "0x184EDDD60")]
				[AsyncStateMachine(typeof(GBWBBWFEMCJ<>.BHKCBBITDAI.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void KEGFGMVFLOY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x4EDDE10", Offset = "0x4EDCE10", VA = "0x184EDDE10")]
				internal bool KELMDTPCVAH()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class BHPIYICQMLR
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
					public BHPIYICQMLR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x41B0C40", Offset = "0x41AFC40", VA = "0x1841B0C40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string VGPKINTMJLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public BHKCBBITDAI LWPGXDDEGGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> ICKPFWLJMGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> ICPWDDFGVRR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action ICVDAJZEFDA;

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public BHPIYICQMLR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x4EDDF90", Offset = "0x4EDCF90", VA = "0x184EDDF90")]
				internal void KEQTBAJAELQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				internal string KFBGVNWUXII()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				internal void KFGNSUQSGTR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0x4EDE300", Offset = "0x4EDD300", VA = "0x184EDE300")]
				[AsyncStateMachine(typeof(GBWBBWFEMCJ<>.BHPIYICQMLR.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void KFLUQBKPQFA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class WUKSLFDYNAT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool LFPMZKFUMGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public XAZCQBDUMDJ GOQKABAWCGY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<DBTVNXLTCIC> HMSCJUEOBVI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public GBWBBWFEMCJ<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<HPGFUJBLNSN> ISFSNOZTJPL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int WTOKHQMMSPC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> CTSYIVUDKAQ;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public WUKSLFDYNAT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x87351A0", Offset = "0x87341A0", VA = "0x1887351A0")]
				internal bool ELPFTIOSCIB()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class WUFLNYKBDPK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public YKOXFKAMQGI MUVRPOMAVDH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public WUKSLFDYNAT LWPGXDDEGGX;

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public WUFLNYKBDPK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x8734DF0", Offset = "0x8733DF0", VA = "0x188734DF0")]
				internal void EKZLBOHAAAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x8734F60", Offset = "0x8733F60", VA = "0x188734F60")]
				internal bool ELERYVAXJLJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x8734FB0", Offset = "0x8733FB0", VA = "0x188734FB0")]
				internal void EMFALCWKEQC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x8735140", Offset = "0x8734140", VA = "0x188735140")]
				internal bool EMKHIJQHOBL()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class WUVGFSRTFXL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public DBTVNXLTCIC OMZBUZRLOWH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public WUFLNYKBDPK LWUNUJXBPSG;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public WUVGFSRTFXL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x8735200", Offset = "0x8734200", VA = "0x188735200")]
				internal void ELJYWBUUSWS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class JUPSWDDNJPQ
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
					public JUPSWDDNJPQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x41B4560", Offset = "0x41B3560", VA = "0x1841B4560", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> AXFADQXVFKL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public PJVLKDMUVJA ZQPXVCHOUEX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool LFPMZKFUMGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public XAZCQBDUMDJ GOQKABAWCGY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public YKOXFKAMQGI MUVRPOMAVDH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string VGPKINTMJLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public JUPSWDDNJPQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x6749470", Offset = "0x6748470", VA = "0x186749470")]
				internal int KGMORWYPJNG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x67494B0", Offset = "0x67484B0", VA = "0x1867494B0")]
				internal void KGRVPDSMSYP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
				internal string KGXCMKMKCJY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x6749710", Offset = "0x6748710", VA = "0x186749710")]
				[AsyncStateMachine(typeof(GBWBBWFEMCJ<>.JUPSWDDNJPQ.<<CreatePortItemV2>b__3>d))]
				internal void KHCJJRGHLVH(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public GBWBBWFEMCJ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x6537BA0", Offset = "0x6536BA0", VA = "0x186537BA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x6537F50", Offset = "0x6536F50", VA = "0x186537F50", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public GBWBBWFEMCJ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<HPGFUJBLNSN> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x6B8AA80", Offset = "0x6B89A80", VA = "0x186B8AA80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x6B8AE30", Offset = "0x6B89E30", VA = "0x186B8AE30", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public GBWBBWFEMCJ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x6C14250", Offset = "0x6C13250", VA = "0x186C14250", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x6C14800", Offset = "0x6C13800", VA = "0x186C14800", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<HPGFUJBLNSN>, bool> UJOPCEEKUUV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<HPGFUJBLNSN>, bool> TUJREOQENTJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<HPGFUJBLNSN>, bool> XNWNMUBVIUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<HPGFUJBLNSN>, bool> VKNMUOHMEBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<HPGFUJBLNSN>, bool> OOCOJFBXCBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<HPGFUJBLNSN>, bool> YLMRUHCVWLE;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool MXULGXUNSOF
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool AGEGGFLYLOY
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool YJYAVOJDHYJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<YUFXTHDQAZB>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x63C2F10", Offset = "0x63C1F10", VA = "0x1863C2F10", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<HPGFUJBLNSN>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x63C3190", Offset = "0x63C2190", VA = "0x1863C3190", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<ISSDUATOTVT>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x63C2F90", Offset = "0x63C1F90", VA = "0x1863C2F90", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x63C2D40", Offset = "0x63C1D40", VA = "0x1863C2D40")]
			public GBWBBWFEMCJ(COWOBFPVIKZ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "154")]
			protected virtual bool NMOZTMLYQMQ(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "155")]
			protected virtual bool SPFSEHSKTDF(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "156")]
			protected virtual bool BPQOXFZDJHI(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "157")]
			protected virtual void LTPEJQQTUSI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x63C22F0", Offset = "0x63C12F0", VA = "0x1863C22F0", Slot = "149")]
			public override bool OORBJXIZJQY(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x63C21D0", Offset = "0x63C11D0", VA = "0x1863C21D0", Slot = "122")]
			[AsyncStateMachine(typeof(GBWBBWFEMCJ<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> ONIENZMFOPL(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x63BE4F0", Offset = "0x63BD4F0", VA = "0x1863BE4F0", Slot = "123")]
			[AsyncStateMachine(typeof(GBWBBWFEMCJ<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, MCRZZCNKUJE>> AZHEBKRWDQA(Id32<HPGFUJBLNSN> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x63BFDB0", Offset = "0x63BEDB0", VA = "0x1863BFDB0", Slot = "124")]
			public override void FAIQHALJAZS(Id32<HPGFUJBLNSN> index, Id32<HPGFUJBLNSN> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x63C11E0", Offset = "0x63C01E0", VA = "0x1863C11E0", Slot = "125")]
			public override IEnumerable<PYPEGOPZPPS> ICYNAQDOWCP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x63C20D0", Offset = "0x63C10D0", VA = "0x1863C20D0")]
			[AsyncStateMachine(typeof(GBWBBWFEMCJ<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, MCRZZCNKUJE>> OIEYCZCRHNY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "158")]
			protected virtual bool LMHAHOYYYIL(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "159")]
			protected virtual bool LJRFWUBMNAL(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "160")]
			protected virtual bool XNMDZEKTMDQ(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "161")]
			protected virtual bool QHUETVHEORG(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "162")]
			protected virtual bool XEHKAYAVZKO(Id32<HPGFUJBLNSN> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "163")]
			protected virtual bool PYFOGSYFRSD(Id32<HPGFUJBLNSN> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "164")]
			protected virtual bool OIMTKAOCFMB(Id32<HPGFUJBLNSN> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "165")]
			protected virtual bool GXCRSDBCUES(Id32<HPGFUJBLNSN> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "166")]
			protected virtual bool NHTGVYWUOSK(Id32<HPGFUJBLNSN> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "167")]
			protected virtual bool HIWHBASYYTH(Id32<HPGFUJBLNSN> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x63C1440", Offset = "0x63C0440", VA = "0x1863C1440", Slot = "168")]
			protected virtual List<PJVLKDMUVJA> KTQCSUYFSTT(Id32<HPGFUJBLNSN> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "169")]
			protected virtual void HHDIKNUJWCG(YAVKDLMCPYL a, GRKTELHQWIB b, XAZCQBDUMDJ c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x63C2390", Offset = "0x63C1390", VA = "0x1863C2390", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x63BE600", Offset = "0x63BD600", VA = "0x1863BE600")]
			private GRKTELHQWIB BBAXPYZCIJF(YAVKDLMCPYL a, XAZCQBDUMDJ b, Id32<HPGFUJBLNSN> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x63C0140", Offset = "0x63BF140", VA = "0x1863C0140")]
			private List<DBTVNXLTCIC> HDNFPPZCTTK(YAVKDLMCPYL a, XAZCQBDUMDJ b, GRKTELHQWIB c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x63C1720", Offset = "0x63C0720", VA = "0x1863C1720")]
			private List<DBTVNXLTCIC> NWQLOXHZGFU(YAVKDLMCPYL a, XAZCQBDUMDJ b, YKOXFKAMQGI c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x63BFF50", Offset = "0x63BEF50", VA = "0x1863BFF50")]
			private PJVLKDMUVJA FDOXWFUVRUQ(List<PJVLKDMUVJA> a, YKOXFKAMQGI b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x63C16C0", Offset = "0x63C06C0", VA = "0x1863C16C0")]
			[CompilerGenerated]
			private PYPEGOPZPPS NELXPZLZVVM(BNPRQWVLIYC a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class ZBDWRUKODCA : VEKHZDNAXTU<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class GWEWRBMCNCR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public ZBDWRUKODCA NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GWEWRBMCNCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B18270", Offset = "0x2B17270", VA = "0x182B18270")]
				internal int FYWQLBYJBCM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B182C0", Offset = "0x2B172C0", VA = "0x182B182C0")]
				internal Task<bool> FZBXIISGKNV(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2B37020", Offset = "0x2B36020", VA = "0x182B37020")]
			public ZBDWRUKODCA(COWOBFPVIKZ a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2B36E70", Offset = "0x2B35E70", VA = "0x182B36E70", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class OWXFAVHWCRG : SUTGBCUJVSK<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public OWXFAVHWCRG NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B19160", Offset = "0x2B18160", VA = "0x182B19160")]
				internal int HYJRWBINHOV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B19010", Offset = "0x2B18010", VA = "0x182B19010")]
				internal Task<bool> HYEKYUOPYDM(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2B26DE0", Offset = "0x2B25DE0", VA = "0x182B26DE0")]
			public OWXFAVHWCRG(COWOBFPVIKZ a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2B26BC0", Offset = "0x2B25BC0", VA = "0x182B26BC0", Slot = "151")]
			protected override void DZVYKMORJUZ(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class SJABJOZFWOO : VEKHZDNAXTU<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xF11500", Offset = "0xF10500", VA = "0x180F11500", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B29E80", Offset = "0x2B28E80", VA = "0x182B29E80")]
			public SJABJOZFWOO(COWOBFPVIKZ a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class JXZXTNEOMNQ : VEKHZDNAXTU<NAFQXGFAERB>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class LPQSXGDQTBI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public JXZXTNEOMNQ NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public YAVKDLMCPYL ZXMLSLTRIQW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> DCRTAZGZODC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> DDHNSTORQLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> DDMUQAIOZWM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> DECPHUQHCEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> DDXIKNWJSTE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> DENDCIEBVBF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> DEHWFBKELPW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> WISHPWFNXVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> WIXONCZLHGN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> WIHTVIRTEYM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> WINASPLQOJV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> WHXGAVDYMBU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> WICMYBXVVND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> WHMSGHQDTFC;

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public LPQSXGDQTBI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C230", Offset = "0x2B1B230", VA = "0x182B1C230")]
				internal bool FYWQLBYJBCM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C2F0", Offset = "0x2B1B2F0", VA = "0x182B1C2F0")]
				internal void FZBXIISGKNV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C0E0", Offset = "0x2B1B0E0", VA = "0x182B1C0E0")]
				internal bool FYBOWAWTPJC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C130", Offset = "0x2B1B130", VA = "0x182B1C130")]
				internal bool FYGVTHQQYUL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C180", Offset = "0x2B1B180", VA = "0x182B1C180")]
				internal void FYMCQOKOIFU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C5F0", Offset = "0x2B1B5F0", VA = "0x182B1C5F0")]
				internal bool GASAMKVLIAP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2B24730", Offset = "0x2B23730", VA = "0x182B24730")]
				internal bool TDXJLPKCQRT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x2B246D0", Offset = "0x2B236D0", VA = "0x182B246D0")]
				internal void TDSCOIQFHGK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x2B24680", Offset = "0x2B23680", VA = "0x182B24680")]
				internal bool TDCHWOINEYJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2B24630", Offset = "0x2B23630", VA = "0x182B24630")]
				internal bool TCXAZHOPVNA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x2B245D0", Offset = "0x2B235D0", VA = "0x182B245D0")]
				internal void TCRUCAUSMBR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2B24580", Offset = "0x2B23580", VA = "0x182B24580")]
				internal bool TCBZKGNAJTQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C880", Offset = "0x2B1B880", VA = "0x182B1C880")]
				internal bool GXYFDQLYUJZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C830", Offset = "0x2B1B830", VA = "0x182B1C830")]
				internal bool GXSYGJSBKYQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C8D0", Offset = "0x2B1B8D0", VA = "0x182B1C8D0")]
				internal bool GYISYDZTNGR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CA20", Offset = "0x2B1BA20", VA = "0x182B1CA20")]
				internal bool HAJJWTQTDQD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C9D0", Offset = "0x2B1B9D0", VA = "0x182B1C9D0")]
				internal bool HAECZMWVUEU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2B25FE0", Offset = "0x2B24FE0", VA = "0x182B25FE0")]
				internal bool ZYCBTZFLQLA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2B26030", Offset = "0x2B25030", VA = "0x182B26030")]
				internal bool ZYHIRFZIZWJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2B25F30", Offset = "0x2B24F30", VA = "0x182B25F30")]
				internal void ZXRNZLRQXOI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CCD0", Offset = "0x2B1BCD0", VA = "0x182B1CCD0")]
				internal bool LASQCQONLLR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CD20", Offset = "0x2B1BD20", VA = "0x182B1CD20")]
				internal bool LAXWZXIKUXA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CD70", Offset = "0x2B1BD70", VA = "0x182B1CD70")]
				internal bool LBDDXECIEIJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CDC0", Offset = "0x2B1BDC0", VA = "0x182B1CDC0")]
				internal bool LBNRRRQCXFB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CE10", Offset = "0x2B1BE10", VA = "0x182B1CE10")]
				internal bool LBSYOYKAGQK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2B25F90", Offset = "0x2B24F90", VA = "0x182B25F90")]
				internal bool ZXWUWSLOGZR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2B26120", Offset = "0x2B25120", VA = "0x182B26120")]
				internal bool ZYXDJAHBCEK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2B26170", Offset = "0x2B25170", VA = "0x182B26170")]
				internal void ZZCKGHAYLPT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2B26080", Offset = "0x2B25080", VA = "0x182B26080")]
				internal bool ZYMPOMTGJHS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2B260D0", Offset = "0x2B250D0", VA = "0x182B260D0")]
				internal bool ZYRWLTNDSTB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2B261D0", Offset = "0x2B251D0", VA = "0x182B261D0")]
				internal void ZZSEYBIQNXU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2B26230", Offset = "0x2B25230", VA = "0x182B26230")]
				internal bool ZZXLVICNXJD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C980", Offset = "0x2B1B980", VA = "0x182B1C980")]
				internal bool GYTGSRNOGDJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C920", Offset = "0x2B1B920", VA = "0x182B1C920")]
				internal void GYNZVKTQWSA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E740", Offset = "0x2B1D740", VA = "0x182B1E740")]
				internal List<DBTVNXLTCIC> SIEAQTMFJTT(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CE60", Offset = "0x2B1BE60", VA = "0x182B1CE60")]
				internal bool LBYFMFDXQBT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CEB0", Offset = "0x2B1BEB0", VA = "0x182B1CEB0")]
				internal int LCDMJLXUZNC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CF00", Offset = "0x2B1BF00", VA = "0x182B1CF00")]
				internal Task<bool> LCITGSRSIYL(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E520", Offset = "0x2B1D520", VA = "0x182B1E520")]
				internal bool SBEOECCSRSR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E4D0", Offset = "0x2B1D4D0", VA = "0x182B1E4D0")]
				internal bool SAZHGVIVIHI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E480", Offset = "0x2B1D480", VA = "0x182B1E480")]
				internal bool SAUAJOOXYVZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E430", Offset = "0x2B1D430", VA = "0x182B1E430")]
				internal int SAOTMHVAPKQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E660", Offset = "0x2B1D660", VA = "0x182B1E660")]
				internal Task<bool> SBZPTDEIDMB(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E610", Offset = "0x2B1D610", VA = "0x182B1E610")]
				internal bool SBUIVWKKUAS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E5C0", Offset = "0x2B1D5C0", VA = "0x182B1E5C0")]
				internal bool SBPBYPQNKPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E570", Offset = "0x2B1D570", VA = "0x182B1E570")]
				internal bool SBJVBIWQBEA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E6F0", Offset = "0x2B1D6F0", VA = "0x182B1E6F0")]
				internal bool SCPKKXMAFUC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x2B258E0", Offset = "0x2B248E0", VA = "0x182B258E0")]
				internal bool ZBVTCUKVHLA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B800", Offset = "0x2B1A800", VA = "0x182B1B800")]
				internal string BOUPQPRMVXJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B850", Offset = "0x2B1A850", VA = "0x182B1B850")]
				internal void BOZWNWLKFIS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B8C0", Offset = "0x2B1A8C0", VA = "0x182B1B8C0")]
				internal int BPPRFQTCHQT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B910", Offset = "0x2B1A910", VA = "0x182B1B910")]
				internal void BPUYCXMZRCC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B970", Offset = "0x2B1A970", VA = "0x182B1B970")]
				internal bool BQAFAEGXANL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B9C0", Offset = "0x2B1A9C0", VA = "0x182B1B9C0")]
				internal bool BQFLXLAUJYU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BA10", Offset = "0x2B1AA10", VA = "0x182B1BA10")]
				internal bool BQKSURURTKD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CB70", Offset = "0x2B1BB70", VA = "0x182B1CB70")]
				internal float IPGNSBFSCEJ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CB10", Offset = "0x2B1BB10", VA = "0x182B1CB10")]
				internal void IPBGUULUSTA(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CAC0", Offset = "0x2B1BAC0", VA = "0x182B1CAC0")]
				internal bool IOVZXNRXJHR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CA70", Offset = "0x2B1BA70", VA = "0x182B1CA70")]
				internal bool IOQTAGXZZWI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CC80", Offset = "0x2B1BC80", VA = "0x182B1CC80")]
				internal bool IQBPHCHHNXT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2B25840", Offset = "0x2B24840", VA = "0x182B25840")]
				internal bool ZBLFIGXAOOI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2B25890", Offset = "0x2B24890", VA = "0x182B25890")]
				internal bool ZBQMFNQXXZR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2B253F0", Offset = "0x2B243F0", VA = "0x182B253F0")]
				internal bool ZBARNTJFVRQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2B25440", Offset = "0x2B24440", VA = "0x182B25440")]
				internal void ZBFYLADDFCZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CC30", Offset = "0x2B1BC30", VA = "0x182B1CC30")]
				internal string IPWIJVNKEMK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CBC0", Offset = "0x2B1BBC0", VA = "0x182B1CBC0")]
				internal void IPRBMOTMVBB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2B25350", Offset = "0x2B24350", VA = "0x182B25350")]
				internal bool ZAQDTFVLCUY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2B253A0", Offset = "0x2B243A0", VA = "0x182B253A0")]
				internal bool ZAVKQMPIMGH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2B25930", Offset = "0x2B24930", VA = "0x182B25930")]
				internal bool ZDLWGWOAEXU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x2B25980", Offset = "0x2B24980", VA = "0x182B25980")]
				internal void ZDRDEDHXOJD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BEA0", Offset = "0x2B1AEA0", VA = "0x182B1BEA0")]
				internal bool FCOZOETXLHB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BE50", Offset = "0x2B1AE50", VA = "0x182B1BE50")]
				internal bool FCJSQYAABVS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BF40", Offset = "0x2B1AF40", VA = "0x182B1BF40")]
				internal bool FCZNISHSEDT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BEF0", Offset = "0x2B1AEF0", VA = "0x182B1BEF0")]
				internal bool FCUGLLNUUSK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BFE0", Offset = "0x2B1AFE0", VA = "0x182B1BFE0")]
				internal void FDKBDFVMXAL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BF90", Offset = "0x2B1AF90", VA = "0x182B1BF90")]
				internal bool FDEUFZBPNPC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C090", Offset = "0x2B1B090", VA = "0x182B1C090")]
				internal bool FDUOXTJHPXD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C040", Offset = "0x2B1B040", VA = "0x182B1C040")]
				internal bool FDPIAMPKGLU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BE00", Offset = "0x2B1AE00", VA = "0x182B1BE00")]
				internal bool FAYWKCQSNUH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BDA0", Offset = "0x2B1ADA0", VA = "0x182B1BDA0")]
				internal void FATPMVWVEIY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D940", Offset = "0x2B1C940", VA = "0x182B1D940")]
				internal bool OVQUIOQHEVS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D990", Offset = "0x2B1C990", VA = "0x182B1D990")]
				internal bool OVWBFVKEOHB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D9E0", Offset = "0x2B1C9E0", VA = "0x182B1D9E0")]
				internal bool OWBIDCEBXSK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DA30", Offset = "0x2B1CA30", VA = "0x182B1DA30")]
				internal bool OWGPAIXZHDT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D840", Offset = "0x2B1C840", VA = "0x182B1D840")]
				internal object OVGGOBCMLZA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D8B0", Offset = "0x2B1C8B0", VA = "0x182B1D8B0")]
				internal void OVLNLHWJVKJ(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DA80", Offset = "0x2B1CA80", VA = "0x182B1DA80")]
				internal bool OXGXMQTMCIM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DAD0", Offset = "0x2B1CAD0", VA = "0x182B1DAD0")]
				internal bool OXMEJXNJLTV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2B24BC0", Offset = "0x2B23BC0", VA = "0x182B24BC0")]
				internal int UWETWSFLZGK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2B24B60", Offset = "0x2B23B60", VA = "0x182B24B60")]
				internal void UVZMZLLOPVB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2B24B10", Offset = "0x2B23B10", VA = "0x182B24B10")]
				internal bool UVJSHRDWNNA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x2B24AC0", Offset = "0x2B23AC0", VA = "0x182B24AC0")]
				internal bool UVELKKJZEBR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2B24C10", Offset = "0x2B23C10", VA = "0x182B24C10")]
				internal int UXUXAUIQWTE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D740", Offset = "0x2B1C740", VA = "0x182B1D740")]
				internal void NXJKUCHZSDJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D6F0", Offset = "0x2B1C6F0", VA = "0x182B1D6F0")]
				internal bool NXEDWVOCISA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D7F0", Offset = "0x2B1C7F0", VA = "0x182B1D7F0")]
				internal bool NXTYOPVULAB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D7A0", Offset = "0x2B1C7A0", VA = "0x182B1D7A0")]
				internal bool NXORRJBXBOS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D6A0", Offset = "0x2B1C6A0", VA = "0x182B1D6A0")]
				internal int NWYWZOUEZGR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D640", Offset = "0x2B1C640", VA = "0x182B1D640")]
				internal void NWTQCIAHPVI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D5F0", Offset = "0x2B1C5F0", VA = "0x182B1D5F0")]
				internal bool NVTHQAEUUQP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D5A0", Offset = "0x2B1C5A0", VA = "0x182B1D5A0")]
				internal bool NVOASTKXLFG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C6E0", Offset = "0x2B1B6E0", VA = "0x182B1C6E0")]
				internal bool GWSFVJZXCLA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C7C0", Offset = "0x2B1B7C0", VA = "0x182B1C7C0")]
				internal object GXSOHRVJXPT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C730", Offset = "0x2B1B730", VA = "0x182B1C730")]
				internal void GXCTPXNRVHS(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C640", Offset = "0x2B1B640", VA = "0x182B1C640")]
				internal bool GVCCRHWSEYG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C690", Offset = "0x2B1B690", VA = "0x182B1C690")]
				internal bool GVHJOOQPOJP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x2B25E20", Offset = "0x2B24E20", VA = "0x182B25E20")]
				internal object? ZWBAWRRUMSR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2B25D90", Offset = "0x2B24D90", VA = "0x182B25D90")]
				internal void ZVVTZKXXDHI(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2B25D40", Offset = "0x2B24D40", VA = "0x182B25D40")]
				internal bool ZVFZHQQFAZH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x2B25CF0", Offset = "0x2B24CF0", VA = "0x182B25CF0")]
				internal int ZVASKJWHRNY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2B25C90", Offset = "0x2B24C90", VA = "0x182B25C90")]
				internal void ZUVLNDCKICP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2B25C40", Offset = "0x2B24C40", VA = "0x182B25C40")]
				internal bool ZUQEPWIMYRG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2B25EE0", Offset = "0x2B24EE0", VA = "0x182B25EE0")]
				internal bool ZXREATUZKFL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2B25E90", Offset = "0x2B24E90", VA = "0x182B25E90")]
				internal bool ZXLXDNBCAUC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2B248D0", Offset = "0x2B238D0", VA = "0x182B248D0")]
				internal int TVHULHISIWQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2B24920", Offset = "0x2B23920", VA = "0x182B24920")]
				internal void TVNBIOCPSHZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2B24980", Offset = "0x2B23980", VA = "0x182B24980")]
				internal bool TVSIFUWNBTI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2B249D0", Offset = "0x2B239D0", VA = "0x182B249D0")]
				internal bool TVXPDBQKLER()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2B24780", Offset = "0x2B23780", VA = "0x182B24780")]
				internal bool TUMSWGHCXDG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2B247D0", Offset = "0x2B237D0", VA = "0x182B247D0")]
				internal float TURZTNBAGOP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2B24820", Offset = "0x2B23820", VA = "0x182B24820")]
				internal void TUXGQTUXPZY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2B24880", Offset = "0x2B23880", VA = "0x182B24880")]
				internal bool TVCNOAOUZLH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2B24A20", Offset = "0x2B23A20", VA = "0x182B24A20")]
				internal bool TWXXPJLXGJK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2B24A70", Offset = "0x2B23A70", VA = "0x182B24A70")]
				internal bool TXDEMQFUPUT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D350", Offset = "0x2B1C350", VA = "0x182B1D350")]
				internal float MUQPMPAPTEH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D2F0", Offset = "0x2B1C2F0", VA = "0x182B1D2F0")]
				internal void MULIPIGSJSY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D3A0", Offset = "0x2B1C3A0", VA = "0x182B1D3A0")]
				internal bool MVBDHCOKMAZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D3F0", Offset = "0x2B1C3F0", VA = "0x182B1D3F0")]
				internal bool MVGKEJIHVMI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D4B0", Offset = "0x2B1C4B0", VA = "0x182B1D4B0")]
				internal string MVWEWDPZXUJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D440", Offset = "0x2B1C440", VA = "0x182B1D440")]
				internal void MVQXYWWCOJA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D550", Offset = "0x2B1C550", VA = "0x182B1D550")]
				internal bool MWGSQRDUQRB(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D500", Offset = "0x2B1C500", VA = "0x182B1D500")]
				internal bool MWBLTKJXHFS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C550", Offset = "0x2B1B550", VA = "0x182B1C550")]
				internal bool GALXEFFGTLA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C5A0", Offset = "0x2B1B5A0", VA = "0x182B1C5A0")]
				internal bool GAREBLZECWJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C490", Offset = "0x2B1B490", VA = "0x182B1C490")]
				internal string GABJJRRMAOI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C4E0", Offset = "0x2B1B4E0", VA = "0x182B1C4E0")]
				internal void GAGQGYLJJZR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C3F0", Offset = "0x2B1B3F0", VA = "0x182B1C3F0")]
				internal bool FZQVPEDRHRQ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C440", Offset = "0x2B1B440", VA = "0x182B1C440")]
				internal bool FZWCMKXORCZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C350", Offset = "0x2B1B350", VA = "0x182B1C350")]
				internal bool FZGHUQPWOUY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C3A0", Offset = "0x2B1B3A0", VA = "0x182B1C3A0")]
				internal bool FZLORXJTYGH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C1E0", Offset = "0x2B1B1E0", VA = "0x182B1C1E0")]
				internal string FYVUADCBVYG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C280", Offset = "0x2B1B280", VA = "0x182B1C280")]
				internal void FZBAXJVZFJP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B251A0", Offset = "0x2B241A0", VA = "0x182B251A0")]
				internal bool YZUSFMXEDSR(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B25150", Offset = "0x2B24150", VA = "0x182B25150")]
				internal bool YZPLIGDGUHI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2B25100", Offset = "0x2B24100", VA = "0x182B25100")]
				internal bool YZKEKZJJKVZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2B250B0", Offset = "0x2B240B0", VA = "0x182B250B0")]
				internal bool YZEXNSPMBKQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2B25300", Offset = "0x2B24300", VA = "0x182B25300")]
				internal string ZAPTUNYTPMB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2B25290", Offset = "0x2B24290", VA = "0x182B25290")]
				internal void ZAKMXHEWGAS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B25240", Offset = "0x2B24240", VA = "0x182B25240")]
				internal bool ZAFGAAKYWPJ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B251F0", Offset = "0x2B241F0", VA = "0x182B251F0")]
				internal bool YZZZCTRBNEA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2B25060", Offset = "0x2B24060", VA = "0x182B25060")]
				internal bool YYEPBKTZGFX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2B25010", Offset = "0x2B24010", VA = "0x182B25010")]
				internal bool YXZIEEABWUO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E170", Offset = "0x2B1D170", VA = "0x182B1E170")]
				internal string RZDNGUPBOAI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E1C0", Offset = "0x2B1D1C0", VA = "0x182B1E1C0")]
				internal void RZIUEBIYXLR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E230", Offset = "0x2B1D230", VA = "0x182B1E230")]
				internal bool RZOBBICWGXA(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E280", Offset = "0x2B1D280", VA = "0x182B1E280")]
				internal bool RZTHYOWTQIJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E2D0", Offset = "0x2B1D2D0", VA = "0x182B1E2D0")]
				internal bool RZYOVVQQZTS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E320", Offset = "0x2B1D320", VA = "0x182B1E320")]
				internal bool SADVTCKOJFB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E370", Offset = "0x2B1D370", VA = "0x182B1E370")]
				internal string SAJCQJELSQK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E3C0", Offset = "0x2B1D3C0", VA = "0x182B1E3C0")]
				internal void SAOJNPYJCBT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E0D0", Offset = "0x2B1D0D0", VA = "0x182B1E0D0")]
				internal bool RXNKCSLWQNO(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E120", Offset = "0x2B1D120", VA = "0x182B1E120")]
				internal bool RXSQZZFTZYX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D120", Offset = "0x2B1C120", VA = "0x182B1D120")]
				internal bool LYKGVKFZKEH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D0D0", Offset = "0x2B1C0D0", VA = "0x182B1D0D0")]
				internal bool LYEZYDMCASY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D1E0", Offset = "0x2B1C1E0", VA = "0x182B1D1E0")]
				internal string LYUUPXTUDAZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D170", Offset = "0x2B1C170", VA = "0x182B1D170")]
				internal void LYPNSQZWTPQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CFE0", Offset = "0x2B1BFE0", VA = "0x182B1CFE0")]
				internal bool LXPFGJEJYKX(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CF90", Offset = "0x2B1BF90", VA = "0x182B1CF90")]
				internal bool LXJYJCKMOZO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D080", Offset = "0x2B1C080", VA = "0x182B1D080")]
				internal bool LXZTAWSERHP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D030", Offset = "0x2B1C030", VA = "0x182B1D030")]
				internal bool LXUMDPYHHWG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D2A0", Offset = "0x2B1C2A0", VA = "0x182B1D2A0")]
				internal string MAAJZMJEHRB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D230", Offset = "0x2B1C230", VA = "0x182B1D230")]
				internal void LZVDCFPGYFS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BB00", Offset = "0x2B1AB00", VA = "0x182B1BB00")]
				internal bool EXTBWRXWULY(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BB50", Offset = "0x2B1AB50", VA = "0x182B1BB50")]
				internal bool EXYITYRUDXH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BA60", Offset = "0x2B1AA60", VA = "0x182B1BA60")]
				internal bool EXIOCEKCBPG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BAB0", Offset = "0x2B1AAB0", VA = "0x182B1BAB0")]
				internal bool EXNUZLDZLAP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BC40", Offset = "0x2B1AC40", VA = "0x182B1BC40")]
				internal string EYODLSZMGFI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BC90", Offset = "0x2B1AC90", VA = "0x182B1BC90")]
				internal void EYTKIZTJPQR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BBA0", Offset = "0x2B1ABA0", VA = "0x182B1BBA0")]
				internal bool EYDPRFLRNIQ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BBF0", Offset = "0x2B1ABF0", VA = "0x182B1BBF0")]
				internal bool EYIWOMFOWTZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BD00", Offset = "0x2B1AD00", VA = "0x182B1BD00")]
				internal bool EZJFAUBBRYS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B1BD50", Offset = "0x2B1AD50", VA = "0x182B1BD50")]
				internal bool EZOLYAUZBKB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DCD0", Offset = "0x2B1CCD0", VA = "0x182B1DCD0")]
				internal string PPXSQTNURWS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DD20", Offset = "0x2B1CD20", VA = "0x182B1DD20")]
				internal void PQCZOAHSBIB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DC80", Offset = "0x2B1CC80", VA = "0x182B1DC80")]
				internal bool PPSLTMTXILJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DBE0", Offset = "0x2B1CBE0", VA = "0x182B1DBE0")]
				internal bool PPCRBSMFGDI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DC30", Offset = "0x2B1CC30", VA = "0x182B1DC30")]
				internal bool PPHXYZGCPOR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DB20", Offset = "0x2B1CB20", VA = "0x182B1DB20")]
				internal string POSDHEYKNGQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DB70", Offset = "0x2B1CB70", VA = "0x182B1DB70")]
				internal void POXKELSHWRZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DD90", Offset = "0x2B1CD90", VA = "0x182B1DD90")]
				internal bool PRNVUVQZPJM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DDE0", Offset = "0x2B1CDE0", VA = "0x182B1DDE0")]
				internal bool PRTCSCKWYUV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B24D00", Offset = "0x2B23D00", VA = "0x182B24D00")]
				internal bool VQQZCDWWVST()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x2B24CB0", Offset = "0x2B23CB0", VA = "0x182B24CB0")]
				internal string VQLSEXCZMHK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x2B24DA0", Offset = "0x2B23DA0", VA = "0x182B24DA0")]
				internal void VRBMWRKROPL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2B24D50", Offset = "0x2B23D50", VA = "0x182B24D50")]
				internal bool VQWFZKQUFEC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2B24E60", Offset = "0x2B23E60", VA = "0x182B24E60")]
				internal bool VRMAREYMHMD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2B24E10", Offset = "0x2B23E10", VA = "0x182B24E10")]
				internal bool VRGTTYEOYAU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B24F20", Offset = "0x2B23F20", VA = "0x182B24F20")]
				internal string VRWOLSMHAIV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B24EB0", Offset = "0x2B23EB0", VA = "0x182B24EB0")]
				internal void VRRHOLSJQXM(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B24C60", Offset = "0x2B23C60", VA = "0x182B24C60")]
				internal bool VOVPAUZUOUQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B7B0", Offset = "0x2B1A7B0", VA = "0x182B1B7B0")]
				internal bool BOPITIXPMMA(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DE30", Offset = "0x2B1CE30", VA = "0x182B1DE30")]
				internal float QLTNNKUQIAA()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DE80", Offset = "0x2B1CE80", VA = "0x182B1DE80")]
				internal void QLYUKRONRLJ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DF80", Offset = "0x2B1CF80", VA = "0x182B1DF80")]
				internal bool QMZCWZKAMQC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DFD0", Offset = "0x2B1CFD0", VA = "0x182B1DFD0")]
				internal bool QNEJUGDXWBL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DEE0", Offset = "0x2B1CEE0", VA = "0x182B1DEE0")]
				internal bool QMOPCLWFTTK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DF30", Offset = "0x2B1CF30", VA = "0x182B1DF30")]
				internal int QMTVZSQDDET()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E020", Offset = "0x2B1D020", VA = "0x182B1E020")]
				internal void QNUEMALPYJM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E080", Offset = "0x2B1D080", VA = "0x182B1E080")]
				internal bool QNZLJHFNHUV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B24FC0", Offset = "0x2B23FC0", VA = "0x182B24FC0")]
				internal bool XMVGGQQNQPB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B24F70", Offset = "0x2B23F70", VA = "0x182B24F70")]
				internal bool XMPZJJWQHDS()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class LPVZUMXOCMR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string CDGWEXVBLNY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public LPQSXGDQTBI LWPGXDDEGGX;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public LPVZUMXOCMR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B41680", Offset = "0x2B40680", VA = "0x182B41680")]
				internal void ZCBAABESQWJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class LPGFCSPWAEQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] FBMJIRRAECJ;

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public LPGFCSPWAEQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B41320", Offset = "0x2B40320", VA = "0x182B41320")]
				internal bool QMJIFFCIKIB(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers NHVWVPJUCXW;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B1B5F0", Offset = "0x2B1A5F0", VA = "0x182B1B5F0")]
			public JXZXTNEOMNQ(COWOBFPVIKZ a, NAFQXGFAERB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B199F0", Offset = "0x2B189F0", VA = "0x182B199F0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class IFOULNRYPHN : VEKHZDNAXTU<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool XCHAFNGAKCC
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B405A0", Offset = "0x2B3F5A0", VA = "0x182B405A0")]
			public IFOULNRYPHN(COWOBFPVIKZ a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B3FCF0", Offset = "0x2B3ECF0", VA = "0x182B3FCF0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B404A0", Offset = "0x2B3F4A0", VA = "0x182B404A0")]
			private static string ZNZTOQOQTAD(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B40040", Offset = "0x2B3F040", VA = "0x182B40040")]
			[CompilerGenerated]
			private object? WTABHQMZRBW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B400E0", Offset = "0x2B3F0E0", VA = "0x182B400E0")]
			[CompilerGenerated]
			private void WTFIEXGXANF(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B401F0", Offset = "0x2B3F1F0", VA = "0x182B401F0")]
			[CompilerGenerated]
			private string WTKPCEAUJYO(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B40400", Offset = "0x2B3F400", VA = "0x182B40400")]
			[CompilerGenerated]
			private IReadOnlyList<object> WTPVZKURTJX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B3FFA0", Offset = "0x2B3EFA0", VA = "0x182B3FFA0")]
			[CompilerGenerated]
			private string? WSEZSPLKFIM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B40000", Offset = "0x2B3F000", VA = "0x182B40000")]
			[CompilerGenerated]
			private bool WSKGPWFHOTV()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class NYDNZGPBHEN : VEKHZDNAXTU<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class GWEWRBMCNCR
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
					public GWEWRBMCNCR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000300")]
					[Cpp2IlInjected.Address(RVA = "0x2B4ABB0", Offset = "0x2B49BB0", VA = "0x182B4ABB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000301")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public NYDNZGPBHEN NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GWEWRBMCNCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A1B0", Offset = "0x2B391B0", VA = "0x182B3A1B0")]
				internal string FYWQLBYJBCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A720", Offset = "0x2B39720", VA = "0x182B3A720")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void FZBXIISGKNV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AAB0", Offset = "0x2B39AB0", VA = "0x182B3AAB0")]
				internal int FZHEFPMDTZE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3ADB0", Offset = "0x2B39DB0", VA = "0x182B3ADB0")]
				internal void FZMLCWGBDKN(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B42DA0", Offset = "0x2B41DA0", VA = "0x182B42DA0")]
			public NYDNZGPBHEN(COWOBFPVIKZ a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B42A70", Offset = "0x2B41A70", VA = "0x182B42A70", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class EOJACYQSNUG : VEKHZDNAXTU<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class CCYEXJECMVG
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
					public CCYEXJECMVG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2B4A870", Offset = "0x2B49870", VA = "0x182B4A870", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public CCYEXJECMVG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000317")]
					[Cpp2IlInjected.Address(RVA = "0x2B4B160", Offset = "0x2B4A160", VA = "0x182B4B160", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000318")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public EOJACYQSNUG NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public CCYEXJECMVG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2B37C40", Offset = "0x2B36C40", VA = "0x182B37C40")]
				internal string FYWQLBYJBCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2B37C90", Offset = "0x2B36C90", VA = "0x182B37C90")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void FZBXIISGKNV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2B37D60", Offset = "0x2B36D60", VA = "0x182B37D60")]
				internal int FZHEFPMDTZE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2B37DB0", Offset = "0x2B36DB0", VA = "0x182B37DB0")]
				internal Task<bool> FZMLCWGBDKN(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2B37A40", Offset = "0x2B36A40", VA = "0x182B37A40")]
				internal string FYBOWAWTPJC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2B37A90", Offset = "0x2B36A90", VA = "0x182B37A90")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void FYGVTHQQYUL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2B37B60", Offset = "0x2B36B60", VA = "0x182B37B60")]
				internal bool FYMCQOKOIFU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2B37BB0", Offset = "0x2B36BB0", VA = "0x182B37BB0")]
				internal void FYRJNVELRRD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2B37E40", Offset = "0x2B36E40", VA = "0x182B37E40")]
				internal bool GAMTPEBNYPG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x2B37E90", Offset = "0x2B36E90", VA = "0x182B37E90")]
				internal void GASAMKVLIAP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2B38160", Offset = "0x2B37160", VA = "0x182B38160")]
				internal float TDXJLPKCQRT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x2B380D0", Offset = "0x2B370D0", VA = "0x182B380D0")]
				internal void TDSCOIQFHGK(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2B38070", Offset = "0x2B37070", VA = "0x182B38070")]
				internal int TDMVRBWHXVB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x2B37FD0", Offset = "0x2B36FD0", VA = "0x182B37FD0")]
				internal void TDHOTVCKOJS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x2B37F60", Offset = "0x2B36F60", VA = "0x182B37F60")]
				internal bool TDCHWOINEYJ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2B38D10", Offset = "0x2B37D10", VA = "0x182B38D10")]
			public EOJACYQSNUG(COWOBFPVIKZ a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x2B383B0", Offset = "0x2B373B0", VA = "0x182B383B0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class LGQOAWAMQNP : VEKHZDNAXTU<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class GWEWRBMCNCR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public LGQOAWAMQNP NJJCUEUTHZM;

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GWEWRBMCNCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A250", Offset = "0x2B39250", VA = "0x182B3A250")]
				internal Dictionary<string, EnumChoiceData> FYWQLBYJBCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A510", Offset = "0x2B39510", VA = "0x182B3A510")]
				internal int FZBXIISGKNV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A930", Offset = "0x2B39930", VA = "0x182B3A930")]
				internal void FZHEFPMDTZE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AD30", Offset = "0x2B39D30", VA = "0x182B3AD30")]
				internal bool FZMLCWGBDKN()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2B412B0", Offset = "0x2B402B0", VA = "0x182B412B0")]
			public LGQOAWAMQNP(COWOBFPVIKZ a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x2B41000", Offset = "0x2B40000", VA = "0x182B41000", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class JJJRHMLBBMM : VEKHZDNAXTU<SGHGIVHUEIR>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class GWEWRBMCNCR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public JJJRHMLBBMM NJJCUEUTHZM;

				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GWEWRBMCNCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A2F0", Offset = "0x2B392F0", VA = "0x182B3A2F0")]
				internal void FYWQLBYJBCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2B40850", Offset = "0x2B3F850", VA = "0x182B40850")]
			public JJJRHMLBBMM(COWOBFPVIKZ a, SGHGIVHUEIR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x2B406D0", Offset = "0x2B3F6D0", VA = "0x182B406D0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class ZOQLLUOUGKK<a> : GBWBBWFEMCJ<a> where a : notnull, JMZDBTZDFHE
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override RQAWMUULEWV? ACSVDAUSNCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x51488B0", Offset = "0x51478B0", VA = "0x1851488B0", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x5148910", Offset = "0x5147910", VA = "0x185148910", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xF3CAA0", Offset = "0xF3BAA0", VA = "0x180F3CAA0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x51488F0", Offset = "0x51478F0", VA = "0x1851488F0")]
			public ZOQLLUOUGKK(COWOBFPVIKZ a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class CAZAYRTYNXI : ZOQLLUOUGKK<FMYNRNNNIYD>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class LPQSXGDQTBI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public CAZAYRTYNXI NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public LPQSXGDQTBI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2B41390", Offset = "0x2B40390", VA = "0x182B41390")]
				internal object FYWQLBYJBCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x2B41440", Offset = "0x2B40440", VA = "0x182B41440")]
				internal void FZBXIISGKNV(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x2B41510", Offset = "0x2B40510", VA = "0x182B41510")]
				internal void FZHEFPMDTZE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? JWMZUYINMKA;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2B379E0", Offset = "0x2B369E0", VA = "0x182B379E0")]
			public CAZAYRTYNXI(COWOBFPVIKZ a, FMYNRNNNIYD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x2B37460", Offset = "0x2B36460", VA = "0x182B37460", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class MXIALLFMSVT : VEKHZDNAXTU<YJPTEHWLYDY>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public MXIALLFMSVT NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<SNPPUNKBJMN>> FFSWMJZXRDN;

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C5A0", Offset = "0x2B3B5A0", VA = "0x182B3C5A0")]
				internal int FZBXIISGKNV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CA70", Offset = "0x2B3BA70", VA = "0x182B3CA70")]
				internal void FZHEFPMDTZE(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class GZNYNIPMRAY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<SNPPUNKBJMN> GVXIIFFQAJP;

				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZNYNIPMRAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600033B")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BCB0", Offset = "0x2B3ACB0", VA = "0x182B3BCB0")]
				internal bool FYBOWAWTPJC(Id32<SNPPUNKBJMN> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2B42850", Offset = "0x2B41850", VA = "0x182B42850")]
			public MXIALLFMSVT(COWOBFPVIKZ a, YJPTEHWLYDY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x2B42320", Offset = "0x2B41320", VA = "0x182B42320", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class AMRZKLPNXCF : VEKHZDNAXTU<OLPZJXJPFMK>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0xD26F10", Offset = "0xD25F10", VA = "0x180D26F10", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x2B37090", Offset = "0x2B36090", VA = "0x182B37090")]
			public AMRZKLPNXCF(COWOBFPVIKZ a, OLPZJXJPFMK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class GFXEAZTVFNE : VEKHZDNAXTU<AHSGZZPHSED>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0xD64890", Offset = "0xD63890", VA = "0x180D64890", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x2B395F0", Offset = "0x2B385F0", VA = "0x182B395F0")]
			public GFXEAZTVFNE(COWOBFPVIKZ a, AHSGZZPHSED b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "134")]
			protected override bool BKHDIZADVTQ(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class YCICJVAIEGS : VEKHZDNAXTU<AFUOAHAAPFJ>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000344")]
				[Cpp2IlInjected.Address(RVA = "0x2B527F0", Offset = "0x2B517F0", VA = "0x182B527F0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool XCHAFNGAKCC
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x2B52780", Offset = "0x2B51780", VA = "0x182B52780")]
			public YCICJVAIEGS(COWOBFPVIKZ a, AFUOAHAAPFJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class GCIFLZFBEXY : VEKHZDNAXTU<GTWNGYTKWUP>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x2B39540", Offset = "0x2B38540", VA = "0x182B39540", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool XCHAFNGAKCC
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2B394D0", Offset = "0x2B384D0", VA = "0x182B394D0")]
			public GCIFLZFBEXY(COWOBFPVIKZ a, GTWNGYTKWUP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class FNDWUOSBBRB : SUTGBCUJVSK<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public FNDWUOSBBRB NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D010", Offset = "0x2B3C010", VA = "0x182B3D010")]
				internal float HYJRWBINHOV()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CED0", Offset = "0x2B3BED0", VA = "0x182B3CED0")]
				internal void HYEKYUOPYDM(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x2B39470", Offset = "0x2B38470", VA = "0x182B39470")]
			public FNDWUOSBBRB(COWOBFPVIKZ a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x2B39200", Offset = "0x2B38200", VA = "0x182B39200", Slot = "151")]
			protected override void DZVYKMORJUZ(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class GYAHYOJICLK : VEKHZDNAXTU<TVREFVKTABP>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BBF0", Offset = "0x2B3ABF0", VA = "0x182B3BBF0")]
			public GYAHYOJICLK(COWOBFPVIKZ a, TVREFVKTABP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class VLXFLNMWRDS : VEKHZDNAXTU<BYFUNWYUWHX>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2B520A0", Offset = "0x2B510A0", VA = "0x182B520A0")]
			public VLXFLNMWRDS(COWOBFPVIKZ a, BYFUNWYUWHX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class PVDZHIOYHON : VEKHZDNAXTU<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public PVDZHIOYHON NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BF70", Offset = "0x2B3AF70", VA = "0x182B3BF70")]
				internal bool FYWQLBYJBCM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C770", Offset = "0x2B3B770", VA = "0x182B3C770")]
				internal void FZBXIISGKNV(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x2B432E0", Offset = "0x2B422E0", VA = "0x182B432E0")]
			public PVDZHIOYHON(COWOBFPVIKZ a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x2B43050", Offset = "0x2B42050", VA = "0x182B43050", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class UDAPDPKVPRL : VEKHZDNAXTU<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public UDAPDPKVPRL NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> CUYNSKJNOQS;

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BFC0", Offset = "0x2B3AFC0", VA = "0x182B3BFC0")]
				internal object? FYWQLBYJBCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BEF0", Offset = "0x2B3AEF0", VA = "0x182B3BEF0")]
				internal bool FYRJNVELRRD(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C350", Offset = "0x2B3B350", VA = "0x182B3C350")]
				internal void FZBXIISGKNV(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CD30", Offset = "0x2B3BD30", VA = "0x182B3CD30")]
				internal string FZHEFPMDTZE(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CE80", Offset = "0x2B3BE80", VA = "0x182B3CE80")]
				internal IReadOnlyList<object> FZMLCWGBDKN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BD00", Offset = "0x2B3AD00", VA = "0x182B3BD00")]
				internal bool FYBOWAWTPJC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BD70", Offset = "0x2B3AD70", VA = "0x182B3BD70")]
				internal bool FYGVTHQQYUL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BDC0", Offset = "0x2B3ADC0", VA = "0x182B3BDC0")]
				internal void FYMCQOKOIFU(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4C4F0", Offset = "0x2B4B4F0", VA = "0x182B4C4F0")]
			public UDAPDPKVPRL(COWOBFPVIKZ a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BE10", Offset = "0x2B4AE10", VA = "0x182B4BE10", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class UDZDOOWIKSP : VEKHZDNAXTU<NUMZRONSPAY>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class CCYEXJECMVG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int UHZROLPZFTL;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public CCYEXJECMVG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x2B37F20", Offset = "0x2B36F20", VA = "0x182B37F20")]
				internal bool IZYFLRMOOEV(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class QBUTDWRBSPN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public UDZDOOWIKSP NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> JGMWSFLGNGV;

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public QBUTDWRBSPN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x2B43350", Offset = "0x2B42350", VA = "0x182B43350")]
				internal int FYWQLBYJBCM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0x2B433F0", Offset = "0x2B423F0", VA = "0x182B433F0")]
				internal void FZBXIISGKNV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0x2B43510", Offset = "0x2B42510", VA = "0x182B43510")]
				internal string? FZHEFPMDTZE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000369")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2B4CA60", Offset = "0x2B4BA60", VA = "0x182B4CA60")]
			public UDZDOOWIKSP(COWOBFPVIKZ a, NUMZRONSPAY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2B4C680", Offset = "0x2B4B680", VA = "0x182B4C680")]
			private int JEBXXYKHMXL(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4C560", Offset = "0x2B4B560", VA = "0x182B4C560")]
			private void EITZQLHCYKJ(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2B4C710", Offset = "0x2B4B710", VA = "0x182B4C710", Slot = "145")]
			protected sealed override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class DZAVNQRELYA : WXDTCCTCLXO<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0xF48230", Offset = "0xF47230", VA = "0x180F48230", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2B382E0", Offset = "0x2B372E0", VA = "0x182B382E0")]
			public DZAVNQRELYA(COWOBFPVIKZ a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class UABQOBYCVWG : SUTGBCUJVSK<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public UABQOBYCVWG NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D090", Offset = "0x2B3C090", VA = "0x182B3D090")]
				internal int HYJRWBINHOV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CF70", Offset = "0x2B3BF70", VA = "0x182B3CF70")]
				internal void HYEKYUOPYDM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BDB0", Offset = "0x2B4ADB0", VA = "0x182B4BDB0")]
			public UABQOBYCVWG(COWOBFPVIKZ a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BB40", Offset = "0x2B4AB40", VA = "0x182B4BB40", Slot = "151")]
			protected override void DZVYKMORJUZ(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class GRQXAUVZRAA : VEKHZDNAXTU<VVYTSHMVGPX>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public GRQXAUVZRAA NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<SNPPUNKBJMN>> FFSWMJZXRDN;

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C8A0", Offset = "0x2B3B8A0", VA = "0x182B3C8A0")]
				internal int FZBXIISGKNV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CBD0", Offset = "0x2B3BBD0", VA = "0x182B3CBD0")]
				internal void FZHEFPMDTZE(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class GZNYNIPMRAY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<SNPPUNKBJMN> GVXIIFFQAJP;

				[Cpp2IlInjected.Token(Token = "0x6000383")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZNYNIPMRAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BC60", Offset = "0x2B3AC60", VA = "0x182B3BC60")]
				internal bool FYBOWAWTPJC(Id32<SNPPUNKBJMN> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x2B39F10", Offset = "0x2B38F10", VA = "0x182B39F10")]
			public GRQXAUVZRAA(COWOBFPVIKZ a, VVYTSHMVGPX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x2B399E0", Offset = "0x2B389E0", VA = "0x182B399E0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class KNNMELXWMPY : VEKHZDNAXTU<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public KNNMELXWMPY NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000388")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C140", Offset = "0x2B3B140", VA = "0x182B3C140")]
				internal bool FYWQLBYJBCM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C230", Offset = "0x2B3B230", VA = "0x182B3C230")]
				internal void FZBXIISGKNV(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2B40B60", Offset = "0x2B3FB60", VA = "0x182B40B60")]
			public KNNMELXWMPY(COWOBFPVIKZ a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2B40990", Offset = "0x2B3F990", VA = "0x182B40990", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class XAMOGIXKLAC : VEKHZDNAXTU<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public XAMOGIXKLAC NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C0F0", Offset = "0x2B3B0F0", VA = "0x182B3C0F0")]
				internal bool FYWQLBYJBCM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C6E0", Offset = "0x2B3B6E0", VA = "0x182B3C6E0")]
				internal void FZBXIISGKNV(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x2B522E0", Offset = "0x2B512E0", VA = "0x182B522E0")]
			public XAMOGIXKLAC(COWOBFPVIKZ a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2B52110", Offset = "0x2B51110", VA = "0x182B52110", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class RZYRCMWYHGU : VEKHZDNAXTU<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public RZYRCMWYHGU NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000392")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C190", Offset = "0x2B3B190", VA = "0x182B3C190")]
				internal int FYWQLBYJBCM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C9E0", Offset = "0x2B3B9E0", VA = "0x182B3C9E0")]
				internal void FZBXIISGKNV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x2B44000", Offset = "0x2B43000", VA = "0x182B44000")]
			public RZYRCMWYHGU(COWOBFPVIKZ a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x2B43DB0", Offset = "0x2B42DB0", VA = "0x182B43DB0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class NPURSMZPBDF
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log NSTUKEGGGWA;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class YAIAFNMGNKM<a> : VEKHZDNAXTU<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class LXFDTAXQBQL
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
					public LXFDTAXQBQL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C8")]
					[Cpp2IlInjected.Address(RVA = "0x41B1570", Offset = "0x41B0570", VA = "0x1841B1570", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C9")]
					[Cpp2IlInjected.Address(RVA = "0x41B18B0", Offset = "0x41B08B0", VA = "0x1841B18B0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload SROPTKKYNAY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public YAIAFNMGNKM<a> NJJCUEUTHZM;

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public LXFDTAXQBQL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x697A660", Offset = "0x6979660", VA = "0x18697A660")]
				[AsyncStateMachine(typeof(YAIAFNMGNKM<>.LXFDTAXQBQL.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task GDRCBGSANSY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0x697A9D0", Offset = "0x69799D0", VA = "0x18697A9D0")]
				internal void XIMHSTQMGHF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class UTHDVMVAFHD
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
					public UTHDVMVAFHD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x41C6BE0", Offset = "0x41C5BE0", VA = "0x1841C6BE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public UTHDVMVAFHD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DD")]
					[Cpp2IlInjected.Address(RVA = "0x41C83C0", Offset = "0x41C73C0", VA = "0x1841C83C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DE")]
					[Cpp2IlInjected.Address(RVA = "0x41C8AD0", Offset = "0x41C7AD0", VA = "0x1841C8AD0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public YAVKDLMCPYL.OJOLWQHPXVX QCBZJKMZKLQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string PBYGCQKILPN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string EMDZZVRYPNT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public YAIAFNMGNKM<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper IKYZLGWFXOR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool LKGGGXQHYYH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action JSYISEHMTGN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool MQYVWWZZGMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string ESQLAFDHMQX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action IDKXSEGWHLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action CDRDZQJBJTR;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public UTHDVMVAFHD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x7F1FA50", Offset = "0x7F1EA50", VA = "0x187F1FA50")]
				internal void NGTOHJTBGWI(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x7F1FAA0", Offset = "0x7F1EAA0", VA = "0x187F1FAA0")]
				internal void NGYVEQMYQHR(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
				internal string HKTECQZBWDB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x7F1F560", Offset = "0x7F1E560", VA = "0x187F1F560")]
				internal void HKNXFKFEMRS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0x73B4380", Offset = "0x73B3380", VA = "0x1873B4380")]
				internal bool HLDRXEMWOZT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0x7F1F6F0", Offset = "0x7F1E6F0", VA = "0x187F1F6F0")]
				internal char HKYKZXSZFOK((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
				internal string? HJYCNPXMKJR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0xF40E90", Offset = "0xF3FE90", VA = "0x180F40E90")]
				internal bool HJSVQJDPAYI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x7F1F4A0", Offset = "0x7F1E4A0", VA = "0x187F1F4A0")]
				internal void HKIQIDLHDGJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x73B4380", Offset = "0x73B3380", VA = "0x1873B4380")]
				internal bool HKDJKWRJTVA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x7F1F7D0", Offset = "0x7F1E7D0", VA = "0x187F1F7D0")]
				[AsyncStateMachine(typeof(YAIAFNMGNKM<>.UTHDVMVAFHD.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void HMJHGTCGTPV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x7F1FDE0", Offset = "0x7F1EDE0", VA = "0x187F1FDE0")]
				internal void ZHAOREBOTGZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x7F1FB10", Offset = "0x7F1EB10", VA = "0x187F1FB10")]
				[AsyncStateMachine(typeof(YAIAFNMGNKM<>.UTHDVMVAFHD.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task PXTHRVLHUTY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x7F1F930", Offset = "0x7F1E930", VA = "0x187F1F930")]
				internal void NFISAOJTSUX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x7F1F870", Offset = "0x7F1E870", VA = "0x187F1F870")]
				internal void ICGQNEEPMAH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x7F1F790", Offset = "0x7F1E790", VA = "0x187F1F790")]
				internal bool HMEAJMIJKEM()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class HRKKFMRPITS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter NPFHHBNKTHH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public YAIAFNMGNKM<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<YAVKDLMCPYL.YNQTUTNLEIR> IBPNQVJUAMY;

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public HRKKFMRPITS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x651AA30", Offset = "0x6519A30", VA = "0x18651AA30")]
				internal bool BAURLFXVSOY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x651AA70", Offset = "0x6519A70", VA = "0x18651AA70")]
				internal void MXVICHTZZRC(YAVKDLMCPYL.YNQTUTNLEIR a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class HRPRCTLMSFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool FSKANLSIQCT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public DBTVNXLTCIC KEBAAHATUJX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public DBTVNXLTCIC DSCZUCFYEZQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public DBTVNXLTCIC YJXWVVFZPQZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string YZOZXFNTZQG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public HRKKFMRPITS LWPGXDDEGGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action CVJBMXXIHNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action ICFIIPRMCUZ;

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public HRPRCTLMSFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0xF49FB0", Offset = "0xF48FB0", VA = "0x180F49FB0")]
				internal bool VACSSXUZQNS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x651BA10", Offset = "0x651AA10", VA = "0x18651BA10")]
				internal void JPCZRALTSQN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x651B5A0", Offset = "0x651A5A0", VA = "0x18651B5A0")]
				internal void BBKMDAFNUWZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x651AB40", Offset = "0x6519B40", VA = "0x18651AB40")]
				internal void AYJMSCTBJIU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x651AB60", Offset = "0x6519B60", VA = "0x18651AB60")]
				internal void BAKDQSKAZSG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0x651AF50", Offset = "0x6519F50", VA = "0x18651AF50")]
				internal void BAZYIMRTCAH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x651AB40", Offset = "0x6519B40", VA = "0x18651AB40")]
				internal void MYLCUCBSBZD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class HRUYAAFKBQK
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
					public HRUYAAFKBQK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003ED")]
					[Cpp2IlInjected.Address(RVA = "0x41DDBB0", Offset = "0x41DCBB0", VA = "0x1841DDBB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EE")]
					[Cpp2IlInjected.Address(RVA = "0x41DE1F0", Offset = "0x41DD1F0", VA = "0x1841DE1F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool ZRDYZWJLLET;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public HRPRCTLMSFB LWUNUJXBPSG;

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public HRUYAAFKBQK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x651BB80", Offset = "0x651AB80", VA = "0x18651BB80")]
				[AsyncStateMachine(typeof(YAIAFNMGNKM<>.HRUYAAFKBQK.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task GMJHQKEUQYX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0x651BB10", Offset = "0x651AB10", VA = "0x18651BB10")]
				internal void AYOTPJMYSUD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class HSAEXGZHLBT
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
					public HSAEXGZHLBT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F2")]
					[Cpp2IlInjected.Address(RVA = "0x41DD5A0", Offset = "0x41DC5A0", VA = "0x1841DD5A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F3")]
					[Cpp2IlInjected.Address(RVA = "0x41DDB50", Offset = "0x41DCB50", VA = "0x1841DDB50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload KEZZRBYTIOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public HRPRCTLMSFB LWZURQQYZDP;

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public HSAEXGZHLBT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F0")]
				[Cpp2IlInjected.Address(RVA = "0x651C6B0", Offset = "0x651B6B0", VA = "0x18651C6B0")]
				[AsyncStateMachine(typeof(YAIAFNMGNKM<>.HSAEXGZHLBT.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task GOFMVFXTXJI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0x651C780", Offset = "0x651B780", VA = "0x18651C780")]
				internal void MYFVWVHUSNU()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class MKRBZEZPJBD
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
					public MKRBZEZPJBD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F9")]
					[Cpp2IlInjected.Address(RVA = "0x41DD0C0", Offset = "0x41DC0C0", VA = "0x1841DD0C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003FA")]
					[Cpp2IlInjected.Address(RVA = "0x41DD540", Offset = "0x41DC540", VA = "0x1841DD540", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public YAIAFNMGNKM<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload BDDNNCVODXU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public YAVKDLMCPYL.YNQTUTNLEIR QCBZJKMZKLQ;

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public MKRBZEZPJBD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x6FBCC40", Offset = "0x6FBBC40", VA = "0x186FBCC40")]
				[AsyncStateMachine(typeof(YAIAFNMGNKM<>.MKRBZEZPJBD.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task OTNDJVEBJHC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x6FBCE80", Offset = "0x6FBBE80", VA = "0x186FBCE80")]
				internal bool QAMJBDXEWAC(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F7")]
				[Cpp2IlInjected.Address(RVA = "0x6FBCD60", Offset = "0x6FBBD60", VA = "0x186FBCD60")]
				internal void QAHCDXDHMOT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F8")]
				[Cpp2IlInjected.Address(RVA = "0x6FBCD10", Offset = "0x6FBBD10", VA = "0x186FBCD10")]
				internal void QABVGQJKDDK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class RECYFJRDOZU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string EQCNFQTAIAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public DBTVNXLTCIC GQQQTJKWLWI;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public RECYFJRDOZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x781A410", Offset = "0x7819410", VA = "0x18781A410")]
				internal string? AQFHNPYJJTV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xE9D0C0", Offset = "0xE9C0C0", VA = "0x180E9D0C0")]
				internal bool AQAAQJEMAIM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FE")]
				[Cpp2IlInjected.Address(RVA = "0x781A430", Offset = "0x7819430", VA = "0x18781A430")]
				internal void AQPVIDMECQN(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool DFCXQXBAAMO;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log NSTUKEGGGWA
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x50D0130", Offset = "0x50CF130", VA = "0x1850D0130")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool XCHAFNGAKCC
			{
				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000398")]
				[Cpp2IlInjected.Address(RVA = "0x50D3F80", Offset = "0x50D2F80", VA = "0x1850D3F80", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected YAVKDLMCPYL ZXMLSLTRIQW
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xCFA2A0", Offset = "0xCF92A0", VA = "0x180CFA2A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xCFA280", Offset = "0xCF9280", VA = "0x180CFA280")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> JMICKCHTCQJ
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xDBC260", Offset = "0xDBB260", VA = "0x180DBC260")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0x110BF30", Offset = "0x110AF30", VA = "0x18110BF30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected ABVKJWGLWKH HQXKVDVUQVS
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xF712B0", Offset = "0xF702B0", VA = "0x180F712B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x1726650", Offset = "0x1725650", VA = "0x181726650")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected GRKTELHQWIB IDTSJUOPMRA
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xF712C0", Offset = "0xF702C0", VA = "0x180F712C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x1725EB0", Offset = "0x1724EB0", VA = "0x181725EB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x4EDEDE0", Offset = "0x4EDDDE0", VA = "0x184EDEDE0")]
			protected YAIAFNMGNKM(COWOBFPVIKZ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x50D00D0", Offset = "0x50CF0D0", VA = "0x1850D00D0", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x50D0070", Offset = "0x50CF070", VA = "0x1850D0070", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x50D0180", Offset = "0x50CF180", VA = "0x1850D0180", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x50D2990", Offset = "0x50D1990", VA = "0x1850D2990")]
			private void PXNFKQAJDCD(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x50D2C70", Offset = "0x50D1C70", VA = "0x1850D2C70", Slot = "145")]
			protected sealed override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x50CF940", Offset = "0x50CE940", VA = "0x1850CF940")]
			private void BKFJSWWTXYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x50D3470", Offset = "0x50D2470", VA = "0x1850D3470")]
			private void ZLXXEQMOWDN(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "151")]
			protected virtual void UTZTWPGCQBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x50D2E90", Offset = "0x50D1E90", VA = "0x1850D2E90")]
			private void UYYMTAATTYW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x50D0580", Offset = "0x50CF580", VA = "0x1850D0580")]
			private void HJIZVGOGFKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x50D1BC0", Offset = "0x50D0BC0", VA = "0x1850D1BC0")]
			private void PJACXPKBVZP(YAVKDLMCPYL.YNQTUTNLEIR a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x50D1070", Offset = "0x50D0070", VA = "0x1850D1070")]
			private void LVUTNWLRIVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x50D33B0", Offset = "0x50D23B0", VA = "0x1850D33B0")]
			protected void ZDHYBYYUQXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x50D01E0", Offset = "0x50CF1E0", VA = "0x1850D01E0")]
			private void GKHNYQKMSRL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x50CF920", Offset = "0x50CE920", VA = "0x1850CF920")]
			private void ASJBNDYCCVT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x50D3040", Offset = "0x50D2040", VA = "0x1850D3040")]
			private void WFKFNJJWJYM(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x50D30A0", Offset = "0x50D20A0", VA = "0x1850D30A0")]
			private string ZBOMRUBBQYW((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x50D33E0", Offset = "0x50D23E0", VA = "0x1850D33E0")]
			private string ZKVGTIMOVBT(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x50D1B40", Offset = "0x50D0B40", VA = "0x1850D1B40")]
			[CompilerGenerated]
			private object? NSHTCAYEPMR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x50D1390", Offset = "0x50D0390", VA = "0x1850D1390")]
			[CompilerGenerated]
			private void NSCMEUEHGBI(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x50D1310", Offset = "0x50D0310", VA = "0x1850D1310")]
			[CompilerGenerated]
			private IReadOnlyList<object> NRRYKGQMNEQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x50D1280", Offset = "0x50D0280", VA = "0x1850D1280")]
			[CompilerGenerated]
			private void NRMRMZWPDTH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x50D1B70", Offset = "0x50D0B70", VA = "0x1850D1B70")]
			[CompilerGenerated]
			private void NTSPIWHMDOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x50D1030", Offset = "0x50D0030", VA = "0x1850D1030")]
			[CompilerGenerated]
			private void KOIBSOBNPPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x50D0250", Offset = "0x50CF250", VA = "0x1850D0250")]
			[CompilerGenerated]
			private void HEBDBAZTMWE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x50D0030", Offset = "0x50CF030", VA = "0x1850D0030")]
			[CompilerGenerated]
			private void BMBVWXQNGGR(YAVKDLMCPYL.YNQTUTNLEIR a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class NXKDQFZJJWT : YAIAFNMGNKM<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x2B42A10", Offset = "0x2B41A10", VA = "0x182B42A10")]
			public NXKDQFZJJWT(COWOBFPVIKZ a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class TMFMGSYJFWX : YAIAFNMGNKM<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type TFUMDEAAQZG
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0x2B44520", Offset = "0x2B43520", VA = "0x182B44520", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope OFXRHMECTKB
				{
					[Cpp2IlInjected.Token(Token = "0x6000408")]
					[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string VTZZDBSQMAL
				{
					[Cpp2IlInjected.Token(Token = "0x6000409")]
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0x1434A60", Offset = "0x1433A60", VA = "0x181434A60")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x2B44430", Offset = "0x2B43430", VA = "0x182B44430", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x2B44360", Offset = "0x2B43360", VA = "0x182B44360", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool NBYOQTAPFDS(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x2B44250", Offset = "0x2B43250", VA = "0x182B44250", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x2B44070", Offset = "0x2B43070", VA = "0x182B44070", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x2B44100", Offset = "0x2B43100", VA = "0x182B44100", Slot = "7")]
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
				protected virtual Type TFUMDEAAQZG
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0x2B45C40", Offset = "0x2B44C40", VA = "0x182B45C40", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers OABWHLUVYRV
				{
					[Cpp2IlInjected.Token(Token = "0x6000411")]
					[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string VTZZDBSQMAL
				{
					[Cpp2IlInjected.Token(Token = "0x6000412")]
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0x1434A60", Offset = "0x1433A60", VA = "0x181434A60")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x2B45B50", Offset = "0x2B44B50", VA = "0x182B45B50", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x2B45A80", Offset = "0x2B44A80", VA = "0x182B45A80", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool NBYOQTAPFDS(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x2B45970", Offset = "0x2B44970", VA = "0x182B45970", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000416")]
				[Cpp2IlInjected.Address(RVA = "0x2B458E0", Offset = "0x2B448E0", VA = "0x182B458E0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x2B45790", Offset = "0x2B44790", VA = "0x182B45790", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class GWEWRBMCNCR
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
					public GWEWRBMCNCR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x2B49B50", Offset = "0x2B48B50", VA = "0x182B49B50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public GWEWRBMCNCR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000427")]
					[Cpp2IlInjected.Address(RVA = "0x2B49F70", Offset = "0x2B48F70", VA = "0x182B49F70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000428")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public TMFMGSYJFWX NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public ABVKJWGLWKH PBMQLQBCPRA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> CVOIKERFQYT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> CVJBMXXIHNK;

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GWEWRBMCNCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B1F0", Offset = "0x2B3A1F0", VA = "0x182B3B1F0")]
				internal object? MDWWQOYDNYA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B3A0", Offset = "0x2B3A3A0", VA = "0x182B3B3A0")]
				internal bool MFMZURBILKU(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B2D0", Offset = "0x2B3A2D0", VA = "0x182B3B2D0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void MECDNVSAXJJ(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AF20", Offset = "0x2B39F20", VA = "0x182B3AF20")]
				internal IReadOnlyList<TargetPlayersSelection> KFUEZRIUSRQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AFD0", Offset = "0x2B39FD0", VA = "0x182B3AFD0")]
				internal object? MDHBYUQLLPZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B400", Offset = "0x2B3A400", VA = "0x182B3B400")]
				internal bool MFSGRXVFUWD(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B120", Offset = "0x2B3A120", VA = "0x182B3B120")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void MDMIWBKIVBI(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> TCHKAKBYZVI;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> PFKIBDQVXLK;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> FMWTDSCVOBO;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000401")]
				[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x2B45640", Offset = "0x2B44640", VA = "0x182B45640")]
			public TMFMGSYJFWX(COWOBFPVIKZ a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x2B44AA0", Offset = "0x2B43AA0", VA = "0x182B44AA0", Slot = "151")]
			protected override void UTZTWPGCQBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x2B45020", Offset = "0x2B44020", VA = "0x182B45020")]
			private static IReadOnlyList<TargetPlayersSelection> ZZSDBMUDIIV(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class NMIDLNMKUUI : BJCKGDSUYRP<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType LLUOFWMONXE
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2B428C0", Offset = "0x2B418C0", VA = "0x182B428C0")]
			public NMIDLNMKUUI(COWOBFPVIKZ a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class ZAWCOHUAOGV : VEKHZDNAXTU<BNPRQWVLIYC>
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x2B40920", Offset = "0x2B3F920", VA = "0x182B40920")]
			public ZAWCOHUAOGV(COWOBFPVIKZ a, BNPRQWVLIYC b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class VEKHZDNAXTU<a> : SNXISRUYHOD, IDisposable where a : notnull, BNPRQWVLIYC
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class PUKJSNNOUVN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public VEKHZDNAXTU<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public COWOBFPVIKZ VMAISQJIZLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a NFWBLMBRPQG;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public PUKJSNNOUVN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0x7541540", Offset = "0x7540540", VA = "0x187541540")]
				internal UOYBKLTOZDU JLGDBKBWBPV(NWXJLXTFVUZ a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class ZZGRLKRXFWJ
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
					public ZZGRLKRXFWJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BD")]
					[Cpp2IlInjected.Address(RVA = "0x41B4140", Offset = "0x41B3140", VA = "0x1841B4140", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BE")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string VGPKINTMJLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, MCRZZCNKUJE>> BIBLSMJGXCQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public VEKHZDNAXTU<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> APYFUGUFPUA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public YAVKDLMCPYL ZXMLSLTRIQW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> UIPDHEYSLIM;

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public ZZGRLKRXFWJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				internal string GEWHTFQWAGJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				internal void GERAVYWYQVA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x514D5F0", Offset = "0x514C5F0", VA = "0x18514D5F0")]
				[AsyncStateMachine(typeof(VEKHZDNAXTU<>.ZZGRLKRXFWJ.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void GELTYSDBHJR()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class WGODBTQTCFK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public WGODBTQTCFK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x8720B10", Offset = "0x871FB10", VA = "0x188720B10")]
				internal Result<string, MCRZZCNKUJE> ZHAQDXRANXB(string a)
				{
					return default(Result<string, MCRZZCNKUJE>);
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
				public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public VEKHZDNAXTU<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x6C14870", Offset = "0x6C13870", VA = "0x186C14870", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x6C14AC0", Offset = "0x6C13AC0", VA = "0x186C14AC0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public VEKHZDNAXTU<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0x6C14B30", Offset = "0x6C13B30", VA = "0x186C14B30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C4")]
				[Cpp2IlInjected.Address(RVA = "0x6C14E30", Offset = "0x6C13E30", VA = "0x186C14E30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly COWOBFPVIKZ YTSLYIPCPMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool LGIBQMQCEIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<HPGFUJBLNSN, UOYBKLTOZDU> XVDUVXHVYGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<HPGFUJBLNSN, XAZCQBDUMDJ> RKIVHNPZQKR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> LUPUPWRVDGU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<HPGFUJBLNSN>>? DINCTXHLWQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<HPGFUJBLNSN>, XAZCQBDUMDJ>? KNNXOEXCGMV;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected FZLXAJZQSFG DNGQBKSNALR
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x801B480", Offset = "0x801A480", VA = "0x18801B480")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected ZGVEFLJMWTI ZGVEFLJMWTI
			{
				[Cpp2IlInjected.Token(Token = "0x600042D")]
				[Cpp2IlInjected.Address(RVA = "0x801CB00", Offset = "0x801BB00", VA = "0x18801CB00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected ZTOKIRXYVVD YMTMJWISNAQ
			{
				[Cpp2IlInjected.Token(Token = "0x600042E")]
				[Cpp2IlInjected.Address(RVA = "0x801BB60", Offset = "0x801AB60", VA = "0x18801BB60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a BNPRQWVLIYC
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<ATOQASVPSNP> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0x1687D40", Offset = "0x1686D40", VA = "0x181687D40", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<ATOQASVPSNP>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<DQODHRVSODS> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0x801D7A0", Offset = "0x801C7A0", VA = "0x18801D7A0", Slot = "6")]
				get
				{
					return default(Id32<DQODHRVSODS>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000436")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x801D610", Offset = "0x801C610", VA = "0x18801D610", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x801D5F0", Offset = "0x801C5F0", VA = "0x18801D5F0", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x801D900", Offset = "0x801C900", VA = "0x18801D900", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool XCHAFNGAKCC
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<SKCKNIYGNEU> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xD6D840", Offset = "0xD6C840", VA = "0x180D6D840", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<SKCKNIYGNEU>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xD6F040", Offset = "0xD6E040", VA = "0x180D6F040")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0xD453D0", Offset = "0xD443D0", VA = "0x180D453D0", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x801D4C0", Offset = "0x801C4C0", VA = "0x18801D4C0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x801D4F0", Offset = "0x801C4F0", VA = "0x18801D4F0", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x801D520", Offset = "0x801C520", VA = "0x18801D520", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x801D780", Offset = "0x801C780", VA = "0x18801D780", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x801D6B0", Offset = "0x801C6B0", VA = "0x18801D6B0", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x801D590", Offset = "0x801C590", VA = "0x18801D590", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x801D560", Offset = "0x801C560", VA = "0x18801D560", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0x10BBCA0", Offset = "0x10BACA0", VA = "0x1810BBCA0", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x180CF70", Offset = "0x180BF70", VA = "0x18180CF70")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x801D550", Offset = "0x801C550", VA = "0x18801D550", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x801D660", Offset = "0x801C660", VA = "0x18801D660", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x801D720", Offset = "0x801C720", VA = "0x18801D720", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x801D750", Offset = "0x801C750", VA = "0x18801D750", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000453")]
				[Cpp2IlInjected.Address(RVA = "0x801D690", Offset = "0x801C690", VA = "0x18801D690", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual RHXDZNHNUEE? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual RQAWMUULEWV? ACSVDAUSNCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<ISSDUATOTVT>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x801D5C0", Offset = "0x801C5C0", VA = "0x18801D5C0", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<YUFXTHDQAZB> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x801D6D0", Offset = "0x801C6D0", VA = "0x18801D6D0", Slot = "68")]
				get
				{
					return default(Id128<YUFXTHDQAZB>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<YUFXTHDQAZB> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x801D630", Offset = "0x801C630", VA = "0x18801D630", Slot = "59")]
				get
				{
					return default(Id32<YUFXTHDQAZB>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<YUFXTHDQAZB>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<YUFXTHDQAZB>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x8019400", Offset = "0x8018400", VA = "0x188019400", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xD01A50", Offset = "0xD00A50", VA = "0x180D01A50", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xD01A40", Offset = "0xD00A40", VA = "0x180D01A40")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0xD01440", Offset = "0xD00440", VA = "0x180D01440", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0xD013E0", Offset = "0xD003E0", VA = "0x180D013E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<ISSDUATOTVT> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x801D7E0", Offset = "0x801C7E0", VA = "0x18801D7E0", Slot = "69")]
				get
				{
					return default(Id32<ISSDUATOTVT>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<ISSDUATOTVT> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x801D700", Offset = "0x801C700", VA = "0x18801D700", Slot = "70")]
				get
				{
					return default(Id128<ISSDUATOTVT>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<ISSDUATOTVT>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0x801D800", Offset = "0x801C800", VA = "0x18801D800", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<HPGFUJBLNSN, XAZCQBDUMDJ> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x801D8C0", Offset = "0x801C8C0", VA = "0x18801D8C0", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<HPGFUJBLNSN, XAZCQBDUMDJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<HPGFUJBLNSN>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action XKCSYYXMRQR
			{
				[Cpp2IlInjected.Token(Token = "0x600045A")]
				[Cpp2IlInjected.Address(RVA = "0x8018FA0", Offset = "0x8017FA0", VA = "0x188018FA0", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x801B260", Offset = "0x801A260", VA = "0x18801B260", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate XGTKAXGZPTO
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x801C3B0", Offset = "0x801B3B0", VA = "0x18801C3B0", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x801ADE0", Offset = "0x8019DE0", VA = "0x18801ADE0", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate FDNBJOKEGJV
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x801C660", Offset = "0x801B660", VA = "0x18801C660", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x8019760", Offset = "0x8018760", VA = "0x188019760", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action GIVVCQPSJIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x801C450", Offset = "0x801B450", VA = "0x18801C450", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x801BC40", Offset = "0x801AC40", VA = "0x18801BC40", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action VNAEOHMBTMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0x801A6F0", Offset = "0x80196F0", VA = "0x18801A6F0", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000464")]
				[Cpp2IlInjected.Address(RVA = "0x801AB00", Offset = "0x8019B00", VA = "0x18801AB00", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<HPGFUJBLNSN>, XAZCQBDUMDJ> JASIGWRKHNV
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x801BA30", Offset = "0x801AA30", VA = "0x18801BA30", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x801C9F0", Offset = "0x801B9F0", VA = "0x18801C9F0", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<HPGFUJBLNSN>, XAZCQBDUMDJ> QZNYTCLFGQS
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x8019280", Offset = "0x8018280", VA = "0x188019280", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x8019820", Offset = "0x8018820", VA = "0x188019820", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<HPGFUJBLNSN>> AHWBQCOYDTO
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x801ACB0", Offset = "0x8019CB0", VA = "0x18801ACB0", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x801BF20", Offset = "0x801AF20", VA = "0x18801BF20", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<HPGFUJBLNSN>, Id32<HPGFUJBLNSN>> YPIZEUVAGTF
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x801CBF0", Offset = "0x801BBF0", VA = "0x18801CBF0", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x801A100", Offset = "0x8019100", VA = "0x18801A100", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<HPGFUJBLNSN>, XAZCQBDUMDJ> YXBCECZDUHF
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x80191C0", Offset = "0x80181C0", VA = "0x1880191C0", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x8019340", Offset = "0x8018340", VA = "0x188019340", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<HPGFUJBLNSN>, Id32<HPGFUJBLNSN>> GYUCPSAADVQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x8019040", Offset = "0x8018040", VA = "0x188019040", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x801C5A0", Offset = "0x801B5A0", VA = "0x18801C5A0", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> BGZGCDYEIFR
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x801ABA0", Offset = "0x8019BA0", VA = "0x18801ABA0", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x8019ED0", Offset = "0x8018ED0", VA = "0x188019ED0", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x801D050", Offset = "0x801C050", VA = "0x18801D050")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected VEKHZDNAXTU(COWOBFPVIKZ a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x801A790", Offset = "0x8019790", VA = "0x18801A790", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x80198E0", Offset = "0x80188E0", VA = "0x1880198E0", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x801AD70", Offset = "0x8019D70", VA = "0x18801AD70", Slot = "9")]
			public Task<Result<None, MCRZZCNKUJE>> MGXUHDSEMYW(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x801AAD0", Offset = "0x8019AD0", VA = "0x18801AAD0")]
			public bool RPNQPQQUCQK([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x801AAA0", Offset = "0x8019AA0", VA = "0x18801AAA0")]
			public bool OECEHXQYERN([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x801C500", Offset = "0x801B500", VA = "0x18801C500", Slot = "34")]
			public void WCKAQYLNYAH(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x801C270", Offset = "0x801B270", VA = "0x18801C270", Slot = "35")]
			public Task USXYJAUDHUP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x8019C20", Offset = "0x8018C20", VA = "0x188019C20", Slot = "36")]
			[AsyncStateMachine(typeof(VEKHZDNAXTU<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, MCRZZCNKUJE>> EHEPJNCOMGS(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "119")]
			public virtual void YWKGNMOGZCV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x1097CD0", Offset = "0x1096CD0", VA = "0x181097CD0")]
			protected void LUEVHGUDGSL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x2154100", Offset = "0x2153100", VA = "0x182154100")]
			protected void ZMMPELBFEZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x2130580", Offset = "0x212F580", VA = "0x182130580")]
			private void MMQLXXGJWDY([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x801B3C0", Offset = "0x801A3C0", VA = "0x18801B3C0", Slot = "122")]
			public virtual Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> ONIENZMFOPL(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x8019100", Offset = "0x8018100", VA = "0x188019100", Slot = "123")]
			public virtual Task<Result<None, MCRZZCNKUJE>> AZHEBKRWDQA(Id32<HPGFUJBLNSN> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "124")]
			public virtual void FAIQHALJAZS(Id32<HPGFUJBLNSN> sourceId, Id32<HPGFUJBLNSN> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x801A5E0", Offset = "0x80195E0", VA = "0x18801A5E0", Slot = "125")]
			public virtual IEnumerable<PYPEGOPZPPS> ICYNAQDOWCP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x801C370", Offset = "0x801B370", VA = "0x18801C370", Slot = "126")]
			public Result<None, MCRZZCNKUJE> VBFBTUDKDTQ(string a)
			{
				return default(Result<None, MCRZZCNKUJE>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x801C8D0", Offset = "0x801B8D0", VA = "0x18801C8D0", Slot = "50")]
			public bool YLVEPQPDCRM([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x801BCA0", Offset = "0x801ACA0", VA = "0x18801BCA0")]
			public bool SEDYZQYZJMT([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "128")]
			public virtual void PVXKIQUNBZD(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "129")]
			public virtual ZBBZHLLRECI JYBGAZEIZEN([In] ZHHYWPNIHVR audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x8019D70", Offset = "0x8018D70", VA = "0x188019D70")]
			protected void EPIJJANRVKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x8019400", Offset = "0x8018400", VA = "0x188019400", Slot = "134")]
			protected virtual bool BKHDIZADVTQ(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x801AC80", Offset = "0x8019C80", VA = "0x18801AC80", Slot = "96")]
			public bool LTGNNCRIKJC(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "135")]
			protected virtual bool RDNJLYLREQN(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected virtual void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x801CCB0", Offset = "0x801BCB0", VA = "0x18801CCB0")]
			protected void ZVTARQKISDH(YAVKDLMCPYL a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, MCRZZCNKUJE>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x801BFE0", Offset = "0x801AFE0", VA = "0x18801BFE0")]
			protected void UGVRIHRKKST(YAVKDLMCPYL a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x8019440", Offset = "0x8018440", VA = "0x188019440", Slot = "146")]
			protected virtual void CIOECYKLDGC(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x801CAB0", Offset = "0x801BAB0", VA = "0x18801CAB0", Slot = "90")]
			public void YPZZVWFEZJZ(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x801A680", Offset = "0x8019680", VA = "0x18801A680", Slot = "91")]
			public CircuitsRigidTransform IELIOEDFUOO()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "149")]
			public virtual bool OORBJXIZJQY(Id32<HPGFUJBLNSN> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x801B240", Offset = "0x801A240", VA = "0x18801B240")]
			private void NQFTKFUANTD([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x801B300", Offset = "0x801A300", VA = "0x18801B300")]
			private void NXCQDZTJLKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x1097CD0", Offset = "0x1096CD0", VA = "0x181097CD0", Slot = "97")]
			private void SGZNRJMUKXV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x801B4E0", Offset = "0x801A4E0", VA = "0x18801B4E0", Slot = "99")]
			private void POWJOPNPKCG(Id32<HPGFUJBLNSN> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x4F35FE0", Offset = "0x4F34FE0", VA = "0x184F35FE0", Slot = "101")]
			private void VAAXGLNQDIH(Id32<HPGFUJBLNSN> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x801A960", Offset = "0x8019960", VA = "0x18801A960", Slot = "103")]
			private void JGTFFZNJJLL(Id32<HPGFUJBLNSN> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x801AE80", Offset = "0x8019E80", VA = "0x18801AE80", Slot = "104")]
			private void MZNLNVCZJFD(Id32<HPGFUJBLNSN> sourceId, Id32<HPGFUJBLNSN> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x801AC60", Offset = "0x8019C60", VA = "0x18801AC60", Slot = "105")]
			private void LCDRWEARKVM(Id32<HPGFUJBLNSN> sourceId, Id32<HPGFUJBLNSN> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x1742780", Offset = "0x1741780", VA = "0x181742780", Slot = "98")]
			private void MDBDHWZWIGN(Id32<HPGFUJBLNSN> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x801A1C0", Offset = "0x80191C0", VA = "0x18801A1C0", Slot = "100")]
			private void HXSHUSIWUOK(Id32<HPGFUJBLNSN> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x801BAF0", Offset = "0x801AAF0", VA = "0x18801BAF0", Slot = "102")]
			private void RBRAXGGOWVS(Id32<HPGFUJBLNSN> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x8019800", Offset = "0x8018800", VA = "0x188019800", Slot = "106")]
			private void CYQUSBAHZBA(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x801C700", Offset = "0x801B700", VA = "0x18801C700", Slot = "150")]
			[AsyncStateMachine(typeof(VEKHZDNAXTU<>.<RequestNameChange>d__224))]
			public Task<Result<None, MCRZZCNKUJE>> XNHZDZTWHSQ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x801C1E0", Offset = "0x801B1E0", VA = "0x18801C1E0", Slot = "57")]
			private void URPZIWWWRXA(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x801C820", Offset = "0x801B820", VA = "0x18801C820", Slot = "58")]
			private void XWFSIPKJDUB(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x801AAD0", Offset = "0x8019AD0", VA = "0x18801AAD0", Slot = "30")]
			private bool KJZZHZVTSPB([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x801AAA0", Offset = "0x8019AA0", VA = "0x18801AAA0", Slot = "32")]
			private bool JOILTUVCJJU([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x801C8B0", Offset = "0x801B8B0", VA = "0x18801C8B0", Slot = "51")]
			private bool YBWJFNFQSQO([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xD01A50", Offset = "0xD00A50", VA = "0x180D01A50")]
			[CompilerGenerated]
			private string FGJQXJQWUJC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x8019F90", Offset = "0x8018F90", VA = "0x188019F90")]
			[CompilerGenerated]
			private void FGOXUQKUDUL(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class JUYGRDDETZB : WXDTCCTCLXO<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0xF22F30", Offset = "0xF21F30", VA = "0x180F22F30", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x2B408C0", Offset = "0x2B3F8C0", VA = "0x182B408C0")]
			public JUYGRDDETZB(COWOBFPVIKZ a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class ULPPXHIMTBJ : VEKHZDNAXTU<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class GWEWRBMCNCR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> CPERBQYNJWQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public ULPPXHIMTBJ NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> JGBZKBQCBEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> FAVSNXPIDJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GWEWRBMCNCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> FYWQLBYJBCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A400", Offset = "0x2B39400", VA = "0x182B3A400")]
				internal int FZBXIISGKNV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B397F0", VA = "0x182B3A7F0")]
				internal void FZHEFPMDTZE(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B4CDB0", Offset = "0x2B4BDB0", VA = "0x182B4CDB0")]
			public ULPPXHIMTBJ(COWOBFPVIKZ a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B4CAD0", Offset = "0x2B4BAD0", VA = "0x182B4CAD0", Slot = "145")]
			protected sealed override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class DORJFCNFYQB : GBWBBWFEMCJ<KKXUVYMCRCC>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B38280", Offset = "0x2B37280", VA = "0x182B38280")]
			public DORJFCNFYQB(COWOBFPVIKZ a, KKXUVYMCRCC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class OSNCOKRPWHJ : VEKHZDNAXTU<OWLHYSEZKII>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public OSNCOKRPWHJ NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C1E0", Offset = "0x2B3B1E0", VA = "0x182B3C1E0")]
				internal bool FYWQLBYJBCM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C2C0", Offset = "0x2B3B2C0", VA = "0x182B3C2C0")]
				internal void FZBXIISGKNV(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B42FE0", Offset = "0x2B41FE0", VA = "0x182B42FE0")]
			public OSNCOKRPWHJ(COWOBFPVIKZ a, OWLHYSEZKII b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B42E10", Offset = "0x2B41E10", VA = "0x182B42E10", Slot = "145")]
			protected sealed override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class HNOODFQPWCA : VEKHZDNAXTU<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class GWEWRBMCNCR
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
					public GWEWRBMCNCR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F5")]
					[Cpp2IlInjected.Address(RVA = "0x2B4AEC0", Offset = "0x2B49EC0", VA = "0x182B4AEC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F6")]
					[Cpp2IlInjected.Address(RVA = "0x2B4B0F0", Offset = "0x2B4A0F0", VA = "0x182B4B0F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XYVMXGXRWPQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public HNOODFQPWCA NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> BXNUKVIPJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> MZSMLYTCSKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GWEWRBMCNCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> FYWQLBYJBCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A600", Offset = "0x2B39600", VA = "0x182B3A600")]
				internal int FZBXIISGKNV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AB00", Offset = "0x2B39B00", VA = "0x182B3AB00")]
				internal void FZHEFPMDTZE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AC40", Offset = "0x2B39C40", VA = "0x182B3AC40")]
				internal int FZMLCWGBDKN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B39F80", Offset = "0x2B38F80", VA = "0x182B39F80")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> FYBOWAWTPJC(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B460", Offset = "0x2B3A460", VA = "0x182B3B460")]
				internal int TCBZKGNAJTQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B9A0", Offset = "0x2B3A9A0", VA = "0x182B3B9A0")]
				internal void ZYCBTZFLQLA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BA30", Offset = "0x2B3AA30", VA = "0x182B3BA30")]
				internal int ZYHIRFZIZWJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B8C0", Offset = "0x2B3A8C0", VA = "0x182B3B8C0")]
				internal void ZXRNZLRQXOI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B950", Offset = "0x2B3A950", VA = "0x182B3B950")]
				internal int ZXWUWSLOGZR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BB10", Offset = "0x2B3AB10", VA = "0x182B3BB10")]
				internal void ZYXDJAHBCEK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BBA0", Offset = "0x2B3ABA0", VA = "0x182B3BBA0")]
				internal int ZZCKGHAYLPT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BA80", Offset = "0x2B3AA80", VA = "0x182B3BA80")]
				internal void ZYMPOMTGJHS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A080", Offset = "0x2B39080", VA = "0x182B3A080")]
				internal float FYGVTHQQYUL()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A0D0", Offset = "0x2B390D0", VA = "0x182B3A0D0")]
				internal void FYMCQOKOIFU(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A160", Offset = "0x2B39160", VA = "0x182B3A160")]
				internal float FYRJNVELRRD()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AE40", Offset = "0x2B39E40", VA = "0x182B3AE40")]
				internal void GAMTPEBNYPG(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AED0", Offset = "0x2B39ED0", VA = "0x182B3AED0")]
				internal bool GASAMKVLIAP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B830", Offset = "0x2B3A830", VA = "0x182B3B830")]
				internal void TDXJLPKCQRT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B7E0", Offset = "0x2B3A7E0", VA = "0x182B3B7E0")]
				internal int TDSCOIQFHGK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B750", Offset = "0x2B3A750", VA = "0x182B3B750")]
				internal void TDMVRBWHXVB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B700", Offset = "0x2B3A700", VA = "0x182B3B700")]
				internal float TDHOTVCKOJS()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B670", Offset = "0x2B3A670", VA = "0x182B3B670")]
				internal void TDCHWOINEYJ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B620", Offset = "0x2B3A620", VA = "0x182B3B620")]
				internal float TCXAZHOPVNA()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B590", Offset = "0x2B3A590", VA = "0x182B3B590")]
				internal void TCRUCAUSMBR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B540", Offset = "0x2B3A540", VA = "0x182B3B540")]
				internal bool TCMNEUAVCQI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B4B0", Offset = "0x2B3A4B0", VA = "0x182B3B4B0")]
				internal void TCHGHNGXTEZ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B3FC80", Offset = "0x2B3EC80", VA = "0x182B3FC80")]
			public HNOODFQPWCA(COWOBFPVIKZ a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EB80", Offset = "0x2B3DB80", VA = "0x182B3EB80", Slot = "145")]
			protected sealed override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class TBZEVSUKOFZ : SUTGBCUJVSK<RecNetImageNode>
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
				public TBZEVSUKOFZ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A6F0", Offset = "0x2B496F0", VA = "0x182B4A6F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B44A40", Offset = "0x2B43A40", VA = "0x182B44A40")]
			public TBZEVSUKOFZ(COWOBFPVIKZ a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B44710", Offset = "0x2B43710", VA = "0x182B44710", Slot = "151")]
			protected override void DZVYKMORJUZ(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B44640", Offset = "0x2B43640", VA = "0x182B44640")]
			[CompilerGenerated]
			private string? AXPAQTCFBVX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B44570", Offset = "0x2B43570", VA = "0x182B44570")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void AXJTTMIHSKO(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class BJCKGDSUYRP<a> : VEKHZDNAXTU<a> where a : notnull, IYPTQHIAKWL
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class QBUTDWRBSPN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XYVMXGXRWPQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public BJCKGDSUYRP<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> BXNUKVIPJUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> MZSMLYTCSKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType ZRXIURZPRQE;

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public QBUTDWRBSPN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> FYWQLBYJBCM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x77386B0", Offset = "0x77376B0", VA = "0x1877386B0")]
				internal int FZBXIISGKNV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x77387D0", Offset = "0x77377D0", VA = "0x1877387D0")]
				internal void FZHEFPMDTZE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x77389C0", Offset = "0x77379C0", VA = "0x1877389C0")]
				internal void FZMLCWGBDKN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x77384F0", Offset = "0x77374F0", VA = "0x1877384F0")]
				internal void FYBOWAWTPJC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x7738600", Offset = "0x7737600", VA = "0x187738600")]
				internal bool FYGVTHQQYUL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x7738660", Offset = "0x7737660", VA = "0x187738660")]
				internal void FYMCQOKOIFU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x7738600", Offset = "0x7737600", VA = "0x187738600")]
				internal bool FYRJNVELRRD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x7738A10", Offset = "0x7737A10", VA = "0x187738A10")]
				internal float GAMTPEBNYPG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x7738A40", Offset = "0x7737A40", VA = "0x187738A40")]
				internal void GASAMKVLIAP(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x7739720", Offset = "0x7738720", VA = "0x187739720")]
				internal float TDXJLPKCQRT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x7739690", Offset = "0x7738690", VA = "0x187739690")]
				internal void TDSCOIQFHGK(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x7739660", Offset = "0x7738660", VA = "0x187739660")]
				internal float TDMVRBWHXVB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x77395D0", Offset = "0x77385D0", VA = "0x1877395D0")]
				internal void TDHOTVCKOJS(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType LLUOFWMONXE
			{
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x4EDEDE0", Offset = "0x4EDDDE0", VA = "0x184EDEDE0")]
			public BJCKGDSUYRP(COWOBFPVIKZ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x4EDE3A0", Offset = "0x4EDD3A0", VA = "0x184EDE3A0", Slot = "145")]
			protected sealed override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class EJXVIFRVSAD : VEKHZDNAXTU<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0xF31AE0", Offset = "0xF30AE0", VA = "0x180F31AE0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2B38340", Offset = "0x2B37340", VA = "0x182B38340")]
			public EJXVIFRVSAD(COWOBFPVIKZ a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class IYVVPJVRMYY : DBUOBHEWEGA<BOUJTFQWGFQ>
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x2B40610", Offset = "0x2B3F610", VA = "0x182B40610")]
			public IYVVPJVRMYY(COWOBFPVIKZ a, BOUJTFQWGFQ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class GEQLQMVUVCE : DBUOBHEWEGA<FUVAPULOULF>
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x2B39590", Offset = "0x2B38590", VA = "0x182B39590")]
			public GEQLQMVUVCE(COWOBFPVIKZ a, FUVAPULOULF b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class DBUOBHEWEGA<a> : VEKHZDNAXTU<a> where a : notnull, CSAWYOINSJG
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
				public DBUOBHEWEGA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0x41B3F40", Offset = "0x41B2F40", VA = "0x1841B3F40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051D")]
				[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class WJESLANGGFS
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
					public WJESLANGGFS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x41B2C10", Offset = "0x41B1C10", VA = "0x1841B2C10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public WJESLANGGFS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x41B2FF0", Offset = "0x41B1FF0", VA = "0x1841B2FF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public WJESLANGGFS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x41B3870", Offset = "0x41B2870", VA = "0x1841B3870", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public WJESLANGGFS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000533")]
					[Cpp2IlInjected.Address(RVA = "0x41B3C50", Offset = "0x41B2C50", VA = "0x1841B3C50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000534")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int JEHIAJMVLLA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry EGTSFQKCMLY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public DBUOBHEWEGA<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<EUKWVPLYZVT, bool> ICFIIPRMCUZ;

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public WJESLANGGFS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0x87255D0", Offset = "0x87245D0", VA = "0x1887255D0")]
				internal bool FZMLCWGBDKN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x8725390", Offset = "0x8724390", VA = "0x188725390")]
				internal void FYBOWAWTPJC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
				internal string FYGVTHQQYUL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x8725400", Offset = "0x8724400", VA = "0x188725400")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.WJESLANGGFS.<<BuildConfigMenuInternal>b__6>d))]
				internal void FYMCQOKOIFU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x87254C0", Offset = "0x87244C0", VA = "0x1887254C0")]
				internal int FYRJNVELRRD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0x8725790", Offset = "0x8724790", VA = "0x188725790")]
				internal bool TDHOTVCKOJS(EUKWVPLYZVT a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x8725630", Offset = "0x8724630", VA = "0x188725630")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.WJESLANGGFS.<<BuildConfigMenuInternal>b__8>d))]
				internal void GAMTPEBNYPG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
				internal string TDXJLPKCQRT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0x8725850", Offset = "0x8724850", VA = "0x188725850")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.WJESLANGGFS.<<BuildConfigMenuInternal>b__11>d))]
				internal void TDSCOIQFHGK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x87257B0", Offset = "0x87247B0", VA = "0x1887257B0")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.WJESLANGGFS.<<BuildConfigMenuInternal>b__12>d))]
				internal void TDMVRBWHXVB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class QWHKHWJLEJV
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x41ACF30", Offset = "0x41ABF30", VA = "0x1841ACF30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x41AD2C0", Offset = "0x41AC2C0", VA = "0x1841AD2C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x41AD690", Offset = "0x41AC690", VA = "0x1841AD690", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x41ADC70", Offset = "0x41ACC70", VA = "0x1841ADC70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x41ADF00", Offset = "0x41ACF00", VA = "0x1841ADF00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x41AE290", Offset = "0x41AD290", VA = "0x1841AE290", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x41AE620", Offset = "0x41AD620", VA = "0x1841AE620", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x41AE8B0", Offset = "0x41AD8B0", VA = "0x1841AE8B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x41AEC40", Offset = "0x41ADC40", VA = "0x1841AEC40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x41AEFD0", Offset = "0x41ADFD0", VA = "0x1841AEFD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x41AF360", Offset = "0x41AE360", VA = "0x1841AF360", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x41AF5F0", Offset = "0x41AE5F0", VA = "0x1841AF5F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x41AF980", Offset = "0x41AE980", VA = "0x1841AF980", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x41AFC10", Offset = "0x41AEC10", VA = "0x1841AFC10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x41AFFA0", Offset = "0x41AEFA0", VA = "0x1841AFFA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x41B0330", Offset = "0x41AF330", VA = "0x1841B0330", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
					public QWHKHWJLEJV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000585")]
					[Cpp2IlInjected.Address(RVA = "0x41B06C0", Offset = "0x41AF6C0", VA = "0x1841B06C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000586")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public DBUOBHEWEGA<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int JEHIAJMVLLA;

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public QWHKHWJLEJV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x77F0C50", Offset = "0x77EFC50", VA = "0x1877F0C50")]
				internal bool PNRNVGDZEVE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x77F0CB0", Offset = "0x77EFCB0", VA = "0x1877F0CB0")]
				internal void PNWUSMXWOGN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x77EE250", Offset = "0x77ED250", VA = "0x1877EE250")]
				internal object GODGVHAJFEF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x77EE190", Offset = "0x77ED190", VA = "0x1877EE190")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__13>d))]
				internal void GNXZYAGLVSW(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x77EE3B0", Offset = "0x77ED3B0", VA = "0x1877EE3B0")]
				internal string GONUPUODYAX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x77EE2F0", Offset = "0x77ED2F0", VA = "0x1877EE2F0")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__15>d))]
				internal void GOINSNUGOPO(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x77EE4E0", Offset = "0x77ED4E0", VA = "0x1877EE4E0")]
				internal bool GOYIKIBYQXP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x77EE450", Offset = "0x77ED450", VA = "0x1877EE450")]
				internal bool GOTBNBIBHMG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x77EE610", Offset = "0x77ED610", VA = "0x1877EE610")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__18>d))]
				internal void GPIWEVPTJUH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x77EE560", Offset = "0x77ED560", VA = "0x1877EE560")]
				internal int GPDPHOVWAIY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x77F0460", Offset = "0x77EF460", VA = "0x1877F0460")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__20>d))]
				internal void LSFQUZBAHDO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x77F0510", Offset = "0x77EF510", VA = "0x1877F0510")]
				internal bool LSKXSFUXQOX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x77F05A0", Offset = "0x77EF5A0", VA = "0x1877F05A0")]
				internal float LSQEPMOVAAG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x77F0650", Offset = "0x77EF650", VA = "0x1877F0650")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__23>d))]
				internal void LSVLMTISJLP(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x77F0710", Offset = "0x77EF710", VA = "0x1877F0710")]
				internal bool LTASKACPSWY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x77F07A0", Offset = "0x77EF7A0", VA = "0x1877F07A0")]
				internal bool LTFZHGWNCIH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x77F0830", Offset = "0x77EF830", VA = "0x1877F0830")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__26>d))]
				internal void LTLGENQKLTQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x77F08E0", Offset = "0x77EF8E0", VA = "0x1877F08E0")]
				internal int LTQNBUKHVEZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x77F0320", Offset = "0x77EF320", VA = "0x1877F0320")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__28>d))]
				internal void LQPNQWXVJQU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x77F03D0", Offset = "0x77EF3D0", VA = "0x1877F03D0")]
				internal bool LQUUODRSTCD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x77F1290", Offset = "0x77F0290", VA = "0x1877F1290")]
				internal float SSWVTRJCWVX()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x77F11D0", Offset = "0x77F01D0", VA = "0x1877F11D0")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__31>d))]
				internal void SSROWKPFNKO(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x77F1140", Offset = "0x77F0140", VA = "0x1877F1140")]
				internal bool SSMHZDVIDZF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x77F10C0", Offset = "0x77F00C0", VA = "0x1877F10C0")]
				internal bool SSHBBXBKUNW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x77F14F0", Offset = "0x77F04F0", VA = "0x1877F14F0")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__34>d))]
				internal void STRXISKSIPH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x77F1460", Offset = "0x77F0460", VA = "0x1877F1460")]
				internal bool STMQLLQUZDY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x77F13D0", Offset = "0x77F03D0", VA = "0x1877F13D0")]
				internal bool STHJOEWXPSP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x77F1320", Offset = "0x77F0320", VA = "0x1877F1320")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__37>d))]
				internal void STCCQYDAGHG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x77F1030", Offset = "0x77F0030", VA = "0x1877F1030")]
				internal int SRGSPPFXZJD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x77F0F80", Offset = "0x77EFF80", VA = "0x1877F0F80")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__39>d))]
				internal void SRBLSIMAPXU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x77EDD70", Offset = "0x77ECD70", VA = "0x1877EDD70")]
				internal bool APUJJOLVVOG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x77EDE00", Offset = "0x77ECE00", VA = "0x1877EDE00")]
				internal float APZQGVFTEZP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x77EDC20", Offset = "0x77ECC20", VA = "0x1877EDC20")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__42>d))]
				internal void APJVPAYBCRO(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x77EDCE0", Offset = "0x77ECCE0", VA = "0x1877EDCE0")]
				internal bool APPCMHRYMCX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x77EDF20", Offset = "0x77ECF20", VA = "0x1877EDF20")]
				internal bool AQPKYPNLHHQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x77EDFA0", Offset = "0x77ECFA0", VA = "0x1877EDFA0")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__45>d))]
				internal void AQURVWHIQSZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x77EDE90", Offset = "0x77ECE90", VA = "0x1877EDE90")]
				internal bool AQEXEBZQOKY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x77F0B10", Offset = "0x77EFB10", VA = "0x1877F0B10")]
				internal bool PNHAASQELYM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x77F0BA0", Offset = "0x77EFBA0", VA = "0x1877F0BA0")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__3>d))]
				internal void PNMGXZKBVJV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x77F0E40", Offset = "0x77EFE40", VA = "0x1877F0E40")]
				internal int POMPKHFOQOO()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x77F0ED0", Offset = "0x77EFED0", VA = "0x1877F0ED0")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__5>d))]
				internal void PORWHNZLZZX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x77F0D20", Offset = "0x77EFD20", VA = "0x1877F0D20")]
				internal bool POCBPTRTXRW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x77F0DB0", Offset = "0x77EFDB0", VA = "0x1877F0DB0")]
				internal bool POHINALRHDF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x77F09C0", Offset = "0x77EF9C0", VA = "0x1877F09C0")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__8>d))]
				internal void PMBKREAUHIK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x77F0A70", Offset = "0x77EFA70", VA = "0x1877F0A70")]
				internal int PMGROKURQTT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x77EE0E0", Offset = "0x77ED0E0", VA = "0x1877EE0E0")]
				[AsyncStateMachine(typeof(DBUOBHEWEGA<>.QWHKHWJLEJV.<<AddConstraintOptions>b__10>d))]
				internal void GNSTATMOMHN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x77EE050", Offset = "0x77ED050", VA = "0x1877EE050")]
				internal bool GNNMDMSRCWE()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> ZWBTXVYLDEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> VXAGIMGIOKX;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000516")]
				[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<EUKWVPLYZVT> BNWXGJUYQJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000517")]
				[Cpp2IlInjected.Address(RVA = "0x53B05B0", Offset = "0x53AF5B0", VA = "0x1853B05B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x53B2E80", Offset = "0x53B1E80", VA = "0x1853B2E80")]
			public DBUOBHEWEGA(COWOBFPVIKZ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x53B0600", Offset = "0x53AF600", VA = "0x1853B0600", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x53B06B0", Offset = "0x53AF6B0", VA = "0x1853B06B0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x53B1720", Offset = "0x53B0720", VA = "0x1853B1720")]
			private GRKTELHQWIB TPFUQEXHXLK(YAVKDLMCPYL a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x53B04A0", Offset = "0x53AF4A0", VA = "0x1853B04A0")]
			[AsyncStateMachine(typeof(DBUOBHEWEGA<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void BQWFPIJZXYM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x53B0550", Offset = "0x53AF550", VA = "0x1853B0550")]
			[CompilerGenerated]
			private bool BRMAHCRSAGN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class XHWDNNHEEHO : VEKHZDNAXTU<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class LPQSXGDQTBI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public XHWDNNHEEHO NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public LPQSXGDQTBI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x2B413F0", Offset = "0x2B403F0", VA = "0x182B413F0")]
				internal int FZBXIISGKNV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x2B415F0", Offset = "0x2B405F0", VA = "0x182B415F0")]
				internal void FZHEFPMDTZE(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? DNQQFYDMFTD;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x2B52710", Offset = "0x2B51710", VA = "0x182B52710")]
			public XHWDNNHEEHO(COWOBFPVIKZ a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x2B523B0", Offset = "0x2B513B0", VA = "0x182B523B0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class JBZMSMLEWGY : BJCKGDSUYRP<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType LLUOFWMONXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000590")]
				[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x2B40670", Offset = "0x2B3F670", VA = "0x182B40670")]
			public JBZMSMLEWGY(COWOBFPVIKZ a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class DJCEJKRQZAP : GBWBBWFEMCJ<KQLCCZCISOI>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000591")]
				[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x2B38220", Offset = "0x2B37220", VA = "0x182B38220")]
			public DJCEJKRQZAP(COWOBFPVIKZ a, KQLCCZCISOI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class LTMDNYNLCHU : GBWBBWFEMCJ<NZTBYSGCCWP>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000594")]
				[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2B42220", Offset = "0x2B41220", VA = "0x182B42220")]
			public LTMDNYNLCHU(COWOBFPVIKZ a, NZTBYSGCCWP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class BAFBXFJVPOG : SUTGBCUJVSK<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
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
					public GZTFKPJKAMH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600059B")]
					[Cpp2IlInjected.Address(RVA = "0x2B4A3E0", Offset = "0x2B493E0", VA = "0x182B4A3E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059C")]
					[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public BAFBXFJVPOG NJJCUEUTHZM;

				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D110", Offset = "0x2B3C110", VA = "0x182B3D110")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void HYJRWBINHOV(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x2B37400", Offset = "0x2B36400", VA = "0x182B37400")]
			public BAFBXFJVPOG(COWOBFPVIKZ a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x2B37100", Offset = "0x2B36100", VA = "0x182B37100", Slot = "151")]
			protected override void DZVYKMORJUZ(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class XHHNPYQBYYZ : BJCKGDSUYRP<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType LLUOFWMONXE
			{
				[Cpp2IlInjected.Token(Token = "0x600059E")]
				[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x2B52350", Offset = "0x2B51350", VA = "0x182B52350")]
			public XHHNPYQBYYZ(COWOBFPVIKZ a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class CDSOCLDGMMM : VEKHZDNAXTU<YBOHZYQYQQQ>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0xF158D0", Offset = "0xF148D0", VA = "0x180F158D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x2B381B0", Offset = "0x2B371B0", VA = "0x182B381B0")]
			public CDSOCLDGMMM(COWOBFPVIKZ a, YBOHZYQYQQQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class LFXPQHHHDOH : VEKHZDNAXTU<ESJKDOEKDSQ>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A3")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool XCHAFNGAKCC
			{
				[Cpp2IlInjected.Token(Token = "0x60005A4")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B40F90", Offset = "0x2B3FF90", VA = "0x182B40F90")]
			public LFXPQHHHDOH(COWOBFPVIKZ a, ESJKDOEKDSQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B40BD0", Offset = "0x2B3FBD0", VA = "0x182B40BD0", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2B40EE0", Offset = "0x2B3FEE0", VA = "0x182B40EE0")]
			private int TJEBASNMLXB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B40F20", Offset = "0x2B3FF20", VA = "0x182B40F20")]
			private void ZLOQOJJWUBN(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class KFSARWTLPBE : ZAWCOHUAOGV
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B40920", Offset = "0x2B3F920", VA = "0x182B40920")]
			public KFSARWTLPBE(COWOBFPVIKZ a, BNPRQWVLIYC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class GJIFJLKKMEI : VEKHZDNAXTU<TMRPTKPKPTH>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class GWEWRBMCNCR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public GJIFJLKKMEI NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GWEWRBMCNCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A200", Offset = "0x2B39200", VA = "0x182B3A200")]
				internal int FYWQLBYJBCM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B3A560", Offset = "0x2B39560", VA = "0x182B3A560")]
				internal void FZBXIISGKNV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AA60", Offset = "0x2B39A60", VA = "0x182B3AA60")]
				internal int FZHEFPMDTZE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AC90", Offset = "0x2B39C90", VA = "0x182B3AC90")]
				internal void FZMLCWGBDKN(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2CD40", VA = "0x180D2DD40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2B39970", Offset = "0x2B38970", VA = "0x182B39970")]
			public GJIFJLKKMEI(COWOBFPVIKZ a, TMRPTKPKPTH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B39660", Offset = "0x2B38660", VA = "0x182B39660", Slot = "145")]
			protected sealed override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class NRFDFZYQRQR : SUTGBCUJVSK<CLEIZZWIMNU>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x2B429B0", Offset = "0x2B419B0", VA = "0x182B429B0")]
			public NRFDFZYQRQR(COWOBFPVIKZ a, CLEIZZWIMNU b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class SUTGBCUJVSK<a> : VEKHZDNAXTU<a> where a : notnull, CLEIZZWIMNU
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class BZJWDVGUZLQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public SUTGBCUJVSK<a> NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public BZJWDVGUZLQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x4F226D0", Offset = "0x4F216D0", VA = "0x184F226D0")]
				internal bool FYWQLBYJBCM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x4F22700", Offset = "0x4F21700", VA = "0x184F22700")]
				internal void FZBXIISGKNV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x4F22790", Offset = "0x4F21790", VA = "0x184F22790")]
				internal bool FZHEFPMDTZE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0x4F227C0", Offset = "0x4F217C0", VA = "0x184F227C0")]
				internal void FZMLCWGBDKN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x4F22660", Offset = "0x4F21660", VA = "0x184F22660")]
				internal bool FYBOWAWTPJC()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class PEUYNJHNJIR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public ZTOKIRXYVVD RHPNTWVDPLR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public SUTGBCUJVSK<a> NJJCUEUTHZM;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public PEUYNJHNJIR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x7535200", Offset = "0x7534200", VA = "0x187535200")]
				internal void HYJRWBINHOV(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0xD608B0", Offset = "0xD5F8B0", VA = "0x180D608B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x7ACA990", Offset = "0x7AC9990", VA = "0x187ACA990", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x7ACA880", Offset = "0x7AC9880", VA = "0x187ACA880")]
			protected SUTGBCUJVSK(COWOBFPVIKZ a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x7ACA3C0", Offset = "0x7AC93C0", VA = "0x187ACA3C0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x7ACA500", Offset = "0x7AC9500", VA = "0x187ACA500", Slot = "145")]
			protected override void THYGOJUEJJA(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x7ACA0D0", Offset = "0x7AC90D0", VA = "0x187ACA0D0", Slot = "151")]
			protected virtual void DZVYKMORJUZ(YAVKDLMCPYL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x7ACA4C0", Offset = "0x7AC94C0", VA = "0x187ACA4C0", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B345C0", Offset = "0x2B335C0", VA = "0x182B345C0")]
		public static SNXISRUYHOD New(COWOBFPVIKZ circuitsManager, BNPRQWVLIYC node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class RBHLBEAAMMV : HGSUVJRLAFJ, QSXKFHFJPKO, YKOXFKAMQGI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<METWAAXGTBK> PERCMXUPNVC
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xEF8370", Offset = "0xEF7370", VA = "0x180EF8370", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<METWAAXGTBK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<HDSUEKONMVO> BFCUJZBUSZR
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x151AF60", Offset = "0x1519F60", VA = "0x18151AF60", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<HDSUEKONMVO>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x23D61D0", Offset = "0x23D51D0", VA = "0x1823D61D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<RGHHVUNUSGT> QPNKJOOCWVB
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x14516F0", Offset = "0x14506F0", VA = "0x1814516F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<GWVCCMPWDTY> AFFBDDUUGFX
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B435C0", Offset = "0x2B425C0", VA = "0x182B435C0", Slot = "22")]
			get
			{
				return default(Id32<GWVCCMPWDTY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B43960", Offset = "0x2B42960", VA = "0x182B43960")]
		private RBHLBEAAMMV(COWOBFPVIKZ a, BNPRQWVLIYC b, VOWYGYOBVLG c, Id32<HPGFUJBLNSN> portGroupId, Id32<HDSUEKONMVO> outputId, Id32<RGHHVUNUSGT> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B43610", Offset = "0x2B42610", VA = "0x182B43610")]
		public static RBHLBEAAMMV New(COWOBFPVIKZ circuitsManager, BNPRQWVLIYC node, VOWYGYOBVLG output, Id32<HPGFUJBLNSN> portGroupId, Id32<RGHHVUNUSGT> outputDefId, Id32<HDSUEKONMVO> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x23D61D0", Offset = "0x23D51D0", VA = "0x1823D61D0")]
		internal void QMXUDBVIURB(Id32<HDSUEKONMVO> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class HGSUVJRLAFJ : YKOXFKAMQGI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private JIKNDOHMACZ? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B42280", Offset = "0x2B41280", VA = "0x182B42280")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B42290", Offset = "0x2B41290", VA = "0x182B42290")]
			public JIKNDOHMACZ DVVRTBPPJKZ(HGSUVJRLAFJ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly COWOBFPVIKZ YTSLYIPCPMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly BNPRQWVLIYC EOMMCCMXVST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter EELJYDJLEIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly ZWQVXEFXEKY GBWULAZOTWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<JFIZWZSGTKE> UGUFQPORHHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<CGBVOBTKVVI> IIFMFRXHIBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool XQFMEWALHFX;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> RFOHNFILEDF
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D310", Offset = "0x2B3C310", VA = "0x182B3D310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind GXPAUJHFBTU
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xD13000", Offset = "0xD12000", VA = "0x180D13000", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<YUFXTHDQAZB> TPKSAYVBGKX
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DE30", Offset = "0x2B3CE30", VA = "0x182B3DE30", Slot = "6")]
			get
			{
				return default(Id32<YUFXTHDQAZB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<YUFXTHDQAZB> XFOTGMLRBKC
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D200", Offset = "0x2B3C200", VA = "0x182B3D200", Slot = "7")]
			get
			{
				return default(Id128<YUFXTHDQAZB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public EUKWVPLYZVT IBUDRYGYXYY
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D1E0", Offset = "0x2B3C1E0", VA = "0x182B3D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public KJYDPEYJTPJ HGDIUIHURVP
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D6B0", Offset = "0x2B3C6B0", VA = "0x182B3D6B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected JIKNDOHMACZ EUHLCTGNLXK
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B3D6B0", Offset = "0x2B3C6B0", VA = "0x182B3D6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage DODJUOCZRIS
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DE80", Offset = "0x2B3CE80", VA = "0x182B3DE80", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xCFC240", Offset = "0xCFB240", VA = "0x180CFC240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<ISSDUATOTVT> YFWMMDCBYNW
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E870", Offset = "0x2B3D870", VA = "0x182B3E870", Slot = "9")]
			get
			{
				return default(Id128<ISSDUATOTVT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<HPGFUJBLNSN> PFMHQRZLLYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xED7420", Offset = "0xED6420", VA = "0x180ED7420", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<HPGFUJBLNSN>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x1AABF50", Offset = "0x1AAAF50", VA = "0x181AABF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<GWVCCMPWDTY> AFFBDDUUGFX
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool UIYPJAJMTUC
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xF57640", Offset = "0xF56640", VA = "0x180F57640", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EA30", Offset = "0x2B3DA30", VA = "0x182B3EA30")]
		protected HGSUVJRLAFJ(COWOBFPVIKZ a, BNPRQWVLIYC b, ZWQVXEFXEKY c, Id32<HPGFUJBLNSN> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D5D0", Offset = "0x2B3C5D0", VA = "0x182B3D5D0", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D230", Offset = "0x2B3C230", VA = "0x182B3D230", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DA60", Offset = "0x2B3CA60", VA = "0x182B3DA60", Slot = "14")]
		public void LAWVMLXQYOV(JFIZWZSGTKE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DB10", Offset = "0x2B3CB10", VA = "0x182B3DB10", Slot = "15")]
		public void LDGPNWEKOTF(CGBVOBTKVVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D740", Offset = "0x2B3C740", VA = "0x182B3D740")]
		private bool KJTEKZSDMCO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E020", Offset = "0x2B3D020", VA = "0x182B3E020", Slot = "17")]
		public void WNTVCECSJUF(IHFZGDSWCHG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DFC0", Offset = "0x2B3CFC0", VA = "0x182B3DFC0", Slot = "25")]
		protected virtual void UVBJQFMSZWL(IHFZGDSWCHG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D450", Offset = "0x2B3C450", VA = "0x182B3D450", Slot = "20")]
		private void IATFHNMVUTO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DBC0", Offset = "0x2B3CBC0", VA = "0x182B3DBC0")]
		private void LKJAPXYNVIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E890", Offset = "0x2B3D890", VA = "0x182B3E890")]
		private void YASXHFZBADB([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DDD0", Offset = "0x2B3CDD0", VA = "0x182B3DDD0", Slot = "18")]
		public void PFNPSWZKFUG(JFIZWZSGTKE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DD70", Offset = "0x2B3CD70", VA = "0x182B3DD70", Slot = "19")]
		public void NXLWWLKFWMI(CGBVOBTKVVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xCFC240", Offset = "0xCFB240", VA = "0x180CFC240")]
		internal void SJUJNZNNBDL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DE60", Offset = "0x2B3CE60", VA = "0x182B3DE60")]
		internal void RLUCYNAROSS(ZGVEFLJMWTI a, EUKWVPLYZVT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1AABF50", Offset = "0x1AAAF50", VA = "0x181AABF50")]
		internal void ZZQPJGZHDLT(Id32<HPGFUJBLNSN> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class UOYBKLTOZDU : XAZCQBDUMDJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class RNYOXKGLJZE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public COWOBFPVIKZ VMAISQJIZLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public BNPRQWVLIYC NFWBLMBRPQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<HPGFUJBLNSN> ISFSNOZTJPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool MMHWTQQBSHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool SDITFHJVEYV;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public RNYOXKGLJZE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2B43C00", Offset = "0x2B42C00", VA = "0x182B43C00")]
			internal UOHKHVUFXJC FUBKWAIPKHU((int PortDescIndex, int PortIndex, TCRFCJQUXOV InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2B43CE0", Offset = "0x2B42CE0", VA = "0x182B43CE0")]
			internal RBHLBEAAMMV FUGRTHCMTTD(VOWYGYOBVLG a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x2B45C90", Offset = "0x2B44C90", VA = "0x182B45C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x2B46100", Offset = "0x2B45100", VA = "0x182B46100", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<IWUJLJYSQDA> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x2B473A0", Offset = "0x2B463A0", VA = "0x182B473A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2B476F0", Offset = "0x2B466F0", VA = "0x182B476F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x2B47760", Offset = "0x2B46760", VA = "0x182B47760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x2B47BE0", Offset = "0x2B46BE0", VA = "0x182B47BE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<RGHHVUNUSGT> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2B47C50", Offset = "0x2B46C50", VA = "0x182B47C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x2B47FA0", Offset = "0x2B46FA0", VA = "0x182B47FA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x2B487D0", Offset = "0x2B477D0", VA = "0x182B487D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x2B48B20", Offset = "0x2B47B20", VA = "0x182B48B20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<IWUJLJYSQDA> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x2B48010", Offset = "0x2B47010", VA = "0x182B48010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x2B48380", Offset = "0x2B47380", VA = "0x182B48380", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<RGHHVUNUSGT> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x2B483F0", Offset = "0x2B473F0", VA = "0x182B483F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x2B48760", Offset = "0x2B47760", VA = "0x182B48760", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public PJVLKDMUVJA type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<IWUJLJYSQDA> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2B48B90", Offset = "0x2B47B90", VA = "0x182B48B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2B48F30", Offset = "0x2B47F30", VA = "0x182B48F30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public PJVLKDMUVJA type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<RGHHVUNUSGT> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2B48FA0", Offset = "0x2B47FA0", VA = "0x182B48FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x2B49340", Offset = "0x2B48340", VA = "0x182B49340", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<IWUJLJYSQDA> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<IWUJLJYSQDA> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x2B493B0", Offset = "0x2B483B0", VA = "0x182B493B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x2B49710", Offset = "0x2B48710", VA = "0x182B49710", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public UOYBKLTOZDU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<RGHHVUNUSGT> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<RGHHVUNUSGT> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private MTGSWKHGETU <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x2B49780", Offset = "0x2B48780", VA = "0x182B49780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x2B49AE0", Offset = "0x2B48AE0", VA = "0x182B49AE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool QBMKYOQPINT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly COWOBFPVIKZ YTSLYIPCPMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool KDVJXNCBYMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<FBIPJIAHSMB, UOHKHVUFXJC> PNARVUFGHYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<FBIPJIAHSMB, RHMKGKFUMBP> THWISSVRRUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly BNPRQWVLIYC EOMMCCMXVST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<HDSUEKONMVO, RBHLBEAAMMV> TWKBZZHSUYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<HDSUEKONMVO, QSXKFHFJPKO> BQOUDLLYAER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? UTLCIHXLRWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly NWXJLXTFVUZ LFGSCQERNYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<HPGFUJBLNSN> RYDBRNHVWAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool LGIBQMQCEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? DRFHLTJFIYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? EAKWNCXXQLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<FBIPJIAHSMB>>? THLMSUZHSSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<HDSUEKONMVO>>? PNDUZORFPUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private XAZCQBDUMDJ.PortGroupIdChangeDelegate? ANKHPUMQUJA;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool NZCUTZHQWFQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EBC0", Offset = "0x2B4DBC0", VA = "0x182B4EBC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool NSCVMWPQEWD
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B518E0", Offset = "0x2B508E0", VA = "0x182B518E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool GIVVAOAIJVL
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B51630", Offset = "0x2B50630", VA = "0x182B51630", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<YUFXTHDQAZB> XFOTGMLRBKC
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D5C0", Offset = "0x2B4C5C0", VA = "0x182B4D5C0", Slot = "7")]
			get
			{
				return default(Id128<YUFXTHDQAZB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool ADFILDAPNXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B505E0", Offset = "0x2B4F5E0", VA = "0x182B505E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<FBIPJIAHSMB, RHMKGKFUMBP> OVARURGOYXN
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<FBIPJIAHSMB, RHMKGKFUMBP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D590", Offset = "0x2B4C590", VA = "0x182B4D590", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<ISSDUATOTVT> YFWMMDCBYNW
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B51800", Offset = "0x2B50800", VA = "0x182B51800", Slot = "11")]
			get
			{
				return default(Id128<ISSDUATOTVT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<HDSUEKONMVO, QSXKFHFJPKO> LYBOYIUPWUE
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<HDSUEKONMVO, QSXKFHFJPKO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<HPGFUJBLNSN> PFMHQRZLLYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x1021F80", Offset = "0x1020F80", VA = "0x181021F80", Slot = "13")]
			get
			{
				return default(Id32<HPGFUJBLNSN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? VNEDBTOBFAF
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B50240", Offset = "0x2B4F240", VA = "0x182B50240", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F3C0", Offset = "0x2B4E3C0", VA = "0x182B4F3C0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? VCVDSPVGBKS
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F070", Offset = "0x2B4E070", VA = "0x182B4F070", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B51300", Offset = "0x2B50300", VA = "0x182B51300", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<FBIPJIAHSMB?>, Id32<FBIPJIAHSMB?>>? VAAKVDRRNZP
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FA70", Offset = "0x2B4EA70", VA = "0x182B4FA70", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F9B0", Offset = "0x2B4E9B0", VA = "0x182B4F9B0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<FBIPJIAHSMB?>, Id32<FBIPJIAHSMB?>>? KXYGZFAFYIK
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FD10", Offset = "0x2B4ED10", VA = "0x182B4FD10", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E1E0", Offset = "0x2B4D1E0", VA = "0x182B4E1E0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<HDSUEKONMVO?>, Id32<HDSUEKONMVO?>>? EQRCKHPIDFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E410", Offset = "0x2B4D410", VA = "0x182B4E410", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2B50520", Offset = "0x2B4F520", VA = "0x182B50520", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<HDSUEKONMVO?>, Id32<HDSUEKONMVO?>>? CSHREPSROAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EE90", Offset = "0x2B4DE90", VA = "0x182B4EE90", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2B4DA50", Offset = "0x2B4CA50", VA = "0x182B4DA50", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<FBIPJIAHSMB?>, RHMKGKFUMBP?>? GJECDGMGXWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2B50A20", Offset = "0x2B4FA20", VA = "0x182B50A20", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2B51820", Offset = "0x2B50820", VA = "0x182B51820", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<FBIPJIAHSMB?>>? MIDAFILKCZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x2B50960", Offset = "0x2B4F960", VA = "0x182B50960", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D4D0", Offset = "0x2B4C4D0", VA = "0x182B4D4D0", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<FBIPJIAHSMB?>, RHMKGKFUMBP?>? YTWYNBJZSVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F140", Offset = "0x2B4E140", VA = "0x182B4F140", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EDD0", Offset = "0x2B4DDD0", VA = "0x182B4EDD0", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<HDSUEKONMVO?>, QSXKFHFJPKO?>? LDOFABZWUQN
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2B508A0", Offset = "0x2B4F8A0", VA = "0x182B508A0", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FC50", Offset = "0x2B4EC50", VA = "0x182B4FC50", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<HDSUEKONMVO?>>? GGRMZXSJPLY
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E9F0", Offset = "0x2B4D9F0", VA = "0x182B4E9F0", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2B51B40", Offset = "0x2B50B40", VA = "0x182B51B40", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<HDSUEKONMVO?>, QSXKFHFJPKO?>? BVXRUASPRXT
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EC80", Offset = "0x2B4DC80", VA = "0x182B4EC80", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D610", Offset = "0x2B4C610", VA = "0x182B4D610", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2B51FA0", Offset = "0x2B50FA0", VA = "0x182B51FA0")]
		private UOYBKLTOZDU(bool a, COWOBFPVIKZ b, bool c, ReadOnlyIdArray<FBIPJIAHSMB, UOHKHVUFXJC> inputs, ReadOnlyIdArray<FBIPJIAHSMB, RHMKGKFUMBP> inputsAsStaticInputs, BNPRQWVLIYC d, ReadOnlyIdArray<HDSUEKONMVO, RBHLBEAAMMV> outputs, ReadOnlyIdArray<HDSUEKONMVO, QSXKFHFJPKO> outputsAsStaticOutputs, string? overrideName, NWXJLXTFVUZ e, Id32<HPGFUJBLNSN> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F460", Offset = "0x2B4E460", VA = "0x182B4F460")]
		public static UOYBKLTOZDU New(bool canInteract, COWOBFPVIKZ circuitsManager, bool hasFunctionHeader, BNPRQWVLIYC node, NWXJLXTFVUZ portGroup, Id32<HPGFUJBLNSN> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D6D0", Offset = "0x2B4C6D0", VA = "0x182B4D6D0", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2B51920", Offset = "0x2B50920", VA = "0x182B51920", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, MCRZZCNKUJE?>>? YUBCGROKPWE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2B50660", Offset = "0x2B4F660", VA = "0x182B50660")]
		private (NBLFIFMWZTR?, int)? SQXIBYSVGCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D3C0", Offset = "0x2B4C3C0", VA = "0x182B4D3C0", Slot = "58")]
		private void BQSQOGQUWEM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x23A7480", Offset = "0x23A6480", VA = "0x1823A7480", Slot = "57")]
		private void OIXWXUKCZSX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E4F0", Offset = "0x2B4D4F0", VA = "0x182B4E4F0", Slot = "61")]
		private void GPLIFLUIPGJ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ED40", Offset = "0x2B4DD40", VA = "0x182B4ED40", Slot = "63")]
		private void ILWHCMNQFJO(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DB10", Offset = "0x2B4CB10", VA = "0x182B4DB10", Slot = "50")]
		private void EGJDMUJBPFV(int a, Id32<FBIPJIAHSMB> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E4D0", Offset = "0x2B4D4D0", VA = "0x182B4E4D0", Slot = "54")]
		private void GEBEPSDSZUU(int a, Id32<FBIPJIAHSMB> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2B51520", Offset = "0x2B50520", VA = "0x182B51520", Slot = "49")]
		private void WPLJNXIEILE(int a, Id32<FBIPJIAHSMB> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2B50EB0", Offset = "0x2B4FEB0", VA = "0x182B50EB0", Slot = "53")]
		private void UYLEBXCHCBB(int a, Id32<FBIPJIAHSMB> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2B513B0", Offset = "0x2B503B0", VA = "0x182B513B0", Slot = "66")]
		private void VTRHICFLPVR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C00", Offset = "0x1105C00", VA = "0x181106C00", Slot = "65")]
		private void PYHTLBTNQSA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2B4EAB0", Offset = "0x2B4DAB0", VA = "0x182B4EAB0", Slot = "60")]
		private void HWFNJKOVVZN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x23A7480", Offset = "0x23A6480", VA = "0x1823A7480", Slot = "59")]
		private void ZCYQMKZFSQS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2B50AE0", Offset = "0x2B4FAE0", VA = "0x182B50AE0", Slot = "62")]
		private void UIQAFJAQPUE(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F200", Offset = "0x2B4E200", VA = "0x182B4F200", Slot = "64")]
		private void NXARSQLLTYH(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CE20", Offset = "0x2B4BE20", VA = "0x182B4CE20", Slot = "52")]
		private void BGIWHLULKJQ(int a, Id32<HDSUEKONMVO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D5F0", Offset = "0x2B4C5F0", VA = "0x182B4D5F0", Slot = "56")]
		private void DEJRPVYFBDJ(int a, Id32<HDSUEKONMVO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F120", Offset = "0x2B4E120", VA = "0x182B4F120", Slot = "51")]
		private void LEXAHKNEHEF(int a, Id32<HDSUEKONMVO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FDD0", Offset = "0x2B4EDD0", VA = "0x182B4FDD0", Slot = "55")]
		private void PZJWTOMJQYO(int a, Id32<HDSUEKONMVO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E2A0", Offset = "0x2B4D2A0", VA = "0x182B4E2A0", Slot = "68")]
		private void FGUOKGIQYDK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x1106C00", Offset = "0x1105C00", VA = "0x181106C00", Slot = "67")]
		private void CTGFCJCUDVD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B50410", Offset = "0x2B4F410", VA = "0x182B50410", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, MCRZZCNKUJE?>>? RPTCBCNHAOB(Id32<IWUJLJYSQDA> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2B516F0", Offset = "0x2B506F0", VA = "0x182B516F0", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, MCRZZCNKUJE?>>? XMRFVQTLVLA(Id32<RGHHVUNUSGT> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2B4EF50", Offset = "0x2B4DF50", VA = "0x182B4EF50", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, MCRZZCNKUJE?>>? JDQXZJJEJVB(Id32<IWUJLJYSQDA> inputDefId, Id32<IWUJLJYSQDA> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FB30", Offset = "0x2B4EB30", VA = "0x182B4FB30", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, MCRZZCNKUJE?>>? PJZTFARBBYW(Id32<RGHHVUNUSGT> outputDefId, Id32<RGHHVUNUSGT> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2B51540", Offset = "0x2B50540", VA = "0x182B51540", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, MCRZZCNKUJE?>>? WQCZERHLEAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E0C0", Offset = "0x2B4D0C0", VA = "0x182B4E0C0", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, MCRZZCNKUJE>> FAQCERJBFME(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F290", Offset = "0x2B4E290", VA = "0x182B4F290", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, MCRZZCNKUJE>> NYYHTQCHANZ(Id32<IWUJLJYSQDA> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E8C0", Offset = "0x2B4D8C0", VA = "0x182B4E8C0", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, MCRZZCNKUJE>> GXYPBSTXIAE(Id32<RGHHVUNUSGT> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2B51A10", Offset = "0x2B50A10", VA = "0x182B51A10", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, MCRZZCNKUJE>> YYDPEQXDFQU(Id32<IWUJLJYSQDA> inputDefId, PJVLKDMUVJA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x2B502E0", Offset = "0x2B4F2E0", VA = "0x182B502E0", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, MCRZZCNKUJE>> QOEYIQSFPVH(Id32<RGHHVUNUSGT> outputDefId, PJVLKDMUVJA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x2B51C00", Offset = "0x2B50C00", VA = "0x182B51C00")]
		internal void ZZQPJGZHDLT(Id32<HPGFUJBLNSN> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class ZJXORRQKNEA : GIIFHFQKBOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface UYPXTMTCQYP
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<YUFXTHDQAZB>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065F")]
				[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<YUFXTHDQAZB>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			ZGVEFLJMWTI ZGVEFLJMWTI
			{
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> PGFEIBYZKAD(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> NEFIEAVAYKW(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<UPLRFRLNHUO> YYPWYKDEEOV(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<SZARDBYZIVI> KRVJFTEAIWW(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> MPIYUBIWZQH(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> RSGLGJEUCLU(CancellationToken a);
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
			public AsyncTaskMethodBuilder<ZJXORRQKNEA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public COWOBFPVIKZ circuitsManager;

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
			private UYPXTMTCQYP <selfDeps>5__2;

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
			private UPLRFRLNHUO <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private SZARDBYZIVI <playerSaveData>5__8;

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
			private TaskAwaiter<UPLRFRLNHUO> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<SZARDBYZIVI> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<UYPXTMTCQYP.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<SEQOFYDKXBO> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2B46170", Offset = "0x2B45170", VA = "0x182B46170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x2B47330", Offset = "0x2B46330", VA = "0x182B47330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public SEQOFYDKXBO SEQOFYDKXBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public QQTZTXNHSNY QQTZTXNHSNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public TWUCWEKRFNJ TWUCWEKRFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public DNGQBKSNALR DNGQBKSNALR
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x112D620", Offset = "0x112C620", VA = "0x18112D620")]
		private ZJXORRQKNEA(SEQOFYDKXBO a, QQTZTXNHSNY b, TWUCWEKRFNJ c, DNGQBKSNALR d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x2B52860", Offset = "0x2B51860", VA = "0x182B52860")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<ZJXORRQKNEA> FCRZSPSXEHZ(COWOBFPVIKZ a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x2B52840", Offset = "0x2B51840", VA = "0x182B52840", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class FFEMUSLXLUQ : KXLSTNRBYUL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly COWOBFPVIKZ YTSLYIPCPMW;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public PFXUWZDGWQA? CIARLSLMHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x2B39100", Offset = "0x2B38100", VA = "0x182B39100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		internal FFEMUSLXLUQ(COWOBFPVIKZ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class TWUCWEKRFNJ : PFXUWZDGWQA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly COWOBFPVIKZ YTSLYIPCPMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly SEQOFYDKXBO MATSITTHXMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly FFEMUSLXLUQ LEEDZMKQYIN;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> KFKIEQMSDOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x2B456A0", Offset = "0x2B446A0", VA = "0x182B456A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xDDB9F0", Offset = "0xDDA9F0", VA = "0x180DDB9F0")]
		public TWUCWEKRFNJ(COWOBFPVIKZ a, SEQOFYDKXBO b, FFEMUSLXLUQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x2B45740", Offset = "0x2B44740", VA = "0x182B45740", Slot = "5")]
		public string PYWXMQZWWWR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2B456E0", Offset = "0x2B446E0", VA = "0x182B456E0", Slot = "6")]
		public void IZYLXKQMATG(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2B617A0", Offset = "0x2B607A0", VA = "0x182B617A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2B619E0", Offset = "0x2B609E0", VA = "0x182B619E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, MCRZZCNKUJE>> <>t__builder;

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
			private PYPEGOPZPPS[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x2B621E0", Offset = "0x2B611E0", VA = "0x182B621E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x2B625B0", Offset = "0x2B615B0", VA = "0x182B625B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public PYPEGOPZPPS action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x2B668E0", Offset = "0x2B658E0", VA = "0x182B668E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x2B66D60", Offset = "0x2B65D60", VA = "0x182B66D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly SWFQECRPDPB _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		public EVRequestExtended(SWFQECRPDPB staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2B38D80", Offset = "0x2B37D80", VA = "0x182B38D80")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, MCRZZCNKUJE>> DCYTPWEWWSH(PYPEGOPZPPS a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2B38FA0", Offset = "0x2B37FA0", VA = "0x182B38FA0")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, MCRZZCNKUJE?>>? HADAGZIIDRK(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x2B38EB0", Offset = "0x2B37EB0", VA = "0x182B38EB0")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, MCRZZCNKUJE>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface RZKCOKFPWZF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		GIIFHFQKBOL? CIARLSLMHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool NVUMPXNIFEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<GIIFHFQKBOL?>? IRXCRXKOKEP();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task LZKVPNWDWAI(COWOBFPVIKZ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface GIIFHFQKBOL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		SEQOFYDKXBO SEQOFYDKXBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		QQTZTXNHSNY QQTZTXNHSNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		TWUCWEKRFNJ TWUCWEKRFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		DNGQBKSNALR DNGQBKSNALR
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class QETWNNUHKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x2B60B90", Offset = "0x2B5FB90", VA = "0x182B60B90")]
		public static ReducerFactory<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ, XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>> KQZIOONCSCF([In] this ReducerFactory<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ, XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ, XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class BHCANWTTFHZ : QMWLHXUPTRG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly COWOBFPVIKZ YTSLYIPCPMW;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool NVUMPXNIFEW
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x2B532B0", Offset = "0x2B522B0", VA = "0x182B532B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		internal BHCANWTTFHZ(COWOBFPVIKZ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class YCFMSDYLAVK : JATPSMBYSGN
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2B67900", Offset = "0x2B66900", VA = "0x182B67900", Slot = "4")]
		public LWDHSRBXMDZ? OCJVQOIYVWI(string? a, string? b, string? c, RoomDoorData.SVFNYUIHGCD.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2B67830", Offset = "0x2B66830", VA = "0x182B67830", Slot = "5")]
		public JNECXGDSWPZ DMRFMFEWKFE(string a, string b, List<string> c, int d, int e, int f, int g, TQSEMUPFQCT h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x2B67790", Offset = "0x2B66790", VA = "0x182B67790", Slot = "6")]
		public TQSEMUPFQCT BYAPDFLBXQA(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public YCFMSDYLAVK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class EHTXORRPEAU : FMQLZJSTKGH
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
			public AsyncTaskMethodBuilder<FZLXAJZQSFG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public EHTXORRPEAU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<GIIFHFQKBOL?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2B61A50", Offset = "0x2B60A50", VA = "0x182B61A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2B61CE0", Offset = "0x2B60CE0", VA = "0x182B61CE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly COWOBFPVIKZ YTSLYIPCPMW;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public FZLXAJZQSFG? CIARLSLMHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B7F0", Offset = "0x2B5A7F0", VA = "0x182B5B7F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public DNGQBKSNALR? HIPOWGPDNQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B770", Offset = "0x2B5A770", VA = "0x182B5B770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool PDQWUBRGSRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x2B5AEF0", Offset = "0x2B59EF0", VA = "0x182B5AEF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool QPSPPAIKILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x2B5B710", Offset = "0x2B5A710", VA = "0x182B5B710", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B870", Offset = "0x2B5A870", VA = "0x182B5B870")]
		internal EHTXORRPEAU(COWOBFPVIKZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B0D0", Offset = "0x2B5A0D0", VA = "0x182B5B0D0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<FZLXAJZQSFG> IRXCRXKOKEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B1C0", Offset = "0x2B5A1C0", VA = "0x182B5B1C0", Slot = "9")]
		public IReadOnlyDictionary<Id128<YUFXTHDQAZB>, Guid> PKOZWPKDSPV(IEnumerable<RWNYJETRKPC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AF50", Offset = "0x2B59F50", VA = "0x182B5AF50", Slot = "10")]
		public CircuitGraphToolMappingRegistryData HDMQJHAOOOD(IEnumerable<RWNYJETRKPC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B540", Offset = "0x2B5A540", VA = "0x182B5B540")]
		public Result<CircuitsRoomData, YCREHOYWOHO> RMDGYUQUKXJ([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, YCREHOYWOHO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AEC0", Offset = "0x2B59EC0", VA = "0x182B5AEC0", Slot = "8")]
		private Result<CircuitsRoomData, YCREHOYWOHO> AMSNKDZARFQ([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, YCREHOYWOHO>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class DNGQBKSNALR : FZLXAJZQSFG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class PUGUPTGXYJQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class GZTFKPJKAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int FXABJGYHUKZ;

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				public GZTFKPJKAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BA50", Offset = "0x2B5AA50", VA = "0x182B5BA50")]
				internal void ULALPCJDZEI(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F5D0", Offset = "0x2B5E5D0", VA = "0x182B5F5D0")]
			public static Result<FZLXAJZQSFG.PrepareTemplateForCloneResult, OVKUTAZGTAB> EBXMKUNRLSP(DNGQBKSNALR a, [In] FZLXAJZQSFG.PrepareTemplateForCloneArgs args)
			{
				return default(Result<FZLXAJZQSFG.PrepareTemplateForCloneResult, OVKUTAZGTAB>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E770", Offset = "0x2B5D770", VA = "0x182B5E770")]
			internal static Result<(GLZUCCCDLMU, CircuitTemplateRootData), OVKUTAZGTAB> CWMEDSBFOHX(DNGQBKSNALR a, CircuitTemplateRootData b, bool c, [In] Id128<YUFXTHDQAZB> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(GLZUCCCDLMU, CircuitTemplateRootData), OVKUTAZGTAB>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FAE0", Offset = "0x2B5EAE0", VA = "0x182B5FAE0")]
			private static void MJJNTYHKYSL(bool a, RWNYJETRKPC b, GLZUCCCDLMU c, [In] Id128<YUFXTHDQAZB> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2B60530", Offset = "0x2B5F530", VA = "0x182B60530")]
			public static void XFYEEKDRNYU(FZCUOOHXFZF a, [In] FZLXAJZQSFG.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x2B5FF70", Offset = "0x2B5EF70", VA = "0x182B5FF70")]
			[CompilerGenerated]
			internal static bool SAQMKTQGMTP(SEQOFYDKXBO a, FDUYIFBBDJV b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x2B60500", Offset = "0x2B5F500", VA = "0x182B60500")]
			[CompilerGenerated]
			internal static bool UVBXHJZXFJK(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class AXCLOFQTRNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public DNGQBKSNALR NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<YUFXTHDQAZB> VYRHSIKQXGM;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public AXCLOFQTRNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x2B53120", Offset = "0x2B52120", VA = "0x182B53120")]
			internal Id128<ISSDUATOTVT> OCRKVBEHVUD(Id32<ISSDUATOTVT> a)
			{
				return default(Id128<ISSDUATOTVT>);
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<METWAAXGTBK> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<EXUEQGJGLLV> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x2B62620", Offset = "0x2B61620", VA = "0x182B62620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x2B62BF0", Offset = "0x2B61BF0", VA = "0x182B62BF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<ISSDUATOTVT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<HPGFUJBLNSN> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<IWUJLJYSQDA> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x2B62C60", Offset = "0x2B61C60", VA = "0x182B62C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2B62FB0", Offset = "0x2B61FB0", VA = "0x182B62FB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<ISSDUATOTVT>, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<DQODHRVSODS> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private SEQOFYDKXBO <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x2B63300", Offset = "0x2B62300", VA = "0x182B63300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x2B63730", Offset = "0x2B62730", VA = "0x182B63730", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<ISSDUATOTVT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x2B63020", Offset = "0x2B62020", VA = "0x182B63020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x2B63290", Offset = "0x2B62290", VA = "0x182B63290", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2B637A0", Offset = "0x2B627A0", VA = "0x182B637A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2B63990", Offset = "0x2B62990", VA = "0x182B63990", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<YUFXTHDQAZB> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<ISSDUATOTVT> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<ISSDUATOTVT>> nodeIds;

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
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2B63A00", Offset = "0x2B62A00", VA = "0x182B63A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2B63CA0", Offset = "0x2B62CA0", VA = "0x182B63CA0", Slot = "5")]
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
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<YUFXTHDQAZB> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<ISSDUATOTVT> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<ISSDUATOTVT>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<HPGFUJBLNSN>, Id32<FBIPJIAHSMB>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<HPGFUJBLNSN>, Id32<HDSUEKONMVO>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2B63D10", Offset = "0x2B62D10", VA = "0x182B63D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2B642E0", Offset = "0x2B632E0", VA = "0x182B642E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<YUFXTHDQAZB> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<ISSDUATOTVT> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<ISSDUATOTVT>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x2B64340", Offset = "0x2B63340", VA = "0x182B64340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2B64550", Offset = "0x2B63550", VA = "0x182B64550", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<ISSDUATOTVT> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<HPGFUJBLNSN> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<FBIPJIAHSMB> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2B645C0", Offset = "0x2B635C0", VA = "0x182B645C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2B64910", Offset = "0x2B63910", VA = "0x182B64910", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<ISSDUATOTVT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<HPGFUJBLNSN> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<IWUJLJYSQDA> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2B64980", Offset = "0x2B63980", VA = "0x182B64980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2B64D60", Offset = "0x2B63D60", VA = "0x182B64D60", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<ISSDUATOTVT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2B64DD0", Offset = "0x2B63DD0", VA = "0x182B64DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2B65050", Offset = "0x2B64050", VA = "0x182B65050", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<ISSDUATOTVT> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<HPGFUJBLNSN> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<HDSUEKONMVO> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2B650C0", Offset = "0x2B640C0", VA = "0x182B650C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2B65410", Offset = "0x2B64410", VA = "0x182B65410", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<ISSDUATOTVT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2B65480", Offset = "0x2B64480", VA = "0x182B65480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2B657C0", Offset = "0x2B647C0", VA = "0x182B657C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<ISSDUATOTVT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2B65830", Offset = "0x2B64830", VA = "0x182B65830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2B65AC0", Offset = "0x2B64AC0", VA = "0x182B65AC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<ISSDUATOTVT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2B65B30", Offset = "0x2B64B30", VA = "0x182B65B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2B65DC0", Offset = "0x2B64DC0", VA = "0x182B65DC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<ISSDUATOTVT>>, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<YUFXTHDQAZB> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<RWNYJETRKPC> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<BNPRQWVLIYC>, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2B65E30", Offset = "0x2B64E30", VA = "0x182B65E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2B665E0", Offset = "0x2B655E0", VA = "0x182B665E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<YUFXTHDQAZB> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<ISSDUATOTVT> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<ISSDUATOTVT>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2B66650", Offset = "0x2B65650", VA = "0x182B66650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2B66870", Offset = "0x2B65870", VA = "0x182B66870", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public DNGQBKSNALR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<YUFXTHDQAZB> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<ISSDUATOTVT> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x2B66DD0", Offset = "0x2B65DD0", VA = "0x182B66DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x2B66FF0", Offset = "0x2B65FF0", VA = "0x182B66FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly COWOBFPVIKZ YTSLYIPCPMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly SEQOFYDKXBO MATSITTHXMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers NHVWVPJUCXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly EHTXORRPEAU JBWVFHBCODT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<ISSDUATOTVT>, SNXISRUYHOD> ALRCOFUJRVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<ISSDUATOTVT>>? GIVVCQPSJIP;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<YUFXTHDQAZB> UIKPWUUYJYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x2B54DB0", Offset = "0x2B53DB0", VA = "0x182B54DB0", Slot = "4")]
			get
			{
				return default(Id128<YUFXTHDQAZB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers REKPNWRXFRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2B59F60", Offset = "0x2B58F60", VA = "0x182B59F60", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> IKBQOYECPRE
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B59E50", Offset = "0x2B58E50", VA = "0x182B59E50", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action CRUONGFVVFX
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B53D90", Offset = "0x2B52D90", VA = "0x182B53D90", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B54C80", Offset = "0x2B53C80", VA = "0x182B54C80", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> YZUTPGAKAOT
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B582B0", Offset = "0x2B572B0", VA = "0x182B582B0", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B541F0", Offset = "0x2B531F0", VA = "0x182B541F0", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A950", Offset = "0x2B59950", VA = "0x182B5A950")]
		public DNGQBKSNALR(COWOBFPVIKZ a, SEQOFYDKXBO b, EHTXORRPEAU c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2B54610", Offset = "0x2B53610", VA = "0x182B54610", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2B55F30", Offset = "0x2B54F30", VA = "0x182B55F30", Slot = "100")]
		public Id32<JWMQWCSZLZH> JEHDSCXPSHY(Id32<YUFXTHDQAZB> graphId, Id32<EXUEQGJGLLV> inputId)
		{
			return default(Id32<JWMQWCSZLZH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2B58A00", Offset = "0x2B57A00", VA = "0x182B58A00", Slot = "101")]
		public Id32<ZZQKNMLXIHO> SHITXRCPYBT(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> outputId)
		{
			return default(Id32<ZZQKNMLXIHO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2B556E0", Offset = "0x2B546E0", VA = "0x182B556E0", Slot = "6")]
		public (bool, bool) IJVMHZZASIS(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2B53E30", Offset = "0x2B52E30", VA = "0x182B53E30")]
		public bool DAKUPMWWKBV(Id32<YUFXTHDQAZB> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2B56100", Offset = "0x2B55100", VA = "0x182B56100", Slot = "8")]
		public bool KONQXNVVJSD(RHMKGKFUMBP a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2B542B0", Offset = "0x2B532B0", VA = "0x182B542B0", Slot = "9")]
		public bool DHZMHVVHLGK(QSXKFHFJPKO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2B545B0", Offset = "0x2B535B0", VA = "0x182B545B0", Slot = "10")]
		public AbsoluteLegacyInputId? DWLIFXWVIXH(Id32<YUFXTHDQAZB> graphId, Id32<EXUEQGJGLLV> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2B55F50", Offset = "0x2B54F50", VA = "0x182B55F50", Slot = "11")]
		public AbsoluteLegacyOutputId? JGYJTQICEIM(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A8F0", Offset = "0x2B598F0", VA = "0x182B5A8F0", Slot = "12")]
		public Id32<METWAAXGTBK>? ZXDOMXHKRYS(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<HDSUEKONMVO> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2B55680", Offset = "0x2B54680", VA = "0x182B55680", Slot = "13")]
		public Id32<EXUEQGJGLLV>? HNOTLXPJVBN(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<FBIPJIAHSMB> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B59BA0", Offset = "0x2B58BA0", VA = "0x182B59BA0", Slot = "14")]
		public IEnumerable<Id32<YUFXTHDQAZB>> WKIJHSOOWUX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B59DC0", Offset = "0x2B58DC0", VA = "0x182B59DC0", Slot = "15")]
		public IEnumerable<Id32<DKRIAFHGUAF>> XTNCMBIHOQA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B567F0", Offset = "0x2B557F0", VA = "0x182B567F0", Slot = "22")]
		public string KSOQULQGPKQ(Id32<DKRIAFHGUAF> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B59040", Offset = "0x2B58040", VA = "0x182B59040", Slot = "16")]
		public Id32<DKRIAFHGUAF>? TLPLTPEKXNW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B59300", Offset = "0x2B58300", VA = "0x182B59300", Slot = "17")]
		public int UBLPLKRSKEZ(Id32<DKRIAFHGUAF> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B568E0", Offset = "0x2B558E0", VA = "0x182B568E0", Slot = "18")]
		public int LTXFRJARVLU(Id32<DKRIAFHGUAF> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B56A20", Offset = "0x2B55A20", VA = "0x182B56A20", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] MXLCGCAPZDZ(Id32<DKRIAFHGUAF> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B58860", Offset = "0x2B57860", VA = "0x182B58860", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] ROCYGZKBYIU(Id32<DKRIAFHGUAF> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x38FA9D0", Offset = "0x38F99D0", VA = "0x1838FA9D0")]
		private static (CircuitTypeIdWrapper, string?)[]? XNBEPEURGTX<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B53E00", Offset = "0x2B52E00", VA = "0x182B53E00", Slot = "21")]
		public string CYIKKLGUBJK(Id32<DKRIAFHGUAF> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B56B90", Offset = "0x2B55B90", VA = "0x182B56B90", Slot = "23")]
		public string NLYUAUSBKJD(Id32<DKRIAFHGUAF> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B58470", Offset = "0x2B57470", VA = "0x182B58470")]
		public SNXISRUYHOD? PUVEWDQLWHQ([In] Id128<ISSDUATOTVT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2B533A0", Offset = "0x2B523A0", VA = "0x182B533A0", Slot = "30")]
		public Id32<DQODHRVSODS> AJVXSWMPBMU(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId)
		{
			return default(Id32<DQODHRVSODS>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B54120", Offset = "0x2B53120", VA = "0x182B54120")]
		public Id32<ISSDUATOTVT> DBLQJKSIHKL(Id32<YUFXTHDQAZB> graphId, [In] Id128<ISSDUATOTVT> legacyNodeId)
		{
			return default(Id32<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B569F0", Offset = "0x2B559F0", VA = "0x182B569F0", Slot = "40")]
		public Id32<ISSDUATOTVT> MQUCEMRITKA(Id32<YUFXTHDQAZB> graphId, Id32<EXUEQGJGLLV> inputId)
		{
			return default(Id32<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B56BB0", Offset = "0x2B55BB0", VA = "0x182B56BB0", Slot = "41")]
		public Id32<ISSDUATOTVT> NPAIAMDCHJB(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> outputId)
		{
			return default(Id32<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B58C70", Offset = "0x2B57C70", VA = "0x182B58C70")]
		public Id32<ISSDUATOTVT>? SNRTYJATVMH(Id32<YUFXTHDQAZB> graphId, [In] Id128<ISSDUATOTVT> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B54330", Offset = "0x2B53330", VA = "0x182B54330", Slot = "32")]
		public AbsoluteNodeId? DOYSURJVFWJ(Id32<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B55EF0", Offset = "0x2B54EF0", VA = "0x182B55EF0", Slot = "33")]
		public long JAKVBGFAIRM()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B53700", Offset = "0x2B52700", VA = "0x182B53700")]
		private void BMPVWUJOGGO(Id128<ISSDUATOTVT> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B58CC0", Offset = "0x2B57CC0", VA = "0x182B58CC0", Slot = "38")]
		public IEnumerable<(Id32<YUFXTHDQAZB>, Id32<ISSDUATOTVT>)> SXXHZCCTEYU(Id32<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B556B0", Offset = "0x2B546B0", VA = "0x182B556B0", Slot = "39")]
		public Id32<EXUEQGJGLLV> HNOTLXPJVBN(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<JWMQWCSZLZH> inputIndex)
		{
			return default(Id32<EXUEQGJGLLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A920", Offset = "0x2B59920", VA = "0x182B5A920", Slot = "42")]
		public Id32<METWAAXGTBK> ZXDOMXHKRYS(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<ZZQKNMLXIHO> outputIndex)
		{
			return default(Id32<METWAAXGTBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B585D0", Offset = "0x2B575D0", VA = "0x182B585D0")]
		private SNXISRUYHOD? QORYNQMNGXT([In] Id128<ISSDUATOTVT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B549B0", Offset = "0x2B539B0", VA = "0x182B549B0")]
		public BNPRQWVLIYC? ESDGFCRCGIX([In] Id128<ISSDUATOTVT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B56820", Offset = "0x2B55820", VA = "0x182B56820")]
		public OOFXQBZYQXD? PASCSJQKHBM([In] Id128<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B58100", Offset = "0x2B57100", VA = "0x182B58100", Slot = "25")]
		public OOFXQBZYQXD? PASCSJQKHBM(Id32<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B54210", Offset = "0x2B53210", VA = "0x182B54210", Slot = "34")]
		public IEnumerable<NewStaticEdge> DHKWENWCLFU(Id32<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B532D0", Offset = "0x2B522D0", VA = "0x182B532D0", Slot = "35")]
		public bool ABTIVNVQASG(Id32<DKRIAFHGUAF> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B58A20", Offset = "0x2B57A20", VA = "0x182B58A20", Slot = "36")]
		public IEnumerable<StableStaticEdge> SKEWACSXTHM(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A2C0", Offset = "0x2B592C0", VA = "0x182B5A2C0", Slot = "37")]
		public IEnumerable<StableStaticEdge> ZMVITQMDSQF(Id32<YUFXTHDQAZB> graphId, Id32<EXUEQGJGLLV> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B53DB0", Offset = "0x2B52DB0", VA = "0x182B53DB0")]
		public Id32<YUFXTHDQAZB> CUSOWEDYOUP([In] Id128<YUFXTHDQAZB> graphId)
		{
			return default(Id32<YUFXTHDQAZB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B585A0", Offset = "0x2B575A0", VA = "0x182B585A0")]
		public Id32<YUFXTHDQAZB>? QJETBELOLSX([In] Id128<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B54150", Offset = "0x2B53150", VA = "0x182B54150")]
		private FDUYIFBBDJV? DCGXRLDTAVD([In] Id128<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B56820", Offset = "0x2B55820", VA = "0x182B56820")]
		private OOFXQBZYQXD? RZFWKJYDADG([In] Id128<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A1B0", Offset = "0x2B591B0", VA = "0x182B5A1B0", Slot = "28")]
		public Id32<YUFXTHDQAZB>? ZMFKUREUZNQ(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B58CA0", Offset = "0x2B57CA0", VA = "0x182B58CA0", Slot = "46")]
		public Id128<YUFXTHDQAZB> SQOXXJSAUOC(Id32<YUFXTHDQAZB> graphId)
		{
			return default(Id128<YUFXTHDQAZB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B59A60", Offset = "0x2B58A60", VA = "0x182B59A60", Slot = "47")]
		public Id128<ISSDUATOTVT> WHTTQUYJVDS(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId)
		{
			return default(Id128<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B538C0", Offset = "0x2B528C0", VA = "0x182B538C0", Slot = "43")]
		public IEnumerable<PJVLKDMUVJA> CIPCGDNGADM(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B593E0", Offset = "0x2B583E0", VA = "0x182B593E0", Slot = "44")]
		public PJVLKDMUVJA VRMKAYHTDRF(RoomVersion a, YKOXFKAMQGI b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B55590", Offset = "0x2B54590", VA = "0x182B55590")]
		public NewStaticEdge HMKFDOPHSZD(Id32<YUFXTHDQAZB> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B54B40", Offset = "0x2B53B40", VA = "0x182B54B40", Slot = "48")]
		public StableStaticEdge EWMNYCSEIMM(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B549F0", Offset = "0x2B539F0", VA = "0x182B549F0", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, MCRZZCNKUJE>> EUBAJMERQWR(Id32<YUFXTHDQAZB> parentGraphId, Id32<ISSDUATOTVT> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B54430", Offset = "0x2B53430", VA = "0x182B54430", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, MCRZZCNKUJE>> DUWQHPPJKYE(Id32<YUFXTHDQAZB> parentGraphId, Id128<ISSDUATOTVT> boardNodeId, List<Id32<ISSDUATOTVT>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B59C50", Offset = "0x2B58C50", VA = "0x182B59C50", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, MCRZZCNKUJE>> XGZXMMJDXWN(Id32<YUFXTHDQAZB> parentGraphId, Id128<ISSDUATOTVT> boardNodeId, List<Id32<ISSDUATOTVT>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B58D50", Offset = "0x2B57D50", VA = "0x182B58D50", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, MCRZZCNKUJE>> SYOJOEMWMLB(Id32<YUFXTHDQAZB> parentGraphId, Id128<ISSDUATOTVT> boardNodeId, Id32<YUFXTHDQAZB> graphId, List<Id32<ISSDUATOTVT>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B546B0", Offset = "0x2B536B0", VA = "0x182B546B0", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<HPGFUJBLNSN>, Id32<FBIPJIAHSMB>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<HPGFUJBLNSN>, Id32<HDSUEKONMVO>)>) EEMONFGMYCM(Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<HPGFUJBLNSN>, Id32<FBIPJIAHSMB>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<HPGFUJBLNSN>, Id32<HDSUEKONMVO>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B55FB0", Offset = "0x2B54FB0", VA = "0x182B55FB0", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task KDYTOYHCPBM(Id128<YUFXTHDQAZB> legacyGraphId, Id128<ISSDUATOTVT> boardNodeId, IReadOnlyList<Id128<ISSDUATOTVT>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<HPGFUJBLNSN>, Id32<FBIPJIAHSMB>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<HPGFUJBLNSN>, Id32<HDSUEKONMVO>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B59C10", Offset = "0x2B58C10", VA = "0x182B59C10", Slot = "55")]
		public bool WQCFQBYWXBQ(Id32<YUFXTHDQAZB> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B59E70", Offset = "0x2B58E70", VA = "0x182B59E70", Slot = "56")]
		public bool YVSMTIFITQW(Id32<YUFXTHDQAZB> graphId, Id32<EXUEQGJGLLV> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B55F10", Offset = "0x2B54F10", VA = "0x182B55F10", Slot = "57")]
		public bool JANCWCOZLPN(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B58830", Offset = "0x2B57830", VA = "0x182B58830")]
		public Result<FZLXAJZQSFG.PrepareTemplateForCloneResult, OVKUTAZGTAB> ZLAGGYJYQZJ([In] FZLXAJZQSFG.PrepareTemplateForCloneArgs args)
		{
			return default(Result<FZLXAJZQSFG.PrepareTemplateForCloneResult, OVKUTAZGTAB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B58EB0", Offset = "0x2B57EB0", VA = "0x182B58EB0", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, MCRZZCNKUJE>> TFLLWOLJBXN(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B535A0", Offset = "0x2B525A0", VA = "0x182B535A0", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<ISSDUATOTVT>, MCRZZCNKUJE>> BJRIDXQCJYO(Id32<YUFXTHDQAZB> graphId, Id32<DQODHRVSODS> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A7B0", Offset = "0x2B597B0", VA = "0x182B5A7B0", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> ZSJCWROFUCH(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B596E0", Offset = "0x2B586E0", VA = "0x182B596E0", Slot = "62")]
		public Result<ControlPanelRootData, YCREHOYWOHO> VUJUIGFNSKD(Id128<YUFXTHDQAZB> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, YCREHOYWOHO>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A650", Offset = "0x2B59650", VA = "0x182B5A650", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, MCRZZCNKUJE>> ZRHQWKZJHKD(Id128<YUFXTHDQAZB> graphId, Id128<ISSDUATOTVT> inputNodeId, Id32<HPGFUJBLNSN> inputPortGroupId, Id32<FBIPJIAHSMB> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B58150", Offset = "0x2B57150", VA = "0x182B58150", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, MCRZZCNKUJE>> PFIQADLAVAS(Id128<YUFXTHDQAZB> graphId, Id128<ISSDUATOTVT> outputNodeId, Id32<HPGFUJBLNSN> outputPortGroupId, Id32<HDSUEKONMVO> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B56A80", Offset = "0x2B55A80", VA = "0x182B56A80", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, MCRZZCNKUJE>> MXLZBYZVNVB(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B59F70", Offset = "0x2B58F70", VA = "0x182B59F70", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<ISSDUATOTVT>>, MCRZZCNKUJE>> ZIOPUHCRYMY(Id128<YUFXTHDQAZB> intoGraphId, CircuitTemplateRootData a, IEnumerable<RWNYJETRKPC> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B587A0", Offset = "0x2B577A0", VA = "0x182B587A0", Slot = "67")]
		public CircuitsData RJSOHIRAETQ()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B55390", Offset = "0x2B54390", VA = "0x182B55390", Slot = "68")]
		public CircuitsData HEJBSSYCDGL()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B582D0", Offset = "0x2B572D0", VA = "0x182B582D0", Slot = "71")]
		public CircuitsTemplateData PJDKXWRAJDC(TemplateSerializationReason a, Id32<YUFXTHDQAZB> sourceGraphId, IEnumerable<Id128<YUFXTHDQAZB>> graphIds, IEnumerable<Id128<ISSDUATOTVT>> nodeIds, ISet<Id128<WIDRWTBBIAB>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B54820", Offset = "0x2B53820", VA = "0x182B54820")]
		private CircuitsTemplateData EPISPMYRHEZ(TemplateSerializationReason a, Id32<YUFXTHDQAZB> sourceGraphId, IEnumerable<Id128<YUFXTHDQAZB>> graphIds, IEnumerable<Id128<ISSDUATOTVT>> nodeIds, ISet<Id128<WIDRWTBBIAB>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B55B80", Offset = "0x2B54B80", VA = "0x182B55B80", Slot = "69")]
		public CircuitsTemplateData IWVGFYSZRSL(TemplateSerializationReason a, Id32<YUFXTHDQAZB> sourceGraphId, IEnumerable<Id128<ISSDUATOTVT>> nodeIds, IEnumerable<RWNYJETRKPC> b, ISet<Id128<WIDRWTBBIAB>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B55DE0", Offset = "0x2B54DE0", VA = "0x182B55DE0", Slot = "70")]
		public CircuitsTemplateData IWVGFYSZRSL(TemplateSerializationReason a, Id32<YUFXTHDQAZB> sourceGraphId, IEnumerable<Id32<ISSDUATOTVT>> nodeIds, IEnumerable<RWNYJETRKPC> b, ISet<Id128<WIDRWTBBIAB>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B539C0", Offset = "0x2B529C0", VA = "0x182B539C0")]
		private static IEnumerable<Id128<YUFXTHDQAZB>> CNIGNPUQWYB(IEnumerable<RWNYJETRKPC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B54DD0", Offset = "0x2B53DD0", VA = "0x182B54DD0")]
		private IEnumerable<Id128<ISSDUATOTVT>> GVVSKJFWBMZ(IEnumerable<RWNYJETRKPC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B53480", Offset = "0x2B52480", VA = "0x182B53480", Slot = "72")]
		public List<FFRJNAJYTGE> BBRCRBMIAYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B56180", Offset = "0x2B55180", VA = "0x182B56180")]
		public (List<FFRJNAJYTGE>, bool) KSFQQEILRIL([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, GUQFFNFRVWI b, HESTTNCLENK c)
		{
			return default((List<FFRJNAJYTGE>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B54CA0", Offset = "0x2B53CA0", VA = "0x182B54CA0", Slot = "74")]
		public bool FSSUZEUGGYG(Id32<YUFXTHDQAZB> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B56BD0", Offset = "0x2B55BD0", VA = "0x182B56BD0", Slot = "75")]
		public bool NPCVVKDYDLO(Id32<YUFXTHDQAZB> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B59C30", Offset = "0x2B58C30", VA = "0x182B59C30")]
		internal void WQOGXJMDANZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B54D90", Offset = "0x2B53D90", VA = "0x182B54D90")]
		internal Task GQPBQWGMCNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B56DA0", Offset = "0x2B55DA0", VA = "0x182B56DA0", Slot = "76")]
		public Result<Id32<METWAAXGTBK>?, MCRZZCNKUJE> OSJKNZAMKVV(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<EXUEQGJGLLV> inputId)
		{
			return default(Result<Id32<METWAAXGTBK>?, MCRZZCNKUJE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B57750", Offset = "0x2B56750", VA = "0x182B57750", Slot = "77")]
		public Result<Id32<EXUEQGJGLLV>?, MCRZZCNKUJE> PAJLMIGRNFR(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<METWAAXGTBK> outputId)
		{
			return default(Result<Id32<EXUEQGJGLLV>?, MCRZZCNKUJE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B56900", Offset = "0x2B55900", VA = "0x182B56900", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, MCRZZCNKUJE>> MAUULLXLYPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B588C0", Offset = "0x2B578C0", VA = "0x182B588C0", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, MCRZZCNKUJE>> SAGDFMQBMSW(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B533C0", Offset = "0x2B523C0", VA = "0x182B533C0", Slot = "80")]
		public Id32<ISSDUATOTVT>? AOMRJPFRXRO(Id32<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B59320", Offset = "0x2B58320", VA = "0x182B59320", Slot = "81")]
		public Id32<ISSDUATOTVT>? VHZTVIJHSKZ(Id32<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B56850", Offset = "0x2B55850", VA = "0x182B56850", Slot = "82")]
		public int LHZQZVKUXVX(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B59E90", Offset = "0x2B58E90", VA = "0x182B59E90", Slot = "83")]
		public int ZCBPOVVSZWK(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A0D0", Offset = "0x2B590D0", VA = "0x182B5A0D0", Slot = "84")]
		public int ZKSKATRKDCX(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<IWUJLJYSQDA> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B534C0", Offset = "0x2B524C0", VA = "0x182B534C0", Slot = "85")]
		public int BJHAEYFPSFH(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<IWUJLJYSQDA> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B53780", Offset = "0x2B52780", VA = "0x182B53780", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, MCRZZCNKUJE>> BUDQXFXHLJX(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<IWUJLJYSQDA> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B56C60", Offset = "0x2B55C60", VA = "0x182B56C60", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, MCRZZCNKUJE>> NWORIVBMZBA(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<IWUJLJYSQDA> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B552D0", Offset = "0x2B542D0", VA = "0x182B552D0", Slot = "88")]
		public int GXIOZUNQNTP(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A510", Offset = "0x2B59510", VA = "0x182B5A510", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, MCRZZCNKUJE>> ZPWAMORUWRB(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B58640", Offset = "0x2B57640", VA = "0x182B58640", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, MCRZZCNKUJE>> QXUZAHWZTAU(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B55420", Offset = "0x2B54420", VA = "0x182B55420", Slot = "91")]
		public bool HIMGUJDNTNX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B59DA0", Offset = "0x2B58DA0", VA = "0x182B59DA0", Slot = "97")]
		public IEnumerable<Id32<QSUPKMQDXBF>> XOIRTZNZHET()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2B53DE0", Offset = "0x2B52DE0", VA = "0x182B53DE0", Slot = "98")]
		public string? CXLNBBFUQFF(Id32<QSUPKMQDXBF> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2B56A10", Offset = "0x2B55A10", VA = "0x182B56A10", Slot = "7")]
		private bool MTPMDBRUQUP(Id32<YUFXTHDQAZB> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2B56820", Offset = "0x2B55820", VA = "0x182B56820", Slot = "24")]
		private OOFXQBZYQXD KTVTIVREFAO([In] Id128<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2B53DB0", Offset = "0x2B52DB0", VA = "0x182B53DB0", Slot = "26")]
		private Id32<YUFXTHDQAZB> FNSJBRJWPML([In] Id128<YUFXTHDQAZB> graphId)
		{
			return default(Id32<YUFXTHDQAZB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2B585A0", Offset = "0x2B575A0", VA = "0x182B585A0", Slot = "27")]
		private Id32<YUFXTHDQAZB>? YMHSBVTTQKL([In] Id128<YUFXTHDQAZB> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2B59A80", Offset = "0x2B58A80", VA = "0x182B59A80", Slot = "29")]
		private SNXISRUYHOD WIXWXHYUFHM([In] Id128<ISSDUATOTVT> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B54120", Offset = "0x2B53120", VA = "0x182B54120", Slot = "31")]
		private Id32<ISSDUATOTVT> QBKGVSOPOYL(Id32<YUFXTHDQAZB> graphId, [In] Id128<ISSDUATOTVT> legacyNodeId)
		{
			return default(Id32<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2B55590", Offset = "0x2B54590", VA = "0x182B55590", Slot = "45")]
		private NewStaticEdge SBCZSNJZFPL(Id32<YUFXTHDQAZB> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2B58830", Offset = "0x2B57830", VA = "0x182B58830", Slot = "58")]
		private Result<FZLXAJZQSFG.PrepareTemplateForCloneResult, OVKUTAZGTAB> RNMXOJGUCET([In] FZLXAJZQSFG.PrepareTemplateForCloneArgs args)
		{
			return default(Result<FZLXAJZQSFG.PrepareTemplateForCloneResult, OVKUTAZGTAB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2B54D30", Offset = "0x2B53D30", VA = "0x182B54D30", Slot = "73")]
		private (List<FFRJNAJYTGE>, bool) GIUXWZFTPBZ([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, GUQFFNFRVWI b, HESTTNCLENK c)
		{
			return default((List<FFRJNAJYTGE>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2B53330", Offset = "0x2B52330", VA = "0x182B53330")]
		[CompilerGenerated]
		private JEWSDYODJBN AGCXOXQNRSQ(EUKWVPLYZVT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2B58FE0", Offset = "0x2B57FE0", VA = "0x182B58FE0")]
		[CompilerGenerated]
		private BNPRQWVLIYC UJXGSGNIDAE(Id128<ISSDUATOTVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2B59010", Offset = "0x2B58010", VA = "0x182B59010")]
		[CompilerGenerated]
		private FDUYIFBBDJV UKCNPNHFMLN(Id128<YUFXTHDQAZB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2B58FE0", Offset = "0x2B57FE0", VA = "0x182B58FE0")]
		[CompilerGenerated]
		private BNPRQWVLIYC THVLIBNMXFK(Id128<ISSDUATOTVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2B59010", Offset = "0x2B58010", VA = "0x182B59010")]
		[CompilerGenerated]
		private FDUYIFBBDJV TIASFIHKGQT(Id128<YUFXTHDQAZB> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class JEWSDYODJBN : PJVLKDMUVJA
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
			public AsyncTaskMethodBuilder<Result<Id32<IWUJLJYSQDA>, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public JEWSDYODJBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<ISSDUATOTVT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<HPGFUJBLNSN> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<IWUJLJYSQDA>, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2B61220", Offset = "0x2B60220", VA = "0x182B61220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2B61470", Offset = "0x2B60470", VA = "0x182B61470", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<RGHHVUNUSGT>, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public JEWSDYODJBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<YUFXTHDQAZB> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<ISSDUATOTVT> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<HPGFUJBLNSN> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<RGHHVUNUSGT>, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x2B614E0", Offset = "0x2B604E0", VA = "0x182B614E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2B61730", Offset = "0x2B60730", VA = "0x182B61730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly EUKWVPLYZVT UQTBIXREUXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly SEQOFYDKXBO MATSITTHXMY;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey KAYJFSSVOYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string MFHOZBZVYOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BA70", Offset = "0x2B5AA70", VA = "0x182B5BA70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public EUKWVPLYZVT EUKWVPLYZVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BD80", Offset = "0x2B5AD80", VA = "0x182B5BD80")]
		public JEWSDYODJBN(EUKWVPLYZVT a, SEQOFYDKXBO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BAA0", Offset = "0x2B5AAA0", VA = "0x182B5BAA0", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<IWUJLJYSQDA>, MCRZZCNKUJE>> MRKZPOVXOLE(Id128<YUFXTHDQAZB> graphId, Id128<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BC10", Offset = "0x2B5AC10", VA = "0x182B5BC10", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<RGHHVUNUSGT>, MCRZZCNKUJE>> NYCFZUVOMJJ(Id128<YUFXTHDQAZB> graphId, Id128<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class JIKNDOHMACZ : KJYDPEYJTPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly EUKWVPLYZVT PYYABSCVHMZ;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<EUKWVPLYZVT> ZUJAFGIQOIB;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<EUKWVPLYZVT> WICWYOCSELM;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<EUKWVPLYZVT> XUOVSWRMSJJ;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public EUKWVPLYZVT AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DC00", Offset = "0x2B5CC00", VA = "0x182B5DC00", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DBF0", Offset = "0x2B5CBF0", VA = "0x182B5DBF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DC50", Offset = "0x2B5CC50", VA = "0x182B5DC50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2B5DB70", Offset = "0x2B5CB70", VA = "0x182B5DB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BFB0", Offset = "0x2B5AFB0", VA = "0x182B5BFB0")]
		public bool YDPNNFVXYAC(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public JIKNDOHMACZ(EUKWVPLYZVT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BE20", Offset = "0x2B5AE20", VA = "0x182B5BE20")]
		internal static TypeKey MDAENLXQVID(EUKWVPLYZVT a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BA70", Offset = "0x2B5AA70", VA = "0x182B5BA70", Slot = "3")]
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
	public readonly struct ActionDeps : DZRBQUPXGSQ.KUIAHXWWOZF<PYPEGOPZPPS, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2B53190", Offset = "0x2B52190", VA = "0x182B53190", Slot = "4")]
		public int KBKRZZJJMWN(None a, PYPEGOPZPPS b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2B531F0", Offset = "0x2B521F0", VA = "0x182B531F0", Slot = "5")]
		public PYPEGOPZPPS NNUKSLXOKOE(None a, PYPEGOPZPPS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2B53240", Offset = "0x2B52240", VA = "0x182B53240", Slot = "6")]
		public PYPEGOPZPPS PGFEOOHFOVJ(None a, PYPEGOPZPPS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2B53270", Offset = "0x2B52270", VA = "0x182B53270", Slot = "7")]
		public IReadOnlyList<PYPEGOPZPPS> PSNLUFMBYVL(None a, PYPEGOPZPPS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2B53160", Offset = "0x2B52160", VA = "0x182B53160", Slot = "8")]
		public PYPEGOPZPPS[] HHITXMVBLEQ(None a, PYPEGOPZPPS b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2B531B0", Offset = "0x2B521B0", VA = "0x182B531B0", Slot = "9")]
		public bool KNMNEJKTNWZ(None a, PYPEGOPZPPS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2B53220", Offset = "0x2B52220", VA = "0x182B53220", Slot = "10")]
		public bool PEPDGBQPMUJ(None a, PYPEGOPZPPS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B53200", Offset = "0x2B52200", VA = "0x182B53200", Slot = "11")]
		public bool OKMIZBGNKEZ(None a, PYPEGOPZPPS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2B53290", Offset = "0x2B52290", VA = "0x182B53290", Slot = "12")]
		public bool YUZUOYQQKPX(None a, PYPEGOPZPPS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2B531D0", Offset = "0x2B521D0", VA = "0x182B531D0", Slot = "13")]
		public bool LJDOULWZRSX(None a, PYPEGOPZPPS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2B53170", Offset = "0x2B52170", VA = "0x182B53170", Slot = "14")]
		public bool JXNJZSVTKXI(None a, PYPEGOPZPPS b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class LQLTSUZKREK : ITTJCCLXRJK
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract VWOBBTEHFZU.UYPXTMTCQYP XXRHGSDVDGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract COWOBFPVIKZ.UYPXTMTCQYP NRNPGXXKVKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract ZJXORRQKNEA.UYPXTMTCQYP BTQPUYQWRZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ> WKZLHXAPLUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E720", Offset = "0x2B5D720", VA = "0x182B5E720", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.UYPXTMTCQYP RPJYXJCXWYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract MTGSWKHGETU KUVBRNXXCXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract RYRAUZOHXNB PTRPROVCCXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract HRTUZVSWSVJ VZLAGHYLIGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract ETFDRUOMIST HJOPHRGSYEW
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract STIVPCHXXDL CHTEPJGYIBK
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected LQLTSUZKREK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class XRVHEIAMIMO : CPXPKKQZVZA
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
			public AsyncTaskMethodBuilder<Result<MultiResult, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<PYPEGOPZPPS> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public XRVHEIAMIMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2B61D50", Offset = "0x2B60D50", VA = "0x182B61D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2B62170", Offset = "0x2B61170", VA = "0x182B62170", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public XRVHEIAMIMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public PYPEGOPZPPS action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x2B66AE0", Offset = "0x2B65AE0", VA = "0x182B66AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2B66CF0", Offset = "0x2B65CF0", VA = "0x182B66CF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly SWFQECRPDPB KTNRGJWMPBX;

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public XRVHEIAMIMO(SWFQECRPDPB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2B67530", Offset = "0x2B66530", VA = "0x182B67530")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, MCRZZCNKUJE>> DCYTPWEWWSH(PYPEGOPZPPS a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2B67660", Offset = "0x2B66660", VA = "0x182B67660", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, MCRZZCNKUJE>> NBFGEEMFFNJ(IReadOnlyList<PYPEGOPZPPS> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PYPEGOPZPPS, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PYPEGOPZPPS, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2B60B30", Offset = "0x2B5FB30", VA = "0x182B60B30")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class TFOROOXXYBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PYPEGOPZPPS, PartialActionReassemblyDeps> FMNARAWZCCY(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PYPEGOPZPPS, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : GIJANZXYKKQ.IULAIVKNAGW<PartialActionPayload, Id128<PartialActionPayload.M>, PYPEGOPZPPS>
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2B60940", Offset = "0x2B5F940", VA = "0x182B60940", Slot = "7")]
		public PYPEGOPZPPS HIEOUGRGTSE(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x12B0130", Offset = "0x12AF130", VA = "0x1812B0130")]
		public Id128<PartialActionPayload.M> CHVKKTAODFU([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x1033BC0", Offset = "0x1032BC0", VA = "0x181033BC0")]
		public int GYOZEDVJTHM([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2B60930", Offset = "0x2B5F930", VA = "0x182B60930")]
		public int XZQZKIMCQZL([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x1033BC0", Offset = "0x1032BC0", VA = "0x181033BC0", Slot = "4")]
		private int OSULPTDSVBI([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2B60930", Offset = "0x2B5F930", VA = "0x182B60930", Slot = "5")]
		private int GGKZQRRPXVP([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x12B0130", Offset = "0x12AF130", VA = "0x1812B0130", Slot = "6")]
		private Id128<PartialActionPayload.M> LZPCWWHSZLA([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, PYPEGOPZPPS, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, PYPEGOPZPPS, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B611C0", Offset = "0x2B601C0", VA = "0x182B611C0")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class RLKVXOOMJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0")]
		public static SnapshotReassembly<PartialInitializePayload, PYPEGOPZPPS, SnapshotReassemblyDeps> FMNARAWZCCY(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, PYPEGOPZPPS, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : LZLNHQMZWLV.IUQHGCEKJSF<PartialInitializePayload, PYPEGOPZPPS>
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x1033BD0", Offset = "0x1032BD0", VA = "0x181033BD0")]
		public int DEKSYBOWVWA([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B60FD0", Offset = "0x2B5FFD0", VA = "0x182B60FD0", Slot = "5")]
		public PYPEGOPZPPS YLDXUMMOOWC(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x1033BD0", Offset = "0x1032BD0", VA = "0x181033BD0", Slot = "4")]
		private int NEAKISZQPZC([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class JJJNSRGIZIC : SIEDSHFPKXL, OVKUTAZGTAB, MCRZZCNKUJE, YCREHOYWOHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly YCREHOYWOHO? NBZMAFKIRGQ;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind BWQZNOWSFXG
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xD031D0", Offset = "0xD021D0", VA = "0x180D031D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override YCREHOYWOHO? DNPGFVWJPPD
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DDD0", Offset = "0x2B5CDD0", VA = "0x182B5DDD0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DFA0", Offset = "0x2B5CFA0", VA = "0x182B5DFA0")]
		private JJJNSRGIZIC(PrepareTemplateForCloneErrKind a, YCREHOYWOHO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DF30", Offset = "0x2B5CF30", VA = "0x182B5DF30")]
		public static JJJNSRGIZIC VSGBDMJVRQS(YCREHOYWOHO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DED0", Offset = "0x2B5CED0", VA = "0x182B5DED0")]
		public static JJJNSRGIZIC EDYQHWBBDUI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DD70", Offset = "0x2B5CD70", VA = "0x182B5DD70")]
		public static JJJNSRGIZIC CRPVDHVTHEC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class SYSVYTEKISR
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x3EF81D0", Offset = "0x3EF71D0", VA = "0x183EF81D0")]
		public static Result<TOk, OVKUTAZGTAB> HAQHKRSKLBF<TOk>([In] this Result<TOk, OVKUTAZGTAB> self, YCREHOYWOHO a) where TOk : notnull
		{
			return default(Result<TOk, OVKUTAZGTAB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8410", Offset = "0x3EF7410", VA = "0x183EF8410")]
		public static Result<a?, OVKUTAZGTAB?> KXQDBXRPWPZ<a>([In] this Result<a, OVKUTAZGTAB> self)
		{
			return default(Result<a, OVKUTAZGTAB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8150", Offset = "0x3EF7150", VA = "0x183EF8150")]
		public static Result<b?, OVKUTAZGTAB?> ASISYFNIZCZ<b>([In] this Result<b, OVKUTAZGTAB> self)
		{
			return default(Result<b, OVKUTAZGTAB>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface MTGSWKHGETU
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VAWKBDYBCOK([In] Result<None, YCREHOYWOHO> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class TXLFSIVIINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x3F3DAE0", Offset = "0x3F3CAE0", VA = "0x183F3DAE0")]
		public static bool VAWKBDYBCOK<TOk, TErr>(this MTGSWKHGETU a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, YCREHOYWOHO
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface RYRAUZOHXNB
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		CICCQXNQDHP PPGJETOORYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface HRTUZVSWSVJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor SNWDDBRWGXA(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface QPIRMGDFYVU
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface TZDJKXENXJH
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WVZPDQMZUFP? MYJDHSVPMSK(Id32<HPGFUJBLNSN> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface POGDKIMLVLV
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface WVZPDQMZUFP
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		POGDKIMLVLV? IBPEDXMKNNO(Id32<IWUJLJYSQDA> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		QPIRMGDFYVU? QDZIQJOVBBJ(Id32<RGHHVUNUSGT> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface ETFDRUOMIST
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> WTJEPKNKJBJ(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface STIVPCHXXDL
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TZDJKXENXJH? YXFGZREAJFW([In] Id128<ATOQASVPSNP> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class KOPLBQQPIWU
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
			public readonly List<PYPEGOPZPPS> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B5AE70", Offset = "0x2B59E70", VA = "0x182B5AE70")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<PYPEGOPZPPS> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2B5ADC0", Offset = "0x2B59DC0", VA = "0x182B5ADC0")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly FFHSPXYHDRT<Diagnostic> JDSOVLLJFCG;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static KOPLBQQPIWU CIARLSLMHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E540", Offset = "0x2B5D540", VA = "0x182B5E540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool MLMZUMRDZUA
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xD4AD80", Offset = "0xD49D80", VA = "0x180D4AD80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xE0C750", Offset = "0xE0B750", VA = "0x180E0C750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E1A0", Offset = "0x2B5D1A0", VA = "0x182B5E1A0")]
		public void JDILBSPLLOX(SEQOFYDKXBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E260", Offset = "0x2B5D260", VA = "0x182B5E260")]
		public void NFBDKYAHZRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DFE0", Offset = "0x2B5CFE0", VA = "0x182B5DFE0")]
		private static string? GOPQKBCRFGA([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E680", Offset = "0x2B5D680", VA = "0x182B5E680")]
		public KOPLBQQPIWU()
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
