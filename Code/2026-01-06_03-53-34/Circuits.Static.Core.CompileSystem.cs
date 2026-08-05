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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D9000", Offset = "0x28D7A00", VA = "0x1828D9000")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
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
		public readonly Id32<DNQUXCYLSXY<WBZFYOYOFGY>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		public ByteCodeAdjustment(Id32<DNQUXCYLSXY<WBZFYOYOFGY>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class RFRDFDYGPGO : WSHRTVYEHEC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x287BE20", Offset = "0x287A820", VA = "0x18287BE20")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x28D7280", Offset = "0x28D5C80", VA = "0x1828D7280", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class OKUIQHCYXWN : WSHRTVYEHEC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<DNQUXCYLSXY<HNSTYFIETBH>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
			public DeadEnd(Id32<DNQUXCYLSXY<HNSTYFIETBH>> nextByteCodePtr)
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
		public abstract class WSHRTVYEHEC
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
			public readonly Id32<WSHRTVYEHEC> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
			public Inst(Def def, Id32<WSHRTVYEHEC> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class AEAIQBZILQC : WSHRTVYEHEC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class JMBYCNVUUDC : WSHRTVYEHEC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2097650", Offset = "0x2096050", VA = "0x182097650", Slot = "3")]
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
		internal IdUnsafeList<RFRDFDYGPGO, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<OKUIQHCYXWN, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<AEAIQBZILQC, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<JMBYCNVUUDC, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28D7430", Offset = "0x28D5E30", VA = "0x1828D7430")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<RFRDFDYGPGO, BytesImmediate> bytesImmediates, [In] IdUnsafeList<OKUIQHCYXWN, DeadEnd> deadEnds, [In] IdUnsafeList<AEAIQBZILQC, Variable> variables, [In] IdUnsafeList<JMBYCNVUUDC, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28D72F0", Offset = "0x28D5CF0", VA = "0x1828D72F0")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class NQFFNGTTMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28D8CF0", Offset = "0x28D76F0", VA = "0x1828D8CF0")]
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
		public sealed class KNFAPOOAOJD : WSHRTVYEHEC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
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
		public abstract class WSHRTVYEHEC
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
			public readonly Id32<WSHRTVYEHEC> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
			public Inst(Def def, Id32<WSHRTVYEHEC> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<KNFAPOOAOJD, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28D7550", Offset = "0x28D5F50", VA = "0x1828D7550")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<KNFAPOOAOJD, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28D74C0", Offset = "0x28D5EC0", VA = "0x1828D74C0")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class OSAGUQCBACS
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28D9080", Offset = "0x28D7A80", VA = "0x1828D9080")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D7630", Offset = "0x28D6030", VA = "0x1828D7630")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28D7590", Offset = "0x28D5F90", VA = "0x1828D7590")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class MMQDOYKJGOZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28D8B40", Offset = "0x28D7540", VA = "0x1828D8B40")]
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
		public sealed class QTFDNCIWSUV : WSHRTVYEHEC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<TPAVREQRGIC> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
			public ExternalCall(Id32<TPAVREQRGIC> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class WSHRTVYEHEC
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
			public readonly Id32<WSHRTVYEHEC> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
			private Inst(Def def, Id32<WSHRTVYEHEC> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28D87E0", Offset = "0x28D71E0", VA = "0x1828D87E0")]
			public static Inst New(Def def, Id32<WSHRTVYEHEC> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class PTAFTIUEVFB : WSHRTVYEHEC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<TPAVREQRGIC> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
			public InternalCall(Id32<TPAVREQRGIC> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class TPAVREQRGIC
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
			[Cpp2IlInjected.Address(RVA = "0x28D7550", Offset = "0x28D5F50", VA = "0x1828D7550")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x28D8630", Offset = "0x28D7030", VA = "0x1828D8630")]
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
		internal IdUnsafeList<PTAFTIUEVFB, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<QTFDNCIWSUV, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<TPAVREQRGIC> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<TPAVREQRGIC, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28D7830", Offset = "0x28D6230", VA = "0x1828D7830")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<PTAFTIUEVFB, InternalCall> internalCalls, [In] IdUnsafeList<QTFDNCIWSUV, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<TPAVREQRGIC> IOId)> callsWithIO, [In] IdUnsafeList<TPAVREQRGIC, IO> io, [In] SOAField<TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> ioModifyingCallLocations, [In] SOAField<TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28D7690", Offset = "0x28D6090", VA = "0x1828D7690")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class NVISGEFGYAT
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28D8DA0", Offset = "0x28D77A0", VA = "0x1828D8DA0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28D8DF0", Offset = "0x28D77F0", VA = "0x1828D8DF0")]
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
		internal SOAField<XDQQSNHTXDZ, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<XDQQSNHTXDZ>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28D8280", Offset = "0x28D6C80", VA = "0x1828D8280")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<XDQQSNHTXDZ, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<XDQQSNHTXDZ>> generatedOutputsForExpression, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28D78F0", Offset = "0x28D62F0", VA = "0x1828D78F0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class QWEWJGXJJHC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : AITLLCNALRJ<Id32<FunctionCalls.TPAVREQRGIC>, SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x28DC630", Offset = "0x28DB030", VA = "0x1828DC630")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x28DC6C0", Offset = "0x28DB0C0", VA = "0x1828DC6C0", Slot = "4")]
			public Id32<FunctionCalls.TPAVREQRGIC> OTOCJEAJTDZ(int a)
			{
				return default(Id32<FunctionCalls.TPAVREQRGIC>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0")]
			public bool HSIJXKHTHCB(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "5")]
			private bool ITSGMIWVRRD(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x28DC6B0", Offset = "0x28DB0B0", VA = "0x1828DC6B0", Slot = "6")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> NOZTESTPKDC(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : GVDCTIQWGWC<Id32<FunctionCalls.TPAVREQRGIC>, SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28D6410", Offset = "0x28D4E10", VA = "0x1828D6410")]
			public UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>> GONWJGEXRMA(int a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x28D6480", Offset = "0x28D4E80", VA = "0x1828D6480")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x28D6510", Offset = "0x28D4F10", VA = "0x1828D6510", Slot = "6")]
			public void PYIZWCDUNBO(Id32<FunctionCalls.TPAVREQRGIC> a, SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> b, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x28D6410", Offset = "0x28D4E10", VA = "0x1828D6410", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>> IQKRHDVHETR(int a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x28D6500", Offset = "0x28D4F00", VA = "0x1828D6500", Slot = "5")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> NUXVAXIYFKB(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : AITLLCNALRJ<Id32<FunctionCalls.TPAVREQRGIC>, SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x28DC710", Offset = "0x28DB110", VA = "0x1828DC710")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x28DC790", Offset = "0x28DB190", VA = "0x1828DC790", Slot = "4")]
			public Id32<FunctionCalls.TPAVREQRGIC> OTOCJEAJTDZ(int a)
			{
				return default(Id32<FunctionCalls.TPAVREQRGIC>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0")]
			public bool HSIJXKHTHCB(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "5")]
			private bool WJNCXXDANWO(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x28DC700", Offset = "0x28DB100", VA = "0x1828DC700", Slot = "6")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> IVUVOGOTEIP(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : GVDCTIQWGWC<Id32<FunctionCalls.TPAVREQRGIC>, SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x28D65B0", Offset = "0x28D4FB0", VA = "0x1828D65B0")]
			public UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>> GONWJGEXRMA(int a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x28D6620", Offset = "0x28D5020", VA = "0x1828D6620")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x28D66A0", Offset = "0x28D50A0", VA = "0x1828D66A0", Slot = "6")]
			public void PYIZWCDUNBO(Id32<FunctionCalls.TPAVREQRGIC> a, SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> b, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x28D65B0", Offset = "0x28D4FB0", VA = "0x1828D65B0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>> XTNBAFQIOCY(int a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x28D6740", Offset = "0x28D5140", VA = "0x1828D6740", Slot = "5")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> XTVNSQMXJWI(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : AITLLCNALRJ<Id32<DDLBQTTJVCO>, SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x28DC840", Offset = "0x28DB240", VA = "0x1828DC840")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<DDLBQTTJVCO> a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x28DC8F0", Offset = "0x28DB2F0", VA = "0x1828DC8F0", Slot = "4")]
			public Id32<DDLBQTTJVCO> OTOCJEAJTDZ(int a)
			{
				return default(Id32<DDLBQTTJVCO>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x28DC7D0", Offset = "0x28DB1D0", VA = "0x1828DC7D0")]
			public bool HSIJXKHTHCB(Id32<DDLBQTTJVCO> a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x28DC7D0", Offset = "0x28DB1D0", VA = "0x1828DC7D0", Slot = "5")]
			private bool AHGGGBLMQAM(Id32<DDLBQTTJVCO> a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x28DC830", Offset = "0x28DB230", VA = "0x1828DC830", Slot = "6")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> BCXCNDPGCWJ(Id32<DDLBQTTJVCO> a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : GVDCTIQWGWC<Id32<DDLBQTTJVCO>, SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x28D6750", Offset = "0x28D5150", VA = "0x1828D6750")]
			public UnsafeList<Id32<DDLBQTTJVCO>> GONWJGEXRMA(int a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(UnsafeList<Id32<DDLBQTTJVCO>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x28D67C0", Offset = "0x28D51C0", VA = "0x1828D67C0")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<DDLBQTTJVCO> a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x28D6870", Offset = "0x28D5270", VA = "0x1828D6870", Slot = "6")]
			public void PYIZWCDUNBO(Id32<DDLBQTTJVCO> a, SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> b, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x28D6750", Offset = "0x28D5150", VA = "0x1828D6750", Slot = "4")]
			private UnsafeList<Id32<DDLBQTTJVCO>> SFXWPKMMCJA(int a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(UnsafeList<Id32<DDLBQTTJVCO>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x28D6970", Offset = "0x28D5370", VA = "0x1828D6970", Slot = "5")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> TMLQFFJFIZE(Id32<DDLBQTTJVCO> a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : AITLLCNALRJ<int, UnsafeList<(Id32<LocalVariables.M>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x28DCA80", Offset = "0x28DB480", VA = "0x1828DCA80")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB181F0", Offset = "0xB16BF0", VA = "0x180B181F0", Slot = "4")]
			public int OTOCJEAJTDZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0")]
			public bool HSIJXKHTHCB(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "5")]
			private bool PVPYYWJIVHD(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x28DCA70", Offset = "0x28DB470", VA = "0x1828DCA70", Slot = "6")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> FFJDNSTVFOE(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : GVDCTIQWGWC<int, UnsafeList<(Id32<LocalVariables.M>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x28D6DA0", Offset = "0x28D57A0", VA = "0x1828D6DA0")]
			public UnsafeList<int> GONWJGEXRMA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28D6E10", Offset = "0x28D5810", VA = "0x1828D6E10")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x28D6EA0", Offset = "0x28D58A0", VA = "0x1828D6EA0", Slot = "6")]
			public void PYIZWCDUNBO(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x28D6DA0", Offset = "0x28D57A0", VA = "0x1828D6DA0", Slot = "4")]
			private UnsafeList<int> WYLFRLPQMTT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x28D6FA0", Offset = "0x28D59A0", VA = "0x1828D6FA0", Slot = "5")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> XQTQXSHZCNJ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : AITLLCNALRJ<int, UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x28DC9E0", Offset = "0x28DB3E0", VA = "0x1828DC9E0")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB181F0", Offset = "0xB16BF0", VA = "0x180B181F0", Slot = "4")]
			public int OTOCJEAJTDZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0")]
			public bool HSIJXKHTHCB(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "5")]
			private bool IJZHSDUAXGA(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x28DC9D0", Offset = "0x28DB3D0", VA = "0x1828DC9D0", Slot = "6")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> HSGEYBSOXCB(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : GVDCTIQWGWC<int, UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x28D6BA0", Offset = "0x28D55A0", VA = "0x1828D6BA0")]
			public UnsafeList<int> GONWJGEXRMA(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x28D6C10", Offset = "0x28D5610", VA = "0x1828D6C10")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x28D6CA0", Offset = "0x28D56A0", VA = "0x1828D6CA0", Slot = "6")]
			public void PYIZWCDUNBO(int a, UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x28D6BA0", Offset = "0x28D55A0", VA = "0x1828D6BA0", Slot = "4")]
			private UnsafeList<int> OORSOBOXQQM(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x28D6B90", Offset = "0x28D5590", VA = "0x1828D6B90", Slot = "5")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> FMSCGPXKZXG(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : AITLLCNALRJ<int, UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x28DC940", Offset = "0x28DB340", VA = "0x1828DC940")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB181F0", Offset = "0xB16BF0", VA = "0x180B181F0", Slot = "4")]
			public int OTOCJEAJTDZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0")]
			public bool HSIJXKHTHCB(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "5")]
			private bool IJZHSDUAXGA(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x28DC930", Offset = "0x28DB330", VA = "0x1828DC930", Slot = "6")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> HSGEYBSOXCB(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : GVDCTIQWGWC<int, UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x28D6990", Offset = "0x28D5390", VA = "0x1828D6990")]
			public UnsafeList<int> GONWJGEXRMA(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x28D6A00", Offset = "0x28D5400", VA = "0x1828D6A00")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x28D6A90", Offset = "0x28D5490", VA = "0x1828D6A90", Slot = "6")]
			public void PYIZWCDUNBO(int a, UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x28D6990", Offset = "0x28D5390", VA = "0x1828D6990", Slot = "4")]
			private UnsafeList<int> OORSOBOXQQM(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x28D6980", Offset = "0x28D5380", VA = "0x1828D6980", Slot = "5")]
			private Id32<DNQUXCYLSXY<WBZFYOYOFGY>> FMSCGPXKZXG(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1A81A70", Offset = "0x1A80470", VA = "0x181A81A70")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x28D8620", Offset = "0x28D7020", VA = "0x1828D8620")]
			public void HMUPOGLQWOR([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<DDLBQTTJVCO> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x28D8600", Offset = "0x28D7000", VA = "0x1828D8600")]
			public GenerateDataBackFromInputIndexResult(Id32<DDLBQTTJVCO> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28D85F0", Offset = "0x28D6FF0", VA = "0x1828D85F0")]
			public void HMUPOGLQWOR([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28D85D0", Offset = "0x28D6FD0", VA = "0x1828D85D0")]
			public void HMUPOGLQWOR([Out] Id32<DataBackResults.M> a, [Out] Id32<DDLBQTTJVCO> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<DDLBQTTJVCO> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
			public GenerateDataBackFromInputIndicesResult(Id32<DDLBQTTJVCO> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x28D8610", Offset = "0x28D7010", VA = "0x1828D8610")]
			public void HMUPOGLQWOR([Out] Id32<DataBackResults.M> a, [Out] Id32<DDLBQTTJVCO> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28DA3D0", Offset = "0x28D8DD0", VA = "0x1828DA3D0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28DBA60", Offset = "0x28DA460", VA = "0x1828DBA60")]
		public static void PVPHWVPYVHI(this FunctionCompileState a, Id32<XDQQSNHTXDZ> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28DC1D0", Offset = "0x28DABD0", VA = "0x1828DC1D0")]
		public static void XKBMSIUQUXG(this FunctionCompileState a, Id32<XDQQSNHTXDZ> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28DB180", Offset = "0x28D9B80", VA = "0x1828DB180")]
		public static Id32<DataBackResults.M>? LZRHUTVSVGZ([In] this FunctionCompileState self, Id32<XDQQSNHTXDZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28DABD0", Offset = "0x28D95D0", VA = "0x1828DABD0")]
		public static Id32<DNQUXCYLSXY<HNSTYFIETBH>> IBSQRHODKON([In] this FunctionCompileState self)
		{
			return default(Id32<DNQUXCYLSXY<HNSTYFIETBH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28D9FA0", Offset = "0x28D89A0", VA = "0x1828D9FA0")]
		private static void BAROWYSUCSG(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28DB290", Offset = "0x28D9C90", VA = "0x1828DB290")]
		private static Id32<DNQUXCYLSXY<HNSTYFIETBH>>? NGBCVCIMCGZ([In] this FunctionCompileState self, Id32<DDLBQTTJVCO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28DAF10", Offset = "0x28D9910", VA = "0x1828DAF10")]
		public static void KCQCXZAUTYZ(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28DC2F0", Offset = "0x28DACF0", VA = "0x1828DC2F0")]
		public static DataBackResults.Def YETAMDZJQQJ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28DADE0", Offset = "0x28D97E0", VA = "0x1828DADE0")]
		public static ReadOnlyArray<byte> JEOOOFZHETD([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28DB310", Offset = "0x28D9D10", VA = "0x1828DB310")]
		public static Id32<LocalVariables.M> NJWDROLSAPN([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28DA280", Offset = "0x28D8C80", VA = "0x1828DA280")]
		public static Union32 DAIPXWDGDVJ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3970320", Offset = "0x396ED20", VA = "0x183970320")]
		private static Id32<DataBackResults.M> HBKJFLWXJNW<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.WSHRTVYEHEC
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28DB8D0", Offset = "0x28DA2D0", VA = "0x1828DB8D0")]
		public static Id32<DataBackResults.M> PEPDNTICCCG(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28DB200", Offset = "0x28D9C00", VA = "0x1828DB200")]
		public static Id32<DataBackResults.M> MPIOWQSQLXP(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28DAB50", Offset = "0x28D9550", VA = "0x1828DAB50")]
		public static Id32<DataBackResults.M> HWHFIXKFDKQ(this FunctionCompileState a, Id32<DNQUXCYLSXY<HNSTYFIETBH>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28DC360", Offset = "0x28DAD60", VA = "0x1828DC360")]
		public static Id32<DataBackResults.M> YNROOUDNRFM(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28DC3E0", Offset = "0x28DADE0", VA = "0x1828DC3E0")]
		public static Id32<DataBackResults.M> ZYZSSQCYZAN(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x39711D0", Offset = "0x396FBD0", VA = "0x1839711D0")]
		private static Id32<ExecForwardResults.M> NUQGAMCUNHV<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.WSHRTVYEHEC
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28DBCB0", Offset = "0x28DA6B0", VA = "0x1828DBCB0")]
		public static Id32<ExecForwardResults.M> SFCAAJAJWXD(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28DAB00", Offset = "0x28D9500", VA = "0x1828DAB00")]
		public static Id32<ExecForwardResults.M> GPNEOFVBTMS(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28D9F20", Offset = "0x28D8920", VA = "0x1828D9F20")]
		public static Id32<ExecForwardResults.M> AQUZEOSASZM(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28DBAF0", Offset = "0x28DA4F0", VA = "0x1828DBAF0")]
		public static Id32<ExecForwardResults.M> QGYWAWZPHYP(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28DB0F0", Offset = "0x28D9AF0", VA = "0x1828DB0F0")]
		public static Id32<ExecForwardResults.M> LSADKTKLSLN(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28DB600", Offset = "0x28DA000", VA = "0x1828DB600")]
		public static FunctionCalls.Def NQAEZEKHIXK([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28DB140", Offset = "0x28D9B40", VA = "0x1828DB140")]
		public static CopyEnumerable<Id32<FunctionCalls.TPAVREQRGIC>, Id32Enumerator<FunctionCalls.TPAVREQRGIC>> LZKKXKFBEUJ([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.TPAVREQRGIC>, Id32Enumerator<FunctionCalls.TPAVREQRGIC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28DB670", Offset = "0x28DA070", VA = "0x1828DB670")]
		public static Id32<FunctionCalls.TPAVREQRGIC> NYYBYUALPBC([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.TPAVREQRGIC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28DA360", Offset = "0x28D8D60", VA = "0x1828DA360")]
		public static FunctionCalls.IO DQMJEVDCQWZ([In] this FunctionCompileState self, Id32<FunctionCalls.TPAVREQRGIC> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28DB080", Offset = "0x28D9A80", VA = "0x1828DB080")]
		public static FunctionCalls.IO KWNEJHVFAEJ(this FunctionCompileState a, Id32<FunctionCalls.TPAVREQRGIC> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3970920", Offset = "0x396F320", VA = "0x183970920")]
		private static Id32<FunctionCalls.M> LIKKPTJVGJM<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.WSHRTVYEHEC
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28DB450", Offset = "0x28D9E50", VA = "0x1828DB450")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>) NPKNWCXRDTF(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28DBCF0", Offset = "0x28DA6F0", VA = "0x1828DBCF0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>) SLTUUVOFGKR(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28DC2A0", Offset = "0x28DACA0", VA = "0x1828DC2A0")]
		public static Id32<FunctionCalls.M> XTKVIVPRKDI(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28DA1F0", Offset = "0x28D8BF0", VA = "0x1828DA1F0")]
		public static void CFGGEVZZAGX(this FunctionCompileState a, Id32<FunctionCalls.TPAVREQRGIC> b, Id32<DNQUXCYLSXY<HNSTYFIETBH>> c, Id32<DNQUXCYLSXY<EIZFQRKEDAI>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3971270", Offset = "0x396FC70", VA = "0x183971270")]
		public static GenerateDataBackResult PYRLFGIHGBF<d, e>(this FunctionCompileState a, d b, e c, Id32<HGNGXYZABBE> d, Id32<DDLBQTTJVCO> e) where d : AGAWTSGPFNV<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x396FED0", Offset = "0x396E8D0", VA = "0x18396FED0")]
		public static GenerateDataBackFromInputIndexResult FQHHETIJVXF<f, g>(this FunctionCompileState a, f b, g c, Id32<HGNGXYZABBE> d, Id32<XEUKGISKBDU> e, int f) where f : AGAWTSGPFNV<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x39703C0", Offset = "0x396EDC0", VA = "0x1839703C0")]
		public static Id32<DataBackResults.M>? JXMHCZJQUOS<h, i>(this FunctionCompileState a, h b, i c, Id32<HGNGXYZABBE> d, Id32<XEUKGISKBDU> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : AGAWTSGPFNV<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x39709B0", Offset = "0x396F3B0", VA = "0x1839709B0")]
		public static Id32<ExecForwardResults.M> MEOSAHWFUPM<j, k>(this FunctionCompileState a, j b, k c, Id32<HGNGXYZABBE> d, Id32<XDQQSNHTXDZ> e) where j : AGAWTSGPFNV<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x28DBEA0", Offset = "0x28DA8A0", VA = "0x1828DBEA0")]
		public static LocalVariables.ArgumentInst UUJNEKOCHWS([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28DBFB0", Offset = "0x28DA9B0", VA = "0x1828DBFB0")]
		public static LocalVariables.CalleeReturnValueInst UXXIZUOUHOK([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28DB950", Offset = "0x28DA350", VA = "0x1828DB950")]
		public static LocalVariables.CallerReturnValueInst PVBGKIOUVER([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28DAC30", Offset = "0x28D9630", VA = "0x1828DAC30")]
		public static Id32<LocalVariables.M> IPXVNQGUPGT(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28DBBA0", Offset = "0x28DA5A0", VA = "0x1828DBBA0")]
		public static LocalVariables.ParameterInst RYQCZXLLIRG([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28DA780", Offset = "0x28D9180", VA = "0x1828DA780")]
		public static LocalVariables.Def FEENXHQRFII([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28DAEC0", Offset = "0x28D98C0", VA = "0x1828DAEC0")]
		public static int? JGUHLANFMPY([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x396FDD0", Offset = "0x396E7D0", VA = "0x18396FDD0")]
		private static Id32<LocalVariables.M> DBDWKXEKTVI<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.WSHRTVYEHEC
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28DA140", Offset = "0x28D8B40", VA = "0x1828DA140")]
		public static Id32<LocalVariables.M> BGJINZLZOSM(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28DB3F0", Offset = "0x28D9DF0", VA = "0x1828DB3F0")]
		public static Id32<LocalVariables.M> NMFUNXRGCEP(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28DA980", Offset = "0x28D9380", VA = "0x1828DA980")]
		public static Id32<LocalVariables.M> GJRWIZKLXAF(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28DB840", Offset = "0x28DA240", VA = "0x1828DB840")]
		public static Id32<LocalVariables.M> OUZTDAVTRMJ(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28DBB40", Offset = "0x28DA540", VA = "0x1828DBB40")]
		public static Id32<LocalVariables.M> RAQZFIANRGJ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28DA7D0", Offset = "0x28D91D0", VA = "0x1828DA7D0")]
		public static void FLUKCIXAXTY(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28DC0C0", Offset = "0x28DAAC0", VA = "0x1828DC0C0")]
		public static void WHKXJRCBTOC(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28D9E70", Offset = "0x28D8870", VA = "0x1828D9E70")]
		public static void AMHGFTZOTDM(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28DA8F0", Offset = "0x28D92F0", VA = "0x1828DA8F0")]
		public static void GAIYIMRNMFD(this FunctionCompileState a, Id32<DNQUXCYLSXY<HNSTYFIETBH>> b, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28DA6A0", Offset = "0x28D90A0", VA = "0x1828DA6A0")]
		public static void ELQANTFMYOB(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<DNQUXCYLSXY<VJKOEGYQQCQ>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3972750", Offset = "0x3971150", VA = "0x183972750")]
		public static void TKJOZUYLDSG<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<DNQUXCYLSXY<ASDRXZXCACQ<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface AGAWTSGPFNV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<MLQMNZEWPGO> ZAFHAXIANJS(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<MLQMNZEWPGO> PARBGROUNUF(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<MLQMNZEWPGO> MSRPDIKGDEC(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<MLQMNZEWPGO> WPVGDCJKQRT(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> MBGBZKHEQBB(a a, FunctionCompileState b, Id32<HGNGXYZABBE> c, Id32<DDLBQTTJVCO> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> YHHIKIUIEZP(a a, FunctionCompileState b, Id32<HGNGXYZABBE> c, Id32<XDQQSNHTXDZ> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int TDGDZDCITIV(a a, Id32<HGNGXYZABBE> b, Id32<DDLBQTTJVCO> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<XDQQSNHTXDZ> ZKYCOQNSLPM(a a, Id32<HGNGXYZABBE> b, Id32<DDLBQTTJVCO> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind ZOTLSYOPEID(a a, Id32<HGNGXYZABBE> b, Id32<DDLBQTTJVCO> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool GHFXTBCWPBG(a a, Id32<HGNGXYZABBE> b, Id32<DDLBQTTJVCO> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int KSDOOJKSYND(a a, Id32<HGNGXYZABBE> b, Id32<DDLBQTTJVCO> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> SYVEZOPHSNV(a a, Id32<HGNGXYZABBE> b, Id32<DDLBQTTJVCO> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<MLQMNZEWPGO>) JVPEWUSVRUN(a a, Id32<HGNGXYZABBE> b, Id32<DDLBQTTJVCO> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int KKDXZYQEETB(a a, Id32<HGNGXYZABBE> b, Id32<XDQQSNHTXDZ> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<DDLBQTTJVCO> ALPMEBUXBFQ(a a, Id32<HGNGXYZABBE> b, Id32<XDQQSNHTXDZ> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<DDLBQTTJVCO> CIVTBGFUGMT(a a, Id32<HGNGXYZABBE> b, Id32<XEUKGISKBDU> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int LOFQKBUMOIX(a a, Id32<HGNGXYZABBE> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? JOZPERAVNTZ(a a, Id32<HGNGXYZABBE> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int PYQVGGQCFHX(a a, Id32<HGNGXYZABBE> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? WECVCCDCTVH(a a, Id32<HGNGXYZABBE> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class ZPTOAQKFATA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C1C2E0", Offset = "0x3C1ACE0", VA = "0x183C1C2E0")]
		public static Id32<LocalVariables.M?> FUXRIVWJWUJ<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C1D790", Offset = "0x3C1C190", VA = "0x183C1D790")]
		public static Id32<LocalVariables.M?> LQVOUIZCKOI<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C1DB00", Offset = "0x3C1C500", VA = "0x183C1DB00")]
		public static Id32<LocalVariables.M?> MQNVOWRIMHP<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x28E0880", Offset = "0x28DF280", VA = "0x1828E0880")]
		public static Id32<LocalVariables.M> RCFAQZHMYVV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x28DCFD0", Offset = "0x28DB9D0", VA = "0x1828DCFD0")]
		public static Id32<LocalVariables.M> CAWLVGIOKMI(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x28DDA40", Offset = "0x28DC440", VA = "0x1828DDA40")]
		public static Id32<LocalVariables.M> FERCHPSKKCJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x28DDD40", Offset = "0x28DC740", VA = "0x1828DDD40")]
		public static Id32<LocalVariables.M> FTWIUFGYYVL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x28E1A60", Offset = "0x28E0460", VA = "0x1828E1A60")]
		public static Id32<LocalVariables.M> UOEAQPTRKLU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28DCB10", Offset = "0x28DB510", VA = "0x1828DCB10")]
		public static Id32<LocalVariables.M> ALMMHBTQQLR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x28E17D0", Offset = "0x28E01D0", VA = "0x1828E17D0")]
		public static Id32<LocalVariables.M> TTJHYEPXGRB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x28E16B0", Offset = "0x28E00B0", VA = "0x1828E16B0")]
		public static Id32<LocalVariables.M> TQTCCJHIEKY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x28DD260", Offset = "0x28DBC60", VA = "0x1828DD260")]
		public static Id32<LocalVariables.M> CZWVUBKNGND(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x28DEB90", Offset = "0x28DD590", VA = "0x1828DEB90")]
		public static Id32<LocalVariables.M> KPQUPGISZJO(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x28DEDB0", Offset = "0x28DD7B0", VA = "0x1828DEDB0")]
		public static Id32<LocalVariables.M> KSSXSHYPYVR(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28DE140", Offset = "0x28DCB40", VA = "0x1828DE140")]
		public static Id32<LocalVariables.M> GVFRZKWEHAC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28DDE40", Offset = "0x28DC840", VA = "0x1828DDE40")]
		public static Id32<LocalVariables.M> GLWSPGPQMSV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28DEA60", Offset = "0x28DD460", VA = "0x1828DEA60")]
		public static Id32<LocalVariables.M> KIVRKRSWNMC(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28DCE70", Offset = "0x28DB870", VA = "0x1828DCE70")]
		public static Id32<LocalVariables.M> AYKESWGADFN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28E19E0", Offset = "0x28E03E0", VA = "0x1828E19E0")]
		public static Id32<LocalVariables.M> TYGUNVQQAMF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28DFEA0", Offset = "0x28DE8A0", VA = "0x1828DFEA0")]
		public static Id32<LocalVariables.M> NGGPJCJXFNU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28DD9C0", Offset = "0x28DC3C0", VA = "0x1828DD9C0")]
		public static Id32<LocalVariables.M> EZFLRKWZLHF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28E0620", Offset = "0x28DF020", VA = "0x1828E0620")]
		public static Id32<LocalVariables.M> QBDPPWPNVSQ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28E1F00", Offset = "0x28E0900", VA = "0x1828E1F00")]
		public static Id32<LocalVariables.M> WYAJTVCTIGL(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28DF5F0", Offset = "0x28DDFF0", VA = "0x1828DF5F0")]
		public static Id32<LocalVariables.M> MAUABKEZUKW(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28E1430", Offset = "0x28DFE30", VA = "0x1828E1430")]
		public static Id32<LocalVariables.M> THXHKGYQHIK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28DD1E0", Offset = "0x28DBBE0", VA = "0x1828DD1E0")]
		public static Id32<LocalVariables.M> CYHTIMVTNJL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28DD940", Offset = "0x28DC340", VA = "0x1828DD940")]
		public static Id32<LocalVariables.M> EKJQSHWOKUY(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28E0CF0", Offset = "0x28DF6F0", VA = "0x1828E0CF0")]
		public static Id32<LocalVariables.M> SMNVKYNIRQT(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28DF7B0", Offset = "0x28DE1B0", VA = "0x1828DF7B0")]
		public static Id32<LocalVariables.M> MQUPULYUJSQ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28DDCC0", Offset = "0x28DC6C0", VA = "0x1828DDCC0")]
		public static Id32<LocalVariables.M> FKREYSCRUKF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28E14B0", Offset = "0x28DFEB0", VA = "0x1828E14B0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> TJEYKYUEQFR(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28DF570", Offset = "0x28DDF70", VA = "0x1828DF570")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> LQGGOHDPWAP(this FunctionCompileState a, int b)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28E1DE0", Offset = "0x28E07E0", VA = "0x1828E1DE0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> VNXONKXCYWI(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28DD4C0", Offset = "0x28DBEC0", VA = "0x1828DD4C0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> DNBWSYVSXYA(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28E1F80", Offset = "0x28E0980", VA = "0x1828E1F80")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ZVAMBQWEMGY(this FunctionCompileState a, int b)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28E07E0", Offset = "0x28DF1E0", VA = "0x1828E07E0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> QVEGGFFJQHB(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28DEED0", Offset = "0x28DD8D0", VA = "0x1828DEED0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>) KTIMUZVTKCE(this FunctionCompileState a, Id32<TTSTDRWIEBX> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28E0E90", Offset = "0x28DF890", VA = "0x1828E0E90")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>) STKPGVKNZAO(this FunctionCompileState a, Id32<JQFETOMIQRN> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C1D4F0", Offset = "0x3C1BEF0", VA = "0x183C1D4F0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<MLQMNZEWPGO>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<TMarker>>, Id32<FunctionCalls.M>) HHHAWQAIHHL<TMarker>(this FunctionCompileState a, Id32<MLQMNZEWPGO> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<MLQMNZEWPGO>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28DE4F0", Offset = "0x28DCEF0", VA = "0x1828DE4F0")]
		public static Id32<LocalVariables.M> IXGNPXDMYAN(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28DD0F0", Offset = "0x28DBAF0", VA = "0x1828DD0F0")]
		public static Id32<LocalVariables.M> CFGILDWUDCC(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28DFF20", Offset = "0x28DE920", VA = "0x1828DFF20")]
		public static Id32<LocalVariables.M> NGNRYRXSNLJ(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28DCD50", Offset = "0x28DB750", VA = "0x1828DCD50")]
		public static Id32<LocalVariables.M> AOUXTGGZSII(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x28DDF40", Offset = "0x28DC940", VA = "0x1828DDF40")]
		public static Id32<LocalVariables.M> GPRUDZOHMBR(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28DD3A0", Offset = "0x28DBDA0", VA = "0x1828DD3A0")]
		public static Id32<LocalVariables.M> DMSWTFXXQCI(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28DD6C0", Offset = "0x28DC0C0", VA = "0x1828DD6C0")]
		public static Id32<LocalVariables.M> DOWKJHGGMMJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28DCC50", Offset = "0x28DB650", VA = "0x1828DCC50")]
		public static Id32<LocalVariables.M> ANZGGKMPWWN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28DEC90", Offset = "0x28DD690", VA = "0x1828DEC90")]
		public static Id32<LocalVariables.M> KSBIEJFFBBY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28E1CA0", Offset = "0x28E06A0", VA = "0x1828E1CA0")]
		public static Id32<LocalVariables.M> VDYXZMYMURR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28E1E80", Offset = "0x28E0880", VA = "0x1828E1E80")]
		public static Id32<LocalVariables.M> WIZMYEGEAXI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28E0010", Offset = "0x28DEA10", VA = "0x1828E0010")]
		public static Id32<LocalVariables.M> NVPAWUSYCTT(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28DE5B0", Offset = "0x28DCFB0", VA = "0x1828DE5B0")]
		public static Id32<LocalVariables.M> JQOVOEPOWGM(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28DF470", Offset = "0x28DDE70", VA = "0x1828DF470")]
		public static Id32<LocalVariables.M> KYZHLQAQTTS(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28E03B0", Offset = "0x28DEDB0", VA = "0x1828E03B0")]
		public static Id32<LocalVariables.M> PMPHURGXQPN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28DDB80", Offset = "0x28DC580", VA = "0x1828DDB80")]
		public static Id32<LocalVariables.M> FJBFBBJZETY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x28DF370", Offset = "0x28DDD70", VA = "0x1828DF370")]
		public static Id32<LocalVariables.M> KUJWMOVTYFX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x28E0AD0", Offset = "0x28DF4D0", VA = "0x1828E0AD0")]
		public static Id32<LocalVariables.M> SAQRSQJEDHU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28DE3A0", Offset = "0x28DCDA0", VA = "0x1828DE3A0")]
		public static Id32<LocalVariables.M> IMAVIDTZKSP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28DCFB0", Offset = "0x28DB9B0", VA = "0x1828DCFB0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> BVSRKAPFBIZ(this FunctionCompileState a)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x28E0BF0", Offset = "0x28DF5F0", VA = "0x1828E0BF0")]
		public static Id32<LocalVariables.M> SCDRCGBILVM(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x28E1B80", Offset = "0x28E0580", VA = "0x1828E1B80")]
		public static Id32<LocalVariables.M> UWLJKKUPTJX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28DF670", Offset = "0x28DE070", VA = "0x1828DF670")]
		public static Id32<LocalVariables.M> MAZSEYPPUBW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x28DE040", Offset = "0x28DCA40", VA = "0x1828DE040")]
		public static Id32<LocalVariables.M> GSOEBPMFBHG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28E0D70", Offset = "0x28DF770", VA = "0x1828E0D70")]
		public static Id32<LocalVariables.M> SMWRYIULJWP(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x28DD800", Offset = "0x28DC200", VA = "0x1828DD800")]
		public static Id32<LocalVariables.M> EJXPBFGZFQO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28E0090", Offset = "0x28DEA90", VA = "0x1828E0090")]
		public static Id32<LocalVariables.M> NYHOBEDASOT(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28E18D0", Offset = "0x28E02D0", VA = "0x1828E18D0")]
		public static Id32<LocalVariables.M> TUSTINFURDW(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28DE4E0", Offset = "0x28DCEE0", VA = "0x1828DE4E0")]
		public static void IVELIJNDJDH(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28E02B0", Offset = "0x28DECB0", VA = "0x1828E02B0")]
		public static Id32<LocalVariables.M> PKWUMEXYOEO(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x28DE280", Offset = "0x28DCC80", VA = "0x1828DE280")]
		public static Id32<LocalVariables.M> HALLINOKVQF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x28DF830", Offset = "0x28DE230", VA = "0x1828DF830")]
		public static Id32<LocalVariables.M> MQZIFLRZQOY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x28E1330", Offset = "0x28DFD30", VA = "0x1828E1330")]
		public static Id32<LocalVariables.M> TFAIDSCFBBW(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28DFD80", Offset = "0x28DE780", VA = "0x1828DFD80")]
		public static Id32<LocalVariables.M> MYRVKDECNZN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28E04E0", Offset = "0x28DEEE0", VA = "0x1828E04E0")]
		public static Id32<LocalVariables.M> PQHXBMAUJZA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28DF970", Offset = "0x28DE370", VA = "0x1828DF970")]
		public static Id32<LocalVariables.M> MVBXMGWONEK(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28DE960", Offset = "0x28DD360", VA = "0x1828DE960")]
		public static Id32<LocalVariables.M> KHRQORSDPIT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28E0190", Offset = "0x28DEB90", VA = "0x1828E0190")]
		public static Id32<LocalVariables.M> OEGYVKWWQFG(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28E06A0", Offset = "0x28DF0A0", VA = "0x1828E06A0")]
		public static Id32<LocalVariables.M> QCYKQBHKDQF(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3C1DF40", Offset = "0x3C1C940", VA = "0x183C1DF40")]
		public static void RWGWASKIDUA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<TTSTDRWIEBX> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3C1E6D0", Offset = "0x3C1D0D0", VA = "0x183C1E6D0")]
		public static void TPKVFUQPSWC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<JQFETOMIQRN> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3C1DC30", Offset = "0x3C1C630", VA = "0x183C1DC30")]
		public static Id32<LocalVariables.M> NTODCPPRDWM<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3C1BC20", Offset = "0x3C1A620", VA = "0x183C1BC20")]
		public static Id32<LocalVariables.M> CJXILBWJEJT<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3C1D0A0", Offset = "0x3C1BAA0", VA = "0x183C1D0A0")]
		public static Id32<DataBackResults.M> GRVJELEKEBI<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, AGAWTSGPFNV<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3C1F610", Offset = "0x3C1E010", VA = "0x183C1F610")]
		public static Id32<ExecForwardResults.M> VXDLRRNLRBT<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, AGAWTSGPFNV<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28E0980", Offset = "0x28DF380", VA = "0x1828E0980")]
		public static Id32<DataBackResults.M> RLKSZZEKPCD(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28DE630", Offset = "0x28DD030", VA = "0x1828DE630")]
		public static Id32<DataBackResults.M> JVNYLEWOXRD(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3C1C740", Offset = "0x3C1B140", VA = "0x183C1C740")]
		public static Id32<DataBackResults.M> GAJTYDPUIYA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<TTSTDRWIEBX> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3C1C4D0", Offset = "0x3C1AED0", VA = "0x183C1C4D0")]
		private static Id32<DataBackResults.M> GAJTYDPUIYA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<TTSTDRWIEBX> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3C1F1C0", Offset = "0x3C1DBC0", VA = "0x183C1F1C0")]
		public static Id32<LocalVariables.M> UHVKEMFGZDO<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3C1EE60", Offset = "0x3C1D860", VA = "0x183C1EE60")]
		public static void TZCMVHKCQKN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<DNQUXCYLSXY<HNSTYFIETBH>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<DNQUXCYLSXY<HNSTYFIETBH>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		public LiveInterval(Id32<DNQUXCYLSXY<HNSTYFIETBH>> firstUse, Id32<DNQUXCYLSXY<HNSTYFIETBH>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28D8810", Offset = "0x28D7210", VA = "0x1828D8810")]
		public static LiveInterval New(Id32<DNQUXCYLSXY<HNSTYFIETBH>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class AYJPWIOTBNH : WSHRTVYEHEC
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
			[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class TIFIIKPNDXB : WSHRTVYEHEC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class FIZIZBQCARG : WSHRTVYEHEC
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
			[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
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
		public abstract class WSHRTVYEHEC
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
			public Id32<WSHRTVYEHEC> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x28D87F0", Offset = "0x28D71F0", VA = "0x1828D87F0")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<WSHRTVYEHEC> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class INDKLOYBAVD : WSHRTVYEHEC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<AYJPWIOTBNH, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<FIZIZBQCARG, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<INDKLOYBAVD, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<TIFIIKPNDXB, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28D8A10", Offset = "0x28D7410", VA = "0x1828D8A10")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<AYJPWIOTBNH, ArgumentInst> argumentVariables, [In] SOAId32Field<FIZIZBQCARG, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<INDKLOYBAVD, ParameterInst> parameterVariables, [In] SOAId32Field<TIFIIKPNDXB, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28D8820", Offset = "0x28D7220", VA = "0x1828D8820")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class PGXLJXUSKVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28D90E0", Offset = "0x28D7AE0", VA = "0x1828D90E0")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class MVGPZZOQNSO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28D8B90", Offset = "0x28D7590", VA = "0x1828D8B90")]
		public static void UGAONVMMAWY(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.TPAVREQRGIC, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28D7240", Offset = "0x28D5C40", VA = "0x1828D7240")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.TPAVREQRGIC, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28D71D0", Offset = "0x28D5BD0", VA = "0x1828D71D0")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28D6FB0", Offset = "0x28D59B0", VA = "0x1828D6FB0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3328810", Offset = "0x3327210", VA = "0x183328810")]
		public static void UGAONVMMAWY<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<HGNGXYZABBE> graphId) where TDeps : notnull, AGAWTSGPFNV<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class REOGZNKVPUP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28DC460", Offset = "0x28DAE60", VA = "0x1828DC460")]
		public static void UGAONVMMAWY(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface UFTPTVPYRGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SSLEOOQCPGL(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : UFTPTVPYRGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x28D9D30", Offset = "0x28D8730", VA = "0x1828D9D30", Slot = "4")]
			public void SSLEOOQCPGL(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : UFTPTVPYRGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x28D9DC0", Offset = "0x28D87C0", VA = "0x1828D9DC0", Slot = "4")]
			public void SSLEOOQCPGL(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : UFTPTVPYRGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x28D9BF0", Offset = "0x28D85F0", VA = "0x1828D9BF0", Slot = "4")]
			public void SSLEOOQCPGL(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : UFTPTVPYRGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x28D9C80", Offset = "0x28D8680", VA = "0x1828D9C80", Slot = "4")]
			public void SSLEOOQCPGL(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class HKNQDMJULLQ<c> where c : struct, UFTPTVPYRGY
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c EONMVLIXIRY;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3636D80", Offset = "0x3635780", VA = "0x183636D80")]
			public static int UGAONVMMAWY<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : AGAWTSGPFNV<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<FunctionCalls.TPAVREQRGIC>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28D87A0", Offset = "0x28D71A0", VA = "0x1828D87A0")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<FunctionCalls.TPAVREQRGIC>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28D86F0", Offset = "0x28D70F0", VA = "0x1828D86F0")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28D86B0", Offset = "0x28D70B0", VA = "0x1828D86B0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x37252F0", Offset = "0x3723CF0", VA = "0x1837252F0")]
		public static void UGAONVMMAWY<b, a>(FunctionCompileState a, b b, a c) where b : AGAWTSGPFNV<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class PNPKMHLULMA
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
		private static int ZHEOWUEJOJM;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int LSQXTJTNCZK;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x28D9640", Offset = "0x28D8040", VA = "0x1828D9640")]
		public static void UGAONVMMAWY(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28D92D0", Offset = "0x28D7CD0", VA = "0x1828D92D0")]
		private static void KIQUSWXRYGR([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28D9190", Offset = "0x28D7B90", VA = "0x1828D9190")]
		private static void KIQUSWXRYGR(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28D94E0", Offset = "0x28D7EE0", VA = "0x1828D94E0")]
		private static void SOQCICFHEPY(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class FNXOQAMAJIA<a, b, c> where a : struct, GVDCTIQWGWC<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a EONMVLIXIRY;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4CFFFC0", Offset = "0x4CFE9C0", VA = "0x184CFFFC0")]
		public static void UGAONVMMAWY([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface GVDCTIQWGWC<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> GONWJGEXRMA(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PYIZWCDUNBO(a a, b b, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface AITLLCNALRJ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a OTOCJEAJTDZ(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HSIJXKHTHCB(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class FOFIOZEAONT<a, b, c> where a : struct, AITLLCNALRJ<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a EONMVLIXIRY;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4D035D0", Offset = "0x4D01FD0", VA = "0x184D035D0")]
		public static UnsafeList<b> UGAONVMMAWY(int a, [In] c values)
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
