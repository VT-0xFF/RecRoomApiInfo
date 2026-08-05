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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B1E330", Offset = "0x2B1D730", VA = "0x182B1E330")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B1D360", Offset = "0x2B1C760", VA = "0x182B1D360", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class SCQFSPRNDPD : IDisposable, TEKEPTBGHHI, OYOXPZSOZHZ, KYBEABDMLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class TLGMPNEBIBW : TVWXLXTXIIP
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public abstract int DGAUNDCEHSU
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2B243A0", Offset = "0x2B237A0", VA = "0x182B243A0", Slot = "5")]
			public YVXKSJHRTOX SSCCOFUGOTW(PWJKHDEOEOW.TVWXLXTXIIP a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void NFQLUSXTKNG();

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void PXDUYRFEYBF();

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2B070E0", Offset = "0x2B064E0", VA = "0x182B070E0", Slot = "13")]
			public virtual void EUSIJIPEQSN(SCQFSPRNDPD a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2B24630", Offset = "0x2B23A30", VA = "0x182B24630", Slot = "14")]
			public virtual void ZCTAUDWYFVQ(SCQFSPRNDPD a, PXBFMCKNGBK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			protected TLGMPNEBIBW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface TVWXLXTXIIP
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			int DGAUNDCEHSU
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			YVXKSJHRTOX SSCCOFUGOTW(PWJKHDEOEOW.TVWXLXTXIIP a);

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void NFQLUSXTKNG();

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void PXDUYRFEYBF();

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void EUSIJIPEQSN(SCQFSPRNDPD a);

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void ZCTAUDWYFVQ(SCQFSPRNDPD a, PXBFMCKNGBK b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD, VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x12C9430", Offset = "0x12C8830", VA = "0x1812C9430")]
			internal Reducer(Reducer<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD, VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class ERJGCPEQSUM : VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly ERJGCPEQSUM LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private ERJGCPEQSUM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x153C820", Offset = "0x153BC20", VA = "0x18153C820", Slot = "4")]
			public ActionKind TIKQYRMXNKI(PXBFMCKNGBK a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2B18710", Offset = "0x2B17B10", VA = "0x182B18710", Slot = "5")]
			public void EUSIJIPEQSN(SCQFSPRNDPD a, PXBFMCKNGBK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2B18820", Offset = "0x2B17C20", VA = "0x182B18820", Slot = "6")]
			public void ZCTAUDWYFVQ(SCQFSPRNDPD a, PXBFMCKNGBK b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD, VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2B22620", Offset = "0x2B21A20", VA = "0x182B22620")]
			internal ReducerFactory(ReducerFactory<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD, VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2B225D0", Offset = "0x2B219D0", VA = "0x182B225D0")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : UXOUZHAFSJC.EIUEKENQCJW<PXBFMCKNGBK, SCQFSPRNDPD>
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
				public AsyncTaskMethodBuilder<Result<object?, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public SCQFSPRNDPD receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public PXBFMCKNGBK action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2B25100", Offset = "0x2B24500", VA = "0x182B25100", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2B252E0", Offset = "0x2B246E0", VA = "0x182B252E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD59840", Offset = "0xD58C40", VA = "0x180D59840", Slot = "4")]
			public Id32<BVHHKRGRDMC> XZVQGNNGUHF(SCQFSPRNDPD a)
			{
				return default(Id32<BVHHKRGRDMC>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2B24340", Offset = "0x2B23740", VA = "0x182B24340", Slot = "5")]
			public void HXBQZUPHUYU(SCQFSPRNDPD a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2B24210", Offset = "0x2B23610", VA = "0x182B24210", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, SKKNIPYCQUO>> DHXGMDSKOIZ(SCQFSPRNDPD a, PXBFMCKNGBK b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2B241F0", Offset = "0x2B235F0", VA = "0x182B241F0", Slot = "7")]
			public PXBFMCKNGBK[] CZEVWGOVSCB(SCQFSPRNDPD a)
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
			public AsyncTaskMethodBuilder<Result<object?, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public SCQFSPRNDPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public PXBFMCKNGBK action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<Result<object?, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2B25350", Offset = "0x2B24750", VA = "0x182B25350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2B25540", Offset = "0x2B24940", VA = "0x182B25540", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public SCQFSPRNDPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<Result<bool, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2B26A80", Offset = "0x2B25E80", VA = "0x182B26A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2B26D00", Offset = "0x2B26100", VA = "0x182B26D00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public SCQFSPRNDPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2B26D70", Offset = "0x2B26170", VA = "0x182B26D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2B26F50", Offset = "0x2B26350", VA = "0x182B26F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<BVHHKRGRDMC> QRVUEYEZETX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer CHVVDQPDKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RegistryV2 IUAMCDGHQDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly ZVMBXFNFHDW MNTIFGRIHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly KDLKXLCXLMQ.CreationArgs FQZHFUDLTZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly RULSKBRZQUV DALXRTKIKCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F08")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly IZAYKUKXVZO MUTWGKOLLXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly LUGKKKAXEJR VKCVIRLMSTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly EKOLSYIPVJG HIIMKJVZPZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly HZSRCXEYKHG ZMHBIRSGVNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly CHZXRYGKZXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly VTUXAFVKZOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest CPWDOZEPEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended VOFGWDBSKLR;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal TVWXLXTXIIP EMZZPPWUFTU
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2B23350", Offset = "0x2B22750", VA = "0x182B23350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal YVXKSJHRTOX SXQXONPSEXE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2B22C00", Offset = "0x2B22000", VA = "0x182B22C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2B231F0", Offset = "0x2B225F0", VA = "0x182B231F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool QFETFMDYOWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2B23850", Offset = "0x2B22C50", VA = "0x182B23850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B233A0", Offset = "0x2B227A0", VA = "0x182B233A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ITZTXVOXFQA RULSKBRZQUV
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B241B0", Offset = "0x2B235B0", VA = "0x182B241B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public WXLIWCAZLHS LUGKKKAXEJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2B241C0", Offset = "0x2B235C0", VA = "0x182B241C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HUUIBWGGLCL HZSRCXEYKHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2B241E0", Offset = "0x2B235E0", VA = "0x182B241E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NTAHRWUKVWD IZAYKUKXVZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B238E0", Offset = "0x2B22CE0", VA = "0x182B238E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IEGBCYAADQN EKOLSYIPVJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2B241D0", Offset = "0x2B235D0", VA = "0x182B241D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KDLKXLCXLMQ? KDLKXLCXLMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2B23210", Offset = "0x2B22610", VA = "0x182B23210", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B23EC0", Offset = "0x2B232C0", VA = "0x182B23EC0")]
		private SCQFSPRNDPD(ZVMBXFNFHDW a, Id32<BVHHKRGRDMC> actorId, [In] Reducer reducer, [In] RegistryV2 registryV2, YVXKSJHRTOX b, [In] KDLKXLCXLMQ.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B234C0", Offset = "0x2B228C0", VA = "0x182B234C0")]
		public static SCQFSPRNDPD New(ZVMBXFNFHDW deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<BVHHKRGRDMC> actorId, Id32<QXDOXFETTHL> rootNetworkObjectId, OKXJRNOVLSL staticNetSys, VYUTWWCJPWH dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B23590", Offset = "0x2B22990", VA = "0x182B23590")]
		public static SCQFSPRNDPD New(ZVMBXFNFHDW dependencies, [In] RegistryV2 registryV2, Id32<BVHHKRGRDMC> actorId, Id32<QXDOXFETTHL> rootNetworkObjectId, OKXJRNOVLSL staticNetSys, VYUTWWCJPWH dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B23010", Offset = "0x2B22410", VA = "0x182B23010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B23DD0", Offset = "0x2B231D0", VA = "0x182B23DD0")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__29))]
		public Task<Result<bool, SKKNIPYCQUO>> XTEXLIGYPYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B23AE0", Offset = "0x2B22EE0", VA = "0x182B23AE0")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__30))]
		public Task<Result<None, SKKNIPYCQUO>> UOSTOPSSLCS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B23BD0", Offset = "0x2B22FD0", VA = "0x182B23BD0")]
		internal void UUDJBUWJSIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B23860", Offset = "0x2B22C60", VA = "0x182B23860")]
		internal Option<PXBFMCKNGBK> OUAXKUNVCRS([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<PXBFMCKNGBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B238F0", Offset = "0x2B22CF0", VA = "0x182B238F0")]
		internal bool SPAXVSFQTYD([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B23960", Offset = "0x2B22D60", VA = "0x182B23960")]
		internal Result<PXBFMCKNGBK, SKKNIPYCQUO> STLPJNVOBVK([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<PXBFMCKNGBK, SKKNIPYCQUO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B23300", Offset = "0x2B22700", VA = "0x182B23300")]
		private void HXBQZUPHUYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B233B0", Offset = "0x2B227B0", VA = "0x182B233B0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__36))]
		internal Task<Result<object, SKKNIPYCQUO>> MORHPQKXIVW(PXBFMCKNGBK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B22C10", Offset = "0x2B22010", VA = "0x182B22C10")]
		private PXBFMCKNGBK[] CZEVWGOVSCB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class XKNUTICDASV<a> : OKJLNQTBITD, XFUVNDQGBBL, FWOTOTOBXEY where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Id128<IHXSJTKSKEJ>? OZSHBXECGNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly string XEBPMPWPFVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly a YVVJIHKGLFY;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Id128<IHXSJTKSKEJ>? ADPVPPFOIUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2E02310", Offset = "0x2E01710", VA = "0x182E02310", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5022BA0", Offset = "0x5021FA0", VA = "0x185022BA0")]
		internal XKNUTICDASV([In] Id128<IHXSJTKSKEJ>? lastNode, Id32<OJXYPHPZREW>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class UVLTEDCGLJH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A820", Offset = "0x2B29C20", VA = "0x182B2A820")]
		public static Result<DebugExecutionResult, XFUVNDQGBBL> WPKKNSVXNKO([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, XFUVNDQGBBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4088790", Offset = "0x4087B90", VA = "0x184088790")]
		public static Result<TOk, XFUVNDQGBBL> ARASZNFTBDU<TOk>([In] this Result<TOk, XFUVNDQGBBL> self, [In] Id128<IHXSJTKSKEJ>? lastNode, Id32<OJXYPHPZREW>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, XFUVNDQGBBL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ZVMBXFNFHDW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		PWJKHDEOEOW.TVWXLXTXIIP WXXFCGPXNMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		SCQFSPRNDPD.TVWXLXTXIIP JFDRWMKNJMD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		MRKIPKACQWY.TVWXLXTXIIP IOMTYGDYRLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD> ERJGCPEQSUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		CV2Request.TVWXLXTXIIP VDVGISORCJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IKBVPHFPXCS FLFQZBOOYEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		WFYONVKPUQH UZRIBIRYRIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		VRZNIJEJJRF UMJDUIZGJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		PBRLRHMSVSH FOLHVPVJCVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		EXVISPQHAEV TDIXQUWTTXC
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
	public static class GNZBDHNLTAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BA40", Offset = "0x2B1AE40", VA = "0x182B1BA40")]
		public static PXBFMCKNGBK LVWFXWBNGKK(this PXBFMCKNGBK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B970", Offset = "0x2B1AD70", VA = "0x182B1B970")]
		public static PXBFMCKNGBK DEOVKLRIVOJ(this CompressedPayload a)
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
			public AsyncTaskMethodBuilder<Result<object?, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public SCQFSPRNDPD root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter<Result<object?, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B255B0", Offset = "0x2B249B0", VA = "0x182B255B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B25CE0", Offset = "0x2B250E0", VA = "0x182B25CE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B18130", Offset = "0x2B17530", VA = "0x182B18130")]
		public static PXBFMCKNGBK KJQXTTNSTJE(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B18080", Offset = "0x2B17480", VA = "0x182B18080")]
		public static ReduceAction<ActionKind, CompressedPayload> EIUGXXQEULB(PXBFMCKNGBK actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B181F0", Offset = "0x2B175F0", VA = "0x182B181F0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, SKKNIPYCQUO>> MORHPQKXIVW(SCQFSPRNDPD a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B185F0", Offset = "0x2B179F0", VA = "0x182B185F0")]
		public static PXBFMCKNGBK KJQXTTNSTJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B18580", Offset = "0x2B17980", VA = "0x182B18580")]
		public static ReduceAction<ActionKind, DestroyPayload> EIUGXXQEULB(PXBFMCKNGBK actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B18690", Offset = "0x2B17A90", VA = "0x182B18690")]
		public static Result<None, ASXPOOCHMFZ> XXACUWNPPVG(SCQFSPRNDPD a, [In] DestroyPayload self)
		{
			return default(Result<None, ASXPOOCHMFZ>);
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
			public AsyncTaskMethodBuilder<Result<None, ASXPOOCHMFZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public SCQFSPRNDPD root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Result<None, ASXPOOCHMFZ> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B25DC0", Offset = "0x2B251C0", VA = "0x182B25DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B26360", Offset = "0x2B25760", VA = "0x182B26360", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F2B580", Offset = "0x1F2A980", VA = "0x181F2B580")]
		private FullInitializePayload(CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B730", Offset = "0x2B1AB30", VA = "0x182B1B730")]
		public static PXBFMCKNGBK? KJQXTTNSTJE(CircuitRootData? a, SuperRoomData? b, CircuitStudioUnitySubAssetUsageData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B620", Offset = "0x2B1AA20", VA = "0x182B1B620")]
		public static ReduceAction<ActionKind, FullInitializePayload> EIUGXXQEULB(PXBFMCKNGBK actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B830", Offset = "0x2B1AC30", VA = "0x182B1B830")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__6))]
		public static Task<Result<None, ASXPOOCHMFZ>> MORHPQKXIVW(SCQFSPRNDPD a, FullInitializePayload b)
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
			public AsyncTaskMethodBuilder<Result<MultiResult, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public SCQFSPRNDPD root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Result<MultiResult, SKKNIPYCQUO> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private Result<object?, FWOTOTOBXEY>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private Result<object?, FWOTOTOBXEY> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<object?, FWOTOTOBXEY>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<Result<object?, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B25870", Offset = "0x2B24C70", VA = "0x182B25870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B25D50", Offset = "0x2B25150", VA = "0x182B25D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyList<PXBFMCKNGBK> Actions;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		private MultiPayload(IReadOnlyList<PXBFMCKNGBK> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DBF0", Offset = "0x2B1CFF0", VA = "0x182B1DBF0")]
		public static PXBFMCKNGBK KJQXTTNSTJE(IReadOnlyList<PXBFMCKNGBK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DB50", Offset = "0x2B1CF50", VA = "0x182B1DB50")]
		public static ReduceAction<ActionKind, MultiPayload> EIUGXXQEULB(PXBFMCKNGBK actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DCB0", Offset = "0x2B1D0B0", VA = "0x182B1DCB0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, SKKNIPYCQUO>> MORHPQKXIVW(SCQFSPRNDPD a, MultiPayload b)
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
		private sealed class RBAAAFPDLJX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Id128<M> JOYNRVOGJGB;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public RBAAAFPDLJX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B217F0", Offset = "0x2B20BF0", VA = "0x182B217F0")]
			internal PXBFMCKNGBK SDNWMOLBTQZ(int a, int b, [In] ReadOnlySpan<byte> span)
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
		[Cpp2IlInjected.Address(RVA = "0x2B20A10", Offset = "0x2B1FE10", VA = "0x182B20A10")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B20670", Offset = "0x2B1FA70", VA = "0x182B20670")]
		public static PXBFMCKNGBK KJQXTTNSTJE(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B20780", Offset = "0x2B1FB80", VA = "0x182B20780")]
		public static PXBFMCKNGBK[] TVVRHCSOHWN(PXBFMCKNGBK a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B20520", Offset = "0x2B1F920", VA = "0x182B20520")]
		public static ReduceAction<ActionKind, PartialActionPayload> EIUGXXQEULB(PXBFMCKNGBK actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B20880", Offset = "0x2B1FC80", VA = "0x182B20880")]
		public static Result<PXBFMCKNGBK, SKKNIPYCQUO> XXACUWNPPVG(SCQFSPRNDPD a, [In] PartialActionPayload self)
		{
			return default(Result<PXBFMCKNGBK, SKKNIPYCQUO>);
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
			public AsyncTaskMethodBuilder<Result<bool, ASXPOOCHMFZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public SCQFSPRNDPD root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private Result<bool, ASXPOOCHMFZ> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<None, ASXPOOCHMFZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2B263D0", Offset = "0x2B257D0", VA = "0x182B263D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B26A10", Offset = "0x2B25E10", VA = "0x182B26A10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xD9F660", Offset = "0xD9EA60", VA = "0x180D9F660")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B20B10", Offset = "0x2B1FF10", VA = "0x182B20B10")]
		public static PXBFMCKNGBK KJQXTTNSTJE(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B20D20", Offset = "0x2B20120", VA = "0x182B20D20")]
		public static PXBFMCKNGBK?[]? XIPACIULSKJ(int a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B20A30", Offset = "0x2B1FE30", VA = "0x182B20A30")]
		public static ReduceAction<ActionKind, PartialInitializePayload> EIUGXXQEULB(PXBFMCKNGBK actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B20BF0", Offset = "0x2B1FFF0", VA = "0x182B20BF0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, ASXPOOCHMFZ>> MORHPQKXIVW(SCQFSPRNDPD a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class RULSKBRZQUV : ITZTXVOXFQA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly SCQFSPRNDPD AIEUPWPRETM;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public UGSJSTYZPJJ? LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B224C0", Offset = "0x2B218C0", VA = "0x182B224C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		internal RULSKBRZQUV(SCQFSPRNDPD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class RRXEAUEVTFM : UGSJSTYZPJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly SCQFSPRNDPD AIEUPWPRETM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly KDLKXLCXLMQ MWLZAPZGSAE;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xCFB220", Offset = "0xCFA620", VA = "0x180CFB220")]
		public RRXEAUEVTFM(SCQFSPRNDPD a, KDLKXLCXLMQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B21F10", Offset = "0x2B21310", VA = "0x182B21F10", Slot = "4")]
		public Result<DebugExecutionResult, XFUVNDQGBBL> TAKYCTYWJYQ(Id128<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId, Id32<KYLBZYJNRQF> inputId)
		{
			return default(Result<DebugExecutionResult, XFUVNDQGBBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B21960", Offset = "0x2B20D60", VA = "0x182B21960", Slot = "5")]
		public Result<DebugExecutionResult, XFUVNDQGBBL> ISMMLGNHHDV(Id128<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId, Id32<DMDCMEAEHJK> outputId)
		{
			return default(Result<DebugExecutionResult, XFUVNDQGBBL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class PWJKHDEOEOW : YVXKSJHRTOX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public interface TVWXLXTXIIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<FXFXXQDTBDJ> VKFPPDLQNNM(SCQFSPRNDPD a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void XCWICRNSSVE(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public abstract class TLGMPNEBIBW : TVWXLXTXIIP
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
				public AsyncTaskMethodBuilder<FXFXXQDTBDJ> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public SCQFSPRNDPD circuitsManager;

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
				private TaskAwaiter<MRKIPKACQWY> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2B246B0", Offset = "0x2B23AB0", VA = "0x182B246B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2B24880", Offset = "0x2B23C80", VA = "0x182B24880", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B244D0", Offset = "0x2B238D0", VA = "0x182B244D0", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeInstance>d__0))]
			public Task<FXFXXQDTBDJ> VKFPPDLQNNM(SCQFSPRNDPD a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void XCWICRNSSVE(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			protected TLGMPNEBIBW()
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
			public AsyncTaskMethodBuilder<FXFXXQDTBDJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PWJKHDEOEOW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B248F0", Offset = "0x2B23CF0", VA = "0x182B248F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B24AF0", Offset = "0x2B23EF0", VA = "0x182B24AF0", Slot = "5")]
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
			public PWJKHDEOEOW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public SCQFSPRNDPD circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<FXFXXQDTBDJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2B24B60", Offset = "0x2B23F60", VA = "0x182B24B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B250A0", Offset = "0x2B244A0", VA = "0x182B250A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly TVWXLXTXIIP RATSQORCBWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<None> IHLCKSBVBIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TaskCompletionSource<None> VHPZGCASTFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CancellationTokenSource SGXOSZPWCER;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool QFETFMDYOWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD4DA50", Offset = "0xD4CE50", VA = "0x180D4DA50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD4E320", Offset = "0xD4D720", VA = "0x180D4E320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF685D0", Offset = "0xF679D0", VA = "0x180F685D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xF9FB80", Offset = "0xF9EF80", VA = "0x180F9FB80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool IJAJVOCURTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1ADC160", Offset = "0x1ADB560", VA = "0x181ADC160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1B179D0", Offset = "0x1B16DD0", VA = "0x181B179D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public FXFXXQDTBDJ? LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E50", Offset = "0xCF4250", VA = "0x180CF4E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B201F0", Offset = "0x2B1F5F0", VA = "0x182B201F0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__20))]
		public Task<FXFXXQDTBDJ> MAXPAVPQBZJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B20420", Offset = "0x2B1F820", VA = "0x182B20420")]
		public PWJKHDEOEOW(TVWXLXTXIIP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B202E0", Offset = "0x2B1F6E0", VA = "0x182B202E0", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task PSTDLVTOSEQ(SCQFSPRNDPD a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B20080", Offset = "0x2B1F480", VA = "0x182B20080", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class YVVACKWQKAL : AKPNKSKFTWC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly GTAENSCVUIX MXTKCGRVRIC;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public YVVACKWQKAL(GTAENSCVUIX a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class BTBFNOGJWGM
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private class CSTTTMBBAYK<a> : HZDTNYOITFT where a : ZBZCNYAIBZN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			protected readonly a MWJPQTXEXMV;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public virtual ObjectBoardProps? JPBIEXPIFHF
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xF102C0", Offset = "0xF0F6C0", VA = "0x180F102C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public virtual Id128<IHXSJTKSKEJ>? XRPORPJOEEX
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x4FB5800", Offset = "0x4FB4C00", VA = "0x184FB5800", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public Id32<EVDWFGHNUCH> LPAAGVPHFAH
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2E12760", Offset = "0x2E11B60", VA = "0x182E12760", Slot = "5")]
				get
				{
					return default(Id32<EVDWFGHNUCH>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public Id32<EVDWFGHNUCH>? MAUEADTXKFR
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x4FB58B0", Offset = "0x4FB4CB0", VA = "0x184FB58B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
			public CSTTTMBBAYK(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class QZKZUPMFSQI : CSTTTMBBAYK<VSGPPCCXANY>
		{
			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public override ObjectBoardProps? JPBIEXPIFHF
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x1054C90", Offset = "0x1054090", VA = "0x181054C90", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B21720", Offset = "0x2B20B20", VA = "0x182B21720")]
			public QZKZUPMFSQI(VSGPPCCXANY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B17E10", Offset = "0x2B17210", VA = "0x182B17E10")]
		public static HZDTNYOITFT New(ZBZCNYAIBZN graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class UZOCHGIXCHS : PHFIUZZADEH, FTGNFXPNPTP, IKOBMFTUZAY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class BYWQKULFMNA
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
				public BYWQKULFMNA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public IKBVPHFPXCS errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B28160", Offset = "0x2B27560", VA = "0x182B28160", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x2B283D0", Offset = "0x2B277D0", VA = "0x182B283D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public UZOCHGIXCHS IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool PBBCXWXIUEP;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public BYWQKULFMNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B17F90", Offset = "0x2B17390", VA = "0x182B17F90")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task LGZYUSTJUHY(IKBVPHFPXCS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class LHVRERDXZSG
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
				public LHVRERDXZSG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x2B28430", Offset = "0x2B27830", VA = "0x182B28430", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x2B28710", Offset = "0x2B27B10", VA = "0x182B28710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public UZOCHGIXCHS IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int PBBCXWXIUEP;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public LHVRERDXZSG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D230", Offset = "0x2B1C630", VA = "0x182B1D230")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task IUDLKKFOJPO(IKBVPHFPXCS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class HZDYEWMUZJZ
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
				public HZDYEWMUZJZ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x2B28C80", Offset = "0x2B28080", VA = "0x182B28C80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B29130", Offset = "0x2B28530", VA = "0x182B29130", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string PBBCXWXIUEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public UZOCHGIXCHS IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int IVJLETCJSOB;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public HZDYEWMUZJZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BDF0", Offset = "0x2B1B1F0", VA = "0x182B1BDF0")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task LMDWMUIFFJQ(IKBVPHFPXCS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class UUOFEODMFYI
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
				public UUOFEODMFYI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x2B28770", Offset = "0x2B27B70", VA = "0x182B28770", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x2B28C20", Offset = "0x2B28020", VA = "0x182B28C20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string PBBCXWXIUEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public UZOCHGIXCHS IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int IVJLETCJSOB;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public UUOFEODMFYI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A750", Offset = "0x2B29B50", VA = "0x182B2A750")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task JQQAPANQEYG(IKBVPHFPXCS a)
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
			public UZOCHGIXCHS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2B26FC0", Offset = "0x2B263C0", VA = "0x182B26FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2B274D0", Offset = "0x2B268D0", VA = "0x182B274D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly XCCDJLHIEYV MTZIJJOPRIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ICollection<TWXQCUFLDUJ> IOOEXEVRMTU;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private ZVMBXFNFHDW TLGMPNEBIBW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BD80", Offset = "0x2B2B180", VA = "0x182B2BD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Id32<KYLBZYJNRQF> NWCJDOUDAFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE35710", Offset = "0xE34B10", VA = "0x180E35710", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<KYLBZYJNRQF>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xF060F0", Offset = "0xF054F0", VA = "0x180F060F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Id32<CPMNZXWNEQO> TNVMTNZXOJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5000", Offset = "0x2AB4400", VA = "0x182AB5000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Id32<NTSCAYGKXQL> LNVBUMPHWNX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1286E90", Offset = "0x1286290", VA = "0x181286E90", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<NTSCAYGKXQL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override Id32<OJXYPHPZREW> SREGWDSDSHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B2C720", Offset = "0x2B2BB20", VA = "0x182B2C720", Slot = "22")]
			get
			{
				return default(Id32<OJXYPHPZREW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool KMYTPEKAGWR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B2E5D0", Offset = "0x2B2D9D0", VA = "0x182B2E5D0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EB40", Offset = "0x2B2DF40", VA = "0x182B2EB40")]
		private UZOCHGIXCHS(SCQFSPRNDPD a, SIDFNDXEBQO b, XCCDJLHIEYV c, Id32<IWTLBCZPUHH> portGroupId, Id32<KYLBZYJNRQF> inputId, Id32<CPMNZXWNEQO> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C990", Offset = "0x2B2BD90", VA = "0x182B2C990")]
		public static UZOCHGIXCHS New(SCQFSPRNDPD circuitsManager, SIDFNDXEBQO node, XCCDJLHIEYV input, Id32<IWTLBCZPUHH> portGroupId, Id32<CPMNZXWNEQO> inputDefId, Id32<KYLBZYJNRQF> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C0A0", Offset = "0x2B2B4A0", VA = "0x182B2C0A0", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B320", Offset = "0x2B2A720", VA = "0x182B2B320", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C140", Offset = "0x2B2B540", VA = "0x182B2C140", Slot = "32")]
		public void KSSAGWAZIMP(TWXQCUFLDUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C360", Offset = "0x2B2B760", VA = "0x182B2C360", Slot = "29")]
		public void MCGSDJJASWQ(ZLYRRFIXKQH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CEB0", Offset = "0x2B2C2B0", VA = "0x182B2CEB0", Slot = "30")]
		public void RBZNTTTHLZB(NFVJGITBHOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E650", Offset = "0x2B2DA50", VA = "0x182B2E650", Slot = "25")]
		protected override void VIRZBNMQVPZ(GQJOFAEKSPO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BC10", Offset = "0x2B2B010", VA = "0x182B2BC10", Slot = "34")]
		public string GFRBDCUMGZS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B950", Offset = "0x2B2AD50", VA = "0x182B2B950", Slot = "31")]
		public string FRMKVLELXHW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AF50", Offset = "0x2B2A350", VA = "0x182B2AF50")]
		private void DMBTEAOIFNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B2ACC0", Offset = "0x2B2A0C0", VA = "0x182B2ACC0", Slot = "33")]
		public void ADTCXGPYETA(TWXQCUFLDUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BDA0", Offset = "0x2B2B1A0", VA = "0x182B2BDA0")]
		private void ISGOUFXKYGX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B3C0", Offset = "0x2B2A7C0", VA = "0x182B2B3C0", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task EAJZZGPDDMX(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C840", Offset = "0x2B2BC40", VA = "0x182B2C840")]
		public void NWGCOKWZTHI(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B180", Offset = "0x2B2A580", VA = "0x182B2B180")]
		private void DTHYCLYDEPO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C1A0", Offset = "0x2B2B5A0", VA = "0x182B2C1A0")]
		private void LFPIWQGQMJQ(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AD90", Offset = "0x2B2A190", VA = "0x182B2AD90")]
		private void CAQDPWFMGTP(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BF60", Offset = "0x2B2B360", VA = "0x182B2BF60")]
		private string IXTIVQYVALQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CD40", Offset = "0x2B2C140", VA = "0x182B2CD40")]
		private string OSOZFFITJXB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xF060F0", Offset = "0xF054F0", VA = "0x180F060F0")]
		internal void GTQLPPLSGLK(Id32<KYLBZYJNRQF> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DFD0", Offset = "0x2B2D3D0", VA = "0x182B2DFD0")]
		[CompilerGenerated]
		private void ROUWJOJVBRV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DF10", Offset = "0x2B2D310", VA = "0x182B2DF10")]
		[CompilerGenerated]
		private bool ROPPMHPXSGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DFE0", Offset = "0x2B2D3E0", VA = "0x182B2DFE0")]
		[CompilerGenerated]
		private bool RPADGVDSLDE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B620", Offset = "0x2B2AA20", VA = "0x182B2B620")]
		[CompilerGenerated]
		private int RPPXYPLKNLF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E0A0", Offset = "0x2B2D4A0", VA = "0x182B2E0A0")]
		[CompilerGenerated]
		private bool RPKRBIRNDZW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E1F0", Offset = "0x2B2D5F0", VA = "0x182B2E1F0")]
		[CompilerGenerated]
		private void RQALTCZFGHX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E130", Offset = "0x2B2D530", VA = "0x182B2E130")]
		[CompilerGenerated]
		private bool RPVEVWFHWWO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DEC0", Offset = "0x2B2D2C0", VA = "0x182B2DEC0")]
		[CompilerGenerated]
		private bool RNETFMGQEFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DE30", Offset = "0x2B2D230", VA = "0x182B2DE30")]
		[CompilerGenerated]
		private bool RMZMIFMSUTS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B620", Offset = "0x2B2AA20", VA = "0x182B2B620")]
		[CompilerGenerated]
		private int ERDOHVULPAE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B670", Offset = "0x2B2AA70", VA = "0x182B2B670")]
		[CompilerGenerated]
		private bool ERIVFCOIYLN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B740", Offset = "0x2B2AB40", VA = "0x182B2B740")]
		[CompilerGenerated]
		private object EROCCJIGHWW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B7A0", Offset = "0x2B2ABA0", VA = "0x182B2B7A0")]
		[CompilerGenerated]
		private void ERTIZQCDRIF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B7F0", Offset = "0x2B2ABF0", VA = "0x182B2B7F0")]
		[CompilerGenerated]
		private bool ESDWUDPYKEX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B8C0", Offset = "0x2B2ACC0", VA = "0x182B2B8C0")]
		[CompilerGenerated]
		private string ESJDRKJVTQG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B940", Offset = "0x2B2AD40", VA = "0x182B2B940")]
		[CompilerGenerated]
		private void ESOKORDTDBP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B4D0", Offset = "0x2B2A8D0", VA = "0x182B2B4D0")]
		[CompilerGenerated]
		private bool EPNLDTRGRNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B5A0", Offset = "0x2B2A9A0", VA = "0x182B2B5A0")]
		[CompilerGenerated]
		private string EPSSBALEAYT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E800", Offset = "0x2B2DC00", VA = "0x182B2E800")]
		[CompilerGenerated]
		private void YMSSAIGZIHV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E730", Offset = "0x2B2DB30", VA = "0x182B2E730")]
		[CompilerGenerated]
		private bool YMNLDBNBYWM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E820", Offset = "0x2B2DC20", VA = "0x182B2E820")]
		[CompilerGenerated]
		private string YNDFUVUUBEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E810", Offset = "0x2B2DC10", VA = "0x182B2E810")]
		[CompilerGenerated]
		private void YMXYXPAWRTE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E910", Offset = "0x2B2DD10", VA = "0x182B2E910")]
		[CompilerGenerated]
		private bool YNNTPJIOUBF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E8A0", Offset = "0x2B2DCA0", VA = "0x182B2E8A0")]
		[CompilerGenerated]
		private string YNIMSCORKPW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EAB0", Offset = "0x2B2DEB0", VA = "0x182B2EAB0")]
		[CompilerGenerated]
		private void YNYHJWWJMXX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E9E0", Offset = "0x2B2DDE0", VA = "0x182B2E9E0")]
		[CompilerGenerated]
		private bool YNTAMQCMDMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EAD0", Offset = "0x2B2DED0", VA = "0x182B2EAD0")]
		[CompilerGenerated]
		private string YOIVEKKEFUP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EAC0", Offset = "0x2B2DEC0", VA = "0x182B2EAC0")]
		[CompilerGenerated]
		private void YODOHDQGWJG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E490", Offset = "0x2B2D890", VA = "0x182B2E490")]
		[CompilerGenerated]
		private bool RSNZRYLQIOO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E560", Offset = "0x2B2D960", VA = "0x182B2E560")]
		[CompilerGenerated]
		private string RSTGPFFNRZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E3B0", Offset = "0x2B2D7B0", VA = "0x182B2E3B0")]
		[CompilerGenerated]
		private void RSDLXKXVPRW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E3C0", Offset = "0x2B2D7C0", VA = "0x182B2E3C0")]
		[CompilerGenerated]
		private bool RSISURRSZDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E330", Offset = "0x2B2D730", VA = "0x182B2E330")]
		[CompilerGenerated]
		private string RRSYCXKAWVE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E3A0", Offset = "0x2B2D7A0", VA = "0x182B2E3A0")]
		[CompilerGenerated]
		private void RRYFAEDYGGN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E200", Offset = "0x2B2D600", VA = "0x182B2E200")]
		[CompilerGenerated]
		private bool RRIKIJWGDYM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E2D0", Offset = "0x2B2D6D0", VA = "0x182B2E2D0")]
		[CompilerGenerated]
		private object RRNRFQQDNJV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B7A0", Offset = "0x2B2ABA0", VA = "0x182B2B7A0")]
		[CompilerGenerated]
		private void RQXWNWILLBU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C770", Offset = "0x2B2BB70", VA = "0x182B2C770")]
		[CompilerGenerated]
		private bool MOBBXSXENSN()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class EXPUZQMWUNQ
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class APNKFVIROEC : OGPTWGQRVAK<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public APNKFVIROEC IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C880", Offset = "0x2B1BC80", VA = "0x182B1C880")]
				internal object ZKVYMHBLGQU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CA20", Offset = "0x2B1BE20", VA = "0x182B1CA20")]
				internal void ZLBFJNVIQCD(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x2B17DA0", Offset = "0x2B171A0", VA = "0x182B17DA0")]
			public APNKFVIROEC(SCQFSPRNDPD a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x2B17B30", Offset = "0x2B16F30", VA = "0x182B17B30", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class WKMXGLFTVMT : UQINANQBUXD<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public override AudioClipType TVOEUJTLAXI
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2B39750", Offset = "0x2B38B50", VA = "0x182B39750")]
			public WKMXGLFTVMT(SCQFSPRNDPD a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class UARMHTVEAXJ : OGPTWGQRVAK<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A4C0", Offset = "0x2B298C0", VA = "0x182B2A4C0")]
			public UARMHTVEAXJ(SCQFSPRNDPD a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A360", Offset = "0x2B29760", VA = "0x182B2A360", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A1E0", Offset = "0x2B295E0", VA = "0x182B2A1E0")]
			[CompilerGenerated]
			private bool CGKQYOKTHTG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A230", Offset = "0x2B29630", VA = "0x182B2A230")]
			[CompilerGenerated]
			private void CGPXVVEQREP(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class JSDONBZKQAX : OGPTWGQRVAK<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public JSDONBZKQAX IRZLODQIRHI;

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C830", Offset = "0x2B1BC30", VA = "0x182B1C830")]
				internal void ZKVYMHBLGQU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CAF0", Offset = "0x2B1BEF0", VA = "0x182B1CAF0")]
				internal bool ZLBFJNVIQCD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D060", Offset = "0x2B1C460", VA = "0x182B1D060")]
				internal bool ZLGMGUPFZNM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D0B0", Offset = "0x2B1C4B0", VA = "0x182B1D0B0")]
				internal void ZLLTEBJDIYV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C5E0", Offset = "0x2B1B9E0", VA = "0x182B1C5E0")]
				internal bool ZKAWXFZVUXK()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2B1C1D0", Offset = "0x2B1B5D0", VA = "0x182B1C1D0")]
			public JSDONBZKQAX(SCQFSPRNDPD a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BEC0", Offset = "0x2B1B2C0", VA = "0x182B1BEC0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class MGLHOVFPDAP : OGPTWGQRVAK<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public MGLHOVFPDAP IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Predicate<Guid> FXBSDGWGMYK;

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C8E0", Offset = "0x2B1BCE0", VA = "0x182B1C8E0")]
				internal object? ZKVYMHBLGQU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C7B0", Offset = "0x2B1BBB0", VA = "0x182B1C7B0")]
				internal bool ZKQRPAHNXFL(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CB40", Offset = "0x2B1BF40", VA = "0x182B1CB40")]
				internal void ZLBFJNVIQCD(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CEC0", Offset = "0x2B1C2C0", VA = "0x182B1CEC0")]
				internal string ZLGMGUPFZNM(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D1E0", Offset = "0x2B1C5E0", VA = "0x182B1D1E0")]
				internal IReadOnlyList<object> ZLLTEBJDIYV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C570", Offset = "0x2B1B970", VA = "0x182B1C570")]
				internal bool ZKAWXFZVUXK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C630", Offset = "0x2B1BA30", VA = "0x182B1C630")]
				internal bool ZKGDUMTTEIT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C680", Offset = "0x2B1BA80", VA = "0x182B1C680")]
				internal void ZKLKRTNQNUC(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2B1DAE0", Offset = "0x2B1CEE0", VA = "0x182B1DAE0")]
			public MGLHOVFPDAP(SCQFSPRNDPD a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D3E0", Offset = "0x2B1C7E0", VA = "0x182B1D3E0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class DCAOFZXROFI : OGPTWGQRVAK<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public DCAOFZXROFI IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C9D0", Offset = "0x2B1BDD0", VA = "0x182B1C9D0")]
				internal bool ZKVYMHBLGQU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x2B1CD90", Offset = "0x2B1C190", VA = "0x182B1CD90")]
				internal void ZLBFJNVIQCD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x2B1D010", Offset = "0x2B1C410", VA = "0x182B1D010")]
				internal bool ZLGMGUPFZNM()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2B18510", Offset = "0x2B17910", VA = "0x182B18510")]
			public DCAOFZXROFI(SCQFSPRNDPD a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2B18300", Offset = "0x2B17700", VA = "0x182B18300", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class FEOZUVDTCVF : OGPTWGQRVAK<XRULXTDTHKI>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class NCLLTQFRZHV
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
					public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public NCLLTQFRZHV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					private TaskAwaiter<Result<Id32<CUIQXPIJUFR>, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x2B27910", Offset = "0x2B26D10", VA = "0x182B27910", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x2B27CF0", Offset = "0x2B270F0", VA = "0x182B27CF0", Slot = "5")]
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
					public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000BE")]
					public NCLLTQFRZHV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000BF")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x2B27D60", Offset = "0x2B27160", VA = "0x182B27D60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x2B280F0", Offset = "0x2B274F0", VA = "0x182B280F0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public Task DURFEAUBRBP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string ZWYZFZJXUKX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public FXXMCEYJLNJ.ADZQKKYSPMR MHFBTGKZLOW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public bool EFVWBKELXHM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public FEOZUVDTCVF IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public FXXMCEYJLNJ ZBFCFCRKQIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public Action XWMRPXERUSM;

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public NCLLTQFRZHV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E300", Offset = "0x2B1D700", VA = "0x182B1E300")]
				internal bool RMMHEMWPRGS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
				internal string NOIOSBHBNUP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DFD0", Offset = "0x2B1D3D0", VA = "0x182B1DFD0")]
				internal void NONVPIAYXFY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E050", Offset = "0x2B1D450", VA = "0x182B1E050")]
				internal void NOTCMOUWGRH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x16252D0", Offset = "0x16246D0", VA = "0x1816252D0")]
				internal bool NOYJJVOTQCQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E0A0", Offset = "0x2B1D4A0", VA = "0x182B1E0A0")]
				internal void NPDQHCIQZNZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x2B1E2C0", Offset = "0x2B1D6C0", VA = "0x182B1E2C0")]
				internal bool NPIXEJCOIZI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DEE0", Offset = "0x2B1D2E0", VA = "0x182B1DEE0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, SKKNIPYCQUO>> CBCPBGRPLBS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x2B1DDF0", Offset = "0x2B1D1F0", VA = "0x182B1DDF0")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, SKKNIPYCQUO>> AJRHLYOKLBT()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class QXLRGRRVYAH
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
					public AsyncTaskMethodBuilder<Result<Id32<CUIQXPIJUFR>, SKKNIPYCQUO>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000C8")]
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000C9")]
					private TaskAwaiter<Result<Id32<CUIQXPIJUFR>, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x2B27530", Offset = "0x2B26930", VA = "0x182B27530", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x2B278A0", Offset = "0x2B26CA0", VA = "0x182B278A0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public FEOZUVDTCVF IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public DLADXAUDIQZ UILEFRJVQYQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public bool RXRCHSMWGOI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public FXXMCEYJLNJ ZBFCFCRKQIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public FXESZWXXPWT LAZQRDXWHQG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public Action FULGMWXOUGX;

				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public QXLRGRRVYAH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2B214D0", Offset = "0x2B208D0", VA = "0x182B214D0")]
				internal object? ZLBFJNVIQCD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2B21540", Offset = "0x2B20940", VA = "0x182B21540")]
				internal void ZLGMGUPFZNM(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x2B21630", Offset = "0x2B20A30", VA = "0x182B21630")]
				internal string ZLLTEBJDIYV(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0x2B211A0", Offset = "0x2B205A0", VA = "0x182B211A0")]
				internal IReadOnlyList<object> ZKAWXFZVUXK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x2B21240", Offset = "0x2B20640", VA = "0x182B21240")]
				internal void ZKGDUMTTEIT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x2B213A0", Offset = "0x2B207A0", VA = "0x182B213A0")]
				internal bool ZKLKRTNQNUC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2B21410", Offset = "0x2B20810", VA = "0x182B21410")]
				internal void ZKQRPAHNXFL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x2B210D0", Offset = "0x2B204D0", VA = "0x182B210D0")]
				internal void ZJFVIEYGJEA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2B21120", Offset = "0x2B20520", VA = "0x182B21120")]
				internal void ZJLCFLSDSPJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000146")]
				[Cpp2IlInjected.Address(RVA = "0x2B20F80", Offset = "0x2B20380", VA = "0x182B20F80")]
				internal bool HGCRPMWBCWJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x2B20FE0", Offset = "0x2B203E0", VA = "0x182B20FE0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<CUIQXPIJUFR>, SKKNIPYCQUO>> QGLUZJCKTUV()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public override Id32<EVDWFGHNUCH>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x2B1B5E0", Offset = "0x2B1A9E0", VA = "0x182B1B5E0", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			protected override bool HJWQOLTFRYK
			{
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2B1B570", Offset = "0x2B1A970", VA = "0x182B1B570")]
			public FEOZUVDTCVF(SCQFSPRNDPD a, XRULXTDTHKI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2B1ABF0", Offset = "0x2B19FF0", VA = "0x182B1ABF0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x2B1A570", Offset = "0x2B19970", VA = "0x182B1A570")]
			private void CLREZUYPPWS(FXXMCEYJLNJ a, Id32<CUIQXPIJUFR>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class SBXVHDQTPGO : MVDYZVCXMTP<UNFBVRWOVBJ>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x1F58A50", Offset = "0x1F57E50", VA = "0x181F58A50", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			protected override bool CVTNDOMQNGZ
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			protected override bool QPOABDABHDW
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool RVXFMTDVSOZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			protected override bool HJWQOLTFRYK
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2B22630", Offset = "0x2B21A30", VA = "0x182B22630")]
			public SBXVHDQTPGO(SCQFSPRNDPD a, UNFBVRWOVBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public abstract class GMYHKEOQUKE<a> : OGPTWGQRVAK<a> where a : notnull, XVLHTUWPFRW
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
				public AsyncTaskMethodBuilder<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public GMYHKEOQUKE<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private TaskAwaiter<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x64A5D80", Offset = "0x64A5180", VA = "0x1864A5D80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x64A60D0", Offset = "0x64A54D0", VA = "0x1864A60D0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public GMYHKEOQUKE<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public Id32<IWTLBCZPUHH> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x6B41800", Offset = "0x6B40C00", VA = "0x186B41800", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x6B41B50", Offset = "0x6B40F50", VA = "0x186B41B50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public sealed override Id32<IWTLBCZPUHH>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x6372410", Offset = "0x6371810", VA = "0x186372410", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x63723E0", Offset = "0x63717E0", VA = "0x1863723E0")]
			protected GMYHKEOQUKE(SCQFSPRNDPD a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x6372220", Offset = "0x6371620", VA = "0x186372220", Slot = "122")]
			[AsyncStateMachine(typeof(GMYHKEOQUKE<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> OCOLHTZIOQR(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x6372340", Offset = "0x6371740", VA = "0x186372340", Slot = "149")]
			public sealed override bool WVWSDSIMVPC(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x6372180", Offset = "0x6371580", VA = "0x186372180", Slot = "134")]
			protected sealed override bool NUBOTBLNDMW(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x6371FD0", Offset = "0x63713D0", VA = "0x186371FD0", Slot = "135")]
			protected override bool BCTGWRHJJQB(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x6372070", Offset = "0x6371470", VA = "0x186372070", Slot = "123")]
			[AsyncStateMachine(typeof(GMYHKEOQUKE<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, SKKNIPYCQUO>> FMFWQQRQHYI(Id32<IWTLBCZPUHH> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public sealed class HGMBCPLZDRX : NZPZDBFTJKC<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public HGMBCPLZDRX IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C470", Offset = "0x2B1B870", VA = "0x182B1C470")]
				internal bool TNPRKDKTDQZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C3C0", Offset = "0x2B1B7C0", VA = "0x182B1C3C0")]
				internal void TNKKMWQVUFQ(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BD90", Offset = "0x2B1B190", VA = "0x182B1BD90")]
			public HGMBCPLZDRX(SCQFSPRNDPD a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BB50", Offset = "0x2B1AF50", VA = "0x182B1BB50", Slot = "151")]
			protected override void QMEBRNYBNGN(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class SCPXICYKMTM : OGPTWGQRVAK<KCMDUGBKCCH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			[CompilerGenerated]
			private sealed class EZWOGTCCREE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public int GPDJOMJKPQR;

				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public EZWOGTCCREE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016A")]
				[Cpp2IlInjected.Address(RVA = "0x2B1A530", Offset = "0x2B19930", VA = "0x182B1A530")]
				internal bool JAYSOLQFUIV(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private sealed class ZMZGDOYHPIH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public SCPXICYKMTM IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public Dictionary<string, EnumChoiceData> VQVHGVSCXCN;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public ZMZGDOYHPIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x2B39A30", Offset = "0x2B38E30", VA = "0x182B39A30")]
				internal int ZKVYMHBLGQU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x2B39AD0", Offset = "0x2B38ED0", VA = "0x182B39AD0")]
				internal void ZLBFJNVIQCD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x2B39BF0", Offset = "0x2B38FF0", VA = "0x182B39BF0")]
				internal string? ZLGMGUPFZNM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2B22B90", Offset = "0x2B21F90", VA = "0x182B22B90")]
			public SCPXICYKMTM(SCQFSPRNDPD a, KCMDUGBKCCH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2B22690", Offset = "0x2B21A90", VA = "0x182B22690")]
			private int DNJHMEFJORH(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x2B22A70", Offset = "0x2B21E70", VA = "0x182B22A70")]
			private void ZZKBJYCJBTL(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2B22720", Offset = "0x2B21B20", VA = "0x182B22720", Slot = "145")]
			protected sealed override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private sealed class LXWKXCMZCTA : MVDYZVCXMTP<FCUSHGRHYXJ>
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D300", Offset = "0x2B1C700", VA = "0x182B1D300")]
			public LXWKXCMZCTA(SCQFSPRNDPD a, FCUSHGRHYXJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public abstract class MVDYZVCXMTP<a> : OGPTWGQRVAK<a> where a : notnull, OCNBRNBLNQP
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			[CompilerGenerated]
			private sealed class BHUUMMASBGZ
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
					public BHUUMMASBGZ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x41C1200", Offset = "0x41C0600", VA = "0x1841C1200", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public FXXMCEYJLNJ ZBFCFCRKQIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public MVDYZVCXMTP<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public Action FXGZANQDWJT;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public BHUUMMASBGZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x4E7A960", Offset = "0x4E79D60", VA = "0x184E7A960")]
				internal void ZKVYMHBLGQU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x4E7A8C0", Offset = "0x4E79CC0", VA = "0x184E7A8C0")]
				[AsyncStateMachine(typeof(MVDYZVCXMTP<>.BHUUMMASBGZ.<<BuildConfigMenuInternal>b__6>d))]
				internal void ZKLKRTNQNUC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x4E7AC20", Offset = "0x4E7A020", VA = "0x184E7AC20")]
				internal bool ZLBFJNVIQCD()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private sealed class BHPNPFGURVQ
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
					public BHPNPFGURVQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000F4")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x41C0A30", Offset = "0x41BFE30", VA = "0x1841C0A30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public string QAWETXQKGBJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public BHUUMMASBGZ IYWFXXOWUJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public Func<string> FWGQOFURBFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action<string> FWWLGACJDNB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action FWREITILUBS;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public BHPNPFGURVQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x4E7A560", Offset = "0x4E79960", VA = "0x184E7A560")]
				internal void ZLGMGUPFZNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				internal string ZLLTEBJDIYV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
				internal void ZKAWXFZVUXK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x4E7A4C0", Offset = "0x4E798C0", VA = "0x184E7A4C0")]
				[AsyncStateMachine(typeof(MVDYZVCXMTP<>.BHPNPFGURVQ.<<BuildConfigMenuInternal>b__5>d))]
				internal void ZKGDUMTTEIT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private sealed class VUXMJHWWZLC
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
					public VUXMJHWWZLC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000105")]
					private TaskAwaiter<Result<Id32<CDTRWUZOHPN>, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x41BE190", Offset = "0x41BD590", VA = "0x1841BE190", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public VUXMJHWWZLC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x41BE8D0", Offset = "0x41BDCD0", VA = "0x1841BE8D0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public VUXMJHWWZLC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010D")]
					private TaskAwaiter<Result<Id32<CPMNZXWNEQO>, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x41BEAB0", Offset = "0x41BDEB0", VA = "0x1841BEAB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public MVDYZVCXMTP<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public Id32<IWTLBCZPUHH> WTJHBDYDFVX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public FXXMCEYJLNJ ZBFCFCRKQIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public AKNWFLPUDGH VASPZJLVCMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public int HYKADRTRDVV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int KVWYCEIOIAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public UGXJSTBRSTY CJPAADHOHIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public string SOGHXOJMIYG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public List<SHJCWUUMGGW> XMCSRLBSFHR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public UGXJSTBRSTY RBXYPWNCKFI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public string BQKTVXEYTIL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public List<SHJCWUUMGGW> XKBFRSUCOXG;

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public VUXMJHWWZLC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DBB0", Offset = "0x7E5CFB0", VA = "0x187E5DBB0")]
				internal bool YVAQJDIGEAT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DB40", Offset = "0x7E5CF40", VA = "0x187E5DB40")]
				internal void YUVJLWOIUPK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x7E5D890", Offset = "0x7E5CC90", VA = "0x187E5D890")]
				internal bool MELJGDLJUSN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DC60", Offset = "0x7E5D060", VA = "0x187E5DC60")]
				[AsyncStateMachine(typeof(MVDYZVCXMTP<>.VUXMJHWWZLC.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void YVLEDQWAWXL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DC20", Offset = "0x7E5D020", VA = "0x187E5DC20")]
				internal bool YVFXGKCDNMC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x7E5D8D0", Offset = "0x7E5CCD0", VA = "0x187E5D8D0")]
				internal void MFGKVEMZGLX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x7E5D9B0", Offset = "0x7E5CDB0", VA = "0x187E5D9B0")]
				internal bool MFLRSLGWPXG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DA60", Offset = "0x7E5CE60", VA = "0x187E5DA60")]
				internal void MFQYPSATZIP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x7E5D6E0", Offset = "0x7E5CAE0", VA = "0x187E5D6E0")]
				internal bool GFXEXECZBRF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DD70", Offset = "0x7E5D170", VA = "0x187E5DD70")]
				internal bool YVVRYEJVPUD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DD00", Offset = "0x7E5D100", VA = "0x187E5DD00")]
				internal void YVQLAXPYGIU(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DE40", Offset = "0x7E5D240", VA = "0x187E5DE40")]
				[AsyncStateMachine(typeof(MVDYZVCXMTP<>.VUXMJHWWZLC.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void YWGFSRXQIQV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DDE0", Offset = "0x7E5D1E0", VA = "0x187E5DDE0")]
				internal bool YWAYVLDSZFM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DF50", Offset = "0x7E5D350", VA = "0x187E5DF50")]
				internal bool YWQTNFLLBNN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DEE0", Offset = "0x7E5D2E0", VA = "0x187E5DEE0")]
				internal void YWLMPYRNSCE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x7E5D790", Offset = "0x7E5CB90", VA = "0x187E5D790")]
				[AsyncStateMachine(typeof(MVDYZVCXMTP<>.VUXMJHWWZLC.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void MDVOOJDRSKM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x7E5D830", Offset = "0x7E5CC30", VA = "0x187E5D830")]
				internal bool MEAVLPXPBVV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private sealed class VVCTGOQUIWL
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
					public VVCTGOQUIWL <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000116")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000117")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x41BE480", Offset = "0x41BD880", VA = "0x1841BE480", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public string RXIPGMUEQXN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public VUXMJHWWZLC IYWFXXOWUJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public Func<string> BEEVHGTMWKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public Action<string> BEKCENNKFVR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public Action BEPJBUHHPHA;

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public VVCTGOQUIWL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DFC0", Offset = "0x7E5D3C0", VA = "0x187E5DFC0")]
				internal void MEGCIWRMLHE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				internal string MEQQDKFHEDW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
				internal void MEVXAQZENPF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0x7E5E320", Offset = "0x7E5D720", VA = "0x187E5E320")]
				[AsyncStateMachine(typeof(MVDYZVCXMTP<>.VVCTGOQUIWL.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void MFBDXXTBXAO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private sealed class SCEXZQVSVUD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public bool XMCSRLBSFHR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public AKNWFLPUDGH VASPZJLVCMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public List<SHJCWUUMGGW> PBAZTQUEDMS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public MVDYZVCXMTP<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public Id32<IWTLBCZPUHH> WTJHBDYDFVX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public int OHKBUHVCYQY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public Func<bool> FVWCTSGWIII;

				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public SCEXZQVSVUD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0x79267F0", Offset = "0x7925BF0", VA = "0x1879267F0")]
				internal bool PJJFPYIZGTT()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class SBZRCKBVMIU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public IKOBMFTUZAY YPIHZULIKUB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public SCEXZQVSVUD IYWFXXOWUJJ;

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public SBZRCKBVMIU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x7926310", Offset = "0x7925710", VA = "0x187926310")]
				internal void PITKYEBHELS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x7926480", Offset = "0x7925880", VA = "0x187926480")]
				internal bool PIYRVKVENXB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x79264D0", Offset = "0x79258D0", VA = "0x1879264D0")]
				internal void PJZAHSQRJBU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x7926660", Offset = "0x7925A60", VA = "0x187926660")]
				internal bool PKEHEZKOSND()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private sealed class SCPLUEJNOQV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public SHJCWUUMGGW ZINLSYWBRRV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public SBZRCKBVMIU IZBMVEIUDUS;

				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public SCPLUEJNOQV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x7926850", Offset = "0x7925C50", VA = "0x187926850")]
				internal void PJDYSRPBXIK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class FHQAJEWLFRE
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
					public FHQAJEWLFRE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012D")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012F")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x41C1CC0", Offset = "0x41C10C0", VA = "0x1841C1CC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public List<object> QZWNMGFLQHV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public UGXJSTBRSTY RDANTZEHILB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public bool XMCSRLBSFHR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public AKNWFLPUDGH VASPZJLVCMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public IKOBMFTUZAY YPIHZULIKUB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public string RXIPGMUEQXN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public FHQAJEWLFRE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x6277D20", Offset = "0x6277120", VA = "0x186277D20")]
				internal int CMQUIRBAYME()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x6277D60", Offset = "0x6277160", VA = "0x186277D60")]
				internal void CMWBFXUYHXN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30")]
				internal string CNBIDEOVRIW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x6277FC0", Offset = "0x62773C0", VA = "0x186277FC0")]
				[AsyncStateMachine(typeof(MVDYZVCXMTP<>.FHQAJEWLFRE.<<CreatePortItemV2>b__3>d))]
				internal void CNGPALITAUF(string a)
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
				public AsyncTaskMethodBuilder<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public MVDYZVCXMTP<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x64A5960", Offset = "0x64A4D60", VA = "0x1864A5960", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x64A5D10", Offset = "0x64A5110", VA = "0x1864A5D10", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public MVDYZVCXMTP<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public Id32<IWTLBCZPUHH> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x6B41BC0", Offset = "0x6B40FC0", VA = "0x186B41BC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x6B41F60", Offset = "0x6B41360", VA = "0x186B41F60", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<MultiResult, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public MVDYZVCXMTP<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				private TaskAwaiter<Result<MultiResult, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x6BCB9E0", Offset = "0x6BCADE0", VA = "0x186BCB9E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x6BCBF80", Offset = "0x6BCB380", VA = "0x186BCBF80", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly Dictionary<Id32<IWTLBCZPUHH>, bool> BPWGPZSXUZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Dictionary<Id32<IWTLBCZPUHH>, bool> BDCKQLBYHFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly Dictionary<Id32<IWTLBCZPUHH>, bool> WNICXPARELS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Dictionary<Id32<IWTLBCZPUHH>, bool> GTKQYYHNBXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private Dictionary<Id32<IWTLBCZPUHH>, bool> FXDDFXWXLMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Dictionary<Id32<IWTLBCZPUHH>, bool> ABAILRVEWOW;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected virtual bool CVTNDOMQNGZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			protected virtual bool QPOABDABHDW
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			protected virtual bool RVXFMTDVSOZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override Id32<EVDWFGHNUCH>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x6FAF3B0", Offset = "0x6FAE7B0", VA = "0x186FAF3B0", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override Id32<IWTLBCZPUHH>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x6FAF610", Offset = "0x6FAEA10", VA = "0x186FAF610", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public override IEnumerable<Id128<IHXSJTKSKEJ>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x6FAF430", Offset = "0x6FAE830", VA = "0x186FAF430", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x6FAF1E0", Offset = "0x6FAE5E0", VA = "0x186FAF1E0")]
			public MVDYZVCXMTP(SCQFSPRNDPD a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "154")]
			protected virtual bool JWFWMFBUPIE(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "155")]
			protected virtual bool HFZFXZFHAJV(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "156")]
			protected virtual bool IRMOKJEOWOO(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "157")]
			protected virtual void GJKKPTQQBDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x6FAE0E0", Offset = "0x6FAD4E0", VA = "0x186FAE0E0", Slot = "149")]
			public override bool WVWSDSIMVPC(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC950", Offset = "0x6FABD50", VA = "0x186FAC950", Slot = "122")]
			[AsyncStateMachine(typeof(MVDYZVCXMTP<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> OCOLHTZIOQR(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC1C0", Offset = "0x6FAB5C0", VA = "0x186FAC1C0", Slot = "123")]
			[AsyncStateMachine(typeof(MVDYZVCXMTP<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, SKKNIPYCQUO>> FMFWQQRQHYI(Id32<IWTLBCZPUHH> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC2D0", Offset = "0x6FAB6D0", VA = "0x186FAC2D0", Slot = "124")]
			public override void HCISHKPEQLO(Id32<IWTLBCZPUHH> index, Id32<IWTLBCZPUHH> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6FACA70", Offset = "0x6FABE70", VA = "0x186FACA70", Slot = "125")]
			public override IEnumerable<PXBFMCKNGBK> QEFOOCZHEIL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6FACCB0", Offset = "0x6FAC0B0", VA = "0x186FACCB0")]
			[AsyncStateMachine(typeof(MVDYZVCXMTP<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, SKKNIPYCQUO>> TMNRHZWBEOC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "158")]
			protected virtual bool UNBZLJONTHZ(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "159")]
			protected virtual bool KNBFWCCKOMH(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "160")]
			protected virtual bool UAZIPJTMPTE(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "161")]
			protected virtual bool VJEWBGWCSVG(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "162")]
			protected virtual bool DENEOFTZGVE(Id32<IWTLBCZPUHH> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "163")]
			protected virtual bool PYXQRCYQRVF(Id32<IWTLBCZPUHH> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "164")]
			protected virtual bool LLDQJSSZDGF(Id32<IWTLBCZPUHH> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "165")]
			protected virtual bool IJEPYNXXGQS(Id32<IWTLBCZPUHH> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "166")]
			protected virtual bool FFANMVDJLLM(Id32<IWTLBCZPUHH> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "167")]
			protected virtual bool HIIUSXWOHLD(Id32<IWTLBCZPUHH> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC470", Offset = "0x6FAB870", VA = "0x186FAC470", Slot = "168")]
			protected virtual List<UGXJSTBRSTY> JGICGHRKNPP(Id32<IWTLBCZPUHH> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "169")]
			protected virtual void VYOHTLNMNMW(FXXMCEYJLNJ a, JIKSHYOTFUN b, AKNWFLPUDGH c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6FACDB0", Offset = "0x6FAC1B0", VA = "0x186FACDB0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6FAA870", Offset = "0x6FA9C70", VA = "0x186FAA870")]
			private JIKSHYOTFUN DFLMGICRILB(FXXMCEYJLNJ a, AKNWFLPUDGH b, Id32<IWTLBCZPUHH> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x6FAE180", Offset = "0x6FAD580", VA = "0x186FAE180")]
			private List<SHJCWUUMGGW> ZEUJBWDLJJG(FXXMCEYJLNJ a, AKNWFLPUDGH b, JIKSHYOTFUN c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x6FAD750", Offset = "0x6FACB50", VA = "0x186FAD750")]
			private List<SHJCWUUMGGW> VPGXYZXZHMS(FXXMCEYJLNJ a, AKNWFLPUDGH b, IKOBMFTUZAY c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC700", Offset = "0x6FABB00", VA = "0x186FAC700")]
			private UGXJSTBRSTY LCNPLCHWQZS(List<UGXJSTBRSTY> a, IKOBMFTUZAY b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC8F0", Offset = "0x6FABCF0", VA = "0x186FAC8F0")]
			[CompilerGenerated]
			private PXBFMCKNGBK NVKAZVVDKXM(SIDFNDXEBQO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class ULHLAKNJZKY : OGPTWGQRVAK<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private sealed class JZPSQTWWHKR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public ULHLAKNJZKY IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public JZPSQTWWHKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C240", Offset = "0x2B1B640", VA = "0x182B1C240")]
				internal int ZKVYMHBLGQU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C290", Offset = "0x2B1B690", VA = "0x182B1C290")]
				internal Task<bool> ZLBFJNVIQCD(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A6E0", Offset = "0x2B29AE0", VA = "0x182B2A6E0")]
			public ULHLAKNJZKY(SCQFSPRNDPD a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A530", Offset = "0x2B29930", VA = "0x182B2A530", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public sealed class YHTUNRYLNNC : NZPZDBFTJKC<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public YHTUNRYLNNC IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C4F0", Offset = "0x2B1B8F0", VA = "0x182B1C4F0")]
				internal int TNPRKDKTDQZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B1C320", Offset = "0x2B1B720", VA = "0x182B1C320")]
				internal Task<bool> TNKKMWQVUFQ(int a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2B399D0", Offset = "0x2B38DD0", VA = "0x182B399D0")]
			public YHTUNRYLNNC(SCQFSPRNDPD a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2B397B0", Offset = "0x2B38BB0", VA = "0x182B397B0", Slot = "151")]
			protected override void QMEBRNYBNGN(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class QEMNHXIRBTY : OGPTWGQRVAK<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xF33D30", Offset = "0xF33130", VA = "0x180F33D30", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B20F10", Offset = "0x2B20310", VA = "0x182B20F10")]
			public QEMNHXIRBTY(SCQFSPRNDPD a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class PLAHNVNGGHM : OGPTWGQRVAK<OBMIDMPQAOH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			[CompilerGenerated]
			private sealed class VUGRTXXDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				public PLAHNVNGGHM IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public FXXMCEYJLNJ ZBFCFCRKQIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public Func<string> LHTNLLDOEPS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public Action<string> LIJIDFLGGXT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public Func<int> LIOPAMFDQJC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public Action<int> LJEJSGMVSRD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public Func<bool> LIZCUZSYJFU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				public Func<bool> LGIREPUGQOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public Func<bool> LGDKHJAJHCY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public Func<float> EHHPJZPIYIS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public Action<float> EHMWHGJGHUB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public Func<bool> EGXBPMBOFMA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public Func<bool> EHCIMSVLOXJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public Func<bool> EGMNUYNTMPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public Func<string> EGRUSFHQWAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public Action<string> EGCAAKZYTSQ;

				[Cpp2IlInjected.Token(Token = "0x6000215")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public VUGRTXXDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0x2B39360", Offset = "0x2B38760", VA = "0x182B39360")]
				internal bool ZKVYMHBLGQU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0x2B393B0", Offset = "0x2B387B0", VA = "0x182B393B0")]
				internal void ZLBFJNVIQCD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x2B39170", Offset = "0x2B38570", VA = "0x182B39170")]
				internal bool ZKAWXFZVUXK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x2B39210", Offset = "0x2B38610", VA = "0x182B39210")]
				internal bool ZKGDUMTTEIT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2B392B0", Offset = "0x2B386B0", VA = "0x182B392B0")]
				internal void ZKLKRTNQNUC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x2B39080", Offset = "0x2B38480", VA = "0x182B39080")]
				internal bool ZJLCFLSDSPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2B35C50", Offset = "0x2B35050", VA = "0x182B35C50")]
				internal bool HGCRPMWBCWJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x2B35BF0", Offset = "0x2B34FF0", VA = "0x182B35BF0")]
				internal void HFXKSGCDTLA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x2B35BA0", Offset = "0x2B34FA0", VA = "0x182B35BA0")]
				internal bool HFHQALULRCZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2B35B50", Offset = "0x2B34F50", VA = "0x182B35B50")]
				internal bool HFCJDFAOHRQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x2B35AF0", Offset = "0x2B34EF0", VA = "0x182B35AF0")]
				internal void HEXCFYGQYGH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2B35CA0", Offset = "0x2B350A0", VA = "0x182B35CA0")]
				internal bool HHNNWIFIQXU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2B38220", Offset = "0x2B37620", VA = "0x182B38220")]
				internal bool VGPZXWKQWNR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2B381D0", Offset = "0x2B375D0", VA = "0x182B381D0")]
				internal bool VGKTAPQTNCI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2B38270", Offset = "0x2B37670", VA = "0x182B38270")]
				internal bool VHANSJYLPKJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2B38180", Offset = "0x2B37580", VA = "0x182B38180")]
				internal bool VFUYIVJBKUH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2B38130", Offset = "0x2B37530", VA = "0x182B38130")]
				internal bool VFPRLOPEBIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2B37020", Offset = "0x2B36420", VA = "0x182B37020")]
				internal bool OGTWOFEDSOS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2B37070", Offset = "0x2B36470", VA = "0x182B37070")]
				internal bool OGZDLLYBCAB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2B36F70", Offset = "0x2B36370", VA = "0x182B36F70")]
				internal void OGJITRQIZSA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2B39030", Offset = "0x2B38430", VA = "0x182B39030")]
				internal bool ZJKKWWNFNPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2B390D0", Offset = "0x2B384D0", VA = "0x182B390D0")]
				internal bool ZJPRUDHCXAS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2B39120", Offset = "0x2B38520", VA = "0x182B39120")]
				internal bool ZJUYRKBAGMB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2B391C0", Offset = "0x2B385C0", VA = "0x182B391C0")]
				internal bool ZKFMLXOUZIT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2B39260", Offset = "0x2B38660", VA = "0x182B39260")]
				internal bool ZKKTJEISIUC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2B36FD0", Offset = "0x2B363D0", VA = "0x182B36FD0")]
				internal bool OGOPQYKGJDJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2B37160", Offset = "0x2B36560", VA = "0x182B37160")]
				internal bool OHOYDGFTEIC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2B371B0", Offset = "0x2B365B0", VA = "0x182B371B0")]
				internal void OHUFAMZQNTL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2B370C0", Offset = "0x2B364C0", VA = "0x182B370C0")]
				internal bool OHEKISRYLLK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2B37110", Offset = "0x2B36510", VA = "0x182B37110")]
				internal bool OHJRFZLVUWT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2B36EC0", Offset = "0x2B362C0", VA = "0x182B36EC0")]
				internal void OFDTKDAYVBY(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2B36F20", Offset = "0x2B36320", VA = "0x182B36F20")]
				internal bool OFJAHJUWENH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2B38320", Offset = "0x2B37720", VA = "0x182B38320")]
				internal bool VHLBMXMGIHB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2B382C0", Offset = "0x2B376C0", VA = "0x182B382C0")]
				internal void VHFUPQSIYVS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2B2F020", Offset = "0x2B2E420", VA = "0x182B2F020")]
				internal List<SHJCWUUMGGW> CXJFFPTRDFP(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2B39310", Offset = "0x2B38710", VA = "0x182B39310")]
				internal bool ZKQAGLCPSFL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2B38F50", Offset = "0x2B38350", VA = "0x182B38F50")]
				internal int ZHPAVNQDGRG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2B38FA0", Offset = "0x2B383A0", VA = "0x182B38FA0")]
				internal Task<bool> ZHUHSUKAQCP(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2B355C0", Offset = "0x2B349C0", VA = "0x182B355C0")]
				internal bool GJWIYIBKTWJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2B35570", Offset = "0x2B34970", VA = "0x182B35570")]
				internal bool GJRCBBHNKLA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2B35520", Offset = "0x2B34920", VA = "0x182B35520")]
				internal bool GJLVDUNQAZR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2B354D0", Offset = "0x2B348D0", VA = "0x182B354D0")]
				internal int GJGOGNTSROI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2B35700", Offset = "0x2B34B00", VA = "0x182B35700")]
				internal Task<bool> GKRKNJDAFPT(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2B356B0", Offset = "0x2B34AB0", VA = "0x182B356B0")]
				internal bool GKMDQCJCWEK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2B35660", Offset = "0x2B34A60", VA = "0x182B35660")]
				internal bool GKGWSVPFMTB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2B35610", Offset = "0x2B34A10", VA = "0x182B35610")]
				internal bool GKBPVOVIDHS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2B35480", Offset = "0x2B34880", VA = "0x182B35480")]
				internal bool GIAYWZEIMYG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x2B36E70", Offset = "0x2B36270", VA = "0x182B36E70")]
				internal bool NKNNXAJNJOS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EE60", Offset = "0x2B2E260", VA = "0x182B2EE60")]
				internal string AVGGCWNAVFF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EEB0", Offset = "0x2B2E2B0", VA = "0x182B2EEB0")]
				internal void AVLNADGYEQO(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EF20", Offset = "0x2B2E320", VA = "0x182B2EF20")]
				internal int AWBHRXOQGYP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EF70", Offset = "0x2B2E370", VA = "0x182B2EF70")]
				internal void AWGOPEINQJY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EFD0", Offset = "0x2B2E3D0", VA = "0x182B2EFD0")]
				internal bool AWLVMLCKZVH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2B2ED70", Offset = "0x2B2E170", VA = "0x182B2ED70")]
				internal bool ATKWBNPYOHC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EDC0", Offset = "0x2B2E1C0", VA = "0x182B2EDC0")]
				internal bool ATQCYUJVXSL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2B35DF0", Offset = "0x2B351F0", VA = "0x182B35DF0")]
				internal float HVSEEIBGBMF()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2B35D90", Offset = "0x2B35190", VA = "0x182B35D90")]
				internal void HVMXHBHISAW(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2B35D40", Offset = "0x2B35140", VA = "0x182B35D40")]
				internal bool HVHQJUNLIPN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2B35CF0", Offset = "0x2B350F0", VA = "0x182B35CF0")]
				internal bool HVCJMNTNZEE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2B35F00", Offset = "0x2B35300", VA = "0x182B35F00")]
				internal bool HWNFTJCVNFP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2B36DD0", Offset = "0x2B361D0", VA = "0x182B36DD0")]
				internal bool NKDACMVSQSA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2B36E20", Offset = "0x2B36220", VA = "0x182B36E20")]
				internal bool NKIGZTPQADJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2B36980", Offset = "0x2B35D80", VA = "0x182B36980")]
				internal bool NJSMHZHXXVI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2B369D0", Offset = "0x2B35DD0", VA = "0x182B369D0")]
				internal void NJXTFGBVHGR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2B35EB0", Offset = "0x2B352B0", VA = "0x182B35EB0")]
				internal string HWHYWCIYDUG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x2B35E40", Offset = "0x2B35240", VA = "0x182B35E40")]
				internal void HWCRYVPAUIX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2B368E0", Offset = "0x2B35CE0", VA = "0x182B368E0")]
				internal bool NJHYNLUDEYQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2B36930", Offset = "0x2B35D30", VA = "0x182B36930")]
				internal bool NJNFKSOAOJZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2B365F0", Offset = "0x2B359F0", VA = "0x182B365F0")]
				internal bool NIXKSYGIMBY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x2B36640", Offset = "0x2B35A40", VA = "0x182B36640")]
				internal void NJCRQFAFVNH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2B37E40", Offset = "0x2B37240", VA = "0x182B37E40")]
				internal bool UESGFKEWJHZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2B37DF0", Offset = "0x2B371F0", VA = "0x182B37DF0")]
				internal bool UEMZIDKYZWQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2B37EE0", Offset = "0x2B372E0", VA = "0x182B37EE0")]
				internal bool UFCTZXSRCER()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2B37E90", Offset = "0x2B37290", VA = "0x182B37E90")]
				internal bool UEXNCQYTSTI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2B37F80", Offset = "0x2B37380", VA = "0x182B37F80")]
				internal void UFNHULGLVBJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2B37F30", Offset = "0x2B37330", VA = "0x182B37F30")]
				internal bool UFIAXEMOLQA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2B38030", Offset = "0x2B37430", VA = "0x182B38030")]
				internal bool UFXVOYUGNYB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2B37FE0", Offset = "0x2B373E0", VA = "0x182B37FE0")]
				internal bool UFSORSAJEMS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2B380E0", Offset = "0x2B374E0", VA = "0x182B380E0")]
				internal bool UGIJJMIBGUT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2B38080", Offset = "0x2B37480", VA = "0x182B38080")]
				internal void UGDCMFODXJK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2B38E10", Offset = "0x2B38210", VA = "0x182B38E10")]
				internal bool YMYVIKYRVEA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2B38E60", Offset = "0x2B38260", VA = "0x182B38E60")]
				internal bool YNECFRSPEPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2B38EB0", Offset = "0x2B382B0", VA = "0x182B38EB0")]
				internal bool YNJJCYMMOAS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2B38F00", Offset = "0x2B38300", VA = "0x182B38F00")]
				internal bool YNOQAFGJXMB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2B38D10", Offset = "0x2B38110", VA = "0x182B38D10")]
				internal object YMOHNXKXCHI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2B38D80", Offset = "0x2B38180", VA = "0x182B38D80")]
				internal void YMTOLEEULSR(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2B38C70", Offset = "0x2B38070", VA = "0x182B38C70")]
				internal bool YLISEIVMXRG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x2B38CC0", Offset = "0x2B380C0", VA = "0x182B38CC0")]
				internal bool YLNZBPPKHCP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2B35430", Offset = "0x2B34830", VA = "0x182B35430")]
				internal int FNKTJWMXBLA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2B353D0", Offset = "0x2B347D0", VA = "0x182B353D0")]
				internal void FNFMMPSZRZR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2B35380", Offset = "0x2B34780", VA = "0x182B35380")]
				internal bool FMPRUVLHPRQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x2B35330", Offset = "0x2B34730", VA = "0x182B35330")]
				internal bool FMKKXORKGGH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2B352E0", Offset = "0x2B346E0", VA = "0x182B352E0")]
				internal int FLUQFUJSDYG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2B35140", Offset = "0x2B34540", VA = "0x182B35140")]
				internal void EOMZOPJFPRR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2B350F0", Offset = "0x2B344F0", VA = "0x182B350F0")]
				internal bool EOHSRIPIGGI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2B351F0", Offset = "0x2B345F0", VA = "0x182B351F0")]
				internal bool EOXNJCXAIOJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2B351A0", Offset = "0x2B345A0", VA = "0x182B351A0")]
				internal bool EOSGLWDCZDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2B350A0", Offset = "0x2B344A0", VA = "0x182B350A0")]
				internal int EOCLUBVKWUZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2B35040", Offset = "0x2B34440", VA = "0x182B35040")]
				internal void ENXEWVBNNJQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2B35290", Offset = "0x2B34690", VA = "0x182B35290")]
				internal bool EQDCSRMKNEL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2B35240", Offset = "0x2B34640", VA = "0x182B35240")]
				internal bool EPXVVKSNDTC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2B38A80", Offset = "0x2B37E80", VA = "0x182B38A80")]
				internal bool XNVUPXBCZZI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2B38B60", Offset = "0x2B37F60", VA = "0x182B38B60")]
				internal object XOWDCEWPVEB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2B38AD0", Offset = "0x2B37ED0", VA = "0x182B38AD0")]
				internal void XOGIKKOXSWA(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2B38BD0", Offset = "0x2B37FD0", VA = "0x182B38BD0")]
				internal bool XPLXTZEHXMC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2B38C20", Offset = "0x2B38020", VA = "0x182B38C20")]
				internal bool XPRERFYFGXL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x2B37D80", Offset = "0x2B37180", VA = "0x182B37D80")]
				internal object? QTRCHNFUAGB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2B37CF0", Offset = "0x2B370F0", VA = "0x182B37CF0")]
				internal void QTLVKGLWQUS(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2B37CA0", Offset = "0x2B370A0", VA = "0x182B37CA0")]
				internal bool QSWASMEEOMR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x2B37C50", Offset = "0x2B37050", VA = "0x182B37C50")]
				internal int QSQTVFKHFBI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2B37BF0", Offset = "0x2B36FF0", VA = "0x182B37BF0")]
				internal void QSLMXYQJVPZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2B37BA0", Offset = "0x2B36FA0", VA = "0x182B37BA0")]
				internal bool QSGGARWMMEQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2B37B50", Offset = "0x2B36F50", VA = "0x182B37B50")]
				internal bool QSAZDLCPCTH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2B37B00", Offset = "0x2B36F00", VA = "0x182B37B00")]
				internal bool QRVSGEIRTHY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2B364A0", Offset = "0x2B358A0", VA = "0x182B364A0")]
				internal int JSZXIUXRKNS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2B364F0", Offset = "0x2B358F0", VA = "0x182B364F0")]
				internal void JTFEGBROTZB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2B36550", Offset = "0x2B35950", VA = "0x182B36550")]
				internal bool JTKLDILMDKK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2B365A0", Offset = "0x2B359A0", VA = "0x182B365A0")]
				internal bool JTPSAPFJMVT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2B36350", Offset = "0x2B35750", VA = "0x182B36350")]
				internal bool JSEVTTWBYUI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2B363A0", Offset = "0x2B357A0", VA = "0x182B363A0")]
				internal float JSKCRAPZIFR()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2B363F0", Offset = "0x2B357F0", VA = "0x182B363F0")]
				internal void JSPJOHJWRRA(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2B36450", Offset = "0x2B35850", VA = "0x182B36450")]
				internal bool JSUQLODUBCJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2B362B0", Offset = "0x2B356B0", VA = "0x182B362B0")]
				internal bool JRJUESUMNAY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2B36300", Offset = "0x2B35700", VA = "0x182B36300")]
				internal bool JRPBBZOJWMH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2B34E90", Offset = "0x2B34290", VA = "0x182B34E90")]
				internal float DSGQXKOPGRR()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2B34E30", Offset = "0x2B34230", VA = "0x182B34E30")]
				internal void DSBKADURXGI(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2B34EE0", Offset = "0x2B342E0", VA = "0x182B34EE0")]
				internal bool DSRERYCJZOJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2B34F30", Offset = "0x2B34330", VA = "0x182B34F30")]
				internal bool DSWLPEWHIZS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2B34FF0", Offset = "0x2B343F0", VA = "0x182B34FF0")]
				internal string DTMGGZDZLHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2B34F80", Offset = "0x2B34380", VA = "0x182B34F80")]
				internal void DTGZJSKCBWK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2B34DE0", Offset = "0x2B341E0", VA = "0x182B34DE0")]
				internal bool DQQNTILKJEX(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2B34D90", Offset = "0x2B34190", VA = "0x182B34D90")]
				internal bool DQLGWBRMZTO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2B38880", Offset = "0x2B37C80", VA = "0x182B38880")]
				internal bool WRPLYSGMQZI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2B388D0", Offset = "0x2B37CD0", VA = "0x182B388D0")]
				internal bool WRUSVZAKAKR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2B387C0", Offset = "0x2B37BC0", VA = "0x182B387C0")]
				internal string WREYEESRYCQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2B38810", Offset = "0x2B37C10", VA = "0x182B38810")]
				internal void WRKFBLMPHNZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2B38720", Offset = "0x2B37B20", VA = "0x182B38720")]
				internal bool WQUKJREXFFY(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2B38770", Offset = "0x2B37B70", VA = "0x182B38770")]
				internal bool WQZRGXYUORH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2B38680", Offset = "0x2B37A80", VA = "0x182B38680")]
				internal bool WQJWPDRCMJG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2B386D0", Offset = "0x2B37AD0", VA = "0x182B386D0")]
				internal bool WQPDMKKZVUP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2B38970", Offset = "0x2B37D70", VA = "0x182B38970")]
				internal string WTFPCUJROMC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2B38A10", Offset = "0x2B37E10", VA = "0x182B38A10")]
				internal void WTKWABDOXXL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B37610", Offset = "0x2B36A10", VA = "0x182B37610")]
				internal bool PQYGZZYKBGZ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B375C0", Offset = "0x2B369C0", VA = "0x182B375C0")]
				internal bool PQTACTEMRVQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2B37570", Offset = "0x2B36970", VA = "0x182B37570")]
				internal bool PQNTFMKPIKH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2B37520", Offset = "0x2B36920", VA = "0x182B37520")]
				internal bool PQIMIFQRYYY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2B37820", Offset = "0x2B36C20", VA = "0x182B37820")]
				internal string PRTIPAZZNAJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2B377B0", Offset = "0x2B36BB0", VA = "0x182B377B0")]
				internal void PROBRUGCDPA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B37760", Offset = "0x2B36B60", VA = "0x182B37760")]
				internal bool PRIUUNMEUDR(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B376C0", Offset = "0x2B36AC0", VA = "0x182B376C0")]
				internal bool PRDNXGSHKSI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2B37970", Offset = "0x2B36D70", VA = "0x182B37970")]
				internal bool PSOKECBOYTT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2B378C0", Offset = "0x2B36CC0", VA = "0x182B378C0")]
				internal bool PSJDGVHRPIK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2B35F50", Offset = "0x2B35350", VA = "0x182B35F50")]
				internal string IQHCBHQHLOQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B35FA0", Offset = "0x2B353A0", VA = "0x182B35FA0")]
				internal void IQMIYOKEUZZ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B36010", Offset = "0x2B35410", VA = "0x182B36010")]
				internal bool IQRPVVECELI(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B36060", Offset = "0x2B35460", VA = "0x182B36060")]
				internal bool IQWWTBXZNWR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B360B0", Offset = "0x2B354B0", VA = "0x182B360B0")]
				internal bool IRCDQIRWXIA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2B36100", Offset = "0x2B35500", VA = "0x182B36100")]
				internal bool IRHKNPLUGTJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2B36150", Offset = "0x2B35550", VA = "0x182B36150")]
				internal string IRMRKWFRQES()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2B361A0", Offset = "0x2B355A0", VA = "0x182B361A0")]
				internal void IRRYICZOZQB(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x2B36210", Offset = "0x2B35610", VA = "0x182B36210")]
				internal bool IRXFFJTMJBK(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2B36260", Offset = "0x2B35660", VA = "0x182B36260")]
				internal bool ISCMCQNJSMT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2B359E0", Offset = "0x2B34DE0", VA = "0x182B359E0")]
				internal bool GNMDNHLFXQT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2B35990", Offset = "0x2B34D90", VA = "0x182B35990")]
				internal bool GNGWQARIOFK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2B35AA0", Offset = "0x2B34EA0", VA = "0x182B35AA0")]
				internal string GNWRHUZAQNL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2B35A30", Offset = "0x2B34E30", VA = "0x182B35A30")]
				internal void GNRKKOFDHCC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2B358A0", Offset = "0x2B34CA0", VA = "0x182B358A0")]
				internal bool GMRBYGJQLXJ(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2B35850", Offset = "0x2B34C50", VA = "0x182B35850")]
				internal bool GMLVAZPTCMA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2B35940", Offset = "0x2B34D40", VA = "0x182B35940")]
				internal bool GNBPSTXLEUB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2B358F0", Offset = "0x2B34CF0", VA = "0x182B358F0")]
				internal bool GMWIVNDNVIS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2B35800", Offset = "0x2B34C00", VA = "0x182B35800")]
				internal string GLWAJFIBADZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2B35790", Offset = "0x2B34B90", VA = "0x182B35790")]
				internal void GLQTLYODQSQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2B39550", Offset = "0x2B38950", VA = "0x182B39550")]
				internal bool ZMUYOPDDHYK(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2B395A0", Offset = "0x2B389A0", VA = "0x182B395A0")]
				internal bool ZNAFLVXARJT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2B394B0", Offset = "0x2B388B0", VA = "0x182B394B0")]
				internal bool ZMKKUBPIPBS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2B39500", Offset = "0x2B38900", VA = "0x182B39500")]
				internal bool ZMPRRIJFYNB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2B39690", Offset = "0x2B38A90", VA = "0x182B39690")]
				internal string ZNQADQESTRU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2B396E0", Offset = "0x2B38AE0", VA = "0x182B396E0")]
				internal void ZNVHAWYQDDD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x2B395F0", Offset = "0x2B389F0", VA = "0x182B395F0")]
				internal bool ZNFMJCQYAVC(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2B39640", Offset = "0x2B38A40", VA = "0x182B39640")]
				internal bool ZNKTGJKVKGL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2B39410", Offset = "0x2B38810", VA = "0x182B39410")]
				internal bool ZLEVKMZYKLQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B39460", Offset = "0x2B38860", VA = "0x182B39460")]
				internal bool ZLKCHTTVTWZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B37460", Offset = "0x2B36860", VA = "0x182B37460")]
				internal string OWJJDAJIREO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B374B0", Offset = "0x2B368B0", VA = "0x182B374B0")]
				internal void OWOQAHDGAPX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2B37410", Offset = "0x2B36810", VA = "0x182B37410")]
				internal bool OWECFTPLHTF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2B37370", Offset = "0x2B36770", VA = "0x182B37370")]
				internal bool OVOHNZHTFLE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2B373C0", Offset = "0x2B367C0", VA = "0x182B373C0")]
				internal bool OVTOLGBQOWN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2B372B0", Offset = "0x2B366B0", VA = "0x182B372B0")]
				internal string OVDTTLTYMOM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2B37300", Offset = "0x2B36700", VA = "0x182B37300")]
				internal void OVJAQSNVVZV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2B37210", Offset = "0x2B36610", VA = "0x182B37210")]
				internal bool OUTFYYGDTRU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B37260", Offset = "0x2B36660", VA = "0x182B37260")]
				internal bool OUYMWFABDDD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B383C0", Offset = "0x2B377C0", VA = "0x182B383C0")]
				internal bool VQOBLKERQXV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x2B38370", Offset = "0x2B37770", VA = "0x182B38370")]
				internal string VQIUODKUHMM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x2B38460", Offset = "0x2B37860", VA = "0x182B38460")]
				internal void VQYPFXSMJUN(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2B38410", Offset = "0x2B37810", VA = "0x182B38410")]
				internal bool VQTIIQYPAJE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2B38520", Offset = "0x2B37920", VA = "0x182B38520")]
				internal bool VRJDALGHCRF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2B384D0", Offset = "0x2B378D0", VA = "0x182B384D0")]
				internal bool VRDWDEMJTFW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B385E0", Offset = "0x2B379E0", VA = "0x182B385E0")]
				internal string VRTQUYUBVNX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B38570", Offset = "0x2B37970", VA = "0x182B38570")]
				internal void VROJXSAEMCO(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B38630", Offset = "0x2B37A30", VA = "0x182B38630")]
				internal bool VRYXSFNZEZG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B2EE10", Offset = "0x2B2E210", VA = "0x182B2EE10")]
				internal bool AVAZFPTDLTW(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B37870", Offset = "0x2B36C70", VA = "0x182B37870")]
				internal float PSFDZRQEHHW()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B37910", Offset = "0x2B36D10", VA = "0x182B37910")]
				internal void PSKKWYKBQTF(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B37A60", Offset = "0x2B36E60", VA = "0x182B37A60")]
				internal bool PTKTJGFOLXY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B37AB0", Offset = "0x2B36EB0", VA = "0x182B37AB0")]
				internal bool PTQAGMZLVJH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B379C0", Offset = "0x2B36DC0", VA = "0x182B379C0")]
				internal bool PTAFOSRTTBG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B37A10", Offset = "0x2B36E10", VA = "0x182B37A10")]
				internal int PTFMLZLRCMP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B37660", Offset = "0x2B36A60", VA = "0x182B37660")]
				internal void PQZOQDAUCRU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B37710", Offset = "0x2B36B10", VA = "0x182B37710")]
				internal bool PREVNJURMDD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B389C0", Offset = "0x2B37DC0", VA = "0x182B389C0")]
				internal bool WTGWSXMBPWX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B38920", Offset = "0x2B37D20", VA = "0x182B38920")]
				internal bool WTBPVQSEGLO()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			[CompilerGenerated]
			private sealed class VULYRERAVCR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public string AUDDCWNIPKW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public VUGRTXXDLRI IYWFXXOWUJJ;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public VULYRERAVCR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B520E0", Offset = "0x2B514E0", VA = "0x182B520E0")]
				internal void NKSUUHDKTAB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class VTWDZKJISUQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public char[] UHRTHVLQAVD;

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public VTWDZKJISUQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B51D80", Offset = "0x2B51180", VA = "0x182B51D80")]
				internal bool PSUYRLXWJPX(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly PrimitivePortGroupModifiers FXSONWLVFPK;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FF20", Offset = "0x2B1F320", VA = "0x182B1FF20")]
			public PLAHNVNGGHM(SCQFSPRNDPD a, OBMIDMPQAOH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B1E3B0", Offset = "0x2B1D7B0", VA = "0x182B1E3B0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public sealed class MRJGVMFOLDN : OGPTWGQRVAK<ConstantAiFunctionNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			protected override bool HJWQOLTFRYK
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B40E30", Offset = "0x2B40230", VA = "0x182B40E30")]
			public MRJGVMFOLDN(SCQFSPRNDPD a, ConstantAiFunctionNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B40B80", Offset = "0x2B3FF80", VA = "0x182B40B80", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B40580", Offset = "0x2B3F980", VA = "0x182B40580")]
			private static string FVBNVMFCRLF(ConstantAiFunctionNode a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B40720", Offset = "0x2B3FB20", VA = "0x182B40720")]
			[CompilerGenerated]
			private object? VFAJPCSMDUA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B407C0", Offset = "0x2B3FBC0", VA = "0x182B407C0")]
			[CompilerGenerated]
			private void VFFQMJMJNFJ(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B408D0", Offset = "0x2B3FCD0", VA = "0x182B408D0")]
			[CompilerGenerated]
			private string VFKXJQGGWQS(object? id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B40AE0", Offset = "0x2B3FEE0", VA = "0x182B40AE0")]
			[CompilerGenerated]
			private IReadOnlyList<object> VFQEGXAEGCB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B40680", Offset = "0x2B3FA80", VA = "0x182B40680")]
			[CompilerGenerated]
			private string? VEFIABQWSAQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B406E0", Offset = "0x2B3FAE0", VA = "0x182B406E0")]
			[CompilerGenerated]
			private bool VEKOXIKUBLZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public sealed class JASMZWAUUWF : OGPTWGQRVAK<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class JZPSQTWWHKR
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
					public JZPSQTWWHKR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000183")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000184")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000185")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000300")]
					[Cpp2IlInjected.Address(RVA = "0x2B50160", Offset = "0x2B4F560", VA = "0x182B50160", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000301")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public JASMZWAUUWF IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public JZPSQTWWHKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D2C0", Offset = "0x2B3C6C0", VA = "0x182B3D2C0")]
				internal string ZKVYMHBLGQU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D490", Offset = "0x2B3C890", VA = "0x182B3D490")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void ZLBFJNVIQCD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DA40", Offset = "0x2B3CE40", VA = "0x182B3DA40")]
				internal int ZLGMGUPFZNM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DC30", Offset = "0x2B3D030", VA = "0x182B3DC30")]
				internal void ZLLTEBJDIYV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C070", Offset = "0x2B3B470", VA = "0x182B3C070")]
			public JASMZWAUUWF(SCQFSPRNDPD a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BD40", Offset = "0x2B3B140", VA = "0x182B3BD40", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public sealed class WQYHZCIIJPQ : OGPTWGQRVAK<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000079")]
			[CompilerGenerated]
			private sealed class EZWOGTCCREE
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
					public EZWOGTCCREE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400018B")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2B50470", Offset = "0x2B4F870", VA = "0x182B50470", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public EZWOGTCCREE <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000191")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000192")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x4000193")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000317")]
					[Cpp2IlInjected.Address(RVA = "0x2B50A50", Offset = "0x2B4FE50", VA = "0x182B50A50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000318")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public WQYHZCIIJPQ IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public EZWOGTCCREE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B480", Offset = "0x2B3A880", VA = "0x182B3B480")]
				internal string ZKVYMHBLGQU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B4D0", Offset = "0x2B3A8D0", VA = "0x182B3B4D0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void ZLBFJNVIQCD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B5A0", Offset = "0x2B3A9A0", VA = "0x182B3B5A0")]
				internal int ZLGMGUPFZNM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B5F0", Offset = "0x2B3A9F0", VA = "0x182B3B5F0")]
				internal Task<bool> ZLLTEBJDIYV(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B280", Offset = "0x2B3A680", VA = "0x182B3B280")]
				internal string ZKAWXFZVUXK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B2D0", Offset = "0x2B3A6D0", VA = "0x182B3B2D0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void ZKGDUMTTEIT(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B3A0", Offset = "0x2B3A7A0", VA = "0x182B3B3A0")]
				internal bool ZKLKRTNQNUC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B3F0", Offset = "0x2B3A7F0", VA = "0x182B3B3F0")]
				internal void ZKQRPAHNXFL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B1A0", Offset = "0x2B3A5A0", VA = "0x182B3B1A0")]
				internal bool ZJFVIEYGJEA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B1F0", Offset = "0x2B3A5F0", VA = "0x182B3B1F0")]
				internal void ZJLCFLSDSPJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B110", Offset = "0x2B3A510", VA = "0x182B3B110")]
				internal float HGCRPMWBCWJ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B080", Offset = "0x2B3A480", VA = "0x182B3B080")]
				internal void HFXKSGCDTLA(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B020", Offset = "0x2B3A420", VA = "0x182B3B020")]
				internal int HFSDUZIGJZR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AF80", Offset = "0x2B3A380", VA = "0x182B3AF80")]
				internal void HFMWXSOJAOI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AF10", Offset = "0x2B3A310", VA = "0x182B3AF10")]
				internal bool HFHQALULRCZ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2B54720", Offset = "0x2B53B20", VA = "0x182B54720")]
			public WQYHZCIIJPQ(SCQFSPRNDPD a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x2B53DC0", Offset = "0x2B531C0", VA = "0x182B53DC0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public sealed class HPKAJWDUPHX : OGPTWGQRVAK<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			[CompilerGenerated]
			private sealed class JZPSQTWWHKR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public HPKAJWDUPHX IRZLODQIRHI;

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public JZPSQTWWHKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D220", Offset = "0x2B3C620", VA = "0x182B3D220")]
				internal Dictionary<string, EnumChoiceData> ZKVYMHBLGQU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D600", Offset = "0x2B3CA00", VA = "0x182B3D600")]
				internal int ZLBFJNVIQCD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D770", Offset = "0x2B3CB70", VA = "0x182B3D770")]
				internal void ZLGMGUPFZNM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DCC0", Offset = "0x2B3D0C0", VA = "0x182B3DCC0")]
				internal bool ZLLTEBJDIYV()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BBC0", Offset = "0x2B3AFC0", VA = "0x182B3BBC0")]
			public HPKAJWDUPHX(SCQFSPRNDPD a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B910", Offset = "0x2B3AD10", VA = "0x182B3B910", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class ZQZKPXDFPJK : OGPTWGQRVAK<QPPBERBOYIJ>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class JZPSQTWWHKR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public ZQZKPXDFPJK IRZLODQIRHI;

				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public JZPSQTWWHKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D110", Offset = "0x2B3C510", VA = "0x182B3D110")]
				internal void ZKVYMHBLGQU()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2B555C0", Offset = "0x2B549C0", VA = "0x182B555C0")]
			public ZQZKPXDFPJK(SCQFSPRNDPD a, QPPBERBOYIJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x2B55440", Offset = "0x2B54840", VA = "0x182B55440", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public class LHVIVJBUFVY<a> : MVDYZVCXMTP<a> where a : notnull, SFFXRPYFSMW
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override YAPLSWVVQAZ? AECCJWIVJTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x689AC80", Offset = "0x689A080", VA = "0x18689AC80", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x689ACE0", Offset = "0x689A0E0", VA = "0x18689ACE0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xF37950", Offset = "0xF36D50", VA = "0x180F37950", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x689ACC0", Offset = "0x689A0C0", VA = "0x18689ACC0")]
			public LHVIVJBUFVY(SCQFSPRNDPD a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class XOEYMBLJLZM : LHVIVJBUFVY<ADKNULQXEWP>
		{
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			[CompilerGenerated]
			private sealed class VUGRTXXDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public XOEYMBLJLZM IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public VUGRTXXDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2B51DF0", Offset = "0x2B511F0", VA = "0x182B51DF0")]
				internal object ZKVYMHBLGQU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x2B51E50", Offset = "0x2B51250", VA = "0x182B51E50")]
				internal void ZLBFJNVIQCD(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x2B51FF0", Offset = "0x2B513F0", VA = "0x182B51FF0")]
				internal void ZLGMGUPFZNM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private static object[]? OASTQISFFFG;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2B54E40", Offset = "0x2B54240", VA = "0x182B54E40")]
			public XOEYMBLJLZM(SCQFSPRNDPD a, ADKNULQXEWP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x2B548D0", Offset = "0x2B53CD0", VA = "0x182B548D0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public sealed class AGHFNMREVSN : OGPTWGQRVAK<QBBXWNXNPBY>
		{
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public AGHFNMREVSN IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				public List<Id32<KOCJWPCQAPD>> POYUQEFAJZR;

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0x2B3ED90", Offset = "0x2B3E190", VA = "0x182B3ED90")]
				internal int ZLBFJNVIQCD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F210", Offset = "0x2B3E610", VA = "0x182B3F210")]
				internal void ZLGMGUPFZNM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000086")]
			[CompilerGenerated]
			private sealed class KCYUNBAGLIY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				public Id32<KOCJWPCQAPD> AJQPQKCXXMF;

				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KCYUNBAGLIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600033B")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DE40", Offset = "0x2B3D240", VA = "0x182B3DE40")]
				internal bool ZKAWXFZVUXK(Id32<KOCJWPCQAPD> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A1B0", Offset = "0x2B395B0", VA = "0x182B3A1B0")]
			public AGHFNMREVSN(SCQFSPRNDPD a, QBBXWNXNPBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x2B39CA0", Offset = "0x2B390A0", VA = "0x182B39CA0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private sealed class QCGKXGEWIGZ : OGPTWGQRVAK<UZOCHGQWWZU>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0xD25F90", Offset = "0xD25390", VA = "0x180D25F90", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x2B48D20", Offset = "0x2B48120", VA = "0x182B48D20")]
			public QCGKXGEWIGZ(SCQFSPRNDPD a, UZOCHGQWWZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class BZTAQIKXQBI : OGPTWGQRVAK<AYYXFSNSHLJ>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0xD63AE0", Offset = "0xD62EE0", VA = "0x180D63AE0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A810", Offset = "0x2B39C10", VA = "0x182B3A810")]
			public BZTAQIKXQBI(SCQFSPRNDPD a, AYYXFSNSHLJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "134")]
			protected override bool NUBOTBLNDMW(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class TPOYCWRRHWW : OGPTWGQRVAK<JXCOOEJQQFN>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000344")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A9D0", Offset = "0x2B49DD0", VA = "0x182B4A9D0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			protected override bool HJWQOLTFRYK
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A960", Offset = "0x2B49D60", VA = "0x182B4A960")]
			public TPOYCWRRHWW(SCQFSPRNDPD a, JXCOOEJQQFN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class QXPJHQJSIEW : OGPTWGQRVAK<PUUMQFAHNFZ>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x2B49CD0", Offset = "0x2B490D0", VA = "0x182B49CD0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool HJWQOLTFRYK
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2B49C60", Offset = "0x2B49060", VA = "0x182B49C60")]
			public QXPJHQJSIEW(SCQFSPRNDPD a, PUUMQFAHNFZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public sealed class UFDVBJZNNZZ : NZPZDBFTJKC<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				public UFDVBJZNNZZ IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E170", Offset = "0x2B3D570", VA = "0x182B3E170")]
				internal float TNPRKDKTDQZ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DF80", Offset = "0x2B3D380", VA = "0x182B3DF80")]
				internal void TNKKMWQVUFQ(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x2B516A0", Offset = "0x2B50AA0", VA = "0x182B516A0")]
			public UFDVBJZNNZZ(SCQFSPRNDPD a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x2B51430", Offset = "0x2B50830", VA = "0x182B51430", Slot = "151")]
			protected override void QMEBRNYBNGN(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private sealed class CVPKGPTNZDO : OGPTWGQRVAK<PFLSOMSONTX>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A8E0", Offset = "0x2B39CE0", VA = "0x182B3A8E0")]
			public CVPKGPTNZDO(SCQFSPRNDPD a, PFLSOMSONTX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private sealed class XHUSYZUINUA : OGPTWGQRVAK<SPWLMOMLKXH>
		{
			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2B54860", Offset = "0x2B53C60", VA = "0x182B54860")]
			public XHUSYZUINUA(SCQFSPRNDPD a, SPWLMOMLKXH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class QUMYBIAGJHT : OGPTWGQRVAK<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				public QUMYBIAGJHT IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E5A0", Offset = "0x2B3D9A0", VA = "0x182B3E5A0")]
				internal bool ZKVYMHBLGQU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E7B0", Offset = "0x2B3DBB0", VA = "0x182B3E7B0")]
				internal void ZLBFJNVIQCD(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x2B49BF0", Offset = "0x2B48FF0", VA = "0x182B49BF0")]
			public QUMYBIAGJHT(SCQFSPRNDPD a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x2B49960", Offset = "0x2B48D60", VA = "0x182B49960", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public sealed class OUZBXMFFNZL : OGPTWGQRVAK<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public OUZBXMFFNZL IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				public Predicate<Guid> FXBSDGWGMYK;

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E5F0", Offset = "0x2B3D9F0", VA = "0x182B3E5F0")]
				internal object? ZKVYMHBLGQU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E3E0", Offset = "0x2B3D7E0", VA = "0x182B3E3E0")]
				internal bool ZKQRPAHNXFL(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2B3EAB0", Offset = "0x2B3DEB0", VA = "0x182B3EAB0")]
				internal void ZLBFJNVIQCD(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F0C0", Offset = "0x2B3E4C0", VA = "0x182B3F0C0")]
				internal string ZLGMGUPFZNM(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2B3F370", Offset = "0x2B3E770", VA = "0x182B3F370")]
				internal IReadOnlyList<object> ZLLTEBJDIYV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E1F0", Offset = "0x2B3D5F0", VA = "0x182B3E1F0")]
				internal bool ZKAWXFZVUXK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E260", Offset = "0x2B3D660", VA = "0x182B3E260")]
				internal bool ZKGDUMTTEIT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E2B0", Offset = "0x2B3D6B0", VA = "0x182B3E2B0")]
				internal void ZKLKRTNQNUC(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2B46D00", Offset = "0x2B46100", VA = "0x182B46D00")]
			public OUZBXMFFNZL(SCQFSPRNDPD a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2B46610", Offset = "0x2B45A10", VA = "0x182B46610", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public sealed class QIBLIWVHRUP : OGPTWGQRVAK<ZJIXINRRBAA>
		{
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			[CompilerGenerated]
			private sealed class EZWOGTCCREE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				public int GPDJOMJKPQR;

				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public EZWOGTCCREE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3B160", Offset = "0x2B3A560", VA = "0x182B3B160")]
				internal bool JAYSOLQFUIV(KeyValuePair<string, EnumChoiceData> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000095")]
			[CompilerGenerated]
			private sealed class ZMZGDOYHPIH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				public QIBLIWVHRUP IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				public Dictionary<string, EnumChoiceData> VQVHGVSCXCN;

				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public ZMZGDOYHPIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0x2B551D0", Offset = "0x2B545D0", VA = "0x182B551D0")]
				internal int ZKVYMHBLGQU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0x2B55270", Offset = "0x2B54670", VA = "0x182B55270")]
				internal void ZLBFJNVIQCD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0x2B55390", Offset = "0x2B54790", VA = "0x182B55390")]
				internal string? ZLGMGUPFZNM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000369")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2B494D0", Offset = "0x2B488D0", VA = "0x182B494D0")]
			public QIBLIWVHRUP(SCQFSPRNDPD a, ZJIXINRRBAA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2B48FD0", Offset = "0x2B483D0", VA = "0x182B48FD0")]
			private int DNJHMEFJORH(Dictionary<string, EnumChoiceData> a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x2B493B0", Offset = "0x2B487B0", VA = "0x182B493B0")]
			private void ZZKBJYCJBTL(Dictionary<string, EnumChoiceData> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2B49060", Offset = "0x2B48460", VA = "0x182B49060", Slot = "145")]
			protected sealed override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public sealed class CRNPAGOFJMQ : GMYHKEOQUKE<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0xF33570", Offset = "0xF32970", VA = "0x180F33570", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A880", Offset = "0x2B39C80", VA = "0x182B3A880")]
			public CRNPAGOFJMQ(SCQFSPRNDPD a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class XVVIVZGZMNE : NZPZDBFTJKC<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				public XVVIVZGZMNE IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E020", Offset = "0x2B3D420", VA = "0x182B3E020")]
				internal int TNPRKDKTDQZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DEE0", Offset = "0x2B3D2E0", VA = "0x182B3DEE0")]
				internal void TNKKMWQVUFQ(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2B55110", Offset = "0x2B54510", VA = "0x182B55110")]
			public XVVIVZGZMNE(SCQFSPRNDPD a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2B54EA0", Offset = "0x2B542A0", VA = "0x182B54EA0", Slot = "151")]
			protected override void QMEBRNYBNGN(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class BNARVACFZAY : OGPTWGQRVAK<LZDRXVHVTGV>
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				public BNARVACFZAY IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				public List<Id32<KOCJWPCQAPD>> POYUQEFAJZR;

				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000381")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E8E0", Offset = "0x2B3DCE0", VA = "0x182B3E8E0")]
				internal int ZLBFJNVIQCD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000382")]
				[Cpp2IlInjected.Address(RVA = "0x2B3EF60", Offset = "0x2B3E360", VA = "0x182B3EF60")]
				internal void ZLGMGUPFZNM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200009C")]
			[CompilerGenerated]
			private sealed class KCYUNBAGLIY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				public Id32<KOCJWPCQAPD> AJQPQKCXXMF;

				[Cpp2IlInjected.Token(Token = "0x6000383")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KCYUNBAGLIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DE90", Offset = "0x2B3D290", VA = "0x182B3DE90")]
				internal bool ZKAWXFZVUXK(Id32<KOCJWPCQAPD> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A730", Offset = "0x2B39B30", VA = "0x182B3A730")]
			public BNARVACFZAY(SCQFSPRNDPD a, LZDRXVHVTGV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A220", Offset = "0x2B39620", VA = "0x182B3A220", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public sealed class PQFJGFOTYLA : OGPTWGQRVAK<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public PQFJGFOTYLA IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000388")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E550", Offset = "0x2B3D950", VA = "0x182B3E550")]
				internal bool ZKVYMHBLGQU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x2B3ED00", Offset = "0x2B3E100", VA = "0x182B3ED00")]
				internal void ZLBFJNVIQCD(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2B48CB0", Offset = "0x2B480B0", VA = "0x182B48CB0")]
			public PQFJGFOTYLA(SCQFSPRNDPD a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2B48AE0", Offset = "0x2B47EE0", VA = "0x182B48AE0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class EAWNDJSDAEW : OGPTWGQRVAK<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public EAWNDJSDAEW IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E500", Offset = "0x2B3D900", VA = "0x182B3E500")]
				internal bool ZKVYMHBLGQU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E720", Offset = "0x2B3DB20", VA = "0x182B3E720")]
				internal void ZLBFJNVIQCD(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x2B3AB20", Offset = "0x2B39F20", VA = "0x182B3AB20")]
			public EAWNDJSDAEW(SCQFSPRNDPD a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A950", Offset = "0x2B39D50", VA = "0x182B3A950", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public sealed class NQUNRMJKFBG : OGPTWGQRVAK<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				public NQUNRMJKFBG IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000392")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E460", Offset = "0x2B3D860", VA = "0x182B3E460")]
				internal int ZKVYMHBLGQU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000393")]
				[Cpp2IlInjected.Address(RVA = "0x2B3EED0", Offset = "0x2B3E2D0", VA = "0x182B3EED0")]
				internal void ZLBFJNVIQCD(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x2B46540", Offset = "0x2B45940", VA = "0x182B46540")]
			public NQUNRMJKFBG(SCQFSPRNDPD a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x2B462F0", Offset = "0x2B456F0", VA = "0x182B462F0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class FFHULZDYGZF
		{
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly Log GLGEGNAUXIQ;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public abstract class NPBYGRAVDAY<a> : OGPTWGQRVAK<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			[CompilerGenerated]
			private sealed class ORXATKMALZB
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
					public ORXATKMALZB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001CD")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003C8")]
					[Cpp2IlInjected.Address(RVA = "0x41BEDA0", Offset = "0x41BE1A0", VA = "0x1841BEDA0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003C9")]
					[Cpp2IlInjected.Address(RVA = "0x41BF0E0", Offset = "0x41BE4E0", VA = "0x1841BF0E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public CV2SetMessageNodeMessageNamePayload ISLWGBJQCFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public NPBYGRAVDAY<a> IRZLODQIRHI;

				[Cpp2IlInjected.Token(Token = "0x60003C5")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public ORXATKMALZB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x734E890", Offset = "0x734DC90", VA = "0x18734E890")]
				[AsyncStateMachine(typeof(NPBYGRAVDAY<>.ORXATKMALZB.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task UFJSDWSRDNC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0x734E770", Offset = "0x734DB70", VA = "0x18734E770")]
				internal void DFCSNIPPRNN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A8")]
			[CompilerGenerated]
			private sealed class PXTERHYESHH
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
					public PXTERHYESHH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DB")]
					[Cpp2IlInjected.Address(RVA = "0x41D3D90", Offset = "0x41D3190", VA = "0x1841D3D90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DC")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public PXTERHYESHH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003DD")]
					[Cpp2IlInjected.Address(RVA = "0x41D54B0", Offset = "0x41D48B0", VA = "0x1841D54B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003DE")]
					[Cpp2IlInjected.Address(RVA = "0x41D5BB0", Offset = "0x41D4FB0", VA = "0x1841D5BB0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public FXXMCEYJLNJ.ADZQKKYSPMR MHFBTGKZLOW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public string OBFITKIYQAX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public string QZDLPSFJEKN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public NPBYGRAVDAY<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public ConfigMenuStringPurificationHelper SDVHMPHKRAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public bool XLRUTUPZJZR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				public Action UDAYGNQSSPP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				public bool GQYWSNTDSHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				public string CCCUFYMRFBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public Action BBYXLKIPWPN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public Action UYYXKSELDYP;

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public PXTERHYESHH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x7469AB0", Offset = "0x7468EB0", VA = "0x187469AB0")]
				internal void LKNUCUYJFAA(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x7469B00", Offset = "0x7468F00", VA = "0x187469B00")]
				internal void LKTBABSGOLJ(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
				internal string VPJQJFHORPN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x7469F00", Offset = "0x7469300", VA = "0x187469F00")]
				internal void VPEJLYNRIEE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0x730B230", Offset = "0x730A630", VA = "0x18730B230")]
				internal bool VPUEDSVJKMF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D0")]
				[Cpp2IlInjected.Address(RVA = "0x746A0E0", Offset = "0x74694E0", VA = "0x18746A0E0")]
				internal char VPOXGMBMBAW((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D1")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
				internal string? VOOOUEFZFWD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0xF30DF0", Offset = "0xF301F0", VA = "0x180F30DF0")]
				internal bool VOJHWXMBWKU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x7469E40", Offset = "0x7469240", VA = "0x187469E40")]
				internal void VOZCORTTYSV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x730B230", Offset = "0x730A630", VA = "0x18730B230")]
				internal bool VOTVRKZWPHM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x7469DA0", Offset = "0x74691A0", VA = "0x187469DA0")]
				[AsyncStateMachine(typeof(NPBYGRAVDAY<>.PXTERHYESHH.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void VNTNFDEJUCT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x746A180", Offset = "0x7469580", VA = "0x18746A180")]
				internal void ZOWHGMVIZVT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x7469C90", Offset = "0x7469090", VA = "0x187469C90")]
				[AsyncStateMachine(typeof(NPBYGRAVDAY<>.PXTERHYESHH.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task NRZSDBDJFMS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x7469B70", Offset = "0x7468F70", VA = "0x187469B70")]
				internal void LMJEEDVLLYD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x74699F0", Offset = "0x7468DF0", VA = "0x1874699F0")]
				internal void FMPKLPXQOGT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x7469D60", Offset = "0x7469160", VA = "0x187469D60")]
				internal bool VNOGHWKMKRK()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class LEHILDGQMIQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public MessageParameter WJQODTVDLMF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public NPBYGRAVDAY<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public Action<FXXMCEYJLNJ.RWQXECADWMJ> BDJTSFRXKQY;

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public LEHILDGQMIQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x6893670", Offset = "0x6892A70", VA = "0x186893670")]
				internal bool NUQDOFIFEGY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x68936B0", Offset = "0x6892AB0", VA = "0x1868936B0")]
				internal void OHCTWKEZBXO(FXXMCEYJLNJ.RWQXECADWMJ a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			[CompilerGenerated]
			private sealed class LEMPIKANVTZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public bool NSVYKKVQRPF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public SHJCWUUMGGW BPGEFLWRELL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public SHJCWUUMGGW LOZMLDOOEEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public SHJCWUUMGGW TGLYRXWJSVT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public string YJVMOSOZWJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public LEHILDGQMIQ IYWFXXOWUJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public Action FUFZPQDRKVO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public Action BDZOJZZPMYZ;

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public LEMPIKANVTZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0xF58E80", Offset = "0xF58280", VA = "0x180F58E80")]
				internal bool QMZAPETCBKM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x6893A10", Offset = "0x6892E10", VA = "0x186893A10")]
				internal void LAULJECBXCN(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x6894540", Offset = "0x6893940", VA = "0x186894540")]
				internal void NVFYFZPXGOZ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x6894990", Offset = "0x6893D90", VA = "0x186894990")]
				internal void NVLFDGJUQAI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x6893B10", Offset = "0x6892F10", VA = "0x186893B10")]
				internal void NUFPTRUKLKG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E8")]
				[Cpp2IlInjected.Address(RVA = "0x6893F00", Offset = "0x6893300", VA = "0x186893F00")]
				internal void NUVKLMCCNSH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x6894990", Offset = "0x6893D90", VA = "0x186894990")]
				internal void OHSOOEMREFP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class LERWFQULFFI
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
					public LERWFQULFFI <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003ED")]
					[Cpp2IlInjected.Address(RVA = "0x41EA5B0", Offset = "0x41E99B0", VA = "0x1841EA5B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EE")]
					[Cpp2IlInjected.Address(RVA = "0x41EABE0", Offset = "0x41E9FE0", VA = "0x1841EABE0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				public bool PBBCXWXIUEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				public LEMPIKANVTZ IZBMVEIUDUS;

				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public LERWFQULFFI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x6894C20", Offset = "0x6894020", VA = "0x186894C20")]
				[AsyncStateMachine(typeof(NPBYGRAVDAY<>.LERWFQULFFI.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task RAQXDTFBCXZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0x6894BB0", Offset = "0x6893FB0", VA = "0x186894BB0")]
				internal void NVQMANDRZLR()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AF")]
			[CompilerGenerated]
			private sealed class LEXDCXOIOQR
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
					public LEXDCXOIOQR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F7")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F2")]
					[Cpp2IlInjected.Address(RVA = "0x41E9FB0", Offset = "0x41E93B0", VA = "0x1841E9FB0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003F3")]
					[Cpp2IlInjected.Address(RVA = "0x41EA550", Offset = "0x41E9950", VA = "0x1841EA550", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public CV2ManageMessageParameterPayload UTFATXPEKXU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public LEMPIKANVTZ IZGTSLCRNGB;

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public LEXDCXOIOQR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F0")]
				[Cpp2IlInjected.Address(RVA = "0x6894CF0", Offset = "0x68940F0", VA = "0x186894CF0")]
				[AsyncStateMachine(typeof(NPBYGRAVDAY<>.LEXDCXOIOQR.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task CTCXDZQISNU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0x6894DC0", Offset = "0x68941C0", VA = "0x186894DC0")]
				internal void OHNHQXSTUUG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class GVRQYAQNAEB
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
					public GVRQYAQNAEB <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FE")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003F9")]
					[Cpp2IlInjected.Address(RVA = "0x41E9AD0", Offset = "0x41E8ED0", VA = "0x1841E9AD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003FA")]
					[Cpp2IlInjected.Address(RVA = "0x41E9F50", Offset = "0x41E9350", VA = "0x1841E9F50", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				public NPBYGRAVDAY<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				public CV2ManageMessageParameterPayload ONDJXCNKEVM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				public FXXMCEYJLNJ.RWQXECADWMJ MHFBTGKZLOW;

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public GVRQYAQNAEB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x637EAD0", Offset = "0x637DED0", VA = "0x18637EAD0")]
				[AsyncStateMachine(typeof(NPBYGRAVDAY<>.GVRQYAQNAEB.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task YGRXRWPYCCA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x637E9F0", Offset = "0x637DDF0", VA = "0x18637E9F0")]
				internal bool GYUFZOHUMTE(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F7")]
				[Cpp2IlInjected.Address(RVA = "0x637E8D0", Offset = "0x637DCD0", VA = "0x18637E8D0")]
				internal void GYOZCHNXDHV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F8")]
				[Cpp2IlInjected.Address(RVA = "0x637E880", Offset = "0x637DC80", VA = "0x18637E880")]
				internal void GYJSFATZTWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class LHVRERDXZSG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				public string EWNJMITVJHH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				public SHJCWUUMGGW OMFBAPDIOUI;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public LHVRERDXZSG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0x689B6A0", Offset = "0x689AAA0", VA = "0x18689B6A0")]
				internal string? VSVTFEKGXLN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0xE8D450", Offset = "0xE8C850", VA = "0x180E8D450")]
				internal bool VSQMHXQJOAE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003FE")]
				[Cpp2IlInjected.Address(RVA = "0x689B6C0", Offset = "0x689AAC0", VA = "0x18689B6C0")]
				internal void VTGGZRYBQIF(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private bool PQOUDSFSEHY;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			protected static Log GLGEGNAUXIQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x71E64F0", Offset = "0x71E58F0", VA = "0x1871E64F0")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected override bool HJWQOLTFRYK
			{
				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000398")]
				[Cpp2IlInjected.Address(RVA = "0x71E8800", Offset = "0x71E7C00", VA = "0x1871E8800", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			protected FXXMCEYJLNJ ZBFCFCRKQIG
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0xCFF450", Offset = "0xCFE850", VA = "0x180CFF450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xCFF140", Offset = "0xCFE540", VA = "0x180CFF140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected Action<string?> TCKGECAJMNH
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0xDBA2B0", Offset = "0xDB96B0", VA = "0x180DBA2B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0x1106650", Offset = "0x1105A50", VA = "0x181106650")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected FXESZWXXPWT VFWSPVPARPS
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0xF65A30", Offset = "0xF64E30", VA = "0x180F65A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x1729A10", Offset = "0x1728E10", VA = "0x181729A10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected JIKSHYOTFUN VLOYPYAXAIC
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xF65A40", Offset = "0xF64E40", VA = "0x180F65A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x1728B80", Offset = "0x1727F80", VA = "0x181728B80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x71E87D0", Offset = "0x71E7BD0", VA = "0x1871E87D0")]
			protected NPBYGRAVDAY(SCQFSPRNDPD a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x71E4CD0", Offset = "0x71E40D0", VA = "0x1871E4CD0", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x71E4C80", Offset = "0x71E4080", VA = "0x1871E4C80", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x71E4D20", Offset = "0x71E4120", VA = "0x1871E4D20", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x71E6FE0", Offset = "0x71E63E0", VA = "0x1871E6FE0")]
			private void TCSAOYWGOFZ(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x71E8070", Offset = "0x71E7470", VA = "0x1871E8070", Slot = "145")]
			protected sealed override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x71E65B0", Offset = "0x71E59B0", VA = "0x1871E65B0")]
			private void NMPXVBDBZVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x71E5A20", Offset = "0x71E4E20", VA = "0x1871E5A20")]
			private void KFDBPLSKARR(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "151")]
			protected virtual void EKVCJHFMVXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x71E8630", Offset = "0x71E7A30", VA = "0x1871E8630")]
			private void XWFENKLJCZI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x71E4D70", Offset = "0x71E4170", VA = "0x1871E4D70")]
			private void HCOFSXOSJVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x71E72A0", Offset = "0x71E66A0", VA = "0x1871E72A0")]
			private void VGOJKIDMFMB(FXXMCEYJLNJ.RWQXECADWMJ a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x71E5820", Offset = "0x71E4C20", VA = "0x1871E5820")]
			private void IBWOGCGGHIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x71E4C50", Offset = "0x71E4050", VA = "0x1871E4C50")]
			protected void CGFRDMQUOFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x71E6540", Offset = "0x71E5940", VA = "0x1871E6540")]
			private void MMVSCDHKWZT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x71E82E0", Offset = "0x71E76E0", VA = "0x1871E82E0")]
			private void WAYNCISLXYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x71E8280", Offset = "0x71E7680", VA = "0x1871E8280")]
			private void VVSVLRTLWTK(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x71E6CE0", Offset = "0x71E60E0", VA = "0x1871E6CE0")]
			private string QEFZJZXGBSO((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x71E6C50", Offset = "0x71E6050", VA = "0x1871E6C50")]
			private string PPSHXAAWEHT(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x71E4C20", Offset = "0x71E4020", VA = "0x1871E4C20")]
			[CompilerGenerated]
			private object? BTPPLPRVLHT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x71E44C0", Offset = "0x71E38C0", VA = "0x1871E44C0")]
			[CompilerGenerated]
			private void BTKIOIXYBWK(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x71E4450", Offset = "0x71E3850", VA = "0x1871E4450")]
			[CompilerGenerated]
			private IReadOnlyList<object> BSZUTVKDIZS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x71E43C0", Offset = "0x71E37C0", VA = "0x1871E43C0")]
			[CompilerGenerated]
			private void BSUNWOQFZOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x71E4370", Offset = "0x71E3770", VA = "0x1871E4370")]
			[CompilerGenerated]
			private void BRUFKGUTEJQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x71E4330", Offset = "0x71E3730", VA = "0x1871E4330")]
			[CompilerGenerated]
			private void BCWVETNHUCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x71E8300", Offset = "0x71E7700", VA = "0x1871E8300")]
			[CompilerGenerated]
			private void WOCTXUQSNBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x71E6C10", Offset = "0x71E6010", VA = "0x1871E6C10")]
			[CompilerGenerated]
			private void NTXTVUJFDXL(FXXMCEYJLNJ.RWQXECADWMJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public class PFICSJNUYYT : NPBYGRAVDAY<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60003FF")]
				[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x2B46D70", Offset = "0x2B46170", VA = "0x182B46D70")]
			public PFICSJNUYYT(SCQFSPRNDPD a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class MKYQENSXJDN : NPBYGRAVDAY<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000061")]
				[CompilerGenerated]
				protected virtual Type HBEDCNLCPGQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0x2B4A100", Offset = "0x2B49500", VA = "0x182B4A100", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public MessageReceiverScope WEVULMAKRSR
				{
					[Cpp2IlInjected.Token(Token = "0x6000408")]
					[Cpp2IlInjected.Address(RVA = "0xCF3110", Offset = "0xCF2510", VA = "0x180CF3110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public string IHYPKZXHWRZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000409")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0x142E0B0", Offset = "0x142D4B0", VA = "0x18142E0B0")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A010", Offset = "0x2B49410", VA = "0x182B4A010", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A150", Offset = "0x2B49550", VA = "0x182B4A150", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool YCDCLASMFRG(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x2B49F00", Offset = "0x2B49300", VA = "0x182B49F00", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x2B49D20", Offset = "0x2B49120", VA = "0x182B49D20", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x2B49DB0", Offset = "0x2B491B0", VA = "0x182B49DB0", Slot = "7")]
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
				protected virtual Type HBEDCNLCPGQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000410")]
					[Cpp2IlInjected.Address(RVA = "0x2B4B440", Offset = "0x2B4A840", VA = "0x182B4B440", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public MessageTargetPlayers VFJBJVMKTJJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000411")]
					[Cpp2IlInjected.Address(RVA = "0xCF3110", Offset = "0xCF2510", VA = "0x180CF3110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public string IHYPKZXHWRZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000412")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0x142E0B0", Offset = "0x142D4B0", VA = "0x18142E0B0")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B350", Offset = "0x2B4A750", VA = "0x182B4B350", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000414")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B490", Offset = "0x2B4A890", VA = "0x182B4B490", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool YCDCLASMFRG(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B240", Offset = "0x2B4A640", VA = "0x182B4B240", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000416")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B1B0", Offset = "0x2B4A5B0", VA = "0x182B4B1B0", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B060", Offset = "0x2B4A460", VA = "0x182B4B060", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[CompilerGenerated]
			private sealed class JZPSQTWWHKR
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
					public JZPSQTWWHKR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000214")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000425")]
					[Cpp2IlInjected.Address(RVA = "0x2B4F440", Offset = "0x2B4E840", VA = "0x182B4F440", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000426")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public JZPSQTWWHKR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000427")]
					[Cpp2IlInjected.Address(RVA = "0x2B4F860", Offset = "0x2B4EC60", VA = "0x182B4F860", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000428")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				public MKYQENSXJDN IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public FXESZWXXPWT MTURFBYRNQC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public Func<ReceiverScopeSelection, bool> FULGMWXOUGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public Func<TargetPlayersSelection, bool> FUFZPQDRKVO;

				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public JZPSQTWWHKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CBA0", Offset = "0x2B3BFA0", VA = "0x182B3CBA0")]
				internal object? OXSGQHZXORK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C8D0", Offset = "0x2B3BCD0", VA = "0x182B3C8D0")]
				internal bool OWCDMFWSREQ(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CC80", Offset = "0x2B3C080", VA = "0x182B3CC80")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void OXXNNOTUYCT(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CD50", Offset = "0x2B3C150", VA = "0x182B3CD50")]
				internal IReadOnlyList<TargetPlayersSelection> TQAQBMVJDBM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C990", Offset = "0x2B3BD90", VA = "0x182B3C990")]
				internal object? OXCLYNSFMJJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C930", Offset = "0x2B3BD30", VA = "0x182B3C930")]
				internal bool OWHKJMQQAPZ(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CAD0", Offset = "0x2B3BED0", VA = "0x182B3CAD0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void OXHSVUMCVUS(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> UVSRZUUXVSW;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private static readonly IReadOnlyList<TargetPlayersSelection> DPZBFBMKOLO;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private static readonly IReadOnlyList<TargetPlayersSelection> TNGOCYQYBHG;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000401")]
				[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x2B40520", Offset = "0x2B3F920", VA = "0x182B40520")]
			public MKYQENSXJDN(SCQFSPRNDPD a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F960", Offset = "0x2B3ED60", VA = "0x182B3F960", Slot = "151")]
			protected override void EKVCJHFMVXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x2B3FEC0", Offset = "0x2B3F2C0", VA = "0x182B3FEC0")]
			private static IReadOnlyList<TargetPlayersSelection> QBIJCJCBGSR(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		public sealed class JWDAYECIOPK : UQINANQBUXD<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public override AudioClipType TVOEUJTLAXI
			{
				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C0E0", Offset = "0x2B3B4E0", VA = "0x182B3C0E0")]
			public JWDAYECIOPK(SCQFSPRNDPD a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class LXUTKHIBBGZ : OGPTWGQRVAK<SIDFNDXEBQO>
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F850", Offset = "0x2B3EC50", VA = "0x182B3F850")]
			public LXUTKHIBBGZ(SCQFSPRNDPD a, SIDFNDXEBQO b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public abstract class OGPTWGQRVAK<a> : FEGMTBIBNYX, IDisposable where a : notnull, SIDFNDXEBQO
		{
			[Cpp2IlInjected.Token(Token = "0x20000BF")]
			[CompilerGenerated]
			private sealed class NCLLTQFRZHV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public OGPTWGQRVAK<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public SCQFSPRNDPD LHQVSXKZPKF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public a CANSHDFJKQC;

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public NCLLTQFRZHV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0x71BAE50", Offset = "0x71BA250", VA = "0x1871BAE50")]
				internal MWYZLKDYPBY ZMCIATNYJML(HZIXAFMUVRH a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			[CompilerGenerated]
			private sealed class HIHPGDGCSYR
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
					public HIHPGDGCSYR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023F")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004BD")]
					[Cpp2IlInjected.Address(RVA = "0x41C18A0", Offset = "0x41C0CA0", VA = "0x1841C18A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004BE")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public string RXIPGMUEQXN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public Func<string, Result<string, SKKNIPYCQUO>> UTFCQBQURQE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public OGPTWGQRVAK<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public Func<string> NMDTQPGLZWM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public FXXMCEYJLNJ ZBFCFCRKQIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public Action<string> OQWIYEKBRBK;

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public HIHPGDGCSYR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				internal string IVQCSYUZRCN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
				internal void IVKVVSBCHRE(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x6416450", Offset = "0x6415850", VA = "0x186416450")]
				[AsyncStateMachine(typeof(OGPTWGQRVAK<>.HIHPGDGCSYR.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void IVFOYLHEYFV()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			[CompilerGenerated]
			private sealed class NFFSTDTYYDG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public NFFSTDTYYDG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x71BD6C0", Offset = "0x71BCAC0", VA = "0x1871BD6C0")]
				internal Result<string, SKKNIPYCQUO> BCNCWHMAABZ(string a)
				{
					return default(Result<string, SKKNIPYCQUO>);
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
				public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public OGPTWGQRVAK<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C1")]
				[Cpp2IlInjected.Address(RVA = "0x6BCBFF0", Offset = "0x6BCB3F0", VA = "0x186BCBFF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C2")]
				[Cpp2IlInjected.Address(RVA = "0x6BCC240", Offset = "0x6BCB640", VA = "0x186BCC240", Slot = "5")]
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
				public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public OGPTWGQRVAK<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004C3")]
				[Cpp2IlInjected.Address(RVA = "0x6BCC2B0", Offset = "0x6BCB6B0", VA = "0x186BCC2B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C4")]
				[Cpp2IlInjected.Address(RVA = "0x6BCC5B0", Offset = "0x6BCB9B0", VA = "0x186BCC5B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private readonly SCQFSPRNDPD AIEUPWPRETM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private readonly bool UKBHMCMKECS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private IdArray<IWTLBCZPUHH, MWYZLKDYPBY> PXZFLGLCSEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IdArray<IWTLBCZPUHH, AKNWFLPUDGH> EGSPOTCXLIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private List<Action> YBOOLSUEXIQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[CompilerGenerated]
			private Action<Id32<IWTLBCZPUHH>>? CKEABPBPWFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			[CompilerGenerated]
			private Action<Id32<IWTLBCZPUHH>, AKNWFLPUDGH>? RSAAFQTYOBL;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			protected UOXIAFFGFEM GTAENSCVUIX
			{
				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x7346000", Offset = "0x7345400", VA = "0x187346000")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected YCULPWATBNY YCULPWATBNY
			{
				[Cpp2IlInjected.Token(Token = "0x600042D")]
				[Cpp2IlInjected.Address(RVA = "0x7346230", Offset = "0x7345630", VA = "0x187346230")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected DLADXAUDIQZ KPNUUEOQDLS
			{
				[Cpp2IlInjected.Token(Token = "0x600042E")]
				[Cpp2IlInjected.Address(RVA = "0x7345880", Offset = "0x7344C80", VA = "0x187345880")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected a SIDFNDXEBQO
			{
				[Cpp2IlInjected.Token(Token = "0x6000432")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public Id128<VOUYFSSRGER> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0x1678900", Offset = "0x1677D00", VA = "0x181678900", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<VOUYFSSRGER>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id32<TUBDDYPKAKM> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000434")]
				[Cpp2IlInjected.Address(RVA = "0x7346E50", Offset = "0x7346250", VA = "0x187346E50", Slot = "6")]
				get
				{
					return default(Id32<TUBDDYPKAKM>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000435")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000436")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0x7346CC0", Offset = "0x73460C0", VA = "0x187346CC0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x7346CA0", Offset = "0x73460A0", VA = "0x187346CA0", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x7346FB0", Offset = "0x73463B0", VA = "0x187346FB0", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			protected virtual bool HJWQOLTFRYK
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public Id32<QJYZSAZIQYY> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600043D")]
				[Cpp2IlInjected.Address(RVA = "0xD6C420", Offset = "0xD6B820", VA = "0x180D6C420", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<QJYZSAZIQYY>);
				}
				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0xD6D6D0", Offset = "0xD6CAD0", VA = "0x180D6D6D0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0xD44C00", Offset = "0xD44000", VA = "0x180D44C00", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0x7346B70", Offset = "0x7345F70", VA = "0x187346B70", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x7346BA0", Offset = "0x7345FA0", VA = "0x187346BA0", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x7346BD0", Offset = "0x7345FD0", VA = "0x187346BD0", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x7346E30", Offset = "0x7346230", VA = "0x187346E30", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x7346D60", Offset = "0x7346160", VA = "0x187346D60", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x7346C40", Offset = "0x7346040", VA = "0x187346C40", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x7346C10", Offset = "0x7346010", VA = "0x187346C10", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0x10C9EA0", Offset = "0x10C92A0", VA = "0x1810C9EA0", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x180FD60", Offset = "0x180F160", VA = "0x18180FD60")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x7346C00", Offset = "0x7346000", VA = "0x187346C00", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x7346D10", Offset = "0x7346110", VA = "0x187346D10", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x7346DD0", Offset = "0x73461D0", VA = "0x187346DD0", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x7346E00", Offset = "0x7346200", VA = "0x187346E00", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000453")]
				[Cpp2IlInjected.Address(RVA = "0x7346D40", Offset = "0x7346140", VA = "0x187346D40", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual AFCBOTRJFZW? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual YAPLSWVVQAZ? AECCJWIVJTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual IEnumerable<Id128<IHXSJTKSKEJ>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x7346C70", Offset = "0x7346070", VA = "0x187346C70", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Id128<EVDWFGHNUCH> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x7346D80", Offset = "0x7346180", VA = "0x187346D80", Slot = "68")]
				get
				{
					return default(Id128<EVDWFGHNUCH>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id32<EVDWFGHNUCH> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x7346CE0", Offset = "0x73460E0", VA = "0x187346CE0", Slot = "59")]
				get
				{
					return default(Id32<EVDWFGHNUCH>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual Id32<EVDWFGHNUCH>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual Id32<EVDWFGHNUCH>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x7344B00", Offset = "0x7343F00", VA = "0x187344B00", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0xCF8190", Offset = "0xCF7590", VA = "0x180CF8190", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0xCF7A50", Offset = "0xCF6E50", VA = "0x180CF7A50")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000485")]
				[Cpp2IlInjected.Address(RVA = "0xCF7B70", Offset = "0xCF6F70", VA = "0x180CF7B70", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0xCF7B60", Offset = "0xCF6F60", VA = "0x180CF7B60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public Id32<IHXSJTKSKEJ> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x7346E90", Offset = "0x7346290", VA = "0x187346E90", Slot = "69")]
				get
				{
					return default(Id32<IHXSJTKSKEJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id128<IHXSJTKSKEJ> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x7346DB0", Offset = "0x73461B0", VA = "0x187346DB0", Slot = "70")]
				get
				{
					return default(Id128<IHXSJTKSKEJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<IHXSJTKSKEJ>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0x7346EB0", Offset = "0x73462B0", VA = "0x187346EB0", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public ReadOnlyIdArray<IWTLBCZPUHH, AKNWFLPUDGH> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x7346F70", Offset = "0x7346370", VA = "0x187346F70", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<IWTLBCZPUHH, AKNWFLPUDGH>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public virtual Id32<IWTLBCZPUHH>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action TZBBGTKJYPP
			{
				[Cpp2IlInjected.Token(Token = "0x600045A")]
				[Cpp2IlInjected.Address(RVA = "0x7344300", Offset = "0x7343700", VA = "0x187344300", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x7346190", Offset = "0x7345590", VA = "0x187346190", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate CAJFMBZHBUU
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x7343E60", Offset = "0x7343260", VA = "0x187343E60", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x7345970", Offset = "0x7344D70", VA = "0x187345970", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate RKPMUIMHJKP
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x7345530", Offset = "0x7344930", VA = "0x187345530", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x7343340", Offset = "0x7342740", VA = "0x187343340", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action TSXREKLLGAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x73456C0", Offset = "0x7344AC0", VA = "0x1873456C0", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0x7345A10", Offset = "0x7344E10", VA = "0x187345A10", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action ZLJUPNPULWW
			{
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0x7343DC0", Offset = "0x73431C0", VA = "0x187343DC0", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000464")]
				[Cpp2IlInjected.Address(RVA = "0x73443A0", Offset = "0x73437A0", VA = "0x1873443A0", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<IWTLBCZPUHH>, AKNWFLPUDGH> KQFEJBVVWOP
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x7345E00", Offset = "0x7345200", VA = "0x187345E00", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x7342850", Offset = "0x7341C50", VA = "0x187342850", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<IWTLBCZPUHH>, AKNWFLPUDGH> COQNKWZGNPA
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x7345770", Offset = "0x7344B70", VA = "0x187345770", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x7343D00", Offset = "0x7343100", VA = "0x187343D00", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<IWTLBCZPUHH>> KKPBUMRMYOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x7342690", Offset = "0x7341A90", VA = "0x187342690", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0x7344B40", Offset = "0x7343F40", VA = "0x187344B40", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<IWTLBCZPUHH>, Id32<IWTLBCZPUHH>> YGFGFCXBCDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0x7344600", Offset = "0x7343A00", VA = "0x187344600", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0x73460D0", Offset = "0x73454D0", VA = "0x1873460D0", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<IWTLBCZPUHH>, AKNWFLPUDGH> HZADFLOQPWD
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x73446C0", Offset = "0x7343AC0", VA = "0x1873446C0", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x7344840", Offset = "0x7343C40", VA = "0x187344840", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<IWTLBCZPUHH>, Id32<IWTLBCZPUHH>> EUWFPSXYERM
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x7345450", Offset = "0x7344850", VA = "0x187345450", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x7345390", Offset = "0x7344790", VA = "0x187345390", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> IOOEYQUOTOD
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x7344780", Offset = "0x7343B80", VA = "0x187344780", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x73455D0", Offset = "0x73449D0", VA = "0x1873455D0", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x7346700", Offset = "0x7345B00", VA = "0x187346700")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected OGPTWGQRVAK(SCQFSPRNDPD a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x73440A0", Offset = "0x73434A0", VA = "0x1873440A0", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x7342F50", Offset = "0x7342350", VA = "0x187342F50", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x7344440", Offset = "0x7343840", VA = "0x187344440", Slot = "9")]
			public Task<Result<None, SKKNIPYCQUO>> KTDGSQTXBCO(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x7344070", Offset = "0x7343470", VA = "0x187344070")]
			public bool IOZAENWRBRU([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x7342660", Offset = "0x7341A60", VA = "0x187342660")]
			public bool IPVPMRJUNMT([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x7344260", Offset = "0x7343660", VA = "0x187344260", Slot = "34")]
			public void JYAGWYRKGWT(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x7342750", Offset = "0x7341B50", VA = "0x187342750", Slot = "35")]
			public Task BUXCFNUADGL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x7346330", Offset = "0x7345730", VA = "0x187346330", Slot = "36")]
			[AsyncStateMachine(typeof(OGPTWGQRVAK<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, SKKNIPYCQUO>> XUZHNZSMHCW(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "119")]
			public virtual void CBTQRIPTHWV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x10984F0", Offset = "0x10978F0", VA = "0x1810984F0")]
			protected void TAPLEZIAICT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x214F1D0", Offset = "0x214E5D0", VA = "0x18214F1D0")]
			protected void LBZOAPTKZDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x212D320", Offset = "0x212C720", VA = "0x18212D320")]
			private void HQSIGUFUAWC([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x7344D20", Offset = "0x7344120", VA = "0x187344D20", Slot = "122")]
			public virtual Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> OCOLHTZIOQR(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x73434D0", Offset = "0x73428D0", VA = "0x1873434D0", Slot = "123")]
			public virtual Task<Result<None, SKKNIPYCQUO>> FMFWQQRQHYI(Id32<IWTLBCZPUHH> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "124")]
			public virtual void HCISHKPEQLO(Id32<IWTLBCZPUHH> sourceId, Id32<IWTLBCZPUHH> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x7345690", Offset = "0x7344A90", VA = "0x187345690", Slot = "125")]
			public virtual IEnumerable<PXBFMCKNGBK> QEFOOCZHEIL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x7342E80", Offset = "0x7342280", VA = "0x187342E80", Slot = "126")]
			public Result<None, SKKNIPYCQUO> DKSOKWRVYNY(string a)
			{
				return default(Result<None, SKKNIPYCQUO>);
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x7344DE0", Offset = "0x73441E0", VA = "0x187344DE0", Slot = "50")]
			public bool OJWPCPRGVXE([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x7346480", Offset = "0x7345880", VA = "0x187346480")]
			public bool ZPRUYEBDIBN([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "128")]
			public virtual void WCSMZJXFQQJ(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "129")]
			public virtual EBUYPFDQCOI SKCDEQPBDBD([In] XCHOONPXDOH audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x73444A0", Offset = "0x73438A0", VA = "0x1873444A0")]
			protected void KTZUDETDYPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x7344B00", Offset = "0x7343F00", VA = "0x187344B00", Slot = "134")]
			protected virtual bool NUBOTBLNDMW(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x73434A0", Offset = "0x73428A0", VA = "0x1873434A0", Slot = "96")]
			public bool FHOZFRHLOEU(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "135")]
			protected virtual bool BCTGWRHJJQB(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected virtual void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x7343590", Offset = "0x7342990", VA = "0x187343590")]
			protected void FQKUWMUWBBH(FXXMCEYJLNJ a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, SKKNIPYCQUO>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x7344900", Offset = "0x7343D00", VA = "0x187344900")]
			protected void NHJFWSQLDAD(FXXMCEYJLNJ a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x7345A90", Offset = "0x7344E90", VA = "0x187345A90", Slot = "146")]
			protected virtual void TBAAVHGHKZQ(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x7345830", Offset = "0x7344C30", VA = "0x187345830", Slot = "90")]
			public void RBZNTTTHLZB(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x7346060", Offset = "0x7345460", VA = "0x187346060", Slot = "91")]
			public CircuitsRigidTransform VWJKNUNYLWS()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "149")]
			public virtual bool WVWSDSIMVPC(Id32<IWTLBCZPUHH> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x7342910", Offset = "0x7341D10", VA = "0x187342910")]
			private void CVQHAMJZNMZ([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x73433E0", Offset = "0x73427E0", VA = "0x1873433E0")]
			private void FBMAVDFZZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x10984F0", Offset = "0x10978F0", VA = "0x1810984F0", Slot = "97")]
			private void AINYKBUERLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x7342930", Offset = "0x7341D30", VA = "0x187342930", Slot = "99")]
			private void DFYXZZHWHVE(Id32<IWTLBCZPUHH> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x4EA3660", Offset = "0x4EA2A60", VA = "0x184EA3660", Slot = "101")]
			private void INXJRXHQDZV(Id32<IWTLBCZPUHH> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x7345EC0", Offset = "0x73452C0", VA = "0x187345EC0", Slot = "103")]
			private void URSMCNJEFKF(Id32<IWTLBCZPUHH> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x7343930", Offset = "0x7342D30", VA = "0x187343930", Slot = "104")]
			private void FYOKMKSLJCZ(Id32<IWTLBCZPUHH> sourceId, Id32<IWTLBCZPUHH> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x7345510", Offset = "0x7344910", VA = "0x187345510", Slot = "105")]
			private void PPTUGRPXLFQ(Id32<IWTLBCZPUHH> sourceId, Id32<IWTLBCZPUHH> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x1746430", Offset = "0x1745830", VA = "0x181746430", Slot = "98")]
			private void JICCEFULJZL(Id32<IWTLBCZPUHH> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x7344F70", Offset = "0x7344370", VA = "0x187344F70", Slot = "100")]
			private void OUUIOCCNLTM(Id32<IWTLBCZPUHH> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x7344F00", Offset = "0x7344300", VA = "0x187344F00", Slot = "102")]
			private void OUSIQJZRMGQ(Id32<IWTLBCZPUHH> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x7343290", Offset = "0x7342690", VA = "0x187343290", Slot = "106")]
			private void EEGYWVCLZDU(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x7344C00", Offset = "0x7344000", VA = "0x187344C00", Slot = "150")]
			[AsyncStateMachine(typeof(OGPTWGQRVAK<>.<RequestNameChange>d__224))]
			public Task<Result<None, SKKNIPYCQUO>> OBEPDYTIDNK(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x7342EC0", Offset = "0x73422C0", VA = "0x187342EC0", Slot = "57")]
			private void DUMBODWXHVM(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x73432B0", Offset = "0x73426B0", VA = "0x1873432B0", Slot = "58")]
			private void ELANSYBQQSR(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x7344070", Offset = "0x7343470", VA = "0x187344070", Slot = "30")]
			private bool YTPMFXOSFYL([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x7342660", Offset = "0x7341A60", VA = "0x187342660", Slot = "32")]
			private bool ABONVPICAUC([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x7345A70", Offset = "0x7344E70", VA = "0x187345A70", Slot = "51")]
			private bool SYIUQUNITJY([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF8190", Offset = "0xCF7590", VA = "0x180CF8190")]
			[CompilerGenerated]
			private string IBXKBXMTXAA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x7343F00", Offset = "0x7343300", VA = "0x187343F00")]
			[CompilerGenerated]
			private void ICCQZEGRGLJ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public sealed class QROTRUFGTJZ : GMYHKEOQUKE<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0xF32050", Offset = "0xF31450", VA = "0x180F32050", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x2B49900", Offset = "0x2B48D00", VA = "0x182B49900")]
			public QROTRUFGTJZ(SCQFSPRNDPD a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public sealed class PICJTOQHKAH : OGPTWGQRVAK<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class JZPSQTWWHKR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> SRCDXNCOBGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public PICJTOQHKAH IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public IReadOnlyDictionary<Guid, int> PDBCULBLZBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				public IReadOnlyDictionary<int, Guid> PJVASTHTMSG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public JZPSQTWWHKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZKVYMHBLGQU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D650", Offset = "0x2B3CA50", VA = "0x182B3D650")]
				internal int ZLBFJNVIQCD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D8F0", Offset = "0x2B3CCF0", VA = "0x182B3D8F0")]
				internal void ZLGMGUPFZNM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B48A70", Offset = "0x2B47E70", VA = "0x182B48A70")]
			public PICJTOQHKAH(SCQFSPRNDPD a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B48790", Offset = "0x2B47B90", VA = "0x182B48790", Slot = "145")]
			protected sealed override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private sealed class KBEAUDZKWZP : MVDYZVCXMTP<IYJACMBKULE>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DDE0", Offset = "0x2B3D1E0", VA = "0x182B3DDE0")]
			public KBEAUDZKWZP(SCQFSPRNDPD a, IYJACMBKULE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public sealed class QHDZHLYZUVN : OGPTWGQRVAK<IIKRUIMOYUI>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				public QHDZHLYZUVN IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E4B0", Offset = "0x2B3D8B0", VA = "0x182B3E4B0")]
				internal bool ZKVYMHBLGQU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B3EA20", Offset = "0x2B3DE20", VA = "0x182B3EA20")]
				internal void ZLBFJNVIQCD(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B48F60", Offset = "0x2B48360", VA = "0x182B48F60")]
			public QHDZHLYZUVN(SCQFSPRNDPD a, IIKRUIMOYUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B48D90", Offset = "0x2B48190", VA = "0x182B48D90", Slot = "145")]
			protected sealed override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class WKPRWIEQDEI : OGPTWGQRVAK<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class JZPSQTWWHKR
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
					public JZPSQTWWHKR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x400025B")]
					public int v;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x400025C")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004F5")]
					[Cpp2IlInjected.Address(RVA = "0x2B507B0", Offset = "0x2B4FBB0", VA = "0x182B507B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004F6")]
					[Cpp2IlInjected.Address(RVA = "0x2B509E0", Offset = "0x2B4FDE0", VA = "0x182B509E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> MPJODWELBOW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				public WKPRWIEQDEI IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				public IReadOnlyDictionary<Guid, int> WUXXHYRGUGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				public IReadOnlyDictionary<int, Guid> XFIDXHLFKME;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public JZPSQTWWHKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZKVYMHBLGQU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D360", Offset = "0x2B3C760", VA = "0x182B3D360")]
				internal int ZLBFJNVIQCD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DA90", Offset = "0x2B3CE90", VA = "0x182B3DA90")]
				internal void ZLGMGUPFZNM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DBE0", Offset = "0x2B3CFE0", VA = "0x182B3DBE0")]
				internal int ZLLTEBJDIYV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CEE0", Offset = "0x2B3C2E0", VA = "0x182B3CEE0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__4>d))]
				internal Task<bool> ZKAWXFZVUXK(int a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C4C0", Offset = "0x2B3B8C0", VA = "0x182B3C4C0")]
				internal int HHNNWIFIQXU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E0")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C680", Offset = "0x2B3BA80", VA = "0x182B3C680")]
				internal void OGTWOFEDSOS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C710", Offset = "0x2B3BB10", VA = "0x182B3C710")]
				internal int OGZDLLYBCAB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C5A0", Offset = "0x2B3B9A0", VA = "0x182B3C5A0")]
				internal void OGJITRQIZSA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C630", Offset = "0x2B3BA30", VA = "0x182B3C630")]
				internal int OGOPQYKGJDJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C7F0", Offset = "0x2B3BBF0", VA = "0x182B3C7F0")]
				internal void OHOYDGFTEIC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C880", Offset = "0x2B3BC80", VA = "0x182B3C880")]
				internal int OHUFAMZQNTL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C760", Offset = "0x2B3BB60", VA = "0x182B3C760")]
				internal void OHEKISRYLLK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CFE0", Offset = "0x2B3C3E0", VA = "0x182B3CFE0")]
				internal float ZKGDUMTTEIT()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D030", Offset = "0x2B3C430", VA = "0x182B3D030")]
				internal void ZKLKRTNQNUC(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D0C0", Offset = "0x2B3C4C0", VA = "0x182B3D0C0")]
				internal float ZKQRPAHNXFL()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CE00", Offset = "0x2B3C200", VA = "0x182B3CE00")]
				internal void ZJFVIEYGJEA(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2B3CE90", Offset = "0x2B3C290", VA = "0x182B3CE90")]
				internal bool ZJLCFLSDSPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C430", Offset = "0x2B3B830", VA = "0x182B3C430")]
				internal void HGCRPMWBCWJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C3E0", Offset = "0x2B3B7E0", VA = "0x182B3C3E0")]
				internal int HFXKSGCDTLA()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C350", Offset = "0x2B3B750", VA = "0x182B3C350")]
				internal void HFSDUZIGJZR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C300", Offset = "0x2B3B700", VA = "0x182B3C300")]
				internal float HFMWXSOJAOI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C270", Offset = "0x2B3B670", VA = "0x182B3C270")]
				internal void HFHQALULRCZ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C220", Offset = "0x2B3B620", VA = "0x182B3C220")]
				internal float HFCJDFAOHRQ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C190", Offset = "0x2B3B590", VA = "0x182B3C190")]
				internal void HEXCFYGQYGH(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C140", Offset = "0x2B3B540", VA = "0x182B3C140")]
				internal bool HERVIRMTOUY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C510", Offset = "0x2B3B910", VA = "0x182B3C510")]
				internal void HHSUTOZGAJD(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B53D50", Offset = "0x2B53150", VA = "0x182B53D50")]
			public WKPRWIEQDEI(SCQFSPRNDPD a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B52C60", Offset = "0x2B52060", VA = "0x182B52C60", Slot = "145")]
			protected sealed override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public sealed class VTLEWXMSBHR : NZPZDBFTJKC<RecNetImageNode>
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
				public VTLEWXMSBHR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004FB")]
				[Cpp2IlInjected.Address(RVA = "0x2B4FFE0", Offset = "0x2B4F3E0", VA = "0x182B4FFE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B51D20", Offset = "0x2B51120", VA = "0x182B51D20")]
			public VTLEWXMSBHR(SCQFSPRNDPD a, RecNetImageNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B51850", Offset = "0x2B50C50", VA = "0x182B51850", Slot = "151")]
			protected override void QMEBRNYBNGN(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B51C50", Offset = "0x2B51050", VA = "0x182B51C50")]
			[CompilerGenerated]
			private string? UQPLBXQVYWJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B51B80", Offset = "0x2B50F80", VA = "0x182B51B80")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__1_1>d))]
			[CompilerGenerated]
			private void UQKEEQWYPLA(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public abstract class UQINANQBUXD<a> : OGPTWGQRVAK<a> where a : notnull, EZZRJNWVODZ
		{
			[Cpp2IlInjected.Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class ZMZGDOYHPIH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> MPJODWELBOW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				public UQINANQBUXD<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public IReadOnlyDictionary<Guid, int> WUXXHYRGUGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				public IReadOnlyDictionary<int, Guid> XFIDXHLFKME;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				public AudioClipType POYVTEJFAJG;

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public ZMZGDOYHPIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZKVYMHBLGQU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x508BD80", Offset = "0x508B180", VA = "0x18508BD80")]
				internal int ZLBFJNVIQCD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x508BEA0", Offset = "0x508B2A0", VA = "0x18508BEA0")]
				internal void ZLGMGUPFZNM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x508C090", Offset = "0x508B490", VA = "0x18508C090")]
				internal void ZLLTEBJDIYV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x508BBC0", Offset = "0x508AFC0", VA = "0x18508BBC0")]
				internal void ZKAWXFZVUXK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0x508BCD0", Offset = "0x508B0D0", VA = "0x18508BCD0")]
				internal bool ZKGDUMTTEIT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x508BD30", Offset = "0x508B130", VA = "0x18508BD30")]
				internal void ZKLKRTNQNUC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x508BCD0", Offset = "0x508B0D0", VA = "0x18508BCD0")]
				internal bool ZKQRPAHNXFL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x508BB00", Offset = "0x508AF00", VA = "0x18508BB00")]
				internal float ZJFVIEYGJEA()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x508BB30", Offset = "0x508AF30", VA = "0x18508BB30")]
				internal void ZJLCFLSDSPJ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x508ADD0", Offset = "0x508A1D0", VA = "0x18508ADD0")]
				internal float HGCRPMWBCWJ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x508AD40", Offset = "0x508A140", VA = "0x18508AD40")]
				internal void HFXKSGCDTLA(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x508AD10", Offset = "0x508A110", VA = "0x18508AD10")]
				internal float HFSDUZIGJZR()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x508AC80", Offset = "0x508A080", VA = "0x18508AC80")]
				internal void HFMWXSOJAOI(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public abstract AudioClipType TVOEUJTLAXI
			{
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x71E87D0", Offset = "0x71E7BD0", VA = "0x1871E87D0")]
			public UQINANQBUXD(SCQFSPRNDPD a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x7D5F100", Offset = "0x7D5E500", VA = "0x187D5F100", Slot = "145")]
			protected sealed override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private sealed class WTSXBRTSDDB : OGPTWGQRVAK<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0xF380F0", Offset = "0xF374F0", VA = "0x180F380F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2B54790", Offset = "0x2B53B90", VA = "0x182B54790")]
			public WTSXBRTSDDB(SCQFSPRNDPD a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public sealed class OOLSOMNUFCA : SZFXGHTOOCY<TKDCZYSFBHQ>
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x2B465B0", Offset = "0x2B459B0", VA = "0x182B465B0")]
			public OOLSOMNUFCA(SCQFSPRNDPD a, TKDCZYSFBHQ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public sealed class SVZSCGYSUYU : SZFXGHTOOCY<NNHXXKKAMVZ>
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A220", Offset = "0x2B49620", VA = "0x182B4A220")]
			public SVZSCGYSUYU(SCQFSPRNDPD a, NNHXXKKAMVZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public abstract class SZFXGHTOOCY<a> : OGPTWGQRVAK<a> where a : notnull, CBLKZRMKILK
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
				public SZFXGHTOOCY<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0x41C16B0", Offset = "0x41C0AB0", VA = "0x1841C16B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051D")]
				[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class UQEFQITABRG
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
					public UQEFQITABRG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000278")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000279")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027A")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x41C03B0", Offset = "0x41BF7B0", VA = "0x1841C03B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public UQEFQITABRG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600052F")]
					[Cpp2IlInjected.Address(RVA = "0x41C0780", Offset = "0x41BFB80", VA = "0x1841C0780", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000530")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public UQEFQITABRG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000282")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000283")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000284")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000531")]
					[Cpp2IlInjected.Address(RVA = "0x41C0E30", Offset = "0x41C0230", VA = "0x1841C0E30", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000532")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public UQEFQITABRG <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000288")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000289")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000533")]
					[Cpp2IlInjected.Address(RVA = "0x41C13C0", Offset = "0x41C07C0", VA = "0x1841C13C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000534")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public int ONJFVMMXRGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public StructuredDataEntry ARPKQNOIUSK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public SZFXGHTOOCY<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public Func<BSJAKYMSOCV, bool> BDZOJZZPMYZ;

				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public UQEFQITABRG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0x7D5F0A0", Offset = "0x7D5E4A0", VA = "0x187D5F0A0")]
				internal bool ZLLTEBJDIYV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000524")]
				[Cpp2IlInjected.Address(RVA = "0x7D5EE60", Offset = "0x7D5E260", VA = "0x187D5EE60")]
				internal void ZKAWXFZVUXK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
				internal string ZKGDUMTTEIT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0x7D5EED0", Offset = "0x7D5E2D0", VA = "0x187D5EED0")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.UQEFQITABRG.<<BuildConfigMenuInternal>b__6>d))]
				internal void ZKLKRTNQNUC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000527")]
				[Cpp2IlInjected.Address(RVA = "0x7D5EF90", Offset = "0x7D5E390", VA = "0x187D5EF90")]
				internal int ZKQRPAHNXFL()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000528")]
				[Cpp2IlInjected.Address(RVA = "0x7D5EB80", Offset = "0x7D5DF80", VA = "0x187D5EB80")]
				internal bool HFMWXSOJAOI(BSJAKYMSOCV a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0x7D5EDB0", Offset = "0x7D5E1B0", VA = "0x187D5EDB0")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.UQEFQITABRG.<<BuildConfigMenuInternal>b__8>d))]
				internal void ZJFVIEYGJEA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
				internal string HGCRPMWBCWJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0x7D5EC40", Offset = "0x7D5E040", VA = "0x187D5EC40")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.UQEFQITABRG.<<BuildConfigMenuInternal>b__11>d))]
				internal void HFXKSGCDTLA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x7D5EBA0", Offset = "0x7D5DFA0", VA = "0x187D5EBA0")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.UQEFQITABRG.<<BuildConfigMenuInternal>b__12>d))]
				internal void HFSDUZIGJZR()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class QXLRGRRVYAH
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400028F")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000290")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000565")]
					[Cpp2IlInjected.Address(RVA = "0x41BA7C0", Offset = "0x41B9BC0", VA = "0x1841BA7C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000566")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000294")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000295")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000567")]
					[Cpp2IlInjected.Address(RVA = "0x41BAB40", Offset = "0x41B9F40", VA = "0x1841BAB40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000568")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029A")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000569")]
					[Cpp2IlInjected.Address(RVA = "0x41BAF10", Offset = "0x41BA310", VA = "0x1841BAF10", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056A")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029E")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400029F")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056B")]
					[Cpp2IlInjected.Address(RVA = "0x41BB4E0", Offset = "0x41BA8E0", VA = "0x1841BB4E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056C")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A3")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A4")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056D")]
					[Cpp2IlInjected.Address(RVA = "0x41BB770", Offset = "0x41BAB70", VA = "0x1841BB770", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600056E")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A8")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600056F")]
					[Cpp2IlInjected.Address(RVA = "0x41BBB00", Offset = "0x41BAF00", VA = "0x1841BBB00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000570")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000571")]
					[Cpp2IlInjected.Address(RVA = "0x41BBE90", Offset = "0x41BB290", VA = "0x1841BBE90", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000572")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B3")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000573")]
					[Cpp2IlInjected.Address(RVA = "0x41BC120", Offset = "0x41BB520", VA = "0x1841BC120", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000574")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000575")]
					[Cpp2IlInjected.Address(RVA = "0x41BC4B0", Offset = "0x41BB8B0", VA = "0x1841BC4B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000576")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BC")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BD")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000577")]
					[Cpp2IlInjected.Address(RVA = "0x41BC840", Offset = "0x41BBC40", VA = "0x1841BC840", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000578")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C1")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C2")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000579")]
					[Cpp2IlInjected.Address(RVA = "0x41BCBC0", Offset = "0x41BBFC0", VA = "0x1841BCBC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057A")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057B")]
					[Cpp2IlInjected.Address(RVA = "0x41BCE50", Offset = "0x41BC250", VA = "0x1841BCE50", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057C")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057D")]
					[Cpp2IlInjected.Address(RVA = "0x41BD1E0", Offset = "0x41BC5E0", VA = "0x1841BD1E0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600057E")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					public float value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600057F")]
					[Cpp2IlInjected.Address(RVA = "0x41BD470", Offset = "0x41BC870", VA = "0x1841BD470", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000580")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					public bool value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000581")]
					[Cpp2IlInjected.Address(RVA = "0x41BD800", Offset = "0x41BCC00", VA = "0x1841BD800", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000582")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DB")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0x41BDB80", Offset = "0x41BCF80", VA = "0x1841BDB80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000584")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
					public QXLRGRRVYAH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002DF")]
					public bool enabled;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E0")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000585")]
					[Cpp2IlInjected.Address(RVA = "0x41BDF00", Offset = "0x41BD300", VA = "0x1841BDF00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000586")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public SZFXGHTOOCY<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int ONJFVMMXRGC;

				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public QXLRGRRVYAH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x7673A00", Offset = "0x7672E00", VA = "0x187673A00")]
				internal bool BDFLQMWLTQS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x7673A60", Offset = "0x7672E60", VA = "0x187673A60")]
				internal void BDKSNTQJDCB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x7675490", Offset = "0x7674890", VA = "0x187675490")]
				internal object WIQFCZXWJPX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x76753D0", Offset = "0x76747D0", VA = "0x1876753D0")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__13>d))]
				internal void WIKYFTDZAEO(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x76755F0", Offset = "0x76749F0", VA = "0x1876755F0")]
				internal string WJASXNLRCMP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0x7675530", Offset = "0x7674930", VA = "0x187675530")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__15>d))]
				internal void WIVMAGRTTBG(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x7675720", Offset = "0x7674B20", VA = "0x187675720")]
				internal bool WJLGSAZLVJH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x7675690", Offset = "0x7674A90", VA = "0x187675690")]
				internal bool WJFZUUFOLXY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x76751E0", Offset = "0x76745E0", VA = "0x1876751E0")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__18>d))]
				internal void WGPOEKGWTGL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x7675130", Offset = "0x7674530", VA = "0x187675130")]
				internal int WGKHHDMZJVC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0x7673E80", Offset = "0x7673280", VA = "0x187673E80")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__20>d))]
				internal void CGEAZRKUHMM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x7673F30", Offset = "0x7673330", VA = "0x187673F30")]
				internal bool CGJHWYERQXV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x7673FC0", Offset = "0x76733C0", VA = "0x187673FC0")]
				internal float CGOOUEYPAJE()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x7674070", Offset = "0x7673470", VA = "0x187674070")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__23>d))]
				internal void CGTVRLSMJUN(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x7674120", Offset = "0x7673520", VA = "0x187674120")]
				internal bool CGZCOSMJTFW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x76741B0", Offset = "0x76735B0", VA = "0x1876741B0")]
				internal bool CHEJLZGHCRF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x7674240", Offset = "0x7673640", VA = "0x187674240")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__26>d))]
				internal void CHJQJGAEMCO(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x76742F0", Offset = "0x76736F0", VA = "0x1876742F0")]
				internal int CHOXGMUBVNX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x7674380", Offset = "0x7673780", VA = "0x187674380")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__28>d))]
				internal void CHUEDTNZEZG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x7674430", Offset = "0x7673830", VA = "0x187674430")]
				internal bool CHZLBAHWOKP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x7674680", Offset = "0x7673A80", VA = "0x187674680")]
				internal float JGVFYJSWXEV()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x76745D0", Offset = "0x76739D0", VA = "0x1876745D0")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__31>d))]
				internal void JGPZBCYZNTM(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x7674540", Offset = "0x7673940", VA = "0x187674540")]
				internal bool JGKSDWFCEID()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x76744C0", Offset = "0x76738C0", VA = "0x1876744C0")]
				internal bool JGFLGPLEUWU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x76748E0", Offset = "0x7673CE0", VA = "0x1876748E0")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__34>d))]
				internal void JHQHNKUMIYF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x7674850", Offset = "0x7673C50", VA = "0x187674850")]
				internal bool JHLAQEAOZMW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x76747C0", Offset = "0x7673BC0", VA = "0x1876747C0")]
				internal bool JHFTSXGRQBN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x7674710", Offset = "0x7673B10", VA = "0x187674710")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__37>d))]
				internal void JHAMVQMUGQE(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x7674A40", Offset = "0x7673E40", VA = "0x187674A40")]
				internal int JILJCLWBURP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x7674990", Offset = "0x7673D90", VA = "0x187674990")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__39>d))]
				internal void JIGCFFCELGG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x7674C10", Offset = "0x7674010", VA = "0x187674C10")]
				internal bool RDSTOGVPVXE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(RVA = "0x7674CA0", Offset = "0x76740A0", VA = "0x187674CA0")]
				internal float RDYALNPNFIN()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x7674AD0", Offset = "0x7673ED0", VA = "0x187674AD0")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__42>d))]
				internal void RDIFTTHVDAM(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x7674B80", Offset = "0x7673F80", VA = "0x187674B80")]
				internal bool RDNMRABSMLV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(RVA = "0x7674DC0", Offset = "0x76741C0", VA = "0x187674DC0")]
				internal bool RENVDHXFHQO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x7674E40", Offset = "0x7674240", VA = "0x187674E40")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__45>d))]
				internal void RETCAORCRBX(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0x7674D30", Offset = "0x7674130", VA = "0x187674D30")]
				internal bool REDHIUJKOTW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055B")]
				[Cpp2IlInjected.Address(RVA = "0x76738C0", Offset = "0x7672CC0", VA = "0x1876738C0")]
				internal bool BCUXVZIRAUA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0x7673950", Offset = "0x7672D50", VA = "0x187673950")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__3>d))]
				internal void BDAETGCOKFJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x7673BF0", Offset = "0x7672FF0", VA = "0x187673BF0")]
				internal int BEANFNYBFKC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x7673C80", Offset = "0x7673080", VA = "0x187673C80")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__5>d))]
				internal void BEFUCURYOVL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x7673AD0", Offset = "0x7672ED0", VA = "0x187673AD0")]
				internal bool BDPZLAKGMNK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x7673B60", Offset = "0x7672F60", VA = "0x187673B60")]
				internal bool BDVGIHEDVYT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x7673D30", Offset = "0x7673130", VA = "0x187673D30")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__8>d))]
				internal void BEVOUOZQRDM(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x7673DE0", Offset = "0x76731E0", VA = "0x187673DE0")]
				internal int BFAVRVTOAOV()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x7675320", Offset = "0x7674720", VA = "0x187675320")]
				[AsyncStateMachine(typeof(SZFXGHTOOCY<>.QXLRGRRVYAH.<<AddConstraintOptions>b__10>d))]
				internal void WIFRIMKBQTF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x7675290", Offset = "0x7674690", VA = "0x187675290")]
				internal bool WIAKLFQEHHW()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private readonly List<bool> IUHCPSMLLLU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			private readonly List<bool> JFJEQHOSFCD;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000516")]
				[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			private List<BSJAKYMSOCV> TPFPRLNKUCR
			{
				[Cpp2IlInjected.Token(Token = "0x6000517")]
				[Cpp2IlInjected.Address(RVA = "0x7945E60", Offset = "0x7945260", VA = "0x187945E60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x79485D0", Offset = "0x79479D0", VA = "0x1879485D0")]
			public SZFXGHTOOCY(SCQFSPRNDPD a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x7945DB0", Offset = "0x79451B0", VA = "0x187945DB0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x7945EB0", Offset = "0x79452B0", VA = "0x187945EB0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x7946EF0", Offset = "0x79462F0", VA = "0x187946EF0")]
			private JIKSHYOTFUN VUBDVISIJKM(FXXMCEYJLNJ a, int b, [In] StructuredDataEntry entry)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x7945CB0", Offset = "0x79450B0", VA = "0x187945CB0")]
			[AsyncStateMachine(typeof(SZFXGHTOOCY<>.<<BuildConfigMenuInternal>b__8_1>d))]
			[CompilerGenerated]
			private void ABQDFCDWHZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x7945D50", Offset = "0x7945150", VA = "0x187945D50")]
			[CompilerGenerated]
			private bool ACFXWWLOKHT()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public sealed class QNGSNBUPPYY : OGPTWGQRVAK<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			[CompilerGenerated]
			private sealed class VUGRTXXDLRI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public QNGSNBUPPYY IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public VUGRTXXDLRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x2B51F10", Offset = "0x2B51310", VA = "0x182B51F10")]
				internal int ZLBFJNVIQCD()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x2B51F60", Offset = "0x2B51360", VA = "0x182B51F60")]
				internal void ZLGMGUPFZNM(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private static Dictionary<string, EnumChoiceData>? XIFUFBAIZWN;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x2B49890", Offset = "0x2B48C90", VA = "0x182B49890")]
			public QNGSNBUPPYY(SCQFSPRNDPD a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x2B49540", Offset = "0x2B48940", VA = "0x182B49540", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public sealed class KDOLBOVQBFO : UQINANQBUXD<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override AudioClipType TVOEUJTLAXI
			{
				[Cpp2IlInjected.Token(Token = "0x6000590")]
				[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F3C0", Offset = "0x2B3E7C0", VA = "0x182B3F3C0")]
			public KDOLBOVQBFO(SCQFSPRNDPD a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private sealed class UWAYWBXCSPN : MVDYZVCXMTP<ZSONSSLHKJK>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000591")]
				[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x2B51700", Offset = "0x2B50B00", VA = "0x182B51700")]
			public UWAYWBXCSPN(SCQFSPRNDPD a, ZSONSSLHKJK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private sealed class HEPVMVNIPIG : MVDYZVCXMTP<OEGEGBDHVTR>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000594")]
				[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B8B0", Offset = "0x2B3ACB0", VA = "0x182B3B8B0")]
			public HEPVMVNIPIG(SCQFSPRNDPD a, OEGEGBDHVTR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public sealed class TEBFKTYZRQS : NZPZDBFTJKC<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000F6")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
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
					public KDEBKHUDUUH <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002EB")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002EC")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002ED")]
					private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600059B")]
					[Cpp2IlInjected.Address(RVA = "0x2B4FCD0", Offset = "0x2B4F0D0", VA = "0x182B4FCD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600059C")]
					[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002E7")]
				public TEBFKTYZRQS IRZLODQIRHI;

				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x2B3E0A0", Offset = "0x2B3D4A0", VA = "0x182B3E0A0")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void TNPRKDKTDQZ(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A580", Offset = "0x2B49980", VA = "0x182B4A580")]
			public TEBFKTYZRQS(SCQFSPRNDPD a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A280", Offset = "0x2B49680", VA = "0x182B4A280", Slot = "151")]
			protected override void QMEBRNYBNGN(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public sealed class XCNAOFUSLZT : UQINANQBUXD<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override AudioClipType TVOEUJTLAXI
			{
				[Cpp2IlInjected.Token(Token = "0x600059E")]
				[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x2B54800", Offset = "0x2B53C00", VA = "0x182B54800")]
			public XCNAOFUSLZT(SCQFSPRNDPD a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private sealed class BRICEBVATQA : OGPTWGQRVAK<UKPBIZBSROY>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0xF1BB00", Offset = "0xF1AF00", VA = "0x180F1BB00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A7A0", Offset = "0x2B39BA0", VA = "0x182B3A7A0")]
			public BRICEBVATQA(SCQFSPRNDPD a, UKPBIZBSROY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public sealed class LHJYBGIXPLN : OGPTWGQRVAK<SXQAHNDUIEQ>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005A2")]
				[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60005A3")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			protected sealed override bool HJWQOLTFRYK
			{
				[Cpp2IlInjected.Token(Token = "0x60005A4")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F7E0", Offset = "0x2B3EBE0", VA = "0x182B3F7E0")]
			public LHJYBGIXPLN(SCQFSPRNDPD a, SXQAHNDUIEQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F4D0", Offset = "0x2B3E8D0", VA = "0x182B3F4D0", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F420", Offset = "0x2B3E820", VA = "0x182B3F420")]
			private int EBOBYQXSBHB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F460", Offset = "0x2B3E860", VA = "0x182B3F460")]
			private void JDWNXEAOKWL(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class XEUGKXTNFCK : LXUTKHIBBGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F850", Offset = "0x2B3EC50", VA = "0x182B3F850")]
			public XEUGKXTNFCK(SCQFSPRNDPD a, SIDFNDXEBQO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public sealed class TGZPVKNSBWY : OGPTWGQRVAK<WYSXVUAKVCR>
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			[CompilerGenerated]
			private sealed class JZPSQTWWHKR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EE")]
				public TGZPVKNSBWY IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public JZPSQTWWHKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D310", Offset = "0x2B3C710", VA = "0x182B3D310")]
				internal int ZKVYMHBLGQU()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D560", Offset = "0x2B3C960", VA = "0x182B3D560")]
				internal void ZLBFJNVIQCD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B3D8A0", Offset = "0x2B3CCA0", VA = "0x182B3D8A0")]
				internal int ZLGMGUPFZNM()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0x2B3DD40", Offset = "0x2B3D140", VA = "0x182B3DD40")]
				internal void ZLLTEBJDIYV(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005AC")]
				[Cpp2IlInjected.Address(RVA = "0xD2CE60", Offset = "0xD2C260", VA = "0x180D2CE60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A8F0", Offset = "0x2B49CF0", VA = "0x182B4A8F0")]
			public TGZPVKNSBWY(SCQFSPRNDPD a, WYSXVUAKVCR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A5E0", Offset = "0x2B499E0", VA = "0x182B4A5E0", Slot = "145")]
			protected sealed override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public sealed class ZABNAGYXVYR : NZPZDBFTJKC<JBZMQSVBRXM>
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x2B55170", Offset = "0x2B54570", VA = "0x182B55170")]
			public ZABNAGYXVYR(SCQFSPRNDPD a, JBZMQSVBRXM b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class NZPZDBFTJKC<a> : OGPTWGQRVAK<a> where a : notnull, JBZMQSVBRXM
		{
			[Cpp2IlInjected.Token(Token = "0x2000100")]
			[CompilerGenerated]
			private sealed class ECWTQFSOHXI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public NZPZDBFTJKC<a> IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public ECWTQFSOHXI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x5AAA350", Offset = "0x5AA9750", VA = "0x185AAA350")]
				internal bool ZKVYMHBLGQU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x5AAA380", Offset = "0x5AA9780", VA = "0x185AAA380")]
				internal void ZLBFJNVIQCD(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x5AAA410", Offset = "0x5AA9810", VA = "0x185AAA410")]
				internal bool ZLGMGUPFZNM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BF")]
				[Cpp2IlInjected.Address(RVA = "0x5AAA440", Offset = "0x5AA9840", VA = "0x185AAA440")]
				internal void ZLLTEBJDIYV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x5AAA260", Offset = "0x5AA9660", VA = "0x185AAA260")]
				internal bool ZKAWXFZVUXK()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[CompilerGenerated]
			private sealed class RBAAAFPDLJX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				public DLADXAUDIQZ YALWCUSQPAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public NZPZDBFTJKC<a> IRZLODQIRHI;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public RBAAAFPDLJX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x76856C0", Offset = "0x7684AC0", VA = "0x1876856C0")]
				internal void TNPRKDKTDQZ(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0xD5FC60", Offset = "0xD5F060", VA = "0x180D5FC60", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x71EEEE0", Offset = "0x71EE2E0", VA = "0x1871EEEE0", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x71EEDD0", Offset = "0x71EE1D0", VA = "0x1871EEDD0")]
			protected NZPZDBFTJKC(SCQFSPRNDPD a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x71EE650", Offset = "0x71EDA50", VA = "0x1871EE650", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x71EEA60", Offset = "0x71EDE60", VA = "0x1871EEA60", Slot = "145")]
			protected override void VLJZDRJTXZI(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x71EE740", Offset = "0x71EDB40", VA = "0x1871EE740", Slot = "151")]
			protected virtual void QMEBRNYBNGN(FXXMCEYJLNJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x71EEA20", Offset = "0x71EDE20", VA = "0x1871EEA20", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B189A0", Offset = "0x2B17DA0", VA = "0x182B189A0")]
		public static FEGMTBIBNYX New(SCQFSPRNDPD circuitsManager, SIDFNDXEBQO node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class TVZFGYDTXEJ : PHFIUZZADEH, YYDKGBIYIEG, IKOBMFTUZAY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<FOQLRVXTRHG> AIULMOXWVCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xF17290", Offset = "0xF16690", VA = "0x180F17290", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<FOQLRVXTRHG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Id32<DMDCMEAEHJK> LZPTVOAZIAT
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x1527750", Offset = "0x1526B50", VA = "0x181527750", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<DMDCMEAEHJK>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x23D3060", Offset = "0x23D2460", VA = "0x1823D3060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private Id32<CDTRWUZOHPN> MTFRBKGRMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x14627B0", Offset = "0x1461BB0", VA = "0x1814627B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public override Id32<OJXYPHPZREW> SREGWDSDSHD
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x2B4AA20", Offset = "0x2B49E20", VA = "0x182B4AA20", Slot = "22")]
			get
			{
				return default(Id32<OJXYPHPZREW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ADC0", Offset = "0x2B4A1C0", VA = "0x182B4ADC0")]
		private TVZFGYDTXEJ(SCQFSPRNDPD a, SIDFNDXEBQO b, HQHSXVCEPWQ c, Id32<IWTLBCZPUHH> portGroupId, Id32<DMDCMEAEHJK> outputId, Id32<CDTRWUZOHPN> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AA70", Offset = "0x2B49E70", VA = "0x182B4AA70")]
		public static TVZFGYDTXEJ New(SCQFSPRNDPD circuitsManager, SIDFNDXEBQO node, HQHSXVCEPWQ output, Id32<IWTLBCZPUHH> portGroupId, Id32<CDTRWUZOHPN> outputDefId, Id32<DMDCMEAEHJK> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x23D3060", Offset = "0x23D2460", VA = "0x1823D3060")]
		internal void RYUJOHEFHBV(Id32<DMDCMEAEHJK> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public abstract class PHFIUZZADEH : IKOBMFTUZAY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private UAOBNCRZIPH? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F8C0", Offset = "0x2B3ECC0", VA = "0x182B3F8C0")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F8D0", Offset = "0x2B3ECD0", VA = "0x182B3F8D0")]
			public UAOBNCRZIPH RJIQBDDMCSV(PHFIUZZADEH a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected readonly SCQFSPRNDPD AIEUPWPRETM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly SIDFNDXEBQO GNXHQHFSAFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private LazyTypeAdapter RQTXDAPEQWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly XMRATBYHWHG HUVEDDTXFAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly List<MNPMUQQJDFG> UZJYWVOYMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly List<AJXPLUEOEKS> MXEBKCLRVRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private readonly bool NJKXLMKQPSV;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> FFXHZXSCFDB
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B47070", Offset = "0x2B46470", VA = "0x182B47070", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public DisplayKind PZBKMDROFLE
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xD11F90", Offset = "0xD11390", VA = "0x180D11F90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id32<EVDWFGHNUCH> LPAAGVPHFAH
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B46F10", Offset = "0x2B46310", VA = "0x182B46F10", Slot = "6")]
			get
			{
				return default(Id32<EVDWFGHNUCH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Id128<EVDWFGHNUCH> HSLTPWIRFSK
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2B47040", Offset = "0x2B46440", VA = "0x182B47040", Slot = "7")]
			get
			{
				return default(Id128<EVDWFGHNUCH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public BSJAKYMSOCV QMIZQQDYTQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x2B46F40", Offset = "0x2B46340", VA = "0x182B46F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public FEZAALSEAFJ IJHTRSYZBWV
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2B471B0", Offset = "0x2B465B0", VA = "0x182B471B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected UAOBNCRZIPH ICELGEFZEWY
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B471B0", Offset = "0x2B465B0", VA = "0x182B471B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public PortImage KNVAXAJEPEC
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B46DD0", Offset = "0x2B461D0", VA = "0x182B46DD0", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E20", Offset = "0xCF4220", VA = "0x180CF4E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id128<IHXSJTKSKEJ> MBVGKXPNKWM
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B47320", Offset = "0x2B46720", VA = "0x182B47320", Slot = "9")]
			get
			{
				return default(Id128<IHXSJTKSKEJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Id32<IWTLBCZPUHH> ZGPJQFDKILH
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xECD1E0", Offset = "0xECC5E0", VA = "0x180ECD1E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<IWTLBCZPUHH>);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x1AA5DF0", Offset = "0x1AA51F0", VA = "0x181AA5DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public abstract Id32<OJXYPHPZREW> SREGWDSDSHD
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool KYEKTQHQVSG
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xF6BC90", Offset = "0xF6B090", VA = "0x180F6BC90", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B48640", Offset = "0x2B47A40", VA = "0x182B48640")]
		protected PHFIUZZADEH(SCQFSPRNDPD a, SIDFNDXEBQO b, XMRATBYHWHG c, Id32<IWTLBCZPUHH> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B47240", Offset = "0x2B46640", VA = "0x182B47240", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B46F60", Offset = "0x2B46360", VA = "0x182B46F60", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B480E0", Offset = "0x2B474E0", VA = "0x182B480E0", Slot = "14")]
		public void TIDGSQSPLSB(MNPMUQQJDFG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B48190", Offset = "0x2B47590", VA = "0x182B48190", Slot = "15")]
		public void TPZPMMSKPYH(AJXPLUEOEKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B482A0", Offset = "0x2B476A0", VA = "0x182B482A0")]
		private bool XCTABKAZCWG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B47680", Offset = "0x2B46A80", VA = "0x182B47680", Slot = "17")]
		public void QLDRYVBZWCV(GQJOFAEKSPO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B48240", Offset = "0x2B47640", VA = "0x182B48240", Slot = "25")]
		protected virtual void VIRZBNMQVPZ(GQJOFAEKSPO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B47340", Offset = "0x2B46740", VA = "0x182B47340", Slot = "20")]
		private void MHVJGSGBALW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B474D0", Offset = "0x2B468D0", VA = "0x182B474D0")]
		private void QKGJYUWONFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B47F30", Offset = "0x2B47330", VA = "0x182B47F30")]
		private void SRFOBSSHZYT([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B47ED0", Offset = "0x2B472D0", VA = "0x182B47ED0", Slot = "18")]
		public void RVNGOBDTUHM(MNPMUQQJDFG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B485C0", Offset = "0x2B479C0", VA = "0x182B485C0", Slot = "19")]
		public void XUZCYFTHWZO(AJXPLUEOEKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xCF4E20", Offset = "0xCF4220", VA = "0x180CF4E20")]
		internal void CILJFNMOOVD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B48620", Offset = "0x2B47A20", VA = "0x182B48620")]
		internal void YKJEQMWUDAC(YCULPWATBNY a, BSJAKYMSOCV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1AA5DF0", Offset = "0x1AA51F0", VA = "0x181AA5DF0")]
		internal void YUFCQFRPQND(Id32<IWTLBCZPUHH> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class MWYZLKDYPBY : AKNWFLPUDGH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class GKKMLGCWAGW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public SCQFSPRNDPD LHQVSXKZPKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public SIDFNDXEBQO CANSHDFJKQC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<IWTLBCZPUHH> WTJHBDYDFVX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public bool MXXEZWUXGZY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public bool DRTXUYIPRON;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public GKKMLGCWAGW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B700", Offset = "0x2B3AB00", VA = "0x182B3B700")]
			internal UZOCHGIXCHS JMZERTXDPVM((int PortDescIndex, int PortIndex, XCCDJLHIEYV InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B7E0", Offset = "0x2B3ABE0", VA = "0x182B3B7E0")]
			internal TVZFGYDTXEJ JNELPARAZGV(HQHSXVCEPWQ a, int b)
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B560", Offset = "0x2B4A960", VA = "0x182B4B560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B9D0", Offset = "0x2B4ADD0", VA = "0x182B4B9D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public Id32<CPMNZXWNEQO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4CC90", Offset = "0x2B4C090", VA = "0x182B4CC90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4CFE0", Offset = "0x2B4C3E0", VA = "0x182B4CFE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D050", Offset = "0x2B4C450", VA = "0x182B4D050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D4D0", Offset = "0x2B4C8D0", VA = "0x182B4D4D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Id32<CDTRWUZOHPN> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D540", Offset = "0x2B4C940", VA = "0x182B4D540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D890", Offset = "0x2B4CC90", VA = "0x182B4D890", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E0C0", Offset = "0x2B4D4C0", VA = "0x182B4E0C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E410", Offset = "0x2B4D810", VA = "0x182B4E410", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public Id32<CPMNZXWNEQO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D900", Offset = "0x2B4CD00", VA = "0x182B4D900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x2B4DC70", Offset = "0x2B4D070", VA = "0x182B4DC70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Id32<CDTRWUZOHPN> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x2B4DCE0", Offset = "0x2B4D0E0", VA = "0x182B4DCE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E050", Offset = "0x2B4D450", VA = "0x182B4E050", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public UGXJSTBRSTY type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Id32<CPMNZXWNEQO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E480", Offset = "0x2B4D880", VA = "0x182B4E480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E820", Offset = "0x2B4DC20", VA = "0x182B4E820", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public UGXJSTBRSTY type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Id32<CDTRWUZOHPN> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E890", Offset = "0x2B4DC90", VA = "0x182B4E890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x2B4EC30", Offset = "0x2B4E030", VA = "0x182B4EC30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Id32<CPMNZXWNEQO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public Id32<CPMNZXWNEQO> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4ECA0", Offset = "0x2B4E0A0", VA = "0x182B4ECA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F000", Offset = "0x2B4E400", VA = "0x182B4F000", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public MWYZLKDYPBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Id32<CDTRWUZOHPN> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Id32<CDTRWUZOHPN> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private IKBVPHFPXCS <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F070", Offset = "0x2B4E470", VA = "0x182B4F070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F3D0", Offset = "0x2B4E7D0", VA = "0x182B4F3D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly bool BZWIPBBXWCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly SCQFSPRNDPD AIEUPWPRETM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly bool ICZNXKJMXGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private ReadOnlyIdArray<KYLBZYJNRQF, UZOCHGIXCHS> WEUILLZIUBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private ReadOnlyIdArray<KYLBZYJNRQF, FTGNFXPNPTP> OPJEXXTAZAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private readonly SIDFNDXEBQO GNXHQHFSAFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private ReadOnlyIdArray<DMDCMEAEHJK, TVZFGYDTXEJ> ISKDLLAMEXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ReadOnlyIdArray<DMDCMEAEHJK, YYDKGBIYIEG> ZMMHJEGEEAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private string? RWJZYOJQORW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly HZIXAFMUVRH ERHZDWVNHAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Id32<IWTLBCZPUHH> JCNINQXVXXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly bool UKBHMCMKECS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[CompilerGenerated]
		private Action? CPVXWQAVJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[CompilerGenerated]
		private Action? RBROOIFZNUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[CompilerGenerated]
		private Action<Id32<KYLBZYJNRQF>>? VPJCWCCMHCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[CompilerGenerated]
		private Action<Id32<DMDCMEAEHJK>>? XZFGSJJEEGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[CompilerGenerated]
		private AKNWFLPUDGH.PortGroupIdChangeDelegate? YTOCLYVNBDI;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool CATJXISASCW
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B41D90", Offset = "0x2B41190", VA = "0x182B41D90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool YJVJUKFJOYH
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B43260", Offset = "0x2B42660", VA = "0x182B43260", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool DMNVLRGIFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B424F0", Offset = "0x2B418F0", VA = "0x182B424F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Id128<EVDWFGHNUCH> HSLTPWIRFSK
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B41E50", Offset = "0x2B41250", VA = "0x182B41E50", Slot = "7")]
			get
			{
				return default(Id128<EVDWFGHNUCH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool HSVSRBNVPSL
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B42B30", Offset = "0x2B41F30", VA = "0x182B42B30", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ReadOnlyIdArray<KYLBZYJNRQF, FTGNFXPNPTP> DBJUNIANPQX
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<KYLBZYJNRQF, FTGNFXPNPTP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B420F0", Offset = "0x2B414F0", VA = "0x182B420F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Id128<IHXSJTKSKEJ> MBVGKXPNKWM
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B42B10", Offset = "0x2B41F10", VA = "0x182B42B10", Slot = "11")]
			get
			{
				return default(Id128<IHXSJTKSKEJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public ReadOnlyIdArray<DMDCMEAEHJK, YYDKGBIYIEG> CYZNYIDEGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<DMDCMEAEHJK, YYDKGBIYIEG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Id32<IWTLBCZPUHH> ZGPJQFDKILH
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x101CAC0", Offset = "0x101BEC0", VA = "0x18101CAC0", Slot = "13")]
			get
			{
				return default(Id32<IWTLBCZPUHH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? FRWUGJAICUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B431C0", Offset = "0x2B425C0", VA = "0x182B431C0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B439D0", Offset = "0x2B42DD0", VA = "0x182B439D0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? XAYMBBBBKDU
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B43B80", Offset = "0x2B42F80", VA = "0x182B43B80", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B458F0", Offset = "0x2B44CF0", VA = "0x182B458F0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<KYLBZYJNRQF?>, Id32<KYLBZYJNRQF?>>? MWYGPKGFDHT
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B41930", Offset = "0x2B40D30", VA = "0x182B41930", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B432A0", Offset = "0x2B426A0", VA = "0x182B432A0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<KYLBZYJNRQF?>, Id32<KYLBZYJNRQF?>>? CECBZYXEVAG
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x2B44E10", Offset = "0x2B44210", VA = "0x182B44E10", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2B410F0", Offset = "0x2B404F0", VA = "0x182B410F0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<DMDCMEAEHJK?>, Id32<DMDCMEAEHJK?>>? IQOVETTXYDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2B42BB0", Offset = "0x2B41FB0", VA = "0x182B42BB0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x2B43E10", Offset = "0x2B43210", VA = "0x182B43E10", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<DMDCMEAEHJK?>, Id32<DMDCMEAEHJK?>>? OPGFGVPTSEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2B42990", Offset = "0x2B41D90", VA = "0x182B42990", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2B41F70", Offset = "0x2B41370", VA = "0x182B41F70", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<KYLBZYJNRQF?>, FTGNFXPNPTP?>? ECYKHNFKYGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2B43C30", Offset = "0x2B43030", VA = "0x182B43C30", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2B425B0", Offset = "0x2B419B0", VA = "0x182B425B0", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<KYLBZYJNRQF?>>? MBXSQGMCRUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x2B42670", Offset = "0x2B41A70", VA = "0x182B42670", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x2B41030", Offset = "0x2B40430", VA = "0x182B41030", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<KYLBZYJNRQF?>, FTGNFXPNPTP?>? ATPOXAPCYFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2B42A50", Offset = "0x2B41E50", VA = "0x182B42A50", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x2B44490", Offset = "0x2B43890", VA = "0x182B44490", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<DMDCMEAEHJK?>, YYDKGBIYIEG?>? EPXSZQYLJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2B46130", Offset = "0x2B45530", VA = "0x182B46130", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x2B42030", Offset = "0x2B41430", VA = "0x182B42030", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<DMDCMEAEHJK?>>? PZFAVVJWBYO
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2B43ED0", Offset = "0x2B432D0", VA = "0x182B43ED0", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x2B44160", Offset = "0x2B43560", VA = "0x182B44160", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<DMDCMEAEHJK?>, YYDKGBIYIEG?>? BRYVTGZLKZD
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x2B428D0", Offset = "0x2B41CD0", VA = "0x182B428D0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x2B44550", Offset = "0x2B43950", VA = "0x182B44550", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2B461F0", Offset = "0x2B455F0", VA = "0x182B461F0")]
		private MWYZLKDYPBY(bool a, SCQFSPRNDPD b, bool c, ReadOnlyIdArray<KYLBZYJNRQF, UZOCHGIXCHS> inputs, ReadOnlyIdArray<KYLBZYJNRQF, FTGNFXPNPTP> inputsAsStaticInputs, SIDFNDXEBQO d, ReadOnlyIdArray<DMDCMEAEHJK, TVZFGYDTXEJ> outputs, ReadOnlyIdArray<DMDCMEAEHJK, YYDKGBIYIEG> outputsAsStaticOutputs, string? overrideName, HZIXAFMUVRH e, Id32<IWTLBCZPUHH> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2B42C70", Offset = "0x2B42070", VA = "0x182B42C70")]
		public static MWYZLKDYPBY New(bool canInteract, SCQFSPRNDPD circuitsManager, bool hasFunctionHeader, SIDFNDXEBQO node, HZIXAFMUVRH portGroup, Id32<IWTLBCZPUHH> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2B419F0", Offset = "0x2B40DF0", VA = "0x182B419F0", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2B41E80", Offset = "0x2B41280", VA = "0x182B41E80", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, SKKNIPYCQUO?>>? ESOCTFXADPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2B44260", Offset = "0x2B43660", VA = "0x182B44260")]
		private (UXHMTADIDLR?, int)? VYLVTMPVCJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2B43A70", Offset = "0x2B42E70", VA = "0x182B43A70", Slot = "58")]
		private void QIQHQXULLLC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x23A9D20", Offset = "0x23A9120", VA = "0x1823A9D20", Slot = "57")]
		private void EGHFIFXKMHB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2B42120", Offset = "0x2B41520", VA = "0x182B42120", Slot = "61")]
		private void GKNNASLAPUF(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2B43F90", Offset = "0x2B43390", VA = "0x182B43F90", Slot = "63")]
		private void TBGHRQTRJCU(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2B44ED0", Offset = "0x2B442D0", VA = "0x182B44ED0", Slot = "50")]
		private void XIABAGINXBF(int a, Id32<KYLBZYJNRQF> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2B44850", Offset = "0x2B43C50", VA = "0x182B44850", Slot = "54")]
		private void XAVWJEVDQSM(int a, Id32<KYLBZYJNRQF> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2B44020", Offset = "0x2B43420", VA = "0x182B44020", Slot = "49")]
		private void TOSDUMARIVA(int a, Id32<KYLBZYJNRQF> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2B414E0", Offset = "0x2B408E0", VA = "0x182B414E0", Slot = "53")]
		private void COUZSQHYOFJ(int a, Id32<KYLBZYJNRQF> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2B459A0", Offset = "0x2B44DA0", VA = "0x182B459A0", Slot = "66")]
		private void XTRFGZZYVCH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x10FFE20", Offset = "0x10FF220", VA = "0x1810FFE20", Slot = "65")]
		private void ABQDSXBXUEE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2B42730", Offset = "0x2B41B30", VA = "0x182B42730", Slot = "60")]
		private void JOOBAPFJIGX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x23A9D20", Offset = "0x23A9120", VA = "0x1823A9D20", Slot = "59")]
		private void MZLDXXTEIQK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2B43360", Offset = "0x2B42760", VA = "0x182B43360", Slot = "62")]
		private void PCAVONREUSM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2B42840", Offset = "0x2B41C40", VA = "0x182B42840", Slot = "64")]
		private void JOYKSMTQALF(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2B44870", Offset = "0x2B43C70", VA = "0x182B44870", Slot = "52")]
		private void XDUGNDCDOBI(int a, Id32<DMDCMEAEHJK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2B44240", Offset = "0x2B43640", VA = "0x182B44240", Slot = "56")]
		private void VCFZLAJBWXF(int a, Id32<DMDCMEAEHJK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2B44220", Offset = "0x2B43620", VA = "0x182B44220", Slot = "51")]
		private void USFVWDMTRGJ(int a, Id32<DMDCMEAEHJK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2B45480", Offset = "0x2B44880", VA = "0x182B45480", Slot = "55")]
		private void XPHHYKRHKBU(int a, Id32<DMDCMEAEHJK> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2B43730", Offset = "0x2B42B30", VA = "0x182B43730", Slot = "68")]
		private void PFQXUJZNFYE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x10FFE20", Offset = "0x10FF220", VA = "0x1810FFE20", Slot = "67")]
		private void KQSDSJXJADD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B44610", Offset = "0x2B43A10", VA = "0x182B44610", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, SKKNIPYCQUO?>>? WWGSEVXXBAR(Id32<CPMNZXWNEQO> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2B412E0", Offset = "0x2B406E0", VA = "0x182B412E0", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, SKKNIPYCQUO?>>? BDPVABHPJDI(Id32<CDTRWUZOHPN> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2B43CF0", Offset = "0x2B430F0", VA = "0x182B43CF0", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, SKKNIPYCQUO?>>? RXDPDOVCYXZ(Id32<CPMNZXWNEQO> inputDefId, Id32<CPMNZXWNEQO> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2B46010", Offset = "0x2B45410", VA = "0x182B46010", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, SKKNIPYCQUO?>>? ZDMJYYGEWZY(Id32<CDTRWUZOHPN> outputDefId, Id32<CDTRWUZOHPN> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2B413F0", Offset = "0x2B407F0", VA = "0x182B413F0", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, SKKNIPYCQUO?>>? BWZMNASLLJT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2B44040", Offset = "0x2B43440", VA = "0x182B44040", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, SKKNIPYCQUO>> UCEDOOSLWDS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2B44720", Offset = "0x2B43B20", VA = "0x182B44720", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, SKKNIPYCQUO>> WZACCLTYLAP(Id32<CPMNZXWNEQO> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2B411B0", Offset = "0x2B405B0", VA = "0x182B411B0", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, SKKNIPYCQUO>> ASXDPRDJQSI(Id32<CDTRWUZOHPN> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2B438A0", Offset = "0x2B42CA0", VA = "0x182B438A0", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, SKKNIPYCQUO>> PPOXCRLUFCQ(Id32<CPMNZXWNEQO> inputDefId, UGXJSTBRSTY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x2B45B10", Offset = "0x2B44F10", VA = "0x182B45B10", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, SKKNIPYCQUO>> YDTHKYMTMUV(Id32<CDTRWUZOHPN> outputDefId, UGXJSTBRSTY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x2B45C40", Offset = "0x2B45040", VA = "0x182B45C40")]
		internal void YUFCQFRPQND(Id32<IWTLBCZPUHH> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class MRKIPKACQWY : FXFXXQDTBDJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public interface TVWXLXTXIIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public readonly IReadOnlyDictionary<Id128<EVDWFGHNUCH>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x600065F")]
				[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<EVDWFGHNUCH>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			YCULPWATBNY YCULPWATBNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> EYVMOXETNRF(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> GASTZJKRRTY(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<AGCAQUBJINY> FTGJZLWEYWN(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<KWFNBZIYXRE> DELLMRPYBPA(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> GVQDTUPMPYH(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> RFHWXQJHTKK(CancellationToken a);
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
			public AsyncTaskMethodBuilder<MRKIPKACQWY> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public SCQFSPRNDPD circuitsManager;

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
			private TVWXLXTXIIP <selfDeps>5__2;

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
			private AGCAQUBJINY <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private KWFNBZIYXRE <playerSaveData>5__8;

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
			private TaskAwaiter<AGCAQUBJINY> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<KWFNBZIYXRE> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<TVWXLXTXIIP.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<KDLKXLCXLMQ> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BA40", Offset = "0x2B4AE40", VA = "0x182B4BA40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x2B4CC20", Offset = "0x2B4C020", VA = "0x182B4CC20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public KDLKXLCXLMQ KDLKXLCXLMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public RRXEAUEVTFM RRXEAUEVTFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public VDNOBGZVMNF VDNOBGZVMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public GTAENSCVUIX GTAENSCVUIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x1111B20", Offset = "0x1110F20", VA = "0x181111B20")]
		private MRKIPKACQWY(KDLKXLCXLMQ a, RRXEAUEVTFM b, VDNOBGZVMNF c, GTAENSCVUIX d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x2B40EC0", Offset = "0x2B402C0", VA = "0x182B40EC0")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__1))]
		public static Task<MRKIPKACQWY> ORCLVUGGPID(SCQFSPRNDPD a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x2B40EA0", Offset = "0x2B402A0", VA = "0x182B40EA0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class IZAYKUKXVZO : NTAHRWUKVWD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly SCQFSPRNDPD AIEUPWPRETM;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public HUOLMPMBVFC? LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BC30", Offset = "0x2B3B030", VA = "0x182B3BC30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		internal IZAYKUKXVZO(SCQFSPRNDPD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public sealed class VDNOBGZVMNF : HUOLMPMBVFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly SCQFSPRNDPD AIEUPWPRETM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly KDLKXLCXLMQ MWLZAPZGSAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly IZAYKUKXVZO MNLKIJDBANL;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IEnumerable<string> EWLEIKLTMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x2B517C0", Offset = "0x2B50BC0", VA = "0x182B517C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xDE3B70", Offset = "0xDE2F70", VA = "0x180DE3B70")]
		public VDNOBGZVMNF(SCQFSPRNDPD a, KDLKXLCXLMQ b, IZAYKUKXVZO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x2B51800", Offset = "0x2B50C00", VA = "0x182B51800", Slot = "5")]
		public string XBFDFKOCGVT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2B51760", Offset = "0x2B50B60", VA = "0x182B51760", Slot = "6")]
		public void WHLIKHFYYHW(string a, string b)
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x2B62460", Offset = "0x2B61860", VA = "0x182B62460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2B626A0", Offset = "0x2B61AA0", VA = "0x182B626A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<bool, SKKNIPYCQUO>> <>t__builder;

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
			private PXBFMCKNGBK[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x2B62EC0", Offset = "0x2B622C0", VA = "0x182B62EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x2B63290", Offset = "0x2B62690", VA = "0x182B63290", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public PXBFMCKNGBK action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x2B675C0", Offset = "0x2B669C0", VA = "0x182B675C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x2B679D0", Offset = "0x2B66DD0", VA = "0x182B679D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly OKXJRNOVLSL _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		public EVRequestExtended(OKXJRNOVLSL staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AB90", Offset = "0x2B39F90", VA = "0x182B3AB90")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, SKKNIPYCQUO>> CKKCUEZVRXJ(PXBFMCKNGBK a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ADB0", Offset = "0x2B3A1B0", VA = "0x182B3ADB0")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, SKKNIPYCQUO?>>? FMDFETDNGQY(int a, CircuitRootData? b, SuperRoomData? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ACC0", Offset = "0x2B3A0C0", VA = "0x182B3ACC0")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, SKKNIPYCQUO>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface YVXKSJHRTOX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		FXFXXQDTBDJ? LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		bool QFETFMDYOWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<FXFXXQDTBDJ?>? MAXPAVPQBZJ();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task PSTDLVTOSEQ(SCQFSPRNDPD a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface FXFXXQDTBDJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		KDLKXLCXLMQ KDLKXLCXLMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		RRXEAUEVTFM RRXEAUEVTFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		VDNOBGZVMNF VDNOBGZVMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		GTAENSCVUIX GTAENSCVUIX
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public static class BFWXZRVIWPG
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x2B55DE0", Offset = "0x2B551E0", VA = "0x182B55DE0")]
		public static ReducerFactory<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD, VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>> AJFJSBSNIYB([In] this ReducerFactory<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD, VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD, VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public sealed class LUGKKKAXEJR : WXLIWCAZLHS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly SCQFSPRNDPD AIEUPWPRETM;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool QFETFMDYOWW
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x2B615F0", Offset = "0x2B609F0", VA = "0x182B615F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		internal LUGKKKAXEJR(SCQFSPRNDPD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal sealed class EKOLSYIPVJG : IEGBCYAADQN
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2B566F0", Offset = "0x2B55AF0", VA = "0x182B566F0", Slot = "4")]
		public JCZEVXLPZMD? ZOOSSAVMULC(string? a, string? b, string? c, RoomDoorData.UJFQYTKYYVN.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2B56620", Offset = "0x2B55A20", VA = "0x182B56620", Slot = "5")]
		public JPEVYQHKZXV XNACGABJNFI(string a, string b, List<string> c, int d, int e, int f, int g, YQUPAYKCXQL h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x2B56580", Offset = "0x2B55980", VA = "0x182B56580", Slot = "6")]
		public YQUPAYKCXQL NODUGADVYLW(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public EKOLSYIPVJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public sealed class HZSRCXEYKHG : HUUIBWGGLCL
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
			public AsyncTaskMethodBuilder<UOXIAFFGFEM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public HZSRCXEYKHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private TaskAwaiter<FXFXXQDTBDJ?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2B62710", Offset = "0x2B61B10", VA = "0x182B62710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2B629C0", Offset = "0x2B61DC0", VA = "0x182B629C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly SCQFSPRNDPD AIEUPWPRETM;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public UOXIAFFGFEM? LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x2B60690", Offset = "0x2B5FA90", VA = "0x182B60690", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public GTAENSCVUIX? HFYQEQPRHLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2B609E0", Offset = "0x2B5FDE0", VA = "0x182B609E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool ITAPMLTPLOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x2B60890", Offset = "0x2B5FC90", VA = "0x182B60890", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool DCGLGJAZGZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x2B60A60", Offset = "0x2B5FE60", VA = "0x182B60A60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2B60CC0", Offset = "0x2B600C0", VA = "0x182B60CC0")]
		internal HZSRCXEYKHG(SCQFSPRNDPD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2B608F0", Offset = "0x2B5FCF0", VA = "0x182B608F0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<UOXIAFFGFEM> MAXPAVPQBZJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2B60310", Offset = "0x2B5F710", VA = "0x182B60310", Slot = "9")]
		public IReadOnlyDictionary<Id128<EVDWFGHNUCH>, Guid> AXDMWBDFDLB(IEnumerable<TEAIRTFLUOM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2B60710", Offset = "0x2B5FB10", VA = "0x182B60710", Slot = "10")]
		public CircuitGraphToolMappingRegistryData KIQQHYSDKDB(IEnumerable<TEAIRTFLUOM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x2B60AF0", Offset = "0x2B5FEF0", VA = "0x182B60AF0")]
		public Result<CircuitsRoomData, FWOTOTOBXEY> VQOXVYPGHJZ([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, FWOTOTOBXEY>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x2B60AC0", Offset = "0x2B5FEC0", VA = "0x182B60AC0", Slot = "8")]
		private Result<CircuitsRoomData, FWOTOTOBXEY> RPDPHWQWPFQ([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, FWOTOTOBXEY>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class GTAENSCVUIX : UOXIAFFGFEM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		internal static class FAIQXTBWCNQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			[CompilerGenerated]
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public int AAPRVUEHVJX;

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x2B615D0", Offset = "0x2B609D0", VA = "0x182B615D0")]
				internal void ROPOZUQLOGI(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x2B56780", Offset = "0x2B55B80", VA = "0x182B56780")]
			public static Result<UOXIAFFGFEM.PrepareTemplateForCloneResult, YUGSJIPXOCB> KJOHUMGZAWL(GTAENSCVUIX a, [In] UOXIAFFGFEM.PrepareTemplateForCloneArgs args)
			{
				return default(Result<UOXIAFFGFEM.PrepareTemplateForCloneResult, YUGSJIPXOCB>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2B56C90", Offset = "0x2B56090", VA = "0x182B56C90")]
			internal static Result<(UNMNEIHQWSM, CircuitTemplateRootData), YUGSJIPXOCB> KYNMBDZQFOF(GTAENSCVUIX a, CircuitTemplateRootData b, bool c, [In] Id128<EVDWFGHNUCH> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(UNMNEIHQWSM, CircuitTemplateRootData), YUGSJIPXOCB>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2B58390", Offset = "0x2B57790", VA = "0x182B58390")]
			private static void ZIRKVBLFARF(bool a, TEAIRTFLUOM b, UNMNEIHQWSM c, [In] Id128<EVDWFGHNUCH> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2B579F0", Offset = "0x2B56DF0", VA = "0x182B579F0")]
			public static void TRFDELYTDWY(NOJIAPKTUHF a, [In] UOXIAFFGFEM.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x2B57E00", Offset = "0x2B57200", VA = "0x182B57E00")]
			[CompilerGenerated]
			internal static bool XZJJZLCQKYN(KDLKXLCXLMQ a, ZBZCNYAIBZN b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x2B579C0", Offset = "0x2B56DC0", VA = "0x182B579C0")]
			[CompilerGenerated]
			internal static bool SSVUIVBFYTC(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class LVYVBAQRTVW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public GTAENSCVUIX IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<EVDWFGHNUCH> PIYZYRFPZMI;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public LVYVBAQRTVW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x2B61610", Offset = "0x2B60A10", VA = "0x182B61610")]
			internal Id128<IHXSJTKSKEJ> SDDHQMQIYBF(Id32<IHXSJTKSKEJ> a)
			{
				return default(Id128<IHXSJTKSKEJ>);
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Id32<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Id32<FOQLRVXTRHG> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<NTSCAYGKXQL> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x2B63300", Offset = "0x2B62700", VA = "0x182B63300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x2B638D0", Offset = "0x2B62CD0", VA = "0x182B638D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Id32<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Id32<IHXSJTKSKEJ> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Id32<IWTLBCZPUHH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<CPMNZXWNEQO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x2B63940", Offset = "0x2B62D40", VA = "0x182B63940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2B63C90", Offset = "0x2B63090", VA = "0x182B63C90", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<IHXSJTKSKEJ>, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Id32<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id32<TUBDDYPKAKM> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private KDLKXLCXLMQ <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<Guid, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x2B63FE0", Offset = "0x2B633E0", VA = "0x182B63FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x2B64410", Offset = "0x2B63810", VA = "0x182B64410", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<IHXSJTKSKEJ> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x2B63D00", Offset = "0x2B63100", VA = "0x182B63D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x2B63F70", Offset = "0x2B63370", VA = "0x182B63F70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2B64480", Offset = "0x2B63880", VA = "0x182B64480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2B64670", Offset = "0x2B63A70", VA = "0x182B64670", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Id32<EVDWFGHNUCH> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Id128<IHXSJTKSKEJ> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public List<Id32<IHXSJTKSKEJ>> nodeIds;

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
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2B646E0", Offset = "0x2B63AE0", VA = "0x182B646E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2B64980", Offset = "0x2B63D80", VA = "0x182B64980", Slot = "5")]
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
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public Id128<EVDWFGHNUCH> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<IHXSJTKSKEJ> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IReadOnlyList<Id128<IHXSJTKSKEJ>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<IWTLBCZPUHH>, Id32<KYLBZYJNRQF>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<IWTLBCZPUHH>, Id32<DMDCMEAEHJK>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2B649F0", Offset = "0x2B63DF0", VA = "0x182B649F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2B64FD0", Offset = "0x2B643D0", VA = "0x182B64FD0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id32<EVDWFGHNUCH> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id128<IHXSJTKSKEJ> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<IHXSJTKSKEJ>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x2B65030", Offset = "0x2B64430", VA = "0x182B65030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2B65240", Offset = "0x2B64640", VA = "0x182B65240", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id128<IHXSJTKSKEJ> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id128<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Id32<IWTLBCZPUHH> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Id32<KYLBZYJNRQF> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2B652B0", Offset = "0x2B646B0", VA = "0x182B652B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2B65600", Offset = "0x2B64A00", VA = "0x182B65600", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public Id32<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Id32<IHXSJTKSKEJ> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Id32<IWTLBCZPUHH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id32<CPMNZXWNEQO> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2B65670", Offset = "0x2B64A70", VA = "0x182B65670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2B65A50", Offset = "0x2B64E50", VA = "0x182B65A50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Id32<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Id32<IHXSJTKSKEJ> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2B65AC0", Offset = "0x2B64EC0", VA = "0x182B65AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2B65D40", Offset = "0x2B65140", VA = "0x182B65D40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public Id128<IHXSJTKSKEJ> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public Id128<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Id32<IWTLBCZPUHH> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Id32<DMDCMEAEHJK> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2B65DB0", Offset = "0x2B651B0", VA = "0x182B65DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2B66100", Offset = "0x2B65500", VA = "0x182B66100", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public Id32<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Id32<IHXSJTKSKEJ> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2B66170", Offset = "0x2B65570", VA = "0x182B66170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2B664B0", Offset = "0x2B658B0", VA = "0x182B664B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public Id32<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public Id32<IHXSJTKSKEJ> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2B66520", Offset = "0x2B65920", VA = "0x182B66520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2B667B0", Offset = "0x2B65BB0", VA = "0x182B667B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Id32<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Id32<IHXSJTKSKEJ> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2B66820", Offset = "0x2B65C20", VA = "0x182B66820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2B66AB0", Offset = "0x2B65EB0", VA = "0x182B66AB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<IHXSJTKSKEJ>>, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Id128<EVDWFGHNUCH> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public IEnumerable<TEAIRTFLUOM> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private TaskAwaiter<Result<IEnumerable<SIDFNDXEBQO>, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2B66B20", Offset = "0x2B65F20", VA = "0x182B66B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2B672C0", Offset = "0x2B666C0", VA = "0x182B672C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public Id32<EVDWFGHNUCH> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public Id128<IHXSJTKSKEJ> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public Id32<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public List<Id32<IHXSJTKSKEJ>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2B67330", Offset = "0x2B66730", VA = "0x182B67330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2B67550", Offset = "0x2B66950", VA = "0x182B67550", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public GTAENSCVUIX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Id32<EVDWFGHNUCH> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Id32<IHXSJTKSKEJ> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x2B67AB0", Offset = "0x2B66EB0", VA = "0x182B67AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x2B67CD0", Offset = "0x2B670D0", VA = "0x182B67CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly SCQFSPRNDPD AIEUPWPRETM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly KDLKXLCXLMQ MWLZAPZGSAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly PrimitivePortGroupModifiers FXSONWLVFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly HZSRCXEYKHG IIWAWDZSLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Dictionary<Id128<IHXSJTKSKEJ>, FEGMTBIBNYX> HLMMSEWRBQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[CompilerGenerated]
		private Action<Id128<IHXSJTKSKEJ>>? TSXREKLLGAL;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public Id128<EVDWFGHNUCH> YZNHEAPWILS
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F4F0", Offset = "0x2B5E8F0", VA = "0x182B5F4F0", Slot = "4")]
			get
			{
				return default(Id128<EVDWFGHNUCH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PrimitivePortGroupModifiers TDSHTRHJXUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2B59420", Offset = "0x2B58820", VA = "0x182B59420", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IReadOnlyList<string> FZCYCVZNIKG
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BCF0", Offset = "0x2B5B0F0", VA = "0x182B5BCF0", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action LUXJMUGXPJP
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B59580", Offset = "0x2B58980", VA = "0x182B59580", Slot = "93")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B5F400", Offset = "0x2B5E800", VA = "0x182B5F400", Slot = "94")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> XSKEWJCIJGX
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BB50", Offset = "0x2B5AF50", VA = "0x182B5BB50", Slot = "95")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E430", Offset = "0x2B5D830", VA = "0x182B5E430", Slot = "96")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FEB0", Offset = "0x2B5F2B0", VA = "0x182B5FEB0")]
		public GTAENSCVUIX(SCQFSPRNDPD a, KDLKXLCXLMQ b, HZSRCXEYKHG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2B59730", Offset = "0x2B58B30", VA = "0x182B59730", Slot = "99")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F440", Offset = "0x2B5E840", VA = "0x182B5F440", Slot = "100")]
		public Id32<QCLVEBCCAXX> WDMCFKBJXOG(Id32<EVDWFGHNUCH> graphId, Id32<NTSCAYGKXQL> inputId)
		{
			return default(Id32<QCLVEBCCAXX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C9D0", Offset = "0x2B5BDD0", VA = "0x182B5C9D0", Slot = "101")]
		public Id32<CGLAUUPHKVS> OLXZZOGVGVL(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> outputId)
		{
			return default(Id32<CGLAUUPHKVS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BDA0", Offset = "0x2B5B1A0", VA = "0x182B5BDA0", Slot = "6")]
		public (bool, bool) MAVTGUCBDXY(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E130", Offset = "0x2B5D530", VA = "0x182B5E130")]
		public bool SELZEMKFEVV(Id32<EVDWFGHNUCH> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B330", Offset = "0x2B5A730", VA = "0x182B5B330", Slot = "8")]
		public bool HCQASWEMJOL(FTGNFXPNPTP a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B7D0", Offset = "0x2B5ABD0", VA = "0x182B5B7D0", Slot = "9")]
		public bool IERIYPABHNM(YYDKGBIYIEG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EE00", Offset = "0x2B5E200", VA = "0x182B5EE00", Slot = "10")]
		public AbsoluteLegacyInputId? VDFXLUJIMDP(Id32<EVDWFGHNUCH> graphId, Id32<NTSCAYGKXQL> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F8B0", Offset = "0x2B5ECB0", VA = "0x182B5F8B0", Slot = "11")]
		public AbsoluteLegacyOutputId? YOHRKWZEWCY(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C4C0", Offset = "0x2B5B8C0", VA = "0x182B5C4C0", Slot = "12")]
		public Id32<FOQLRVXTRHG>? NRIZYPGKCMO(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId, Id32<DMDCMEAEHJK> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AC00", Offset = "0x2B5A000", VA = "0x182B5AC00", Slot = "13")]
		public Id32<NTSCAYGKXQL>? GETGRQDWFLZ(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId, Id32<KYLBZYJNRQF> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B58AD0", Offset = "0x2B57ED0", VA = "0x182B58AD0", Slot = "14")]
		public IEnumerable<Id32<EVDWFGHNUCH>> AZIYJSJSIRV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FA50", Offset = "0x2B5EE50", VA = "0x182B5FA50", Slot = "15")]
		public IEnumerable<Id32<AXCQMZDPZIR>> YTPVQQQTRZS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BB70", Offset = "0x2B5AF70", VA = "0x182B5BB70", Slot = "22")]
		public string KBXWUNYDBUU(Id32<AXCQMZDPZIR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B440", Offset = "0x2B5A840", VA = "0x182B5B440", Slot = "16")]
		public Id32<AXCQMZDPZIR>? HLOLSCMBLDK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E710", Offset = "0x2B5DB10", VA = "0x182B5E710", Slot = "17")]
		public int TLDEMCZWNKZ(Id32<AXCQMZDPZIR> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AA80", Offset = "0x2B59E80", VA = "0x182B5AA80", Slot = "18")]
		public int GCIQMGDOTKG(Id32<AXCQMZDPZIR> functionDeclId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B58CB0", Offset = "0x2B580B0", VA = "0x182B58CB0", Slot = "19")]
		public (CircuitTypeIdWrapper, string)[] BNYQDQXMFLJ(Id32<AXCQMZDPZIR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B595A0", Offset = "0x2B589A0", VA = "0x182B595A0", Slot = "20")]
		public (CircuitTypeIdWrapper, string)[] DOQVBPDLXOE(Id32<AXCQMZDPZIR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3AC1D90", Offset = "0x3AC1190", VA = "0x183AC1D90")]
		private static (CircuitTypeIdWrapper, string?)[]? ISEUQURKLGV<a>([In] IdUnsafeList<a, NamedType> list)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E100", Offset = "0x2B5D500", VA = "0x182B5E100", Slot = "21")]
		public string RYUNMLVNWIA(Id32<AXCQMZDPZIR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B990", Offset = "0x2B5AD90", VA = "0x182B5B990", Slot = "23")]
		public string IZBUSTDKLHD(Id32<AXCQMZDPZIR> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B59600", Offset = "0x2B58A00", VA = "0x182B59600")]
		public FEGMTBIBNYX? DZDLTAFHLTM([In] Id128<IHXSJTKSKEJ> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F600", Offset = "0x2B5EA00", VA = "0x182B5F600", Slot = "30")]
		public Id32<TUBDDYPKAKM> WXVVYOKXMAY(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(Id32<TUBDDYPKAKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B58E00", Offset = "0x2B58200", VA = "0x182B58E00")]
		public Id32<IHXSJTKSKEJ> CZQKCSNGRXZ(Id32<EVDWFGHNUCH> graphId, [In] Id128<IHXSJTKSKEJ> legacyNodeId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B58B40", Offset = "0x2B57F40", VA = "0x182B58B40", Slot = "40")]
		public Id32<IHXSJTKSKEJ> BBSADPLRKQI(Id32<EVDWFGHNUCH> graphId, Id32<NTSCAYGKXQL> inputId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E6F0", Offset = "0x2B5DAF0", VA = "0x182B5E6F0", Slot = "41")]
		public Id32<IHXSJTKSKEJ> SZXXYNSKHHN(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> outputId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EDB0", Offset = "0x2B5E1B0", VA = "0x182B5EDB0")]
		public Id32<IHXSJTKSKEJ>? UJTMBIFLWJJ(Id32<EVDWFGHNUCH> graphId, [In] Id128<IHXSJTKSKEJ> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DBE0", Offset = "0x2B5CFE0", VA = "0x182B5DBE0", Slot = "32")]
		public AbsoluteNodeId? RLXMBJMEVOJ(Id32<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BA40", Offset = "0x2B5AE40", VA = "0x182B5BA40", Slot = "33")]
		public long JCFZUCFJFTE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C4F0", Offset = "0x2B5B8F0", VA = "0x182B5C4F0")]
		private void NWOCTDERTVU(Id128<IHXSJTKSKEJ> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BBA0", Offset = "0x2B5AFA0", VA = "0x182B5BBA0", Slot = "38")]
		public IEnumerable<(Id32<EVDWFGHNUCH>, Id32<IHXSJTKSKEJ>)> KWQDHPHTPEI(Id32<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B5ABD0", Offset = "0x2B59FD0", VA = "0x182B5ABD0", Slot = "39")]
		public Id32<NTSCAYGKXQL> GETGRQDWFLZ(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<QCLVEBCCAXX> inputIndex)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C490", Offset = "0x2B5B890", VA = "0x182B5C490", Slot = "42")]
		public Id32<FOQLRVXTRHG> NRIZYPGKCMO(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<CGLAUUPHKVS> outputIndex)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B760", Offset = "0x2B5AB60", VA = "0x182B5B760")]
		private FEGMTBIBNYX? HVODZHXHDQN([In] Id128<IHXSJTKSKEJ> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E870", Offset = "0x2B5DC70", VA = "0x182B5E870")]
		public SIDFNDXEBQO? UFXJNPAVIUX([In] Id128<IHXSJTKSKEJ> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A1D0", Offset = "0x2B595D0", VA = "0x182B5A1D0")]
		public HZDTNYOITFT? FGGOFMRHMEK([In] Id128<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A180", Offset = "0x2B59580", VA = "0x182B5A180", Slot = "25")]
		public HZDTNYOITFT? FGGOFMRHMEK(Id32<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E060", Offset = "0x2B5D460", VA = "0x182B5E060", Slot = "34")]
		public IEnumerable<NewStaticEdge> RSPQMCREOGW(Id32<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B700", Offset = "0x2B5AB00", VA = "0x182B5B700", Slot = "35")]
		public bool HOFPYJNBWFQ(Id32<AXCQMZDPZIR> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FC60", Offset = "0x2B5F060", VA = "0x182B5FC60", Slot = "36")]
		public IEnumerable<StableStaticEdge> ZXMGATTCWTY(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F660", Offset = "0x2B5EA60", VA = "0x182B5F660", Slot = "37")]
		public IEnumerable<StableStaticEdge> YMORBTGUIWB(Id32<EVDWFGHNUCH> graphId, Id32<NTSCAYGKXQL> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CB30", Offset = "0x2B5BF30", VA = "0x182B5CB30")]
		public Id32<EVDWFGHNUCH> ORZHFJHYWJV([In] Id128<EVDWFGHNUCH> graphId)
		{
			return default(Id32<EVDWFGHNUCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B58D10", Offset = "0x2B58110", VA = "0x182B58D10")]
		public Id32<EVDWFGHNUCH>? POOOXVDCFBR([In] Id128<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AC30", Offset = "0x2B5A030", VA = "0x182B5AC30")]
		private ZBZCNYAIBZN? GFIOBYXCXQZ([In] Id128<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A1D0", Offset = "0x2B595D0", VA = "0x182B5A1D0")]
		private HZDTNYOITFT? FZVHGPQFTOE([In] Id128<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E760", Offset = "0x2B5DB60", VA = "0x182B5E760", Slot = "28")]
		public Id32<EVDWFGHNUCH>? UEVKCYDNROW(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F420", Offset = "0x2B5E820", VA = "0x182B5F420", Slot = "46")]
		public Id128<EVDWFGHNUCH> VVWVZQOBKDI(Id32<EVDWFGHNUCH> graphId)
		{
			return default(Id128<EVDWFGHNUCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B58E30", Offset = "0x2B58230", VA = "0x182B58E30", Slot = "47")]
		public Id128<IHXSJTKSKEJ> CBCXLIRRDAA(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(Id128<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B58E50", Offset = "0x2B58250", VA = "0x182B58E50", Slot = "43")]
		public IEnumerable<UGXJSTBRSTY> CFFIHVGJCZY(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B5ACD0", Offset = "0x2B5A0D0", VA = "0x182B5ACD0", Slot = "44")]
		public UGXJSTBRSTY GKOXEXVHTQX(RoomVersion a, IKOBMFTUZAY b, bool c, bool d, bool e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BA60", Offset = "0x2B5AE60", VA = "0x182B5BA60")]
		public NewStaticEdge JLIXUDJKZWF(Id32<EVDWFGHNUCH> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F230", Offset = "0x2B5E630", VA = "0x182B5F230", Slot = "48")]
		public StableStaticEdge VKDJXGFXGEE(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B58B60", Offset = "0x2B57F60", VA = "0x182B58B60", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__82))]
		public Task<Result<None, SKKNIPYCQUO>> BGXEZIGXHAJ(Id32<EVDWFGHNUCH> parentGraphId, Id32<IHXSJTKSKEJ> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C7F0", Offset = "0x2B5BBF0", VA = "0x182B5C7F0", Slot = "50")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__83))]
		public Task<Result<None, SKKNIPYCQUO>> OFLEYCZCMEE(Id32<EVDWFGHNUCH> parentGraphId, Id128<IHXSJTKSKEJ> boardNodeId, List<Id32<IHXSJTKSKEJ>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C260", Offset = "0x2B5B660", VA = "0x182B5C260", Slot = "53")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__84))]
		public Task<Result<None, SKKNIPYCQUO>> NECMJTRXGDH(Id32<EVDWFGHNUCH> parentGraphId, Id128<IHXSJTKSKEJ> boardNodeId, List<Id32<IHXSJTKSKEJ>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B58F50", Offset = "0x2B58350", VA = "0x182B58F50", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__85))]
		public Task<Result<None, SKKNIPYCQUO>> CHHSIDBJJQL(Id32<EVDWFGHNUCH> parentGraphId, Id128<IHXSJTKSKEJ> boardNodeId, Id32<EVDWFGHNUCH> graphId, List<Id32<IHXSJTKSKEJ>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B060", Offset = "0x2B5A460", VA = "0x182B5B060", Slot = "51")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<IWTLBCZPUHH>, Id32<KYLBZYJNRQF>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<IWTLBCZPUHH>, Id32<DMDCMEAEHJK>)>) GZPCEASLKNW(Id128<EVDWFGHNUCH> legacyGraphId, Id32<IHXSJTKSKEJ> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<IWTLBCZPUHH>, Id32<KYLBZYJNRQF>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<IWTLBCZPUHH>, Id32<DMDCMEAEHJK>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A860", Offset = "0x2B59C60", VA = "0x182B5A860", Slot = "52")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__87))]
		public Task FHDMWDJFJCK(Id128<EVDWFGHNUCH> legacyGraphId, Id128<IHXSJTKSKEJ> boardNodeId, IReadOnlyList<Id128<IHXSJTKSKEJ>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<IWTLBCZPUHH>, Id32<KYLBZYJNRQF>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<IWTLBCZPUHH>, Id32<DMDCMEAEHJK>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BD10", Offset = "0x2B5B110", VA = "0x182B5BD10", Slot = "55")]
		public bool LSYTMXRPQLY(Id32<EVDWFGHNUCH> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F640", Offset = "0x2B5EA40", VA = "0x182B5F640", Slot = "56")]
		public bool YASTVYYXNUW(Id32<EVDWFGHNUCH> graphId, Id32<NTSCAYGKXQL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EDE0", Offset = "0x2B5E1E0", VA = "0x182B5EDE0", Slot = "57")]
		public bool UPNBDKCDKXJ(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E730", Offset = "0x2B5DB30", VA = "0x182B5E730")]
		public Result<UOXIAFFGFEM.PrepareTemplateForCloneResult, YUGSJIPXOCB> YMPURUQIZAX([In] UOXIAFFGFEM.PrepareTemplateForCloneArgs args)
		{
			return default(Result<UOXIAFFGFEM.PrepareTemplateForCloneResult, YUGSJIPXOCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AAA0", Offset = "0x2B59EA0", VA = "0x182B5AAA0", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__101))]
		public Task<Result<None, SKKNIPYCQUO>> GCJTXZBBSST(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D750", Offset = "0x2B5CB50", VA = "0x182B5D750", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__103))]
		public Task<Result<Id32<IHXSJTKSKEJ>, SKKNIPYCQUO>> QFFBTZDXZFM(Id32<EVDWFGHNUCH> graphId, Id32<TUBDDYPKAKM> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C9F0", Offset = "0x2B5BDF0", VA = "0x182B5C9F0", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__104))]
		public Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> ORJETLIIWNR(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DCE0", Offset = "0x2B5D0E0", VA = "0x182B5DCE0", Slot = "62")]
		public Result<ControlPanelRootData, FWOTOTOBXEY> RSEGGEIFIDZ(Id128<EVDWFGHNUCH> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, FWOTOTOBXEY>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B1D0", Offset = "0x2B5A5D0", VA = "0x182B5B1D0", Slot = "63")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__112))]
		public Task<Result<None, SKKNIPYCQUO>> HCOEWQTKLIH(Id128<EVDWFGHNUCH> graphId, Id128<IHXSJTKSKEJ> inputNodeId, Id32<IWTLBCZPUHH> inputPortGroupId, Id32<KYLBZYJNRQF> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E590", Offset = "0x2B5D990", VA = "0x182B5E590", Slot = "64")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__113))]
		public Task<Result<None, SKKNIPYCQUO>> SXPMORZEXNA(Id128<EVDWFGHNUCH> graphId, Id128<IHXSJTKSKEJ> outputNodeId, Id32<IWTLBCZPUHH> outputPortGroupId, Id32<DMDCMEAEHJK> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B58830", Offset = "0x2B57C30", VA = "0x182B58830", Slot = "65")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__115))]
		public Task<Result<None, SKKNIPYCQUO>> AENTORQGRAT(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CB60", Offset = "0x2B5BF60", VA = "0x182B5CB60", Slot = "66")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__121))]
		public Task<Result<IEnumerable<Id128<IHXSJTKSKEJ>>, SKKNIPYCQUO>> OXNEFSSYWOM(Id128<EVDWFGHNUCH> intoGraphId, CircuitTemplateRootData a, IEnumerable<TEAIRTFLUOM> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F370", Offset = "0x2B5E770", VA = "0x182B5F370", Slot = "67")]
		public CircuitsData VKXZHJUMAQW()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AFD0", Offset = "0x2B5A3D0", VA = "0x182B5AFD0", Slot = "68")]
		public CircuitsData GQIQLKRIUQL()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DA40", Offset = "0x2B5CE40", VA = "0x182B5DA40", Slot = "71")]
		public CircuitsTemplateData RJMJGKPUAAM(TemplateSerializationReason a, Id32<EVDWFGHNUCH> sourceGraphId, IEnumerable<Id128<EVDWFGHNUCH>> graphIds, IEnumerable<Id128<IHXSJTKSKEJ>> nodeIds, ISet<Id128<IBWAZGTULTH>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D8B0", Offset = "0x2B5CCB0", VA = "0x182B5D8B0")]
		private CircuitsTemplateData QKEEKFVLBJX(TemplateSerializationReason a, Id32<EVDWFGHNUCH> sourceGraphId, IEnumerable<Id128<EVDWFGHNUCH>> graphIds, IEnumerable<Id128<IHXSJTKSKEJ>> nodeIds, ISet<Id128<IBWAZGTULTH>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B591C0", Offset = "0x2B585C0", VA = "0x182B591C0", Slot = "69")]
		public CircuitsTemplateData CTHEUXEKKJR(TemplateSerializationReason a, Id32<EVDWFGHNUCH> sourceGraphId, IEnumerable<Id128<IHXSJTKSKEJ>> nodeIds, IEnumerable<TEAIRTFLUOM> b, ISet<Id128<IBWAZGTULTH>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B590B0", Offset = "0x2B584B0", VA = "0x182B590B0", Slot = "70")]
		public CircuitsTemplateData CTHEUXEKKJR(TemplateSerializationReason a, Id32<EVDWFGHNUCH> sourceGraphId, IEnumerable<Id32<IHXSJTKSKEJ>> nodeIds, IEnumerable<TEAIRTFLUOM> b, ISet<Id128<IBWAZGTULTH>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EE60", Offset = "0x2B5E260", VA = "0x182B5EE60")]
		private static IEnumerable<Id128<EVDWFGHNUCH>> VEPCMQTSWNX(IEnumerable<TEAIRTFLUOM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E8B0", Offset = "0x2B5DCB0", VA = "0x182B5E8B0")]
		private IEnumerable<Id128<IHXSJTKSKEJ>> UJOAXYCGASJ(IEnumerable<TEAIRTFLUOM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FC20", Offset = "0x2B5F020", VA = "0x182B5FC20", Slot = "72")]
		public List<PJRODDBAYOY> ZQWSMJTGTEU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A200", Offset = "0x2B59600", VA = "0x182B5A200")]
		public (List<PJRODDBAYOY>, bool) FGNGXBVINCX([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, UOFJVIBRITC b, PINDEHVTQDG c)
		{
			return default((List<PJRODDBAYOY>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B3B0", Offset = "0x2B5A7B0", VA = "0x182B5B3B0", Slot = "74")]
		public bool HKKNRSZVHTU(Id32<EVDWFGHNUCH> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F460", Offset = "0x2B5E860", VA = "0x182B5F460", Slot = "75")]
		public bool WTBEOCSWLFS(Id32<EVDWFGHNUCH> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B58AB0", Offset = "0x2B57EB0", VA = "0x182B58AB0")]
		internal void ANXFLDLALRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B59430", Offset = "0x2B58830", VA = "0x182B59430")]
		internal Task CWTEUTTQMVN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CCC0", Offset = "0x2B5C0C0", VA = "0x182B5CCC0", Slot = "76")]
		public Result<Id32<FOQLRVXTRHG>?, SKKNIPYCQUO> OXTLONEVMYP(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<NTSCAYGKXQL> inputId)
		{
			return default(Result<Id32<FOQLRVXTRHG>?, SKKNIPYCQUO>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B597D0", Offset = "0x2B58BD0", VA = "0x182B597D0", Slot = "77")]
		public Result<Id32<NTSCAYGKXQL>?, SKKNIPYCQUO> EOIZXSFODUT(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<FOQLRVXTRHG> outputId)
		{
			return default(Result<Id32<NTSCAYGKXQL>?, SKKNIPYCQUO>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F510", Offset = "0x2B5E910", VA = "0x182B5F510", Slot = "78")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__141))]
		public Task<Result<None, SKKNIPYCQUO>> WWVWKHEXNAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F910", Offset = "0x2B5ED10", VA = "0x182B5F910", Slot = "79")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__142))]
		public Task<Result<None, SKKNIPYCQUO>> YSKCPZUFBTQ(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A9C0", Offset = "0x2B59DC0", VA = "0x182B5A9C0", Slot = "80")]
		public Id32<IHXSJTKSKEJ>? FYKACFSWNTC(Id32<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BC30", Offset = "0x2B5B030", VA = "0x182B5BC30", Slot = "81")]
		public Id32<IHXSJTKSKEJ>? LBFXPQFRLJX(Id32<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B9B0", Offset = "0x2B5ADB0", VA = "0x182B5B9B0", Slot = "82")]
		public int JAHVSINYGSB(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B594B0", Offset = "0x2B588B0", VA = "0x182B594B0", Slot = "83")]
		public int DFTNYNHVIZA(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D670", Offset = "0x2B5CA70", VA = "0x182B5D670", Slot = "84")]
		public int PIIIVOKXWMH(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId, Id32<CPMNZXWNEQO> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C3B0", Offset = "0x2B5B7B0", VA = "0x182B5C3B0", Slot = "85")]
		public int NIYRCIVCVQN(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId, Id32<CPMNZXWNEQO> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E450", Offset = "0x2B5D850", VA = "0x182B5E450", Slot = "86")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__150))]
		public Task<Result<None, SKKNIPYCQUO>> SRWTFUHIDCN(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId, Id32<CPMNZXWNEQO> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B850", Offset = "0x2B5AC50", VA = "0x182B5B850", Slot = "87")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__151))]
		public Task<Result<None, SKKNIPYCQUO>> ISNCCRGBBFI(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId, Id32<CPMNZXWNEQO> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B58D40", Offset = "0x2B58140", VA = "0x182B58D40", Slot = "88")]
		public int BVGDWYFNZWB(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FAE0", Offset = "0x2B5EEE0", VA = "0x182B5FAE0", Slot = "89")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__154))]
		public Task<Result<None, SKKNIPYCQUO>> YUMFVMIBLDZ(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C690", Offset = "0x2B5BA90", VA = "0x182B5C690", Slot = "90")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__155))]
		public Task<Result<None, SKKNIPYCQUO>> OBSNGZNKRUE(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B58940", Offset = "0x2B57D40", VA = "0x182B58940", Slot = "91")]
		public bool AFGVLATFHIB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F620", Offset = "0x2B5EA20", VA = "0x182B5F620", Slot = "97")]
		public IEnumerable<Id32<CUIQXPIJUFR>> XHBVUHFWLNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C240", Offset = "0x2B5B640", VA = "0x182B5C240", Slot = "98")]
		public string? MWSRSHLTUNV(Id32<CUIQXPIJUFR> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A9B0", Offset = "0x2B59DB0", VA = "0x182B5A9B0", Slot = "7")]
		private bool FKGZLDJRIXR(Id32<EVDWFGHNUCH> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A1D0", Offset = "0x2B595D0", VA = "0x182B5A1D0", Slot = "24")]
		private HZDTNYOITFT QEGZOMVXFWC([In] Id128<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CB30", Offset = "0x2B5BF30", VA = "0x182B5CB30", Slot = "26")]
		private Id32<EVDWFGHNUCH> VULAZILFGNV([In] Id128<EVDWFGHNUCH> graphId)
		{
			return default(Id32<EVDWFGHNUCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2B58D10", Offset = "0x2B58110", VA = "0x182B58D10", Slot = "27")]
		private Id32<EVDWFGHNUCH>? BRREXAOAVYL([In] Id128<EVDWFGHNUCH> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C570", Offset = "0x2B5B970", VA = "0x182B5C570", Slot = "29")]
		private FEGMTBIBNYX OAYKMMQOVOO([In] Id128<IHXSJTKSKEJ> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B58E00", Offset = "0x2B58200", VA = "0x182B58E00", Slot = "31")]
		private Id32<IHXSJTKSKEJ> BVXVSGTMSJB(Id32<EVDWFGHNUCH> graphId, [In] Id128<IHXSJTKSKEJ> legacyNodeId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BA60", Offset = "0x2B5AE60", VA = "0x182B5BA60", Slot = "45")]
		private NewStaticEdge XRJTTFYBGGZ(Id32<EVDWFGHNUCH> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E730", Offset = "0x2B5DB30", VA = "0x182B5E730", Slot = "58")]
		private Result<UOXIAFFGFEM.PrepareTemplateForCloneResult, YUGSJIPXOCB> TPOFMWJKWGX([In] UOXIAFFGFEM.PrepareTemplateForCloneArgs args)
		{
			return default(Result<UOXIAFFGFEM.PrepareTemplateForCloneResult, YUGSJIPXOCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2B59450", Offset = "0x2B58850", VA = "0x182B59450", Slot = "73")]
		private (List<PJRODDBAYOY>, bool) CZVKHUCAETB([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, UOFJVIBRITC b, PINDEHVTQDG c)
		{
			return default((List<PJRODDBAYOY>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BD30", Offset = "0x2B5B130", VA = "0x182B5BD30")]
		[CompilerGenerated]
		private OUBQYYFKGGX LUSRHANVWNW(BSJAKYMSOCV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C970", Offset = "0x2B5BD70", VA = "0x182B5C970")]
		[CompilerGenerated]
		private SIDFNDXEBQO TYMUUYEHJHW(Id128<IHXSJTKSKEJ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C9A0", Offset = "0x2B5BDA0", VA = "0x182B5C9A0")]
		[CompilerGenerated]
		private ZBZCNYAIBZN TYSBSEYESTF(Id128<EVDWFGHNUCH> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C970", Offset = "0x2B5BD70", VA = "0x182B5C970")]
		[CompilerGenerated]
		private SIDFNDXEBQO OFOXOXULGOU(Id128<IHXSJTKSKEJ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C9A0", Offset = "0x2B5BDA0", VA = "0x182B5C9A0")]
		[CompilerGenerated]
		private ZBZCNYAIBZN OFUEMEOIQAD(Id128<EVDWFGHNUCH> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public sealed class OUBQYYFKGGX : UGXJSTBRSTY
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
			public AsyncTaskMethodBuilder<Result<Id32<CPMNZXWNEQO>, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public OUBQYYFKGGX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public Id128<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public Id128<IHXSJTKSKEJ> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public Id32<IWTLBCZPUHH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<Result<Id32<CPMNZXWNEQO>, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2B61EE0", Offset = "0x2B612E0", VA = "0x182B61EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2B62130", Offset = "0x2B61530", VA = "0x182B62130", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<CDTRWUZOHPN>, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public OUBQYYFKGGX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public Id128<EVDWFGHNUCH> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public Id128<IHXSJTKSKEJ> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public Id32<IWTLBCZPUHH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<Result<Id32<CDTRWUZOHPN>, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x2B621A0", Offset = "0x2B615A0", VA = "0x182B621A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2B623F0", Offset = "0x2B617F0", VA = "0x182B623F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly BSJAKYMSOCV GIBJFYDHTXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly KDLKXLCXLMQ MWLZAPZGSAE;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public TypeKey ZWJOFGQADZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string TNVEBLLBSMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x2B61930", Offset = "0x2B60D30", VA = "0x182B61930", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public BSJAKYMSOCV BSJAKYMSOCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2B61960", Offset = "0x2B60D60", VA = "0x182B61960")]
		public OUBQYYFKGGX(BSJAKYMSOCV a, KDLKXLCXLMQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2B617C0", Offset = "0x2B60BC0", VA = "0x182B617C0", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<CPMNZXWNEQO>, SKKNIPYCQUO>> CBWPKNTKJCC(Id128<EVDWFGHNUCH> graphId, Id128<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2B61650", Offset = "0x2B60A50", VA = "0x182B61650", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<CDTRWUZOHPN>, SKKNIPYCQUO>> ADRNMMMAEUD(Id128<EVDWFGHNUCH> graphId, Id128<IHXSJTKSKEJ> nodeId, Id32<IWTLBCZPUHH> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class UAOBNCRZIPH : FEZAALSEAFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private readonly BSJAKYMSOCV PLBJGNUDMKB;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly HashSet<BSJAKYMSOCV> CIYHUQPYUYB;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly HashSet<BSJAKYMSOCV> GZCYDPXIYXM;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly HashSet<BSJAKYMSOCV> CPDITLDQGZB;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public BSJAKYMSOCV UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x2B69EF0", Offset = "0x2B692F0", VA = "0x182B69EF0", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x2B69EE0", Offset = "0x2B692E0", VA = "0x182B69EE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x2B69F40", Offset = "0x2B69340", VA = "0x182B69F40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2B69E60", Offset = "0x2B69260", VA = "0x182B69E60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2B68210", Offset = "0x2B67610", VA = "0x182B68210")]
		public bool SYQOKEJVQMS(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public UAOBNCRZIPH(BSJAKYMSOCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2B68480", Offset = "0x2B67880", VA = "0x182B68480")]
		internal static TypeKey UYQJIEHUUOD(BSJAKYMSOCV a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2B61930", Offset = "0x2B60D30", VA = "0x182B61930", Slot = "3")]
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
	public readonly struct ActionDeps : UXOUZHAFSJC.YWYJNPIOPIT<PXBFMCKNGBK, None>
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2B55D00", Offset = "0x2B55100", VA = "0x182B55D00", Slot = "4")]
		public int LJNIWHGZZVL(None a, PXBFMCKNGBK b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2B55D60", Offset = "0x2B55160", VA = "0x182B55D60", Slot = "5")]
		public PXBFMCKNGBK SUKXYRHXJHO(None a, PXBFMCKNGBK b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2B55DB0", Offset = "0x2B551B0", VA = "0x182B55DB0", Slot = "6")]
		public PXBFMCKNGBK WXBBESHFYXF(None a, PXBFMCKNGBK b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2B55D20", Offset = "0x2B55120", VA = "0x182B55D20", Slot = "7")]
		public IReadOnlyList<PXBFMCKNGBK> MZIMHHQPCEV(None a, PXBFMCKNGBK b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2B55CF0", Offset = "0x2B550F0", VA = "0x182B55CF0", Slot = "8")]
		public PXBFMCKNGBK[] HYKGVNEHMWA(None a, PXBFMCKNGBK b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2B55CB0", Offset = "0x2B550B0", VA = "0x182B55CB0", Slot = "9")]
		public bool GKYOVMSGEVH(None a, PXBFMCKNGBK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2B55D40", Offset = "0x2B55140", VA = "0x182B55D40", Slot = "10")]
		public bool NBXLACDXBZL(None a, PXBFMCKNGBK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B55D90", Offset = "0x2B55190", VA = "0x182B55D90", Slot = "11")]
		public bool VBIUYEBHXBL(None a, PXBFMCKNGBK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2B55CD0", Offset = "0x2B550D0", VA = "0x182B55CD0", Slot = "12")]
		public bool HWBDZBMNVGV(None a, PXBFMCKNGBK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2B55C90", Offset = "0x2B55090", VA = "0x182B55C90", Slot = "13")]
		public bool BFZIPYUCSBN(None a, PXBFMCKNGBK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2B55D70", Offset = "0x2B55170", VA = "0x182B55D70", Slot = "14")]
		public bool TYGDSSYZSAW(None a, PXBFMCKNGBK b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public abstract class TFJAJMKERNY : ZVMBXFNFHDW
	{
		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract PWJKHDEOEOW.TVWXLXTXIIP WXXFCGPXNMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public abstract SCQFSPRNDPD.TVWXLXTXIIP JFDRWMKNJMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract MRKIPKACQWY.TVWXLXTXIIP IOMTYGDYRLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD> ERJGCPEQSUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x2B61E90", Offset = "0x2B61290", VA = "0x182B61E90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract CV2Request.TVWXLXTXIIP VDVGISORCJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract IKBVPHFPXCS FLFQZBOOYEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract WFYONVKPUQH UZRIBIRYRIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract VRZNIJEJJRF UMJDUIZGJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract PBRLRHMSVSH FOLHVPVJCVE
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public abstract EXVISPQHAEV TDIXQUWTTXC
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected TFJAJMKERNY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public sealed class DLYZWNGBOLQ : TRRIJWHMCHA
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
			public AsyncTaskMethodBuilder<Result<MultiResult, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public IReadOnlyList<PXBFMCKNGBK> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public DLYZWNGBOLQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2B62A30", Offset = "0x2B61E30", VA = "0x182B62A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2B62E50", Offset = "0x2B62250", VA = "0x182B62E50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public DLYZWNGBOLQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public PXBFMCKNGBK action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x2B677C0", Offset = "0x2B66BC0", VA = "0x182B677C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2B67A40", Offset = "0x2B66E40", VA = "0x182B67A40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private readonly OKXJRNOVLSL XGJERDJYPMB;

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public DLYZWNGBOLQ(OKXJRNOVLSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2B56220", Offset = "0x2B55620", VA = "0x182B56220")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, SKKNIPYCQUO>> CKKCUEZVRXJ(PXBFMCKNGBK a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2B56350", Offset = "0x2B55750", VA = "0x182B56350", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, SKKNIPYCQUO>> ZLPQDJKMPQD(IReadOnlyList<PXBFMCKNGBK> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PXBFMCKNGBK, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x12C9430", Offset = "0x12C8830", VA = "0x1812C9430")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PXBFMCKNGBK, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2B61BF0", Offset = "0x2B60FF0", VA = "0x182B61BF0")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public static class KMSFVYHSAWD
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xE18120", Offset = "0xE17520", VA = "0x180E18120")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PXBFMCKNGBK, PartialActionReassemblyDeps> OVWEHRAXJII(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, PXBFMCKNGBK, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public struct PartialActionReassemblyDeps : DKNVYVNLIHG.MDFEQTCPLCK<PartialActionPayload, Id128<PartialActionPayload.M>, PXBFMCKNGBK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2B61A00", Offset = "0x2B60E00", VA = "0x182B61A00", Slot = "7")]
		public PXBFMCKNGBK FDGNOCDNXPC(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x12BDAE0", Offset = "0x12BCEE0", VA = "0x1812BDAE0")]
		public Id128<PartialActionPayload.M> HUUNNCDMJQG([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x1044FE0", Offset = "0x10443E0", VA = "0x181044FE0")]
		public int OSQLGVETQIG([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2B61BE0", Offset = "0x2B60FE0", VA = "0x182B61BE0")]
		public int GNXXQAYPDCF([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x1044FE0", Offset = "0x10443E0", VA = "0x181044FE0", Slot = "4")]
		private int DDQVHQWERMS([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2B61BE0", Offset = "0x2B60FE0", VA = "0x182B61BE0", Slot = "5")]
		private int UYYHQWQAEGR([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x12BDAE0", Offset = "0x12BCEE0", VA = "0x1812BDAE0", Slot = "6")]
		private Id128<PartialActionPayload.M> QFZFZUUEEMS([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		internal SnapshotReassembly<PartialInitializePayload, PXBFMCKNGBK, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x12C9430", Offset = "0x12C8830", VA = "0x1812C9430")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, PXBFMCKNGBK, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B61E30", Offset = "0x2B61230", VA = "0x182B61E30")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public static class QAAHOQQJJZA
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xE18120", Offset = "0xE17520", VA = "0x180E18120")]
		public static SnapshotReassembly<PartialInitializePayload, PXBFMCKNGBK, SnapshotReassemblyDeps> OVWEHRAXJII(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, PXBFMCKNGBK, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct SnapshotReassemblyDeps : BVIZNESWPRV.MDKLNZWMUNT<PartialInitializePayload, PXBFMCKNGBK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x1044FF0", Offset = "0x10443F0", VA = "0x181044FF0")]
		public int GPQQKGDOBMM([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B61C50", Offset = "0x2B61050", VA = "0x182B61C50", Slot = "5")]
		public PXBFMCKNGBK FOGRNCCRJLU(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x1044FF0", Offset = "0x10443F0", VA = "0x181044FF0", Slot = "4")]
		private int VCPSRRKIMYQ([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class VEQWMXEDJOW : OKJLNQTBITD, YUGSJIPXOCB, SKKNIPYCQUO, FWOTOTOBXEY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly FWOTOTOBXEY? QJWEOVICLPG;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public PrepareTemplateForCloneErrKind NDBCZWHGVDW
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xCFFA40", Offset = "0xCFEE40", VA = "0x180CFFA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override FWOTOTOBXEY? POTNOGBXLKN
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A0C0", Offset = "0x2B694C0", VA = "0x182B6A0C0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A290", Offset = "0x2B69690", VA = "0x182B6A290")]
		private VEQWMXEDJOW(PrepareTemplateForCloneErrKind a, FWOTOTOBXEY? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A1C0", Offset = "0x2B695C0", VA = "0x182B6A1C0")]
		public static VEQWMXEDJOW JQZJBTVPUKK(FWOTOTOBXEY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A230", Offset = "0x2B69630", VA = "0x182B6A230")]
		public static VEQWMXEDJOW QKCOWIXPCFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A060", Offset = "0x2B69460", VA = "0x182B6A060")]
		public static VEQWMXEDJOW DOWBYBHRWSS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public static class OGCEHKJTDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x3D3B280", Offset = "0x3D3A680", VA = "0x183D3B280")]
		public static Result<TOk, YUGSJIPXOCB> TIDXZTRBQYL<TOk>([In] this Result<TOk, YUGSJIPXOCB> self, FWOTOTOBXEY a) where TOk : notnull
		{
			return default(Result<TOk, YUGSJIPXOCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x3D3B200", Offset = "0x3D3A600", VA = "0x183D3B200")]
		public static Result<a?, YUGSJIPXOCB?> SQCARLGVHWH<a>([In] this Result<a, YUGSJIPXOCB> self)
		{
			return default(Result<a, YUGSJIPXOCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x3D3B0B0", Offset = "0x3D3A4B0", VA = "0x183D3B0B0")]
		public static Result<b?, YUGSJIPXOCB?> FOROVZSUXFL<b>([In] this Result<b, YUGSJIPXOCB> self)
		{
			return default(Result<b, YUGSJIPXOCB>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface IKBVPHFPXCS
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool EPWKVWMGEBE([In] Result<None, FWOTOTOBXEY> result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public static class YWEXCBMDTLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x411EFF0", Offset = "0x411E3F0", VA = "0x18411EFF0")]
		public static bool EPWKVWMGEBE<TOk, TErr>(this IKBVPHFPXCS a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, FWOTOTOBXEY
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface WFYONVKPUQH
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		ZGJZLOXSVLX CZOLNAMGODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface VRZNIJEJJRF
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor KVBXYIIWLEC(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface CRTWCKFYNLU
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface SKJGKTEEOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TCHNWUTFPWB? HZTPFEOAXTE(Id32<IWTLBCZPUHH> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface JTPSYKOBODZ
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface TCHNWUTFPWB
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JTPSYKOBODZ? XWBYTPSWWWY(Id32<CPMNZXWNEQO> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CRTWCKFYNLU? EHLAEKQQZRJ(Id32<CDTRWUZOHPN> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface PBRLRHMSVSH
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> HMVXOFBXMOL(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface EXVISPQHAEV
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SKJGKTEEOIF? VGECUOROSXG([In] Id128<VOUYFSSRGER> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public sealed class IMTEPDBVOPK
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
			public readonly List<PXBFMCKNGBK> Actions;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B56530", Offset = "0x2B55930", VA = "0x182B56530")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<PXBFMCKNGBK> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2B56480", Offset = "0x2B55880", VA = "0x182B56480")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly QGTTMCBHRBT<Diagnostic> GBANDIWTEPQ;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public static IMTEPDBVOPK LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x2B60F50", Offset = "0x2B60350", VA = "0x182B60F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public bool TIEVGEKNXKE
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xD4A700", Offset = "0xD49B00", VA = "0x180D4A700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xE03EC0", Offset = "0xE032C0", VA = "0x180E03EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B60E90", Offset = "0x2B60290", VA = "0x182B60E90")]
		public void CTBDBZVUHNB(KDLKXLCXLMQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B60FA0", Offset = "0x2B603A0", VA = "0x182B60FA0")]
		public void RFABHJMSGSI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B61280", Offset = "0x2B60680", VA = "0x182B61280")]
		private static string? UBXCNZEHECE([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B61530", Offset = "0x2B60930", VA = "0x182B61530")]
		public IMTEPDBVOPK()
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
