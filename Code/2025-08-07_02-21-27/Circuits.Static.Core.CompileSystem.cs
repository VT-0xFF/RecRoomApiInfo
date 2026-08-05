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
		[Cpp2IlInjected.Address(RVA = "0x2DE5250", Offset = "0x2DE3E50", VA = "0x182DE5250")]
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
namespace Circuits.Static.Core.CompileSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct ByteCodeAdjustment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly Id32<URLPKZCBIQI<PCOBNQTLDEG>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		public ByteCodeAdjustment(Id32<URLPKZCBIQI<PCOBNQTLDEG>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class MRHOWFDMYNS : JDRZXAZSAPS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2D841D0", Offset = "0x2D82DD0", VA = "0x182D841D0")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0E70", Offset = "0x2DDFA70", VA = "0x182DE0E70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class XABNLECPTMX : JDRZXAZSAPS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<URLPKZCBIQI<JTNRDUJMXAD>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
			public DeadEnd(Id32<URLPKZCBIQI<JTNRDUJMXAD>> nextByteCodePtr)
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
		public abstract class JDRZXAZSAPS
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
			public readonly Id32<JDRZXAZSAPS> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
			public Inst(Def def, Id32<JDRZXAZSAPS> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class EVLLBGSXIYA : JDRZXAZSAPS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class ZEOLEERPONM : JDRZXAZSAPS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2C47080", Offset = "0x2C45C80", VA = "0x182C47080", Slot = "3")]
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
		internal IdUnsafeList<MRHOWFDMYNS, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<XABNLECPTMX, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<EVLLBGSXIYA, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<ZEOLEERPONM, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2DE1120", Offset = "0x2DDFD20", VA = "0x182DE1120")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<MRHOWFDMYNS, BytesImmediate> bytesImmediates, [In] IdUnsafeList<XABNLECPTMX, DeadEnd> deadEnds, [In] IdUnsafeList<EVLLBGSXIYA, Variable> variables, [In] IdUnsafeList<ZEOLEERPONM, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0FE0", Offset = "0x2DDFBE0", VA = "0x182DE0FE0")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class URGMHPLUJLR
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2DEB080", Offset = "0x2DE9C80", VA = "0x182DEB080")]
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
		public sealed class WQALJBABLWL : JDRZXAZSAPS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
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
		public abstract class JDRZXAZSAPS
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
			public readonly Id32<JDRZXAZSAPS> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
			public Inst(Def def, Id32<JDRZXAZSAPS> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<WQALJBABLWL, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2DE1240", Offset = "0x2DDFE40", VA = "0x182DE1240")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<WQALJBABLWL, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2DE11B0", Offset = "0x2DDFDB0", VA = "0x182DE11B0")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class AEBRYKBNDPW
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2DDFFA0", Offset = "0x2DDEBA0", VA = "0x182DDFFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DE1320", Offset = "0x2DDFF20", VA = "0x182DE1320")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2DE1280", Offset = "0x2DDFE80", VA = "0x182DE1280")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class CEKIAEFFBWD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0EE0", Offset = "0x2DDFAE0", VA = "0x182DE0EE0")]
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
		public sealed class TTRWTECYFBB : JDRZXAZSAPS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<UHPDBSPWOPW> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
			public ExternalCall(Id32<UHPDBSPWOPW> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class JDRZXAZSAPS
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
			public readonly Id32<JDRZXAZSAPS> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
			private Inst(Def def, Id32<JDRZXAZSAPS> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2DE26A0", Offset = "0x2DE12A0", VA = "0x182DE26A0")]
			public static Inst New(Def def, Id32<JDRZXAZSAPS> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class NKBGEIDLZEZ : JDRZXAZSAPS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<UHPDBSPWOPW> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
			public InternalCall(Id32<UHPDBSPWOPW> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class UHPDBSPWOPW
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
			[Cpp2IlInjected.Address(RVA = "0x2DE1240", Offset = "0x2DDFE40", VA = "0x182DE1240")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2DE24F0", Offset = "0x2DE10F0", VA = "0x182DE24F0")]
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
		internal IdUnsafeList<NKBGEIDLZEZ, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<TTRWTECYFBB, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<UHPDBSPWOPW> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<UHPDBSPWOPW, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2DE1520", Offset = "0x2DE0120", VA = "0x182DE1520")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<NKBGEIDLZEZ, InternalCall> internalCalls, [In] IdUnsafeList<TTRWTECYFBB, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<UHPDBSPWOPW> IOId)> callsWithIO, [In] IdUnsafeList<UHPDBSPWOPW, IO> io, [In] SOAField<UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> ioModifyingCallLocations, [In] SOAField<UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2DE1380", Offset = "0x2DDFF80", VA = "0x182DE1380")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class NNKUFJNBHPX
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4FF0", Offset = "0x2DE3BF0", VA = "0x182DE4FF0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5040", Offset = "0x2DE3C40", VA = "0x182DE5040")]
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
		internal SOAField<IEQQYWIVYHH, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<IEQQYWIVYHH>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2DE1F70", Offset = "0x2DE0B70", VA = "0x182DE1F70")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<IEQQYWIVYHH, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<IEQQYWIVYHH>> generatedOutputsForExpression, [In] SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2DE15E0", Offset = "0x2DE01E0", VA = "0x182DE15E0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class MQMXTVLMHFE
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : VRIUWUUSQQB<Id32<FunctionCalls.UHPDBSPWOPW>, SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAA50", Offset = "0x2DE9650", VA = "0x182DEAA50")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAAD0", Offset = "0x2DE96D0", VA = "0x182DEAAD0", Slot = "4")]
			public Id32<FunctionCalls.UHPDBSPWOPW> ZAIXHRGXKYZ(int a)
			{
				return default(Id32<FunctionCalls.UHPDBSPWOPW>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0")]
			public bool VJGAGGFLTWX(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "5")]
			private bool YWCIQEZQSPZ(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAA40", Offset = "0x2DE9640", VA = "0x182DEAA40", Slot = "6")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> ECLMPFKLVXM(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : CLOHCEEQPOM<Id32<FunctionCalls.UHPDBSPWOPW>, SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0010", Offset = "0x2DDEC10", VA = "0x182DE0010")]
			public UnsafeList<Id32<FunctionCalls.UHPDBSPWOPW>> JWTFHXCRNVM(int a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UHPDBSPWOPW>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0120", Offset = "0x2DDED20", VA = "0x182DE0120")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0080", Offset = "0x2DDEC80", VA = "0x182DE0080", Slot = "6")]
			public void LBZMPFQNDTA(Id32<FunctionCalls.UHPDBSPWOPW> a, SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> b, Id32<URLPKZCBIQI<PCOBNQTLDEG>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0010", Offset = "0x2DDEC10", VA = "0x182DE0010", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UHPDBSPWOPW>> YWFMQQPCLJT(int a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UHPDBSPWOPW>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0000", Offset = "0x2DDEC00", VA = "0x182DE0000", Slot = "5")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> GRHAKINUDWL(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JTNRDUJMXAD>>> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : VRIUWUUSQQB<Id32<FunctionCalls.UHPDBSPWOPW>, SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAB10", Offset = "0x2DE9710", VA = "0x182DEAB10")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAB90", Offset = "0x2DE9790", VA = "0x182DEAB90", Slot = "4")]
			public Id32<FunctionCalls.UHPDBSPWOPW> ZAIXHRGXKYZ(int a)
			{
				return default(Id32<FunctionCalls.UHPDBSPWOPW>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0")]
			public bool VJGAGGFLTWX(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "5")]
			private bool BJULHEIRPLS(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2DEABD0", Offset = "0x2DE97D0", VA = "0x182DEABD0", Slot = "6")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> ZHJEWNIKKZD(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : CLOHCEEQPOM<Id32<FunctionCalls.UHPDBSPWOPW>, SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2DE01B0", Offset = "0x2DDEDB0", VA = "0x182DE01B0")]
			public UnsafeList<Id32<FunctionCalls.UHPDBSPWOPW>> JWTFHXCRNVM(int a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UHPDBSPWOPW>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2DE02C0", Offset = "0x2DDEEC0", VA = "0x182DE02C0")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0220", Offset = "0x2DDEE20", VA = "0x182DE0220", Slot = "6")]
			public void LBZMPFQNDTA(Id32<FunctionCalls.UHPDBSPWOPW> a, SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> b, Id32<URLPKZCBIQI<PCOBNQTLDEG>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2DE01B0", Offset = "0x2DDEDB0", VA = "0x182DE01B0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UHPDBSPWOPW>> RZRXSKVFYEW(int a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UHPDBSPWOPW>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2DE01A0", Offset = "0x2DDEDA0", VA = "0x182DE01A0", Slot = "5")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> BOGNGWWGPEO(Id32<FunctionCalls.UHPDBSPWOPW> a, [In] SOAField<FunctionCalls.UHPDBSPWOPW, Id32<URLPKZCBIQI<JUWNCHNHAOC>>> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : VRIUWUUSQQB<Id32<AWZVWRTEXTC>, SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAC40", Offset = "0x2DE9840", VA = "0x182DEAC40")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(Id32<AWZVWRTEXTC> a, [In] SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2DEACF0", Offset = "0x2DE98F0", VA = "0x182DEACF0", Slot = "4")]
			public Id32<AWZVWRTEXTC> ZAIXHRGXKYZ(int a)
			{
				return default(Id32<AWZVWRTEXTC>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2DEABE0", Offset = "0x2DE97E0", VA = "0x182DEABE0")]
			public bool VJGAGGFLTWX(Id32<AWZVWRTEXTC> a, [In] SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2DEABE0", Offset = "0x2DE97E0", VA = "0x182DEABE0", Slot = "5")]
			private bool ESLKWOWITHA(Id32<AWZVWRTEXTC> a, [In] SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAD30", Offset = "0x2DE9930", VA = "0x182DEAD30", Slot = "6")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> ZKPFWZMCKJR(Id32<AWZVWRTEXTC> a, [In] SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : CLOHCEEQPOM<Id32<AWZVWRTEXTC>, SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0340", Offset = "0x2DDEF40", VA = "0x182DE0340")]
			public UnsafeList<Id32<AWZVWRTEXTC>> JWTFHXCRNVM(int a, [In] SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> values)
			{
				return default(UnsafeList<Id32<AWZVWRTEXTC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2DE04B0", Offset = "0x2DDF0B0", VA = "0x182DE04B0")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(Id32<AWZVWRTEXTC> a, [In] SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2DE03B0", Offset = "0x2DDEFB0", VA = "0x182DE03B0", Slot = "6")]
			public void LBZMPFQNDTA(Id32<AWZVWRTEXTC> a, SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> b, Id32<URLPKZCBIQI<PCOBNQTLDEG>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0340", Offset = "0x2DDEF40", VA = "0x182DE0340", Slot = "4")]
			private UnsafeList<Id32<AWZVWRTEXTC>> LCUVTBJLXNO(int a, [In] SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> values)
			{
				return default(UnsafeList<Id32<AWZVWRTEXTC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0560", Offset = "0x2DDF160", VA = "0x182DE0560", Slot = "5")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> WUBUVCWSRXW(Id32<AWZVWRTEXTC> a, [In] SOAField<AWZVWRTEXTC, Id32<URLPKZCBIQI<JTNRDUJMXAD>>?> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : VRIUWUUSQQB<int, UnsafeList<(Id32<LocalVariables.M>, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAE90", Offset = "0x2DE9A90", VA = "0x182DEAE90")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xC2A140", Offset = "0xC28D40", VA = "0x180C2A140", Slot = "4")]
			public int ZAIXHRGXKYZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0")]
			public bool VJGAGGFLTWX(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "5")]
			private bool ORCXFHPTOCX(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAE80", Offset = "0x2DE9A80", VA = "0x182DEAE80", Slot = "6")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> SLVKLMOLRLQ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : CLOHCEEQPOM<int, UnsafeList<(Id32<LocalVariables.M>, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0990", Offset = "0x2DDF590", VA = "0x182DE0990")]
			public UnsafeList<int> JWTFHXCRNVM(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0B10", Offset = "0x2DDF710", VA = "0x182DE0B10")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0A00", Offset = "0x2DDF600", VA = "0x182DE0A00", Slot = "6")]
			public void LBZMPFQNDTA(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> values, Id32<URLPKZCBIQI<PCOBNQTLDEG>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0990", Offset = "0x2DDF590", VA = "0x182DE0990", Slot = "4")]
			private UnsafeList<int> WBAODGTCKMT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0B00", Offset = "0x2DDF700", VA = "0x182DE0B00", Slot = "5")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> OFCDMQFFMDX(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<URLPKZCBIQI<NZMKZPVTOGO<PCOBNQTLDEG>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : VRIUWUUSQQB<int, UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2DEADE0", Offset = "0x2DE99E0", VA = "0x182DEADE0")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xC2A140", Offset = "0xC28D40", VA = "0x180C2A140", Slot = "4")]
			public int ZAIXHRGXKYZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0")]
			public bool VJGAGGFLTWX(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "5")]
			private bool IRDYZZLDMBU(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAE70", Offset = "0x2DE9A70", VA = "0x182DEAE70", Slot = "6")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> XNAJTAWHDTN(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : CLOHCEEQPOM<int, UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0780", Offset = "0x2DDF380", VA = "0x182DE0780")]
			public UnsafeList<int> JWTFHXCRNVM(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0900", Offset = "0x2DDF500", VA = "0x182DE0900")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2DE07F0", Offset = "0x2DDF3F0", VA = "0x182DE07F0", Slot = "6")]
			public void LBZMPFQNDTA(int a, UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values, Id32<URLPKZCBIQI<PCOBNQTLDEG>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0780", Offset = "0x2DDF380", VA = "0x182DE0780", Slot = "4")]
			private UnsafeList<int> TEGNEHNKAFM(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2DE08F0", Offset = "0x2DDF4F0", VA = "0x182DE08F0", Slot = "5")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> NJLXMNZOAES(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : VRIUWUUSQQB<int, UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAD40", Offset = "0x2DE9940", VA = "0x182DEAD40")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC2A140", Offset = "0xC28D40", VA = "0x180C2A140", Slot = "4")]
			public int ZAIXHRGXKYZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0")]
			public bool VJGAGGFLTWX(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "5")]
			private bool IRDYZZLDMBU(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2DEADD0", Offset = "0x2DE99D0", VA = "0x182DEADD0", Slot = "6")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> XNAJTAWHDTN(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : CLOHCEEQPOM<int, UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0570", Offset = "0x2DDF170", VA = "0x182DE0570")]
			public UnsafeList<int> JWTFHXCRNVM(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2DE06F0", Offset = "0x2DDF2F0", VA = "0x182DE06F0")]
			public Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2DE05E0", Offset = "0x2DDF1E0", VA = "0x182DE05E0", Slot = "6")]
			public void LBZMPFQNDTA(int a, UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values, Id32<URLPKZCBIQI<PCOBNQTLDEG>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0570", Offset = "0x2DDF170", VA = "0x182DE0570", Slot = "4")]
			private UnsafeList<int> TEGNEHNKAFM(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2DE06E0", Offset = "0x2DDF2E0", VA = "0x182DE06E0", Slot = "5")]
			private Id32<URLPKZCBIQI<PCOBNQTLDEG>> NJLXMNZOAES(int a, [In] UnsafeList<(Id32<URLPKZCBIQI<JTNRDUJMXAD>> Target, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
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
			[Cpp2IlInjected.Address(RVA = "0x2476730", Offset = "0x2475330", VA = "0x182476730")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2DE2310", Offset = "0x2DE0F10", VA = "0x182DE2310")]
			public void SGLQLYIOUSX([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<AWZVWRTEXTC> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2DE22F0", Offset = "0x2DE0EF0", VA = "0x182DE22F0")]
			public GenerateDataBackFromInputIndexResult(Id32<AWZVWRTEXTC> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2DE22C0", Offset = "0x2DE0EC0", VA = "0x182DE22C0")]
			public void SGLQLYIOUSX([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2DE22D0", Offset = "0x2DE0ED0", VA = "0x182DE22D0")]
			public void SGLQLYIOUSX([Out] Id32<DataBackResults.M> a, [Out] Id32<AWZVWRTEXTC> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<AWZVWRTEXTC> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
			public GenerateDataBackFromInputIndicesResult(Id32<AWZVWRTEXTC> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2DE2300", Offset = "0x2DE0F00", VA = "0x182DE2300")]
			public void SGLQLYIOUSX([Out] Id32<DataBackResults.M> a, [Out] Id32<AWZVWRTEXTC> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3320", Offset = "0x2DE1F20", VA = "0x182DE3320")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3DD0", Offset = "0x2DE29D0", VA = "0x182DE3DD0")]
		public static void MDJBYENIJRC(this FunctionCompileState a, Id32<IEQQYWIVYHH> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4C90", Offset = "0x2DE3890", VA = "0x182DE4C90")]
		public static void WPMGUOJAOAG(this FunctionCompileState a, Id32<IEQQYWIVYHH> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4E90", Offset = "0x2DE3A90", VA = "0x182DE4E90")]
		public static Id32<DataBackResults.M>? ZQMZSYDTVKT([In] this FunctionCompileState self, Id32<IEQQYWIVYHH> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2DA0", Offset = "0x2DE19A0", VA = "0x182DE2DA0")]
		public static Id32<URLPKZCBIQI<JTNRDUJMXAD>> COERSQGZCWP([In] this FunctionCompileState self)
		{
			return default(Id32<URLPKZCBIQI<JTNRDUJMXAD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2E00", Offset = "0x2DE1A00", VA = "0x182DE2E00")]
		private static void COKGRGHHFSY(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE36D0", Offset = "0x2DE22D0", VA = "0x182DE36D0")]
		private static Id32<URLPKZCBIQI<JTNRDUJMXAD>>? FYXGCZHWBDB([In] this FunctionCompileState self, Id32<AWZVWRTEXTC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4170", Offset = "0x2DE2D70", VA = "0x182DE4170")]
		public static void PLWGSMDQMLZ(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3C50", Offset = "0x2DE2850", VA = "0x182DE3C50")]
		public static DataBackResults.Def LQQBHITQXZZ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4000", Offset = "0x2DE2C00", VA = "0x182DE4000")]
		public static ReadOnlyArray<byte> OKOFPPCNOAT([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4F10", Offset = "0x2DE3B10", VA = "0x182DE4F10")]
		public static Id32<LocalVariables.M> ZSBJNXJWFIR([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4470", Offset = "0x2DE3070", VA = "0x182DE4470")]
		public static Union32 SHNEVPVDQHT([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D02430", Offset = "0x3D01030", VA = "0x183D02430")]
		private static Id32<DataBackResults.M> ABHUOWFATCW<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.JDRZXAZSAPS
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2FA0", Offset = "0x2DE1BA0", VA = "0x182DE2FA0")]
		public static Id32<DataBackResults.M> CXCASJVFJDS(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3070", Offset = "0x2DE1C70", VA = "0x182DE3070")]
		public static Id32<DataBackResults.M> CZKLMGRWXKT(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3650", Offset = "0x2DE2250", VA = "0x182DE3650")]
		public static Id32<DataBackResults.M> FNPTLURVTLY(this FunctionCompileState a, Id32<URLPKZCBIQI<JTNRDUJMXAD>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2DE37C0", Offset = "0x2DE23C0", VA = "0x182DE37C0")]
		public static Id32<DataBackResults.M> JJYNFPVUNJW(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3AB0", Offset = "0x2DE26B0", VA = "0x182DE3AB0")]
		public static Id32<DataBackResults.M> LFNQFAHXFDF(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D034A0", Offset = "0x3D020A0", VA = "0x183D034A0")]
		private static Id32<ExecForwardResults.M> QTNLSOXZFBL<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.JDRZXAZSAPS
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3F70", Offset = "0x2DE2B70", VA = "0x182DE3F70")]
		public static Id32<ExecForwardResults.M> NQVALPCBQTJ(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3A60", Offset = "0x2DE2660", VA = "0x182DE3A60")]
		public static Id32<ExecForwardResults.M> LBKFPFWGQGI(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2DE43F0", Offset = "0x2DE2FF0", VA = "0x182DE43F0")]
		public static Id32<ExecForwardResults.M> RSNFYUEYXBW(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3020", Offset = "0x2DE1C20", VA = "0x182DE3020")]
		public static Id32<ExecForwardResults.M> CXRBKEBVVOV(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4E40", Offset = "0x2DE3A40", VA = "0x182DE4E40")]
		public static Id32<ExecForwardResults.M> YSHMPTVBEBH(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4950", Offset = "0x2DE3550", VA = "0x182DE4950")]
		public static FunctionCalls.Def VHMIPPKTTXM([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE49C0", Offset = "0x2DE35C0", VA = "0x182DE49C0")]
		public static CopyEnumerable<Id32<FunctionCalls.UHPDBSPWOPW>, Id32Enumerator<FunctionCalls.UHPDBSPWOPW>> VIXGYZRWWVJ([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.UHPDBSPWOPW>, Id32Enumerator<FunctionCalls.UHPDBSPWOPW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3890", Offset = "0x2DE2490", VA = "0x182DE3890")]
		public static Id32<FunctionCalls.UHPDBSPWOPW> KZCTNPWGIDE([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.UHPDBSPWOPW>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3100", Offset = "0x2DE1D00", VA = "0x182DE3100")]
		public static FunctionCalls.IO DBUEILXAKXB([In] this FunctionCompileState self, Id32<FunctionCalls.UHPDBSPWOPW> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3750", Offset = "0x2DE2350", VA = "0x182DE3750")]
		public static FunctionCalls.IO GMHHHJYVZVZ(this FunctionCompileState a, Id32<FunctionCalls.UHPDBSPWOPW> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D02A30", Offset = "0x3D01630", VA = "0x183D02A30")]
		private static Id32<FunctionCalls.M> HKTQOCJPPXS<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.JDRZXAZSAPS
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4550", Offset = "0x2DE3150", VA = "0x182DE4550")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UHPDBSPWOPW>) SQAPXEPQSBH(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UHPDBSPWOPW>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2A50", Offset = "0x2DE1650", VA = "0x182DE2A50")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UHPDBSPWOPW>) BQKDDBPYJNF(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UHPDBSPWOPW>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3FB0", Offset = "0x2DE2BB0", VA = "0x182DE3FB0")]
		public static Id32<FunctionCalls.M> OHVEYJGDUXC(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2DE40E0", Offset = "0x2DE2CE0", VA = "0x182DE40E0")]
		public static void ONAMBMIGIPD(this FunctionCompileState a, Id32<FunctionCalls.UHPDBSPWOPW> b, Id32<URLPKZCBIQI<JTNRDUJMXAD>> c, Id32<URLPKZCBIQI<JUWNCHNHAOC>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D03640", Offset = "0x3D02240", VA = "0x183D03640")]
		public static GenerateDataBackResult TIMIAQSSOWN<d, e>(this FunctionCompileState a, d b, e c, Id32<JQPVMRMCZNG> d, Id32<AWZVWRTEXTC> e) where d : MQMDYMTPLDL<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D04A40", Offset = "0x3D03640", VA = "0x183D04A40")]
		public static GenerateDataBackFromInputIndexResult YNLWPQCJTZX<f, g>(this FunctionCompileState a, f b, g c, Id32<JQPVMRMCZNG> d, Id32<LWYTCPIHOQE> e, int f) where f : MQMDYMTPLDL<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3D024D0", Offset = "0x3D010D0", VA = "0x183D024D0")]
		public static Id32<DataBackResults.M>? FJHADGKFFTC<h, i>(this FunctionCompileState a, h b, i c, Id32<JQPVMRMCZNG> d, Id32<LWYTCPIHOQE> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : MQMDYMTPLDL<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3D02C80", Offset = "0x3D01880", VA = "0x183D02C80")]
		public static Id32<ExecForwardResults.M> PCWLKKDPKME<j, k>(this FunctionCompileState a, j b, k c, Id32<JQPVMRMCZNG> d, Id32<IEQQYWIVYHH> e) where j : MQMDYMTPLDL<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4840", Offset = "0x2DE3440", VA = "0x182DE4840")]
		public static LocalVariables.ArgumentInst UYXRWGMFURK([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3E60", Offset = "0x2DE2A60", VA = "0x182DE3E60")]
		public static LocalVariables.CalleeReturnValueInst NDQFYYMXSYA([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2C90", Offset = "0x2DE1890", VA = "0x182DE2C90")]
		public static LocalVariables.CallerReturnValueInst CODUFBJGQBN([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3170", Offset = "0x2DE1D70", VA = "0x182DE3170")]
		public static Id32<LocalVariables.M> DKHUPCGKZUV(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4B80", Offset = "0x2DE3780", VA = "0x182DE4B80")]
		public static LocalVariables.ParameterInst WFKOVKTPPOC([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3840", Offset = "0x2DE2440", VA = "0x182DE3840")]
		public static LocalVariables.Def JUYSYWHBFQO([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2A00", Offset = "0x2DE1600", VA = "0x182DE2A00")]
		public static int? BKOYOZHQXEY([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3D03540", Offset = "0x3D02140", VA = "0x183D03540")]
		private static Id32<LocalVariables.M> RYKXTRIYZAA<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.JDRZXAZSAPS
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2DE42E0", Offset = "0x2DE2EE0", VA = "0x182DE42E0")]
		public static Id32<LocalVariables.M> QOJKYGSXLUK(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2DE35F0", Offset = "0x2DE21F0", VA = "0x182DE35F0")]
		public static Id32<LocalVariables.M> EOSTCMXOLWR(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4A00", Offset = "0x2DE3600", VA = "0x182DE4A00")]
		public static Id32<LocalVariables.M> VXOMSGSKQKD(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2DE47B0", Offset = "0x2DE33B0", VA = "0x182DE47B0")]
		public static Id32<LocalVariables.M> SZHCEIHZCUL(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4390", Offset = "0x2DE2F90", VA = "0x182DE4390")]
		public static Id32<LocalVariables.M> ROAOFMYJNPZ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3B30", Offset = "0x2DE2730", VA = "0x182DE3B30")]
		public static void LPPHEXSJIJG(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3CC0", Offset = "0x2DE28C0", VA = "0x182DE3CC0")]
		public static void LUBQXDNRRNO(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4700", Offset = "0x2DE3300", VA = "0x182DE4700")]
		public static void SXKEPZZCYNK(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2C00", Offset = "0x2DE1800", VA = "0x182DE2C00")]
		public static void CFMYOLUZKPN(this FunctionCompileState a, Id32<URLPKZCBIQI<JTNRDUJMXAD>> b, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4D60", Offset = "0x2DE3960", VA = "0x182DE4D60")]
		public static void XZRSELLTMZZ(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<URLPKZCBIQI<DGVAYPZQLZQ>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3D02BA0", Offset = "0x3D017A0", VA = "0x183D02BA0")]
		public static void NXKFXNATKAI<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<URLPKZCBIQI<NZMKZPVTOGO<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface MQMDYMTPLDL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<GEBYEJADWWU> RLAZKCMWWSS(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<GEBYEJADWWU> EASBXOFHLVN(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<GEBYEJADWWU> QYWIUSIACBK(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<GEBYEJADWWU> DXIKWZQRDAX(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> LWKQPMNDYOR(a a, FunctionCompileState b, Id32<JQPVMRMCZNG> c, Id32<AWZVWRTEXTC> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> DEWNAYVATHJ(a a, FunctionCompileState b, Id32<JQPVMRMCZNG> c, Id32<IEQQYWIVYHH> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int BGTRTFBXPTV(a a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<IEQQYWIVYHH> NWFFHGCHLHK(a a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind WNBNWPXRIZT(a a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool RROHYMCBKLU(a a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int PSYAZVNNBVB(a a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> EGKVVJNKMAN(a a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<GEBYEJADWWU>) FREBOXVFLPN(a a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int PFPRFGCHMMF(a a, Id32<JQPVMRMCZNG> b, Id32<IEQQYWIVYHH> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<AWZVWRTEXTC> IAOGNETHDIQ(a a, Id32<JQPVMRMCZNG> b, Id32<IEQQYWIVYHH> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<AWZVWRTEXTC> CCSXLJXNYIF(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int PESXKOMJQFL(a a, Id32<JQPVMRMCZNG> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? EIKTBOUTKEJ(a a, Id32<JQPVMRMCZNG> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int JCGGPEUTMTN(a a, Id32<JQPVMRMCZNG> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? XBAHZGSVDMT(a a, Id32<JQPVMRMCZNG> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class RBDSZTYBCQQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3F14CB0", Offset = "0x3F138B0", VA = "0x183F14CB0")]
		public static Id32<LocalVariables.M?> NMSBEEUTLJF<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3F126B0", Offset = "0x3F112B0", VA = "0x183F126B0")]
		public static Id32<LocalVariables.M?> DBTJEXJCSWO<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F139A0", Offset = "0x3F125A0", VA = "0x183F139A0")]
		public static Id32<LocalVariables.M?> HORPAOGKWKD<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA940", Offset = "0x2DE9540", VA = "0x182DEA940")]
		public static Id32<LocalVariables.M> ZTRMRFRXHNT(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA3A0", Offset = "0x2DE8FA0", VA = "0x182DEA3A0")]
		public static Id32<LocalVariables.M> YRTKSUKHBYS(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5D10", Offset = "0x2DE4910", VA = "0x182DE5D10")]
		public static Id32<LocalVariables.M> ENMATPOKDXF(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2DE81F0", Offset = "0x2DE6DF0", VA = "0x182DE81F0")]
		public static Id32<LocalVariables.M> OJATHXHRULR(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8B50", Offset = "0x2DE7750", VA = "0x182DE8B50")]
		public static Id32<LocalVariables.M> SFQBOQMKVIE(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8FD0", Offset = "0x2DE7BD0", VA = "0x182DE8FD0")]
		public static Id32<LocalVariables.M> UEHNJGWYITD(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2DE82F0", Offset = "0x2DE6EF0", VA = "0x182DE82F0")]
		public static Id32<LocalVariables.M> OWLEPGZDFAN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8A30", Offset = "0x2DE7630", VA = "0x182DE8A30")]
		public static Id32<LocalVariables.M> RVPBGZZQYXY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9310", Offset = "0x2DE7F10", VA = "0x182DE9310")]
		public static Id32<LocalVariables.M> VTCGZXCCQTN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2DE70C0", Offset = "0x2DE5CC0", VA = "0x182DE70C0")]
		public static Id32<LocalVariables.M> LKMJNZVLKQK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9C40", Offset = "0x2DE8840", VA = "0x182DE9C40")]
		public static Id32<LocalVariables.M> XZQQBFTHYTP(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2DE57A0", Offset = "0x2DE43A0", VA = "0x182DE57A0")]
		public static Id32<LocalVariables.M> CUMGIRZMLWU(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5A50", Offset = "0x2DE4650", VA = "0x182DE5A50")]
		public static Id32<LocalVariables.M> DDJQCUPBCTV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5550", Offset = "0x2DE4150", VA = "0x182DE5550")]
		public static Id32<LocalVariables.M> ABGRQFWPHGE(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8870", Offset = "0x2DE7470", VA = "0x182DE8870")]
		public static Id32<LocalVariables.M> RGOKWEWYNVX(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2DE85B0", Offset = "0x2DE71B0", VA = "0x182DE85B0")]
		public static Id32<LocalVariables.M> QBSKIMZZNLR(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8C70", Offset = "0x2DE7870", VA = "0x182DE8C70")]
		public static Id32<LocalVariables.M> SRZFTOGDYBK(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7A80", Offset = "0x2DE6680", VA = "0x182DE7A80")]
		public static Id32<LocalVariables.M> NNVSBGVXFVX(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8E10", Offset = "0x2DE7A10", VA = "0x182DE8E10")]
		public static Id32<LocalVariables.M> TAUHZSIPILU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5F50", Offset = "0x2DE4B50", VA = "0x182DE5F50")]
		public static Id32<LocalVariables.M> FZCXDUXMMND(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6850", Offset = "0x2DE5450", VA = "0x182DE6850")]
		public static Id32<LocalVariables.M> JPCEBBZAMEE(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA060", Offset = "0x2DE8C60", VA = "0x182DEA060")]
		public static Id32<LocalVariables.M> YLYBQTGPVVC(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA7C0", Offset = "0x2DE93C0", VA = "0x182DEA7C0")]
		public static Id32<LocalVariables.M> ZNKTKEPAMYP(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6690", Offset = "0x2DE5290", VA = "0x182DE6690")]
		public static Id32<LocalVariables.M> IIKZTOLXAQK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2DE83F0", Offset = "0x2DE6FF0", VA = "0x182DE83F0")]
		public static Id32<LocalVariables.M> PDKMMJLORWF(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA200", Offset = "0x2DE8E00", VA = "0x182DEA200")]
		public static Id32<LocalVariables.M> YRBBPTDRKCG(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2DE69D0", Offset = "0x2DE55D0", VA = "0x182DE69D0")]
		public static Id32<LocalVariables.M> JYDRWWDESLB(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA4C0", Offset = "0x2DE90C0", VA = "0x182DEA4C0")]
		public static Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> YSBBGLVLXTH(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2DE64D0", Offset = "0x2DE50D0", VA = "0x182DE64D0")]
		public static Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> HULIIHWMOAN(this FunctionCompileState a, int b)
		{
			return default(Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5680", Offset = "0x2DE4280", VA = "0x182DE5680")]
		public static Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> CDUDZZMPXQK(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7660", Offset = "0x2DE6260", VA = "0x182DE7660")]
		public static Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> MKJTUNXPJWW(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5720", Offset = "0x2DE4320", VA = "0x182DE5720")]
		public static Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> CRAVTJRGRJI(this FunctionCompileState a, int b)
		{
			return default(Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9E80", Offset = "0x2DE8A80", VA = "0x182DE9E80")]
		public static Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> YHBPNAFEIJT(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6C20", Offset = "0x2DE5820", VA = "0x182DE6C20")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UHPDBSPWOPW>) KYMZVARUXPA(this FunctionCompileState a, Id32<KQWRYFZVYKT> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UHPDBSPWOPW>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2DE71C0", Offset = "0x2DE5DC0", VA = "0x182DE71C0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UHPDBSPWOPW>) LWUHNFAMLRC(this FunctionCompileState a, Id32<KZBLUFSWXZT> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UHPDBSPWOPW>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3F16000", Offset = "0x3F14C00", VA = "0x183F16000")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<GEBYEJADWWU>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<TMarker>>, Id32<FunctionCalls.M>) WVLPTYPJMNR<TMarker>(this FunctionCompileState a, Id32<GEBYEJADWWU> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<GEBYEJADWWU>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6A50", Offset = "0x2DE5650", VA = "0x182DE6A50")]
		public static Id32<LocalVariables.M> JZIPRPMMASP(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2DE60D0", Offset = "0x2DE4CD0", VA = "0x182DE60D0")]
		public static Id32<LocalVariables.M> GXFRFAUAFEY(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2DE63E0", Offset = "0x2DE4FE0", VA = "0x182DE63E0")]
		public static Id32<LocalVariables.M> HIAUBCBFBTP(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA0E0", Offset = "0x2DE8CE0", VA = "0x182DEA0E0")]
		public static Id32<LocalVariables.M> YPESIINXSEC(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8770", Offset = "0x2DE7370", VA = "0x182DE8770")]
		public static Id32<LocalVariables.M> QZEIGNMQBFP(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7960", Offset = "0x2DE6560", VA = "0x182DE7960")]
		public static Id32<LocalVariables.M> NEYPVIKFXSC(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6710", Offset = "0x2DE5310", VA = "0x182DE6710")]
		public static Id32<LocalVariables.M> JNZIBPOMAQD(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA840", Offset = "0x2DE9440", VA = "0x182DEA840")]
		public static Id32<LocalVariables.M> ZOPDTVWVMHV(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8CF0", Offset = "0x2DE78F0", VA = "0x182DE8CF0")]
		public static Id32<LocalVariables.M> SYSCLLGXTIA(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8E90", Offset = "0x2DE7A90", VA = "0x182DE8E90")]
		public static Id32<LocalVariables.M> TKTOPJXRGJD(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5C90", Offset = "0x2DE4890", VA = "0x182DE5C90")]
		public static Id32<LocalVariables.M> ELYBNQZOOEI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2DE89B0", Offset = "0x2DE75B0", VA = "0x182DE89B0")]
		public static Id32<LocalVariables.M> RUEVFQHFWNF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7C40", Offset = "0x2DE6840", VA = "0x182DE7C40")]
		public static Id32<LocalVariables.M> OBWQSGCFXKC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7860", Offset = "0x2DE6460", VA = "0x182DE7860")]
		public static Id32<LocalVariables.M> NEFIGZEBFVM(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9570", Offset = "0x2DE8170", VA = "0x182DE9570")]
		public static Id32<LocalVariables.M> WHSIFCPAPRP(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8630", Offset = "0x2DE7230", VA = "0x182DE8630")]
		public static Id32<LocalVariables.M> QJZKBHBMGIU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9210", Offset = "0x2DE7E10", VA = "0x182DE9210")]
		public static Id32<LocalVariables.M> UOFYPNZWXLB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2DE99D0", Offset = "0x2DE85D0", VA = "0x182DE99D0")]
		public static Id32<LocalVariables.M> XEMUAPGBIAU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5B50", Offset = "0x2DE4750", VA = "0x182DE5B50")]
		public static Id32<LocalVariables.M> ECGBRLQVUDP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5A30", Offset = "0x2DE4630", VA = "0x182DE5A30")]
		public static Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>> DBOYBVGWMAP(this FunctionCompileState a)
		{
			return default(Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2DE68D0", Offset = "0x2DE54D0", VA = "0x182DE68D0")]
		public static Id32<LocalVariables.M> JQDNZOTEAUA(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA280", Offset = "0x2DE8E80", VA = "0x182DEA280")]
		public static Id32<LocalVariables.M> YRMCVHSCPDN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6550", Offset = "0x2DE5150", VA = "0x182DE6550")]
		public static Id32<LocalVariables.M> IBEORNIAQKK(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5FD0", Offset = "0x2DE4BD0", VA = "0x182DE5FD0")]
		public static Id32<LocalVariables.M> GHIHIHLUTRY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9450", Offset = "0x2DE8050", VA = "0x182DE9450")]
		public static Id32<LocalVariables.M> VXWQGYNTITD(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9F20", Offset = "0x2DE8B20", VA = "0x182DE9F20")]
		public static Id32<LocalVariables.M> YJTXQLOKREU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9110", Offset = "0x2DE7D10", VA = "0x182DE9110")]
		public static Id32<LocalVariables.M> UHFLNALUQWF(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6B10", Offset = "0x2DE5710", VA = "0x182DE6B10")]
		public static Id32<LocalVariables.M> KQUZOUORKVE(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9AF0", Offset = "0x2DE86F0", VA = "0x182DE9AF0")]
		public static void XKVBEVEASOX(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5E50", Offset = "0x2DE4A50", VA = "0x182DE5E50")]
		public static Id32<LocalVariables.M> ERVZFCPHUYE(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2DE80D0", Offset = "0x2DE6CD0", VA = "0x182DE80D0")]
		public static Id32<LocalVariables.M> OFORFYZUJIH(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8470", Offset = "0x2DE7070", VA = "0x182DE8470")]
		public static Id32<LocalVariables.M> PQWCIAIYWRA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA6C0", Offset = "0x2DE92C0", VA = "0x182DEA6C0")]
		public static Id32<LocalVariables.M> ZEVTWXHLUFI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9D60", Offset = "0x2DE8960", VA = "0x182DE9D60")]
		public static Id32<LocalVariables.M> YBPZQNLIWAV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9B00", Offset = "0x2DE8700", VA = "0x182DE9B00")]
		public static Id32<LocalVariables.M> XPONMOUPIZS(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7CC0", Offset = "0x2DE68C0", VA = "0x182DE7CC0")]
		public static Id32<LocalVariables.M> OENUNHIISCY(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2DE61C0", Offset = "0x2DE4DC0", VA = "0x182DE61C0")]
		public static Id32<LocalVariables.M> HCNFKNPGSCN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2DE62C0", Offset = "0x2DE4EC0", VA = "0x182DE62C0")]
		public static Id32<LocalVariables.M> HEQOZZOOYQO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7B00", Offset = "0x2DE6700", VA = "0x182DE7B00")]
		public static Id32<LocalVariables.M> NZEHVDSGDVN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F12C40", Offset = "0x3F11840", VA = "0x183F12C40")]
		public static void FJIVTOMTNGO<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<KQWRYFZVYKT> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, MQMDYMTPLDL<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3F13AD0", Offset = "0x3F126D0", VA = "0x183F13AD0")]
		public static void HZPALTQOWGQ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<KZBLUFSWXZT> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, MQMDYMTPLDL<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3F141E0", Offset = "0x3F12DE0", VA = "0x183F141E0")]
		public static Id32<LocalVariables.M> JWDQNUDLHOC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, MQMDYMTPLDL<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3F13350", Offset = "0x3F11F50", VA = "0x183F13350")]
		public static Id32<LocalVariables.M> GNYJDDTESOX<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, MQMDYMTPLDL<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3F144F0", Offset = "0x3F130F0", VA = "0x183F144F0")]
		public static Id32<DataBackResults.M> LCRHWMNDVUE<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, MQMDYMTPLDL<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3F14800", Offset = "0x3F13400", VA = "0x183F14800")]
		public static Id32<ExecForwardResults.M> LXBXCTHCHIX<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, MQMDYMTPLDL<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2DE58E0", Offset = "0x2DE44E0", VA = "0x182DE58E0")]
		public static Id32<DataBackResults.M> CVGNJEUROER(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2DE96A0", Offset = "0x2DE82A0", VA = "0x182DE96A0")]
		public static Id32<DataBackResults.M> WXUWMVBPGDB(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3F15560", Offset = "0x3F14160", VA = "0x183F15560")]
		public static Id32<DataBackResults.M> SYWGLQOFTRE<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<KQWRYFZVYKT> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, MQMDYMTPLDL<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3F152F0", Offset = "0x3F13EF0", VA = "0x183F152F0")]
		private static Id32<DataBackResults.M> SYWGLQOFTRE<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<KQWRYFZVYKT> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, MQMDYMTPLDL<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F14EA0", Offset = "0x3F13AA0", VA = "0x183F14EA0")]
		public static Id32<LocalVariables.M> PWJDCCFLUJA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, MQMDYMTPLDL<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F128E0", Offset = "0x3F114E0", VA = "0x183F128E0")]
		public static void ERLBQBNYXLB<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, MQMDYMTPLDL<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<URLPKZCBIQI<JTNRDUJMXAD>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<URLPKZCBIQI<JTNRDUJMXAD>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		public LiveInterval(Id32<URLPKZCBIQI<JTNRDUJMXAD>> firstUse, Id32<URLPKZCBIQI<JTNRDUJMXAD>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2DE26D0", Offset = "0x2DE12D0", VA = "0x182DE26D0")]
		public static LiveInterval New(Id32<URLPKZCBIQI<JTNRDUJMXAD>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class NRJLOLOSESD : JDRZXAZSAPS
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
			[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class MAEZAJMLAON : JDRZXAZSAPS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class CRGWDMFIWFY : JDRZXAZSAPS
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
			[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
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
		public abstract class JDRZXAZSAPS
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
			public Id32<JDRZXAZSAPS> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2DE26B0", Offset = "0x2DE12B0", VA = "0x182DE26B0")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<JDRZXAZSAPS> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class FSAWEBLEHRR : JDRZXAZSAPS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<NRJLOLOSESD, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<CRGWDMFIWFY, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<FSAWEBLEHRR, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<MAEZAJMLAON, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2DE28D0", Offset = "0x2DE14D0", VA = "0x182DE28D0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<NRJLOLOSESD, ArgumentInst> argumentVariables, [In] SOAId32Field<CRGWDMFIWFY, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<FSAWEBLEHRR, ParameterInst> parameterVariables, [In] SOAId32Field<MAEZAJMLAON, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2DE26E0", Offset = "0x2DE12E0", VA = "0x182DE26E0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class DJSWSDVSVOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0F30", Offset = "0x2DDFB30", VA = "0x182DE0F30")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class UKUOOCBOEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2DEAF20", Offset = "0x2DE9B20", VA = "0x182DEAF20")]
		public static void Run(FunctionCompileState self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.UHPDBSPWOPW, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0E30", Offset = "0x2DDFA30", VA = "0x182DE0E30")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.UHPDBSPWOPW, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0DC0", Offset = "0x2DDF9C0", VA = "0x182DE0DC0")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0BA0", Offset = "0x2DDF7A0", VA = "0x182DE0BA0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3829590", Offset = "0x3828190", VA = "0x183829590")]
		public static void Run<TDeps, TStateSys>(FunctionCompileState self, TDeps deps, TStateSys stateSys, Id32<JQPVMRMCZNG> graphId) where TDeps : notnull, MQMDYMTPLDL<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class IBUWJNXFWWR
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2320", Offset = "0x2DE0F20", VA = "0x182DE2320")]
		public static void Run(FunctionCompileState self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface VVJKXNDOTQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void VSFDWZCAQTH(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : VVJKXNDOTQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2DE5410", Offset = "0x2DE4010", VA = "0x182DE5410", Slot = "4")]
			public void VSFDWZCAQTH(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : VVJKXNDOTQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2DE54A0", Offset = "0x2DE40A0", VA = "0x182DE54A0", Slot = "4")]
			public void VSFDWZCAQTH(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : VVJKXNDOTQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2DE52D0", Offset = "0x2DE3ED0", VA = "0x182DE52D0", Slot = "4")]
			public void VSFDWZCAQTH(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : VVJKXNDOTQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2DE5360", Offset = "0x2DE3F60", VA = "0x182DE5360", Slot = "4")]
			public void VSFDWZCAQTH(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class REQQJGQOEBW<a> where a : struct, VVJKXNDOTQK
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly a KOIFGESKYOE;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x421D1B0", Offset = "0x421BDB0", VA = "0x18421D1B0")]
			public static int Run<TDeps, TStateSys>(TDeps deps, TStateSys state, FunctionCompileState ctx, [In] UnsafeList<byte> fromByteCode, int byteCodePtr) where TDeps : MQMDYMTPLDL<TStateSys>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<FunctionCalls.UHPDBSPWOPW>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2660", Offset = "0x2DE1260", VA = "0x182DE2660")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<FunctionCalls.UHPDBSPWOPW>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2DE25B0", Offset = "0x2DE11B0", VA = "0x182DE25B0")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2570", Offset = "0x2DE1170", VA = "0x182DE2570")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3C3C5A0", Offset = "0x3C3B1A0", VA = "0x183C3C5A0")]
		public static void Run<TDeps, TStateSys>(FunctionCompileState self, TDeps deps, TStateSys stateSys) where TDeps : MQMDYMTPLDL<TStateSys>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class VPLPESVGRTE
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
		private static int UHKJLYEVEIY;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int MYXEZRTCHJM;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2DEB480", Offset = "0x2DEA080", VA = "0x182DEB480")]
		public static void Run(FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2DEB270", Offset = "0x2DE9E70", VA = "0x182DEB270")]
		private static void BLUKUFEIGIH([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2DEB130", Offset = "0x2DE9D30", VA = "0x182DEB130")]
		private static void BLUKUFEIGIH(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2DEB9E0", Offset = "0x2DEA5E0", VA = "0x182DEB9E0")]
		private static void YNMBTZQNNOY(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class LDBXQQTKVJU<a, b, c> where a : struct, CLOHCEEQPOM<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a KOIFGESKYOE;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5979D60", Offset = "0x5978960", VA = "0x185979D60")]
		public static void Run([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int numItems, c values)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface CLOHCEEQPOM<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> JWTFHXCRNVM(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LBZMPFQNDTA(a a, b b, Id32<URLPKZCBIQI<PCOBNQTLDEG>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface VRIUWUUSQQB<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a ZAIXHRGXKYZ(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VJGAGGFLTWX(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<URLPKZCBIQI<PCOBNQTLDEG>> WMHYWRZRZGG(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class IFKGBQOPSIH<a, b, c> where a : struct, VRIUWUUSQQB<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a KOIFGESKYOE;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5551690", Offset = "0x5550290", VA = "0x185551690")]
		public static UnsafeList<b> Run(int numItems, [In] c values)
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
