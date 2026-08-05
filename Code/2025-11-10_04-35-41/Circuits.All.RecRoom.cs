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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2811230", Offset = "0x2810630", VA = "0x182811230")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x28109D0", Offset = "0x280FDD0", VA = "0x1828109D0", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class AUQKPBYPMDP : IDisposable, VCAHKPHXNHQ, SFGLUSMFRGD, IEBGZIOLEVU
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class IXIUPKGVEEA : ALXXNXZFOSL
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int ZVIYHVBCGVS
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2810480", Offset = "0x280F880", VA = "0x182810480", Slot = "5")]
			public GNWDQRYJEFF LUUWKQXAUXO(AYAZJFNSIFY.ALXXNXZFOSL a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void CKKEVZKOCQY();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void FIBNMYMZWQH();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2801B10", Offset = "0x2800F10", VA = "0x182801B10", Slot = "13")]
			public virtual void RMKERTAHZRT(AUQKPBYPMDP a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x28102A0", Offset = "0x280F6A0", VA = "0x1828102A0", Slot = "14")]
			public virtual void CUMSSDFNYBM(AUQKPBYPMDP a, VLXCXCSSZAI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			protected IXIUPKGVEEA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ALXXNXZFOSL
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int ZVIYHVBCGVS
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			GNWDQRYJEFF LUUWKQXAUXO(AYAZJFNSIFY.ALXXNXZFOSL a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void CKKEVZKOCQY();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void FIBNMYMZWQH();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void RMKERTAHZRT(AUQKPBYPMDP a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void CUMSSDFNYBM(AUQKPBYPMDP a, VLXCXCSSZAI b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP, RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xFB42A0", Offset = "0xFB36A0", VA = "0x180FB42A0")]
			internal Reducer(Reducer<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP, RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class VRQYXACKGZC : RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly VRQYXACKGZC LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private VRQYXACKGZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1204400", Offset = "0x1203800", VA = "0x181204400", Slot = "4")]
			public ActionKind REKJBCOSSKU(VLXCXCSSZAI a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x282C580", Offset = "0x282B980", VA = "0x18282C580", Slot = "5")]
			public void RMKERTAHZRT(AUQKPBYPMDP a, VLXCXCSSZAI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x282C470", Offset = "0x282B870", VA = "0x18282C470", Slot = "6")]
			public void CUMSSDFNYBM(AUQKPBYPMDP a, VLXCXCSSZAI b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP, RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x281DB50", Offset = "0x281CF50", VA = "0x18281DB50")]
			internal ReducerFactory(ReducerFactory<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP, RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x281DB00", Offset = "0x281CF00", VA = "0x18281DB00")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : YTIPMBUMKVK.GZCKQDRWUAA<VLXCXCSSZAI, AUQKPBYPMDP>
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
				public AsyncTaskMethodBuilder<Result<object?, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public AUQKPBYPMDP receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public VLXCXCSSZAI action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x28214E0", Offset = "0x28208E0", VA = "0x1828214E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x28216C0", Offset = "0x2820AC0", VA = "0x1828216C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB04900", Offset = "0xB03D00", VA = "0x180B04900", Slot = "4")]
			public Id32<FJSVDCFYEAW> YVSJMCAIEIT(AUQKPBYPMDP a)
			{
				return default(Id32<FJSVDCFYEAW>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x281EA80", Offset = "0x281DE80", VA = "0x18281EA80", Slot = "5")]
			public void TLZSZVKSXFW(AUQKPBYPMDP a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x281EAE0", Offset = "0x281DEE0", VA = "0x18281EAE0", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, RAGLFGQXJZI>> UTPQLLOACBH(AUQKPBYPMDP a, VLXCXCSSZAI b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x281EA60", Offset = "0x281DE60", VA = "0x18281EA60", Slot = "7")]
			public VLXCXCSSZAI[] DMYPDINFOEV(AUQKPBYPMDP a)
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
			public AsyncTaskMethodBuilder<Result<object?, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public AUQKPBYPMDP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public VLXCXCSSZAI action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2821730", Offset = "0x2820B30", VA = "0x182821730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2821920", Offset = "0x2820D20", VA = "0x182821920", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public AUQKPBYPMDP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2822E60", Offset = "0x2822260", VA = "0x182822E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x28230E0", Offset = "0x28224E0", VA = "0x1828230E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AUQKPBYPMDP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2823150", Offset = "0x2822550", VA = "0x182823150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2823330", Offset = "0x2822730", VA = "0x182823330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<FJSVDCFYEAW> WIAPBGXZCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer PHKLTZVLHEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 JQZPKIMWPBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EB0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly PHMKKHZLINW WBAXDAZKXYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly MCGUTYIFENK.CreationArgs CSPHYMTJYJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly UDBOMBDPSDP OGOTCYGZQYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly WJICPLMKAMU KEKSLSGNWOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly VTSDFFBTWFZ XZWRVRUMFUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly ZZFOJFXVFUA DUIJJXVSMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly EXUBBYSPYXO JMERTNABFYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly MXCNSZOYCYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly PJMSPYZTYBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest CPSNKPESROC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended CLRZZUSKHTV;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal ALXXNXZFOSL MKORQESJIXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x280DC40", Offset = "0x280D040", VA = "0x18280DC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal GNWDQRYJEFF NWTWXUSSHEO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x280D860", Offset = "0x280CC60", VA = "0x18280D860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x280E300", Offset = "0x280D700", VA = "0x18280E300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool PTDGGKWCEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x280DD00", Offset = "0x280D100", VA = "0x18280DD00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x280E320", Offset = "0x280D720", VA = "0x18280E320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DGORIRYPZWM UDBOMBDPSDP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x280E820", Offset = "0x280DC20", VA = "0x18280E820", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ZIDJAMSNONC VTSDFFBTWFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x280E830", Offset = "0x280DC30", VA = "0x18280E830", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public JBIKIRFDWLV EXUBBYSPYXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x280E850", Offset = "0x280DC50", VA = "0x18280E850", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NKMPTCHVIDV WJICPLMKAMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x280E0A0", Offset = "0x280D4A0", VA = "0x18280E0A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GYJOBUSAVKZ ZZFOJFXVFUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x280E840", Offset = "0x280DC40", VA = "0x18280E840", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MCGUTYIFENK? MCGUTYIFENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x280DB60", Offset = "0x280CF60", VA = "0x18280DB60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x280E530", Offset = "0x280D930", VA = "0x18280E530")]
		private AUQKPBYPMDP(PHMKKHZLINW a, Id32<FJSVDCFYEAW> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, GNWDQRYJEFF b, [In] MCGUTYIFENK.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x280DFD0", Offset = "0x280D3D0", VA = "0x18280DFD0")]
		public static AUQKPBYPMDP New(PHMKKHZLINW deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<FJSVDCFYEAW> actorId, Id32<LPULDJDRFFP> rootNetworkObjectId, ZVRVTWCRUTF staticNetSys, GUDZVKDXAAH dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x280DD10", Offset = "0x280D110", VA = "0x18280DD10")]
		public static AUQKPBYPMDP New(PHMKKHZLINW dependencies, [In] RegistryV2 registryV2, Id32<FJSVDCFYEAW> actorId, Id32<LPULDJDRFFP> rootNetworkObjectId, ZVRVTWCRUTF staticNetSys, GUDZVKDXAAH dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x280D680", Offset = "0x280CA80", VA = "0x18280D680", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x280DA70", Offset = "0x280CE70", VA = "0x18280DA70")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, RAGLFGQXJZI>> HYHVTEALLWE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x280E440", Offset = "0x280D840", VA = "0x18280E440")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, RAGLFGQXJZI>> ZMHRVNEPBKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x280D870", Offset = "0x280CC70", VA = "0x18280D870")]
		internal void HQBWUGIJIRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x280E0B0", Offset = "0x280D4B0", VA = "0x18280E0B0")]
		internal Option<VLXCXCSSZAI> RQMGCFDMMEM([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<VLXCXCSSZAI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x280DC90", Offset = "0x280D090", VA = "0x18280DC90")]
		internal bool LEJHUQWEAXB([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x280E180", Offset = "0x280D580", VA = "0x18280E180")]
		internal Result<VLXCXCSSZAI, RAGLFGQXJZI> TOSPTLEHTAU([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<VLXCXCSSZAI, RAGLFGQXJZI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x280E130", Offset = "0x280D530", VA = "0x18280E130")]
		private void TLZSZVKSXFW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x280E330", Offset = "0x280D730", VA = "0x18280E330")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, RAGLFGQXJZI>> XTFHVVQTCSU(VLXCXCSSZAI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x280D280", Offset = "0x280C680", VA = "0x18280D280")]
		private VLXCXCSSZAI[] DMYPDINFOEV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class MWQZUZGXXSB<a> : GKLIEWNFSHL, YDOJLCJITLX, XOJOHOBKPDS where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<FRZIQAPUPIV>? GJJDSDAWWHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string EZHNQEWUXQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a VQVHWHVOHGG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<FRZIQAPUPIV>? VFVORBANNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8850", Offset = "0x2AF7C50", VA = "0x182AF8850", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x57DEC90", Offset = "0x57DE090", VA = "0x1857DEC90")]
		internal MWQZUZGXXSB([In] Id128<FRZIQAPUPIV>? lastNode, Id32<KRAHEPMHAQK>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class UQOMUCEIQLX
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2826F30", Offset = "0x2826330", VA = "0x182826F30")]
		public static Result<DebugExecutionResult, YDOJLCJITLX> RWJDDBWCXSW([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, YDOJLCJITLX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0970", Offset = "0x3BAFD70", VA = "0x183BB0970")]
		public static Result<TOk, YDOJLCJITLX> IGJLFWZHRZA<TOk>([In] this Result<TOk, YDOJLCJITLX> self, [In] Id128<FRZIQAPUPIV>? lastNode, Id32<KRAHEPMHAQK>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, YDOJLCJITLX>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface PHMKKHZLINW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		AYAZJFNSIFY.ALXXNXZFOSL IGMGNSJIQBS
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		AUQKPBYPMDP.ALXXNXZFOSL ZPCSKYYTWMX
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		HGEHYAJDPNG.ALXXNXZFOSL JOUDFCYGGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP> VRQYXACKGZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.ALXXNXZFOSL BWRJSSVQRZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		WTTLBDSHSXM YXHITRENJNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		BSBAJWUIWZV NMRGTZVZSAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		JKZPZKKOTQX VXKWKFOKFNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		DYPXEDJBIXJ QVPTAXTVMFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		REEYAUJRNNP BVRLFSWXCEM
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
	public static class VADXAHUTSJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2827820", Offset = "0x2826C20", VA = "0x182827820")]
		public static VLXCXCSSZAI SXEOROAFTOG(this VLXCXCSSZAI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2827750", Offset = "0x2826B50", VA = "0x182827750")]
		public static VLXCXCSSZAI CPLDJUIINHX(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public AUQKPBYPMDP root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2821990", Offset = "0x2820D90", VA = "0x182821990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x28220C0", Offset = "0x28214C0", VA = "0x1828220C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x280F4E0", Offset = "0x280E8E0", VA = "0x18280F4E0")]
		public static VLXCXCSSZAI DCFKJHKOADU(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x280F5A0", Offset = "0x280E9A0", VA = "0x18280F5A0")]
		public static ReduceAction<ActionKind, CompressedPayload> LMABCSMPWRN(VLXCXCSSZAI actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x280F650", Offset = "0x280EA50", VA = "0x18280F650")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, RAGLFGQXJZI>> XTFHVVQTCSU(AUQKPBYPMDP a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x280F920", Offset = "0x280ED20", VA = "0x18280F920")]
		public static VLXCXCSSZAI DCFKJHKOADU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x280F9C0", Offset = "0x280EDC0", VA = "0x18280F9C0")]
		public static ReduceAction<ActionKind, DestroyPayload> LMABCSMPWRN(VLXCXCSSZAI actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x280FA30", Offset = "0x280EE30", VA = "0x18280FA30")]
		public static Result<None, UWIINLOGUJB> ZBFNJKJSRMY(AUQKPBYPMDP a, [In] DestroyPayload self)
		{
			return default(Result<None, UWIINLOGUJB>);
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
			public AsyncTaskMethodBuilder<Result<None, UWIINLOGUJB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public AUQKPBYPMDP root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, UWIINLOGUJB> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x28221A0", Offset = "0x28215A0", VA = "0x1828221A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2822740", Offset = "0x2821B40", VA = "0x182822740", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B6F5A0", Offset = "0x1B6E9A0", VA = "0x181B6F5A0")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x280FCD0", Offset = "0x280F0D0", VA = "0x18280FCD0")]
		public static VLXCXCSSZAI? DCFKJHKOADU(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x280FDD0", Offset = "0x280F1D0", VA = "0x18280FDD0")]
		public static ReduceAction<ActionKind, FullInitializePayload> LMABCSMPWRN(VLXCXCSSZAI actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x280FEE0", Offset = "0x280F2E0", VA = "0x18280FEE0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, UWIINLOGUJB>> XTFHVVQTCSU(AUQKPBYPMDP a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public AUQKPBYPMDP root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, RAGLFGQXJZI> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, XOJOHOBKPDS>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, XOJOHOBKPDS> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, XOJOHOBKPDS>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2821C50", Offset = "0x2821050", VA = "0x182821C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2822130", Offset = "0x2821530", VA = "0x182822130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<VLXCXCSSZAI> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
		private MultiPayload(IReadOnlyList<VLXCXCSSZAI> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2810F90", Offset = "0x2810390", VA = "0x182810F90")]
		public static VLXCXCSSZAI DCFKJHKOADU(IReadOnlyList<VLXCXCSSZAI> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2811050", Offset = "0x2810450", VA = "0x182811050")]
		public static ReduceAction<ActionKind, MultiPayload> LMABCSMPWRN(VLXCXCSSZAI actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x28110F0", Offset = "0x28104F0", VA = "0x1828110F0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, RAGLFGQXJZI>> XTFHVVQTCSU(AUQKPBYPMDP a, MultiPayload b)
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
		private sealed class ACTEAKJALWV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> ANACEJQULGR;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ACTEAKJALWV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x280D110", Offset = "0x280C510", VA = "0x18280D110")]
			internal VLXCXCSSZAI WUSCYGJXXAB(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x281C2B0", Offset = "0x281B6B0", VA = "0x18281C2B0")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x281BDC0", Offset = "0x281B1C0", VA = "0x18281BDC0")]
		public static VLXCXCSSZAI DCFKJHKOADU(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x281BED0", Offset = "0x281B2D0", VA = "0x18281BED0")]
		public static VLXCXCSSZAI[] FDBHDKECIRT(VLXCXCSSZAI a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x281BFD0", Offset = "0x281B3D0", VA = "0x18281BFD0")]
		public static ReduceAction<ActionKind, PartialActionPayload> LMABCSMPWRN(VLXCXCSSZAI actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x281C120", Offset = "0x281B520", VA = "0x18281C120")]
		public static Result<VLXCXCSSZAI, RAGLFGQXJZI> ZBFNJKJSRMY(AUQKPBYPMDP a, [In] PartialActionPayload self)
		{
			return default(Result<VLXCXCSSZAI, RAGLFGQXJZI>);
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
			public AsyncTaskMethodBuilder<Result<bool, UWIINLOGUJB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AUQKPBYPMDP root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, UWIINLOGUJB> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, UWIINLOGUJB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x28227B0", Offset = "0x2821BB0", VA = "0x1828227B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2822DF0", Offset = "0x28221F0", VA = "0x182822DF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1113E10", Offset = "0x1113210", VA = "0x181113E10")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x281C2D0", Offset = "0x281B6D0", VA = "0x18281C2D0")]
		public static VLXCXCSSZAI DCFKJHKOADU(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x281C490", Offset = "0x281B890", VA = "0x18281C490")]
		public static VLXCXCSSZAI?[]? TAVFTCCITVH(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x281C3B0", Offset = "0x281B7B0", VA = "0x18281C3B0")]
		public static ReduceAction<ActionKind, PartialInitializePayload> LMABCSMPWRN(VLXCXCSSZAI actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x281C680", Offset = "0x281BA80", VA = "0x18281C680")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, UWIINLOGUJB>> XTFHVVQTCSU(AUQKPBYPMDP a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UDBOMBDPSDP : DGORIRYPZWM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly AUQKPBYPMDP XBAZNGQYGJY;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public UYSKBWHFHBR? LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x28265B0", Offset = "0x28259B0", VA = "0x1828265B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		internal UDBOMBDPSDP(AUQKPBYPMDP a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class YWMJZOGYJLI : UYSKBWHFHBR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly AUQKPBYPMDP XBAZNGQYGJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly MCGUTYIFENK ALQLHMYZNSU;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		public YWMJZOGYJLI(AUQKPBYPMDP a, MCGUTYIFENK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x282C9E0", Offset = "0x282BDE0", VA = "0x18282C9E0", Slot = "4")]
		public Result<DebugExecutionResult, YDOJLCJITLX> EDYXQJNBLCU(Id128<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId, Id32<IFNWILEMGJH> inputId)
		{
			return default(Result<DebugExecutionResult, YDOJLCJITLX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x282CF90", Offset = "0x282C390", VA = "0x18282CF90", Slot = "5")]
		public Result<DebugExecutionResult, YDOJLCJITLX> VBWMOTBWNAL(Id128<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId, Id32<CSVKPDHJMYA> outputId)
		{
			return default(Result<DebugExecutionResult, YDOJLCJITLX>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class AYAZJFNSIFY : GNWDQRYJEFF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface ALXXNXZFOSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<LBNGUKJCJSD> HUXFUVOJXHQ(AUQKPBYPMDP a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class IXIUPKGVEEA : ALXXNXZFOSL
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
				public AsyncTaskMethodBuilder<LBNGUKJCJSD> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public AUQKPBYPMDP circuitsManager;

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
				private TaskAwaiter<HGEHYAJDPNG> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2820AC0", Offset = "0x281FEC0", VA = "0x182820AC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2820C90", Offset = "0x2820090", VA = "0x182820C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2810320", Offset = "0x280F720", VA = "0x182810320", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<LBNGUKJCJSD> HUXFUVOJXHQ(AUQKPBYPMDP a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
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
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			protected IXIUPKGVEEA()
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
			public AsyncTaskMethodBuilder<LBNGUKJCJSD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AYAZJFNSIFY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2820D00", Offset = "0x2820100", VA = "0x182820D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2820F00", Offset = "0x2820300", VA = "0x182820F00", Slot = "5")]
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
			public AYAZJFNSIFY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AUQKPBYPMDP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<LBNGUKJCJSD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2820F70", Offset = "0x2820370", VA = "0x182820F70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2821480", Offset = "0x2820880", VA = "0x182821480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ALXXNXZFOSL MKZWHJKZWXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> PFYHQJMNVMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> EQFPAJSWMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource BCOFGQIMPBD;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool PTDGGKWCEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F90", Offset = "0xAF9390", VA = "0x180AF9F90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAF9170", Offset = "0xAF8570", VA = "0x180AF9170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool FTNBLRPOGMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xC6AC80", Offset = "0xC6A080", VA = "0x180C6AC80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCA3E90", Offset = "0xCA3290", VA = "0x180CA3E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool ZPXUBQWEMEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x17EEB60", Offset = "0x17EDF60", VA = "0x1817EEB60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x17EEB70", Offset = "0x17EDF70", VA = "0x1817EEB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public LBNGUKJCJSD? LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x280E9D0", Offset = "0x280DDD0", VA = "0x18280E9D0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<LBNGUKJCJSD> JVDKCQIIKOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x280EC00", Offset = "0x280E000", VA = "0x18280EC00")]
		public AYAZJFNSIFY(ALXXNXZFOSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x280EAC0", Offset = "0x280DEC0", VA = "0x18280EAC0", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task MTRORTTHKXC(AUQKPBYPMDP a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x280E860", Offset = "0x280DC60", VA = "0x18280E860", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class RGEQYQEUNEP : WYQCXNYQERA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly ETIPBFENWNV LGWSJCDTGVU;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public RGEQYQEUNEP(ETIPBFENWNV a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class TBPGMUQKNUE
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class NVAIVHHTELU<a> : SMYDLSZQBNT where a : GVCZGRMKSXF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a RJWLASFRRRL;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? CLEEOPDCCSL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0xBF9F30", Offset = "0xBF9330", VA = "0x180BF9F30", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<FRZIQAPUPIV>? GUFAMSRLMNN
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x585BFF0", Offset = "0x585B3F0", VA = "0x18585BFF0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<HUXETNCTSFJ> IYXGXTJGXSL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x2AF4E10", Offset = "0x2AF4210", VA = "0x182AF4E10", Slot = "5")]
				get
				{
					return default(Id32<HUXETNCTSFJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<HUXETNCTSFJ>? MZXKBECDUXN
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x585BF70", Offset = "0x585B370", VA = "0x18585BF70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
			public NVAIVHHTELU(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class PNWFUCTQDWY : NVAIVHHTELU<XCGCACZVCXE>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? CLEEOPDCCSL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xD1CB00", Offset = "0xD1BF00", VA = "0x180D1CB00", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x281BCF0", Offset = "0x281B0F0", VA = "0x18281BCF0")]
			public PNWFUCTQDWY(XCGCACZVCXE a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x281EC10", Offset = "0x281E010", VA = "0x18281EC10")]
		public static SMYDLSZQBNT New(GVCZGRMKSXF graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class VOIRXGKTOAQ : TJAZIGGQZMH, KNHDWBMZHLX, GSJOVJNHIEE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class DMEHGYKWLLI
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
				public DMEHGYKWLLI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public WTTLBDSHSXM errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x2824530", Offset = "0x2823930", VA = "0x182824530", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x28247A0", Offset = "0x2823BA0", VA = "0x1828247A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public VOIRXGKTOAQ MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool VLFARCGJFNR;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public DMEHGYKWLLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x280F760", Offset = "0x280EB60", VA = "0x18280F760")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task HQQOKSCSQUG(WTTLBDSHSXM a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class UKCTNRDETIC
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
				public UKCTNRDETIC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x2824800", Offset = "0x2823C00", VA = "0x182824800", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x2824AE0", Offset = "0x2823EE0", VA = "0x182824AE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public VOIRXGKTOAQ MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int VLFARCGJFNR;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UKCTNRDETIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x28266C0", Offset = "0x2825AC0", VA = "0x1828266C0")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task AWWRGGWVSWU(WTTLBDSHSXM a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class ZDJLHJLETPN
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
				public ZDJLHJLETPN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x2825050", Offset = "0x2824450", VA = "0x182825050", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x2825500", Offset = "0x2824900", VA = "0x182825500", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string VLFARCGJFNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public VOIRXGKTOAQ MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int TUDOIBVOMGZ;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ZDJLHJLETPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x282D540", Offset = "0x282C940", VA = "0x18282D540")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task ZGXPORZJGWS(WTTLBDSHSXM a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class DWVHNOCSZOE
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
				public DWVHNOCSZOE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x2824B40", Offset = "0x2823F40", VA = "0x182824B40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x2824FF0", Offset = "0x28243F0", VA = "0x182824FF0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string VLFARCGJFNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public VOIRXGKTOAQ MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int TUDOIBVOMGZ;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public DWVHNOCSZOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x280F850", Offset = "0x280EC50", VA = "0x18280F850")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task YSZFEMDVNKO(WTTLBDSHSXM a)
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
			public VOIRXGKTOAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x28233A0", Offset = "0x28227A0", VA = "0x1828233A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x28238A0", Offset = "0x2822CA0", VA = "0x1828238A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NDPFPWUWSWZ GUHAPNKOYDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<RJEVJCHYTXL> ZOPLLAFAWZQ;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private PHMKKHZLINW IXIUPKGVEEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x282C230", Offset = "0x282B630", VA = "0x18282C230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<IFNWILEMGJH> OWRQCYZPDJS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB0E8C0", Offset = "0xB0DCC0", VA = "0x180B0E8C0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<IFNWILEMGJH>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xBF0970", Offset = "0xBEFD70", VA = "0x180BF0970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<KRQTPWZEGQG> LMJONQNJJYA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x27A9090", Offset = "0x27A8490", VA = "0x1827A9090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<AINMIFOSACL> YZTOZCZSSNX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xF76410", Offset = "0xF75810", VA = "0x180F76410", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<AINMIFOSACL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<KRAHEPMHAQK> ZBEYMOAJLJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x282B340", Offset = "0x282A740", VA = "0x18282B340", Slot = "22")]
			get
			{
				return default(Id32<KRAHEPMHAQK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool OJFQDMFPVKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2829AC0", Offset = "0x2828EC0", VA = "0x182829AC0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x282C250", Offset = "0x282B650", VA = "0x18282C250")]
		private VOIRXGKTOAQ(AUQKPBYPMDP a, CFDTQFFCTZU b, NDPFPWUWSWZ c, Id32<RWZXBCGZCJT> portGroupId, Id32<IFNWILEMGJH> inputId, Id32<KRQTPWZEGQG> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x282AF90", Offset = "0x282A390", VA = "0x18282AF90")]
		public static VOIRXGKTOAQ New(AUQKPBYPMDP circuitsManager, CFDTQFFCTZU node, NDPFPWUWSWZ input, Id32<RWZXBCGZCJT> portGroupId, Id32<KRQTPWZEGQG> inputDefId, Id32<IFNWILEMGJH> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x282A4B0", Offset = "0x28298B0", VA = "0x18282A4B0", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2829A20", Offset = "0x2828E20", VA = "0x182829A20", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x282C1D0", Offset = "0x282B5D0", VA = "0x18282C1D0", Slot = "32")]
		public void YTVXNXXZUGD(RJEVJCHYTXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x282B390", Offset = "0x282A790", VA = "0x18282B390", Slot = "29")]
		public void QJYXFNJRTQY(RWNGZCYWDBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2828680", Offset = "0x2827A80", VA = "0x182828680", Slot = "30")]
		public void BNQKRUOMWXZ(WAWKRLIVCJH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2829FC0", Offset = "0x28293C0", VA = "0x182829FC0", Slot = "25")]
		protected override void FGNIGDQSKZJ(FANNPLWXHAQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x282AE20", Offset = "0x282A220", VA = "0x18282AE20", Slot = "34")]
		public string NUZRXGZHEJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2829D00", Offset = "0x2829100", VA = "0x182829D00", Slot = "31")]
		public string EPYNKXXGWEI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x282A7D0", Offset = "0x2829BD0", VA = "0x18282A7D0")]
		private void MSFAPJXZBQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x282A710", Offset = "0x2829B10", VA = "0x18282A710", Slot = "33")]
		public void LWYCAYMTFRQ(RJEVJCHYTXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x282A550", Offset = "0x2829950", VA = "0x18282A550")]
		private void JLNUOVHSNIH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x282B750", Offset = "0x282AB50", VA = "0x18282B750", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task UIWOMTBUMNZ(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2828530", Offset = "0x2827930", VA = "0x182828530")]
		public void AKPEDNQSGDE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x282B930", Offset = "0x282AD30", VA = "0x18282B930")]
		private void WJWDUMWSRIQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2829B40", Offset = "0x2828F40", VA = "0x182829B40")]
		private void EEMAXCOTUES(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x282BAD0", Offset = "0x282AED0", VA = "0x18282BAD0")]
		private void XFNOJCEELIR(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x28283F0", Offset = "0x28277F0", VA = "0x1828283F0")]
		private string AHSANTMDDIK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x282BC90", Offset = "0x282B090", VA = "0x18282BC90")]
		private string YHLVKQIEAGP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xBF0970", Offset = "0xBEFD70", VA = "0x180BF0970")]
		internal void SZIIPFDIJKA(Id32<IFNWILEMGJH> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x282BEC0", Offset = "0x282B2C0", VA = "0x18282BEC0")]
		[CompilerGenerated]
		private void YMRDLEBTLTR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x282BE00", Offset = "0x282B200", VA = "0x18282BE00")]
		[CompilerGenerated]
		private bool YMLWNXHWCII()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x282BED0", Offset = "0x282B2D0", VA = "0x18282BED0")]
		[CompilerGenerated]
		private bool YMWKIKVQVFA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x282A9F0", Offset = "0x2829DF0", VA = "0x18282A9F0")]
		[CompilerGenerated]
		private int YNMFAFDIXNB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x282BF90", Offset = "0x282B390", VA = "0x18282BF90")]
		[CompilerGenerated]
		private bool YNGYCYJLOBS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x282C0E0", Offset = "0x282B4E0", VA = "0x18282C0E0")]
		[CompilerGenerated]
		private void YNWSUSRDQJT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x282C020", Offset = "0x282B420", VA = "0x18282C020")]
		[CompilerGenerated]
		private bool YNRLXLXGGYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x282C180", Offset = "0x282B580", VA = "0x18282C180")]
		[CompilerGenerated]
		private bool YOHGPGEYJGL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x282C0F0", Offset = "0x282B4F0", VA = "0x18282C0F0")]
		[CompilerGenerated]
		private bool YOBZRZLAZVC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x282A9F0", Offset = "0x2829DF0", VA = "0x18282A9F0")]
		[CompilerGenerated]
		private int NPXNPDHAGMQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x282AA40", Offset = "0x2829E40", VA = "0x18282AA40")]
		[CompilerGenerated]
		private bool NQCUMKAXPXZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x282AB10", Offset = "0x2829F10", VA = "0x18282AB10")]
		[CompilerGenerated]
		private object NQIBJQUUZJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28299D0", Offset = "0x2828DD0", VA = "0x1828299D0")]
		[CompilerGenerated]
		private void NQNIGXOSIUR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x282AB70", Offset = "0x2829F70", VA = "0x18282AB70")]
		[CompilerGenerated]
		private bool NQXWBLCNBRJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x282AC40", Offset = "0x282A040", VA = "0x18282AC40")]
		[CompilerGenerated]
		private string NRDCYRWKLCS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x282ACC0", Offset = "0x282A0C0", VA = "0x18282ACC0")]
		[CompilerGenerated]
		private void NRIJVYQHUOB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x282ACD0", Offset = "0x282A0D0", VA = "0x18282ACD0")]
		[CompilerGenerated]
		private bool NRNQTFKFDZK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x282ADA0", Offset = "0x282A1A0", VA = "0x18282ADA0")]
		[CompilerGenerated]
		private string NRSXQMECNKT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x282A1F0", Offset = "0x28295F0", VA = "0x18282A1F0")]
		[CompilerGenerated]
		private void HRZDXYGHPTJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x282A120", Offset = "0x2829520", VA = "0x18282A120")]
		[CompilerGenerated]
		private bool HRTXARMKGIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x282A210", Offset = "0x2829610", VA = "0x18282A210")]
		[CompilerGenerated]
		private string HSJRSLUCIQB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x282A200", Offset = "0x2829600", VA = "0x18282A200")]
		[CompilerGenerated]
		private void HSEKVFAEZES(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x282A300", Offset = "0x2829700", VA = "0x18282A300")]
		[CompilerGenerated]
		private bool HSUFMZHXBMT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x282A290", Offset = "0x2829690", VA = "0x18282A290")]
		[CompilerGenerated]
		private string HSOYPSNZSBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x282A4A0", Offset = "0x28298A0", VA = "0x18282A4A0")]
		[CompilerGenerated]
		private void HTETHMVRUJL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x282A3D0", Offset = "0x28297D0", VA = "0x18282A3D0")]
		[CompilerGenerated]
		private bool HSZMKGBUKYC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x282A0B0", Offset = "0x28294B0", VA = "0x18282A0B0")]
		[CompilerGenerated]
		private string HQJATWDCSGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x282A0A0", Offset = "0x28294A0", VA = "0x18282A0A0")]
		[CompilerGenerated]
		private void HQDTWPJFIVG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2829890", Offset = "0x2828C90", VA = "0x182829890")]
		[CompilerGenerated]
		private bool BRFXMNXFLXI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2829960", Offset = "0x2828D60", VA = "0x182829960")]
		[CompilerGenerated]
		private string BRLEJURCVIR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28297B0", Offset = "0x2828BB0", VA = "0x1828297B0")]
		[CompilerGenerated]
		private void BQVJSAJKTAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28297C0", Offset = "0x2828BC0", VA = "0x1828297C0")]
		[CompilerGenerated]
		private bool BRAQPHDICLZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2829730", Offset = "0x2828B30", VA = "0x182829730")]
		[CompilerGenerated]
		private string BQKVXMVQADY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28297A0", Offset = "0x2828BA0", VA = "0x1828297A0")]
		[CompilerGenerated]
		private void BQQCUTPNJPH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2829600", Offset = "0x2828A00", VA = "0x182829600")]
		[CompilerGenerated]
		private bool BQAICZHVHHG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28296D0", Offset = "0x2828AD0", VA = "0x1828296D0")]
		[CompilerGenerated]
		private object BQFPAGBSQSP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28299D0", Offset = "0x2828DD0", VA = "0x1828299D0")]
		[CompilerGenerated]
		private void BSWAQQAKJKC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x282B860", Offset = "0x282AC60", VA = "0x18282B860")]
		[CompilerGenerated]
		private bool VTHNVIWMVEB()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class ZIKPQDOHGSG
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class LAIZLWAXTDQ : NWBVHBZMQLQ<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public LAIZLWAXTDQ MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x281E200", Offset = "0x281D600", VA = "0x18281E200")]
				internal object YKZCBYLTSVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x281E630", Offset = "0x281DA30", VA = "0x18281E630")]
				internal void YLEIZFFRCGT(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2810960", Offset = "0x280FD60", VA = "0x182810960")]
			public LAIZLWAXTDQ(AUQKPBYPMDP a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x28106F0", Offset = "0x280FAF0", VA = "0x1828106F0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class OYCYAGOCZET : UUKNZKPGMLL<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType EDAUFZUQIPI
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x281BC90", Offset = "0x281B090", VA = "0x18281BC90")]
			public OYCYAGOCZET(AUQKPBYPMDP a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class VAVULCMRKKD : NWBVHBZMQLQ<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2827C10", Offset = "0x2827010", VA = "0x182827C10")]
			public VAVULCMRKKD(AUQKPBYPMDP a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2827AB0", Offset = "0x2826EB0", VA = "0x182827AB0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2827930", Offset = "0x2826D30", VA = "0x182827930")]
			[CompilerGenerated]
			private bool MJGWPBMGGZO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2827980", Offset = "0x2826D80", VA = "0x182827980")]
			[CompilerGenerated]
			private void MJMDMIGDQKX(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class UZPHNNEJBQD : NWBVHBZMQLQ<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public UZPHNNEJBQD MXVWDMPVVWS;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x281E1B0", Offset = "0x281D5B0", VA = "0x18281E1B0")]
				internal void YKZCBYLTSVK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x281E260", Offset = "0x281D660", VA = "0x18281E260")]
				internal bool YLEIZFFRCGT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x281E890", Offset = "0x281DC90", VA = "0x18281E890")]
				internal bool YLJPWLZOLSC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x281E930", Offset = "0x281DD30", VA = "0x18281E930")]
				internal void YLOWTSTLVDL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x281DE20", Offset = "0x281D220", VA = "0x18281DE20")]
				internal bool YKEAMXKEHCA()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x28276E0", Offset = "0x2826AE0", VA = "0x1828276E0")]
			public UZPHNNEJBQD(AUQKPBYPMDP a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x28273D0", Offset = "0x28267D0", VA = "0x1828273D0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class VCFEODUIXKL : NWBVHBZMQLQ<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public VCFEODUIXKL MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> GSJXVHYZMYK;

				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0x281E070", Offset = "0x281D470", VA = "0x18281E070")]
				internal object? YKZCBYLTSVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0x281DFF0", Offset = "0x281D3F0", VA = "0x18281DFF0")]
				internal bool YKTVERRWJKB(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x281E3E0", Offset = "0x281D7E0", VA = "0x18281E3E0")]
				internal void YLEIZFFRCGT(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x281E700", Offset = "0x281DB00", VA = "0x18281E700")]
				internal string YLJPWLZOLSC(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x281E8E0", Offset = "0x281DCE0", VA = "0x18281E8E0")]
				internal IReadOnlyList<object> YLOWTSTLVDL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x281DDB0", Offset = "0x281D1B0", VA = "0x18281DDB0")]
				internal bool YKEAMXKEHCA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x281DE70", Offset = "0x281D270", VA = "0x18281DE70")]
				internal bool YKJHKEEBQNJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x281DEC0", Offset = "0x281D2C0", VA = "0x18281DEC0")]
				internal void YKOOHKXYZYS(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2828380", Offset = "0x2827780", VA = "0x182828380")]
			public VCFEODUIXKL(AUQKPBYPMDP a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2827C80", Offset = "0x2827080", VA = "0x182827C80", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class HJYJGNMXCDU : NWBVHBZMQLQ<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public HJYJGNMXCDU MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(RVA = "0x281E160", Offset = "0x281D560", VA = "0x18281E160")]
				internal bool YKZCBYLTSVK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x281E2B0", Offset = "0x281D6B0", VA = "0x18281E2B0")]
				internal void YLEIZFFRCGT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x281E840", Offset = "0x281DC40", VA = "0x18281E840")]
				internal bool YLJPWLZOLSC()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2810230", Offset = "0x280F630", VA = "0x182810230")]
			public HJYJGNMXCDU(AUQKPBYPMDP a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2810020", Offset = "0x280F420", VA = "0x182810020", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class QVCXXCOBOJV : NWBVHBZMQLQ<GZTVXYBJHYE>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class MWLHREALRTF
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
					public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public MWLHREALRTF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<OCNIJHVCKJR>, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x2823CE0", Offset = "0x28230E0", VA = "0x182823CE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0x28240C0", Offset = "0x28234C0", VA = "0x1828240C0", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public MWLHREALRTF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x2824130", Offset = "0x2823530", VA = "0x182824130", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x28244C0", Offset = "0x28238C0", VA = "0x1828244C0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task XTHUHXRMJLL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string TKEGCUZYKRZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public THQFFICRKST.TROCYAGKOOZ ZHXZARJMRYK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool KEKJYFYBXFY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public QVCXXCOBOJV MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public THQFFICRKST ZNMMCDBHZDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action KMLJCGXKIVO;

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public MWLHREALRTF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x2810F60", Offset = "0x2810360", VA = "0x182810F60")]
				internal bool YBUQMTNLUEC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
				internal string DLUXJVLGVPR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2810A50", Offset = "0x280FE50", VA = "0x182810A50")]
				internal void DMAEHCFEFBA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x2810AD0", Offset = "0x280FED0", VA = "0x182810AD0")]
				internal void DMFLEIZBOMJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x12D83D0", Offset = "0x12D77D0", VA = "0x1812D83D0")]
				internal bool DMKSBPSYXXS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2810B20", Offset = "0x280FF20", VA = "0x182810B20")]
				internal void DMPYYWMWHJB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x2810D40", Offset = "0x2810140", VA = "0x182810D40")]
				internal bool DMVFWDGTQUK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2810E70", Offset = "0x2810270", VA = "0x182810E70")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, RAGLFGQXJZI>> WNDAEERBAOU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x2810D80", Offset = "0x2810180", VA = "0x182810D80")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, RAGLFGQXJZI>> WFPSSKHNYSV()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class UMOAHPPLSQX
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
					public AsyncTaskMethodBuilder<Result<Id32<OCNIJHVCKJR>, RAGLFGQXJZI>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<OCNIJHVCKJR>, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0x2823900", Offset = "0x2822D00", VA = "0x182823900", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0x2823C70", Offset = "0x2823070", VA = "0x182823C70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public QVCXXCOBOJV MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public RWPWJSQETXX UIBXSNZJKCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool CTYGBPDSVOU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public THQFFICRKST ZNMMCDBHZDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public MWWWSQOARST XTODSOJQBFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action GSZSNCGRPGL;

				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UMOAHPPLSQX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0x2826C10", Offset = "0x2826010", VA = "0x182826C10")]
				internal object? YLEIZFFRCGT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0x2826C80", Offset = "0x2826080", VA = "0x182826C80")]
				internal void YLJPWLZOLSC(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2826D70", Offset = "0x2826170", VA = "0x182826D70")]
				internal string YLOWTSTLVDL(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x28268E0", Offset = "0x2825CE0", VA = "0x1828268E0")]
				internal IReadOnlyList<object> YKEAMXKEHCA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2826980", Offset = "0x2825D80", VA = "0x182826980")]
				internal void YKJHKEEBQNJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2826AE0", Offset = "0x2825EE0", VA = "0x182826AE0")]
				internal bool YKOOHKXYZYS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x2826B50", Offset = "0x2825F50", VA = "0x182826B50")]
				internal void YKTVERRWJKB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2826E60", Offset = "0x2826260", VA = "0x182826E60")]
				internal void YMPFGAOYQIE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2826EB0", Offset = "0x28262B0", VA = "0x182826EB0")]
				internal void YMUMDHIVZTN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2826880", Offset = "0x2825C80", VA = "0x182826880")]
				internal bool PXDWTNUSYJT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2826790", Offset = "0x2825B90", VA = "0x182826790")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<OCNIJHVCKJR>, RAGLFGQXJZI>> EIWNYEVZJIV()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<HUXETNCTSFJ>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x281D820", Offset = "0x281CC20", VA = "0x18281D820", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool JZQXASCFDXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x281D7B0", Offset = "0x281CBB0", VA = "0x18281D7B0")]
			public QVCXXCOBOJV(AUQKPBYPMDP a, GZTVXYBJHYE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x281CE30", Offset = "0x281C230", VA = "0x18281CE30", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x281C7B0", Offset = "0x281BBB0", VA = "0x18281C7B0")]
			private void LETXLJMSIBA(THQFFICRKST a, Id32<OCNIJHVCKJR>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class WYFCWODHULA : DAZJVKPPUTH<WNIWCYSULYT>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0x1B89620", Offset = "0x1B88A20", VA = "0x181B89620", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool WGITTWITMCV
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool FCWCPEWWNEE
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool GCTKTBGZSMF
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool JZQXASCFDXE
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x282C700", Offset = "0x282BB00", VA = "0x18282C700")]
			public WYFCWODHULA(AUQKPBYPMDP a, WNIWCYSULYT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class IRRMIJNVRYU<a> : NWBVHBZMQLQ<a> where a : notnull, QZCZDJSOVWU
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
				public AsyncTaskMethodBuilder<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public IRRMIJNVRYU<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x4E46F40", Offset = "0x4E46340", VA = "0x184E46F40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0x4E47290", Offset = "0x4E46690", VA = "0x184E47290", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public IRRMIJNVRYU<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<RWZXBCGZCJT> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x5178270", Offset = "0x5177670", VA = "0x185178270", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x51785C0", Offset = "0x51779C0", VA = "0x1851785C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<RWZXBCGZCJT>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0x5026A60", Offset = "0x5025E60", VA = "0x185026A60", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5026A30", Offset = "0x5025E30", VA = "0x185026A30")]
			protected IRRMIJNVRYU(AUQKPBYPMDP a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x5026790", Offset = "0x5025B90", VA = "0x185026790", Slot = "122")]
			[AsyncStateMachine(typeof(IRRMIJNVRYU<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> LUQAFUENQIJ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x50268B0", Offset = "0x5025CB0", VA = "0x1850268B0", Slot = "149")]
			public sealed override bool OSAKSEJBKOI(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x50266D0", Offset = "0x5025AD0", VA = "0x1850266D0", Slot = "134")]
			protected sealed override bool IAAYWVGSBMO(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x5026970", Offset = "0x5025D70", VA = "0x185026970", Slot = "135")]
			protected override bool ZSABMOVERGV(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x50265C0", Offset = "0x50259C0", VA = "0x1850265C0", Slot = "123")]
			[AsyncStateMachine(typeof(IRRMIJNVRYU<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, RAGLFGQXJZI>> CJVEPGNCOHO(Id32<RWZXBCGZCJT> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class RFVABKWGDBH : MIRWKZWWRTI<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public RFVABKWGDBH MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x281DCB0", Offset = "0x281D0B0", VA = "0x18281DCB0")]
				internal bool LZLUEZDNBTL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0x281DB60", Offset = "0x281CF60", VA = "0x18281DB60")]
				internal void LZGNHSJPSIC(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x281DAA0", Offset = "0x281CEA0", VA = "0x18281DAA0")]
			public RFVABKWGDBH(AUQKPBYPMDP a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x281D860", Offset = "0x281CC60", VA = "0x18281D860", Slot = "151")]
			protected override void MKVXEIQGUZT(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class CJIAITAJRSS : NWBVHBZMQLQ<VZSIKQCOLBV>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class OBPSGXVZRRC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int VMKZIJTAXIZ;

				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public OBPSGXVZRRC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x28112B0", Offset = "0x28106B0", VA = "0x1828112B0")]
				internal bool MBSVJMHZNWN(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class AZSYQXSOVDR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public CJIAITAJRSS MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> BUVFJZUSZRH;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public AZSYQXSOVDR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x280ED00", Offset = "0x280E100", VA = "0x18280ED00")]
				internal int YKZCBYLTSVK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x280EDA0", Offset = "0x280E1A0", VA = "0x18280EDA0")]
				internal void YLEIZFFRCGT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x280EEC0", Offset = "0x280E2C0", VA = "0x18280EEC0")]
				internal string? YLJPWLZOLSC()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x280F470", Offset = "0x280E870", VA = "0x18280F470")]
			public CJIAITAJRSS(AUQKPBYPMDP a, VZSIKQCOLBV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x280F090", Offset = "0x280E490", VA = "0x18280F090")]
			private int DXPYYYPCRWZ(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x280EF70", Offset = "0x280E370", VA = "0x18280EF70")]
			private void ADXPRJGXPSV(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x280F120", Offset = "0x280E520", VA = "0x18280F120", Slot = "145")]
			protected sealed override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class KSMQQUXLSOK : DAZJVKPPUTH<SEGYJATBYYX>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x2810690", Offset = "0x280FA90", VA = "0x182810690")]
			public KSMQQUXLSOK(AUQKPBYPMDP a, SEGYJATBYYX b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class DAZJVKPPUTH<a> : NWBVHBZMQLQ<a> where a : notnull, QSFKEYADZPB
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class TTSQZNKXNAF
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
					public TTSQZNKXNAF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0x3CB5AB0", Offset = "0x3CB4EB0", VA = "0x183CB5AB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public THQFFICRKST ZNMMCDBHZDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public DAZJVKPPUTH<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action GSPESOSWWJT;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public TTSQZNKXNAF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5F086D0", Offset = "0x5F07AD0", VA = "0x185F086D0")]
				internal void YKZCBYLTSVK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x5F08630", Offset = "0x5F07A30", VA = "0x185F08630")]
				[AsyncStateMachine(typeof(DAZJVKPPUTH<>.TTSQZNKXNAF.<<BuildConfigMenuInternal>b__6>d))]
				internal void YKOOHKXYZYS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x5F08990", Offset = "0x5F07D90", VA = "0x185F08990")]
				internal bool YLEIZFFRCGT()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class TTNKCGRADOW
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
					public TTNKCGRADOW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x3CB52E0", Offset = "0x3CB46E0", VA = "0x183CB52E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string LMDFOVEJMZR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public TTSQZNKXNAF AAFJFKGKTGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> GROWGGXKBFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> GSEQYBFCDNB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action GRZKAULEUBS;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public TTNKCGRADOW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5F08270", Offset = "0x5F07670", VA = "0x185F08270")]
				internal void YLJPWLZOLSC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				internal string YLOWTSTLVDL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
				internal void YKEAMXKEHCA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x5F081D0", Offset = "0x5F075D0", VA = "0x185F081D0")]
				[AsyncStateMachine(typeof(DAZJVKPPUTH<>.TTNKCGRADOW.<<BuildConfigMenuInternal>b__5>d))]
				internal void YKJHKEEBQNJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class HSPFGAXWSUM
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
					public HSPFGAXWSUM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<GLLQVRJNTAT>, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0x3CB2A30", Offset = "0x3CB1E30", VA = "0x183CB2A30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public HSPFGAXWSUM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x3CB3170", Offset = "0x3CB2570", VA = "0x183CB3170", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public HSPFGAXWSUM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<KRQTPWZEGQG>, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x3CB3350", Offset = "0x3CB2750", VA = "0x183CB3350", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public DAZJVKPPUTH<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<RWZXBCGZCJT> OQKYHSYTTKF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public THQFFICRKST ZNMMCDBHZDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public ZIUCYVLLCOL WYCEIVQOYRS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int WVVYZECGFOT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int PGPQCTSLGKF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public CAMZTXWHAYG QWXDMAOAGOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string GTUKTEBIJSW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<OHCPENJXYFI> CPHZSYRXGJZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public CAMZTXWHAYG VLVXRQWUKIS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string RFYZCUANTQL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<OHCPENJXYFI> NDIVLIJZPSE;

				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public HSPFGAXWSUM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A6E0", Offset = "0x4F49AE0", VA = "0x184F4A6E0")]
				internal bool RJQHSTUHHLZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A670", Offset = "0x4F49A70", VA = "0x184F4A670")]
				internal void RJLAVNAJYAQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x4F4AD50", Offset = "0x4F4A150", VA = "0x184F4AD50")]
				internal bool WYEQERJWFDP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A790", Offset = "0x4F49B90", VA = "0x184F4A790")]
				[AsyncStateMachine(typeof(DAZJVKPPUTH<>.HSPFGAXWSUM.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void RKAVNHICAIR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A750", Offset = "0x4F49B50", VA = "0x184F4A750")]
				internal bool RJVOQAOEQXI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x4F4AD90", Offset = "0x4F4A190", VA = "0x184F4AD90")]
				internal void WYZRTSLLQWZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x4F4AAC0", Offset = "0x4F49EC0", VA = "0x184F4AAC0")]
				internal bool WVYSIUYZFIU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x4F4AB70", Offset = "0x4F49F70", VA = "0x184F4AB70")]
				internal void WWDZGBSWOUD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x4F4AA10", Offset = "0x4F49E10", VA = "0x184F4AA10")]
				internal bool RTBXSRNSHZN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A8A0", Offset = "0x4F49CA0", VA = "0x184F4A8A0")]
				internal bool RKLJHUVWTFJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A830", Offset = "0x4F49C30", VA = "0x184F4A830")]
				internal void RKGCKOBZJUA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A970", Offset = "0x4F49D70", VA = "0x184F4A970")]
				[AsyncStateMachine(typeof(DAZJVKPPUTH<>.HSPFGAXWSUM.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void RKVXCIJRMCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A910", Offset = "0x4F49D10", VA = "0x184F4A910")]
				internal bool RKQQFBPUCQS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A600", Offset = "0x4F49A00", VA = "0x184F4A600")]
				internal bool RIAEORRCJZF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x4F4A590", Offset = "0x4F49990", VA = "0x184F4A590")]
				internal void RHUXRKXFANW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x4F4AC50", Offset = "0x4F4A050", VA = "0x184F4AC50")]
				[AsyncStateMachine(typeof(DAZJVKPPUTH<>.HSPFGAXWSUM.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void WXOVMXCECVO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x4F4ACF0", Offset = "0x4F4A0F0", VA = "0x184F4ACF0")]
				internal bool WXUCKDWBMGX()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class HSUMDHRUCFV
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
					public HSUMDHRUCFV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x3CB2D20", Offset = "0x3CB2120", VA = "0x183CB2D20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string VMNILLOITNN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public HSPFGAXWSUM AAFJFKGKTGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> HNKAQGMKCKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> HNPHNNGHLVJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action HNUOKUAEVGS;

				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public HSUMDHRUCFV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(RVA = "0x4F4AE70", Offset = "0x4F4A270", VA = "0x184F4AE70")]
				internal void WXZJHKPYVSG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				internal string WYJXBYDTOOY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
				internal void WYPDZEXQYAH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x4F4B1D0", Offset = "0x4F4A5D0", VA = "0x184F4B1D0")]
				[AsyncStateMachine(typeof(DAZJVKPPUTH<>.HSUMDHRUCFV.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void WYUKWLROHLQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class UXEYGJHFMGD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool CPHZSYRXGJZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public ZIUCYVLLCOL WYCEIVQOYRS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<OHCPENJXYFI> ETCCWYQLZTE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public DAZJVKPPUTH<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<RWZXBCGZCJT> OQKYHSYTTKF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int PRQIAVXDAPS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> GREILTJPIII;

				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UXEYGJHFMGD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0x614C350", Offset = "0x614B750", VA = "0x18614C350")]
				internal bool VBZUQHGCYUB()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class UWZRJCNICUU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public GSJOVJNHIEE XYPCGXYNQTD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public UXEYGJHFMGD AAFJFKGKTGT;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UWZRJCNICUU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x614BE50", Offset = "0x614B250", VA = "0x18614BE50")]
				internal void VBJZYMYKWMA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0x614BFC0", Offset = "0x614B3C0", VA = "0x18614BFC0")]
				internal bool VBPGVTSIFXJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x614C010", Offset = "0x614B410", VA = "0x18614C010")]
				internal void VCPPIBNVBCC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x614C1A0", Offset = "0x614B5A0", VA = "0x18614C1A0")]
				internal bool VCUWFIHSKNL()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class UXPMAWVAFCV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public OHCPENJXYFI QSFWSJONBVF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public UWZRJCNICUU AAKQCRAICSC;

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UXPMAWVAFCV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x614C3B0", Offset = "0x614B7B0", VA = "0x18614C3B0")]
				internal void VBUNTAMFPIS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class NIUIYVRLMAK
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
					public NIUIYVRLMAK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0x3CB6CE0", Offset = "0x3CB60E0", VA = "0x183CB6CE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> YVZCIHYIRWL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public CAMZTXWHAYG LTJMTXCMYCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool CPHZSYRXGJZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public ZIUCYVLLCOL WYCEIVQOYRS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public GSJOVJNHIEE XYPCGXYNQTD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string VMNILLOITNN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public NIUIYVRLMAK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x584EFF0", Offset = "0x584E3F0", VA = "0x18584EFF0")]
				internal int EPKRGLLYNXK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x584F030", Offset = "0x584E430", VA = "0x18584F030")]
				internal void EPPYDSFVXIT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
				internal string EPVFAYZTGUC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x584F280", Offset = "0x584E680", VA = "0x18584F280")]
				[AsyncStateMachine(typeof(DAZJVKPPUTH<>.NIUIYVRLMAK.<<CreatePortItemV2>b__3>d))]
				internal void EQALYFTQQFL(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public DAZJVKPPUTH<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x4E46B20", Offset = "0x4E45F20", VA = "0x184E46B20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x4E46ED0", Offset = "0x4E462D0", VA = "0x184E46ED0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public DAZJVKPPUTH<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<RWZXBCGZCJT> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x5178630", Offset = "0x5177A30", VA = "0x185178630", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x5178960", Offset = "0x5177D60", VA = "0x185178960", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public DAZJVKPPUTH<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x517DF90", Offset = "0x517D390", VA = "0x18517DF90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x517E530", Offset = "0x517D930", VA = "0x18517E530", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<RWZXBCGZCJT>, bool> EEZWXNVRADH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<RWZXBCGZCJT>, bool> HWCAFIDWLQP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<RWZXBCGZCJT>, bool> GFOAMQXCGOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<RWZXBCGZCJT>, bool> PORDVUSOWDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<RWZXBCGZCJT>, bool> NWJMFANZSMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<RWZXBCGZCJT>, bool> JJRHHMYZZTY;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool WGITTWITMCV
			{
				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool FCWCPEWWNEE
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool GCTKTBGZSMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<HUXETNCTSFJ>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x413A640", Offset = "0x4139A40", VA = "0x18413A640", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<RWZXBCGZCJT>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x413A8A0", Offset = "0x4139CA0", VA = "0x18413A8A0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<FRZIQAPUPIV>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x413A6C0", Offset = "0x4139AC0", VA = "0x18413A6C0", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x413A470", Offset = "0x4139870", VA = "0x18413A470")]
			public DAZJVKPPUTH(AUQKPBYPMDP a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "154")]
			protected virtual bool GRPNUZMNSFW(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "155")]
			protected virtual bool ONGHVKAMSYH(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "156")]
			protected virtual bool VASEEUYYRJM(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "157")]
			protected virtual void YGQEXJNKEKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x41389D0", Offset = "0x4137DD0", VA = "0x1841389D0", Slot = "149")]
			public override bool OSAKSEJBKOI(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x41388B0", Offset = "0x4137CB0", VA = "0x1841388B0", Slot = "122")]
			[AsyncStateMachine(typeof(DAZJVKPPUTH<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> LUQAFUENQIJ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4137460", Offset = "0x4136860", VA = "0x184137460", Slot = "123")]
			[AsyncStateMachine(typeof(DAZJVKPPUTH<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, RAGLFGQXJZI>> CJVEPGNCOHO(Id32<RWZXBCGZCJT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x41398D0", Offset = "0x4138CD0", VA = "0x1841398D0", Slot = "124")]
			public override void WQJXDSDXUKI(Id32<RWZXBCGZCJT> index, Id32<RWZXBCGZCJT> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4139400", Offset = "0x4138800", VA = "0x184139400", Slot = "125")]
			public override IEnumerable<VLXCXCSSZAI> QJOQQAFFWHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4137570", Offset = "0x4136970", VA = "0x184137570")]
			[AsyncStateMachine(typeof(DAZJVKPPUTH<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, RAGLFGQXJZI>> DIBPNSKIZCG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "158")]
			protected virtual bool BOYHYLUIYPF(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "159")]
			protected virtual bool GURFJOMDZSP(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "160")]
			protected virtual bool DQIVYYLBGBM(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "161")]
			protected virtual bool ZCMPPTGHNMU(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "162")]
			protected virtual bool MQJNBEJPCRE(Id32<RWZXBCGZCJT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "163")]
			protected virtual bool UBIGQXTINRV(Id32<RWZXBCGZCJT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "164")]
			protected virtual bool QCJZHBEYXVP(Id32<RWZXBCGZCJT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "165")]
			protected virtual bool HSYLJLIYJOK(Id32<RWZXBCGZCJT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "166")]
			protected virtual bool HCNROWPVBUC(Id32<RWZXBCGZCJT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "167")]
			protected virtual bool PGZGEAFFFPT(Id32<RWZXBCGZCJT> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4139640", Offset = "0x4138A40", VA = "0x184139640", Slot = "168")]
			protected virtual List<CAMZTXWHAYG> SQKGGLRPQQZ(Id32<RWZXBCGZCJT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "169")]
			protected virtual void ZNBBEZJLADU(THQFFICRKST a, PPQWGBSFXBL b, ZIUCYVLLCOL c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4139A70", Offset = "0x4138E70", VA = "0x184139A70", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x4135B10", Offset = "0x4134F10", VA = "0x184135B10")]
			private PPQWGBSFXBL BPVRTXBGSXB(THQFFICRKST a, ZIUCYVLLCOL b, Id32<RWZXBCGZCJT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4137670", Offset = "0x4136A70", VA = "0x184137670")]
			private List<OHCPENJXYFI> KYCGTZAOJIQ(THQFFICRKST a, ZIUCYVLLCOL b, PPQWGBSFXBL c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x4138A70", Offset = "0x4137E70", VA = "0x184138A70")]
			private List<OHCPENJXYFI> PJDTEPDCVOW(THQFFICRKST a, ZIUCYVLLCOL b, GSJOVJNHIEE c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x41386C0", Offset = "0x4137AC0", VA = "0x1841386C0")]
			private CAMZTXWHAYG LLBZNRVPNHC(List<CAMZTXWHAYG> a, GSJOVJNHIEE b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x413A410", Offset = "0x4139810", VA = "0x18413A410")]
			[CompilerGenerated]
			private VLXCXCSSZAI ZQNARIJENVE(CFDTQFFCTZU a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class FSIAWNZAOSE : NWBVHBZMQLQ<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class JLSEUHBSZCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public FSIAWNZAOSE MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public JLSEUHBSZCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x28105B0", Offset = "0x280F9B0", VA = "0x1828105B0")]
				internal int YKZCBYLTSVK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x2810600", Offset = "0x280FA00", VA = "0x182810600")]
				internal Task<bool> YLEIZFFRCGT(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x280FC60", Offset = "0x280F060", VA = "0x18280FC60")]
			public FSIAWNZAOSE(AUQKPBYPMDP a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x280FAB0", Offset = "0x280EEB0", VA = "0x18280FAB0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class XZGKWAIGAFG : MIRWKZWWRTI<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public XZGKWAIGAFG MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0x281DD30", Offset = "0x281D130", VA = "0x18281DD30")]
				internal int LZLUEZDNBTL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x281DC10", Offset = "0x281D010", VA = "0x18281DC10")]
				internal Task<bool> LZGNHSJPSIC(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x282C980", Offset = "0x282BD80", VA = "0x18282C980")]
			public XZGKWAIGAFG(AUQKPBYPMDP a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x282C760", Offset = "0x282BB60", VA = "0x18282C760", Slot = "151")]
			protected override void MKVXEIQGUZT(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class TIPHIGZMZXQ : NWBVHBZMQLQ<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0xC11440", Offset = "0xC10840", VA = "0x180C11440", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x281ED90", Offset = "0x281E190", VA = "0x18281ED90")]
			public TIPHIGZMZXQ(AUQKPBYPMDP a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class TTOIJKDLWPM : NWBVHBZMQLQ<JOAGRJVCFNF>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class OFEBALTHFAS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public TTOIJKDLWPM MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public THQFFICRKST ZNMMCDBHZDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> FQRGXNYIRIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> FRHBPIGATQN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> FRMIMOZYDBW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> FSCDEJHQFJX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> FRWWHCNSVYO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> FSMQYWVKYGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> FSHKBQBNOVG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> YWRVMKWXBAO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> YWXCJRQUKLX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> YWHHRXJCIDW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> YWMOPECZRPF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> YVWTXJVHPHE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> YWCAUQPEYSN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> YVMGCWHMWKM;

				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public OFEBALTHFAS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x281B8E0", Offset = "0x281ACE0", VA = "0x18281B8E0")]
				internal bool YKZCBYLTSVK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0x281B930", Offset = "0x281AD30", VA = "0x18281B930")]
				internal void YLEIZFFRCGT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x281B7E0", Offset = "0x281ABE0", VA = "0x18281B7E0")]
				internal bool YKEAMXKEHCA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x281B830", Offset = "0x281AC30", VA = "0x18281B830")]
				internal bool YKJHKEEBQNJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x281B880", Offset = "0x281AC80", VA = "0x18281B880")]
				internal void YKOOHKXYZYS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x281B990", Offset = "0x281AD90", VA = "0x18281B990")]
				internal bool YMUMDHIVZTN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2813F80", Offset = "0x2813380", VA = "0x182813F80")]
				internal bool PXDWTNUSYJT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2813F20", Offset = "0x2813320", VA = "0x182813F20")]
				internal void PWYPWHAVOYK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2813ED0", Offset = "0x28132D0", VA = "0x182813ED0")]
				internal bool PWIVEMTDMQJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x2813E80", Offset = "0x2813280", VA = "0x182813E80")]
				internal bool PWDOHFZGDFA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x2813E20", Offset = "0x2813220", VA = "0x182813E20")]
				internal void PVYHJZFITTR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2813DD0", Offset = "0x28131D0", VA = "0x182813DD0")]
				internal bool PVIMSEXQRLQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x28119C0", Offset = "0x2810DC0", VA = "0x1828119C0")]
				internal bool CRGTYGXOQFR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2811970", Offset = "0x2810D70", VA = "0x182811970")]
				internal bool CRBNBADRGUI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2811A10", Offset = "0x2810E10", VA = "0x182811A10")]
				internal bool CRRHSULJJCJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2811B60", Offset = "0x2810F60", VA = "0x182811B60")]
				internal bool CTRYRKCIZLV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2811B10", Offset = "0x2810F10", VA = "0x182811B10")]
				internal bool CTMRUDILQAM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2815510", Offset = "0x2814910", VA = "0x182815510")]
				internal bool WRIPBXQBYDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2815560", Offset = "0x2814960", VA = "0x182815560")]
				internal bool WRNVZEJZHOJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2815460", Offset = "0x2814860", VA = "0x182815460")]
				internal void WQYBHKCHFGI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2812360", Offset = "0x2811760", VA = "0x182812360")]
				internal bool HTZDKOZDTDR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x28123B0", Offset = "0x28117B0", VA = "0x1828123B0")]
				internal bool HUEKHVTBCPA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2812400", Offset = "0x2811800", VA = "0x182812400")]
				internal bool HUJRFCMYMAJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2812450", Offset = "0x2811850", VA = "0x182812450")]
				internal bool HUUEZQATEXB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x28124A0", Offset = "0x28118A0", VA = "0x1828124A0")]
				internal bool HUZLWWUQOIK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x28154C0", Offset = "0x28148C0", VA = "0x1828154C0")]
				internal bool WRDIEQWEORR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2815650", Offset = "0x2814A50", VA = "0x182815650")]
				internal bool WSDQQYRRJWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x28156A0", Offset = "0x2814AA0", VA = "0x1828156A0")]
				internal void WSIXOFLOTHT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x28155B0", Offset = "0x28149B0", VA = "0x1828155B0")]
				internal bool WRTCWLDWQZS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2815600", Offset = "0x2814A00", VA = "0x182815600")]
				internal bool WRYJTRXUALB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2815700", Offset = "0x2814B00", VA = "0x182815700")]
				internal void WSYSFZTGVPU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2815760", Offset = "0x2814B60", VA = "0x182815760")]
				internal bool WTDZDGNEFBD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2811AC0", Offset = "0x2810EC0", VA = "0x182811AC0")]
				internal bool CSBVNHZEBZB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2811A60", Offset = "0x2810E60", VA = "0x182811A60")]
				internal void CRWOQBFGSNS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2815AA0", Offset = "0x2814EA0", VA = "0x182815AA0")]
				internal List<OHCPENJXYFI> XXPMAQTPXYJ(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x28124F0", Offset = "0x28118F0", VA = "0x1828124F0")]
				internal bool HVESUDONXTT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2812540", Offset = "0x2811940", VA = "0x182812540")]
				internal int HVJZRKILHFC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2812590", Offset = "0x2811990", VA = "0x182812590")]
				internal Task<bool> HVPGORCIQQL(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2813850", Offset = "0x2812C50", VA = "0x182813850")]
				internal bool OULBMANIZKR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2813800", Offset = "0x2812C00", VA = "0x182813800")]
				internal bool OUFUOTTLPZI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x28137B0", Offset = "0x2812BB0", VA = "0x1828137B0")]
				internal bool OUANRMZOGNZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2813760", Offset = "0x2812B60", VA = "0x182813760")]
				internal int OTVGUGFQXCQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2813990", Offset = "0x2812D90", VA = "0x182813990")]
				internal Task<bool> OVGDBBOYLEB(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2813940", Offset = "0x2812D40", VA = "0x182813940")]
				internal bool OVAWDUVBBSS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x28138F0", Offset = "0x2812CF0", VA = "0x1828138F0")]
				internal bool OUVPGOBDSHJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x28138A0", Offset = "0x2812CA0", VA = "0x1828138A0")]
				internal bool OUQIJHHGIWA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2813A20", Offset = "0x2812E20", VA = "0x182813A20")]
				internal bool OVVXSVWQNMC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2814DE0", Offset = "0x28141E0", VA = "0x182814DE0")]
				internal bool UVEHXKWLDGS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x281BA30", Offset = "0x281AE30", VA = "0x18281BA30")]
				internal string YYFTCMLKDXR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x281BA80", Offset = "0x281AE80", VA = "0x18281BA80")]
				internal void YYKZZTFHNJA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x281BAF0", Offset = "0x281AEF0", VA = "0x18281BAF0")]
				internal int YZAURNMZPRB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x281BB40", Offset = "0x281AF40", VA = "0x18281BB40")]
				internal void YZGBOUGWZCK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x281BBA0", Offset = "0x281AFA0", VA = "0x18281BBA0")]
				internal bool YZLIMBAUINT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x281BBF0", Offset = "0x281AFF0", VA = "0x18281BBF0")]
				internal bool YZQPJHURRZC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x281BC40", Offset = "0x281B040", VA = "0x18281BC40")]
				internal bool YZVWGOOPBKL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2812200", Offset = "0x2811600", VA = "0x182812200")]
				internal float FYRRDXZPKER()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x28121A0", Offset = "0x28115A0", VA = "0x1828121A0")]
				internal void FYMKGRFSATI(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2812150", Offset = "0x2811550", VA = "0x182812150")]
				internal bool FYHDJKLURHZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2812100", Offset = "0x2811500", VA = "0x182812100")]
				internal bool FYBWMDRXHWQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2812310", Offset = "0x2811710", VA = "0x182812310")]
				internal bool FZMSSZBEVYB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2814D40", Offset = "0x2814140", VA = "0x182814D40")]
				internal bool UUTUCXIQKKA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2814D90", Offset = "0x2814190", VA = "0x182814D90")]
				internal bool UUZBAECNTVJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2814900", Offset = "0x2813D00", VA = "0x182814900")]
				internal bool UUJGIJUVRNI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2814950", Offset = "0x2813D50", VA = "0x182814950")]
				internal void UUONFQOTAYR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x28122C0", Offset = "0x28116C0", VA = "0x1828122C0")]
				internal string FZHLVSHHMMS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2812250", Offset = "0x2811650", VA = "0x182812250")]
				internal void FZCEYLNKDBJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2814860", Offset = "0x2813C60", VA = "0x182814860")]
				internal bool UTYSNWHAYQQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x28148B0", Offset = "0x2813CB0", VA = "0x1828148B0")]
				internal bool UUDZLDAYIBZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2814E30", Offset = "0x2814230", VA = "0x182814E30")]
				internal bool UWULBMZQATM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2814E80", Offset = "0x2814280", VA = "0x182814E80")]
				internal void UWZRYTTNKEV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x28113F0", Offset = "0x28107F0", VA = "0x1828113F0")]
				internal bool BVVMWDENSZB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x28113A0", Offset = "0x28107A0", VA = "0x1828113A0")]
				internal bool BVQFYWKQJNS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2811490", Offset = "0x2810890", VA = "0x182811490")]
				internal bool BWGAQQSILVT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2811440", Offset = "0x2810840", VA = "0x182811440")]
				internal bool BWATTJYLCKK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2811530", Offset = "0x2810930", VA = "0x182811530")]
				internal void BWQOLEGDESL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x28114E0", Offset = "0x28108E0", VA = "0x1828114E0")]
				internal bool BWLHNXMFVHC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x28115E0", Offset = "0x28109E0", VA = "0x1828115E0")]
				internal bool BXBCFRTXXPD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2811590", Offset = "0x2810990", VA = "0x182811590")]
				internal bool BWVVILAAODU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2811350", Offset = "0x2810750", VA = "0x182811350")]
				internal bool BUFJSBBIVMH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x28112F0", Offset = "0x28106F0", VA = "0x1828112F0")]
				internal void BUACUUHLMAY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2812D30", Offset = "0x2812130", VA = "0x182812D30")]
				internal bool KOZJDFBXARK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2812D80", Offset = "0x2812180", VA = "0x182812D80")]
				internal bool KPEQALVUKCT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2812DD0", Offset = "0x28121D0", VA = "0x182812DD0")]
				internal bool KPJWXSPRTOC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2812E20", Offset = "0x2812220", VA = "0x182812E20")]
				internal bool KPPDUZJPCZL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2812C30", Offset = "0x2812030", VA = "0x182812C30")]
				internal object KOOVIROCHUS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2812CA0", Offset = "0x28120A0", VA = "0x182812CA0")]
				internal void KOUCFYHZRGB(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2812E70", Offset = "0x2812270", VA = "0x182812E70")]
				internal bool KQPMHHFBYEE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2812EC0", Offset = "0x28122C0", VA = "0x182812EC0")]
				internal bool KQUTENYZHPN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2814410", Offset = "0x2813810", VA = "0x182814410")]
				internal int RPLHEQQCGYK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x28143B0", Offset = "0x28137B0", VA = "0x1828143B0")]
				internal void RPGAHJWEXNB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2814360", Offset = "0x2813760", VA = "0x182814360")]
				internal bool ROQFPPOMVFA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2814310", Offset = "0x2813710", VA = "0x182814310")]
				internal bool ROKYSIUPLTR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2814460", Offset = "0x2813860", VA = "0x182814460")]
				internal int RRBKISTHELE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x28130B0", Offset = "0x28124B0", VA = "0x1828130B0")]
				internal void LGUOFZBXADR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2813060", Offset = "0x2812460", VA = "0x182813060")]
				internal bool LGPHISHZQSI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2813160", Offset = "0x2812560", VA = "0x182813160")]
				internal bool LHFCAMPRTAJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2813110", Offset = "0x2812510", VA = "0x182813110")]
				internal bool LGZVDFVUJPA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2813010", Offset = "0x2812410", VA = "0x182813010")]
				internal int LGKALLOCHGZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2812FB0", Offset = "0x28123B0", VA = "0x182812FB0")]
				internal void LGETOEUEXVQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2812F60", Offset = "0x2812360", VA = "0x182812F60")]
				internal bool LFELBWYSCQX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2812F10", Offset = "0x2812310", VA = "0x182812F10")]
				internal bool LEZEEQEUTFO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2811FB0", Offset = "0x28113B0", VA = "0x182811FB0")]
				internal bool EGDJHGTUKLI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2812090", Offset = "0x2811490", VA = "0x182812090")]
				internal object EHDRTOPHFQB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2812000", Offset = "0x2811400", VA = "0x182812000")]
				internal void EGNXBUHPDIA(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2811F10", Offset = "0x2811310", VA = "0x182811F10")]
				internal bool EENGDEQPMYO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2811F60", Offset = "0x2811360", VA = "0x182811F60")]
				internal bool EESNALKMWJX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2815990", Offset = "0x2814D90", VA = "0x182815990")]
				internal object? XFMEIOLRUSZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2815900", Offset = "0x2814D00", VA = "0x182815900")]
				internal void XFGXLHRULHQ(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x28158B0", Offset = "0x2814CB0", VA = "0x1828158B0")]
				internal bool XERCTNKCIZP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2815860", Offset = "0x2814C60", VA = "0x182815860")]
				internal int XELVWGQEZOG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2815800", Offset = "0x2814C00", VA = "0x182815800")]
				internal void XEGOYZWHQCX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x28157B0", Offset = "0x2814BB0", VA = "0x1828157B0")]
				internal bool XEBIBTCKGRO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2815A50", Offset = "0x2814E50", VA = "0x182815A50")]
				internal bool XHCHMQOWSFT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2815A00", Offset = "0x2814E00", VA = "0x182815A00")]
				internal bool XGXAPJUZIUK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2814120", Offset = "0x2813520", VA = "0x182814120")]
				internal int QEUZJWDPFAQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2814170", Offset = "0x2813570", VA = "0x182814170")]
				internal void QFAGHCXMOLZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x28141D0", Offset = "0x28135D0", VA = "0x1828141D0")]
				internal bool QFFNEJRJXXI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2814220", Offset = "0x2813620", VA = "0x182814220")]
				internal bool QFKUBQLHHIR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2813FD0", Offset = "0x28133D0", VA = "0x182813FD0")]
				internal bool QDZXUVBZTHG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2814020", Offset = "0x2813420", VA = "0x182814020")]
				internal float QEFESBVXCSP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2814070", Offset = "0x2813470", VA = "0x182814070")]
				internal void QEKLPIPUMDY(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x28140D0", Offset = "0x28134D0", VA = "0x1828140D0")]
				internal bool QEPSMPJRVPH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2814270", Offset = "0x2813670", VA = "0x182814270")]
				internal bool QGLCNYGUCNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x28142C0", Offset = "0x28136C0", VA = "0x1828142C0")]
				internal bool QGQJLFARLYT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x28129E0", Offset = "0x2811DE0", VA = "0x1828129E0")]
				internal float KEBSYLUNBEP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2812980", Offset = "0x2811D80", VA = "0x182812980")]
				internal void KDWMBFAPRTG(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2812A30", Offset = "0x2811E30", VA = "0x182812A30")]
				internal bool KEMGSZIHUBH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2812A80", Offset = "0x2811E80", VA = "0x182812A80")]
				internal bool KERNQGCFDMQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2812B40", Offset = "0x2811F40", VA = "0x182812B40")]
				internal string KFHIIAJXFUR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2812AD0", Offset = "0x2811ED0", VA = "0x182812AD0")]
				internal void KFCBKTPZWJI(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2812BE0", Offset = "0x2811FE0", VA = "0x182812BE0")]
				internal bool KFRWCNXRYRJ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2812B90", Offset = "0x2811F90", VA = "0x182812B90")]
				internal bool KFMPFHDUPGA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2811E70", Offset = "0x2811270", VA = "0x182811E70")]
				internal bool DJXAQBZEBLI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2811EC0", Offset = "0x28112C0", VA = "0x182811EC0")]
				internal bool DKCHNITBKWR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2811DB0", Offset = "0x28111B0", VA = "0x182811DB0")]
				internal string DJMMVOLJIOQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2811E00", Offset = "0x2811200", VA = "0x182811E00")]
				internal void DJRTSVFGRZZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2811D10", Offset = "0x2811110", VA = "0x182811D10")]
				internal bool DJBZBAXOPRY(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2811D60", Offset = "0x2811160", VA = "0x182811D60")]
				internal bool DJHFYHRLZDH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2811C70", Offset = "0x2811070", VA = "0x182811C70")]
				internal bool DIRLGNJTWVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2811CC0", Offset = "0x28110C0", VA = "0x182811CC0")]
				internal bool DIWSDUDRGGP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2811BB0", Offset = "0x2810FB0", VA = "0x182811BB0")]
				internal string DIGXLZVZDYO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2811C00", Offset = "0x2811000", VA = "0x182811C00")]
				internal void DIMEJGPWNJX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x28152B0", Offset = "0x28146B0", VA = "0x1828152B0")]
				internal bool WJFVRJRBLSZ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2815260", Offset = "0x2814660", VA = "0x182815260")]
				internal bool WJAOUCXECHQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2815210", Offset = "0x2814610", VA = "0x182815210")]
				internal bool WIVHWWDGSWH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x28151C0", Offset = "0x28145C0", VA = "0x1828151C0")]
				internal bool WIQAZPJJJKY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2815410", Offset = "0x2814810", VA = "0x182815410")]
				internal string WKAXGKSQXMJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x28153A0", Offset = "0x28147A0", VA = "0x1828153A0")]
				internal void WJVQJDYTOBA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2815350", Offset = "0x2814750", VA = "0x182815350")]
				internal bool WJQJLXEWEPR(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2815300", Offset = "0x2814700", VA = "0x182815300")]
				internal bool WJLCOQKYVEI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2815170", Offset = "0x2814570", VA = "0x182815170")]
				internal bool WHPSNHNWOGF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2815120", Offset = "0x2814520", VA = "0x182815120")]
				internal bool WHKLQATZEUW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2813B10", Offset = "0x2812F10", VA = "0x182813B10")]
				internal string PIOQSRIYWAQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2813B60", Offset = "0x2812F60", VA = "0x182813B60")]
				internal void PITXPYCWFLZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2813BD0", Offset = "0x2812FD0", VA = "0x182813BD0")]
				internal bool PIZENEWTOXI(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2813C20", Offset = "0x2813020", VA = "0x182813C20")]
				internal bool PJELKLQQYIR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2813C70", Offset = "0x2813070", VA = "0x182813C70")]
				internal bool PJJSHSKOHUA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2813CC0", Offset = "0x28130C0", VA = "0x182813CC0")]
				internal bool PJOZEZELRFJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2813D10", Offset = "0x2813110", VA = "0x182813D10")]
				internal string PJUGCFYJAQS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2813D60", Offset = "0x2813160", VA = "0x182813D60")]
				internal void PJZMZMSGKCB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2813A70", Offset = "0x2812E70", VA = "0x182813A70")]
				internal bool PGYNOPFTYNW(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2813AC0", Offset = "0x2812EC0", VA = "0x182813AC0")]
				internal bool PHDULVZRHZF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x28127B0", Offset = "0x2811BB0", VA = "0x1828127B0")]
				internal bool IHXLTZAWGIH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2812760", Offset = "0x2811B60", VA = "0x182812760")]
				internal bool IHSEWSGYWWY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2812870", Offset = "0x2811C70", VA = "0x182812870")]
				internal string IIHZOMOQZEZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2812800", Offset = "0x2811C00", VA = "0x182812800")]
				internal void IICSRFUTPTQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2812670", Offset = "0x2811A70", VA = "0x182812670")]
				internal bool IHCKEXZGUOX(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2812620", Offset = "0x2811A20", VA = "0x182812620")]
				internal bool IGXDHRFJLDO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2812710", Offset = "0x2811B10", VA = "0x182812710")]
				internal bool IHMXZLNBNLP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x28126C0", Offset = "0x2811AC0", VA = "0x1828126C0")]
				internal bool IHHRCETEEAG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2812930", Offset = "0x2811D30", VA = "0x182812930")]
				internal string IJNOYBEBDVB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x28128C0", Offset = "0x2811CC0", VA = "0x1828128C0")]
				internal void IJIIAUKDUJS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x28116D0", Offset = "0x2810AD0", VA = "0x1828116D0")]
				internal bool CHEFIORUCMG(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2811720", Offset = "0x2810B20", VA = "0x182811720")]
				internal bool CHJMFVLRLXP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2811630", Offset = "0x2810A30", VA = "0x182811630")]
				internal bool CGTROBDZJPO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2811680", Offset = "0x2810A80", VA = "0x182811680")]
				internal bool CGYYLHXWTAX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2811810", Offset = "0x2810C10", VA = "0x182811810")]
				internal string CHZGXPTJOFQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2811860", Offset = "0x2810C60", VA = "0x182811860")]
				internal void CIENUWNGXQZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2811770", Offset = "0x2810B70", VA = "0x182811770")]
				internal bool CHOTDCFOVIY(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x28117C0", Offset = "0x2810BC0", VA = "0x1828117C0")]
				internal bool CHUAAIZMEUH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x28118D0", Offset = "0x2810CD0", VA = "0x1828118D0")]
				internal bool CIUIMQUYZZA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2811920", Offset = "0x2810D20", VA = "0x182811920")]
				internal bool CIZPJXOWJKJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2813360", Offset = "0x2812760", VA = "0x182813360")]
				internal string LZKXPIIROAS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x28133B0", Offset = "0x28127B0", VA = "0x1828133B0")]
				internal void LZQEMPCOXMB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2813310", Offset = "0x2812710", VA = "0x182813310")]
				internal bool LZFQSBOUEPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2813270", Offset = "0x2812670", VA = "0x182813270")]
				internal bool LYPWAHHCCHI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x28132C0", Offset = "0x28126C0", VA = "0x1828132C0")]
				internal bool LYVCXOAZLSR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x28131B0", Offset = "0x28125B0", VA = "0x1828131B0")]
				internal string LYFIFTTHJKQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2813200", Offset = "0x2812600", VA = "0x182813200")]
				internal void LYKPDANESVZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2813420", Offset = "0x2812820", VA = "0x182813420")]
				internal bool MBBATKLWLNM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2813470", Offset = "0x2812870", VA = "0x182813470")]
				internal bool MBGHQRFTUYV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2814550", Offset = "0x2813950", VA = "0x182814550")]
				internal bool TACCOAQUDTB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2814500", Offset = "0x2813900", VA = "0x182814500")]
				internal string SZWVQTWWUHS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x28145F0", Offset = "0x28139F0", VA = "0x1828145F0")]
				internal void TAMQIOEOWPT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x28145A0", Offset = "0x28139A0", VA = "0x1828145A0")]
				internal bool TAHJLHKRNEK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x28146B0", Offset = "0x2813AB0", VA = "0x1828146B0")]
				internal bool TAXEDBSJPML()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2814660", Offset = "0x2813A60", VA = "0x182814660")]
				internal bool TARXFUYMGBC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2814770", Offset = "0x2813B70", VA = "0x182814770")]
				internal string TBHRXPGEIJD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2814700", Offset = "0x2813B00", VA = "0x182814700")]
				internal void TBCLAIMGYXU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x28144B0", Offset = "0x28138B0", VA = "0x1828144B0")]
				internal bool SYGSMRTRWUY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x281B9E0", Offset = "0x281ADE0", VA = "0x18281B9E0")]
				internal bool YYAMFFRMUMI(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x28134C0", Offset = "0x28128C0", VA = "0x1828134C0")]
				internal float NVEQZHONQAI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2813510", Offset = "0x2812910", VA = "0x182813510")]
				internal void NVJXWOIKZLR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2813610", Offset = "0x2812A10", VA = "0x182813610")]
				internal bool NWKGIWDXUQK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2813660", Offset = "0x2812A60", VA = "0x182813660")]
				internal bool NWPNGCXVEBT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2813570", Offset = "0x2812970", VA = "0x182813570")]
				internal bool NVZSOIQDBTS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x28135C0", Offset = "0x28129C0", VA = "0x1828135C0")]
				internal int NWEZLPKALFB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x28136B0", Offset = "0x2812AB0", VA = "0x1828136B0")]
				internal void NXFHXXFNGJU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2813710", Offset = "0x2812B10", VA = "0x182813710")]
				internal bool NXKOVDZKPVD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2814810", Offset = "0x2813C10", VA = "0x182814810")]
				internal bool TWILFFLKMTB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x28147C0", Offset = "0x2813BC0", VA = "0x1828147C0")]
				internal bool TWDEHYRNDHS()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class OFJHXSNEOMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string BNCAUSTTULI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public OFEBALTHFAS AAFJFKGKTGT;

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public OFJHXSNEOMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2836310", Offset = "0x2835710", VA = "0x182836310")]
				internal void UVJOURQIMSB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class OETNFYFMMEA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] SBKCKIISIMF;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public OETNFYFMMEA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2835FB0", Offset = "0x28353B0", VA = "0x182835FB0")]
				internal bool NVULRBWFSIJ(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers YRYKBPMZLYQ;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2820960", Offset = "0x281FD60", VA = "0x182820960")]
			public TTOIJKDLWPM(AUQKPBYPMDP a, JOAGRJVCFNF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x281EE00", Offset = "0x281E200", VA = "0x18281EE00", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class WNGMSCGAUEH : NWBVHBZMQLQ<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool JZQXASCFDXE
			{
				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x2848790", Offset = "0x2847B90", VA = "0x182848790")]
			public WNGMSCGAUEH(AUQKPBYPMDP a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x28484E0", Offset = "0x28478E0", VA = "0x1828484E0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x2847EF0", Offset = "0x28472F0", VA = "0x182847EF0")]
			private static string BJHRCVUIPBJ(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2848090", Offset = "0x2847490", VA = "0x182848090")]
			[CompilerGenerated]
			private object? UCLETNGWZCE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2848130", Offset = "0x2847530", VA = "0x182848130")]
			[CompilerGenerated]
			private void UCQLQUAUINN(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2848240", Offset = "0x2847640", VA = "0x182848240")]
			[CompilerGenerated]
			private string UCVSOAURRYW(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2848440", Offset = "0x2847840", VA = "0x182848440")]
			[CompilerGenerated]
			private IReadOnlyList<object> UDAZLHOPBKF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2847FF0", Offset = "0x28473F0", VA = "0x182847FF0")]
			[CompilerGenerated]
			private string? UBQDEMFHNIU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2848050", Offset = "0x2847450", VA = "0x182848050")]
			[CompilerGenerated]
			private bool UBVKBSZEWUD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class BGJTWDETJHH : NWBVHBZMQLQ<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class JLSEUHBSZCB
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
					public JLSEUHBSZCB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60002FE")]
					[Cpp2IlInjected.Address(RVA = "0x28461D0", Offset = "0x28455D0", VA = "0x1828461D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60002FF")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public BGJTWDETJHH MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public JLSEUHBSZCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x2832DD0", Offset = "0x28321D0", VA = "0x182832DD0")]
				internal string YKZCBYLTSVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0x2833350", Offset = "0x2832750", VA = "0x182833350")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void YLEIZFFRCGT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x28337F0", Offset = "0x2832BF0", VA = "0x1828337F0")]
				internal int YLJPWLZOLSC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x28338E0", Offset = "0x2832CE0", VA = "0x1828338E0")]
				internal void YLOWTSTLVDL(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x282F740", Offset = "0x282EB40", VA = "0x18282F740")]
			public BGJTWDETJHH(AUQKPBYPMDP a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x282F410", Offset = "0x282E810", VA = "0x18282F410", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class XPHZPJAORVM : NWBVHBZMQLQ<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class OBPSGXVZRRC
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
					public OBPSGXVZRRC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000313")]
					[Cpp2IlInjected.Address(RVA = "0x28464E0", Offset = "0x28458E0", VA = "0x1828464E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000314")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public OBPSGXVZRRC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2846AC0", Offset = "0x2845EC0", VA = "0x182846AC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public XPHZPJAORVM MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public OBPSGXVZRRC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0x2835CD0", Offset = "0x28350D0", VA = "0x182835CD0")]
				internal string YKZCBYLTSVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x2835D20", Offset = "0x2835120", VA = "0x182835D20")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void YLEIZFFRCGT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2835DF0", Offset = "0x28351F0", VA = "0x182835DF0")]
				internal int YLJPWLZOLSC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2835E40", Offset = "0x2835240", VA = "0x182835E40")]
				internal Task<bool> YLOWTSTLVDL(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2835AD0", Offset = "0x2834ED0", VA = "0x182835AD0")]
				internal string YKEAMXKEHCA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2835B20", Offset = "0x2834F20", VA = "0x182835B20")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void YKJHKEEBQNJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2835BF0", Offset = "0x2834FF0", VA = "0x182835BF0")]
				internal bool YKOOHKXYZYS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2835C40", Offset = "0x2835040", VA = "0x182835C40")]
				internal void YKTVERRWJKB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2835ED0", Offset = "0x28352D0", VA = "0x182835ED0")]
				internal bool YMPFGAOYQIE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2835F20", Offset = "0x2835320", VA = "0x182835F20")]
				internal void YMUMDHIVZTN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2835A80", Offset = "0x2834E80", VA = "0x182835A80")]
				internal float PXDWTNUSYJT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x28359F0", Offset = "0x2834DF0", VA = "0x1828359F0")]
				internal void PWYPWHAVOYK(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2835990", Offset = "0x2834D90", VA = "0x182835990")]
				internal int PWTIZAGYFNB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x28358F0", Offset = "0x2834CF0", VA = "0x1828358F0")]
				internal void PWOCBTNAWBS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2835880", Offset = "0x2834C80", VA = "0x182835880")]
				internal bool PWIVEMTDMQJ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2849310", Offset = "0x2848710", VA = "0x182849310")]
			public XPHZPJAORVM(AUQKPBYPMDP a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x28489B0", Offset = "0x2847DB0", VA = "0x1828489B0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class LUGKTYRESZP : NWBVHBZMQLQ<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class JLSEUHBSZCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public LUGKTYRESZP MXVWDMPVVWS;

				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public JLSEUHBSZCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x2832E70", Offset = "0x2832270", VA = "0x182832E70")]
				internal Dictionary<string, EnumChoiceData> YKZCBYLTSVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0x2833140", Offset = "0x2832540", VA = "0x182833140")]
				internal int YLEIZFFRCGT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x28336C0", Offset = "0x2832AC0", VA = "0x1828336C0")]
				internal void YLJPWLZOLSC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2833970", Offset = "0x2832D70", VA = "0x182833970")]
				internal bool YLOWTSTLVDL()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x28352A0", Offset = "0x28346A0", VA = "0x1828352A0")]
			public LUGKTYRESZP(AUQKPBYPMDP a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2834FF0", Offset = "0x28343F0", VA = "0x182834FF0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class LRLWQXRURNK : NWBVHBZMQLQ<PUHRYBYIXFT>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class JLSEUHBSZCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public LRLWQXRURNK MXVWDMPVVWS;

				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public JLSEUHBSZCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x2832F10", Offset = "0x2832310", VA = "0x182832F10")]
				internal void YKZCBYLTSVK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x2834F80", Offset = "0x2834380", VA = "0x182834F80")]
			public LRLWQXRURNK(AUQKPBYPMDP a, PUHRYBYIXFT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2834E00", Offset = "0x2834200", VA = "0x182834E00", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class ANOBIPTKBEK<a> : DAZJVKPPUTH<a> where a : notnull, QXUCZURTUVM
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override WBDRXWGHZKJ? GWSLNJDNJSG
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x547BA80", Offset = "0x547AE80", VA = "0x18547BA80", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0x547BAE0", Offset = "0x547AEE0", VA = "0x18547BAE0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0xC0DBC0", Offset = "0xC0CFC0", VA = "0x180C0DBC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x547BAC0", Offset = "0x547AEC0", VA = "0x18547BAC0")]
			public ANOBIPTKBEK(AUQKPBYPMDP a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class LGLKSHQAOES : ANOBIPTKBEK<LDQXCEYRGBB>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class OFEBALTHFAS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public LGLKSHQAOES MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public OFEBALTHFAS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x2836020", Offset = "0x2835420", VA = "0x182836020")]
				internal object YKZCBYLTSVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x2836080", Offset = "0x2835480", VA = "0x182836080")]
				internal void YLEIZFFRCGT(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2836190", Offset = "0x2835590", VA = "0x182836190")]
				internal void YLJPWLZOLSC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? DACVZHCKTAQ;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2834B00", Offset = "0x2833F00", VA = "0x182834B00")]
			public LGLKSHQAOES(AUQKPBYPMDP a, LDQXCEYRGBB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x2834590", Offset = "0x2833990", VA = "0x182834590", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class KVLXGSLXODP : NWBVHBZMQLQ<ZRYDBGGKWKC>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public KVLXGSLXODP MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<CTXJFDCZQJP>> XTBNYBDGBTF;

				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x283EBE0", Offset = "0x283DFE0", VA = "0x18283EBE0")]
				internal int YLEIZFFRCGT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0x283F460", Offset = "0x283E860", VA = "0x18283F460")]
				internal void YLJPWLZOLSC(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class SYFLWXHJVWU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<CTXJFDCZQJP> QYKJWKYDJMF;

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYFLWXHJVWU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x283E1E0", Offset = "0x283D5E0", VA = "0x18283E1E0")]
				internal bool YKEAMXKEHCA(Id32<CTXJFDCZQJP> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x2834520", Offset = "0x2833920", VA = "0x182834520")]
			public KVLXGSLXODP(AUQKPBYPMDP a, ZRYDBGGKWKC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2834010", Offset = "0x2833410", VA = "0x182834010", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class YLPRMOMJRWV : NWBVHBZMQLQ<MBCUNGOTUBM>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xB16290", Offset = "0xB15690", VA = "0x180B16290", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x284A4E0", Offset = "0x28498E0", VA = "0x18284A4E0")]
			public YLPRMOMJRWV(AUQKPBYPMDP a, MBCUNGOTUBM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class FWPPDFWXWXM : NWBVHBZMQLQ<KCETHDJPSRB>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033D")]
				[Cpp2IlInjected.Address(RVA = "0xB49F40", Offset = "0xB49340", VA = "0x180B49F40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x28313F0", Offset = "0x28307F0", VA = "0x1828313F0")]
			public FWPPDFWXWXM(AUQKPBYPMDP a, KCETHDJPSRB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "134")]
			protected override bool IAAYWVGSBMO(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class XMJCHMHKYBU : NWBVHBZMQLQ<UBPTKHIXPZZ>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000341")]
				[Cpp2IlInjected.Address(RVA = "0xB411C0", Offset = "0xB405C0", VA = "0x180B411C0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000342")]
				[Cpp2IlInjected.Address(RVA = "0x2848870", Offset = "0x2847C70", VA = "0x182848870", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool JZQXASCFDXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x2848800", Offset = "0x2847C00", VA = "0x182848800")]
			public XMJCHMHKYBU(AUQKPBYPMDP a, UBPTKHIXPZZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class VKHWKGWGZWW : NWBVHBZMQLQ<KYYEPJJBPKH>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x28477B0", Offset = "0x2846BB0", VA = "0x1828477B0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool JZQXASCFDXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2847740", Offset = "0x2846B40", VA = "0x182847740")]
			public VKHWKGWGZWW(AUQKPBYPMDP a, KYYEPJJBPKH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class KFYXRURJGTZ : MIRWKZWWRTI<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public KFYXRURJGTZ MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x600034D")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600034E")]
				[Cpp2IlInjected.Address(RVA = "0x283E510", Offset = "0x283D910", VA = "0x18283E510")]
				internal float LZLUEZDNBTL()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0x283E280", Offset = "0x283D680", VA = "0x18283E280")]
				internal void LZGNHSJPSIC(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2833FB0", Offset = "0x28333B0", VA = "0x182833FB0")]
			public KFYXRURJGTZ(AUQKPBYPMDP a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x2833D40", Offset = "0x2833140", VA = "0x182833D40", Slot = "151")]
			protected override void MKVXEIQGUZT(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class PKNYLGHUCII : NWBVHBZMQLQ<EPPSOTEKAQB>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x2836EF0", Offset = "0x28362F0", VA = "0x182836EF0")]
			public PKNYLGHUCII(AUQKPBYPMDP a, EPPSOTEKAQB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class WFKVVKZPREQ : NWBVHBZMQLQ<IMTYSVDJOMN>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000353")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x2847D70", Offset = "0x2847170", VA = "0x182847D70")]
			public WFKVVKZPREQ(AUQKPBYPMDP a, IMTYSVDJOMN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class DENQEBHVIXX : NWBVHBZMQLQ<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public DENQEBHVIXX MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x6000358")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000359")]
				[Cpp2IlInjected.Address(RVA = "0x283E8F0", Offset = "0x283DCF0", VA = "0x18283E8F0")]
				internal bool YKZCBYLTSVK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0x283ED20", Offset = "0x283E120", VA = "0x18283ED20")]
				internal void YLEIZFFRCGT(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2830090", Offset = "0x282F490", VA = "0x182830090")]
			public DENQEBHVIXX(AUQKPBYPMDP a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x282FE00", Offset = "0x282F200", VA = "0x18282FE00", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class STADCFEDLIF : NWBVHBZMQLQ<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public STADCFEDLIF MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> GSJXVHYZMYK;

				[Cpp2IlInjected.Token(Token = "0x600035D")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x283E990", Offset = "0x283DD90", VA = "0x18283E990")]
				internal object? YKZCBYLTSVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x283E780", Offset = "0x283DB80", VA = "0x18283E780")]
				internal bool YKTVERRWJKB(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x283F020", Offset = "0x283E420", VA = "0x18283F020")]
				internal void YLEIZFFRCGT(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x283F5C0", Offset = "0x283E9C0", VA = "0x18283F5C0")]
				internal string YLJPWLZOLSC(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x283F700", Offset = "0x283EB00", VA = "0x18283F700")]
				internal IReadOnlyList<object> YLOWTSTLVDL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x283E590", Offset = "0x283D990", VA = "0x18283E590")]
				internal bool YKEAMXKEHCA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x283E600", Offset = "0x283DA00", VA = "0x18283E600")]
				internal bool YKJHKEEBQNJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x283E650", Offset = "0x283DA50", VA = "0x18283E650")]
				internal void YKOOHKXYZYS(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x283DDF0", Offset = "0x283D1F0", VA = "0x18283DDF0")]
			public STADCFEDLIF(AUQKPBYPMDP a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x283D700", Offset = "0x283CB00", VA = "0x18283D700", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class HSQTKTKSJMP : NWBVHBZMQLQ<FUVWMIQWVQA>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class OBPSGXVZRRC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int VMKZIJTAXIZ;

				[Cpp2IlInjected.Token(Token = "0x600036B")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public OBPSGXVZRRC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036C")]
				[Cpp2IlInjected.Address(RVA = "0x2835840", Offset = "0x2834C40", VA = "0x182835840")]
				internal bool MBSVJMHZNWN(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class AZSYQXSOVDR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public HSQTKTKSJMP MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> BUVFJZUSZRH;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public AZSYQXSOVDR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x282F1A0", Offset = "0x282E5A0", VA = "0x18282F1A0")]
				internal int YKZCBYLTSVK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0x282F240", Offset = "0x282E640", VA = "0x18282F240")]
				internal void YLEIZFFRCGT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x282F360", Offset = "0x282E760", VA = "0x18282F360")]
				internal string? YLJPWLZOLSC()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x2831F20", Offset = "0x2831320", VA = "0x182831F20")]
			public HSQTKTKSJMP(AUQKPBYPMDP a, FUVWMIQWVQA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2831B40", Offset = "0x2830F40", VA = "0x182831B40")]
			private int DXPYYYPCRWZ(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x2831A20", Offset = "0x2830E20", VA = "0x182831A20")]
			private void ADXPRJGXPSV(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2831BD0", Offset = "0x2830FD0", VA = "0x182831BD0", Slot = "145")]
			protected sealed override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class JWBDZXPQDEY : IRRMIJNVRYU<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0xC0FD00", Offset = "0xC0F100", VA = "0x180C0FD00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x2833C20", Offset = "0x2833020", VA = "0x182833C20")]
			public JWBDZXPQDEY(AUQKPBYPMDP a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class FOPAJECSNWW : MIRWKZWWRTI<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public FOPAJECSNWW MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x6000375")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000376")]
				[Cpp2IlInjected.Address(RVA = "0x283E3C0", Offset = "0x283D7C0", VA = "0x18283E3C0")]
				internal int LZLUEZDNBTL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0x283E320", Offset = "0x283D720", VA = "0x18283E320")]
				internal void LZGNHSJPSIC(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2830D50", Offset = "0x2830150", VA = "0x182830D50")]
			public FOPAJECSNWW(AUQKPBYPMDP a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2830AE0", Offset = "0x282FEE0", VA = "0x182830AE0", Slot = "151")]
			protected override void MKVXEIQGUZT(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class BSBVBCBVDWM : NWBVHBZMQLQ<UDPMOPNATJH>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public BSBVBCBVDWM MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<CTXJFDCZQJP>> XTBNYBDGBTF;

				[Cpp2IlInjected.Token(Token = "0x600037E")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600037F")]
				[Cpp2IlInjected.Address(RVA = "0x283EEE0", Offset = "0x283E2E0", VA = "0x18283EEE0")]
				internal int YLEIZFFRCGT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0x283F300", Offset = "0x283E700", VA = "0x18283F300")]
				internal void YLJPWLZOLSC(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class SYFLWXHJVWU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<CTXJFDCZQJP> QYKJWKYDJMF;

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYFLWXHJVWU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x283E230", Offset = "0x283D630", VA = "0x18283E230")]
				internal bool YKEAMXKEHCA(Id32<CTXJFDCZQJP> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x282FCC0", Offset = "0x282F0C0", VA = "0x18282FCC0")]
			public BSBVBCBVDWM(AUQKPBYPMDP a, UDPMOPNATJH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x282F7B0", Offset = "0x282EBB0", VA = "0x18282F7B0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class ECESPIQCYHY : NWBVHBZMQLQ<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public ECESPIQCYHY MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x6000385")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000386")]
				[Cpp2IlInjected.Address(RVA = "0x283E8A0", Offset = "0x283DCA0", VA = "0x18283E8A0")]
				internal bool YKZCBYLTSVK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0x283EE50", Offset = "0x283E250", VA = "0x18283EE50")]
				internal void YLEIZFFRCGT(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2830330", Offset = "0x282F730", VA = "0x182830330")]
			public ECESPIQCYHY(AUQKPBYPMDP a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x2830160", Offset = "0x282F560", VA = "0x182830160", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class UPFAMZWDHCW : NWBVHBZMQLQ<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public UPFAMZWDHCW MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x600038A")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038B")]
				[Cpp2IlInjected.Address(RVA = "0x283E800", Offset = "0x283DC00", VA = "0x18283E800")]
				internal bool YKZCBYLTSVK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0x283EB50", Offset = "0x283DF50", VA = "0x18283EB50")]
				internal void YLEIZFFRCGT(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2847670", Offset = "0x2846A70", VA = "0x182847670")]
			public UPFAMZWDHCW(AUQKPBYPMDP a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x28474A0", Offset = "0x28468A0", VA = "0x1828474A0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class RVZTKTNJKTO : NWBVHBZMQLQ<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public RVZTKTNJKTO MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x600038F")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000390")]
				[Cpp2IlInjected.Address(RVA = "0x283E940", Offset = "0x283DD40", VA = "0x18283E940")]
				internal int YKZCBYLTSVK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0x283F270", Offset = "0x283E670", VA = "0x18283F270")]
				internal void YLEIZFFRCGT(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x283C510", Offset = "0x283B910", VA = "0x18283C510")]
			public RVZTKTNJKTO(AUQKPBYPMDP a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x283C2C0", Offset = "0x283B6C0", VA = "0x18283C2C0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class HAZGHQLGNKX
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log HONKOTEDSFS;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class HCQEYDUSNCM<a> : NWBVHBZMQLQ<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class YMJEHRLXYVF
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
					public YMJEHRLXYVF <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C6")]
					[Cpp2IlInjected.Address(RVA = "0x3CB3640", Offset = "0x3CB2A40", VA = "0x183CB3640", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C7")]
					[Cpp2IlInjected.Address(RVA = "0x3CB3980", Offset = "0x3CB2D80", VA = "0x183CB3980", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload ZLJYXBCSVPS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public HCQEYDUSNCM<a> MXVWDMPVVWS;

				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public YMJEHRLXYVF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x3E76C10", Offset = "0x3E76010", VA = "0x183E76C10")]
				[AsyncStateMachine(typeof(HCQEYDUSNCM<>.YMJEHRLXYVF.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task CTQCSHZCYLS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0x3E76CE0", Offset = "0x3E760E0", VA = "0x183E76CE0")]
				internal void UUICERYJJNF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class ZAAHAHXLLXD
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
					public ZAAHAHXLLXD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003D9")]
					[Cpp2IlInjected.Address(RVA = "0x3CC62A0", Offset = "0x3CC56A0", VA = "0x183CC62A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DA")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public ZAAHAHXLLXD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x3CC79C0", Offset = "0x3CC6DC0", VA = "0x183CC79C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0x3CC80C0", Offset = "0x3CC74C0", VA = "0x183CC80C0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public THQFFICRKST.TROCYAGKOOZ ZHXZARJMRYK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string AIRKWRPXVOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string PKCCQCPHTPH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public HCQEYDUSNCM<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper TUPMAFESEFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool FAYVBCOUMQP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action QQDVONOUMYV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool SIBEBXAORUJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string ISOREDEPTJR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action HOKJCOHWXOT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action BOQPKAKBZXJ;

				[Cpp2IlInjected.Token(Token = "0x60003C8")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public ZAAHAHXLLXD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C9")]
				[Cpp2IlInjected.Address(RVA = "0x3E7EBF0", Offset = "0x3E7DFF0", VA = "0x183E7EBF0")]
				internal void AZLXSGFUHTK(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0x3E7EC40", Offset = "0x3E7E040", VA = "0x183E7EC40")]
				internal void AZREPMZRRET(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
				internal string JWRCRYEJMFV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x3E7EF50", Offset = "0x3E7E350", VA = "0x183E7EF50")]
				internal void JWLVURKMCUM(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0x3E7EE80", Offset = "0x3E7E280", VA = "0x183E7EE80")]
				internal bool JXBQMLSEFCN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x3E7F130", Offset = "0x3E7E530", VA = "0x183E7F130")]
				internal char JWWJPEYGVRE((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
				internal string? JVWBCXCUAML()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0xC0F2F0", Offset = "0xC0E6F0", VA = "0x180C0F2F0")]
				internal bool JVQUFQIWRBC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0x3E7EE90", Offset = "0x3E7E290", VA = "0x183E7EE90")]
				internal void JWGOXKQOTJD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0x3E7EE80", Offset = "0x3E7E280", VA = "0x183E7EE80")]
				internal bool JWBIADWRJXU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x3E7F210", Offset = "0x3E7E610", VA = "0x183E7F210")]
				[AsyncStateMachine(typeof(HCQEYDUSNCM<>.ZAAHAHXLLXD.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void JYHFWAHOJSP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x3E7ED80", Offset = "0x3E7E180", VA = "0x183E7ED80")]
				internal void GNEGBCDQNOB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x3E7ECB0", Offset = "0x3E7E0B0", VA = "0x183E7ECB0")]
				[AsyncStateMachine(typeof(HCQEYDUSNCM<>.ZAAHAHXLLXD.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task BKIGOTBTDES()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x3E7EAD0", Offset = "0x3E7DED0", VA = "0x183E7EAD0")]
				internal void AYBBLKWMTRZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x3E7F2B0", Offset = "0x3E7E6B0", VA = "0x183E7F2B0")]
				internal void VUYZYARIMXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x3E7F1D0", Offset = "0x3E7E5D0", VA = "0x183E7F1D0")]
				internal bool JYBYYTNRAHG()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class UGOKUDFXFYM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter YSRALZXSTVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public HCQEYDUSNCM<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<THQFFICRKST.RXDRCHGYLXH> HMOZBFKUQQQ;

				[Cpp2IlInjected.Token(Token = "0x60003DD")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UGOKUDFXFYM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DE")]
				[Cpp2IlInjected.Address(RVA = "0x6129010", Offset = "0x6128410", VA = "0x186129010")]
				internal bool YSXGPKBUNUI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0x6128F50", Offset = "0x6128350", VA = "0x186128F50")]
				internal void QRARRADWGVO(THQFFICRKST.RXDRCHGYLXH a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class UGTRRJZUPJV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool ERFWTHKUMST;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public OHCPENJXYFI YWAGPAXXEAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public OHCPENJXYFI HRHXARRGHHY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public OHCPENJXYFI HTMEIYJCUSZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string CLOFGIXMFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public UGOKUDFXFYM AAFJFKGKTGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action GSULPVMUFVC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action HNETSZSMSYR;

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UGTRRJZUPJV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0xC20030", Offset = "0xC1F430", VA = "0x180C20030")]
				internal bool ULAJIDDADCM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x6129050", Offset = "0x6128450", VA = "0x186129050")]
				internal void POOONKYVPRP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0x6129BA0", Offset = "0x6128FA0", VA = "0x186129BA0")]
				internal void YTNBHEJMQCJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x6129150", Offset = "0x6128550", VA = "0x186129150")]
				internal void YQMBWGXAEOE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x6129170", Offset = "0x6128570", VA = "0x186129170")]
				internal void YSMSUWNZUXQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x6129560", Offset = "0x6128960", VA = "0x186129560")]
				internal void YTCNMQVRXFR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x6129150", Offset = "0x6128550", VA = "0x186129150")]
				internal void QRQMIULOJDP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class UGYYOQTRYVE
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
					public UGYYOQTRYVE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003EB")]
					[Cpp2IlInjected.Address(RVA = "0x3CD5E00", Offset = "0x3CD5200", VA = "0x183CD5E00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EC")]
					[Cpp2IlInjected.Address(RVA = "0x3CD6430", Offset = "0x3CD5830", VA = "0x183CD6430", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool VLFARCGJFNR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public UGTRRJZUPJV AAKQCRAICSC;

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UGYYOQTRYVE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x6129FF0", Offset = "0x61293F0", VA = "0x186129FF0")]
				[AsyncStateMachine(typeof(HCQEYDUSNCM<>.UGYYOQTRYVE.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task LFILDOMYLRR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x612A0C0", Offset = "0x61294C0", VA = "0x18612A0C0")]
				internal void YQRITNQXNZN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class UHEFLXNPIGN
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
					public UHEFLXNPIGN <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F0")]
					[Cpp2IlInjected.Address(RVA = "0x3CD5800", Offset = "0x3CD4C00", VA = "0x183CD5800", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F1")]
					[Cpp2IlInjected.Address(RVA = "0x3CD5DA0", Offset = "0x3CD51A0", VA = "0x183CD5DA0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload VHPMYYVIGNA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public UGTRRJZUPJV AAPWZXUFMDL;

				[Cpp2IlInjected.Token(Token = "0x60003ED")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UHEFLXNPIGN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EE")]
				[Cpp2IlInjected.Address(RVA = "0x612A130", Offset = "0x6129530", VA = "0x18612A130")]
				[AsyncStateMachine(typeof(HCQEYDUSNCM<>.UHEFLXNPIGN.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task JLBTCRGUYBM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0x612A200", Offset = "0x6129600", VA = "0x18612A200")]
				internal void QRLFLNRQZSG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class IIZHUEQDZCJ
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
					public IIZHUEQDZCJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F7")]
					[Cpp2IlInjected.Address(RVA = "0x3CD5320", Offset = "0x3CD4720", VA = "0x183CD5320", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F8")]
					[Cpp2IlInjected.Address(RVA = "0x3CD57A0", Offset = "0x3CD4BA0", VA = "0x183CD57A0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public HCQEYDUSNCM<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload YXBBWIBPHBI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public THQFFICRKST.RXDRCHGYLXH ZHXZARJMRYK;

				[Cpp2IlInjected.Token(Token = "0x60003F2")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public IIZHUEQDZCJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F3")]
				[Cpp2IlInjected.Address(RVA = "0x4FF5A10", Offset = "0x4FF4E10", VA = "0x184FF5A10")]
				[AsyncStateMachine(typeof(HCQEYDUSNCM<>.IIZHUEQDZCJ.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task EKZTTDVRTRW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0x4FF5C50", Offset = "0x4FF5050", VA = "0x184FF5C50")]
				internal bool XOQANKNOELM(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x4FF5B30", Offset = "0x4FF4F30", VA = "0x184FF5B30")]
				internal void XOKTQDTQVAD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x4FF5AE0", Offset = "0x4FF4EE0", VA = "0x184FF5AE0")]
				internal void XOFMSWZTLOU()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class UKCTNRDETIC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string QWTPYJAZRUN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public OHCPENJXYFI TLECTFGOOSU;

				[Cpp2IlInjected.Token(Token = "0x60003F9")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UKCTNRDETIC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FA")]
				[Cpp2IlInjected.Address(RVA = "0x612C060", Offset = "0x612B460", VA = "0x18612C060")]
				internal string? OVXKCIPNUKT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xC26330", Offset = "0xC25730", VA = "0x180C26330")]
				internal bool OVSDFBVQKZK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x612C080", Offset = "0x612B480", VA = "0x18612C080")]
				internal void OWHXWWDINHL(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool MSELWKRVBWO;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log HONKOTEDSFS
			{
				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x4F419E0", Offset = "0x4F40DE0", VA = "0x184F419E0")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool JZQXASCFDXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x4F45000", Offset = "0x4F44400", VA = "0x184F45000", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected THQFFICRKST ZNMMCDBHZDE
			{
				[Cpp2IlInjected.Token(Token = "0x600039B")]
				[Cpp2IlInjected.Address(RVA = "0xAA6AB0", Offset = "0xAA5EB0", VA = "0x180AA6AB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039C")]
				[Cpp2IlInjected.Address(RVA = "0xAA6D60", Offset = "0xAA6160", VA = "0x180AA6D60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> NZSUSCWJZUV
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xC666E0", Offset = "0xC65AE0", VA = "0x180C666E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xDEC850", Offset = "0xDEBC50", VA = "0x180DEC850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected MWWWSQOARST EUCANDFKPCE
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xC666C0", Offset = "0xC65AC0", VA = "0x180C666C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0x1416090", Offset = "0x1415490", VA = "0x181416090")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected PPQWGBSFXBL DMIFATIDKWW
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xC666D0", Offset = "0xC65AD0", VA = "0x180C666D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x1418530", Offset = "0x1417930", VA = "0x181418530")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x4F44FD0", Offset = "0x4F443D0", VA = "0x184F44FD0")]
			protected HCQEYDUSNCM(AUQKPBYPMDP a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x4F41940", Offset = "0x4F40D40", VA = "0x184F41940", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x4F418F0", Offset = "0x4F40CF0", VA = "0x184F418F0", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x4F41990", Offset = "0x4F40D90", VA = "0x184F41990", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x4F44D10", Offset = "0x4F44110", VA = "0x184F44D10")]
			private void YULCQHHTQPN(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x4F44AD0", Offset = "0x4F43ED0", VA = "0x184F44AD0", Slot = "145")]
			protected sealed override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x4F44470", Offset = "0x4F43870", VA = "0x184F44470")]
			private void XCELNMXSZCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x4F42330", Offset = "0x4F41730", VA = "0x184F42330")]
			private void GSUUQAFGRQP(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "151")]
			protected virtual void CZOHMSUBZJY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x4F442D0", Offset = "0x4F436D0", VA = "0x184F442D0")]
			private void WLXOPKNWBNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4F40DF0", Offset = "0x4F401F0", VA = "0x184F40DF0")]
			private void BPYXGTUZWTR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x4F42EA0", Offset = "0x4F422A0", VA = "0x184F42EA0")]
			private void MIWPHMQGODP(THQFFICRKST.RXDRCHGYLXH a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x4F43DA0", Offset = "0x4F431A0", VA = "0x184F43DA0")]
			private void SVDNJPMUHAX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x4F44CE0", Offset = "0x4F440E0", VA = "0x184F44CE0")]
			protected void YHIJSIOBTLX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x4F43C60", Offset = "0x4F43060", VA = "0x184F43C60")]
			private void MTSKHNINZUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x4F42310", Offset = "0x4F41710", VA = "0x184F42310")]
			private void GADUOOYGIGR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x4F42E00", Offset = "0x4F42200", VA = "0x184F42E00")]
			private void GZNXIBWIQMY(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x4F40AF0", Offset = "0x4F3FEF0", VA = "0x184F40AF0")]
			private string ARLBGDMTZOG((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x4F43D10", Offset = "0x4F43110", VA = "0x184F43D10")]
			private string RLYGJUVDTFL(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x4F42290", Offset = "0x4F41690", VA = "0x184F42290")]
			[CompilerGenerated]
			private object? FECKOCRQFRX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x4F41B30", Offset = "0x4F40F30", VA = "0x184F41B30")]
			[CompilerGenerated]
			private void FDXDQVXSWGO(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x4F41AC0", Offset = "0x4F40EC0", VA = "0x184F41AC0")]
			[CompilerGenerated]
			private IReadOnlyList<object> FDMPWIJYDJW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x4F41A30", Offset = "0x4F40E30", VA = "0x184F41A30")]
			[CompilerGenerated]
			private void FDHIZBQATYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x4F422C0", Offset = "0x4F416C0", VA = "0x184F422C0")]
			[CompilerGenerated]
			private void FFNGUYAXTTI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x4F42E60", Offset = "0x4F42260", VA = "0x184F42E60")]
			[CompilerGenerated]
			private void JEDHSPMHMGS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x4F43FA0", Offset = "0x4F433A0", VA = "0x184F43FA0")]
			[CompilerGenerated]
			private void VHAPDIZKCRG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x4F43CD0", Offset = "0x4F430D0", VA = "0x184F43CD0")]
			[CompilerGenerated]
			private void OKJEQSVFSOR(THQFFICRKST.RXDRCHGYLXH a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class LJRIEMLNOJB : HCQEYDUSNCM<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xB411C0", Offset = "0xB405C0", VA = "0x180B411C0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x2834B60", Offset = "0x2833F60", VA = "0x182834B60")]
			public LJRIEMLNOJB(AUQKPBYPMDP a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class SSARQCQEDGX : HCQEYDUSNCM<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type ITQAFHBSGFG
				{
					[Cpp2IlInjected.Token(Token = "0x6000405")]
					[Cpp2IlInjected.Address(RVA = "0x283C940", Offset = "0x283BD40", VA = "0x18283C940", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope STGRVQXMZBD
				{
					[Cpp2IlInjected.Token(Token = "0x6000406")]
					[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string UUDIJZTBEAD
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000404")]
				[Cpp2IlInjected.Address(RVA = "0x11269C0", Offset = "0x1125DC0", VA = "0x1811269C0")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000408")]
				[Cpp2IlInjected.Address(RVA = "0x283C990", Offset = "0x283BD90", VA = "0x18283C990", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000409")]
				[Cpp2IlInjected.Address(RVA = "0x283C870", Offset = "0x283BC70", VA = "0x18283C870", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool LXITBKEHWVK(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x283C760", Offset = "0x283BB60", VA = "0x18283C760", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x283C6D0", Offset = "0x283BAD0", VA = "0x18283C6D0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x283C580", Offset = "0x283B980", VA = "0x18283C580", Slot = "7")]
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
				protected virtual Type ITQAFHBSGFG
				{
					[Cpp2IlInjected.Token(Token = "0x600040E")]
					[Cpp2IlInjected.Address(RVA = "0x28414A0", Offset = "0x28408A0", VA = "0x1828414A0", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers HAVWZPQFBHF
				{
					[Cpp2IlInjected.Token(Token = "0x600040F")]
					[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string UUDIJZTBEAD
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x11269C0", Offset = "0x1125DC0", VA = "0x1811269C0")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000411")]
				[Cpp2IlInjected.Address(RVA = "0x28414F0", Offset = "0x28408F0", VA = "0x1828414F0", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000412")]
				[Cpp2IlInjected.Address(RVA = "0x28413D0", Offset = "0x28407D0", VA = "0x1828413D0", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool LXITBKEHWVK(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x28412C0", Offset = "0x28406C0", VA = "0x1828412C0", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x2841230", Offset = "0x2840630", VA = "0x182841230", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x28410E0", Offset = "0x28404E0", VA = "0x1828410E0", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class JLSEUHBSZCB
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
					public JLSEUHBSZCB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000423")]
					[Cpp2IlInjected.Address(RVA = "0x28454B0", Offset = "0x28448B0", VA = "0x1828454B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000424")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public JLSEUHBSZCB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x28458D0", Offset = "0x2844CD0", VA = "0x1828458D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public SSARQCQEDGX MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public MWWWSQOARST RPFWCGIKBIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> GSZSNCGRPGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> GSULPVMUFVC;

				[Cpp2IlInjected.Token(Token = "0x600041B")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public JLSEUHBSZCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x28321A0", Offset = "0x28315A0", VA = "0x1828321A0")]
				internal object? CKHRBGDUFFG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0x2832350", Offset = "0x2831750", VA = "0x182832350")]
				internal bool CLXUFIGZCSA(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x2832280", Offset = "0x2831680", VA = "0x182832280")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void CKMXYMXROQP(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x2833B70", Offset = "0x2832F70", VA = "0x182833B70")]
				internal IReadOnlyList<TargetPlayersSelection> ZCADMAWWQQS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2831F90", Offset = "0x2831390", VA = "0x182831F90")]
				internal object? CJRWJLWCCXF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x28323B0", Offset = "0x28317B0", VA = "0x1828323B0")]
				internal bool CMDBCPAWMDJ(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x28320D0", Offset = "0x28314D0", VA = "0x1828320D0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void CJXDGSPZMIO(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> RVVYTLWOBHE;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> FJOKVZCHYQE;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> CNFAAISQCGU;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x283D6A0", Offset = "0x283CAA0", VA = "0x18283D6A0")]
			public SSARQCQEDGX(AUQKPBYPMDP a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x283CAE0", Offset = "0x283BEE0", VA = "0x18283CAE0", Slot = "151")]
			protected override void CZOHMSUBZJY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x283D040", Offset = "0x283C440", VA = "0x18283D040")]
			private static IReadOnlyList<TargetPlayersSelection> VWUKBPNAXNP(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class FZSNTXYCWFW : UUKNZKPGMLL<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType EDAUFZUQIPI
			{
				[Cpp2IlInjected.Token(Token = "0x6000428")]
				[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x28317B0", Offset = "0x2830BB0", VA = "0x1828317B0")]
			public FZSNTXYCWFW(AUQKPBYPMDP a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class ZKKQLZTLUSN : NWBVHBZMQLQ<CFDTQFFCTZU>
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x283C1E0", Offset = "0x283B5E0", VA = "0x18283C1E0")]
			public ZKKQLZTLUSN(AUQKPBYPMDP a, CFDTQFFCTZU b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class NWBVHBZMQLQ<a> : COLFGFXWPZV, IDisposable where a : notnull, CFDTQFFCTZU
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class MWLHREALRTF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public NWBVHBZMQLQ<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public AUQKPBYPMDP LCZXFXKCJWV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a QMXJVPYWNHQ;

				[Cpp2IlInjected.Token(Token = "0x60004B5")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public MWLHREALRTF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B6")]
				[Cpp2IlInjected.Address(RVA = "0x57DE7A0", Offset = "0x57DDBA0", VA = "0x1857DE7A0")]
				internal PNTWOAKYAEO EVPOEESQNSH(LIRLSAHGKSB a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class RFOXBGLKAKN
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
					public RFOXBGLKAKN <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BB")]
					[Cpp2IlInjected.Address(RVA = "0x3CB6150", Offset = "0x3CB5550", VA = "0x183CB6150", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BC")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string VMNILLOITNN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, RAGLFGQXJZI>> YPDAFPGCXAE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public NWBVHBZMQLQ<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> EMUZWRSYROM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public THQFFICRKST ZNMMCDBHZDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> OOYIRVHQPUU;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public RFOXBGLKAKN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				internal string HSLHUBDZHZH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
				internal void HSGAWUKBYNY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0x5B360C0", Offset = "0x5B354C0", VA = "0x185B360C0")]
				[AsyncStateMachine(typeof(NWBVHBZMQLQ<>.RFOXBGLKAKN.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void HSATZNQEPCP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class FELLHTYJGEU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x60004BD")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public FELLHTYJGEU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BE")]
				[Cpp2IlInjected.Address(RVA = "0x4D91E60", Offset = "0x4D91260", VA = "0x184D91E60")]
				internal Result<string, RAGLFGQXJZI> FAEIDESYWID(string a)
				{
					return default(Result<string, RAGLFGQXJZI>);
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
				public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public NWBVHBZMQLQ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0x517E5A0", Offset = "0x517D9A0", VA = "0x18517E5A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x517E7F0", Offset = "0x517DBF0", VA = "0x18517E7F0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public NWBVHBZMQLQ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x517E860", Offset = "0x517DC60", VA = "0x18517E860", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x517EAE0", Offset = "0x517DEE0", VA = "0x18517EAE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly AUQKPBYPMDP XBAZNGQYGJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool TUVKIGZIHMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<RWZXBCGZCJT, PNTWOAKYAEO> DNUBRNPAPOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<RWZXBCGZCJT, ZIUCYVLLCOL> SUDBHFSHOJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> MECLYFPWZDS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<RWZXBCGZCJT>>? YEDBLGLUJKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<RWZXBCGZCJT>, ZIUCYVLLCOL>? EAXPXFXVMQN;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected KXJXLLGOBKY ETIPBFENWNV
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0x5860150", Offset = "0x585F550", VA = "0x185860150")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected IAPPTVDTDES IAPPTVDTDES
			{
				[Cpp2IlInjected.Token(Token = "0x600042B")]
				[Cpp2IlInjected.Address(RVA = "0x5860F00", Offset = "0x5860300", VA = "0x185860F00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected RWPWJSQETXX QZHTMKYSJUI
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x5860840", Offset = "0x585FC40", VA = "0x185860840")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a CFDTQFFCTZU
			{
				[Cpp2IlInjected.Token(Token = "0x6000430")]
				[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<HESNLTWUPXP> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000431")]
				[Cpp2IlInjected.Address(RVA = "0x134DB80", Offset = "0x134CF80", VA = "0x18134DB80", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<HESNLTWUPXP>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<FHMKUSQVKNG> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0x5863260", Offset = "0x5862660", VA = "0x185863260", Slot = "6")]
				get
				{
					return default(Id32<FHMKUSQVKNG>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0x58630D0", Offset = "0x58624D0", VA = "0x1858630D0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x58630B0", Offset = "0x58624B0", VA = "0x1858630B0", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x6000438")]
				[Cpp2IlInjected.Address(RVA = "0x58633C0", Offset = "0x58627C0", VA = "0x1858633C0", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool JZQXASCFDXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<VXBDDQUHKWU> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xCDFFD0", Offset = "0xCDF3D0", VA = "0x180CDFFD0", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<VXBDDQUHKWU>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0xCE1070", Offset = "0xCE0470", VA = "0x180CE1070")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xAF3EB0", Offset = "0xAF32B0", VA = "0x180AF3EB0", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0x5862F80", Offset = "0x5862380", VA = "0x185862F80", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0x5862FB0", Offset = "0x58623B0", VA = "0x185862FB0", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x5862FE0", Offset = "0x58623E0", VA = "0x185862FE0", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x5863240", Offset = "0x5862640", VA = "0x185863240", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x5863170", Offset = "0x5862570", VA = "0x185863170", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x5863050", Offset = "0x5862450", VA = "0x185863050", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x5863020", Offset = "0x5862420", VA = "0x185863020", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0xDAE780", Offset = "0xDADB80", VA = "0x180DAE780", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x14F8A00", Offset = "0x14F7E00", VA = "0x1814F8A00")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x5863010", Offset = "0x5862410", VA = "0x185863010", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0x5863120", Offset = "0x5862520", VA = "0x185863120", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x58631E0", Offset = "0x58625E0", VA = "0x1858631E0", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x5863210", Offset = "0x5862610", VA = "0x185863210", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x5863150", Offset = "0x5862550", VA = "0x185863150", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x600046F")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual VEDYYPMAEUM? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000470")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual WBDRXWGHZKJ? GWSLNJDNJSG
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<FRZIQAPUPIV>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000477")]
				[Cpp2IlInjected.Address(RVA = "0x5863080", Offset = "0x5862480", VA = "0x185863080", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<HUXETNCTSFJ> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000478")]
				[Cpp2IlInjected.Address(RVA = "0x5863190", Offset = "0x5862590", VA = "0x185863190", Slot = "68")]
				get
				{
					return default(Id128<HUXETNCTSFJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<HUXETNCTSFJ> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x58630F0", Offset = "0x58624F0", VA = "0x1858630F0", Slot = "59")]
				get
				{
					return default(Id32<HUXETNCTSFJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<HUXETNCTSFJ>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<HUXETNCTSFJ>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0x58600A0", Offset = "0x585F4A0", VA = "0x1858600A0", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xAAD010", Offset = "0xAAC410", VA = "0x180AAD010", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0xAAD050", Offset = "0xAAC450", VA = "0x180AAD050")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xAAD040", Offset = "0xAAC440", VA = "0x180AAD040", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xAAC9D0", Offset = "0xAABDD0", VA = "0x180AAC9D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<FRZIQAPUPIV> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0x58632A0", Offset = "0x58626A0", VA = "0x1858632A0", Slot = "69")]
				get
				{
					return default(Id32<FRZIQAPUPIV>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<FRZIQAPUPIV> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0x58631C0", Offset = "0x58625C0", VA = "0x1858631C0", Slot = "70")]
				get
				{
					return default(Id128<FRZIQAPUPIV>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<FRZIQAPUPIV>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x58632C0", Offset = "0x58626C0", VA = "0x1858632C0", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<RWZXBCGZCJT, ZIUCYVLLCOL> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x5863380", Offset = "0x5862780", VA = "0x185863380", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<RWZXBCGZCJT, ZIUCYVLLCOL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<RWZXBCGZCJT>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600049E")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600049F")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action OBUCAQSOCNL
			{
				[Cpp2IlInjected.Token(Token = "0x6000458")]
				[Cpp2IlInjected.Address(RVA = "0x585EA90", Offset = "0x585DE90", VA = "0x18585EA90", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000459")]
				[Cpp2IlInjected.Address(RVA = "0x585FBA0", Offset = "0x585EFA0", VA = "0x18585FBA0", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate NHRWBEVDNAU
			{
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x585FA40", Offset = "0x585EE40", VA = "0x18585FA40", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045C")]
				[Cpp2IlInjected.Address(RVA = "0x5862960", Offset = "0x5861D60", VA = "0x185862960", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate VIVARFIRZVZ
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x5862850", Offset = "0x5861C50", VA = "0x185862850", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x5860B90", Offset = "0x585FF90", VA = "0x185860B90", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action KSLPEBPYGGP
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x58606D0", Offset = "0x585FAD0", VA = "0x1858606D0", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x585F160", Offset = "0x585E560", VA = "0x18585F160", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action HCDGHSYEHFI
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x585FC70", Offset = "0x585F070", VA = "0x18585FC70", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x585EB30", Offset = "0x585DF30", VA = "0x18585EB30", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<RWZXBCGZCJT>, ZIUCYVLLCOL> LYYERPWPRXB
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x5860AB0", Offset = "0x585FEB0", VA = "0x185860AB0", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0x585F2D0", Offset = "0x585E6D0", VA = "0x18585F2D0", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<RWZXBCGZCJT>, ZIUCYVLLCOL> QIWPGYWAFCK
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x5860C30", Offset = "0x5860030", VA = "0x185860C30", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x5860370", Offset = "0x585F770", VA = "0x185860370", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<RWZXBCGZCJT>> KKFWNRRYRVC
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x5860610", Offset = "0x585FA10", VA = "0x185860610", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x5862690", Offset = "0x5861A90", VA = "0x185862690", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<RWZXBCGZCJT>, Id32<RWZXBCGZCJT>> AEYBYODRWXF
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x585FAE0", Offset = "0x585EEE0", VA = "0x18585FAE0", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x5860E40", Offset = "0x5860240", VA = "0x185860E40", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<RWZXBCGZCJT>, ZIUCYVLLCOL> ZCYVMLEREED
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x5860550", Offset = "0x585F950", VA = "0x185860550", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x5860CF0", Offset = "0x58600F0", VA = "0x185860CF0", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<RWZXBCGZCJT>, Id32<RWZXBCGZCJT>> VZNOMOVNSVM
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x5860930", Offset = "0x585FD30", VA = "0x185860930", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x58609F0", Offset = "0x585FDF0", VA = "0x1858609F0", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> QTGWGMQOMFB
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x5861D10", Offset = "0x5861110", VA = "0x185861D10", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x5862790", Offset = "0x5861B90", VA = "0x185862790", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x5862B20", Offset = "0x5861F20", VA = "0x185862B20")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected NWBVHBZMQLQ(AUQKPBYPMDP a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x58601B0", Offset = "0x585F5B0", VA = "0x1858601B0", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x585F610", Offset = "0x585EA10", VA = "0x18585F610", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x58604F0", Offset = "0x585F8F0", VA = "0x1858604F0", Slot = "9")]
			public Task<Result<None, RAGLFGQXJZI>> LBTNWYKIJXM(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x585FC40", Offset = "0x585F040", VA = "0x18585FC40")]
			public bool NXKEWFRHICG([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x585F950", Offset = "0x585ED50", VA = "0x18585F950")]
			public bool EDAYQFFEQQX([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x5860430", Offset = "0x585F830", VA = "0x185860430", Slot = "34")]
			public void KNJGAUSYMTR(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x5862450", Offset = "0x5861850", VA = "0x185862450", Slot = "35")]
			public Task VMBJUUPMRBN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x5862300", Offset = "0x5861700", VA = "0x185862300", Slot = "36")]
			[AsyncStateMachine(typeof(NWBVHBZMQLQ<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, RAGLFGQXJZI>> VJECZZDBOMW(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "119")]
			public virtual void NWHXUTVRORD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xD80A50", Offset = "0xD7FE50", VA = "0x180D80A50")]
			protected void VGLVYDWVUNV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x1DED940", Offset = "0x1DECD40", VA = "0x181DED940")]
			protected void ALYOFRYSRZY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x1DCB360", Offset = "0x1DCA760", VA = "0x181DCB360")]
			private void IMINVTMAHXE([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x5860780", Offset = "0x585FB80", VA = "0x185860780", Slot = "122")]
			public virtual Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> LUQAFUENQIJ(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x585F1E0", Offset = "0x585E5E0", VA = "0x18585F1E0", Slot = "123")]
			public virtual Task<Result<None, RAGLFGQXJZI>> CJVEPGNCOHO(Id32<RWZXBCGZCJT> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "124")]
			public virtual void WQJXDSDXUKI(Id32<RWZXBCGZCJT> sourceId, Id32<RWZXBCGZCJT> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x5860FF0", Offset = "0x58603F0", VA = "0x185860FF0", Slot = "125")]
			public virtual IEnumerable<VLXCXCSSZAI> QJOQQAFFWHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x58619D0", Offset = "0x5860DD0", VA = "0x1858619D0", Slot = "126")]
			public Result<None, RAGLFGQXJZI> UIFFYCDDLXQ(string a)
			{
				return default(Result<None, RAGLFGQXJZI>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x585EBD0", Offset = "0x585DFD0", VA = "0x18585EBD0", Slot = "50")]
			public bool ATUFJHHWGMW([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x585F390", Offset = "0x585E790", VA = "0x18585F390")]
			public bool DLOCKBWOFGH([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "128")]
			public virtual void QIUSLYUCXUV(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "129")]
			public virtual DKPXFRAAFBG HTBNCHBXTDH([In] DIYSPRESVJB audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x58617E0", Offset = "0x5860BE0", VA = "0x1858617E0")]
			protected void RKIICTGTQCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x58600A0", Offset = "0x585F4A0", VA = "0x1858600A0", Slot = "134")]
			protected virtual bool IAAYWVGSBMO(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x585F2A0", Offset = "0x585E6A0", VA = "0x18585F2A0", Slot = "96")]
			public bool CYQYUCAQFTS(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "135")]
			protected virtual bool ZSABMOVERGV(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected virtual void XKFCZTAPEEO(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x585FD10", Offset = "0x585F110", VA = "0x18585FD10")]
			protected void HGDMJSBCRSV(THQFFICRKST a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, RAGLFGQXJZI>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x58615E0", Offset = "0x58609E0", VA = "0x1858615E0")]
			protected void REGLIRLRSSL(THQFFICRKST a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x5861A10", Offset = "0x5860E10", VA = "0x185861A10", Slot = "146")]
			protected virtual void UUDULRDSWRA(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x585ECF0", Offset = "0x585E0F0", VA = "0x18585ECF0", Slot = "90")]
			public void BNQKRUOMWXZ(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x58628F0", Offset = "0x5861CF0", VA = "0x1858628F0", Slot = "91")]
			public CircuitsRigidTransform YURYDYHTVQW()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "149")]
			public virtual bool OSAKSEJBKOI(Id32<RWZXBCGZCJT> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x585F1C0", Offset = "0x585E5C0", VA = "0x18585F1C0")]
			private void CFPEEDLPZHT([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x585F980", Offset = "0x585ED80", VA = "0x18585F980")]
			private void FMZUXFSKJXE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xD80A50", Offset = "0xD7FE50", VA = "0x180D80A50", Slot = "97")]
			private void XTTAYHEFSTF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x5861090", Offset = "0x5860490", VA = "0x185861090", Slot = "99")]
			private void QTKQEELKLMW(Id32<RWZXBCGZCJT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x5860B70", Offset = "0x585FF70", VA = "0x185860B70", Slot = "101")]
			private void NULEIAZDARB(Id32<RWZXBCGZCJT> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x5862550", Offset = "0x5861950", VA = "0x185862550", Slot = "103")]
			private void VPKLVCTMWMV(Id32<RWZXBCGZCJT> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x5861F40", Offset = "0x5861340", VA = "0x185861F40", Slot = "104")]
			private void VHZBBIALEON(Id32<RWZXBCGZCJT> sourceId, Id32<RWZXBCGZCJT> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x5862750", Offset = "0x5861B50", VA = "0x185862750", Slot = "105")]
			private void WRXOLDAYZNY(Id32<RWZXBCGZCJT> sourceId, Id32<RWZXBCGZCJT> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x14E5200", Offset = "0x14E4600", VA = "0x1814E5200", Slot = "98")]
			private void AKHYVFDLHCB(Id32<RWZXBCGZCJT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x585ED40", Offset = "0x585E140", VA = "0x18585ED40", Slot = "100")]
			private void BTWSICWRQYO(Id32<RWZXBCGZCJT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x58600E0", Offset = "0x585F4E0", VA = "0x1858600E0", Slot = "102")]
			private void IHAQCBASCDG(Id32<RWZXBCGZCJT> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x58604D0", Offset = "0x585F8D0", VA = "0x1858604D0", Slot = "106")]
			private void KQIDTOJHWXQ(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x5862A00", Offset = "0x5861E00", VA = "0x185862A00", Slot = "150")]
			[AsyncStateMachine(typeof(NWBVHBZMQLQ<>.<RequestNameChange>d__224))]
			public Task<Result<None, RAGLFGQXJZI>> ZSZYAKQGHBK(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x5860DB0", Offset = "0x58601B0", VA = "0x185860DB0", Slot = "57")]
			private void OYTWUIYQTPI(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x5861940", Offset = "0x5860D40", VA = "0x185861940", Slot = "58")]
			private void RODOSBEVDNH(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x585FC40", Offset = "0x585F040", VA = "0x18585FC40", Slot = "30")]
			private bool GAJKNYGJOXR([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x585F950", Offset = "0x585ED50", VA = "0x18585F950", Slot = "32")]
			private bool THZVUREPIVY([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x5862770", Offset = "0x5861B70", VA = "0x185862770", Slot = "51")]
			private bool XHAKHWGABZI([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xAAD010", Offset = "0xAAC410", VA = "0x180AAD010")]
			[CompilerGenerated]
			private string VBHJDZEPAKA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x5861DD0", Offset = "0x58611D0", VA = "0x185861DD0")]
			[CompilerGenerated]
			private void VBMQBFYMJVJ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class DEHSOFWYJWX : IRRMIJNVRYU<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0xC12910", Offset = "0xC11D10", VA = "0x180C12910", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x282FDA0", Offset = "0x282F1A0", VA = "0x18282FDA0")]
			public DEHSOFWYJWX(AUQKPBYPMDP a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class FXBGMEHCGXR : NWBVHBZMQLQ<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class JLSEUHBSZCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XTBTSHZMXZS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public FXBGMEHCGXR MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> ZEQUFFHGPOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> DMKVRZZBXIW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public JLSEUHBSZCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C9")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> YKZCBYLTSVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0x2833230", Offset = "0x2832630", VA = "0x182833230")]
				internal int YLEIZFFRCGT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0x2833570", Offset = "0x2832970", VA = "0x182833570")]
				internal void YLJPWLZOLSC(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C6")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x2831740", Offset = "0x2830B40", VA = "0x182831740")]
			public FXBGMEHCGXR(AUQKPBYPMDP a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2831460", Offset = "0x2830860", VA = "0x182831460", Slot = "145")]
			protected sealed override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class JYQJSGUBHVD : DAZJVKPPUTH<EXXELHLDWJQ>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x2833C80", Offset = "0x2833080", VA = "0x182833C80")]
			public JYQJSGUBHVD(AUQKPBYPMDP a, EXXELHLDWJQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class LLDCDZTDXGP : NWBVHBZMQLQ<UVDOMBWEPUU>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public LLDCDZTDXGP MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x60004D1")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x283E850", Offset = "0x283DC50", VA = "0x18283E850")]
				internal bool YKZCBYLTSVK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0x283EAC0", Offset = "0x283DEC0", VA = "0x18283EAC0")]
				internal void YLEIZFFRCGT(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2834D90", Offset = "0x2834190", VA = "0x182834D90")]
			public LLDCDZTDXGP(AUQKPBYPMDP a, UVDOMBWEPUU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x2834BC0", Offset = "0x2833FC0", VA = "0x182834BC0", Slot = "145")]
			protected sealed override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class YEPUTORLTUY : NWBVHBZMQLQ<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class JLSEUHBSZCB
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
					public JLSEUHBSZCB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F3")]
					[Cpp2IlInjected.Address(RVA = "0x2846820", Offset = "0x2845C20", VA = "0x182846820", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F4")]
					[Cpp2IlInjected.Address(RVA = "0x2846A50", Offset = "0x2845E50", VA = "0x182846A50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> UUGHOKSAZVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public YEPUTORLTUY MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> NAMJXHXJWPK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> BHRMYLCCZFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public JLSEUHBSZCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D8")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> YKZCBYLTSVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0x2833020", Offset = "0x2832420", VA = "0x182833020")]
				internal int YLEIZFFRCGT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0x2833420", Offset = "0x2832820", VA = "0x182833420")]
				internal void YLJPWLZOLSC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2833890", Offset = "0x2832C90", VA = "0x182833890")]
				internal int YLOWTSTLVDL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2832BA0", Offset = "0x2831FA0", VA = "0x182832BA0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> YKEAMXKEHCA(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2832410", Offset = "0x2831810", VA = "0x182832410")]
				internal int PVIMSEXQRLQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x2832950", Offset = "0x2831D50", VA = "0x182832950")]
				internal void WRIPBXQBYDA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x28329E0", Offset = "0x2831DE0", VA = "0x1828329E0")]
				internal int WRNVZEJZHOJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x2832870", Offset = "0x2831C70", VA = "0x182832870")]
				internal void WQYBHKCHFGI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x2832900", Offset = "0x2831D00", VA = "0x182832900")]
				internal int WRDIEQWEORR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2832AC0", Offset = "0x2831EC0", VA = "0x182832AC0")]
				internal void WSDQQYRRJWK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2832B50", Offset = "0x2831F50", VA = "0x182832B50")]
				internal int WSIXOFLOTHT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2832A30", Offset = "0x2831E30", VA = "0x182832A30")]
				internal void WRTCWLDWQZS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2832CA0", Offset = "0x28320A0", VA = "0x182832CA0")]
				internal float YKJHKEEBQNJ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x2832CF0", Offset = "0x28320F0", VA = "0x182832CF0")]
				internal void YKOOHKXYZYS(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x2832D80", Offset = "0x2832180", VA = "0x182832D80")]
				internal float YKTVERRWJKB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x2833A90", Offset = "0x2832E90", VA = "0x182833A90")]
				internal void YMPFGAOYQIE(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x2833B20", Offset = "0x2832F20", VA = "0x182833B20")]
				internal bool YMUMDHIVZTN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x28327E0", Offset = "0x2831BE0", VA = "0x1828327E0")]
				internal void PXDWTNUSYJT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2832790", Offset = "0x2831B90", VA = "0x182832790")]
				internal int PWYPWHAVOYK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2832700", Offset = "0x2831B00", VA = "0x182832700")]
				internal void PWTIZAGYFNB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x28326B0", Offset = "0x2831AB0", VA = "0x1828326B0")]
				internal float PWOCBTNAWBS()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2832620", Offset = "0x2831A20", VA = "0x182832620")]
				internal void PWIVEMTDMQJ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x28325D0", Offset = "0x28319D0", VA = "0x1828325D0")]
				internal float PWDOHFZGDFA()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2832540", Offset = "0x2831940", VA = "0x182832540")]
				internal void PVYHJZFITTR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x28324F0", Offset = "0x28318F0", VA = "0x1828324F0")]
				internal bool PVTAMSLLKII()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2832460", Offset = "0x2831860", VA = "0x182832460")]
				internal void PVNTPLROAWZ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x284A470", Offset = "0x2849870", VA = "0x18284A470")]
			public YEPUTORLTUY(AUQKPBYPMDP a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2849380", Offset = "0x2848780", VA = "0x182849380", Slot = "145")]
			protected sealed override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class ZDIFNKINVJN : MIRWKZWWRTI<RecNetImageNode>
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
				public ZDIFNKINVJN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004F9")]
				[Cpp2IlInjected.Address(RVA = "0x2846050", Offset = "0x2845450", VA = "0x182846050", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FA")]
				[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x284AA20", Offset = "0x2849E20", VA = "0x18284AA20")]
			public ZDIFNKINVJN(AUQKPBYPMDP a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x284A550", Offset = "0x2849950", VA = "0x18284A550", Slot = "151")]
			protected override void MKVXEIQGUZT(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x284A950", Offset = "0x2849D50", VA = "0x18284A950")]
			[CompilerGenerated]
			private string? ZHXZZMPFYDP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x284A880", Offset = "0x2849C80", VA = "0x18284A880")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void ZHSTCFVIOSG(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class UUKNZKPGMLL<a> : NWBVHBZMQLQ<a> where a : notnull, AXDLFWBSFPF
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class AZSYQXSOVDR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> UUGHOKSAZVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public UUKNZKPGMLL<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> NAMJXHXJWPK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> BHRMYLCCZFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType AVFPDZFBDTO;

				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public AZSYQXSOVDR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000500")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> YKZCBYLTSVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0x550B220", Offset = "0x550A620", VA = "0x18550B220")]
				internal int YLEIZFFRCGT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0x550B340", Offset = "0x550A740", VA = "0x18550B340")]
				internal void YLJPWLZOLSC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x550B530", Offset = "0x550A930", VA = "0x18550B530")]
				internal void YLOWTSTLVDL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x550B060", Offset = "0x550A460", VA = "0x18550B060")]
				internal void YKEAMXKEHCA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x550B170", Offset = "0x550A570", VA = "0x18550B170")]
				internal bool YKJHKEEBQNJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x550B1D0", Offset = "0x550A5D0", VA = "0x18550B1D0")]
				internal void YKOOHKXYZYS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x550B170", Offset = "0x550A570", VA = "0x18550B170")]
				internal bool YKTVERRWJKB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x550B580", Offset = "0x550A980", VA = "0x18550B580")]
				internal float YMPFGAOYQIE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x550B5B0", Offset = "0x550A9B0", VA = "0x18550B5B0")]
				internal void YMUMDHIVZTN(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x550B030", Offset = "0x550A430", VA = "0x18550B030")]
				internal float PXDWTNUSYJT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x550AFA0", Offset = "0x550A3A0", VA = "0x18550AFA0")]
				internal void PWYPWHAVOYK(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x550AF70", Offset = "0x550A370", VA = "0x18550AF70")]
				internal float PWTIZAGYFNB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x550AEE0", Offset = "0x550A2E0", VA = "0x18550AEE0")]
				internal void PWOCBTNAWBS(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType EDAUFZUQIPI
			{
				[Cpp2IlInjected.Token(Token = "0x60004FD")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x4F44FD0", Offset = "0x4F443D0", VA = "0x184F44FD0")]
			public UUKNZKPGMLL(AUQKPBYPMDP a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x6134F90", Offset = "0x6134390", VA = "0x186134F90", Slot = "145")]
			protected sealed override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class CSBVWLNTAGP : NWBVHBZMQLQ<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0xC192F0", Offset = "0xC186F0", VA = "0x180C192F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x282FD30", Offset = "0x282F130", VA = "0x18282FD30")]
			public CSBVWLNTAGP(AUQKPBYPMDP a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class SFWILHMEMJG : MWEJJDZKACY<PJIAMLIPYFQ>
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x283CA80", Offset = "0x283BE80", VA = "0x18283CA80")]
			public SFWILHMEMJG(AUQKPBYPMDP a, PJIAMLIPYFQ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class FMGGFCCNUUM : MWEJJDZKACY<KLQGNTZBNDJ>
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2830720", Offset = "0x282FB20", VA = "0x182830720")]
			public FMGGFCCNUUM(AUQKPBYPMDP a, KLQGNTZBNDJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class MWEJJDZKACY<a> : NWBVHBZMQLQ<a> where a : notnull, ZKYIIPGTJVS
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
				public MWEJJDZKACY<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051A")]
				[Cpp2IlInjected.Address(RVA = "0x3CB5F60", Offset = "0x3CB5360", VA = "0x183CB5F60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051B")]
				[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class YYSAOGCWSFC
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
					public YYSAOGCWSFC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052B")]
					[Cpp2IlInjected.Address(RVA = "0x3CB4C60", Offset = "0x3CB4060", VA = "0x183CB4C60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052C")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public YYSAOGCWSFC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x3CB5030", Offset = "0x3CB4430", VA = "0x183CB5030", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public YYSAOGCWSFC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x3CB56E0", Offset = "0x3CB4AE0", VA = "0x183CB56E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public YYSAOGCWSFC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x3CB5C70", Offset = "0x3CB5070", VA = "0x183CB5C70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int LJHVHRDBFNE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry GVCVZBFJZBQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public MWEJJDZKACY<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<HRQTZSPCIJP, bool> HNETSZSMSYR;

				[Cpp2IlInjected.Token(Token = "0x6000520")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public YYSAOGCWSFC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000521")]
				[Cpp2IlInjected.Address(RVA = "0x3E7E960", Offset = "0x3E7DD60", VA = "0x183E7E960")]
				internal bool YLOWTSTLVDL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0x3E7E720", Offset = "0x3E7DB20", VA = "0x183E7E720")]
				internal void YKEAMXKEHCA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
				internal string YKJHKEEBQNJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x3E7E790", Offset = "0x3E7DB90", VA = "0x183E7E790")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.YYSAOGCWSFC.<<BuildConfigMenuInternal>b__6>d))]
				internal void YKOOHKXYZYS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0x3E7E850", Offset = "0x3E7DC50", VA = "0x183E7E850")]
				internal int YKTVERRWJKB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x3E7E5A0", Offset = "0x3E7D9A0", VA = "0x183E7E5A0")]
				internal bool PWOCBTNAWBS(HRQTZSPCIJP a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x3E7E9C0", Offset = "0x3E7DDC0", VA = "0x183E7E9C0")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.YYSAOGCWSFC.<<BuildConfigMenuInternal>b__8>d))]
				internal void YMPFGAOYQIE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
				internal string PXDWTNUSYJT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x3E7E660", Offset = "0x3E7DA60", VA = "0x183E7E660")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.YYSAOGCWSFC.<<BuildConfigMenuInternal>b__11>d))]
				internal void PWYPWHAVOYK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0x3E7E5C0", Offset = "0x3E7D9C0", VA = "0x183E7E5C0")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.YYSAOGCWSFC.<<BuildConfigMenuInternal>b__12>d))]
				internal void PWTIZAGYFNB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class UMOAHPPLSQX
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000563")]
					[Cpp2IlInjected.Address(RVA = "0x3CAF060", Offset = "0x3CAE460", VA = "0x183CAF060", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000564")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x3CAF3E0", Offset = "0x3CAE7E0", VA = "0x183CAF3E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x3CAF7B0", Offset = "0x3CAEBB0", VA = "0x183CAF7B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x3CAFD80", Offset = "0x3CAF180", VA = "0x183CAFD80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x3CB0010", Offset = "0x3CAF410", VA = "0x183CB0010", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x3CB03A0", Offset = "0x3CAF7A0", VA = "0x183CB03A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x3CB0730", Offset = "0x3CAFB30", VA = "0x183CB0730", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x3CB09C0", Offset = "0x3CAFDC0", VA = "0x183CB09C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x3CB0D50", Offset = "0x3CB0150", VA = "0x183CB0D50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x3CB10E0", Offset = "0x3CB04E0", VA = "0x183CB10E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x3CB1460", Offset = "0x3CB0860", VA = "0x183CB1460", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x3CB16F0", Offset = "0x3CB0AF0", VA = "0x183CB16F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x3CB1A80", Offset = "0x3CB0E80", VA = "0x183CB1A80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x3CB1D10", Offset = "0x3CB1110", VA = "0x183CB1D10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x3CB20A0", Offset = "0x3CB14A0", VA = "0x183CB20A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x3CB2420", Offset = "0x3CB1820", VA = "0x183CB2420", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
					public UMOAHPPLSQX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x3CB27A0", Offset = "0x3CB1BA0", VA = "0x183CB27A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public MWEJJDZKACY<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int LJHVHRDBFNE;

				[Cpp2IlInjected.Token(Token = "0x6000533")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UMOAHPPLSQX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000534")]
				[Cpp2IlInjected.Address(RVA = "0x612FAB0", Offset = "0x612EEB0", VA = "0x18612FAB0")]
				internal bool WTDAVKZGRPU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0x612FB10", Offset = "0x612EF10", VA = "0x18612FB10")]
				internal void WTIHSRTEBBD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x612ED20", Offset = "0x612E120", VA = "0x18612ED20")]
				internal object LBIIQJJYJXP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x612EC60", Offset = "0x612E060", VA = "0x18612EC60")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__13>d))]
				internal void LBDBTCQBAMG(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x612EE80", Offset = "0x612E280", VA = "0x18612EE80")]
				internal string LBSWKWXTCUH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x612EDC0", Offset = "0x612E1C0", VA = "0x18612EDC0")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__15>d))]
				internal void LBNPNQDVTIY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x612EFB0", Offset = "0x612E3B0", VA = "0x18612EFB0")]
				internal bool LCDKFKLNVQZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x612EF20", Offset = "0x612E320", VA = "0x18612EF20")]
				internal bool LBYDIDRQMFQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x612F0E0", Offset = "0x612E4E0", VA = "0x18612F0E0")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__18>d))]
				internal void LCNXZXZIONR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x612F030", Offset = "0x612E430", VA = "0x18612F030")]
				internal int LCIRCRFLFCI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x612F2D0", Offset = "0x612E6D0", VA = "0x18612F2D0")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__20>d))]
				internal void RFIRDJJPXTG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x612F380", Offset = "0x612E780", VA = "0x18612F380")]
				internal bool RFNYAQDNHEP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x612F410", Offset = "0x612E810", VA = "0x18612F410")]
				internal float RFTEXWXKQPY()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x612F4C0", Offset = "0x612E8C0", VA = "0x18612F4C0")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__23>d))]
				internal void RFYLVDRIABH(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x612F570", Offset = "0x612E970", VA = "0x18612F570")]
				internal bool RGDSSKLFJMQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x612F600", Offset = "0x612EA00", VA = "0x18612F600")]
				internal bool RGIZPRFCSXZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x612F690", Offset = "0x612EA90", VA = "0x18612F690")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__26>d))]
				internal void RGOGMXZACJI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x612F740", Offset = "0x612EB40", VA = "0x18612F740")]
				internal int RGTNKESXLUR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x612F190", Offset = "0x612E590", VA = "0x18612F190")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__28>d))]
				internal void RDSNZHGLAGM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x612F240", Offset = "0x612E640", VA = "0x18612F240")]
				internal bool RDXUWOAIJRV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x61300E0", Offset = "0x612F4E0", VA = "0x1861300E0")]
				internal float YFZWCBRSNLP()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x6130030", Offset = "0x612F430", VA = "0x186130030")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__31>d))]
				internal void YFUPEUXVEAG(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x612FFA0", Offset = "0x612F3A0", VA = "0x18612FFA0")]
				internal bool YFPIHODXUOX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x612FF20", Offset = "0x612F320", VA = "0x18612FF20")]
				internal bool YFKBKHKALDO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x6130340", Offset = "0x612F740", VA = "0x186130340")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__34>d))]
				internal void YGUXRCTHZEZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x61302B0", Offset = "0x612F6B0", VA = "0x1861302B0")]
				internal bool YGPQTVZKPTQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x6130220", Offset = "0x612F620", VA = "0x186130220")]
				internal bool YGKJWPFNGIH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x6130170", Offset = "0x612F570", VA = "0x186130170")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__37>d))]
				internal void YGFCZILPWWY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x612FE90", Offset = "0x612F290", VA = "0x18612FE90")]
				internal int YEJSXZONPYV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x612FDE0", Offset = "0x612F1E0", VA = "0x18612FDE0")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__39>d))]
				internal void YEEMASUQGNM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x612CF00", Offset = "0x612C300", VA = "0x18612CF00")]
				internal bool GCXJRYULMDY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x612CF90", Offset = "0x612C390", VA = "0x18612CF90")]
				internal float GDCQPFOIVPH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x612CDC0", Offset = "0x612C1C0", VA = "0x18612CDC0")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__42>d))]
				internal void GCMVXLGQTHG(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x612CE70", Offset = "0x612C270", VA = "0x18612CE70")]
				internal bool GCSCUSAOCSP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x612D0B0", Offset = "0x612C4B0", VA = "0x18612D0B0")]
				internal bool GDSLGZWAXXI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x612D130", Offset = "0x612C530", VA = "0x18612D130")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__45>d))]
				internal void GDXSEGPYHIR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x612D020", Offset = "0x612C420", VA = "0x18612D020")]
				internal bool GDHXMMIGFAQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x612F970", Offset = "0x612ED70", VA = "0x18612F970")]
				internal bool WSSNAXLLYTC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x612FA00", Offset = "0x612EE00", VA = "0x18612FA00")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__3>d))]
				internal void WSXTYEFJIEL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x612FCA0", Offset = "0x612F0A0", VA = "0x18612FCA0")]
				internal int WTYCKMAWDJE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x612FD30", Offset = "0x612F130", VA = "0x18612FD30")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__5>d))]
				internal void WUDJHSUTMUN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x612FB80", Offset = "0x612EF80", VA = "0x18612FB80")]
				internal bool WTNOPYNBKMM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x612FC10", Offset = "0x612F010", VA = "0x18612FC10")]
				internal bool WTSVNFGYTXV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x612F820", Offset = "0x612EC20", VA = "0x18612F820")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__8>d))]
				internal void WRMXRIWBUDA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x612F8D0", Offset = "0x612ECD0", VA = "0x18612F8D0")]
				internal int WRSEOPPZDOJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x612EBB0", Offset = "0x612DFB0", VA = "0x18612EBB0")]
				[AsyncStateMachine(typeof(MWEJJDZKACY<>.UMOAHPPLSQX.<<AddConstraintOptions>b__10>d))]
				internal void LAXUVVWDRAX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x612EB20", Offset = "0x612DF20", VA = "0x18612EB20")]
				internal bool LASNYPCGHPO()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> BXKZYTDQXEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> WDJXSIPUHCD;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000514")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<HRQTZSPCIJP> FAHUMRTBSWB
			{
				[Cpp2IlInjected.Token(Token = "0x6000515")]
				[Cpp2IlInjected.Address(RVA = "0x57DD5B0", Offset = "0x57DC9B0", VA = "0x1857DD5B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x57DD600", Offset = "0x57DCA00", VA = "0x1857DD600")]
			public MWEJJDZKACY(AUQKPBYPMDP a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x57DAD30", Offset = "0x57DA130", VA = "0x1857DAD30", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x57DC5A0", Offset = "0x57DB9A0", VA = "0x1857DC5A0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x57DADE0", Offset = "0x57DA1E0", VA = "0x1857DADE0")]
			private PPQWGBSFXBL JSEBGNEBAYE(THQFFICRKST a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x57DC4A0", Offset = "0x57DB8A0", VA = "0x1857DC4A0")]
			[AsyncStateMachine(typeof(MWEJJDZKACY<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void QRWLRJSAPKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x57DC540", Offset = "0x57DB940", VA = "0x1857DC540")]
			[CompilerGenerated]
			private bool QSMGJDZSRSB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class WBZINASTWVC : NWBVHBZMQLQ<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class OFEBALTHFAS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public WBZINASTWVC MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x600058A")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public OFEBALTHFAS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058B")]
				[Cpp2IlInjected.Address(RVA = "0x2836140", Offset = "0x2835540", VA = "0x182836140")]
				internal int YLEIZFFRCGT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0x2836280", Offset = "0x2835680", VA = "0x182836280")]
				internal void YLJPWLZOLSC(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? QDGXCRFXJDL;

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x2847D00", Offset = "0x2847100", VA = "0x182847D00")]
			public WBZINASTWVC(AUQKPBYPMDP a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x28479B0", Offset = "0x2846DB0", VA = "0x1828479B0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class DMZBGIFDQXO : UUKNZKPGMLL<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType EDAUFZUQIPI
			{
				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x2830100", Offset = "0x282F500", VA = "0x182830100")]
			public DMZBGIFDQXO(AUQKPBYPMDP a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class OZNUJDEDJDJ : DAZJVKPPUTH<WIDPXMYYGVS>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600058F")]
				[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x2836E90", Offset = "0x2836290", VA = "0x182836E90")]
			public OZNUJDEDJDJ(AUQKPBYPMDP a, WIDPXMYYGVS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class KCBVQCEUSLE : DAZJVKPPUTH<PCNXWTTHQAL>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000592")]
				[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x2833CE0", Offset = "0x28330E0", VA = "0x182833CE0")]
			public KCBVQCEUSLE(AUQKPBYPMDP a, PCNXWTTHQAL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class FMTRWOBSHHE : MIRWKZWWRTI<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
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
					public SYKSUEBHFID <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000599")]
					[Cpp2IlInjected.Address(RVA = "0x2845D40", Offset = "0x2845140", VA = "0x182845D40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059A")]
					[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public FMTRWOBSHHE MXVWDMPVVWS;

				[Cpp2IlInjected.Token(Token = "0x6000597")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000598")]
				[Cpp2IlInjected.Address(RVA = "0x283E440", Offset = "0x283D840", VA = "0x18283E440")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void LZLUEZDNBTL(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2830A80", Offset = "0x282FE80", VA = "0x182830A80")]
			public FMTRWOBSHHE(AUQKPBYPMDP a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x2830780", Offset = "0x282FB80", VA = "0x182830780", Slot = "151")]
			protected override void MKVXEIQGUZT(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class UQQUVUOEPCR : UUKNZKPGMLL<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType EDAUFZUQIPI
			{
				[Cpp2IlInjected.Token(Token = "0x600059C")]
				[Cpp2IlInjected.Address(RVA = "0xB411C0", Offset = "0xB405C0", VA = "0x180B411C0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x28476E0", Offset = "0x2846AE0", VA = "0x1828476E0")]
			public UQQUVUOEPCR(AUQKPBYPMDP a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class RMPTBRCQCGA : NWBVHBZMQLQ<JFIHTVJBYAI>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059D")]
				[Cpp2IlInjected.Address(RVA = "0xC120B0", Offset = "0xC114B0", VA = "0x180C120B0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x283C250", Offset = "0x283B650", VA = "0x18283C250")]
			public RMPTBRCQCGA(AUQKPBYPMDP a, JFIHTVJBYAI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class NLVYFCFWEYX : NWBVHBZMQLQ<EBQPYQFDZIU>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A0")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A1")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool JZQXASCFDXE
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x28357D0", Offset = "0x2834BD0", VA = "0x1828357D0")]
			public NLVYFCFWEYX(AUQKPBYPMDP a, EBQPYQFDZIU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x28354C0", Offset = "0x28348C0", VA = "0x1828354C0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2835410", Offset = "0x2834810", VA = "0x182835410")]
			private int NTOMHOMDOFR()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x2835450", Offset = "0x2834850", VA = "0x182835450")]
			private void UKXDEDFVPNB(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class PNVYAVNNRPQ : ZKKQLZTLUSN
		{
			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x283C1E0", Offset = "0x283B5E0", VA = "0x18283C1E0")]
			public PNVYAVNNRPQ(AUQKPBYPMDP a, CFDTQFFCTZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class SVPXQLIZDAM : NWBVHBZMQLQ<AVWOPWNSWBP>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class JLSEUHBSZCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public SVPXQLIZDAM MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public JLSEUHBSZCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AD")]
				[Cpp2IlInjected.Address(RVA = "0x2832E20", Offset = "0x2832220", VA = "0x182832E20")]
				internal int YKZCBYLTSVK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0x2833190", Offset = "0x2832590", VA = "0x182833190")]
				internal void YLEIZFFRCGT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x2833840", Offset = "0x2832C40", VA = "0x182833840")]
				internal int YLJPWLZOLSC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x28339F0", Offset = "0x2832DF0", VA = "0x1828339F0")]
				internal void YLOWTSTLVDL(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AA")]
				[Cpp2IlInjected.Address(RVA = "0xFC4710", Offset = "0xFC3B10", VA = "0x180FC4710", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x283E170", Offset = "0x283D570", VA = "0x18283E170")]
			public SVPXQLIZDAM(AUQKPBYPMDP a, AVWOPWNSWBP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x283DE60", Offset = "0x283D260", VA = "0x18283DE60", Slot = "145")]
			protected sealed override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class NHAUNNMJQSJ : MIRWKZWWRTI<NHZZKWVADUC>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x28353B0", Offset = "0x28347B0", VA = "0x1828353B0")]
			public NHAUNNMJQSJ(AUQKPBYPMDP a, NHZZKWVADUC b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class MIRWKZWWRTI<a> : NWBVHBZMQLQ<a> where a : notnull, NHZZKWVADUC
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class EOXEHAWLLLA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public MIRWKZWWRTI<a> MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.Token(Token = "0x60005B9")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public EOXEHAWLLLA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BA")]
				[Cpp2IlInjected.Address(RVA = "0x476FE40", Offset = "0x476F240", VA = "0x18476FE40")]
				internal bool YKZCBYLTSVK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0x476FE70", Offset = "0x476F270", VA = "0x18476FE70")]
				internal void YLEIZFFRCGT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x476FF00", Offset = "0x476F300", VA = "0x18476FF00")]
				internal bool YLJPWLZOLSC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x476FF30", Offset = "0x476F330", VA = "0x18476FF30")]
				internal void YLOWTSTLVDL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x476FD50", Offset = "0x476F150", VA = "0x18476FD50")]
				internal bool YKEAMXKEHCA()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class ACTEAKJALWV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public RWPWJSQETXX YIQQPGKCDDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public MIRWKZWWRTI<a> MXVWDMPVVWS;

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public ACTEAKJALWV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x5476CE0", Offset = "0x54760E0", VA = "0x185476CE0")]
				internal void LZLUEZDNBTL(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0xB4EDA0", Offset = "0xB4E1A0", VA = "0x180B4EDA0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x57D2070", Offset = "0x57D1470", VA = "0x1857D2070", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x57D1F60", Offset = "0x57D1360", VA = "0x1857D1F60")]
			protected MIRWKZWWRTI(AUQKPBYPMDP a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x57D1840", Offset = "0x57D0C40", VA = "0x1857D1840", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x57D1BF0", Offset = "0x57D0FF0", VA = "0x1857D1BF0", Slot = "145")]
			protected override void XKFCZTAPEEO(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x57D1930", Offset = "0x57D0D30", VA = "0x1857D1930", Slot = "151")]
			protected virtual void MKVXEIQGUZT(THQFFICRKST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x57D1BB0", Offset = "0x57D0FB0", VA = "0x1857D1BB0", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x282D610", Offset = "0x282CA10", VA = "0x18282D610")]
		public static COLFGFXWPZV New(AUQKPBYPMDP circuitsManager, CFDTQFFCTZU node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class FSEDRVFEGAF : TJAZIGGQZMH, WNDBIVWVRJA, GSJOVJNHIEE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<DTGDQHKOFYM> ACAQGDHYVHG
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xBF7910", Offset = "0xBF6D10", VA = "0x180BF7910", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<DTGDQHKOFYM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<CSVKPDHJMYA> YLHXGNKJMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x14DE830", Offset = "0x14DDC30", VA = "0x1814DE830", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<CSVKPDHJMYA>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x204FD10", Offset = "0x204F110", VA = "0x18204FD10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<GLLQVRJNTAT> WUAAHOGKRYX
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x1143E50", Offset = "0x1143250", VA = "0x181143E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<KRAHEPMHAQK> ZBEYMOAJLJD
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x2831100", Offset = "0x2830500", VA = "0x182831100", Slot = "22")]
			get
			{
				return default(Id32<KRAHEPMHAQK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x2831150", Offset = "0x2830550", VA = "0x182831150")]
		private FSEDRVFEGAF(AUQKPBYPMDP a, CFDTQFFCTZU b, HSEFZQIPYSE c, Id32<RWZXBCGZCJT> portGroupId, Id32<CSVKPDHJMYA> outputId, Id32<GLLQVRJNTAT> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x2830DB0", Offset = "0x28301B0", VA = "0x182830DB0")]
		public static FSEDRVFEGAF New(AUQKPBYPMDP circuitsManager, CFDTQFFCTZU node, HSEFZQIPYSE output, Id32<RWZXBCGZCJT> portGroupId, Id32<GLLQVRJNTAT> outputDefId, Id32<CSVKPDHJMYA> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x204FD10", Offset = "0x204F110", VA = "0x18204FD10")]
		internal void IVLKJAGVUFR(Id32<CSVKPDHJMYA> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class TJAZIGGQZMH : GSJOVJNHIEE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private LGHGGKCJVJH? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x2835310", Offset = "0x2834710", VA = "0x182835310")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x2835320", Offset = "0x2834720", VA = "0x182835320")]
			public LGHGGKCJVJH UHZHKZRQIRP(TJAZIGGQZMH a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly AUQKPBYPMDP XBAZNGQYGJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly CFDTQFFCTZU MCVFAAMBCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter BTRSJGZPVDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly QYVIVRRUPZO YEIOXAAFNTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<DTOFFHJUYXO> CYCZQINQEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<WSWNBTBOZNY> QPHKBWIPDDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool BKCHMFBZZUZ;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> MEMLVSRYSYD
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x283FE50", Offset = "0x283F250", VA = "0x18283FE50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind KGAJGQEJPSW
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F80", Offset = "0xAC1380", VA = "0x180AC1F80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<HUXETNCTSFJ> IYXGXTJGXSL
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x283FDE0", Offset = "0x283F1E0", VA = "0x18283FDE0", Slot = "6")]
			get
			{
				return default(Id32<HUXETNCTSFJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<HUXETNCTSFJ> LQMRHYERQZA
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x283FA90", Offset = "0x283EE90", VA = "0x18283FA90", Slot = "7")]
			get
			{
				return default(Id128<HUXETNCTSFJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public HRQTZSPCIJP CYNMABYEHEQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x283FF90", Offset = "0x283F390", VA = "0x18283FF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public TECTNCZKXAX LJKQNJFIXKF
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x283FD50", Offset = "0x283F150", VA = "0x18283FD50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected LGHGGKCJVJH FHXTDFYACSI
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x283FD50", Offset = "0x283F150", VA = "0x18283FD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage TWZUOHKPCXI
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2840950", Offset = "0x283FD50", VA = "0x182840950", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<FRZIQAPUPIV> BEIJNFCVCJG
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x283FE10", Offset = "0x283F210", VA = "0x18283FE10", Slot = "9")]
			get
			{
				return default(Id128<FRZIQAPUPIV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<RWZXBCGZCJT> VBJCZPUUPYB
		{
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xBB86C0", Offset = "0xBB7AC0", VA = "0x180BB86C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<RWZXBCGZCJT>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x175B160", Offset = "0x175A560", VA = "0x18175B160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<KRAHEPMHAQK> ZBEYMOAJLJD
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool NDIETIRHCQG
		{
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0xC6B720", Offset = "0xC6AB20", VA = "0x180C6B720", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x2840F90", Offset = "0x2840390", VA = "0x182840F90")]
		protected TJAZIGGQZMH(AUQKPBYPMDP a, CFDTQFFCTZU b, QYVIVRRUPZO c, Id32<RWZXBCGZCJT> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x283FAC0", Offset = "0x283EEC0", VA = "0x18283FAC0", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x283F8F0", Offset = "0x283ECF0", VA = "0x18283F8F0", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2840060", Offset = "0x283F460", VA = "0x182840060", Slot = "14")]
		public void TSUVJWAYBHH(DTOFFHJUYXO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x283FFB0", Offset = "0x283F3B0", VA = "0x18283FFB0", Slot = "15")]
		public void TSDSLZNFILV(WSWNBTBOZNY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2840C70", Offset = "0x2840070", VA = "0x182840C70")]
		private bool ZVLVBRTGFDY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2840110", Offset = "0x283F510", VA = "0x182840110", Slot = "17")]
		public void VFDLUMKFNCB(FANNPLWXHAQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x283F9D0", Offset = "0x283EDD0", VA = "0x18283F9D0", Slot = "25")]
		protected virtual void FGNIGDQSKZJ(FANNPLWXHAQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2840AF0", Offset = "0x283FEF0", VA = "0x182840AF0", Slot = "20")]
		private void XSDCTBQBXQA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x283FBA0", Offset = "0x283EFA0", VA = "0x18283FBA0")]
		private void KMMYQNLGPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x283F750", Offset = "0x283EB50", VA = "0x18283F750")]
		private void CPCAPHRZLPN([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2840A90", Offset = "0x283FE90", VA = "0x182840A90", Slot = "18")]
		public void XCPQQPQSAYS(DTOFFHJUYXO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x283FA30", Offset = "0x283EE30", VA = "0x18283FA30", Slot = "19")]
		public void HEFEGBVEKSE(WSWNBTBOZNY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
		internal void OYFWCEJLJHD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x283FE30", Offset = "0x283F230", VA = "0x18283FE30")]
		internal void QDVAAXUUKJE(IAPPTVDTDES a, HRQTZSPCIJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x175B160", Offset = "0x175A560", VA = "0x18175B160")]
		internal void LFSJSSGLWMN(Id32<RWZXBCGZCJT> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class PNTWOAKYAEO : ZIUCYVLLCOL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class VURSCFIWQPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public AUQKPBYPMDP LCZXFXKCJWV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public CFDTQFFCTZU QMXJVPYWNHQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<RWZXBCGZCJT> OQKYHSYTTKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool YFTNRCXOUEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool RZEABSEIYRD;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public VURSCFIWQPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x2847800", Offset = "0x2846C00", VA = "0x182847800")]
			internal VOIRXGKTOAQ WEURIKLAWFQ((int PortDescIndex, int PortIndex, NDPFPWUWSWZ InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x28478E0", Offset = "0x2846CE0", VA = "0x1828478E0")]
			internal FSEDRVFEGAF WEZYFREYFQZ(HSEFZQIPYSE a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x28415E0", Offset = "0x28409E0", VA = "0x1828415E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2841A50", Offset = "0x2840E50", VA = "0x182841A50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<KRQTPWZEGQG> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x2842D00", Offset = "0x2842100", VA = "0x182842D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x2843050", Offset = "0x2842450", VA = "0x182843050", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x28430C0", Offset = "0x28424C0", VA = "0x1828430C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2843540", Offset = "0x2842940", VA = "0x182843540", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<GLLQVRJNTAT> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x28435B0", Offset = "0x28429B0", VA = "0x1828435B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x2843900", Offset = "0x2842D00", VA = "0x182843900", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2844130", Offset = "0x2843530", VA = "0x182844130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x2844480", Offset = "0x2843880", VA = "0x182844480", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<KRQTPWZEGQG> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x2843970", Offset = "0x2842D70", VA = "0x182843970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x2843CE0", Offset = "0x28430E0", VA = "0x182843CE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<GLLQVRJNTAT> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x2843D50", Offset = "0x2843150", VA = "0x182843D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x28440C0", Offset = "0x28434C0", VA = "0x1828440C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public CAMZTXWHAYG type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<KRQTPWZEGQG> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x28444F0", Offset = "0x28438F0", VA = "0x1828444F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x2844890", Offset = "0x2843C90", VA = "0x182844890", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public CAMZTXWHAYG type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<GLLQVRJNTAT> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2844900", Offset = "0x2843D00", VA = "0x182844900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2844CA0", Offset = "0x28440A0", VA = "0x182844CA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<KRQTPWZEGQG> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<KRQTPWZEGQG> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2844D10", Offset = "0x2844110", VA = "0x182844D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x2845070", Offset = "0x2844470", VA = "0x182845070", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public PNTWOAKYAEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<GLLQVRJNTAT> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<GLLQVRJNTAT> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private WTTLBDSHSXM <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x28450E0", Offset = "0x28444E0", VA = "0x1828450E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x2845440", Offset = "0x2844840", VA = "0x182845440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool XEXXQHUZOZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly AUQKPBYPMDP XBAZNGQYGJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool QIRBRQZJSDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<IFNWILEMGJH, VOIRXGKTOAQ> MJXQEIWTVUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<IFNWILEMGJH, KNHDWBMZHLX> CHGXBBQMTGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly CFDTQFFCTZU MCVFAAMBCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<CSVKPDHJMYA, FSEDRVFEGAF> NZRGWYQKJBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<CSVKPDHJMYA, WNDBIVWVRJA> CLOHFXMAIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? HHRVDLDCDYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly LIRLSAHGKSB EYMRENBULVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<RWZXBCGZCJT> ISKOKGZAZHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool TUVKIGZIHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? TDBRCVFOSMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? LUOVOQIBFCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<IFNWILEMGJH>>? EVYHGFQUWOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<CSVKPDHJMYA>>? YTVXUOWWVJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private ZIUCYVLLCOL.PortGroupIdChangeDelegate? AYTVRWSBWZA;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool WSWYSCUPLYW
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x2838740", Offset = "0x2837B40", VA = "0x182838740", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool KHUKDNNWTZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x2838ED0", Offset = "0x28382D0", VA = "0x182838ED0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool XXLVVJAHOAR
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2837340", Offset = "0x2836740", VA = "0x182837340", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<HUXETNCTSFJ> LQMRHYERQZA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2838A10", Offset = "0x2837E10", VA = "0x182838A10", Slot = "7")]
			get
			{
				return default(Id128<HUXETNCTSFJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool WGEDCURXDOL
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x283B4A0", Offset = "0x283A8A0", VA = "0x18283B4A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<IFNWILEMGJH, KNHDWBMZHLX> XHMKLXSAGRR
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<IFNWILEMGJH, KNHDWBMZHLX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2837020", Offset = "0x2836420", VA = "0x182837020", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<FRZIQAPUPIV> BEIJNFCVCJG
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x283AA70", Offset = "0x2839E70", VA = "0x18283AA70", Slot = "11")]
			get
			{
				return default(Id128<FRZIQAPUPIV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<CSVKPDHJMYA, WNDBIVWVRJA> RLNCNQDAKCA
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<CSVKPDHJMYA, WNDBIVWVRJA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<RWZXBCGZCJT> VBJCZPUUPYB
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0xC473A0", Offset = "0xC467A0", VA = "0x180C473A0", Slot = "13")]
			get
			{
				return default(Id32<RWZXBCGZCJT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? FBCWEMWXEIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x2839530", Offset = "0x2838930", VA = "0x182839530", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x28385C0", Offset = "0x28379C0", VA = "0x1828385C0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? UYFOULGGPTQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x283B750", Offset = "0x283AB50", VA = "0x18283B750", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2837850", Offset = "0x2836C50", VA = "0x182837850", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<IFNWILEMGJH?>, Id32<IFNWILEMGJH?>>? EVAPLDJHWAV
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x283AB50", Offset = "0x2839F50", VA = "0x18283AB50", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x28395D0", Offset = "0x28389D0", VA = "0x1828395D0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<IFNWILEMGJH?>, Id32<IFNWILEMGJH?>>? FVDHVQQFFXA
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x28371C0", Offset = "0x28365C0", VA = "0x1828371C0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x283BEA0", Offset = "0x283B2A0", VA = "0x18283BEA0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<CSVKPDHJMYA?>, Id32<CSVKPDHJMYA?>>? GGDJLYCXIHS
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x2838240", Offset = "0x2837640", VA = "0x182838240", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x283BF60", Offset = "0x283B360", VA = "0x18283BF60", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<CSVKPDHJMYA?>, Id32<CSVKPDHJMYA?>>? IDXHBRJSZEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2838800", Offset = "0x2837C00", VA = "0x182838800", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2836F60", Offset = "0x2836360", VA = "0x182836F60", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<IFNWILEMGJH?>, KNHDWBMZHLX?>? UFTPIUEUHNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x28388C0", Offset = "0x2837CC0", VA = "0x1828388C0", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x283C020", Offset = "0x283B420", VA = "0x18283C020", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<IFNWILEMGJH?>>? NTRMFKEZZLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2838F10", Offset = "0x2838310", VA = "0x182838F10", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2839B10", Offset = "0x2838F10", VA = "0x182839B10", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<IFNWILEMGJH?>, KNHDWBMZHLX?>? SASETLBJDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x2838500", Offset = "0x2837900", VA = "0x182838500", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x283B3C0", Offset = "0x283A7C0", VA = "0x18283B3C0", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<CSVKPDHJMYA?>, WNDBIVWVRJA?>? XUVWIPZJTYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2838680", Offset = "0x2837A80", VA = "0x182838680", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2837280", Offset = "0x2836680", VA = "0x182837280", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<CSVKPDHJMYA?>>? MQGQVFOVTNE
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x283AA90", Offset = "0x2839E90", VA = "0x18283AA90", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2838E10", Offset = "0x2838210", VA = "0x182838E10", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<CSVKPDHJMYA?>, WNDBIVWVRJA?>? RNAGPGPQMYF
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2838FD0", Offset = "0x28383D0", VA = "0x182838FD0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2839800", Offset = "0x2838C00", VA = "0x182839800", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x283C0E0", Offset = "0x283B4E0", VA = "0x18283C0E0")]
		private PNTWOAKYAEO(bool a, AUQKPBYPMDP b, bool c, ReadOnlyIdArray<IFNWILEMGJH, VOIRXGKTOAQ> inputs, ReadOnlyIdArray<IFNWILEMGJH, KNHDWBMZHLX> inputsAsStaticInputs, CFDTQFFCTZU d, ReadOnlyIdArray<CSVKPDHJMYA, FSEDRVFEGAF> outputs, ReadOnlyIdArray<CSVKPDHJMYA, WNDBIVWVRJA> outputsAsStaticOutputs, string? overrideName, LIRLSAHGKSB e, Id32<RWZXBCGZCJT> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x283A3E0", Offset = "0x28397E0", VA = "0x18283A3E0")]
		public static PNTWOAKYAEO New(bool canInteract, AUQKPBYPMDP circuitsManager, bool hasFunctionHeader, CFDTQFFCTZU node, LIRLSAHGKSB portGroup, Id32<RWZXBCGZCJT> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2837EC0", Offset = "0x28372C0", VA = "0x182837EC0", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2838410", Offset = "0x2837810", VA = "0x182838410", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, RAGLFGQXJZI?>>? FPLZNGBCOFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x283BC70", Offset = "0x283B070", VA = "0x18283BC70")]
		private (ELVDVGZXELN?, int)? YLEOXSIEKGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x283AC10", Offset = "0x283A010", VA = "0x18283AC10", Slot = "58")]
		private void QLEUQWXGKVS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2050", Offset = "0x1FE1450", VA = "0x181FE2050", Slot = "57")]
		private void EGVLPVUIJUD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x283AEE0", Offset = "0x283A2E0", VA = "0x18283AEE0", Slot = "61")]
		private void RZWWSJGOLSB(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x283AE50", Offset = "0x283A250", VA = "0x18283AE50", Slot = "63")]
		private void RYUBFREZDYI(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2839BD0", Offset = "0x2838FD0", VA = "0x182839BD0", Slot = "50")]
		private void NKKHGUUZCUD(int a, Id32<IFNWILEMGJH> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x283A930", Offset = "0x2839D30", VA = "0x18283A930", Slot = "54")]
		private void OABTOEYXATK(int a, Id32<IFNWILEMGJH> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x283B480", Offset = "0x283A880", VA = "0x18283B480", Slot = "49")]
		private void TTJPSAWQPIG(int a, Id32<IFNWILEMGJH> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2837400", Offset = "0x2836800", VA = "0x182837400", Slot = "53")]
		private void CHXPIDQZEZJ(int a, Id32<IFNWILEMGJH> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2837050", Offset = "0x2836450", VA = "0x182837050", Slot = "66")]
		private void AZLVAZNZMMH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0xDE98C0", Offset = "0xDE8CC0", VA = "0x180DE98C0", Slot = "65")]
		private void NNXSSRPYVPS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x283B520", Offset = "0x283A920", VA = "0x18283B520", Slot = "60")]
		private void UPICWIRPOML(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2050", Offset = "0x1FE1450", VA = "0x181FE2050", Slot = "59")]
		private void LAWIZVUZULM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2838A40", Offset = "0x2837E40", VA = "0x182838A40", Slot = "62")]
		private void JBFVWQATAGE(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x2838980", Offset = "0x2837D80", VA = "0x182838980", Slot = "64")]
		private void IRFXBLCQKTF(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2837920", Offset = "0x2836D20", VA = "0x182837920", Slot = "52")]
		private void DOHBKSDJFPY(int a, Id32<CSVKPDHJMYA> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2837900", Offset = "0x2836D00", VA = "0x182837900", Slot = "56")]
		private void DAPUDDJNQYL(int a, Id32<CSVKPDHJMYA> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2838660", Offset = "0x2837A60", VA = "0x182838660", Slot = "51")]
		private void GQPBHYFZPGZ(int a, Id32<CSVKPDHJMYA> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x283B800", Offset = "0x283AC00", VA = "0x18283B800", Slot = "55")]
		private void XMDUDYGXAMG(int a, Id32<CSVKPDHJMYA> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2839690", Offset = "0x2838A90", VA = "0x182839690", Slot = "68")]
		private void MBQISLECKJG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xDE98C0", Offset = "0xDE8CC0", VA = "0x180DE98C0", Slot = "67")]
		private void XQCQSINWPXP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2838300", Offset = "0x2837700", VA = "0x182838300", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, RAGLFGQXJZI?>>? FGRMLNYZFQJ(Id32<KRQTPWZEGQG> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x283B2B0", Offset = "0x283A6B0", VA = "0x18283B2B0", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, RAGLFGQXJZI?>>? SBSIRZKDBMW(Id32<GLLQVRJNTAT> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x283A950", Offset = "0x2839D50", VA = "0x18283A950", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, RAGLFGQXJZI?>>? OVUBSAICFSP(Id32<KRQTPWZEGQG> inputDefId, Id32<KRQTPWZEGQG> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x28399F0", Offset = "0x2838DF0", VA = "0x1828399F0", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, RAGLFGQXJZI?>>? NEANSKLIEJI(Id32<GLLQVRJNTAT> outputDefId, Id32<GLLQVRJNTAT> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2839090", Offset = "0x2838490", VA = "0x182839090", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, RAGLFGQXJZI?>>? KZQGRFVATCZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x283B630", Offset = "0x283AA30", VA = "0x18283B630", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, RAGLFGQXJZI>> USVSUYBWVVC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x28398C0", Offset = "0x2838CC0", VA = "0x1828398C0", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, RAGLFGQXJZI>> MXEPZHDULUP(Id32<KRQTPWZEGQG> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x283A180", Offset = "0x2839580", VA = "0x18283A180", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, RAGLFGQXJZI>> NQXDMLLSFXS(Id32<GLLQVRJNTAT> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x283A2B0", Offset = "0x28396B0", VA = "0x18283A2B0", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, RAGLFGQXJZI>> NUGPCSAPFUM(Id32<KRQTPWZEGQG> inputDefId, CAMZTXWHAYG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x283AD20", Offset = "0x283A120", VA = "0x18283AD20", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, RAGLFGQXJZI>> RVXUPACWHFP(Id32<GLLQVRJNTAT> outputDefId, CAMZTXWHAYG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2839180", Offset = "0x2838580", VA = "0x182839180")]
		internal void LFSJSSGLWMN(Id32<RWZXBCGZCJT> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class HGEHYAJDPNG : LBNGUKJCJSD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface ALXXNXZFOSL
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<HUXETNCTSFJ>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065D")]
				[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<HUXETNCTSFJ>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			IAPPTVDTDES IAPPTVDTDES
			{
				[Cpp2IlInjected.Token(Token = "0x6000656")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> XHPKFUKJHMH(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> DYOLREEIOFA(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<IMMUYPZLBKK> AWRRCUBWSVH(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<YVWXGRBPFFE> SWZRLXEUJNM(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> KASVNQHQLQP(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> CYLWWOXDRGC(CancellationToken a);
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
			public AsyncTaskMethodBuilder<HGEHYAJDPNG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public AUQKPBYPMDP circuitsManager;

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
			private ALXXNXZFOSL <selfDeps>5__2;

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
			private IMMUYPZLBKK <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private YVWXGRBPFFE <playerSaveData>5__8;

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
			private TaskAwaiter<IMMUYPZLBKK> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<YVWXGRBPFFE> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<ALXXNXZFOSL.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<MCGUTYIFENK> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x2841AC0", Offset = "0x2840EC0", VA = "0x182841AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x2842C90", Offset = "0x2842090", VA = "0x182842C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public MCGUTYIFENK MCGUTYIFENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public YWMJZOGYJLI YWMJZOGYJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public XOHXLDGYZGH XOHXLDGYZGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public ETIPBFENWNV ETIPBFENWNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xE213F0", Offset = "0xE207F0", VA = "0x180E213F0")]
		private HGEHYAJDPNG(MCGUTYIFENK a, YWMJZOGYJLI b, XOHXLDGYZGH c, ETIPBFENWNV d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x28318B0", Offset = "0x2830CB0", VA = "0x1828318B0")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<HGEHYAJDPNG> GYKMYAHPPVB(AUQKPBYPMDP a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x2831890", Offset = "0x2830C90", VA = "0x182831890", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class WJICPLMKAMU : NKMPTCHVIDV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly AUQKPBYPMDP XBAZNGQYGJY;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public EWLZMGNRPPO? LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2847DE0", Offset = "0x28471E0", VA = "0x182847DE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		internal WJICPLMKAMU(AUQKPBYPMDP a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class XOHXLDGYZGH : EWLZMGNRPPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly AUQKPBYPMDP XBAZNGQYGJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly MCGUTYIFENK ALQLHMYZNSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly WJICPLMKAMU KJNDIOHICTH;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> YLKZOUFEMHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x2848920", Offset = "0x2847D20", VA = "0x182848920", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xD92220", Offset = "0xD91620", VA = "0x180D92220")]
		public XOHXLDGYZGH(AUQKPBYPMDP a, MCGUTYIFENK b, WJICPLMKAMU c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x2848960", Offset = "0x2847D60", VA = "0x182848960", Slot = "5")]
		public string PLNXNVHYOKJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x28488C0", Offset = "0x2847CC0", VA = "0x1828488C0", Slot = "6")]
		public void DFRJEEEQPBO(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x2858DE0", Offset = "0x28581E0", VA = "0x182858DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x2859020", Offset = "0x2858420", VA = "0x182859020", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, RAGLFGQXJZI>> <>t__builder;

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
			private VLXCXCSSZAI[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2859830", Offset = "0x2858C30", VA = "0x182859830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2859C00", Offset = "0x2859000", VA = "0x182859C00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public VLXCXCSSZAI action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x285DF30", Offset = "0x285D330", VA = "0x18285DF30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x285E3B0", Offset = "0x285D7B0", VA = "0x18285E3B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly ZVRVTWCRUTF _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
		public EVRequestExtended(ZVRVTWCRUTF staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x28305F0", Offset = "0x282F9F0", VA = "0x1828305F0")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, RAGLFGQXJZI>> IGVOWTPJRQX(VLXCXCSSZAI a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2830490", Offset = "0x282F890", VA = "0x182830490")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, RAGLFGQXJZI?>>? GQOWSUPQVPW(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x28303A0", Offset = "0x282F7A0", VA = "0x1828303A0")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, RAGLFGQXJZI>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface GNWDQRYJEFF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		LBNGUKJCJSD? LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool FTNBLRPOGMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool PTDGGKWCEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<LBNGUKJCJSD?>? JVDKCQIIKOL();

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task MTRORTTHKXC(AUQKPBYPMDP a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface LBNGUKJCJSD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		MCGUTYIFENK MCGUTYIFENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		YWMJZOGYJLI YWMJZOGYJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		XOHXLDGYZGH XOHXLDGYZGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		ETIPBFENWNV ETIPBFENWNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class VZWSWGSWLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x285EBA0", Offset = "0x285DFA0", VA = "0x18285EBA0")]
		public static ReducerFactory<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP, RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>> IRNLNVHTGZH([In] this ReducerFactory<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP, RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP, RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class VTSDFFBTWFZ : ZIDJAMSNONC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly AUQKPBYPMDP XBAZNGQYGJY;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool PTDGGKWCEEK
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x285EB80", Offset = "0x285DF80", VA = "0x18285EB80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		internal VTSDFFBTWFZ(AUQKPBYPMDP a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class ZZFOJFXVFUA : GYJOBUSAVKZ
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x285F550", Offset = "0x285E950", VA = "0x18285F550", Slot = "4")]
		public GSNJULYUHGX? NLYKRNJOVNC(string? a, string? b, string? c, RoomDoorData.NQYZCTZVWIX.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x285F5E0", Offset = "0x285E9E0", VA = "0x18285F5E0", Slot = "5")]
		public JTBLQFEYHKH PWULLZNDPHU(string a, string b, List<string> c, int d, int e, int f, int g, QPONHYVFMCT h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x285F4B0", Offset = "0x285E8B0", VA = "0x18285F4B0", Slot = "6")]
		public QPONHYVFMCT ANQEGWQGCPG(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ZZFOJFXVFUA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class EXUBBYSPYXO : JBIKIRFDWLV
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
			public AsyncTaskMethodBuilder<KXJXLLGOBKY> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public EXUBBYSPYXO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<LBNGUKJCJSD?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x2859090", Offset = "0x2858490", VA = "0x182859090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x2859330", Offset = "0x2858730", VA = "0x182859330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly AUQKPBYPMDP XBAZNGQYGJY;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public KXJXLLGOBKY? LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x2853A00", Offset = "0x2852E00", VA = "0x182853A00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public ETIPBFENWNV? HJDYCRHKPZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x2853980", Offset = "0x2852D80", VA = "0x182853980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool VUNNBNURAEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x2853AE0", Offset = "0x2852EE0", VA = "0x182853AE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool SUQXDYFGOCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2853A80", Offset = "0x2852E80", VA = "0x182853A80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x2853EF0", Offset = "0x28532F0", VA = "0x182853EF0")]
		internal EXUBBYSPYXO(AUQKPBYPMDP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x2853890", Offset = "0x2852C90", VA = "0x182853890", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<KXJXLLGOBKY> JVDKCQIIKOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2853B70", Offset = "0x2852F70", VA = "0x182853B70", Slot = "9")]
		public IReadOnlyDictionary<Id128<HUXETNCTSFJ>, Guid> YAQEYECIQUD(IEnumerable<BMALMPEIUXS> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2853540", Offset = "0x2852940", VA = "0x182853540", Slot = "10")]
		public CircuitGraphToolMappingRegistryData BINKQVYAEFV(IEnumerable<BMALMPEIUXS> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x28536C0", Offset = "0x2852AC0", VA = "0x1828536C0")]
		public Result<CircuitsRoomData, XOJOHOBKPDS> HALSXJWXZPV([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, XOJOHOBKPDS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2853B40", Offset = "0x2852F40", VA = "0x182853B40", Slot = "8")]
		private Result<CircuitsRoomData, XOJOHOBKPDS> XTFUZSJQXWO([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, XOJOHOBKPDS>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class ETIPBFENWNV : KXJXLLGOBKY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class JQFIIIMHIPE
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class SYKSUEBHFID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int QVHWJGKRSRL;

				[Cpp2IlInjected.Token(Token = "0x6000716")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public SYKSUEBHFID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000717")]
				[Cpp2IlInjected.Address(RVA = "0x2858600", Offset = "0x2857A00", VA = "0x182858600")]
				internal void INPDRUTDMTG(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x2855C50", Offset = "0x2855050", VA = "0x182855C50")]
			public static Result<KXJXLLGOBKY.PrepareTemplateForCloneResult, RMWBTSSRSGR> ZCWYKYGUMCT(ETIPBFENWNV a, [In] KXJXLLGOBKY.PrepareTemplateForCloneArgs args)
			{
				return default(Result<KXJXLLGOBKY.PrepareTemplateForCloneResult, RMWBTSSRSGR>);
			}

			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x2854F20", Offset = "0x2854320", VA = "0x182854F20")]
			internal static Result<(RJGPGVVKARG, CircuitTemplateRootData), RMWBTSSRSGR> WUQRQJGXZVP(ETIPBFENWNV a, CircuitTemplateRootData b, bool c, [In] Id128<HUXETNCTSFJ> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(RJGPGVVKARG, CircuitTemplateRootData), RMWBTSSRSGR>);
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x2854A90", Offset = "0x2853E90", VA = "0x182854A90")]
			private static void VJBPJDPLBML(bool a, BMALMPEIUXS b, RJGPGVVKARG c, [In] Id128<HUXETNCTSFJ> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x28540C0", Offset = "0x28534C0", VA = "0x1828540C0")]
			public static void HVBEHXQJJEM(ZOWXJLETAIT a, [In] KXJXLLGOBKY.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x28544D0", Offset = "0x28538D0", VA = "0x1828544D0")]
			[CompilerGenerated]
			internal static bool TOQHKPOQLHL(MCGUTYIFENK a, GVCZGRMKSXF b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2854A60", Offset = "0x2853E60", VA = "0x182854A60")]
			[CompilerGenerated]
			internal static bool TRLLEPTNGYA(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class EEFUJHIGLNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public ETIPBFENWNV MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<HUXETNCTSFJ> TGFTGXOEAWY;

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EEFUJHIGLNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x284BA20", Offset = "0x284AE20", VA = "0x18284BA20")]
			internal Id128<FRZIQAPUPIV> JCPZPZSPSLJ(Id32<FRZIQAPUPIV> a)
			{
				return default(Id128<FRZIQAPUPIV>);
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<DTGDQHKOFYM> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<AINMIFOSACL> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x2859C70", Offset = "0x2859070", VA = "0x182859C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x285A240", Offset = "0x2859640", VA = "0x18285A240", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<FRZIQAPUPIV> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<RWZXBCGZCJT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<KRQTPWZEGQG> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x285A2B0", Offset = "0x28596B0", VA = "0x18285A2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x285A600", Offset = "0x2859A00", VA = "0x18285A600", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<FRZIQAPUPIV>, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<FHMKUSQVKNG> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private MCGUTYIFENK <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x285A950", Offset = "0x2859D50", VA = "0x18285A950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x285AD80", Offset = "0x285A180", VA = "0x18285AD80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<FRZIQAPUPIV> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x285A670", Offset = "0x2859A70", VA = "0x18285A670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x285A8E0", Offset = "0x2859CE0", VA = "0x18285A8E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x285ADF0", Offset = "0x285A1F0", VA = "0x18285ADF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x285AFE0", Offset = "0x285A3E0", VA = "0x18285AFE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<HUXETNCTSFJ> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<FRZIQAPUPIV> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<FRZIQAPUPIV>> nodeIds;

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
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x285B050", Offset = "0x285A450", VA = "0x18285B050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x285B2F0", Offset = "0x285A6F0", VA = "0x18285B2F0", Slot = "5")]
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
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<HUXETNCTSFJ> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<FRZIQAPUPIV> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<FRZIQAPUPIV>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<RWZXBCGZCJT>, Id32<IFNWILEMGJH>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<RWZXBCGZCJT>, Id32<CSVKPDHJMYA>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x285B360", Offset = "0x285A760", VA = "0x18285B360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x285B940", Offset = "0x285AD40", VA = "0x18285B940", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<HUXETNCTSFJ> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<FRZIQAPUPIV> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<FRZIQAPUPIV>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x285B9A0", Offset = "0x285ADA0", VA = "0x18285B9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x285BBB0", Offset = "0x285AFB0", VA = "0x18285BBB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<FRZIQAPUPIV> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<RWZXBCGZCJT> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<IFNWILEMGJH> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x285BC20", Offset = "0x285B020", VA = "0x18285BC20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x285BF70", Offset = "0x285B370", VA = "0x18285BF70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<FRZIQAPUPIV> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<RWZXBCGZCJT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<KRQTPWZEGQG> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x285BFE0", Offset = "0x285B3E0", VA = "0x18285BFE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x285C3C0", Offset = "0x285B7C0", VA = "0x18285C3C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<FRZIQAPUPIV> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x285C430", Offset = "0x285B830", VA = "0x18285C430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x285C6B0", Offset = "0x285BAB0", VA = "0x18285C6B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<FRZIQAPUPIV> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<RWZXBCGZCJT> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<CSVKPDHJMYA> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x285C720", Offset = "0x285BB20", VA = "0x18285C720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x285CA70", Offset = "0x285BE70", VA = "0x18285CA70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<FRZIQAPUPIV> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x285CAE0", Offset = "0x285BEE0", VA = "0x18285CAE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x285CE20", Offset = "0x285C220", VA = "0x18285CE20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<FRZIQAPUPIV> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x285CE90", Offset = "0x285C290", VA = "0x18285CE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x285D120", Offset = "0x285C520", VA = "0x18285D120", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<FRZIQAPUPIV> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x285D190", Offset = "0x285C590", VA = "0x18285D190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x285D420", Offset = "0x285C820", VA = "0x18285D420", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<FRZIQAPUPIV>>, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<HUXETNCTSFJ> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<BMALMPEIUXS> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<CFDTQFFCTZU>, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x285D490", Offset = "0x285C890", VA = "0x18285D490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x285DC30", Offset = "0x285D030", VA = "0x18285DC30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<HUXETNCTSFJ> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<FRZIQAPUPIV> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<FRZIQAPUPIV>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x285DCA0", Offset = "0x285D0A0", VA = "0x18285DCA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x285DEC0", Offset = "0x285D2C0", VA = "0x18285DEC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public ETIPBFENWNV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<HUXETNCTSFJ> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<FRZIQAPUPIV> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x285E420", Offset = "0x285D820", VA = "0x18285E420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x285E640", Offset = "0x285DA40", VA = "0x18285E640", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly AUQKPBYPMDP XBAZNGQYGJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly MCGUTYIFENK ALQLHMYZNSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers YRYKBPMZLYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly EXUBBYSPYXO XBIOAJUQNYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<FRZIQAPUPIV>, COLFGFXWPZV> UFMFPGJVFYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<FRZIQAPUPIV>>? KSLPEBPYGGP;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<HUXETNCTSFJ> CWZJEIENEIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x284BEB0", Offset = "0x284B2B0", VA = "0x18284BEB0", Slot = "4")]
			get
			{
				return default(Id128<HUXETNCTSFJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers JNMPKVJQMUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x284EEF0", Offset = "0x284E2F0", VA = "0x18284EEF0", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> PVNCXHBDEIS
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x284FB40", Offset = "0x284EF40", VA = "0x18284FB40", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action VNPHMCUHBSF
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x284F700", Offset = "0x284EB00", VA = "0x18284F700", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x284C850", Offset = "0x284BC50", VA = "0x18284C850", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> GEXZQWLRDIL
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x284DB80", Offset = "0x284CF80", VA = "0x18284DB80", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x284F050", Offset = "0x284E450", VA = "0x18284F050", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x28530E0", Offset = "0x28524E0", VA = "0x1828530E0")]
		public ETIPBFENWNV(AUQKPBYPMDP a, MCGUTYIFENK b, EXUBBYSPYXO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x284C7B0", Offset = "0x284BBB0", VA = "0x18284C7B0", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x284F860", Offset = "0x284EC60", VA = "0x18284F860", Slot = "100")]
		public Id32<LYGICQJVUFL> PNDHOSIJWVM(Id32<HUXETNCTSFJ> graphId, Id32<AINMIFOSACL> inputId)
		{
			return default(Id32<LYGICQJVUFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2850870", Offset = "0x284FC70", VA = "0x182850870", Slot = "101")]
		public Id32<NOOKDCCCOLW> QLOHJWCVSLH(Id32<HUXETNCTSFJ> graphId, Id32<DTGDQHKOFYM> outputId)
		{
			return default(Id32<NOOKDCCCOLW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2852A00", Offset = "0x2851E00", VA = "0x182852A00", Slot = "6")]
		public (bool, bool) YBRTPHMZWFI(Id32<HUXETNCTSFJ> graphId, Id32<DTGDQHKOFYM> srcId, Id32<AINMIFOSACL> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x284CCE0", Offset = "0x284C0E0", VA = "0x18284CCE0")]
		public bool GKSVJCZUMCD(Id32<HUXETNCTSFJ> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x284BE30", Offset = "0x284B230", VA = "0x18284BE30", Slot = "8")]
		public bool AMUKAHNGXST(KNHDWBMZHLX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x284FA90", Offset = "0x284EE90", VA = "0x18284FA90", Slot = "9")]
		public bool QBUSBQMUHVM(WNDBIVWVRJA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x284C750", Offset = "0x284BB50", VA = "0x18284C750", Slot = "10")]
		public AbsoluteLegacyInputId? DPPHMYUQJLT(Id32<HUXETNCTSFJ> graphId, Id32<AINMIFOSACL> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2850920", Offset = "0x284FD20", VA = "0x182850920", Slot = "11")]
		public AbsoluteLegacyOutputId? QRAUKNHOFII(Id32<HUXETNCTSFJ> graphId, Id32<DTGDQHKOFYM> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x284C720", Offset = "0x284BB20", VA = "0x18284C720", Slot = "12")]
		public Id32<DTGDQHKOFYM>? DKSUQXSAOXI(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId, Id32<CSVKPDHJMYA> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2851EF0", Offset = "0x28512F0", VA = "0x182851EF0", Slot = "13")]
		public Id32<AINMIFOSACL>? WIMVKEGMMAT(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId, Id32<IFNWILEMGJH> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x284D160", Offset = "0x284C560", VA = "0x18284D160", Slot = "14")]
		public IEnumerable<Id32<HUXETNCTSFJ>> HNHRZJXTWKT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2850890", Offset = "0x284FC90", VA = "0x182850890", Slot = "15")]
		public IEnumerable<Id32<DNHEAGZQCWR>> QLOPTEVGHRK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x284C650", Offset = "0x284BA50", VA = "0x18284C650", Slot = "22")]
		public string CXQELFUZBLG(Id32<DNHEAGZQCWR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x284D1D0", Offset = "0x284C5D0", VA = "0x18284D1D0", Slot = "16")]
		public Id32<DNHEAGZQCWR>? HOKBOEPSPMQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x284F840", Offset = "0x284EC40", VA = "0x18284F840", Slot = "17")]
		public int PHBDPDUWVTH(Id32<DNHEAGZQCWR> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x284CFE0", Offset = "0x284C3E0", VA = "0x18284CFE0", Slot = "18")]
		public int GODYZRHQOVU(Id32<DNHEAGZQCWR> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2851F50", Offset = "0x2851350", VA = "0x182851F50", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] WKNSLBOXUZB(Id32<DNHEAGZQCWR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x284F170", Offset = "0x284E570", VA = "0x18284F170", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] NEDFRQOBRWU(Id32<DNHEAGZQCWR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x35603F0", Offset = "0x355F7F0", VA = "0x1835603F0")]
		private static (CircuitTypeIdWrapper, string?)[]? VWBQUBXXXOF<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x2851EC0", Offset = "0x28512C0", VA = "0x182851EC0", Slot = "21")]
		public string VWTYKWBSVPO(Id32<DNHEAGZQCWR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x284CA10", Offset = "0x284BE10", VA = "0x18284CA10", Slot = "23")]
		public string FIUYLOHECLX(Id32<DNHEAGZQCWR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x284EAF0", Offset = "0x284DEF0", VA = "0x18284EAF0")]
		public COLFGFXWPZV? LDITQJSASGC([In] Id128<FRZIQAPUPIV> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2850980", Offset = "0x284FD80", VA = "0x182850980", Slot = "30")]
		public Id32<FHMKUSQVKNG> QVRXQQRFEQQ(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId)
		{
			return default(Id32<FHMKUSQVKNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x284F810", Offset = "0x284EC10", VA = "0x18284F810")]
		public Id32<FRZIQAPUPIV> PGZEFDGSMNJ(Id32<HUXETNCTSFJ> graphId, [In] Id128<FRZIQAPUPIV> legacyNodeId)
		{
			return default(Id32<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2851B20", Offset = "0x2850F20", VA = "0x182851B20", Slot = "40")]
		public Id32<FRZIQAPUPIV> TTSPEYBDGVO(Id32<HUXETNCTSFJ> graphId, Id32<AINMIFOSACL> inputId)
		{
			return default(Id32<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x284EAB0", Offset = "0x284DEB0", VA = "0x18284EAB0", Slot = "41")]
		public Id32<FRZIQAPUPIV> KJUCUVSXKPR(Id32<HUXETNCTSFJ> graphId, Id32<DTGDQHKOFYM> outputId)
		{
			return default(Id32<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x284FB10", Offset = "0x284EF10", VA = "0x18284FB10")]
		public Id32<FRZIQAPUPIV>? QDHJBMHAHWT(Id32<HUXETNCTSFJ> graphId, [In] Id128<FRZIQAPUPIV> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x284C910", Offset = "0x284BD10", VA = "0x18284C910", Slot = "32")]
		public AbsoluteNodeId? ETBWXJYLFWZ(Id32<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x284D140", Offset = "0x284C540", VA = "0x18284D140", Slot = "33")]
		public long GYBEZQCUTHE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2850BB0", Offset = "0x284FFB0", VA = "0x182850BB0")]
		private void RFTEBWKSMRY(Id128<FRZIQAPUPIV> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x284E340", Offset = "0x284D740", VA = "0x18284E340", Slot = "38")]
		public IEnumerable<(Id32<HUXETNCTSFJ>, Id32<FRZIQAPUPIV>)> JTYKHRJLBJG(Id32<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2851F20", Offset = "0x2851320", VA = "0x182851F20", Slot = "39")]
		public Id32<AINMIFOSACL> WIMVKEGMMAT(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<LYGICQJVUFL> inputIndex)
		{
			return default(Id32<AINMIFOSACL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x284C6F0", Offset = "0x284BAF0", VA = "0x18284C6F0", Slot = "42")]
		public Id32<DTGDQHKOFYM> DKSUQXSAOXI(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<NOOKDCCCOLW> outputIndex)
		{
			return default(Id32<DTGDQHKOFYM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x284CB00", Offset = "0x284BF00", VA = "0x18284CB00")]
		private COLFGFXWPZV? FUBOVMWPFEF([In] Id128<FRZIQAPUPIV> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x28506F0", Offset = "0x284FAF0", VA = "0x1828506F0")]
		public CFDTQFFCTZU? QKEPOJBYWNV([In] Id128<FRZIQAPUPIV> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x284D490", Offset = "0x284C890", VA = "0x18284D490")]
		public SMYDLSZQBNT? QVURZHOTUNI([In] Id128<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x28509A0", Offset = "0x284FDA0", VA = "0x1828509A0", Slot = "25")]
		public SMYDLSZQBNT? QVURZHOTUNI(Id32<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x284C870", Offset = "0x284BC70", VA = "0x18284C870", Slot = "34")]
		public IEnumerable<NewStaticEdge> EPRIPBLCPYW(Id32<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2851AC0", Offset = "0x2850EC0", VA = "0x182851AC0", Slot = "35")]
		public bool TMPWPKAHLUO(Id32<DNHEAGZQCWR> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x284D930", Offset = "0x284CD30", VA = "0x18284D930", Slot = "36")]
		public IEnumerable<StableStaticEdge> JGVHZWRHHIC(Id32<HUXETNCTSFJ> graphId, Id32<DTGDQHKOFYM> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2852650", Offset = "0x2851A50", VA = "0x182852650", Slot = "37")]
		public IEnumerable<StableStaticEdge> XFVAXMDHDXL(Id32<HUXETNCTSFJ> graphId, Id32<AINMIFOSACL> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x284DC90", Offset = "0x284D090", VA = "0x18284DC90")]
		public Id32<HUXETNCTSFJ> JICNLYMHGZV([In] Id128<HUXETNCTSFJ> graphId)
		{
			return default(Id32<HUXETNCTSFJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x284BED0", Offset = "0x284B2D0", VA = "0x18284BED0")]
		public Id32<HUXETNCTSFJ>? BBBXPYBGNZJ([In] Id128<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2850C30", Offset = "0x2850030", VA = "0x182850C30")]
		private GVCZGRMKSXF? RSADVPQOUMF([In] Id128<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x284D490", Offset = "0x284C890", VA = "0x18284D490")]
		private SMYDLSZQBNT? HOYFXJGTRJW([In] Id128<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x284CBD0", Offset = "0x284BFD0", VA = "0x18284CBD0", Slot = "28")]
		public Id32<HUXETNCTSFJ>? GECYRAYXEXY(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x284F130", Offset = "0x284E530", VA = "0x18284F130", Slot = "46")]
		public Id128<HUXETNCTSFJ> MTPBKEQVMVU(Id32<HUXETNCTSFJ> graphId)
		{
			return default(Id128<HUXETNCTSFJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2850B90", Offset = "0x284FF90", VA = "0x182850B90", Slot = "47")]
		public Id128<FRZIQAPUPIV> RDRQAZRRBAQ(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId)
		{
			return default(Id128<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x284E9B0", Offset = "0x284DDB0", VA = "0x18284E9B0", Slot = "43")]
		public IEnumerable<CAMZTXWHAYG> KHYYELHLIAC(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2852350", Offset = "0x2851750", VA = "0x182852350", Slot = "44")]
		public CAMZTXWHAYG XDJOMPDVPXZ(RoomVersion a, GSJOVJNHIEE b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x284DBA0", Offset = "0x284CFA0", VA = "0x18284DBA0")]
		public NewStaticEdge QWBSUZAIDLD(Id32<HUXETNCTSFJ> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x284D000", Offset = "0x284C400", VA = "0x18284D000", Slot = "48")]
		public StableStaticEdge GRGAOTXVBAY(Id32<HUXETNCTSFJ> graphId, Id32<DTGDQHKOFYM> srcId, Id32<AINMIFOSACL> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x284F3F0", Offset = "0x284E7F0", VA = "0x18284F3F0", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, RAGLFGQXJZI>> NRMWMIGIIAF(Id32<HUXETNCTSFJ> parentGraphId, Id32<FRZIQAPUPIV> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x284F910", Offset = "0x284ED10", VA = "0x18284F910", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, RAGLFGQXJZI>> PYYEOHDCSCI(Id32<HUXETNCTSFJ> parentGraphId, Id128<FRZIQAPUPIV> boardNodeId, List<Id32<FRZIQAPUPIV>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x28505A0", Offset = "0x284F9A0", VA = "0x1828505A0", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, RAGLFGQXJZI>> QJJEONHGXOV(Id32<HUXETNCTSFJ> parentGraphId, Id128<FRZIQAPUPIV> boardNodeId, List<Id32<FRZIQAPUPIV>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x284EC20", Offset = "0x284E020", VA = "0x18284EC20", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, RAGLFGQXJZI>> LOVXALXORJB(Id32<HUXETNCTSFJ> parentGraphId, Id128<FRZIQAPUPIV> boardNodeId, Id32<HUXETNCTSFJ> graphId, List<Id32<FRZIQAPUPIV>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x284C4C0", Offset = "0x284B8C0", VA = "0x18284C4C0", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<RWZXBCGZCJT>, Id32<IFNWILEMGJH>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<RWZXBCGZCJT>, Id32<CSVKPDHJMYA>)>) CVSCRWPSZFK(Id128<HUXETNCTSFJ> legacyGraphId, Id32<FRZIQAPUPIV> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<RWZXBCGZCJT>, Id32<IFNWILEMGJH>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<RWZXBCGZCJT>, Id32<CSVKPDHJMYA>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x284EF00", Offset = "0x284E300", VA = "0x18284EF00", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task MKICHTPNYHE(Id128<HUXETNCTSFJ> legacyGraphId, Id128<FRZIQAPUPIV> boardNodeId, IReadOnlyList<Id128<FRZIQAPUPIV>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<RWZXBCGZCJT>, Id32<IFNWILEMGJH>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<RWZXBCGZCJT>, Id32<CSVKPDHJMYA>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x284BA60", Offset = "0x284AE60", VA = "0x18284BA60", Slot = "55")]
		public bool AEYMQLKSWBE(Id32<HUXETNCTSFJ> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x284DCC0", Offset = "0x284D0C0", VA = "0x18284DCC0", Slot = "56")]
		public bool JOYBLDIEJNM(Id32<HUXETNCTSFJ> graphId, Id32<AINMIFOSACL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x284F150", Offset = "0x284E550", VA = "0x18284F150", Slot = "57")]
		public bool NBIVYUDFYIP(Id32<HUXETNCTSFJ> graphId, Id32<DTGDQHKOFYM> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x284BA80", Offset = "0x284AE80", VA = "0x18284BA80")]
		public Result<KXJXLLGOBKY.PrepareTemplateForCloneResult, RMWBTSSRSGR> KDCIITEYNCL([In] KXJXLLGOBKY.PrepareTemplateForCloneArgs args)
		{
			return default(Result<KXJXLLGOBKY.PrepareTemplateForCloneResult, RMWBTSSRSGR>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x284F540", Offset = "0x284E940", VA = "0x18284F540", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, RAGLFGQXJZI>> NTRUVNOYBWP(Id32<HUXETNCTSFJ> graphId, Id32<DTGDQHKOFYM> srcId, Id32<AINMIFOSACL> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x28528A0", Offset = "0x2851CA0", VA = "0x1828528A0", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<FRZIQAPUPIV>, RAGLFGQXJZI>> XYOXMSJBYBQ(Id32<HUXETNCTSFJ> graphId, Id32<FHMKUSQVKNG> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x284BF20", Offset = "0x284B320", VA = "0x18284BF20", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> BJUJDPTTGBJ(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2851FD0", Offset = "0x28513D0", VA = "0x182851FD0", Slot = "62")]
		public Result<ControlPanelRootData, XOJOHOBKPDS> XCJDWPQGAVF(Id128<HUXETNCTSFJ> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, XOJOHOBKPDS>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2851B40", Offset = "0x2850F40", VA = "0x182851B40", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, RAGLFGQXJZI>> TXTRKEJMSTF(Id128<HUXETNCTSFJ> graphId, Id128<FRZIQAPUPIV> inputNodeId, Id32<RWZXBCGZCJT> inputPortGroupId, Id32<IFNWILEMGJH> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2851CA0", Offset = "0x28510A0", VA = "0x182851CA0", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, RAGLFGQXJZI>> UYKDDNOJZCG(Id128<HUXETNCTSFJ> graphId, Id128<FRZIQAPUPIV> outputNodeId, Id32<RWZXBCGZCJT> outputPortGroupId, Id32<CSVKPDHJMYA> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x284D4C0", Offset = "0x284C8C0", VA = "0x18284D4C0", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, RAGLFGQXJZI>> HTGTMCYFWNN(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2850E10", Offset = "0x2850210", VA = "0x182850E10", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<FRZIQAPUPIV>>, RAGLFGQXJZI>> RUXMZRXGEZO(Id128<HUXETNCTSFJ> intoGraphId, CircuitTemplateRootData a, IEnumerable<BMALMPEIUXS> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2850510", Offset = "0x284F910", VA = "0x182850510", Slot = "67")]
		public CircuitsData QJDPZRYWDZI()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x284F670", Offset = "0x284EA70", VA = "0x18284F670", Slot = "68")]
		public CircuitsData OCDJEKLSMXN()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x28509F0", Offset = "0x284FDF0", VA = "0x1828509F0", Slot = "71")]
		public CircuitsTemplateData RCHQLPBQINS(TemplateSerializationReason a, Id32<HUXETNCTSFJ> sourceGraphId, IEnumerable<Id128<HUXETNCTSFJ>> graphIds, IEnumerable<Id128<FRZIQAPUPIV>> nodeIds, ISet<Id128<OPTEWREDVNL>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x284F1D0", Offset = "0x284E5D0", VA = "0x18284F1D0")]
		private CircuitsTemplateData NLUHRJKYSKJ(TemplateSerializationReason a, Id32<HUXETNCTSFJ> sourceGraphId, IEnumerable<Id128<HUXETNCTSFJ>> graphIds, IEnumerable<Id128<FRZIQAPUPIV>> nodeIds, ISet<Id128<OPTEWREDVNL>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x284BBC0", Offset = "0x284AFC0", VA = "0x18284BBC0", Slot = "69")]
		public CircuitsTemplateData AGSIXDYLEID(TemplateSerializationReason a, Id32<HUXETNCTSFJ> sourceGraphId, IEnumerable<Id128<FRZIQAPUPIV>> nodeIds, IEnumerable<BMALMPEIUXS> b, ISet<Id128<OPTEWREDVNL>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x284BAB0", Offset = "0x284AEB0", VA = "0x18284BAB0", Slot = "70")]
		public CircuitsTemplateData AGSIXDYLEID(TemplateSerializationReason a, Id32<HUXETNCTSFJ> sourceGraphId, IEnumerable<Id32<FRZIQAPUPIV>> nodeIds, IEnumerable<BMALMPEIUXS> b, ISet<Id128<OPTEWREDVNL>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x284C0F0", Offset = "0x284B4F0", VA = "0x18284C0F0")]
		private static IEnumerable<Id128<HUXETNCTSFJ>> CGRHGDUJDLH(IEnumerable<BMALMPEIUXS> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x284E4B0", Offset = "0x284D8B0", VA = "0x18284E4B0")]
		private IEnumerable<Id128<FRZIQAPUPIV>> KBMZFUPCOBT(IEnumerable<BMALMPEIUXS> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2852FE0", Offset = "0x28523E0", VA = "0x182852FE0", Slot = "72")]
		public List<PHSOEICSIXG> ZFSGQEVMZPW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x284DCE0", Offset = "0x284D0E0", VA = "0x18284DCE0")]
		public (List<PHSOEICSIXG>, bool) JPGVORUVNUD([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, IONTNODDBKQ b, EXSBOVGLIDO c)
		{
			return default((List<PHSOEICSIXG>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x284F360", Offset = "0x284E760", VA = "0x18284F360", Slot = "74")]
		public bool NQEHDJKEVDM(Id32<HUXETNCTSFJ> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x284F880", Offset = "0x284EC80", VA = "0x18284F880", Slot = "75")]
		public bool PVGAQCHHYWU(Id32<HUXETNCTSFJ> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x284EAD0", Offset = "0x284DED0", VA = "0x18284EAD0")]
		internal void KYZJQMUAZXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2851FB0", Offset = "0x28513B0", VA = "0x182851FB0")]
		internal Task WMUFDCWBTGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x284FB60", Offset = "0x284EF60", VA = "0x18284FB60", Slot = "76")]
		public Result<Id32<DTGDQHKOFYM>?, RAGLFGQXJZI> QHIXBKSPTPF(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<AINMIFOSACL> inputId)
		{
			return default(Result<Id32<DTGDQHKOFYM>?, RAGLFGQXJZI>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x28510B0", Offset = "0x28504B0", VA = "0x1828510B0", Slot = "77")]
		public Result<Id32<AINMIFOSACL>?, RAGLFGQXJZI> SSLYONMCTNR(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<DTGDQHKOFYM> outputId)
		{
			return default(Result<Id32<AINMIFOSACL>?, RAGLFGQXJZI>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x284F720", Offset = "0x284EB20", VA = "0x18284F720", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, RAGLFGQXJZI>> OQHHRMXISLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2852EA0", Offset = "0x28522A0", VA = "0x182852EA0", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, RAGLFGQXJZI>> ZCNGLDHMBCK(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x284F070", Offset = "0x284E470", VA = "0x18284F070", Slot = "80")]
		public Id32<FRZIQAPUPIV>? MRLXMJTSPTC(Id32<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2851E00", Offset = "0x2851200", VA = "0x182851E00", Slot = "81")]
		public Id32<FRZIQAPUPIV>? VPAKTYDWITP(Id32<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x284C060", Offset = "0x284B460", VA = "0x18284C060", Slot = "82")]
		public int BUAJMHZKRTT(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x284CA30", Offset = "0x284BE30", VA = "0x18284CA30", Slot = "83")]
		public int FMZPPLALDUO(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x284D850", Offset = "0x284CC50", VA = "0x18284D850", Slot = "84")]
		public int IDNQPLLLIEX(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId, Id32<KRQTPWZEGQG> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x284E3D0", Offset = "0x284D7D0", VA = "0x18284E3D0", Slot = "85")]
		public int JVPUDHMXHIF(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId, Id32<KRQTPWZEGQG> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2850730", Offset = "0x284FB30", VA = "0x182850730", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, RAGLFGQXJZI>> QKNWVQTPQNL(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId, Id32<KRQTPWZEGQG> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2850F70", Offset = "0x2850370", VA = "0x182850F70", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, RAGLFGQXJZI>> RXPPXTDVWRU(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId, Id32<KRQTPWZEGQG> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2853020", Offset = "0x2852420", VA = "0x182853020", Slot = "88")]
		public int ZRSPWKFESQZ(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2850CD0", Offset = "0x28500D0", VA = "0x182850CD0", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, RAGLFGQXJZI>> RSKLDRGGZYP(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x284D5D0", Offset = "0x284C9D0", VA = "0x18284D5D0", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, RAGLFGQXJZI>> HYLIAGHCTKI(Id32<HUXETNCTSFJ> graphId, Id32<FRZIQAPUPIV> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x284ED80", Offset = "0x284E180", VA = "0x18284ED80", Slot = "91")]
		public bool LXRVALANESR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x284BF00", Offset = "0x284B300", VA = "0x18284BF00", Slot = "97")]
		public IEnumerable<Id32<OCNIJHVCKJR>> BEBQWRBMRBR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x284C630", Offset = "0x284BA30", VA = "0x18284C630", Slot = "98")]
		public string? CXIZCCKLWSD(Id32<OCNIJHVCKJR> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x284BE20", Offset = "0x284B220", VA = "0x18284BE20", Slot = "7")]
		private bool AJAWFVKYTMT(Id32<HUXETNCTSFJ> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x284D490", Offset = "0x284C890", VA = "0x18284D490", Slot = "24")]
		private SMYDLSZQBNT PTUROVOIXRM([In] Id128<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x284DC90", Offset = "0x284D090", VA = "0x18284DC90", Slot = "26")]
		private Id32<HUXETNCTSFJ> VNQVUTTIZZR([In] Id128<HUXETNCTSFJ> graphId)
		{
			return default(Id32<HUXETNCTSFJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x284BED0", Offset = "0x284B2D0", VA = "0x18284BED0", Slot = "27")]
		private Id32<HUXETNCTSFJ>? SHEZFBQPUOT([In] Id128<HUXETNCTSFJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x284D730", Offset = "0x284CB30", VA = "0x18284D730", Slot = "29")]
		private COLFGFXWPZV HZAWVZKJSKS([In] Id128<FRZIQAPUPIV> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x284F810", Offset = "0x284EC10", VA = "0x18284F810", Slot = "31")]
		private Id32<FRZIQAPUPIV> QGWZSDKKBPB(Id32<HUXETNCTSFJ> graphId, [In] Id128<FRZIQAPUPIV> legacyNodeId)
		{
			return default(Id32<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x284DBA0", Offset = "0x284CFA0", VA = "0x18284DBA0", Slot = "45")]
		private NewStaticEdge JHUWXRSVWSZ(Id32<HUXETNCTSFJ> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x284BA80", Offset = "0x284AE80", VA = "0x18284BA80", Slot = "58")]
		private Result<KXJXLLGOBKY.PrepareTemplateForCloneResult, RMWBTSSRSGR> AFXNXRWZQGP([In] KXJXLLGOBKY.PrepareTemplateForCloneArgs args)
		{
			return default(Result<KXJXLLGOBKY.PrepareTemplateForCloneResult, RMWBTSSRSGR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x284CB70", Offset = "0x284BF70", VA = "0x18284CB70", Slot = "73")]
		private (List<PHSOEICSIXG>, bool) FUGPNVLVUCL([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, IONTNODDBKQ b, EXSBOVGLIDO c)
		{
			return default((List<PHSOEICSIXG>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x284C680", Offset = "0x284BA80", VA = "0x18284C680")]
		[CompilerGenerated]
		private QVSSMHCEDRN DKJXUQACAYA(HRQTZSPCIJP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2851A60", Offset = "0x2850E60", VA = "0x182851A60")]
		[CompilerGenerated]
		private CFDTQFFCTZU THYGIWNHZKA(Id128<FRZIQAPUPIV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2851A90", Offset = "0x2850E90", VA = "0x182851A90")]
		[CompilerGenerated]
		private GVCZGRMKSXF TIDNGDHFIVJ(Id128<HUXETNCTSFJ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2851A60", Offset = "0x2850E60", VA = "0x182851A60")]
		[CompilerGenerated]
		private CFDTQFFCTZU XJZSPKZBGKU(Id128<FRZIQAPUPIV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2851A90", Offset = "0x2850E90", VA = "0x182851A90")]
		[CompilerGenerated]
		private GVCZGRMKSXF XKEZMRSYPWD(Id128<HUXETNCTSFJ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class QVSSMHCEDRN : CAMZTXWHAYG
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
			public AsyncTaskMethodBuilder<Result<Id32<KRQTPWZEGQG>, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public QVSSMHCEDRN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<FRZIQAPUPIV> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<RWZXBCGZCJT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<KRQTPWZEGQG>, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2858860", Offset = "0x2857C60", VA = "0x182858860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x2858AB0", Offset = "0x2857EB0", VA = "0x182858AB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<GLLQVRJNTAT>, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public QVSSMHCEDRN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<HUXETNCTSFJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<FRZIQAPUPIV> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<RWZXBCGZCJT> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<GLLQVRJNTAT>, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2858B20", Offset = "0x2857F20", VA = "0x182858B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2858D70", Offset = "0x2858170", VA = "0x182858D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly HRQTZSPCIJP VRWSDRLOZKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly MCGUTYIFENK ALQLHMYZNSU;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey DFZYAYUSTVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string HPJRLWCSRYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x28562F0", Offset = "0x28556F0", VA = "0x1828562F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public HRQTZSPCIJP HRQTZSPCIJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x2858560", Offset = "0x2857960", VA = "0x182858560")]
		public QVSSMHCEDRN(HRQTZSPCIJP a, MCGUTYIFENK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x28583F0", Offset = "0x28577F0", VA = "0x1828583F0", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<KRQTPWZEGQG>, RAGLFGQXJZI>> WSKCHOENEZQ(Id128<HUXETNCTSFJ> graphId, Id128<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2858280", Offset = "0x2857680", VA = "0x182858280", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<GLLQVRJNTAT>, RAGLFGQXJZI>> OIWGSMXIGGP(Id128<HUXETNCTSFJ> graphId, Id128<FRZIQAPUPIV> nodeId, Id32<RWZXBCGZCJT> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class LGHGGKCJVJH : TECTNCZKXAX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly HRQTZSPCIJP UZFVRNRIZAR;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<HRQTZSPCIJP> DYMEVWRAOOF;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<HRQTZSPCIJP> XHSXJSDKGAC;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<HRQTZSPCIJP> GLTTCDJYPVN;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public HRQTZSPCIJP IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2857E70", Offset = "0x2857270", VA = "0x182857E70", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x2857E60", Offset = "0x2857260", VA = "0x182857E60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x2857EC0", Offset = "0x28572C0", VA = "0x182857EC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2857DE0", Offset = "0x28571E0", VA = "0x182857DE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2856320", Offset = "0x2855720", VA = "0x182856320")]
		public bool WNIWTQLPHSC(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public LGHGGKCJVJH(HRQTZSPCIJP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2856160", Offset = "0x2855560", VA = "0x182856160")]
		internal static TypeKey DMGIDDSWWIP(HRQTZSPCIJP a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x28562F0", Offset = "0x28556F0", VA = "0x1828562F0", Slot = "3")]
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
	public readonly struct ActionDeps : YTIPMBUMKVK.OSWHAJJFKLJ<VLXCXCSSZAI, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x284B8B0", Offset = "0x284ACB0", VA = "0x18284B8B0", Slot = "4")]
		public int RFSJZPKKTDX(None a, VLXCXCSSZAI b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x284B860", Offset = "0x284AC60", VA = "0x18284B860", Slot = "5")]
		public VLXCXCSSZAI KXWQFMNTUWU(None a, VLXCXCSSZAI b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x284B810", Offset = "0x284AC10", VA = "0x18284B810", Slot = "6")]
		public VLXCXCSSZAI FYGLHZWNVVN(None a, VLXCXCSSZAI b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x284B870", Offset = "0x284AC70", VA = "0x18284B870", Slot = "7")]
		public IReadOnlyList<VLXCXCSSZAI> ONCEOKUMABL(None a, VLXCXCSSZAI b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x284B8F0", Offset = "0x284ACF0", VA = "0x18284B8F0", Slot = "8")]
		public VLXCXCSSZAI[] YRVRGGIUZQI(None a, VLXCXCSSZAI b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x284B900", Offset = "0x284AD00", VA = "0x18284B900", Slot = "9")]
		public bool ZEFZTGZXMCF(None a, VLXCXCSSZAI b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x284B8D0", Offset = "0x284ACD0", VA = "0x18284B8D0", Slot = "10")]
		public bool VXHJHXGQEON(None a, VLXCXCSSZAI b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x284B890", Offset = "0x284AC90", VA = "0x18284B890", Slot = "11")]
		public bool RBSCLDJHZOJ(None a, VLXCXCSSZAI b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x284B7F0", Offset = "0x284ABF0", VA = "0x18284B7F0", Slot = "12")]
		public bool CHGOKWGTJKV(None a, VLXCXCSSZAI b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x284B840", Offset = "0x284AC40", VA = "0x18284B840", Slot = "13")]
		public bool KCONGTCRBJR(None a, VLXCXCSSZAI b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x284B7D0", Offset = "0x284ABD0", VA = "0x18284B7D0", Slot = "14")]
		public bool AFVWGQPXITI(None a, VLXCXCSSZAI b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class LGMVLTQSIHA : PHMKKHZLINW
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract AYAZJFNSIFY.ALXXNXZFOSL IGMGNSJIQBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract AUQKPBYPMDP.ALXXNXZFOSL ZPCSKYYTWMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract HGEHYAJDPNG.ALXXNXZFOSL JOUDFCYGGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP> VRQYXACKGZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x2857FE0", Offset = "0x28573E0", VA = "0x182857FE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.ALXXNXZFOSL BWRJSSVQRZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract WTTLBDSHSXM YXHITRENJNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract BSBAJWUIWZV NMRGTZVZSAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract JKZPZKKOTQX VXKWKFOKFNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract DYPXEDJBIXJ QVPTAXTVMFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract REEYAUJRNNP BVRLFSWXCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected LGMVLTQSIHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class WNKCMZLIIPA : OTUEWSZEJIS
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
			public AsyncTaskMethodBuilder<Result<MultiResult, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<VLXCXCSSZAI> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public WNKCMZLIIPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x28593A0", Offset = "0x28587A0", VA = "0x1828593A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x28597C0", Offset = "0x2858BC0", VA = "0x1828597C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public WNKCMZLIIPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public VLXCXCSSZAI action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x285E130", Offset = "0x285D530", VA = "0x18285E130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x285E340", Offset = "0x285D740", VA = "0x18285E340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly ZVRVTWCRUTF KMYHGCTGVIZ;

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public WNKCMZLIIPA(ZVRVTWCRUTF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x285EFE0", Offset = "0x285E3E0", VA = "0x18285EFE0")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, RAGLFGQXJZI>> IGVOWTPJRQX(VLXCXCSSZAI a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x285F110", Offset = "0x285E510", VA = "0x18285F110", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, RAGLFGQXJZI>> VIAYLEWFJYL(IReadOnlyList<VLXCXCSSZAI> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, VLXCXCSSZAI, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xFB42A0", Offset = "0xFB36A0", VA = "0x180FB42A0")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, VLXCXCSSZAI, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2858220", Offset = "0x2857620", VA = "0x182858220")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class FBAHFNPERNR
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, VLXCXCSSZAI, PartialActionReassemblyDeps> BOODFOMVPUA(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, VLXCXCSSZAI, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : BEDMZXHSCGY.GIAVPBUDCZA<PartialActionPayload, Id128<PartialActionPayload.M>, VLXCXCSSZAI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2858040", Offset = "0x2857440", VA = "0x182858040", Slot = "7")]
		public VLXCXCSSZAI GWNNTFMGGZC(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xF93080", Offset = "0xF92480", VA = "0x180F93080")]
		public Id128<PartialActionPayload.M> ZUSSLQMXBNU([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0xFDF040", Offset = "0xFDE440", VA = "0x180FDF040")]
		public int KCBRJBAIAAW([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2858030", Offset = "0x2857430", VA = "0x182858030")]
		public int BPSFJZOFCVD([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0xFDF040", Offset = "0xFDE440", VA = "0x180FDF040", Slot = "4")]
		private int SHPHJYYXHTE([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2858030", Offset = "0x2857430", VA = "0x182858030", Slot = "5")]
		private int LINEQTNRDDT([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xF93080", Offset = "0xF92480", VA = "0x180F93080", Slot = "6")]
		private Id128<PartialActionPayload.M> GYRQVDEGATU([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, VLXCXCSSZAI, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xFB42A0", Offset = "0xFB36A0", VA = "0x180FB42A0")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, VLXCXCSSZAI, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2858800", Offset = "0x2857C00", VA = "0x182858800")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class DDBBWSFXXHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static SnapshotReassembly<PartialInitializePayload, VLXCXCSSZAI, SnapshotReassemblyDeps> BOODFOMVPUA(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, VLXCXCSSZAI, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : TACPNLYUAQD.GIGCMIOAMKJ<PartialInitializePayload, VLXCXCSSZAI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xDDDA50", Offset = "0xDDCE50", VA = "0x180DDDA50")]
		public int CKBVIXHYIWE([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2858620", Offset = "0x2857A20", VA = "0x182858620", Slot = "5")]
		public VLXCXCSSZAI UQJZKXSCYFE(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xDDDA50", Offset = "0xDDCE50", VA = "0x180DDDA50", Slot = "4")]
		private int TRCQIAMVBDO([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class ZLZDLICJIBE : GKLIEWNFSHL, RMWBTSSRSGR, RAGLFGQXJZI, XOJOHOBKPDS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly XOJOHOBKPDS? AHUJKMYMQSM;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind LAFGGLSRZTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override XOJOHOBKPDS? CRJWSUPXPSF
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x285F240", Offset = "0x285E640", VA = "0x18285F240", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x285F470", Offset = "0x285E870", VA = "0x18285F470")]
		private ZLZDLICJIBE(PrepareTemplateForCloneErrKind a, XOJOHOBKPDS? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x285F340", Offset = "0x285E740", VA = "0x18285F340")]
		public static ZLZDLICJIBE EFMGGXHYHBY(XOJOHOBKPDS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x285F3B0", Offset = "0x285E7B0", VA = "0x18285F3B0")]
		public static ZLZDLICJIBE JTNBOCAAJBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x285F410", Offset = "0x285E810", VA = "0x18285F410")]
		public static ZLZDLICJIBE SZTRAQHSCJM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class FDKNBIWOJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x363BF50", Offset = "0x363B350", VA = "0x18363BF50")]
		public static Result<TOk, RMWBTSSRSGR> HWRYWRZPYDV<TOk>([In] this Result<TOk, RMWBTSSRSGR> self, XOJOHOBKPDS a) where TOk : notnull
		{
			return default(Result<TOk, RMWBTSSRSGR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x363C190", Offset = "0x363B590", VA = "0x18363C190")]
		public static Result<a?, RMWBTSSRSGR?> KSHUXKNCXAT<a>([In] this Result<a, RMWBTSSRSGR> self)
		{
			return default(Result<a, RMWBTSSRSGR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x363C2E0", Offset = "0x363B6E0", VA = "0x18363C2E0")]
		public static Result<b?, RMWBTSSRSGR?> WZQBQLWXDEF<b>([In] this Result<b, RMWBTSSRSGR> self)
		{
			return default(Result<b, RMWBTSSRSGR>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface WTTLBDSHSXM
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NDKAGIQIETY([In] Result<None, XOJOHOBKPDS> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class NTRDGBQYUOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x3824D90", Offset = "0x3824190", VA = "0x183824D90")]
		public static bool NDKAGIQIETY<TOk, TErr>(this WTTLBDSHSXM a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, XOJOHOBKPDS
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface BSBAJWUIWZV
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		YJUHLGNCLGJ ISFCJOCMICU
		{
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface JKZPZKKOTQX
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor YEKJZVCOCSS(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface USHKKQAUDVQ
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface UVARJVBQTYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LILPGEUAYSF? HTWGKHMYHEC(Id32<RWZXBCGZCJT> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface XRZGTPLOJNZ
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface LILPGEUAYSF
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		XRZGTPLOJNZ? ATSDQRRGPXC(Id32<KRQTPWZEGQG> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		USHKKQAUDVQ? NYDCKITWEOD(Id32<GLLQVRJNTAT> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface DYPXEDJBIXJ
	{
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> FQKOMTSFLQD(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface REEYAUJRNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UVARJVBQTYZ? XUZWRKKJLSE([In] Id128<HESNLTWUPXP> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class ASCPBTBAIIY
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
			public readonly List<VLXCXCSSZAI> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x284B9D0", Offset = "0x284ADD0", VA = "0x18284B9D0")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<VLXCXCSSZAI> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x284B920", Offset = "0x284AD20", VA = "0x18284B920")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly XRIYBVKTNZL<Diagnostic> HWNIZEOIQTI;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static ASCPBTBAIIY LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x284B090", Offset = "0x284A490", VA = "0x18284B090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool FTRQWTMEOUE
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x284B3C0", Offset = "0x284A7C0", VA = "0x18284B3C0")]
		public void UKZGJVTIKXZ(MCGUTYIFENK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x284B0E0", Offset = "0x284A4E0", VA = "0x18284B0E0")]
		public void QXPJTLASIUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x284B480", Offset = "0x284A880", VA = "0x18284B480")]
		private static string? XEPLMCEEJDW([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x284B730", Offset = "0x284AB30", VA = "0x18284B730")]
		public ASCPBTBAIIY()
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
