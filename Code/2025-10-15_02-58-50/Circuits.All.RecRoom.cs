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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AB8640", Offset = "0x2AB7440", VA = "0x182AB8640")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AB66C0", Offset = "0x2AB54C0", VA = "0x182AB66C0", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class RGZHVGRSJVI : IDisposable, RUBLDTSGSLZ, LCSAJRMLRRQ, WOFMJWUENVV
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class XZYTPGYTANL : XQEIROEEFNO
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int NVRXHSLURFH
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2AD0300", Offset = "0x2ACF100", VA = "0x182AD0300", Slot = "5")]
			public YLCKUADMMIO LOCWXVVXXZL(IYEHCMGHYUZ.XQEIROEEFNO a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void ULQWPKIHUFZ();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void SISLSPZBEQO();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2AA61C0", Offset = "0x2AA4FC0", VA = "0x182AA61C0", Slot = "13")]
			public virtual void ZXNAZMLQOPY(RGZHVGRSJVI a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2AD0430", Offset = "0x2ACF230", VA = "0x182AD0430", Slot = "14")]
			public virtual void LUOTZGKBHFN(RGZHVGRSJVI a, ELPAQFNEADX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			protected XZYTPGYTANL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface XQEIROEEFNO
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int NVRXHSLURFH
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			YLCKUADMMIO LOCWXVVXXZL(IYEHCMGHYUZ.XQEIROEEFNO a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void ULQWPKIHUFZ();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void SISLSPZBEQO();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ZXNAZMLQOPY(RGZHVGRSJVI a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void LUOTZGKBHFN(RGZHVGRSJVI a, ELPAQFNEADX b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, ELPAQFNEADX, RGZHVGRSJVI, MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1313220", Offset = "0x1312020", VA = "0x181313220")]
			internal Reducer(Reducer<ActionKind, ELPAQFNEADX, RGZHVGRSJVI, MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class QBILVALNXRF : MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly QBILVALNXRF VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private QBILVALNXRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCB6160", Offset = "0xCB4F60", VA = "0x180CB6160", Slot = "4")]
			public ActionKind IAQCFCOSJKH(ELPAQFNEADX a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3E80", Offset = "0x2AC2C80", VA = "0x182AC3E80", Slot = "5")]
			public void ZXNAZMLQOPY(RGZHVGRSJVI a, ELPAQFNEADX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3D70", Offset = "0x2AC2B70", VA = "0x182AC3D70", Slot = "6")]
			public void LUOTZGKBHFN(RGZHVGRSJVI a, ELPAQFNEADX b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, ELPAQFNEADX, RGZHVGRSJVI, MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2AC58F0", Offset = "0x2AC46F0", VA = "0x182AC58F0")]
			internal ReducerFactory(ReducerFactory<ActionKind, ELPAQFNEADX, RGZHVGRSJVI, MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2AC58A0", Offset = "0x2AC46A0", VA = "0x182AC58A0")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : ELLZGADELWZ.HXNLCVOFITR<ELPAQFNEADX, RGZHVGRSJVI>
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
				public AsyncTaskMethodBuilder<Result<object?, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public RGZHVGRSJVI receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public ELPAQFNEADX action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6CC0", Offset = "0x2AC5AC0", VA = "0x182AC6CC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6EA0", Offset = "0x2AC5CA0", VA = "0x182AC6EA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAFDB50", Offset = "0xAFC950", VA = "0x180AFDB50", Slot = "4")]
			public Id32<VCZWSUVCRXV> ZGGAKUMPZGY(RGZHVGRSJVI a)
			{
				return default(Id32<VCZWSUVCRXV>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5BA0", Offset = "0x2AC49A0", VA = "0x182AC5BA0", Slot = "5")]
			public void RTNXGYXZNRB(RGZHVGRSJVI a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5C00", Offset = "0x2AC4A00", VA = "0x182AC5C00", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, SJKUUBAWOPB>> VEKDJDGRJDM(RGZHVGRSJVI a, ELPAQFNEADX b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5B80", Offset = "0x2AC4980", VA = "0x182AC5B80", Slot = "7")]
			public ELPAQFNEADX[] GOFQFNQLQIQ(RGZHVGRSJVI a)
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
			public AsyncTaskMethodBuilder<Result<object?, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public RGZHVGRSJVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public ELPAQFNEADX action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6F10", Offset = "0x2AC5D10", VA = "0x182AC6F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7100", Offset = "0x2AC5F00", VA = "0x182AC7100", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public RGZHVGRSJVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8640", Offset = "0x2AC7440", VA = "0x182AC8640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2AC88C0", Offset = "0x2AC76C0", VA = "0x182AC88C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public RGZHVGRSJVI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8930", Offset = "0x2AC7730", VA = "0x182AC8930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8B10", Offset = "0x2AC7910", VA = "0x182AC8B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<VCZWSUVCRXV> QMWRLZSRXEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer OXBFENMEDAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 RHKOHZHXMYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EA8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly RAMVABNVEDJ SYMZGOAQBSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EB0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly QJDKMJZUZXH.CreationArgs OQUSDZUBZPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly LMRHUQRSYTE QNQTMULBLOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly LUPUFDLXTXH JTSXILBKZJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly SSANEMPSJGO UYKTYEPXSID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly QXGRLLVAXUP ASKSJWGDXMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly GORZCVDQGOR GQGKUJJMKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly LVXXCXLQGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly YSZDSNIOTMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest VSPYXMOBVRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended YKWXAOLSSQE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal XQEIROEEFNO PBOJXVPDXRN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4CE0", Offset = "0x2AC3AE0", VA = "0x182AC4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal YLCKUADMMIO AEFOUZDMJOR
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4350", Offset = "0x2AC3150", VA = "0x182AC4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC45C0", Offset = "0x2AC33C0", VA = "0x182AC45C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool QFWAQTPWMJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2AC52C0", Offset = "0x2AC40C0", VA = "0x182AC52C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2AC47C0", Offset = "0x2AC35C0", VA = "0x182AC47C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OGAIGSYHLWZ LMRHUQRSYTE
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5780", Offset = "0x2AC4580", VA = "0x182AC5780", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public VITTVEGHMGL SSANEMPSJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5790", Offset = "0x2AC4590", VA = "0x182AC5790", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MZVNUTHPWMY GORZCVDQGOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2AC57B0", Offset = "0x2AC45B0", VA = "0x182AC57B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FBGAYSQSFLW LUPUFDLXTXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5480", Offset = "0x2AC4280", VA = "0x182AC5480", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GQQKYERGYSM QXGRLLVAXUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2AC57A0", Offset = "0x2AC45A0", VA = "0x182AC57A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public QJDKMJZUZXH? QJDKMJZUZXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2AC44D0", Offset = "0x2AC32D0", VA = "0x182AC44D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5490", Offset = "0x2AC4290", VA = "0x182AC5490")]
		private RGZHVGRSJVI(RAMVABNVEDJ a, Id32<VCZWSUVCRXV> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, YLCKUADMMIO b, [In] QJDKMJZUZXH.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2AC51F0", Offset = "0x2AC3FF0", VA = "0x182AC51F0")]
		public static RGZHVGRSJVI New(RAMVABNVEDJ deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<VCZWSUVCRXV> actorId, Id32<FQTHCTXUYZW> rootNetworkObjectId, SVBMWMSSDIU staticNetSys, REYULGVCMLG dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4F30", Offset = "0x2AC3D30", VA = "0x182AC4F30")]
		public static RGZHVGRSJVI New(RAMVABNVEDJ dependencies, [In] RegistryV2 registryV2, Id32<VCZWSUVCRXV> actorId, Id32<FQTHCTXUYZW> rootNetworkObjectId, SVBMWMSSDIU staticNetSys, REYULGVCMLG dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2AC45E0", Offset = "0x2AC33E0", VA = "0x182AC45E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5320", Offset = "0x2AC4120", VA = "0x182AC5320")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, SJKUUBAWOPB>> SCSEQWRIMGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2AC43E0", Offset = "0x2AC31E0", VA = "0x182AC43E0")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, SJKUUBAWOPB>> BXGWJYCJGJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4D30", Offset = "0x2AC3B30", VA = "0x182AC4D30")]
		internal void KMFRHQQJYQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4360", Offset = "0x2AC3160", VA = "0x182AC4360")]
		internal Option<ELPAQFNEADX> BXDLGVXCGDF([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<ELPAQFNEADX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5410", Offset = "0x2AC4210", VA = "0x182AC5410")]
		internal bool VZUTOONAWTW([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC41C0", Offset = "0x2AC2FC0", VA = "0x182AC41C0")]
		internal Result<ELPAQFNEADX, SJKUUBAWOPB> BFBAODDNTHF([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<ELPAQFNEADX, SJKUUBAWOPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC52D0", Offset = "0x2AC40D0", VA = "0x182AC52D0")]
		private void RTNXGYXZNRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC47D0", Offset = "0x2AC35D0", VA = "0x182AC47D0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, SJKUUBAWOPB>> FGFOXRDNVMX(ELPAQFNEADX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC48E0", Offset = "0x2AC36E0", VA = "0x182AC48E0")]
		private ELPAQFNEADX[] GOFQFNQLQIQ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class SUNCTKQPYBE<a> : NLAHVKALZBM, AERBGWCCHDS, HEYQXAVABBH where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<LQPAJNJDNAW>? YIVWDYURFWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string SZNTBOUKDVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a JGQJHTLYZSP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<LQPAJNJDNAW>? QXAJBYVDJGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4D80", Offset = "0x2DA3B80", VA = "0x182DA4D80", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAA2210", Offset = "0xAA1010", VA = "0x180AA2210", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x600A7E0", Offset = "0x60095E0", VA = "0x18600A7E0")]
		internal SUNCTKQPYBE([In] Id128<LQPAJNJDNAW>? lastNode, Id32<CLCEYSQWERP>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ZJRGVZZYCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD18E0", Offset = "0x2AD06E0", VA = "0x182AD18E0")]
		public static Result<DebugExecutionResult, AERBGWCCHDS> TSDPRQDPQSD([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, AERBGWCCHDS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB3A0", Offset = "0x3EFA1A0", VA = "0x183EFB3A0")]
		public static Result<TOk, AERBGWCCHDS> WDNCVBNLXWR<TOk>([In] this Result<TOk, AERBGWCCHDS> self, [In] Id128<LQPAJNJDNAW>? lastNode, Id32<CLCEYSQWERP>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, AERBGWCCHDS>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface RAMVABNVEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		IYEHCMGHYUZ.XQEIROEEFNO UGWZVGLBOID
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		RGZHVGRSJVI.XQEIROEEFNO FKKGLUKMDTW
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		HHBELIZAZTL.XQEIROEEFNO NJIXVJOPWFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI> QBILVALNXRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.XQEIROEEFNO IWVMVGFINXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		HBKJLPUCFON RGEYZGDJYUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		YTSHAVYTUSY HAFZOOZMFCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		SKHEHGRSHLY PERFJBHOVYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		ZPSEWEXFJLQ VOHNTVXESAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		EAPBZKKMHYU TNXCLFCQOXN
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
	public static class IRIVFZQDRXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4930", Offset = "0x2AB3730", VA = "0x182AB4930")]
		public static ELPAQFNEADX ZEPCZEKEFAX(this ELPAQFNEADX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4860", Offset = "0x2AB3660", VA = "0x182AB4860")]
		public static ELPAQFNEADX WMGSBZSEGYI(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public RGZHVGRSJVI root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7170", Offset = "0x2AC5F70", VA = "0x182AC7170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC78A0", Offset = "0x2AC66A0", VA = "0x182AC78A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1350", Offset = "0x2AB0150", VA = "0x182AB1350")]
		public static ELPAQFNEADX MDIOXHHQYTX(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1410", Offset = "0x2AB0210", VA = "0x182AB1410")]
		public static ReduceAction<ActionKind, CompressedPayload> RTKBFZYSAJG(ELPAQFNEADX actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1240", Offset = "0x2AB0040", VA = "0x182AB1240")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, SJKUUBAWOPB>> FGFOXRDNVMX(RGZHVGRSJVI a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2AB14C0", Offset = "0x2AB02C0", VA = "0x182AB14C0")]
		public static ELPAQFNEADX MDIOXHHQYTX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1560", Offset = "0x2AB0360", VA = "0x182AB1560")]
		public static ReduceAction<ActionKind, DestroyPayload> RTKBFZYSAJG(ELPAQFNEADX actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2AB15D0", Offset = "0x2AB03D0", VA = "0x182AB15D0")]
		public static Result<None, LPRGMGAIUGA> ZAIQDFEHJGJ(RGZHVGRSJVI a, [In] DestroyPayload self)
		{
			return default(Result<None, LPRGMGAIUGA>);
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
			public AsyncTaskMethodBuilder<Result<None, LPRGMGAIUGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RGZHVGRSJVI root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, LPRGMGAIUGA> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7980", Offset = "0x2AC6780", VA = "0x182AC7980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7F20", Offset = "0x2AC6D20", VA = "0x182AC7F20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EB0540", Offset = "0x1EAF340", VA = "0x181EB0540")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2AB37F0", Offset = "0x2AB25F0", VA = "0x182AB37F0")]
		public static ELPAQFNEADX? MDIOXHHQYTX(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2AB38F0", Offset = "0x2AB26F0", VA = "0x182AB38F0")]
		public static ReduceAction<ActionKind, FullInitializePayload> RTKBFZYSAJG(ELPAQFNEADX actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2AB36B0", Offset = "0x2AB24B0", VA = "0x182AB36B0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, LPRGMGAIUGA>> FGFOXRDNVMX(RGZHVGRSJVI a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public RGZHVGRSJVI root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, SJKUUBAWOPB> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, HEYQXAVABBH>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, HEYQXAVABBH> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, HEYQXAVABBH>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7430", Offset = "0x2AC6230", VA = "0x182AC7430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7910", Offset = "0x2AC6710", VA = "0x182AC7910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<ELPAQFNEADX> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		private MultiPayload(IReadOnlyList<ELPAQFNEADX> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8410", Offset = "0x2AB7210", VA = "0x182AB8410")]
		public static ELPAQFNEADX MDIOXHHQYTX(IReadOnlyList<ELPAQFNEADX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB84D0", Offset = "0x2AB72D0", VA = "0x182AB84D0")]
		public static ReduceAction<ActionKind, MultiPayload> RTKBFZYSAJG(ELPAQFNEADX actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB82D0", Offset = "0x2AB70D0", VA = "0x182AB82D0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, SJKUUBAWOPB>> FGFOXRDNVMX(RGZHVGRSJVI a, MultiPayload b)
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
		private sealed class CORIYCNATUY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> WNIOIQHMGUA;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public CORIYCNATUY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2AB10D0", Offset = "0x2AAFED0", VA = "0x182AB10D0")]
			internal ELPAQFNEADX UZTNIPDNEFS(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x2AC3860", Offset = "0x2AC2660", VA = "0x182AC3860")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3360", Offset = "0x2AC2160", VA = "0x182AC3360")]
		public static ELPAQFNEADX MDIOXHHQYTX(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2AC35C0", Offset = "0x2AC23C0", VA = "0x182AC35C0")]
		public static ELPAQFNEADX[] YPCCFSTNEMU(ELPAQFNEADX a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3470", Offset = "0x2AC2270", VA = "0x182AC3470")]
		public static ReduceAction<ActionKind, PartialActionPayload> RTKBFZYSAJG(ELPAQFNEADX actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2AC36C0", Offset = "0x2AC24C0", VA = "0x182AC36C0")]
		public static Result<ELPAQFNEADX, SJKUUBAWOPB> ZAIQDFEHJGJ(RGZHVGRSJVI a, [In] PartialActionPayload self)
		{
			return default(Result<ELPAQFNEADX, SJKUUBAWOPB>);
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
			public AsyncTaskMethodBuilder<Result<bool, LPRGMGAIUGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public RGZHVGRSJVI root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, LPRGMGAIUGA> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, LPRGMGAIUGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7F90", Offset = "0x2AC6D90", VA = "0x182AC7F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC85D0", Offset = "0x2AC73D0", VA = "0x182AC85D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xE0A4F0", Offset = "0xE092F0", VA = "0x180E0A4F0")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2AC39B0", Offset = "0x2AC27B0", VA = "0x182AC39B0")]
		public static ELPAQFNEADX MDIOXHHQYTX(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3A90", Offset = "0x2AC2890", VA = "0x182AC3A90")]
		public static ELPAQFNEADX?[]? QJNQIBOZKNQ(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3C90", Offset = "0x2AC2A90", VA = "0x182AC3C90")]
		public static ReduceAction<ActionKind, PartialInitializePayload> RTKBFZYSAJG(ELPAQFNEADX actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3880", Offset = "0x2AC2680", VA = "0x182AC3880")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, LPRGMGAIUGA>> FGFOXRDNVMX(RGZHVGRSJVI a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class LMRHUQRSYTE : OGAIGSYHLWZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly RGZHVGRSJVI XTDGCADPGFN;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public QNQMXIRQSJE? VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2AB65B0", Offset = "0x2AB53B0", VA = "0x182AB65B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		internal LMRHUQRSYTE(RGZHVGRSJVI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class YLUNAYITVRH : QNQMXIRQSJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly RGZHVGRSJVI XTDGCADPGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly QJDKMJZUZXH RGDFIMVWSGB;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAA5770", Offset = "0xAA4570", VA = "0x180AA5770")]
		public YLUNAYITVRH(RGZHVGRSJVI a, QJDKMJZUZXH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0D80", Offset = "0x2ACFB80", VA = "0x182AD0D80", Slot = "4")]
		public Result<DebugExecutionResult, AERBGWCCHDS> ENJSBBTJGTL(Id128<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId, Id32<SYBOCFQCTDO> inputId)
		{
			return default(Result<DebugExecutionResult, AERBGWCCHDS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2AD1330", Offset = "0x2AD0130", VA = "0x182AD1330", Slot = "5")]
		public Result<DebugExecutionResult, AERBGWCCHDS> XNCTOYRCPBK(Id128<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId, Id32<SFFGLAFZKMT> outputId)
		{
			return default(Result<DebugExecutionResult, AERBGWCCHDS>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class IYEHCMGHYUZ : YLCKUADMMIO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface XQEIROEEFNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<TCDWQQVTIFG> RYUTOFKJKNL(RGZHVGRSJVI a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class XZYTPGYTANL : XQEIROEEFNO
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
				public AsyncTaskMethodBuilder<TCDWQQVTIFG> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public RGZHVGRSJVI circuitsManager;

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
				private TaskAwaiter<HHBELIZAZTL> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2AC62A0", Offset = "0x2AC50A0", VA = "0x182AC62A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2AC6470", Offset = "0x2AC5270", VA = "0x182AC6470", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2AD04B0", Offset = "0x2ACF2B0", VA = "0x182AD04B0", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<TCDWQQVTIFG> RYUTOFKJKNL(RGZHVGRSJVI a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			protected XZYTPGYTANL()
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
			public AsyncTaskMethodBuilder<TCDWQQVTIFG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public IYEHCMGHYUZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC64E0", Offset = "0x2AC52E0", VA = "0x182AC64E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2AC66E0", Offset = "0x2AC54E0", VA = "0x182AC66E0", Slot = "5")]
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
			public IYEHCMGHYUZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public RGZHVGRSJVI circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<TCDWQQVTIFG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6750", Offset = "0x2AC5550", VA = "0x182AC6750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6C60", Offset = "0x2AC5A60", VA = "0x182AC6C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly XQEIROEEFNO RHEDUJJJYXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> RBVHRGMDOTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> UJIGVJLHXDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource WYQUZJADQLY;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool QFWAQTPWMJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB009E0", Offset = "0xAFF7E0", VA = "0x180B009E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB01120", Offset = "0xAFFF20", VA = "0x180B01120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xFBD570", Offset = "0xFBC370", VA = "0x180FBD570", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x100A770", Offset = "0x1009570", VA = "0x18100A770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool NKYMQXRCWKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1B3F390", Offset = "0x1B3E190", VA = "0x181B3F390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1B3F3A0", Offset = "0x1B3E1A0", VA = "0x181B3F3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public TCDWQQVTIFG? VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BF0", Offset = "0xA9F9F0", VA = "0x180AA0BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4CF0", Offset = "0x2AB3AF0", VA = "0x182AB4CF0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<TCDWQQVTIFG> ZMTEENDRIWW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4DE0", Offset = "0x2AB3BE0", VA = "0x182AB4DE0")]
		public IYEHCMGHYUZ(XQEIROEEFNO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4BB0", Offset = "0x2AB39B0", VA = "0x182AB4BB0", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task RIFZHRTMBBB(RGZHVGRSJVI a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4A40", Offset = "0x2AB3840", VA = "0x182AB4A40", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class GVCOPHKPTHO : EQENIZAUNXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly AISMQWVGLVE TOIXDBXOIGN;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public GVCOPHKPTHO(AISMQWVGLVE a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class OMPJGZUPGOL
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class XODRGJIVVRJ<a> : RDNXSUMSJLC where a : MKQIQLGMGLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a HPJGKCEVLUY;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? GIHCUNFMLNM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0xF730D0", Offset = "0xF71ED0", VA = "0x180F730D0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<LQPAJNJDNAW>? HJWUZPMSHXQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x409D790", Offset = "0x409C590", VA = "0x18409D790", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<TROAQNNIZMC> TLMCRDJZEWE
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DA10", Offset = "0x2D9C810", VA = "0x182D9DA10", Slot = "5")]
				get
				{
					return default(Id32<TROAQNNIZMC>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<TROAQNNIZMC>? XREUZKVGACE
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x409D840", Offset = "0x409C640", VA = "0x18409D840", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
			public XODRGJIVVRJ(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class NOGAOYCQCXB : XODRGJIVVRJ<MPGRWGHBTDR>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? GIHCUNFMLNM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x1097570", Offset = "0x1096370", VA = "0x181097570", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8570", Offset = "0x2AB7370", VA = "0x182AB8570")]
			public NOGAOYCQCXB(MPGRWGHBTDR a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC31A0", Offset = "0x2AC1FA0", VA = "0x182AC31A0")]
		public static RDNXSUMSJLC New(MKQIQLGMGLA graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class VMIPVXRPZKX : VUSRKGTDCLQ, CWZUZWKZEGA, BSZEZNSGOWH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class QOHUNNMLAFT
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
				public QOHUNNMLAFT <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public HBKJLPUCFON errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x2AC9D20", Offset = "0x2AC8B20", VA = "0x182AC9D20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x2AC9F90", Offset = "0x2AC8D90", VA = "0x182AC9F90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public VMIPVXRPZKX SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool IEYQMEXZWTG;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public QOHUNNMLAFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4000", Offset = "0x2AC2E00", VA = "0x182AC4000")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task XZIDKKYXCMR(HBKJLPUCFON a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ZXGVHKFDNKZ
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
				public ZXGVHKFDNKZ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x2AC9FF0", Offset = "0x2AC8DF0", VA = "0x182AC9FF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x2ACA2D0", Offset = "0x2AC90D0", VA = "0x182ACA2D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public VMIPVXRPZKX SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int IEYQMEXZWTG;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public ZXGVHKFDNKZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2AD1D80", Offset = "0x2AD0B80", VA = "0x182AD1D80")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task EITZECPKOQH(HBKJLPUCFON a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class VLCVATRSNWU
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
				public VLCVATRSNWU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x2ACA840", Offset = "0x2AC9640", VA = "0x182ACA840", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x2ACACF0", Offset = "0x2AC9AF0", VA = "0x182ACACF0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string IEYQMEXZWTG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public VMIPVXRPZKX SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int GQOSUZHKZWA;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public VLCVATRSNWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2ACC0F0", Offset = "0x2ACAEF0", VA = "0x182ACC0F0")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task FHPMRNAJCON(HBKJLPUCFON a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class QRQYUPAEHYD
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
				public QRQYUPAEHYD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x2ACA330", Offset = "0x2AC9130", VA = "0x182ACA330", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x2ACA7E0", Offset = "0x2AC95E0", VA = "0x182ACA7E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string IEYQMEXZWTG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public VMIPVXRPZKX SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int GQOSUZHKZWA;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public QRQYUPAEHYD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2AC40F0", Offset = "0x2AC2EF0", VA = "0x182AC40F0")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task ZSAYUCTBGEB(HBKJLPUCFON a)
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
			public VMIPVXRPZKX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8B80", Offset = "0x2AC7980", VA = "0x182AC8B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2AC9090", Offset = "0x2AC7E90", VA = "0x182AC9090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly MCRKWYVOTDU TIVDREDCGPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<BDPCESYNIZC> IAXYCGIYRAB;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private RAMVABNVEDJ XZYTPGYTANL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2ACD930", Offset = "0x2ACC730", VA = "0x182ACD930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<SYBOCFQCTDO> VHUHCVDVBSP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xE759C0", Offset = "0xE747C0", VA = "0x180E759C0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<SYBOCFQCTDO>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xF79190", Offset = "0xF77F90", VA = "0x180F79190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<ENGFBJMMTKB> TDKBWONNOYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AAC0", Offset = "0x2A498C0", VA = "0x182A4AAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<WFLMXHQDTIG> IYPHROQZZZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x12D31D0", Offset = "0x12D1FD0", VA = "0x1812D31D0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<WFLMXHQDTIG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<CLCEYSQWERP> KLLHKXMCDBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2ACD950", Offset = "0x2ACC750", VA = "0x182ACD950", Slot = "22")]
			get
			{
				return default(Id32<CLCEYSQWERP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool VGXAXKTETFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2ACFFF0", Offset = "0x2ACEDF0", VA = "0x182ACFFF0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AD0070", Offset = "0x2ACEE70", VA = "0x182AD0070")]
		private VMIPVXRPZKX(RGZHVGRSJVI a, ITZFJUYYDSP b, MCRKWYVOTDU c, Id32<TOCKAIBKNWY> portGroupId, Id32<SYBOCFQCTDO> inputId, Id32<ENGFBJMMTKB> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDD70", Offset = "0x2ACCB70", VA = "0x182ACDD70")]
		public static VMIPVXRPZKX New(RGZHVGRSJVI circuitsManager, ITZFJUYYDSP node, MCRKWYVOTDU input, Id32<TOCKAIBKNWY> portGroupId, Id32<ENGFBJMMTKB> inputDefId, Id32<SYBOCFQCTDO> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACCE70", Offset = "0x2ACBC70", VA = "0x182ACCE70", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC7A0", Offset = "0x2ACB5A0", VA = "0x182ACC7A0", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC990", Offset = "0x2ACB790", VA = "0x182ACC990", Slot = "32")]
		public void GGYLTXJBUZU(BDPCESYNIZC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD570", Offset = "0x2ACC370", VA = "0x182ACD570", Slot = "29")]
		public void JZZJBLCFCUN(WLBBGWRYRTG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF040", Offset = "0x2ACDE40", VA = "0x182ACF040", Slot = "30")]
		public void YHLMVRUSNOI(XKZFFSFQQNM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEA20", Offset = "0x2ACD820", VA = "0x182ACEA20", Slot = "25")]
		protected override void UCXDLGSCNTE(LXWGCYDHMCB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE120", Offset = "0x2ACCF20", VA = "0x182ACE120", Slot = "34")]
		public string OKJFOESJEWP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC9F0", Offset = "0x2ACB7F0", VA = "0x182ACC9F0", Slot = "31")]
		public string GVZOQERRNXP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC1C0", Offset = "0x2ACAFC0", VA = "0x182ACC1C0")]
		private void AFXYWEIFQIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD420", Offset = "0x2ACC220", VA = "0x182ACD420", Slot = "33")]
		public void JXTDDNAHKHP(BDPCESYNIZC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE6A0", Offset = "0x2ACD4A0", VA = "0x182ACE6A0")]
		private void RKNBVPQLLCK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD230", Offset = "0x2ACC030", VA = "0x182ACD230", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task JWYSULTELNU(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC840", Offset = "0x2ACB640", VA = "0x182ACC840")]
		public void FHYOYYPYPRJ(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC3F0", Offset = "0x2ACB1F0", VA = "0x182ACC3F0")]
		private void APEVEYYIKWH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE860", Offset = "0x2ACD660", VA = "0x182ACE860")]
		private void SVGODRGNMCH(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACCCB0", Offset = "0x2ACBAB0", VA = "0x182ACCCB0")]
		private void HLAJJLAJHYY(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC590", Offset = "0x2ACB390", VA = "0x182ACC590")]
		private string DDPRUAJXVML(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEED0", Offset = "0x2ACDCD0", VA = "0x182ACEED0")]
		private string WQWCEKQYDZY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF79190", Offset = "0xF77F90", VA = "0x180F79190")]
		internal void DNWKMTLSUKB(Id32<SYBOCFQCTDO> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDA60", Offset = "0x2ACC860", VA = "0x182ACDA60")]
		[CompilerGenerated]
		private void LYIOUSMEDBA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDA70", Offset = "0x2ACC870", VA = "0x182ACDA70")]
		[CompilerGenerated]
		private bool LYNVRZGBMMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD9A0", Offset = "0x2ACC7A0", VA = "0x182ACD9A0")]
		[CompilerGenerated]
		private bool LYDHXLSGTPR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD130", Offset = "0x2ACBF30", VA = "0x182ACD130")]
		[CompilerGenerated]
		private int LZDQJTNTOUK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDC00", Offset = "0x2ACCA00", VA = "0x182ACDC00")]
		[CompilerGenerated]
		private bool LZIXHAHQYFT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDB30", Offset = "0x2ACC930", VA = "0x182ACDB30")]
		[CompilerGenerated]
		private void LYTCPFZYVXS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDB40", Offset = "0x2ACC940", VA = "0x182ACDB40")]
		[CompilerGenerated]
		private bool LYYJMMTWFJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDC90", Offset = "0x2ACCA90", VA = "0x182ACDC90")]
		[CompilerGenerated]
		private bool LZYRYUPJANU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDCE0", Offset = "0x2ACCAE0", VA = "0x182ACDCE0")]
		[CompilerGenerated]
		private bool MADYWBJGJZD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD130", Offset = "0x2ACBF30", VA = "0x182ACD130")]
		[CompilerGenerated]
		private int JWOARSBDHNV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD060", Offset = "0x2ACBE60", VA = "0x182ACD060")]
		[CompilerGenerated]
		private bool JWITULHFYCM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD1D0", Offset = "0x2ACBFD0", VA = "0x182ACD1D0")]
		[CompilerGenerated]
		private object JWYOMFOYAKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD180", Offset = "0x2ACBF80", VA = "0x182ACD180")]
		[CompilerGenerated]
		private void JWTHOYVAQZE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD340", Offset = "0x2ACC140", VA = "0x182ACD340")]
		[CompilerGenerated]
		private bool JXDVJMIVJVW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD4F0", Offset = "0x2ACC2F0", VA = "0x182ACD4F0")]
		[CompilerGenerated]
		private string JXTQBGQNMDX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD410", Offset = "0x2ACC210", VA = "0x182ACD410")]
		[CompilerGenerated]
		private void JXOJDZWQCSO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2ACCF90", Offset = "0x2ACBD90", VA = "0x182ACCF90")]
		[CompilerGenerated]
		private bool JUXXNPXYKBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACCF10", Offset = "0x2ACBD10", VA = "0x182ACCF10")]
		[CompilerGenerated]
		private string JUSQQJEBAPS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE290", Offset = "0x2ACD090", VA = "0x182ACE290")]
		[CompilerGenerated]
		private void PUMKIXBVYHC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE2A0", Offset = "0x2ACD0A0", VA = "0x182ACE2A0")]
		[CompilerGenerated]
		private bool PURRGDVTHSL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE370", Offset = "0x2ACD170", VA = "0x182ACE370")]
		[CompilerGenerated]
		private string PUWYDKPQRDU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE3F0", Offset = "0x2ACD1F0", VA = "0x182ACE3F0")]
		[CompilerGenerated]
		private void PVCFARJOAPD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE400", Offset = "0x2ACD200", VA = "0x182ACE400")]
		[CompilerGenerated]
		private bool PVHLXYDLKAM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE4D0", Offset = "0x2ACD2D0", VA = "0x182ACE4D0")]
		[CompilerGenerated]
		private string PVMSVEXITLV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE540", Offset = "0x2ACD340", VA = "0x182ACE540")]
		[CompilerGenerated]
		private void PVRZSLRGCXE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE550", Offset = "0x2ACD350", VA = "0x182ACE550")]
		[CompilerGenerated]
		private bool PVXGPSLDMIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE620", Offset = "0x2ACD420", VA = "0x182ACE620")]
		[CompilerGenerated]
		private string PWCNMZFAVTW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE690", Offset = "0x2ACD490", VA = "0x182ACE690")]
		[CompilerGenerated]
		private void PWHUKFYYFFF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEC50", Offset = "0x2ACDA50", VA = "0x182ACEC50")]
		[CompilerGenerated]
		private bool VVFQUHKYCDD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEBE0", Offset = "0x2ACD9E0", VA = "0x182ACEBE0")]
		[CompilerGenerated]
		private string VVAJXARASRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEBD0", Offset = "0x2ACD9D0", VA = "0x182ACEBD0")]
		[CompilerGenerated]
		private void VUVCZTXDJGL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEB00", Offset = "0x2ACD900", VA = "0x182ACEB00")]
		[CompilerGenerated]
		private bool VUPWCNDFZVC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEE60", Offset = "0x2ACDC60", VA = "0x182ACEE60")]
		[CompilerGenerated]
		private string VWASJIMNNWN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2ACEE50", Offset = "0x2ACDC50", VA = "0x182ACEE50")]
		[CompilerGenerated]
		private void VVVLMBSQELE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2ACED80", Offset = "0x2ACDB80", VA = "0x182ACED80")]
		[CompilerGenerated]
		private bool VVQEOUYSUZV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2ACED20", Offset = "0x2ACDB20", VA = "0x182ACED20")]
		[CompilerGenerated]
		private object VVKXROEVLOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD180", Offset = "0x2ACBF80", VA = "0x182ACD180")]
		[CompilerGenerated]
		private void VWVTYJOCZPX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC6D0", Offset = "0x2ACB4D0", VA = "0x182ACC6D0")]
		[CompilerGenerated]
		private bool DSDEKENRAVM()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class MWPOVEXZXED
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class GLPZMZMAKVX : EOGMAVBNCPD<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public GLPZMZMAKVX SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5510", Offset = "0x2AB4310", VA = "0x182AB5510")]
				internal object AIVVSQNXYVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x2AB52B0", Offset = "0x2AB40B0", VA = "0x182AB52B0")]
				internal void AIQOVJUAPJS(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3C70", Offset = "0x2AB2A70", VA = "0x182AB3C70")]
			public GLPZMZMAKVX(RGZHVGRSJVI a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3A00", Offset = "0x2AB2800", VA = "0x182AB3A00", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class WBOHUQOLGRK : AZSQARIURKK<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType KNBJQCEZLVP
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xB00150", Offset = "0xAFEF50", VA = "0x180B00150", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2AD02A0", Offset = "0x2ACF0A0", VA = "0x182AD02A0")]
			public WBOHUQOLGRK(RGZHVGRSJVI a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class VGWVYALDVNY : EOGMAVBNCPD<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2ACC080", Offset = "0x2ACAE80", VA = "0x182ACC080")]
			public VGWVYALDVNY(RGZHVGRSJVI a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2ACBF20", Offset = "0x2ACAD20", VA = "0x182ACBF20", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2ACBED0", Offset = "0x2ACACD0", VA = "0x182ACBED0")]
			[CompilerGenerated]
			private bool ADDDPCDGZJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2ACBDA0", Offset = "0x2ACABA0", VA = "0x182ACBDA0")]
			[CompilerGenerated]
			private void ACXWRVJJPXS(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class HSPCLDSQZHE : EOGMAVBNCPD<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public HSPCLDSQZHE SVDPBWSVAHX;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5380", Offset = "0x2AB4180", VA = "0x182AB5380")]
				internal void AIVVSQNXYVB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x2AB4EE0", Offset = "0x2AB3CE0", VA = "0x182AB4EE0")]
				internal bool AIQOVJUAPJS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5840", Offset = "0x2AB4640", VA = "0x182AB5840")]
				internal bool AJGJNEBSRRT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5570", Offset = "0x2AB4370", VA = "0x182AB5570")]
				internal void AJBCPXHVIGK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5930", Offset = "0x2AB4730", VA = "0x182AB5930")]
				internal bool AJQXHRPNKOL()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3FF0", Offset = "0x2AB2DF0", VA = "0x182AB3FF0")]
			public HSPCLDSQZHE(RGZHVGRSJVI a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3CE0", Offset = "0x2AB2AE0", VA = "0x182AB3CE0", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class YJXNLVLNMPI : EOGMAVBNCPD<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public YJXNLVLNMPI SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> JOOMIEHQAKD;

				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5420", Offset = "0x2AB4220", VA = "0x182AB5420")]
				internal object? AIVVSQNXYVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0x2AB59F0", Offset = "0x2AB47F0", VA = "0x182AB59F0")]
				internal bool AJWEEYJKTZU(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5060", Offset = "0x2AB3E60", VA = "0x182AB5060")]
				internal void AIQOVJUAPJS(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x2AB56F0", Offset = "0x2AB44F0", VA = "0x182AB56F0")]
				internal string AJGJNEBSRRT(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2AB56A0", Offset = "0x2AB44A0", VA = "0x182AB56A0")]
				internal IReadOnlyList<object> AJBCPXHVIGK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5980", Offset = "0x2AB4780", VA = "0x182AB5980")]
				internal bool AJQXHRPNKOL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x2AB58E0", Offset = "0x2AB46E0", VA = "0x182AB58E0")]
				internal bool AJLQKKVQBDC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5A70", Offset = "0x2AB4870", VA = "0x182AB5A70")]
				internal void AKBLCFDIDLD(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2AD0D10", Offset = "0x2ACFB10", VA = "0x182AD0D10")]
			public YJXNLVLNMPI(RGZHVGRSJVI a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2AD0610", Offset = "0x2ACF410", VA = "0x182AD0610", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class BXDPKIEUUIJ : EOGMAVBNCPD<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public BXDPKIEUUIJ SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(RVA = "0x2AB53D0", Offset = "0x2AB41D0", VA = "0x182AB53D0")]
				internal bool AIVVSQNXYVB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x2AB4F30", Offset = "0x2AB3D30", VA = "0x182AB4F30")]
				internal void AIQOVJUAPJS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5890", Offset = "0x2AB4690", VA = "0x182AB5890")]
				internal bool AJGJNEBSRRT()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1060", Offset = "0x2AAFE60", VA = "0x182AB1060")]
			public BXDPKIEUUIJ(RGZHVGRSJVI a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0E50", Offset = "0x2AAFC50", VA = "0x182AB0E50", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class AZDSMNJQHLE : EOGMAVBNCPD<LXRUNNYHIGD>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class KUZIAGTACLK
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
					public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public KUZIAGTACLK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<VKUGUULGSUQ>, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x2AC94D0", Offset = "0x2AC82D0", VA = "0x182AC94D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0x2AC98B0", Offset = "0x2AC86B0", VA = "0x182AC98B0", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public KUZIAGTACLK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x2AC9920", Offset = "0x2AC8720", VA = "0x182AC9920", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x2AC9CB0", Offset = "0x2AC8AB0", VA = "0x182AC9CB0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task RSFUWTKRPHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string KIXOIFNULFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public MSLEAENUAIG.JVUNXFPVLGY YSMJAIXNONZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool BKDZKHOEVBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public AZDSMNJQHLE SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public MSLEAENUAIG OZUDTGYFQYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action KWMLSQKCCXR;

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public KUZIAGTACLK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6580", Offset = "0x2AB5380", VA = "0x182AB6580")]
				internal bool XYWYCXAIWZT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
				internal string FAPMEGGMAGC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2AB60C0", Offset = "0x2AB4EC0", VA = "0x182AB60C0")]
				internal void FAKFGZMOQUT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6070", Offset = "0x2AB4E70", VA = "0x182AB6070")]
				internal void FAEYJSSRHJK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x1631420", Offset = "0x1630220", VA = "0x181631420")]
				internal bool FBPUQOBYVKV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6180", Offset = "0x2AB4F80", VA = "0x182AB6180")]
				internal void FBKNTHIBLZM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6140", Offset = "0x2AB4F40", VA = "0x182AB6140")]
				internal bool FBFGWAOECOD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2AB63A0", Offset = "0x2AB51A0", VA = "0x182AB63A0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, SJKUUBAWOPB>> ROZKXBHPPYN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x2AB6490", Offset = "0x2AB5290", VA = "0x182AB6490")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, SJKUUBAWOPB>> WKGHUKMVNAS()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class IEWMQXGPNAW
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
					public AsyncTaskMethodBuilder<Result<Id32<VKUGUULGSUQ>, SJKUUBAWOPB>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<VKUGUULGSUQ>, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0x2AC90F0", Offset = "0x2AC7EF0", VA = "0x182AC90F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0x2AC9460", Offset = "0x2AC8260", VA = "0x182AC9460", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public AZDSMNJQHLE SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public BKLHYEYAHLO MPFQMDGEUOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool DPQVQFZRUKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public MSLEAENUAIG OZUDTGYFQYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public FAEFOLOYIAQ ZDAPGEYRGRB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action JMIOMHWTAPI;

				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public IEWMQXGPNAW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0x2AB4190", Offset = "0x2AB2F90", VA = "0x182AB4190")]
				internal object? AIQOVJUAPJS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0x2AB42F0", Offset = "0x2AB30F0", VA = "0x182AB42F0")]
				internal void AJGJNEBSRRT(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2AB4200", Offset = "0x2AB3000", VA = "0x182AB4200")]
				internal string AJBCPXHVIGK(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2AB4540", Offset = "0x2AB3340", VA = "0x182AB4540")]
				internal IReadOnlyList<object> AJQXHRPNKOL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2AB43E0", Offset = "0x2AB31E0", VA = "0x182AB43E0")]
				internal void AJLQKKVQBDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2AB46A0", Offset = "0x2AB34A0", VA = "0x182AB46A0")]
				internal bool AKBLCFDIDLD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x2AB45E0", Offset = "0x2AB33E0", VA = "0x182AB45E0")]
				internal void AJWEEYJKTZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2AB4140", Offset = "0x2AB2F40", VA = "0x182AB4140")]
				internal void AHFSOOKTBIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2AB40C0", Offset = "0x2AB2EC0", VA = "0x182AB40C0")]
				internal void AHALRHQVRWY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2AB4710", Offset = "0x2AB3510", VA = "0x182AB4710")]
				internal bool EMTTFILJCOM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2AB4770", Offset = "0x2AB3570", VA = "0x182AB4770")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<VKUGUULGSUQ>, SJKUUBAWOPB>> WOTBNHKSYSE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<TROAQNNIZMC>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0BA0", Offset = "0x2AAF9A0", VA = "0x182AB0BA0", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool BKBUYOBQYPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0B30", Offset = "0x2AAF930", VA = "0x182AB0B30")]
			public AZDSMNJQHLE(RGZHVGRSJVI a, LXRUNNYHIGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB01B0", Offset = "0x2AAEFB0", VA = "0x182AB01B0", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFB20", Offset = "0x2AAE920", VA = "0x182AAFB20")]
			private void FZFLQNSZBZZ(MSLEAENUAIG a, Id32<VKUGUULGSUQ>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class HVXXQZQDNDJ : XSMRIYLPWPA<UXUZCTNARHS>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0x16C95D0", Offset = "0x16C83D0", VA = "0x1816C95D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool RJLWJICVMDE
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool WSXINFEUNUR
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool JBNRFADPYCI
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool BKBUYOBQYPX
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4060", Offset = "0x2AB2E60", VA = "0x182AB4060")]
			public HVXXQZQDNDJ(RGZHVGRSJVI a, UXUZCTNARHS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class BQWSCWSGSFR<a> : EOGMAVBNCPD<a> where a : notnull, VVBJPCICEQZ
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
				public AsyncTaskMethodBuilder<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public BQWSCWSGSFR<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x4FEF540", Offset = "0x4FEE340", VA = "0x184FEF540", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0x4FEF890", Offset = "0x4FEE690", VA = "0x184FEF890", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public BQWSCWSGSFR<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<TOCKAIBKNWY> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x5284010", Offset = "0x5282E10", VA = "0x185284010", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x5284360", Offset = "0x5283160", VA = "0x185284360", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<TOCKAIBKNWY>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0x71F00F0", Offset = "0x71EEEF0", VA = "0x1871F00F0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x71F00C0", Offset = "0x71EEEC0", VA = "0x1871F00C0")]
			protected BQWSCWSGSFR(RGZHVGRSJVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x71EFFA0", Offset = "0x71EEDA0", VA = "0x1871EFFA0", Slot = "122")]
			[AsyncStateMachine(typeof(BQWSCWSGSFR<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> XZBAOBIIBQI(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x71EFF00", Offset = "0x71EED00", VA = "0x1871EFF00", Slot = "149")]
			public sealed override bool XSQFCMPRZGF(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x71EFE60", Offset = "0x71EEC60", VA = "0x1871EFE60", Slot = "134")]
			protected sealed override bool IHUKBKBQUAP(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x71EFDC0", Offset = "0x71EEBC0", VA = "0x1871EFDC0", Slot = "135")]
			protected override bool FMXOHQUBVKQ(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x71EFCB0", Offset = "0x71EEAB0", VA = "0x1871EFCB0", Slot = "123")]
			[AsyncStateMachine(typeof(BQWSCWSGSFR<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, SJKUUBAWOPB>> CUKJUWJKPZZ(Id32<TOCKAIBKNWY> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class EIGCJYCVGCO : WWMERNBFBAB<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public EIGCJYCVGCO SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5BA0", Offset = "0x2AB49A0", VA = "0x182AB5BA0")]
				internal bool OEQLGKTAGEC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5CA0", Offset = "0x2AB4AA0", VA = "0x182AB5CA0")]
				internal void OEVSDRMXPPL(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1890", Offset = "0x2AB0690", VA = "0x182AB1890")]
			public EIGCJYCVGCO(RGZHVGRSJVI a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1650", Offset = "0x2AB0450", VA = "0x182AB1650", Slot = "151")]
			protected override void XSDVTBNRAWC(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class TJHIKKMUBNF : EOGMAVBNCPD<JLVNBGRDXOU>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class OPUURPABOAR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int VLDMKPMGSMK;

				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public OPUURPABOAR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3320", Offset = "0x2AC2120", VA = "0x182AC3320")]
				internal bool LAIYDGHDMHM(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class BLFBRGQSUPA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public TJHIKKMUBNF SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> TXDAEYYFXBW;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public BLFBRGQSUPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0D00", Offset = "0x2AAFB00", VA = "0x182AB0D00")]
				internal int AIVVSQNXYVB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0BE0", Offset = "0x2AAF9E0", VA = "0x182AB0BE0")]
				internal void AIQOVJUAPJS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0DA0", Offset = "0x2AAFBA0", VA = "0x182AB0DA0")]
				internal string? AJGJNEBSRRT()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6230", Offset = "0x2AC5030", VA = "0x182AC6230")]
			public TJHIKKMUBNF(RGZHVGRSJVI a, JLVNBGRDXOU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5D30", Offset = "0x2AC4B30", VA = "0x182AC5D30")]
			private int BNYELKSLSWI(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6110", Offset = "0x2AC4F10", VA = "0x182AC6110")]
			private void PYEIHQQRLVQ(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5DC0", Offset = "0x2AC4BC0", VA = "0x182AC5DC0", Slot = "145")]
			protected sealed override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class KNIDLPXZDEF : XSMRIYLPWPA<MSHEQMEXBMS>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5DF0", Offset = "0x2AB4BF0", VA = "0x182AB5DF0")]
			public KNIDLPXZDEF(RGZHVGRSJVI a, MSHEQMEXBMS b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class XSMRIYLPWPA<a> : EOGMAVBNCPD<a> where a : notnull, CEVUUCXNOZI
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class KYAZWCYTODY
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
					public KYAZWCYTODY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0x3F95050", Offset = "0x3F93E50", VA = "0x183F95050", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public MSLEAENUAIG OZUDTGYFQYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public XSMRIYLPWPA<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action JOJFKXNSQYU;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public KYAZWCYTODY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x53C8B40", Offset = "0x53C7940", VA = "0x1853C8B40")]
				internal void AIVVSQNXYVB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x53C8E00", Offset = "0x53C7C00", VA = "0x1853C8E00")]
				[AsyncStateMachine(typeof(XSMRIYLPWPA<>.KYAZWCYTODY.<<BuildConfigMenuInternal>b__6>d))]
				internal void AKBLCFDIDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x53C8790", Offset = "0x53C7590", VA = "0x1853C8790")]
				internal bool AIQOVJUAPJS()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class KYGGTJSQXPH
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
					public KYGGTJSQXPH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x3F94880", Offset = "0x3F93680", VA = "0x183F94880", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string EYTIMIWMQZC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public KYAZWCYTODY JOWOLGJKVOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> JNTKTDGAOQT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> JOTTFLBNJVM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action JOZACRVKTGV;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public KYGGTJSQXPH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x53C8EA0", Offset = "0x53C7CA0", VA = "0x1853C8EA0")]
				internal void AJGJNEBSRRT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				internal string AJBCPXHVIGK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
				internal void AJQXHRPNKOL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x53C9200", Offset = "0x53C8000", VA = "0x1853C9200")]
				[AsyncStateMachine(typeof(XSMRIYLPWPA<>.KYGGTJSQXPH.<<BuildConfigMenuInternal>b__5>d))]
				internal void AJLQKKVQBDC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class GOPYZURGLNZ
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
					public GOPYZURGLNZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<NLSPOFOVMCC>, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0x3F92070", Offset = "0x3F90E70", VA = "0x183F92070", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public GOPYZURGLNZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x3F927B0", Offset = "0x3F915B0", VA = "0x183F927B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public GOPYZURGLNZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<ENGFBJMMTKB>, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x3F92990", Offset = "0x3F91790", VA = "0x183F92990", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public XSMRIYLPWPA<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<TOCKAIBKNWY> TEFLDLEVGFU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public MSLEAENUAIG OZUDTGYFQYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public MEYJBPAULDI SEDYURNQHHT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int XLRHITAUJFW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int IAVJCEPXIJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public XJIDAZKYYEX GSPXMLUFWOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string PPOCOTEMNJZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<MNNBDWWYAWZ> JTBSOZEOVIW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public XJIDAZKYYEX ERJFHPJUUAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string DOKAVONNZMY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<MNNBDWWYAWZ> UICFYEGTFFV;

				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public GOPYZURGLNZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x50AD020", Offset = "0x50ABE20", VA = "0x1850AD020")]
				internal bool QCREQQEKGKS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x50AD090", Offset = "0x50ABE90", VA = "0x1850AD090")]
				internal void QCWLNWYHPWB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x50AD3E0", Offset = "0x50AC1E0", VA = "0x1850AD3E0")]
				internal bool VVIXSNZGYLI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x50ACF40", Offset = "0x50ABD40", VA = "0x1850ACF40")]
				[AsyncStateMachine(typeof(XSMRIYLPWPA<>.GOPYZURGLNZ.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void QCGQWCQPNOA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x50ACFE0", Offset = "0x50ABDE0", VA = "0x1850ACFE0")]
				internal bool QCLXTJKMWZJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x50AD420", Offset = "0x50AC220", VA = "0x1850AD420")]
				internal void VWDZHPAWKES()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x50AD5E0", Offset = "0x50AC3E0", VA = "0x1850AD5E0")]
				internal bool VWTTZJIOMMT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x50AD500", Offset = "0x50AC300", VA = "0x1850AD500")]
				internal void VWONCCORDBK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x50ACDB0", Offset = "0x50ABBB0", VA = "0x1850ACDB0")]
				internal bool BZONCUSVVSI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x50AD200", Offset = "0x50AC000", VA = "0x1850AD200")]
				internal bool QDMGFRFZSEC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x50AD270", Offset = "0x50AC070", VA = "0x1850AD270")]
				internal void QDRNCXZXBPL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x50AD100", Offset = "0x50ABF00", VA = "0x1850AD100")]
				[AsyncStateMachine(typeof(XSMRIYLPWPA<>.GOPYZURGLNZ.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void QDBSLDSEZHK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x50AD1A0", Offset = "0x50ABFA0", VA = "0x1850AD1A0")]
				internal bool QDGZIKMCIST()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x50ACE60", Offset = "0x50ABC60", VA = "0x1850ACE60")]
				internal bool QBBBMOBFIXY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x50ACED0", Offset = "0x50ABCD0", VA = "0x1850ACED0")]
				internal void QBGIJUVCSJH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x50AD340", Offset = "0x50AC140", VA = "0x1850AD340")]
				[AsyncStateMachine(typeof(XSMRIYLPWPA<>.GOPYZURGLNZ.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void VVDQVHFJOZZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x50AD2E0", Offset = "0x50AC0E0", VA = "0x1850AD2E0")]
				internal bool VUYJYALMFOQ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class GOKSCNXJCCQ
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
					public GOKSCNXJCCQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x3F92360", Offset = "0x3F91160", VA = "0x183F92360", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string HVFQWXGGBXC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public GOPYZURGLNZ JOWOLGJKVOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> XRXDWCBANVZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> XRRWYVHDEKQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action XSHRQPOVGSR;

				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public GOKSCNXJCCQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(RVA = "0x50AC9B0", Offset = "0x50AB7B0", VA = "0x1850AC9B0")]
				internal void VVOEPUTEHWR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				internal string VVYSKIGZATJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
				internal void VVTLNBNBRIA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x50ACD10", Offset = "0x50ABB10", VA = "0x1850ACD10")]
				[AsyncStateMachine(typeof(XSMRIYLPWPA<>.GOKSCNXJCCQ.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void VWJGEVUTTQB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class LBPIPQWBBNO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool JTBSOZEOVIW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public MEYJBPAULDI SEDYURNQHHT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<MNNBDWWYAWZ> XJWCEVRSBYL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public XSMRIYLPWPA<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<TOCKAIBKNWY> TEFLDLEVGFU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int WAZKNZYAIJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> JODYNQTVHNL;

				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public LBPIPQWBBNO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0x547E6B0", Offset = "0x547D4B0", VA = "0x18547E6B0")]
				internal bool AZIFOQLYDJQ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class LBUPMXPYKYX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public BSZEZNSGOWH HEADDHRXRKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public LBPIPQWBBNO JOWOLGJKVOM;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public LBUPMXPYKYX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x5480710", Offset = "0x547F510", VA = "0x185480710")]
				internal void AZCYRJSATYH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0x54806C0", Offset = "0x547F4C0", VA = "0x1854806C0")]
				internal bool AYXRUCYDKMY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x54808E0", Offset = "0x547F6E0", VA = "0x1854808E0")]
				internal void BAIOAYHKYOJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x5480880", Offset = "0x547F680", VA = "0x185480880")]
				internal bool BADHDRNNPDA()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class LBZWKEJVUKG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public MNNBDWWYAWZ BEDFURVKKUK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public LBUPMXPYKYX JPMJDARCXWN;

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public LBZWKEJVUKG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x5480A70", Offset = "0x547F870", VA = "0x185480A70")]
				internal void AZNMLXFVMUZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class HUEAHOQODWF
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
					public HUEAHOQODWF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0x3F96280", Offset = "0x3F95080", VA = "0x183F96280", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> OAUVRIIECYO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public XJIDAZKYYEX RIIZSSYTFDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool JTBSOZEOVIW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public MEYJBPAULDI SEDYURNQHHT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public BSZEZNSGOWH HEADDHRXRKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string HVFQWXGGBXC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public HUEAHOQODWF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x511E850", Offset = "0x511D650", VA = "0x18511E850")]
				internal int KTAMZKOZBAZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x511E5F0", Offset = "0x511D3F0", VA = "0x18511E5F0")]
				internal void KSVGCDVBRPQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930")]
				internal string KSPZEXBEIEH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x511E530", Offset = "0x511D330", VA = "0x18511E530")]
				[AsyncStateMachine(typeof(XSMRIYLPWPA<>.HUEAHOQODWF.<<CreatePortItemV2>b__3>d))]
				internal void KSKSHQHGYSY(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public XSMRIYLPWPA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x4FEF120", Offset = "0x4FEDF20", VA = "0x184FEF120", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x4FEF4D0", Offset = "0x4FEE2D0", VA = "0x184FEF4D0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public XSMRIYLPWPA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<TOCKAIBKNWY> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x52843D0", Offset = "0x52831D0", VA = "0x1852843D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x5284770", Offset = "0x5283570", VA = "0x185284770", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public XSMRIYLPWPA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x5290E10", Offset = "0x528FC10", VA = "0x185290E10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x52913B0", Offset = "0x52901B0", VA = "0x1852913B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<TOCKAIBKNWY>, bool> EONQYUUMHBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<TOCKAIBKNWY>, bool> VZGDWFBPFOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<TOCKAIBKNWY>, bool> UXBYMDACDOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<TOCKAIBKNWY>, bool> XMJPMQQHJOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<TOCKAIBKNWY>, bool> XANHBGABIUQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<TOCKAIBKNWY>, bool> AKQFNWRSAXP;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool RJLWJICVMDE
			{
				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool WSXINFEUNUR
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool JBNRFADPYCI
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<TROAQNNIZMC>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x40A5A60", Offset = "0x40A4860", VA = "0x1840A5A60", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<TOCKAIBKNWY>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x40A5CC0", Offset = "0x40A4AC0", VA = "0x1840A5CC0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<LQPAJNJDNAW>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x40A5AE0", Offset = "0x40A48E0", VA = "0x1840A5AE0", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x40A5890", Offset = "0x40A4690", VA = "0x1840A5890")]
			public XSMRIYLPWPA(RGZHVGRSJVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "154")]
			protected virtual bool TRZQEYPMFLZ(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "155")]
			protected virtual bool XVKAIWKCVIM(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "156")]
			protected virtual bool MJHONIMROQV(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "157")]
			protected virtual void TWKUFERRNGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x40A4670", Offset = "0x40A3470", VA = "0x1840A4670", Slot = "149")]
			public override bool XSQFCMPRZGF(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x40A4710", Offset = "0x40A3510", VA = "0x1840A4710", Slot = "122")]
			[AsyncStateMachine(typeof(XSMRIYLPWPA<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> XZBAOBIIBQI(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x40A2920", Offset = "0x40A1720", VA = "0x1840A2920", Slot = "123")]
			[AsyncStateMachine(typeof(XSMRIYLPWPA<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, SJKUUBAWOPB>> CUKJUWJKPZZ(Id32<TOCKAIBKNWY> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x40A44D0", Offset = "0x40A32D0", VA = "0x1840A44D0", Slot = "124")]
			public override void WJSNPWXDIEP(Id32<TOCKAIBKNWY> index, Id32<TOCKAIBKNWY> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x40A35C0", Offset = "0x40A23C0", VA = "0x1840A35C0", Slot = "125")]
			public override IEnumerable<ELPAQFNEADX> MQFVROWYEII()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x40A3800", Offset = "0x40A2600", VA = "0x1840A3800")]
			[AsyncStateMachine(typeof(XSMRIYLPWPA<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, SJKUUBAWOPB>> NPOAHYCKUVF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "158")]
			protected virtual bool VNZHNHCESWO(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "159")]
			protected virtual bool EBMKLOPNRDO(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "160")]
			protected virtual bool BOPZHEIKUOF(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "161")]
			protected virtual bool GOWZDRDIYGR(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "162")]
			protected virtual bool FEPOVJYLKQV(Id32<TOCKAIBKNWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "163")]
			protected virtual bool XWINIWFDHFI(Id32<TOCKAIBKNWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "164")]
			protected virtual bool AOSISQQGZOY(Id32<TOCKAIBKNWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "165")]
			protected virtual bool TSCEDTOZTPT(Id32<TOCKAIBKNWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "166")]
			protected virtual bool PVQPUWZYUTD(Id32<TOCKAIBKNWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "167")]
			protected virtual bool NINHLVVGHBG(Id32<TOCKAIBKNWY> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x40A4240", Offset = "0x40A3040", VA = "0x1840A4240", Slot = "168")]
			protected virtual List<XJIDAZKYYEX> SBTFHBRCNOC(Id32<TOCKAIBKNWY> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "169")]
			protected virtual void QOZTJIWHZYP(MSLEAENUAIG a, MRZZXIBLOAY b, MEYJBPAULDI c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x40A2C20", Offset = "0x40A1A20", VA = "0x1840A2C20", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x40A0FD0", Offset = "0x409FDD0", VA = "0x1840A0FD0")]
			private MRZZXIBLOAY CLMLKXNWSNI(MSLEAENUAIG a, MEYJBPAULDI b, Id32<TOCKAIBKNWY> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x40A4830", Offset = "0x40A3630", VA = "0x1840A4830")]
			private List<MNNBDWWYAWZ> ZXJYUNJRGIX(MSLEAENUAIG a, MEYJBPAULDI b, MRZZXIBLOAY c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x40A3900", Offset = "0x40A2700", VA = "0x1840A3900")]
			private List<MNNBDWWYAWZ> OMLCFUJNIYT(MSLEAENUAIG a, MEYJBPAULDI b, BSZEZNSGOWH c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x40A2A30", Offset = "0x40A1830", VA = "0x1840A2A30")]
			private XJIDAZKYYEX FCRCQNSGMNV(List<XJIDAZKYYEX> a, BSZEZNSGOWH b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x40A41E0", Offset = "0x40A2FE0", VA = "0x1840A41E0")]
			[CompilerGenerated]
			private ELPAQFNEADX ONUXGSYUAKL(ITZFJUYYDSP a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class KQDURPZPACV : EOGMAVBNCPD<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class RYMNRJREOIY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public KQDURPZPACV SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RYMNRJREOIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x2AC5850", Offset = "0x2AC4650", VA = "0x182AC5850")]
				internal int AIVVSQNXYVB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x2AC57C0", Offset = "0x2AC45C0", VA = "0x182AC57C0")]
				internal Task<bool> AIQOVJUAPJS(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6000", Offset = "0x2AB4E00", VA = "0x182AB6000")]
			public KQDURPZPACV(RGZHVGRSJVI a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5E50", Offset = "0x2AB4C50", VA = "0x182AB5E50", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class STBMFVXWAJP : WWMERNBFBAB<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public STBMFVXWAJP SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5C20", Offset = "0x2AB4A20", VA = "0x182AB5C20")]
				internal int OEQLGKTAGEC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5D50", Offset = "0x2AB4B50", VA = "0x182AB5D50")]
				internal Task<bool> OEVSDRMXPPL(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5B20", Offset = "0x2AC4920", VA = "0x182AC5B20")]
			public STBMFVXWAJP(RGZHVGRSJVI a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5900", Offset = "0x2AC4700", VA = "0x182AC5900", Slot = "151")]
			protected override void XSDVTBNRAWC(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class EOIZWFJJKBB : EOGMAVBNCPD<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0xF82760", Offset = "0xF81560", VA = "0x180F82760", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2AB18F0", Offset = "0x2AB06F0", VA = "0x182AB18F0")]
			public EOIZWFJJKBB(RGZHVGRSJVI a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class FZLSKWRDJRR : EOGMAVBNCPD<MLELVYDBMIY>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class OMGLYBCUARB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public FZLSKWRDJRR SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public MSLEAENUAIG OZUDTGYFQYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> TVBIRLCDOWR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> TULNZQULMOQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> TUGHCKAODDH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> TTQMKPSWAVG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> TTVTHWMTKGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> TTFYQCFBHYO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> TTLFNIYYRJX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> APAUCODPFEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> AOVNFHJRVTG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> APLHXBRJYBH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> APGAZUXMOPY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> APVVRPFEQXZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> APQOUILHHMQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> AQGJMCSZJUR;

				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public OMGLYBCUARB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x2AB88C0", Offset = "0x2AB76C0", VA = "0x182AB88C0")]
				internal bool AIVVSQNXYVB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0x2AB8860", Offset = "0x2AB7660", VA = "0x182AB8860")]
				internal void AIQOVJUAPJS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2AB8C70", Offset = "0x2AB7A70", VA = "0x182AB8C70")]
				internal bool AJQXHRPNKOL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x2AB8C20", Offset = "0x2AB7A20", VA = "0x182AB8C20")]
				internal bool AJLQKKVQBDC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2AB90D0", Offset = "0x2AB7ED0", VA = "0x182AB90D0")]
				internal void AKBLCFDIDLD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x2AB8810", Offset = "0x2AB7610", VA = "0x182AB8810")]
				internal bool AHALRHQVRWY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA170", Offset = "0x2AB8F70", VA = "0x182ABA170")]
				internal bool EMTTFILJCOM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA1C0", Offset = "0x2AB8FC0", VA = "0x182ABA1C0")]
				internal void EMZACPFGLZV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA220", Offset = "0x2AB9020", VA = "0x182ABA220")]
				internal bool ENOUUJMYOHW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA270", Offset = "0x2AB9070", VA = "0x182ABA270")]
				internal bool ENUBRQGVXTF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA2C0", Offset = "0x2AB90C0", VA = "0x182ABA2C0")]
				internal void ENZIOXATHEO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA120", Offset = "0x2AB8F20", VA = "0x182ABA120")]
				internal bool ELIWYNCBONB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1DF0", Offset = "0x2AC0BF0", VA = "0x182AC1DF0")]
				internal bool SNHBNRZYWFU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1E40", Offset = "0x2AC0C40", VA = "0x182AC1E40")]
				internal bool SNMIKYTWFRD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1DA0", Offset = "0x2AC0BA0", VA = "0x182AC1DA0")]
				internal bool SMWNTEMEDJC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1D00", Offset = "0x2AC0B00", VA = "0x182AC1D00")]
				internal bool SMLZYQYJKMK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1D50", Offset = "0x2AC0B50", VA = "0x182AC1D50")]
				internal bool SMRGVXSGTXT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2CB0", Offset = "0x2AC1AB0", VA = "0x182AC2CB0")]
				internal bool ZIGVLCWXHSL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2C60", Offset = "0x2AC1A60", VA = "0x182AC2C60")]
				internal bool ZIBONWCZYHC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2D50", Offset = "0x2AC1B50", VA = "0x182AC2D50")]
				internal void ZIRJFQKSAPD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2AC13D0", Offset = "0x2AC01D0", VA = "0x182AC13D0")]
				internal bool MJLZXYUERVM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1380", Offset = "0x2AC0180", VA = "0x182AC1380")]
				internal bool MJGTASAHIKD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1330", Offset = "0x2AC0130", VA = "0x182AC1330")]
				internal bool MJBMDLGJYYU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2AC12E0", Offset = "0x2AC00E0", VA = "0x182AC12E0")]
				internal bool MIQYIXSPGCC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1290", Offset = "0x2AC0090", VA = "0x182AC1290")]
				internal bool MILRLQYRWQT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2D00", Offset = "0x2AC1B00", VA = "0x182AC2D00")]
				internal bool ZIMCIJQURDU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2E10", Offset = "0x2AC1C10", VA = "0x182AC2E10")]
				internal bool ZJBXADYMTLV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2DB0", Offset = "0x2AC1BB0", VA = "0x182AC2DB0")]
				internal void ZIWQCXEPKAM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2EB0", Offset = "0x2AC1CB0", VA = "0x182AC2EB0")]
				internal bool ZJMKURMHMIN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2E60", Offset = "0x2AC1C60", VA = "0x182AC2E60")]
				internal bool ZJHDXKSKCXE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2F50", Offset = "0x2AC1D50", VA = "0x182AC2F50")]
				internal void ZJWYPFACFFF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2F00", Offset = "0x2AC1D00", VA = "0x182AC2F00")]
				internal bool ZJRRRYGEVTW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1E90", Offset = "0x2AC0C90", VA = "0x182AC1E90")]
				internal bool SOCDCTBOHZE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1EE0", Offset = "0x2AC0CE0", VA = "0x182AC1EE0")]
				internal void SOHJZZVLRKN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAB80", Offset = "0x2AB9980", VA = "0x182ABAB80")]
				internal List<MNNBDWWYAWZ> HCHKMEHALTY(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1240", Offset = "0x2AC0040", VA = "0x182AC1240")]
				internal bool MIGKOKEUNFK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2AC14B0", Offset = "0x2AC02B0", VA = "0x182AC14B0")]
				internal int MLHJZHRGYTP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1420", Offset = "0x2AC0220", VA = "0x182AC1420")]
				internal Task<bool> MLCDCAXJPIG(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA740", Offset = "0x2AB9540", VA = "0x182ABA740")]
				internal bool GIYAJVEZXKU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA790", Offset = "0x2AB9590", VA = "0x182ABA790")]
				internal bool GJDHHBYXGWD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA7E0", Offset = "0x2AB95E0", VA = "0x182ABA7E0")]
				internal bool GJIOEISUQHM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA830", Offset = "0x2AB9630", VA = "0x182ABA830")]
				internal int GJNVBPMRZSV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA5C0", Offset = "0x2AB93C0", VA = "0x182ABA5C0")]
				internal Task<bool> GICYUUDKLRK(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA650", Offset = "0x2AB9450", VA = "0x182ABA650")]
				internal bool GIIFSAXHVCT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA6A0", Offset = "0x2AB94A0", VA = "0x182ABA6A0")]
				internal bool GINMPHRFEOC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA6F0", Offset = "0x2AB94F0", VA = "0x182ABA6F0")]
				internal bool GISTMOLCNZL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA880", Offset = "0x2AB9680", VA = "0x182ABA880")]
				internal bool GKTKLECCEIX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9220", Offset = "0x2AB8020", VA = "0x182AB9220")]
				internal bool AKZQSQEHGRN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1AF0", Offset = "0x2AC08F0", VA = "0x182AC1AF0")]
				internal string PGLLEXHGEWM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1B90", Offset = "0x2AC0990", VA = "0x182AC1B90")]
				internal void PHBFWROYHEN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1C00", Offset = "0x2AC0A00", VA = "0x182AC1C00")]
				internal int PHGMTYIVQPW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1CA0", Offset = "0x2AC0AA0", VA = "0x182AC1CA0")]
				internal void PHWHLSQNSXX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1C50", Offset = "0x2AC0A50", VA = "0x182AC1C50")]
				internal bool PHRAOLWQJMO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1AA0", Offset = "0x2AC08A0", VA = "0x182AC1AA0")]
				internal bool PFAOYBXYQVB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1A50", Offset = "0x2AC0850", VA = "0x182AC1A50")]
				internal bool PEVIAVEBHJS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0B70", Offset = "0x2ABF970", VA = "0x182AC0B70")]
				internal float JFXLQTSBKLU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0BC0", Offset = "0x2ABF9C0", VA = "0x182AC0BC0")]
				internal void JGCSOALYTXD(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0AD0", Offset = "0x2ABF8D0", VA = "0x182AC0AD0")]
				internal bool JFMXWGEGRPC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0B20", Offset = "0x2ABF920", VA = "0x182AC0B20")]
				internal bool JFSETMYEBAL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0A30", Offset = "0x2ABF830", VA = "0x182AC0A30")]
				internal bool JFCKBSQLYSK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2AB92C0", Offset = "0x2AB80C0", VA = "0x182AB92C0")]
				internal bool ALKENDSBZOF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9270", Offset = "0x2AB8070", VA = "0x182AB9270")]
				internal bool ALEXPWYEQCW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9130", Offset = "0x2AB7F30", VA = "0x182AB9130")]
				internal bool AKEPDPCRUYD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2AB8CC0", Offset = "0x2AB7AC0", VA = "0x182AB8CC0")]
				internal void AJZIGIIULMU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0A80", Offset = "0x2ABF880", VA = "0x182AC0A80")]
				internal string JFHQYZKJIDT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2AC09C0", Offset = "0x2ABF7C0", VA = "0x182AC09C0")]
				internal void JERWHFCRFVS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2AB91D0", Offset = "0x2AB7FD0", VA = "0x182AB91D0")]
				internal bool AKPCYCQMNUV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9180", Offset = "0x2AB7F80", VA = "0x182AB9180")]
				internal bool AKJWAVWPEJM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2AB8BD0", Offset = "0x2AB79D0", VA = "0x182AB8BD0")]
				internal bool AJJNOOBCJET()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2AB8910", Offset = "0x2AB7710", VA = "0x182AB8910")]
				internal void AJEGRHHEZTK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2380", Offset = "0x2AC1180", VA = "0x182AC2380")]
				internal bool TKILTXWEQZE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x2AC23D0", Offset = "0x2AC11D0", VA = "0x182AC23D0")]
				internal bool TKNSREQCAKN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2AC22E0", Offset = "0x2AC10E0", VA = "0x182AC22E0")]
				internal bool TJXXZKIJYCM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2330", Offset = "0x2AC1130", VA = "0x182AC2330")]
				internal bool TKDEWRCHHNV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2AC24C0", Offset = "0x2AC12C0", VA = "0x182AC24C0")]
				internal void TLDNIYXUCSO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2520", Offset = "0x2AC1320", VA = "0x182AC2520")]
				internal bool TLIUGFRRMDX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2420", Offset = "0x2AC1220", VA = "0x182AC2420")]
				internal bool TKSZOLJZJVW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2470", Offset = "0x2AC1270", VA = "0x182AC2470")]
				internal bool TKYGLSDWTHF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2230", Offset = "0x2AC1030", VA = "0x182AC2230")]
				internal bool TISIPVSZTMK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2280", Offset = "0x2AC1080", VA = "0x182AC2280")]
				internal void TIXPNCMXCXT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0D10", Offset = "0x2ABFB10", VA = "0x182AC0D10")]
				internal bool JOLUFIRLKHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0CC0", Offset = "0x2ABFAC0", VA = "0x182AC0CC0")]
				internal bool JOGNIBXOAWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0C70", Offset = "0x2ABFA70", VA = "0x182AC0C70")]
				internal bool JOBGKVDQRLB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0C20", Offset = "0x2ABFA20", VA = "0x182AC0C20")]
				internal bool JNVZNOJTHZS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0DF0", Offset = "0x2ABFBF0", VA = "0x182AC0DF0")]
				internal object JOWHZWFGDEL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0D60", Offset = "0x2ABFB60", VA = "0x182AC0D60")]
				internal void JORBCPLITTC(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0EB0", Offset = "0x2ABFCB0", VA = "0x182AC0EB0")]
				internal bool JQBXJKUQHUN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0E60", Offset = "0x2ABFC60", VA = "0x182AC0E60")]
				internal bool JPWQMEASYJE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9980", Offset = "0x2AB8780", VA = "0x182AB9980")]
				internal int CNZWDXDGEAT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x2AB99D0", Offset = "0x2AB87D0", VA = "0x182AB99D0")]
				internal void COFDBDXDNMC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9A30", Offset = "0x2AB8830", VA = "0x182AB9A30")]
				internal bool COUXSYEVPUD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9A80", Offset = "0x2AB8880", VA = "0x182AB9A80")]
				internal bool CPAEQEYSZFM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9AD0", Offset = "0x2AB88D0", VA = "0x182AB9AD0")]
				internal int CPPZHZGLBNN()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA3C0", Offset = "0x2AB91C0", VA = "0x182ABA3C0")]
				internal void GDLSIWQRHZK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA420", Offset = "0x2AB9220", VA = "0x182ABA420")]
				internal bool GDQZGDKORKT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA470", Offset = "0x2AB9270", VA = "0x182ABA470")]
				internal bool GDWGDKEMAWC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA4C0", Offset = "0x2AB92C0", VA = "0x182ABA4C0")]
				internal bool GEBNAQYJKHL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA510", Offset = "0x2AB9310", VA = "0x182ABA510")]
				internal int GERHSLGBMPM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA560", Offset = "0x2AB9360", VA = "0x182ABA560")]
				internal void GEWOPRZYWAV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA320", Offset = "0x2AB9120", VA = "0x182ABA320")]
				internal bool GBVPEUNMKMQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA370", Offset = "0x2AB9170", VA = "0x182ABA370")]
				internal bool GCAWCBHJTXZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2AC15A0", Offset = "0x2AC03A0", VA = "0x182AC15A0")]
				internal bool NECXHOYTXRT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1680", Offset = "0x2AC0480", VA = "0x182AC1680")]
				internal object NESRZJGLZZU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2AC15F0", Offset = "0x2AC03F0", VA = "0x182AC15F0")]
				internal void NENLCCMOQOL(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1550", Offset = "0x2AC0350", VA = "0x182AC1550")]
				internal bool NCMUDMVPAEZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1500", Offset = "0x2AC0300", VA = "0x182AC1500")]
				internal bool NCHNGGBRQTQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2130", Offset = "0x2AC0F30", VA = "0x182AC2130")]
				internal object? TEWDSZHWBNU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2AC21A0", Offset = "0x2AC0FA0", VA = "0x182AC21A0")]
				internal void TFBKQGBTKZD(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2090", Offset = "0x2AC0E90", VA = "0x182AC2090")]
				internal bool TEBCDYGGPUK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2AC20E0", Offset = "0x2AC0EE0", VA = "0x182AC20E0")]
				internal int TEGJBFADZFT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1FE0", Offset = "0x2AC0DE0", VA = "0x182AC1FE0")]
				internal void TDQOJKSLWXS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2040", Offset = "0x2AC0E40", VA = "0x182AC2040")]
				internal bool TDVVGRMJGJB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1F40", Offset = "0x2AC0D40", VA = "0x182AC1F40")]
				internal bool TDGAOXEREBA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1F90", Offset = "0x2AC0D90", VA = "0x182AC1F90")]
				internal bool TDLHMDYONMJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3010", Offset = "0x2AC1E10", VA = "0x182AC3010")]
				internal int ZZAWBJDFBHB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2FB0", Offset = "0x2AC1DB0", VA = "0x182AC2FB0")]
				internal void ZYVPECJHRVS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2AC30B0", Offset = "0x2AC1EB0", VA = "0x182AC30B0")]
				internal bool ZZLJVWQZUDT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3060", Offset = "0x2AC1E60", VA = "0x182AC3060")]
				internal bool ZZGCYPXCKSK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3150", Offset = "0x2AC1F50", VA = "0x182AC3150")]
				internal bool ZZVXQKEUNAL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2AC3100", Offset = "0x2AC1F00", VA = "0x182AC3100")]
				internal float ZZQQTDKXDPC()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2AB8710", Offset = "0x2AB7510", VA = "0x182AB8710")]
				internal void AAGLKXSPFXD(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2AB86C0", Offset = "0x2AB74C0", VA = "0x182AB86C0")]
				internal bool AABENQYRWLU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2AB87C0", Offset = "0x2AB75C0", VA = "0x182AB87C0")]
				internal bool AAQZFLGJYTV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2AB8770", Offset = "0x2AB7570", VA = "0x182AB8770")]
				internal bool AALSIEMMPIM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA9E0", Offset = "0x2AB97E0", VA = "0x182ABA9E0")]
				internal float GZSBABLHQZK()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAA30", Offset = "0x2AB9830", VA = "0x182ABAA30")]
				internal void GZXHXIFFAKT(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAA90", Offset = "0x2AB9890", VA = "0x182ABAA90")]
				internal bool HACOUOZCJWC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA8D0", Offset = "0x2AB96D0", VA = "0x182ABA8D0")]
				internal bool GZCGIHDPORJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA920", Offset = "0x2AB9720", VA = "0x182ABA920")]
				internal string GZHNFNXMYCS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA970", Offset = "0x2AB9770", VA = "0x182ABA970")]
				internal void GZMUCURKHOB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAAE0", Offset = "0x2AB98E0", VA = "0x182ABAAE0")]
				internal bool HBIEEDOMOME(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2ABAB30", Offset = "0x2AB9930", VA = "0x182ABAB30")]
				internal bool HBNLBKIJXXN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1940", Offset = "0x2AC0740", VA = "0x182AC1940")]
				internal bool OAJFYTTKGRT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2AC18F0", Offset = "0x2AC06F0", VA = "0x182AC18F0")]
				internal bool OADZBMZMXGK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2AC18A0", Offset = "0x2AC06A0", VA = "0x182AC18A0")]
				internal string NZYSEGFPNVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1830", Offset = "0x2AC0630", VA = "0x182AC1830")]
				internal void NZTLGZLSEJS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2AC17E0", Offset = "0x2AC05E0", VA = "0x182AC17E0")]
				internal bool NZOEJSRUUYJ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1790", Offset = "0x2AC0590", VA = "0x182AC1790")]
				internal bool NZIXMLXXLNA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1740", Offset = "0x2AC0540", VA = "0x182AC1740")]
				internal bool NZDQPFEACBR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2AC16F0", Offset = "0x2AC04F0", VA = "0x182AC16F0")]
				internal bool NYYJRYKCSQI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1A00", Offset = "0x2AC0800", VA = "0x182AC1A00")]
				internal string OBZJCVWPEEN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1990", Offset = "0x2AC0790", VA = "0x182AC1990")]
				internal void OBUCFPCRUTE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2AC26B0", Offset = "0x2AC14B0", VA = "0x182AC26B0")]
				internal bool VBAKXMBMWKC(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2700", Offset = "0x2AC1500", VA = "0x182AC2700")]
				internal bool VBFRUSVKFVL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2610", Offset = "0x2AC1410", VA = "0x182AC2610")]
				internal bool VAPXCYNSDNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2660", Offset = "0x2AC1460", VA = "0x182AC2660")]
				internal bool VAVEAFHPMYT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2AC27F0", Offset = "0x2AC15F0", VA = "0x182AC27F0")]
				internal string VBVMMNDCIDM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2840", Offset = "0x2AC1640", VA = "0x182AC2840")]
				internal void VCATJTWZROV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2750", Offset = "0x2AC1550", VA = "0x182AC2750")]
				internal bool VBKYRZPHPGU(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2AC27A0", Offset = "0x2AC15A0", VA = "0x182AC27A0")]
				internal bool VBQFPGJEYSD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2570", Offset = "0x2AC1370", VA = "0x182AC2570")]
				internal bool UZKHTJYHYXI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2AC25C0", Offset = "0x2AC13C0", VA = "0x182AC25C0")]
				internal bool UZPOQQSFIIR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9580", Offset = "0x2AB8380", VA = "0x182AB9580")]
				internal string BBTRIWKPAGD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9510", Offset = "0x2AB8310", VA = "0x182AB9510")]
				internal void BBOKLPQRQUU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9620", Offset = "0x2AB8420", VA = "0x182AB9620")]
				internal bool BCEFDJYJTCV(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2AB95D0", Offset = "0x2AB83D0", VA = "0x182AB95D0")]
				internal bool BBYYGDEMJRM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9400", Offset = "0x2AB8200", VA = "0x182AB9400")]
				internal bool BAYPTVIZOMT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2AB93B0", Offset = "0x2AB81B0", VA = "0x182AB93B0")]
				internal bool BATIWOPCFBK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2AB94C0", Offset = "0x2AB82C0", VA = "0x182AB94C0")]
				internal string BBJDOIWUHJL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9450", Offset = "0x2AB8250", VA = "0x182AB9450")]
				internal void BBDWRCCWXYC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9360", Offset = "0x2AB8160", VA = "0x182AB9360")]
				internal bool BADOEUHKCTJ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9310", Offset = "0x2AB8110", VA = "0x182AB9310")]
				internal bool AZYHHNNMTIA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9DC0", Offset = "0x2AB8BC0", VA = "0x182AB9DC0")]
				internal bool EEMOKEORAAI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9E10", Offset = "0x2AB8C10", VA = "0x182AB9E10")]
				internal bool EERVHLIOJLR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9E60", Offset = "0x2AB8C60", VA = "0x182AB9E60")]
				internal string EEXCESCLSXA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9EB0", Offset = "0x2AB8CB0", VA = "0x182AB9EB0")]
				internal void EFCJBYWJCIJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9F20", Offset = "0x2AB8D20", VA = "0x182AB9F20")]
				internal bool EFHPZFQGLTS(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9F70", Offset = "0x2AB8D70", VA = "0x182AB9F70")]
				internal bool EFMWWMKDVFB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9FC0", Offset = "0x2AB8DC0", VA = "0x182AB9FC0")]
				internal bool EFSDTTEBEQK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA010", Offset = "0x2AB8E10", VA = "0x182ABA010")]
				internal bool EFXKQZXYOBT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA060", Offset = "0x2AB8E60", VA = "0x182ABA060")]
				internal string EGCROGRVXNC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2ABA0B0", Offset = "0x2AB8EB0", VA = "0x182ABA0B0")]
				internal void EGHYLNLTGYL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0FF0", Offset = "0x2ABFDF0", VA = "0x182AC0FF0")]
				internal bool KFFUVOXTDWJ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0FA0", Offset = "0x2ABFDA0", VA = "0x182AC0FA0")]
				internal bool KFANYIDVULA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0F50", Offset = "0x2ABFD50", VA = "0x182AC0F50")]
				internal bool KEVHBBJYKZR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0F00", Offset = "0x2ABFD00", VA = "0x182AC0F00")]
				internal bool KEQADUQBBOI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1150", Offset = "0x2ABFF50", VA = "0x182AC1150")]
				internal string KGAWKPZIPPT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2AC10E0", Offset = "0x2ABFEE0", VA = "0x182AC10E0")]
				internal void KFVPNJFLGEK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1090", Offset = "0x2ABFE90", VA = "0x182AC1090")]
				internal bool KFQIQCLNWTB(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1040", Offset = "0x2ABFE40", VA = "0x182AC1040")]
				internal bool KFLBSVRQNHS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x2AC11F0", Offset = "0x2ABFFF0", VA = "0x182AC11F0")]
				internal bool KGVXZRAYBJD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2AC11A0", Offset = "0x2ABFFA0", VA = "0x182AC11A0")]
				internal bool KGQRCKHARXU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9730", Offset = "0x2AB8530", VA = "0x182AB9730")]
				internal string CFGGSBJYUTL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x2AB96C0", Offset = "0x2AB84C0", VA = "0x182AB96C0")]
				internal void CFAZUUQBLIC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9670", Offset = "0x2AB8470", VA = "0x182AB9670")]
				internal bool CEQMAHCGSLK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9890", Offset = "0x2AB8690", VA = "0x182AB9890")]
				internal bool CGBIHCLOGMV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9840", Offset = "0x2AB8640", VA = "0x182AB9840")]
				internal bool CFWBJVRQXBM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2AB97F0", Offset = "0x2AB85F0", VA = "0x182AB97F0")]
				internal string CFQUMOXTNQD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9780", Offset = "0x2AB8580", VA = "0x182AB9780")]
				internal void CFLNPIDWEEU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9930", Offset = "0x2AB8730", VA = "0x182AB9930")]
				internal bool CGWJWDNDSGF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2AB98E0", Offset = "0x2AB86E0", VA = "0x182AB98E0")]
				internal bool CGRCYWTGIUW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2AC28B0", Offset = "0x2AC16B0", VA = "0x182AC28B0")]
				internal bool VEPBTJBWFBC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2900", Offset = "0x2AC1700", VA = "0x182AC2900")]
				internal string VEUIQPVTOML()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2950", Offset = "0x2AC1750", VA = "0x182AC2950")]
				internal void VEZPNWPQXXU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x2AC29C0", Offset = "0x2AC17C0", VA = "0x182AC29C0")]
				internal bool VFEWLDJOHJD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2A10", Offset = "0x2AC1810", VA = "0x182AC2A10")]
				internal bool VFKDIKDLQUM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2A60", Offset = "0x2AC1860", VA = "0x182AC2A60")]
				internal bool VFPKFQXJAFV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2AB0", Offset = "0x2AC18B0", VA = "0x182AC2AB0")]
				internal string VFURCXRGJRE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2B00", Offset = "0x2AC1900", VA = "0x182AC2B00")]
				internal void VFZYAELDTCN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2B70", Offset = "0x2AC1970", VA = "0x182AC2B70")]
				internal bool VGKLURYYLZF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2AC1B40", Offset = "0x2AC0940", VA = "0x182AC1B40")]
				internal bool PGQSCEBDOHV(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9D70", Offset = "0x2AB8B70", VA = "0x182AB9D70")]
				internal float DHOOFBDOAVV()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9D10", Offset = "0x2AB8B10", VA = "0x182AB9D10")]
				internal void DHJHHUJQRKM(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9CC0", Offset = "0x2AB8AC0", VA = "0x182AB9CC0")]
				internal bool DHEAKNPTHZD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9C70", Offset = "0x2AB8A70", VA = "0x182AB9C70")]
				internal bool DGYTNGVVYNU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9C20", Offset = "0x2AB8A20", VA = "0x182AB9C20")]
				internal bool DGTMQABYPCL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9BD0", Offset = "0x2AB89D0", VA = "0x182AB9BD0")]
				internal int DGOFSTIBFRC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9B70", Offset = "0x2AB8970", VA = "0x182AB9B70")]
				internal void DGIYVMODWFT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2AB9B20", Offset = "0x2AB8920", VA = "0x182AB9B20")]
				internal bool DGDRYFUGMUK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2BC0", Offset = "0x2AC19C0", VA = "0x182AC2BC0")]
				internal bool WHHXAWJGEAE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2AC2C10", Offset = "0x2AC1A10", VA = "0x182AC2C10")]
				internal bool WHNDYDDDNLN()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class OMBFAUIWRFS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string KBGFOQETFIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public OMGLYBCUARB JOWOLGJKVOM;

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public OMBFAUIWRFS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2ADA450", Offset = "0x2AD9250", VA = "0x182ADA450")]
				internal void AKUJVJKJXGE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class OMQZSOQOTNT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] HVUBBKMYPCM;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public OMQZSOQOTNT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB2D0", Offset = "0x2ADA0D0", VA = "0x182ADB2D0")]
				internal bool DHTVCHXLKHE(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers NUYCDTYWOLT;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3550", Offset = "0x2AB2350", VA = "0x182AB3550")]
			public FZLSKWRDJRR(RGZHVGRSJVI a, MLELVYDBMIY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1960", Offset = "0x2AB0760", VA = "0x182AB1960", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class EEIONUKGVEE : EOGMAVBNCPD<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool BKBUYOBQYPX
			{
				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4790", Offset = "0x2AD3590", VA = "0x182AD4790")]
			public EEIONUKGVEE(RGZHVGRSJVI a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3EE0", Offset = "0x2AD2CE0", VA = "0x182AD3EE0", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4690", Offset = "0x2AD3490", VA = "0x182AD4690")]
			private static string UJZTTNOEWXC(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2AD42A0", Offset = "0x2AD30A0", VA = "0x182AD42A0")]
			[CompilerGenerated]
			private object? QNRQEWXUWET()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4190", Offset = "0x2AD2F90", VA = "0x182AD4190")]
			[CompilerGenerated]
			private void QNMJHQDXMTK(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2AD43E0", Offset = "0x2AD31E0", VA = "0x182AD43E0")]
			[CompilerGenerated]
			private string QOCDZKLPPBL(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4340", Offset = "0x2AD3140", VA = "0x182AD4340")]
			[CompilerGenerated]
			private IReadOnlyList<object> QNWXCDRSFQC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4630", Offset = "0x2AD3430", VA = "0x182AD4630")]
			[CompilerGenerated]
			private string? QOMRTXZKHYD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2AD45F0", Offset = "0x2AD33F0", VA = "0x182AD45F0")]
			[CompilerGenerated]
			private bool QOHKWRFMYMU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class KNONXMNELXE : EOGMAVBNCPD<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class RYMNRJREOIY
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
					public RYMNRJREOIY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60002FE")]
					[Cpp2IlInjected.Address(RVA = "0x2AE4700", Offset = "0x2AE3500", VA = "0x182AE4700", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60002FF")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public KNONXMNELXE SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RYMNRJREOIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x2ADC9E0", Offset = "0x2ADB7E0", VA = "0x182ADC9E0")]
				internal string AIVVSQNXYVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0x2ADC4E0", Offset = "0x2ADB2E0", VA = "0x182ADC4E0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void AIQOVJUAPJS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x2ADCEC0", Offset = "0x2ADBCC0", VA = "0x182ADCEC0")]
				internal int AJGJNEBSRRT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2ADCB40", Offset = "0x2ADB940", VA = "0x182ADCB40")]
				internal void AJBCPXHVIGK(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2AD8E30", Offset = "0x2AD7C30", VA = "0x182AD8E30")]
			public KNONXMNELXE(RGZHVGRSJVI a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2AD8B00", Offset = "0x2AD7900", VA = "0x182AD8B00", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class UNGCDGZCAZF : EOGMAVBNCPD<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class OPUURPABOAR
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
					public OPUURPABOAR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000313")]
					[Cpp2IlInjected.Address(RVA = "0x2AE43C0", Offset = "0x2AE31C0", VA = "0x182AE43C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000314")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public OPUURPABOAR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2AE4CB0", Offset = "0x2AE3AB0", VA = "0x182AE4CB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public UNGCDGZCAZF SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public OPUURPABOAR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB4F0", Offset = "0x2ADA2F0", VA = "0x182ADB4F0")]
				internal string AIVVSQNXYVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB420", Offset = "0x2ADA220", VA = "0x182ADB420")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void AIQOVJUAPJS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB5D0", Offset = "0x2ADA3D0", VA = "0x182ADB5D0")]
				internal int AJGJNEBSRRT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB540", Offset = "0x2ADA340", VA = "0x182ADB540")]
				internal Task<bool> AJBCPXHVIGK(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB6F0", Offset = "0x2ADA4F0", VA = "0x182ADB6F0")]
				internal string AJQXHRPNKOL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB620", Offset = "0x2ADA420", VA = "0x182ADB620")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void AJLQKKVQBDC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB7D0", Offset = "0x2ADA5D0", VA = "0x182ADB7D0")]
				internal bool AKBLCFDIDLD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB740", Offset = "0x2ADA540", VA = "0x182ADB740")]
				internal void AJWEEYJKTZU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB3D0", Offset = "0x2ADA1D0", VA = "0x182ADB3D0")]
				internal bool AHFSOOKTBIH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB340", Offset = "0x2ADA140", VA = "0x182ADB340")]
				internal void AHALRHQVRWY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB820", Offset = "0x2ADA620", VA = "0x182ADB820")]
				internal float EMTTFILJCOM()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB870", Offset = "0x2ADA670", VA = "0x182ADB870")]
				internal void EMZACPFGLZV(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB900", Offset = "0x2ADA700", VA = "0x182ADB900")]
				internal int ENEGZVZDVLE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB960", Offset = "0x2ADA760", VA = "0x182ADB960")]
				internal void ENJNXCTBEWN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2ADBA00", Offset = "0x2ADA800", VA = "0x182ADBA00")]
				internal bool ENOUUJMYOHW()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6080", Offset = "0x2AE4E80", VA = "0x182AE6080")]
			public UNGCDGZCAZF(RGZHVGRSJVI a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5720", Offset = "0x2AE4520", VA = "0x182AE5720", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class AHKEQYOPIVI : EOGMAVBNCPD<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class RYMNRJREOIY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public AHKEQYOPIVI SVDPBWSVAHX;

				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RYMNRJREOIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x2ADC8F0", Offset = "0x2ADB6F0", VA = "0x182ADC8F0")]
				internal Dictionary<string, EnumChoiceData> AIVVSQNXYVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0x2ADC5B0", Offset = "0x2ADB3B0", VA = "0x182ADC5B0")]
				internal int AIQOVJUAPJS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x2ADCD40", Offset = "0x2ADBB40", VA = "0x182ADCD40")]
				internal void AJGJNEBSRRT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2ADCC70", Offset = "0x2ADBA70", VA = "0x182ADCC70")]
				internal bool AJBCPXHVIGK()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x2AD24D0", Offset = "0x2AD12D0", VA = "0x182AD24D0")]
			public AHKEQYOPIVI(RGZHVGRSJVI a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2220", Offset = "0x2AD1020", VA = "0x182AD2220", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class AVZRIFVMRGH : EOGMAVBNCPD<JWEVBLMZFQU>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class RYMNRJREOIY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public AVZRIFVMRGH SVDPBWSVAHX;

				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RYMNRJREOIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x2ADCA30", Offset = "0x2ADB830", VA = "0x182ADCA30")]
				internal void AIVVSQNXYVB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x2AD26C0", Offset = "0x2AD14C0", VA = "0x182AD26C0")]
			public AVZRIFVMRGH(RGZHVGRSJVI a, JWEVBLMZFQU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2540", Offset = "0x2AD1340", VA = "0x182AD2540", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class RYQLAVFCWGZ<a> : XSMRIYLPWPA<a> where a : notnull, SYGABIASZCL
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override GEIPSZYFMAS? SSDVDSJHOQL
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x5D878A0", Offset = "0x5D866A0", VA = "0x185D878A0", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0x5D878F0", Offset = "0x5D866F0", VA = "0x185D878F0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0xF7F680", Offset = "0xF7E480", VA = "0x180F7F680", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x5D878E0", Offset = "0x5D866E0", VA = "0x185D878E0")]
			public RYQLAVFCWGZ(RGZHVGRSJVI a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class MCOVWCLOMFX : RYQLAVFCWGZ<OCIFJFJKOVU>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class OMGLYBCUARB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public MCOVWCLOMFX SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public OMGLYBCUARB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB0F0", Offset = "0x2AD9EF0", VA = "0x182ADB0F0")]
				internal object AIVVSQNXYVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB030", Offset = "0x2AD9E30", VA = "0x182ADB030")]
				internal void AIQOVJUAPJS(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB150", Offset = "0x2AD9F50", VA = "0x182ADB150")]
				internal void AJGJNEBSRRT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? VTLFGEQETUN;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9BA0", Offset = "0x2AD89A0", VA = "0x182AD9BA0")]
			public MCOVWCLOMFX(RGZHVGRSJVI a, OCIFJFJKOVU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9620", Offset = "0x2AD8420", VA = "0x182AD9620", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class NAMNEDPTXOA : EOGMAVBNCPD<DGHXCSOKZIN>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public NAMNEDPTXOA SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<IMTHRFIEELI>> IGZJXRKHEIU;

				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7C10", Offset = "0x2AD6A10", VA = "0x182AD7C10")]
				internal int AIQOVJUAPJS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0x2AD8060", Offset = "0x2AD6E60", VA = "0x182AD8060")]
				internal void AJGJNEBSRRT(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class JTFBBPORJUZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<IMTHRFIEELI> UEAQTRLZKLQ;

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JTFBBPORJUZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2AD89F0", Offset = "0x2AD77F0", VA = "0x182AD89F0")]
				internal bool AJQXHRPNKOL(Id32<IMTHRFIEELI> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x2ADA130", Offset = "0x2AD8F30", VA = "0x182ADA130")]
			public NAMNEDPTXOA(RGZHVGRSJVI a, DGHXCSOKZIN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9C00", Offset = "0x2AD8A00", VA = "0x182AD9C00", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class OBMSNVBHUVW : EOGMAVBNCPD<XIXCXTBGKNX>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xE73400", Offset = "0xE72200", VA = "0x180E73400", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x2ADA1A0", Offset = "0x2AD8FA0", VA = "0x182ADA1A0")]
			public OBMSNVBHUVW(RGZHVGRSJVI a, XIXCXTBGKNX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class BHMXTFSSCOH : EOGMAVBNCPD<WFXUZKCRWUM>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033D")]
				[Cpp2IlInjected.Address(RVA = "0xC07F00", Offset = "0xC06D00", VA = "0x180C07F00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2A80", Offset = "0x2AD1880", VA = "0x182AD2A80")]
			public BHMXTFSSCOH(RGZHVGRSJVI a, WFXUZKCRWUM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "134")]
			protected override bool IHUKBKBQUAP(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class BLEOJODBEFB : EOGMAVBNCPD<BCQPMUBBPRG>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000341")]
				[Cpp2IlInjected.Address(RVA = "0xD864B0", Offset = "0xD852B0", VA = "0x180D864B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000342")]
				[Cpp2IlInjected.Address(RVA = "0x2AD2BD0", Offset = "0x2AD19D0", VA = "0x182AD2BD0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool BKBUYOBQYPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2B60", Offset = "0x2AD1960", VA = "0x182AD2B60")]
			public BLEOJODBEFB(RGZHVGRSJVI a, BCQPMUBBPRG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class BPMFUPWGRNJ : EOGMAVBNCPD<VQTQWVGKAWM>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0xB00150", Offset = "0xAFEF50", VA = "0x180B00150", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x2AD2F00", Offset = "0x2AD1D00", VA = "0x182AD2F00", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool BKBUYOBQYPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2E90", Offset = "0x2AD1C90", VA = "0x182AD2E90")]
			public BPMFUPWGRNJ(RGZHVGRSJVI a, VQTQWVGKAWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class MAETTJRXWBY : WWMERNBFBAB<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public MAETTJRXWBY SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x600034D")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600034E")]
				[Cpp2IlInjected.Address(RVA = "0x2AD87B0", Offset = "0x2AD75B0", VA = "0x182AD87B0")]
				internal float OEQLGKTAGEC()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0x2AD8950", Offset = "0x2AD7750", VA = "0x182AD8950")]
				internal void OEVSDRMXPPL(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2AD95C0", Offset = "0x2AD83C0", VA = "0x182AD95C0")]
			public MAETTJRXWBY(RGZHVGRSJVI a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9350", Offset = "0x2AD8150", VA = "0x182AD9350", Slot = "151")]
			protected override void XSDVTBNRAWC(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class VCZWJYBVMBF : EOGMAVBNCPD<ZXKIZKHXATK>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x2AE60F0", Offset = "0x2AE4EF0", VA = "0x182AE60F0")]
			public VCZWJYBVMBF(RGZHVGRSJVI a, ZXKIZKHXATK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class KESBFKMALDF : EOGMAVBNCPD<XPBZRDCXQOE>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000353")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x2AD8A90", Offset = "0x2AD7890", VA = "0x182AD8A90")]
			public KESBFKMALDF(RGZHVGRSJVI a, XPBZRDCXQOE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class LJIIGMDZARM : EOGMAVBNCPD<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public LJIIGMDZARM SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x6000358")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000359")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7DF0", Offset = "0x2AD6BF0", VA = "0x182AD7DF0")]
				internal bool AIVVSQNXYVB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7630", Offset = "0x2AD6430", VA = "0x182AD7630")]
				internal void AIQOVJUAPJS(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2AD9130", Offset = "0x2AD7F30", VA = "0x182AD9130")]
			public LJIIGMDZARM(RGZHVGRSJVI a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x2AD8EA0", Offset = "0x2AD7CA0", VA = "0x182AD8EA0", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class IGFKQLAMSJE : EOGMAVBNCPD<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public IGFKQLAMSJE SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> JOOMIEHQAKD;

				[Cpp2IlInjected.Token(Token = "0x600035D")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7E40", Offset = "0x2AD6C40", VA = "0x182AD7E40")]
				internal object? AIVVSQNXYVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x2AD8530", Offset = "0x2AD7330", VA = "0x182AD8530")]
				internal bool AJWEEYJKTZU(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7760", Offset = "0x2AD6560", VA = "0x182AD7760")]
				internal void AIQOVJUAPJS(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2AD8320", Offset = "0x2AD7120", VA = "0x182AD8320")]
				internal string AJGJNEBSRRT(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2AD8010", Offset = "0x2AD6E10", VA = "0x182AD8010")]
				internal IReadOnlyList<object> AJBCPXHVIGK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2AD84C0", Offset = "0x2AD72C0", VA = "0x182AD84C0")]
				internal bool AJQXHRPNKOL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2AD8470", Offset = "0x2AD7270", VA = "0x182AD8470")]
				internal bool AJLQKKVQBDC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x2AD85B0", Offset = "0x2AD73B0", VA = "0x182AD85B0")]
				internal void AKBLCFDIDLD(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x2AD5B00", Offset = "0x2AD4900", VA = "0x182AD5B00")]
			public IGFKQLAMSJE(RGZHVGRSJVI a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x2AD5410", Offset = "0x2AD4210", VA = "0x182AD5410", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class QFJSWATWBYQ : EOGMAVBNCPD<IOIBVUHSWSJ>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class OPUURPABOAR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int VLDMKPMGSMK;

				[Cpp2IlInjected.Token(Token = "0x600036B")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public OPUURPABOAR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036C")]
				[Cpp2IlInjected.Address(RVA = "0x2ADBA70", Offset = "0x2ADA870", VA = "0x182ADBA70")]
				internal bool LAIYDGHDMHM(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class BLFBRGQSUPA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public QFJSWATWBYQ SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> TXDAEYYFXBW;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public BLFBRGQSUPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x2AD2D40", Offset = "0x2AD1B40", VA = "0x182AD2D40")]
				internal int AIVVSQNXYVB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0x2AD2C20", Offset = "0x2AD1A20", VA = "0x182AD2C20")]
				internal void AIQOVJUAPJS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x2AD2DE0", Offset = "0x2AD1BE0", VA = "0x182AD2DE0")]
				internal string? AJGJNEBSRRT()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x2ADC330", Offset = "0x2ADB130", VA = "0x182ADC330")]
			public QFJSWATWBYQ(RGZHVGRSJVI a, IOIBVUHSWSJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2ADBE30", Offset = "0x2ADAC30", VA = "0x182ADBE30")]
			private int BNYELKSLSWI(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x2ADC210", Offset = "0x2ADB010", VA = "0x182ADC210")]
			private void PYEIHQQRLVQ(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2ADBEC0", Offset = "0x2ADACC0", VA = "0x182ADBEC0", Slot = "145")]
			protected sealed override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class JPZCHPXKWXP : BQWSCWSGSFR<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0xF9D8D0", Offset = "0xF9C6D0", VA = "0x180F9D8D0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x2AD74B0", Offset = "0x2AD62B0", VA = "0x182AD74B0")]
			public JPZCHPXKWXP(RGZHVGRSJVI a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class ECGIKDWBHKL : WWMERNBFBAB<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public ECGIKDWBHKL SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x6000375")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000376")]
				[Cpp2IlInjected.Address(RVA = "0x2AD8830", Offset = "0x2AD7630", VA = "0x182AD8830")]
				internal int OEQLGKTAGEC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0x2AD88B0", Offset = "0x2AD76B0", VA = "0x182AD88B0")]
				internal void OEVSDRMXPPL(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3E80", Offset = "0x2AD2C80", VA = "0x182AD3E80")]
			public ECGIKDWBHKL(RGZHVGRSJVI a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3C10", Offset = "0x2AD2A10", VA = "0x182AD3C10", Slot = "151")]
			protected override void XSDVTBNRAWC(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class JJFDIEWOLOJ : EOGMAVBNCPD<QYGEJXLVKBY>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public JJFDIEWOLOJ SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<IMTHRFIEELI>> IGZJXRKHEIU;

				[Cpp2IlInjected.Token(Token = "0x600037E")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600037F")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7AD0", Offset = "0x2AD68D0", VA = "0x182AD7AD0")]
				internal int AIQOVJUAPJS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0x2AD81C0", Offset = "0x2AD6FC0", VA = "0x182AD81C0")]
				internal void AJGJNEBSRRT(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class JTFBBPORJUZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<IMTHRFIEELI> UEAQTRLZKLQ;

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JTFBBPORJUZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x2AD8A40", Offset = "0x2AD7840", VA = "0x182AD8A40")]
				internal bool AJQXHRPNKOL(Id32<IMTHRFIEELI> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x2AD7440", Offset = "0x2AD6240", VA = "0x182AD7440")]
			public JJFDIEWOLOJ(RGZHVGRSJVI a, QYGEJXLVKBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x2AD6F10", Offset = "0x2AD5D10", VA = "0x182AD6F10", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class JDDXWPALUBB : EOGMAVBNCPD<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public JDDXWPALUBB SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x6000385")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000386")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7FC0", Offset = "0x2AD6DC0", VA = "0x182AD7FC0")]
				internal bool AIVVSQNXYVB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0x2AD75A0", Offset = "0x2AD63A0", VA = "0x182AD75A0")]
				internal void AIQOVJUAPJS(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2AD6EA0", Offset = "0x2AD5CA0", VA = "0x182AD6EA0")]
			public JDDXWPALUBB(RGZHVGRSJVI a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x2AD6CD0", Offset = "0x2AD5AD0", VA = "0x182AD6CD0", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class OKUZYNMHEHR : EOGMAVBNCPD<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public OKUZYNMHEHR SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x600038A")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038B")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7F70", Offset = "0x2AD6D70", VA = "0x182AD7F70")]
				internal bool AIVVSQNXYVB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7A40", Offset = "0x2AD6840", VA = "0x182AD7A40")]
				internal void AIQOVJUAPJS(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2ADA3E0", Offset = "0x2AD91E0", VA = "0x182ADA3E0")]
			public OKUZYNMHEHR(RGZHVGRSJVI a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x2ADA210", Offset = "0x2AD9010", VA = "0x182ADA210", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class FRQAXUBHHSN : EOGMAVBNCPD<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public FRQAXUBHHSN SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x600038F")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000390")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7DA0", Offset = "0x2AD6BA0", VA = "0x182AD7DA0")]
				internal int AIVVSQNXYVB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0x2AD79B0", Offset = "0x2AD67B0", VA = "0x182AD79B0")]
				internal void AIQOVJUAPJS(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x2AD51B0", Offset = "0x2AD3FB0", VA = "0x182AD51B0")]
			public FRQAXUBHHSN(RGZHVGRSJVI a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4F60", Offset = "0x2AD3D60", VA = "0x182AD4F60", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class UNFLVGVFJPM
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log YLLVKVFSHML;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class MGLTLQTITGJ<a> : EOGMAVBNCPD<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class HOHSCUKUCJO
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
					public HOHSCUKUCJO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C6")]
					[Cpp2IlInjected.Address(RVA = "0x3F92C80", Offset = "0x3F91A80", VA = "0x183F92C80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C7")]
					[Cpp2IlInjected.Address(RVA = "0x3F92FB0", Offset = "0x3F91DB0", VA = "0x183F92FB0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload WRIZMFGVEDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public MGLTLQTITGJ<a> SVDPBWSVAHX;

				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public HOHSCUKUCJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x511A880", Offset = "0x5119680", VA = "0x18511A880")]
				[AsyncStateMachine(typeof(MGLTLQTITGJ<>.HOHSCUKUCJO.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task QXIGAPALKOV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0x511A760", Offset = "0x5119560", VA = "0x18511A760")]
				internal void GXDUSUPVHSW()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class VALUUDZVZTY
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
					public VALUUDZVZTY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003D9")]
					[Cpp2IlInjected.Address(RVA = "0x3FA5620", Offset = "0x3FA4420", VA = "0x183FA5620", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DA")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public VALUUDZVZTY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x3FA6D50", Offset = "0x3FA5B50", VA = "0x183FA6D50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0x3FA7450", Offset = "0x3FA6250", VA = "0x183FA7450", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public MSLEAENUAIG.JVUNXFPVLGY YSMJAIXNONZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string BWLTDZQNNUE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string DPUBJAJVAEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public MGLTLQTITGJ<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper FELHJDBKRXG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool ULTYJIUURDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action GJKWBUDGQGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool QQXKQRBPTIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string WFNRSZUKYCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action XSMYNWISQEA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action CVPABGNWWYQ;

				[Cpp2IlInjected.Token(Token = "0x60003C8")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public VALUUDZVZTY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C9")]
				[Cpp2IlInjected.Address(RVA = "0x63F6910", Offset = "0x63F5710", VA = "0x1863F6910")]
				internal void OUVHYOIDERD(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0x63F68A0", Offset = "0x63F56A0", VA = "0x1863F68A0")]
				internal void OUQBBHOFVFU(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
				internal string WHPWUCAARYQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x63F6CE0", Offset = "0x63F5AE0", VA = "0x1863F6CE0")]
				internal void WHVDRITYBJZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0x5B21AA0", Offset = "0x5B208A0", VA = "0x185B21AA0")]
				internal bool WIAKOPNVKVI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x63F6ED0", Offset = "0x63F5CD0", VA = "0x1863F6ED0")]
				internal char WIFRLWHSUGR((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
				internal string? WGUVFAYLGFG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0xF9B8B0", Offset = "0xF9A6B0", VA = "0x180F9B8B0")]
				internal bool WHACCHSIPQP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0x63F6C20", Offset = "0x63F5A20", VA = "0x1863F6C20")]
				internal void WHFIZOMFZBY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0x5B21AA0", Offset = "0x5B208A0", VA = "0x185B21AA0")]
				internal bool WHKPWVGDINH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x63F6B40", Offset = "0x63F5940", VA = "0x1863F6B40")]
				[AsyncStateMachine(typeof(MGLTLQTITGJ<>.VALUUDZVZTY.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void WFZTPZWVULW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x63F67A0", Offset = "0x63F55A0", VA = "0x1863F67A0")]
				internal void LSOGXLCLHTW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x63F66D0", Offset = "0x63F54D0", VA = "0x1863F66D0")]
				[AsyncStateMachine(typeof(MGLTLQTITGJ<>.VALUUDZVZTY.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task CDOCCVZBNRL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x63F6960", Offset = "0x63F5760", VA = "0x1863F6960")]
				internal void OWGEFJRKSSO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x63F6A80", Offset = "0x63F5880", VA = "0x1863F6A80")]
				internal void VVMMXGQFUJM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x63F6BE0", Offset = "0x63F59E0", VA = "0x1863F6BE0")]
				internal bool WGFANGQTDXF()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class RLHPEAVZJMP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter FLWGQLWRDES;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public MGLTLQTITGJ<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<MSLEAENUAIG.LOXWEJZVWKW> XRCCHAZLCCP;

				[Cpp2IlInjected.Token(Token = "0x60003DD")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RLHPEAVZJMP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DE")]
				[Cpp2IlInjected.Address(RVA = "0x5D45970", Offset = "0x5D44770", VA = "0x185D45970")]
				internal bool YYBKLHAFMOF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0x5D458B0", Offset = "0x5D446B0", VA = "0x185D458B0")]
				internal void RMENTGAXJHN(MSLEAENUAIG.LOXWEJZVWKW a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class RLCIGUCCABG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool ZKREPRLNMCU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public MNNBDWWYAWZ AUEGRXYFPSO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public MNNBDWWYAWZ MPNWQNVRCUD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public MNNBDWWYAWZ AAZIIJRQDMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string OHIOYJHTQQT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public RLHPEAVZJMP JOWOLGJKVOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action JMNVJOQQKAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action XRHJEHTILNY;

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RLCIGUCCABG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0xB57510", Offset = "0xB56310", VA = "0x180B57510")]
				internal bool XAMRATEPYCX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x5D447D0", Offset = "0x5D435D0", VA = "0x185D447D0")]
				internal void QEGKJAEEGXI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0x5D448F0", Offset = "0x5D436F0", VA = "0x185D448F0")]
				internal void YXLPTMSNKGE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x5D448D0", Offset = "0x5D436D0", VA = "0x185D448D0")]
				internal void ZAMPEKEZVUJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x5D45380", Offset = "0x5D44180", VA = "0x185D45380")]
				internal void YYLYFUOAFKX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x5D44D40", Offset = "0x5D43B40", VA = "0x185D44D40")]
				internal void YXWDOAGIDCW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x5D448D0", Offset = "0x5D436D0", VA = "0x185D448D0")]
				internal void RMJUQMUUSSW()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class RLSCYOJUCJH
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
					public RLSCYOJUCJH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003EB")]
					[Cpp2IlInjected.Address(RVA = "0x3FB4C40", Offset = "0x3FB3A40", VA = "0x183FB4C40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EC")]
					[Cpp2IlInjected.Address(RVA = "0x3FB5270", Offset = "0x3FB4070", VA = "0x183FB5270", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool IEYQMEXZWTG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public RLCIGUCCABG JPMJDARCXWN;

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RLSCYOJUCJH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x5D47660", Offset = "0x5D46460", VA = "0x185D47660")]
				[AsyncStateMachine(typeof(MGLTLQTITGJ<>.RLSCYOJUCJH.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task ZUGKOJBIYAC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x5D475F0", Offset = "0x5D463F0", VA = "0x185D475F0")]
				internal void ZAHIHDLCMJA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class RLMWBHPWSXY
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
					public RLMWBHPWSXY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F0")]
					[Cpp2IlInjected.Address(RVA = "0x3FB4640", Offset = "0x3FB3440", VA = "0x183FB4640", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F1")]
					[Cpp2IlInjected.Address(RVA = "0x3FB4BE0", Offset = "0x3FB39E0", VA = "0x183FB4BE0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload FVMFFIFMNJV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public RLCIGUCCABG JPHCFTXFOLE;

				[Cpp2IlInjected.Token(Token = "0x60003ED")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RLMWBHPWSXY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EE")]
				[Cpp2IlInjected.Address(RVA = "0x5D45A20", Offset = "0x5D44820", VA = "0x185D45A20")]
				[AsyncStateMachine(typeof(MGLTLQTITGJ<>.RLMWBHPWSXY.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task TIBJUNVGYIF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0x5D459B0", Offset = "0x5D447B0", VA = "0x185D459B0")]
				internal void RMPBNTOSCEF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class LYKHAWSEHQS
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
					public LYKHAWSEHQS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F7")]
					[Cpp2IlInjected.Address(RVA = "0x3FB4160", Offset = "0x3FB2F60", VA = "0x183FB4160", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F8")]
					[Cpp2IlInjected.Address(RVA = "0x3FB45E0", Offset = "0x3FB33E0", VA = "0x183FB45E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public MGLTLQTITGJ<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload JEQOYSHSAGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public MSLEAENUAIG.LOXWEJZVWKW YSMJAIXNONZ;

				[Cpp2IlInjected.Token(Token = "0x60003F2")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public LYKHAWSEHQS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F3")]
				[Cpp2IlInjected.Address(RVA = "0x5491240", Offset = "0x5490040", VA = "0x185491240")]
				[AsyncStateMachine(typeof(MGLTLQTITGJ<>.LYKHAWSEHQS.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task KBBUKASANHF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0x54917D0", Offset = "0x54905D0", VA = "0x1854917D0")]
				internal bool VIFJYUTOQBH(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x5491660", Offset = "0x5490460", VA = "0x185491660")]
				internal void VHPPHALWNTG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x5491780", Offset = "0x5490580", VA = "0x185491780")]
				internal void VHUWEHFTXEP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class ZXGVHKFDNKZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string IHUDFJRUNXI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public MNNBDWWYAWZ KIMGNGENSAZ;

				[Cpp2IlInjected.Token(Token = "0x60003F9")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public ZXGVHKFDNKZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FA")]
				[Cpp2IlInjected.Address(RVA = "0x417ED00", Offset = "0x417DB00", VA = "0x18417ED00")]
				internal string? OQPHIVKORRO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xC4F880", Offset = "0xC4E680", VA = "0x180C4F880")]
				internal bool OQUOGCEMBCX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x417ED20", Offset = "0x417DB20", VA = "0x18417ED20")]
				internal void OQZVDIYJKOG(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool KRKTZUEGOZB;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log YLLVKVFSHML
			{
				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x592BB30", Offset = "0x592A930", VA = "0x18592BB30")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool BKBUYOBQYPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x592F740", Offset = "0x592E540", VA = "0x18592F740", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected MSLEAENUAIG OZUDTGYFQYJ
			{
				[Cpp2IlInjected.Token(Token = "0x600039B")]
				[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB8B0", VA = "0x180AACAB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039C")]
				[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB890", VA = "0x180AACA90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> WXHSEKXGRKU
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xB05F60", Offset = "0xB04D60", VA = "0x180B05F60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xB914F0", Offset = "0xB902F0", VA = "0x180B914F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected FAEFOLOYIAQ QQQJXOKAPXF
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xB07900", Offset = "0xB06700", VA = "0x180B07900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0xB083C0", Offset = "0xB071C0", VA = "0x180B083C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected MRZZXIBLOAY IDRCQEHLKKT
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xB05F70", Offset = "0xB04D70", VA = "0x180B05F70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0xB05650", Offset = "0xB04450", VA = "0x180B05650")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x5636C30", Offset = "0x5635A30", VA = "0x185636C30")]
			protected MGLTLQTITGJ(RGZHVGRSJVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x592BAE0", Offset = "0x592A8E0", VA = "0x18592BAE0", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x592BA90", Offset = "0x592A890", VA = "0x18592BA90", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x592BB80", Offset = "0x592A980", VA = "0x18592BB80", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x592B2E0", Offset = "0x592A0E0", VA = "0x18592B2E0")]
			private void AVCZEWTZEWS(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x592C9B0", Offset = "0x592B7B0", VA = "0x18592C9B0", Slot = "145")]
			protected sealed override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x592F0F0", Offset = "0x592DEF0", VA = "0x18592F0F0")]
			private void XCYGPVHTEMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x592E630", Offset = "0x592D430", VA = "0x18592E630")]
			private void VUFSESPNDGM(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "151")]
			protected virtual void LAGXFPVXCTZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x592CBB0", Offset = "0x592B9B0", VA = "0x18592CBB0")]
			private void JUXMIVEYMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x592BBD0", Offset = "0x592A9D0", VA = "0x18592BBD0")]
			private void FAJPDIBIKCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x592CD80", Offset = "0x592BB80", VA = "0x18592CD80")]
			private void KRNYPRNQXCO(MSLEAENUAIG.LOXWEJZVWKW a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x592B590", Offset = "0x592A390", VA = "0x18592B590")]
			private void BACQMMMHRQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x592CD50", Offset = "0x592BB50", VA = "0x18592CD50")]
			protected void KNBZPIWSCGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x592E5A0", Offset = "0x592D3A0", VA = "0x18592E5A0")]
			private void RXPIZQPVOSQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x592E610", Offset = "0x592D410", VA = "0x18592E610")]
			private void TZXOTWMPNRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x592DB90", Offset = "0x592C990", VA = "0x18592DB90")]
			private void KWOZHUHICCL(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x592B790", Offset = "0x592A590", VA = "0x18592B790")]
			private string BDXVWPVFVYN((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x592E4D0", Offset = "0x592D2D0", VA = "0x18592E4D0")]
			private string NZBCPXZDNOW(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x592DC60", Offset = "0x592CA60", VA = "0x18592DC60")]
			[CompilerGenerated]
			private object? MXQLFQUZTFA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x592DC90", Offset = "0x592CA90", VA = "0x18592DC90")]
			[CompilerGenerated]
			private void MXVSCXOXCQJ(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x592DBF0", Offset = "0x592C9F0", VA = "0x18592DBF0")]
			[CompilerGenerated]
			private IReadOnlyList<object> MXLEIKBCJTR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x592E3F0", Offset = "0x592D1F0", VA = "0x18592E3F0")]
			[CompilerGenerated]
			private void MYLMURWPEYK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x592E480", Offset = "0x592D280", VA = "0x18592E480")]
			[CompilerGenerated]
			private void MZLVGZSCADD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x592E560", Offset = "0x592D360", VA = "0x18592E560")]
			[CompilerGenerated]
			private void PFGRBGPBMDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x592C680", Offset = "0x592B480", VA = "0x18592C680")]
			[CompilerGenerated]
			private void HVHCLIKOWUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x592DB50", Offset = "0x592C950", VA = "0x18592DB50")]
			[CompilerGenerated]
			private void KSWBYIGSBUA(MSLEAENUAIG.LOXWEJZVWKW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class WQKKPDXGNZE : MGLTLQTITGJ<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xD864B0", Offset = "0xD852B0", VA = "0x180D864B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7EE0", Offset = "0x2AE6CE0", VA = "0x182AE7EE0")]
			public WQKKPDXGNZE(RGZHVGRSJVI a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class TWPYUUIOZEO : MGLTLQTITGJ<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type XFSJBLIIZXL
				{
					[Cpp2IlInjected.Token(Token = "0x6000405")]
					[Cpp2IlInjected.Address(RVA = "0x2ADE290", Offset = "0x2ADD090", VA = "0x182ADE290", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope DYGXSDNZLFQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000406")]
					[Cpp2IlInjected.Address(RVA = "0xA9D110", Offset = "0xA9BF10", VA = "0x180A9D110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string IVVXEUOYEWE
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000404")]
				[Cpp2IlInjected.Address(RVA = "0x1486D40", Offset = "0x1485B40", VA = "0x181486D40")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000408")]
				[Cpp2IlInjected.Address(RVA = "0x2ADE3F0", Offset = "0x2ADD1F0", VA = "0x182ADE3F0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000409")]
				[Cpp2IlInjected.Address(RVA = "0x2ADE4E0", Offset = "0x2ADD2E0", VA = "0x182ADE4E0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool ZXLVJXONPKB(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x2ADE2E0", Offset = "0x2ADD0E0", VA = "0x182ADE2E0", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x2ADE200", Offset = "0x2ADD000", VA = "0x182ADE200", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x2ADE0B0", Offset = "0x2ADCEB0", VA = "0x182ADE0B0", Slot = "7")]
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
				protected virtual Type XFSJBLIIZXL
				{
					[Cpp2IlInjected.Token(Token = "0x600040E")]
					[Cpp2IlInjected.Address(RVA = "0x2ADF4A0", Offset = "0x2ADE2A0", VA = "0x182ADF4A0", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers LZNLQKWEGYA
				{
					[Cpp2IlInjected.Token(Token = "0x600040F")]
					[Cpp2IlInjected.Address(RVA = "0xA9D110", Offset = "0xA9BF10", VA = "0x180A9D110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string IVVXEUOYEWE
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x1486D40", Offset = "0x1485B40", VA = "0x181486D40")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000411")]
				[Cpp2IlInjected.Address(RVA = "0x2ADF600", Offset = "0x2ADE400", VA = "0x182ADF600", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000412")]
				[Cpp2IlInjected.Address(RVA = "0x2ADF6F0", Offset = "0x2ADE4F0", VA = "0x182ADF6F0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool ZXLVJXONPKB(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x2ADF4F0", Offset = "0x2ADE2F0", VA = "0x182ADF4F0", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x2ADF2C0", Offset = "0x2ADE0C0", VA = "0x182ADF2C0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x2ADF350", Offset = "0x2ADE150", VA = "0x182ADF350", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class RYMNRJREOIY
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
					public RYMNRJREOIY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000423")]
					[Cpp2IlInjected.Address(RVA = "0x2AE36A0", Offset = "0x2AE24A0", VA = "0x182AE36A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000424")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public RYMNRJREOIY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x2AE3AC0", Offset = "0x2AE28C0", VA = "0x182AE3AC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public TWPYUUIOZEO SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public FAEFOLOYIAQ JRXZVTTSDRP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> JMIOMHWTAPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> JMNVJOQQKAR;

				[Cpp2IlInjected.Token(Token = "0x600041B")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RYMNRJREOIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD9C0", Offset = "0x2ADC7C0", VA = "0x182ADD9C0")]
				internal object? ZDCSSCTIJDH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0x2ADDD20", Offset = "0x2ADCB20", VA = "0x182ADDD20")]
				internal bool ZESVWEWNGQB(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD8F0", Offset = "0x2ADC6F0", VA = "0x182ADD8F0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void ZCXLUVZKZRY(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD840", Offset = "0x2ADC640", VA = "0x182ADD840")]
				internal IReadOnlyList<TargetPlayersSelection> YUGDZBLVTVV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2ADDB70", Offset = "0x2ADC970", VA = "0x182ADDB70")]
				internal object? ZDSNJXBALLI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x2ADDCC0", Offset = "0x2ADCAC0", VA = "0x182ADDCC0")]
				internal bool ZENOYYCPXES(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x2ADDAA0", Offset = "0x2ADC8A0", VA = "0x182ADDAA0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void ZDNGMQHDBZZ(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> DUHQCBXCMLL;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> UMRPJWVPCZN;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> QSCPZFQWCKD;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xB00150", Offset = "0xAFEF50", VA = "0x180B00150", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x2ADF260", Offset = "0x2ADE060", VA = "0x182ADF260")]
			public TWPYUUIOZEO(RGZHVGRSJVI a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x2ADE670", Offset = "0x2ADD470", VA = "0x182ADE670", Slot = "151")]
			protected override void LAGXFPVXCTZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x2ADEBF0", Offset = "0x2ADD9F0", VA = "0x182ADEBF0")]
			private static IReadOnlyList<TargetPlayersSelection> LWJDJYYJDAY(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class SICHLHQYMGD : AZSQARIURKK<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType KNBJQCEZLVP
			{
				[Cpp2IlInjected.Token(Token = "0x6000428")]
				[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x2ADE5B0", Offset = "0x2ADD3B0", VA = "0x182ADE5B0")]
			public SICHLHQYMGD(RGZHVGRSJVI a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class PFJATQKEZTE : EOGMAVBNCPD<ITZFJUYYDSP>
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2AF0", Offset = "0x2AD18F0", VA = "0x182AD2AF0")]
			public PFJATQKEZTE(RGZHVGRSJVI a, ITZFJUYYDSP b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class EOGMAVBNCPD<a> : WVHJGQESRCU, IDisposable where a : notnull, ITZFJUYYDSP
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class KUZIAGTACLK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public EOGMAVBNCPD<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public RGZHVGRSJVI BYYCAVELYOK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a SMJSDUHDMSD;

				[Cpp2IlInjected.Token(Token = "0x60004B5")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public KUZIAGTACLK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B6")]
				[Cpp2IlInjected.Address(RVA = "0x53C7C70", Offset = "0x53C6A70", VA = "0x1853C7C70")]
				internal ZQDUIDEOMSJ AUGHZLDZJFO(TGZIJCIGDIK a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class PFIIXRHJOWE
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
					public PFIIXRHJOWE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BB")]
					[Cpp2IlInjected.Address(RVA = "0x3F956F0", Offset = "0x3F944F0", VA = "0x183F956F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BC")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string HVFQWXGGBXC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, SJKUUBAWOPB>> ZMQYJMZZKMB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public EOGMAVBNCPD<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> ZJPAGPZDMFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public MSLEAENUAIG OZUDTGYFQYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> FFQOSVKKUBF;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public PFIIXRHJOWE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				internal string ADVKMJHQNLE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
				internal void AEARJQBNWWN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0x5C85750", Offset = "0x5C84550", VA = "0x185C85750")]
				[AsyncStateMachine(typeof(EOGMAVBNCPD<>.PFIIXRHJOWE.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void ADKWRVTVUOM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class TYUFDVYXUUV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x60004BD")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public TYUFDVYXUUV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BE")]
				[Cpp2IlInjected.Address(RVA = "0x610D850", Offset = "0x610C650", VA = "0x18610D850")]
				internal Result<string, SJKUUBAWOPB> CVXUEVWRXBS(string a)
				{
					return default(Result<string, SJKUUBAWOPB>);
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
				public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public EOGMAVBNCPD<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0x5291420", Offset = "0x5290220", VA = "0x185291420", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x5291670", Offset = "0x5290470", VA = "0x185291670", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public EOGMAVBNCPD<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x52916E0", Offset = "0x52904E0", VA = "0x1852916E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x52919E0", Offset = "0x52907E0", VA = "0x1852919E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly RGZHVGRSJVI XTDGCADPGFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool FTICIYKBCBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<TOCKAIBKNWY, ZQDUIDEOMSJ> IPKUZDBRUTN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<TOCKAIBKNWY, MEYJBPAULDI> VRESRMEAOPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> FORSSHCBMWF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<TOCKAIBKNWY>>? KKUAWOJXKZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<TOCKAIBKNWY>, MEYJBPAULDI>? ETGHBJORGJI;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected PPOKMLHFENR AISMQWVGLVE
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0x493AAB0", Offset = "0x49398B0", VA = "0x18493AAB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected AOAGTNJJCPD AOAGTNJJCPD
			{
				[Cpp2IlInjected.Token(Token = "0x600042B")]
				[Cpp2IlInjected.Address(RVA = "0x493B500", Offset = "0x493A300", VA = "0x18493B500")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected BKLHYEYAHLO IEPXSXDFBIX
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x493BFE0", Offset = "0x493ADE0", VA = "0x18493BFE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a ITZFJUYYDSP
			{
				[Cpp2IlInjected.Token(Token = "0x6000430")]
				[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<PXJWRZNPPPA> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000431")]
				[Cpp2IlInjected.Address(RVA = "0x16AFFA0", Offset = "0x16AEDA0", VA = "0x1816AFFA0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<PXJWRZNPPPA>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<HHVRSZHWLKJ> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0x493DC20", Offset = "0x493CA20", VA = "0x18493DC20", Slot = "6")]
				get
				{
					return default(Id32<HHVRSZHWLKJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0x493DA90", Offset = "0x493C890", VA = "0x18493DA90", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x493DA70", Offset = "0x493C870", VA = "0x18493DA70", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x6000438")]
				[Cpp2IlInjected.Address(RVA = "0x493DD80", Offset = "0x493CB80", VA = "0x18493DD80", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool BKBUYOBQYPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<OYBSQMSSBDV> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xB9FA80", Offset = "0xB9E880", VA = "0x180B9FA80", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<OYBSQMSSBDV>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0x106F3E0", Offset = "0x106E1E0", VA = "0x18106F3E0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xAECCD0", Offset = "0xAEBAD0", VA = "0x180AECCD0", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0x493D940", Offset = "0x493C740", VA = "0x18493D940", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0x493D970", Offset = "0x493C770", VA = "0x18493D970", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x493D9A0", Offset = "0x493C7A0", VA = "0x18493D9A0", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x493DC00", Offset = "0x493CA00", VA = "0x18493DC00", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x493DB30", Offset = "0x493C930", VA = "0x18493DB30", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x493DA10", Offset = "0x493C810", VA = "0x18493DA10", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x493D9E0", Offset = "0x493C7E0", VA = "0x18493D9E0", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x110D340", Offset = "0x110C140", VA = "0x18110D340", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x18393E0", Offset = "0x18381E0", VA = "0x1818393E0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x493D9D0", Offset = "0x493C7D0", VA = "0x18493D9D0", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0x493DAE0", Offset = "0x493C8E0", VA = "0x18493DAE0", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x493DBA0", Offset = "0x493C9A0", VA = "0x18493DBA0", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x493DBD0", Offset = "0x493C9D0", VA = "0x18493DBD0", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x493DB10", Offset = "0x493C910", VA = "0x18493DB10", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x600046F")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual SXKUGSZGSNN? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000470")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual GEIPSZYFMAS? SSDVDSJHOQL
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<LQPAJNJDNAW>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000477")]
				[Cpp2IlInjected.Address(RVA = "0x493DA40", Offset = "0x493C840", VA = "0x18493DA40", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<TROAQNNIZMC> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000478")]
				[Cpp2IlInjected.Address(RVA = "0x493DB50", Offset = "0x493C950", VA = "0x18493DB50", Slot = "68")]
				get
				{
					return default(Id128<TROAQNNIZMC>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<TROAQNNIZMC> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x493DAB0", Offset = "0x493C8B0", VA = "0x18493DAB0", Slot = "59")]
				get
				{
					return default(Id32<TROAQNNIZMC>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<TROAQNNIZMC>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<TROAQNNIZMC>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0x493A760", Offset = "0x4939560", VA = "0x18493A760", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xA9ECF0", Offset = "0xA9DAF0", VA = "0x180A9ECF0", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0xA9EC60", Offset = "0xA9DA60", VA = "0x180A9EC60")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xA9EC70", Offset = "0xA9DA70", VA = "0x180A9EC70", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xA9EC20", Offset = "0xA9DA20", VA = "0x180A9EC20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<LQPAJNJDNAW> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0x493DC60", Offset = "0x493CA60", VA = "0x18493DC60", Slot = "69")]
				get
				{
					return default(Id32<LQPAJNJDNAW>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<LQPAJNJDNAW> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0x493DB80", Offset = "0x493C980", VA = "0x18493DB80", Slot = "70")]
				get
				{
					return default(Id128<LQPAJNJDNAW>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<LQPAJNJDNAW>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x493DC80", Offset = "0x493CA80", VA = "0x18493DC80", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<TOCKAIBKNWY, MEYJBPAULDI> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x493DD40", Offset = "0x493CB40", VA = "0x18493DD40", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<TOCKAIBKNWY, MEYJBPAULDI>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<TOCKAIBKNWY>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600049E")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600049F")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action WUNOIIBUJYK
			{
				[Cpp2IlInjected.Token(Token = "0x6000458")]
				[Cpp2IlInjected.Address(RVA = "0x493BE70", Offset = "0x493AC70", VA = "0x18493BE70", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000459")]
				[Cpp2IlInjected.Address(RVA = "0x493AA10", Offset = "0x4939810", VA = "0x18493AA10", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate JSHETIKOZTJ
			{
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x493B050", Offset = "0x4939E50", VA = "0x18493B050", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045C")]
				[Cpp2IlInjected.Address(RVA = "0x493C8E0", Offset = "0x493B6E0", VA = "0x18493C8E0", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate LCHRZAUSIQM
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x493AF30", Offset = "0x4939D30", VA = "0x18493AF30", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x49396D0", Offset = "0x49384D0", VA = "0x1849396D0", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action RWVDKIUMJGQ
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x493BF10", Offset = "0x493AD10", VA = "0x18493BF10", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x493AFD0", Offset = "0x4939DD0", VA = "0x18493AFD0", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action XPLBBJLILHX
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x493CDA0", Offset = "0x493BBA0", VA = "0x18493CDA0", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x493C350", Offset = "0x493B150", VA = "0x18493C350", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<TOCKAIBKNWY>, MEYJBPAULDI> JSSWNAMFTQA
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x493A520", Offset = "0x4939320", VA = "0x18493A520", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0x493AB10", Offset = "0x4939910", VA = "0x18493AB10", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<TOCKAIBKNWY>, MEYJBPAULDI> ZHPTCUODHMH
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x4939ED0", Offset = "0x4938CD0", VA = "0x184939ED0", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x493A0D0", Offset = "0x4938ED0", VA = "0x18493A0D0", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<TOCKAIBKNWY>> OYZYAIAURCF
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x493A5E0", Offset = "0x49393E0", VA = "0x18493A5E0", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x493A6A0", Offset = "0x49394A0", VA = "0x18493A6A0", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<TOCKAIBKNWY>, Id32<TOCKAIBKNWY>> RDUVFUDINSQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x493A010", Offset = "0x4938E10", VA = "0x18493A010", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x493BBA0", Offset = "0x493A9A0", VA = "0x18493BBA0", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<TOCKAIBKNWY>, MEYJBPAULDI> ZKZDWYOJPGY
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x493C980", Offset = "0x493B780", VA = "0x18493C980", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x493B210", Offset = "0x493A010", VA = "0x18493B210", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<TOCKAIBKNWY>, Id32<TOCKAIBKNWY>> ZWNKTXMMWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x493C3F0", Offset = "0x493B1F0", VA = "0x18493C3F0", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x493ABD0", Offset = "0x49399D0", VA = "0x18493ABD0", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> ZTKPUUYJWUA
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x493BD20", Offset = "0x493AB20", VA = "0x18493BD20", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x493CB00", Offset = "0x493B900", VA = "0x18493CB00", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x493D4E0", Offset = "0x493C2E0", VA = "0x18493D4E0")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected EOGMAVBNCPD(RGZHVGRSJVI a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x493A850", Offset = "0x4939650", VA = "0x18493A850", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x4939770", Offset = "0x4938570", VA = "0x184939770", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x493C880", Offset = "0x493B680", VA = "0x18493C880", Slot = "9")]
			public Task<Result<None, SJKUUBAWOPB>> VFZCBCAZCRZ(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x4939FB0", Offset = "0x4938DB0", VA = "0x184939FB0")]
			public bool FFWONSBHUKP([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x4939FE0", Offset = "0x4938DE0", VA = "0x184939FE0")]
			public bool FISEBDOAEAO([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x493BDE0", Offset = "0x493ABE0", VA = "0x18493BDE0", Slot = "34")]
			public void RWDWBYKQPGK(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x493B400", Offset = "0x493A200", VA = "0x18493B400", Slot = "35")]
			public Task OHDBXPYBGSS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x493D390", Offset = "0x493C190", VA = "0x18493D390", Slot = "36")]
			[AsyncStateMachine(typeof(EOGMAVBNCPD<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, SJKUUBAWOPB>> ZPKPORALQNL(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "119")]
			public virtual void GKVHSQLJFCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x10F2A70", Offset = "0x10F1870", VA = "0x1810F2A70")]
			protected void QTELEZQYWGW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x235F2E0", Offset = "0x235E0E0", VA = "0x18235F2E0")]
			protected void KKQAXVDXQAR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x233B3C0", Offset = "0x233A1C0", VA = "0x18233B3C0")]
			private void RKKALNZBVPV([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x493CA40", Offset = "0x493B840", VA = "0x18493CA40", Slot = "122")]
			public virtual Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> XZBAOBIIBQI(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x4939610", Offset = "0x4938410", VA = "0x184939610", Slot = "123")]
			public virtual Task<Result<None, SJKUUBAWOPB>> CUKJUWJKPZZ(Id32<TOCKAIBKNWY> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "124")]
			public virtual void WJSNPWXDIEP(Id32<TOCKAIBKNWY> sourceId, Id32<TOCKAIBKNWY> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x493B2D0", Offset = "0x493A0D0", VA = "0x18493B2D0", Slot = "125")]
			public virtual IEnumerable<ELPAQFNEADX> MQFVROWYEII()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x493B970", Offset = "0x493A770", VA = "0x18493B970", Slot = "126")]
			public Result<None, SJKUUBAWOPB> QPFOGRJBIUN(string a)
			{
				return default(Result<None, SJKUUBAWOPB>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x493B0F0", Offset = "0x4939EF0", VA = "0x18493B0F0", Slot = "50")]
			public bool LUWFGRKZAYJ([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x493ACB0", Offset = "0x4939AB0", VA = "0x18493ACB0")]
			public bool KBICTAFALVE([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "128")]
			public virtual void VUEBDUETAWU(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "129")]
			public virtual AZFOGHQWRGL QCZBLJJGHQY([In] FDSHMFOSWPE audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x493C0D0", Offset = "0x493AED0", VA = "0x18493C0D0")]
			protected void UNOVTNPLCGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x493A760", Offset = "0x4939560", VA = "0x18493A760", Slot = "134")]
			protected virtual bool IHUKBKBQUAP(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x493CD70", Offset = "0x493BB70", VA = "0x18493CD70", Slot = "96")]
			public bool YQXUDXDVIBL(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "135")]
			protected virtual bool FMXOHQUBVKQ(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected virtual void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x493A190", Offset = "0x4938F90", VA = "0x18493A190")]
			protected void GMRUQOOZJXM(MSLEAENUAIG a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, SJKUUBAWOPB>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x493B9B0", Offset = "0x493A7B0", VA = "0x18493B9B0")]
			protected void QVIXNBAAVCI(MSLEAENUAIG a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x493B600", Offset = "0x493A400", VA = "0x18493B600", Slot = "146")]
			protected virtual void PERJOUNMLDL(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x493CD20", Offset = "0x493BB20", VA = "0x18493CD20", Slot = "90")]
			public void YHLMVRUSNOI(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x493B900", Offset = "0x493A700", VA = "0x18493B900", Slot = "91")]
			public CircuitsRigidTransform QDUFBWMUBBX()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "149")]
			public virtual bool XSQFCMPRZGF(Id32<TOCKAIBKNWY> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x493A830", Offset = "0x4939630", VA = "0x18493A830")]
			private void IRJMWBBAWPC([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x493BC60", Offset = "0x493AA60", VA = "0x18493BC60")]
			private void RMNDUEEBYIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x10F2A70", Offset = "0x10F1870", VA = "0x1810F2A70", Slot = "97")]
			private void JJTJJETONEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x493CE40", Offset = "0x493BC40", VA = "0x18493CE40", Slot = "99")]
			private void ZLDRNKDKSFX(Id32<TOCKAIBKNWY> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x4939F90", Offset = "0x4938D90", VA = "0x184939F90", Slot = "101")]
			private void FFETEBRTWYO(Id32<TOCKAIBKNWY> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x49394D0", Offset = "0x49382D0", VA = "0x1849394D0", Slot = "103")]
			private void BKPFUCYXZMQ(Id32<TOCKAIBKNWY> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x493C4B0", Offset = "0x493B2B0", VA = "0x18493C4B0", Slot = "104")]
			private void VFPFNNFTLAQ(Id32<TOCKAIBKNWY> sourceId, Id32<TOCKAIBKNWY> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x493AC90", Offset = "0x4939A90", VA = "0x18493AC90", Slot = "105")]
			private void JVEYFYMPPWJ(Id32<TOCKAIBKNWY> sourceId, Id32<TOCKAIBKNWY> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x2163070", Offset = "0x2161E70", VA = "0x182163070", Slot = "98")]
			private void VJXNQMASCMA(Id32<TOCKAIBKNWY> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x4939AB0", Offset = "0x49388B0", VA = "0x184939AB0", Slot = "100")]
			private void EXYKUMUUSRX(Id32<TOCKAIBKNWY> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x4939460", Offset = "0x4938260", VA = "0x184939460", Slot = "102")]
			private void AVGGUAFCJRJ(Id32<TOCKAIBKNWY> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x493B030", Offset = "0x4939E30", VA = "0x18493B030", Slot = "106")]
			private void LAPKLCVUQMR(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x493C230", Offset = "0x493B030", VA = "0x18493C230", Slot = "150")]
			[AsyncStateMachine(typeof(EOGMAVBNCPD<>.<RequestNameChange>d__224))]
			public Task<Result<None, SJKUUBAWOPB>> UPZGTLJXZMT(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x493B370", Offset = "0x493A170", VA = "0x18493B370", Slot = "57")]
			private void NZOPMCRUZUB(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x493A7A0", Offset = "0x49395A0", VA = "0x18493A7A0", Slot = "58")]
			private void IIHPPBWBURE(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x4939FB0", Offset = "0x4938DB0", VA = "0x184939FB0", Slot = "30")]
			private bool VHRPOAKUCPA([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x4939FE0", Offset = "0x4938DE0", VA = "0x184939FE0", Slot = "32")]
			private bool WBDXWBWRCWP([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x493BFC0", Offset = "0x493ADC0", VA = "0x18493BFC0", Slot = "51")]
			private bool TOMTCGFQTNN([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xA9ECF0", Offset = "0xA9DAF0", VA = "0x180A9ECF0")]
			[CompilerGenerated]
			private string YEQNTCEKHKD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x493CBC0", Offset = "0x493B9C0", VA = "0x18493CBC0")]
			[CompilerGenerated]
			private void YELGVVKMXYU(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class FPRXWOPOIGA : BQWSCWSGSFR<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0xF9D370", Offset = "0xF9C170", VA = "0x180F9D370", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4E90", Offset = "0x2AD3C90", VA = "0x182AD4E90")]
			public FPRXWOPOIGA(RGZHVGRSJVI a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class AZTSVCKHJGC : EOGMAVBNCPD<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class RYMNRJREOIY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BQHLISCYZTL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public AZTSVCKHJGC SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> DISPDIMCKET;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> JGBHYXKMQRN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RYMNRJREOIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C9")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> AIVVSQNXYVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0x2ADC7D0", Offset = "0x2ADB5D0", VA = "0x182ADC7D0")]
				internal int AIQOVJUAPJS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD060", Offset = "0x2ADBE60", VA = "0x182ADD060")]
				internal void AJGJNEBSRRT(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C6")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2A10", Offset = "0x2AD1810", VA = "0x182AD2A10")]
			public AZTSVCKHJGC(RGZHVGRSJVI a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2730", Offset = "0x2AD1530", VA = "0x182AD2730", Slot = "145")]
			protected sealed override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class SYJCALHPFII : XSMRIYLPWPA<YOJXWXHUCEF>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x2ADE610", Offset = "0x2ADD410", VA = "0x182ADE610")]
			public SYJCALHPFII(RGZHVGRSJVI a, YOJXWXHUCEF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class EYTNBSODYGO : EOGMAVBNCPD<ELZAICXANUP>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public EYTNBSODYGO SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x60004D1")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7D50", Offset = "0x2AD6B50", VA = "0x182AD7D50")]
				internal bool AIVVSQNXYVB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0x2AD7510", Offset = "0x2AD6310", VA = "0x182AD7510")]
				internal void AIQOVJUAPJS(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4DC0", Offset = "0x2AD3BC0", VA = "0x182AD4DC0")]
			public EYTNBSODYGO(RGZHVGRSJVI a, ELZAICXANUP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4BF0", Offset = "0x2AD39F0", VA = "0x182AD4BF0", Slot = "145")]
			protected sealed override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class IPVYJGLPLVR : EOGMAVBNCPD<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class RYMNRJREOIY
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
					public RYMNRJREOIY <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F3")]
					[Cpp2IlInjected.Address(RVA = "0x2AE4A10", Offset = "0x2AE3810", VA = "0x182AE4A10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F4")]
					[Cpp2IlInjected.Address(RVA = "0x2AE4C40", Offset = "0x2AE3A40", VA = "0x182AE4C40", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> RFCJFKUINZT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public IPVYJGLPLVR SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> KGOASQWFEUH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> WNXXONHNVLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RYMNRJREOIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D8")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> AIVVSQNXYVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0x2ADC6A0", Offset = "0x2ADB4A0", VA = "0x182ADC6A0")]
				internal int AIQOVJUAPJS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0x2ADCF10", Offset = "0x2ADBD10", VA = "0x182ADCF10")]
				internal void AJGJNEBSRRT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2ADCCF0", Offset = "0x2ADBAF0", VA = "0x182ADCCF0")]
				internal int AJBCPXHVIGK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD200", Offset = "0x2ADC000", VA = "0x182ADD200")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> AJQXHRPNKOL(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD470", Offset = "0x2ADC270", VA = "0x182ADD470")]
				internal int ELIWYNCBONB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x2ADDDD0", Offset = "0x2ADCBD0", VA = "0x182ADDDD0")]
				internal void ZIGVLCWXHSL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x2ADDD80", Offset = "0x2ADCB80", VA = "0x182ADDD80")]
				internal int ZIBONWCZYHC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x2ADDEB0", Offset = "0x2ADCCB0", VA = "0x182ADDEB0")]
				internal void ZIRJFQKSAPD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x2ADDE60", Offset = "0x2ADCC60", VA = "0x182ADDE60")]
				internal int ZIMCIJQURDU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2ADDF90", Offset = "0x2ADCD90", VA = "0x182ADDF90")]
				internal void ZJBXADYMTLV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2ADDF40", Offset = "0x2ADCD40", VA = "0x182ADDF40")]
				internal int ZIWQCXEPKAM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2ADE020", Offset = "0x2ADCE20", VA = "0x182ADE020")]
				internal void ZJMKURMHMIN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD1B0", Offset = "0x2ADBFB0", VA = "0x182ADD1B0")]
				internal float AJLQKKVQBDC()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD350", Offset = "0x2ADC150", VA = "0x182ADD350")]
				internal void AKBLCFDIDLD(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD300", Offset = "0x2ADC100", VA = "0x182ADD300")]
				internal float AJWEEYJKTZU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x2ADC450", Offset = "0x2ADB250", VA = "0x182ADC450")]
				internal void AHFSOOKTBIH(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x2ADC400", Offset = "0x2ADB200", VA = "0x182ADC400")]
				internal bool AHALRHQVRWY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD4C0", Offset = "0x2ADC2C0", VA = "0x182ADD4C0")]
				internal void EMTTFILJCOM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD550", Offset = "0x2ADC350", VA = "0x182ADD550")]
				internal int EMZACPFGLZV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD5A0", Offset = "0x2ADC3A0", VA = "0x182ADD5A0")]
				internal void ENEGZVZDVLE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD630", Offset = "0x2ADC430", VA = "0x182ADD630")]
				internal float ENJNXCTBEWN()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD680", Offset = "0x2ADC480", VA = "0x182ADD680")]
				internal void ENOUUJMYOHW(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD710", Offset = "0x2ADC510", VA = "0x182ADD710")]
				internal float ENUBRQGVXTF()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD760", Offset = "0x2ADC560", VA = "0x182ADD760")]
				internal void ENZIOXATHEO(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD7F0", Offset = "0x2ADC5F0", VA = "0x182ADD7F0")]
				internal bool EOEPMDUQQPX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2ADD3E0", Offset = "0x2ADC1E0", VA = "0x182ADD3E0")]
				internal void ELDQBGIEFBS(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x2AD6C60", Offset = "0x2AD5A60", VA = "0x182AD6C60")]
			public IPVYJGLPLVR(RGZHVGRSJVI a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AD5B70", Offset = "0x2AD4970", VA = "0x182AD5B70", Slot = "145")]
			protected sealed override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class BXCQFOLGPRY : WWMERNBFBAB<RecNetImageNode>
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
				public BXCQFOLGPRY <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004F9")]
				[Cpp2IlInjected.Address(RVA = "0x2AE4240", Offset = "0x2AE3040", VA = "0x182AE4240", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FA")]
				[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3420", Offset = "0x2AD2220", VA = "0x182AD3420")]
			public BXCQFOLGPRY(RGZHVGRSJVI a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x2AD30F0", Offset = "0x2AD1EF0", VA = "0x182AD30F0", Slot = "151")]
			protected override void XSDVTBNRAWC(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2F50", Offset = "0x2AD1D50", VA = "0x182AD2F50")]
			[CompilerGenerated]
			private string? DLOJSYCPRJU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3020", Offset = "0x2AD1E20", VA = "0x182AD3020")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void DLTQQEWNAVD(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class AZSQARIURKK<a> : EOGMAVBNCPD<a> where a : notnull, FAFFLRMSDDU
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class BLFBRGQSUPA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> RFCJFKUINZT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public AZSQARIURKK<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> KGOASQWFEUH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> WNXXONHNVLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType MAWFEZRZPKJ;

				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public BLFBRGQSUPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000500")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> AIVVSQNXYVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0x71ED200", Offset = "0x71EC000", VA = "0x1871ED200")]
				internal int AIQOVJUAPJS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0x71ED370", Offset = "0x71EC170", VA = "0x1871ED370")]
				internal void AJGJNEBSRRT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x71ED320", Offset = "0x71EC120", VA = "0x1871ED320")]
				internal void AJBCPXHVIGK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x71ED5C0", Offset = "0x71EC3C0", VA = "0x1871ED5C0")]
				internal void AJQXHRPNKOL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x71ED560", Offset = "0x71EC360", VA = "0x1871ED560")]
				internal bool AJLQKKVQBDC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x71ED6D0", Offset = "0x71EC4D0", VA = "0x1871ED6D0")]
				internal void AKBLCFDIDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x71ED560", Offset = "0x71EC360", VA = "0x1871ED560")]
				internal bool AJWEEYJKTZU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x71ED1D0", Offset = "0x71EBFD0", VA = "0x1871ED1D0")]
				internal float AHFSOOKTBIH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x71ED140", Offset = "0x71EBF40", VA = "0x1871ED140")]
				internal void AHALRHQVRWY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x71ED8C0", Offset = "0x71EC6C0", VA = "0x1871ED8C0")]
				internal float EMTTFILJCOM()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x71ED8F0", Offset = "0x71EC6F0", VA = "0x1871ED8F0")]
				internal void EMZACPFGLZV(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x71ED980", Offset = "0x71EC780", VA = "0x1871ED980")]
				internal float ENEGZVZDVLE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x71ED9B0", Offset = "0x71EC7B0", VA = "0x1871ED9B0")]
				internal void ENJNXCTBEWN(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType KNBJQCEZLVP
			{
				[Cpp2IlInjected.Token(Token = "0x60004FD")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x5636C30", Offset = "0x5635A30", VA = "0x185636C30")]
			public AZSQARIURKK(RGZHVGRSJVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x5636220", Offset = "0x5635020", VA = "0x185636220", Slot = "145")]
			protected sealed override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class FRFTZMZLWTY : EOGMAVBNCPD<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0xF93950", Offset = "0xF92750", VA = "0x180F93950", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4EF0", Offset = "0x2AD3CF0", VA = "0x182AD4EF0")]
			public FRFTZMZLWTY(RGZHVGRSJVI a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class VEGFJYFDGVF : YAGSWYMXLTV<BSVCYIJGFIF>
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6160", Offset = "0x2AE4F60", VA = "0x182AE6160")]
			public VEGFJYFDGVF(RGZHVGRSJVI a, BSVCYIJGFIF b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class DJNMKHIAKMD : YAGSWYMXLTV<RALIKYUZRWY>
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3BB0", Offset = "0x2AD29B0", VA = "0x182AD3BB0")]
			public DJNMKHIAKMD(RGZHVGRSJVI a, RALIKYUZRWY b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class YAGSWYMXLTV<a> : EOGMAVBNCPD<a> where a : notnull, OIIYCFCFLWF
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
				public YAGSWYMXLTV<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051A")]
				[Cpp2IlInjected.Address(RVA = "0x3F95500", Offset = "0x3F94300", VA = "0x183F95500", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051B")]
				[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class DSSMKGTENMR
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
					public DSSMKGTENMR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052B")]
					[Cpp2IlInjected.Address(RVA = "0x3F94200", Offset = "0x3F93000", VA = "0x183F94200", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052C")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public DSSMKGTENMR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x3F945D0", Offset = "0x3F933D0", VA = "0x183F945D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public DSSMKGTENMR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x3F94C80", Offset = "0x3F93A80", VA = "0x183F94C80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public DSSMKGTENMR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x3F95210", Offset = "0x3F94010", VA = "0x183F95210", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int VEJGVBBERIR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry QQCQHGIOZIV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public YAGSWYMXLTV<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<VJBGGKQUSTY, bool> XRHJEHTILNY;

				[Cpp2IlInjected.Token(Token = "0x6000520")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public DSSMKGTENMR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000521")]
				[Cpp2IlInjected.Address(RVA = "0x432F660", Offset = "0x432E460", VA = "0x18432F660")]
				internal bool AJBCPXHVIGK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0x432F6C0", Offset = "0x432E4C0", VA = "0x18432F6C0")]
				internal void AJQXHRPNKOL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
				internal string AJLQKKVQBDC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x432F840", Offset = "0x432E640", VA = "0x18432F840")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.DSSMKGTENMR.<<BuildConfigMenuInternal>b__6>d))]
				internal void AKBLCFDIDLD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0x432F730", Offset = "0x432E530", VA = "0x18432F730")]
				internal int AJWEEYJKTZU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x432FB10", Offset = "0x432E910", VA = "0x18432FB10")]
				internal bool ENJNXCTBEWN(VJBGGKQUSTY a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x432F5B0", Offset = "0x432E3B0", VA = "0x18432F5B0")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.DSSMKGTENMR.<<BuildConfigMenuInternal>b__8>d))]
				internal void AHFSOOKTBIH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
				internal string EMTTFILJCOM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x432F9B0", Offset = "0x432E7B0", VA = "0x18432F9B0")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.DSSMKGTENMR.<<BuildConfigMenuInternal>b__11>d))]
				internal void EMZACPFGLZV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0x432FA70", Offset = "0x432E870", VA = "0x18432FA70")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.DSSMKGTENMR.<<BuildConfigMenuInternal>b__12>d))]
				internal void ENEGZVZDVLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class IEWMQXGPNAW
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000563")]
					[Cpp2IlInjected.Address(RVA = "0x3F8E700", Offset = "0x3F8D500", VA = "0x183F8E700", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000564")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x3F8EA80", Offset = "0x3F8D880", VA = "0x183F8EA80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x3F8EE40", Offset = "0x3F8DC40", VA = "0x183F8EE40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x3F8F410", Offset = "0x3F8E210", VA = "0x183F8F410", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x3F8F690", Offset = "0x3F8E490", VA = "0x183F8F690", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x3F8FA20", Offset = "0x3F8E820", VA = "0x183F8FA20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x3F8FDA0", Offset = "0x3F8EBA0", VA = "0x183F8FDA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x3F90020", Offset = "0x3F8EE20", VA = "0x183F90020", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x3F903B0", Offset = "0x3F8F1B0", VA = "0x183F903B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x3F90730", Offset = "0x3F8F530", VA = "0x183F90730", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x3F90AB0", Offset = "0x3F8F8B0", VA = "0x183F90AB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x3F90D40", Offset = "0x3F8FB40", VA = "0x183F90D40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x3F910D0", Offset = "0x3F8FED0", VA = "0x183F910D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x3F91360", Offset = "0x3F90160", VA = "0x183F91360", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x3F916E0", Offset = "0x3F904E0", VA = "0x183F916E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x3F91A60", Offset = "0x3F90860", VA = "0x183F91A60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
					public IEWMQXGPNAW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x3F91DE0", Offset = "0x3F90BE0", VA = "0x183F91DE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public YAGSWYMXLTV<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int VEJGVBBERIR;

				[Cpp2IlInjected.Token(Token = "0x6000533")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public IEWMQXGPNAW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000534")]
				[Cpp2IlInjected.Address(RVA = "0x51DC8E0", Offset = "0x51DB6E0", VA = "0x1851DC8E0")]
				internal bool KMOWFMXRJCH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0x51DC870", Offset = "0x51DB670", VA = "0x1851DC870")]
				internal void KMJPIGDTZQY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x51DD660", Offset = "0x51DC460", VA = "0x1851DD660")]
				internal object VTVTGHTJNAW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x51DD700", Offset = "0x51DC500", VA = "0x1851DD700")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__13>d))]
				internal void VUBADONGWMF(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x51DD2B0", Offset = "0x51DC0B0", VA = "0x1851DD2B0")]
				internal string VSQDWTDZIKU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x51DD350", Offset = "0x51DC150", VA = "0x1851DD350")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__15>d))]
				internal void VSVKTZXWRWD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x51DD410", Offset = "0x51DC210", VA = "0x1851DD410")]
				internal bool VTARRGRUBHM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x51DD490", Offset = "0x51DC290", VA = "0x1851DD490")]
				internal bool VTFYONLRKSV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x51DD7C0", Offset = "0x51DC5C0", VA = "0x1851DD7C0")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__18>d))]
				internal void VVBIPWITRQY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x51DD870", Offset = "0x51DC670", VA = "0x1851DD870")]
				internal int VVGPNDCRBCH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x51DD0A0", Offset = "0x51DBEA0", VA = "0x1851DD0A0")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__20>d))]
				internal void PVMVUPEWDKX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x51DD010", Offset = "0x51DBE10", VA = "0x1851DD010")]
				internal bool PVHOXIKYTZO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x51DD200", Offset = "0x51DC000", VA = "0x1851DD200")]
				internal float PVXJPCSQWHP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x51DD150", Offset = "0x51DBF50", VA = "0x1851DD150")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__23>d))]
				internal void PVSCRVYTMWG(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x51DCE40", Offset = "0x51DBC40", VA = "0x1851DCE40")]
				internal bool PURUFODGRRN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x51DCDB0", Offset = "0x51DBBB0", VA = "0x1851DCDB0")]
				internal bool PUMNIHJJIGE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x51DCF60", Offset = "0x51DBD60", VA = "0x1851DCF60")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__26>d))]
				internal void PVCIABRBKOF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x51DCED0", Offset = "0x51DBCD0", VA = "0x1851DCED0")]
				internal int PUXBCUXEBCW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x51DCD00", Offset = "0x51DBB00", VA = "0x1851DCD00")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__28>d))]
				internal void PTWSQNBRFYD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x51DCC70", Offset = "0x51DBA70", VA = "0x1851DCC70")]
				internal bool PTRLTGHTWMU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x51DC100", Offset = "0x51DAF00", VA = "0x1851DC100")]
				internal float JUTPJEVTZOW()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x51DC190", Offset = "0x51DAF90", VA = "0x1851DC190")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__31>d))]
				internal void JUYWGLPRJAF(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x51DBFF0", Offset = "0x51DADF0", VA = "0x1851DBFF0")]
				internal bool JUJBORHZGSE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x51DC080", Offset = "0x51DAE80", VA = "0x1851DC080")]
				internal bool JUOILYBWQDN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x51DC380", Offset = "0x51DB180", VA = "0x1851DC380")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__34>d))]
				internal void JVOQYFXJLIG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x51DC430", Offset = "0x51DB230", VA = "0x1851DC430")]
				internal bool JVTXVMRGUTP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x51DC240", Offset = "0x51DB040", VA = "0x1851DC240")]
				internal bool JVEDDSJOSLO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x51DC2D0", Offset = "0x51DB0D0", VA = "0x1851DC2D0")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__37>d))]
				internal void JVJKAZDMBWX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x51DBEB0", Offset = "0x51DACB0", VA = "0x1851DBEB0")]
				internal int JTDMFCSPCCC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x51DBF40", Offset = "0x51DAD40", VA = "0x1851DBF40")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__39>d))]
				internal void JTITCJMMLNL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x51DBC10", Offset = "0x51DAA10", VA = "0x1851DBC10")]
				internal bool BXWBTHTBAWN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x51DBB80", Offset = "0x51DA980", VA = "0x1851DBB80")]
				internal float BXQUWAZDRLE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x51DBAD0", Offset = "0x51DA8D0", VA = "0x1851DBAD0")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__42>d))]
				internal void BXLNYUFGHZV(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x51DBA40", Offset = "0x51DA840", VA = "0x1851DBA40")]
				internal bool BXGHBNLIYOM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x51DBDE0", Offset = "0x51DABE0", VA = "0x1851DBDE0")]
				internal bool BYRDIIUQMPX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x51DBD30", Offset = "0x51DAB30", VA = "0x1851DBD30")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__45>d))]
				internal void BYLWLCATDEO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x51DBCA0", Offset = "0x51DAAA0", VA = "0x1851DBCA0")]
				internal bool BYGPNVGVTTF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x51DC9F0", Offset = "0x51DB7F0", VA = "0x1851DC9F0")]
				internal bool KMZKAALMBYZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x51DC940", Offset = "0x51DB740", VA = "0x1851DC940")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__3>d))]
				internal void KMUDCTROSNQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x51DC6C0", Offset = "0x51DB4C0", VA = "0x1851DC6C0")]
				internal int KLTUQLWBXIX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x51DC610", Offset = "0x51DB410", VA = "0x1851DC610")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__5>d))]
				internal void KLONTFCENXO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x51DC7E0", Offset = "0x51DB5E0", VA = "0x1851DC7E0")]
				internal bool KMEIKZJWQFP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x51DC750", Offset = "0x51DB550", VA = "0x1851DC750")]
				internal bool KLZBNSPZGUG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x51DC560", Offset = "0x51DB360", VA = "0x1851DC560")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__8>d))]
				internal void KKYTBKUMLPN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x51DC4C0", Offset = "0x51DB2C0", VA = "0x1851DC4C0")]
				internal int KKTMEEAPCEE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x51DD520", Offset = "0x51DC320", VA = "0x1851DD520")]
				[AsyncStateMachine(typeof(YAGSWYMXLTV<>.IEWMQXGPNAW.<<AddConstraintOptions>b__10>d))]
				internal void VTLFLUFOUEE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x51DD5D0", Offset = "0x51DC3D0", VA = "0x1851DD5D0")]
				internal bool VTQMJAZMDPN()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> JYGJLPNOVDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> QUJVSKGZWVY;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000514")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<VJBGGKQUSTY> EMVALVOBUHC
			{
				[Cpp2IlInjected.Token(Token = "0x6000515")]
				[Cpp2IlInjected.Address(RVA = "0x40A9950", Offset = "0x40A8750", VA = "0x1840A9950")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x40AC180", Offset = "0x40AAF80", VA = "0x1840AC180")]
			public YAGSWYMXLTV(RGZHVGRSJVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x40A98A0", Offset = "0x40A86A0", VA = "0x1840A98A0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x40A99A0", Offset = "0x40A87A0", VA = "0x1840A99A0", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x40AA9D0", Offset = "0x40A97D0", VA = "0x1840AA9D0")]
			private MRZZXIBLOAY VFJNVLEVQER(MSLEAENUAIG a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x40AC080", Offset = "0x40AAE80", VA = "0x1840AC080")]
			[AsyncStateMachine(typeof(YAGSWYMXLTV<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void VUNOMTXMQYP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x40AC120", Offset = "0x40AAF20", VA = "0x1840AC120")]
			[CompilerGenerated]
			private bool VUSVKARKAJY()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class ACRLZXPOZMV : EOGMAVBNCPD<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class OMGLYBCUARB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public ACRLZXPOZMV SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x600058A")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public OMGLYBCUARB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058B")]
				[Cpp2IlInjected.Address(RVA = "0x2ADAFE0", Offset = "0x2AD9DE0", VA = "0x182ADAFE0")]
				internal int AIQOVJUAPJS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0x2ADB240", Offset = "0x2ADA040", VA = "0x182ADB240")]
				internal void AJGJNEBSRRT(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? MAXIKPRGCZK;

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x2AD21B0", Offset = "0x2AD0FB0", VA = "0x182AD21B0")]
			public ACRLZXPOZMV(RGZHVGRSJVI a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x2AD1E50", Offset = "0x2AD0C50", VA = "0x182AD1E50", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class HKUSHTXWKSL : AZSQARIURKK<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType KNBJQCEZLVP
			{
				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x2AD53B0", Offset = "0x2AD41B0", VA = "0x182AD53B0")]
			public HKUSHTXWKSL(RGZHVGRSJVI a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class WSHKLAGPNJW : XSMRIYLPWPA<MCDWMQUFLER>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600058F")]
				[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7F40", Offset = "0x2AE6D40", VA = "0x182AE7F40")]
			public WSHKLAGPNJW(RGZHVGRSJVI a, MCDWMQUFLER b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class XMYTIVMIJGT : XSMRIYLPWPA<FNBFUCIKLPK>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000592")]
				[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7FA0", Offset = "0x2AE6DA0", VA = "0x182AE7FA0")]
			public XMYTIVMIJGT(RGZHVGRSJVI a, FNBFUCIKLPK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class VGOJFFAJRLL : WWMERNBFBAB<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
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
					public JSZUEIUUAJQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000599")]
					[Cpp2IlInjected.Address(RVA = "0x2AE3F30", Offset = "0x2AE2D30", VA = "0x182AE3F30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059A")]
					[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public VGOJFFAJRLL SVDPBWSVAHX;

				[Cpp2IlInjected.Token(Token = "0x6000597")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000598")]
				[Cpp2IlInjected.Address(RVA = "0x2AD86E0", Offset = "0x2AD74E0", VA = "0x182AD86E0")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void OEQLGKTAGEC(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2AE64C0", Offset = "0x2AE52C0", VA = "0x182AE64C0")]
			public VGOJFFAJRLL(RGZHVGRSJVI a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x2AE61C0", Offset = "0x2AE4FC0", VA = "0x182AE61C0", Slot = "151")]
			protected override void XSDVTBNRAWC(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class FAOURDAPKOU : AZSQARIURKK<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType KNBJQCEZLVP
			{
				[Cpp2IlInjected.Token(Token = "0x600059C")]
				[Cpp2IlInjected.Address(RVA = "0xD864B0", Offset = "0xD852B0", VA = "0x180D864B0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4E30", Offset = "0x2AD3C30", VA = "0x182AD4E30")]
			public FAOURDAPKOU(RGZHVGRSJVI a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class ENOMZDZNKOR : EOGMAVBNCPD<KLFLCDKMWLZ>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059D")]
				[Cpp2IlInjected.Address(RVA = "0xF80220", Offset = "0xF7F020", VA = "0x180F80220", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x2AD4800", Offset = "0x2AD3600", VA = "0x182AD4800")]
			public ENOMZDZNKOR(RGZHVGRSJVI a, KLFLCDKMWLZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class ZJNSJKGNPCY : EOGMAVBNCPD<ZRVFMGQBKXL>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A0")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A1")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool BKBUYOBQYPX
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8570", Offset = "0x2AE7370", VA = "0x182AE8570")]
			public ZJNSJKGNPCY(RGZHVGRSJVI a, ZRVFMGQBKXL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x2AE81B0", Offset = "0x2AE6FB0", VA = "0x182AE81B0", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8530", Offset = "0x2AE7330", VA = "0x182AE8530")]
			private int UTYZOWVSUOW()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AE84C0", Offset = "0x2AE72C0", VA = "0x182AE84C0")]
			private void ODKFIQUVHYC(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class BKFXIPVCRWD : PFJATQKEZTE
		{
			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AD2AF0", Offset = "0x2AD18F0", VA = "0x182AD2AF0")]
			public BKFXIPVCRWD(RGZHVGRSJVI a, ITZFJUYYDSP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class PFWVPAAYJWB : EOGMAVBNCPD<SIVOJKRKYNQ>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class RYMNRJREOIY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public PFWVPAAYJWB SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RYMNRJREOIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AD")]
				[Cpp2IlInjected.Address(RVA = "0x2ADC990", Offset = "0x2ADB790", VA = "0x182ADC990")]
				internal int AIVVSQNXYVB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0x2ADC600", Offset = "0x2ADB400", VA = "0x182ADC600")]
				internal void AIQOVJUAPJS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x2ADCE70", Offset = "0x2ADBC70", VA = "0x182ADCE70")]
				internal int AJGJNEBSRRT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x2ADCBD0", Offset = "0x2ADB9D0", VA = "0x182ADCBD0")]
				internal void AJBCPXHVIGK(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AA")]
				[Cpp2IlInjected.Address(RVA = "0x1316D40", Offset = "0x1315B40", VA = "0x181316D40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2ADBDC0", Offset = "0x2ADABC0", VA = "0x182ADBDC0")]
			public PFWVPAAYJWB(RGZHVGRSJVI a, SIVOJKRKYNQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2ADBAB0", Offset = "0x2ADA8B0", VA = "0x182ADBAB0", Slot = "145")]
			protected sealed override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class RFOKFLLKABQ : WWMERNBFBAB<LBUYTQLYBIP>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x2ADC3A0", Offset = "0x2ADB1A0", VA = "0x182ADC3A0")]
			public RFOKFLLKABQ(RGZHVGRSJVI a, LBUYTQLYBIP b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class WWMERNBFBAB<a> : EOGMAVBNCPD<a> where a : notnull, LBUYTQLYBIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class VFMVPEYKGXJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public WWMERNBFBAB<a> SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.Token(Token = "0x60005B9")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public VFMVPEYKGXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BA")]
				[Cpp2IlInjected.Address(RVA = "0x640DE20", Offset = "0x640CC20", VA = "0x18640DE20")]
				internal bool AIVVSQNXYVB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0x640DD90", Offset = "0x640CB90", VA = "0x18640DD90")]
				internal void AIQOVJUAPJS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x640DEE0", Offset = "0x640CCE0", VA = "0x18640DEE0")]
				internal bool AJGJNEBSRRT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x640DE50", Offset = "0x640CC50", VA = "0x18640DE50")]
				internal void AJBCPXHVIGK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x640DF10", Offset = "0x640CD10", VA = "0x18640DF10")]
				internal bool AJQXHRPNKOL()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class CORIYCNATUY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public BKLHYEYAHLO XMBULKQXVMU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public WWMERNBFBAB<a> SVDPBWSVAHX;

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public CORIYCNATUY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x4032C70", Offset = "0x4031A70", VA = "0x184032C70")]
				internal void OEQLGKTAGEC(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0xDDA9F0", Offset = "0xDD97F0", VA = "0x180DDA9F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x6825FA0", Offset = "0x6824DA0", VA = "0x186825FA0", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x6825EA0", Offset = "0x6824CA0", VA = "0x186825EA0")]
			protected WWMERNBFBAB(RGZHVGRSJVI a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x6825720", Offset = "0x6824520", VA = "0x186825720", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x6825810", Offset = "0x6824610", VA = "0x186825810", Slot = "145")]
			protected override void JFEJVYCTZDP(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x6825BB0", Offset = "0x68249B0", VA = "0x186825BB0", Slot = "151")]
			protected virtual void XSDVTBNRAWC(MSLEAENUAIG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x6825B70", Offset = "0x6824970", VA = "0x186825B70", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6740", Offset = "0x2AB5540", VA = "0x182AB6740")]
		public static WVHJGQESRCU New(RGZHVGRSJVI circuitsManager, ITZFJUYYDSP node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class BZTVZNQSSFG : VUSRKGTDCLQ, QWJMNUKNOYN, BSZEZNSGOWH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<GXAJUPUXNOX> LBMORVMEVIL
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xF79CF0", Offset = "0xF78AF0", VA = "0x180F79CF0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GXAJUPUXNOX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<SFFGLAFZKMT> IQUTKFXCCJY
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x1ECB270", Offset = "0x1ECA070", VA = "0x181ECB270", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<SFFGLAFZKMT>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x25BF010", Offset = "0x25BDE10", VA = "0x1825BF010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<NLSPOFOVMCC> PWANNKEWWRK
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x14A1D70", Offset = "0x14A0B70", VA = "0x1814A1D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<CLCEYSQWERP> KLLHKXMCDBK
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3480", Offset = "0x2AD2280", VA = "0x182AD3480", Slot = "22")]
			get
			{
				return default(Id32<CLCEYSQWERP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AD3820", Offset = "0x2AD2620", VA = "0x182AD3820")]
		private BZTVZNQSSFG(RGZHVGRSJVI a, ITZFJUYYDSP b, CPESHSRQGWJ c, Id32<TOCKAIBKNWY> portGroupId, Id32<SFFGLAFZKMT> outputId, Id32<NLSPOFOVMCC> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AD34D0", Offset = "0x2AD22D0", VA = "0x182AD34D0")]
		public static BZTVZNQSSFG New(RGZHVGRSJVI circuitsManager, ITZFJUYYDSP node, CPESHSRQGWJ output, Id32<TOCKAIBKNWY> portGroupId, Id32<NLSPOFOVMCC> outputDefId, Id32<SFFGLAFZKMT> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x25BF010", Offset = "0x25BDE10", VA = "0x1825BF010")]
		internal void FATKYUWICLW(Id32<SFFGLAFZKMT> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class VUSRKGTDCLQ : BSZEZNSGOWH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private MKSFTRBCKAG? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x2AD92B0", Offset = "0x2AD80B0", VA = "0x182AD92B0")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x2AD92C0", Offset = "0x2AD80C0", VA = "0x182AD92C0")]
			public MKSFTRBCKAG JFKGAUCTPVK(VUSRKGTDCLQ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly RGZHVGRSJVI XTDGCADPGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly ITZFJUYYDSP TMSOESJLDWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter TDVENWEDLRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly FZLDKRTZLDL YKKJXPWZBPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<ZAOMLEERSRV> QTRYDNRFRRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<QJXHGISXMQF> ZROYMJHFVIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool CNPSARUTVEY;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> ANPCDQRLDUA
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6520", Offset = "0x2AE5320", VA = "0x182AE6520", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind ZMDSKWYQMXX
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xABBB50", Offset = "0xABA950", VA = "0x180ABBB50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<TROAQNNIZMC> TLMCRDJZEWE
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7080", Offset = "0x2AE5E80", VA = "0x182AE7080", Slot = "6")]
			get
			{
				return default(Id32<TROAQNNIZMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<TROAQNNIZMC> SCOTPHRGYZX
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7BB0", Offset = "0x2AE69B0", VA = "0x182AE7BB0", Slot = "7")]
			get
			{
				return default(Id128<TROAQNNIZMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public VJBGGKQUSTY WMOHPTVKGAT
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7AE0", Offset = "0x2AE68E0", VA = "0x182AE7AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public RGQBZFZJYOU DLBCLHFGJVC
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6F90", Offset = "0x2AE5D90", VA = "0x182AE6F90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected MKSFTRBCKAG BAHWBCYMATR
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6F90", Offset = "0x2AE5D90", VA = "0x182AE6F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage AUZANCQKNGF
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7920", Offset = "0x2AE6720", VA = "0x182AE7920", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC10", Offset = "0xA9DA10", VA = "0x180A9EC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<LQPAJNJDNAW> HUUEOCFJEVP
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7AC0", Offset = "0x2AE68C0", VA = "0x182AE7AC0", Slot = "9")]
			get
			{
				return default(Id128<LQPAJNJDNAW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<TOCKAIBKNWY> RLXFLEPNDZI
		{
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xF2E2E0", Offset = "0xF2D0E0", VA = "0x180F2E2E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<TOCKAIBKNWY>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x1AD65E0", Offset = "0x1AD53E0", VA = "0x181AD65E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<CLCEYSQWERP> KLLHKXMCDBK
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool IRSGWHZPOOV
		{
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0xFCD270", Offset = "0xFCC070", VA = "0x180FCD270", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7D90", Offset = "0x2AE6B90", VA = "0x182AE7D90")]
		protected VUSRKGTDCLQ(RGZHVGRSJVI a, ITZFJUYYDSP b, FZLDKRTZLDL c, Id32<TOCKAIBKNWY> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6A00", Offset = "0x2AE5800", VA = "0x182AE6A00", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6810", Offset = "0x2AE5610", VA = "0x182AE6810", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AE68F0", Offset = "0x2AE56F0", VA = "0x182AE68F0", Slot = "14")]
		public void GQNXNXUUPQG(ZAOMLEERSRV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7B00", Offset = "0x2AE6900", VA = "0x182AE7B00", Slot = "15")]
		public void WFIIBIARJAU(QJXHGISXMQF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6C70", Offset = "0x2AE5A70", VA = "0x182AE6C70")]
		private bool LNWTYWZRCTR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AE70B0", Offset = "0x2AE5EB0", VA = "0x182AE70B0", Slot = "17")]
		public void OKYHXLSSEPC(LXWGCYDHMCB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7A60", Offset = "0x2AE6860", VA = "0x182AE7A60", Slot = "25")]
		protected virtual void UCXDLGSCNTE(LXWGCYDHMCB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6AE0", Offset = "0x2AE58E0", VA = "0x182AE6AE0", Slot = "20")]
		private void LHSAVZKFBYZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7BE0", Offset = "0x2AE69E0", VA = "0x182AE7BE0")]
		private void ZPOVHWAUGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6660", Offset = "0x2AE5460", VA = "0x182AE6660")]
		private void BWXBUCQJQYC([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7020", Offset = "0x2AE5E20", VA = "0x182AE7020", Slot = "18")]
		public void MHBTECHZBTN(ZAOMLEERSRV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AE69A0", Offset = "0x2AE57A0", VA = "0x182AE69A0", Slot = "19")]
		public void HNVEONFHDMZ(QJXHGISXMQF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xA9EC10", Offset = "0xA9DA10", VA = "0x180A9EC10")]
		internal void XLLTSOMEHIK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7900", Offset = "0x2AE6700", VA = "0x182AE7900")]
		internal void QFHQQYNUGTH(AOAGTNJJCPD a, VJBGGKQUSTY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x1AD65E0", Offset = "0x1AD53E0", VA = "0x181AD65E0")]
		internal void QPGQDHMJQTW(Id32<TOCKAIBKNWY> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class ZQDUIDEOMSJ : MEYJBPAULDI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class XZJLPJMBZGV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public RGZHVGRSJVI BYYCAVELYOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public ITZFJUYYDSP SMJSDUHDMSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<TOCKAIBKNWY> TEFLDLEVGFU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool YHNDMBZUSLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool CRPONLGWPIO;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public XZJLPJMBZGV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x2AE80D0", Offset = "0x2AE6ED0", VA = "0x182AE80D0")]
			internal VMIPVXRPZKX HVEHNOCMSBT((int PortDescIndex, int PortIndex, MCRKWYVOTDU InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8000", Offset = "0x2AE6E00", VA = "0x182AE8000")]
			internal BZTVZNQSSFG HUZAQHIPIQK(CPESHSRQGWJ a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2ADF7C0", Offset = "0x2ADE5C0", VA = "0x182ADF7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2ADFC30", Offset = "0x2ADEA30", VA = "0x182ADFC30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<ENGFBJMMTKB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x2AE0EF0", Offset = "0x2ADFCF0", VA = "0x182AE0EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x2AE1240", Offset = "0x2AE0040", VA = "0x182AE1240", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x2AE12B0", Offset = "0x2AE00B0", VA = "0x182AE12B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2AE1730", Offset = "0x2AE0530", VA = "0x182AE1730", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<NLSPOFOVMCC> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x2AE17A0", Offset = "0x2AE05A0", VA = "0x182AE17A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x2AE1AF0", Offset = "0x2AE08F0", VA = "0x182AE1AF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2AE2320", Offset = "0x2AE1120", VA = "0x182AE2320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x2AE2670", Offset = "0x2AE1470", VA = "0x182AE2670", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<ENGFBJMMTKB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x2AE1B60", Offset = "0x2AE0960", VA = "0x182AE1B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x2AE1ED0", Offset = "0x2AE0CD0", VA = "0x182AE1ED0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<NLSPOFOVMCC> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x2AE1F40", Offset = "0x2AE0D40", VA = "0x182AE1F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x2AE22B0", Offset = "0x2AE10B0", VA = "0x182AE22B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public XJIDAZKYYEX type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<ENGFBJMMTKB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x2AE26E0", Offset = "0x2AE14E0", VA = "0x182AE26E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x2AE2A80", Offset = "0x2AE1880", VA = "0x182AE2A80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public XJIDAZKYYEX type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<NLSPOFOVMCC> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2AE2AF0", Offset = "0x2AE18F0", VA = "0x182AE2AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2AE2E90", Offset = "0x2AE1C90", VA = "0x182AE2E90", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<ENGFBJMMTKB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<ENGFBJMMTKB> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2AE2F00", Offset = "0x2AE1D00", VA = "0x182AE2F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x2AE3260", Offset = "0x2AE2060", VA = "0x182AE3260", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public ZQDUIDEOMSJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<NLSPOFOVMCC> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<NLSPOFOVMCC> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private HBKJLPUCFON <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x2AE32D0", Offset = "0x2AE20D0", VA = "0x182AE32D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x2AE3630", Offset = "0x2AE2430", VA = "0x182AE3630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool UHEIDCPYXWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly RGZHVGRSJVI XTDGCADPGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool SNBLZVUHNKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<SYBOCFQCTDO, VMIPVXRPZKX> OKFKAAJCGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<SYBOCFQCTDO, CWZUZWKZEGA> NTFGSFBEZRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly ITZFJUYYDSP TMSOESJLDWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<SFFGLAFZKMT, BZTVZNQSSFG> WGRKPMXVMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<SFFGLAFZKMT, QWJMNUKNOYN> DQLUTIBSVES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? HXYYEZBAAQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly TGZIJCIGDIK GBGBXUANADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<TOCKAIBKNWY> FTTWAXYLYZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool FTICIYKBCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? EITSUPZDVTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? LQACWVWTJWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<SYBOCFQCTDO>>? WXSJTSWUKYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<SFFGLAFZKMT>>? EGVIOYKCJYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private MEYJBPAULDI.PortGroupIdChangeDelegate? ETDXQBGAHTV;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool JXEXIJBPYLF
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x2AEB410", Offset = "0x2AEA210", VA = "0x182AEB410", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool TIXAPWXVUCI
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x2AE86A0", Offset = "0x2AE74A0", VA = "0x182AE86A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool NDVMCVRANAG
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2AED4E0", Offset = "0x2AEC2E0", VA = "0x182AED4E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<TROAQNNIZMC> SCOTPHRGYZX
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2AED5A0", Offset = "0x2AEC3A0", VA = "0x182AED5A0", Slot = "7")]
			get
			{
				return default(Id128<TROAQNNIZMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool NKDCLIBFMGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x2AED700", Offset = "0x2AEC500", VA = "0x182AED700", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<SYBOCFQCTDO, CWZUZWKZEGA> NIMXKGFJHZM
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<SYBOCFQCTDO, CWZUZWKZEGA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2AED780", Offset = "0x2AEC580", VA = "0x182AED780", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<LQPAJNJDNAW> HUUEOCFJEVP
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x2AECDF0", Offset = "0x2AEBBF0", VA = "0x182AECDF0", Slot = "11")]
			get
			{
				return default(Id128<LQPAJNJDNAW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<SFFGLAFZKMT, QWJMNUKNOYN> TGOZBFGIPBN
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<SFFGLAFZKMT, QWJMNUKNOYN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<TOCKAIBKNWY> RLXFLEPNDZI
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0xC44D30", Offset = "0xC43B30", VA = "0x180C44D30", Slot = "13")]
			get
			{
				return default(Id32<TOCKAIBKNWY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? BGSNCGZRWRS
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x2AE86E0", Offset = "0x2AE74E0", VA = "0x182AE86E0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8E90", Offset = "0x2AE7C90", VA = "0x182AE8E90", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? KHLHVWJMMMP
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9880", Offset = "0x2AE8680", VA = "0x182AE9880", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA000", Offset = "0x2AE8E00", VA = "0x182AEA000", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<SYBOCFQCTDO?>, Id32<SYBOCFQCTDO?>>? CLJISUSOSUU
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA0B0", Offset = "0x2AE8EB0", VA = "0x182AEA0B0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2AED360", Offset = "0x2AEC160", VA = "0x182AED360", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<SYBOCFQCTDO?>, Id32<SYBOCFQCTDO?>>? EGNWETDFMUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8DD0", Offset = "0x2AE7BD0", VA = "0x182AE8DD0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x2AEAFF0", Offset = "0x2AE9DF0", VA = "0x182AEAFF0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<SFFGLAFZKMT?>, Id32<SFFGLAFZKMT?>>? KOZJSUAPNQH
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x2AE85E0", Offset = "0x2AE73E0", VA = "0x182AE85E0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA170", Offset = "0x2AE8F70", VA = "0x182AEA170", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<SFFGLAFZKMT?>, Id32<SFFGLAFZKMT?>>? OCWGTIQTYNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2AEC3C0", Offset = "0x2AEB1C0", VA = "0x182AEC3C0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2AECE10", Offset = "0x2AEBC10", VA = "0x182AECE10", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<SYBOCFQCTDO?>, CWZUZWKZEGA?>? MNPFURNNDAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2AE95D0", Offset = "0x2AE83D0", VA = "0x182AE95D0", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2AEBCD0", Offset = "0x2AEAAD0", VA = "0x182AEBCD0", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<SYBOCFQCTDO?>>? YOBVKZTLNFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2AEBB00", Offset = "0x2AEA900", VA = "0x182AEBB00", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8970", Offset = "0x2AE7770", VA = "0x182AE8970", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<SYBOCFQCTDO?>, CWZUZWKZEGA?>? WYHAPYQTRPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x2AED420", Offset = "0x2AEC220", VA = "0x182AED420", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9690", Offset = "0x2AE8490", VA = "0x182AE9690", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<SFFGLAFZKMT?>, QWJMNUKNOYN?>? BMHQKXOWIHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8FF0", Offset = "0x2AE7DF0", VA = "0x182AE8FF0", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2AEC9E0", Offset = "0x2AEB7E0", VA = "0x182AEC9E0", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<SFFGLAFZKMT?>>? DOOTEXHBLBX
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2AEBA40", Offset = "0x2AEA840", VA = "0x182AEBA40", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2AED2A0", Offset = "0x2AEC0A0", VA = "0x182AED2A0", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<SFFGLAFZKMT?>, QWJMNUKNOYN?>? TWFDMIKZXKY
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8F30", Offset = "0x2AE7D30", VA = "0x182AE8F30", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8780", Offset = "0x2AE7580", VA = "0x182AE8780", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2AED7B0", Offset = "0x2AEC5B0", VA = "0x182AED7B0")]
		private ZQDUIDEOMSJ(bool a, RGZHVGRSJVI b, bool c, ReadOnlyIdArray<SYBOCFQCTDO, VMIPVXRPZKX> inputs, ReadOnlyIdArray<SYBOCFQCTDO, CWZUZWKZEGA> inputsAsStaticInputs, ITZFJUYYDSP d, ReadOnlyIdArray<SFFGLAFZKMT, BZTVZNQSSFG> outputs, ReadOnlyIdArray<SFFGLAFZKMT, QWJMNUKNOYN> outputsAsStaticOutputs, string? overrideName, TGZIJCIGDIK e, Id32<TOCKAIBKNWY> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB4F0", Offset = "0x2AEA2F0", VA = "0x182AEB4F0")]
		public static ZQDUIDEOMSJ New(bool canInteract, RGZHVGRSJVI circuitsManager, bool hasFunctionHeader, ITZFJUYYDSP node, TGZIJCIGDIK portGroup, Id32<TOCKAIBKNWY> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8A30", Offset = "0x2AE7830", VA = "0x182AE8A30", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBD90", Offset = "0x2AEAB90", VA = "0x182AEBD90", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, SJKUUBAWOPB?>>? OVKIZOIRTLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB1D0", Offset = "0x2AE9FD0", VA = "0x182AEB1D0")]
		private (KRYQAXXBGCU?, int)? NEJKXGWXAON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2AECC30", Offset = "0x2AEBA30", VA = "0x182AECC30", Slot = "58")]
		private void TKKCHBWCCMX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x255A660", Offset = "0x2559460", VA = "0x18255A660", Slot = "57")]
		private void MLVVFMXALQK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2AECED0", Offset = "0x2AEBCD0", VA = "0x182AECED0", Slot = "61")]
		private void VFBPULASNRG(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2AECD40", Offset = "0x2AEBB40", VA = "0x182AECD40", Slot = "63")]
		private void TOZFVYGYFCP(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9930", Offset = "0x2AE8730", VA = "0x182AE9930", Slot = "50")]
		private void IOIYYBZYCIO(int a, Id32<SYBOCFQCTDO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2AECC10", Offset = "0x2AEBA10", VA = "0x182AECC10", Slot = "54")]
		private void TFVZMINBYDZ(int a, Id32<SYBOCFQCTDO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2AECDD0", Offset = "0x2AEBBD0", VA = "0x182AECDD0", Slot = "49")]
		private void UAEHVZEIBWF(int a, Id32<SYBOCFQCTDO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA7D0", Offset = "0x2AE95D0", VA = "0x182AEA7D0", Slot = "53")]
		private void LESENOSAZQO(int a, Id32<SYBOCFQCTDO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBE80", Offset = "0x2AEAC80", VA = "0x182AEBE80", Slot = "66")]
		private void PWCQGPEJGOY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x114AA60", Offset = "0x1149860", VA = "0x18114AA60", Slot = "65")]
		private void CZKNAYXSUEV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC6D0", Offset = "0x2AEB4D0", VA = "0x182AEC6D0", Slot = "60")]
		private void SFJVSBSTMEC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x255A660", Offset = "0x2559460", VA = "0x18255A660", Slot = "59")]
		private void PKQEYZQGJUZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAC20", Offset = "0x2AE9A20", VA = "0x182AEAC20", Slot = "62")]
		private void LOQRAHWCUBR(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9520", Offset = "0x2AE8320", VA = "0x182AE9520", Slot = "64")]
		private void GMTUXLVUUTA(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA230", Offset = "0x2AE9030", VA = "0x182AEA230", Slot = "52")]
		private void KOGNSFOITXD(int a, Id32<SFFGLAFZKMT> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB4D0", Offset = "0x2AEA2D0", VA = "0x182AEB4D0", Slot = "56")]
		private void NJTEDSHECES(int a, Id32<SFFGLAFZKMT> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2AE95B0", Offset = "0x2AE83B0", VA = "0x182AE95B0", Slot = "51")]
		private void GQHTOXRURZG(int a, Id32<SFFGLAFZKMT> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2AE90B0", Offset = "0x2AE7EB0", VA = "0x182AE90B0", Slot = "55")]
		private void FCOMUJLTKIN(int a, Id32<SFFGLAFZKMT> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2AECAA0", Offset = "0x2AEB8A0", VA = "0x182AECAA0", Slot = "68")]
		private void SYQXFSVCJZD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x114AA60", Offset = "0x1149860", VA = "0x18114AA60", Slot = "67")]
		private void DROGFCCYZOW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC7E0", Offset = "0x2AEB5E0", VA = "0x182AEC7E0", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, SJKUUBAWOPB?>>? SFMRBZFQSRW(Id32<ENGFBJMMTKB> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBBC0", Offset = "0x2AEA9C0", VA = "0x182AEBBC0", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, SJKUUBAWOPB?>>? ORMJUBBDRAZ(Id32<NLSPOFOVMCC> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC5B0", Offset = "0x2AEB3B0", VA = "0x182AEC5B0", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, SJKUUBAWOPB?>>? RZOIUKFNOKK(Id32<ENGFBJMMTKB> inputDefId, Id32<ENGFBJMMTKB> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9EE0", Offset = "0x2AE8CE0", VA = "0x182AE9EE0", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, SJKUUBAWOPB?>>? JAIWJQHEFUV(Id32<NLSPOFOVMCC> outputDefId, Id32<NLSPOFOVMCC> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC8F0", Offset = "0x2AEB6F0", VA = "0x182AEC8F0", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, SJKUUBAWOPB?>>? SMILSHBICNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB0B0", Offset = "0x2AE9EB0", VA = "0x182AEB0B0", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, SJKUUBAWOPB>> MCXFGAWUMVT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2AED5D0", Offset = "0x2AEC3D0", VA = "0x182AED5D0", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, SJKUUBAWOPB>> YSJUCASANRM(Id32<ENGFBJMMTKB> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9750", Offset = "0x2AE8550", VA = "0x182AE9750", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, SJKUUBAWOPB>> HXLMUTILQSP(Id32<NLSPOFOVMCC> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8840", Offset = "0x2AE7640", VA = "0x182AE8840", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, SJKUUBAWOPB>> CNBQSBTPSVP(Id32<ENGFBJMMTKB> inputDefId, XJIDAZKYYEX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC480", Offset = "0x2AEB280", VA = "0x182AEC480", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, SJKUUBAWOPB>> RYAQFEAFPXE(Id32<NLSPOFOVMCC> outputDefId, XJIDAZKYYEX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBFF0", Offset = "0x2AEADF0", VA = "0x182AEBFF0")]
		internal void QPGQDHMJQTW(Id32<TOCKAIBKNWY> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class HHBELIZAZTL : TCDWQQVTIFG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface XQEIROEEFNO
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<TROAQNNIZMC>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065D")]
				[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<TROAQNNIZMC>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			AOAGTNJJCPD AOAGTNJJCPD
			{
				[Cpp2IlInjected.Token(Token = "0x6000656")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> EKNSRJOJMVQ(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> GRDISRSROHH(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<ZISFUTTVJRN> LKSWFICDDGG(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<WNJQWAUFPBV> ABUGSKMZKKH(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> OKFCYFIBJXC(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> XJSCBWVWLKP(CancellationToken a);
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
			public AsyncTaskMethodBuilder<HHBELIZAZTL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public RGZHVGRSJVI circuitsManager;

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
			private XQEIROEEFNO <selfDeps>5__2;

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
			private ZISFUTTVJRN <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private WNJQWAUFPBV <playerSaveData>5__8;

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
			private TaskAwaiter<ZISFUTTVJRN> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<WNJQWAUFPBV> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<XQEIROEEFNO.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<QJDKMJZUZXH> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x2ADFCA0", Offset = "0x2ADEAA0", VA = "0x182ADFCA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x2AE0E80", Offset = "0x2ADFC80", VA = "0x182AE0E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public QJDKMJZUZXH QJDKMJZUZXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public YLUNAYITVRH YLUNAYITVRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public CGXZWWAAXRY CGXZWWAAXRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public AISMQWVGLVE AISMQWVGLVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x117B280", Offset = "0x117A080", VA = "0x18117B280")]
		private HHBELIZAZTL(QJDKMJZUZXH a, YLUNAYITVRH b, CGXZWWAAXRY c, AISMQWVGLVE d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5240", Offset = "0x2AD4040", VA = "0x182AD5240")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<HHBELIZAZTL> MRJGZOIOIQW(RGZHVGRSJVI a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5220", Offset = "0x2AD4020", VA = "0x182AD5220", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class LUPUFDLXTXH : FBGAYSQSFLW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly RGZHVGRSJVI XTDGCADPGFN;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public LECPTNCSKED? VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2AD91A0", Offset = "0x2AD7FA0", VA = "0x182AD91A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		internal LUPUFDLXTXH(RGZHVGRSJVI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class CGXZWWAAXRY : LECPTNCSKED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly RGZHVGRSJVI XTDGCADPGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly QJDKMJZUZXH RGDFIMVWSGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly LUPUFDLXTXH MKDIMUSZCFQ;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> EOAQGTCIJDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x2AD3AC0", Offset = "0x2AD28C0", VA = "0x182AD3AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xE40350", Offset = "0xE3F150", VA = "0x180E40350")]
		public CGXZWWAAXRY(RGZHVGRSJVI a, QJDKMJZUZXH b, LUPUFDLXTXH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x2AD3B60", Offset = "0x2AD2960", VA = "0x182AD3B60", Slot = "5")]
		public string OYYMADYTODS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x2AD3B00", Offset = "0x2AD2900", VA = "0x182AD3B00", Slot = "6")]
		public void OWXNTMRJVFF(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x2AFC900", Offset = "0x2AFB700", VA = "0x182AFC900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x2AFCB40", Offset = "0x2AFB940", VA = "0x182AFCB40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, SJKUUBAWOPB>> <>t__builder;

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
			private ELPAQFNEADX[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD360", Offset = "0x2AFC160", VA = "0x182AFD360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD730", Offset = "0x2AFC530", VA = "0x182AFD730", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public ELPAQFNEADX action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x2B01A70", Offset = "0x2B00870", VA = "0x182B01A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x2B01E80", Offset = "0x2B00C80", VA = "0x182B01E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly SVBMWMSSDIU _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		public EVRequestExtended(SVBMWMSSDIU staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4AC0", Offset = "0x2AD38C0", VA = "0x182AD4AC0")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, SJKUUBAWOPB>> TLBNIVDFOCM(ELPAQFNEADX a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4960", Offset = "0x2AD3760", VA = "0x182AD4960")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, SJKUUBAWOPB?>>? KGNAPVPVRPR(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4870", Offset = "0x2AD3670", VA = "0x182AD4870")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, SJKUUBAWOPB>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface YLCKUADMMIO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		TCDWQQVTIFG? VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool QFWAQTPWMJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<TCDWQQVTIFG?>? ZMTEENDRIWW();

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task RIFZHRTMBBB(RGZHVGRSJVI a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface TCDWQQVTIFG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		QJDKMJZUZXH QJDKMJZUZXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		YLUNAYITVRH YLUNAYITVRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		CGXZWWAAXRY CGXZWWAAXRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		AISMQWVGLVE AISMQWVGLVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class OURVBZNARGX
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB880", Offset = "0x2AFA680", VA = "0x182AFB880")]
		public static ReducerFactory<ActionKind, ELPAQFNEADX, RGZHVGRSJVI, MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>> ETJTTNEKKEM([In] this ReducerFactory<ActionKind, ELPAQFNEADX, RGZHVGRSJVI, MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, ELPAQFNEADX, RGZHVGRSJVI, MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class SSANEMPSJGO : VITTVEGHMGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly RGZHVGRSJVI XTDGCADPGFN;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool QFWAQTPWMJH
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x2AFC110", Offset = "0x2AFAF10", VA = "0x182AFC110", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		internal SSANEMPSJGO(RGZHVGRSJVI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class QXGRLLVAXUP : GQQKYERGYSM
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBFE0", Offset = "0x2AFADE0", VA = "0x182AFBFE0", Slot = "4")]
		public JKNMSSQZZIS? KWOYWVJICLH(string? a, string? b, string? c, RoomDoorData.VGCLVFOWXCM.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBF20", Offset = "0x2AFAD20", VA = "0x182AFBF20", Slot = "5")]
		public GRDYCQFTRVG HUFCAZQSWAF(string a, string b, List<string> c, int d, int e, int f, int g, JGZPKUWDUSK h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC070", Offset = "0x2AFAE70", VA = "0x182AFC070", Slot = "6")]
		public JGZPKUWDUSK TOCRUDJBBHH(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public QXGRLLVAXUP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class GORZCVDQGOR : MZVNUTHPWMY
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
			public AsyncTaskMethodBuilder<PPOKMLHFENR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public GORZCVDQGOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<TCDWQQVTIFG?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFCBB0", Offset = "0x2AFB9B0", VA = "0x182AFCBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFCE60", Offset = "0x2AFBC60", VA = "0x182AFCE60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly RGZHVGRSJVI XTDGCADPGFN;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public PPOKMLHFENR? VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x2AF83C0", Offset = "0x2AF71C0", VA = "0x182AF83C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public AISMQWVGLVE? TVVPYRLPQVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x2AF84A0", Offset = "0x2AF72A0", VA = "0x182AF84A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool YDVBXUIFALS
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8BF0", Offset = "0x2AF79F0", VA = "0x182AF8BF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool JYQAZYAYAXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8440", Offset = "0x2AF7240", VA = "0x182AF8440", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D70", Offset = "0x2AF7B70", VA = "0x182AF8D70")]
		internal GORZCVDQGOR(RGZHVGRSJVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8C50", Offset = "0x2AF7A50", VA = "0x182AF8C50", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<PPOKMLHFENR> ZMTEENDRIWW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2AF86F0", Offset = "0x2AF74F0", VA = "0x182AF86F0", Slot = "9")]
		public IReadOnlyDictionary<Id128<TROAQNNIZMC>, Guid> OBAUSXRVBYU(IEnumerable<PALJQNQKVVN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8A70", Offset = "0x2AF7870", VA = "0x182AF8A70", Slot = "10")]
		public CircuitGraphToolMappingRegistryData UBVALCNBWZM(IEnumerable<PALJQNQKVVN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8520", Offset = "0x2AF7320", VA = "0x182AF8520")]
		public Result<CircuitsRoomData, HEYQXAVABBH> MFFPVGYBJDY([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, HEYQXAVABBH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D40", Offset = "0x2AF7B40", VA = "0x182AF8D40", Slot = "8")]
		private Result<CircuitsRoomData, HEYQXAVABBH> ZTQNALGFXZR([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, HEYQXAVABBH>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class AISMQWVGLVE : PPOKMLHFENR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class ETQNXMUVYWV
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class JSZUEIUUAJQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int XXLSWQFFAWC;

				[Cpp2IlInjected.Token(Token = "0x6000716")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public JSZUEIUUAJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000717")]
				[Cpp2IlInjected.Address(RVA = "0x2AF8F50", Offset = "0x2AF7D50", VA = "0x182AF8F50")]
				internal void CTQYYAEYSCP(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF7B00", Offset = "0x2AF6900", VA = "0x182AF7B00")]
			public static Result<PPOKMLHFENR.PrepareTemplateForCloneResult, NVAIURBTDUG> YEYQFACLXEM(AISMQWVGLVE a, [In] PPOKMLHFENR.PrepareTemplateForCloneArgs args)
			{
				return default(Result<PPOKMLHFENR.PrepareTemplateForCloneResult, NVAIURBTDUG>);
			}

			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6DC0", Offset = "0x2AF5BC0", VA = "0x182AF6DC0")]
			internal static Result<(GXUDKIZPZYH, CircuitTemplateRootData), NVAIURBTDUG> WPZQLFXRBSS(AISMQWVGLVE a, CircuitTemplateRootData b, bool c, [In] Id128<TROAQNNIZMC> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(GXUDKIZPZYH, CircuitTemplateRootData), NVAIURBTDUG>);
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5F50", Offset = "0x2AF4D50", VA = "0x182AF5F50")]
			private static void BTKYTKACYLW(bool a, PALJQNQKVVN b, GXUDKIZPZYH c, [In] Id128<TROAQNNIZMC> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2AF63F0", Offset = "0x2AF51F0", VA = "0x182AF63F0")]
			public static void OKDDTKRLKGN(HEZSYTDRMTA a, [In] PPOKMLHFENR.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6800", Offset = "0x2AF5600", VA = "0x182AF6800")]
			[CompilerGenerated]
			internal static bool OWMXUBTXRTK(QJDKMJZUZXH a, MKQIQLGMGLA b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6D90", Offset = "0x2AF5B90", VA = "0x182AF6D90")]
			[CompilerGenerated]
			internal static bool UYVFKLARKQB(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class MPSOAGOZWUJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public AISMQWVGLVE SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<TROAQNNIZMC> OXVQTKFHLTN;

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public MPSOAGOZWUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB100", Offset = "0x2AF9F00", VA = "0x182AFB100")]
			internal Id128<LQPAJNJDNAW> JJFXAVDNPLC(Id32<LQPAJNJDNAW> a)
			{
				return default(Id128<LQPAJNJDNAW>);
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<GXAJUPUXNOX> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<WFLMXHQDTIG> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD7A0", Offset = "0x2AFC5A0", VA = "0x182AFD7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFDD70", Offset = "0x2AFCB70", VA = "0x182AFDD70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<LQPAJNJDNAW> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<TOCKAIBKNWY> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<ENGFBJMMTKB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFDDE0", Offset = "0x2AFCBE0", VA = "0x182AFDDE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE130", Offset = "0x2AFCF30", VA = "0x182AFE130", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<LQPAJNJDNAW>, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<HHVRSZHWLKJ> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private QJDKMJZUZXH <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE480", Offset = "0x2AFD280", VA = "0x182AFE480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE8B0", Offset = "0x2AFD6B0", VA = "0x182AFE8B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<LQPAJNJDNAW> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE1A0", Offset = "0x2AFCFA0", VA = "0x182AFE1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE410", Offset = "0x2AFD210", VA = "0x182AFE410", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE920", Offset = "0x2AFD720", VA = "0x182AFE920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEB10", Offset = "0x2AFD910", VA = "0x182AFEB10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<TROAQNNIZMC> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<LQPAJNJDNAW> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<LQPAJNJDNAW>> nodeIds;

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
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEB80", Offset = "0x2AFD980", VA = "0x182AFEB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEE20", Offset = "0x2AFDC20", VA = "0x182AFEE20", Slot = "5")]
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
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<TROAQNNIZMC> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<LQPAJNJDNAW> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<LQPAJNJDNAW>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<TOCKAIBKNWY>, Id32<SYBOCFQCTDO>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<TOCKAIBKNWY>, Id32<SFFGLAFZKMT>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEE90", Offset = "0x2AFDC90", VA = "0x182AFEE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF470", Offset = "0x2AFE270", VA = "0x182AFF470", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<TROAQNNIZMC> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<LQPAJNJDNAW> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<LQPAJNJDNAW>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF4D0", Offset = "0x2AFE2D0", VA = "0x182AFF4D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF6E0", Offset = "0x2AFE4E0", VA = "0x182AFF6E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<LQPAJNJDNAW> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<TOCKAIBKNWY> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<SYBOCFQCTDO> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF750", Offset = "0x2AFE550", VA = "0x182AFF750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFAA0", Offset = "0x2AFE8A0", VA = "0x182AFFAA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<LQPAJNJDNAW> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<TOCKAIBKNWY> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<ENGFBJMMTKB> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFB10", Offset = "0x2AFE910", VA = "0x182AFFB10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFEF0", Offset = "0x2AFECF0", VA = "0x182AFFEF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<LQPAJNJDNAW> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFF60", Offset = "0x2AFED60", VA = "0x182AFFF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2B001E0", Offset = "0x2AFEFE0", VA = "0x182B001E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<LQPAJNJDNAW> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<TOCKAIBKNWY> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<SFFGLAFZKMT> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2B00250", Offset = "0x2AFF050", VA = "0x182B00250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2B005A0", Offset = "0x2AFF3A0", VA = "0x182B005A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<LQPAJNJDNAW> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2B00610", Offset = "0x2AFF410", VA = "0x182B00610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2B00950", Offset = "0x2AFF750", VA = "0x182B00950", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<LQPAJNJDNAW> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2B009C0", Offset = "0x2AFF7C0", VA = "0x182B009C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2B00C50", Offset = "0x2AFFA50", VA = "0x182B00C50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<LQPAJNJDNAW> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2B00CC0", Offset = "0x2AFFAC0", VA = "0x182B00CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2B00F50", Offset = "0x2AFFD50", VA = "0x182B00F50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<LQPAJNJDNAW>>, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<TROAQNNIZMC> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<PALJQNQKVVN> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<ITZFJUYYDSP>, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2B00FC0", Offset = "0x2AFFDC0", VA = "0x182B00FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2B01770", Offset = "0x2B00570", VA = "0x182B01770", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<TROAQNNIZMC> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<LQPAJNJDNAW> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<LQPAJNJDNAW>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2B017E0", Offset = "0x2B005E0", VA = "0x182B017E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2B01A00", Offset = "0x2B00800", VA = "0x182B01A00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public AISMQWVGLVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<TROAQNNIZMC> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<LQPAJNJDNAW> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2B01F60", Offset = "0x2B00D60", VA = "0x182B01F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2B02180", Offset = "0x2B00F80", VA = "0x182B02180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly RGZHVGRSJVI XTDGCADPGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly QJDKMJZUZXH RGDFIMVWSGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers NUYCDTYWOLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly GORZCVDQGOR XJVYKVEBRPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<LQPAJNJDNAW>, WVHJGQESRCU> KWBZZACKJQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<LQPAJNJDNAW>>? RWVDKIUMJGQ;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<TROAQNNIZMC> GOQKJCBLQSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2AEE7B0", Offset = "0x2AED5B0", VA = "0x182AEE7B0", Slot = "4")]
			get
			{
				return default(Id128<TROAQNNIZMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers WLQPOTMTCII
		{
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2AEE3A0", Offset = "0x2AED1A0", VA = "0x182AEE3A0", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> EYHBNCEYMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x2AF06B0", Offset = "0x2AEF4B0", VA = "0x182AF06B0", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action KEZCYERKTIC
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x2AEE610", Offset = "0x2AED410", VA = "0x182AEE610", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0660", Offset = "0x2AEF460", VA = "0x182AF0660", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> PGXXVQRDEVA
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x2AF26F0", Offset = "0x2AF14F0", VA = "0x182AF26F0", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x2AF20A0", Offset = "0x2AF0EA0", VA = "0x182AF20A0", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5630", Offset = "0x2AF4430", VA = "0x182AF5630")]
		public AISMQWVGLVE(RGZHVGRSJVI a, QJDKMJZUZXH b, GORZCVDQGOR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE7D0", Offset = "0x2AED5D0", VA = "0x182AEE7D0", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0960", Offset = "0x2AEF760", VA = "0x182AF0960", Slot = "100")]
		public Id32<RAQSAJFZUNU> JDJJRTFNAUB(Id32<TROAQNNIZMC> graphId, Id32<WFLMXHQDTIG> inputId)
		{
			return default(Id32<RAQSAJFZUNU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE3B0", Offset = "0x2AED1B0", VA = "0x182AEE3B0", Slot = "101")]
		public Id32<NFJBKYKGXIZ> BHPDQDMSXFC(Id32<TROAQNNIZMC> graphId, Id32<GXAJUPUXNOX> outputId)
		{
			return default(Id32<NFJBKYKGXIZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4E00", Offset = "0x2AF3C00", VA = "0x182AF4E00", Slot = "6")]
		public (bool, bool) YSQIGGAPBYL(Id32<TROAQNNIZMC> graphId, Id32<GXAJUPUXNOX> srcId, Id32<WFLMXHQDTIG> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2AF23F0", Offset = "0x2AF11F0", VA = "0x182AF23F0")]
		public bool RVBMETLBWIO(Id32<TROAQNNIZMC> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4C50", Offset = "0x2AF3A50", VA = "0x182AF4C50", Slot = "8")]
		public bool XCSTCQVZGPG(CWZUZWKZEGA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1060", Offset = "0x2AEFE60", VA = "0x182AF1060", Slot = "9")]
		public bool MILDBYBXCBZ(QWJMNUKNOYN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF290", Offset = "0x2AEE090", VA = "0x182AEF290", Slot = "10")]
		public AbsoluteLegacyInputId? GAQCLPNZZKA(Id32<TROAQNNIZMC> graphId, Id32<WFLMXHQDTIG> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2040", Offset = "0x2AF0E40", VA = "0x182AF2040", Slot = "11")]
		public AbsoluteLegacyOutputId? OIBPSERPFQL(Id32<TROAQNNIZMC> graphId, Id32<GXAJUPUXNOX> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0AF0", Offset = "0x2AEF8F0", VA = "0x182AF0AF0", Slot = "12")]
		public Id32<GXAJUPUXNOX>? KGDLTBDJZIR(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId, Id32<SFFGLAFZKMT> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE340", Offset = "0x2AED140", VA = "0x182AEE340", Slot = "13")]
		public Id32<WFLMXHQDTIG>? AYDIXJFOEFQ(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId, Id32<SYBOCFQCTDO> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2380", Offset = "0x2AF1180", VA = "0x182AF2380", Slot = "14")]
		public IEnumerable<Id32<TROAQNNIZMC>> ROVGLOTCGCS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3F90", Offset = "0x2AF2D90", VA = "0x182AF3F90", Slot = "15")]
		public IEnumerable<Id32<ZFIIEZOQVNM>> WJMLDACMPRT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0680", Offset = "0x2AEF480", VA = "0x182AF0680", Slot = "22")]
		public string IHCDVWIAIYZ(Id32<ZFIIEZOQVNM> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1D50", Offset = "0x2AF0B50", VA = "0x182AF1D50", Slot = "16")]
		public Id32<ZFIIEZOQVNM>? NTCCZCWLFIT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF03A0", Offset = "0x2AEF1A0", VA = "0x182AF03A0", Slot = "17")]
		public int HMTKOQULJGS(Id32<ZFIIEZOQVNM> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5610", Offset = "0x2AF4410", VA = "0x182AF5610", Slot = "18")]
		public int ZVQASDSUYHF(Id32<ZFIIEZOQVNM> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0B50", Offset = "0x2AEF950", VA = "0x182AF0B50", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] KGXDHKUEBOI(Id32<ZFIIEZOQVNM> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF1D0", Offset = "0x2AEDFD0", VA = "0x182AEF1D0", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] FTTPASHQPIZ(Id32<ZFIIEZOQVNM> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x32BD490", Offset = "0x32BC290", VA = "0x1832BD490")]
		private static (CircuitTypeIdWrapper, string?)[]? BKFHEVIVDDM<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0BB0", Offset = "0x2AEF9B0", VA = "0x182AF0BB0", Slot = "21")]
		public string KITNEJJQNTF(Id32<ZFIIEZOQVNM> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1380", Offset = "0x2AF0180", VA = "0x182AF1380", Slot = "23")]
		public string NHVRVVBWCXI(Id32<ZFIIEZOQVNM> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2230", Offset = "0x2AF1030", VA = "0x182AF2230")]
		public WVHJGQESRCU? QOFKOTCBYSV([In] Id128<LQPAJNJDNAW> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4CD0", Offset = "0x2AF3AD0", VA = "0x182AF4CD0", Slot = "30")]
		public Id32<HHVRSZHWLKJ> XNOZOANYAVD(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId)
		{
			return default(Id32<HHVRSZHWLKJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEAD0", Offset = "0x2AED8D0", VA = "0x182AEEAD0")]
		public Id32<LQPAJNJDNAW> NFOUHNEIDSE(Id32<TROAQNNIZMC> graphId, [In] Id128<LQPAJNJDNAW> legacyNodeId)
		{
			return default(Id32<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2870", Offset = "0x2AF1670", VA = "0x182AF2870", Slot = "40")]
		public Id32<LQPAJNJDNAW> SNVCTYZIMNL(Id32<TROAQNNIZMC> graphId, Id32<WFLMXHQDTIG> inputId)
		{
			return default(Id32<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0BE0", Offset = "0x2AEF9E0", VA = "0x182AF0BE0", Slot = "41")]
		public Id32<LQPAJNJDNAW> KMSRFJXYDII(Id32<TROAQNNIZMC> graphId, Id32<GXAJUPUXNOX> outputId)
		{
			return default(Id32<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2010", Offset = "0x2AF0E10", VA = "0x182AF2010")]
		public Id32<LQPAJNJDNAW>? NZJANKXPBCY(Id32<TROAQNNIZMC> graphId, [In] Id128<LQPAJNJDNAW> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE0E0", Offset = "0x2AECEE0", VA = "0x182AEE0E0", Slot = "32")]
		public AbsoluteNodeId? AOARZEJNKFY(Id32<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF37E0", Offset = "0x2AF25E0", VA = "0x182AF37E0", Slot = "33")]
		public long VACBUIIWORZ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3760", Offset = "0x2AF2560", VA = "0x182AF3760")]
		private void UTBRZXFEPVN(Id128<LQPAJNJDNAW> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE580", Offset = "0x2AED380", VA = "0x182AEE580", Slot = "38")]
		public IEnumerable<(Id32<TROAQNNIZMC>, Id32<LQPAJNJDNAW>)> BWSWGXPGRQF(Id32<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE370", Offset = "0x2AED170", VA = "0x182AEE370", Slot = "39")]
		public Id32<WFLMXHQDTIG> AYDIXJFOEFQ(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<RAQSAJFZUNU> inputIndex)
		{
			return default(Id32<WFLMXHQDTIG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0B20", Offset = "0x2AEF920", VA = "0x182AF0B20", Slot = "42")]
		public Id32<GXAJUPUXNOX> KGDLTBDJZIR(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<NFJBKYKGXIZ> outputIndex)
		{
			return default(Id32<GXAJUPUXNOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEB00", Offset = "0x2AED900", VA = "0x182AEEB00")]
		private WVHJGQESRCU? FFNWFSXHLFK([In] Id128<LQPAJNJDNAW> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2CD0", Offset = "0x2AF1AD0", VA = "0x182AF2CD0")]
		public ITZFJUYYDSP? TRVZJLNSEOO([In] Id128<LQPAJNJDNAW> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE550", Offset = "0x2AED350", VA = "0x182AEE550")]
		public RDNXSUMSJLC? WVYHLYLFQOH([In] Id128<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4830", Offset = "0x2AF3630", VA = "0x182AF4830", Slot = "25")]
		public RDNXSUMSJLC? WVYHLYLFQOH(Id32<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEA30", Offset = "0x2AED830", VA = "0x182AEEA30", Slot = "34")]
		public IEnumerable<NewStaticEdge> EPYFEMQTVPH(Id32<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF09D0", Offset = "0x2AEF7D0", VA = "0x182AF09D0", Slot = "35")]
		public bool JSIYJPNLTKZ(Id32<ZFIIEZOQVNM> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFCA0", Offset = "0x2AEEAA0", VA = "0x182AEFCA0", Slot = "36")]
		public IEnumerable<StableStaticEdge> GFFXYDAVHWV(Id32<TROAQNNIZMC> graphId, Id32<GXAJUPUXNOX> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF34F0", Offset = "0x2AF22F0", VA = "0x182AF34F0", Slot = "37")]
		public IEnumerable<StableStaticEdge> UGAWIRDRKXC(Id32<TROAQNNIZMC> graphId, Id32<WFLMXHQDTIG> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2C80", Offset = "0x2AF1A80", VA = "0x182AF2C80")]
		public Id32<TROAQNNIZMC> TNSCVHKPLGG([In] Id128<TROAQNNIZMC> graphId)
		{
			return default(Id32<TROAQNNIZMC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF09A0", Offset = "0x2AEF7A0", VA = "0x182AF09A0")]
		public Id32<TROAQNNIZMC>? WUHTGZTATJY([In] Id128<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE870", Offset = "0x2AED670", VA = "0x182AEE870")]
		private MKQIQLGMGLA? EAKNDXQLDJY([In] Id128<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE550", Offset = "0x2AED350", VA = "0x182AEE550")]
		private RDNXSUMSJLC? BKIUGKXOBIR([In] Id128<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4CF0", Offset = "0x2AF3AF0", VA = "0x182AF4CF0", Slot = "28")]
		public Id32<TROAQNNIZMC>? XTVAWBPVUEB(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1360", Offset = "0x2AF0160", VA = "0x182AF1360", Slot = "46")]
		public Id128<TROAQNNIZMC> NEVVHEXVFID(Id32<TROAQNNIZMC> graphId)
		{
			return default(Id128<TROAQNNIZMC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AEECB0", Offset = "0x2AEDAB0", VA = "0x182AEECB0", Slot = "47")]
		public Id128<LQPAJNJDNAW> FOGZMURRBFN(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId)
		{
			return default(Id128<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF11D0", Offset = "0x2AEFFD0", VA = "0x182AF11D0", Slot = "43")]
		public IEnumerable<XJIDAZKYYEX> NBQVLAWYDVD(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2DA0", Offset = "0x2AF1BA0", VA = "0x182AF2DA0", Slot = "44")]
		public XJIDAZKYYEX TXKZMZEAJGE(RoomVersion a, BSZEZNSGOWH b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF10E0", Offset = "0x2AEFEE0", VA = "0x182AF10E0")]
		public NewStaticEdge NGSPEUHRJHM(Id32<TROAQNNIZMC> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0820", Offset = "0x2AEF620", VA = "0x182AF0820", Slot = "48")]
		public StableStaticEdge ITEVPLZTQBZ(Id32<TROAQNNIZMC> graphId, Id32<GXAJUPUXNOX> srcId, Id32<WFLMXHQDTIG> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5400", Offset = "0x2AF4200", VA = "0x182AF5400", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, SJKUUBAWOPB>> YZZIKJDPVLA(Id32<TROAQNNIZMC> parentGraphId, Id32<LQPAJNJDNAW> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE3D0", Offset = "0x2AED1D0", VA = "0x182AEE3D0", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, SJKUUBAWOPB>> BIZJSVEWEKH(Id32<TROAQNNIZMC> parentGraphId, Id128<LQPAJNJDNAW> boardNodeId, List<Id32<LQPAJNJDNAW>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3C00", Offset = "0x2AF2A00", VA = "0x182AF3C00", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, SJKUUBAWOPB>> VRIKQWVVSDG(Id32<TROAQNNIZMC> parentGraphId, Id128<LQPAJNJDNAW> boardNodeId, List<Id32<LQPAJNJDNAW>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE1E0", Offset = "0x2AECFE0", VA = "0x182AEE1E0", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, SJKUUBAWOPB>> ARHRBSGUDZK(Id32<TROAQNNIZMC> parentGraphId, Id128<LQPAJNJDNAW> boardNodeId, Id32<TROAQNNIZMC> graphId, List<Id32<LQPAJNJDNAW>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2B10", Offset = "0x2AF1910", VA = "0x182AF2B10", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<TOCKAIBKNWY>, Id32<SYBOCFQCTDO>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<TOCKAIBKNWY>, Id32<SFFGLAFZKMT>)>) TLRSTXQDUGR(Id128<TROAQNNIZMC> legacyGraphId, Id32<LQPAJNJDNAW> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<TOCKAIBKNWY>, Id32<SYBOCFQCTDO>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<TOCKAIBKNWY>, Id32<SFFGLAFZKMT>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3D50", Offset = "0x2AF2B50", VA = "0x182AF3D50", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task VXSTFXUNMKT(Id128<TROAQNNIZMC> legacyGraphId, Id128<LQPAJNJDNAW> boardNodeId, IReadOnlyList<Id128<LQPAJNJDNAW>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<TOCKAIBKNWY>, Id32<SYBOCFQCTDO>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<TOCKAIBKNWY>, Id32<SFFGLAFZKMT>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3740", Offset = "0x2AF2540", VA = "0x182AF3740", Slot = "55")]
		public bool UKONGGCXUQH(Id32<TROAQNNIZMC> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0980", Offset = "0x2AEF780", VA = "0x182AF0980", Slot = "56")]
		public bool JERZZGBMISP(Id32<TROAQNNIZMC> graphId, Id32<WFLMXHQDTIG> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2360", Offset = "0x2AF1160", VA = "0x182AF2360", Slot = "57")]
		public bool RLEAKGOJSQM(Id32<TROAQNNIZMC> graphId, Id32<GXAJUPUXNOX> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0210", Offset = "0x2AEF010", VA = "0x182AF0210")]
		public Result<PPOKMLHFENR.PrepareTemplateForCloneResult, NVAIURBTDUG> HJWMNAWTUZG([In] PPOKMLHFENR.PrepareTemplateForCloneArgs args)
		{
			return default(Result<PPOKMLHFENR.PrepareTemplateForCloneResult, NVAIURBTDUG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF20C0", Offset = "0x2AF0EC0", VA = "0x182AF20C0", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, SJKUUBAWOPB>> PKUIQWQYLZI(Id32<TROAQNNIZMC> graphId, Id32<GXAJUPUXNOX> srcId, Id32<WFLMXHQDTIG> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0240", Offset = "0x2AEF040", VA = "0x182AF0240", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<LQPAJNJDNAW>, SJKUUBAWOPB>> HKEUOKQYHLJ(Id32<TROAQNNIZMC> graphId, Id32<HHVRSZHWLKJ> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2890", Offset = "0x2AF1690", VA = "0x182AF2890", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> SPKUQUFVKLA(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF30A0", Offset = "0x2AF1EA0", VA = "0x182AF30A0", Slot = "62")]
		public Result<ControlPanelRootData, HEYQXAVABBH> UDPHVEIABBW(Id128<TROAQNNIZMC> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, HEYQXAVABBH>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2710", Offset = "0x2AF1510", VA = "0x182AF2710", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, SJKUUBAWOPB>> SDMCHUDMTAI(Id128<TROAQNNIZMC> graphId, Id128<LQPAJNJDNAW> inputNodeId, Id32<TOCKAIBKNWY> inputPortGroupId, Id32<SYBOCFQCTDO> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF03C0", Offset = "0x2AEF1C0", VA = "0x182AF03C0", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, SJKUUBAWOPB>> HOUDYJDUUID(Id128<TROAQNNIZMC> graphId, Id128<LQPAJNJDNAW> outputNodeId, Id32<TOCKAIBKNWY> outputPortGroupId, Id32<SFFGLAFZKMT> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE910", Offset = "0x2AED710", VA = "0x182AEE910", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, SJKUUBAWOPB>> EDJRXVNFJGM(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0F00", Offset = "0x2AEFD00", VA = "0x182AF0F00", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<LQPAJNJDNAW>>, SJKUUBAWOPB>> LLMNWKNDBDD(Id128<TROAQNNIZMC> intoGraphId, CircuitTemplateRootData a, IEnumerable<PALJQNQKVVN> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE630", Offset = "0x2AED430", VA = "0x182AEE630", Slot = "67")]
		public CircuitsData CDTJILPIDEX()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF12D0", Offset = "0x2AF00D0", VA = "0x182AF12D0", Slot = "68")]
		public CircuitsData NCDLLENMRDA()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4020", Offset = "0x2AF2E20", VA = "0x182AF4020", Slot = "71")]
		public CircuitsTemplateData WTDBYAUCNZD(TemplateSerializationReason a, Id32<TROAQNNIZMC> sourceGraphId, IEnumerable<Id128<TROAQNNIZMC>> graphIds, IEnumerable<Id128<LQPAJNJDNAW>> nodeIds, ISet<Id128<ZOPOWZPEQUO>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0C00", Offset = "0x2AEFA00", VA = "0x182AF0C00")]
		private CircuitsTemplateData KPXRRPOBFWM(TemplateSerializationReason a, Id32<TROAQNNIZMC> sourceGraphId, IEnumerable<Id128<TROAQNNIZMC>> graphIds, IEnumerable<Id128<LQPAJNJDNAW>> nodeIds, ISet<Id128<ZOPOWZPEQUO>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3890", Offset = "0x2AF2690", VA = "0x182AF3890", Slot = "69")]
		public CircuitsTemplateData VREFLEKANAU(TemplateSerializationReason a, Id32<TROAQNNIZMC> sourceGraphId, IEnumerable<Id128<LQPAJNJDNAW>> nodeIds, IEnumerable<PALJQNQKVVN> b, ISet<Id128<ZOPOWZPEQUO>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3AF0", Offset = "0x2AF28F0", VA = "0x182AF3AF0", Slot = "70")]
		public CircuitsTemplateData VREFLEKANAU(TemplateSerializationReason a, Id32<TROAQNNIZMC> sourceGraphId, IEnumerable<Id32<LQPAJNJDNAW>> nodeIds, IEnumerable<PALJQNQKVVN> b, ISet<Id128<ZOPOWZPEQUO>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4880", Offset = "0x2AF3680", VA = "0x182AF4880")]
		private static IEnumerable<Id128<TROAQNNIZMC>> XASPGXBLMOY(IEnumerable<PALJQNQKVVN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AEECD0", Offset = "0x2AEDAD0", VA = "0x182AEECD0")]
		private IEnumerable<Id128<LQPAJNJDNAW>> FRHDBCDACQS(IEnumerable<PALJQNQKVVN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF52A0", Offset = "0x2AF40A0", VA = "0x182AF52A0", Slot = "72")]
		public List<ZJXQXZHJORD> YXVGTJCXCFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF41C0", Offset = "0x2AF2FC0", VA = "0x182AF41C0")]
		public (List<ZJXQXZHJORD>, bool) WUTICZUEUOE([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, RKOCWUGHZBJ b, WPOMOYRBFHL c)
		{
			return default((List<ZJXQXZHJORD>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2D10", Offset = "0x2AF1B10", VA = "0x182AF2D10", Slot = "74")]
		public bool TUVEKSUAPRL(Id32<TROAQNNIZMC> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE720", Offset = "0x2AED520", VA = "0x182AEE720", Slot = "75")]
		public bool DLRRFXCVOYH(Id32<TROAQNNIZMC> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2210", Offset = "0x2AF1010", VA = "0x182AF2210")]
		internal void PUWUPJOKYQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2CB0", Offset = "0x2AF1AB0", VA = "0x182AF2CB0")]
		internal Task TQQELXAPUWO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF2F0", Offset = "0x2AEE0F0", VA = "0x182AEF2F0", Slot = "76")]
		public Result<Id32<GXAJUPUXNOX>?, SJKUUBAWOPB> GAVWADXNVSO(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<WFLMXHQDTIG> inputId)
		{
			return default(Result<Id32<GXAJUPUXNOX>?, SJKUUBAWOPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF13A0", Offset = "0x2AF01A0", VA = "0x182AF13A0", Slot = "77")]
		public Result<Id32<WFLMXHQDTIG>?, SJKUUBAWOPB> NSCFFWLZHAK(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<GXAJUPUXNOX> outputId)
		{
			return default(Result<Id32<WFLMXHQDTIG>?, SJKUUBAWOPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3EA0", Offset = "0x2AF2CA0", VA = "0x182AF3EA0", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, SJKUUBAWOPB>> WAJNFVJSOOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDFA0", Offset = "0x2AECDA0", VA = "0x182AEDFA0", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, SJKUUBAWOPB>> AHIQVHYGMCT(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFF10", Offset = "0x2AEED10", VA = "0x182AEFF10", Slot = "80")]
		public Id32<LQPAJNJDNAW>? GTQLBLJHDFL(Id32<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0A30", Offset = "0x2AEF830", VA = "0x182AF0A30", Slot = "81")]
		public Id32<LQPAJNJDNAW>? JVLSEAOZVOW(Id32<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3800", Offset = "0x2AF2600", VA = "0x182AF3800", Slot = "82")]
		public int VDNGZUVZKGU(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3420", Offset = "0x2AF2220", VA = "0x182AF3420", Slot = "83")]
		public int UFTTTFTGZHT(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFFD0", Offset = "0x2AEEDD0", VA = "0x182AEFFD0", Slot = "84")]
		public int GWGGTHHWODU(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId, Id32<ENGFBJMMTKB> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0740", Offset = "0x2AEF540", VA = "0x182AF0740", Slot = "85")]
		public int INNISCHTBNS(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId, Id32<ENGFBJMMTKB> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF29D0", Offset = "0x2AF17D0", VA = "0x182AF29D0", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, SJKUUBAWOPB>> SZUKGKFWABY(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId, Id32<ENGFBJMMTKB> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEB70", Offset = "0x2AED970", VA = "0x182AEEB70", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, SJKUUBAWOPB>> FHIXWZULBWP(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId, Id32<ENGFBJMMTKB> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5550", Offset = "0x2AF4350", VA = "0x182AF5550", Slot = "88")]
		public int ZLORAVYLROO(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0520", Offset = "0x2AEF320", VA = "0x182AF0520", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, SJKUUBAWOPB>> HQHVOIFYHWE(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF00B0", Offset = "0x2AEEEB0", VA = "0x182AF00B0", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, SJKUUBAWOPB>> HCKXFAEJNGB(Id32<TROAQNNIZMC> graphId, Id32<LQPAJNJDNAW> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0D90", Offset = "0x2AEFB90", VA = "0x182AF0D90", Slot = "91")]
		public bool LGTQLJOTSZW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFEF0", Offset = "0x2AEECF0", VA = "0x182AEFEF0", Slot = "97")]
		public IEnumerable<Id32<VKUGUULGSUQ>> GPYZPZNFUBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF21F0", Offset = "0x2AF0FF0", VA = "0x182AF21F0", Slot = "98")]
		public string? PQVMVGMNHDW(Id32<VKUGUULGSUQ> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEA20", Offset = "0x2AED820", VA = "0x182AEEA20", Slot = "7")]
		private bool EJMBFLPIUPE(Id32<TROAQNNIZMC> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE550", Offset = "0x2AED350", VA = "0x182AEE550", Slot = "24")]
		private RDNXSUMSJLC BJOLCTXTSIH([In] Id128<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2C80", Offset = "0x2AF1A80", VA = "0x182AF2C80", Slot = "26")]
		private Id32<TROAQNNIZMC> ZMUBMZEKLMW([In] Id128<TROAQNNIZMC> graphId)
		{
			return default(Id32<TROAQNNIZMC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2AF09A0", Offset = "0x2AEF7A0", VA = "0x182AF09A0", Slot = "27")]
		private Id32<TROAQNNIZMC>? JIHNNAZWLUG([In] Id128<TROAQNNIZMC> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2AF52E0", Offset = "0x2AF40E0", VA = "0x182AF52E0", Slot = "29")]
		private WVHJGQESRCU YZOBYCVZMQF([In] Id128<LQPAJNJDNAW> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEAD0", Offset = "0x2AED8D0", VA = "0x182AEEAD0", Slot = "31")]
		private Id32<LQPAJNJDNAW> ESQXRHQQZDG(Id32<TROAQNNIZMC> graphId, [In] Id128<LQPAJNJDNAW> legacyNodeId)
		{
			return default(Id32<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2AF10E0", Offset = "0x2AEFEE0", VA = "0x182AF10E0", Slot = "45")]
		private NewStaticEdge MJQMLDLDLVU(Id32<TROAQNNIZMC> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0210", Offset = "0x2AEF010", VA = "0x182AF0210", Slot = "58")]
		private Result<PPOKMLHFENR.PrepareTemplateForCloneResult, NVAIURBTDUG> VGDFSXJYJSU([In] PPOKMLHFENR.PrepareTemplateForCloneArgs args)
		{
			return default(Result<PPOKMLHFENR.PrepareTemplateForCloneResult, NVAIURBTDUG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF230", Offset = "0x2AEE030", VA = "0x182AEF230", Slot = "73")]
		private (List<ZJXQXZHJORD>, bool) FYPGDGDONAQ([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, RKOCWUGHZBJ b, WPOMOYRBFHL c)
		{
			return default((List<ZJXQXZHJORD>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2AF06D0", Offset = "0x2AEF4D0", VA = "0x182AF06D0")]
		[CompilerGenerated]
		private EVSQCMILSUU INHCQFNLWPL(VJBGGKQUSTY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE6F0", Offset = "0x2AED4F0", VA = "0x182AEE6F0")]
		[CompilerGenerated]
		private ITZFJUYYDSP OOPKFCAPLRD(Id128<LQPAJNJDNAW> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE6C0", Offset = "0x2AED4C0", VA = "0x182AEE6C0")]
		[CompilerGenerated]
		private MKQIQLGMGLA OOKDHVGSCFU(Id128<TROAQNNIZMC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE6F0", Offset = "0x2AED4F0", VA = "0x182AEE6F0")]
		[CompilerGenerated]
		private ITZFJUYYDSP CZYHNDGGFKB(Id128<LQPAJNJDNAW> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE6C0", Offset = "0x2AED4C0", VA = "0x182AEE6C0")]
		[CompilerGenerated]
		private MKQIQLGMGLA CZTAPWMIVYS(Id128<TROAQNNIZMC> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class EVSQCMILSUU : XJIDAZKYYEX
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
			public AsyncTaskMethodBuilder<Result<Id32<ENGFBJMMTKB>, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public EVSQCMILSUU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<LQPAJNJDNAW> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<TOCKAIBKNWY> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<ENGFBJMMTKB>, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2AFC380", Offset = "0x2AFB180", VA = "0x182AFC380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x2AFC5D0", Offset = "0x2AFB3D0", VA = "0x182AFC5D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<NLSPOFOVMCC>, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public EVSQCMILSUU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<TROAQNNIZMC> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<LQPAJNJDNAW> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<TOCKAIBKNWY> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<NLSPOFOVMCC>, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2AFC640", Offset = "0x2AFB440", VA = "0x182AFC640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2AFC890", Offset = "0x2AFB690", VA = "0x182AFC890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly VJBGGKQUSTY EBSXUQODBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly QJDKMJZUZXH RGDFIMVWSGB;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey UNMENMUBEPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string ZIXAHHZDHMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x2AF82F0", Offset = "0x2AF70F0", VA = "0x182AF82F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public VJBGGKQUSTY VJBGGKQUSTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8320", Offset = "0x2AF7120", VA = "0x182AF8320")]
		public EVSQCMILSUU(VJBGGKQUSTY a, QJDKMJZUZXH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8010", Offset = "0x2AF6E10", VA = "0x182AF8010", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<ENGFBJMMTKB>, SJKUUBAWOPB>> AKRTUGOHOHP(Id128<TROAQNNIZMC> graphId, Id128<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8180", Offset = "0x2AF6F80", VA = "0x182AF8180", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<NLSPOFOVMCC>, SJKUUBAWOPB>> NRPBTXOWQQK(Id128<TROAQNNIZMC> graphId, Id128<LQPAJNJDNAW> nodeId, Id32<TOCKAIBKNWY> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class MKSFTRBCKAG : RGQBZFZJYOU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly VJBGGKQUSTY CWEPRURLXRQ;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<VJBGGKQUSTY> ACEJGYJSSUY;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<VJBGGKQUSTY> WUJFTCHKMOZ;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<VJBGGKQUSTY> QWNFBLCJMHW;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public VJBGGKQUSTY QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAF90", Offset = "0x2AF9D90", VA = "0x182AFAF90", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAF80", Offset = "0x2AF9D80", VA = "0x182AFAF80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAFE0", Offset = "0x2AF9DE0", VA = "0x182AFAFE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAF00", Offset = "0x2AF9D00", VA = "0x182AFAF00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9230", Offset = "0x2AF8030", VA = "0x182AF9230")]
		public bool CUOXAFRLPOP(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public MKSFTRBCKAG(VJBGGKQUSTY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2AF94A0", Offset = "0x2AF82A0", VA = "0x182AF94A0")]
		internal static TypeKey PZFMSSEDMTO(VJBGGKQUSTY a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2AF82F0", Offset = "0x2AF70F0", VA = "0x182AF82F0", Slot = "3")]
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
	public readonly struct ActionDeps : ELLZGADELWZ.MGXIZUFHQWM<ELPAQFNEADX, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5BB0", Offset = "0x2AF49B0", VA = "0x182AF5BB0", Slot = "4")]
		public int WAEIPGOUELQ(None a, ELPAQFNEADX b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5BA0", Offset = "0x2AF49A0", VA = "0x182AF5BA0", Slot = "5")]
		public ELPAQFNEADX TQEWTNTNPIZ(None a, ELPAQFNEADX b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5B10", Offset = "0x2AF4910", VA = "0x182AF5B10", Slot = "6")]
		public ELPAQFNEADX NRJWQRYEUOW(None a, ELPAQFNEADX b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5B80", Offset = "0x2AF4980", VA = "0x182AF5B80", Slot = "7")]
		public IReadOnlyList<ELPAQFNEADX> TFLQAORVLPW(None a, ELPAQFNEADX b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5AA0", Offset = "0x2AF48A0", VA = "0x182AF5AA0", Slot = "8")]
		public ELPAQFNEADX[] AITCBGBGNOT(None a, ELPAQFNEADX b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5AF0", Offset = "0x2AF48F0", VA = "0x182AF5AF0", Slot = "9")]
		public bool JSNQNFDCQCA(None a, ELPAQFNEADX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5BD0", Offset = "0x2AF49D0", VA = "0x182AF5BD0", Slot = "10")]
		public bool XXWIVNRRAZQ(None a, ELPAQFNEADX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5B40", Offset = "0x2AF4940", VA = "0x182AF5B40", Slot = "11")]
		public bool NVWOOSILPKA(None a, ELPAQFNEADX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5B60", Offset = "0x2AF4960", VA = "0x182AF5B60", Slot = "12")]
		public bool RTAKLDRJNPE(None a, ELPAQFNEADX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5AD0", Offset = "0x2AF48D0", VA = "0x182AF5AD0", Slot = "13")]
		public bool IEWXXYYTKEQ(None a, ELPAQFNEADX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5AB0", Offset = "0x2AF48B0", VA = "0x182AF5AB0", Slot = "14")]
		public bool DGQOFGHISPH(None a, ELPAQFNEADX b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class LHRGNHCJUNN : RAMVABNVEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract IYEHCMGHYUZ.XQEIROEEFNO UGWZVGLBOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract RGZHVGRSJVI.XQEIROEEFNO FKKGLUKMDTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract HHBELIZAZTL.XQEIROEEFNO NJIXVJOPWFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI> QBILVALNXRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x2AF91E0", Offset = "0x2AF7FE0", VA = "0x182AF91E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.XQEIROEEFNO IWVMVGFINXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract HBKJLPUCFON RGEYZGDJYUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract YTSHAVYTUSY HAFZOOZMFCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract SKHEHGRSHLY PERFJBHOVYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract ZPSEWEXFJLQ VOHNTVXESAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract EAPBZKKMHYU TNXCLFCQOXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected LHRGNHCJUNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class DYREXXKQRTN : HJACRTQVELT
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
			public AsyncTaskMethodBuilder<Result<MultiResult, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<ELPAQFNEADX> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public DYREXXKQRTN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFCED0", Offset = "0x2AFBCD0", VA = "0x182AFCED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD2F0", Offset = "0x2AFC0F0", VA = "0x182AFD2F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public DYREXXKQRTN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public ELPAQFNEADX action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2B01C70", Offset = "0x2B00A70", VA = "0x182B01C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2B01EF0", Offset = "0x2B00CF0", VA = "0x182B01EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly SVBMWMSSDIU PJJOWOJGXQG;

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public DYREXXKQRTN(SVBMWMSSDIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5BF0", Offset = "0x2AF49F0", VA = "0x182AF5BF0")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, SJKUUBAWOPB>> TLBNIVDFOCM(ELPAQFNEADX a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5D20", Offset = "0x2AF4B20", VA = "0x182AF5D20", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, SJKUUBAWOPB>> VBLXPQPLRGA(IReadOnlyList<ELPAQFNEADX> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, ELPAQFNEADX, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x1313220", Offset = "0x1312020", VA = "0x181313220")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, ELPAQFNEADX, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBEC0", Offset = "0x2AFACC0", VA = "0x182AFBEC0")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class DVPCIIGSEYK
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, ELPAQFNEADX, PartialActionReassemblyDeps> ALLBMPGAGHP(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, ELPAQFNEADX, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : QYRFBIONUPZ.YUERGOQQINL<PartialActionPayload, Id128<PartialActionPayload.M>, ELPAQFNEADX>
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBCD0", Offset = "0x2AFAAD0", VA = "0x182AFBCD0", Slot = "7")]
		public ELPAQFNEADX PHRYTBSSXTN(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x130FD50", Offset = "0x130EB50", VA = "0x18130FD50")]
		public Id128<PartialActionPayload.M> PHUALTNPCAP([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x132A5E0", Offset = "0x13293E0", VA = "0x18132A5E0")]
		public int GNSRAAMFHDH([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBCC0", Offset = "0x2AFAAC0", VA = "0x182AFBCC0")]
		public int RVFZIEELMNM([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x132A5E0", Offset = "0x13293E0", VA = "0x18132A5E0", Slot = "4")]
		private int YUNERLVWHYH([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBCC0", Offset = "0x2AFAAC0", VA = "0x182AFBCC0", Slot = "5")]
		private int FCGRIWWOTGQ([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x130FD50", Offset = "0x130EB50", VA = "0x18130FD50", Slot = "6")]
		private Id128<PartialActionPayload.M> IWQFBCJHFMN([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, ELPAQFNEADX, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x1313220", Offset = "0x1312020", VA = "0x181313220")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, ELPAQFNEADX, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC320", Offset = "0x2AFB120", VA = "0x182AFC320")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class GBXHZJGAXEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30")]
		public static SnapshotReassembly<PartialInitializePayload, ELPAQFNEADX, SnapshotReassemblyDeps> ALLBMPGAGHP(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, ELPAQFNEADX, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : YUOEODGOXES.YTZKJHWSZCC<PartialInitializePayload, ELPAQFNEADX>
	{
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x150BC80", Offset = "0x150AA80", VA = "0x18150BC80")]
		public int XJXKQQCYOFJ([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC130", Offset = "0x2AFAF30", VA = "0x182AFC130", Slot = "5")]
		public ELPAQFNEADX YJGQRRMXUJD(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x150BC80", Offset = "0x150AA80", VA = "0x18150BC80", Slot = "4")]
		private int GGAFRYZBWON([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class KWHIYABOEJN : NLAHVKALZBM, NVAIURBTDUG, SJKUUBAWOPB, HEYQXAVABBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly HEYQXAVABBH? GWVNBWSMNZR;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind KFDHSHLWAWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5F30", VA = "0x180AA7130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override HEYQXAVABBH? ZPCKSBYJGSI
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8FD0", Offset = "0x2AF7DD0", VA = "0x182AF8FD0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF91A0", Offset = "0x2AF7FA0", VA = "0x182AF91A0")]
		private KWHIYABOEJN(PrepareTemplateForCloneErrKind a, HEYQXAVABBH? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9130", Offset = "0x2AF7F30", VA = "0x182AF9130")]
		public static KWHIYABOEJN UDMQQEVDSJV(HEYQXAVABBH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF90D0", Offset = "0x2AF7ED0", VA = "0x182AF90D0")]
		public static KWHIYABOEJN OXRAXUZCVOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8F70", Offset = "0x2AF7D70", VA = "0x182AF8F70")]
		public static KWHIYABOEJN BFEVISQXVPT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class RKLCXOTIASG
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x3C35C00", Offset = "0x3C34A00", VA = "0x183C35C00")]
		public static Result<TOk, NVAIURBTDUG> JLGYVPAAQTW<TOk>([In] this Result<TOk, NVAIURBTDUG> self, HEYQXAVABBH a) where TOk : notnull
		{
			return default(Result<TOk, NVAIURBTDUG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x3C35B80", Offset = "0x3C34980", VA = "0x183C35B80")]
		public static Result<a?, NVAIURBTDUG?> DECBNFHPIBU<a>([In] this Result<a, NVAIURBTDUG> self)
		{
			return default(Result<a, NVAIURBTDUG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x3C35E40", Offset = "0x3C34C40", VA = "0x183C35E40")]
		public static Result<b?, NVAIURBTDUG?> TIQEBOMVQLK<b>([In] this Result<b, NVAIURBTDUG> self)
		{
			return default(Result<b, NVAIURBTDUG>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface HBKJLPUCFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BPIJXXNOVRB([In] Result<None, HEYQXAVABBH> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class CXDDMNRLYAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x37370F0", Offset = "0x3735EF0", VA = "0x1837370F0")]
		public static bool BPIJXXNOVRB<TOk, TErr>(this HBKJLPUCFON a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, HEYQXAVABBH
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface YTSHAVYTUSY
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		MJLOQDUEBTO NNRKKJPGEGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface SKHEHGRSHLY
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor NXVCIGDAOQT(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface FMGOVHDYEGL
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface MRXXYBMJXQA
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UTBCOYJEGFE? IDQSUMLEHQJ(Id32<TOCKAIBKNWY> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface EROOUTBSDQQ
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface UTBCOYJEGFE
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		EROOUTBSDQQ? VJSHIWZYMMD(Id32<ENGFBJMMTKB> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FMGOVHDYEGL? TKQAKNYRDRE(Id32<NLSPOFOVMCC> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface ZPSEWEXFJLQ
	{
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> NBFBOFCEUBK(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface EAPBZKKMHYU
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MRXXYBMJXQA? UVSCQOIEIUJ([In] Id128<PXJWRZNPPPA> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class OBRBBBJAXST
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
			public readonly List<ELPAQFNEADX> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5F00", Offset = "0x2AF4D00", VA = "0x182AF5F00")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<ELPAQFNEADX> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5E50", Offset = "0x2AF4C50", VA = "0x182AF5E50")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly EWZYIHMIDEI<Diagnostic> IFDUMNXMCMV;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static OBRBBBJAXST VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB200", Offset = "0x2AFA000", VA = "0x182AFB200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool PWQQEXHNITL
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xAF1380", Offset = "0xAF0180", VA = "0x180AF1380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0xBF7410", Offset = "0xBF6210", VA = "0x180BF7410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB140", Offset = "0x2AF9F40", VA = "0x182AFB140")]
		public void BLGDMKIQDTO(QJDKMJZUZXH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB410", Offset = "0x2AFA210", VA = "0x182AFB410")]
		public void ZJHBJFCUJZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB250", Offset = "0x2AFA050", VA = "0x182AFB250")]
		private static string? ISYPDFFVMJL([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB7E0", Offset = "0x2AFA5E0", VA = "0x182AFB7E0")]
		public OBRBBBJAXST()
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
