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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA6DC0", Offset = "0x2BA5DC0", VA = "0x182BA6DC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B34700", Offset = "0x2B33700", VA = "0x182B34700")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B9F340", Offset = "0x2B9E340", VA = "0x182B9F340", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
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
			[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
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
			[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x23A64B0", Offset = "0x23A54B0", VA = "0x1823A64B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9F650", Offset = "0x2B9E650", VA = "0x182B9F650")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<LKKKABWYIBZ, BytesImmediate> bytesImmediates, [In] IdUnsafeList<GOUCNEWEBWG, DeadEnd> deadEnds, [In] IdUnsafeList<KRRICHCQKAD, Variable> variables, [In] IdUnsafeList<NVAZKMNTIYV, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F510", Offset = "0x2B9E510", VA = "0x182B9F510")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class AFVTVMRWSSE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E3C0", Offset = "0x2B9D3C0", VA = "0x182B9E3C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
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
			[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9F770", Offset = "0x2B9E770", VA = "0x182B9F770")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<YZKALMDVUYO, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F6E0", Offset = "0x2B9E6E0", VA = "0x182B9F6E0")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class BHWODCZAHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F2E0", Offset = "0x2B9E2E0", VA = "0x182B9F2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9F850", Offset = "0x2B9E850", VA = "0x182B9F850")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F7B0", Offset = "0x2B9E7B0", VA = "0x182B9F7B0")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class HSPTFGHULBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0900", Offset = "0x2B9F900", VA = "0x182BA0900")]
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
			[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
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
			[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
			private Inst(Def def, Id32<CMCAYUZTWUP> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA0B00", Offset = "0x2B9FB00", VA = "0x182BA0B00")]
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
			[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9F770", Offset = "0x2B9E770", VA = "0x182B9F770")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2BA0950", Offset = "0x2B9F950", VA = "0x182BA0950")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9FA50", Offset = "0x2B9EA50", VA = "0x182B9FA50")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<QCMXMPNXPGS, InternalCall> internalCalls, [In] IdUnsafeList<NLFWFOKFOWQ, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<UERCVPOWXRJ> IOId)> callsWithIO, [In] IdUnsafeList<UERCVPOWXRJ, IO> io, [In] SOAField<UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> ioModifyingCallLocations, [In] SOAField<UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F8B0", Offset = "0x2B9E8B0", VA = "0x182B9F8B0")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class QLAWRIAGWYA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2BA72D0", Offset = "0x2BA62D0", VA = "0x182BA72D0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BA70C0", Offset = "0x2BA60C0", VA = "0x182BA70C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA04A0", Offset = "0x2B9F4A0", VA = "0x182BA04A0")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<HSLAWAWHJXI, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<HSLAWAWHJXI>> generatedOutputsForExpression, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FB10", Offset = "0x2B9EB10", VA = "0x182B9FB10")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA9960", Offset = "0x2BA8960", VA = "0x182BA9960")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9910", Offset = "0x2BA8910", VA = "0x182BA9910", Slot = "4")]
			public Id32<FunctionCalls.UERCVPOWXRJ> HXQZBEXBHJO(int a)
			{
				return default(Id32<FunctionCalls.UERCVPOWXRJ>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0")]
			public bool BKNIWPEUIQO(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "5")]
			private bool APZKZQMGMMQ(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9950", Offset = "0x2BA8950", VA = "0x182BA9950", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9E480", Offset = "0x2B9D480", VA = "0x182B9E480")]
			public UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> RATOPIWNAVL(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E590", Offset = "0x2B9D590", VA = "0x182B9E590")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E4F0", Offset = "0x2B9D4F0", VA = "0x182B9E4F0", Slot = "6")]
			public void SJZTTAPRIXF(Id32<FunctionCalls.UERCVPOWXRJ> a, SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E480", Offset = "0x2B9D480", VA = "0x182B9E480", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> JEJNPXKTANW(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E470", Offset = "0x2B9D470", VA = "0x182B9E470", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA9A30", Offset = "0x2BA8A30", VA = "0x182BA9A30")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2BA99E0", Offset = "0x2BA89E0", VA = "0x182BA99E0", Slot = "4")]
			public Id32<FunctionCalls.UERCVPOWXRJ> HXQZBEXBHJO(int a)
			{
				return default(Id32<FunctionCalls.UERCVPOWXRJ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0")]
			public bool BKNIWPEUIQO(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "5")]
			private bool AXGYJOHTNGZ(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9A20", Offset = "0x2BA8A20", VA = "0x182BA9A20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9E620", Offset = "0x2B9D620", VA = "0x182B9E620")]
			public UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> RATOPIWNAVL(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E730", Offset = "0x2B9D730", VA = "0x182B9E730")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<FunctionCalls.UERCVPOWXRJ> a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E690", Offset = "0x2B9D690", VA = "0x182B9E690", Slot = "6")]
			public void SJZTTAPRIXF(Id32<FunctionCalls.UERCVPOWXRJ> a, SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E620", Offset = "0x2B9D620", VA = "0x182B9E620", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>> TLGWPMKCRQN(int a, [In] SOAField<FunctionCalls.UERCVPOWXRJ, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UERCVPOWXRJ>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E610", Offset = "0x2B9D610", VA = "0x182B9E610", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA9B60", Offset = "0x2BA8B60", VA = "0x182BA9B60")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9B20", Offset = "0x2BA8B20", VA = "0x182BA9B20", Slot = "4")]
			public Id32<CCKCDLBLEMF> HXQZBEXBHJO(int a)
			{
				return default(Id32<CCKCDLBLEMF>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9AB0", Offset = "0x2BA8AB0", VA = "0x182BA9AB0")]
			public bool BKNIWPEUIQO(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9AB0", Offset = "0x2BA8AB0", VA = "0x182BA9AB0", Slot = "5")]
			private bool DPFSWVUEMXB(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9B10", Offset = "0x2BA8B10", VA = "0x182BA9B10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9E7B0", Offset = "0x2B9D7B0", VA = "0x182B9E7B0")]
			public UnsafeList<Id32<CCKCDLBLEMF>> RATOPIWNAVL(int a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(UnsafeList<Id32<CCKCDLBLEMF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E930", Offset = "0x2B9D930", VA = "0x182B9E930")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(Id32<CCKCDLBLEMF> a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E820", Offset = "0x2B9D820", VA = "0x182B9E820", Slot = "6")]
			public void SJZTTAPRIXF(Id32<CCKCDLBLEMF> a, SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E7B0", Offset = "0x2B9D7B0", VA = "0x182B9E7B0", Slot = "4")]
			private UnsafeList<Id32<CCKCDLBLEMF>> JUOZFCBUBXF(int a, [In] SOAField<CCKCDLBLEMF, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>?> values)
			{
				return default(UnsafeList<Id32<CCKCDLBLEMF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E920", Offset = "0x2B9D920", VA = "0x182B9E920", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA9D60", Offset = "0x2BA8D60", VA = "0x182BA9D60")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD6F990", Offset = "0xD6E990", VA = "0x180D6F990", Slot = "4")]
			public int HXQZBEXBHJO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0")]
			public bool BKNIWPEUIQO(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "5")]
			private bool SVZFHFBSXVU(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9D50", Offset = "0x2BA8D50", VA = "0x182BA9D50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9EE10", Offset = "0x2B9DE10", VA = "0x182B9EE10")]
			public UnsafeList<int> RATOPIWNAVL(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B9EF80", Offset = "0x2B9DF80", VA = "0x182B9EF80")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B9EE80", Offset = "0x2B9DE80", VA = "0x182B9EE80", Slot = "6")]
			public void SJZTTAPRIXF(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B9EE10", Offset = "0x2B9DE10", VA = "0x182B9EE10", Slot = "4")]
			private UnsafeList<int> XJQRPADZNII(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<KGMTAGLYNTP<UTDLMYHANGH<RRRVXHRUCXR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B9EE00", Offset = "0x2B9DE00", VA = "0x182B9EE00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA9CC0", Offset = "0x2BA8CC0", VA = "0x182BA9CC0")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD6F990", Offset = "0xD6E990", VA = "0x180D6F990", Slot = "4")]
			public int HXQZBEXBHJO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0")]
			public bool BKNIWPEUIQO(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "5")]
			private bool UPXQSNYZYIJ(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9CB0", Offset = "0x2BA8CB0", VA = "0x182BA9CB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9EC00", Offset = "0x2B9DC00", VA = "0x182B9EC00")]
			public UnsafeList<int> RATOPIWNAVL(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B9ED70", Offset = "0x2B9DD70", VA = "0x182B9ED70")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B9EC70", Offset = "0x2B9DC70", VA = "0x182B9EC70", Slot = "6")]
			public void SJZTTAPRIXF(int a, UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B9EC00", Offset = "0x2B9DC00", VA = "0x182B9EC00", Slot = "4")]
			private UnsafeList<int> YUGGXXHTFCT(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B9EBF0", Offset = "0x2B9DBF0", VA = "0x182B9EBF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA9C20", Offset = "0x2BA8C20", VA = "0x182BA9C20")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD6F990", Offset = "0xD6E990", VA = "0x180D6F990", Slot = "4")]
			public int HXQZBEXBHJO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0")]
			public bool BKNIWPEUIQO(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "5")]
			private bool UPXQSNYZYIJ(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9C10", Offset = "0x2BA8C10", VA = "0x182BA9C10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9E9F0", Offset = "0x2B9D9F0", VA = "0x182B9E9F0")]
			public UnsafeList<int> RATOPIWNAVL(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B9EB60", Offset = "0x2B9DB60", VA = "0x182B9EB60")]
			public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> WVCQKCRTMEH(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B9EA60", Offset = "0x2B9DA60", VA = "0x182B9EA60", Slot = "6")]
			public void SJZTTAPRIXF(int a, UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E9F0", Offset = "0x2B9D9F0", VA = "0x182B9E9F0", Slot = "4")]
			private UnsafeList<int> YUGGXXHTFCT(int a, [In] UnsafeList<(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> Target, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E9E0", Offset = "0x2B9D9E0", VA = "0x182B9E9E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1CDE040", Offset = "0x1CDD040", VA = "0x181CDE040")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA0840", Offset = "0x2B9F840", VA = "0x182BA0840")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA0820", Offset = "0x2B9F820", VA = "0x182BA0820")]
			public GenerateDataBackFromInputIndexResult(Id32<CCKCDLBLEMF> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA0810", Offset = "0x2B9F810", VA = "0x182BA0810")]
			public void BXVWZDHELXS([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA07F0", Offset = "0x2B9F7F0", VA = "0x182BA07F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
			public GenerateDataBackFromInputIndicesResult(Id32<CCKCDLBLEMF> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BA0830", Offset = "0x2B9F830", VA = "0x182BA0830")]
			public void BXVWZDHELXS([Out] Id32<DataBackResults.M> a, [Out] Id32<CCKCDLBLEMF> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BA77A0", Offset = "0x2BA67A0", VA = "0x182BA77A0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9210", Offset = "0x2BA8210", VA = "0x182BA9210")]
		public static void UALYGHJPRNX(this FunctionCompileState a, Id32<HSLAWAWHJXI> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8410", Offset = "0x2BA7410", VA = "0x182BA8410")]
		public static void MLBZXEZMYRN(this FunctionCompileState a, Id32<HSLAWAWHJXI> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7580", Offset = "0x2BA6580", VA = "0x182BA7580")]
		public static Id32<DataBackResults.M>? DKKDCOTILRS([In] this FunctionCompileState self, Id32<HSLAWAWHJXI> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9340", Offset = "0x2BA8340", VA = "0x182BA9340")]
		public static Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> VKFVMIAYRUU([In] this FunctionCompileState self)
		{
			return default(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9620", Offset = "0x2BA8620", VA = "0x182BA9620")]
		private static void ZJAPXVLTYDV(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA84E0", Offset = "0x2BA74E0", VA = "0x182BA84E0")]
		private static Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>? MVJBQPTTOOE([In] this FunctionCompileState self, Id32<CCKCDLBLEMF> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA94B0", Offset = "0x2BA84B0", VA = "0x182BA94B0")]
		public static void VRUWSEJMTME(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA89E0", Offset = "0x2BA79E0", VA = "0x182BA89E0")]
		public static DataBackResults.Def PCVTFLIIRXU([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8750", Offset = "0x2BA7750", VA = "0x182BA8750")]
		public static ReadOnlyArray<byte> OTOJAIOYJKS([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8D60", Offset = "0x2BA7D60", VA = "0x182BA8D60")]
		public static Id32<LocalVariables.M> RYFNRSEUAUG([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7320", Offset = "0x2BA6320", VA = "0x182BA7320")]
		public static Union32 BVHGWLEWHAU([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E4E840", Offset = "0x3E4D840", VA = "0x183E4E840")]
		private static Id32<DataBackResults.M> JDZDFYOFRGJ<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.CMCAYUZTWUP
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7BA0", Offset = "0x2BA6BA0", VA = "0x182BA7BA0")]
		public static Id32<DataBackResults.M> HCNBHTONLCN(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7C80", Offset = "0x2BA6C80", VA = "0x182BA7C80")]
		public static Id32<DataBackResults.M> IGIUGDDJBRS(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8CE0", Offset = "0x2BA7CE0", VA = "0x182BA8CE0")]
		public static Id32<DataBackResults.M> RTTXXXREAHR(this FunctionCompileState a, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7FE0", Offset = "0x2BA6FE0", VA = "0x182BA7FE0")]
		public static Id32<DataBackResults.M> KQRKXAWGMLN(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BA86D0", Offset = "0x2BA76D0", VA = "0x182BA86D0")]
		public static Id32<DataBackResults.M> OLPIBJVIGQQ(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E4E7A0", Offset = "0x3E4D7A0", VA = "0x183E4E7A0")]
		private static Id32<ExecForwardResults.M> EAVICPICWOW<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.CMCAYUZTWUP
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BA97C0", Offset = "0x2BA87C0", VA = "0x182BA97C0")]
		public static Id32<ExecForwardResults.M> ZPPYLSZIPZE(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2BA92F0", Offset = "0x2BA82F0", VA = "0x182BA92F0")]
		public static Id32<ExecForwardResults.M> VCXHJBACSBF(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7500", Offset = "0x2BA6500", VA = "0x182BA7500")]
		public static Id32<ExecForwardResults.M> DEYXFKRSIKD(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8680", Offset = "0x2BA7680", VA = "0x182BA8680")]
		public static Id32<ExecForwardResults.M> OCIZHVTSISM(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA92A0", Offset = "0x2BA82A0", VA = "0x182BA92A0")]
		public static Id32<ExecForwardResults.M> UKETTYMWENY(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8310", Offset = "0x2BA7310", VA = "0x182BA8310")]
		public static FunctionCalls.Def MBFZVXKUKTN([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7B60", Offset = "0x2BA6B60", VA = "0x182BA7B60")]
		public static CopyEnumerable<Id32<FunctionCalls.UERCVPOWXRJ>, Id32Enumerator<FunctionCalls.UERCVPOWXRJ>> GZIAIGWIQKG([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.UERCVPOWXRJ>, Id32Enumerator<FunctionCalls.UERCVPOWXRJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8060", Offset = "0x2BA7060", VA = "0x182BA8060")]
		public static Id32<FunctionCalls.UERCVPOWXRJ> LIWGGIQZFHL([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.UERCVPOWXRJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA91A0", Offset = "0x2BA81A0", VA = "0x182BA91A0")]
		public static FunctionCalls.IO SLNXQINMRVK([In] this FunctionCompileState self, Id32<FunctionCalls.UERCVPOWXRJ> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7DB0", Offset = "0x2BA6DB0", VA = "0x182BA7DB0")]
		public static FunctionCalls.IO JZPZDVZLJMS(this FunctionCompileState a, Id32<FunctionCalls.UERCVPOWXRJ> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E4E9E0", Offset = "0x3E4D9E0", VA = "0x183E4E9E0")]
		private static Id32<FunctionCalls.M> NZFUESDUUJL<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.CMCAYUZTWUP
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8E40", Offset = "0x2BA7E40", VA = "0x182BA8E40")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) SBUDEBOHXRK(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8FF0", Offset = "0x2BA7FF0", VA = "0x182BA8FF0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) SFPAVCIXPIS(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2BA74B0", Offset = "0x2BA64B0", VA = "0x182BA74B0")]
		public static Id32<FunctionCalls.M> CQYSUTMSUWX(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7A70", Offset = "0x2BA6A70", VA = "0x182BA7A70")]
		public static void FUMZKLOQXAG(this FunctionCompileState a, Id32<FunctionCalls.UERCVPOWXRJ> b, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> c, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E4EA70", Offset = "0x3E4DA70", VA = "0x183E4EA70")]
		public static GenerateDataBackResult OJURPXKKLLW<d, e>(this FunctionCompileState a, d b, e c, Id32<GNQADATMYDH> d, Id32<CCKCDLBLEMF> e) where d : VDFOEWNMPJQ<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3E50690", Offset = "0x3E4F690", VA = "0x183E50690")]
		public static GenerateDataBackFromInputIndexResult SLVPXLTXDPG<f, g>(this FunctionCompileState a, f b, g c, Id32<GNQADATMYDH> d, Id32<NYBQVHGBIMX> e, int f) where f : VDFOEWNMPJQ<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3E50AE0", Offset = "0x3E4FAE0", VA = "0x183E50AE0")]
		public static Id32<DataBackResults.M>? VFQOBLULJFD<h, i>(this FunctionCompileState a, h b, i c, Id32<GNQADATMYDH> d, Id32<NYBQVHGBIMX> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : VDFOEWNMPJQ<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FE70", Offset = "0x3E4EE70", VA = "0x183E4FE70")]
		public static Id32<ExecForwardResults.M> SJEEVRSLYHB<j, k>(this FunctionCompileState a, j b, k c, Id32<GNQADATMYDH> d, Id32<HSLAWAWHJXI> e) where j : VDFOEWNMPJQ<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7E20", Offset = "0x2BA6E20", VA = "0x182BA7E20")]
		public static LocalVariables.ArgumentInst KJUCGBEEVLV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8BD0", Offset = "0x2BA7BD0", VA = "0x182BA8BD0")]
		public static LocalVariables.CalleeReturnValueInst RQJYVPBIJNH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9800", Offset = "0x2BA8800", VA = "0x182BA9800")]
		public static LocalVariables.CallerReturnValueInst ZYHOGTIBCAC([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8830", Offset = "0x2BA7830", VA = "0x182BA8830")]
		public static Id32<LocalVariables.M> OUIPRHHGOXQ(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7690", Offset = "0x2BA6690", VA = "0x182BA7690")]
		public static LocalVariables.ParameterInst DOOMZDADMQH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7D10", Offset = "0x2BA6D10", VA = "0x182BA7D10")]
		public static LocalVariables.Def IICMZVGUBAH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7D60", Offset = "0x2BA6D60", VA = "0x182BA7D60")]
		public static int? JIMSELOCTCN([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3E4E8E0", Offset = "0x3E4D8E0", VA = "0x183E4E8E0")]
		private static Id32<LocalVariables.M> NMDCJYOPUHT<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.CMCAYUZTWUP
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7F30", Offset = "0x2BA6F30", VA = "0x182BA7F30")]
		public static Id32<LocalVariables.M> KKONINLXVOF(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7B00", Offset = "0x2BA6B00", VA = "0x182BA7B00")]
		public static Id32<LocalVariables.M> GFRFCZWNLJQ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8A50", Offset = "0x2BA7A50", VA = "0x182BA8A50")]
		public static Id32<LocalVariables.M> QSSAJOPXESG(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8380", Offset = "0x2BA7380", VA = "0x182BA8380")]
		public static Id32<LocalVariables.M> MDAGLKTCVJK(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7C20", Offset = "0x2BA6C20", VA = "0x182BA7C20")]
		public static Id32<LocalVariables.M> ICCFCLXEBTS(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8560", Offset = "0x2BA7560", VA = "0x182BA8560")]
		public static void NCJVQGONQAJ(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2BA93A0", Offset = "0x2BA83A0", VA = "0x182BA93A0")]
		public static void VKTRWIVMBHF(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7400", Offset = "0x2BA6400", VA = "0x182BA7400")]
		public static void CDLJESBLWZF(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7600", Offset = "0x2BA6600", VA = "0x182BA7600")]
		public static void DNDFUWPVAVG(this FunctionCompileState a, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> b, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8230", Offset = "0x2BA7230", VA = "0x182BA8230")]
		public static void LTUOEQUTBUI(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<KGMTAGLYNTP<BEQDFDHTNDH>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3E4E6C0", Offset = "0x3E4D6C0", VA = "0x183E4E6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D6AFE0", Offset = "0x3D69FE0", VA = "0x183D6AFE0")]
		public static Id32<LocalVariables.M?> QQXPWZLPOSS<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D68230", Offset = "0x3D67230", VA = "0x183D68230")]
		public static Id32<LocalVariables.M?> EGEQYCCPAZF<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A570", Offset = "0x3D69570", VA = "0x183D6A570")]
		public static Id32<LocalVariables.M?> PJEWQERJKTM<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3110", Offset = "0x2BA2110", VA = "0x182BA3110")]
		public static Id32<LocalVariables.M> FYJVPGJCRRM(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5EE0", Offset = "0x2BA4EE0", VA = "0x182BA5EE0")]
		public static Id32<LocalVariables.M> TZKFCVZXCQV(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4390", Offset = "0x2BA3390", VA = "0x182BA4390")]
		public static Id32<LocalVariables.M> LUEKJFGJNAM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6980", Offset = "0x2BA5980", VA = "0x182BA6980")]
		public static Id32<LocalVariables.M> YDXWQRQBSOM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA48B0", Offset = "0x2BA38B0", VA = "0x182BA48B0")]
		public static Id32<LocalVariables.M> MVGXPRZNONF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4BF0", Offset = "0x2BA3BF0", VA = "0x182BA4BF0")]
		public static Id32<LocalVariables.M> NKYRLCPAPRE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5DE0", Offset = "0x2BA4DE0", VA = "0x182BA5DE0")]
		public static Id32<LocalVariables.M> TZDQRRTTAUG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1B70", Offset = "0x2BA0B70", VA = "0x182BA1B70")]
		public static Id32<LocalVariables.M> ASNPNQPQTLX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2E30", Offset = "0x2BA1E30", VA = "0x182BA2E30")]
		public static Id32<LocalVariables.M> FBPZZSRREGU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6230", Offset = "0x2BA5230", VA = "0x182BA6230")]
		public static Id32<LocalVariables.M> VJJNHDEIGVL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2D10", Offset = "0x2BA1D10", VA = "0x182BA2D10")]
		public static Id32<LocalVariables.M> EXACKMWKZBM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3740", Offset = "0x2BA2740", VA = "0x182BA3740")]
		public static Id32<LocalVariables.M> HREIOIUMEMP(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1950", Offset = "0x2BA0950", VA = "0x182BA1950")]
		public static Id32<LocalVariables.M> AEPGCVKICGE(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4D30", Offset = "0x2BA3D30", VA = "0x182BA4D30")]
		public static Id32<LocalVariables.M> NMVZUURZKPB(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA45F0", Offset = "0x2BA35F0", VA = "0x182BA45F0")]
		public static Id32<LocalVariables.M> MMHQLQDJXFU(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6880", Offset = "0x2BA5880", VA = "0x182BA6880")]
		public static Id32<LocalVariables.M> XPTSSTMQIOK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5880", Offset = "0x2BA4880", VA = "0x182BA5880")]
		public static Id32<LocalVariables.M> ROXJYNBIYSN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2BA53C0", Offset = "0x2BA43C0", VA = "0x182BA53C0")]
		public static Id32<LocalVariables.M> PQFYDWQVLHO(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3090", Offset = "0x2BA2090", VA = "0x182BA3090")]
		public static Id32<LocalVariables.M> FRYIJCBIATJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5D60", Offset = "0x2BA4D60", VA = "0x182BA5D60")]
		public static Id32<LocalVariables.M> TXPUMITBSEA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3BB0", Offset = "0x2BA2BB0", VA = "0x182BA3BB0")]
		public static Id32<LocalVariables.M> JZULWUHZRMN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4EE0", Offset = "0x2BA3EE0", VA = "0x182BA4EE0")]
		public static Id32<LocalVariables.M> OFHCJBOAQKL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4730", Offset = "0x2BA3730", VA = "0x182BA4730")]
		public static Id32<LocalVariables.M> MPUDEVTLZOI(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5780", Offset = "0x2BA4780", VA = "0x182BA5780")]
		public static Id32<LocalVariables.M> PSMZTOWXTLH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5800", Offset = "0x2BA4800", VA = "0x182BA5800")]
		public static Id32<LocalVariables.M> QUDNUTTPJZA(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4E60", Offset = "0x2BA3E60", VA = "0x182BA4E60")]
		public static Id32<LocalVariables.M> NQHSCUJNNMN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2250", Offset = "0x2BA1250", VA = "0x182BA2250")]
		public static Id32<LocalVariables.M> BGFLNLHVLJK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6A80", Offset = "0x2BA5A80", VA = "0x182BA6A80")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> YWJBJFSSUKY(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6800", Offset = "0x2BA5800", VA = "0x182BA6800")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> XFQZVRCSXRO(this FunctionCompileState a, int b)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3210", Offset = "0x2BA2210", VA = "0x182BA3210")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> GJZJVBPMXVR(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5440", Offset = "0x2BA4440", VA = "0x182BA5440")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> PRFBJBVUFDX(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA32B0", Offset = "0x2BA22B0", VA = "0x182BA32B0")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> HBRZXQVCIJL(this FunctionCompileState a, int b)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6520", Offset = "0x2BA5520", VA = "0x182BA6520")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> WLLHMLDBSAO(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1C90", Offset = "0x2BA0C90", VA = "0x182BA1C90")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) ATLPWQJFITF(this FunctionCompileState a, Id32<CQQKHLGBDOQ> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2770", Offset = "0x2BA1770", VA = "0x182BA2770")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>) EGBIAIZLVEB(this FunctionCompileState a, Id32<BVTCYCWYPSS> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UERCVPOWXRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D6B310", Offset = "0x3D6A310", VA = "0x183D6B310")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<FKAHYQVBHTH>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<TMarker>>, Id32<FunctionCalls.M>) UNYMIPPOVTU<TMarker>(this FunctionCompileState a, Id32<FKAHYQVBHTH> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<FKAHYQVBHTH>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5B80", Offset = "0x2BA4B80", VA = "0x182BA5B80")]
		public static Id32<LocalVariables.M> TPPIXYLUFJS(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6330", Offset = "0x2BA5330", VA = "0x182BA6330")]
		public static Id32<LocalVariables.M> WCXKFWJBDBR(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3980", Offset = "0x2BA2980", VA = "0x182BA3980")]
		public static Id32<LocalVariables.M> IEYHOKHGELG(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5C40", Offset = "0x2BA4C40", VA = "0x182BA5C40")]
		public static Id32<LocalVariables.M> TRIMDBDSSNN(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2C10", Offset = "0x2BA1C10", VA = "0x182BA2C10")]
		public static Id32<LocalVariables.M> ENVOXYFKKUQ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4AD0", Offset = "0x2BA3AD0", VA = "0x182BA4AD0")]
		public static Id32<LocalVariables.M> NJCAGUMIKJN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA23D0", Offset = "0x2BA13D0", VA = "0x182BA23D0")]
		public static Id32<LocalVariables.M> CSKGYBVUMUO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6000", Offset = "0x2BA5000", VA = "0x182BA6000")]
		public static Id32<LocalVariables.M> UHNMIYPTOHA(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2510", Offset = "0x2BA1510", VA = "0x182BA2510")]
		public static Id32<LocalVariables.M> DXXYHEMWUIB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3A70", Offset = "0x2BA2A70", VA = "0x182BA3A70")]
		public static Id32<LocalVariables.M> IHAITGOXFCY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA18D0", Offset = "0x2BA08D0", VA = "0x182BA18D0")]
		public static Id32<LocalVariables.M> AEGETHUQNUT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6900", Offset = "0x2BA5900", VA = "0x182BA6900")]
		public static Id32<LocalVariables.M> XQYDLJXJQCU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5340", Offset = "0x2BA4340", VA = "0x182BA5340")]
		public static Id32<LocalVariables.M> PKZCTRFWENH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BA65C0", Offset = "0x2BA55C0", VA = "0x182BA65C0")]
		public static Id32<LocalVariables.M> WOQAUPJEZET(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6100", Offset = "0x2BA5100", VA = "0x182BA6100")]
		public static Id32<LocalVariables.M> UZDBQJOQIIQ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5640", Offset = "0x2BA4640", VA = "0x182BA5640")]
		public static Id32<LocalVariables.M> PRHZXGVJCFH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6420", Offset = "0x2BA5420", VA = "0x182BA6420")]
		public static Id32<LocalVariables.M> WKEBRYGQLTU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA44D0", Offset = "0x2BA34D0", VA = "0x182BA44D0")]
		public static Id32<LocalVariables.M> MASKQPIPAUZ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BA51E0", Offset = "0x2BA41E0", VA = "0x182BA51E0")]
		public static Id32<LocalVariables.M> OMPSACJGJGQ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5320", Offset = "0x2BA4320", VA = "0x182BA5320")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>> OPCTOHDOGOM(this FunctionCompileState a)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA22D0", Offset = "0x2BA12D0", VA = "0x182BA22D0")]
		public static Id32<LocalVariables.M> CSIEZMWFUOV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2F70", Offset = "0x2BA1F70", VA = "0x182BA2F70")]
		public static Id32<LocalVariables.M> FGXPYGRZSUG(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4F60", Offset = "0x2BA3F60", VA = "0x182BA4F60")]
		public static Id32<LocalVariables.M> OIESXIUKQSD(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BA49D0", Offset = "0x2BA39D0", VA = "0x182BA49D0")]
		public static Id32<LocalVariables.M> MYRPAKONBHF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2130", Offset = "0x2BA1130", VA = "0x182BA2130")]
		public static Id32<LocalVariables.M> BEJBDRGGSRW(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2630", Offset = "0x2BA1630", VA = "0x182BA2630")]
		public static Id32<LocalVariables.M> DYKEOTJQTSR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA47B0", Offset = "0x2BA37B0", VA = "0x182BA47B0")]
		public static Id32<LocalVariables.M> MUZYBTAJBEI(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3C30", Offset = "0x2BA2C30", VA = "0x182BA3C30")]
		public static Id32<LocalVariables.M> KETCQRUEQOP(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5B70", Offset = "0x2BA4B70", VA = "0x182BA5B70")]
		public static void TMWHGJEHLXU(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3E60", Offset = "0x2BA2E60", VA = "0x182BA3E60")]
		public static Id32<LocalVariables.M> KVAOHIYTKQN(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5900", Offset = "0x2BA4900", VA = "0x182BA5900")]
		public static Id32<LocalVariables.M> SFISEJGDVZM(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6C80", Offset = "0x2BA5C80", VA = "0x182BA6C80")]
		public static Id32<LocalVariables.M> YXEGEWSUIYL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3F60", Offset = "0x2BA2F60", VA = "0x182BA3F60")]
		public static Id32<LocalVariables.M> KXKOULYRQNB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3D40", Offset = "0x2BA2D40", VA = "0x182BA3D40")]
		public static Id32<LocalVariables.M> KUUIYQQCOGY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA66C0", Offset = "0x2BA56C0", VA = "0x182BA66C0")]
		public static Id32<LocalVariables.M> XAYPSPUNDSN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3330", Offset = "0x2BA2330", VA = "0x182BA3330")]
		public static Id32<LocalVariables.M> HNNEJQJZFLT(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3880", Offset = "0x2BA2880", VA = "0x182BA3880")]
		public static Id32<LocalVariables.M> IDRZMPDSFJM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1A50", Offset = "0x2BA0A50", VA = "0x182BA1A50")]
		public static Id32<LocalVariables.M> AQJERBQYICB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BA50A0", Offset = "0x2BA40A0", VA = "0x182BA50A0")]
		public static Id32<LocalVariables.M> OKEXXCMNSQM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3D68970", Offset = "0x3D67970", VA = "0x183D68970")]
		public static void JKETOAVTQMV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CQQKHLGBDOQ> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A6A0", Offset = "0x3D696A0", VA = "0x183D6A6A0")]
		public static void PVQSPGQKPVB<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<BVTCYCWYPSS> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3D69550", Offset = "0x3D68550", VA = "0x183D69550")]
		public static Id32<LocalVariables.M> NZDRZSUITEF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3D68460", Offset = "0x3D67460", VA = "0x183D68460")]
		public static Id32<LocalVariables.M> ILZABXPGSKC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3D6B420", Offset = "0x3D6A420", VA = "0x183D6B420")]
		public static Id32<DataBackResults.M> UZWPBWYJTNF<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, VDFOEWNMPJQ<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3D6B730", Offset = "0x3D6A730", VA = "0x183D6B730")]
		public static Id32<ExecForwardResults.M> WKDEKTSHIQQ<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, VDFOEWNMPJQ<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5A20", Offset = "0x2BA4A20", VA = "0x182BA5A20")]
		public static Id32<DataBackResults.M> TEAVPQPPOXG(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4060", Offset = "0x2BA3060", VA = "0x182BA4060")]
		public static Id32<DataBackResults.M> LBMTJEHMOSG(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3D69AD0", Offset = "0x3D68AD0", VA = "0x183D69AD0")]
		public static Id32<DataBackResults.M> PEJPTQOIUHL<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CQQKHLGBDOQ> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3D69860", Offset = "0x3D68860", VA = "0x183D69860")]
		private static Id32<DataBackResults.M> PEJPTQOIUHL<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CQQKHLGBDOQ> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3D69100", Offset = "0x3D68100", VA = "0x183D69100")]
		public static Id32<LocalVariables.M> KRHAFODUWCF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, VDFOEWNMPJQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3D6BA30", Offset = "0x3D6AA30", VA = "0x183D6BA30")]
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
		[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
		public LiveInterval(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> firstUse, Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA15A0", Offset = "0x2BA05A0", VA = "0x182BA15A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
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
			[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA0B10", Offset = "0x2B9FB10", VA = "0x182BA0B10")]
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
			[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA17A0", Offset = "0x2BA07A0", VA = "0x182BA17A0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<YUOPJWDRBXC, ArgumentInst> argumentVariables, [In] SOAId32Field<XXCGHWAUASX, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<HVSJGHAWALI, ParameterInst> parameterVariables, [In] SOAId32Field<QHJRCLYUKQY, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BA15B0", Offset = "0x2BA05B0", VA = "0x182BA15B0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class HCBGCUPBBJR
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0850", Offset = "0x2B9F850", VA = "0x182BA0850")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9F3B0", Offset = "0x2B9E3B0", VA = "0x182B9F3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9F2A0", Offset = "0x2B9E2A0", VA = "0x182B9F2A0")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.UERCVPOWXRJ, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F230", Offset = "0x2B9E230", VA = "0x182B9F230")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F010", Offset = "0x2B9E010", VA = "0x182B9F010")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x36AC980", Offset = "0x36AB980", VA = "0x1836AC980")]
		public static void XTRREELNPZX<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<GNQADATMYDH> graphId) where TDeps : notnull, VDFOEWNMPJQ<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class VRTDYJNDBYY
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9DF0", Offset = "0x2BA8DF0", VA = "0x182BA9DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA6F80", Offset = "0x2BA5F80", VA = "0x182BA6F80", Slot = "4")]
			public void JZJIZDFYZGI(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7010", Offset = "0x2BA6010", VA = "0x182BA7010", Slot = "4")]
			public void JZJIZDFYZGI(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2BA6E40", Offset = "0x2BA5E40", VA = "0x182BA6E40", Slot = "4")]
			public void JZJIZDFYZGI(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : EVLFCSMGXXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2BA6ED0", Offset = "0x2BA5ED0", VA = "0x182BA6ED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x418F510", Offset = "0x418E510", VA = "0x18418F510")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA0AC0", Offset = "0x2B9FAC0", VA = "0x182BA0AC0")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<FunctionCalls.UERCVPOWXRJ>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0A10", Offset = "0x2B9FA10", VA = "0x182BA0A10")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2BA09D0", Offset = "0x2B9F9D0", VA = "0x182BA09D0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3BC31A0", Offset = "0x3BC21A0", VA = "0x183BC31A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA0E90", Offset = "0x2B9FE90", VA = "0x182BA0E90")]
		public static void XTRREELNPZX(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0C70", Offset = "0x2B9FC70", VA = "0x182BA0C70")]
		private static void PUEFFAKTMJK([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0B30", Offset = "0x2B9FB30", VA = "0x182BA0B30")]
		private static void PUEFFAKTMJK(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA13F0", Offset = "0x2BA03F0", VA = "0x182BA13F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x77C17D0", Offset = "0x77C07D0", VA = "0x1877C17D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x668B970", Offset = "0x668A970", VA = "0x18668B970")]
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
