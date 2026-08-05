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
		[Cpp2IlInjected.Address(RVA = "0x2B9F1D0", Offset = "0x2B9E5D0", VA = "0x182B9F1D0")]
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
namespace Circuits.Static.Core.RequestReduce
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate ReduceAction<TActionKind, TPayload> DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload>(TSerializedAction serializedAction);
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal interface SAXDENCFKEK<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, SKKNIPYCQUO>> XXACUWNPPVG(c a, b b, a c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class EDXKZSLGFDU<a, b, c, d> : ASXPOOCHMFZ where d : VZLHKDLMKIS.MDFEQTCPLCK<a, b, c>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly d RATSQORCBWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly b SMQMUPHJADU;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5AC36B0", Offset = "0x5AC2AB0", VA = "0x185AC36B0")]
		public EDXKZSLGFDU([In] d deps, [In] b serializedAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5AC35A0", Offset = "0x5AC29A0", VA = "0x185AC35A0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x78B38F0", Offset = "0x78B2CF0", VA = "0x1878B38F0")]
		internal ReduceAction(TActionKind actionKind, [In] TPayload payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MMUMOPZVIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3C02840", Offset = "0x3C01C40", VA = "0x183C02840")]
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
	public readonly struct Reducer<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : VZLHKDLMKIS.MDFEQTCPLCK<TActionKind, TSerializedAction, TRoot>
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
			public AsyncTaskMethodBuilder<Result<object?, SKKNIPYCQUO>> <>t__builder;

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
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6B3DAB0", Offset = "0x6B3CEB0", VA = "0x186B3DAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6B3EC90", Offset = "0x6B3E090", VA = "0x186B3EC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<TActionKind, SAXDENCFKEK<TSerializedAction, TRoot, TDeps>> _reducers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
		internal Reducer(Dictionary<TActionKind, SAXDENCFKEK<TSerializedAction, TRoot, TDeps>> reducers, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78B5D70", Offset = "0x78B5170", VA = "0x1878B5D70")]
		[AsyncStateMachine(typeof(Reducer<, , , >.<Reduce>d__3))]
		public Task<Result<object, SKKNIPYCQUO>> XXACUWNPPVG(TRoot a, TSerializedAction b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class VZLHKDLMKIS
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public interface MDFEQTCPLCK<a, b, c>
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			a TIKQYRMXNKI(b a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void EUSIJIPEQSN(c a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void ZCTAUDWYFVQ(c a, b b);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1230", Offset = "0x3BC0630", VA = "0x183BC1230")]
		internal static Reducer<TActionKind, TSerializedAction, TRoot, TDeps> New<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, SAXDENCFKEK<TSerializedAction, TRoot, TDeps>> reducers, TDeps deps) where TDeps : MDFEQTCPLCK<TActionKind, TSerializedAction, TRoot>
		{
			return default(Reducer<TActionKind, TSerializedAction, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal sealed class NCNVOTIJVHM<a, b, c, d>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Dictionary<a, SAXDENCFKEK<b, c, d>> GMWPDCYLVSL;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		private NCNVOTIJVHM(Dictionary<a, SAXDENCFKEK<b, c, d>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71BB0B0", Offset = "0x71BA4B0", VA = "0x1871BB0B0")]
		public static NCNVOTIJVHM<a, b, c, d> New()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, VZLHKDLMKIS.MDFEQTCPLCK<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private sealed class XWIFCSIRLHG<e, f, g> : SAXDENCFKEK<TSerializedAction, TRoot, TDeps> where e : notnull where f : notnull where g : notnull, SKKNIPYCQUO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly DeserializeActionDelegate<TActionKind, TSerializedAction, e> WIMVVVKMCUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly ReducePayloadSyncDelegate<TRoot, e, f, g> GBVRYWINGXM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly bool CIERBCUJZNM;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1D2D5E0", Offset = "0x1D2C9E0", VA = "0x181D2D5E0")]
			public XWIFCSIRLHG(DeserializeActionDelegate<TActionKind, TSerializedAction, e> a, ReducePayloadSyncDelegate<TRoot, e, f, g> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x503DF90", Offset = "0x503D390", VA = "0x18503DF90", Slot = "4")]
			public Task<Result<object, SKKNIPYCQUO>> XXACUWNPPVG(TDeps a, TRoot b, TSerializedAction c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private sealed class DOMTOYOEOLV<e, f, g> : SAXDENCFKEK<TSerializedAction, TRoot, TDeps> where e : notnull where f : notnull where g : notnull, SKKNIPYCQUO
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
				public AsyncTaskMethodBuilder<Result<object?, SKKNIPYCQUO>> <>t__builder;

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
				public DOMTOYOEOLV<e, f, g> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private Result<object?, SKKNIPYCQUO> <r>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				private TaskAwaiter<Result<f, g>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x6B3F100", Offset = "0x6B3E500", VA = "0x186B3F100", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x6B41510", Offset = "0x6B40910", VA = "0x186B41510", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly DeserializeActionDelegate<TActionKind, TSerializedAction, e> WIMVVVKMCUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly ReducePayloadAsyncDelegate<TRoot, e, f, g> GBVRYWINGXM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly bool CIERBCUJZNM;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1D2D5E0", Offset = "0x1D2C9E0", VA = "0x181D2D5E0")]
			public DOMTOYOEOLV(DeserializeActionDelegate<TActionKind, TSerializedAction, e> a, ReducePayloadAsyncDelegate<TRoot, e, f, g> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x533FD90", Offset = "0x533F190", VA = "0x18533FD90", Slot = "4")]
			[AsyncStateMachine(typeof(DOMTOYOEOLV<, , >.<Reduce>d__4))]
			public Task<Result<object, SKKNIPYCQUO>> XXACUWNPPVG(TDeps a, TRoot b, TSerializedAction c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly NCNVOTIJVHM<TActionKind, TSerializedAction, TRoot, TDeps> _data;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		private ReducerFactory(NCNVOTIJVHM<TActionKind, TSerializedAction, TRoot, TDeps> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x78B5890", Offset = "0x78B4C90", VA = "0x1878B5890")]
		public static ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> New()
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E99D80", Offset = "0x3E99180", VA = "0x183E99D80")]
		public ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> APZOLQXQELB<TPayload, TOk, TErr>(TActionKind a, DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload> b, ReducePayloadSyncDelegate<TRoot, TPayload, TOk, TErr> c, bool d = true) where TPayload : notnull where TOk : notnull where TErr : notnull, SKKNIPYCQUO
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E99D80", Offset = "0x3E99180", VA = "0x183E99D80")]
		public ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> YWRLVTMSQJM<TPayload, TOk, TErr>(TActionKind a, DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload> b, ReducePayloadAsyncDelegate<TRoot, TPayload, TOk, TErr> c, bool d = true) where TPayload : notnull where TOk : notnull where TErr : notnull, SKKNIPYCQUO
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78B55D0", Offset = "0x78B49D0", VA = "0x1878B55D0")]
		public Reducer<TActionKind, TSerializedAction, TRoot, TDeps> ISHNKJMJOID(TDeps a)
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
