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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B90C10", Offset = "0x2B8F810", VA = "0x182B90C10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B1E620", Offset = "0x2B1D220", VA = "0x182B1E620")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B891A0", Offset = "0x2B87DA0", VA = "0x182B891A0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x238B410", Offset = "0x238A010", VA = "0x18238B410", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B894B0", Offset = "0x2B880B0", VA = "0x182B894B0")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<LKKKABWYIBZ, BytesImmediate> bytesImmediates, [In] IdUnsafeList<GOUCNEWEBWG, DeadEnd> deadEnds, [In] IdUnsafeList<KRRICHCQKAD, Variable> variables, [In] IdUnsafeList<NVAZKMNTIYV, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B89370", Offset = "0x2B87F70", VA = "0x182B89370")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class AFVTVMRWSSE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B88220", Offset = "0x2B86E20", VA = "0x182B88220")]
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
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B895D0", Offset = "0x2B881D0", VA = "0x182B895D0")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<YZKALMDVUYO, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B89540", Offset = "0x2B88140", VA = "0x182B89540")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class BHWODCZAHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B89140", Offset = "0x2B87D40", VA = "0x182B89140")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B896B0", Offset = "0x2B882B0", VA = "0x182B896B0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B89610", Offset = "0x2B88210", VA = "0x182B89610")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class HSPTFGHULBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A760", Offset = "0x2B89360", VA = "0x182B8A760")]
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
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
			private Inst(Def def, Id32<CMCAYUZTWUP> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8A960", Offset = "0x2B89560", VA = "0x182B8A960")]
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
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B895D0", Offset = "0x2B881D0", VA = "0x182B895D0")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8A7B0", Offset = "0x2B893B0", VA = "0x182B8A7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B898B0", Offset = "0x2B884B0", VA = "0x182B898B0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<QCMXMPNXPGS, InternalCall> internalCalls, [In] IdUnsafeList<NLFWFOKFOWQ, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<UERCVPOWXRJ> IOId)> callsWithIO, [In] IdUnsafeList<UERCVPOWXRJ, IO> io, [In] SOAField<UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> ioModifyingCallLocations, [In] SOAField<UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B89710", Offset = "0x2B88310", VA = "0x182B89710")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class QLAWRIAGWYA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B91120", Offset = "0x2B8FD20", VA = "0x182B91120")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B90F10", Offset = "0x2B8FB10", VA = "0x182B90F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8A300", Offset = "0x2B88F00", VA = "0x182B8A300")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<HSLAWAWHJXI, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<HSLAWAWHJXI>> generatedOutputsForExpression, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B89970", Offset = "0x2B88570", VA = "0x182B89970")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B937B0", Offset = "0x2B923B0", VA = "0x182B937B0")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B93760", Offset = "0x2B92360", VA = "0x182B93760", Slot = "4")]
			public Id32<FunctionCalls.UERCVPOWXRJ> HXQZBEXBHJO(int a)
			{
				return default(Id32<FunctionCalls.UERCVPOWXRJ>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
			public bool BKNIWPEUIQO(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "5")]
			private bool APZKZQMGMMQ(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B937A0", Offset = "0x2B923A0", VA = "0x182B937A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B882E0", Offset = "0x2B86EE0", VA = "0x182B882E0")]
			public UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> RATOPIWNAVL(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B883F0", Offset = "0x2B86FF0", VA = "0x182B883F0")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B88350", Offset = "0x2B86F50", VA = "0x182B88350", Slot = "6")]
			public void SJZTTAPRIXF(Id32<FunctionCalls.UERCVPOWXRJ> a, SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B882E0", Offset = "0x2B86EE0", VA = "0x182B882E0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> JEJNPXKTANW(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B882D0", Offset = "0x2B86ED0", VA = "0x182B882D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B93880", Offset = "0x2B92480", VA = "0x182B93880")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B93830", Offset = "0x2B92430", VA = "0x182B93830", Slot = "4")]
			public Id32<FunctionCalls.UERCVPOWXRJ> HXQZBEXBHJO(int a)
			{
				return default(Id32<FunctionCalls.UERCVPOWXRJ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
			public bool BKNIWPEUIQO(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "5")]
			private bool AXGYJOHTNGZ(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B93870", Offset = "0x2B92470", VA = "0x182B93870", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B88480", Offset = "0x2B87080", VA = "0x182B88480")]
			public UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> RATOPIWNAVL(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B88590", Offset = "0x2B87190", VA = "0x182B88590")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B884F0", Offset = "0x2B870F0", VA = "0x182B884F0", Slot = "6")]
			public void SJZTTAPRIXF(Id32<FunctionCalls.UERCVPOWXRJ> a, SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B88480", Offset = "0x2B87080", VA = "0x182B88480", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> TLGWPMKCRQN(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B88470", Offset = "0x2B87070", VA = "0x182B88470", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B939B0", Offset = "0x2B925B0", VA = "0x182B939B0")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2B93970", Offset = "0x2B92570", VA = "0x182B93970", Slot = "4")]
			public Id32<CCKCDLBLEMF> HXQZBEXBHJO(int a)
			{
				return default(Id32<CCKCDLBLEMF>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B93900", Offset = "0x2B92500", VA = "0x182B93900")]
			public bool BKNIWPEUIQO(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B93900", Offset = "0x2B92500", VA = "0x182B93900", Slot = "5")]
			private bool DPFSWVUEMXB(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B93960", Offset = "0x2B92560", VA = "0x182B93960", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B88610", Offset = "0x2B87210", VA = "0x182B88610")]
			public UnsafeList<Id32<CCKCDLBLEMF>> RATOPIWNAVL(int a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(UnsafeList<Id32<CCKCDLBLEMF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B88790", Offset = "0x2B87390", VA = "0x182B88790")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B88680", Offset = "0x2B87280", VA = "0x182B88680", Slot = "6")]
			public void SJZTTAPRIXF(Id32<CCKCDLBLEMF> a, SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B88610", Offset = "0x2B87210", VA = "0x182B88610", Slot = "4")]
			private UnsafeList<Id32<CCKCDLBLEMF>> JUOZFCBUBXF(int a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(UnsafeList<Id32<CCKCDLBLEMF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B88780", Offset = "0x2B87380", VA = "0x182B88780", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B93BB0", Offset = "0x2B927B0", VA = "0x182B93BB0")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD54570", Offset = "0xD53170", VA = "0x180D54570", Slot = "4")]
			public int HXQZBEXBHJO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
			public bool BKNIWPEUIQO(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "5")]
			private bool SVZFHFBSXVU(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B93BA0", Offset = "0x2B927A0", VA = "0x182B93BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B88C70", Offset = "0x2B87870", VA = "0x182B88C70")]
			public UnsafeList<int> RATOPIWNAVL(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B88DE0", Offset = "0x2B879E0", VA = "0x182B88DE0")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B88CE0", Offset = "0x2B878E0", VA = "0x182B88CE0", Slot = "6")]
			public void SJZTTAPRIXF(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B88C70", Offset = "0x2B87870", VA = "0x182B88C70", Slot = "4")]
			private UnsafeList<int> XJQRPADZNII(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B88C60", Offset = "0x2B87860", VA = "0x182B88C60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B93B10", Offset = "0x2B92710", VA = "0x182B93B10")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD54570", Offset = "0xD53170", VA = "0x180D54570", Slot = "4")]
			public int HXQZBEXBHJO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
			public bool BKNIWPEUIQO(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "5")]
			private bool UPXQSNYZYIJ(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B93B00", Offset = "0x2B92700", VA = "0x182B93B00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B88A60", Offset = "0x2B87660", VA = "0x182B88A60")]
			public UnsafeList<int> RATOPIWNAVL(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B88BD0", Offset = "0x2B877D0", VA = "0x182B88BD0")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B88AD0", Offset = "0x2B876D0", VA = "0x182B88AD0", Slot = "6")]
			public void SJZTTAPRIXF(int a, UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B88A60", Offset = "0x2B87660", VA = "0x182B88A60", Slot = "4")]
			private UnsafeList<int> YUGGXXHTFCT(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B88A50", Offset = "0x2B87650", VA = "0x182B88A50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B93A70", Offset = "0x2B92670", VA = "0x182B93A70")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD54570", Offset = "0xD53170", VA = "0x180D54570", Slot = "4")]
			public int HXQZBEXBHJO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
			public bool BKNIWPEUIQO(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "5")]
			private bool UPXQSNYZYIJ(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2B93A60", Offset = "0x2B92660", VA = "0x182B93A60", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B88850", Offset = "0x2B87450", VA = "0x182B88850")]
			public UnsafeList<int> RATOPIWNAVL(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B889C0", Offset = "0x2B875C0", VA = "0x182B889C0")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B888C0", Offset = "0x2B874C0", VA = "0x182B888C0", Slot = "6")]
			public void SJZTTAPRIXF(int a, UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B88850", Offset = "0x2B87450", VA = "0x182B88850", Slot = "4")]
			private UnsafeList<int> YUGGXXHTFCT(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B88840", Offset = "0x2B87440", VA = "0x182B88840", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1CC3410", Offset = "0x1CC2010", VA = "0x181CC3410")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B8A6A0", Offset = "0x2B892A0", VA = "0x182B8A6A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8A680", Offset = "0x2B89280", VA = "0x182B8A680")]
			public GenerateDataBackFromInputIndexResult(Id32<CCKCDLBLEMF> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8A670", Offset = "0x2B89270", VA = "0x182B8A670")]
			public void BXVWZDHELXS([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B8A650", Offset = "0x2B89250", VA = "0x182B8A650")]
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
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
			public GenerateDataBackFromInputIndicesResult(Id32<CCKCDLBLEMF> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8A690", Offset = "0x2B89290", VA = "0x182B8A690")]
			public void BXVWZDHELXS([Out] Id32<DataBackResults.M> a, [Out] Id32<CCKCDLBLEMF> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B915F0", Offset = "0x2B901F0", VA = "0x182B915F0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B93060", Offset = "0x2B91C60", VA = "0x182B93060")]
		public static void UALYGHJPRNX(this FunctionCompileState a, Id32<HSLAWAWHJXI> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B92260", Offset = "0x2B90E60", VA = "0x182B92260")]
		public static void MLBZXEZMYRN(this FunctionCompileState a, Id32<HSLAWAWHJXI> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B913D0", Offset = "0x2B8FFD0", VA = "0x182B913D0")]
		public static Id32<DataBackResults.M>? DKKDCOTILRS([In] this FunctionCompileState self, Id32<HSLAWAWHJXI> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B93190", Offset = "0x2B91D90", VA = "0x182B93190")]
		public static Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> VKFVMIAYRUU([In] this FunctionCompileState self)
		{
			return default(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B93470", Offset = "0x2B92070", VA = "0x182B93470")]
		private static void ZJAPXVLTYDV(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B92330", Offset = "0x2B90F30", VA = "0x182B92330")]
		private static Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>? MVJBQPTTOOE([In] this FunctionCompileState self, Id32<CCKCDLBLEMF> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B93300", Offset = "0x2B91F00", VA = "0x182B93300")]
		public static void VRUWSEJMTME(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B92830", Offset = "0x2B91430", VA = "0x182B92830")]
		public static DataBackResults.Def PCVTFLIIRXU([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B925A0", Offset = "0x2B911A0", VA = "0x182B925A0")]
		public static ReadOnlyArray<byte> OTOJAIOYJKS([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B92BB0", Offset = "0x2B917B0", VA = "0x182B92BB0")]
		public static Id32<LocalVariables.M> RYFNRSEUAUG([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B91170", Offset = "0x2B8FD70", VA = "0x182B91170")]
		public static Union32 BVHGWLEWHAU([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E37F30", Offset = "0x3E36B30", VA = "0x183E37F30")]
		private static Id32<DataBackResults.M> JDZDFYOFRGJ<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.CMCAYUZTWUP
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B919F0", Offset = "0x2B905F0", VA = "0x182B919F0")]
		public static Id32<DataBackResults.M> HCNBHTONLCN(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B91AD0", Offset = "0x2B906D0", VA = "0x182B91AD0")]
		public static Id32<DataBackResults.M> IGIUGDDJBRS(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B92B30", Offset = "0x2B91730", VA = "0x182B92B30")]
		public static Id32<DataBackResults.M> RTTXXXREAHR(this FunctionCompileState a, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B91E30", Offset = "0x2B90A30", VA = "0x182B91E30")]
		public static Id32<DataBackResults.M> KQRKXAWGMLN(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B92520", Offset = "0x2B91120", VA = "0x182B92520")]
		public static Id32<DataBackResults.M> OLPIBJVIGQQ(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E37E90", Offset = "0x3E36A90", VA = "0x183E37E90")]
		private static Id32<ExecForwardResults.M> EAVICPICWOW<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.CMCAYUZTWUP
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B93610", Offset = "0x2B92210", VA = "0x182B93610")]
		public static Id32<ExecForwardResults.M> ZPPYLSZIPZE(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B93140", Offset = "0x2B91D40", VA = "0x182B93140")]
		public static Id32<ExecForwardResults.M> VCXHJBACSBF(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B91350", Offset = "0x2B8FF50", VA = "0x182B91350")]
		public static Id32<ExecForwardResults.M> DEYXFKRSIKD(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B924D0", Offset = "0x2B910D0", VA = "0x182B924D0")]
		public static Id32<ExecForwardResults.M> OCIZHVTSISM(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B930F0", Offset = "0x2B91CF0", VA = "0x182B930F0")]
		public static Id32<ExecForwardResults.M> UKETTYMWENY(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B92160", Offset = "0x2B90D60", VA = "0x182B92160")]
		public static FunctionCalls.Def MBFZVXKUKTN([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B919B0", Offset = "0x2B905B0", VA = "0x182B919B0")]
		public static CopyEnumerable<Id32<FunctionCalls.UERCVPOWXRJ>, Id32Enumerator<FunctionCalls.UERCVPOWXRJ>> GZIAIGWIQKG([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.UERCVPOWXRJ>, Id32Enumerator<FunctionCalls.UERCVPOWXRJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B91EB0", Offset = "0x2B90AB0", VA = "0x182B91EB0")]
		public static Id32<FunctionCalls.UERCVPOWXRJ> LIWGGIQZFHL([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.UERCVPOWXRJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B92FF0", Offset = "0x2B91BF0", VA = "0x182B92FF0")]
		public static FunctionCalls.IO SLNXQINMRVK([In] this FunctionCompileState self, Id32<FunctionCalls.UERCVPOWXRJ> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B91C00", Offset = "0x2B90800", VA = "0x182B91C00")]
		public static FunctionCalls.IO JZPZDVZLJMS(this FunctionCompileState a, Id32<FunctionCalls.UERCVPOWXRJ> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E380D0", Offset = "0x3E36CD0", VA = "0x183E380D0")]
		private static Id32<FunctionCalls.M> NZFUESDUUJL<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.CMCAYUZTWUP
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B92C90", Offset = "0x2B91890", VA = "0x182B92C90")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) SBUDEBOHXRK(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B92E40", Offset = "0x2B91A40", VA = "0x182B92E40")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) SFPAVCIXPIS(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B91300", Offset = "0x2B8FF00", VA = "0x182B91300")]
		public static Id32<FunctionCalls.M> CQYSUTMSUWX(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B918C0", Offset = "0x2B904C0", VA = "0x182B918C0")]
		public static void FUMZKLOQXAG(this FunctionCompileState a, Id32<FunctionCalls.UERCVPOWXRJ> b, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> c, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E38160", Offset = "0x3E36D60", VA = "0x183E38160")]
		public static GenerateDataBackResult OJURPXKKLLW<d, e>(this FunctionCompileState a, d b, e c, Id32<GNQADATMYDH> d, Id32<CCKCDLBLEMF> e) where d : VDFOEWNMPJQ<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3E39D80", Offset = "0x3E38980", VA = "0x183E39D80")]
		public static GenerateDataBackFromInputIndexResult SLVPXLTXDPG<f, g>(this FunctionCompileState a, f b, g c, Id32<GNQADATMYDH> d, Id32<NYBQVHGBIMX> e, int f) where f : VDFOEWNMPJQ<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A1D0", Offset = "0x3E38DD0", VA = "0x183E3A1D0")]
		public static Id32<DataBackResults.M>? VFQOBLULJFD<h, i>(this FunctionCompileState a, h b, i c, Id32<GNQADATMYDH> d, Id32<NYBQVHGBIMX> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : VDFOEWNMPJQ<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E39560", Offset = "0x3E38160", VA = "0x183E39560")]
		public static Id32<ExecForwardResults.M> SJEEVRSLYHB<j, k>(this FunctionCompileState a, j b, k c, Id32<GNQADATMYDH> d, Id32<HSLAWAWHJXI> e) where j : VDFOEWNMPJQ<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B91C70", Offset = "0x2B90870", VA = "0x182B91C70")]
		public static LocalVariables.ArgumentInst KJUCGBEEVLV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B92A20", Offset = "0x2B91620", VA = "0x182B92A20")]
		public static LocalVariables.CalleeReturnValueInst RQJYVPBIJNH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B93650", Offset = "0x2B92250", VA = "0x182B93650")]
		public static LocalVariables.CallerReturnValueInst ZYHOGTIBCAC([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B92680", Offset = "0x2B91280", VA = "0x182B92680")]
		public static Id32<LocalVariables.M> OUIPRHHGOXQ(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B914E0", Offset = "0x2B900E0", VA = "0x182B914E0")]
		public static LocalVariables.ParameterInst DOOMZDADMQH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B91B60", Offset = "0x2B90760", VA = "0x182B91B60")]
		public static LocalVariables.Def IICMZVGUBAH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B91BB0", Offset = "0x2B907B0", VA = "0x182B91BB0")]
		public static int? JIMSELOCTCN([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3E37FD0", Offset = "0x3E36BD0", VA = "0x183E37FD0")]
		private static Id32<LocalVariables.M> NMDCJYOPUHT<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.CMCAYUZTWUP
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B91D80", Offset = "0x2B90980", VA = "0x182B91D80")]
		public static Id32<LocalVariables.M> KKONINLXVOF(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B91950", Offset = "0x2B90550", VA = "0x182B91950")]
		public static Id32<LocalVariables.M> GFRFCZWNLJQ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B928A0", Offset = "0x2B914A0", VA = "0x182B928A0")]
		public static Id32<LocalVariables.M> QSSAJOPXESG(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B921D0", Offset = "0x2B90DD0", VA = "0x182B921D0")]
		public static Id32<LocalVariables.M> MDAGLKTCVJK(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B91A70", Offset = "0x2B90670", VA = "0x182B91A70")]
		public static Id32<LocalVariables.M> ICCFCLXEBTS(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B923B0", Offset = "0x2B90FB0", VA = "0x182B923B0")]
		public static void NCJVQGONQAJ(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B931F0", Offset = "0x2B91DF0", VA = "0x182B931F0")]
		public static void VKTRWIVMBHF(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B91250", Offset = "0x2B8FE50", VA = "0x182B91250")]
		public static void CDLJESBLWZF(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B91450", Offset = "0x2B90050", VA = "0x182B91450")]
		public static void DNDFUWPVAVG(this FunctionCompileState a, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> b, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B92080", Offset = "0x2B90C80", VA = "0x182B92080")]
		public static void LTUOEQUTBUI(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<KGMTAGLYNTP<BEQDFDHTNDH>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3E37DB0", Offset = "0x3E369B0", VA = "0x183E37DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D55EF0", Offset = "0x3D54AF0", VA = "0x183D55EF0")]
		public static Id32<LocalVariables.M?> QQXPWZLPOSS<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D53140", Offset = "0x3D51D40", VA = "0x183D53140")]
		public static Id32<LocalVariables.M?> EGEQYCCPAZF<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D55480", Offset = "0x3D54080", VA = "0x183D55480")]
		public static Id32<LocalVariables.M?> PJEWQERJKTM<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CF60", Offset = "0x2B8BB60", VA = "0x182B8CF60")]
		public static Id32<LocalVariables.M> FYJVPGJCRRM(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FD30", Offset = "0x2B8E930", VA = "0x182B8FD30")]
		public static Id32<LocalVariables.M> TZKFCVZXCQV(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E1E0", Offset = "0x2B8CDE0", VA = "0x182B8E1E0")]
		public static Id32<LocalVariables.M> LUEKJFGJNAM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B907D0", Offset = "0x2B8F3D0", VA = "0x182B907D0")]
		public static Id32<LocalVariables.M> YDXWQRQBSOM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E700", Offset = "0x2B8D300", VA = "0x182B8E700")]
		public static Id32<LocalVariables.M> MVGXPRZNONF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA40", Offset = "0x2B8D640", VA = "0x182B8EA40")]
		public static Id32<LocalVariables.M> NKYRLCPAPRE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FC30", Offset = "0x2B8E830", VA = "0x182B8FC30")]
		public static Id32<LocalVariables.M> TZDQRRTTAUG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B9C0", Offset = "0x2B8A5C0", VA = "0x182B8B9C0")]
		public static Id32<LocalVariables.M> ASNPNQPQTLX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CC80", Offset = "0x2B8B880", VA = "0x182B8CC80")]
		public static Id32<LocalVariables.M> FBPZZSRREGU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B90080", Offset = "0x2B8EC80", VA = "0x182B90080")]
		public static Id32<LocalVariables.M> VJJNHDEIGVL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CB60", Offset = "0x2B8B760", VA = "0x182B8CB60")]
		public static Id32<LocalVariables.M> EXACKMWKZBM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D590", Offset = "0x2B8C190", VA = "0x182B8D590")]
		public static Id32<LocalVariables.M> HREIOIUMEMP(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B7A0", Offset = "0x2B8A3A0", VA = "0x182B8B7A0")]
		public static Id32<LocalVariables.M> AEPGCVKICGE(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EB80", Offset = "0x2B8D780", VA = "0x182B8EB80")]
		public static Id32<LocalVariables.M> NMVZUURZKPB(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E440", Offset = "0x2B8D040", VA = "0x182B8E440")]
		public static Id32<LocalVariables.M> MMHQLQDJXFU(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B906D0", Offset = "0x2B8F2D0", VA = "0x182B906D0")]
		public static Id32<LocalVariables.M> XPTSSTMQIOK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F6D0", Offset = "0x2B8E2D0", VA = "0x182B8F6D0")]
		public static Id32<LocalVariables.M> ROXJYNBIYSN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F210", Offset = "0x2B8DE10", VA = "0x182B8F210")]
		public static Id32<LocalVariables.M> PQFYDWQVLHO(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CEE0", Offset = "0x2B8BAE0", VA = "0x182B8CEE0")]
		public static Id32<LocalVariables.M> FRYIJCBIATJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FBB0", Offset = "0x2B8E7B0", VA = "0x182B8FBB0")]
		public static Id32<LocalVariables.M> TXPUMITBSEA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA00", Offset = "0x2B8C600", VA = "0x182B8DA00")]
		public static Id32<LocalVariables.M> JZULWUHZRMN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ED30", Offset = "0x2B8D930", VA = "0x182B8ED30")]
		public static Id32<LocalVariables.M> OFHCJBOAQKL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E580", Offset = "0x2B8D180", VA = "0x182B8E580")]
		public static Id32<LocalVariables.M> MPUDEVTLZOI(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F5D0", Offset = "0x2B8E1D0", VA = "0x182B8F5D0")]
		public static Id32<LocalVariables.M> PSMZTOWXTLH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F650", Offset = "0x2B8E250", VA = "0x182B8F650")]
		public static Id32<LocalVariables.M> QUDNUTTPJZA(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ECB0", Offset = "0x2B8D8B0", VA = "0x182B8ECB0")]
		public static Id32<LocalVariables.M> NQHSCUJNNMN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C0A0", Offset = "0x2B8ACA0", VA = "0x182B8C0A0")]
		public static Id32<LocalVariables.M> BGFLNLHVLJK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B908D0", Offset = "0x2B8F4D0", VA = "0x182B908D0")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> YWJBJFSSUKY(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B90650", Offset = "0x2B8F250", VA = "0x182B90650")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> XFQZVRCSXRO(this FunctionCompileState a, int b)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D060", Offset = "0x2B8BC60", VA = "0x182B8D060")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> GJZJVBPMXVR(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F290", Offset = "0x2B8DE90", VA = "0x182B8F290")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> PRFBJBVUFDX(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D100", Offset = "0x2B8BD00", VA = "0x182B8D100")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> HBRZXQVCIJL(this FunctionCompileState a, int b)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B90370", Offset = "0x2B8EF70", VA = "0x182B90370")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> WLLHMLDBSAO(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BAE0", Offset = "0x2B8A6E0", VA = "0x182B8BAE0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) ATLPWQJFITF(this FunctionCompileState a, Id32<CQQKHLGBDOQ> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C5C0", Offset = "0x2B8B1C0", VA = "0x182B8C5C0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) EGBIAIZLVEB(this FunctionCompileState a, Id32<BVTCYCWYPSS> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D56220", Offset = "0x3D54E20", VA = "0x183D56220")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<FKAHYQVBHTH>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<TMarker>>, Id32<FunctionCalls.M>) UNYMIPPOVTU<TMarker>(this FunctionCompileState a, Id32<FKAHYQVBHTH> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<FKAHYQVBHTH>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F9D0", Offset = "0x2B8E5D0", VA = "0x182B8F9D0")]
		public static Id32<LocalVariables.M> TPPIXYLUFJS(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B90180", Offset = "0x2B8ED80", VA = "0x182B90180")]
		public static Id32<LocalVariables.M> WCXKFWJBDBR(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D7D0", Offset = "0x2B8C3D0", VA = "0x182B8D7D0")]
		public static Id32<LocalVariables.M> IEYHOKHGELG(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FA90", Offset = "0x2B8E690", VA = "0x182B8FA90")]
		public static Id32<LocalVariables.M> TRIMDBDSSNN(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CA60", Offset = "0x2B8B660", VA = "0x182B8CA60")]
		public static Id32<LocalVariables.M> ENVOXYFKKUQ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E920", Offset = "0x2B8D520", VA = "0x182B8E920")]
		public static Id32<LocalVariables.M> NJCAGUMIKJN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C220", Offset = "0x2B8AE20", VA = "0x182B8C220")]
		public static Id32<LocalVariables.M> CSKGYBVUMUO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FE50", Offset = "0x2B8EA50", VA = "0x182B8FE50")]
		public static Id32<LocalVariables.M> UHNMIYPTOHA(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C360", Offset = "0x2B8AF60", VA = "0x182B8C360")]
		public static Id32<LocalVariables.M> DXXYHEMWUIB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D8C0", Offset = "0x2B8C4C0", VA = "0x182B8D8C0")]
		public static Id32<LocalVariables.M> IHAITGOXFCY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B720", Offset = "0x2B8A320", VA = "0x182B8B720")]
		public static Id32<LocalVariables.M> AEGETHUQNUT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B90750", Offset = "0x2B8F350", VA = "0x182B90750")]
		public static Id32<LocalVariables.M> XQYDLJXJQCU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F190", Offset = "0x2B8DD90", VA = "0x182B8F190")]
		public static Id32<LocalVariables.M> PKZCTRFWENH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B90410", Offset = "0x2B8F010", VA = "0x182B90410")]
		public static Id32<LocalVariables.M> WOQAUPJEZET(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FF50", Offset = "0x2B8EB50", VA = "0x182B8FF50")]
		public static Id32<LocalVariables.M> UZDBQJOQIIQ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F490", Offset = "0x2B8E090", VA = "0x182B8F490")]
		public static Id32<LocalVariables.M> PRHZXGVJCFH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B90270", Offset = "0x2B8EE70", VA = "0x182B90270")]
		public static Id32<LocalVariables.M> WKEBRYGQLTU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E320", Offset = "0x2B8CF20", VA = "0x182B8E320")]
		public static Id32<LocalVariables.M> MASKQPIPAUZ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F030", Offset = "0x2B8DC30", VA = "0x182B8F030")]
		public static Id32<LocalVariables.M> OMPSACJGJGQ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F170", Offset = "0x2B8DD70", VA = "0x182B8F170")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> OPCTOHDOGOM(this FunctionCompileState a)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C120", Offset = "0x2B8AD20", VA = "0x182B8C120")]
		public static Id32<LocalVariables.M> CSIEZMWFUOV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CDC0", Offset = "0x2B8B9C0", VA = "0x182B8CDC0")]
		public static Id32<LocalVariables.M> FGXPYGRZSUG(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EDB0", Offset = "0x2B8D9B0", VA = "0x182B8EDB0")]
		public static Id32<LocalVariables.M> OIESXIUKQSD(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E820", Offset = "0x2B8D420", VA = "0x182B8E820")]
		public static Id32<LocalVariables.M> MYRPAKONBHF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BF80", Offset = "0x2B8AB80", VA = "0x182B8BF80")]
		public static Id32<LocalVariables.M> BEJBDRGGSRW(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C480", Offset = "0x2B8B080", VA = "0x182B8C480")]
		public static Id32<LocalVariables.M> DYKEOTJQTSR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E600", Offset = "0x2B8D200", VA = "0x182B8E600")]
		public static Id32<LocalVariables.M> MUZYBTAJBEI(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA80", Offset = "0x2B8C680", VA = "0x182B8DA80")]
		public static Id32<LocalVariables.M> KETCQRUEQOP(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F9C0", Offset = "0x2B8E5C0", VA = "0x182B8F9C0")]
		public static void TMWHGJEHLXU(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DCB0", Offset = "0x2B8C8B0", VA = "0x182B8DCB0")]
		public static Id32<LocalVariables.M> KVAOHIYTKQN(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F750", Offset = "0x2B8E350", VA = "0x182B8F750")]
		public static Id32<LocalVariables.M> SFISEJGDVZM(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B90AD0", Offset = "0x2B8F6D0", VA = "0x182B90AD0")]
		public static Id32<LocalVariables.M> YXEGEWSUIYL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DDB0", Offset = "0x2B8C9B0", VA = "0x182B8DDB0")]
		public static Id32<LocalVariables.M> KXKOULYRQNB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DB90", Offset = "0x2B8C790", VA = "0x182B8DB90")]
		public static Id32<LocalVariables.M> KUUIYQQCOGY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B90510", Offset = "0x2B8F110", VA = "0x182B90510")]
		public static Id32<LocalVariables.M> XAYPSPUNDSN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D180", Offset = "0x2B8BD80", VA = "0x182B8D180")]
		public static Id32<LocalVariables.M> HNNEJQJZFLT(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D6D0", Offset = "0x2B8C2D0", VA = "0x182B8D6D0")]
		public static Id32<LocalVariables.M> IDRZMPDSFJM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B8A0", Offset = "0x2B8A4A0", VA = "0x182B8B8A0")]
		public static Id32<LocalVariables.M> AQJERBQYICB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EEF0", Offset = "0x2B8DAF0", VA = "0x182B8EEF0")]
		public static Id32<LocalVariables.M> OKEXXCMNSQM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3D53880", Offset = "0x3D52480", VA = "0x183D53880")]
		public static void JKETOAVTQMV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CQQKHLGBDOQ> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3D555B0", Offset = "0x3D541B0", VA = "0x183D555B0")]
		public static void PVQSPGQKPVB<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<BVTCYCWYPSS> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3D54460", Offset = "0x3D53060", VA = "0x183D54460")]
		public static Id32<LocalVariables.M> NZDRZSUITEF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3D53370", Offset = "0x3D51F70", VA = "0x183D53370")]
		public static Id32<LocalVariables.M> ILZABXPGSKC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3D56330", Offset = "0x3D54F30", VA = "0x183D56330")]
		public static Id32<DataBackResults.M> UZWPBWYJTNF<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, VDFOEWNMPJQ<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3D56640", Offset = "0x3D55240", VA = "0x183D56640")]
		public static Id32<ExecForwardResults.M> WKDEKTSHIQQ<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, VDFOEWNMPJQ<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F870", Offset = "0x2B8E470", VA = "0x182B8F870")]
		public static Id32<DataBackResults.M> TEAVPQPPOXG(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DEB0", Offset = "0x2B8CAB0", VA = "0x182B8DEB0")]
		public static Id32<DataBackResults.M> LBMTJEHMOSG(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3D549E0", Offset = "0x3D535E0", VA = "0x183D549E0")]
		public static Id32<DataBackResults.M> PEJPTQOIUHL<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CQQKHLGBDOQ> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3D54770", Offset = "0x3D53370", VA = "0x183D54770")]
		private static Id32<DataBackResults.M> PEJPTQOIUHL<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CQQKHLGBDOQ> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3D54010", Offset = "0x3D52C10", VA = "0x183D54010")]
		public static Id32<LocalVariables.M> KRHAFODUWCF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3D56940", Offset = "0x3D55540", VA = "0x183D56940")]
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
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
		public LiveInterval(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> firstUse, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B3F0", Offset = "0x2B89FF0", VA = "0x182B8B3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8A970", Offset = "0x2B89570", VA = "0x182B8A970")]
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
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8B5F0", Offset = "0x2B8A1F0", VA = "0x182B8B5F0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<YUOPJWDRBXC, ArgumentInst> argumentVariables, [In] SOAId32Field<XXCGHWAUASX, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<HVSJGHAWALI, ParameterInst> parameterVariables, [In] SOAId32Field<QHJRCLYUKQY, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B400", Offset = "0x2B8A000", VA = "0x182B8B400")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class HCBGCUPBBJR
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A6B0", Offset = "0x2B892B0", VA = "0x182B8A6B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B89210", Offset = "0x2B87E10", VA = "0x182B89210")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B89100", Offset = "0x2B87D00", VA = "0x182B89100")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.UERCVPOWXRJ, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B89090", Offset = "0x2B87C90", VA = "0x182B89090")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B88E70", Offset = "0x2B87A70", VA = "0x182B88E70")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3691E70", Offset = "0x3690A70", VA = "0x183691E70")]
		public static void XTRREELNPZX<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<GNQADATMYDH> graphId) where TDeps : notnull, VDFOEWNMPJQ<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class VRTDYJNDBYY
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B93C40", Offset = "0x2B92840", VA = "0x182B93C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B90DD0", Offset = "0x2B8F9D0", VA = "0x182B90DD0", Slot = "4")]
			public void JZJIZDFYZGI(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2B90E60", Offset = "0x2B8FA60", VA = "0x182B90E60", Slot = "4")]
			public void JZJIZDFYZGI(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2B90C90", Offset = "0x2B8F890", VA = "0x182B90C90", Slot = "4")]
			public void JZJIZDFYZGI(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2B90D20", Offset = "0x2B8F920", VA = "0x182B90D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4174340", Offset = "0x4172F40", VA = "0x184174340")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8A920", Offset = "0x2B89520", VA = "0x182B8A920")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<FunctionCalls.UERCVPOWXRJ>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A870", Offset = "0x2B89470", VA = "0x182B8A870")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A830", Offset = "0x2B89430", VA = "0x182B8A830")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3BABAF0", Offset = "0x3BAA6F0", VA = "0x183BABAF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8ACE0", Offset = "0x2B898E0", VA = "0x182B8ACE0")]
		public static void XTRREELNPZX(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AAD0", Offset = "0x2B896D0", VA = "0x182B8AAD0")]
		private static void PUEFFAKTMJK([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A990", Offset = "0x2B89590", VA = "0x182B8A990")]
		private static void PUEFFAKTMJK(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B240", Offset = "0x2B89E40", VA = "0x182B8B240")]
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
		[Cpp2IlInjected.Address(RVA = "0x767C220", Offset = "0x767AE20", VA = "0x18767C220")]
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
		[Cpp2IlInjected.Address(RVA = "0x65B4640", Offset = "0x65B3240", VA = "0x1865B4640")]
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
