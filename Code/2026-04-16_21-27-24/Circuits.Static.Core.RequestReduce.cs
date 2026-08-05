using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Static.Api;
using Circuits.Static.Utilities;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B93200", Offset = "0x2B92000", VA = "0x182B93200")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.RequestReduce
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate ReduceAction<TActionKind, TPayload> DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload>(TSerializedAction serializedAction);
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal interface HQDZQRZDMPP<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, KXUOEYSOWHL>> OUIDBMKEHPJ(c a, b b, a c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class RISGPTGVJOZ<a, b, c, d> : GFBUJJTFVYG where d : PPKJGVJKAIL.EXOUKTTMMZJ<a, b, c>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly d BJEOXILCYDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly b ALMKXQLPIJP;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x762EE40", Offset = "0x762DC40", VA = "0x18762EE40")]
		public RISGPTGVJOZ([In] d deps, [In] b serializedAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x762EC10", Offset = "0x762DA10", VA = "0x18762EC10", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct ReduceAction<TActionKind, TPayload>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly TActionKind ActionKind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly TPayload Payload;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7835350", Offset = "0x7834150", VA = "0x187835350")]
		internal ReduceAction(TActionKind actionKind, [In] TPayload payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class WAOKLNJSUSF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x40FE5D0", Offset = "0x40FD3D0", VA = "0x1840FE5D0")]
		public static ReduceAction<TActionKind, TPayload> New<TActionKind, TPayload>([In] TActionKind actionKind, [In] TPayload payload)
		{
			return default(ReduceAction<TActionKind, TPayload>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate Task<Result<TOk, TErr>> ReducePayloadAsyncDelegate<TRoot, TPayload, TOk, TErr>(TRoot root, TPayload payload);
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Result<TOk, TErr> ReducePayloadSyncDelegate<TRoot, TPayload, TOk, TErr>(TRoot root, [In] TPayload payload);
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct Reducer<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : PPKJGVJKAIL.EXOUKTTMMZJ<TActionKind, TSerializedAction, TRoot>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <Reduce>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public AsyncTaskMethodBuilder<Result<object?, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Reducer<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6AA6BC0", Offset = "0x6AA59C0", VA = "0x186AA6BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6AA7D50", Offset = "0x6AA6B50", VA = "0x186AA7D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<TActionKind, HQDZQRZDMPP<TSerializedAction, TRoot, TDeps>> _reducers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
		internal Reducer(Dictionary<TActionKind, HQDZQRZDMPP<TSerializedAction, TRoot, TDeps>> reducers, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7837330", Offset = "0x7836130", VA = "0x187837330")]
		[AsyncStateMachine(typeof(Reducer<, , , >.<Reduce>d__3))]
		public Task<Result<object, KXUOEYSOWHL>> OUIDBMKEHPJ(TRoot a, TSerializedAction b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class PPKJGVJKAIL
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public interface EXOUKTTMMZJ<a, b, c>
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			a SQJRFTPNJUV(b a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void NLIDBWXTTVK(c a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void KHNWMNPHRQR(c a, b b);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E550", Offset = "0x3D7D350", VA = "0x183D7E550")]
		internal static Reducer<TActionKind, TSerializedAction, TRoot, TDeps> New<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, HQDZQRZDMPP<TSerializedAction, TRoot, TDeps>> reducers, TDeps deps) where TDeps : EXOUKTTMMZJ<TActionKind, TSerializedAction, TRoot>
		{
			return default(Reducer<TActionKind, TSerializedAction, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal sealed class AZDNQMOUUXR<a, b, c, d>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Dictionary<a, HQDZQRZDMPP<b, c, d>> PWTCSFMXOCU;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		private AZDNQMOUUXR(Dictionary<a, HQDZQRZDMPP<b, c, d>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72003E0", Offset = "0x71FF1E0", VA = "0x1872003E0")]
		public static AZDNQMOUUXR<a, b, c, d> New()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, PPKJGVJKAIL.EXOUKTTMMZJ<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private sealed class HVDUVADKWKZ<e, f, g> : HQDZQRZDMPP<TSerializedAction, TRoot, TDeps> where e : notnull where f : notnull where g : notnull, KXUOEYSOWHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly DeserializeActionDelegate<TActionKind, TSerializedAction, e> NWAAWQCKNWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly ReducePayloadSyncDelegate<TRoot, e, f, g> DMZMRHHFKIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly bool IMPCLVWHZTN;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1D20010", Offset = "0x1D1EE10", VA = "0x181D20010")]
			public HVDUVADKWKZ(DeserializeActionDelegate<TActionKind, TSerializedAction, e> a, ReducePayloadSyncDelegate<TRoot, e, f, g> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x647FD10", Offset = "0x647EB10", VA = "0x18647FD10", Slot = "4")]
			public Task<Result<object, KXUOEYSOWHL>> OUIDBMKEHPJ(TDeps a, TRoot b, TSerializedAction c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private sealed class JLNPWDZGKYU<e, f, g> : HQDZQRZDMPP<TSerializedAction, TRoot, TDeps> where e : notnull where f : notnull where g : notnull, KXUOEYSOWHL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			[CompilerGenerated]
			private struct <Reduce>d__4 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public AsyncTaskMethodBuilder<Result<object?, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public TDeps deps;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public TRoot root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public TSerializedAction serializedAction;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public JLNPWDZGKYU<e, f, g> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private Result<object?, KXUOEYSOWHL> <r>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				private TaskAwaiter<Result<f, g>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x6AA7DC0", Offset = "0x6AA6BC0", VA = "0x186AA7DC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x6AAA710", Offset = "0x6AA9510", VA = "0x186AAA710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly DeserializeActionDelegate<TActionKind, TSerializedAction, e> NWAAWQCKNWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly ReducePayloadAsyncDelegate<TRoot, e, f, g> DMZMRHHFKIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly bool IMPCLVWHZTN;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1D20010", Offset = "0x1D1EE10", VA = "0x181D20010")]
			public JLNPWDZGKYU(DeserializeActionDelegate<TActionKind, TSerializedAction, e> a, ReducePayloadAsyncDelegate<TRoot, e, f, g> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6669090", Offset = "0x6667E90", VA = "0x186669090", Slot = "4")]
			[AsyncStateMachine(typeof(JLNPWDZGKYU<, , >.<Reduce>d__4))]
			public Task<Result<object, KXUOEYSOWHL>> OUIDBMKEHPJ(TDeps a, TRoot b, TSerializedAction c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly AZDNQMOUUXR<TActionKind, TSerializedAction, TRoot, TDeps> _data;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		private ReducerFactory(AZDNQMOUUXR<TActionKind, TSerializedAction, TRoot, TDeps> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7837090", Offset = "0x7835E90", VA = "0x187837090")]
		public static ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> New()
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C070", Offset = "0x3E3AE70", VA = "0x183E3C070")]
		public ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> ONZEEQCPOEC<TPayload, TOk, TErr>(TActionKind a, DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload> b, ReducePayloadSyncDelegate<TRoot, TPayload, TOk, TErr> c, bool d = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KXUOEYSOWHL
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C070", Offset = "0x3E3AE70", VA = "0x183E3C070")]
		public ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> AHFZMMPXPMZ<TPayload, TOk, TErr>(TActionKind a, DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload> b, ReducePayloadAsyncDelegate<TRoot, TPayload, TOk, TErr> c, bool d = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KXUOEYSOWHL
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7837100", Offset = "0x7835F00", VA = "0x187837100")]
		public Reducer<TActionKind, TSerializedAction, TRoot, TDeps> YTMSCNEQASK(TDeps a)
		{
			return default(Reducer<TActionKind, TSerializedAction, TRoot, TDeps>);
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
