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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x28FF330", Offset = "0x28FDB30", VA = "0x1828FF330")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
	internal interface VWBFTLGWICT<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, SPRIBHSTRKT>> TQCQCFLVQEN(c a, b b, a c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class GOYCXSVZENN<a, b, c, d> : UKTPHMNXTOY where d : ZLUDVAHINHT.BZZUHUVHMDL<a, b, c>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly d FPRKQLVLHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly b MQCISAONOXF;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E9C440", Offset = "0x4E9AC40", VA = "0x184E9C440")]
		public GOYCXSVZENN([In] d deps, [In] b serializedAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4E9BFC0", Offset = "0x4E9A7C0", VA = "0x184E9BFC0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DDC9B0", Offset = "0x5DDB1B0", VA = "0x185DDC9B0")]
		internal ReduceAction(TActionKind actionKind, [In] TPayload payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class HKSXBPMLSTJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x36DC1B0", Offset = "0x36DA9B0", VA = "0x1836DC1B0")]
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
	public readonly struct Reducer<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : ZLUDVAHINHT.BZZUHUVHMDL<TActionKind, TSerializedAction, TRoot>
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
			public AsyncTaskMethodBuilder<Result<object?, SPRIBHSTRKT>> <>t__builder;

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
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5100150", Offset = "0x50FE950", VA = "0x185100150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x51012F0", Offset = "0x50FFAF0", VA = "0x1851012F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<TActionKind, VWBFTLGWICT<TSerializedAction, TRoot, TDeps>> _reducers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE5D150", Offset = "0xE5B950", VA = "0x180E5D150")]
		internal Reducer(Dictionary<TActionKind, VWBFTLGWICT<TSerializedAction, TRoot, TDeps>> reducers, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEDF0", Offset = "0x5DDD5F0", VA = "0x185DDEDF0")]
		[AsyncStateMachine(typeof(Reducer<, , , >.<Reduce>d__3))]
		public Task<Result<object, SPRIBHSTRKT>> TQCQCFLVQEN(TRoot a, TSerializedAction b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class ZLUDVAHINHT
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public interface BZZUHUVHMDL<a, b, c>
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			a INQWKGUZWUL(b a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void UYIQLOFRWJY(c a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void TVXGPLCNJID(c a, b b);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C15760", Offset = "0x3C13F60", VA = "0x183C15760")]
		internal static Reducer<TActionKind, TSerializedAction, TRoot, TDeps> New<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, VWBFTLGWICT<TSerializedAction, TRoot, TDeps>> reducers, TDeps deps) where TDeps : BZZUHUVHMDL<TActionKind, TSerializedAction, TRoot>
		{
			return default(Reducer<TActionKind, TSerializedAction, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal sealed class VDCYHJGSHHX<a, b, c, d>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Dictionary<a, VWBFTLGWICT<b, c, d>> TCKQZJCWDCK;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		private VDCYHJGSHHX(Dictionary<a, VWBFTLGWICT<b, c, d>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x62B79D0", Offset = "0x62B61D0", VA = "0x1862B79D0")]
		public static VDCYHJGSHHX<a, b, c, d> New()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, ZLUDVAHINHT.BZZUHUVHMDL<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private sealed class KBDEATHQQSL<e, f, g> : VWBFTLGWICT<TSerializedAction, TRoot, TDeps> where e : notnull where f : notnull where g : notnull, SPRIBHSTRKT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly DeserializeActionDelegate<TActionKind, TSerializedAction, e> XXOLCDDDRZI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly ReducePayloadSyncDelegate<TRoot, e, f, g> XIZXOVMWLAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly bool MDZBGLIFAUJ;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1A64B30", Offset = "0x1A63330", VA = "0x181A64B30")]
			public KBDEATHQQSL(DeserializeActionDelegate<TActionKind, TSerializedAction, e> a, ReducePayloadSyncDelegate<TRoot, e, f, g> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x51DF9A0", Offset = "0x51DE1A0", VA = "0x1851DF9A0", Slot = "4")]
			public Task<Result<object, SPRIBHSTRKT>> TQCQCFLVQEN(TDeps a, TRoot b, TSerializedAction c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private sealed class UOQQXUQHRBM<e, f, g> : VWBFTLGWICT<TSerializedAction, TRoot, TDeps> where e : notnull where f : notnull where g : notnull, SPRIBHSTRKT
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
				public AsyncTaskMethodBuilder<Result<object?, SPRIBHSTRKT>> <>t__builder;

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
				public UOQQXUQHRBM<e, f, g> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private Result<object?, SPRIBHSTRKT> <r>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				private TaskAwaiter<Result<f, g>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x5103650", Offset = "0x5101E50", VA = "0x185103650", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5103D40", Offset = "0x5102540", VA = "0x185103D40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly DeserializeActionDelegate<TActionKind, TSerializedAction, e> XXOLCDDDRZI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly ReducePayloadAsyncDelegate<TRoot, e, f, g> XIZXOVMWLAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly bool MDZBGLIFAUJ;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1A64B30", Offset = "0x1A63330", VA = "0x181A64B30")]
			public UOQQXUQHRBM(DeserializeActionDelegate<TActionKind, TSerializedAction, e> a, ReducePayloadAsyncDelegate<TRoot, e, f, g> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x61A2C40", Offset = "0x61A1440", VA = "0x1861A2C40", Slot = "4")]
			[AsyncStateMachine(typeof(UOQQXUQHRBM<, , >.<Reduce>d__4))]
			public Task<Result<object, SPRIBHSTRKT>> TQCQCFLVQEN(TDeps a, TRoot b, TSerializedAction c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly VDCYHJGSHHX<TActionKind, TSerializedAction, TRoot, TDeps> _data;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		private ReducerFactory(VDCYHJGSHHX<TActionKind, TSerializedAction, TRoot, TDeps> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDE920", Offset = "0x5DDD120", VA = "0x185DDE920")]
		public static ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> New()
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x36471C0", Offset = "0x36459C0", VA = "0x1836471C0")]
		public ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> SANNRNXKVCA<TPayload, TOk, TErr>(TActionKind a, DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload> b, ReducePayloadSyncDelegate<TRoot, TPayload, TOk, TErr> c, bool d = true) where TPayload : notnull where TOk : notnull where TErr : notnull, SPRIBHSTRKT
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x36471C0", Offset = "0x36459C0", VA = "0x1836471C0")]
		public ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> AATWANBEOQP<TPayload, TOk, TErr>(TActionKind a, DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload> b, ReducePayloadAsyncDelegate<TRoot, TPayload, TOk, TErr> c, bool d = true) where TPayload : notnull where TOk : notnull where TErr : notnull, SPRIBHSTRKT
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5DDE820", Offset = "0x5DDD020", VA = "0x185DDE820")]
		public Reducer<TActionKind, TSerializedAction, TRoot, TDeps> AXHFTEUJRLO(TDeps a)
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
