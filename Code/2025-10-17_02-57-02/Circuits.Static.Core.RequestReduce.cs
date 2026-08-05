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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B22C30", Offset = "0x2B21230", VA = "0x182B22C30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
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
	internal interface DIGRZZGUMKQ<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, IQRQYBTPXGA>> BSUKQQMCKCK(c a, b b, a c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class WVQDGBABKZK<a, b, c, d> : AYCQJPFKAZX where d : WBBSASUOFLK.UWEOGEPSJXO<a, b, c>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly d KUPOYFERZJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly b FIWAOCKPVTK;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6868420", Offset = "0x6866A20", VA = "0x186868420")]
		public WVQDGBABKZK([In] d deps, [In] b serializedAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6868310", Offset = "0x6866910", VA = "0x186868310", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F13E10", Offset = "0x5F12410", VA = "0x185F13E10")]
		internal ReduceAction(TActionKind actionKind, [In] TPayload payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EMRXFYSQSAU
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x37F1400", Offset = "0x37EFA00", VA = "0x1837F1400")]
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
	public readonly struct Reducer<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : WBBSASUOFLK.UWEOGEPSJXO<TActionKind, TSerializedAction, TRoot>
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
			public AsyncTaskMethodBuilder<Result<object?, IQRQYBTPXGA>> <>t__builder;

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
			private TaskAwaiter<Result<object, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x52752F0", Offset = "0x52738F0", VA = "0x1852752F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5276490", Offset = "0x5274A90", VA = "0x185276490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<TActionKind, DIGRZZGUMKQ<TSerializedAction, TRoot, TDeps>> _reducers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
		internal Reducer(Dictionary<TActionKind, DIGRZZGUMKQ<TSerializedAction, TRoot, TDeps>> reducers, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5F16250", Offset = "0x5F14850", VA = "0x185F16250")]
		[AsyncStateMachine(typeof(Reducer<, , , >.<Reduce>d__3))]
		public Task<Result<object, IQRQYBTPXGA>> BSUKQQMCKCK(TRoot a, TSerializedAction b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class WBBSASUOFLK
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public interface UWEOGEPSJXO<a, b, c>
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			a GCPWWWFYVDQ(b a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void HUSHVTDZFPR(c a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void TFOEHDFCOGU(c a, b b);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2D20", Offset = "0x3EC1320", VA = "0x183EC2D20")]
		internal static Reducer<TActionKind, TSerializedAction, TRoot, TDeps> New<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, DIGRZZGUMKQ<TSerializedAction, TRoot, TDeps>> reducers, TDeps deps) where TDeps : UWEOGEPSJXO<TActionKind, TSerializedAction, TRoot>
		{
			return default(Reducer<TActionKind, TSerializedAction, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal sealed class PPIESJYGEVW<a, b, c, d>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Dictionary<a, DIGRZZGUMKQ<b, c, d>> DOLYVYMQDNP;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		private PPIESJYGEVW(Dictionary<a, DIGRZZGUMKQ<b, c, d>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5C89400", Offset = "0x5C87A00", VA = "0x185C89400")]
		public static PPIESJYGEVW<a, b, c, d> New()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, WBBSASUOFLK.UWEOGEPSJXO<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private sealed class VQVRBMLWFNE<e, f, g> : DIGRZZGUMKQ<TSerializedAction, TRoot, TDeps> where e : notnull where f : notnull where g : notnull, IQRQYBTPXGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly DeserializeActionDelegate<TActionKind, TSerializedAction, e> CSZVOFPKWMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly ReducePayloadSyncDelegate<TRoot, e, f, g> KRNFMSOFYSU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly bool NIQOVTPOUPG;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1D32D10", Offset = "0x1D31310", VA = "0x181D32D10")]
			public VQVRBMLWFNE(DeserializeActionDelegate<TActionKind, TSerializedAction, e> a, ReducePayloadSyncDelegate<TRoot, e, f, g> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x64E4E30", Offset = "0x64E3430", VA = "0x1864E4E30", Slot = "4")]
			public Task<Result<object, IQRQYBTPXGA>> BSUKQQMCKCK(TDeps a, TRoot b, TSerializedAction c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private sealed class VGTJALZBMMZ<e, f, g> : DIGRZZGUMKQ<TSerializedAction, TRoot, TDeps> where e : notnull where f : notnull where g : notnull, IQRQYBTPXGA
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
				public AsyncTaskMethodBuilder<Result<object?, IQRQYBTPXGA>> <>t__builder;

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
				public VGTJALZBMMZ<e, f, g> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private Result<object?, IQRQYBTPXGA> <r>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				private TaskAwaiter<Result<f, g>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x5277FE0", Offset = "0x52765E0", VA = "0x185277FE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5278E00", Offset = "0x5277400", VA = "0x185278E00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly DeserializeActionDelegate<TActionKind, TSerializedAction, e> CSZVOFPKWMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly ReducePayloadAsyncDelegate<TRoot, e, f, g> KRNFMSOFYSU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly bool NIQOVTPOUPG;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1D32D10", Offset = "0x1D31310", VA = "0x181D32D10")]
			public VGTJALZBMMZ(DeserializeActionDelegate<TActionKind, TSerializedAction, e> a, ReducePayloadAsyncDelegate<TRoot, e, f, g> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x64C21B0", Offset = "0x64C07B0", VA = "0x1864C21B0", Slot = "4")]
			[AsyncStateMachine(typeof(VGTJALZBMMZ<, , >.<Reduce>d__4))]
			public Task<Result<object, IQRQYBTPXGA>> BSUKQQMCKCK(TDeps a, TRoot b, TSerializedAction c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly PPIESJYGEVW<TActionKind, TSerializedAction, TRoot, TDeps> _data;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		private ReducerFactory(PPIESJYGEVW<TActionKind, TSerializedAction, TRoot, TDeps> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5F15D80", Offset = "0x5F14380", VA = "0x185F15D80")]
		public static ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> New()
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D510", Offset = "0x3B1BB10", VA = "0x183B1D510")]
		public ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> WYFPBOZYQBL<TPayload, TOk, TErr>(TActionKind a, DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload> b, ReducePayloadSyncDelegate<TRoot, TPayload, TOk, TErr> c, bool d = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IQRQYBTPXGA
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D510", Offset = "0x3B1BB10", VA = "0x183B1D510")]
		public ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps> VVGCZBUSKOE<TPayload, TOk, TErr>(TActionKind a, DeserializeActionDelegate<TActionKind, TSerializedAction, TPayload> b, ReducePayloadAsyncDelegate<TRoot, TPayload, TOk, TErr> c, bool d = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IQRQYBTPXGA
		{
			return default(ReducerFactory<TActionKind, TSerializedAction, TRoot, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5F15AC0", Offset = "0x5F140C0", VA = "0x185F15AC0")]
		public Reducer<TActionKind, TSerializedAction, TRoot, TDeps> BESFLJVUAJT(TDeps a)
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
