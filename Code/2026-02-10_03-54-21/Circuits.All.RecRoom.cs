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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x28A4AE0", Offset = "0x28A3CE0", VA = "0x1828A4AE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x28A42B0", Offset = "0x28A34B0", VA = "0x1828A42B0", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class RRHCIMKELZN : IDisposable, VUVCFQMHIXO, XCDISBFUVBP, CAHHGYVVFHK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class PLYECWWDWRI : ELSNTWPCDON
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int TQOXMETRDYG
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x28A4D00", Offset = "0x28A3F00", VA = "0x1828A4D00", Slot = "5")]
			public ZYKWBNETGNH NSYAKSTAQEO(HXXVFCDUHKY.ELSNTWPCDON a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void NWHVHMPYKFA();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void QUIRETUARDX();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2891710", Offset = "0x2890910", VA = "0x182891710", Slot = "13")]
			public virtual void TIVWYLEYFZZ(RRHCIMKELZN a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x28A4E30", Offset = "0x28A4030", VA = "0x1828A4E30", Slot = "14")]
			public virtual void UHQCLFSSZKE(RRHCIMKELZN a, USPEKNRWVPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			protected PLYECWWDWRI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ELSNTWPCDON
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int TQOXMETRDYG
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			ZYKWBNETGNH NSYAKSTAQEO(HXXVFCDUHKY.ELSNTWPCDON a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void NWHVHMPYKFA();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void QUIRETUARDX();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void TIVWYLEYFZZ(RRHCIMKELZN a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void UHQCLFSSZKE(RRHCIMKELZN a, USPEKNRWVPE b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, USPEKNRWVPE, RRHCIMKELZN, RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x105B060", Offset = "0x105A260", VA = "0x18105B060")]
			internal Reducer(Reducer<ActionKind, USPEKNRWVPE, RRHCIMKELZN, RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class ZAOCERFTHHU : RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly ZAOCERFTHHU DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private ZAOCERFTHHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x12BEC30", Offset = "0x12BDE30", VA = "0x1812BEC30", Slot = "4")]
			public ActionKind IEIVPSNHONM(USPEKNRWVPE a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x28BE0B0", Offset = "0x28BD2B0", VA = "0x1828BE0B0", Slot = "5")]
			public void TIVWYLEYFZZ(RRHCIMKELZN a, USPEKNRWVPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x28BE1B0", Offset = "0x28BD3B0", VA = "0x1828BE1B0", Slot = "6")]
			public void UHQCLFSSZKE(RRHCIMKELZN a, USPEKNRWVPE b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, USPEKNRWVPE, RRHCIMKELZN, RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x28B1F70", Offset = "0x28B1170", VA = "0x1828B1F70")]
			internal ReducerFactory(ReducerFactory<ActionKind, USPEKNRWVPE, RRHCIMKELZN, RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x28B1F20", Offset = "0x28B1120", VA = "0x1828B1F20")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : EFFEKHEHDBI.OYNDGZFOJFE<USPEKNRWVPE, RRHCIMKELZN>
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
				public AsyncTaskMethodBuilder<Result<object?, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public RRHCIMKELZN receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public USPEKNRWVPE action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x28B5530", Offset = "0x28B4730", VA = "0x1828B5530", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x28B5710", Offset = "0x28B4910", VA = "0x1828B5710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB1A100", Offset = "0xB19300", VA = "0x180B1A100", Slot = "4")]
			public Id32<WBUFIROFFZC> XGXZBNNJYTP(RRHCIMKELZN a)
			{
				return default(Id32<WBUFIROFFZC>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x28B4630", Offset = "0x28B3830", VA = "0x1828B4630", Slot = "5")]
			public void NSQQGGFQLDA(RRHCIMKELZN a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x28B4690", Offset = "0x28B3890", VA = "0x1828B4690", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, JDUFGOJEPGU>> PZGKDFDFRQX(RRHCIMKELZN a, USPEKNRWVPE b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x28B47C0", Offset = "0x28B39C0", VA = "0x1828B47C0", Slot = "7")]
			public USPEKNRWVPE[] QACIFHIFJET(RRHCIMKELZN a)
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
			public AsyncTaskMethodBuilder<Result<object?, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public RRHCIMKELZN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public USPEKNRWVPE action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x28B5780", Offset = "0x28B4980", VA = "0x1828B5780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x28B5970", Offset = "0x28B4B70", VA = "0x1828B5970", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public RRHCIMKELZN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x28B6EA0", Offset = "0x28B60A0", VA = "0x1828B6EA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x28B7120", Offset = "0x28B6320", VA = "0x1828B7120", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public RRHCIMKELZN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x28B7190", Offset = "0x28B6390", VA = "0x1828B7190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x28B7370", Offset = "0x28B6570", VA = "0x1828B7370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<WBUFIROFFZC> LKMLKXTJTVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer YJYGIBIOHPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 VUECDXQYVFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly QGBMHGUBIHM ENYFIGNQEXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly FCZEXSWNMQC.CreationArgs YBEMSLNEMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly WWUBDEZIMKL FGWHDYHIQUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly ZIXPGQUVXZI NKYRDQJXYOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly SWUNRXFXXLH NGEDLMEBUVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly EBMMTQZZARY IANWVUPCPET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly ABWWDJKMJLI WCJMRAONZQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly IYGNIVBTNPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly KYCUWPAPSSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest DFLTJUAEOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended USPBSEZFAEJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal ELSNTWPCDON XWEAFCMKVPG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x28B0D30", Offset = "0x28AFF30", VA = "0x1828B0D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal ZYKWBNETGNH OUVPVOUYDCY
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x28B0F80", Offset = "0x28B0180", VA = "0x1828B0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x28B1780", Offset = "0x28B0980", VA = "0x1828B1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool OMOMCSXCLPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x28B0F90", Offset = "0x28B0190", VA = "0x1828B0F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x28B1BE0", Offset = "0x28B0DE0", VA = "0x1828B1BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IIGNMDSTLDQ WWUBDEZIMKL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x28B1EE0", Offset = "0x28B10E0", VA = "0x1828B1EE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RTBCXHUIOQG SWUNRXFXXLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x28B1EF0", Offset = "0x28B10F0", VA = "0x1828B1EF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public TFAVROEGEKR ABWWDJKMJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x28B1F10", Offset = "0x28B1110", VA = "0x1828B1F10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public VCWVNKLHUPD ZIXPGQUVXZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x28B0D20", Offset = "0x28AFF20", VA = "0x1828B0D20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JMOBNNFBEAL EBMMTQZZARY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x28B1F00", Offset = "0x28B1100", VA = "0x1828B1F00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FCZEXSWNMQC? FCZEXSWNMQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x28B17A0", Offset = "0x28B09A0", VA = "0x1828B17A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28B1BF0", Offset = "0x28B0DF0", VA = "0x1828B1BF0")]
		private RRHCIMKELZN(QGBMHGUBIHM a, Id32<WBUFIROFFZC> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, ZYKWBNETGNH b, [In] FCZEXSWNMQC.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28B12B0", Offset = "0x28B04B0", VA = "0x1828B12B0")]
		public static RRHCIMKELZN New(QGBMHGUBIHM deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<WBUFIROFFZC> actorId, Id32<EWGMMJRBQBF> rootNetworkObjectId, DLOXXYQFPRD staticNetSys, KDTPHZGDKFX dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28B0FF0", Offset = "0x28B01F0", VA = "0x1828B0FF0")]
		public static RRHCIMKELZN New(QGBMHGUBIHM dependencies, [In] RegistryV2 registryV2, Id32<WBUFIROFFZC> actorId, Id32<EWGMMJRBQBF> rootNetworkObjectId, DLOXXYQFPRD staticNetSys, KDTPHZGDKFX dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28B0B40", Offset = "0x28AFD40", VA = "0x1828B0B40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28B0D80", Offset = "0x28AFF80", VA = "0x1828B0D80")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, JDUFGOJEPGU>> KCMJTWUUKBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28B1970", Offset = "0x28B0B70", VA = "0x1828B1970")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, JDUFGOJEPGU>> UIDBTTBILBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28B0940", Offset = "0x28AFB40", VA = "0x1828B0940")]
		internal void AJRPUMHVGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28B18F0", Offset = "0x28B0AF0", VA = "0x1828B18F0")]
		internal Option<USPEKNRWVPE> TUBLWUSTGRY([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<USPEKNRWVPE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28B1880", Offset = "0x28B0A80", VA = "0x1828B1880")]
		internal bool TUAPIXTXYSR([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28B1A60", Offset = "0x28B0C60", VA = "0x1828B1A60")]
		internal Result<USPEKNRWVPE, JDUFGOJEPGU> XGDGISOQZSK([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<USPEKNRWVPE, JDUFGOJEPGU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28B0FA0", Offset = "0x28B01A0", VA = "0x1828B0FA0")]
		private void NSQQGGFQLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28B0E70", Offset = "0x28B0070", VA = "0x1828B0E70")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, JDUFGOJEPGU>> KTPOMXLNVPM(USPEKNRWVPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28B1380", Offset = "0x28B0580", VA = "0x1828B1380")]
		private USPEKNRWVPE[] QACIFHIFJET()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class BLLHCOECXQP<a> : VTISYMIGLDB, ENGAPKTTSRZ, WMUYMRHRYMC where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<FAVTMLJIUOX>? CJQVZGPCIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string LOODGBNBKRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a KHVUALCSJMI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<FAVTMLJIUOX>? PSNLVWKJBPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2B8DE40", Offset = "0x2B8D040", VA = "0x182B8DE40", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7127DD0", Offset = "0x7126FD0", VA = "0x187127DD0")]
		internal BLLHCOECXQP([In] Id128<FAVTMLJIUOX>? lastNode, Id32<XWVPYHBWQIU>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class PWHKCIYKQPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28A4EB0", Offset = "0x28A40B0", VA = "0x1828A4EB0")]
		public static Result<DebugExecutionResult, ENGAPKTTSRZ> ZRDBVTEWENO([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, ENGAPKTTSRZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x395EB70", Offset = "0x395DD70", VA = "0x18395EB70")]
		public static Result<TOk, ENGAPKTTSRZ> PMKKDUPQZNS<TOk>([In] this Result<TOk, ENGAPKTTSRZ> self, [In] Id128<FAVTMLJIUOX>? lastNode, Id32<XWVPYHBWQIU>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, ENGAPKTTSRZ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface QGBMHGUBIHM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		HXXVFCDUHKY.ELSNTWPCDON ISJJBPAZHRA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		RRHCIMKELZN.ELSNTWPCDON HLTAHUAHGLL
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PTEMFAIRMBY.ELSNTWPCDON HZPVXQROKXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN> ZAOCERFTHHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.ELSNTWPCDON BUISVEIYUDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		BKQRFKBWSPS OOZAYYTADBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		KCBFZEYCEZD OCFPZNPJYLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		PUFXDFRADIJ YYONDGKDFLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		TWDSZOCCEPP WMWORLFYNJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		SPZWLQEAMOP BUXKODBFIDA
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
	public static class DMQAXHZZVVP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x289C830", Offset = "0x289BA30", VA = "0x18289C830")]
		public static USPEKNRWVPE GKPXAAFYWPS(this USPEKNRWVPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x289C760", Offset = "0x289B960", VA = "0x18289C760")]
		public static USPEKNRWVPE FABCDJHRCML(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public RRHCIMKELZN root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x28B59E0", Offset = "0x28B4BE0", VA = "0x1828B59E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x28B6100", Offset = "0x28B5300", VA = "0x1828B6100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x289C4E0", Offset = "0x289B6E0", VA = "0x18289C4E0")]
		public static USPEKNRWVPE KRFVHDKZUPK(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x289C6B0", Offset = "0x289B8B0", VA = "0x18289C6B0")]
		public static ReduceAction<ActionKind, CompressedPayload> ORZRGKUQBUF(USPEKNRWVPE actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x289C5A0", Offset = "0x289B7A0", VA = "0x18289C5A0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, JDUFGOJEPGU>> KTPOMXLNVPM(RRHCIMKELZN a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x289CA20", Offset = "0x289BC20", VA = "0x18289CA20")]
		public static USPEKNRWVPE KRFVHDKZUPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x289CAC0", Offset = "0x289BCC0", VA = "0x18289CAC0")]
		public static ReduceAction<ActionKind, DestroyPayload> ORZRGKUQBUF(USPEKNRWVPE actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x289CB30", Offset = "0x289BD30", VA = "0x18289CB30")]
		public static Result<None, ZIKRBQQFHYB> TSQKIXHUQUC(RRHCIMKELZN a, [In] DestroyPayload self)
		{
			return default(Result<None, ZIKRBQQFHYB>);
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
			public AsyncTaskMethodBuilder<Result<None, ZIKRBQQFHYB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RRHCIMKELZN root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, ZIKRBQQFHYB> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x28B61E0", Offset = "0x28B53E0", VA = "0x1828B61E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x28B6780", Offset = "0x28B5980", VA = "0x1828B6780", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CB6CD0", Offset = "0x1CB5ED0", VA = "0x181CB6CD0")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x289CBB0", Offset = "0x289BDB0", VA = "0x18289CBB0")]
		public static USPEKNRWVPE? KRFVHDKZUPK(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x289CDF0", Offset = "0x289BFF0", VA = "0x18289CDF0")]
		public static ReduceAction<ActionKind, FullInitializePayload> ORZRGKUQBUF(USPEKNRWVPE actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x289CCB0", Offset = "0x289BEB0", VA = "0x18289CCB0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, ZIKRBQQFHYB>> KTPOMXLNVPM(RRHCIMKELZN a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public RRHCIMKELZN root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, JDUFGOJEPGU> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, WMUYMRHRYMC>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, WMUYMRHRYMC> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, WMUYMRHRYMC>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x28B5CA0", Offset = "0x28B4EA0", VA = "0x1828B5CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x28B6170", Offset = "0x28B5370", VA = "0x1828B6170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<USPEKNRWVPE> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
		private MultiPayload(IReadOnlyList<USPEKNRWVPE> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28A4680", Offset = "0x28A3880", VA = "0x1828A4680")]
		public static USPEKNRWVPE KRFVHDKZUPK(IReadOnlyList<USPEKNRWVPE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28A4880", Offset = "0x28A3A80", VA = "0x1828A4880")]
		public static ReduceAction<ActionKind, MultiPayload> ORZRGKUQBUF(USPEKNRWVPE actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x28A4740", Offset = "0x28A3940", VA = "0x1828A4740")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, JDUFGOJEPGU>> KTPOMXLNVPM(RRHCIMKELZN a, MultiPayload b)
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
		private sealed class LWTYMBCWKSX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> TVTSLJSNUAL;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public LWTYMBCWKSX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x28A4140", Offset = "0x28A3340", VA = "0x1828A4140")]
			internal USPEKNRWVPE CZAYWSSIRZN(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x28B01C0", Offset = "0x28AF3C0", VA = "0x1828B01C0")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28AFDD0", Offset = "0x28AEFD0", VA = "0x1828AFDD0")]
		public static USPEKNRWVPE KRFVHDKZUPK(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28AFCD0", Offset = "0x28AEED0", VA = "0x1828AFCD0")]
		public static USPEKNRWVPE[] IDNMVEGDZHJ(USPEKNRWVPE a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28AFEE0", Offset = "0x28AF0E0", VA = "0x1828AFEE0")]
		public static ReduceAction<ActionKind, PartialActionPayload> ORZRGKUQBUF(USPEKNRWVPE actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28B0030", Offset = "0x28AF230", VA = "0x1828B0030")]
		public static Result<USPEKNRWVPE, JDUFGOJEPGU> TSQKIXHUQUC(RRHCIMKELZN a, [In] PartialActionPayload self)
		{
			return default(Result<USPEKNRWVPE, JDUFGOJEPGU>);
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
			public AsyncTaskMethodBuilder<Result<bool, ZIKRBQQFHYB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public RRHCIMKELZN root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, ZIKRBQQFHYB> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, ZIKRBQQFHYB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x28B67F0", Offset = "0x28B59F0", VA = "0x1828B67F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x28B6E30", Offset = "0x28B6030", VA = "0x1828B6E30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3FEF0", Offset = "0xB3F0F0", VA = "0x180B3FEF0")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28B03D0", Offset = "0x28AF5D0", VA = "0x1828B03D0")]
		public static USPEKNRWVPE KRFVHDKZUPK(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28B01E0", Offset = "0x28AF3E0", VA = "0x1828B01E0")]
		public static USPEKNRWVPE?[]? BVURXAUZKTR(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28B05E0", Offset = "0x28AF7E0", VA = "0x1828B05E0")]
		public static ReduceAction<ActionKind, PartialInitializePayload> ORZRGKUQBUF(USPEKNRWVPE actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28B04B0", Offset = "0x28AF6B0", VA = "0x1828B04B0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, ZIKRBQQFHYB>> KTPOMXLNVPM(RRHCIMKELZN a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class WWUBDEZIMKL : IIGNMDSTLDQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly RRHCIMKELZN GLGGEMXYIBO;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public KDFNFUODWSZ? DZRVHNEPLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x28BDFB0", Offset = "0x28BD1B0", VA = "0x1828BDFB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		internal WWUBDEZIMKL(RRHCIMKELZN a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class JLVAVCHMIDO : KDFNFUODWSZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly RRHCIMKELZN GLGGEMXYIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly FCZEXSWNMQC ODFDTYQEEMC;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xAC0190", VA = "0x180AC0F90")]
		public JLVAVCHMIDO(RRHCIMKELZN a, FCZEXSWNMQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28A3480", Offset = "0x28A2680", VA = "0x1828A3480", Slot = "4")]
		public Result<DebugExecutionResult, ENGAPKTTSRZ> LZANPOEFVLE(Id128<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId, Id32<EXAEBOAKZGD> inputId)
		{
			return default(Result<DebugExecutionResult, ENGAPKTTSRZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28A2ED0", Offset = "0x28A20D0", VA = "0x1828A2ED0", Slot = "5")]
		public Result<DebugExecutionResult, ENGAPKTTSRZ> LQMQNTIHXTD(Id128<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId, Id32<RJHPWNGPQQO> outputId)
		{
			return default(Result<DebugExecutionResult, ENGAPKTTSRZ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class HXXVFCDUHKY : ZYKWBNETGNH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface ELSNTWPCDON
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<BTDOGBIDVJH> JKDVPAMIYHK(RRHCIMKELZN a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void BTUTCUGXTLW(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class PLYECWWDWRI : ELSNTWPCDON
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
				public AsyncTaskMethodBuilder<BTDOGBIDVJH> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public RRHCIMKELZN circuitsManager;

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
				private TaskAwaiter<PTEMFAIRMBY> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x28B4AE0", Offset = "0x28B3CE0", VA = "0x1828B4AE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x28B4CB0", Offset = "0x28B3EB0", VA = "0x1828B4CB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x28A4BA0", Offset = "0x28A3DA0", VA = "0x1828A4BA0", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<BTDOGBIDVJH> JKDVPAMIYHK(RRHCIMKELZN a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void BTUTCUGXTLW(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			protected PLYECWWDWRI()
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
			public AsyncTaskMethodBuilder<BTDOGBIDVJH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public HXXVFCDUHKY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28B4D20", Offset = "0x28B3F20", VA = "0x1828B4D20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28B4F20", Offset = "0x28B4120", VA = "0x1828B4F20", Slot = "5")]
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
			public HXXVFCDUHKY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public RRHCIMKELZN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<BTDOGBIDVJH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x28B4F90", Offset = "0x28B4190", VA = "0x1828B4F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x28B54D0", Offset = "0x28B46D0", VA = "0x1828B54D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ELSNTWPCDON SNMLORCJSFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> WJXZWXMVVNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> MHIJPQIFTMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource REPBVXGICYH;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool OMOMCSXCLPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB1BF50", Offset = "0xB1B150", VA = "0x180B1BF50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB1C780", Offset = "0xB1B980", VA = "0x180B1C780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool SKRCPBVXMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCEB500", Offset = "0xCEA700", VA = "0x180CEB500", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD31830", Offset = "0xD30A30", VA = "0x180D31830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool TRTHHUUBATA
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x184DB30", Offset = "0x184CD30", VA = "0x18184DB30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x18A4D10", Offset = "0x18A3F10", VA = "0x1818A4D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public BTDOGBIDVJH? DZRVHNEPLID
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xABEC10", Offset = "0xABDE10", VA = "0x180ABEC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28A2A30", Offset = "0x28A1C30", VA = "0x1828A2A30", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<BTDOGBIDVJH> VNBNBTRUYUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28A2B20", Offset = "0x28A1D20", VA = "0x1828A2B20")]
		public HXXVFCDUHKY(ELSNTWPCDON a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28A2780", Offset = "0x28A1980", VA = "0x1828A2780", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task DRWAGXEESWS(RRHCIMKELZN a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28A28C0", Offset = "0x28A1AC0", VA = "0x1828A28C0", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class HUDKSYFQYVT : VWUZZKOSSEY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly VGVVQLSXQGB KATSCTULIXW;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		public HUDKSYFQYVT(VGVVQLSXQGB a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class INUMMMPBHKK
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class DVQFUACABQY<a> : AAIZPJCHXDV where a : FGITXDOLHEZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a LWYIYHCZRLB;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? BKCMRVOIBIZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xCA1D90", Offset = "0xCA0F90", VA = "0x180CA1D90", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<FAVTMLJIUOX>? HAMESCYIFFH
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x40A0130", Offset = "0x409F330", VA = "0x1840A0130", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<NZKBDZMUQMJ> RNQCONEVYND
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B89210", Offset = "0x2B88410", VA = "0x182B89210", Slot = "5")]
				get
				{
					return default(Id32<NZKBDZMUQMJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<NZKBDZMUQMJ>? EITNAVQAOXX
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x40A01E0", Offset = "0x409F3E0", VA = "0x1840A01E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
			public DVQFUACABQY(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class NDXYZSCIVQW : DVQFUACABQY<MPNUDMSLMLW>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? BKCMRVOIBIZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xDDB9C0", Offset = "0xDDABC0", VA = "0x180DDB9C0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x28A4A10", Offset = "0x28A3C10", VA = "0x1828A4A10")]
			public NDXYZSCIVQW(MPNUDMSLMLW a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x28A2CF0", Offset = "0x28A1EF0", VA = "0x1828A2CF0")]
		public static AAIZPJCHXDV New(FGITXDOLHEZ graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class GQOYTODQKPI : DKNTXNYIADL, WVFYSXHQAXF, YSPMOZFFUWS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class NDNQKCIQOZC
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
				public NDNQKCIQOZC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public BKQRFKBWSPS errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x28B8570", Offset = "0x28B7770", VA = "0x1828B8570", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x28B87E0", Offset = "0x28B79E0", VA = "0x1828B87E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public GQOYTODQKPI LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool VTEDWCEIGWR;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public NDNQKCIQOZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x28A4920", Offset = "0x28A3B20", VA = "0x1828A4920")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task RCMIQHBKINS(BKQRFKBWSPS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class CNIVDJMUJNC
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
				public CNIVDJMUJNC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x28B8840", Offset = "0x28B7A40", VA = "0x1828B8840", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x28B8B20", Offset = "0x28B7D20", VA = "0x1828B8B20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public GQOYTODQKPI LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int VTEDWCEIGWR;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public CNIVDJMUJNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x289C410", Offset = "0x289B610", VA = "0x18289C410")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task SHKKVBSOZGW(BKQRFKBWSPS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class IGSPWWDJBIB
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
				public IGSPWWDJBIB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x28B9090", Offset = "0x28B8290", VA = "0x1828B9090", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x28B9540", Offset = "0x28B8740", VA = "0x1828B9540", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string VTEDWCEIGWR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public GQOYTODQKPI LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int WILLVTZMOZZ;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public IGSPWWDJBIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x28A2C20", Offset = "0x28A1E20", VA = "0x1828A2C20")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task TWXWPFJSARK(BKQRFKBWSPS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class CJUMJVPMWDM
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
				public CJUMJVPMWDM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x28B8B80", Offset = "0x28B7D80", VA = "0x1828B8B80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x28B9030", Offset = "0x28B8230", VA = "0x1828B9030", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string VTEDWCEIGWR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public GQOYTODQKPI LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int WILLVTZMOZZ;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public CJUMJVPMWDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x289C340", Offset = "0x289B540", VA = "0x18289C340")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task LQUHMYBKJXK(BKQRFKBWSPS a)
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
			public GQOYTODQKPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x28B73E0", Offset = "0x28B65E0", VA = "0x1828B73E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x28B78E0", Offset = "0x28B6AE0", VA = "0x1828B78E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly KBRGELRFHGL WMNLKVPROWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<JIBXIDESRVJ> NVBUWVJBLME;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private QGBMHGUBIHM PLYECWWDWRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x289DD40", Offset = "0x289CF40", VA = "0x18289DD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<EXAEBOAKZGD> UMBQQBZKSXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xBB1D10", Offset = "0xBB0F10", VA = "0x180BB1D10", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<EXAEBOAKZGD>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xCB1EC0", Offset = "0xCB10C0", VA = "0x180CB1EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<XZLTFWVWVWY> QVEDOTBBGEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2838410", Offset = "0x2837610", VA = "0x182838410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<KWIEUHKUXJL> FEGSSSTSSBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1032970", Offset = "0x1031B70", VA = "0x181032970", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<KWIEUHKUXJL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<XWVPYHBWQIU> ZAHAXKVJLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x289FB50", Offset = "0x289ED50", VA = "0x18289FB50", Slot = "22")]
			get
			{
				return default(Id32<XWVPYHBWQIU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool NUQYRZNQPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x28A0AC0", Offset = "0x289FCC0", VA = "0x1828A0AC0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x28A0D50", Offset = "0x289FF50", VA = "0x1828A0D50")]
		private GQOYTODQKPI(RRHCIMKELZN a, AUAIRMEYYLK b, KBRGELRFHGL c, Id32<WXMOLFBEQDB> portGroupId, Id32<EXAEBOAKZGD> inputId, Id32<XZLTFWVWVWY> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x289F7B0", Offset = "0x289E9B0", VA = "0x18289F7B0")]
		public static GQOYTODQKPI New(RRHCIMKELZN circuitsManager, AUAIRMEYYLK node, KBRGELRFHGL input, Id32<WXMOLFBEQDB> portGroupId, Id32<XZLTFWVWVWY> inputDefId, Id32<EXAEBOAKZGD> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x289DD60", Offset = "0x289CF60", VA = "0x18289DD60", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x289D0A0", Offset = "0x289C2A0", VA = "0x18289D0A0", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x28A0040", Offset = "0x289F240", VA = "0x1828A0040", Slot = "32")]
		public void TIBPHGKGVGJ(JIBXIDESRVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x289D140", Offset = "0x289C340", VA = "0x18289D140", Slot = "29")]
		public void GGMFQKPWDOK(UWDBOQBZTXH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x289E110", Offset = "0x289D310", VA = "0x18289E110", Slot = "30")]
		public void KVDZQDMLOBT(VODUAGQYWOD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x289CFC0", Offset = "0x289C1C0", VA = "0x18289CFC0", Slot = "25")]
		protected override void BIIKBIYTNUR(RWHYFKIXBOO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x289FED0", Offset = "0x289F0D0", VA = "0x18289FED0", Slot = "34")]
		public string RSBJIVXGKBY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x28A0800", Offset = "0x289FA00", VA = "0x1828A0800", Slot = "31")]
		public string XIEMRQVIRPM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x289FCB0", Offset = "0x289EEB0", VA = "0x18289FCB0")]
		private void REVFNLPRYDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x289CF00", Offset = "0x289C100", VA = "0x18289CF00", Slot = "33")]
		public void AWMCFXAOEYA(JIBXIDESRVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28A0640", Offset = "0x289F840", VA = "0x1828A0640")]
		private void WZEUHBREGKV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x289FBA0", Offset = "0x289EDA0", VA = "0x18289FBA0", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task QUSIJPGIIMF(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x289DFC0", Offset = "0x289D1C0", VA = "0x18289DFC0")]
		public void KPKDNTYZQIA(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x289F200", Offset = "0x289E400", VA = "0x18289F200")]
		private void MQICXKXKPLE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x28A0480", Offset = "0x289F680", VA = "0x1828A0480")]
		private void VYFZMKMCSHG(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x289DE00", Offset = "0x289D000", VA = "0x18289DE00")]
		private void JWPJVMWUSHB(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28A0B40", Offset = "0x289FD40", VA = "0x1828A0B40")]
		private string ZFTXVZNHJIY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x289F090", Offset = "0x289E290", VA = "0x18289F090")]
		private string LYJXGYLUJGZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xCB1EC0", Offset = "0xCB10C0", VA = "0x180CB1EC0")]
		internal void LTRNVCOPGOC(Id32<EXAEBOAKZGD> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x289DCE0", Offset = "0x289CEE0", VA = "0x18289DCE0")]
		[CompilerGenerated]
		private void GQRTSOBCART(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x289DC20", Offset = "0x289CE20", VA = "0x18289DC20")]
		[CompilerGenerated]
		private bool GQMMVHHERGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x289DA80", Offset = "0x289CC80", VA = "0x18289DA80")]
		[CompilerGenerated]
		private bool GQBZATTJYJS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x289D9C0", Offset = "0x289CBC0", VA = "0x18289D9C0")]
		[CompilerGenerated]
		private int GPWSDMZMOYJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x289D860", Offset = "0x289CA60", VA = "0x18289D860")]
		[CompilerGenerated]
		private bool GPRLGGFPFNA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x289D7F0", Offset = "0x289C9F0", VA = "0x18289D7F0")]
		[CompilerGenerated]
		private void GPMEIZLRWBR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x289D660", Offset = "0x289C860", VA = "0x18289D660")]
		[CompilerGenerated]
		private bool GPGXLSRUMQI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x289D600", Offset = "0x289C800", VA = "0x18289D600")]
		[CompilerGenerated]
		private bool GPBQOLXXDEZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x289D500", Offset = "0x289C700", VA = "0x18289D500")]
		[CompilerGenerated]
		private bool GOWJRFDZTTQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x289D9C0", Offset = "0x289CBC0", VA = "0x18289D9C0")]
		[CompilerGenerated]
		private int TRCKHDGISCC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28A0250", Offset = "0x289F450", VA = "0x1828A0250")]
		[CompilerGenerated]
		private bool TRHREKAGBNL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28A01F0", Offset = "0x289F3F0", VA = "0x1828A01F0")]
		[CompilerGenerated]
		private object TQRWMPSNZFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x289DCF0", Offset = "0x289CEF0", VA = "0x18289DCF0")]
		[CompilerGenerated]
		private void TQXDJWMLIQT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28A03B0", Offset = "0x289F5B0", VA = "0x1828A03B0")]
		[CompilerGenerated]
		private bool TSCSTLBVNGV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28A0320", Offset = "0x289F520", VA = "0x1828A0320")]
		[CompilerGenerated]
		private string TRMYBQUDKYU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28A03A0", Offset = "0x289F5A0", VA = "0x1828A03A0")]
		[CompilerGenerated]
		private void TRSEYXOAUKD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28A00A0", Offset = "0x289F2A0", VA = "0x1828A00A0")]
		[CompilerGenerated]
		private bool TPMHDBDDUPI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28A0170", Offset = "0x289F370", VA = "0x1828A0170")]
		[CompilerGenerated]
		private string TPROAHXBEAR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x289F720", Offset = "0x289E920", VA = "0x18289F720")]
		[CompilerGenerated]
		private void NQJDVSXGOGB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x289F650", Offset = "0x289E850", VA = "0x18289F650")]
		[CompilerGenerated]
		private bool NQDWYMDJEUS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x289F5D0", Offset = "0x289E7D0", VA = "0x18289F5D0")]
		[CompilerGenerated]
		private string NPYQBFJLVJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x289F5C0", Offset = "0x289E7C0", VA = "0x18289F5C0")]
		[CompilerGenerated]
		private void NPTJDYPOLYA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x289F4F0", Offset = "0x289E6F0", VA = "0x18289F4F0")]
		[CompilerGenerated]
		private bool NPOCGRVRCMR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x289F480", Offset = "0x289E680", VA = "0x18289F480")]
		[CompilerGenerated]
		private string NPIVJLBTTBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x289F470", Offset = "0x289E670", VA = "0x18289F470")]
		[CompilerGenerated]
		private void NPDOMEHWJPZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x289F3A0", Offset = "0x289E5A0", VA = "0x18289F3A0")]
		[CompilerGenerated]
		private bool NOYHOXNZAEQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x289F740", Offset = "0x289E940", VA = "0x18289F740")]
		[CompilerGenerated]
		private string NRZGZVALLSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x289F730", Offset = "0x289E930", VA = "0x18289F730")]
		[CompilerGenerated]
		private void NRUACOGOCHM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x289D8F0", Offset = "0x289CAF0", VA = "0x18289D8F0")]
		[CompilerGenerated]
		private bool GPRYXAPDYNS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x289DA10", Offset = "0x289CC10", VA = "0x18289DA10")]
		[CompilerGenerated]
		private string GPXFUHJBHZB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x289DB40", Offset = "0x289CD40", VA = "0x18289DB40")]
		[CompilerGenerated]
		private void GQCMROCYRKK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x289DB50", Offset = "0x289CD50", VA = "0x18289DB50")]
		[CompilerGenerated]
		private bool GQHTOUWWAVT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x289D590", Offset = "0x289C790", VA = "0x18289D590")]
		[CompilerGenerated]
		private string GOWXHZNOMUI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x289D650", Offset = "0x289C850", VA = "0x18289D650")]
		[CompilerGenerated]
		private void GPCEFGHLWFR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x289D720", Offset = "0x289C920", VA = "0x18289D720")]
		[CompilerGenerated]
		private bool GPHLCNBJFRA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x289D800", Offset = "0x289CA00", VA = "0x18289D800")]
		[CompilerGenerated]
		private object GPMRZTVGPCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x289DCF0", Offset = "0x289CEF0", VA = "0x18289DCF0")]
		[CompilerGenerated]
		private void GRICBCSIWAM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28A0C80", Offset = "0x289FE80", VA = "0x1828A0C80")]
		[CompilerGenerated]
		private bool ZPATYIHBIVJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class SFBGZNVDYII
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class UURHMWAWZZO : HNPTTMVJLEI<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public UURHMWAWZZO LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x28BB200", Offset = "0x28BA400", VA = "0x1828BB200")]
				internal object XKGFHHJOQDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x28BB6D0", Offset = "0x28BA8D0", VA = "0x1828BB6D0")]
				internal void XKLMEODLZOJ(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x28BDED0", Offset = "0x28BD0D0", VA = "0x1828BDED0")]
			public UURHMWAWZZO(RRHCIMKELZN a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x28BDC60", Offset = "0x28BCE60", VA = "0x1828BDC60", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class TADFKIWAEVX : DEBRRVHTBGP<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType TWIOBILTJWA
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xBECF30", Offset = "0xBEC130", VA = "0x180BECF30", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x28B47E0", Offset = "0x28B39E0", VA = "0x1828B47E0")]
			public TADFKIWAEVX(RRHCIMKELZN a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class MUXWCGWVJMJ : HNPTTMVJLEI<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x28A4610", Offset = "0x28A3810", VA = "0x1828A4610")]
			public MUXWCGWVJMJ(RRHCIMKELZN a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x28A4330", Offset = "0x28A3530", VA = "0x1828A4330", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x28A4490", Offset = "0x28A3690", VA = "0x1828A4490")]
			[CompilerGenerated]
			private bool LSWQBWUGXTE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x28A44E0", Offset = "0x28A36E0", VA = "0x1828A44E0")]
			[CompilerGenerated]
			private void LTBWZDOEHEN(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class SUZPJRBQBJP : HNPTTMVJLEI<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public SUZPJRBQBJP LQBDIDDTHZG;

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x28BB2B0", Offset = "0x28BA4B0", VA = "0x1828BB2B0")]
				internal void XKGFHHJOQDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x28BB300", Offset = "0x28BA500", VA = "0x1828BB300")]
				internal bool XKLMEODLZOJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x28BAF40", Offset = "0x28BA140", VA = "0x1828BAF40")]
				internal bool XJVRMTVTXGI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x28BAFE0", Offset = "0x28BA1E0", VA = "0x1828BAFE0")]
				internal void XKAYKAPRGRR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x28BB950", Offset = "0x28BAB50", VA = "0x1828BB950")]
				internal bool XLBGWILEBWK()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x28B3E20", Offset = "0x28B3020", VA = "0x1828B3E20")]
			public SUZPJRBQBJP(RRHCIMKELZN a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x28B3B10", Offset = "0x28B2D10", VA = "0x1828B3B10", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class HXFOHOUBRKB : HNPTTMVJLEI<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public HXFOHOUBRKB LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> CVEMAYQOFJC;

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x28BB110", Offset = "0x28BA310", VA = "0x1828BB110")]
				internal object? XKGFHHJOQDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x28BB8D0", Offset = "0x28BAAD0", VA = "0x1828BB8D0")]
				internal bool XKVZZBRGSLB(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x28BB480", Offset = "0x28BA680", VA = "0x1828BB480")]
				internal void XKLMEODLZOJ(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x28BADB0", Offset = "0x28B9FB0", VA = "0x1828BADB0")]
				internal string XJVRMTVTXGI(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x28BAF90", Offset = "0x28BA190", VA = "0x1828BAF90")]
				internal IReadOnlyList<object> XKAYKAPRGRR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x28BB9A0", Offset = "0x28BABA0", VA = "0x1828BB9A0")]
				internal bool XLBGWILEBWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x28BBA10", Offset = "0x28BAC10", VA = "0x1828BBA10")]
				internal bool XLGNTPFBLHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x28BB7A0", Offset = "0x28BA9A0", VA = "0x1828BB7A0")]
				internal void XKQTBUXJIZS(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x28A2710", Offset = "0x28A1910", VA = "0x1828A2710")]
			public HXFOHOUBRKB(RRHCIMKELZN a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x28A2020", Offset = "0x28A1220", VA = "0x1828A2020", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class JNACMLRMFKQ : HNPTTMVJLEI<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public JNACMLRMFKQ LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x28BB260", Offset = "0x28BA460", VA = "0x1828BB260")]
				internal bool XKGFHHJOQDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x28BB350", Offset = "0x28BA550", VA = "0x1828BB350")]
				internal void XKLMEODLZOJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x28BAEF0", Offset = "0x28BA0F0", VA = "0x1828BAEF0")]
				internal bool XJVRMTVTXGI()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x28A3C40", Offset = "0x28A2E40", VA = "0x1828A3C40")]
			public JNACMLRMFKQ(RRHCIMKELZN a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x28A3A30", Offset = "0x28A2C30", VA = "0x1828A3A30", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class HMAFGEBYXSV : HNPTTMVJLEI<CEFVOOZLAAO>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class UNQTNBOCDEJ
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
					public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public UNQTNBOCDEJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<ZEROUCBBYDP>, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x28B7D20", Offset = "0x28B6F20", VA = "0x1828B7D20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x28B8100", Offset = "0x28B7300", VA = "0x1828B8100", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public UNQTNBOCDEJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x28B8170", Offset = "0x28B7370", VA = "0x1828B8170", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x28B8500", Offset = "0x28B7700", VA = "0x1828B8500", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task YQOZEMQOSZB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string SJARWZOYJZP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public JXYGDPTLLDL.OITIPDYSPDR EGGIGJUHXJO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool XLUBCMWFJVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public HMAFGEBYXSV LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public JXYGDPTLLDL LQIXNKGWRSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action PJJHORPXFVQ;

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UNQTNBOCDEJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x28BBA60", Offset = "0x28BAC60", VA = "0x1828BBA60")]
				internal bool EOZPAWWKOOM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
				internal string OTYXRSSRFQF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x28BBA90", Offset = "0x28BAC90", VA = "0x1828BBA90")]
				internal void OTJCZYKZDIE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x28BBB10", Offset = "0x28BAD10", VA = "0x1828BBB10")]
				internal void OTOJXFEWMTN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x13B4110", Offset = "0x13B3310", VA = "0x1813B4110")]
				internal bool OUOSJNAJHYG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x28BBBA0", Offset = "0x28BADA0", VA = "0x1828BBBA0")]
				internal void OUTZGTUGRJP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x28BBB60", Offset = "0x28BAD60", VA = "0x1828BBB60")]
				internal bool OUEEOZMOPBO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x28BBEB0", Offset = "0x28BB0B0", VA = "0x1828BBEB0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, JDUFGOJEPGU>> TGEHNEGIKUS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x28BBDC0", Offset = "0x28BAFC0", VA = "0x1828BBDC0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, JDUFGOJEPGU>> QBFPENDYKJR()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class SZVZAOYZOQR
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
					public AsyncTaskMethodBuilder<Result<Id32<ZEROUCBBYDP>, JDUFGOJEPGU>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<ZEROUCBBYDP>, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x28B7940", Offset = "0x28B6B40", VA = "0x1828B7940", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x28B7CB0", Offset = "0x28B6EB0", VA = "0x1828B7CB0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public HMAFGEBYXSV LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public IPREUGGLREP DTRUIHPXPZE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool WTVBVTVISFY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public JXYGDPTLLDL LQIXNKGWRSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public WTLEQAXFPCB LINHNFKZYCY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action CYFLLWDAQXH;

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public SZVZAOYZOQR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x28B4290", Offset = "0x28B3490", VA = "0x1828B4290")]
				internal object? XKLMEODLZOJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x28B40B0", Offset = "0x28B32B0", VA = "0x1828B40B0")]
				internal void XJVRMTVTXGI(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x28B41A0", Offset = "0x28B33A0", VA = "0x1828B41A0")]
				internal string XKAYKAPRGRR(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x28B4430", Offset = "0x28B3630", VA = "0x1828B4430")]
				internal IReadOnlyList<object> XLBGWILEBWK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x28B44D0", Offset = "0x28B36D0", VA = "0x1828B44D0")]
				internal void XLGNTPFBLHT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x28B4300", Offset = "0x28B3500", VA = "0x1828B4300")]
				internal bool XKQTBUXJIZS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x28B4370", Offset = "0x28B3570", VA = "0x1828B4370")]
				internal void XKVZZBRGSLB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x28B3FE0", Offset = "0x28B31E0", VA = "0x1828B3FE0")]
				internal void XIQCDFGJSQG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x28B4030", Offset = "0x28B3230", VA = "0x1828B4030")]
				internal void XIVJAMAHCBP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000146")]
				[Cpp2IlInjected.Address(RVA = "0x28B3E90", Offset = "0x28B3090", VA = "0x1828B3E90")]
				internal bool JMCGANYVJLZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x28B3EF0", Offset = "0x28B30F0", VA = "0x1828B3EF0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<ZEROUCBBYDP>, JDUFGOJEPGU>> XHEEWOAJTGD()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<NZKBDZMUQMJ>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x28A1FE0", Offset = "0x28A11E0", VA = "0x1828A1FE0", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool DNLWTMQZBPG
			{
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x28A1F70", Offset = "0x28A1170", VA = "0x1828A1F70")]
			public HMAFGEBYXSV(RRHCIMKELZN a, CEFVOOZLAAO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x28A15F0", Offset = "0x28A07F0", VA = "0x1828A15F0", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x28A0F70", Offset = "0x28A0170", VA = "0x1828A0F70")]
			private void CXOYKBKJJGQ(JXYGDPTLLDL a, Id32<ZEROUCBBYDP>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class CBWMIHAASLW : KZZCPIHSVFJ<BEZIBHNLDMR>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x1CDA8E0", Offset = "0x1CD9AE0", VA = "0x181CDA8E0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool NYFSXQFJLEP
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool ZGBNLAAVUAG
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool UTUTMKCUSPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool DNLWTMQZBPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x289C2E0", Offset = "0x289B4E0", VA = "0x18289C2E0")]
			public CBWMIHAASLW(RRHCIMKELZN a, BEZIBHNLDMR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class QPMBLHHIIWW<a> : HNPTTMVJLEI<a> where a : notnull, DFSLLGCNZOW
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
				public AsyncTaskMethodBuilder<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public QPMBLHHIIWW<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x4E17530", Offset = "0x4E16730", VA = "0x184E17530", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x4E17880", Offset = "0x4E16A80", VA = "0x184E17880", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public QPMBLHHIIWW<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<WXMOLFBEQDB> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x51773A0", Offset = "0x51765A0", VA = "0x1851773A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x51776F0", Offset = "0x51768F0", VA = "0x1851776F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<WXMOLFBEQDB>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x5CC32C0", Offset = "0x5CC24C0", VA = "0x185CC32C0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x5CC3290", Offset = "0x5CC2490", VA = "0x185CC3290")]
			protected QPMBLHHIIWW(RRHCIMKELZN a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x5CC30D0", Offset = "0x5CC22D0", VA = "0x185CC30D0", Slot = "122")]
			[AsyncStateMachine(typeof(QPMBLHHIIWW<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> TMXXOUUQGJR(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x5CC31F0", Offset = "0x5CC23F0", VA = "0x185CC31F0", Slot = "149")]
			public sealed override bool VTVKOCSEWFM(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x5CC2E80", Offset = "0x5CC2080", VA = "0x185CC2E80", Slot = "134")]
			protected sealed override bool EMBMGBLSZCU(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5CC2F20", Offset = "0x5CC2120", VA = "0x185CC2F20", Slot = "135")]
			protected override bool HBFZTSHTDCT(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x5CC2FC0", Offset = "0x5CC21C0", VA = "0x185CC2FC0", Slot = "123")]
			[AsyncStateMachine(typeof(QPMBLHHIIWW<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, JDUFGOJEPGU>> NROOLRPOZIK(Id32<WXMOLFBEQDB> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class TGRSLLXXKGL : MNWSRKOEBSE<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public TGRSLLXXKGL LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x28BACB0", Offset = "0x28B9EB0", VA = "0x1828BACB0")]
				internal bool FEZVBWKFQOH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x28BAC00", Offset = "0x28B9E00", VA = "0x1828BAC00")]
				internal void FEUOEPQIHCY(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x28B4A80", Offset = "0x28B3C80", VA = "0x1828B4A80")]
			public TGRSLLXXKGL(RRHCIMKELZN a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x28B4840", Offset = "0x28B3A40", VA = "0x1828B4840", Slot = "151")]
			protected override void JLXBZNPFGSX(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class UBRRACLDNJG : HNPTTMVJLEI<EJHRKHSCKJL>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class PLYECEGTBAG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int MQPKRFBAECL;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PLYECEGTBAG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x28A4B60", Offset = "0x28A3D60", VA = "0x1828A4B60")]
				internal bool BJYTQPSGGAD(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class KZUDVNTIBMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public UBRRACLDNJG LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> PHXHJYBFTNN;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public KZUDVNTIBMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x28A3D60", Offset = "0x28A2F60", VA = "0x1828A3D60")]
				internal int XKGFHHJOQDA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x28A3E00", Offset = "0x28A3000", VA = "0x1828A3E00")]
				internal void XKLMEODLZOJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x28A3CB0", Offset = "0x28A2EB0", VA = "0x1828A3CB0")]
				internal string? XJVRMTVTXGI()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x28BAAF0", Offset = "0x28B9CF0", VA = "0x1828BAAF0")]
			public UBRRACLDNJG(RRHCIMKELZN a, EJHRKHSCKJL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x28BA5F0", Offset = "0x28B97F0", VA = "0x1828BA5F0")]
			private int BDIZEXJRXPN(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x28BA9D0", Offset = "0x28B9BD0", VA = "0x1828BA9D0")]
			private void WUFNONHXZHB(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x28BA680", Offset = "0x28B9880", VA = "0x1828BA680", Slot = "145")]
			protected sealed override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class ISTJDJLTOFK : KZZCPIHSVFJ<CDMVKGDYMOZ>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x28A2E70", Offset = "0x28A2070", VA = "0x1828A2E70")]
			public ISTJDJLTOFK(RRHCIMKELZN a, CDMVKGDYMOZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class KZZCPIHSVFJ<a> : HNPTTMVJLEI<a> where a : notnull, TTDYHLANIFT
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class BDQGVWUKSAX
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
					public BDQGVWUKSAX <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x3CE7150", Offset = "0x3CE6350", VA = "0x183CE7150", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public JXYGDPTLLDL LQIXNKGWRSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public KZZCPIHSVFJ<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action CVJSYFKLOUL;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public BDQGVWUKSAX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x705AEF0", Offset = "0x705A0F0", VA = "0x18705AEF0")]
				internal void XKGFHHJOQDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x705B570", Offset = "0x705A770", VA = "0x18705B570")]
				[AsyncStateMachine(typeof(KZZCPIHSVFJ<>.BDQGVWUKSAX.<<BuildConfigMenuInternal>b__6>d))]
				internal void XKQTBUXJIZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x705B1C0", Offset = "0x705A3C0", VA = "0x18705B1C0")]
				internal bool XKLMEODLZOJ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class BDKZYQANIPO
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
					public BDKZYQANIPO <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x3CE6D50", Offset = "0x3CE5F50", VA = "0x183CE6D50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string HMHGIJZFKHH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public BDQGVWUKSAX BXOYYNWATYZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> CVZNPZSDRCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> CVUGSSYGHRD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action CVOZVMEIYFU;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public BDKZYQANIPO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x705AAE0", Offset = "0x7059CE0", VA = "0x18705AAE0")]
				internal void XJVRMTVTXGI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				internal string XKAYKAPRGRR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
				internal void XLBGWILEBWK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x705AE50", Offset = "0x705A050", VA = "0x18705AE50")]
				[AsyncStateMachine(typeof(KZZCPIHSVFJ<>.BDKZYQANIPO.<<BuildConfigMenuInternal>b__5>d))]
				internal void XLGNTPFBLHT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class WKJPCEMKRTM
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
					public WKJPCEMKRTM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<FXOBICRSDUR>, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x3CE4400", Offset = "0x3CE3600", VA = "0x183CE4400", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public WKJPCEMKRTM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x3CE4B50", Offset = "0x3CE3D50", VA = "0x183CE4B50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public WKJPCEMKRTM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<XZLTFWVWVWY>, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x3CE4D30", Offset = "0x3CE3F30", VA = "0x183CE4D30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public KZZCPIHSVFJ<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<WXMOLFBEQDB> XSZHKZYXWVB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public JXYGDPTLLDL LQIXNKGWRSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public DMCBGFQYAXT TQIVZOKGWZA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int OMJPSWYRZXX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int PTMGRSXZQKH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public MIILYKSZUVS ABDUUDWNXNN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string NKSHCMOPVSQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<AFCJFIIREJS> WZXBBGNPVFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public MIILYKSZUVS RCBRBFYHACA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string XDVKKFIRMYV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<AFCJFIIREJS> DXMIVLIMNRI;

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public WKJPCEMKRTM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x67B0E40", Offset = "0x67B0040", VA = "0x1867B0E40")]
				internal bool VEAPQCUCUPD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x67B0DD0", Offset = "0x67AFFD0", VA = "0x1867B0DD0")]
				internal void VDVISWAFLDU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x67B0A20", Offset = "0x67AFC20", VA = "0x1867B0A20")]
				internal bool BNOBNCRQYHZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x67B0D30", Offset = "0x67AFF30", VA = "0x1867B0D30")]
				[AsyncStateMachine(typeof(KZZCPIHSVFJ<>.WKJPCEMKRTM.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void VDQBVPGIBSL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x67B0CF0", Offset = "0x67AFEF0", VA = "0x1867B0CF0")]
				internal bool VDKUYIMKSHC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x67B0940", Offset = "0x67AFB40", VA = "0x1867B0940")]
				internal void BMSZYBQBMOP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x67B0B60", Offset = "0x67AFD60", VA = "0x1867B0B60")]
				internal bool BPJLOLOTFGC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x67B0C10", Offset = "0x67AFE10", VA = "0x1867B0C10")]
				internal void BPOSLSIQORL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x67B1170", Offset = "0x67B0370", VA = "0x1867B1170")]
				internal bool VNABYZCMDXH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x67B1020", Offset = "0x67B0220", VA = "0x1867B1020")]
				internal bool VEVRFDVSGIN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x67B0FB0", Offset = "0x67B01B0", VA = "0x1867B0FB0")]
				internal void VEQKHXBUWXE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x67B0F10", Offset = "0x67B0110", VA = "0x1867B0F10")]
				[AsyncStateMachine(typeof(KZZCPIHSVFJ<>.WKJPCEMKRTM.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void VELDKQHXNLV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x67B0EB0", Offset = "0x67B00B0", VA = "0x1867B0EB0")]
				internal bool VEFWNJOAEAM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x67B1100", Offset = "0x67B0300", VA = "0x1867B1100")]
				internal bool VFQSUEXHSBX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x67B1090", Offset = "0x67B0290", VA = "0x1867B1090")]
				internal void VFLLWYDKIQO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x67B0A60", Offset = "0x67AFC60", VA = "0x1867B0A60")]
				[AsyncStateMachine(typeof(KZZCPIHSVFJ<>.WKJPCEMKRTM.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void BNTIKJLOHTI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x67B0B00", Offset = "0x67AFD00", VA = "0x1867B0B00")]
				internal bool BNYPHQFLRER()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class WKOVZLGIBEV
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
					public WKOVZLGIBEV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x3CE46F0", Offset = "0x3CE38F0", VA = "0x183CE46F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string ZVLCSMBPVQV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public WKJPCEMKRTM BXOYYNWATYZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> YQRBVZIFZKS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> YQWITGCDIWB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action YQGOBLULGOA;

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public WKOVZLGIBEV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x67B12C0", Offset = "0x67B04C0", VA = "0x1867B12C0")]
				internal void BNIUPVXTOWQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				internal string BMYGVIJYVZY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
				internal void BNDNSPDWFLH(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0x67B1220", Offset = "0x67B0420", VA = "0x1867B1220")]
				[AsyncStateMachine(typeof(KZZCPIHSVFJ<>.WKOVZLGIBEV.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void BMNTAUWEDDG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class KJGDIRZJXNT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool WZXBBGNPVFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public DMCBGFQYAXT TQIVZOKGWZA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<AFCJFIIREJS> QZFMBYKGAKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public KZZCPIHSVFJ<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<WXMOLFBEQDB> XSZHKZYXWVB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int DTJGDHDEILQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> CWKBKNFYJZE;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public KJGDIRZJXNT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x5218310", Offset = "0x5217510", VA = "0x185218310")]
				internal bool IXDXCYPTKHR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class KJAWLLFMOCK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public YSPMOZFFUWS AHXPUGXXARF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public KJGDIRZJXNT BXOYYNWATYZ;

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public KJAWLLFMOCK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x5218150", Offset = "0x5217350", VA = "0x185218150")]
				internal void IXJEAFJQTTA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x52182C0", Offset = "0x52174C0", VA = "0x1852182C0")]
				internal bool IXOKXMDODEJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x5217F60", Offset = "0x5217160", VA = "0x185217F60")]
				internal void IWDOQQUGPCY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x52180F0", Offset = "0x52172F0", VA = "0x1852180F0")]
				internal bool IWIVNXODYOH()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class KIVPOELPERB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public AFCJFIIREJS AXBZWQCAYRH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public KJAWLLFMOCK BWZEGTOIRQY;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public KIVPOELPERB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x52151A0", Offset = "0x52143A0", VA = "0x1852151A0")]
				internal void IWYQFRVWAWI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class MJAQTRDLXVK
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
					public MJAQTRDLXVK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x3CE7FF0", Offset = "0x3CE71F0", VA = "0x183CE7FF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> RMLRUHDKBLL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public MIILYKSZUVS HSVFQCSAZWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool WZXBBGNPVFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public DMCBGFQYAXT TQIVZOKGWZA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public YSPMOZFFUWS AHXPUGXXARF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string ZVLCSMBPVQV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public MJAQTRDLXVK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x589EFD0", Offset = "0x589E1D0", VA = "0x18589EFD0")]
				internal int ZFRSFUYIHJM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x589F010", Offset = "0x589E210", VA = "0x18589F010")]
				internal void ZFWZDBSFQUV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890")]
				internal string ZFHELHKNOMU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x589EF10", Offset = "0x589E110", VA = "0x18589EF10")]
				[AsyncStateMachine(typeof(KZZCPIHSVFJ<>.MJAQTRDLXVK.<<CreatePortItemV2>b__3>d))]
				internal void ZFMLIOEKXYD(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public KZZCPIHSVFJ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x4E17110", Offset = "0x4E16310", VA = "0x184E17110", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x4E174C0", Offset = "0x4E166C0", VA = "0x184E174C0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public KZZCPIHSVFJ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<WXMOLFBEQDB> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x5177760", Offset = "0x5176960", VA = "0x185177760", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x5177B00", Offset = "0x5176D00", VA = "0x185177B00", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public KZZCPIHSVFJ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x517D2E0", Offset = "0x517C4E0", VA = "0x18517D2E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x517D880", Offset = "0x517CA80", VA = "0x18517D880", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<WXMOLFBEQDB>, bool> KCHPHBOOBTN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<WXMOLFBEQDB>, bool> DVZZSGVUYNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<WXMOLFBEQDB>, bool> AUTLYIDRLDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<WXMOLFBEQDB>, bool> HXBCPSXOKMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<WXMOLFBEQDB>, bool> KJXGAFNYDUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<WXMOLFBEQDB>, bool> FOYCZTCKYAU;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool NYFSXQFJLEP
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool ZGBNLAAVUAG
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool UTUTMKCUSPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<NZKBDZMUQMJ>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x52BCA30", Offset = "0x52BBC30", VA = "0x1852BCA30", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<WXMOLFBEQDB>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x52BCCA0", Offset = "0x52BBEA0", VA = "0x1852BCCA0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<FAVTMLJIUOX>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x52BCAB0", Offset = "0x52BBCB0", VA = "0x1852BCAB0", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x52BC860", Offset = "0x52BBA60", VA = "0x1852BC860")]
			public KZZCPIHSVFJ(RRHCIMKELZN a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "154")]
			protected virtual bool VKRGBNUFGXU(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "155")]
			protected virtual bool YYXPICSDTSR(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "156")]
			protected virtual bool GYIJWXNZREM(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "157")]
			protected virtual void GKVJCTAWGXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x52BC6C0", Offset = "0x52BB8C0", VA = "0x1852BC6C0", Slot = "149")]
			public override bool VTVKOCSEWFM(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x52BBBF0", Offset = "0x52BADF0", VA = "0x1852BBBF0", Slot = "122")]
			[AsyncStateMachine(typeof(KZZCPIHSVFJ<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> TMXXOUUQGJR(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x52BAA60", Offset = "0x52B9C60", VA = "0x1852BAA60", Slot = "123")]
			[AsyncStateMachine(typeof(KZZCPIHSVFJ<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, JDUFGOJEPGU>> NROOLRPOZIK(Id32<WXMOLFBEQDB> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x52B8330", Offset = "0x52B7530", VA = "0x1852B8330", Slot = "124")]
			public override void CHPDKWCJLBM(Id32<WXMOLFBEQDB> index, Id32<WXMOLFBEQDB> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x52B8E80", Offset = "0x52B8080", VA = "0x1852B8E80", Slot = "125")]
			public override IEnumerable<USPEKNRWVPE> LWQABXEACSB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x52BC760", Offset = "0x52BB960", VA = "0x1852BC760")]
			[AsyncStateMachine(typeof(KZZCPIHSVFJ<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, JDUFGOJEPGU>> WDFNDJKBCEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "158")]
			protected virtual bool ZNXUBDEXVUJ(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "159")]
			protected virtual bool SMBKNVAWNVD(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "160")]
			protected virtual bool QYLILKRUOWY(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "161")]
			protected virtual bool LQTEHSHEUPE(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "162")]
			protected virtual bool BYIIUBNKETO(Id32<WXMOLFBEQDB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "163")]
			protected virtual bool SOGNFASRBMV(Id32<WXMOLFBEQDB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "164")]
			protected virtual bool CRRZHFDKKPJ(Id32<WXMOLFBEQDB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "165")]
			protected virtual bool VFXGNLUEFFO(Id32<WXMOLFBEQDB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "166")]
			protected virtual bool NLKQDEBWAFK(Id32<WXMOLFBEQDB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "167")]
			protected virtual bool MNKDCYIYTNZ(Id32<WXMOLFBEQDB> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x52B80B0", Offset = "0x52B72B0", VA = "0x1852B80B0", Slot = "168")]
			protected virtual List<MIILYKSZUVS> AOKELDWEKPJ(Id32<WXMOLFBEQDB> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "169")]
			protected virtual void TKVEHVEDJNC(JXYGDPTLLDL a, KTXMTOSWJRV b, DMCBGFQYAXT c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x52B84D0", Offset = "0x52B76D0", VA = "0x1852B84D0", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x52B90D0", Offset = "0x52B82D0", VA = "0x1852B90D0")]
			private KTXMTOSWJRV LWUPXPZTUDP(JXYGDPTLLDL a, DMCBGFQYAXT b, Id32<WXMOLFBEQDB> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x52BAB70", Offset = "0x52B9D70", VA = "0x1852BAB70")]
			private List<AFCJFIIREJS> ODOWNNHBTFU(JXYGDPTLLDL a, DMCBGFQYAXT b, KTXMTOSWJRV c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x52BBD10", Offset = "0x52BAF10", VA = "0x1852BBD10")]
			private List<AFCJFIIREJS> UOXKNYAALWE(JXYGDPTLLDL a, DMCBGFQYAXT b, YSPMOZFFUWS c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x52BA870", Offset = "0x52B9A70", VA = "0x1852BA870")]
			private MIILYKSZUVS MAGSXXQDNSO(List<MIILYKSZUVS> a, YSPMOZFFUWS b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x52B8470", Offset = "0x52B7670", VA = "0x1852B8470")]
			[CompilerGenerated]
			private USPEKNRWVPE DPVPRZGUSHW(AUAIRMEYYLK a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class LPBHNFSDBAS : HNPTTMVJLEI<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class DVLSPHLOUXJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public LPBHNFSDBAS LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public DVLSPHLOUXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x289C940", Offset = "0x289BB40", VA = "0x18289C940")]
				internal int XKGFHHJOQDA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x289C990", Offset = "0x289BB90", VA = "0x18289C990")]
				internal Task<bool> XKLMEODLZOJ(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x28A40D0", Offset = "0x28A32D0", VA = "0x1828A40D0")]
			public LPBHNFSDBAS(RRHCIMKELZN a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x28A3F20", Offset = "0x28A3120", VA = "0x1828A3F20", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class REKWUFLLUBI : MNWSRKOEBSE<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public REKWUFLLUBI LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x28BAD30", Offset = "0x28B9F30", VA = "0x1828BAD30")]
				internal int FEZVBWKFQOH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x28BAB60", Offset = "0x28B9D60", VA = "0x1828BAB60")]
				internal Task<bool> FEUOEPQIHCY(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x28B08E0", Offset = "0x28AFAE0", VA = "0x1828B08E0")]
			public REKWUFLLUBI(RRHCIMKELZN a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x28B06C0", Offset = "0x28AF8C0", VA = "0x1828B06C0", Slot = "151")]
			protected override void JLXBZNPFGSX(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class UYVZMYMDRWY : HNPTTMVJLEI<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xCB5690", Offset = "0xCB4890", VA = "0x180CB5690", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x28BDF40", Offset = "0x28BD140", VA = "0x1828BDF40")]
			public UYVZMYMDRWY(RRHCIMKELZN a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class URYEAZCMRAM : HNPTTMVJLEI<RIWPDYCMIZH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class PWPEITYPPDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public URYEAZCMRAM LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public JXYGDPTLLDL LQIXNKGWRSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> PBZCDABQWMC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> PBTVFTHTNAT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> PBEANZABKSS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> PAYTQSGEBHJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> PATMTLMGRWA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> PDUMEIYTDKF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> PDPFHCEVTYW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> IBNEBONLQFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> IBSKYVHIZQL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> IBXRWCBGJBU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> ICCYTIVDSND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> IASCMNLWELS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> IAXJJUFTNXB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> IBCQHAZQXIK;

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PWPEITYPPDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x28AF7E0", Offset = "0x28AE9E0", VA = "0x1828AF7E0")]
				internal bool XKGFHHJOQDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x28AF830", Offset = "0x28AEA30", VA = "0x1828AF830")]
				internal void XKLMEODLZOJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x28AF8F0", Offset = "0x28AEAF0", VA = "0x1828AF8F0")]
				internal bool XLBGWILEBWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x28AF940", Offset = "0x28AEB40", VA = "0x1828AF940")]
				internal bool XLGNTPFBLHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x28AF890", Offset = "0x28AEA90", VA = "0x1828AF890")]
				internal void XKQTBUXJIZS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x28AF790", Offset = "0x28AE990", VA = "0x1828AF790")]
				internal bool XIVJAMAHCBP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x28ACC80", Offset = "0x28ABE80", VA = "0x1828ACC80")]
				internal bool JMCGANYVJLZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x28ACC20", Offset = "0x28ABE20", VA = "0x1828ACC20")]
				internal void JLWZDHEYAAQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x28ACD20", Offset = "0x28ABF20", VA = "0x1828ACD20")]
				internal bool JMXHPPAKVFJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x28ACCD0", Offset = "0x28ABED0", VA = "0x1828ACCD0")]
				internal bool JMSASIGNLUA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x28ACD70", Offset = "0x28ABF70", VA = "0x1828ACD70")]
				internal void JNHVKCOFOCB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x28ACDD0", Offset = "0x28ABFD0", VA = "0x1828ACDD0")]
				internal bool JNNCHJICXNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x28AF360", Offset = "0x28AE560", VA = "0x1828AF360")]
				internal bool VSBKIMWZFTT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x28AF310", Offset = "0x28AE510", VA = "0x1828AF310")]
				internal bool VRWDLGDBWIK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x28AF2C0", Offset = "0x28AE4C0", VA = "0x1828AF2C0")]
				internal bool VRQWNZJEMXB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x28AF1C0", Offset = "0x28AE3C0", VA = "0x1828AF1C0")]
				internal bool VPQFPJSEWNP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x28AF170", Offset = "0x28AE370", VA = "0x1828AF170")]
				internal bool VPKYSCYHNCG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x28ADA80", Offset = "0x28ACC80", VA = "0x1828ADA80")]
				internal bool PQNCIBMHQEI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x28ADAD0", Offset = "0x28ACCD0", VA = "0x1828ADAD0")]
				internal bool PQSJFIGEZPR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x28ADB20", Offset = "0x28ACD20", VA = "0x1828ADB20")]
				internal void PQXQCPACJBA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x28A6310", Offset = "0x28A5510", VA = "0x1828A6310")]
				internal bool DOJDGPSACEB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x28A6270", Offset = "0x28A5470", VA = "0x1828A6270")]
				internal bool DNTIOVKHZWA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x28A62C0", Offset = "0x28A54C0", VA = "0x1828A62C0")]
				internal bool DNYPMCEFJHJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x28A6400", Offset = "0x28A5600", VA = "0x1828A6400")]
				internal bool DPEEVQTPNXL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x28A6360", Offset = "0x28A5560", VA = "0x1828A6360")]
				internal bool DOOKDWLXLPK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x28ADB80", Offset = "0x28ACD80", VA = "0x1828ADB80")]
				internal bool PRCWZVTZSMJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x28ADBD0", Offset = "0x28ACDD0", VA = "0x1828ADBD0")]
				internal bool PRIDXCNXBXS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x28ADC20", Offset = "0x28ACE20", VA = "0x1828ADC20")]
				internal void PRNKUJHULJB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x28ADC80", Offset = "0x28ACE80", VA = "0x1828ADC80")]
				internal bool PRSRRQBRUUK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x28ADCD0", Offset = "0x28ACED0", VA = "0x1828ADCD0")]
				internal bool PRXYOWVPEFT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x28AD9D0", Offset = "0x28ACBD0", VA = "0x1828AD9D0")]
				internal void POWZDZJCSRO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x28ADA30", Offset = "0x28ACC30", VA = "0x1828ADA30")]
				internal bool PPCGBGDACCX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x28AF270", Offset = "0x28AE470", VA = "0x1828AF270")]
				internal bool VRGITLVJUAJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x28AF210", Offset = "0x28AE410", VA = "0x1828AF210")]
				internal void VRBBWFBMKPA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x28A6450", Offset = "0x28A5650", VA = "0x1828A6450")]
				internal List<AFCJFIIREJS> FQEDOSYNSNR(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x28A63B0", Offset = "0x28A55B0", VA = "0x1828A63B0")]
				internal bool DOTRBDFUVAT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x28A6190", Offset = "0x28A5390", VA = "0x1828A6190")]
				internal int DMNTFGUXVFY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x28A61E0", Offset = "0x28A53E0", VA = "0x1828A61E0")]
				internal Task<bool> DMTACNOVERH(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x28AD040", Offset = "0x28AC240", VA = "0x1828AD040")]
				internal bool KOVBIBGFILB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x28ACFF0", Offset = "0x28AC1F0", VA = "0x1828ACFF0")]
				internal bool KOPUKUMHYZS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x28AD0E0", Offset = "0x28AC2E0", VA = "0x1828AD0E0")]
				internal bool KPFPCOUABHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x28AD090", Offset = "0x28AC290", VA = "0x1828AD090")]
				internal int KPAIFIACRWK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x28ACEC0", Offset = "0x28AC0C0", VA = "0x1828ACEC0")]
				internal Task<bool> KNZZTAEPWRR(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x28ACE70", Offset = "0x28AC070", VA = "0x1828ACE70")]
				internal bool KNUSVTKSNGI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x28ACFA0", Offset = "0x28AC1A0", VA = "0x1828ACFA0")]
				internal bool KOKNNNSKPOJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x28ACF50", Offset = "0x28AC150", VA = "0x1828ACF50")]
				internal bool KOFGQGYNGDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x28ACE20", Offset = "0x28AC020", VA = "0x1828ACE20")]
				internal bool KMZRGSJDBMY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x28AE530", Offset = "0x28AD730", VA = "0x1828AE530")]
				internal bool QMTKZGGXZEI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x28A5DE0", Offset = "0x28A4FE0", VA = "0x1828A5DE0")]
				internal string CFOQAFNXEYF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x28A5D20", Offset = "0x28A4F20", VA = "0x1828A5D20")]
				internal void CEYVILGFCQE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x28A5CD0", Offset = "0x28A4ED0", VA = "0x1828A5CD0")]
				internal int CETOLEMHTEV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x28A5C20", Offset = "0x28A4E20", VA = "0x1828A5C20")]
				internal void CEDTTKEPQWU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x28A5C80", Offset = "0x28A4E80", VA = "0x1828A5C80")]
				internal bool CEJAQQYNAID()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x28A5B80", Offset = "0x28A4D80", VA = "0x1828A5B80")]
				internal bool CDTFYWQUYAC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x28A5BD0", Offset = "0x28A4DD0", VA = "0x1828A5BD0")]
				internal bool CDYMWDKSHLL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x28ACA20", Offset = "0x28ABC20", VA = "0x1828ACA20")]
				internal float IZOBLIPIVGD()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x28AC9C0", Offset = "0x28ABBC0", VA = "0x1828AC9C0")]
				internal void IZIUOBVLLUU(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x28ACAC0", Offset = "0x28ABCC0", VA = "0x1828ACAC0")]
				internal bool IZYPFWDDOCV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x28ACA70", Offset = "0x28ABC70", VA = "0x1828ACA70")]
				internal bool IZTIIPJGERM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x28ACB60", Offset = "0x28ABD60", VA = "0x1828ACB60")]
				internal bool JAJDAJQYGZN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x28AE580", Offset = "0x28AD780", VA = "0x1828AE580")]
				internal bool QNDYTTUSSBA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x28AE5D0", Offset = "0x28AD7D0", VA = "0x1828AE5D0")]
				internal bool QNJFRAOQBMJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x28AE060", Offset = "0x28AD260", VA = "0x1828AE060")]
				internal bool QLYJKFFINKY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x28AE0B0", Offset = "0x28AD2B0", VA = "0x1828AE0B0")]
				internal void QMDQHLZFWWH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x28ACB10", Offset = "0x28ABD10", VA = "0x1828ACB10")]
				internal string JADWDCXAXOE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x28ACBB0", Offset = "0x28ABDB0", VA = "0x1828ACBB0")]
				internal void JATQUXESZWF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x28AE490", Offset = "0x28AD690", VA = "0x1828AE490")]
				internal bool QMIXESTDGHQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x28AE4E0", Offset = "0x28AD6E0", VA = "0x1828AE4E0")]
				internal bool QMOEBZNAPSZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x28AE620", Offset = "0x28AD820", VA = "0x1828AE620")]
				internal bool QOJODIKCWRC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x28AE670", Offset = "0x28AD870", VA = "0x1828AE670")]
				internal void QOOVAPEAGCL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x28AFBD0", Offset = "0x28AEDD0", VA = "0x1828AFBD0")]
				internal bool XNKPXYPAOWR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x28AFB80", Offset = "0x28AED80", VA = "0x1828AFB80")]
				internal bool XNFJARVDFLI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x28AFB30", Offset = "0x28AED30", VA = "0x1828AFB30")]
				internal bool XNACDLBFVZZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x28AFAE0", Offset = "0x28AECE0", VA = "0x1828AFAE0")]
				internal bool XMUVGEHIMOQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x28AFA80", Offset = "0x28AEC80", VA = "0x1828AFA80")]
				internal void XMPOIXNLDDH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x28AFA30", Offset = "0x28AEC30", VA = "0x1828AFA30")]
				internal bool XMKHLQTNTRY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x28AF9E0", Offset = "0x28AEBE0", VA = "0x1828AF9E0")]
				internal bool XMFAOJZQKGP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x28AF990", Offset = "0x28AEB90", VA = "0x1828AF990")]
				internal bool XLZTRDFTAVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x28AFC80", Offset = "0x28AEE80", VA = "0x1828AFC80")]
				internal bool XPATCASFMJL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x28AFC20", Offset = "0x28AEE20", VA = "0x1828AFC20")]
				internal void XOVMETYICYC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x28A54F0", Offset = "0x28A46F0", VA = "0x1828A54F0")]
				internal bool ASYJTMBMBTQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x28A5540", Offset = "0x28A4740", VA = "0x1828A5540")]
				internal bool ATDQQSVJLEZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x28A5450", Offset = "0x28A4650", VA = "0x1828A5450")]
				internal bool ASNVYYNRIWY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x28A54A0", Offset = "0x28A46A0", VA = "0x1828A54A0")]
				internal bool ASTCWFHOSIH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x28A5350", Offset = "0x28A4550", VA = "0x1828A5350")]
				internal object ARSUJXMBXDO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x28A53C0", Offset = "0x28A45C0", VA = "0x1828A53C0")]
				internal void ARYBHEFZGOX(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x28A5590", Offset = "0x28A4790", VA = "0x1828A5590")]
				internal bool AUOMXOEQZGK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x28A55E0", Offset = "0x28A47E0", VA = "0x1828A55E0")]
				internal bool AUTTUUYOIRT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x28AC1D0", Offset = "0x28AB3D0", VA = "0x1828AC1D0")]
				internal int HTKHUXPRIAQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x28AC220", Offset = "0x28AB420", VA = "0x1828AC220")]
				internal void HUACMRXJKIR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x28AC280", Offset = "0x28AB480", VA = "0x1828AC280")]
				internal bool HUFJJYRGTUA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x28AC2D0", Offset = "0x28AB4D0", VA = "0x1828AC2D0")]
				internal bool HUVEBSYYWCB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x28AC180", Offset = "0x28AB380", VA = "0x1828AC180")]
				internal int HRUEQVMMKNW()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x28A5720", Offset = "0x28A4920", VA = "0x1828A5720")]
				internal void AWRIIJUVJZT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x28A56D0", Offset = "0x28A48D0", VA = "0x1828A56D0")]
				internal bool AWMBLDAYAOK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x28A5680", Offset = "0x28A4880", VA = "0x1828A5680")]
				internal bool AWGUNWHARDB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x28A5630", Offset = "0x28A4830", VA = "0x1828A5630")]
				internal bool AWBNQPNDHRS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x28A57E0", Offset = "0x28A49E0", VA = "0x1828A57E0")]
				internal int AXBWCXIQCWL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x28A5780", Offset = "0x28A4980", VA = "0x1828A5780")]
				internal void AWWPFQOSTLC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x28A5880", Offset = "0x28A4A80", VA = "0x1828A5880")]
				internal bool AYHLMLYAHMN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x28A5830", Offset = "0x28A4A30", VA = "0x1828A5830")]
				internal bool AYCEPFECYBE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x28AE910", Offset = "0x28ADB10", VA = "0x1828AE910")]
				internal bool TWADJRMSUHK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x28AE960", Offset = "0x28ADB60", VA = "0x1828AE960")]
				internal object TXALVZIFPMD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x28AE9D0", Offset = "0x28ADBD0", VA = "0x1828AE9D0")]
				internal void TXFSTGCCYXM(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x28AEA60", Offset = "0x28ADC60", VA = "0x1828AEA60")]
				internal bool TXQGNTPXRUE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x28AEAB0", Offset = "0x28ADCB0", VA = "0x1828AEAB0")]
				internal bool TXVNLAJVBFN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x28AD570", Offset = "0x28AC770", VA = "0x1828AD570")]
				internal object? OXZSFULAPKL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x28AD4E0", Offset = "0x28AC6E0", VA = "0x1828AD4E0")]
				internal void OXULINRDFZC(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x28AD630", Offset = "0x28AC830", VA = "0x1828AD630")]
				internal bool OYUTUVMQBDV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x28AD5E0", Offset = "0x28AC7E0", VA = "0x1828AD5E0")]
				internal int OYPMXOSSRSM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x28AD6D0", Offset = "0x28AC8D0", VA = "0x1828AD6D0")]
				internal void OZFHPJAKUAN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x28AD680", Offset = "0x28AC880", VA = "0x1828AD680")]
				internal bool OZAASCGNKPE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x28AD490", Offset = "0x28AC690", VA = "0x1828AD490")]
				internal bool OWJPBSHVRXR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x28AD440", Offset = "0x28AC640", VA = "0x1828AD440")]
				internal bool OWEIELNYIMI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x28AC510", Offset = "0x28AB710", VA = "0x1828AC510")]
				internal int HXINHCCXZSC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x28AC560", Offset = "0x28AB760", VA = "0x1828AC560")]
				internal void HXNUEIWVJDL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x28AC470", Offset = "0x28AB670", VA = "0x1828AC470")]
				internal bool HWXZMOPDGVK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x28AC4C0", Offset = "0x28AB6C0", VA = "0x1828AC4C0")]
				internal bool HXDGJVJAQGT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x28AC3D0", Offset = "0x28AB5D0", VA = "0x1828AC3D0")]
				internal bool HWNLSBBINYS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x28AC420", Offset = "0x28AB620", VA = "0x1828AC420")]
				internal float HWSSPHVFXKB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x28AC320", Offset = "0x28AB520", VA = "0x1828AC320")]
				internal void HWCXXNNNVCA(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x28AC380", Offset = "0x28AB580", VA = "0x1828AC380")]
				internal bool HWIEUUHLENJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x28AC5C0", Offset = "0x28AB7C0", VA = "0x1828AC5C0")]
				internal bool HYYQLEGCXEW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x28AC610", Offset = "0x28AB810", VA = "0x1828AC610")]
				internal bool HZDXILAAGQF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x28A5B30", Offset = "0x28A4D30", VA = "0x1828A5B30")]
				internal float BZKDPXCFIYV()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x28A5AD0", Offset = "0x28A4CD0", VA = "0x1828A5AD0")]
				internal void BZEWSQIHZNM(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x28A5A80", Offset = "0x28A4C80", VA = "0x1828A5A80")]
				internal bool BYZPVJOKQCD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x28A5A30", Offset = "0x28A4C30", VA = "0x1828A5A30")]
				internal bool BYJVDPGSNUC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x28A59E0", Offset = "0x28A4BE0", VA = "0x1828A59E0")]
				internal string BYEOGIMVEIT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x28A5970", Offset = "0x28A4B70", VA = "0x1828A5970")]
				internal void BXZHJBSXUXK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x28A5920", Offset = "0x28A4B20", VA = "0x1828A5920")]
				internal bool BXUALUZALMB(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x28A58D0", Offset = "0x28A4AD0", VA = "0x1828A58D0")]
				internal bool BXOTOOFDCAS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x28AED00", Offset = "0x28ADF00", VA = "0x1828AED00")]
				internal bool UYSYREUCTGM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x28AED50", Offset = "0x28ADF50", VA = "0x1828AED50")]
				internal bool UYYFOLOACRV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x28AEDA0", Offset = "0x28ADFA0", VA = "0x1828AEDA0")]
				internal string UZDMLSHXMDE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x28AEDF0", Offset = "0x28ADFF0", VA = "0x1828AEDF0")]
				internal void UZITIZBUVON(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x28AEBC0", Offset = "0x28ADDC0", VA = "0x1828AEBC0")]
				internal bool UXXXCDSNHNC(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x28AEC10", Offset = "0x28ADE10", VA = "0x1828AEC10")]
				internal bool UYDDZKMKQYL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x28AEC60", Offset = "0x28ADE60", VA = "0x1828AEC60")]
				internal bool UYIKWRGIAJU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x28AECB0", Offset = "0x28ADEB0", VA = "0x1828AECB0")]
				internal bool UYNRTYAFJVD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x28AEB00", Offset = "0x28ADD00", VA = "0x1828AEB00")]
				internal string UXCVNCQXVTS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x28AEB50", Offset = "0x28ADD50", VA = "0x1828AEB50")]
				internal void UXICKJKVFFB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x28ADED0", Offset = "0x28AD0D0", VA = "0x1828ADED0")]
				internal bool PUGAWZFQYKL(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x28ADE80", Offset = "0x28AD080", VA = "0x1828ADE80")]
				internal bool PUATZSLTOZC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x28ADF70", Offset = "0x28AD170", VA = "0x1828ADF70")]
				internal bool PUQORMTLRHD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x28ADF20", Offset = "0x28AD120", VA = "0x1828ADF20")]
				internal bool PULHUFZOHVU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x28ADD90", Offset = "0x28ACF90", VA = "0x1828ADD90")]
				internal string PTKZHYEBMRB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x28ADD20", Offset = "0x28ACF20", VA = "0x1828ADD20")]
				internal void PTFSKRKEDFS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x28ADE30", Offset = "0x28AD030", VA = "0x1828ADE30")]
				internal bool PTVNCLRWFNT(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x28ADDE0", Offset = "0x28ACFE0", VA = "0x1828ADDE0")]
				internal bool PTQGFEXYWCK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x28AE010", Offset = "0x28AD210", VA = "0x1828AE010")]
				internal bool PVWEBBIVVXF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x28ADFC0", Offset = "0x28AD1C0", VA = "0x1828ADFC0")]
				internal bool PVQXDUOYMLW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x28AC700", Offset = "0x28AB900", VA = "0x1828AC700")]
				internal string ITOVYGXOISC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x28AC750", Offset = "0x28AB950", VA = "0x1828AC750")]
				internal void ITUCVNRLSDL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x28AC660", Offset = "0x28AB860", VA = "0x1828AC660")]
				internal bool ITEIDTJTPVK(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x28AC6B0", Offset = "0x28AB8B0", VA = "0x1828AC6B0")]
				internal bool ITJPBADQZGT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x28AC880", Offset = "0x28ABA80", VA = "0x1828AC880")]
				internal bool IUJXNHZDULM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x28AC8D0", Offset = "0x28ABAD0", VA = "0x1828AC8D0")]
				internal bool IUPEKOTBDWV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x28AC7C0", Offset = "0x28AB9C0", VA = "0x1828AC7C0")]
				internal string ITZJSULJBOU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x28AC810", Offset = "0x28ABA10", VA = "0x1828AC810")]
				internal void IUEQQBFGLAD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x28AC920", Offset = "0x28ABB20", VA = "0x1828AC920")]
				internal bool IVEZCJATGEW(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x28AC970", Offset = "0x28ABB70", VA = "0x1828AC970")]
				internal bool IVKFZPUQPQF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x28A6000", Offset = "0x28A5200", VA = "0x1828A6000")]
				internal bool CVQMHBWVRYV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x28A5FB0", Offset = "0x28A51B0", VA = "0x1828A5FB0")]
				internal bool CVLFJVCYINM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x28A5F60", Offset = "0x28A5160", VA = "0x1828A5F60")]
				internal string CVFYMOJAZCD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x28A5EF0", Offset = "0x28A50F0", VA = "0x1828A5EF0")]
				internal void CVARPHPDPQU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x28A6140", Offset = "0x28A5340", VA = "0x1828A6140")]
				internal bool CWLNWCYLDSF(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x28A60F0", Offset = "0x28A52F0", VA = "0x1828A60F0")]
				internal bool CWGGYWENUGW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x28A60A0", Offset = "0x28A52A0", VA = "0x1828A60A0")]
				internal bool CWBABPKQKVN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x28A6050", Offset = "0x28A5250", VA = "0x1828A6050")]
				internal bool CVVTEIQTBKE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x28A5EA0", Offset = "0x28A50A0", VA = "0x1828A5EA0")]
				internal string CUAJCZTQUMB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x28A5E30", Offset = "0x28A5030", VA = "0x1828A5E30")]
				internal void CTVCFSZTLAS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x28AF4F0", Offset = "0x28AE6F0", VA = "0x1828AF4F0")]
				internal bool WUXFVRNTOCU(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x28AF540", Offset = "0x28AE740", VA = "0x1828AF540")]
				internal bool WVCMSYHQXOD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x28AF590", Offset = "0x28AE790", VA = "0x1828AF590")]
				internal bool WVHTQFBOGZM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x28AF5E0", Offset = "0x28AE7E0", VA = "0x1828AF5E0")]
				internal bool WVNANLVLQKV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x28AF630", Offset = "0x28AE830", VA = "0x1828AF630")]
				internal string WVSHKSPIZWE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x28AF680", Offset = "0x28AE880", VA = "0x1828AF680")]
				internal void WVXOHZJGJHN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x28AF6F0", Offset = "0x28AE8F0", VA = "0x1828AF6F0")]
				internal bool WWCVFGDDSSW(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x28AF740", Offset = "0x28AE940", VA = "0x1828AF740")]
				internal bool WWICCMXBCEF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x28AF450", Offset = "0x28AE650", VA = "0x1828AF450")]
				internal bool WTHCRPKOQQA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x28AF4A0", Offset = "0x28AE6A0", VA = "0x1828AF4A0")]
				internal bool WTMJOWEMABJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x28AD1D0", Offset = "0x28AC3D0", VA = "0x1828AD1D0")]
				internal string OEAZFODUQCE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x28AD220", Offset = "0x28AC420", VA = "0x1828AD220")]
				internal void OEGGCUXRZNN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x28AD290", Offset = "0x28AC490", VA = "0x1828AD290")]
				internal bool OEQTXILMSKF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x28AD2E0", Offset = "0x28AC4E0", VA = "0x1828AD2E0")]
				internal bool OEWAUPFKBVO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x28AD330", Offset = "0x28AC530", VA = "0x1828AD330")]
				internal bool OFBHRVZHLGX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x28AD380", Offset = "0x28AC580", VA = "0x1828AD380")]
				internal string OFGOPCTEUSG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x28AD3D0", Offset = "0x28AC5D0", VA = "0x1828AD3D0")]
				internal void OFLVMJNCEDP(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x28AD130", Offset = "0x28AC330", VA = "0x1828AD130")]
				internal bool OCKWBMAPSPK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x28AD180", Offset = "0x28AC380", VA = "0x1828AD180")]
				internal bool OCQCYSUNCAT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x28AEFC0", Offset = "0x28AE1C0", VA = "0x1828AEFC0")]
				internal bool VESEEGLXFUN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x28AEF70", Offset = "0x28AE170", VA = "0x1828AEF70")]
				internal string VEMXGZRZWJE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x28AEF00", Offset = "0x28AE100", VA = "0x1828AEF00")]
				internal void VEHQJSYCMXV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x28AEEB0", Offset = "0x28AE0B0", VA = "0x1828AEEB0")]
				internal bool VECJMMEFDMM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x28AF120", Offset = "0x28AE320", VA = "0x1828AF120")]
				internal bool VFNFTHNMRNX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x28AF0D0", Offset = "0x28AE2D0", VA = "0x1828AF0D0")]
				internal bool VFHYWATPICO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x28AF080", Offset = "0x28AE280", VA = "0x1828AF080")]
				internal string VFCRYTZRYRF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x28AF010", Offset = "0x28AE210", VA = "0x1828AF010")]
				internal void VEXLBNFUPFW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x28AEE60", Offset = "0x28AE060", VA = "0x1828AEE60")]
				internal bool VCWUCXOUYWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x28A5D90", Offset = "0x28A4F90", VA = "0x1828A5D90")]
				internal bool CFJJCYTZVMW(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x28AD870", Offset = "0x28ACA70", VA = "0x1828AD870")]
				internal float PARVRGMFRYW()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x28AD8C0", Offset = "0x28ACAC0", VA = "0x1828AD8C0")]
				internal void PAXCONGDBKF(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x28AD730", Offset = "0x28AC930", VA = "0x1828AD730")]
				internal bool OZMGHRWVNIU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x28AD780", Offset = "0x28AC980", VA = "0x1828AD780")]
				internal bool OZRNEYQSWUD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x28AD7D0", Offset = "0x28AC9D0", VA = "0x1828AD7D0")]
				internal bool OZWUCFKQGFM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x28AD820", Offset = "0x28ACA20", VA = "0x1828AD820")]
				internal int PACAZMENPQV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x28AD920", Offset = "0x28ACB20", VA = "0x1828AD920")]
				internal void PBXLAVBPWOY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x28AD980", Offset = "0x28ACB80", VA = "0x1828AD980")]
				internal bool PCCRYBVNGAH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x28AF400", Offset = "0x28AE600", VA = "0x1828AF400")]
				internal bool WAYMVLGNOUN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x28AF3B0", Offset = "0x28AE5B0", VA = "0x1828AF3B0")]
				internal bool WATFYEMQFJE()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class PWULGASMYOL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string EDUUBXDZEGY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public PWPEITYPPDC BXOYYNWATYZ;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PWULGASMYOL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x28C60F0", Offset = "0x28C52F0", VA = "0x1828C60F0")]
				internal void QMYRWNAVIPR()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class PWZSDHMKHZU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] PNDQBBEEOUX;

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PWZSDHMKHZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x28C6C70", Offset = "0x28C5E70", VA = "0x1828C6C70")]
				internal bool PAMOTZSIINN(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers RFLGLVFQVQO;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x28BDB00", Offset = "0x28BCD00", VA = "0x1828BDB00")]
			public URYEAZCMRAM(RRHCIMKELZN a, RIWPDYCMIZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x28BBFA0", Offset = "0x28BB1A0", VA = "0x1828BBFA0", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class YJWJCFIRDYR : HNPTTMVJLEI<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool DNLWTMQZBPG
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x28D9960", Offset = "0x28D8B60", VA = "0x1828D9960")]
			public YJWJCFIRDYR(RRHCIMKELZN a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x28D95B0", Offset = "0x28D87B0", VA = "0x1828D95B0", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x28D9860", Offset = "0x28D8A60", VA = "0x1828D9860")]
			private static string ZIFRFTGPLMJ(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x28D9400", Offset = "0x28D8600", VA = "0x1828D9400")]
			[CompilerGenerated]
			private object? BCRUVDYKSHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x28D94A0", Offset = "0x28D86A0", VA = "0x1828D94A0")]
			[CompilerGenerated]
			private void BCXBSKSIBSN(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x28D9160", Offset = "0x28D8360", VA = "0x1828D9160")]
			[CompilerGenerated]
			private string BCHHAQKPZKM(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x28D9360", Offset = "0x28D8560", VA = "0x1828D9360")]
			[CompilerGenerated]
			private IReadOnlyList<object> BCMNXXENIVV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x28D90C0", Offset = "0x28D82C0", VA = "0x1828D90C0")]
			[CompilerGenerated]
			private string? BBWTGCWVGNU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x28D9120", Offset = "0x28D8320", VA = "0x1828D9120")]
			[CompilerGenerated]
			private bool BCCADJQSPZD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class QGNVYFELMAT : HNPTTMVJLEI<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class DVLSPHLOUXJ
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
					public DVLSPHLOUXJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000300")]
					[Cpp2IlInjected.Address(RVA = "0x28D0090", Offset = "0x28CF290", VA = "0x1828D0090", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000301")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public QGNVYFELMAT LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public DVLSPHLOUXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x28C18C0", Offset = "0x28C0AC0", VA = "0x1828C18C0")]
				internal string XKGFHHJOQDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x28C1910", Offset = "0x28C0B10", VA = "0x1828C1910")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void XKLMEODLZOJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x28C1070", Offset = "0x28C0270", VA = "0x1828C1070")]
				internal int XJVRMTVTXGI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x28C14C0", Offset = "0x28C06C0", VA = "0x1828C14C0")]
				internal void XKAYKAPRGRR(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x28C7760", Offset = "0x28C6960", VA = "0x1828C7760")]
			public QGNVYFELMAT(RRHCIMKELZN a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x28C7430", Offset = "0x28C6630", VA = "0x1828C7430", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class VYVCPMRVRNS : HNPTTMVJLEI<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class PLYECEGTBAG
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
					public PLYECEGTBAG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x28CFD50", Offset = "0x28CEF50", VA = "0x1828CFD50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public PLYECEGTBAG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000317")]
					[Cpp2IlInjected.Address(RVA = "0x28D0640", Offset = "0x28CF840", VA = "0x1828D0640", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000318")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public VYVCPMRVRNS LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PLYECEGTBAG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x28C5960", Offset = "0x28C4B60", VA = "0x1828C5960")]
				internal string XKGFHHJOQDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x28C59B0", Offset = "0x28C4BB0", VA = "0x1828C59B0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void XKLMEODLZOJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x28C5880", Offset = "0x28C4A80", VA = "0x1828C5880")]
				internal int XJVRMTVTXGI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x28C58D0", Offset = "0x28C4AD0", VA = "0x1828C58D0")]
				internal Task<bool> XKAYKAPRGRR(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x28C5B60", Offset = "0x28C4D60", VA = "0x1828C5B60")]
				internal string XLBGWILEBWK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x28C5BB0", Offset = "0x28C4DB0", VA = "0x1828C5BB0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void XLGNTPFBLHT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x28C5A80", Offset = "0x28C4C80", VA = "0x1828C5A80")]
				internal bool XKQTBUXJIZS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x28C5AD0", Offset = "0x28C4CD0", VA = "0x1828C5AD0")]
				internal void XKVZZBRGSLB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x28C57A0", Offset = "0x28C49A0", VA = "0x1828C57A0")]
				internal bool XIQCDFGJSQG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x28C57F0", Offset = "0x28C49F0", VA = "0x1828C57F0")]
				internal void XIVJAMAHCBP(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x28C55E0", Offset = "0x28C47E0", VA = "0x1828C55E0")]
				internal float JMCGANYVJLZ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x28C5550", Offset = "0x28C4750", VA = "0x1828C5550")]
				internal void JLWZDHEYAAQ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x28C56D0", Offset = "0x28C48D0", VA = "0x1828C56D0")]
				internal int JMMTVBMQCIR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x28C5630", Offset = "0x28C4830", VA = "0x1828C5630")]
				internal void JMHMXUSSSXI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x28C5730", Offset = "0x28C4930", VA = "0x1828C5730")]
				internal bool JMXHPPAKVFJ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x28D3380", Offset = "0x28D2580", VA = "0x1828D3380")]
			public VYVCPMRVRNS(RRHCIMKELZN a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x28D2A20", Offset = "0x28D1C20", VA = "0x1828D2A20", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class FCSKELZOZIT : HNPTTMVJLEI<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class DVLSPHLOUXJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public FCSKELZOZIT LQBDIDDTHZG;

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public DVLSPHLOUXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x28C1820", Offset = "0x28C0A20", VA = "0x1828C1820")]
				internal Dictionary<string, EnumChoiceData> XKGFHHJOQDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x28C1CB0", Offset = "0x28C0EB0", VA = "0x1828C1CB0")]
				internal int XKLMEODLZOJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x28C1250", Offset = "0x28C0450", VA = "0x1828C1250")]
				internal void XJVRMTVTXGI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x28C15A0", Offset = "0x28C07A0", VA = "0x1828C15A0")]
				internal bool XKAYKAPRGRR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x28C2C90", Offset = "0x28C1E90", VA = "0x1828C2C90")]
			public FCSKELZOZIT(RRHCIMKELZN a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x28C29E0", Offset = "0x28C1BE0", VA = "0x1828C29E0", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class LHJHMSMUZOC : HNPTTMVJLEI<QEHQXZEAXBV>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class DVLSPHLOUXJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public LHJHMSMUZOC LQBDIDDTHZG;

				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public DVLSPHLOUXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x28C1710", Offset = "0x28C0910", VA = "0x1828C1710")]
				internal void XKGFHHJOQDA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x28C4980", Offset = "0x28C3B80", VA = "0x1828C4980")]
			public LHJHMSMUZOC(RRHCIMKELZN a, QEHQXZEAXBV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x28C4800", Offset = "0x28C3A00", VA = "0x1828C4800", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class OJFQKMCQZQQ<a> : KZZCPIHSVFJ<a> where a : notnull, QETHEYJYHHK
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override HYUPTAFTQGX? YGZRBHYMZDK
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x5A86040", Offset = "0x5A85240", VA = "0x185A86040", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x5A860A0", Offset = "0x5A852A0", VA = "0x185A860A0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xCC8F80", Offset = "0xCC8180", VA = "0x180CC8F80", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x5A86080", Offset = "0x5A85280", VA = "0x185A86080")]
			public OJFQKMCQZQQ(RRHCIMKELZN a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class KPHJMWVHYIA : OJFQKMCQZQQ<FZXISYRTZOJ>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class PWPEITYPPDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public KPHJMWVHYIA LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PWPEITYPPDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x28C5F80", Offset = "0x28C5180", VA = "0x1828C5F80")]
				internal object XKGFHHJOQDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x28C5FE0", Offset = "0x28C51E0", VA = "0x1828C5FE0")]
				internal void XKLMEODLZOJ(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x28C5EA0", Offset = "0x28C50A0", VA = "0x1828C5EA0")]
				internal void XJVRMTVTXGI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? CMIGIATJYGG;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x28C4530", Offset = "0x28C3730", VA = "0x1828C4530")]
			public KPHJMWVHYIA(RRHCIMKELZN a, FZXISYRTZOJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x28C3FD0", Offset = "0x28C31D0", VA = "0x1828C3FD0", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class AXAFDHOZUQT : HNPTTMVJLEI<BWXFTTYJPYA>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public AXAFDHOZUQT LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<VUAUFXZXUVR>> DAKSKGADANL;

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0x28D1B70", Offset = "0x28D0D70", VA = "0x1828D1B70")]
				internal int XKLMEODLZOJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x28D1510", Offset = "0x28D0710", VA = "0x1828D1510")]
				internal void XJVRMTVTXGI(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class UINXSDSDFFY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<VUAUFXZXUVR> PASFQHTCSEP;

				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UINXSDSDFFY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600033B")]
				[Cpp2IlInjected.Address(RVA = "0x28D1070", Offset = "0x28D0270", VA = "0x1828D1070")]
				internal bool XLBGWILEBWK(Id32<VUAUFXZXUVR> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x28BE840", Offset = "0x28BDA40", VA = "0x1828BE840")]
			public AXAFDHOZUQT(RRHCIMKELZN a, BWXFTTYJPYA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x28BE330", Offset = "0x28BD530", VA = "0x1828BE330", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class EJKVKCCREOH : HNPTTMVJLEI<MXRXEKMGBDS>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0xAE8340", Offset = "0xAE7540", VA = "0x180AE8340", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x28C23B0", Offset = "0x28C15B0", VA = "0x1828C23B0")]
			public EJKVKCCREOH(RRHCIMKELZN a, MXRXEKMGBDS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class JFYSQJRNVTK : HNPTTMVJLEI<DOZGNJFMMDH>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0xBE2BA0", Offset = "0xBE1DA0", VA = "0x180BE2BA0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x28C3860", Offset = "0x28C2A60", VA = "0x1828C3860")]
			public JFYSQJRNVTK(RRHCIMKELZN a, DOZGNJFMMDH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "134")]
			protected override bool EMBMGBLSZCU(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class LXFLELCLXNC : HNPTTMVJLEI<WXIMLBDKRTH>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xBDF4C0", Offset = "0xBDE6C0", VA = "0x180BDF4C0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000344")]
				[Cpp2IlInjected.Address(RVA = "0x28C4A60", Offset = "0x28C3C60", VA = "0x1828C4A60", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool DNLWTMQZBPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x28C49F0", Offset = "0x28C3BF0", VA = "0x1828C49F0")]
			public LXFLELCLXNC(RRHCIMKELZN a, WXIMLBDKRTH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class NLGSMZGQUWY : HNPTTMVJLEI<PTQQAUQKFIB>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xBECF30", Offset = "0xBEC130", VA = "0x180BECF30", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x28C4BC0", Offset = "0x28C3DC0", VA = "0x1828C4BC0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool DNLWTMQZBPG
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x28C4B50", Offset = "0x28C3D50", VA = "0x1828C4B50")]
			public NLGSMZGQUWY(RRHCIMKELZN a, PTQQAUQKFIB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class FEEWTMTXYYR : MNWSRKOEBSE<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public FEEWTMTXYYR LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x28D1200", Offset = "0x28D0400", VA = "0x1828D1200")]
				internal float FEZVBWKFQOH()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0x28D1160", Offset = "0x28D0360", VA = "0x1828D1160")]
				internal void FEUOEPQIHCY(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x28C2F70", Offset = "0x28C2170", VA = "0x1828C2F70")]
			public FEEWTMTXYYR(RRHCIMKELZN a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x28C2D00", Offset = "0x28C1F00", VA = "0x1828C2D00", Slot = "151")]
			protected override void JLXBZNPFGSX(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class WXMXGNPKFNQ : HNPTTMVJLEI<OTYANHQIPAT>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x28D38B0", Offset = "0x28D2AB0", VA = "0x1828D38B0")]
			public WXMXGNPKFNQ(RRHCIMKELZN a, OTYANHQIPAT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class CODWFEHMOOG : HNPTTMVJLEI<YVJUAAJBGWX>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x28BECF0", Offset = "0x28BDEF0", VA = "0x1828BECF0")]
			public CODWFEHMOOG(RRHCIMKELZN a, YVJUAAJBGWX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class NWLKKMJKGOP : HNPTTMVJLEI<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public NWLKKMJKGOP LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x28D1820", Offset = "0x28D0A20", VA = "0x1828D1820")]
				internal bool XKGFHHJOQDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0x28D1FA0", Offset = "0x28D11A0", VA = "0x1828D1FA0")]
				internal void XKLMEODLZOJ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x28C4F20", Offset = "0x28C4120", VA = "0x1828C4F20")]
			public NWLKKMJKGOP(RRHCIMKELZN a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x28C4C90", Offset = "0x28C3E90", VA = "0x1828C4C90", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class QDJMZEQPSUX : HNPTTMVJLEI<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public QDJMZEQPSUX LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> CVEMAYQOFJC;

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x28D19B0", Offset = "0x28D0BB0", VA = "0x1828D19B0")]
				internal object? XKGFHHJOQDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x28D2450", Offset = "0x28D1650", VA = "0x1828D2450")]
				internal bool XKVZZBRGSLB(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x28D20D0", Offset = "0x28D12D0", VA = "0x1828D20D0")]
				internal void XKLMEODLZOJ(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x28D13D0", Offset = "0x28D05D0", VA = "0x1828D13D0")]
				internal string XJVRMTVTXGI(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x28D17D0", Offset = "0x28D09D0", VA = "0x1828D17D0")]
				internal IReadOnlyList<object> XKAYKAPRGRR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x28D24D0", Offset = "0x28D16D0", VA = "0x1828D24D0")]
				internal bool XLBGWILEBWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0x28D2540", Offset = "0x28D1740", VA = "0x1828D2540")]
				internal bool XLGNTPFBLHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x28D2320", Offset = "0x28D1520", VA = "0x1828D2320")]
				internal void XKQTBUXJIZS(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x28C73C0", Offset = "0x28C65C0", VA = "0x1828C73C0")]
			public QDJMZEQPSUX(RRHCIMKELZN a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x28C6CE0", Offset = "0x28C5EE0", VA = "0x1828C6CE0", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class SQLFXPTHPCV : HNPTTMVJLEI<JBRFOZTXMNU>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class PLYECEGTBAG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int MQPKRFBAECL;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PLYECEGTBAG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x28C5510", Offset = "0x28C4710", VA = "0x1828C5510")]
				internal bool BJYTQPSGGAD(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class KZUDVNTIBMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public SQLFXPTHPCV LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> PHXHJYBFTNN;

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public KZUDVNTIBMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x28C4640", Offset = "0x28C3840", VA = "0x1828C4640")]
				internal int XKGFHHJOQDA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0x28C46E0", Offset = "0x28C38E0", VA = "0x1828C46E0")]
				internal void XKLMEODLZOJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0x28C4590", Offset = "0x28C3790", VA = "0x1828C4590")]
				internal string? XJVRMTVTXGI()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000369")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x28C9530", Offset = "0x28C8730", VA = "0x1828C9530")]
			public SQLFXPTHPCV(RRHCIMKELZN a, JBRFOZTXMNU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x28C9030", Offset = "0x28C8230", VA = "0x1828C9030")]
			private int BDIZEXJRXPN(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x28C9410", Offset = "0x28C8610", VA = "0x1828C9410")]
			private void WUFNONHXZHB(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x28C90C0", Offset = "0x28C82C0", VA = "0x1828C90C0", Slot = "145")]
			protected sealed override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class THCDZHJGVXQ : QPMBLHHIIWW<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0xCC9BF0", Offset = "0xCC8DF0", VA = "0x180CC9BF0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x28CA700", Offset = "0x28C9900", VA = "0x1828CA700")]
			public THCDZHJGVXQ(RRHCIMKELZN a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class TZTBRBBFPMQ : MNWSRKOEBSE<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public TZTBRBBFPMQ LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x28D1350", Offset = "0x28D0550", VA = "0x1828D1350")]
				internal int FEZVBWKFQOH()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x28D10C0", Offset = "0x28D02C0", VA = "0x1828D10C0")]
				internal void FEUOEPQIHCY(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x28CAC10", Offset = "0x28C9E10", VA = "0x1828CAC10")]
			public TZTBRBBFPMQ(RRHCIMKELZN a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x28CA9A0", Offset = "0x28C9BA0", VA = "0x1828CA9A0", Slot = "151")]
			protected override void JLXBZNPFGSX(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class OXJHRMJWXYS : HNPTTMVJLEI<FNURZJZDEOD>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public OXJHRMJWXYS LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<VUAUFXZXUVR>> DAKSKGADANL;

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0x28D1CB0", Offset = "0x28D0EB0", VA = "0x1828D1CB0")]
				internal int XKLMEODLZOJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x28D1670", Offset = "0x28D0870", VA = "0x1828D1670")]
				internal void XJVRMTVTXGI(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class UINXSDSDFFY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<VUAUFXZXUVR> PASFQHTCSEP;

				[Cpp2IlInjected.Token(Token = "0x6000383")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UINXSDSDFFY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0x28D1020", Offset = "0x28D0220", VA = "0x1828D1020")]
				internal bool XLBGWILEBWK(Id32<VUAUFXZXUVR> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x28C54A0", Offset = "0x28C46A0", VA = "0x1828C54A0")]
			public OXJHRMJWXYS(RRHCIMKELZN a, FNURZJZDEOD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x28C4F90", Offset = "0x28C4190", VA = "0x1828C4F90", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class EYJWMRCNZDO : HNPTTMVJLEI<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public EYJWMRCNZDO LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000388")]
				[Cpp2IlInjected.Address(RVA = "0x28D1870", Offset = "0x28D0A70", VA = "0x1828D1870")]
				internal bool XKGFHHJOQDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x28D1F10", Offset = "0x28D1110", VA = "0x1828D1F10")]
				internal void XKLMEODLZOJ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x28C2970", Offset = "0x28C1B70", VA = "0x1828C2970")]
			public EYJWMRCNZDO(RRHCIMKELZN a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x28C27A0", Offset = "0x28C19A0", VA = "0x1828C27A0", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class TMTLTRLFUMI : HNPTTMVJLEI<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public TMTLTRLFUMI LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0x28D1960", Offset = "0x28D0B60", VA = "0x1828D1960")]
				internal bool XKGFHHJOQDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x28D1AE0", Offset = "0x28D0CE0", VA = "0x1828D1AE0")]
				internal void XKLMEODLZOJ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x28CA930", Offset = "0x28C9B30", VA = "0x1828CA930")]
			public TMTLTRLFUMI(RRHCIMKELZN a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x28CA760", Offset = "0x28C9960", VA = "0x1828CA760", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class RNEEVLUBCZM : HNPTTMVJLEI<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public RNEEVLUBCZM LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000392")]
				[Cpp2IlInjected.Address(RVA = "0x28D18C0", Offset = "0x28D0AC0", VA = "0x1828D18C0")]
				internal int XKGFHHJOQDA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x28D1E80", Offset = "0x28D1080", VA = "0x1828D1E80")]
				internal void XKLMEODLZOJ(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x28C7DA0", Offset = "0x28C6FA0", VA = "0x1828C7DA0")]
			public RNEEVLUBCZM(RRHCIMKELZN a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x28C7B50", Offset = "0x28C6D50", VA = "0x1828C7B50", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class NSBGXJZHQMF
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log JXFMMOBINLM;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class SBRDRTBXASO<a> : HNPTTMVJLEI<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class WZNNQLIGBBT
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
					public WZNNQLIGBBT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C8")]
					[Cpp2IlInjected.Address(RVA = "0x3CE5020", Offset = "0x3CE4220", VA = "0x183CE5020", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C9")]
					[Cpp2IlInjected.Address(RVA = "0x3CE5360", Offset = "0x3CE4560", VA = "0x183CE5360", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload TFVCVMFOQXA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public SBRDRTBXASO<a> LQBDIDDTHZG;

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public WZNNQLIGBBT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x67B7F40", Offset = "0x67B7140", VA = "0x1867B7F40")]
				[AsyncStateMachine(typeof(SBRDRTBXASO<>.WZNNQLIGBBT.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task UVWTFXIIYTM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0x67B7E20", Offset = "0x67B7020", VA = "0x1867B7E20")]
				internal void FQZFFEIAQJH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class IKBUDXRCJAL
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
					public IKBUDXRCJAL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x3CF8810", Offset = "0x3CF7A10", VA = "0x183CF8810", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public IKBUDXRCJAL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DD")]
					[Cpp2IlInjected.Address(RVA = "0x3CF9F80", Offset = "0x3CF9180", VA = "0x183CF9F80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DE")]
					[Cpp2IlInjected.Address(RVA = "0x3CFA680", Offset = "0x3CF9880", VA = "0x183CFA680", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public JXYGDPTLLDL.OITIPDYSPDR EGGIGJUHXJO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string PWPKOUJHTCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string TIUQZHHZJQT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public SBRDRTBXASO<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper NADHMDHDIFV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool OHKNIYOJAOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action QYXNOWMZJHZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool JWTNLBXQMWX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string MVUACDYOAUF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action YRRKIHDSUPL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action RVRHYOLHNYB;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public IKBUDXRCJAL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x4FFE020", Offset = "0x4FFD220", VA = "0x184FFE020")]
				internal void RCNNNNSXRWG(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x4FFE070", Offset = "0x4FFD270", VA = "0x184FFE070")]
				internal void RCSUKUMVBHP(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
				internal string TEGYPTFUQNL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x4FFE330", Offset = "0x4FFD530", VA = "0x184FFE330")]
				internal void TEBRSMLXHCC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0x4FFE1C0", Offset = "0x4FFD3C0", VA = "0x184FFE1C0")]
				internal bool TDWKVFRZXQT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0x4FFE290", Offset = "0x4FFD490", VA = "0x184FFE290")]
				internal char TDRDXYYCOFK((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
				internal string? TDLXASEFEUB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0xCB3340", Offset = "0xCB2540", VA = "0x180CB3340")]
				internal bool TDGQDLKHVIS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x4FFE1D0", Offset = "0x4FFD3D0", VA = "0x184FFE1D0")]
				internal void TDBJGEQKLXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x4FFE1C0", Offset = "0x4FFD3C0", VA = "0x184FFE1C0")]
				internal bool TCWCIXWNCMA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x4FFE120", Offset = "0x4FFD320", VA = "0x184FFE120")]
				[AsyncStateMachine(typeof(SBRDRTBXASO<>.IKBUDXRCJAL.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void TCQVLRCPTAR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x4FFE520", Offset = "0x4FFD720", VA = "0x184FFE520")]
				internal void THWPOMGJUET(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x4FFDD70", Offset = "0x4FFCF70", VA = "0x184FFDD70")]
				[AsyncStateMachine(typeof(SBRDRTBXASO<>.IKBUDXRCJAL.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task APTCFOUUTVW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x4FFDF00", Offset = "0x4FFD100", VA = "0x184FFDF00")]
				internal void RBCRGSJQDUV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x4FFDE40", Offset = "0x4FFD040", VA = "0x184FFDE40")]
				internal void LBUHCDJVOAF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x4FFE0E0", Offset = "0x4FFD2E0", VA = "0x184FFE0E0")]
				internal bool TCLOOKISJPI()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class MZZHQOLJBPM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter JMTPIAREJZV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public SBRDRTBXASO<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<JXYGDPTLLDL.DZKTFGCGNMH> YPWAGYGQNRI;

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public MZZHQOLJBPM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x58E9EA0", Offset = "0x58E90A0", VA = "0x1858E9EA0")]
				internal bool VFQSHBQUUMO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x58E9DD0", Offset = "0x58E8FD0", VA = "0x1858E9DD0")]
				internal void HWEKYQECVDE(JXYGDPTLLDL.DZKTFGCGNMH a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class NAEONVFGLAV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool IXJDTAUFQZH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public AFCJFIIREJS POOXJJMLOXV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public AFCJFIIREJS TLYWNZNNZUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public AFCJFIIREJS QBYNEFZWXUT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string TCUSDAHPZJO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public MZZHQOLJBPM BXOYYNWATYZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action CYAEOPJDHLY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action YPQTJRMTEFZ;

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public NAEONVFGLAV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0xCD48C0", Offset = "0xCD3AC0", VA = "0x180CD48C0")]
				internal bool HBGLDODKWUK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x5956690", Offset = "0x5955890", VA = "0x185956690")]
				internal void UPPKPPFBCAL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x5956790", Offset = "0x5955990", VA = "0x185956790")]
				internal void VFLLJUWXLBF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x5956670", Offset = "0x5955870", VA = "0x185956670")]
				internal void VIBXAEVPDSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x5957260", Offset = "0x5956460", VA = "0x185957260")]
				internal void VGBGBPEPNJG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0x5956C00", Offset = "0x5955E00", VA = "0x185956C00")]
				internal void VFVZEIKSDXX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x5956670", Offset = "0x5955870", VA = "0x185956670")]
				internal void HVZEBJKFLRV()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class MZOTWAXOISU
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
					public MZOTWAXOISU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003ED")]
					[Cpp2IlInjected.Address(RVA = "0x3D09990", Offset = "0x3D08B90", VA = "0x183D09990", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EE")]
					[Cpp2IlInjected.Address(RVA = "0x3D09FC0", Offset = "0x3D091C0", VA = "0x183D09FC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool VTEDWCEIGWR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public NAEONVFGLAV BWZEGTOIRQY;

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public MZOTWAXOISU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x58B1840", Offset = "0x58B0A40", VA = "0x1858B1840")]
				[AsyncStateMachine(typeof(SBRDRTBXASO<>.MZOTWAXOISU.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task EMNEBYCGNUB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0x58B1910", Offset = "0x58B0B10", VA = "0x1858B1910")]
				internal void VIHDXLPMNEB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class MZUATHRLSED
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
					public MZUATHRLSED <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F2")]
					[Cpp2IlInjected.Address(RVA = "0x3D09390", Offset = "0x3D08590", VA = "0x183D09390", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F3")]
					[Cpp2IlInjected.Address(RVA = "0x3D09930", Offset = "0x3D08B30", VA = "0x183D09930", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload IIXKPNCROXG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public NAEONVFGLAV BXELEAIGBCH;

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public MZUATHRLSED()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F0")]
				[Cpp2IlInjected.Address(RVA = "0x58E9D00", Offset = "0x58E8F00", VA = "0x1858E9D00")]
				[AsyncStateMachine(typeof(SBRDRTBXASO<>.MZUATHRLSED.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task KUCQFLIZLZC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0x58E9BE0", Offset = "0x58E8DE0", VA = "0x1858E9BE0")]
				internal void HVTXECQICGM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class YUQGTSLQFWD
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
					public YUQGTSLQFWD <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F9")]
					[Cpp2IlInjected.Address(RVA = "0x3D08EB0", Offset = "0x3D080B0", VA = "0x183D08EB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003FA")]
					[Cpp2IlInjected.Address(RVA = "0x3D09330", Offset = "0x3D08530", VA = "0x183D09330", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public SBRDRTBXASO<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload MNQQRVBLPYM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public JXYGDPTLLDL.DZKTFGCGNMH EGGIGJUHXJO;

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public YUQGTSLQFWD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x3EC0E40", Offset = "0x3EC0040", VA = "0x183EC0E40")]
				[AsyncStateMachine(typeof(SBRDRTBXASO<>.YUQGTSLQFWD.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task RKZHLHOBIAW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x3EC0B80", Offset = "0x3EBFD80", VA = "0x183EC0B80")]
				internal bool LCGCGJZULAY(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F7")]
				[Cpp2IlInjected.Address(RVA = "0x3EC0D20", Offset = "0x3EBFF20", VA = "0x183EC0D20")]
				internal void LCVWYEHMNIZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F8")]
				[Cpp2IlInjected.Address(RVA = "0x3EC0C60", Offset = "0x3EBFE60", VA = "0x183EC0C60")]
				internal void LCQQAXNPDXQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class CNIVDJMUJNC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string HSQGLLXNJSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public AFCJFIIREJS COUGBZDWAWG;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public CNIVDJMUJNC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x3D9E610", Offset = "0x3D9D810", VA = "0x183D9E610")]
				internal string? TTWLHFSJVWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xC64B10", Offset = "0xC63D10", VA = "0x180C64B10")]
				internal bool TTREJYYMMKW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FE")]
				[Cpp2IlInjected.Address(RVA = "0x3D9E5A0", Offset = "0x3D9D7A0", VA = "0x183D9E5A0")]
				internal void TTLXMSEPCZN(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool INDCPGOGCUQ;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log JXFMMOBINLM
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x5F6DF90", Offset = "0x5F6D190", VA = "0x185F6DF90")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool DNLWTMQZBPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000398")]
				[Cpp2IlInjected.Address(RVA = "0x5F700C0", Offset = "0x5F6F2C0", VA = "0x185F700C0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected JXYGDPTLLDL LQIXNKGWRSA
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xAC1920", Offset = "0xAC0B20", VA = "0x180AC1920")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xAC1960", Offset = "0xAC0B60", VA = "0x180AC1960")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> IFNHNOOESUD
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xB5C290", Offset = "0xB5B490", VA = "0x180B5C290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0xE98640", Offset = "0xE97840", VA = "0x180E98640")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected WTLEQAXFPCB OLTFGWKEMIC
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xD11790", Offset = "0xD10990", VA = "0x180D11790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x14B7AB0", Offset = "0x14B6CB0", VA = "0x1814B7AB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected KTXMTOSWJRV RTEYYFCWAKQ
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xD117A0", Offset = "0xD109A0", VA = "0x180D117A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x14B8EE0", Offset = "0x14B80E0", VA = "0x1814B8EE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x407ACD0", Offset = "0x4079ED0", VA = "0x18407ACD0")]
			protected SBRDRTBXASO(RRHCIMKELZN a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x5F6BE10", Offset = "0x5F6B010", VA = "0x185F6BE10", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x5F6BDC0", Offset = "0x5F6AFC0", VA = "0x185F6BDC0", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x5F6BE60", Offset = "0x5F6B060", VA = "0x185F6BE60", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x5F6C980", Offset = "0x5F6BB80", VA = "0x185F6C980")]
			private void ICONQXEVPJL(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5F6DD40", Offset = "0x5F6CF40", VA = "0x185F6DD40", Slot = "145")]
			protected sealed override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5F6EC20", Offset = "0x5F6DE20", VA = "0x185F6EC20")]
			private void VEPWNIMLRTV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5F6F340", Offset = "0x5F6E540", VA = "0x185F6F340")]
			private void YBKWUFBGKRP(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "151")]
			protected virtual void LNVHVQPQBOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x5F6FF10", Offset = "0x5F6F110", VA = "0x185F6FF10")]
			private void ZTRPUIMYABG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x5F6BEB0", Offset = "0x5F6B0B0", VA = "0x185F6BEB0")]
			private void GFTQINIVDQF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x5F6CF80", Offset = "0x5F6C180", VA = "0x185F6CF80")]
			private void JHMPDYHADJJ(JXYGDPTLLDL.DZKTFGCGNMH a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x5F6BBA0", Offset = "0x5F6ADA0", VA = "0x185F6BBA0")]
			private void BKYYJETKXTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x5F6C950", Offset = "0x5F6BB50", VA = "0x185F6C950")]
			protected void HWNTJEEVRKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x5F6FE10", Offset = "0x5F6F010", VA = "0x185F6FE10")]
			private void YIEDSEHLQTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x5F6BDA0", Offset = "0x5F6AFA0", VA = "0x185F6BDA0")]
			private void CJCFAHSDAZN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x5F6F2E0", Offset = "0x5F6E4E0", VA = "0x185F6F2E0")]
			private void VHDXDISBUWW(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x5F6E8E0", Offset = "0x5F6DAE0", VA = "0x185F6E8E0")]
			private string SUPFEYGWTWE((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x5F6FE80", Offset = "0x5F6F080", VA = "0x185F6FE80")]
			private string ZGVJVRJZKYP(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x5F6E7B0", Offset = "0x5F6D9B0", VA = "0x185F6E7B0")]
			[CompilerGenerated]
			private object? SBVTADFJDAX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x5F6E030", Offset = "0x5F6D230", VA = "0x185F6E030")]
			[CompilerGenerated]
			private void SBQMCWLLTPO(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x5F6E7E0", Offset = "0x5F6D9E0", VA = "0x185F6E7E0")]
			[CompilerGenerated]
			private IReadOnlyList<object> SCAZXJZGMMG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x5F6E850", Offset = "0x5F6DA50", VA = "0x185F6E850")]
			[CompilerGenerated]
			private void SCQUPEGYOUH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x5F6DFE0", Offset = "0x5F6D1E0", VA = "0x185F6DFE0")]
			[CompilerGenerated]
			private void SAAIYUIGWCU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x5F6DF50", Offset = "0x5F6D150", VA = "0x185F6DF50")]
			[CompilerGenerated]
			private void RBBTDCMVGVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x5F6CC50", Offset = "0x5F6BE50", VA = "0x185F6CC50")]
			[CompilerGenerated]
			private void IXAKAWJNAJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x5F6EBE0", Offset = "0x5F6DDE0", VA = "0x185F6EBE0")]
			[CompilerGenerated]
			private void TWQNREQUZUH(JXYGDPTLLDL.DZKTFGCGNMH a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class UTHZVXAKAYZ : SBRDRTBXASO<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xBDF4C0", Offset = "0xBDE6C0", VA = "0x180BDF4C0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x28D29C0", Offset = "0x28D1BC0", VA = "0x1828D29C0")]
			public UTHZVXAKAYZ(RRHCIMKELZN a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class SIWQYLZBJTP : SBRDRTBXASO<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type DBJJMYEQZVM
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0x28C8230", Offset = "0x28C7430", VA = "0x1828C8230", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope GABSSRXXKST
				{
					[Cpp2IlInjected.Token(Token = "0x6000408")]
					[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB4310", VA = "0x180AB5110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string FAHWWOIXZMF
				{
					[Cpp2IlInjected.Token(Token = "0x6000409")]
					[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0x11CADE0", Offset = "0x11C9FE0", VA = "0x1811CADE0")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x28C8280", Offset = "0x28C7480", VA = "0x1828C8280", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x28C7E70", Offset = "0x28C7070", VA = "0x1828C7E70", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool EFZUHGNCTYS(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x28C8120", Offset = "0x28C7320", VA = "0x1828C8120", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x28C8090", Offset = "0x28C7290", VA = "0x1828C8090", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x28C7F40", Offset = "0x28C7140", VA = "0x1828C7F40", Slot = "7")]
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
				protected virtual Type DBJJMYEQZVM
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0x28CB030", Offset = "0x28CA230", VA = "0x1828CB030", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers XBVFCBXPDYV
				{
					[Cpp2IlInjected.Token(Token = "0x6000411")]
					[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB4310", VA = "0x180AB5110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string FAHWWOIXZMF
				{
					[Cpp2IlInjected.Token(Token = "0x6000412")]
					[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0x11CADE0", Offset = "0x11C9FE0", VA = "0x1811CADE0")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x28CB080", Offset = "0x28CA280", VA = "0x1828CB080", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x28CAC70", Offset = "0x28C9E70", VA = "0x1828CAC70", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool EFZUHGNCTYS(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x28CAF20", Offset = "0x28CA120", VA = "0x1828CAF20", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000416")]
				[Cpp2IlInjected.Address(RVA = "0x28CAD40", Offset = "0x28C9F40", VA = "0x1828CAD40", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x28CADD0", Offset = "0x28C9FD0", VA = "0x1828CADD0", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class DVLSPHLOUXJ
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
					public DVLSPHLOUXJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x28CF030", Offset = "0x28CE230", VA = "0x1828CF030", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public DVLSPHLOUXJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000427")]
					[Cpp2IlInjected.Address(RVA = "0x28CF450", Offset = "0x28CE650", VA = "0x1828CF450", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000428")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public SIWQYLZBJTP LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public WTLEQAXFPCB YVXPPJLPYGY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> CYFLLWDAQXH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> CYAEOPJDHLY;

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public DVLSPHLOUXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x28C2140", Offset = "0x28C1340", VA = "0x1828C2140")]
				internal object? XWSPFWMTCFA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x28C22F0", Offset = "0x28C14F0", VA = "0x1828C22F0")]
				internal bool XYISJYPXZRU(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x28C2220", Offset = "0x28C1420", VA = "0x1828C2220")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void XWXWDDGQLQJ(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x28C0EE0", Offset = "0x28C00E0", VA = "0x1828C0EE0")]
				internal IReadOnlyList<TargetPlayersSelection> UVJCOOXCGVK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x28C2000", Offset = "0x28C1200", VA = "0x1828C2000")]
				internal object? XWCUOCFAZWZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x28C2350", Offset = "0x28C1550", VA = "0x1828C2350")]
				internal bool XYNZHFJVJDD(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x28C1F30", Offset = "0x28C1130", VA = "0x1828C1F30")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void XVMZWHXIXOY(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> CBGPPWWVQVW;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> NCVLITDVNPU;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> ZZAEDVORPGW;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000401")]
				[Cpp2IlInjected.Address(RVA = "0xBECF30", Offset = "0xBEC130", VA = "0x180BECF30", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x28C8EE0", Offset = "0x28C80E0", VA = "0x1828C8EE0")]
			public SIWQYLZBJTP(RRHCIMKELZN a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x28C8370", Offset = "0x28C7570", VA = "0x1828C8370", Slot = "151")]
			protected override void LNVHVQPQBOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x28C88D0", Offset = "0x28C7AD0", VA = "0x1828C88D0")]
			private static IReadOnlyList<TargetPlayersSelection> ORIPYUKTKRJ(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class IHGZETILBGS : DEBRRVHTBGP<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType TWIOBILTJWA
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x28C3800", Offset = "0x28C2A00", VA = "0x1828C3800")]
			public IHGZETILBGS(RRHCIMKELZN a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class AYHGIRIFWXJ : HNPTTMVJLEI<AUAIRMEYYLK>
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x28BE8B0", Offset = "0x28BDAB0", VA = "0x1828BE8B0")]
			public AYHGIRIFWXJ(RRHCIMKELZN a, AUAIRMEYYLK b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class HNPTTMVJLEI<a> : EVXNXIKLNWV, IDisposable where a : notnull, AUAIRMEYYLK
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class UNQTNBOCDEJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public HNPTTMVJLEI<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public RRHCIMKELZN BZQOZHVRJST;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a JTYGKFBHBEU;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UNQTNBOCDEJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0x6276090", Offset = "0x6275290", VA = "0x186276090")]
				internal XNWUZFFCQGA WSKJTLIAZXH(WUASAFDCPMX a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class JPRXFARXXEL
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
					public JPRXFARXXEL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BD")]
					[Cpp2IlInjected.Address(RVA = "0x3CE7BE0", Offset = "0x3CE6DE0", VA = "0x183CE7BE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BE")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string ZVLCSMBPVQV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, JDUFGOJEPGU>> KABQQZJCLMO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public HNPTTMVJLEI<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> DGNNBRBNIGW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public JXYGDPTLLDL LQIXNKGWRSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> QUPRGHJFAEW;

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public JPRXFARXXEL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				internal string FXATHMTWUUP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
				internal void FWVMKFZZLJG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x50EAE50", Offset = "0x50EA050", VA = "0x1850EAE50")]
				[AsyncStateMachine(typeof(HNPTTMVJLEI<>.JPRXFARXXEL.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void FXLHCAHRNRH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class FPWRIHWESUG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public FPWRIHWESUG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x4D5B300", Offset = "0x4D5A500", VA = "0x184D5B300")]
				internal Result<string, JDUFGOJEPGU> XUGDSQACDNL(string a)
				{
					return default(Result<string, JDUFGOJEPGU>);
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
				public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public HNPTTMVJLEI<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x517D8F0", Offset = "0x517CAF0", VA = "0x18517D8F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x517DB40", Offset = "0x517CD40", VA = "0x18517DB40", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public HNPTTMVJLEI<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0x5291150", Offset = "0x5290350", VA = "0x185291150", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C4")]
				[Cpp2IlInjected.Address(RVA = "0x5291450", Offset = "0x5290650", VA = "0x185291450", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly RRHCIMKELZN GLGGEMXYIBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool JZMLWZYFVIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<WXMOLFBEQDB, XNWUZFFCQGA> VFTUFKGBTFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<WXMOLFBEQDB, DMCBGFQYAXT> UESIMYOLNWH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> VPDXLJUESLY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<WXMOLFBEQDB>>? SEFGMFSCULS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<WXMOLFBEQDB>, DMCBGFQYAXT>? IVMHVWPCOQP;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected YGDIPUPKRWC VGVVQLSXQGB
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x4F1DF80", Offset = "0x4F1D180", VA = "0x184F1DF80")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected PZCZATDXERS PZCZATDXERS
			{
				[Cpp2IlInjected.Token(Token = "0x600042D")]
				[Cpp2IlInjected.Address(RVA = "0x4F1B5F0", Offset = "0x4F1A7F0", VA = "0x184F1B5F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected IPREUGGLREP WTRGANRMVAG
			{
				[Cpp2IlInjected.Token(Token = "0x600042E")]
				[Cpp2IlInjected.Address(RVA = "0x4F1CA30", Offset = "0x4F1BC30", VA = "0x184F1CA30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a AUAIRMEYYLK
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<ZTTYPUHCXEP> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0x140FC00", Offset = "0x140EE00", VA = "0x18140FC00", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<ZTTYPUHCXEP>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<QNINDUGEANA> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E750", Offset = "0x4F1D950", VA = "0x184F1E750", Slot = "6")]
				get
				{
					return default(Id32<QNINDUGEANA>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000436")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E5C0", Offset = "0x4F1D7C0", VA = "0x184F1E5C0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E5A0", Offset = "0x4F1D7A0", VA = "0x184F1E5A0", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E8B0", Offset = "0x4F1DAB0", VA = "0x184F1E8B0", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool DNLWTMQZBPG
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<WVCLCRLTTZM> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xD87E30", Offset = "0xD87030", VA = "0x180D87E30", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<WVCLCRLTTZM>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xD96570", Offset = "0xD95770", VA = "0x180D96570")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0xB07320", Offset = "0xB06520", VA = "0x180B07320", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E470", Offset = "0x4F1D670", VA = "0x184F1E470", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E4A0", Offset = "0x4F1D6A0", VA = "0x184F1E4A0", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E4D0", Offset = "0x4F1D6D0", VA = "0x184F1E4D0", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E730", Offset = "0x4F1D930", VA = "0x184F1E730", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E660", Offset = "0x4F1D860", VA = "0x184F1E660", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E540", Offset = "0x4F1D740", VA = "0x184F1E540", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E510", Offset = "0x4F1D710", VA = "0x184F1E510", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0xE56FC0", Offset = "0xE561C0", VA = "0x180E56FC0", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x159D700", Offset = "0x159C900", VA = "0x18159D700")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E500", Offset = "0x4F1D700", VA = "0x184F1E500", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E610", Offset = "0x4F1D810", VA = "0x184F1E610", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E6D0", Offset = "0x4F1D8D0", VA = "0x184F1E6D0", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E700", Offset = "0x4F1D900", VA = "0x184F1E700", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000453")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E640", Offset = "0x4F1D840", VA = "0x184F1E640", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual MLWDYDWGGWS? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual HYUPTAFTQGX? YGZRBHYMZDK
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<FAVTMLJIUOX>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E570", Offset = "0x4F1D770", VA = "0x184F1E570", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<NZKBDZMUQMJ> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E680", Offset = "0x4F1D880", VA = "0x184F1E680", Slot = "68")]
				get
				{
					return default(Id128<NZKBDZMUQMJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<NZKBDZMUQMJ> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E5E0", Offset = "0x4F1D7E0", VA = "0x184F1E5E0", Slot = "59")]
				get
				{
					return default(Id32<NZKBDZMUQMJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<NZKBDZMUQMJ>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<NZKBDZMUQMJ>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x4F1AEB0", Offset = "0x4F1A0B0", VA = "0x184F1AEB0", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xAB9260", Offset = "0xAB8460", VA = "0x180AB9260", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xAB9980", Offset = "0xAB8B80", VA = "0x180AB9980")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0xAB9320", Offset = "0xAB8520", VA = "0x180AB9320", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0xAB92C0", Offset = "0xAB84C0", VA = "0x180AB92C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<FAVTMLJIUOX> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E790", Offset = "0x4F1D990", VA = "0x184F1E790", Slot = "69")]
				get
				{
					return default(Id32<FAVTMLJIUOX>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<FAVTMLJIUOX> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E6B0", Offset = "0x4F1D8B0", VA = "0x184F1E6B0", Slot = "70")]
				get
				{
					return default(Id128<FAVTMLJIUOX>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<FAVTMLJIUOX>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E7B0", Offset = "0x4F1D9B0", VA = "0x184F1E7B0", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<WXMOLFBEQDB, DMCBGFQYAXT> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x4F1E870", Offset = "0x4F1DA70", VA = "0x184F1E870", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<WXMOLFBEQDB, DMCBGFQYAXT>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<WXMOLFBEQDB>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action DNXLDEMZCMD
			{
				[Cpp2IlInjected.Token(Token = "0x600045A")]
				[Cpp2IlInjected.Address(RVA = "0x4F1AF30", Offset = "0x4F1A130", VA = "0x184F1AF30", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x4F1DBF0", Offset = "0x4F1CDF0", VA = "0x184F1DBF0", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate TVKWKDWPNJI
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x4F1A4B0", Offset = "0x4F196B0", VA = "0x184F1A4B0", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x4F1A0D0", Offset = "0x4F192D0", VA = "0x184F1A0D0", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate TTONIWXFMSB
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x4F1DB50", Offset = "0x4F1CD50", VA = "0x184F1DB50", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x4F1C120", Offset = "0x4F1B320", VA = "0x184F1C120", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action VBAISYLJUPH
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x4F1A890", Offset = "0x4F19A90", VA = "0x184F1A890", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x4F1C9D0", Offset = "0x4F1BBD0", VA = "0x184F1C9D0", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action RSWABSIYPLS
			{
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0x4F1D0C0", Offset = "0x4F1C2C0", VA = "0x184F1D0C0", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000464")]
				[Cpp2IlInjected.Address(RVA = "0x4F1A3F0", Offset = "0x4F195F0", VA = "0x184F1A3F0", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<WXMOLFBEQDB>, DMCBGFQYAXT> VRMVJBZZSCN
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x4F1CF90", Offset = "0x4F1C190", VA = "0x184F1CF90", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x4F1B0D0", Offset = "0x4F1A2D0", VA = "0x184F1B0D0", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<WXMOLFBEQDB>, DMCBGFQYAXT> PJIMKOAVOSQ
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x4F1C4C0", Offset = "0x4F1B6C0", VA = "0x184F1C4C0", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x4F1B6E0", Offset = "0x4F1A8E0", VA = "0x184F1B6E0", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<WXMOLFBEQDB>> TDXZUMTRMEO
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x4F1DEC0", Offset = "0x4F1D0C0", VA = "0x184F1DEC0", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x4F19F50", Offset = "0x4F19150", VA = "0x184F19F50", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<WXMOLFBEQDB>, Id32<WXMOLFBEQDB>> EHKZRHYUPZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x4F1C210", Offset = "0x4F1B410", VA = "0x184F1C210", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x4F1DCC0", Offset = "0x4F1CEC0", VA = "0x184F1DCC0", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<WXMOLFBEQDB>, DMCBGFQYAXT> VTKHAEHFXTX
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x4F1B880", Offset = "0x4F1AA80", VA = "0x184F1B880", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x4F1D220", Offset = "0x4F1C420", VA = "0x184F1D220", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<WXMOLFBEQDB>, Id32<WXMOLFBEQDB>> VBVUGLATWKQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x4F1B940", Offset = "0x4F1AB40", VA = "0x184F1B940", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x4F1A010", Offset = "0x4F19210", VA = "0x184F1A010", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> YDPOYRTKBCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x4F1B7C0", Offset = "0x4F1A9C0", VA = "0x184F1B7C0", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x4F1B530", Offset = "0x4F1A730", VA = "0x184F1B530", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x4F1E000", Offset = "0x4F1D200", VA = "0x184F1E000")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected HNPTTMVJLEI(RRHCIMKELZN a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x4F1BA00", Offset = "0x4F1AC00", VA = "0x184F1BA00", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x4F1AB60", Offset = "0x4F19D60", VA = "0x184F1AB60", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x4F1C8F0", Offset = "0x4F1BAF0", VA = "0x184F1C8F0", Slot = "9")]
			public Task<Result<None, JDUFGOJEPGU>> OKTGIEFIXIE(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x4F1CBA0", Offset = "0x4F1BDA0", VA = "0x184F1CBA0")]
			public bool QNJRMPLASTG([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x4F1A550", Offset = "0x4F19750", VA = "0x184F1A550")]
			public bool ZETXDPTAMGV([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x4F1D990", Offset = "0x4F1CB90", VA = "0x184F1D990", Slot = "34")]
			public void WPYHFVHKWMZ(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x4F1AFD0", Offset = "0x4F1A1D0", VA = "0x184F1AFD0", Slot = "35")]
			public Task FDDIYMDBGEF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x4F1D820", Offset = "0x4F1CA20", VA = "0x184F1D820", Slot = "36")]
			[AsyncStateMachine(typeof(HNPTTMVJLEI<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, JDUFGOJEPGU>> UPXZTEAIIQU(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "119")]
			public virtual void YPDXPMRFJAX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xE434F0", Offset = "0xE426F0", VA = "0x180E434F0")]
			protected void IWQLAYYDBKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x1EDB4A0", Offset = "0x1EDA6A0", VA = "0x181EDB4A0")]
			protected void ZPJTBCAHIBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x1EB9FB0", Offset = "0x1EB91B0", VA = "0x181EB9FB0")]
			private void GPAFOPNTXZO([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x4F1D160", Offset = "0x4F1C360", VA = "0x184F1D160", Slot = "122")]
			public virtual Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> TMXXOUUQGJR(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x4F1C400", Offset = "0x4F1B600", VA = "0x184F1C400", Slot = "123")]
			public virtual Task<Result<None, JDUFGOJEPGU>> NROOLRPOZIK(Id32<WXMOLFBEQDB> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "124")]
			public virtual void CHPDKWCJLBM(Id32<WXMOLFBEQDB> sourceId, Id32<WXMOLFBEQDB> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x4F1C2D0", Offset = "0x4F1B4D0", VA = "0x184F1C2D0", Slot = "125")]
			public virtual IEnumerable<USPEKNRWVPE> LWQABXEACSB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x4F1AEF0", Offset = "0x4F1A0F0", VA = "0x184F1AEF0", Slot = "126")]
			public Result<None, JDUFGOJEPGU> ERUXNXHXXHG(string a)
			{
				return default(Result<None, JDUFGOJEPGU>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x4F1D2E0", Offset = "0x4F1C4E0", VA = "0x184F1D2E0", Slot = "50")]
			public bool UCWOYHTFMWM([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x4F1A170", Offset = "0x4F19370", VA = "0x184F1A170")]
			public bool BROQUVOCGYR([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "128")]
			public virtual void YCLLAYMLKYL(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "129")]
			public virtual GNCVAFKXDAO RMTMNSWHSBB([In] NXOLQWSEMWB audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x4F1AA00", Offset = "0x4F19C00", VA = "0x184F1AA00")]
			protected void DYVEXKOZVHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x4F1AEB0", Offset = "0x4F1A0B0", VA = "0x184F1AEB0", Slot = "134")]
			protected virtual bool EMBMGBLSZCU(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x4F1DC90", Offset = "0x4F1CE90", VA = "0x184F1DC90", Slot = "96")]
			public bool YDZRKAVKRIG(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "135")]
			protected virtual bool HBFZTSHTDCT(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected virtual void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x4F1B190", Offset = "0x4F1A390", VA = "0x184F1B190")]
			protected void FTMCSVJTGKD(JXYGDPTLLDL a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, JDUFGOJEPGU>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x4F1C6F0", Offset = "0x4F1B8F0", VA = "0x184F1C6F0")]
			protected void OHEJRCGOAAN(JXYGDPTLLDL a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x4F1A580", Offset = "0x4F19780", VA = "0x184F1A580", Slot = "146")]
			protected virtual void CYQNPSXWDHS(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x4F1C1C0", Offset = "0x4F1B3C0", VA = "0x184F1C1C0", Slot = "90")]
			public void KVDZQDMLOBT(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x4F1D050", Offset = "0x4F1C250", VA = "0x184F1D050", Slot = "91")]
			public CircuitsRigidTransform QTPIFTRRDJC()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "149")]
			public virtual bool VTVKOCSEWFM(Id32<WXMOLFBEQDB> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x4F1D970", Offset = "0x4F1CB70", VA = "0x184F1D970")]
			private void WLXLWJEIHWT([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x4F1A940", Offset = "0x4F19B40", VA = "0x184F1A940")]
			private void DJNQYZSRFMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0xE434F0", Offset = "0xE426F0", VA = "0x180E434F0", Slot = "97")]
			private void QELOZSBUVXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x4F1BBD0", Offset = "0x4F1ADD0", VA = "0x184F1BBD0", Slot = "99")]
			private void JVLLBSHNNPK(Id32<WXMOLFBEQDB> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x4F1B7A0", Offset = "0x4F1A9A0", VA = "0x184F1B7A0", Slot = "101")]
			private void GPNXFGQEVXL(Id32<WXMOLFBEQDB> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x4F1DD80", Offset = "0x4F1CF80", VA = "0x184F1DD80", Slot = "103")]
			private void YTDOVPCPPTJ(Id32<WXMOLFBEQDB> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x4F1CBD0", Offset = "0x4F1BDD0", VA = "0x184F1CBD0", Slot = "104")]
			private void QKZZTRHRGHN(Id32<WXMOLFBEQDB> sourceId, Id32<WXMOLFBEQDB> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x4F1AE90", Offset = "0x4F1A090", VA = "0x184F1AE90", Slot = "105")]
			private void EBJJDNVJJNS(Id32<WXMOLFBEQDB> sourceId, Id32<WXMOLFBEQDB> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x14F40B0", Offset = "0x14F32B0", VA = "0x1814F40B0", Slot = "98")]
			private void QUFNBRVIHJV(Id32<WXMOLFBEQDB> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x4F1D400", Offset = "0x4F1C600", VA = "0x184F1D400", Slot = "100")]
			private void ULHPZGPXBJK(Id32<WXMOLFBEQDB> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x4F1C960", Offset = "0x4F1BB60", VA = "0x184F1C960", Slot = "102")]
			private void PAEHABTWTPI(Id32<WXMOLFBEQDB> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x4F1DFE0", Offset = "0x4F1D1E0", VA = "0x184F1DFE0", Slot = "106")]
			private void ZYTDQXUZCEI(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x4F1DA30", Offset = "0x4F1CC30", VA = "0x184F1DA30", Slot = "150")]
			[AsyncStateMachine(typeof(HNPTTMVJLEI<>.<RequestNameChange>d__224))]
			public Task<Result<None, JDUFGOJEPGU>> WXRLCPNTKLU(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x4F1C370", Offset = "0x4F1B570", VA = "0x184F1C370", Slot = "57")]
			private void MIOMMNXKTIE(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x4F1CB10", Offset = "0x4F1BD10", VA = "0x184F1CB10", Slot = "58")]
			private void PKDPEQRTPCD(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x4F1CBA0", Offset = "0x4F1BDA0", VA = "0x184F1CBA0", Slot = "30")]
			private bool PTYPQXIGCGV([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x4F1A550", Offset = "0x4F19750", VA = "0x184F1A550", Slot = "32")]
			private bool CNFXOCDHABS([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x4F1A490", Offset = "0x4F19690", VA = "0x184F1A490", Slot = "51")]
			private bool CBFQWSQBNIE([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xAB9260", Offset = "0xAB8460", VA = "0x180AB9260")]
			[CompilerGenerated]
			private string NYEQFYBYAPE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x4F1C580", Offset = "0x4F1B780", VA = "0x184F1C580")]
			[CompilerGenerated]
			private void NYJXDEVVKAN(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class HUZUVHWKHZD : QPMBLHHIIWW<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0xCBD4A0", Offset = "0xCBC6A0", VA = "0x180CBD4A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x28C37A0", Offset = "0x28C29A0", VA = "0x1828C37A0")]
			public HUZUVHWKHZD(RRHCIMKELZN a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class FURCVGKRFLX : HNPTTMVJLEI<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class DVLSPHLOUXJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> AZOHSVBWLNA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public FURCVGKRFLX LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> SRXQADZIFQU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> OVCOQCSKIKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public DVLSPHLOUXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XKGFHHJOQDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x28C1BA0", Offset = "0x28C0DA0", VA = "0x1828C1BA0")]
				internal int XKLMEODLZOJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x28C1380", Offset = "0x28C0580", VA = "0x1828C1380")]
				internal void XJVRMTVTXGI(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x28C3310", Offset = "0x28C2510", VA = "0x1828C3310")]
			public FURCVGKRFLX(RRHCIMKELZN a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x28C3030", Offset = "0x28C2230", VA = "0x1828C3030", Slot = "145")]
			protected sealed override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class DEHXTXBCPPR : KZZCPIHSVFJ<AWZLFQYUZEA>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x28BED60", Offset = "0x28BDF60", VA = "0x1828BED60")]
			public DEHXTXBCPPR(RRHCIMKELZN a, AWZLFQYUZEA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class WPSTISJENTP : HNPTTMVJLEI<CIGERQTMQZI>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public WPSTISJENTP LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x28D1910", Offset = "0x28D0B10", VA = "0x1828D1910")]
				internal bool XKGFHHJOQDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x28D1DF0", Offset = "0x28D0FF0", VA = "0x1828D1DF0")]
				internal void XKLMEODLZOJ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x28D3840", Offset = "0x28D2A40", VA = "0x1828D3840")]
			public WPSTISJENTP(RRHCIMKELZN a, CIGERQTMQZI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x28D3670", Offset = "0x28D2870", VA = "0x1828D3670", Slot = "145")]
			protected sealed override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class SYCXPOKTSUK : HNPTTMVJLEI<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class DVLSPHLOUXJ
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
					public DVLSPHLOUXJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F5")]
					[Cpp2IlInjected.Address(RVA = "0x28D03A0", Offset = "0x28CF5A0", VA = "0x1828D03A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F6")]
					[Cpp2IlInjected.Address(RVA = "0x28D05D0", Offset = "0x28CF7D0", VA = "0x1828D05D0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> RYQLGIPVSVC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public SYCXPOKTSUK LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> JONWZONUHFM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> OXDQEOCCYMO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public DVLSPHLOUXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XKGFHHJOQDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x28C19E0", Offset = "0x28C0BE0", VA = "0x1828C19E0")]
				internal int XKLMEODLZOJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x28C1110", Offset = "0x28C0310", VA = "0x1828C1110")]
				internal void XJVRMTVTXGI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x28C1550", Offset = "0x28C0750", VA = "0x1828C1550")]
				internal int XKAYKAPRGRR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x28C1DE0", Offset = "0x28C0FE0", VA = "0x1828C1DE0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> XLBGWILEBWK(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x28C0AD0", Offset = "0x28BFCD0", VA = "0x1828C0AD0")]
				internal int JNNCHJICXNK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x28C0BB0", Offset = "0x28BFDB0", VA = "0x1828C0BB0")]
				internal void PQNCIBMHQEI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x28C0C40", Offset = "0x28BFE40", VA = "0x1828C0C40")]
				internal int PQSJFIGEZPR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x28C0C90", Offset = "0x28BFE90", VA = "0x1828C0C90")]
				internal void PQXQCPACJBA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x28C0D20", Offset = "0x28BFF20", VA = "0x1828C0D20")]
				internal int PRCWZVTZSMJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x28C0D70", Offset = "0x28BFF70", VA = "0x1828C0D70")]
				internal void PRIDXCNXBXS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x28C0E00", Offset = "0x28C0000", VA = "0x1828C0E00")]
				internal int PRNKUJHULJB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x28C0E50", Offset = "0x28C0050", VA = "0x1828C0E50")]
				internal void PRSRRQBRUUK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x28C1EE0", Offset = "0x28C10E0", VA = "0x1828C1EE0")]
				internal float XLGNTPFBLHT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x28C1D00", Offset = "0x28C0F00", VA = "0x1828C1D00")]
				internal void XKQTBUXJIZS(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x28C1D90", Offset = "0x28C0F90", VA = "0x1828C1D90")]
				internal float XKVZZBRGSLB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x28C0F90", Offset = "0x28C0190", VA = "0x1828C0F90")]
				internal void XIQCDFGJSQG(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x28C1020", Offset = "0x28C0220", VA = "0x1828C1020")]
				internal bool XIVJAMAHCBP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x28C07A0", Offset = "0x28BF9A0", VA = "0x1828C07A0")]
				internal void JMCGANYVJLZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x28C0750", Offset = "0x28BF950", VA = "0x1828C0750")]
				internal int JLWZDHEYAAQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x28C0880", Offset = "0x28BFA80", VA = "0x1828C0880")]
				internal void JMMTVBMQCIR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x28C0830", Offset = "0x28BFA30", VA = "0x1828C0830")]
				internal float JMHMXUSSSXI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x28C0960", Offset = "0x28BFB60", VA = "0x1828C0960")]
				internal void JMXHPPAKVFJ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x28C0910", Offset = "0x28BFB10", VA = "0x1828C0910")]
				internal float JMSASIGNLUA()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x28C0A40", Offset = "0x28BFC40", VA = "0x1828C0A40")]
				internal void JNHVKCOFOCB(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0x28C09F0", Offset = "0x28BFBF0", VA = "0x1828C09F0")]
				internal bool JNCOMVUIEQS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x28C0B20", Offset = "0x28BFD20", VA = "0x1828C0B20")]
				internal void JNSJEQCAGYT(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x28CA690", Offset = "0x28C9890", VA = "0x1828CA690")]
			public SYCXPOKTSUK(RRHCIMKELZN a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x28C95A0", Offset = "0x28C87A0", VA = "0x1828C95A0", Slot = "145")]
			protected sealed override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class WYJIPFFMBMR : MNWSRKOEBSE<RecNetImageNode>
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
				public WYJIPFFMBMR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004FB")]
				[Cpp2IlInjected.Address(RVA = "0x28CFBD0", Offset = "0x28CEDD0", VA = "0x1828CFBD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x28D3DF0", Offset = "0x28D2FF0", VA = "0x1828D3DF0")]
			public WYJIPFFMBMR(RRHCIMKELZN a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x28D3920", Offset = "0x28D2B20", VA = "0x1828D3920", Slot = "151")]
			protected override void JLXBZNPFGSX(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x28D3D20", Offset = "0x28D2F20", VA = "0x1828D3D20")]
			[CompilerGenerated]
			private string? UXURTDIWZBR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x28D3C50", Offset = "0x28D2E50", VA = "0x1828D3C50")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void UXPKVWOZPQI(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class DEBRRVHTBGP<a> : HNPTTMVJLEI<a> where a : notnull, PPRLEKQYAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class KZUDVNTIBMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> RYQLGIPVSVC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public DEBRRVHTBGP<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> JONWZONUHFM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> OXDQEOCCYMO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType QXMIVIKTMOW;

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public KZUDVNTIBMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XKGFHHJOQDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x52B7DD0", Offset = "0x52B6FD0", VA = "0x1852B7DD0")]
				internal int XKLMEODLZOJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x52B7B90", Offset = "0x52B6D90", VA = "0x1852B7B90")]
				internal void XJVRMTVTXGI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x52B7D80", Offset = "0x52B6F80", VA = "0x1852B7D80")]
				internal void XKAYKAPRGRR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x52B7FA0", Offset = "0x52B71A0", VA = "0x1852B7FA0")]
				internal void XLBGWILEBWK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x52B7F40", Offset = "0x52B7140", VA = "0x1852B7F40")]
				internal bool XLGNTPFBLHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x52B7EF0", Offset = "0x52B70F0", VA = "0x1852B7EF0")]
				internal void XKQTBUXJIZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x52B7F40", Offset = "0x52B7140", VA = "0x1852B7F40")]
				internal bool XKVZZBRGSLB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x52B7AD0", Offset = "0x52B6CD0", VA = "0x1852B7AD0")]
				internal float XIQCDFGJSQG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x52B7B00", Offset = "0x52B6D00", VA = "0x1852B7B00")]
				internal void XIVJAMAHCBP(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x52B6CA0", Offset = "0x52B5EA0", VA = "0x1852B6CA0")]
				internal float JMCGANYVJLZ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x52B6C10", Offset = "0x52B5E10", VA = "0x1852B6C10")]
				internal void JLWZDHEYAAQ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x52B6D60", Offset = "0x52B5F60", VA = "0x1852B6D60")]
				internal float JMMTVBMQCIR()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x52B6CD0", Offset = "0x52B5ED0", VA = "0x1852B6CD0")]
				internal void JMHMXUSSSXI(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType TWIOBILTJWA
			{
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x407ACD0", Offset = "0x4079ED0", VA = "0x18407ACD0")]
			public DEBRRVHTBGP(RRHCIMKELZN a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x407A290", Offset = "0x4079490", VA = "0x18407A290", Slot = "145")]
			protected sealed override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class WCPEUEQZPWR : HNPTTMVJLEI<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0xCC4DC0", Offset = "0xCC3FC0", VA = "0x180CC4DC0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x28D3600", Offset = "0x28D2800", VA = "0x1828D3600")]
			public WCPEUEQZPWR(RRHCIMKELZN a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class KALRYLFJXHY : PZLQZSQTPDQ<APZFBVVJOYU>
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x28C3F10", Offset = "0x28C3110", VA = "0x1828C3F10")]
			public KALRYLFJXHY(RRHCIMKELZN a, APZFBVVJOYU b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class ZQFLVDPDMDQ : PZLQZSQTPDQ<ARVHSHVDXTT>
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x28D9AD0", Offset = "0x28D8CD0", VA = "0x1828D9AD0")]
			public ZQFLVDPDMDQ(RRHCIMKELZN a, ARVHSHVDXTT b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class PZLQZSQTPDQ<a> : HNPTTMVJLEI<a> where a : notnull, ENNMBKMQJES
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
				public PZLQZSQTPDQ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0x3CE79E0", Offset = "0x3CE6BE0", VA = "0x183CE79E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051D")]
				[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class FVGGAGPQVFA
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
					public FVGGAGPQVFA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x3CE66B0", Offset = "0x3CE58B0", VA = "0x183CE66B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public FVGGAGPQVFA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x3CE6A90", Offset = "0x3CE5C90", VA = "0x183CE6A90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public FVGGAGPQVFA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x3CE7310", Offset = "0x3CE6510", VA = "0x183CE7310", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public FVGGAGPQVFA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000533")]
					[Cpp2IlInjected.Address(RVA = "0x3CE76F0", Offset = "0x3CE68F0", VA = "0x183CE76F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000534")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int NMEELCHBFXG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry NKXCLLMTAVG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public PZLQZSQTPDQ<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<NRZUVTJIBNZ, bool> YPQTJRMTEFZ;

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public FVGGAGPQVFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0x4D66610", Offset = "0x4D65810", VA = "0x184D66610")]
				internal bool XKAYKAPRGRR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x4D66840", Offset = "0x4D65A40", VA = "0x184D66840")]
				internal void XLBGWILEBWK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
				internal string XLGNTPFBLHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x4D66670", Offset = "0x4D65870", VA = "0x184D66670")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.FVGGAGPQVFA.<<BuildConfigMenuInternal>b__6>d))]
				internal void XKQTBUXJIZS(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x4D66730", Offset = "0x4D65930", VA = "0x184D66730")]
				internal int XKVZZBRGSLB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0x4D66430", Offset = "0x4D65630", VA = "0x184D66430")]
				internal bool JMHMXUSSSXI(NRZUVTJIBNZ a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x4D66560", Offset = "0x4D65760", VA = "0x184D66560")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.FVGGAGPQVFA.<<BuildConfigMenuInternal>b__8>d))]
				internal void XIQCDFGJSQG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
				internal string JMCGANYVJLZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0x4D66370", Offset = "0x4D65570", VA = "0x184D66370")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.FVGGAGPQVFA.<<BuildConfigMenuInternal>b__11>d))]
				internal void JLWZDHEYAAQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x4D66450", Offset = "0x4D65650", VA = "0x184D66450")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.FVGGAGPQVFA.<<BuildConfigMenuInternal>b__12>d))]
				internal void JMMTVBMQCIR()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class SZVZAOYZOQR
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x3CE0A20", Offset = "0x3CDFC20", VA = "0x183CE0A20", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x3CE0DA0", Offset = "0x3CDFFA0", VA = "0x183CE0DA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x3CE1170", Offset = "0x3CE0370", VA = "0x183CE1170", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x3CE1750", Offset = "0x3CE0950", VA = "0x183CE1750", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x3CE19E0", Offset = "0x3CE0BE0", VA = "0x183CE19E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x3CE1D70", Offset = "0x3CE0F70", VA = "0x183CE1D70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x3CE2100", Offset = "0x3CE1300", VA = "0x183CE2100", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x3CE2390", Offset = "0x3CE1590", VA = "0x183CE2390", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x3CE2720", Offset = "0x3CE1920", VA = "0x183CE2720", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x3CE2AB0", Offset = "0x3CE1CB0", VA = "0x183CE2AB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x3CE2E30", Offset = "0x3CE2030", VA = "0x183CE2E30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x3CE30C0", Offset = "0x3CE22C0", VA = "0x183CE30C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x3CE3450", Offset = "0x3CE2650", VA = "0x183CE3450", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x3CE36E0", Offset = "0x3CE28E0", VA = "0x183CE36E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x3CE3A70", Offset = "0x3CE2C70", VA = "0x183CE3A70", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x3CE3DF0", Offset = "0x3CE2FF0", VA = "0x183CE3DF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
					public SZVZAOYZOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000585")]
					[Cpp2IlInjected.Address(RVA = "0x3CE4170", Offset = "0x3CE3370", VA = "0x183CE4170", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000586")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public PZLQZSQTPDQ<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int NMEELCHBFXG;

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public SZVZAOYZOQR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x5F845A0", Offset = "0x5F837A0", VA = "0x185F845A0")]
				internal bool LGYELFXRPKM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x5F84600", Offset = "0x5F83800", VA = "0x185F84600")]
				internal void LHDLIMROYVV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x5F83EB0", Offset = "0x5F830B0", VA = "0x185F83EB0")]
				internal object IDESZPZQZXV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x5F83DF0", Offset = "0x5F82FF0", VA = "0x185F83DF0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__13>d))]
				internal void ICZMCJFTQMM(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x5F83D50", Offset = "0x5F82F50", VA = "0x185F83D50")]
				internal string ICUFFCLWHBD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x5F83C90", Offset = "0x5F82E90", VA = "0x185F83C90")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__15>d))]
				internal void ICOYHVRYXPU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x5F83C10", Offset = "0x5F82E10", VA = "0x185F83C10")]
				internal bool ICJRKOYBOEL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x5F83B80", Offset = "0x5F82D80", VA = "0x185F83B80")]
				internal bool ICEKNIEEETC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x5F84140", Offset = "0x5F83340", VA = "0x185F84140")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__18>d))]
				internal void IFFJYFQQQHH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x5F84090", Offset = "0x5F83290", VA = "0x185F84090")]
				internal int IFADAYWTGVY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x5F86680", Offset = "0x5F85880", VA = "0x185F86680")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__20>d))]
				internal void PEGLSVVOIMW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x5F86730", Offset = "0x5F85930", VA = "0x185F86730")]
				internal bool PELSQCPLRYF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x5F86520", Offset = "0x5F85720", VA = "0x185F86520")]
				internal float PDVXYIHTPQE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x5F865D0", Offset = "0x5F857D0", VA = "0x185F865D0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__23>d))]
				internal void PEBEVPBQZBN(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x5F86900", Offset = "0x5F85B00", VA = "0x185F86900")]
				internal bool PFBNHWXDUGG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x5F86990", Offset = "0x5F85B90", VA = "0x185F86990")]
				internal bool PFGUFDRBDRP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x5F867C0", Offset = "0x5F859C0", VA = "0x185F867C0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__26>d))]
				internal void PEQZNJJJBJO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x5F86870", Offset = "0x5F85A70", VA = "0x185F86870")]
				internal int PEWGKQDGKUX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x5F863E0", Offset = "0x5F855E0", VA = "0x185F863E0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__28>d))]
				internal void PCQIOTSJLAC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x5F86490", Offset = "0x5F85690", VA = "0x185F86490")]
				internal bool PCVPMAMGULL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x5F86E90", Offset = "0x5F86090", VA = "0x185F86E90")]
				internal float VEZSEGEQMIX()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x5F86DE0", Offset = "0x5F85FE0", VA = "0x185F86DE0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__31>d))]
				internal void VEULGZKTCXO(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x5F86FA0", Offset = "0x5F861A0", VA = "0x185F86FA0")]
				internal bool VFKFYTSLFFP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x5F86F20", Offset = "0x5F86120", VA = "0x185F86F20")]
				internal bool VFEZBMYNVUG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x5F86BF0", Offset = "0x5F85DF0", VA = "0x185F86BF0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__34>d))]
				internal void VEEQPFDBAPN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x5F86B60", Offset = "0x5F85D60", VA = "0x185F86B60")]
				internal bool VDZJRYJDREE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x5F86D50", Offset = "0x5F85F50", VA = "0x185F86D50")]
				internal bool VEPEJSQVTMF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x5F86CA0", Offset = "0x5F85EA0", VA = "0x185F86CA0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__37>d))]
				internal void VEJXMLWYKAW(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x5F86AD0", Offset = "0x5F85CD0", VA = "0x185F86AD0")]
				internal int VDJPAEBLOWD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x5F86A20", Offset = "0x5F85C20", VA = "0x185F86A20")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__39>d))]
				internal void VDEICXHOFKU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x5F83710", Offset = "0x5F82910", VA = "0x185F83710")]
				internal bool AGRTEGKSUCE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x5F837A0", Offset = "0x5F829A0", VA = "0x185F837A0")]
				internal float AGXABNEQDNN()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x5F83830", Offset = "0x5F82A30", VA = "0x185F83830")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__42>d))]
				internal void AHCGYTYNMYW(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x5F838E0", Offset = "0x5F82AE0", VA = "0x185F838E0")]
				internal bool AHHNWASKWKF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x5F83970", Offset = "0x5F82B70", VA = "0x185F83970")]
				internal bool AHMUTHMIFVO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x5F839F0", Offset = "0x5F82BF0", VA = "0x185F839F0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__45>d))]
				internal void AHSBQOGFPGX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x5F83AA0", Offset = "0x5F82CA0", VA = "0x185F83AA0")]
				internal bool AHXINVACYSG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x5F84670", Offset = "0x5F83870", VA = "0x185F84670")]
				internal bool LHISFTLMIHE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x5F84700", Offset = "0x5F83900", VA = "0x185F84700")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__3>d))]
				internal void LHNZDAFJRSN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x5F84340", Offset = "0x5F83540", VA = "0x185F84340")]
				internal int LGDCWEWCDRC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x5F843D0", Offset = "0x5F835D0", VA = "0x185F843D0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__5>d))]
				internal void LGIJTLPZNCL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x5F84480", Offset = "0x5F83680", VA = "0x185F84480")]
				internal bool LGNQQSJWWNU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x5F84510", Offset = "0x5F83710", VA = "0x185F84510")]
				internal bool LGSXNZDUFZD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x5F841F0", Offset = "0x5F833F0", VA = "0x185F841F0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__8>d))]
				internal void LFIBHDUMRXS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x5F842A0", Offset = "0x5F834A0", VA = "0x185F842A0")]
				internal int LFNIEKOKBJB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x5F83FE0", Offset = "0x5F831E0", VA = "0x185F83FE0")]
				[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.SZVZAOYZOQR.<<AddConstraintOptions>b__10>d))]
				internal void IDPGUDNLSUN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x5F83F50", Offset = "0x5F83150", VA = "0x185F83F50")]
				internal bool IDJZWWTOJJE()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> MXRTBDBGPXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> KAOPBTKYNMN;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000516")]
				[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<NRZUVTJIBNZ> LFDXRHSLCGH
			{
				[Cpp2IlInjected.Token(Token = "0x6000517")]
				[Cpp2IlInjected.Address(RVA = "0x5C1D5F0", Offset = "0x5C1C7F0", VA = "0x185C1D5F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x5C1D640", Offset = "0x5C1C840", VA = "0x185C1D640")]
			public PZLQZSQTPDQ(RRHCIMKELZN a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x5C1ACC0", Offset = "0x5C19EC0", VA = "0x185C1ACC0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x5C1AD70", Offset = "0x5C19F70", VA = "0x185C1AD70", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x5C1BDC0", Offset = "0x5C1AFC0", VA = "0x185C1BDC0")]
			private KTXMTOSWJRV LONXXSIZABQ(JXYGDPTLLDL a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x5C1D550", Offset = "0x5C1C750", VA = "0x185C1D550")]
			[AsyncStateMachine(typeof(PZLQZSQTPDQ<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void QVTRVSIWMGS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x5C1D4F0", Offset = "0x5C1C6F0", VA = "0x185C1D4F0")]
			[CompilerGenerated]
			private bool QVOKYLOZCVJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class GLXLEBGBFYW : HNPTTMVJLEI<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class PWPEITYPPDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public GLXLEBGBFYW LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PWPEITYPPDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x28C60A0", Offset = "0x28C52A0", VA = "0x1828C60A0")]
				internal int XKLMEODLZOJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x28C5E10", Offset = "0x28C5010", VA = "0x1828C5E10")]
				internal void XJVRMTVTXGI(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? ABHNBZPRANR;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x28C3730", Offset = "0x28C2930", VA = "0x1828C3730")]
			public GLXLEBGBFYW(RRHCIMKELZN a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x28C33E0", Offset = "0x28C25E0", VA = "0x1828C33E0", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class FXZGREAMHRI : DEBRRVHTBGP<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType TWIOBILTJWA
			{
				[Cpp2IlInjected.Token(Token = "0x6000590")]
				[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x28C3380", Offset = "0x28C2580", VA = "0x1828C3380")]
			public FXZGREAMHRI(RRHCIMKELZN a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class KCDIFBKCIXP : KZZCPIHSVFJ<CCJGXQQIEVE>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000591")]
				[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x28C3F70", Offset = "0x28C3170", VA = "0x1828C3F70")]
			public KCDIFBKCIXP(RRHCIMKELZN a, CCJGXQQIEVE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class VZKBIZAHTCQ : KZZCPIHSVFJ<CVTXZDZASIR>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000594")]
				[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x28D33F0", Offset = "0x28D25F0", VA = "0x1828D33F0")]
			public VZKBIZAHTCQ(RRHCIMKELZN a, CVTXZDZASIR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class BOWHWSYZHDS : MNWSRKOEBSE<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
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
					public UITEPKMAORH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600059B")]
					[Cpp2IlInjected.Address(RVA = "0x28CF8C0", Offset = "0x28CEAC0", VA = "0x1828CF8C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059C")]
					[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public BOWHWSYZHDS LQBDIDDTHZG;

				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x28D1280", Offset = "0x28D0480", VA = "0x1828D1280")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void FEZVBWKFQOH(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x28BEC90", Offset = "0x28BDE90", VA = "0x1828BEC90")]
			public BOWHWSYZHDS(RRHCIMKELZN a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x28BE990", Offset = "0x28BDB90", VA = "0x1828BE990", Slot = "151")]
			protected override void JLXBZNPFGSX(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class FKYKPUSLGHZ : DEBRRVHTBGP<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType TWIOBILTJWA
			{
				[Cpp2IlInjected.Token(Token = "0x600059E")]
				[Cpp2IlInjected.Address(RVA = "0xBDF4C0", Offset = "0xBDE6C0", VA = "0x180BDF4C0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x28C2FD0", Offset = "0x28C21D0", VA = "0x1828C2FD0")]
			public FKYKPUSLGHZ(RRHCIMKELZN a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class BIZBBWMCTWC : HNPTTMVJLEI<HTBUBOVQVNI>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0xCC46A0", Offset = "0xCC38A0", VA = "0x180CC46A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x28BE920", Offset = "0x28BDB20", VA = "0x1828BE920")]
			public BIZBBWMCTWC(RRHCIMKELZN a, HTBUBOVQVNI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class UTHYLDWRBSB : HNPTTMVJLEI<VNALYYTJWAS>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A3")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool DNLWTMQZBPG
			{
				[Cpp2IlInjected.Token(Token = "0x60005A4")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x28D2950", Offset = "0x28D1B50", VA = "0x1828D2950")]
			public UTHYLDWRBSB(RRHCIMKELZN a, VNALYYTJWAS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x28D2600", Offset = "0x28D1800", VA = "0x1828D2600", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x28D2910", Offset = "0x28D1B10", VA = "0x1828D2910")]
			private int MJSGKCBMLBL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x28D2590", Offset = "0x28D1790", VA = "0x1828D2590")]
			private void CNLRLSJKEAF(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class PRTBQVLTMDG : AYHGIRIFWXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x28BE8B0", Offset = "0x28BDAB0", VA = "0x1828BE8B0")]
			public PRTBQVLTMDG(RRHCIMKELZN a, AUAIRMEYYLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class QZRMPVOSAOO : HNPTTMVJLEI<WZNWDQEIKFJ>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class DVLSPHLOUXJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public QZRMPVOSAOO LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public DVLSPHLOUXJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x28C16C0", Offset = "0x28C08C0", VA = "0x1828C16C0")]
				internal int XKGFHHJOQDA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x28C1B00", Offset = "0x28C0D00", VA = "0x1828C1B00")]
				internal void XKLMEODLZOJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B1")]
				[Cpp2IlInjected.Address(RVA = "0x28C10C0", Offset = "0x28C02C0", VA = "0x1828C10C0")]
				internal int XJVRMTVTXGI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0x28C1620", Offset = "0x28C0820", VA = "0x1828C1620")]
				internal void XKAYKAPRGRR(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xAEF260", Offset = "0xAEE460", VA = "0x180AEF260", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x28C7AE0", Offset = "0x28C6CE0", VA = "0x1828C7AE0")]
			public QZRMPVOSAOO(RRHCIMKELZN a, WZNWDQEIKFJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x28C77D0", Offset = "0x28C69D0", VA = "0x1828C77D0", Slot = "145")]
			protected sealed override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class RYOURAFSFPN : MNWSRKOEBSE<IXIBGFYAWYY>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x28C7E10", Offset = "0x28C7010", VA = "0x1828C7E10")]
			public RYOURAFSFPN(RRHCIMKELZN a, IXIBGFYAWYY b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class MNWSRKOEBSE<a> : HNPTTMVJLEI<a> where a : notnull, IXIBGFYAWYY
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class YYQSCBGHHGI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public MNWSRKOEBSE<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public YYQSCBGHHGI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x3ED08D0", Offset = "0x3ECFAD0", VA = "0x183ED08D0")]
				internal bool XKGFHHJOQDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x3ED0900", Offset = "0x3ECFB00", VA = "0x183ED0900")]
				internal void XKLMEODLZOJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x3ED0810", Offset = "0x3ECFA10", VA = "0x183ED0810")]
				internal bool XJVRMTVTXGI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0x3ED0840", Offset = "0x3ECFA40", VA = "0x183ED0840")]
				internal void XKAYKAPRGRR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x3ED0990", Offset = "0x3ECFB90", VA = "0x183ED0990")]
				internal bool XLBGWILEBWK()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class LWTYMBCWKSX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public IPREUGGLREP PDBNCXOUVLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public MNWSRKOEBSE<a> LQBDIDDTHZG;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public LWTYMBCWKSX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x53D4B00", Offset = "0x53D3D00", VA = "0x1853D4B00")]
				internal void FEZVBWKFQOH(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0xBE74C0", Offset = "0xBE66C0", VA = "0x180BE74C0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x58A0D40", Offset = "0x589FF40", VA = "0x1858A0D40", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x58A0C30", Offset = "0x589FE30", VA = "0x1858A0C30")]
			protected MNWSRKOEBSE(RRHCIMKELZN a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x58A0480", Offset = "0x589F680", VA = "0x1858A0480", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x58A0870", Offset = "0x589FA70", VA = "0x1858A0870", Slot = "145")]
			protected override void JPWNODKMFQE(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x58A0580", Offset = "0x589F780", VA = "0x1858A0580", Slot = "151")]
			protected virtual void JLXBZNPFGSX(JXYGDPTLLDL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x58A0BF0", Offset = "0x589FDF0", VA = "0x1858A0BF0", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x28B1F80", Offset = "0x28B1180", VA = "0x1828B1F80")]
		public static EVXNXIKLNWV New(RRHCIMKELZN circuitsManager, AUAIRMEYYLK node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class JIMNTKWNNZR : DKNTXNYIADL, FBFBNRKPMVK, YSPMOZFFUWS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<HCYBYNYIFYK> LBBVAJZOTQK
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xCACAC0", Offset = "0xCABCC0", VA = "0x180CACAC0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<HCYBYNYIFYK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<RJHPWNGPQQO> KCJKBRSYPDD
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x12B2FF0", Offset = "0x12B21F0", VA = "0x1812B2FF0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<RJHPWNGPQQO>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x214C2C0", Offset = "0x214B4C0", VA = "0x18214C2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<FXOBICRSDUR> FQBSIZRUUHP
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x11E7440", Offset = "0x11E6640", VA = "0x1811E7440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<XWVPYHBWQIU> ZAHAXKVJLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x28C3C20", Offset = "0x28C2E20", VA = "0x1828C3C20", Slot = "22")]
			get
			{
				return default(Id32<XWVPYHBWQIU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x28C3C70", Offset = "0x28C2E70", VA = "0x1828C3C70")]
		private JIMNTKWNNZR(RRHCIMKELZN a, AUAIRMEYYLK b, TLSVDERIQZI c, Id32<WXMOLFBEQDB> portGroupId, Id32<RJHPWNGPQQO> outputId, Id32<FXOBICRSDUR> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x28C38D0", Offset = "0x28C2AD0", VA = "0x1828C38D0")]
		public static JIMNTKWNNZR New(RRHCIMKELZN circuitsManager, AUAIRMEYYLK node, TLSVDERIQZI output, Id32<WXMOLFBEQDB> portGroupId, Id32<FXOBICRSDUR> outputDefId, Id32<RJHPWNGPQQO> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x214C2C0", Offset = "0x214B4C0", VA = "0x18214C2C0")]
		internal void AVMZUNKPPMZ(Id32<RJHPWNGPQQO> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class DKNTXNYIADL : YSPMOZFFUWS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private XNYSBRMNESP? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x28C4AB0", Offset = "0x28C3CB0", VA = "0x1828C4AB0")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x28C4AC0", Offset = "0x28C3CC0", VA = "0x1828C4AC0")]
			public XNYSBRMNESP ERBXNCJWAYH(DKNTXNYIADL a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly RRHCIMKELZN GLGGEMXYIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly AUAIRMEYYLK NUYEYAMQJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter OHMOCEYDGNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly BEYZDISXZKK JFKHHIGMAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<BHOZMVZHVDE> HRLLIAGIJZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<AQZUKHGBTZW> UQZIYNVFCIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool EOACLKBIENN;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> PBOQYBSZSPH
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x28BF230", Offset = "0x28BE430", VA = "0x1828BF230", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind PZLROGHEWJS
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xAD45F0", Offset = "0xAD37F0", VA = "0x180AD45F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<NZKBDZMUQMJ> RNQCONEVYND
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x28C0460", Offset = "0x28BF660", VA = "0x1828C0460", Slot = "6")]
			get
			{
				return default(Id32<NZKBDZMUQMJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<NZKBDZMUQMJ> DPIAUDCYRFO
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x28C0490", Offset = "0x28BF690", VA = "0x1828C0490", Slot = "7")]
			get
			{
				return default(Id128<NZKBDZMUQMJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public NRZUVTJIBNZ PNDOGWAOLOS
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x28C0440", Offset = "0x28BF640", VA = "0x1828C0440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public DHPBSHZYRAJ BONJGAMWLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x28BFC90", Offset = "0x28BEE90", VA = "0x1828BFC90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected XNYSBRMNESP XGKHPVTKCOO
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x28BFC90", Offset = "0x28BEE90", VA = "0x1828BFC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage GZMAHTNHSMU
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x28C04C0", Offset = "0x28BF6C0", VA = "0x1828C04C0", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xAB92F0", Offset = "0xAB84F0", VA = "0x180AB92F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<FAVTMLJIUOX> PWDNIPEFMSC
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x28BF210", Offset = "0x28BE410", VA = "0x1828BF210", Slot = "9")]
			get
			{
				return default(Id128<FAVTMLJIUOX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<WXMOLFBEQDB> PZNVTDWSLJN
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xC45940", Offset = "0xC44B40", VA = "0x180C45940", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<WXMOLFBEQDB>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x1841780", Offset = "0x1840980", VA = "0x181841780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<XWVPYHBWQIU> ZAHAXKVJLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool JRRQGURFBWY
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xCF5F00", Offset = "0xCF5100", VA = "0x180CF5F00", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x28C0600", Offset = "0x28BF800", VA = "0x1828C0600")]
		protected DKNTXNYIADL(RRHCIMKELZN a, AUAIRMEYYLK b, BEYZDISXZKK c, Id32<WXMOLFBEQDB> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x28BF370", Offset = "0x28BE570", VA = "0x1828BF370", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x28BEFA0", Offset = "0x28BE1A0", VA = "0x1828BEFA0", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x28BF080", Offset = "0x28BE280", VA = "0x1828BF080", Slot = "14")]
		public void EOCULZTLSUT(BHOZMVZHVDE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x28C0040", Offset = "0x28BF240", VA = "0x1828C0040", Slot = "15")]
		public void OQRGWUGAGNH(AQZUKHGBTZW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x28BFD20", Offset = "0x28BEF20", VA = "0x1828BFD20")]
		private bool MYPRDAIXRLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x28BF450", Offset = "0x28BE650", VA = "0x1828BF450", Slot = "17")]
		public void KNREQWMUPDZ(RWHYFKIXBOO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x28BEF40", Offset = "0x28BE140", VA = "0x1828BEF40", Slot = "25")]
		protected virtual void BIIKBIYTNUR(RWHYFKIXBOO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x28BEDC0", Offset = "0x28BDFC0", VA = "0x1828BEDC0", Slot = "20")]
		private void BAFACXUCNUO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x28C0290", Offset = "0x28BF490", VA = "0x1828C0290")]
		private void UNQTSWSGDCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x28C00F0", Offset = "0x28BF2F0", VA = "0x1828C00F0")]
		private void PPQFUTIRSYZ([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x28BF1B0", Offset = "0x28BE3B0", VA = "0x1828BF1B0", Slot = "18")]
		public void FYFFRCTXGFK(BHOZMVZHVDE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x28BF150", Offset = "0x28BE350", VA = "0x1828BF150", Slot = "19")]
		public void FYEHUAKZSJM(AQZUKHGBTZW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xAB92F0", Offset = "0xAB84F0", VA = "0x180AB92F0")]
		internal void LYKCXLMMEOD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x28BF130", Offset = "0x28BE330", VA = "0x1828BF130")]
		internal void FQNHCLRVHPS(PZCZATDXERS a, NRZUVTJIBNZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1841780", Offset = "0x1840980", VA = "0x181841780")]
		internal void GKLUNTVNTVF(Id32<WXMOLFBEQDB> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class XNWUZFFCQGA : DMCBGFQYAXT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class WASMBPUFCIY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public RRHCIMKELZN BZQOZHVRJST;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public AUAIRMEYYLK JTYGKFBHBEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<WXMOLFBEQDB> XSZHKZYXWVB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool EYEUQQSGMAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool IPFELEQZEVN;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public WASMBPUFCIY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x28D3450", Offset = "0x28D2650", VA = "0x1828D3450")]
			internal GQOYTODQKPI DBRLUXUKSCY((int PortDescIndex, int PortIndex, KBRGELRFHGL InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x28D3530", Offset = "0x28D2730", VA = "0x1828D3530")]
			internal JIMNTKWNNZR DBWSSEOIBOH(TLSVDERIQZI a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x28CB170", Offset = "0x28CA370", VA = "0x1828CB170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x28CB5E0", Offset = "0x28CA7E0", VA = "0x1828CB5E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<XZLTFWVWVWY> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x28CC880", Offset = "0x28CBA80", VA = "0x1828CC880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x28CCBD0", Offset = "0x28CBDD0", VA = "0x1828CCBD0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x28CCC40", Offset = "0x28CBE40", VA = "0x1828CCC40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x28CD0C0", Offset = "0x28CC2C0", VA = "0x1828CD0C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<FXOBICRSDUR> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x28CD130", Offset = "0x28CC330", VA = "0x1828CD130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x28CD480", Offset = "0x28CC680", VA = "0x1828CD480", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x28CDCB0", Offset = "0x28CCEB0", VA = "0x1828CDCB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x28CE000", Offset = "0x28CD200", VA = "0x1828CE000", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<XZLTFWVWVWY> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x28CD4F0", Offset = "0x28CC6F0", VA = "0x1828CD4F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x28CD860", Offset = "0x28CCA60", VA = "0x1828CD860", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<FXOBICRSDUR> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x28CD8D0", Offset = "0x28CCAD0", VA = "0x1828CD8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x28CDC40", Offset = "0x28CCE40", VA = "0x1828CDC40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public MIILYKSZUVS type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<XZLTFWVWVWY> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x28CE070", Offset = "0x28CD270", VA = "0x1828CE070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x28CE410", Offset = "0x28CD610", VA = "0x1828CE410", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public MIILYKSZUVS type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<FXOBICRSDUR> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x28CE480", Offset = "0x28CD680", VA = "0x1828CE480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x28CE820", Offset = "0x28CDA20", VA = "0x1828CE820", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<XZLTFWVWVWY> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<XZLTFWVWVWY> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x28CE890", Offset = "0x28CDA90", VA = "0x1828CE890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x28CEBF0", Offset = "0x28CDDF0", VA = "0x1828CEBF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public XNWUZFFCQGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<FXOBICRSDUR> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<FXOBICRSDUR> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private BKQRFKBWSPS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x28CEC60", Offset = "0x28CDE60", VA = "0x1828CEC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x28CEFC0", Offset = "0x28CE1C0", VA = "0x1828CEFC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool OLKYYSGAHYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly RRHCIMKELZN GLGGEMXYIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool IVEAQWUEMVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<EXAEBOAKZGD, GQOYTODQKPI> RXWSNTTQAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<EXAEBOAKZGD, WVFYSXHQAXF> VPMSGEFLHLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly AUAIRMEYYLK NUYEYAMQJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<RJHPWNGPQQO, JIMNTKWNNZR> YHGLDEFTJXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<RJHPWNGPQQO, FBFBNRKPMVK> EFXLQHJABIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? UUTCKXNGIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly WUASAFDCPMX ZFJRSMYGUSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<WXMOLFBEQDB> ZHICURIBDIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool JZMLWZYFVIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? XXBVPXHHXHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? COGYGGAYIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<EXAEBOAKZGD>>? ZAPRDJADVGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<RJHPWNGPQQO>>? LYKYZILZYEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private DMCBGFQYAXT.PortGroupIdChangeDelegate? VGTSXJGTFEU;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool XHTIUPCETQU
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x28D54B0", Offset = "0x28D46B0", VA = "0x1828D54B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool WOWBOHFMLOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x28D47A0", Offset = "0x28D39A0", VA = "0x1828D47A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool ULUIATNXZWP
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x28D5570", Offset = "0x28D4770", VA = "0x1828D5570", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<NZKBDZMUQMJ> DPIAUDCYRFO
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x28D8F00", Offset = "0x28D8100", VA = "0x1828D8F00", Slot = "7")]
			get
			{
				return default(Id128<NZKBDZMUQMJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool CNKXUWPKBJD
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x28D4180", Offset = "0x28D3380", VA = "0x1828D4180", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<EXAEBOAKZGD, WVFYSXHQAXF> IPKEBOMJKTL
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<EXAEBOAKZGD, WVFYSXHQAXF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x28D3FD0", Offset = "0x28D31D0", VA = "0x1828D3FD0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<FAVTMLJIUOX> PWDNIPEFMSC
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x28D5260", Offset = "0x28D4460", VA = "0x1828D5260", Slot = "11")]
			get
			{
				return default(Id128<FAVTMLJIUOX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<RJHPWNGPQQO, FBFBNRKPMVK> LOEUARIWFLU
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<RJHPWNGPQQO, FBFBNRKPMVK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<WXMOLFBEQDB> PZNVTDWSLJN
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0xDBE750", Offset = "0xDBD950", VA = "0x180DBE750", Slot = "13")]
			get
			{
				return default(Id32<WXMOLFBEQDB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? QCZNAEYCENR
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x28D67A0", Offset = "0x28D59A0", VA = "0x1828D67A0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x28D4C40", Offset = "0x28D3E40", VA = "0x1828D4C40", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? NCNSOANPHRK
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x28D8040", Offset = "0x28D7240", VA = "0x1828D8040", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x28D7460", Offset = "0x28D6660", VA = "0x1828D7460", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<EXAEBOAKZGD?>, Id32<EXAEBOAKZGD?>>? NWNDQDUMBUX
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x28D5630", Offset = "0x28D4830", VA = "0x1828D5630", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x28D64B0", Offset = "0x28D56B0", VA = "0x1828D64B0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<EXAEBOAKZGD?>, Id32<EXAEBOAKZGD?>>? KLUMJISEZEE
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x28D8C50", Offset = "0x28D7E50", VA = "0x1828D8C50", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x28D7D00", Offset = "0x28D6F00", VA = "0x1828D7D00", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<RJHPWNGPQQO?>, Id32<RJHPWNGPQQO?>>? GMDILHBGDGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x28D8B90", Offset = "0x28D7D90", VA = "0x1828D8B90", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x28D53F0", Offset = "0x28D45F0", VA = "0x1828D53F0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<RJHPWNGPQQO?>, Id32<RJHPWNGPQQO?>>? OQGMKXDRBWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x28D7DC0", Offset = "0x28D6FC0", VA = "0x1828D7DC0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x28D4E00", Offset = "0x28D4000", VA = "0x1828D4E00", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<EXAEBOAKZGD?>, WVFYSXHQAXF?>? QRNCKBQIYVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x28D7530", Offset = "0x28D6730", VA = "0x1828D7530", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x28D5B00", Offset = "0x28D4D00", VA = "0x1828D5B00", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<EXAEBOAKZGD?>>? EWYIBJHOVBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x28D5BC0", Offset = "0x28D4DC0", VA = "0x1828D5BC0", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x28D3E50", Offset = "0x28D3050", VA = "0x1828D3E50", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<EXAEBOAKZGD?>, WVFYSXHQAXF?>? TSRMZZJBQCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x28D40C0", Offset = "0x28D32C0", VA = "0x1828D40C0", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x28D7B30", Offset = "0x28D6D30", VA = "0x1828D7B30", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<RJHPWNGPQQO?>, FBFBNRKPMVK?>? AMBYJQKCSUP
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x28D5710", Offset = "0x28D4910", VA = "0x1828D5710", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x28D4B80", Offset = "0x28D3D80", VA = "0x1828D4B80", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<RJHPWNGPQQO?>>? IKEGKVVZYSY
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x28D4000", Offset = "0x28D3200", VA = "0x1828D4000", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x28D80F0", Offset = "0x28D72F0", VA = "0x1828D80F0", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<RJHPWNGPQQO?>, FBFBNRKPMVK?>? QMVJIOKIIXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x28D8D10", Offset = "0x28D7F10", VA = "0x1828D8D10", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x28D3F10", Offset = "0x28D3110", VA = "0x1828D3F10", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x28D8FC0", Offset = "0x28D81C0", VA = "0x1828D8FC0")]
		private XNWUZFFCQGA(bool a, RRHCIMKELZN b, bool c, ReadOnlyIdArray<EXAEBOAKZGD, GQOYTODQKPI> inputs, ReadOnlyIdArray<EXAEBOAKZGD, WVFYSXHQAXF> inputsAsStaticInputs, AUAIRMEYYLK d, ReadOnlyIdArray<RJHPWNGPQQO, JIMNTKWNNZR> outputs, ReadOnlyIdArray<RJHPWNGPQQO, FBFBNRKPMVK> outputsAsStaticOutputs, string? overrideName, WUASAFDCPMX e, Id32<WXMOLFBEQDB> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x28D6DF0", Offset = "0x28D5FF0", VA = "0x1828D6DF0")]
		public static XNWUZFFCQGA New(bool canInteract, RRHCIMKELZN circuitsManager, bool hasFunctionHeader, AUAIRMEYYLK node, WUASAFDCPMX portGroup, Id32<WXMOLFBEQDB> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x28D47E0", Offset = "0x28D39E0", VA = "0x1828D47E0", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x28D5A10", Offset = "0x28D4C10", VA = "0x1828D5A10", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, JDUFGOJEPGU?>>? JWFYEAMGSWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x28D6570", Offset = "0x28D5770", VA = "0x1828D6570")]
		private (TMAFNKPFSVP?, int)? MFGOBTGABHU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x28D7BF0", Offset = "0x28D6DF0", VA = "0x1828D7BF0", Slot = "58")]
		private void SWVHDEIIILE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x21136E0", Offset = "0x21128E0", VA = "0x1821136E0", Slot = "57")]
		private void FPRNUQZSXAJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x28D87C0", Offset = "0x28D79C0", VA = "0x1828D87C0", Slot = "61")]
		private void WXFYHXQEEUD(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x28D7EA0", Offset = "0x28D70A0", VA = "0x1828D7EA0", Slot = "63")]
		private void UXUAMAQGNKW(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x28D6840", Offset = "0x28D5A40", VA = "0x1828D6840", Slot = "50")]
		private void MTFBXAKFUEV(int a, Id32<EXAEBOAKZGD> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x28D7510", Offset = "0x28D6710", VA = "0x1828D7510", Slot = "54")]
		private void QLUIUHBVFOK(int a, Id32<EXAEBOAKZGD> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x28D7E80", Offset = "0x28D7080", VA = "0x1828D7E80", Slot = "49")]
		private void UQCIJSMWDDK(int a, Id32<EXAEBOAKZGD> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x28D75F0", Offset = "0x28D67F0", VA = "0x1828D75F0", Slot = "53")]
		private void RCVUQHQXMEN(int a, Id32<EXAEBOAKZGD> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x28D5280", Offset = "0x28D4480", VA = "0x1828D5280", Slot = "66")]
		private void HLXLWGZGBPX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xE938F0", Offset = "0xE92AF0", VA = "0x180E938F0", Slot = "65")]
		private void GVGRTKLBYCK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x28D7F30", Offset = "0x28D7130", VA = "0x1828D7F30", Slot = "60")]
		private void VFQHMJEEJIB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x21136E0", Offset = "0x21128E0", VA = "0x1821136E0", Slot = "59")]
		private void SYCSUCWQZUA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x28D82E0", Offset = "0x28D74E0", VA = "0x1828D82E0", Slot = "62")]
		private void VXRIZFIJNNA(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x28D8F30", Offset = "0x28D8130", VA = "0x1828D8F30", Slot = "64")]
		private void YPUNNVLVVWZ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x28D4200", Offset = "0x28D3400", VA = "0x1828D4200", Slot = "52")]
		private void DUBJODRUFFC(int a, Id32<RJHPWNGPQQO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x28D4B60", Offset = "0x28D3D60", VA = "0x1828D4B60", Slot = "56")]
		private void EPQUTZQTMDL(int a, Id32<RJHPWNGPQQO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x28D56F0", Offset = "0x28D48F0", VA = "0x1828D56F0", Slot = "51")]
		private void IDJEULNGGTB(int a, Id32<RJHPWNGPQQO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x28D5C80", Offset = "0x28D4E80", VA = "0x1828D5C80", Slot = "55")]
		private void LEGCYKSULMI(int a, Id32<RJHPWNGPQQO> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x28D6210", Offset = "0x28D5410", VA = "0x1828D6210", Slot = "68")]
		private void LMKFTBOXWUO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xE938F0", Offset = "0xE92AF0", VA = "0x180E938F0", Slot = "67")]
		private void HCWBMKKCGRV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x28D86B0", Offset = "0x28D78B0", VA = "0x1828D86B0", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, JDUFGOJEPGU?>>? VYMFFZJXZZR(Id32<XZLTFWVWVWY> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x28D57D0", Offset = "0x28D49D0", VA = "0x1828D57D0", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, JDUFGOJEPGU?>>? JHOPPYKNDWY(Id32<FXOBICRSDUR> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x28D4CE0", Offset = "0x28D3EE0", VA = "0x1828D4CE0", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, JDUFGOJEPGU?>>? EZEYMXXGWUV(Id32<XZLTFWVWVWY> inputDefId, Id32<XZLTFWVWVWY> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x28D60F0", Offset = "0x28D52F0", VA = "0x1828D60F0", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, JDUFGOJEPGU?>>? LJOXDYBYFKE(Id32<FXOBICRSDUR> outputDefId, Id32<FXOBICRSDUR> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x28D7A40", Offset = "0x28D6C40", VA = "0x1828D7A40", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, JDUFGOJEPGU?>>? REPGBOUFVRV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x28D7340", Offset = "0x28D6540", VA = "0x1828D7340", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, JDUFGOJEPGU>> OVEXTDYBLRA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x28D6380", Offset = "0x28D5580", VA = "0x1828D6380", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, JDUFGOJEPGU>> LQDEKGDULZT(Id32<XZLTFWVWVWY> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x28D81B0", Offset = "0x28D73B0", VA = "0x1828D81B0", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, JDUFGOJEPGU>> VWUYQREVUEW(Id32<FXOBICRSDUR> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x28D58E0", Offset = "0x28D4AE0", VA = "0x1828D58E0", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, JDUFGOJEPGU>> JILAVNTWHPY(Id32<XZLTFWVWVWY> inputDefId, MIILYKSZUVS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x28D8DD0", Offset = "0x28D7FD0", VA = "0x1828D8DD0", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, JDUFGOJEPGU>> XXJFWYUKHDB(Id32<FXOBICRSDUR> outputDefId, MIILYKSZUVS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x28D4EC0", Offset = "0x28D40C0", VA = "0x1828D4EC0")]
		internal void GKLUNTVNTVF(Id32<WXMOLFBEQDB> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class PTEMFAIRMBY : BTDOGBIDVJH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface ELSNTWPCDON
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<NZKBDZMUQMJ>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065F")]
				[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<NZKBDZMUQMJ>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			PZCZATDXERS PZCZATDXERS
			{
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> GQZYFHICZDT(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> HXUWLQGTRBK(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<NJNAUXVLGSU> PBAYARRHHRJ(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<VBVBJYMCJCU> QNHQANGMPPK(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> OYWIEMATUXT(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> ZSGLOLATFLK(CancellationToken a);
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
			public AsyncTaskMethodBuilder<PTEMFAIRMBY> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public RRHCIMKELZN circuitsManager;

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
			private ELSNTWPCDON <selfDeps>5__2;

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
			private NJNAUXVLGSU <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private VBVBJYMCJCU <playerSaveData>5__8;

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
			private TaskAwaiter<NJNAUXVLGSU> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<VBVBJYMCJCU> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<ELSNTWPCDON.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<FCZEXSWNMQC> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x28CB650", Offset = "0x28CA850", VA = "0x1828CB650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x28CC810", Offset = "0x28CBA10", VA = "0x1828CC810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public FCZEXSWNMQC FCZEXSWNMQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public JLVAVCHMIDO JLVAVCHMIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public SJWVZEMLUVH SJWVZEMLUVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public VGVVQLSXQGB VGVVQLSXQGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xEC1580", Offset = "0xEC0780", VA = "0x180EC1580")]
		private PTEMFAIRMBY(FCZEXSWNMQC a, JLVAVCHMIDO b, SJWVZEMLUVH c, VGVVQLSXQGB d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x28C5CA0", Offset = "0x28C4EA0", VA = "0x1828C5CA0")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<PTEMFAIRMBY> XLJEXHLYWIN(RRHCIMKELZN a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x28C5C80", Offset = "0x28C4E80", VA = "0x1828C5C80", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class ZIXPGQUVXZI : VCWVNKLHUPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly RRHCIMKELZN GLGGEMXYIBO;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public LSKPFMPPTFI? DZRVHNEPLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x28D99D0", Offset = "0x28D8BD0", VA = "0x1828D99D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		internal ZIXPGQUVXZI(RRHCIMKELZN a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class SJWVZEMLUVH : LSKPFMPPTFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly RRHCIMKELZN GLGGEMXYIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly FCZEXSWNMQC ODFDTYQEEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly ZIXPGQUVXZI JAOSARPOMTJ;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> HKADVPEELWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x28C8F90", Offset = "0x28C8190", VA = "0x1828C8F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xB5E4E0", Offset = "0xB5D6E0", VA = "0x180B5E4E0")]
		public SJWVZEMLUVH(RRHCIMKELZN a, FCZEXSWNMQC b, ZIXPGQUVXZI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x28C8F40", Offset = "0x28C8140", VA = "0x1828C8F40", Slot = "5")]
		public string FQCZKPHHQPZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x28C8FD0", Offset = "0x28C81D0", VA = "0x1828C8FD0", Slot = "6")]
		public void USKSFQDARAC(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x28DED90", Offset = "0x28DDF90", VA = "0x1828DED90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x28DEFD0", Offset = "0x28DE1D0", VA = "0x1828DEFD0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, JDUFGOJEPGU>> <>t__builder;

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
			private USPEKNRWVPE[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x28DF7D0", Offset = "0x28DE9D0", VA = "0x1828DF7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x28DFBA0", Offset = "0x28DEDA0", VA = "0x1828DFBA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public USPEKNRWVPE action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x28E3EC0", Offset = "0x28E30C0", VA = "0x1828E3EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x28E42D0", Offset = "0x28E34D0", VA = "0x1828E42D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly DLOXXYQFPRD _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
		public EVRequestExtended(DLOXXYQFPRD staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x28C2510", Offset = "0x28C1710", VA = "0x1828C2510")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, JDUFGOJEPGU>> LKRUMWVBRVX(USPEKNRWVPE a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x28C2640", Offset = "0x28C1840", VA = "0x1828C2640")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, JDUFGOJEPGU?>>? UPFPWWRPZLM(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x28C2420", Offset = "0x28C1620", VA = "0x1828C2420")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, JDUFGOJEPGU>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface ZYKWBNETGNH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		BTDOGBIDVJH? DZRVHNEPLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool SKRCPBVXMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool OMOMCSXCLPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<BTDOGBIDVJH?>? VNBNBTRUYUN();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task DRWAGXEESWS(RRHCIMKELZN a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface BTDOGBIDVJH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		FCZEXSWNMQC FCZEXSWNMQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		JLVAVCHMIDO JLVAVCHMIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		SJWVZEMLUVH SJWVZEMLUVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		VGVVQLSXQGB VGVVQLSXQGB
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class WQUEHXGHASC
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x28EC600", Offset = "0x28EB800", VA = "0x1828EC600")]
		public static ReducerFactory<ActionKind, USPEKNRWVPE, RRHCIMKELZN, RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>> MEOSFTJHEEP([In] this ReducerFactory<ActionKind, USPEKNRWVPE, RRHCIMKELZN, RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, USPEKNRWVPE, RRHCIMKELZN, RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class SWUNRXFXXLH : RTBCXHUIOQG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly RRHCIMKELZN GLGGEMXYIBO;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool OMOMCSXCLPG
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x28DE5B0", Offset = "0x28DD7B0", VA = "0x1828DE5B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		internal SWUNRXFXXLH(RRHCIMKELZN a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class EBMMTQZZARY : JMOBNNFBEAL
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x28DB260", Offset = "0x28DA460", VA = "0x1828DB260", Slot = "4")]
		public DLFBFMEYOWZ? QXGIKPPYIYG(string? a, string? b, string? c, RoomDoorData.XTSKGUBYJNP.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x28DB2F0", Offset = "0x28DA4F0", VA = "0x1828DB2F0", Slot = "5")]
		public VSRTOLQECND ZSEXMDHXAFS(string a, string b, List<string> c, int d, int e, int f, int g, TZYAEDLYUWN h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x28DB1C0", Offset = "0x28DA3C0", VA = "0x1828DB1C0", Slot = "6")]
		public TZYAEDLYUWN JAZWNPAETCO(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public EBMMTQZZARY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class ABWWDJKMJLI : TFAVROEGEKR
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
			public AsyncTaskMethodBuilder<YGDIPUPKRWC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public ABWWDJKMJLI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<BTDOGBIDVJH?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x28DF040", Offset = "0x28DE240", VA = "0x1828DF040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x28DF2D0", Offset = "0x28DE4D0", VA = "0x1828DF2D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly RRHCIMKELZN GLGGEMXYIBO;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public YGDIPUPKRWC? DZRVHNEPLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x28DA1F0", Offset = "0x28D93F0", VA = "0x1828DA1F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public VGVVQLSXQGB? SGINOJGFAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x28DA300", Offset = "0x28D9500", VA = "0x1828DA300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool ENEYTDQIPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x28DA2A0", Offset = "0x28D94A0", VA = "0x1828DA2A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool GNNZQTLMTIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x28DA190", Offset = "0x28D9390", VA = "0x1828DA190", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x28DAB40", Offset = "0x28D9D40", VA = "0x1828DAB40")]
		internal ABWWDJKMJLI(RRHCIMKELZN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x28DA8D0", Offset = "0x28D9AD0", VA = "0x1828DA8D0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<YGDIPUPKRWC> VNBNBTRUYUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x28DA380", Offset = "0x28D9580", VA = "0x1828DA380", Slot = "9")]
		public IReadOnlyDictionary<Id128<NZKBDZMUQMJ>, Guid> NPKIKOLAOLP(IEnumerable<BSVXXMCDZJY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x28DA9C0", Offset = "0x28D9BC0", VA = "0x1828DA9C0", Slot = "10")]
		public CircuitGraphToolMappingRegistryData ZHTIDWVFSBH(IEnumerable<BSVXXMCDZJY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x28DA700", Offset = "0x28D9900", VA = "0x1828DA700")]
		public Result<CircuitsRoomData, WMUYMRHRYMC> ORBEMBJWAPH([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, WMUYMRHRYMC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x28DA270", Offset = "0x28D9470", VA = "0x1828DA270", Slot = "8")]
		private Result<CircuitsRoomData, WMUYMRHRYMC> HMUQOYTYCLO([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, WMUYMRHRYMC>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class VGVVQLSXQGB : YGDIPUPKRWC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class LLURBPETPZK
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class UITEPKMAORH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int ONWIRAFZOEX;

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public UITEPKMAORH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x28E4B10", Offset = "0x28E3D10", VA = "0x1828E4B10")]
				internal void UJXNECIWJHU(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x28DCC30", Offset = "0x28DBE30", VA = "0x1828DCC30")]
			public static Result<YGDIPUPKRWC.PrepareTemplateForCloneResult, SXSCEXBQPFJ> SOOCWXYATXH(VGVVQLSXQGB a, [In] YGDIPUPKRWC.PrepareTemplateForCloneArgs args)
			{
				return default(Result<YGDIPUPKRWC.PrepareTemplateForCloneResult, SXSCEXBQPFJ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x28DB450", Offset = "0x28DA650", VA = "0x1828DB450")]
			internal static Result<(VMAYEPEBAHA, CircuitTemplateRootData), SXSCEXBQPFJ> JLLXIATAARJ(VGVVQLSXQGB a, CircuitTemplateRootData b, bool c, [In] Id128<NZKBDZMUQMJ> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(VMAYEPEBAHA, CircuitTemplateRootData), SXSCEXBQPFJ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x28DD170", Offset = "0x28DC370", VA = "0x1828DD170")]
			private static void UKDASYJQMHX(bool a, BSVXXMCDZJY b, VMAYEPEBAHA c, [In] Id128<NZKBDZMUQMJ> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x28DC2A0", Offset = "0x28DB4A0", VA = "0x1828DC2A0")]
			public static void KEOANCSJSWS(SXKHJAXUAYV a, [In] YGDIPUPKRWC.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x28DC6A0", Offset = "0x28DB8A0", VA = "0x1828DC6A0")]
			[CompilerGenerated]
			internal static bool SDIFWGWCOFF(FCZEXSWNMQC a, FGITXDOLHEZ b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x28DD140", Offset = "0x28DC340", VA = "0x1828DD140")]
			[CompilerGenerated]
			internal static bool TPNDHXIJROG(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class KSYWZYBCWPY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public VGVVQLSXQGB LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<NZKBDZMUQMJ> JKMQQRBUYBM;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public KSYWZYBCWPY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x28DB3C0", Offset = "0x28DA5C0", VA = "0x1828DB3C0")]
			internal Id128<FAVTMLJIUOX> QNJHKOKTMGF(Id32<FAVTMLJIUOX> a)
			{
				return default(Id128<FAVTMLJIUOX>);
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<HCYBYNYIFYK> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<KWIEUHKUXJL> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x28DFC10", Offset = "0x28DEE10", VA = "0x1828DFC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x28E01E0", Offset = "0x28DF3E0", VA = "0x1828E01E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<FAVTMLJIUOX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<WXMOLFBEQDB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<XZLTFWVWVWY> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x28E0250", Offset = "0x28DF450", VA = "0x1828E0250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x28E05A0", Offset = "0x28DF7A0", VA = "0x1828E05A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<FAVTMLJIUOX>, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<QNINDUGEANA> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private FCZEXSWNMQC <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x28E08F0", Offset = "0x28DFAF0", VA = "0x1828E08F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x28E0D20", Offset = "0x28DFF20", VA = "0x1828E0D20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<FAVTMLJIUOX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x28E0610", Offset = "0x28DF810", VA = "0x1828E0610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x28E0880", Offset = "0x28DFA80", VA = "0x1828E0880", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x28E0D90", Offset = "0x28DFF90", VA = "0x1828E0D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x28E0F80", Offset = "0x28E0180", VA = "0x1828E0F80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<NZKBDZMUQMJ> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<FAVTMLJIUOX> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<FAVTMLJIUOX>> nodeIds;

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
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x28E0FF0", Offset = "0x28E01F0", VA = "0x1828E0FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x28E1290", Offset = "0x28E0490", VA = "0x1828E1290", Slot = "5")]
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
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<NZKBDZMUQMJ> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<FAVTMLJIUOX> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<FAVTMLJIUOX>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<WXMOLFBEQDB>, Id32<EXAEBOAKZGD>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<WXMOLFBEQDB>, Id32<RJHPWNGPQQO>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x28E1300", Offset = "0x28E0500", VA = "0x1828E1300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x28E18D0", Offset = "0x28E0AD0", VA = "0x1828E18D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<NZKBDZMUQMJ> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<FAVTMLJIUOX> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<FAVTMLJIUOX>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x28E1930", Offset = "0x28E0B30", VA = "0x1828E1930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x28E1B40", Offset = "0x28E0D40", VA = "0x1828E1B40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<FAVTMLJIUOX> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<WXMOLFBEQDB> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<EXAEBOAKZGD> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x28E1BB0", Offset = "0x28E0DB0", VA = "0x1828E1BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x28E1F00", Offset = "0x28E1100", VA = "0x1828E1F00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<FAVTMLJIUOX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<WXMOLFBEQDB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<XZLTFWVWVWY> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x28E1F70", Offset = "0x28E1170", VA = "0x1828E1F70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x28E2350", Offset = "0x28E1550", VA = "0x1828E2350", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<FAVTMLJIUOX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x28E23C0", Offset = "0x28E15C0", VA = "0x1828E23C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x28E2640", Offset = "0x28E1840", VA = "0x1828E2640", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<FAVTMLJIUOX> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<WXMOLFBEQDB> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<RJHPWNGPQQO> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x28E26B0", Offset = "0x28E18B0", VA = "0x1828E26B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x28E2A00", Offset = "0x28E1C00", VA = "0x1828E2A00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<FAVTMLJIUOX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x28E2A70", Offset = "0x28E1C70", VA = "0x1828E2A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x28E2DB0", Offset = "0x28E1FB0", VA = "0x1828E2DB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<FAVTMLJIUOX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x28E2E20", Offset = "0x28E2020", VA = "0x1828E2E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x28E30B0", Offset = "0x28E22B0", VA = "0x1828E30B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<FAVTMLJIUOX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x28E3120", Offset = "0x28E2320", VA = "0x1828E3120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x28E33B0", Offset = "0x28E25B0", VA = "0x1828E33B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<FAVTMLJIUOX>>, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<NZKBDZMUQMJ> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<BSVXXMCDZJY> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<AUAIRMEYYLK>, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x28E3420", Offset = "0x28E2620", VA = "0x1828E3420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x28E3BC0", Offset = "0x28E2DC0", VA = "0x1828E3BC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<NZKBDZMUQMJ> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<FAVTMLJIUOX> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<FAVTMLJIUOX>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x28E3C30", Offset = "0x28E2E30", VA = "0x1828E3C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x28E3E50", Offset = "0x28E3050", VA = "0x1828E3E50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public VGVVQLSXQGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<NZKBDZMUQMJ> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<FAVTMLJIUOX> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x28E43B0", Offset = "0x28E35B0", VA = "0x1828E43B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x28E45D0", Offset = "0x28E37D0", VA = "0x1828E45D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly RRHCIMKELZN GLGGEMXYIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly FCZEXSWNMQC ODFDTYQEEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers RFLGLVFQVQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly ABWWDJKMJLI KAAHTGFMNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<FAVTMLJIUOX>, EVXNXIKLNWV> SSKLISGFCZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<FAVTMLJIUOX>>? VBAISYLJUPH;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<NZKBDZMUQMJ> RBPLUAZOTAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x28E5920", Offset = "0x28E4B20", VA = "0x1828E5920", Slot = "4")]
			get
			{
				return default(Id128<NZKBDZMUQMJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers YWNZWMCTKZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x28E6690", Offset = "0x28E5890", VA = "0x1828E6690", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> ALOATRLIKBG
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x28EA6E0", Offset = "0x28E98E0", VA = "0x1828EA6E0", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action XBXSGCFUBNB
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x28EA560", Offset = "0x28E9760", VA = "0x1828EA560", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x28E66A0", Offset = "0x28E58A0", VA = "0x1828E66A0", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> ALYQSMWXQRX
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x28EA020", Offset = "0x28E9220", VA = "0x1828EA020", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x28EA6C0", Offset = "0x28E98C0", VA = "0x1828EA6C0", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x28EC1A0", Offset = "0x28EB3A0", VA = "0x1828EC1A0")]
		public VGVVQLSXQGB(RRHCIMKELZN a, FCZEXSWNMQC b, ABWWDJKMJLI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x28E65F0", Offset = "0x28E57F0", VA = "0x1828E65F0", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x28E7650", Offset = "0x28E6850", VA = "0x1828E7650", Slot = "100")]
		public Id32<VQMMYMKBSUP> HPEQAVQTCIQ(Id32<NZKBDZMUQMJ> graphId, Id32<KWIEUHKUXJL> inputId)
		{
			return default(Id32<VQMMYMKBSUP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x28E7E10", Offset = "0x28E7010", VA = "0x1828E7E10", Slot = "101")]
		public Id32<DEALJTDQHQG> IWKWWRQRLNN(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> outputId)
		{
			return default(Id32<DEALJTDQHQG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x28E9010", Offset = "0x28E8210", VA = "0x1828E9010", Slot = "6")]
		public (bool, bool) ORMMMUJWHNO(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> srcId, Id32<KWIEUHKUXJL> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x28E9C00", Offset = "0x28E8E00", VA = "0x1828E9C00")]
		public bool PJKYTJOQHVT(Id32<NZKBDZMUQMJ> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x28EA580", Offset = "0x28E9780", VA = "0x1828EA580", Slot = "8")]
		public bool SAQWYTNRNPL(WVFYSXHQAXF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x28E8CE0", Offset = "0x28E7EE0", VA = "0x1828E8CE0", Slot = "9")]
		public bool NLHMYEJQHIU(FBFBNRKPMVK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x28EB410", Offset = "0x28EA610", VA = "0x1828EB410", Slot = "10")]
		public AbsoluteLegacyInputId? YTCWLFDXKFF(Id32<NZKBDZMUQMJ> graphId, Id32<KWIEUHKUXJL> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x28EA180", Offset = "0x28E9380", VA = "0x1828EA180", Slot = "11")]
		public AbsoluteLegacyOutputId? QWQBHUVQORA(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x28EAF90", Offset = "0x28EA190", VA = "0x1828EAF90", Slot = "12")]
		public Id32<HCYBYNYIFYK>? VSLRGPFNELK(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId, Id32<RJHPWNGPQQO> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x28E62F0", Offset = "0x28E54F0", VA = "0x1828E62F0", Slot = "13")]
		public Id32<KWIEUHKUXJL>? DLRCLSKBOXL(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId, Id32<EXAEBOAKZGD> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x28E8820", Offset = "0x28E7A20", VA = "0x1828E8820", Slot = "14")]
		public IEnumerable<Id32<NZKBDZMUQMJ>> LRLEXJMBJOV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x28EA700", Offset = "0x28E9900", VA = "0x1828EA700", Slot = "15")]
		public IEnumerable<Id32<NFRTHLBJYHR>> TUQDEVLDZES()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x28EA620", Offset = "0x28E9820", VA = "0x1828EA620", Slot = "22")]
		public string STOYJQWXTLU(Id32<NFRTHLBJYHR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x28EA7B0", Offset = "0x28E99B0", VA = "0x1828EA7B0", Slot = "16")]
		public Id32<NFRTHLBJYHR>? UEJUSYAWFPI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x28E8C00", Offset = "0x28E7E00", VA = "0x1828E8C00", Slot = "17")]
		public int MQZYSUUOPBB(Id32<NFRTHLBJYHR> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x28EA3E0", Offset = "0x28E95E0", VA = "0x1828EA3E0", Slot = "18")]
		public int RSFKNHMGQXK(Id32<NFRTHLBJYHR> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x28E75C0", Offset = "0x28E67C0", VA = "0x1828E75C0", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] HNUGHACMAKV(Id32<NFRTHLBJYHR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x28EAB30", Offset = "0x28E9D30", VA = "0x1828EAB30", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] VJFSCXRMJRY(Id32<NFRTHLBJYHR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C22500", Offset = "0x3C21700", VA = "0x183C22500")]
		private static (CircuitTypeIdWrapper, string?)[]? UJAHXDYNTGX<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x28E8BB0", Offset = "0x28E7DB0", VA = "0x1828E8BB0", Slot = "21")]
		public string MOFHSLKHYXQ(Id32<NFRTHLBJYHR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x28E67D0", Offset = "0x28E59D0", VA = "0x1828E67D0", Slot = "23")]
		public string ENBVOBAYJEL(Id32<NFRTHLBJYHR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x28E6D20", Offset = "0x28E5F20", VA = "0x1828E6D20")]
		public EVXNXIKLNWV? FSUAZUUKPKU([In] Id128<FAVTMLJIUOX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x28E9EF0", Offset = "0x28E90F0", VA = "0x1828E9EF0", Slot = "30")]
		public Id32<QNINDUGEANA> PNIWRQNHXFQ(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId)
		{
			return default(Id32<QNINDUGEANA>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x28EA3B0", Offset = "0x28E95B0", VA = "0x1828EA3B0")]
		public Id32<FAVTMLJIUOX> RNUODMCQKBH(Id32<NZKBDZMUQMJ> graphId, [In] Id128<FAVTMLJIUOX> legacyNodeId)
		{
			return default(Id32<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x28EA600", Offset = "0x28E9800", VA = "0x1828EA600", Slot = "40")]
		public Id32<FAVTMLJIUOX> SBJJTKTRFTA(Id32<NZKBDZMUQMJ> graphId, Id32<KWIEUHKUXJL> inputId)
		{
			return default(Id32<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x28E4B30", Offset = "0x28E3D30", VA = "0x1828E4B30", Slot = "41")]
		public Id32<FAVTMLJIUOX> ANUAUIRAZZX(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> outputId)
		{
			return default(Id32<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x28EAA70", Offset = "0x28E9C70", VA = "0x1828EAA70")]
		public Id32<FAVTMLJIUOX>? UFARELHPOPH(Id32<NZKBDZMUQMJ> graphId, [In] Id128<FAVTMLJIUOX> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x28E6350", Offset = "0x28E5550", VA = "0x1828E6350", Slot = "32")]
		public AbsoluteNodeId? DOIQEKUSQLB(Id32<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x28E8B90", Offset = "0x28E7D90", VA = "0x1828E8B90", Slot = "33")]
		public long MDWLHNHPACA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x28E7D90", Offset = "0x28E6F90", VA = "0x1828E7D90")]
		private void ITYDJTKUBTS(Id128<FAVTMLJIUOX> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x28E67F0", Offset = "0x28E59F0", VA = "0x1828E67F0", Slot = "38")]
		public IEnumerable<(Id32<NZKBDZMUQMJ>, Id32<FAVTMLJIUOX>)> EQWCZZCWDLE(Id32<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x28E6320", Offset = "0x28E5520", VA = "0x1828E6320", Slot = "39")]
		public Id32<KWIEUHKUXJL> DLRCLSKBOXL(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<VQMMYMKBSUP> inputIndex)
		{
			return default(Id32<KWIEUHKUXJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x28EAF60", Offset = "0x28EA160", VA = "0x1828EAF60", Slot = "42")]
		public Id32<HCYBYNYIFYK> VSLRGPFNELK(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<DEALJTDQHQG> outputIndex)
		{
			return default(Id32<HCYBYNYIFYK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x28EA650", Offset = "0x28E9850", VA = "0x1828EA650")]
		private EVXNXIKLNWV? SZZQQOKVZUH([In] Id128<FAVTMLJIUOX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x28E8E90", Offset = "0x28E8090", VA = "0x1828E8E90")]
		public AUAIRMEYYLK? OHJSWTFYTDD([In] Id128<FAVTMLJIUOX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x28E84F0", Offset = "0x28E76F0", VA = "0x1828E84F0")]
		public AAIZPJCHXDV? JMLKHXATNYA([In] Id128<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x28E8520", Offset = "0x28E7720", VA = "0x1828E8520", Slot = "25")]
		public AAIZPJCHXDV? JMLKHXATNYA(Id32<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x28EB370", Offset = "0x28EA570", VA = "0x1828EB370", Slot = "34")]
		public IEnumerable<NewStaticEdge> YKAOQJUCIFK(Id32<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x28E6770", Offset = "0x28E5970", VA = "0x1828E6770", Slot = "35")]
		public bool EHGSDWOVEWE(Id32<NFRTHLBJYHR> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x28E5590", Offset = "0x28E4790", VA = "0x1828E5590", Slot = "36")]
		public IEnumerable<StableStaticEdge> BZJHDPCACXG(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x28E7EF0", Offset = "0x28E70F0", VA = "0x1828E7EF0", Slot = "37")]
		public IEnumerable<StableStaticEdge> JAGCKUTUJYD(Id32<NZKBDZMUQMJ> graphId, Id32<KWIEUHKUXJL> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x28EAFC0", Offset = "0x28EA1C0", VA = "0x1828EAFC0")]
		public Id32<NZKBDZMUQMJ> WUYRZZGCUAR([In] Id128<NZKBDZMUQMJ> graphId)
		{
			return default(Id32<NZKBDZMUQMJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x28E6B80", Offset = "0x28E5D80", VA = "0x1828E6B80")]
		public Id32<NZKBDZMUQMJ>? WNEIBIXKQUN([In] Id128<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x28E6E70", Offset = "0x28E6070", VA = "0x1828E6E70")]
		private FGITXDOLHEZ? FTMOMZGBQSL([In] Id128<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x28E84F0", Offset = "0x28E76F0", VA = "0x1828E84F0")]
		private AAIZPJCHXDV? SHGCRQSTLVY([In] Id128<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x28E9F10", Offset = "0x28E9110", VA = "0x1828E9F10", Slot = "28")]
		public Id32<NZKBDZMUQMJ>? PPZRDKLZZME(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x28E5900", Offset = "0x28E4B00", VA = "0x1828E5900", Slot = "46")]
		public Id128<NZKBDZMUQMJ> DGIONMNCWEQ(Id32<NZKBDZMUQMJ> graphId)
		{
			return default(Id128<NZKBDZMUQMJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x28E8BE0", Offset = "0x28E7DE0", VA = "0x1828E8BE0", Slot = "47")]
		public Id128<FAVTMLJIUOX> MQHBAGJBPJM(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId)
		{
			return default(Id128<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x28E6A80", Offset = "0x28E5C80", VA = "0x1828E6A80", Slot = "43")]
		public IEnumerable<MIILYKSZUVS> FEPLMJIPRWU(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x28E8890", Offset = "0x28E7A90", VA = "0x1828E8890", Slot = "44")]
		public MIILYKSZUVS LXCXAWYXZFD(RoomVersion a, YSPMOZFFUWS b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x28E9510", Offset = "0x28E8710", VA = "0x1828E9510")]
		public NewStaticEdge OVPAMVHWREL(Id32<NZKBDZMUQMJ> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x28EA040", Offset = "0x28E9240", VA = "0x1828EA040", Slot = "48")]
		public StableStaticEdge QUTTAMLBBPU(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> srcId, Id32<KWIEUHKUXJL> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x28E86D0", Offset = "0x28E78D0", VA = "0x1828E86D0", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, JDUFGOJEPGU>> KTRHCPQVCRZ(Id32<NZKBDZMUQMJ> parentGraphId, Id32<FAVTMLJIUOX> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x28E7270", Offset = "0x28E6470", VA = "0x1828E7270", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, JDUFGOJEPGU>> GVOWWSPMOCS(Id32<NZKBDZMUQMJ> parentGraphId, Id128<FAVTMLJIUOX> boardNodeId, List<Id32<FAVTMLJIUOX>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x28E8280", Offset = "0x28E7480", VA = "0x1828E8280", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, JDUFGOJEPGU>> JEEDFCUMKBR(Id32<NZKBDZMUQMJ> parentGraphId, Id128<FAVTMLJIUOX> boardNodeId, List<Id32<FAVTMLJIUOX>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x28EBC30", Offset = "0x28EAE30", VA = "0x1828EBC30", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, JDUFGOJEPGU>> ZIYUHUAZULX(Id32<NZKBDZMUQMJ> parentGraphId, Id128<FAVTMLJIUOX> boardNodeId, Id32<NZKBDZMUQMJ> graphId, List<Id32<FAVTMLJIUOX>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x28EBEF0", Offset = "0x28EB0F0", VA = "0x1828EBEF0", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<WXMOLFBEQDB>, Id32<EXAEBOAKZGD>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<WXMOLFBEQDB>, Id32<RJHPWNGPQQO>)>) ZSJYZVJINIS(Id128<NZKBDZMUQMJ> legacyGraphId, Id32<FAVTMLJIUOX> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<WXMOLFBEQDB>, Id32<EXAEBOAKZGD>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<WXMOLFBEQDB>, Id32<RJHPWNGPQQO>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x28E6910", Offset = "0x28E5B10", VA = "0x1828E6910", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task ETZGDFRWMUU(Id128<NZKBDZMUQMJ> legacyGraphId, Id128<FAVTMLJIUOX> boardNodeId, IReadOnlyList<Id128<FAVTMLJIUOX>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<WXMOLFBEQDB>, Id32<EXAEBOAKZGD>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<WXMOLFBEQDB>, Id32<RJHPWNGPQQO>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x28EA790", Offset = "0x28E9990", VA = "0x1828EA790", Slot = "55")]
		public bool UCCAISLQMSM(Id32<NZKBDZMUQMJ> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x28E7C50", Offset = "0x28E6E50", VA = "0x1828E7C50", Slot = "56")]
		public bool IHNORNISWZO(Id32<NZKBDZMUQMJ> graphId, Id32<KWIEUHKUXJL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x28E9970", Offset = "0x28E8B70", VA = "0x1828E9970", Slot = "57")]
		public bool PEHGTUVSXNT(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x28E7620", Offset = "0x28E6820", VA = "0x1828E7620")]
		public Result<YGDIPUPKRWC.PrepareTemplateForCloneResult, SXSCEXBQPFJ> KLUQHARXRMJ([In] YGDIPUPKRWC.PrepareTemplateForCloneArgs args)
		{
			return default(Result<YGDIPUPKRWC.PrepareTemplateForCloneResult, SXSCEXBQPFJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x28E8D60", Offset = "0x28E7F60", VA = "0x1828E8D60", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, JDUFGOJEPGU>> OGXHBUQNSON(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> srcId, Id32<KWIEUHKUXJL> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x28E9990", Offset = "0x28E8B90", VA = "0x1828E9990", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<FAVTMLJIUOX>, JDUFGOJEPGU>> PGEGHFKUEMY(Id32<NZKBDZMUQMJ> graphId, Id32<QNINDUGEANA> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x28E8ED0", Offset = "0x28E80D0", VA = "0x1828E8ED0", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> ONGEJXSUYWV(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x28EAFF0", Offset = "0x28EA1F0", VA = "0x1828EAFF0", Slot = "62")]
		public Result<ControlPanelRootData, WMUYMRHRYMC> YEXOSWISCQB(Id128<NZKBDZMUQMJ> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, WMUYMRHRYMC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x28EA400", Offset = "0x28E9600", VA = "0x1828EA400", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, JDUFGOJEPGU>> RVKMDFZIKKB(Id128<NZKBDZMUQMJ> graphId, Id128<FAVTMLJIUOX> inputNodeId, Id32<WXMOLFBEQDB> inputPortGroupId, Id32<EXAEBOAKZGD> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x28EB470", Offset = "0x28EA670", VA = "0x1828EB470", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, JDUFGOJEPGU>> YTFAIDGWEUM(Id128<NZKBDZMUQMJ> graphId, Id128<FAVTMLJIUOX> outputNodeId, Id32<WXMOLFBEQDB> outputPortGroupId, Id32<RJHPWNGPQQO> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x28E9AF0", Offset = "0x28E8CF0", VA = "0x1828E9AF0", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, JDUFGOJEPGU>> PGLRPRODCJL(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x28EBD90", Offset = "0x28EAF90", VA = "0x1828EBD90", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<FAVTMLJIUOX>>, JDUFGOJEPGU>> ZPQYQVWRASW(Id128<NZKBDZMUQMJ> intoGraphId, CircuitTemplateRootData a, IEnumerable<BSVXXMCDZJY> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x28E70A0", Offset = "0x28E62A0", VA = "0x1828E70A0", Slot = "67")]
		public CircuitsData GJDZUKXOCOQ()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x28E4B50", Offset = "0x28E3D50", VA = "0x1828E4B50", Slot = "68")]
		public CircuitsData ARRSBYPFECV()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x28E6450", Offset = "0x28E5650", VA = "0x1828E6450", Slot = "71")]
		public CircuitsTemplateData DPQWNMCWZSO(TemplateSerializationReason a, Id32<NZKBDZMUQMJ> sourceGraphId, IEnumerable<Id128<NZKBDZMUQMJ>> graphIds, IEnumerable<Id128<FAVTMLJIUOX>> nodeIds, ISet<Id128<NFKDLTDXJBR>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x28E6F10", Offset = "0x28E6110", VA = "0x1828E6F10")]
		private CircuitsTemplateData GAPKSKJQTBV(TemplateSerializationReason a, Id32<NZKBDZMUQMJ> sourceGraphId, IEnumerable<Id128<NZKBDZMUQMJ>> graphIds, IEnumerable<Id128<FAVTMLJIUOX>> nodeIds, ISet<Id128<NFKDLTDXJBR>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x28E9600", Offset = "0x28E8800", VA = "0x1828E9600", Slot = "69")]
		public CircuitsTemplateData OVWPGEKDFLL(TemplateSerializationReason a, Id32<NZKBDZMUQMJ> sourceGraphId, IEnumerable<Id128<FAVTMLJIUOX>> nodeIds, IEnumerable<BSVXXMCDZJY> b, ISet<Id128<NFKDLTDXJBR>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x28E9860", Offset = "0x28E8A60", VA = "0x1828E9860", Slot = "70")]
		public CircuitsTemplateData OVWPGEKDFLL(TemplateSerializationReason a, Id32<NZKBDZMUQMJ> sourceGraphId, IEnumerable<Id32<FAVTMLJIUOX>> nodeIds, IEnumerable<BSVXXMCDZJY> b, ISet<Id128<NFKDLTDXJBR>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x28EAB90", Offset = "0x28E9D90", VA = "0x1828EAB90")]
		private static IEnumerable<Id128<NZKBDZMUQMJ>> VMDFPHPHSLV(IEnumerable<BSVXXMCDZJY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x28E7670", Offset = "0x28E6870", VA = "0x1828E7670")]
		private IEnumerable<Id128<FAVTMLJIUOX>> HPYKCPDFJXZ(IEnumerable<BSVXXMCDZJY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x28E84B0", Offset = "0x28E76B0", VA = "0x1828E84B0", Slot = "72")]
		public List<OUUOSIRLAVE> JKJEPYHQGRI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x28EB5D0", Offset = "0x28EA7D0", VA = "0x1828EB5D0")]
		public (List<OUUOSIRLAVE>, bool) ZBGWEGRLJRP([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, FTTHWDAOFXU b, ITZIBLWYZOO c)
		{
			return default((List<OUUOSIRLAVE>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x28EAAA0", Offset = "0x28E9CA0", VA = "0x1828EAAA0", Slot = "74")]
		public bool UQMMHLKUNOA(Id32<NZKBDZMUQMJ> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x28E6880", Offset = "0x28E5A80", VA = "0x1828E6880", Slot = "75")]
		public bool ETLDQFBQSIG(Id32<NZKBDZMUQMJ> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x28E6A60", Offset = "0x28E5C60", VA = "0x1828E6A60")]
		internal void FCPVSZPZFUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x28E66C0", Offset = "0x28E58C0", VA = "0x1828E66C0")]
		internal Task EDYCAXASLSF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x28E4BE0", Offset = "0x28E3DE0", VA = "0x1828E4BE0", Slot = "76")]
		public Result<Id32<HCYBYNYIFYK>?, JDUFGOJEPGU> BHAKWNFHZPL(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<KWIEUHKUXJL> inputId)
		{
			return default(Result<Id32<HCYBYNYIFYK>?, JDUFGOJEPGU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x28E5940", Offset = "0x28E4B40", VA = "0x1828E5940", Slot = "77")]
		public Result<Id32<KWIEUHKUXJL>?, JDUFGOJEPGU> DLNOHUSAQKB(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<HCYBYNYIFYK> outputId)
		{
			return default(Result<Id32<KWIEUHKUXJL>?, JDUFGOJEPGU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x28E73F0", Offset = "0x28E65F0", VA = "0x1828E73F0", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, JDUFGOJEPGU>> HGXUVNUGBJQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x28E8570", Offset = "0x28E7770", VA = "0x1828E8570", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, JDUFGOJEPGU>> JNMGPYDTKFW(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x28E7E30", Offset = "0x28E7030", VA = "0x1828E7E30", Slot = "80")]
		public Id32<FAVTMLJIUOX>? IYMBSGSZKUS(Id32<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x28E5840", Offset = "0x28E4A40", VA = "0x1828E5840", Slot = "81")]
		public Id32<FAVTMLJIUOX>? CPTFESNVNYL(Id32<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x28E66E0", Offset = "0x28E58E0", VA = "0x1828E66E0", Slot = "82")]
		public int EFKVENJFZIP(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x28E7B70", Offset = "0x28E6D70", VA = "0x1828E7B70", Slot = "83")]
		public int HTPODOUGVAM(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x28E74E0", Offset = "0x28E66E0", VA = "0x1828E74E0", Slot = "84")]
		public int HMLAVYMGXJP(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId, Id32<XZLTFWVWVWY> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x28E83D0", Offset = "0x28E75D0", VA = "0x1828E83D0", Slot = "85")]
		public int JKEPLBYXASP(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId, Id32<XZLTFWVWVWY> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x28E8140", Offset = "0x28E7340", VA = "0x1828E8140", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, JDUFGOJEPGU>> JAYDHYDNLOD(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId, Id32<XZLTFWVWVWY> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x28EC060", Offset = "0x28EB260", VA = "0x1828EC060", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, JDUFGOJEPGU>> ZXVBOEMZJDG(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId, Id32<XZLTFWVWVWY> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x28E8C20", Offset = "0x28E7E20", VA = "0x1828E8C20", Slot = "88")]
		public int NHGGKQAVIJF(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x28E7130", Offset = "0x28E6330", VA = "0x1828E7130", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, JDUFGOJEPGU>> GSPNZYVDSWB(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x28EA1E0", Offset = "0x28E93E0", VA = "0x1828EA1E0", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, JDUFGOJEPGU>> RKSAGBLSHYO(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x28E6BB0", Offset = "0x28E5DB0", VA = "0x1828E6BB0", Slot = "91")]
		public bool FPTOLAUWDBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x28E86B0", Offset = "0x28E78B0", VA = "0x1828E86B0", Slot = "97")]
		public IEnumerable<Id32<ZEROUCBBYDP>> KCFSXJPZKYB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x28E6E50", Offset = "0x28E6050", VA = "0x1828E6E50", Slot = "98")]
		public string? FTGWHWKRCQJ(Id32<ZEROUCBBYDP> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x28E7C40", Offset = "0x28E6E40", VA = "0x1828E7C40", Slot = "7")]
		private bool HUUUHZLTGDL(Id32<NZKBDZMUQMJ> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x28E84F0", Offset = "0x28E76F0", VA = "0x1828E84F0", Slot = "24")]
		private AAIZPJCHXDV LZJNMIODAYM([In] Id128<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x28EAFC0", Offset = "0x28EA1C0", VA = "0x1828EAFC0", Slot = "26")]
		private Id32<NZKBDZMUQMJ> ZQWWMOZRPIV([In] Id128<NZKBDZMUQMJ> graphId)
		{
			return default(Id32<NZKBDZMUQMJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x28E6B80", Offset = "0x28E5D80", VA = "0x1828E6B80", Slot = "27")]
		private Id32<NZKBDZMUQMJ>? FMYSSWANULH([In] Id128<NZKBDZMUQMJ> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x28E7C70", Offset = "0x28E6E70", VA = "0x1828E7C70", Slot = "29")]
		private EVXNXIKLNWV IQRNRYMXRLC([In] Id128<FAVTMLJIUOX> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x28EA3B0", Offset = "0x28E95B0", VA = "0x1828EA3B0", Slot = "31")]
		private Id32<FAVTMLJIUOX> XKIYXZWMAPL(Id32<NZKBDZMUQMJ> graphId, [In] Id128<FAVTMLJIUOX> legacyNodeId)
		{
			return default(Id32<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x28E9510", Offset = "0x28E8710", VA = "0x1828E9510", Slot = "45")]
		private NewStaticEdge YGMCVLBOTRZ(Id32<NZKBDZMUQMJ> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x28E7620", Offset = "0x28E6820", VA = "0x1828E7620", Slot = "58")]
		private Result<YGDIPUPKRWC.PrepareTemplateForCloneResult, SXSCEXBQPFJ> HOOLPXNDJPT([In] YGDIPUPKRWC.PrepareTemplateForCloneArgs args)
		{
			return default(Result<YGDIPUPKRWC.PrepareTemplateForCloneResult, SXSCEXBQPFJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x28E94B0", Offset = "0x28E86B0", VA = "0x1828E94B0", Slot = "73")]
		private (List<OUUOSIRLAVE>, bool) OUQCFQZDFAR([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, FTTHWDAOFXU b, ITZIBLWYZOO c)
		{
			return default((List<OUUOSIRLAVE>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x28EA340", Offset = "0x28E9540", VA = "0x1828EA340")]
		[CompilerGenerated]
		private SELRMVZFOMN RLIXMDVCIIG(NRZUVTJIBNZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x28E57E0", Offset = "0x28E49E0", VA = "0x1828E57E0")]
		[CompilerGenerated]
		private AUAIRMEYYLK ZZTDTJMMVHA(Id128<FAVTMLJIUOX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x28E5810", Offset = "0x28E4A10", VA = "0x1828E5810")]
		[CompilerGenerated]
		private FGITXDOLHEZ ZZYKQQGKESJ(Id128<NZKBDZMUQMJ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x28E57E0", Offset = "0x28E49E0", VA = "0x1828E57E0")]
		[CompilerGenerated]
		private AUAIRMEYYLK CNBOXJHTLFA(Id128<FAVTMLJIUOX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x28E5810", Offset = "0x28E4A10", VA = "0x1828E5810")]
		[CompilerGenerated]
		private FGITXDOLHEZ CNGVUQBQUQJ(Id128<NZKBDZMUQMJ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class SELRMVZFOMN : MIILYKSZUVS
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
			public AsyncTaskMethodBuilder<Result<Id32<XZLTFWVWVWY>, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public SELRMVZFOMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<FAVTMLJIUOX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<WXMOLFBEQDB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<XZLTFWVWVWY>, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x28DE810", Offset = "0x28DDA10", VA = "0x1828DE810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x28DEA60", Offset = "0x28DDC60", VA = "0x1828DEA60", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<FXOBICRSDUR>, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public SELRMVZFOMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<NZKBDZMUQMJ> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<FAVTMLJIUOX> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<WXMOLFBEQDB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<FXOBICRSDUR>, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x28DEAD0", Offset = "0x28DDCD0", VA = "0x1828DEAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x28DED20", Offset = "0x28DDF20", VA = "0x1828DED20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly NRZUVTJIBNZ TXCGTTWUEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly FCZEXSWNMQC ODFDTYQEEMC;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey EAPFUOWZMZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xAC7520", Offset = "0xAC6720", VA = "0x180AC7520", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string NAODPYDTZJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x28DDC30", Offset = "0x28DCE30", VA = "0x1828DDC30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public NRZUVTJIBNZ NRZUVTJIBNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x28DDDD0", Offset = "0x28DCFD0", VA = "0x1828DDDD0")]
		public SELRMVZFOMN(NRZUVTJIBNZ a, FCZEXSWNMQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x28DDC60", Offset = "0x28DCE60", VA = "0x1828DDC60", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<XZLTFWVWVWY>, JDUFGOJEPGU>> YNXLWZQUJDK(Id128<NZKBDZMUQMJ> graphId, Id128<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x28DDAC0", Offset = "0x28DCCC0", VA = "0x1828DDAC0", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<FXOBICRSDUR>, JDUFGOJEPGU>> DNQLOZKMKLL(Id128<NZKBDZMUQMJ> graphId, Id128<FAVTMLJIUOX> nodeId, Id32<WXMOLFBEQDB> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class XNYSBRMNESP : DHPBSHZYRAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly NRZUVTJIBNZ WABJXDDZNEX;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<NRZUVTJIBNZ> KYKJCCGEYAH;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<NRZUVTJIBNZ> HGQLZMLEXHO;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<NRZUVTJIBNZ> KTVPTLWGGJD;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public NRZUVTJIBNZ OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x28EE720", Offset = "0x28ED920", VA = "0x1828EE720", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x28EE710", Offset = "0x28ED910", VA = "0x1828EE710", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x28EE770", Offset = "0x28ED970", VA = "0x1828EE770", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x28EE690", Offset = "0x28ED890", VA = "0x1828EE690", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x28ECBD0", Offset = "0x28EBDD0", VA = "0x1828ECBD0")]
		public bool XLHEPGXBSHG(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		public XNYSBRMNESP(NRZUVTJIBNZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x28ECA40", Offset = "0x28EBC40", VA = "0x1828ECA40")]
		internal static TypeKey LWOPKDZTPXL(NRZUVTJIBNZ a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x28DDC30", Offset = "0x28DCE30", VA = "0x1828DDC30", Slot = "3")]
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
	public readonly struct ActionDeps : EFFEKHEHDBI.CBHBDQDBQEN<USPEKNRWVPE, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x28DAD80", Offset = "0x28D9F80", VA = "0x1828DAD80", Slot = "4")]
		public int ILKHEXDZLDB(None a, USPEKNRWVPE b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x28DAE50", Offset = "0x28DA050", VA = "0x1828DAE50", Slot = "5")]
		public USPEKNRWVPE UQZPDKUQYDY(None a, USPEKNRWVPE b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x28DAD30", Offset = "0x28D9F30", VA = "0x1828DAD30", Slot = "6")]
		public USPEKNRWVPE GMSXWMZZVDH(None a, USPEKNRWVPE b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x28DAD60", Offset = "0x28D9F60", VA = "0x1828DAD60", Slot = "7")]
		public IReadOnlyList<USPEKNRWVPE> ICDVKYPRRRV(None a, USPEKNRWVPE b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x28DADE0", Offset = "0x28D9FE0", VA = "0x1828DADE0", Slot = "8")]
		public USPEKNRWVPE[] MFWPNIGNKPA(None a, USPEKNRWVPE b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x28DADA0", Offset = "0x28D9FA0", VA = "0x1828DADA0", Slot = "9")]
		public bool LMEGERLVKBJ(None a, USPEKNRWVPE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x28DADC0", Offset = "0x28D9FC0", VA = "0x1828DADC0", Slot = "10")]
		public bool LUQBRJZINFN(None a, USPEKNRWVPE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x28DAE30", Offset = "0x28DA030", VA = "0x1828DAE30", Slot = "11")]
		public bool SLUMLXZOIHF(None a, USPEKNRWVPE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x28DAD10", Offset = "0x28D9F10", VA = "0x1828DAD10", Slot = "12")]
		public bool GCVYIGTNIJB(None a, USPEKNRWVPE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x28DADF0", Offset = "0x28D9FF0", VA = "0x1828DADF0", Slot = "13")]
		public bool MWRLJTXDSAB(None a, USPEKNRWVPE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x28DAE10", Offset = "0x28DA010", VA = "0x1828DAE10", Slot = "14")]
		public bool PSBAVATXZTC(None a, USPEKNRWVPE b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class KTGASFDRKZK : QGBMHGUBIHM
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract HXXVFCDUHKY.ELSNTWPCDON ISJJBPAZHRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract RRHCIMKELZN.ELSNTWPCDON HLTAHUAHGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract PTEMFAIRMBY.ELSNTWPCDON HZPVXQROKXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN> ZAOCERFTHHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x28DB400", Offset = "0x28DA600", VA = "0x1828DB400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.ELSNTWPCDON BUISVEIYUDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract BKQRFKBWSPS OOZAYYTADBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract KCBFZEYCEZD OCFPZNPJYLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract PUFXDFRADIJ YYONDGKDFLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract TWDSZOCCEPP WMWORLFYNJK
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract SPZWLQEAMOP BUXKODBFIDA
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		protected KTGASFDRKZK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class DCXBIPUOFGI : QWRZYRRNLME
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
			public AsyncTaskMethodBuilder<Result<MultiResult, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<USPEKNRWVPE> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public DCXBIPUOFGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x28DF340", Offset = "0x28DE540", VA = "0x1828DF340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x28DF760", Offset = "0x28DE960", VA = "0x1828DF760", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public DCXBIPUOFGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public USPEKNRWVPE action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x28E40C0", Offset = "0x28E32C0", VA = "0x1828E40C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x28E4340", Offset = "0x28E3540", VA = "0x1828E4340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly DLOXXYQFPRD BSMPVHEYOGD;

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		public DCXBIPUOFGI(DLOXXYQFPRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x28DAE60", Offset = "0x28DA060", VA = "0x1828DAE60")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, JDUFGOJEPGU>> LKRUMWVBRVX(USPEKNRWVPE a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x28DAF90", Offset = "0x28DA190", VA = "0x1828DAF90", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, JDUFGOJEPGU>> XEABFFMTZEV(IReadOnlyList<USPEKNRWVPE> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, USPEKNRWVPE, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x105B060", Offset = "0x105A260", VA = "0x18105B060")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, USPEKNRWVPE, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x28DD7F0", Offset = "0x28DC9F0", VA = "0x1828DD7F0")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class ADXKJIPGNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xBA0810", Offset = "0xB9FA10", VA = "0x180BA0810")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, USPEKNRWVPE, PartialActionReassemblyDeps> XNICNFCHVJY(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, USPEKNRWVPE, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : TQHJTZSRHIS.IRGRAGFCDUQ<PartialActionPayload, Id128<PartialActionPayload.M>, USPEKNRWVPE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x28DD610", Offset = "0x28DC810", VA = "0x1828DD610", Slot = "7")]
		public USPEKNRWVPE OXTDHACEYCG(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x104CA50", Offset = "0x104BC50", VA = "0x18104CA50")]
		public Id128<PartialActionPayload.M> MMRSNRWBTCM([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0xDCFC30", Offset = "0xDCEE30", VA = "0x180DCFC30")]
		public int VKBCNZFDNUU([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x28DD600", Offset = "0x28DC800", VA = "0x1828DD600")]
		public int NMIORWILCQX([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xDCFC30", Offset = "0xDCEE30", VA = "0x180DCFC30", Slot = "4")]
		private int SWCUVSNABCQ([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x28DD600", Offset = "0x28DC800", VA = "0x1828DD600", Slot = "5")]
		private int BANEWVTAHUD([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x104CA50", Offset = "0x104BC50", VA = "0x18104CA50", Slot = "6")]
		private Id128<PartialActionPayload.M> YPXQJSEIINC([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, USPEKNRWVPE, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x105B060", Offset = "0x105A260", VA = "0x18105B060")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, USPEKNRWVPE, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x28DE7B0", Offset = "0x28DD9B0", VA = "0x1828DE7B0")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class JIFEYPCSVGQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xBA0810", Offset = "0xB9FA10", VA = "0x180BA0810")]
		public static SnapshotReassembly<PartialInitializePayload, USPEKNRWVPE, SnapshotReassemblyDeps> XNICNFCHVJY(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, USPEKNRWVPE, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : JJNQSCZSWJX.IRLXXMYZNFZ<PartialInitializePayload, USPEKNRWVPE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xDCFBD0", Offset = "0xDCEDD0", VA = "0x180DCFBD0")]
		public int ZUMIPFLHYSS([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x28DE5D0", Offset = "0x28DD7D0", VA = "0x1828DE5D0", Slot = "5")]
		public USPEKNRWVPE DNRFPKUKCMI(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xDCFBD0", Offset = "0xDCEDD0", VA = "0x180DCFBD0", Slot = "4")]
		private int HMOULXRFMYO([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class RYITDXKUKJS : VTISYMIGLDB, SXSCEXBQPFJ, JDUFGOJEPGU, WMUYMRHRYMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly WMUYMRHRYMC? RZZDGPEJTFY;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind EQBNTADKZHU
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xABB640", Offset = "0xABA840", VA = "0x180ABB640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override WMUYMRHRYMC? GFGLTQPZUZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x28DD850", Offset = "0x28DCA50", VA = "0x1828DD850", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x28DDA80", Offset = "0x28DCC80", VA = "0x1828DDA80")]
		private RYITDXKUKJS(PrepareTemplateForCloneErrKind a, WMUYMRHRYMC? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x28DD950", Offset = "0x28DCB50", VA = "0x1828DD950")]
		public static RYITDXKUKJS GJDMQLNPUPK(WMUYMRHRYMC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x28DDA20", Offset = "0x28DCC20", VA = "0x1828DDA20")]
		public static RYITDXKUKJS QIBSZQYLJEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x28DD9C0", Offset = "0x28DCBC0", VA = "0x1828DD9C0")]
		public static RYITDXKUKJS MDGGJSEGLKU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class FDCXOZHDFWH
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x3702420", Offset = "0x3701620", VA = "0x183702420")]
		public static Result<TOk, SXSCEXBQPFJ> GCEYNONSMJT<TOk>([In] this Result<TOk, SXSCEXBQPFJ> self, WMUYMRHRYMC a) where TOk : notnull
		{
			return default(Result<TOk, SXSCEXBQPFJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x3702660", Offset = "0x3701860", VA = "0x183702660")]
		public static Result<a?, SXSCEXBQPFJ?> JWHSNFMPBAB<a>([In] this Result<a, SXSCEXBQPFJ> self)
		{
			return default(Result<a, SXSCEXBQPFJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x37027B0", Offset = "0x37019B0", VA = "0x1837027B0")]
		public static Result<b?, SXSCEXBQPFJ?> TPSQBNXISUX<b>([In] this Result<b, SXSCEXBQPFJ> self)
		{
			return default(Result<b, SXSCEXBQPFJ>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface BKQRFKBWSPS
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PJBGBUBJGRW([In] Result<None, WMUYMRHRYMC> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class MMZFCCJEGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x384A6A0", Offset = "0x38498A0", VA = "0x18384A6A0")]
		public static bool PJBGBUBJGRW<TOk, TErr>(this BKQRFKBWSPS a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, WMUYMRHRYMC
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface KCBFZEYCEZD
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		MMFRHKTHWJJ WALCZQZNUCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface PUFXDFRADIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor VJABFFGJREE(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface GYILCNHAVCI
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface XHIYDWWLCZB
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UNHUBNANYLJ? APJVSEKBIVO(Id32<WXMOLFBEQDB> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface YFKUGYFKORD
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface UNHUBNANYLJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		YFKUGYFKORD? ESKTTCPONPM(Id32<XZLTFWVWVWY> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GYILCNHAVCI? BHSVWEVMYKZ(Id32<FXOBICRSDUR> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface TWDSZOCCEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> WMLPFRLMGEV(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface SPZWLQEAMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		XHIYDWWLCZB? EODDZQCAGTI([In] Id128<ZTTYPUHCXEP> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class SFVFLYJHYCW
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
			public readonly List<USPEKNRWVPE> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x28DB170", Offset = "0x28DA370", VA = "0x1828DB170")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<USPEKNRWVPE> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x28DB0C0", Offset = "0x28DA2C0", VA = "0x1828DB0C0")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly NBLYOTUHNMP<Diagnostic> TZMOKXWKXUM;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static SFVFLYJHYCW DZRVHNEPLID
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x28DDE70", Offset = "0x28DD070", VA = "0x1828DDE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool YKKMTTNABVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xB0C710", Offset = "0xB0B910", VA = "0x180B0C710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xBBFE90", Offset = "0xBBF090", VA = "0x180BBFE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x28DDEC0", Offset = "0x28DD0C0", VA = "0x1828DDEC0")]
		public void OIJCYISNYHD(FCZEXSWNMQC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x28DE140", Offset = "0x28DD340", VA = "0x1828DE140")]
		public void ZINXTZBXTDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x28DDF80", Offset = "0x28DD180", VA = "0x1828DDF80")]
		private static string? SLAFQJYHTAO([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x28DE510", Offset = "0x28DD710", VA = "0x1828DE510")]
		public SFVFLYJHYCW()
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
