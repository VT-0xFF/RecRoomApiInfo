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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C6830", Offset = "0x28C5030", VA = "0x1828C6830")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2869540", Offset = "0x2867D40", VA = "0x182869540")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x28C4AB0", Offset = "0x28C32B0", VA = "0x1828C4AB0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2080200", Offset = "0x207EA00", VA = "0x182080200", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C4C60", Offset = "0x28C3460", VA = "0x1828C4C60")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<RFRDFDYGPGO, BytesImmediate> bytesImmediates, [In] IdUnsafeList<OKUIQHCYXWN, DeadEnd> deadEnds, [In] IdUnsafeList<AEAIQBZILQC, Variable> variables, [In] IdUnsafeList<JMBYCNVUUDC, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28C4B20", Offset = "0x28C3320", VA = "0x1828C4B20")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class NQFFNGTTMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28C6520", Offset = "0x28C4D20", VA = "0x1828C6520")]
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
			[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C4D80", Offset = "0x28C3580", VA = "0x1828C4D80")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<KNFAPOOAOJD, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28C4CF0", Offset = "0x28C34F0", VA = "0x1828C4CF0")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class OSAGUQCBACS
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28C68B0", Offset = "0x28C50B0", VA = "0x1828C68B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C4E60", Offset = "0x28C3660", VA = "0x1828C4E60")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28C4DC0", Offset = "0x28C35C0", VA = "0x1828C4DC0")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class MMQDOYKJGOZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28C6370", Offset = "0x28C4B70", VA = "0x1828C6370")]
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
			[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
			private Inst(Def def, Id32<WSHRTVYEHEC> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28C6010", Offset = "0x28C4810", VA = "0x1828C6010")]
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
			[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C4D80", Offset = "0x28C3580", VA = "0x1828C4D80")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x28C5E60", Offset = "0x28C4660", VA = "0x1828C5E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C5060", Offset = "0x28C3860", VA = "0x1828C5060")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<PTAFTIUEVFB, InternalCall> internalCalls, [In] IdUnsafeList<QTFDNCIWSUV, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<TPAVREQRGIC> IOId)> callsWithIO, [In] IdUnsafeList<TPAVREQRGIC, IO> io, [In] SOAField<TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> ioModifyingCallLocations, [In] SOAField<TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28C4EC0", Offset = "0x28C36C0", VA = "0x1828C4EC0")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class NVISGEFGYAT
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28C65D0", Offset = "0x28C4DD0", VA = "0x1828C65D0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28C6620", Offset = "0x28C4E20", VA = "0x1828C6620")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C5AB0", Offset = "0x28C42B0", VA = "0x1828C5AB0")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<XDQQSNHTXDZ, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<XDQQSNHTXDZ>> generatedOutputsForExpression, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28C5120", Offset = "0x28C3920", VA = "0x1828C5120")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C9E60", Offset = "0x28C8660", VA = "0x1828C9E60")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x28C9EF0", Offset = "0x28C86F0", VA = "0x1828C9EF0", Slot = "4")]
			public Id32<FunctionCalls.TPAVREQRGIC> OTOCJEAJTDZ(int a)
			{
				return default(Id32<FunctionCalls.TPAVREQRGIC>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
			public bool HSIJXKHTHCB(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "5")]
			private bool ITSGMIWVRRD(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x28C9EE0", Offset = "0x28C86E0", VA = "0x1828C9EE0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C3C40", Offset = "0x28C2440", VA = "0x1828C3C40")]
			public UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>> GONWJGEXRMA(int a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x28C3CB0", Offset = "0x28C24B0", VA = "0x1828C3CB0")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x28C3D40", Offset = "0x28C2540", VA = "0x1828C3D40", Slot = "6")]
			public void PYIZWCDUNBO(Id32<FunctionCalls.TPAVREQRGIC> a, SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> b, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x28C3C40", Offset = "0x28C2440", VA = "0x1828C3C40", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>> IQKRHDVHETR(int a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<HNSTYFIETBH>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x28C3D30", Offset = "0x28C2530", VA = "0x1828C3D30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C9F40", Offset = "0x28C8740", VA = "0x1828C9F40")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x28C9FC0", Offset = "0x28C87C0", VA = "0x1828C9FC0", Slot = "4")]
			public Id32<FunctionCalls.TPAVREQRGIC> OTOCJEAJTDZ(int a)
			{
				return default(Id32<FunctionCalls.TPAVREQRGIC>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
			public bool HSIJXKHTHCB(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "5")]
			private bool WJNCXXDANWO(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x28C9F30", Offset = "0x28C8730", VA = "0x1828C9F30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C3DE0", Offset = "0x28C25E0", VA = "0x1828C3DE0")]
			public UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>> GONWJGEXRMA(int a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x28C3E50", Offset = "0x28C2650", VA = "0x1828C3E50")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<FunctionCalls.TPAVREQRGIC> a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x28C3ED0", Offset = "0x28C26D0", VA = "0x1828C3ED0", Slot = "6")]
			public void PYIZWCDUNBO(Id32<FunctionCalls.TPAVREQRGIC> a, SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> b, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x28C3DE0", Offset = "0x28C25E0", VA = "0x1828C3DE0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>> XTNBAFQIOCY(int a, [In] SOAField<FunctionCalls.TPAVREQRGIC, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TPAVREQRGIC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x28C3F70", Offset = "0x28C2770", VA = "0x1828C3F70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x28CA070", Offset = "0x28C8870", VA = "0x1828CA070")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<DDLBQTTJVCO> a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x28CA120", Offset = "0x28C8920", VA = "0x1828CA120", Slot = "4")]
			public Id32<DDLBQTTJVCO> OTOCJEAJTDZ(int a)
			{
				return default(Id32<DDLBQTTJVCO>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x28CA000", Offset = "0x28C8800", VA = "0x1828CA000")]
			public bool HSIJXKHTHCB(Id32<DDLBQTTJVCO> a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x28CA000", Offset = "0x28C8800", VA = "0x1828CA000", Slot = "5")]
			private bool AHGGGBLMQAM(Id32<DDLBQTTJVCO> a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x28CA060", Offset = "0x28C8860", VA = "0x1828CA060", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C3F80", Offset = "0x28C2780", VA = "0x1828C3F80")]
			public UnsafeList<Id32<DDLBQTTJVCO>> GONWJGEXRMA(int a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(UnsafeList<Id32<DDLBQTTJVCO>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x28C3FF0", Offset = "0x28C27F0", VA = "0x1828C3FF0")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(Id32<DDLBQTTJVCO> a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x28C40A0", Offset = "0x28C28A0", VA = "0x1828C40A0", Slot = "6")]
			public void PYIZWCDUNBO(Id32<DDLBQTTJVCO> a, SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> b, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x28C3F80", Offset = "0x28C2780", VA = "0x1828C3F80", Slot = "4")]
			private UnsafeList<Id32<DDLBQTTJVCO>> SFXWPKMMCJA(int a, [In] SOAField<DDLBQTTJVCO, Id32<DNQUXCYLSXY<HNSTYFIETBH>>?> values)
			{
				return default(UnsafeList<Id32<DDLBQTTJVCO>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x28C41A0", Offset = "0x28C29A0", VA = "0x1828C41A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x28CA2B0", Offset = "0x28C8AB0", VA = "0x1828CA2B0")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB01040", Offset = "0xAFF840", VA = "0x180B01040", Slot = "4")]
			public int OTOCJEAJTDZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
			public bool HSIJXKHTHCB(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "5")]
			private bool PVPYYWJIVHD(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x28CA2A0", Offset = "0x28C8AA0", VA = "0x1828CA2A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C45D0", Offset = "0x28C2DD0", VA = "0x1828C45D0")]
			public UnsafeList<int> GONWJGEXRMA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28C4640", Offset = "0x28C2E40", VA = "0x1828C4640")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x28C46D0", Offset = "0x28C2ED0", VA = "0x1828C46D0", Slot = "6")]
			public void PYIZWCDUNBO(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x28C45D0", Offset = "0x28C2DD0", VA = "0x1828C45D0", Slot = "4")]
			private UnsafeList<int> WYLFRLPQMTT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WBZFYOYOFGY>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x28C47D0", Offset = "0x28C2FD0", VA = "0x1828C47D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x28CA210", Offset = "0x28C8A10", VA = "0x1828CA210")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB01040", Offset = "0xAFF840", VA = "0x180B01040", Slot = "4")]
			public int OTOCJEAJTDZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
			public bool HSIJXKHTHCB(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "5")]
			private bool IJZHSDUAXGA(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x28CA200", Offset = "0x28C8A00", VA = "0x1828CA200", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C43D0", Offset = "0x28C2BD0", VA = "0x1828C43D0")]
			public UnsafeList<int> GONWJGEXRMA(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x28C4440", Offset = "0x28C2C40", VA = "0x1828C4440")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x28C44D0", Offset = "0x28C2CD0", VA = "0x1828C44D0", Slot = "6")]
			public void PYIZWCDUNBO(int a, UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x28C43D0", Offset = "0x28C2BD0", VA = "0x1828C43D0", Slot = "4")]
			private UnsafeList<int> OORSOBOXQQM(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x28C43C0", Offset = "0x28C2BC0", VA = "0x1828C43C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x28CA170", Offset = "0x28C8970", VA = "0x1828CA170")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB01040", Offset = "0xAFF840", VA = "0x180B01040", Slot = "4")]
			public int OTOCJEAJTDZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
			public bool HSIJXKHTHCB(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "5")]
			private bool IJZHSDUAXGA(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x28CA160", Offset = "0x28C8960", VA = "0x1828CA160", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C41C0", Offset = "0x28C29C0", VA = "0x1828C41C0")]
			public UnsafeList<int> GONWJGEXRMA(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x28C4230", Offset = "0x28C2A30", VA = "0x1828C4230")]
			public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> KTKQEJMIGCE(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x28C42C0", Offset = "0x28C2AC0", VA = "0x1828C42C0", Slot = "6")]
			public void PYIZWCDUNBO(int a, UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x28C41C0", Offset = "0x28C29C0", VA = "0x1828C41C0", Slot = "4")]
			private UnsafeList<int> OORSOBOXQQM(int a, [In] UnsafeList<(Id32<DNQUXCYLSXY<HNSTYFIETBH>> Target, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x28C41B0", Offset = "0x28C29B0", VA = "0x1828C41B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1A6A950", Offset = "0x1A69150", VA = "0x181A6A950")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x28C5E50", Offset = "0x28C4650", VA = "0x1828C5E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C5E30", Offset = "0x28C4630", VA = "0x1828C5E30")]
			public GenerateDataBackFromInputIndexResult(Id32<DDLBQTTJVCO> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28C5E20", Offset = "0x28C4620", VA = "0x1828C5E20")]
			public void HMUPOGLQWOR([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28C5E00", Offset = "0x28C4600", VA = "0x1828C5E00")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
			public GenerateDataBackFromInputIndicesResult(Id32<DDLBQTTJVCO> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x28C5E40", Offset = "0x28C4640", VA = "0x1828C5E40")]
			public void HMUPOGLQWOR([Out] Id32<DataBackResults.M> a, [Out] Id32<DDLBQTTJVCO> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28C7C00", Offset = "0x28C6400", VA = "0x1828C7C00")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28C9290", Offset = "0x28C7A90", VA = "0x1828C9290")]
		public static void PVPHWVPYVHI(this FunctionCompileState a, Id32<XDQQSNHTXDZ> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28C9A00", Offset = "0x28C8200", VA = "0x1828C9A00")]
		public static void XKBMSIUQUXG(this FunctionCompileState a, Id32<XDQQSNHTXDZ> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28C89B0", Offset = "0x28C71B0", VA = "0x1828C89B0")]
		public static Id32<DataBackResults.M>? LZRHUTVSVGZ([In] this FunctionCompileState self, Id32<XDQQSNHTXDZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28C8400", Offset = "0x28C6C00", VA = "0x1828C8400")]
		public static Id32<DNQUXCYLSXY<HNSTYFIETBH>> IBSQRHODKON([In] this FunctionCompileState self)
		{
			return default(Id32<DNQUXCYLSXY<HNSTYFIETBH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28C77D0", Offset = "0x28C5FD0", VA = "0x1828C77D0")]
		private static void BAROWYSUCSG(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28C8AC0", Offset = "0x28C72C0", VA = "0x1828C8AC0")]
		private static Id32<DNQUXCYLSXY<HNSTYFIETBH>>? NGBCVCIMCGZ([In] this FunctionCompileState self, Id32<DDLBQTTJVCO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28C8740", Offset = "0x28C6F40", VA = "0x1828C8740")]
		public static void KCQCXZAUTYZ(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28C9B20", Offset = "0x28C8320", VA = "0x1828C9B20")]
		public static DataBackResults.Def YETAMDZJQQJ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28C8610", Offset = "0x28C6E10", VA = "0x1828C8610")]
		public static ReadOnlyArray<byte> JEOOOFZHETD([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28C8B40", Offset = "0x28C7340", VA = "0x1828C8B40")]
		public static Id32<LocalVariables.M> NJWDROLSAPN([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28C7AB0", Offset = "0x28C62B0", VA = "0x1828C7AB0")]
		public static Union32 DAIPXWDGDVJ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x39540C0", Offset = "0x39528C0", VA = "0x1839540C0")]
		private static Id32<DataBackResults.M> HBKJFLWXJNW<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.WSHRTVYEHEC
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28C9100", Offset = "0x28C7900", VA = "0x1828C9100")]
		public static Id32<DataBackResults.M> PEPDNTICCCG(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28C8A30", Offset = "0x28C7230", VA = "0x1828C8A30")]
		public static Id32<DataBackResults.M> MPIOWQSQLXP(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28C8380", Offset = "0x28C6B80", VA = "0x1828C8380")]
		public static Id32<DataBackResults.M> HWHFIXKFDKQ(this FunctionCompileState a, Id32<DNQUXCYLSXY<HNSTYFIETBH>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28C9B90", Offset = "0x28C8390", VA = "0x1828C9B90")]
		public static Id32<DataBackResults.M> YNROOUDNRFM(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28C9C10", Offset = "0x28C8410", VA = "0x1828C9C10")]
		public static Id32<DataBackResults.M> ZYZSSQCYZAN(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3954FA0", Offset = "0x39537A0", VA = "0x183954FA0")]
		private static Id32<ExecForwardResults.M> NUQGAMCUNHV<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.WSHRTVYEHEC
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28C94E0", Offset = "0x28C7CE0", VA = "0x1828C94E0")]
		public static Id32<ExecForwardResults.M> SFCAAJAJWXD(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28C8330", Offset = "0x28C6B30", VA = "0x1828C8330")]
		public static Id32<ExecForwardResults.M> GPNEOFVBTMS(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28C7750", Offset = "0x28C5F50", VA = "0x1828C7750")]
		public static Id32<ExecForwardResults.M> AQUZEOSASZM(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28C9320", Offset = "0x28C7B20", VA = "0x1828C9320")]
		public static Id32<ExecForwardResults.M> QGYWAWZPHYP(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28C8920", Offset = "0x28C7120", VA = "0x1828C8920")]
		public static Id32<ExecForwardResults.M> LSADKTKLSLN(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28C8E30", Offset = "0x28C7630", VA = "0x1828C8E30")]
		public static FunctionCalls.Def NQAEZEKHIXK([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28C8970", Offset = "0x28C7170", VA = "0x1828C8970")]
		public static CopyEnumerable<Id32<FunctionCalls.TPAVREQRGIC>, Id32Enumerator<FunctionCalls.TPAVREQRGIC>> LZKKXKFBEUJ([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.TPAVREQRGIC>, Id32Enumerator<FunctionCalls.TPAVREQRGIC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28C8EA0", Offset = "0x28C76A0", VA = "0x1828C8EA0")]
		public static Id32<FunctionCalls.TPAVREQRGIC> NYYBYUALPBC([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.TPAVREQRGIC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28C7B90", Offset = "0x28C6390", VA = "0x1828C7B90")]
		public static FunctionCalls.IO DQMJEVDCQWZ([In] this FunctionCompileState self, Id32<FunctionCalls.TPAVREQRGIC> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28C88B0", Offset = "0x28C70B0", VA = "0x1828C88B0")]
		public static FunctionCalls.IO KWNEJHVFAEJ(this FunctionCompileState a, Id32<FunctionCalls.TPAVREQRGIC> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x39546D0", Offset = "0x3952ED0", VA = "0x1839546D0")]
		private static Id32<FunctionCalls.M> LIKKPTJVGJM<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.WSHRTVYEHEC
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28C8C80", Offset = "0x28C7480", VA = "0x1828C8C80")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>) NPKNWCXRDTF(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28C9520", Offset = "0x28C7D20", VA = "0x1828C9520")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>) SLTUUVOFGKR(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28C9AD0", Offset = "0x28C82D0", VA = "0x1828C9AD0")]
		public static Id32<FunctionCalls.M> XTKVIVPRKDI(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28C7A20", Offset = "0x28C6220", VA = "0x1828C7A20")]
		public static void CFGGEVZZAGX(this FunctionCompileState a, Id32<FunctionCalls.TPAVREQRGIC> b, Id32<DNQUXCYLSXY<HNSTYFIETBH>> c, Id32<DNQUXCYLSXY<EIZFQRKEDAI>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3955040", Offset = "0x3953840", VA = "0x183955040")]
		public static GenerateDataBackResult PYRLFGIHGBF<d, e>(this FunctionCompileState a, d b, e c, Id32<HGNGXYZABBE> d, Id32<DDLBQTTJVCO> e) where d : AGAWTSGPFNV<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3953C60", Offset = "0x3952460", VA = "0x183953C60")]
		public static GenerateDataBackFromInputIndexResult FQHHETIJVXF<f, g>(this FunctionCompileState a, f b, g c, Id32<HGNGXYZABBE> d, Id32<XEUKGISKBDU> e, int f) where f : AGAWTSGPFNV<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3954160", Offset = "0x3952960", VA = "0x183954160")]
		public static Id32<DataBackResults.M>? JXMHCZJQUOS<h, i>(this FunctionCompileState a, h b, i c, Id32<HGNGXYZABBE> d, Id32<XEUKGISKBDU> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : AGAWTSGPFNV<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3954760", Offset = "0x3952F60", VA = "0x183954760")]
		public static Id32<ExecForwardResults.M> MEOSAHWFUPM<j, k>(this FunctionCompileState a, j b, k c, Id32<HGNGXYZABBE> d, Id32<XDQQSNHTXDZ> e) where j : AGAWTSGPFNV<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x28C96D0", Offset = "0x28C7ED0", VA = "0x1828C96D0")]
		public static LocalVariables.ArgumentInst UUJNEKOCHWS([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28C97E0", Offset = "0x28C7FE0", VA = "0x1828C97E0")]
		public static LocalVariables.CalleeReturnValueInst UXXIZUOUHOK([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28C9180", Offset = "0x28C7980", VA = "0x1828C9180")]
		public static LocalVariables.CallerReturnValueInst PVBGKIOUVER([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28C8460", Offset = "0x28C6C60", VA = "0x1828C8460")]
		public static Id32<LocalVariables.M> IPXVNQGUPGT(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28C93D0", Offset = "0x28C7BD0", VA = "0x1828C93D0")]
		public static LocalVariables.ParameterInst RYQCZXLLIRG([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28C7FB0", Offset = "0x28C67B0", VA = "0x1828C7FB0")]
		public static LocalVariables.Def FEENXHQRFII([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28C86F0", Offset = "0x28C6EF0", VA = "0x1828C86F0")]
		public static int? JGUHLANFMPY([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3953B60", Offset = "0x3952360", VA = "0x183953B60")]
		private static Id32<LocalVariables.M> DBDWKXEKTVI<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.WSHRTVYEHEC
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28C7970", Offset = "0x28C6170", VA = "0x1828C7970")]
		public static Id32<LocalVariables.M> BGJINZLZOSM(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28C8C20", Offset = "0x28C7420", VA = "0x1828C8C20")]
		public static Id32<LocalVariables.M> NMFUNXRGCEP(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28C81B0", Offset = "0x28C69B0", VA = "0x1828C81B0")]
		public static Id32<LocalVariables.M> GJRWIZKLXAF(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28C9070", Offset = "0x28C7870", VA = "0x1828C9070")]
		public static Id32<LocalVariables.M> OUZTDAVTRMJ(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28C9370", Offset = "0x28C7B70", VA = "0x1828C9370")]
		public static Id32<LocalVariables.M> RAQZFIANRGJ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28C8000", Offset = "0x28C6800", VA = "0x1828C8000")]
		public static void FLUKCIXAXTY(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28C98F0", Offset = "0x28C80F0", VA = "0x1828C98F0")]
		public static void WHKXJRCBTOC(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28C76A0", Offset = "0x28C5EA0", VA = "0x1828C76A0")]
		public static void AMHGFTZOTDM(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28C8120", Offset = "0x28C6920", VA = "0x1828C8120")]
		public static void GAIYIMRNMFD(this FunctionCompileState a, Id32<DNQUXCYLSXY<HNSTYFIETBH>> b, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28C7ED0", Offset = "0x28C66D0", VA = "0x1828C7ED0")]
		public static void ELQANTFMYOB(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<DNQUXCYLSXY<VJKOEGYQQCQ>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3956570", Offset = "0x3954D70", VA = "0x183956570")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C05010", Offset = "0x3C03810", VA = "0x183C05010")]
		public static Id32<LocalVariables.M?> FUXRIVWJWUJ<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C064F0", Offset = "0x3C04CF0", VA = "0x183C064F0")]
		public static Id32<LocalVariables.M?> LQVOUIZCKOI<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C06860", Offset = "0x3C05060", VA = "0x183C06860")]
		public static Id32<LocalVariables.M?> MQNVOWRIMHP<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x28CE0B0", Offset = "0x28CC8B0", VA = "0x1828CE0B0")]
		public static Id32<LocalVariables.M> RCFAQZHMYVV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x28CA800", Offset = "0x28C9000", VA = "0x1828CA800")]
		public static Id32<LocalVariables.M> CAWLVGIOKMI(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x28CB270", Offset = "0x28C9A70", VA = "0x1828CB270")]
		public static Id32<LocalVariables.M> FERCHPSKKCJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x28CB570", Offset = "0x28C9D70", VA = "0x1828CB570")]
		public static Id32<LocalVariables.M> FTWIUFGYYVL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x28CF290", Offset = "0x28CDA90", VA = "0x1828CF290")]
		public static Id32<LocalVariables.M> UOEAQPTRKLU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28CA340", Offset = "0x28C8B40", VA = "0x1828CA340")]
		public static Id32<LocalVariables.M> ALMMHBTQQLR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x28CF000", Offset = "0x28CD800", VA = "0x1828CF000")]
		public static Id32<LocalVariables.M> TTJHYEPXGRB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x28CEEE0", Offset = "0x28CD6E0", VA = "0x1828CEEE0")]
		public static Id32<LocalVariables.M> TQTCCJHIEKY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x28CAA90", Offset = "0x28C9290", VA = "0x1828CAA90")]
		public static Id32<LocalVariables.M> CZWVUBKNGND(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x28CC3C0", Offset = "0x28CABC0", VA = "0x1828CC3C0")]
		public static Id32<LocalVariables.M> KPQUPGISZJO(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x28CC5E0", Offset = "0x28CADE0", VA = "0x1828CC5E0")]
		public static Id32<LocalVariables.M> KSSXSHYPYVR(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28CB970", Offset = "0x28CA170", VA = "0x1828CB970")]
		public static Id32<LocalVariables.M> GVFRZKWEHAC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28CB670", Offset = "0x28C9E70", VA = "0x1828CB670")]
		public static Id32<LocalVariables.M> GLWSPGPQMSV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28CC290", Offset = "0x28CAA90", VA = "0x1828CC290")]
		public static Id32<LocalVariables.M> KIVRKRSWNMC(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28CA6A0", Offset = "0x28C8EA0", VA = "0x1828CA6A0")]
		public static Id32<LocalVariables.M> AYKESWGADFN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28CF210", Offset = "0x28CDA10", VA = "0x1828CF210")]
		public static Id32<LocalVariables.M> TYGUNVQQAMF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28CD6D0", Offset = "0x28CBED0", VA = "0x1828CD6D0")]
		public static Id32<LocalVariables.M> NGGPJCJXFNU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28CB1F0", Offset = "0x28C99F0", VA = "0x1828CB1F0")]
		public static Id32<LocalVariables.M> EZFLRKWZLHF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28CDE50", Offset = "0x28CC650", VA = "0x1828CDE50")]
		public static Id32<LocalVariables.M> QBDPPWPNVSQ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28CF730", Offset = "0x28CDF30", VA = "0x1828CF730")]
		public static Id32<LocalVariables.M> WYAJTVCTIGL(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28CCE20", Offset = "0x28CB620", VA = "0x1828CCE20")]
		public static Id32<LocalVariables.M> MAUABKEZUKW(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28CEC60", Offset = "0x28CD460", VA = "0x1828CEC60")]
		public static Id32<LocalVariables.M> THXHKGYQHIK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28CAA10", Offset = "0x28C9210", VA = "0x1828CAA10")]
		public static Id32<LocalVariables.M> CYHTIMVTNJL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28CB170", Offset = "0x28C9970", VA = "0x1828CB170")]
		public static Id32<LocalVariables.M> EKJQSHWOKUY(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28CE520", Offset = "0x28CCD20", VA = "0x1828CE520")]
		public static Id32<LocalVariables.M> SMNVKYNIRQT(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28CCFE0", Offset = "0x28CB7E0", VA = "0x1828CCFE0")]
		public static Id32<LocalVariables.M> MQUPULYUJSQ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28CB4F0", Offset = "0x28C9CF0", VA = "0x1828CB4F0")]
		public static Id32<LocalVariables.M> FKREYSCRUKF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28CECE0", Offset = "0x28CD4E0", VA = "0x1828CECE0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> TJEYKYUEQFR(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28CCDA0", Offset = "0x28CB5A0", VA = "0x1828CCDA0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> LQGGOHDPWAP(this FunctionCompileState a, int b)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28CF610", Offset = "0x28CDE10", VA = "0x1828CF610")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> VNXONKXCYWI(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28CACF0", Offset = "0x28C94F0", VA = "0x1828CACF0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> DNBWSYVSXYA(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28CF7B0", Offset = "0x28CDFB0", VA = "0x1828CF7B0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> ZVAMBQWEMGY(this FunctionCompileState a, int b)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28CE010", Offset = "0x28CC810", VA = "0x1828CE010")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> QVEGGFFJQHB(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28CC700", Offset = "0x28CAF00", VA = "0x1828CC700")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>) KTIMUZVTKCE(this FunctionCompileState a, Id32<TTSTDRWIEBX> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28CE6C0", Offset = "0x28CCEC0", VA = "0x1828CE6C0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>) STKPGVKNZAO(this FunctionCompileState a, Id32<JQFETOMIQRN> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TPAVREQRGIC>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C06250", Offset = "0x3C04A50", VA = "0x183C06250")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<MLQMNZEWPGO>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<TMarker>>, Id32<FunctionCalls.M>) HHHAWQAIHHL<TMarker>(this FunctionCompileState a, Id32<MLQMNZEWPGO> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<MLQMNZEWPGO>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28CBD20", Offset = "0x28CA520", VA = "0x1828CBD20")]
		public static Id32<LocalVariables.M> IXGNPXDMYAN(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28CA920", Offset = "0x28C9120", VA = "0x1828CA920")]
		public static Id32<LocalVariables.M> CFGILDWUDCC(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28CD750", Offset = "0x28CBF50", VA = "0x1828CD750")]
		public static Id32<LocalVariables.M> NGNRYRXSNLJ(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28CA580", Offset = "0x28C8D80", VA = "0x1828CA580")]
		public static Id32<LocalVariables.M> AOUXTGGZSII(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x28CB770", Offset = "0x28C9F70", VA = "0x1828CB770")]
		public static Id32<LocalVariables.M> GPRUDZOHMBR(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28CABD0", Offset = "0x28C93D0", VA = "0x1828CABD0")]
		public static Id32<LocalVariables.M> DMSWTFXXQCI(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28CAEF0", Offset = "0x28C96F0", VA = "0x1828CAEF0")]
		public static Id32<LocalVariables.M> DOWKJHGGMMJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28CA480", Offset = "0x28C8C80", VA = "0x1828CA480")]
		public static Id32<LocalVariables.M> ANZGGKMPWWN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28CC4C0", Offset = "0x28CACC0", VA = "0x1828CC4C0")]
		public static Id32<LocalVariables.M> KSBIEJFFBBY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28CF4D0", Offset = "0x28CDCD0", VA = "0x1828CF4D0")]
		public static Id32<LocalVariables.M> VDYXZMYMURR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28CF6B0", Offset = "0x28CDEB0", VA = "0x1828CF6B0")]
		public static Id32<LocalVariables.M> WIZMYEGEAXI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28CD840", Offset = "0x28CC040", VA = "0x1828CD840")]
		public static Id32<LocalVariables.M> NVPAWUSYCTT(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28CBDE0", Offset = "0x28CA5E0", VA = "0x1828CBDE0")]
		public static Id32<LocalVariables.M> JQOVOEPOWGM(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28CCCA0", Offset = "0x28CB4A0", VA = "0x1828CCCA0")]
		public static Id32<LocalVariables.M> KYZHLQAQTTS(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28CDBE0", Offset = "0x28CC3E0", VA = "0x1828CDBE0")]
		public static Id32<LocalVariables.M> PMPHURGXQPN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28CB3B0", Offset = "0x28C9BB0", VA = "0x1828CB3B0")]
		public static Id32<LocalVariables.M> FJBFBBJZETY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x28CCBA0", Offset = "0x28CB3A0", VA = "0x1828CCBA0")]
		public static Id32<LocalVariables.M> KUJWMOVTYFX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x28CE300", Offset = "0x28CCB00", VA = "0x1828CE300")]
		public static Id32<LocalVariables.M> SAQRSQJEDHU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28CBBD0", Offset = "0x28CA3D0", VA = "0x1828CBBD0")]
		public static Id32<LocalVariables.M> IMAVIDTZKSP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28CA7E0", Offset = "0x28C8FE0", VA = "0x1828CA7E0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>> BVSRKAPFBIZ(this FunctionCompileState a)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x28CE420", Offset = "0x28CCC20", VA = "0x1828CE420")]
		public static Id32<LocalVariables.M> SCDRCGBILVM(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x28CF3B0", Offset = "0x28CDBB0", VA = "0x1828CF3B0")]
		public static Id32<LocalVariables.M> UWLJKKUPTJX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28CCEA0", Offset = "0x28CB6A0", VA = "0x1828CCEA0")]
		public static Id32<LocalVariables.M> MAZSEYPPUBW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x28CB870", Offset = "0x28CA070", VA = "0x1828CB870")]
		public static Id32<LocalVariables.M> GSOEBPMFBHG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28CE5A0", Offset = "0x28CCDA0", VA = "0x1828CE5A0")]
		public static Id32<LocalVariables.M> SMWRYIULJWP(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x28CB030", Offset = "0x28C9830", VA = "0x1828CB030")]
		public static Id32<LocalVariables.M> EJXPBFGZFQO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28CD8C0", Offset = "0x28CC0C0", VA = "0x1828CD8C0")]
		public static Id32<LocalVariables.M> NYHOBEDASOT(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28CF100", Offset = "0x28CD900", VA = "0x1828CF100")]
		public static Id32<LocalVariables.M> TUSTINFURDW(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28CBD10", Offset = "0x28CA510", VA = "0x1828CBD10")]
		public static void IVELIJNDJDH(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28CDAE0", Offset = "0x28CC2E0", VA = "0x1828CDAE0")]
		public static Id32<LocalVariables.M> PKWUMEXYOEO(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x28CBAB0", Offset = "0x28CA2B0", VA = "0x1828CBAB0")]
		public static Id32<LocalVariables.M> HALLINOKVQF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x28CD060", Offset = "0x28CB860", VA = "0x1828CD060")]
		public static Id32<LocalVariables.M> MQZIFLRZQOY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x28CEB60", Offset = "0x28CD360", VA = "0x1828CEB60")]
		public static Id32<LocalVariables.M> TFAIDSCFBBW(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28CD5B0", Offset = "0x28CBDB0", VA = "0x1828CD5B0")]
		public static Id32<LocalVariables.M> MYRVKDECNZN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28CDD10", Offset = "0x28CC510", VA = "0x1828CDD10")]
		public static Id32<LocalVariables.M> PQHXBMAUJZA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28CD1A0", Offset = "0x28CB9A0", VA = "0x1828CD1A0")]
		public static Id32<LocalVariables.M> MVBXMGWONEK(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28CC190", Offset = "0x28CA990", VA = "0x1828CC190")]
		public static Id32<LocalVariables.M> KHRQORSDPIT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28CD9C0", Offset = "0x28CC1C0", VA = "0x1828CD9C0")]
		public static Id32<LocalVariables.M> OEGYVKWWQFG(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28CDED0", Offset = "0x28CC6D0", VA = "0x1828CDED0")]
		public static Id32<LocalVariables.M> QCYKQBHKDQF(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3C06CB0", Offset = "0x3C054B0", VA = "0x183C06CB0")]
		public static void RWGWASKIDUA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<TTSTDRWIEBX> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3C07460", Offset = "0x3C05C60", VA = "0x183C07460")]
		public static void TPKVFUQPSWC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<JQFETOMIQRN> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3C06990", Offset = "0x3C05190", VA = "0x183C06990")]
		public static Id32<LocalVariables.M> NTODCPPRDWM<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3C04940", Offset = "0x3C03140", VA = "0x183C04940")]
		public static Id32<LocalVariables.M> CJXILBWJEJT<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3C05DF0", Offset = "0x3C045F0", VA = "0x183C05DF0")]
		public static Id32<DataBackResults.M> GRVJELEKEBI<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, AGAWTSGPFNV<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3C083D0", Offset = "0x3C06BD0", VA = "0x183C083D0")]
		public static Id32<ExecForwardResults.M> VXDLRRNLRBT<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, AGAWTSGPFNV<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28CE1B0", Offset = "0x28CC9B0", VA = "0x1828CE1B0")]
		public static Id32<DataBackResults.M> RLKSZZEKPCD(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28CBE60", Offset = "0x28CA660", VA = "0x1828CBE60")]
		public static Id32<DataBackResults.M> JVNYLEWOXRD(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3C05470", Offset = "0x3C03C70", VA = "0x183C05470")]
		public static Id32<DataBackResults.M> GAJTYDPUIYA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<TTSTDRWIEBX> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3C05200", Offset = "0x3C03A00", VA = "0x183C05200")]
		private static Id32<DataBackResults.M> GAJTYDPUIYA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<TTSTDRWIEBX> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3C07F80", Offset = "0x3C06780", VA = "0x183C07F80")]
		public static Id32<LocalVariables.M> UHVKEMFGZDO<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, AGAWTSGPFNV<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3C07C10", Offset = "0x3C06410", VA = "0x183C07C10")]
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
		[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
		public LiveInterval(Id32<DNQUXCYLSXY<HNSTYFIETBH>> firstUse, Id32<DNQUXCYLSXY<HNSTYFIETBH>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28C6040", Offset = "0x28C4840", VA = "0x1828C6040")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C6020", Offset = "0x28C4820", VA = "0x1828C6020")]
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
			[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C6240", Offset = "0x28C4A40", VA = "0x1828C6240")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<AYJPWIOTBNH, ArgumentInst> argumentVariables, [In] SOAId32Field<FIZIZBQCARG, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<INDKLOYBAVD, ParameterInst> parameterVariables, [In] SOAId32Field<TIFIIKPNDXB, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28C6050", Offset = "0x28C4850", VA = "0x1828C6050")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class PGXLJXUSKVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28C6910", Offset = "0x28C5110", VA = "0x1828C6910")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C63C0", Offset = "0x28C4BC0", VA = "0x1828C63C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C4A70", Offset = "0x28C3270", VA = "0x1828C4A70")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.TPAVREQRGIC, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28C4A00", Offset = "0x28C3200", VA = "0x1828C4A00")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28C47E0", Offset = "0x28C2FE0", VA = "0x1828C47E0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x330DD40", Offset = "0x330C540", VA = "0x18330DD40")]
		public static void UGAONVMMAWY<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<HGNGXYZABBE> graphId) where TDeps : notnull, AGAWTSGPFNV<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class REOGZNKVPUP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28C9C90", Offset = "0x28C8490", VA = "0x1828C9C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C7560", Offset = "0x28C5D60", VA = "0x1828C7560", Slot = "4")]
			public void SSLEOOQCPGL(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : UFTPTVPYRGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x28C75F0", Offset = "0x28C5DF0", VA = "0x1828C75F0", Slot = "4")]
			public void SSLEOOQCPGL(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : UFTPTVPYRGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x28C7420", Offset = "0x28C5C20", VA = "0x1828C7420", Slot = "4")]
			public void SSLEOOQCPGL(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : UFTPTVPYRGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x28C74B0", Offset = "0x28C5CB0", VA = "0x1828C74B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x361C950", Offset = "0x361B150", VA = "0x18361C950")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C5FD0", Offset = "0x28C47D0", VA = "0x1828C5FD0")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<FunctionCalls.TPAVREQRGIC>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28C5F20", Offset = "0x28C4720", VA = "0x1828C5F20")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28C5EE0", Offset = "0x28C46E0", VA = "0x1828C5EE0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x370B2F0", Offset = "0x3709AF0", VA = "0x18370B2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C6E70", Offset = "0x28C5670", VA = "0x1828C6E70")]
		public static void UGAONVMMAWY(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28C6B00", Offset = "0x28C5300", VA = "0x1828C6B00")]
		private static void KIQUSWXRYGR([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28C69C0", Offset = "0x28C51C0", VA = "0x1828C69C0")]
		private static void KIQUSWXRYGR(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28C6D10", Offset = "0x28C5510", VA = "0x1828C6D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C97080", Offset = "0x4C95880", VA = "0x184C97080")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C9A4B0", Offset = "0x4C98CB0", VA = "0x184C9A4B0")]
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
