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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8F980", Offset = "0x2B8E380", VA = "0x182B8F980")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18210", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
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
		public readonly Id32<KGMTAGLYNTP<RRRVXHRUCXR>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
		public ByteCodeAdjustment(Id32<KGMTAGLYNTP<RRRVXHRUCXR>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class LKKKABWYIBZ : CMCAYUZTWUP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D390", Offset = "0x2B1BD90", VA = "0x182B1D390")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B87F10", Offset = "0x2B86910", VA = "0x182B87F10", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class GOUCNEWEBWG : CMCAYUZTWUP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
			public DeadEnd(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> nextByteCodePtr)
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
		public abstract class CMCAYUZTWUP
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
			public readonly Id32<CMCAYUZTWUP> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
			public Inst(Def def, Id32<CMCAYUZTWUP> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class KRRICHCQKAD : CMCAYUZTWUP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class NVAZKMNTIYV : CMCAYUZTWUP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2389B70", Offset = "0x2388570", VA = "0x182389B70", Slot = "3")]
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
		internal IdUnsafeList<LKKKABWYIBZ, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<GOUCNEWEBWG, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<KRRICHCQKAD, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<NVAZKMNTIYV, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B88220", Offset = "0x2B86C20", VA = "0x182B88220")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<LKKKABWYIBZ, BytesImmediate> bytesImmediates, [In] IdUnsafeList<GOUCNEWEBWG, DeadEnd> deadEnds, [In] IdUnsafeList<KRRICHCQKAD, Variable> variables, [In] IdUnsafeList<NVAZKMNTIYV, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B880E0", Offset = "0x2B86AE0", VA = "0x182B880E0")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class AFVTVMRWSSE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B86F90", Offset = "0x2B85990", VA = "0x182B86F90")]
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
		public sealed class YZKALMDVUYO : CMCAYUZTWUP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
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
		public abstract class CMCAYUZTWUP
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
			public readonly Id32<CMCAYUZTWUP> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
			public Inst(Def def, Id32<CMCAYUZTWUP> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<YZKALMDVUYO, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B88340", Offset = "0x2B86D40", VA = "0x182B88340")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<YZKALMDVUYO, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B882B0", Offset = "0x2B86CB0", VA = "0x182B882B0")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class BHWODCZAHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B87EB0", Offset = "0x2B868B0", VA = "0x182B87EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B88420", Offset = "0x2B86E20", VA = "0x182B88420")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B88380", Offset = "0x2B86D80", VA = "0x182B88380")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class HSPTFGHULBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B894D0", Offset = "0x2B87ED0", VA = "0x182B894D0")]
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
		public sealed class NLFWFOKFOWQ : CMCAYUZTWUP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<UERCVPOWXRJ> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
			public ExternalCall(Id32<UERCVPOWXRJ> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class CMCAYUZTWUP
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
			public readonly Id32<CMCAYUZTWUP> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
			private Inst(Def def, Id32<CMCAYUZTWUP> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B896D0", Offset = "0x2B880D0", VA = "0x182B896D0")]
			public static Inst New(Def def, Id32<CMCAYUZTWUP> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class QCMXMPNXPGS : CMCAYUZTWUP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<UERCVPOWXRJ> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
			public InternalCall(Id32<UERCVPOWXRJ> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class UERCVPOWXRJ
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
			[Cpp2IlInjected.Address(RVA = "0x2B88340", Offset = "0x2B86D40", VA = "0x182B88340")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B89520", Offset = "0x2B87F20", VA = "0x182B89520")]
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
		internal IdUnsafeList<QCMXMPNXPGS, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<NLFWFOKFOWQ, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<UERCVPOWXRJ> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<UERCVPOWXRJ, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B88620", Offset = "0x2B87020", VA = "0x182B88620")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<QCMXMPNXPGS, InternalCall> internalCalls, [In] IdUnsafeList<NLFWFOKFOWQ, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<UERCVPOWXRJ> IOId)> callsWithIO, [In] IdUnsafeList<UERCVPOWXRJ, IO> io, [In] SOAField<UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> ioModifyingCallLocations, [In] SOAField<UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B88480", Offset = "0x2B86E80", VA = "0x182B88480")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class QLAWRIAGWYA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FE90", Offset = "0x2B8E890", VA = "0x182B8FE90")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FC80", Offset = "0x2B8E680", VA = "0x182B8FC80")]
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
		internal SOAField<HSLAWAWHJXI, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<HSLAWAWHJXI>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B89070", Offset = "0x2B87A70", VA = "0x182B89070")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<HSLAWAWHJXI, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<HSLAWAWHJXI>> generatedOutputsForExpression, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B886E0", Offset = "0x2B870E0", VA = "0x182B886E0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class QSALSBUDEIF
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : GLIYORXVQTG<Id32<FunctionCalls.UERCVPOWXRJ>, SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B92520", Offset = "0x2B90F20", VA = "0x182B92520")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B924D0", Offset = "0x2B90ED0", VA = "0x182B924D0", Slot = "4")]
			public Id32<FunctionCalls.UERCVPOWXRJ> HXQZBEXBHJO(int a)
			{
				return default(Id32<FunctionCalls.UERCVPOWXRJ>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0")]
			public bool BKNIWPEUIQO(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "5")]
			private bool APZKZQMGMMQ(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B92510", Offset = "0x2B90F10", VA = "0x182B92510", Slot = "6")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WSUQFYVUWQJ(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : PMEGHTFDUYN<Id32<FunctionCalls.UERCVPOWXRJ>, SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B87050", Offset = "0x2B85A50", VA = "0x182B87050")]
			public UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> RATOPIWNAVL(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B87160", Offset = "0x2B85B60", VA = "0x182B87160")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B870C0", Offset = "0x2B85AC0", VA = "0x182B870C0", Slot = "6")]
			public void SJZTTAPRIXF(Id32<FunctionCalls.UERCVPOWXRJ> a, SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B87050", Offset = "0x2B85A50", VA = "0x182B87050", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> JEJNPXKTANW(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B87040", Offset = "0x2B85A40", VA = "0x182B87040", Slot = "5")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> EMOGUKQKOQM(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : GLIYORXVQTG<Id32<FunctionCalls.UERCVPOWXRJ>, SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B925F0", Offset = "0x2B90FF0", VA = "0x182B925F0")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B925A0", Offset = "0x2B90FA0", VA = "0x182B925A0", Slot = "4")]
			public Id32<FunctionCalls.UERCVPOWXRJ> HXQZBEXBHJO(int a)
			{
				return default(Id32<FunctionCalls.UERCVPOWXRJ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0")]
			public bool BKNIWPEUIQO(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "5")]
			private bool AXGYJOHTNGZ(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B925E0", Offset = "0x2B90FE0", VA = "0x182B925E0", Slot = "6")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> LORMUOKYISU(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : PMEGHTFDUYN<Id32<FunctionCalls.UERCVPOWXRJ>, SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B871F0", Offset = "0x2B85BF0", VA = "0x182B871F0")]
			public UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> RATOPIWNAVL(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B87300", Offset = "0x2B85D00", VA = "0x182B87300")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B87260", Offset = "0x2B85C60", VA = "0x182B87260", Slot = "6")]
			public void SJZTTAPRIXF(Id32<FunctionCalls.UERCVPOWXRJ> a, SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B871F0", Offset = "0x2B85BF0", VA = "0x182B871F0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> TLGWPMKCRQN(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B871E0", Offset = "0x2B85BE0", VA = "0x182B871E0", Slot = "5")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> AMWGFDVFKXF(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : GLIYORXVQTG<Id32<CCKCDLBLEMF>, SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2B92720", Offset = "0x2B91120", VA = "0x182B92720")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2B926E0", Offset = "0x2B910E0", VA = "0x182B926E0", Slot = "4")]
			public Id32<CCKCDLBLEMF> HXQZBEXBHJO(int a)
			{
				return default(Id32<CCKCDLBLEMF>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B92670", Offset = "0x2B91070", VA = "0x182B92670")]
			public bool BKNIWPEUIQO(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B92670", Offset = "0x2B91070", VA = "0x182B92670", Slot = "5")]
			private bool DPFSWVUEMXB(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B926D0", Offset = "0x2B910D0", VA = "0x182B926D0", Slot = "6")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> GUJNRFGDWXY(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : PMEGHTFDUYN<Id32<CCKCDLBLEMF>, SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2B87380", Offset = "0x2B85D80", VA = "0x182B87380")]
			public UnsafeList<Id32<CCKCDLBLEMF>> RATOPIWNAVL(int a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(UnsafeList<Id32<CCKCDLBLEMF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B87500", Offset = "0x2B85F00", VA = "0x182B87500")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B873F0", Offset = "0x2B85DF0", VA = "0x182B873F0", Slot = "6")]
			public void SJZTTAPRIXF(Id32<CCKCDLBLEMF> a, SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B87380", Offset = "0x2B85D80", VA = "0x182B87380", Slot = "4")]
			private UnsafeList<Id32<CCKCDLBLEMF>> JUOZFCBUBXF(int a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(UnsafeList<Id32<CCKCDLBLEMF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B874F0", Offset = "0x2B85EF0", VA = "0x182B874F0", Slot = "5")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> VAXPOOUMGSF(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : GLIYORXVQTG<int, UnsafeList<(Id32<LocalVariables.M>, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2B92920", Offset = "0x2B91320", VA = "0x182B92920")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD54570", Offset = "0xD52F70", VA = "0x180D54570", Slot = "4")]
			public int HXQZBEXBHJO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0")]
			public bool BKNIWPEUIQO(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "5")]
			private bool SVZFHFBSXVU(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B92910", Offset = "0x2B91310", VA = "0x182B92910", Slot = "6")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> UUBKLOWZWCP(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : PMEGHTFDUYN<int, UnsafeList<(Id32<LocalVariables.M>, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B879E0", Offset = "0x2B863E0", VA = "0x182B879E0")]
			public UnsafeList<int> RATOPIWNAVL(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B87B50", Offset = "0x2B86550", VA = "0x182B87B50")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B87A50", Offset = "0x2B86450", VA = "0x182B87A50", Slot = "6")]
			public void SJZTTAPRIXF(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B879E0", Offset = "0x2B863E0", VA = "0x182B879E0", Slot = "4")]
			private UnsafeList<int> XJQRPADZNII(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B879D0", Offset = "0x2B863D0", VA = "0x182B879D0", Slot = "5")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> BANEFXCSSLK(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : GLIYORXVQTG<int, UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2B92880", Offset = "0x2B91280", VA = "0x182B92880")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD54570", Offset = "0xD52F70", VA = "0x180D54570", Slot = "4")]
			public int HXQZBEXBHJO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0")]
			public bool BKNIWPEUIQO(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "5")]
			private bool UPXQSNYZYIJ(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B92870", Offset = "0x2B91270", VA = "0x182B92870", Slot = "6")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> MIBYYKLKLUE(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : PMEGHTFDUYN<int, UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2B877D0", Offset = "0x2B861D0", VA = "0x182B877D0")]
			public UnsafeList<int> RATOPIWNAVL(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B87940", Offset = "0x2B86340", VA = "0x182B87940")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B87840", Offset = "0x2B86240", VA = "0x182B87840", Slot = "6")]
			public void SJZTTAPRIXF(int a, UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B877D0", Offset = "0x2B861D0", VA = "0x182B877D0", Slot = "4")]
			private UnsafeList<int> YUGGXXHTFCT(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B877C0", Offset = "0x2B861C0", VA = "0x182B877C0", Slot = "5")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> PQRSTPXNREZ(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : GLIYORXVQTG<int, UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2B927E0", Offset = "0x2B911E0", VA = "0x182B927E0")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD54570", Offset = "0xD52F70", VA = "0x180D54570", Slot = "4")]
			public int HXQZBEXBHJO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0")]
			public bool BKNIWPEUIQO(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "5")]
			private bool UPXQSNYZYIJ(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2B927D0", Offset = "0x2B911D0", VA = "0x182B927D0", Slot = "6")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> MIBYYKLKLUE(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : PMEGHTFDUYN<int, UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2B875C0", Offset = "0x2B85FC0", VA = "0x182B875C0")]
			public UnsafeList<int> RATOPIWNAVL(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B87730", Offset = "0x2B86130", VA = "0x182B87730")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B87630", Offset = "0x2B86030", VA = "0x182B87630", Slot = "6")]
			public void SJZTTAPRIXF(int a, UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B875C0", Offset = "0x2B85FC0", VA = "0x182B875C0", Slot = "4")]
			private UnsafeList<int> YUGGXXHTFCT(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B875B0", Offset = "0x2B85FB0", VA = "0x182B875B0", Slot = "5")]
			private Id32<KGMTAGLYNTP<RRRVXHRUCXR>> PQRSTPXNREZ(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1CC1B70", Offset = "0x1CC0570", VA = "0x181CC1B70")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B89410", Offset = "0x2B87E10", VA = "0x182B89410")]
			public void BXVWZDHELXS([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<CCKCDLBLEMF> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B893F0", Offset = "0x2B87DF0", VA = "0x182B893F0")]
			public GenerateDataBackFromInputIndexResult(Id32<CCKCDLBLEMF> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B893E0", Offset = "0x2B87DE0", VA = "0x182B893E0")]
			public void BXVWZDHELXS([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B893C0", Offset = "0x2B87DC0", VA = "0x182B893C0")]
			public void BXVWZDHELXS([Out] Id32<DataBackResults.M> a, [Out] Id32<CCKCDLBLEMF> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<CCKCDLBLEMF> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
			public GenerateDataBackFromInputIndicesResult(Id32<CCKCDLBLEMF> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B89400", Offset = "0x2B87E00", VA = "0x182B89400")]
			public void BXVWZDHELXS([Out] Id32<DataBackResults.M> a, [Out] Id32<CCKCDLBLEMF> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B90360", Offset = "0x2B8ED60", VA = "0x182B90360")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B91DD0", Offset = "0x2B907D0", VA = "0x182B91DD0")]
		public static void UALYGHJPRNX(this FunctionCompileState a, Id32<HSLAWAWHJXI> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B90FD0", Offset = "0x2B8F9D0", VA = "0x182B90FD0")]
		public static void MLBZXEZMYRN(this FunctionCompileState a, Id32<HSLAWAWHJXI> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B90140", Offset = "0x2B8EB40", VA = "0x182B90140")]
		public static Id32<DataBackResults.M>? DKKDCOTILRS([In] this FunctionCompileState self, Id32<HSLAWAWHJXI> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B91F00", Offset = "0x2B90900", VA = "0x182B91F00")]
		public static Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> VKFVMIAYRUU([In] this FunctionCompileState self)
		{
			return default(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B921E0", Offset = "0x2B90BE0", VA = "0x182B921E0")]
		private static void ZJAPXVLTYDV(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B910A0", Offset = "0x2B8FAA0", VA = "0x182B910A0")]
		private static Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>? MVJBQPTTOOE([In] this FunctionCompileState self, Id32<CCKCDLBLEMF> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B92070", Offset = "0x2B90A70", VA = "0x182B92070")]
		public static void VRUWSEJMTME(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B915A0", Offset = "0x2B8FFA0", VA = "0x182B915A0")]
		public static DataBackResults.Def PCVTFLIIRXU([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B91310", Offset = "0x2B8FD10", VA = "0x182B91310")]
		public static ReadOnlyArray<byte> OTOJAIOYJKS([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B91920", Offset = "0x2B90320", VA = "0x182B91920")]
		public static Id32<LocalVariables.M> RYFNRSEUAUG([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FEE0", Offset = "0x2B8E8E0", VA = "0x182B8FEE0")]
		public static Union32 BVHGWLEWHAU([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E36840", Offset = "0x3E35240", VA = "0x183E36840")]
		private static Id32<DataBackResults.M> JDZDFYOFRGJ<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.CMCAYUZTWUP
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B90760", Offset = "0x2B8F160", VA = "0x182B90760")]
		public static Id32<DataBackResults.M> HCNBHTONLCN(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B90840", Offset = "0x2B8F240", VA = "0x182B90840")]
		public static Id32<DataBackResults.M> IGIUGDDJBRS(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B918A0", Offset = "0x2B902A0", VA = "0x182B918A0")]
		public static Id32<DataBackResults.M> RTTXXXREAHR(this FunctionCompileState a, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B90BA0", Offset = "0x2B8F5A0", VA = "0x182B90BA0")]
		public static Id32<DataBackResults.M> KQRKXAWGMLN(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B91290", Offset = "0x2B8FC90", VA = "0x182B91290")]
		public static Id32<DataBackResults.M> OLPIBJVIGQQ(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E367A0", Offset = "0x3E351A0", VA = "0x183E367A0")]
		private static Id32<ExecForwardResults.M> EAVICPICWOW<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.CMCAYUZTWUP
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B92380", Offset = "0x2B90D80", VA = "0x182B92380")]
		public static Id32<ExecForwardResults.M> ZPPYLSZIPZE(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B91EB0", Offset = "0x2B908B0", VA = "0x182B91EB0")]
		public static Id32<ExecForwardResults.M> VCXHJBACSBF(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B900C0", Offset = "0x2B8EAC0", VA = "0x182B900C0")]
		public static Id32<ExecForwardResults.M> DEYXFKRSIKD(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B91240", Offset = "0x2B8FC40", VA = "0x182B91240")]
		public static Id32<ExecForwardResults.M> OCIZHVTSISM(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B91E60", Offset = "0x2B90860", VA = "0x182B91E60")]
		public static Id32<ExecForwardResults.M> UKETTYMWENY(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B90ED0", Offset = "0x2B8F8D0", VA = "0x182B90ED0")]
		public static FunctionCalls.Def MBFZVXKUKTN([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B90720", Offset = "0x2B8F120", VA = "0x182B90720")]
		public static CopyEnumerable<Id32<FunctionCalls.UERCVPOWXRJ>, Id32Enumerator<FunctionCalls.UERCVPOWXRJ>> GZIAIGWIQKG([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.UERCVPOWXRJ>, Id32Enumerator<FunctionCalls.UERCVPOWXRJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B90C20", Offset = "0x2B8F620", VA = "0x182B90C20")]
		public static Id32<FunctionCalls.UERCVPOWXRJ> LIWGGIQZFHL([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.UERCVPOWXRJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B91D60", Offset = "0x2B90760", VA = "0x182B91D60")]
		public static FunctionCalls.IO SLNXQINMRVK([In] this FunctionCompileState self, Id32<FunctionCalls.UERCVPOWXRJ> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B90970", Offset = "0x2B8F370", VA = "0x182B90970")]
		public static FunctionCalls.IO JZPZDVZLJMS(this FunctionCompileState a, Id32<FunctionCalls.UERCVPOWXRJ> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E369E0", Offset = "0x3E353E0", VA = "0x183E369E0")]
		private static Id32<FunctionCalls.M> NZFUESDUUJL<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.CMCAYUZTWUP
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B91A00", Offset = "0x2B90400", VA = "0x182B91A00")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) SBUDEBOHXRK(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B91BB0", Offset = "0x2B905B0", VA = "0x182B91BB0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) SFPAVCIXPIS(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B90070", Offset = "0x2B8EA70", VA = "0x182B90070")]
		public static Id32<FunctionCalls.M> CQYSUTMSUWX(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B90630", Offset = "0x2B8F030", VA = "0x182B90630")]
		public static void FUMZKLOQXAG(this FunctionCompileState a, Id32<FunctionCalls.UERCVPOWXRJ> b, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> c, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E36A70", Offset = "0x3E35470", VA = "0x183E36A70")]
		public static GenerateDataBackResult OJURPXKKLLW<d, e>(this FunctionCompileState a, d b, e c, Id32<GNQADATMYDH> d, Id32<CCKCDLBLEMF> e) where d : VDFOEWNMPJQ<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3E38690", Offset = "0x3E37090", VA = "0x183E38690")]
		public static GenerateDataBackFromInputIndexResult SLVPXLTXDPG<f, g>(this FunctionCompileState a, f b, g c, Id32<GNQADATMYDH> d, Id32<NYBQVHGBIMX> e, int f) where f : VDFOEWNMPJQ<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3E38AE0", Offset = "0x3E374E0", VA = "0x183E38AE0")]
		public static Id32<DataBackResults.M>? VFQOBLULJFD<h, i>(this FunctionCompileState a, h b, i c, Id32<GNQADATMYDH> d, Id32<NYBQVHGBIMX> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : VDFOEWNMPJQ<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E37E70", Offset = "0x3E36870", VA = "0x183E37E70")]
		public static Id32<ExecForwardResults.M> SJEEVRSLYHB<j, k>(this FunctionCompileState a, j b, k c, Id32<GNQADATMYDH> d, Id32<HSLAWAWHJXI> e) where j : VDFOEWNMPJQ<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B909E0", Offset = "0x2B8F3E0", VA = "0x182B909E0")]
		public static LocalVariables.ArgumentInst KJUCGBEEVLV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B91790", Offset = "0x2B90190", VA = "0x182B91790")]
		public static LocalVariables.CalleeReturnValueInst RQJYVPBIJNH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B923C0", Offset = "0x2B90DC0", VA = "0x182B923C0")]
		public static LocalVariables.CallerReturnValueInst ZYHOGTIBCAC([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B913F0", Offset = "0x2B8FDF0", VA = "0x182B913F0")]
		public static Id32<LocalVariables.M> OUIPRHHGOXQ(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B90250", Offset = "0x2B8EC50", VA = "0x182B90250")]
		public static LocalVariables.ParameterInst DOOMZDADMQH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B908D0", Offset = "0x2B8F2D0", VA = "0x182B908D0")]
		public static LocalVariables.Def IICMZVGUBAH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B90920", Offset = "0x2B8F320", VA = "0x182B90920")]
		public static int? JIMSELOCTCN([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3E368E0", Offset = "0x3E352E0", VA = "0x183E368E0")]
		private static Id32<LocalVariables.M> NMDCJYOPUHT<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.CMCAYUZTWUP
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B90AF0", Offset = "0x2B8F4F0", VA = "0x182B90AF0")]
		public static Id32<LocalVariables.M> KKONINLXVOF(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B906C0", Offset = "0x2B8F0C0", VA = "0x182B906C0")]
		public static Id32<LocalVariables.M> GFRFCZWNLJQ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B91610", Offset = "0x2B90010", VA = "0x182B91610")]
		public static Id32<LocalVariables.M> QSSAJOPXESG(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B90F40", Offset = "0x2B8F940", VA = "0x182B90F40")]
		public static Id32<LocalVariables.M> MDAGLKTCVJK(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B907E0", Offset = "0x2B8F1E0", VA = "0x182B907E0")]
		public static Id32<LocalVariables.M> ICCFCLXEBTS(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B91120", Offset = "0x2B8FB20", VA = "0x182B91120")]
		public static void NCJVQGONQAJ(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B91F60", Offset = "0x2B90960", VA = "0x182B91F60")]
		public static void VKTRWIVMBHF(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FFC0", Offset = "0x2B8E9C0", VA = "0x182B8FFC0")]
		public static void CDLJESBLWZF(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B901C0", Offset = "0x2B8EBC0", VA = "0x182B901C0")]
		public static void DNDFUWPVAVG(this FunctionCompileState a, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> b, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B90DF0", Offset = "0x2B8F7F0", VA = "0x182B90DF0")]
		public static void LTUOEQUTBUI(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<KGMTAGLYNTP<BEQDFDHTNDH>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3E366C0", Offset = "0x3E350C0", VA = "0x183E366C0")]
		public static void DJMEFFMPQTH<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<KGMTAGLYNTP<UTDLMYHANGH<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface VDFOEWNMPJQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<FKAHYQVBHTH> YFVZQIFJNND(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<FKAHYQVBHTH> CPINKIWOIYI(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<FKAHYQVBHTH> VDIEILRGLBX(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<FKAHYQVBHTH> JZQKWSOJGKG(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> MTRMREPVSOE(a a, FunctionCompileState b, Id32<GNQADATMYDH> c, Id32<CCKCDLBLEMF> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> NPJSLAMMARK(a a, FunctionCompileState b, Id32<GNQADATMYDH> c, Id32<HSLAWAWHJXI> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int XUWGONUWQKG(a a, Id32<GNQADATMYDH> b, Id32<CCKCDLBLEMF> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<HSLAWAWHJXI> MAFZHAWPQQV(a a, Id32<GNQADATMYDH> b, Id32<CCKCDLBLEMF> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind WJLBRLHWUGI(a a, Id32<GNQADATMYDH> b, Id32<CCKCDLBLEMF> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool PIPMNFTUQLD(a a, Id32<GNQADATMYDH> b, Id32<CCKCDLBLEMF> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int XCTGCOOSPGW(a a, Id32<GNQADATMYDH> b, Id32<CCKCDLBLEMF> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> LXVNJOAGAJO(a a, Id32<GNQADATMYDH> b, Id32<CCKCDLBLEMF> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<FKAHYQVBHTH>) AAOBXMLBGMO(a a, Id32<GNQADATMYDH> b, Id32<CCKCDLBLEMF> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int IJAOZNKVQHC(a a, Id32<GNQADATMYDH> b, Id32<HSLAWAWHJXI> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<CCKCDLBLEMF> LFLISJXLWTP(a a, Id32<GNQADATMYDH> b, Id32<HSLAWAWHJXI> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<CCKCDLBLEMF> PISKLWHXUDG(a a, Id32<GNQADATMYDH> b, Id32<NYBQVHGBIMX> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int LZHERFDPEBW(a a, Id32<GNQADATMYDH> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? XAFCTAHDWFA(a a, Id32<GNQADATMYDH> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int MKTFPTIFHAG(a a, Id32<GNQADATMYDH> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? DIYFMRAMLKE(a a, Id32<GNQADATMYDH> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class NLVPQCBPLYD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D54800", Offset = "0x3D53200", VA = "0x183D54800")]
		public static Id32<LocalVariables.M?> QQXPWZLPOSS<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D51A50", Offset = "0x3D50450", VA = "0x183D51A50")]
		public static Id32<LocalVariables.M?> EGEQYCCPAZF<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D53D90", Offset = "0x3D52790", VA = "0x183D53D90")]
		public static Id32<LocalVariables.M?> PJEWQERJKTM<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BCD0", Offset = "0x2B8A6D0", VA = "0x182B8BCD0")]
		public static Id32<LocalVariables.M> FYJVPGJCRRM(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EAA0", Offset = "0x2B8D4A0", VA = "0x182B8EAA0")]
		public static Id32<LocalVariables.M> TZKFCVZXCQV(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CF50", Offset = "0x2B8B950", VA = "0x182B8CF50")]
		public static Id32<LocalVariables.M> LUEKJFGJNAM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F540", Offset = "0x2B8DF40", VA = "0x182B8F540")]
		public static Id32<LocalVariables.M> YDXWQRQBSOM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D470", Offset = "0x2B8BE70", VA = "0x182B8D470")]
		public static Id32<LocalVariables.M> MVGXPRZNONF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D7B0", Offset = "0x2B8C1B0", VA = "0x182B8D7B0")]
		public static Id32<LocalVariables.M> NKYRLCPAPRE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E9A0", Offset = "0x2B8D3A0", VA = "0x182B8E9A0")]
		public static Id32<LocalVariables.M> TZDQRRTTAUG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A730", Offset = "0x2B89130", VA = "0x182B8A730")]
		public static Id32<LocalVariables.M> ASNPNQPQTLX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B9F0", Offset = "0x2B8A3F0", VA = "0x182B8B9F0")]
		public static Id32<LocalVariables.M> FBPZZSRREGU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EDF0", Offset = "0x2B8D7F0", VA = "0x182B8EDF0")]
		public static Id32<LocalVariables.M> VJJNHDEIGVL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B8D0", Offset = "0x2B8A2D0", VA = "0x182B8B8D0")]
		public static Id32<LocalVariables.M> EXACKMWKZBM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C300", Offset = "0x2B8AD00", VA = "0x182B8C300")]
		public static Id32<LocalVariables.M> HREIOIUMEMP(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A510", Offset = "0x2B88F10", VA = "0x182B8A510")]
		public static Id32<LocalVariables.M> AEPGCVKICGE(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D8F0", Offset = "0x2B8C2F0", VA = "0x182B8D8F0")]
		public static Id32<LocalVariables.M> NMVZUURZKPB(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D1B0", Offset = "0x2B8BBB0", VA = "0x182B8D1B0")]
		public static Id32<LocalVariables.M> MMHQLQDJXFU(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F440", Offset = "0x2B8DE40", VA = "0x182B8F440")]
		public static Id32<LocalVariables.M> XPTSSTMQIOK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E440", Offset = "0x2B8CE40", VA = "0x182B8E440")]
		public static Id32<LocalVariables.M> ROXJYNBIYSN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF80", Offset = "0x2B8C980", VA = "0x182B8DF80")]
		public static Id32<LocalVariables.M> PQFYDWQVLHO(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BC50", Offset = "0x2B8A650", VA = "0x182B8BC50")]
		public static Id32<LocalVariables.M> FRYIJCBIATJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E920", Offset = "0x2B8D320", VA = "0x182B8E920")]
		public static Id32<LocalVariables.M> TXPUMITBSEA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C770", Offset = "0x2B8B170", VA = "0x182B8C770")]
		public static Id32<LocalVariables.M> JZULWUHZRMN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DAA0", Offset = "0x2B8C4A0", VA = "0x182B8DAA0")]
		public static Id32<LocalVariables.M> OFHCJBOAQKL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D2F0", Offset = "0x2B8BCF0", VA = "0x182B8D2F0")]
		public static Id32<LocalVariables.M> MPUDEVTLZOI(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E340", Offset = "0x2B8CD40", VA = "0x182B8E340")]
		public static Id32<LocalVariables.M> PSMZTOWXTLH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E3C0", Offset = "0x2B8CDC0", VA = "0x182B8E3C0")]
		public static Id32<LocalVariables.M> QUDNUTTPJZA(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA20", Offset = "0x2B8C420", VA = "0x182B8DA20")]
		public static Id32<LocalVariables.M> NQHSCUJNNMN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE10", Offset = "0x2B89810", VA = "0x182B8AE10")]
		public static Id32<LocalVariables.M> BGFLNLHVLJK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F640", Offset = "0x2B8E040", VA = "0x182B8F640")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> YWJBJFSSUKY(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F3C0", Offset = "0x2B8DDC0", VA = "0x182B8F3C0")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> XFQZVRCSXRO(this FunctionCompileState a, int b)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BDD0", Offset = "0x2B8A7D0", VA = "0x182B8BDD0")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> GJZJVBPMXVR(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E000", Offset = "0x2B8CA00", VA = "0x182B8E000")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> PRFBJBVUFDX(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BE70", Offset = "0x2B8A870", VA = "0x182B8BE70")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> HBRZXQVCIJL(this FunctionCompileState a, int b)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F0E0", Offset = "0x2B8DAE0", VA = "0x182B8F0E0")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> WLLHMLDBSAO(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A850", Offset = "0x2B89250", VA = "0x182B8A850")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) ATLPWQJFITF(this FunctionCompileState a, Id32<CQQKHLGBDOQ> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B330", Offset = "0x2B89D30", VA = "0x182B8B330")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) EGBIAIZLVEB(this FunctionCompileState a, Id32<BVTCYCWYPSS> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D54B30", Offset = "0x3D53530", VA = "0x183D54B30")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<FKAHYQVBHTH>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<TMarker>>, Id32<FunctionCalls.M>) UNYMIPPOVTU<TMarker>(this FunctionCompileState a, Id32<FKAHYQVBHTH> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<FKAHYQVBHTH>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E740", Offset = "0x2B8D140", VA = "0x182B8E740")]
		public static Id32<LocalVariables.M> TPPIXYLUFJS(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EEF0", Offset = "0x2B8D8F0", VA = "0x182B8EEF0")]
		public static Id32<LocalVariables.M> WCXKFWJBDBR(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C540", Offset = "0x2B8AF40", VA = "0x182B8C540")]
		public static Id32<LocalVariables.M> IEYHOKHGELG(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E800", Offset = "0x2B8D200", VA = "0x182B8E800")]
		public static Id32<LocalVariables.M> TRIMDBDSSNN(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B7D0", Offset = "0x2B8A1D0", VA = "0x182B8B7D0")]
		public static Id32<LocalVariables.M> ENVOXYFKKUQ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D690", Offset = "0x2B8C090", VA = "0x182B8D690")]
		public static Id32<LocalVariables.M> NJCAGUMIKJN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AF90", Offset = "0x2B89990", VA = "0x182B8AF90")]
		public static Id32<LocalVariables.M> CSKGYBVUMUO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBC0", Offset = "0x2B8D5C0", VA = "0x182B8EBC0")]
		public static Id32<LocalVariables.M> UHNMIYPTOHA(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B0D0", Offset = "0x2B89AD0", VA = "0x182B8B0D0")]
		public static Id32<LocalVariables.M> DXXYHEMWUIB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C630", Offset = "0x2B8B030", VA = "0x182B8C630")]
		public static Id32<LocalVariables.M> IHAITGOXFCY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A490", Offset = "0x2B88E90", VA = "0x182B8A490")]
		public static Id32<LocalVariables.M> AEGETHUQNUT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F4C0", Offset = "0x2B8DEC0", VA = "0x182B8F4C0")]
		public static Id32<LocalVariables.M> XQYDLJXJQCU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF00", Offset = "0x2B8C900", VA = "0x182B8DF00")]
		public static Id32<LocalVariables.M> PKZCTRFWENH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F180", Offset = "0x2B8DB80", VA = "0x182B8F180")]
		public static Id32<LocalVariables.M> WOQAUPJEZET(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ECC0", Offset = "0x2B8D6C0", VA = "0x182B8ECC0")]
		public static Id32<LocalVariables.M> UZDBQJOQIIQ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E200", Offset = "0x2B8CC00", VA = "0x182B8E200")]
		public static Id32<LocalVariables.M> PRHZXGVJCFH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EFE0", Offset = "0x2B8D9E0", VA = "0x182B8EFE0")]
		public static Id32<LocalVariables.M> WKEBRYGQLTU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D090", Offset = "0x2B8BA90", VA = "0x182B8D090")]
		public static Id32<LocalVariables.M> MASKQPIPAUZ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DDA0", Offset = "0x2B8C7A0", VA = "0x182B8DDA0")]
		public static Id32<LocalVariables.M> OMPSACJGJGQ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DEE0", Offset = "0x2B8C8E0", VA = "0x182B8DEE0")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> OPCTOHDOGOM(this FunctionCompileState a)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE90", Offset = "0x2B89890", VA = "0x182B8AE90")]
		public static Id32<LocalVariables.M> CSIEZMWFUOV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BB30", Offset = "0x2B8A530", VA = "0x182B8BB30")]
		public static Id32<LocalVariables.M> FGXPYGRZSUG(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DB20", Offset = "0x2B8C520", VA = "0x182B8DB20")]
		public static Id32<LocalVariables.M> OIESXIUKQSD(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D590", Offset = "0x2B8BF90", VA = "0x182B8D590")]
		public static Id32<LocalVariables.M> MYRPAKONBHF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ACF0", Offset = "0x2B896F0", VA = "0x182B8ACF0")]
		public static Id32<LocalVariables.M> BEJBDRGGSRW(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B1F0", Offset = "0x2B89BF0", VA = "0x182B8B1F0")]
		public static Id32<LocalVariables.M> DYKEOTJQTSR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D370", Offset = "0x2B8BD70", VA = "0x182B8D370")]
		public static Id32<LocalVariables.M> MUZYBTAJBEI(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C7F0", Offset = "0x2B8B1F0", VA = "0x182B8C7F0")]
		public static Id32<LocalVariables.M> KETCQRUEQOP(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E730", Offset = "0x2B8D130", VA = "0x182B8E730")]
		public static void TMWHGJEHLXU(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CA20", Offset = "0x2B8B420", VA = "0x182B8CA20")]
		public static Id32<LocalVariables.M> KVAOHIYTKQN(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E4C0", Offset = "0x2B8CEC0", VA = "0x182B8E4C0")]
		public static Id32<LocalVariables.M> SFISEJGDVZM(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F840", Offset = "0x2B8E240", VA = "0x182B8F840")]
		public static Id32<LocalVariables.M> YXEGEWSUIYL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CB20", Offset = "0x2B8B520", VA = "0x182B8CB20")]
		public static Id32<LocalVariables.M> KXKOULYRQNB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C900", Offset = "0x2B8B300", VA = "0x182B8C900")]
		public static Id32<LocalVariables.M> KUUIYQQCOGY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F280", Offset = "0x2B8DC80", VA = "0x182B8F280")]
		public static Id32<LocalVariables.M> XAYPSPUNDSN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BEF0", Offset = "0x2B8A8F0", VA = "0x182B8BEF0")]
		public static Id32<LocalVariables.M> HNNEJQJZFLT(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C440", Offset = "0x2B8AE40", VA = "0x182B8C440")]
		public static Id32<LocalVariables.M> IDRZMPDSFJM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A610", Offset = "0x2B89010", VA = "0x182B8A610")]
		public static Id32<LocalVariables.M> AQJERBQYICB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DC60", Offset = "0x2B8C660", VA = "0x182B8DC60")]
		public static Id32<LocalVariables.M> OKEXXCMNSQM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3D52190", Offset = "0x3D50B90", VA = "0x183D52190")]
		public static void JKETOAVTQMV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CQQKHLGBDOQ> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3D53EC0", Offset = "0x3D528C0", VA = "0x183D53EC0")]
		public static void PVQSPGQKPVB<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<BVTCYCWYPSS> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3D52D70", Offset = "0x3D51770", VA = "0x183D52D70")]
		public static Id32<LocalVariables.M> NZDRZSUITEF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3D51C80", Offset = "0x3D50680", VA = "0x183D51C80")]
		public static Id32<LocalVariables.M> ILZABXPGSKC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3D54C40", Offset = "0x3D53640", VA = "0x183D54C40")]
		public static Id32<DataBackResults.M> UZWPBWYJTNF<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, VDFOEWNMPJQ<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3D54F50", Offset = "0x3D53950", VA = "0x183D54F50")]
		public static Id32<ExecForwardResults.M> WKDEKTSHIQQ<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, VDFOEWNMPJQ<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E5E0", Offset = "0x2B8CFE0", VA = "0x182B8E5E0")]
		public static Id32<DataBackResults.M> TEAVPQPPOXG(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CC20", Offset = "0x2B8B620", VA = "0x182B8CC20")]
		public static Id32<DataBackResults.M> LBMTJEHMOSG(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3D532F0", Offset = "0x3D51CF0", VA = "0x183D532F0")]
		public static Id32<DataBackResults.M> PEJPTQOIUHL<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CQQKHLGBDOQ> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3D53080", Offset = "0x3D51A80", VA = "0x183D53080")]
		private static Id32<DataBackResults.M> PEJPTQOIUHL<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CQQKHLGBDOQ> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3D52920", Offset = "0x3D51320", VA = "0x183D52920")]
		public static Id32<LocalVariables.M> KRHAFODUWCF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3D55250", Offset = "0x3D53C50", VA = "0x183D55250")]
		public static void ZREZFQQDNEI<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
		public LiveInterval(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> firstUse, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A160", Offset = "0x2B88B60", VA = "0x182B8A160")]
		public static LiveInterval New(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class YUOPJWDRBXC : CMCAYUZTWUP
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
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class QHJRCLYUKQY : CMCAYUZTWUP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class XXCGHWAUASX : CMCAYUZTWUP
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
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
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
		public abstract class CMCAYUZTWUP
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
			public Id32<CMCAYUZTWUP> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2B896E0", Offset = "0x2B880E0", VA = "0x182B896E0")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<CMCAYUZTWUP> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class HVSJGHAWALI : CMCAYUZTWUP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<YUOPJWDRBXC, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<XXCGHWAUASX, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<HVSJGHAWALI, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<QHJRCLYUKQY, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A360", Offset = "0x2B88D60", VA = "0x182B8A360")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<YUOPJWDRBXC, ArgumentInst> argumentVariables, [In] SOAId32Field<XXCGHWAUASX, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<HVSJGHAWALI, ParameterInst> parameterVariables, [In] SOAId32Field<QHJRCLYUKQY, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A170", Offset = "0x2B88B70", VA = "0x182B8A170")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class HCBGCUPBBJR
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B89420", Offset = "0x2B87E20", VA = "0x182B89420")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class CPNKHOXPEST
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B87F80", Offset = "0x2B86980", VA = "0x182B87F80")]
		public static void XTRREELNPZX(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.UERCVPOWXRJ, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B87E70", Offset = "0x2B86870", VA = "0x182B87E70")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.UERCVPOWXRJ, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B87E00", Offset = "0x2B86800", VA = "0x182B87E00")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B87BE0", Offset = "0x2B865E0", VA = "0x182B87BE0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3690DD0", Offset = "0x368F7D0", VA = "0x183690DD0")]
		public static void XTRREELNPZX<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<GNQADATMYDH> graphId) where TDeps : notnull, VDFOEWNMPJQ<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class VRTDYJNDBYY
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B929B0", Offset = "0x2B913B0", VA = "0x182B929B0")]
		public static void XTRREELNPZX(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void JZJIZDFYZGI(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2B8FB40", Offset = "0x2B8E540", VA = "0x182B8FB40", Slot = "4")]
			public void JZJIZDFYZGI(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2B8FBD0", Offset = "0x2B8E5D0", VA = "0x182B8FBD0", Slot = "4")]
			public void JZJIZDFYZGI(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2B8FA00", Offset = "0x2B8E400", VA = "0x182B8FA00", Slot = "4")]
			public void JZJIZDFYZGI(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2B8FA90", Offset = "0x2B8E490", VA = "0x182B8FA90", Slot = "4")]
			public void JZJIZDFYZGI(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class URGJJIJXUPR<c> where c : struct, EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c XBSGLFJHVQL;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4172C50", Offset = "0x4171650", VA = "0x184172C50")]
			public static int XTRREELNPZX<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : VDFOEWNMPJQ<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<FunctionCalls.UERCVPOWXRJ>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B89690", Offset = "0x2B88090", VA = "0x182B89690")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<FunctionCalls.UERCVPOWXRJ>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B895E0", Offset = "0x2B87FE0", VA = "0x182B895E0")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B895A0", Offset = "0x2B87FA0", VA = "0x182B895A0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA400", Offset = "0x3BA8E00", VA = "0x183BAA400")]
		public static void XTRREELNPZX<b, a>(FunctionCompileState a, b b, a c) where b : VDFOEWNMPJQ<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class LXWIOPPTZEB
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
		private static int SRMKYDKFQWJ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int TVPHXJSOYPB;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B89A50", Offset = "0x2B88450", VA = "0x182B89A50")]
		public static void XTRREELNPZX(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B89840", Offset = "0x2B88240", VA = "0x182B89840")]
		private static void PUEFFAKTMJK([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B89700", Offset = "0x2B88100", VA = "0x182B89700")]
		private static void PUEFFAKTMJK(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B89FB0", Offset = "0x2B889B0", VA = "0x182B89FB0")]
		private static void XXIKOFQDEZB(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class RMBUJYUKGON<a, b, c> where a : struct, PMEGHTFDUYN<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a XBSGLFJHVQL;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x767AAA0", Offset = "0x76794A0", VA = "0x18767AAA0")]
		public static void XTRREELNPZX([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface PMEGHTFDUYN<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> RATOPIWNAVL(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SJZTTAPRIXF(a a, b b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface GLIYORXVQTG<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a HXQZBEXBHJO(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BKNIWPEUIQO(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class IZDYRGUOHFG<a, b, c> where a : struct, GLIYORXVQTG<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a XBSGLFJHVQL;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x65B2EC0", Offset = "0x65B18C0", VA = "0x1865B2EC0")]
		public static UnsafeList<b> XTRREELNPZX(int a, [In] c values)
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
