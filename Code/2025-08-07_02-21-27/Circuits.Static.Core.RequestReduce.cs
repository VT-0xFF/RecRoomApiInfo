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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DF4E80", Offset = "0x2DF3A80", VA = "0x182DF4E80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
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
	internal interface MEOFQENXVZT<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, JGXPLWKAZER>> OMFFNDUCKPZ(c a, b b, a c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class LQMLEGTMVVX<a, b, c, d> : NJKZNHRVAZM where d : TWZYVPJPRWX.MQBQDZFUSGT<a, b, c>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly d KOIFGESKYOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly b TTZLVNPHFYJ;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x59D5670", Offset = "0x59D4270", VA = "0x1859D5670")]
		public LQMLEGTMVVX([In] d deps, [In] b serializedAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x59D5310", Offset = "0x59D3F10", VA = "0x1859D5310", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x647DCF0", Offset = "0x647C8F0", VA = "0x18647DCF0")]
		internal ReduceAction(TActionKind actionKind, [In] TPayload payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class TBZLPCYVQCR
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4033180", Offset = "0x4031D80", VA = "0x184033180")]
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
	public readonly struct Reducer<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : TWZYVPJPRWX.MQBQDZFUSGT<TActionKind, TSerializedAction, TRoot>
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
			public AsyncTaskMethodBuilder<Result<object?, JGXPLWKAZER>> <>t__builder;

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
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x55EC710", Offset = "0x55EB310", VA = "0x1855EC710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x55ED8D0", Offset = "0x55EC4D0", VA = "0x1855ED8D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<TActionKind, MEOFQENXVZT<TSerializedAction, TRoot, TDeps>> _reducers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
		internal Reducer(Dictionary<TActionKind, MEOFQENXVZT<TSerializedAction, TRoot, TDeps>> reducers, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6480280", Offset = "0x647EE80", VA = "0x186480280")]
		[AsyncStateMachine(typeof(Reducer<, , , >.<Reduce>d__3))]
		public Task<Result<object, JGXPLWKAZER>> OMFFNDUCKPZ(TRoot a, TSerializedAction b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TWZYVPJPRWX
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public interface MQBQDZFUSGT<a, b, c>
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			a SPGAEXWGVXT(b a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void DOCGKORNSBS(c a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void KDYLPGOSAXD(c a, b b);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C7BA20", Offset = "0x3C7A620", VA = "0x183C7BA20")]
		internal static Reducer<TActionKind, TSerializedAction, TRoot, TDeps> New<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, MEOFQENXVZT<TSerializedAction, TRoot, TDeps>> reducers, TDeps deps) where TDeps : MQBQDZFUSGT<TActionKind, TSerializedAction, TRoot>
		{
			return default(Reducer<TActionKind, TSerializedAction, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal sealed class YBFMKEQOWYL<a, b, c, d>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Dictionary<a, MEOFQENXVZT<b, c, d>> ERDLXYRSBDS;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		private YBFMKEQOWYL(Dictionary<a, MEOFQENXVZT<b, c, d>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4482220", Offset = "0x4480E20", VA = "0x184482220")]
		public static YBFMKEQOWYL<a, b, c, d> New()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, TWZYVPJPRWX.MQBQDZFUSGT<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private sealed class WBTWLVTQTHP<e, f, g> : MEOFQENXVZT<TSerializedAction, TRoot, TDeps> where e : notnull where f : notnull where g : notnull, JGXPLWKAZER
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly DeserializeActionDelegate<TActionKind, TSerializedAction, e> TXSJUWGIJUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly ReducePayloadSyncDelegate<TRoot, e, f, g> RQRVCBQJDUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly bool NDZKBRXGGOH;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1FE0F60", Offset = "0x1FDFB60", VA = "0x181FE0F60")]
			public WBTWLVTQTHP(DeserializeActionDelegate<TActionKind, TSerializedAction, e> a, ReducePayloadSyncDelegate<TRoot, e, f, g> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6D2BCF0", Offset = "0x6D2A8F0", VA = "0x186D2BCF0", Slot = "4")]
			public Task<Result<object, JGXPLWKAZER>> OMFFNDUCKPZ(TDeps a, TRoot b, TSerializedAction c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private sealed class UNQFLFAVOUI<e, f, g> : MEOFQENXVZT<TSerializedAction, TRoot, TDeps> where e : notnull where f : notnull where g : notnull, JGXPLWKAZER
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
				public AsyncTaskMethodBuilder<Result<object?, JGXPLWKAZER>> <>t__builder;

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
				public UNQFLFAVOUI<e, f, g> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private Result<object?, JGXPLWKAZER> <r>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				private TaskAwaiter<Result<f, g>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x55EF840", Offset = "0x55EE440", VA = "0x1855EF840", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x55F00A0", Offset = "0x55EECA0", VA = "0x1855F00A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly DeserializeActionDelegate<TActionKind, TSerializedAction, e> TXSJUWGIJUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly ReducePayloadAsyncDelegate<TRoot, e, f, g> RQRVCBQJDUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly bool NDZKBRXGGOH;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1FE0F60", Offset = "0x1FDFB60", VA = "0x181FE0F60")]
			public UNQFLFAVOUI(DeserializeActionDelegate<TActionKind, TSerializedAction, e> a, ReducePayloadAsyncDelegate<TRoot, e, f, g> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x681A900", Offset = "0x6819500", VA = "0x18681A900", Slot = "4")]
			[AsyncStateMachine(typeof(UNQFLFAVOUI<, , >.<Reduce>d__4))]
			public Task<Result<object, JGXPLWKAZER>> OMFFNDUCKPZ(TDeps a, TRoot b, TSerializedAction c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly YBFMKEQOWYL<TActionKind, TSerializedAction, TRoot, TDeps> _data;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		private ReducerFactory(YBFMKEQOWYL<TActionKind, TSerializedAction, TRoot, TDeps> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x647FDC0", Offset = "0x647E9C0", VA = "0x18647FDC0")]
		public static ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> New()
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x421EF60", Offset = "0x421DB60", VA = "0x18421EF60")]
		public ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> UYUNTGDSEVU<TPayload, TOk, TErr>(TActionKind a, DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload> b, ReducePayloadSyncDelegate<TRoot, TPayload, TOk, TErr> c, bool d = true) where TPayload : notnull where TOk : notnull where TErr : notnull, JGXPLWKAZER
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x421EF60", Offset = "0x421DB60", VA = "0x18421EF60")]
		public ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> IRGRLFYBNTP<TPayload, TOk, TErr>(TActionKind a, DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload> b, ReducePayloadAsyncDelegate<TRoot, TPayload, TOk, TErr> c, bool d = true) where TPayload : notnull where TOk : notnull where TErr : notnull, JGXPLWKAZER
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x647FCC0", Offset = "0x647E8C0", VA = "0x18647FCC0")]
		public Reducer<TActionKind, TSerializedAction, TRoot, TDeps> End(TDeps deps)
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
