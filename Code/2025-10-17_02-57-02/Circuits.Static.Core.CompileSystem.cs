using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Shared.Core.ByteCode;
using Circuits.Shared.Utilities;
using Circuits.Static.Api;
using Circuits.Static.Core.CompileSystem.Helpers;
using Circuits.Static.Core.CompileSystem.Passes;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures.Performance;

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
		[Cpp2IlInjected.Address(RVA = "0x2B12210", Offset = "0x2B10810", VA = "0x182B12210")]
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
namespace Circuits.Static.Core.CompileSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct ByteCodeAdjustment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
		public ByteCodeAdjustment(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class WZFQGTFJCFJ : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6600", Offset = "0x2AB4C00", VA = "0x182AB6600")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FB70", Offset = "0x2B0E170", VA = "0x182B0FB70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class TTBPFFYWBNI : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<OPRBWAEKAQJ<LYBQOQJENGA>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
			public DeadEnd(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> nextByteCodePtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public enum Def
		{
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			BytesImmediate,
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			DeadEnd,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			Variable,
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			X32Immediate
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public abstract class VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct Inst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly Def Def;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public readonly Id32<VAUNTHRTZOH> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
			public Inst(Def def, Id32<VAUNTHRTZOH> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class VCRIFVUWSBB : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class EISCHWEIIYV : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x254B480", Offset = "0x2549A80", VA = "0x18254B480", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		internal IdUnsafeList<WZFQGTFJCFJ, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<TTBPFFYWBNI, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<VCRIFVUWSBB, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<EISCHWEIIYV, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B10780", Offset = "0x2B0ED80", VA = "0x182B10780")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<WZFQGTFJCFJ, BytesImmediate> bytesImmediates, [In] IdUnsafeList<TTBPFFYWBNI, DeadEnd> deadEnds, [In] IdUnsafeList<VCRIFVUWSBB, Variable> variables, [In] IdUnsafeList<EISCHWEIIYV, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B10640", Offset = "0x2B0EC40", VA = "0x182B10640")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class WCZXCJGAKTC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B150F0", Offset = "0x2B136F0", VA = "0x182B150F0")]
		public static void Destroy(this DataBackResults self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum DefaultValueKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Bytes,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Class
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct ExecForwardResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public sealed class SOKZXQWLAFU : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
			public DeadEndData(Id32<DataBackResults.M> dataBackId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum Def
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			Branch,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			DeadEnd,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			DeadEndData,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			NodeAlreadyVisited,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			NodeCantVisit,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			OutNode
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public abstract class VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public readonly struct Inst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly Def Def;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly Id32<VAUNTHRTZOH> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
			public Inst(Def def, Id32<VAUNTHRTZOH> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<SOKZXQWLAFU, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B10A00", Offset = "0x2B0F000", VA = "0x182B10A00")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<SOKZXQWLAFU, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B10970", Offset = "0x2B0EF70", VA = "0x182B10970")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class PTYWKVOXFXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B14880", Offset = "0x2B12E80", VA = "0x182B14880")]
		public static void Destroy(this ExecForwardResults self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct FunctionCallRegisterOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public UnsafeList<int> ReturnValueOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public UnsafeList<int> ArgumentOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int SizeBeforeUnmanagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int SizeBeforeManagedRegisterPointer;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B10AE0", Offset = "0x2B0F0E0", VA = "0x182B10AE0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B10A40", Offset = "0x2B0F040", VA = "0x182B10A40")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class NBLVMEQDCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B11FF0", Offset = "0x2B105F0", VA = "0x182B11FF0")]
		public static void Destroy(this FunctionCallRegisterOffsets self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct FunctionCalls
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public enum Def
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			External,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			Internal,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Runtime
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public sealed class FVEVCVVYUDW : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<ZOFPNHMTEQP> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
			public ExternalCall(Id32<ZOFPNHMTEQP> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public readonly struct Inst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public readonly Def Def;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public readonly Id32<VAUNTHRTZOH> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
			private Inst(Def def, Id32<VAUNTHRTZOH> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B11C90", Offset = "0x2B10290", VA = "0x182B11C90")]
			public static Inst New(Def def, Id32<VAUNTHRTZOH> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class DEVYYFJXQTE : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<ZOFPNHMTEQP> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
			public InternalCall(Id32<ZOFPNHMTEQP> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class ZOFPNHMTEQP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct IO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public UnsafeList<Id32<LocalVariables.M>> Arguments;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public UnsafeList<Id32<LocalVariables.M>> ReturnValues;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B10A00", Offset = "0x2B0F000", VA = "0x182B10A00")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B11AE0", Offset = "0x2B100E0", VA = "0x182B11AE0")]
			public static IO New()
			{
				return default(IO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal IdUnsafeList<DEVYYFJXQTE, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<FVEVCVVYUDW, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<ZOFPNHMTEQP> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<ZOFPNHMTEQP, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B10CE0", Offset = "0x2B0F2E0", VA = "0x182B10CE0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<DEVYYFJXQTE, InternalCall> internalCalls, [In] IdUnsafeList<FVEVCVVYUDW, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<ZOFPNHMTEQP> IOId)> callsWithIO, [In] IdUnsafeList<ZOFPNHMTEQP, IO> io, [In] SOAField<ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> ioModifyingCallLocations, [In] SOAField<ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B10B40", Offset = "0x2B0F140", VA = "0x182B10B40")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class ZVYWWMPRBLW
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A690", Offset = "0x2B18C90", VA = "0x182B1A690")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A6E0", Offset = "0x2B18CE0", VA = "0x182B1A6E0")]
		public static void Destroy(this FunctionCalls self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public struct FunctionCompileState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public UnsafeList<byte> ByteCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		internal FunctionCalls _functionCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		internal LocalVariables _localVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		internal Dictionary<string, Id32<LocalVariables.M>> _localNamedVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		internal DataBackResults _dataBackResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		internal ExecForwardResults _execForwardResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal SOAField<MXAREIUAFLA, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<MXAREIUAFLA>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B11730", Offset = "0x2B0FD30", VA = "0x182B11730")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<MXAREIUAFLA, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<MXAREIUAFLA>> generatedOutputsForExpression, [In] SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B10DA0", Offset = "0x2B0F3A0", VA = "0x182B10DA0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class OMZNVDZUYLX
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : JYDSVSINWEM<Id32<FunctionCalls.ZOFPNHMTEQP>, SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B14BB0", Offset = "0x2B131B0", VA = "0x182B14BB0")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B14B70", Offset = "0x2B13170", VA = "0x182B14B70", Slot = "4")]
			public Id32<FunctionCalls.ZOFPNHMTEQP> LDFMVYGACLO(int a)
			{
				return default(Id32<FunctionCalls.ZOFPNHMTEQP>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350")]
			public bool ZWMQBBDYILI(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "5")]
			private bool LPJMLVOWTSQ(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B14B60", Offset = "0x2B13160", VA = "0x182B14B60", Slot = "6")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> BTWGLKYQHFL(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : GICHBZKXTJP<Id32<FunctionCalls.ZOFPNHMTEQP>, SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B0ED00", Offset = "0x2B0D300", VA = "0x182B0ED00")]
			public UnsafeList<Id32<FunctionCalls.ZOFPNHMTEQP>> EOLUMDYVEHP(int a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZOFPNHMTEQP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EE20", Offset = "0x2B0D420", VA = "0x182B0EE20")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B0ED70", Offset = "0x2B0D370", VA = "0x182B0ED70", Slot = "6")]
			public void OTXDVGSWVUP(Id32<FunctionCalls.ZOFPNHMTEQP> a, SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> b, Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B0ED00", Offset = "0x2B0D300", VA = "0x182B0ED00", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.ZOFPNHMTEQP>> RFGIKQFUBGI(int a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZOFPNHMTEQP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EE10", Offset = "0x2B0D410", VA = "0x182B0EE10", Slot = "5")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> PYFMNCOXRPK(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : JYDSVSINWEM<Id32<FunctionCalls.ZOFPNHMTEQP>, SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B14C80", Offset = "0x2B13280", VA = "0x182B14C80")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B14C40", Offset = "0x2B13240", VA = "0x182B14C40", Slot = "4")]
			public Id32<FunctionCalls.ZOFPNHMTEQP> LDFMVYGACLO(int a)
			{
				return default(Id32<FunctionCalls.ZOFPNHMTEQP>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350")]
			public bool ZWMQBBDYILI(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "5")]
			private bool BCLFEQIGGLT(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B14C30", Offset = "0x2B13230", VA = "0x182B14C30", Slot = "6")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> JSMLTCUCRIM(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : GICHBZKXTJP<Id32<FunctionCalls.ZOFPNHMTEQP>, SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EEB0", Offset = "0x2B0D4B0", VA = "0x182B0EEB0")]
			public UnsafeList<Id32<FunctionCalls.ZOFPNHMTEQP>> EOLUMDYVEHP(int a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZOFPNHMTEQP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EFC0", Offset = "0x2B0D5C0", VA = "0x182B0EFC0")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EF20", Offset = "0x2B0D520", VA = "0x182B0EF20", Slot = "6")]
			public void OTXDVGSWVUP(Id32<FunctionCalls.ZOFPNHMTEQP> a, SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> b, Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EEB0", Offset = "0x2B0D4B0", VA = "0x182B0EEB0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.ZOFPNHMTEQP>> RXZMBTPIUSV(int a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZOFPNHMTEQP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EEA0", Offset = "0x2B0D4A0", VA = "0x182B0EEA0", Slot = "5")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> ASFDACSRWML(Id32<FunctionCalls.ZOFPNHMTEQP> a, [In] SOAField<FunctionCalls.ZOFPNHMTEQP, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : JYDSVSINWEM<Id32<XYCEOHQMMOR>, SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2B14DB0", Offset = "0x2B133B0", VA = "0x182B14DB0")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(Id32<XYCEOHQMMOR> a, [In] SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2B14D60", Offset = "0x2B13360", VA = "0x182B14D60", Slot = "4")]
			public Id32<XYCEOHQMMOR> LDFMVYGACLO(int a)
			{
				return default(Id32<XYCEOHQMMOR>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B14D00", Offset = "0x2B13300", VA = "0x182B14D00")]
			public bool ZWMQBBDYILI(Id32<XYCEOHQMMOR> a, [In] SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B14D00", Offset = "0x2B13300", VA = "0x182B14D00", Slot = "5")]
			private bool KUWOLTDLWPZ(Id32<XYCEOHQMMOR> a, [In] SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B14DA0", Offset = "0x2B133A0", VA = "0x182B14DA0", Slot = "6")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> PDMDWXNWYFU(Id32<XYCEOHQMMOR> a, [In] SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : GICHBZKXTJP<Id32<XYCEOHQMMOR>, SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F040", Offset = "0x2B0D640", VA = "0x182B0F040")]
			public UnsafeList<Id32<XYCEOHQMMOR>> EOLUMDYVEHP(int a, [In] SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> values)
			{
				return default(UnsafeList<Id32<XYCEOHQMMOR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F1C0", Offset = "0x2B0D7C0", VA = "0x182B0F1C0")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(Id32<XYCEOHQMMOR> a, [In] SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F0B0", Offset = "0x2B0D6B0", VA = "0x182B0F0B0", Slot = "6")]
			public void OTXDVGSWVUP(Id32<XYCEOHQMMOR> a, SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> b, Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F040", Offset = "0x2B0D640", VA = "0x182B0F040", Slot = "4")]
			private UnsafeList<Id32<XYCEOHQMMOR>> MECPLQSSMKD(int a, [In] SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> values)
			{
				return default(UnsafeList<Id32<XYCEOHQMMOR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F1B0", Offset = "0x2B0D7B0", VA = "0x182B0F1B0", Slot = "5")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> RLMIVHPWLNL(Id32<XYCEOHQMMOR> a, [In] SOAField<XYCEOHQMMOR, Id32<OPRBWAEKAQJ<LYBQOQJENGA>>?> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : JYDSVSINWEM<int, UnsafeList<(Id32<LocalVariables.M>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2B14FB0", Offset = "0x2B135B0", VA = "0x182B14FB0")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xC3C7B0", Offset = "0xC3ADB0", VA = "0x180C3C7B0", Slot = "4")]
			public int LDFMVYGACLO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350")]
			public bool ZWMQBBDYILI(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "5")]
			private bool BINDQFJBUYC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B14FA0", Offset = "0x2B135A0", VA = "0x182B14FA0", Slot = "6")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> ARYBVVTNXAX(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : GICHBZKXTJP<int, UnsafeList<(Id32<LocalVariables.M>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F690", Offset = "0x2B0DC90", VA = "0x182B0F690")]
			public UnsafeList<int> EOLUMDYVEHP(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F810", Offset = "0x2B0DE10", VA = "0x182B0F810")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F710", Offset = "0x2B0DD10", VA = "0x182B0F710", Slot = "6")]
			public void OTXDVGSWVUP(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> values, Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F690", Offset = "0x2B0DC90", VA = "0x182B0F690", Slot = "4")]
			private UnsafeList<int> VEDJNELUZMA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F700", Offset = "0x2B0DD00", VA = "0x182B0F700", Slot = "5")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> NTCBWHPAVOY(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<OPRBWAEKAQJ<YGAASBJWVTN<RBQKWAEEJQD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : JYDSVSINWEM<int, UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2B14F10", Offset = "0x2B13510", VA = "0x182B14F10")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xC3C7B0", Offset = "0xC3ADB0", VA = "0x180C3C7B0", Slot = "4")]
			public int LDFMVYGACLO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350")]
			public bool ZWMQBBDYILI(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "5")]
			private bool CLNENPHUSEZ(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B14F00", Offset = "0x2B13500", VA = "0x182B14F00", Slot = "6")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> CRORYDAMEMI(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : GICHBZKXTJP<int, UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F480", Offset = "0x2B0DA80", VA = "0x182B0F480")]
			public UnsafeList<int> EOLUMDYVEHP(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F600", Offset = "0x2B0DC00", VA = "0x182B0F600")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F500", Offset = "0x2B0DB00", VA = "0x182B0F500", Slot = "6")]
			public void OTXDVGSWVUP(int a, UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values, Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F480", Offset = "0x2B0DA80", VA = "0x182B0F480", Slot = "4")]
			private UnsafeList<int> LGZNDHNOJZN(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F4F0", Offset = "0x2B0DAF0", VA = "0x182B0F4F0", Slot = "5")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> IAASUYSXODX(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : JYDSVSINWEM<int, UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2B14E70", Offset = "0x2B13470", VA = "0x182B14E70")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC3C7B0", Offset = "0xC3ADB0", VA = "0x180C3C7B0", Slot = "4")]
			public int LDFMVYGACLO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350")]
			public bool ZWMQBBDYILI(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "5")]
			private bool CLNENPHUSEZ(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2B14E60", Offset = "0x2B13460", VA = "0x182B14E60", Slot = "6")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> CRORYDAMEMI(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : GICHBZKXTJP<int, UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F270", Offset = "0x2B0D870", VA = "0x182B0F270")]
			public UnsafeList<int> EOLUMDYVEHP(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F3F0", Offset = "0x2B0D9F0", VA = "0x182B0F3F0")]
			public Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F2F0", Offset = "0x2B0D8F0", VA = "0x182B0F2F0", Slot = "6")]
			public void OTXDVGSWVUP(int a, UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values, Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F270", Offset = "0x2B0D870", VA = "0x182B0F270", Slot = "4")]
			private UnsafeList<int> LGZNDHNOJZN(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F2E0", Offset = "0x2B0D8E0", VA = "0x182B0F2E0", Slot = "5")]
			private Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> IAASUYSXODX(int a, [In] UnsafeList<(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> Target, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public readonly struct GenerateDataBackResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x21E9600", Offset = "0x21E7C00", VA = "0x1821E9600")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B11AD0", Offset = "0x2B100D0", VA = "0x182B11AD0")]
			public void PKKFLCUPRJW([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<XYCEOHQMMOR> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B11AB0", Offset = "0x2B100B0", VA = "0x182B11AB0")]
			public GenerateDataBackFromInputIndexResult(Id32<XYCEOHQMMOR> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B11AA0", Offset = "0x2B100A0", VA = "0x182B11AA0")]
			public void PKKFLCUPRJW([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B11A80", Offset = "0x2B10080", VA = "0x182B11A80")]
			public void PKKFLCUPRJW([Out] Id32<DataBackResults.M> a, [Out] Id32<XYCEOHQMMOR> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<XYCEOHQMMOR> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
			public GenerateDataBackFromInputIndicesResult(Id32<XYCEOHQMMOR> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B11AC0", Offset = "0x2B100C0", VA = "0x182B11AC0")]
			public void PKKFLCUPRJW([Out] Id32<DataBackResults.M> a, [Out] Id32<XYCEOHQMMOR> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B126C0", Offset = "0x2B10CC0", VA = "0x182B126C0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B13590", Offset = "0x2B11B90", VA = "0x182B13590")]
		public static void RYBROCIXXUB(this FunctionCompileState a, Id32<MXAREIUAFLA> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B13EC0", Offset = "0x2B124C0", VA = "0x182B13EC0")]
		public static void UUXXLKCZLBR(this FunctionCompileState a, Id32<MXAREIUAFLA> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B12AA0", Offset = "0x2B110A0", VA = "0x182B12AA0")]
		public static Id32<DataBackResults.M>? FBWFDKUGLLG([In] this FunctionCompileState self, Id32<MXAREIUAFLA> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B13330", Offset = "0x2B11930", VA = "0x182B13330")]
		public static Id32<OPRBWAEKAQJ<LYBQOQJENGA>> PXHHBLAKPJC([In] this FunctionCompileState self)
		{
			return default(Id32<OPRBWAEKAQJ<LYBQOQJENGA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B141A0", Offset = "0x2B127A0", VA = "0x182B141A0")]
		private static void WGDSANZDTXJ(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B13390", Offset = "0x2B11990", VA = "0x182B13390")]
		private static Id32<OPRBWAEKAQJ<LYBQOQJENGA>>? QJVUSEBIQAY([In] this FunctionCompileState self, Id32<XYCEOHQMMOR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B12550", Offset = "0x2B10B50", VA = "0x182B12550")]
		public static void DYOVCTESHQU(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B12B20", Offset = "0x2B11120", VA = "0x182B12B20")]
		public static DataBackResults.Def GDLJUDTMAYG([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B12D70", Offset = "0x2B11370", VA = "0x182B12D70")]
		public static ReadOnlyArray<byte> KWNTGMNFUXE([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B131E0", Offset = "0x2B117E0", VA = "0x182B131E0")]
		public static Id32<LocalVariables.M> PTBJNKPCZJY([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B13620", Offset = "0x2B11C20", VA = "0x182B13620")]
		public static Union32 SHGVVEJEMGM([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DBC0", Offset = "0x3B0C1C0", VA = "0x183B0DBC0")]
		private static Id32<DataBackResults.M> AIELSMXRWCF<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.VAUNTHRTZOH
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B14720", Offset = "0x2B12D20", VA = "0x182B14720")]
		public static Id32<DataBackResults.M> YVXSBLINNOV(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B123A0", Offset = "0x2B109A0", VA = "0x182B123A0")]
		public static Id32<DataBackResults.M> BBBUMPXZNUM(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B13160", Offset = "0x2B11760", VA = "0x182B13160")]
		public static Id32<DataBackResults.M> PRVIHWEOHZJ(this FunctionCompileState a, Id32<OPRBWAEKAQJ<LYBQOQJENGA>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B134A0", Offset = "0x2B11AA0", VA = "0x182B134A0")]
		public static Id32<DataBackResults.M> RDJYKOHRXUH(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B12430", Offset = "0x2B10A30", VA = "0x182B12430")]
		public static Id32<DataBackResults.M> BKDUIGLLOGE(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EE70", Offset = "0x3B0D470", VA = "0x183B0EE70")]
		private static Id32<ExecForwardResults.M> IQMMASJBZZM<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.VAUNTHRTZOH
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B12360", Offset = "0x2B10960", VA = "0x182B12360")]
		public static Id32<ExecForwardResults.M> BATVCKOHICG(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B13B40", Offset = "0x2B12140", VA = "0x182B13B40")]
		public static Id32<ExecForwardResults.M> TZGBOTEDSBV(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B12B90", Offset = "0x2B11190", VA = "0x182B12B90")]
		public static Id32<ExecForwardResults.M> IFPNYMATTHF(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B13920", Offset = "0x2B11F20", VA = "0x182B13920")]
		public static Id32<ExecForwardResults.M> TFQEEKOEMCU(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B124B0", Offset = "0x2B10AB0", VA = "0x182B124B0")]
		public static Id32<ExecForwardResults.M> DKKRFXNGIWG(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B132C0", Offset = "0x2B118C0", VA = "0x182B132C0")]
		public static FunctionCalls.Def PVRBJSCRGGP([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B12C10", Offset = "0x2B11210", VA = "0x182B12C10")]
		public static CopyEnumerable<Id32<FunctionCalls.ZOFPNHMTEQP>, Id32Enumerator<FunctionCalls.ZOFPNHMTEQP>> INDJSVRULHQ([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.ZOFPNHMTEQP>, Id32Enumerator<FunctionCalls.ZOFPNHMTEQP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B13970", Offset = "0x2B11F70", VA = "0x182B13970")]
		public static Id32<FunctionCalls.ZOFPNHMTEQP> TOPFKSLZFFX([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.ZOFPNHMTEQP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B13520", Offset = "0x2B11B20", VA = "0x182B13520")]
		public static FunctionCalls.IO RMBBRTYIXTO([In] this FunctionCompileState self, Id32<FunctionCalls.ZOFPNHMTEQP> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B12290", Offset = "0x2B10890", VA = "0x182B12290")]
		public static FunctionCalls.IO AKNBGELRIOK(this FunctionCompileState a, Id32<FunctionCalls.ZOFPNHMTEQP> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EF10", Offset = "0x3B0D510", VA = "0x183B0EF10")]
		private static Id32<FunctionCalls.M> PIAILKVOTVP<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.VAUNTHRTZOH
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B14570", Offset = "0x2B12B70", VA = "0x182B14570")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZOFPNHMTEQP>) XJXCWGKQTWY(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZOFPNHMTEQP>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B13B90", Offset = "0x2B12190", VA = "0x182B13B90")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZOFPNHMTEQP>) UDNSPZSOYDQ(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZOFPNHMTEQP>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B12E50", Offset = "0x2B11450", VA = "0x182B12E50")]
		public static Id32<FunctionCalls.M> MMEUVQRUHTB(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B13410", Offset = "0x2B11A10", VA = "0x182B13410")]
		public static void QYIHKUYPVPI(this FunctionCompileState a, Id32<FunctionCalls.ZOFPNHMTEQP> b, Id32<OPRBWAEKAQJ<LYBQOQJENGA>> c, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F260", Offset = "0x3B0D860", VA = "0x183B0F260")]
		public static GenerateDataBackResult YVWGOJOSSOU<d, e>(this FunctionCompileState a, d b, e c, Id32<YRJDGOUPWNL> d, Id32<XYCEOHQMMOR> e) where d : UWPCASDNCUG<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EA10", Offset = "0x3B0D010", VA = "0x183B0EA10")]
		public static GenerateDataBackFromInputIndexResult HMKORGILZYM<f, g>(this FunctionCompileState a, f b, g c, Id32<YRJDGOUPWNL> d, Id32<BZFRCGZKOVF> e, int f) where f : UWPCASDNCUG<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DC60", Offset = "0x3B0C260", VA = "0x183B0DC60")]
		public static Id32<DataBackResults.M>? ATHXIVXMGBX<h, i>(this FunctionCompileState a, h b, i c, Id32<YRJDGOUPWNL> d, Id32<BZFRCGZKOVF> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : UWPCASDNCUG<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E1D0", Offset = "0x3B0C7D0", VA = "0x183B0E1D0")]
		public static Id32<ExecForwardResults.M> FTZUPACECMX<j, k>(this FunctionCompileState a, j b, k c, Id32<YRJDGOUPWNL> d, Id32<MXAREIUAFLA> e) where j : UWPCASDNCUG<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B12990", Offset = "0x2B10F90", VA = "0x182B12990")]
		public static LocalVariables.ArgumentInst ESRCJTASYHZ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B13FE0", Offset = "0x2B125E0", VA = "0x182B13FE0")]
		public static LocalVariables.CalleeReturnValueInst VKRVCYXCUDX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B13700", Offset = "0x2B11D00", VA = "0x182B13700")]
		public static LocalVariables.CallerReturnValueInst STESJSWWCYS([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B12FB0", Offset = "0x2B115B0", VA = "0x182B12FB0")]
		public static Id32<LocalVariables.M> NRGPCHJCCAO(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B13810", Offset = "0x2B11E10", VA = "0x182B13810")]
		public static LocalVariables.ParameterInst SWEPYGXHZFZ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B13F90", Offset = "0x2B12590", VA = "0x182B13F90")]
		public static LocalVariables.Def VCGWLDSHOXN([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B12500", Offset = "0x2B10B00", VA = "0x182B12500")]
		public static int? DVUZNQWFEPX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EFA0", Offset = "0x3B0D5A0", VA = "0x183B0EFA0")]
		private static Id32<LocalVariables.M> TFWLZFPMXAN<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.VAUNTHRTZOH
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B140F0", Offset = "0x2B126F0", VA = "0x182B140F0")]
		public static Id32<LocalVariables.M> VXULENYNGSR(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B13D40", Offset = "0x2B12340", VA = "0x182B13D40")]
		public static Id32<LocalVariables.M> UJRDKWKYMTI(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B143F0", Offset = "0x2B129F0", VA = "0x182B143F0")]
		public static Id32<LocalVariables.M> XAIPFUVGYCG(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B12CE0", Offset = "0x2B112E0", VA = "0x182B12CE0")]
		public static Id32<LocalVariables.M> JJILTBMPTAM(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B12300", Offset = "0x2B10900", VA = "0x182B12300")]
		public static Id32<LocalVariables.M> BAKQHFEYIEU(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B13DA0", Offset = "0x2B123A0", VA = "0x182B13DA0")]
		public static void URCBKSAKJNT(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B12EA0", Offset = "0x2B114A0", VA = "0x182B12EA0")]
		public static void MWLKPJUJPCP(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B14340", Offset = "0x2B12940", VA = "0x182B14340")]
		public static void WUXDUQCSZPN(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B12C50", Offset = "0x2B11250", VA = "0x182B12C50")]
		public static void IWNMSUSZCDK(this FunctionCompileState a, Id32<OPRBWAEKAQJ<LYBQOQJENGA>> b, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B147A0", Offset = "0x2B12DA0", VA = "0x182B147A0")]
		public static void ZKYMMRGRLUI(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<OPRBWAEKAQJ<PHWGZXQPBVL>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F180", Offset = "0x3B0D780", VA = "0x183B0F180")]
		public static void UCSELHDDFUR<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<OPRBWAEKAQJ<YGAASBJWVTN<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface UWPCASDNCUG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<TYMAZGWXABP> DUKNUKKCZYV(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<TYMAZGWXABP> JXJNLDEMROA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<TYMAZGWXABP> VMINQJKPKUN(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<TYMAZGWXABP> RFXVNCZWDOK(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> XLTWMVQEXWA(a a, FunctionCompileState b, Id32<YRJDGOUPWNL> c, Id32<XYCEOHQMMOR> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> WTHVAMJTRQQ(a a, FunctionCompileState b, Id32<YRJDGOUPWNL> c, Id32<MXAREIUAFLA> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int KICESAHVPZU(a a, Id32<YRJDGOUPWNL> b, Id32<XYCEOHQMMOR> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<MXAREIUAFLA> LQBJIWEMWFL(a a, Id32<YRJDGOUPWNL> b, Id32<XYCEOHQMMOR> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind UHVDSVXRVEY(a a, Id32<YRJDGOUPWNL> b, Id32<XYCEOHQMMOR> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool SMCUZCJPNWR(a a, Id32<YRJDGOUPWNL> b, Id32<XYCEOHQMMOR> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int BTBBSJZBYZU(a a, Id32<YRJDGOUPWNL> b, Id32<XYCEOHQMMOR> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> SAVOMTLOJAM(a a, Id32<YRJDGOUPWNL> b, Id32<XYCEOHQMMOR> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<TYMAZGWXABP>) GPBCGGRJSKK(a a, Id32<YRJDGOUPWNL> b, Id32<XYCEOHQMMOR> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int BBSATVAXZTO(a a, Id32<YRJDGOUPWNL> b, Id32<MXAREIUAFLA> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<XYCEOHQMMOR> SAZXGCPWAVT(a a, Id32<YRJDGOUPWNL> b, Id32<MXAREIUAFLA> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<XYCEOHQMMOR> NPDZFOSWYMM(a a, Id32<YRJDGOUPWNL> b, Id32<BZFRCGZKOVF> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int BYBRVOLELCA(a a, Id32<YRJDGOUPWNL> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? HIAEEQAUOVQ(a a, Id32<YRJDGOUPWNL> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int GIXYTXFTTFM(a a, Id32<YRJDGOUPWNL> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? TGYJNIBISLW(a a, Id32<YRJDGOUPWNL> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class XHRKGRWABJR
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0CB0", Offset = "0x3ECF2B0", VA = "0x183ED0CB0")]
		public static Id32<LocalVariables.M?> IVHWNPQLUSC<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2FF0", Offset = "0x3ED15F0", VA = "0x183ED2FF0")]
		public static Id32<LocalVariables.M?> VIEFOLDDDZR<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1EF0", Offset = "0x3ED04F0", VA = "0x183ED1EF0")]
		public static Id32<LocalVariables.M?> PYBJRDCQKVI<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B16280", Offset = "0x2B14880", VA = "0x182B16280")]
		public static Id32<LocalVariables.M> LBRGQLLHENY(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B15B70", Offset = "0x2B14170", VA = "0x182B15B70")]
		public static Id32<LocalVariables.M> EPEEXDGPAAV(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A200", Offset = "0x2B18800", VA = "0x182B1A200")]
		public static Id32<LocalVariables.M> ZDTLDZIISYI(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B155B0", Offset = "0x2B13BB0", VA = "0x182B155B0")]
		public static Id32<LocalVariables.M> CWBDKYTZMSE(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B15360", Offset = "0x2B13960", VA = "0x182B15360")]
		public static Id32<LocalVariables.M> BFYUNTSZEEP(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B16040", Offset = "0x2B14640", VA = "0x182B16040")]
		public static Id32<LocalVariables.M> IHKSYXRHVIW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B17E20", Offset = "0x2B16420", VA = "0x182B17E20")]
		public static Id32<LocalVariables.M> PYRCCCMKCSS(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B16950", Offset = "0x2B14F50", VA = "0x182B16950")]
		public static Id32<LocalVariables.M> MBSDGRJEBZL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B185B0", Offset = "0x2B16BB0", VA = "0x182B185B0")]
		public static Id32<LocalVariables.M> UHRDYKARNOY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B16380", Offset = "0x2B14980", VA = "0x182B16380")]
		public static Id32<LocalVariables.M> LEVEVPAIQSJ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B19FA0", Offset = "0x2B185A0", VA = "0x182B19FA0")]
		public static Id32<LocalVariables.M> YRKXGIOVAJQ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B16710", Offset = "0x2B14D10", VA = "0x182B16710")]
		public static Id32<LocalVariables.M> LZXQPPRDZHN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B19000", Offset = "0x2B17600", VA = "0x182B19000")]
		public static Id32<LocalVariables.M> VJCLOGWNLYM(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B19380", Offset = "0x2B17980", VA = "0x182B19380")]
		public static Id32<LocalVariables.M> WKPDHSEYDBZ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B15A30", Offset = "0x2B14030", VA = "0x182B15A30")]
		public static Id32<LocalVariables.M> ECWEXLGGFHY(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B19CE0", Offset = "0x2B182E0", VA = "0x182B19CE0")]
		public static Id32<LocalVariables.M> XXJBVNOKUOC(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B17100", Offset = "0x2B15700", VA = "0x182B17100")]
		public static Id32<LocalVariables.M> NTGZXOVVQIR(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B19C60", Offset = "0x2B18260", VA = "0x182B19C60")]
		public static Id32<LocalVariables.M> XOERBEPCXIE(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B15530", Offset = "0x2B13B30", VA = "0x182B15530")]
		public static Id32<LocalVariables.M> CDRWATJBMGL(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B17F20", Offset = "0x2B16520", VA = "0x182B17F20")]
		public static Id32<LocalVariables.M> QMPEPWPACLK(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B152E0", Offset = "0x2B138E0", VA = "0x182B152E0")]
		public static Id32<LocalVariables.M> AVJLUPJKQGN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B17180", Offset = "0x2B15780", VA = "0x182B17180")]
		public static Id32<LocalVariables.M> OANGWPXRTOH(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B16A70", Offset = "0x2B15070", VA = "0x182B16A70")]
		public static Id32<LocalVariables.M> MHCBWGDCFTW(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B15E30", Offset = "0x2B14430", VA = "0x182B15E30")]
		public static Id32<LocalVariables.M> HXZRKEBBUYZ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B15C90", Offset = "0x2B14290", VA = "0x182B15C90")]
		public static Id32<LocalVariables.M> FSOJWOMFPUC(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B18530", Offset = "0x2B16B30", VA = "0x182B18530")]
		public static Id32<LocalVariables.M> TJGVUPQDHCR(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B184B0", Offset = "0x2B16AB0", VA = "0x182B184B0")]
		public static Id32<LocalVariables.M> SZNEYKMKJDO(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B16AF0", Offset = "0x2B150F0", VA = "0x182B16AF0")]
		public static Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> MLOJCLXLZNW(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B16F60", Offset = "0x2B15560", VA = "0x182B16F60")]
		public static Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> MWIRDSTKREA(this FunctionCompileState a, int b)
		{
			return default(Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B15490", Offset = "0x2B13A90", VA = "0x182B15490")]
		public static Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> BPXGHHYFPOX(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B17FA0", Offset = "0x2B165A0", VA = "0x182B17FA0")]
		public static Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> QRFFQELSMOV(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B17200", Offset = "0x2B15800", VA = "0x182B17200")]
		public static Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> ONCPPBMEWDX(this FunctionCompileState a, int b)
		{
			return default(Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B15FA0", Offset = "0x2B145A0", VA = "0x182B15FA0")]
		public static Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> IDDISUTXVFI(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B174E0", Offset = "0x2B15AE0", VA = "0x182B174E0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZOFPNHMTEQP>) PCWPAOJBYET(this FunctionCompileState a, Id32<WTQCYPTFIQA> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZOFPNHMTEQP>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B17980", Offset = "0x2B15F80", VA = "0x182B17980")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZOFPNHMTEQP>) PDDORKUGZHT(this FunctionCompileState a, Id32<QIASPGRRBJU> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZOFPNHMTEQP>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3ED09F0", Offset = "0x3ECEFF0", VA = "0x183ED09F0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<TYMAZGWXABP>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<TMarker>>, Id32<FunctionCalls.M>) HRFNOTZTLPU<TMarker>(this FunctionCompileState a, Id32<TYMAZGWXABP> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<TYMAZGWXABP>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B17280", Offset = "0x2B15880", VA = "0x182B17280")]
		public static Id32<LocalVariables.M> OWNMQOSQZCQ(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B181A0", Offset = "0x2B167A0", VA = "0x182B181A0")]
		public static Id32<LocalVariables.M> RVGFEUFZTRJ(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B15EB0", Offset = "0x2B144B0", VA = "0x182B15EB0")]
		public static Id32<LocalVariables.M> IARQCMPHOTO(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B156B0", Offset = "0x2B13CB0", VA = "0x182B156B0")]
		public static Id32<LocalVariables.M> DETFOBPIBVJ(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B16850", Offset = "0x2B14E50", VA = "0x182B16850")]
		public static Id32<LocalVariables.M> MACYDSDTLUM(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B19B40", Offset = "0x2B18140", VA = "0x182B19B40")]
		public static Id32<LocalVariables.M> XENBMSOFMTR(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B16E20", Offset = "0x2B15420", VA = "0x182B16E20")]
		public static Id32<LocalVariables.M> MSCKFGKFWBE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B16180", Offset = "0x2B14780", VA = "0x182B16180")]
		public static Id32<LocalVariables.M> IVMCKCUBOHI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B157D0", Offset = "0x2B13DD0", VA = "0x182B157D0")]
		public static Id32<LocalVariables.M> DFCDLAIBDND(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A0C0", Offset = "0x2B186C0", VA = "0x182B1A0C0")]
		public static Id32<LocalVariables.M> ZABYCKERWZW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B19300", Offset = "0x2B17900", VA = "0x182B19300")]
		public static Id32<LocalVariables.M> WJEZKKHLXLV(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B18C40", Offset = "0x2B17240", VA = "0x182B18C40")]
		public static Id32<LocalVariables.M> UPTUKAMWJRK(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B17340", Offset = "0x2B15940", VA = "0x182B17340")]
		public static Id32<LocalVariables.M> OXFFZSTVHSJ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B19D60", Offset = "0x2B18360", VA = "0x182B19D60")]
		public static Id32<LocalVariables.M> YJHEVDKLEOT(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B16CF0", Offset = "0x2B152F0", VA = "0x182B16CF0")]
		public static Id32<LocalVariables.M> MOYQYKCEVZK(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A340", Offset = "0x2B18940", VA = "0x182B1A340")]
		public static Id32<LocalVariables.M> ZFFCVSLQTIV(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B18290", Offset = "0x2B16890", VA = "0x182B18290")]
		public static Id32<LocalVariables.M> SJVUDHPNWRM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B16FE0", Offset = "0x2B155E0", VA = "0x182B16FE0")]
		public static Id32<LocalVariables.M> NLAGFYZPDSJ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B18B00", Offset = "0x2B17100", VA = "0x182B18B00")]
		public static Id32<LocalVariables.M> UNPOZHUUAXC(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B19F80", Offset = "0x2B18580", VA = "0x182B19F80")]
		public static Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>> YKHAQBJMGJW(this FunctionCompileState a)
		{
			return default(Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B18CC0", Offset = "0x2B172C0", VA = "0x182B18CC0")]
		public static Id32<LocalVariables.M> UXFFHZXOJVL(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B195B0", Offset = "0x2B17BB0", VA = "0x182B195B0")]
		public static Id32<LocalVariables.M> WNLJXOPQFNA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B165D0", Offset = "0x2B14BD0", VA = "0x182B165D0")]
		public static Id32<LocalVariables.M> LVQYARTEMDR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B19200", Offset = "0x2B17800", VA = "0x182B19200")]
		public static Id32<LocalVariables.M> VXMZOQVOWVF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B173C0", Offset = "0x2B159C0", VA = "0x182B173C0")]
		public static Id32<LocalVariables.M> PAQFKSIJKHK(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B158F0", Offset = "0x2B13EF0", VA = "0x182B158F0")]
		public static Id32<LocalVariables.M> DFWRGMRBFPH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B194B0", Offset = "0x2B17AB0", VA = "0x182B194B0")]
		public static Id32<LocalVariables.M> WMZUZKGUNQA(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A580", Offset = "0x2B18B80", VA = "0x182B1A580")]
		public static Id32<LocalVariables.M> ZPCTLYZGJDR(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B15480", Offset = "0x2B13A80", VA = "0x182B15480")]
		public static void BPDEOOWBHEK(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B18F00", Offset = "0x2B17500", VA = "0x182B18F00")]
		public static Id32<LocalVariables.M> VDYIBUNSETX(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B15D10", Offset = "0x2B14310", VA = "0x182B15D10")]
		public static Id32<LocalVariables.M> GUUZJLLNGSW(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B19A00", Offset = "0x2B18000", VA = "0x182B19A00")]
		public static Id32<LocalVariables.M> WWHQXNPSTUP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B19100", Offset = "0x2B17700", VA = "0x182B19100")]
		public static Id32<LocalVariables.M> VNXGCWUIFOD(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B18390", Offset = "0x2B16990", VA = "0x182B18390")]
		public static Id32<LocalVariables.M> SLUHQIBWKAM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B151A0", Offset = "0x2B137A0", VA = "0x182B151A0")]
		public static Id32<LocalVariables.M> ARHTWTQSXLT(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B186F0", Offset = "0x2B16CF0", VA = "0x182B186F0")]
		public static Id32<LocalVariables.M> UKTJJBNIOIN(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A480", Offset = "0x2B18A80", VA = "0x182B1A480")]
		public static Id32<LocalVariables.M> ZMWPVAVJRYW(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B19E60", Offset = "0x2B18460", VA = "0x182B19E60")]
		public static Id32<LocalVariables.M> YJQVOQZGTUJ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B18DC0", Offset = "0x2B173C0", VA = "0x182B18DC0")]
		public static Id32<LocalVariables.M> VAOWILHHTJW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3670", Offset = "0x3ED1C70", VA = "0x183ED3670")]
		public static void YMZQUCHLSKJ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<WTQCYPTFIQA> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, UWPCASDNCUG<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2390", Offset = "0x3ED0990", VA = "0x183ED2390")]
		public static void RETJENUXQJF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<QIASPGRRBJU> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, UWPCASDNCUG<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2B40", Offset = "0x3ED1140", VA = "0x183ED2B40")]
		public static Id32<LocalVariables.M> UTMTUMUXGZX<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, UWPCASDNCUG<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0090", Offset = "0x3ECE690", VA = "0x183ED0090")]
		public static Id32<LocalVariables.M> AFWEUFGMAKS<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, UWPCASDNCUG<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1A90", Offset = "0x3ED0090", VA = "0x183ED1A90")]
		public static Id32<DataBackResults.M> MHDKZUOTIKH<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, UWPCASDNCUG<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3ED05B0", Offset = "0x3ECEBB0", VA = "0x183ED05B0")]
		public static Id32<ExecForwardResults.M> DAONLLRLEPS<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, UWPCASDNCUG<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B16480", Offset = "0x2B14A80", VA = "0x182B16480")]
		public static Id32<DataBackResults.M> LMMAAGCSNBW(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B196D0", Offset = "0x2B17CD0", VA = "0x182B196D0")]
		public static Id32<DataBackResults.M> WTZWWZSTQVA(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0EA0", Offset = "0x3ECF4A0", VA = "0x183ED0EA0")]
		public static Id32<DataBackResults.M> JNZKUGGIQYZ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<WTQCYPTFIQA> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, UWPCASDNCUG<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1080", Offset = "0x3ECF680", VA = "0x183ED1080")]
		private static Id32<DataBackResults.M> JNZKUGGIQYZ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<WTQCYPTFIQA> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, UWPCASDNCUG<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3220", Offset = "0x3ED1820", VA = "0x183ED3220")]
		public static Id32<LocalVariables.M> YDTMDSKDXGJ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, UWPCASDNCUG<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2020", Offset = "0x3ED0620", VA = "0x183ED2020")]
		public static void RDUTOKRMSDO<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, UWPCASDNCUG<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<OPRBWAEKAQJ<LYBQOQJENGA>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<OPRBWAEKAQJ<LYBQOQJENGA>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
		public LiveInterval(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> firstUse, Id32<OPRBWAEKAQJ<LYBQOQJENGA>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B11CC0", Offset = "0x2B102C0", VA = "0x182B11CC0")]
		public static LiveInterval New(Id32<OPRBWAEKAQJ<LYBQOQJENGA>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class CQNJOREQIEU : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct ArgumentInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Id32<FunctionCalls.M> CallId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class SHGSUTWOGEI : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class SMYPUGRALXR : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct CallerReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Id32<FunctionCalls.M> CallId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
			public CallerReturnValueInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public enum Def
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			Temporary,
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			Named,
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			Argument,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			CallerReturnValue,
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Parameter,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			CalleeReturnValue
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public abstract class VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct Inst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int? UnmanagedSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public LiveInterval LiveInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Def Def;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public Id32<VAUNTHRTZOH> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2B11CA0", Offset = "0x2B102A0", VA = "0x182B11CA0")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<VAUNTHRTZOH> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class XXOXUMUBZRY : VAUNTHRTZOH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<CQNJOREQIEU, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<SMYPUGRALXR, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<XXOXUMUBZRY, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<SHGSUTWOGEI, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B11EC0", Offset = "0x2B104C0", VA = "0x182B11EC0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<CQNJOREQIEU, ArgumentInst> argumentVariables, [In] SOAId32Field<SMYPUGRALXR, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<XXOXUMUBZRY, ParameterInst> parameterVariables, [In] SOAId32Field<SHGSUTWOGEI, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B11CD0", Offset = "0x2B102D0", VA = "0x182B11CD0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class TLZMNTFTTDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B15040", Offset = "0x2B13640", VA = "0x182B15040")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class EQQRRZDXAUH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B10810", Offset = "0x2B0EE10", VA = "0x182B10810")]
		public static void YRCEFRNPVRH(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.ZOFPNHMTEQP, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FB30", Offset = "0x2B0E130", VA = "0x182B0FB30")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.ZOFPNHMTEQP, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FAC0", Offset = "0x2B0E0C0", VA = "0x182B0FAC0")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F8A0", Offset = "0x2B0DEA0", VA = "0x182B0F8A0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x355F730", Offset = "0x355DD30", VA = "0x18355F730")]
		public static void YRCEFRNPVRH<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<YRJDGOUPWNL> graphId) where TDeps : notnull, UWPCASDNCUG<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class NDDERUNQEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B12040", Offset = "0x2B10640", VA = "0x182B12040")]
		public static void YRCEFRNPVRH(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface CJWHAZUNYVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void PNQJDDJYOVG(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : CJWHAZUNYVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2B14A20", Offset = "0x2B13020", VA = "0x182B14A20", Slot = "4")]
			public void PNQJDDJYOVG(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : CJWHAZUNYVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2B14AB0", Offset = "0x2B130B0", VA = "0x182B14AB0", Slot = "4")]
			public void PNQJDDJYOVG(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : CJWHAZUNYVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2B148E0", Offset = "0x2B12EE0", VA = "0x182B148E0", Slot = "4")]
			public void PNQJDDJYOVG(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : CJWHAZUNYVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2B14970", Offset = "0x2B12F70", VA = "0x182B14970", Slot = "4")]
			public void PNQJDDJYOVG(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class KGEAVPENQUX<c> where c : struct, CJWHAZUNYVV
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c KUPOYFERZJZ;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3A41DC0", Offset = "0x3A403C0", VA = "0x183A41DC0")]
			public static int YRCEFRNPVRH<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : UWPCASDNCUG<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<FunctionCalls.ZOFPNHMTEQP>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B11C50", Offset = "0x2B10250", VA = "0x182B11C50")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<FunctionCalls.ZOFPNHMTEQP>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B11BA0", Offset = "0x2B101A0", VA = "0x182B11BA0")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B11B60", Offset = "0x2B10160", VA = "0x182B11B60")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x396D430", Offset = "0x396BA30", VA = "0x18396D430")]
		public static void YRCEFRNPVRH<b, a>(FunctionCompileState a, b b, a c) where b : UWPCASDNCUG<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class DYQRASBQPNP
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private struct QueuedWrite
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Id32<LocalVariables.M> varId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int bytecodeOffsetOfCopyXInstruction;
		}

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static int CGAKQWYMAND;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int CTUMDOJDIXR;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B10090", Offset = "0x2B0E690", VA = "0x182B10090")]
		public static void YRCEFRNPVRH(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FE80", Offset = "0x2B0E480", VA = "0x182B0FE80")]
		private static void YHIJVOSIMDW([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FD40", Offset = "0x2B0E340", VA = "0x182B0FD40")]
		private static void YHIJVOSIMDW(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FBE0", Offset = "0x2B0E1E0", VA = "0x182B0FBE0")]
		private static void QQAWIVCLETV(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class CRIFLGWROEB<a, b, c> where a : struct, GICHBZKXTJP<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a KUPOYFERZJZ;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x410D720", Offset = "0x410BD20", VA = "0x18410D720")]
		public static void YRCEFRNPVRH([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface GICHBZKXTJP<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> EOLUMDYVEHP(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OTXDVGSWVUP(a a, b b, Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface JYDSVSINWEM<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a LDFMVYGACLO(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZWMQBBDYILI(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> SQBENDIYCWL(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class BOZCAHRKRCE<a, b, c> where a : struct, JYDSVSINWEM<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a KUPOYFERZJZ;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x72109E0", Offset = "0x720EFE0", VA = "0x1872109E0")]
		public static UnsafeList<b> YRCEFRNPVRH(int a, [In] c values)
		{
			return default(UnsafeList<b>);
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
