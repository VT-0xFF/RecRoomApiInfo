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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x292D620", Offset = "0x292C620", VA = "0x18292D620")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
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
		public readonly Id32<IPPVCHRMOTE<WFYGDDOIHYI>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
		public ByteCodeAdjustment(Id32<IPPVCHRMOTE<WFYGDDOIHYI>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class JZMLOCYKLWS : IHEUWTVOAES
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x28C8090", Offset = "0x28C7090", VA = "0x1828C8090")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x292BB00", Offset = "0x292AB00", VA = "0x18292BB00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class MGTQCVWLILL : IHEUWTVOAES
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<IPPVCHRMOTE<OEBZQFUZUXL>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
			public DeadEnd(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> nextByteCodePtr)
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
		public abstract class IHEUWTVOAES
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
			public readonly Id32<IHEUWTVOAES> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
			public Inst(Def def, Id32<IHEUWTVOAES> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class OZDLXBHROMS : IHEUWTVOAES
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class NWSHMWAZPCM : IHEUWTVOAES
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x210C6E0", Offset = "0x210B6E0", VA = "0x18210C6E0", Slot = "3")]
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
		internal IdUnsafeList<JZMLOCYKLWS, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<MGTQCVWLILL, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<OZDLXBHROMS, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<NWSHMWAZPCM, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x292BD60", Offset = "0x292AD60", VA = "0x18292BD60")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<JZMLOCYKLWS, BytesImmediate> bytesImmediates, [In] IdUnsafeList<MGTQCVWLILL, DeadEnd> deadEnds, [In] IdUnsafeList<OZDLXBHROMS, Variable> variables, [In] IdUnsafeList<NWSHMWAZPCM, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x292BC20", Offset = "0x292AC20", VA = "0x18292BC20")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class PWGRSIVIPQF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x292D6A0", Offset = "0x292C6A0", VA = "0x18292D6A0")]
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
		public sealed class SYNRYXXSJOB : IHEUWTVOAES
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
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
		public abstract class IHEUWTVOAES
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
			public readonly Id32<IHEUWTVOAES> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
			public Inst(Def def, Id32<IHEUWTVOAES> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<SYNRYXXSJOB, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x292BED0", Offset = "0x292AED0", VA = "0x18292BED0")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<SYNRYXXSJOB, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x292BE40", Offset = "0x292AE40", VA = "0x18292BE40")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class BMWSJBRCIQK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x292BAA0", Offset = "0x292AAA0", VA = "0x18292BAA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x292BFB0", Offset = "0x292AFB0", VA = "0x18292BFB0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x292BF10", Offset = "0x292AF10", VA = "0x18292BF10")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class EMXJZZSFFUN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x292BDF0", Offset = "0x292ADF0", VA = "0x18292BDF0")]
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
		public sealed class XIGBUEYMPOZ : IHEUWTVOAES
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<DSWGFYHFFKO> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
			public ExternalCall(Id32<DSWGFYHFFKO> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class IHEUWTVOAES
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
			public readonly Id32<IHEUWTVOAES> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
			private Inst(Def def, Id32<IHEUWTVOAES> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x292D160", Offset = "0x292C160", VA = "0x18292D160")]
			public static Inst New(Def def, Id32<IHEUWTVOAES> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class NUZWYYVBXJV : IHEUWTVOAES
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<DSWGFYHFFKO> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
			public InternalCall(Id32<DSWGFYHFFKO> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class DSWGFYHFFKO
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
			[Cpp2IlInjected.Address(RVA = "0x292BED0", Offset = "0x292AED0", VA = "0x18292BED0")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x292CFB0", Offset = "0x292BFB0", VA = "0x18292CFB0")]
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
		internal IdUnsafeList<NUZWYYVBXJV, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<XIGBUEYMPOZ, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<DSWGFYHFFKO> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<DSWGFYHFFKO, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x292C1B0", Offset = "0x292B1B0", VA = "0x18292C1B0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<NUZWYYVBXJV, InternalCall> internalCalls, [In] IdUnsafeList<XIGBUEYMPOZ, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<DSWGFYHFFKO> IOId)> callsWithIO, [In] IdUnsafeList<DSWGFYHFFKO, IO> io, [In] SOAField<DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> ioModifyingCallLocations, [In] SOAField<DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x292C010", Offset = "0x292B010", VA = "0x18292C010")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class UEISWORTYVN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2933780", Offset = "0x2932780", VA = "0x182933780")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2933570", Offset = "0x2932570", VA = "0x182933570")]
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
		internal SOAField<JZMHXBKSKRV, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<JZMHXBKSKRV>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x292CC00", Offset = "0x292BC00", VA = "0x18292CC00")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<JZMHXBKSKRV, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<JZMHXBKSKRV>> generatedOutputsForExpression, [In] SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x292C270", Offset = "0x292B270", VA = "0x18292C270")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class VEHDOFRZLGY
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : KJWKINQKTWD<Id32<FunctionCalls.DSWGFYHFFKO>, SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2933090", Offset = "0x2932090", VA = "0x182933090")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2933120", Offset = "0x2932120", VA = "0x182933120", Slot = "4")]
			public Id32<FunctionCalls.DSWGFYHFFKO> QPWNYNSHFHF(int a)
			{
				return default(Id32<FunctionCalls.DSWGFYHFFKO>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390")]
			public bool VYXWMQGBPPT(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "5")]
			private bool YIUQPGQGSUN(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2933110", Offset = "0x2932110", VA = "0x182933110", Slot = "6")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> NFHQUARSZQI(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : JJDVEOUVVTQ<Id32<FunctionCalls.DSWGFYHFFKO>, SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x292AD50", Offset = "0x2929D50", VA = "0x18292AD50")]
			public UnsafeList<Id32<FunctionCalls.DSWGFYHFFKO>> LGDXSMFIRCA(int a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.DSWGFYHFFKO>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x292ACD0", Offset = "0x2929CD0", VA = "0x18292ACD0")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x292AC30", Offset = "0x2929C30", VA = "0x18292AC30", Slot = "6")]
			public void IRMBQBLWBHG(Id32<FunctionCalls.DSWGFYHFFKO> a, SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> b, Id32<IPPVCHRMOTE<WFYGDDOIHYI>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x292AD50", Offset = "0x2929D50", VA = "0x18292AD50", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.DSWGFYHFFKO>> XKRKOTVFSDF(int a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.DSWGFYHFFKO>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x292ADC0", Offset = "0x2929DC0", VA = "0x18292ADC0", Slot = "5")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> TQZMQWCATHL(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : KJWKINQKTWD<Id32<FunctionCalls.DSWGFYHFFKO>, SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2933160", Offset = "0x2932160", VA = "0x182933160")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x29331E0", Offset = "0x29321E0", VA = "0x1829331E0", Slot = "4")]
			public Id32<FunctionCalls.DSWGFYHFFKO> QPWNYNSHFHF(int a)
			{
				return default(Id32<FunctionCalls.DSWGFYHFFKO>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390")]
			public bool VYXWMQGBPPT(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "5")]
			private bool NGKCZKPWAOG(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2933220", Offset = "0x2932220", VA = "0x182933220", Slot = "6")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> TWXGRNHHKQT(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : JJDVEOUVVTQ<Id32<FunctionCalls.DSWGFYHFFKO>, SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x292AF00", Offset = "0x2929F00", VA = "0x18292AF00")]
			public UnsafeList<Id32<FunctionCalls.DSWGFYHFFKO>> LGDXSMFIRCA(int a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.DSWGFYHFFKO>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x292AE70", Offset = "0x2929E70", VA = "0x18292AE70")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x292ADD0", Offset = "0x2929DD0", VA = "0x18292ADD0", Slot = "6")]
			public void IRMBQBLWBHG(Id32<FunctionCalls.DSWGFYHFFKO> a, SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> b, Id32<IPPVCHRMOTE<WFYGDDOIHYI>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x292AF00", Offset = "0x2929F00", VA = "0x18292AF00", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.DSWGFYHFFKO>> YZYWYQPYYEI(int a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.DSWGFYHFFKO>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x292AEF0", Offset = "0x2929EF0", VA = "0x18292AEF0", Slot = "5")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> KTSNPIWUYCA(Id32<FunctionCalls.DSWGFYHFFKO> a, [In] SOAField<FunctionCalls.DSWGFYHFFKO, Id32<IPPVCHRMOTE<BVYDAJBFASE>>> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : KJWKINQKTWD<Id32<SUVSOCRKLLI>, SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x29332A0", Offset = "0x29322A0", VA = "0x1829332A0")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(Id32<SUVSOCRKLLI> a, [In] SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2933350", Offset = "0x2932350", VA = "0x182933350", Slot = "4")]
			public Id32<SUVSOCRKLLI> QPWNYNSHFHF(int a)
			{
				return default(Id32<SUVSOCRKLLI>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2933240", Offset = "0x2932240", VA = "0x182933240")]
			public bool VYXWMQGBPPT(Id32<SUVSOCRKLLI> a, [In] SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2933240", Offset = "0x2932240", VA = "0x182933240", Slot = "5")]
			private bool JDMHKEQXQNW(Id32<SUVSOCRKLLI> a, [In] SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2933230", Offset = "0x2932230", VA = "0x182933230", Slot = "6")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> GESLXDHEUKF(Id32<SUVSOCRKLLI> a, [In] SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : JJDVEOUVVTQ<Id32<SUVSOCRKLLI>, SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x292B120", Offset = "0x292A120", VA = "0x18292B120")]
			public UnsafeList<Id32<SUVSOCRKLLI>> LGDXSMFIRCA(int a, [In] SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> values)
			{
				return default(UnsafeList<Id32<SUVSOCRKLLI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x292B070", Offset = "0x292A070", VA = "0x18292B070")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(Id32<SUVSOCRKLLI> a, [In] SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x292AF70", Offset = "0x2929F70", VA = "0x18292AF70", Slot = "6")]
			public void IRMBQBLWBHG(Id32<SUVSOCRKLLI> a, SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> b, Id32<IPPVCHRMOTE<WFYGDDOIHYI>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x292B120", Offset = "0x292A120", VA = "0x18292B120", Slot = "4")]
			private UnsafeList<Id32<SUVSOCRKLLI>> XZJSMIKDHNI(int a, [In] SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> values)
			{
				return default(UnsafeList<Id32<SUVSOCRKLLI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x292B190", Offset = "0x292A190", VA = "0x18292B190", Slot = "5")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> WOPBGTCZTDY(Id32<SUVSOCRKLLI> a, [In] SOAField<SUVSOCRKLLI, Id32<IPPVCHRMOTE<OEBZQFUZUXL>>?> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : KJWKINQKTWD<int, UnsafeList<(Id32<LocalVariables.M>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x29334D0", Offset = "0x29324D0", VA = "0x1829334D0")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB30F60", Offset = "0xB2FF60", VA = "0x180B30F60", Slot = "4")]
			public int QPWNYNSHFHF(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390")]
			public bool VYXWMQGBPPT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "5")]
			private bool DDJSEOYPLZD(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2933560", Offset = "0x2932560", VA = "0x182933560", Slot = "6")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> WTFCHYZVUAA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : JJDVEOUVVTQ<int, UnsafeList<(Id32<LocalVariables.M>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x292B5C0", Offset = "0x292A5C0", VA = "0x18292B5C0")]
			public UnsafeList<int> LGDXSMFIRCA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x292B730", Offset = "0x292A730", VA = "0x18292B730")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x292B630", Offset = "0x292A630", VA = "0x18292B630", Slot = "6")]
			public void IRMBQBLWBHG(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> values, Id32<IPPVCHRMOTE<WFYGDDOIHYI>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x292B5C0", Offset = "0x292A5C0", VA = "0x18292B5C0", Slot = "4")]
			private UnsafeList<int> IILECBAOQCZ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x292B7C0", Offset = "0x292A7C0", VA = "0x18292B7C0", Slot = "5")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> XOGRWUZHEAX(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IPPVCHRMOTE<SDPQMIFAXNK<WFYGDDOIHYI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : KJWKINQKTWD<int, UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2933430", Offset = "0x2932430", VA = "0x182933430")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB30F60", Offset = "0xB2FF60", VA = "0x180B30F60", Slot = "4")]
			public int QPWNYNSHFHF(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390")]
			public bool VYXWMQGBPPT(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "5")]
			private bool MTVNUCUZPUY(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x29334C0", Offset = "0x29324C0", VA = "0x1829334C0", Slot = "6")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> OCFPPTGLMMV(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : JJDVEOUVVTQ<int, UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x292B3B0", Offset = "0x292A3B0", VA = "0x18292B3B0")]
			public UnsafeList<int> LGDXSMFIRCA(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x292B520", Offset = "0x292A520", VA = "0x18292B520")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x292B420", Offset = "0x292A420", VA = "0x18292B420", Slot = "6")]
			public void IRMBQBLWBHG(int a, UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values, Id32<IPPVCHRMOTE<WFYGDDOIHYI>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x292B3B0", Offset = "0x292A3B0", VA = "0x18292B3B0", Slot = "4")]
			private UnsafeList<int> FPQDGUPSMYY(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x292B5B0", Offset = "0x292A5B0", VA = "0x18292B5B0", Slot = "5")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> UNHCZLDMNQI(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : KJWKINQKTWD<int, UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2933390", Offset = "0x2932390", VA = "0x182933390")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB30F60", Offset = "0xB2FF60", VA = "0x180B30F60", Slot = "4")]
			public int QPWNYNSHFHF(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390")]
			public bool VYXWMQGBPPT(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "5")]
			private bool MTVNUCUZPUY(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2933420", Offset = "0x2932420", VA = "0x182933420", Slot = "6")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> OCFPPTGLMMV(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : JJDVEOUVVTQ<int, UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x292B1A0", Offset = "0x292A1A0", VA = "0x18292B1A0")]
			public UnsafeList<int> LGDXSMFIRCA(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x292B310", Offset = "0x292A310", VA = "0x18292B310")]
			public Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x292B210", Offset = "0x292A210", VA = "0x18292B210", Slot = "6")]
			public void IRMBQBLWBHG(int a, UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values, Id32<IPPVCHRMOTE<WFYGDDOIHYI>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x292B1A0", Offset = "0x292A1A0", VA = "0x18292B1A0", Slot = "4")]
			private UnsafeList<int> FPQDGUPSMYY(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x292B3A0", Offset = "0x292A3A0", VA = "0x18292B3A0", Slot = "5")]
			private Id32<IPPVCHRMOTE<WFYGDDOIHYI>> UNHCZLDMNQI(int a, [In] UnsafeList<(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> Target, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1A8EF90", Offset = "0x1A8DF90", VA = "0x181A8EF90")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x292CFA0", Offset = "0x292BFA0", VA = "0x18292CFA0")]
			public void AKGSYCXFFIN([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<SUVSOCRKLLI> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x292CF80", Offset = "0x292BF80", VA = "0x18292CF80")]
			public GenerateDataBackFromInputIndexResult(Id32<SUVSOCRKLLI> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x292CF70", Offset = "0x292BF70", VA = "0x18292CF70")]
			public void AKGSYCXFFIN([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x292CF50", Offset = "0x292BF50", VA = "0x18292CF50")]
			public void AKGSYCXFFIN([Out] Id32<DataBackResults.M> a, [Out] Id32<SUVSOCRKLLI> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<SUVSOCRKLLI> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
			public GenerateDataBackFromInputIndicesResult(Id32<SUVSOCRKLLI> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x292CF90", Offset = "0x292BF90", VA = "0x18292CF90")]
			public void AKGSYCXFFIN([Out] Id32<DataBackResults.M> a, [Out] Id32<SUVSOCRKLLI> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2934900", Offset = "0x2933900", VA = "0x182934900")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x29346C0", Offset = "0x29336C0", VA = "0x1829346C0")]
		public static void CHVAFEFMGOS(this FunctionCompileState a, Id32<JZMHXBKSKRV> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2935B10", Offset = "0x2934B10", VA = "0x182935B10")]
		public static void OPBYINASCMA(this FunctionCompileState a, Id32<JZMHXBKSKRV> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2935A90", Offset = "0x2934A90", VA = "0x182935A90")]
		public static Id32<DataBackResults.M>? OLPVXTOJCSB([In] this FunctionCompileState self, Id32<JZMHXBKSKRV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2935580", Offset = "0x2934580", VA = "0x182935580")]
		public static Id32<IPPVCHRMOTE<OEBZQFUZUXL>> KAKWQMHRZZX([In] this FunctionCompileState self)
		{
			return default(Id32<IPPVCHRMOTE<OEBZQFUZUXL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x29344A0", Offset = "0x29334A0", VA = "0x1829344A0")]
		private static void ATZZJQKAJZI(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2934640", Offset = "0x2933640", VA = "0x182934640")]
		private static Id32<IPPVCHRMOTE<OEBZQFUZUXL>>? BQVQSJOESSF([In] this FunctionCompileState self, Id32<SUVSOCRKLLI> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2934750", Offset = "0x2933750", VA = "0x182934750")]
		public static void CTHVLJODYYJ(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x29362B0", Offset = "0x29352B0", VA = "0x1829362B0")]
		public static DataBackResults.Def VQWTTLUZILP([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2935150", Offset = "0x2934150", VA = "0x182935150")]
		public static ReadOnlyArray<byte> GEWPISHGWBT([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x29366F0", Offset = "0x29356F0", VA = "0x1829366F0")]
		public static Id32<LocalVariables.M> ZKVCUBJWWMX([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x29355E0", Offset = "0x29345E0", VA = "0x1829355E0")]
		public static Union32 KDMBNRSXCNB([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A590", Offset = "0x3C49590", VA = "0x183C4A590")]
		private static Id32<DataBackResults.M> BKMYTRKSWIQ<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.IHEUWTVOAES
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2935F40", Offset = "0x2934F40", VA = "0x182935F40")]
		public static Id32<DataBackResults.M> RQKAZMQFEPY(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2935FC0", Offset = "0x2934FC0", VA = "0x182935FC0")]
		public static Id32<DataBackResults.M> RVZJFQFHMMV(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2934420", Offset = "0x2933420", VA = "0x182934420")]
		public static Id32<DataBackResults.M> AIBXTDKCIIU(this FunctionCompileState a, Id32<IPPVCHRMOTE<OEBZQFUZUXL>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2935EC0", Offset = "0x2934EC0", VA = "0x182935EC0")]
		public static Id32<DataBackResults.M> QSXMDTVWOXQ(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2935230", Offset = "0x2934230", VA = "0x182935230")]
		public static Id32<DataBackResults.M> GFJFFIHUWUN(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C4CF50", Offset = "0x3C4BF50", VA = "0x183C4CF50")]
		private static Id32<ExecForwardResults.M> XCPLBMZNKTV<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.IHEUWTVOAES
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2935460", Offset = "0x2934460", VA = "0x182935460")]
		public static Id32<ExecForwardResults.M> HLOCYURKFVX(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x29367D0", Offset = "0x29357D0", VA = "0x1829367D0")]
		public static Id32<ExecForwardResults.M> ZLDRMZGKOXE(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2934BD0", Offset = "0x2933BD0", VA = "0x182934BD0")]
		public static Id32<ExecForwardResults.M> EKGLDKSNXBE(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x29356C0", Offset = "0x29346C0", VA = "0x1829356C0")]
		public static Id32<ExecForwardResults.M> KRQYBKBVDWH(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x29354A0", Offset = "0x29344A0", VA = "0x1829354A0")]
		public static Id32<ExecForwardResults.M> IFBAGWNKOYP(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2936130", Offset = "0x2935130", VA = "0x182936130")]
		public static FunctionCalls.Def TIRQVIPSZQI([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x29348C0", Offset = "0x29338C0", VA = "0x1829348C0")]
		public static CopyEnumerable<Id32<FunctionCalls.DSWGFYHFFKO>, Id32Enumerator<FunctionCalls.DSWGFYHFFKO>> DSTIJULYCXH([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.DSWGFYHFFKO>, Id32Enumerator<FunctionCalls.DSWGFYHFFKO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2934F10", Offset = "0x2933F10", VA = "0x182934F10")]
		public static Id32<FunctionCalls.DSWGFYHFFKO> FSNRZXDTDYA([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.DSWGFYHFFKO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x29350E0", Offset = "0x29340E0", VA = "0x1829350E0")]
		public static FunctionCalls.IO FXMDUSNVHPX([In] this FunctionCompileState self, Id32<FunctionCalls.DSWGFYHFFKO> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x29343B0", Offset = "0x29333B0", VA = "0x1829343B0")]
		public static FunctionCalls.IO ADKYZASBWOZ(this FunctionCompileState a, Id32<FunctionCalls.DSWGFYHFFKO> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C6A0", Offset = "0x3C4B6A0", VA = "0x183C4C6A0")]
		private static Id32<FunctionCalls.M> VUNZWPKPYRQ<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.IHEUWTVOAES
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2934D60", Offset = "0x2933D60", VA = "0x182934D60")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.DSWGFYHFFKO>) FBOHCNIOYWP(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.DSWGFYHFFKO>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2935CC0", Offset = "0x2934CC0", VA = "0x182935CC0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.DSWGFYHFFKO>) QMEHFJTCFTX(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.DSWGFYHFFKO>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2935A40", Offset = "0x2934A40", VA = "0x182935A40")]
		public static Id32<FunctionCalls.M> NHGAOJOILNE(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2936430", Offset = "0x2935430", VA = "0x182936430")]
		public static void XAAKXUPWNHV(this FunctionCompileState a, Id32<FunctionCalls.DSWGFYHFFKO> b, Id32<IPPVCHRMOTE<OEBZQFUZUXL>> c, Id32<IPPVCHRMOTE<BVYDAJBFASE>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A8F0", Offset = "0x3C498F0", VA = "0x183C4A8F0")]
		public static GenerateDataBackResult GZELOAIRNBN<d, e>(this FunctionCompileState a, d b, e c, Id32<YHQFEYRJQPY> d, Id32<SUVSOCRKLLI> e) where d : GJBEFWGGCMP<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C250", Offset = "0x3C4B250", VA = "0x183C4C250")]
		public static GenerateDataBackFromInputIndexResult TKSOJDVDILN<f, g>(this FunctionCompileState a, f b, g c, Id32<YHQFEYRJQPY> d, Id32<QYHWLOYXTJM> e, int f) where f : GJBEFWGGCMP<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BCF0", Offset = "0x3C4ACF0", VA = "0x183C4BCF0")]
		public static Id32<DataBackResults.M>? JJLUVQAEFYW<h, i>(this FunctionCompileState a, h b, i c, Id32<YHQFEYRJQPY> d, Id32<QYHWLOYXTJM> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : GJBEFWGGCMP<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C730", Offset = "0x3C4B730", VA = "0x183C4C730")]
		public static Id32<ExecForwardResults.M> XCCUBZCLRUS<j, k>(this FunctionCompileState a, j b, k c, Id32<YHQFEYRJQPY> d, Id32<JZMHXBKSKRV> e) where j : GJBEFWGGCMP<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x29364C0", Offset = "0x29354C0", VA = "0x1829364C0")]
		public static LocalVariables.ArgumentInst YWIDEFQFPGW([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2934C50", Offset = "0x2933C50", VA = "0x182934C50")]
		public static LocalVariables.CalleeReturnValueInst EUOLLPCEMOK([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2935820", Offset = "0x2934820", VA = "0x182935820")]
		public static LocalVariables.CallerReturnValueInst MSCLWOYFPWZ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x29352B0", Offset = "0x29342B0", VA = "0x1829352B0")]
		public static Id32<LocalVariables.M> HERGYDWROFN(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2935930", Offset = "0x2934930", VA = "0x182935930")]
		public static LocalVariables.ParameterInst MSKWQTUDNIA([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x29360E0", Offset = "0x29350E0", VA = "0x1829360E0")]
		public static LocalVariables.Def THDKEVGBJYU([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2935E70", Offset = "0x2934E70", VA = "0x182935E70")]
		public static int? QNXDBHKMWNQ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A7F0", Offset = "0x3C497F0", VA = "0x183C4A7F0")]
		private static Id32<LocalVariables.M> GIWUCOSAWKO<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.IHEUWTVOAES
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2935710", Offset = "0x2934710", VA = "0x182935710")]
		public static Id32<LocalVariables.M> LAQLXOOOKAU(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x29357C0", Offset = "0x29347C0", VA = "0x1829357C0")]
		public static Id32<LocalVariables.M> MKTTZICQPMP(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2934230", Offset = "0x2933230", VA = "0x182934230")]
		public static Id32<LocalVariables.M> AAJLIQQPWRL(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2936050", Offset = "0x2935050", VA = "0x182936050")]
		public static Id32<LocalVariables.M> TEPHTJZUFRT(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2936250", Offset = "0x2935250", VA = "0x182936250")]
		public static Id32<LocalVariables.M> VEEQTLGJGCB(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x29365D0", Offset = "0x29355D0", VA = "0x1829365D0")]
		public static void ZBQNXKJVFQK(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2936320", Offset = "0x2935320", VA = "0x182936320")]
		public static void WOEBLMGLTHE(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x29361A0", Offset = "0x29351A0", VA = "0x1829361A0")]
		public static void TVJPJYLMCGW(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x29354F0", Offset = "0x29344F0", VA = "0x1829354F0")]
		public static void IVMZLWMFFWR(this FunctionCompileState a, Id32<IPPVCHRMOTE<OEBZQFUZUXL>> b, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2935BE0", Offset = "0x2934BE0", VA = "0x182935BE0")]
		public static void QCPGKBPBMYR(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<IPPVCHRMOTE<MAKXALEIWEY>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A710", Offset = "0x3C49710", VA = "0x183C4A710")]
		public static void DTMZRZUYIMC<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<IPPVCHRMOTE<SDPQMIFAXNK<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface GJBEFWGGCMP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<WNOXGYXOQBA> VQNUDCAJNHC(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<WNOXGYXOQBA> TAFUAMMXTMJ(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<WNOXGYXOQBA> XUJDLKKSNHY(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<WNOXGYXOQBA> WBXSMKBKFDX(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> PHZVRINOOIH(a a, FunctionCompileState b, Id32<YHQFEYRJQPY> c, Id32<SUVSOCRKLLI> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> CYRQTVXVJVX(a a, FunctionCompileState b, Id32<YHQFEYRJQPY> c, Id32<JZMHXBKSKRV> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int UHXMAABQAQV(a a, Id32<YHQFEYRJQPY> b, Id32<SUVSOCRKLLI> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<JZMHXBKSKRV> ICISWSEQWLU(a a, Id32<YHQFEYRJQPY> b, Id32<SUVSOCRKLLI> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind GGFGPTMSLDV(a a, Id32<YHQFEYRJQPY> b, Id32<SUVSOCRKLLI> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool CLSOOSESMBW(a a, Id32<YHQFEYRJQPY> b, Id32<SUVSOCRKLLI> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int XIEPIXQOTOR(a a, Id32<YHQFEYRJQPY> b, Id32<SUVSOCRKLLI> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> UJFGUBSTXHR(a a, Id32<YHQFEYRJQPY> b, Id32<SUVSOCRKLLI> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<WNOXGYXOQBA>) VNLJKXQBEYV(a a, Id32<YHQFEYRJQPY> b, Id32<SUVSOCRKLLI> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int CBWPCZPQSAL(a a, Id32<YHQFEYRJQPY> b, Id32<JZMHXBKSKRV> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<SUVSOCRKLLI> GQWFWURIXEW(a a, Id32<YHQFEYRJQPY> b, Id32<JZMHXBKSKRV> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<SUVSOCRKLLI> PDSASJNAZJZ(a a, Id32<YHQFEYRJQPY> b, Id32<QYHWLOYXTJM> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int YTJFCUBJCYD(a a, Id32<YHQFEYRJQPY> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? RHGNGYHSCWT(a a, Id32<YHQFEYRJQPY> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int EDFCXDEDXXT(a a, Id32<YHQFEYRJQPY> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? FNHLQKRBMKF(a a, Id32<YHQFEYRJQPY> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class QQTECFUZZQO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x39F97B0", Offset = "0x39F87B0", VA = "0x1839F97B0")]
		public static Id32<LocalVariables.M?> DUISIRNCTCN<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x39FCB10", Offset = "0x39FBB10", VA = "0x1839FCB10")]
		public static Id32<LocalVariables.M?> XNKCEFAYWJW<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x39FBDB0", Offset = "0x39FADB0", VA = "0x1839FBDB0")]
		public static Id32<LocalVariables.M?> RQWQDDHCBNL<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2930220", Offset = "0x292F220", VA = "0x182930220")]
		public static Id32<LocalVariables.M> KQWUDLZELBN(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x292F1A0", Offset = "0x292E1A0", VA = "0x18292F1A0")]
		public static Id32<LocalVariables.M> FZKESPLBJSE(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x292F8E0", Offset = "0x292E8E0", VA = "0x18292F8E0")]
		public static Id32<LocalVariables.M> IZLCXGHZRTH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x292E660", Offset = "0x292D660", VA = "0x18292E660")]
		public static Id32<LocalVariables.M> CMQJDAUCRAV(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x292E760", Offset = "0x292D760", VA = "0x18292E760")]
		public static Id32<LocalVariables.M> COTSSMTKXOW(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x292FC00", Offset = "0x292EC00", VA = "0x18292FC00")]
		public static Id32<LocalVariables.M> JJHLNQXCCTV(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2932B80", Offset = "0x2931B80", VA = "0x182932B80")]
		public static Id32<LocalVariables.M> ZCFKTKBLTCP(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x292EF30", Offset = "0x292DF30", VA = "0x18292EF30")]
		public static Id32<LocalVariables.M> FVVGCKHKHIM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x292F5E0", Offset = "0x292E5E0", VA = "0x18292F5E0")]
		public static Id32<LocalVariables.M> HUMRXARXUTL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2931370", Offset = "0x2930370", VA = "0x182931370")]
		public static Id32<LocalVariables.M> OHMYEOOXAIQ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2930080", Offset = "0x292F080", VA = "0x182930080")]
		public static Id32<LocalVariables.M> KKXPXVKDZMD(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x292E880", Offset = "0x292D880", VA = "0x18292E880")]
		public static Id32<LocalVariables.M> DKVDZWWTMIC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x292FF80", Offset = "0x292EF80", VA = "0x18292FF80")]
		public static Id32<LocalVariables.M> KADKIRUTTFX(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x292D9D0", Offset = "0x292C9D0", VA = "0x18292D9D0")]
		public static Id32<LocalVariables.M> ALCSBRMVKYC(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2931F40", Offset = "0x2930F40", VA = "0x182931F40")]
		public static Id32<LocalVariables.M> TGUTDQVMCDJ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2932C80", Offset = "0x2931C80", VA = "0x182932C80")]
		public static Id32<LocalVariables.M> ZLSHLJNHYLL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x29318F0", Offset = "0x29308F0", VA = "0x1829318F0")]
		public static Id32<LocalVariables.M> PVHVNDQESKK(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2932460", Offset = "0x2931460", VA = "0x182932460")]
		public static Id32<LocalVariables.M> VXHAFJEBORZ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x29317F0", Offset = "0x29307F0", VA = "0x1829317F0")]
		public static Id32<LocalVariables.M> PLEFCPJQGOI(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x292FB80", Offset = "0x292EB80", VA = "0x18292FB80")]
		public static Id32<LocalVariables.M> JEVSJALNTLZ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x29324E0", Offset = "0x29314E0", VA = "0x1829324E0")]
		public static Id32<LocalVariables.M> VZGEMYGKDQC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x29323E0", Offset = "0x29313E0", VA = "0x1829323E0")]
		public static Id32<LocalVariables.M> VUZEVFYGUGW(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x292F440", Offset = "0x292E440", VA = "0x18292F440")]
		public static Id32<LocalVariables.M> HARMYVLOIQN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x292F2C0", Offset = "0x292E2C0", VA = "0x18292F2C0")]
		public static Id32<LocalVariables.M> GTPSBYHOYOY(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2931870", Offset = "0x2930870", VA = "0x182931870")]
		public static Id32<LocalVariables.M> PRTWRZHJIRZ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x292F860", Offset = "0x292E860", VA = "0x18292F860")]
		public static Id32<LocalVariables.M> IHDJGQZWYMU(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2931BB0", Offset = "0x2930BB0", VA = "0x182931BB0")]
		public static Id32<LocalVariables.M> SJTPTWKCACR(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2931C30", Offset = "0x2930C30", VA = "0x182931C30")]
		public static Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> SLHKWUDUEEP(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x29308B0", Offset = "0x292F8B0", VA = "0x1829308B0")]
		public static Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> LSKMQJMWNWT(this FunctionCompileState a, int b)
		{
			return default(Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2932E20", Offset = "0x2931E20", VA = "0x182932E20")]
		public static Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> ZSLDSJWCXHG(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x292E3C0", Offset = "0x292D3C0", VA = "0x18292E3C0")]
		public static Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> BRUVBBGGKUA(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2932560", Offset = "0x2931560", VA = "0x182932560")]
		public static Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> WKNHEBSUKLS(this FunctionCompileState a, int b)
		{
			return default(Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x292E5C0", Offset = "0x292D5C0", VA = "0x18292E5C0")]
		public static Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> CEOAFVYZJCD(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x29325E0", Offset = "0x29315E0", VA = "0x1829325E0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.DSWGFYHFFKO>) WQTBCUGCZII(this FunctionCompileState a, Id32<LSCPVJVXELH> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.DSWGFYHFFKO>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2930320", Offset = "0x292F320", VA = "0x182930320")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.DSWGFYHFFKO>) KTJWZSIDAIW(this FunctionCompileState a, Id32<SQTEKUFGHFF> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.DSWGFYHFFKO>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x39F94F0", Offset = "0x39F84F0", VA = "0x1839F94F0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<WNOXGYXOQBA>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<TMarker>>, Id32<FunctionCalls.M>) CKUSVHISQWN<TMarker>(this FunctionCompileState a, Id32<WNOXGYXOQBA> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<WNOXGYXOQBA>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2931230", Offset = "0x2930230", VA = "0x182931230")]
		public static Id32<LocalVariables.M> NCCFFXJXHVT(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2930930", Offset = "0x292F930", VA = "0x182930930")]
		public static Id32<LocalVariables.M> LZLPYLEZIQG(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x29307C0", Offset = "0x292F7C0", VA = "0x1829307C0")]
		public static Id32<LocalVariables.M> LGMILBABYKL(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x292FD40", Offset = "0x292ED40", VA = "0x18292FD40")]
		public static Id32<LocalVariables.M> JVRVBXKJQVK(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x292F340", Offset = "0x292E340", VA = "0x18292F340")]
		public static Id32<LocalVariables.M> GXDWKRFWKSL(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2932D00", Offset = "0x2931D00", VA = "0x182932D00")]
		public static Id32<LocalVariables.M> ZRBHABJTPLW(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x292FA40", Offset = "0x292EA40", VA = "0x18292FA40")]
		public static Id32<LocalVariables.M> JDJNNVOSXCV(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2931E30", Offset = "0x2930E30", VA = "0x182931E30")]
		public static Id32<LocalVariables.M> SSHTSJQMWSB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x292FE60", Offset = "0x292EE60", VA = "0x18292FE60")]
		public static Id32<LocalVariables.M> JYTPFFPPERA(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x292DF50", Offset = "0x292CF50", VA = "0x18292DF50")]
		public static Id32<LocalVariables.M> BDTIVVSSQZF(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2930B60", Offset = "0x292FB60", VA = "0x182930B60")]
		public static Id32<LocalVariables.M> MGCIZWHXUPE(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x29312F0", Offset = "0x29302F0", VA = "0x1829312F0")]
		public static Id32<LocalVariables.M> NZXBVTNAJUB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x29301A0", Offset = "0x292F1A0", VA = "0x1829301A0")]
		public static Id32<LocalVariables.M> KQVCPNVBJJO(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x292E9C0", Offset = "0x292D9C0", VA = "0x18292E9C0")]
		public static Id32<LocalVariables.M> DTDVVPEDTQU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x292EE00", Offset = "0x292DE00", VA = "0x18292EE00")]
		public static Id32<LocalVariables.M> FMPAVYYTHLF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x292ECC0", Offset = "0x292DCC0", VA = "0x18292ECC0")]
		public static Id32<LocalVariables.M> FIYYMBSOCYS(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x292EBC0", Offset = "0x292DBC0", VA = "0x18292EBC0")]
		public static Id32<LocalVariables.M> FHYYTDJJPCN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2930BE0", Offset = "0x292FBE0", VA = "0x182930BE0")]
		public static Id32<LocalVariables.M> MVHTOQWDMJY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x292DE10", Offset = "0x292CE10", VA = "0x18292DE10")]
		public static Id32<LocalVariables.M> AYGWLUJPQPZ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x292FA20", Offset = "0x292EA20", VA = "0x18292FA20")]
		public static Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>> JBVWLRWRLJD(this FunctionCompileState a)
		{
			return default(Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2931970", Offset = "0x2930970", VA = "0x182931970")]
		public static Id32<LocalVariables.M> QJZWSCSQBTE(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x29316D0", Offset = "0x29306D0", VA = "0x1829316D0")]
		public static Id32<LocalVariables.M> OTTSCOAOGBP(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2931590", Offset = "0x2930590", VA = "0x182931590")]
		public static Id32<LocalVariables.M> OMYCGHDTRGM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x292EAC0", Offset = "0x292DAC0", VA = "0x18292EAC0")]
		public static Id32<LocalVariables.M> EPLNYIRQLZO(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x292F4C0", Offset = "0x292E4C0", VA = "0x18292F4C0")]
		public static Id32<LocalVariables.M> HROMKXKCHNF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2931A70", Offset = "0x2930A70", VA = "0x182931A70")]
		public static Id32<LocalVariables.M> RJXHLFHXMQO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x292DC10", Offset = "0x292CC10", VA = "0x18292DC10")]
		public static Id32<LocalVariables.M> ARZLQDZOIUD(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x292DB00", Offset = "0x292CB00", VA = "0x18292DB00")]
		public static Id32<LocalVariables.M> AOXINCJRJIA(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2931F30", Offset = "0x2930F30", VA = "0x182931F30")]
		public static void STKYLPPLNIR(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2932A80", Offset = "0x2931A80", VA = "0x182932A80")]
		public static Id32<LocalVariables.M> YDNZBQUIOBI(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2931470", Offset = "0x2930470", VA = "0x182931470")]
		public static Id32<LocalVariables.M> OMNEUPUOJUZ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2930A20", Offset = "0x292FA20", VA = "0x182930A20")]
		public static Id32<LocalVariables.M> MFXEJXNWZVS(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x292DD10", Offset = "0x292CD10", VA = "0x18292DD10")]
		public static Id32<LocalVariables.M> AXUXJTUKJBK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2932180", Offset = "0x2931180", VA = "0x182932180")]
		public static Id32<LocalVariables.M> VBJSCKRQKMH(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x29322A0", Offset = "0x29312A0", VA = "0x1829322A0")]
		public static Id32<LocalVariables.M> VEFZAVUUSKO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2930E20", Offset = "0x292FE20", VA = "0x182930E20")]
		public static Id32<LocalVariables.M> MXMBXQOREBI(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2932080", Offset = "0x2931080", VA = "0x182932080")]
		public static Id32<LocalVariables.M> UHYZVVJPQIT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2930D00", Offset = "0x292FD00", VA = "0x182930D00")]
		public static Id32<LocalVariables.M> MXIMKNCDGDO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x292F720", Offset = "0x292E720", VA = "0x18292F720")]
		public static Id32<LocalVariables.M> ICMWDAVYTAJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x39FC1F0", Offset = "0x39FB1F0", VA = "0x1839FC1F0")]
		public static void WPYNVTPDKTK<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LSCPVJVXELH> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, GJBEFWGGCMP<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x39FB4E0", Offset = "0x39FA4E0", VA = "0x1839FB4E0")]
		public static void RLUBZKUBOOG<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<SQTEKUFGHFF> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, GJBEFWGGCMP<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x39FBEE0", Offset = "0x39FAEE0", VA = "0x1839FBEE0")]
		public static Id32<LocalVariables.M> SNGWCRNGHPW<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, GJBEFWGGCMP<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x39FA570", Offset = "0x39F9570", VA = "0x1839FA570")]
		public static Id32<LocalVariables.M> HLDSGKCHGMR<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, GJBEFWGGCMP<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x39FAED0", Offset = "0x39F9ED0", VA = "0x1839FAED0")]
		public static Id32<DataBackResults.M> NVENGYWYEVE<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, GJBEFWGGCMP<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x39FB1E0", Offset = "0x39FA1E0", VA = "0x1839FB1E0")]
		public static Id32<ExecForwardResults.M> RLSEAQLKYEV<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, GJBEFWGGCMP<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x292F050", Offset = "0x292E050", VA = "0x18292F050")]
		public static Id32<DataBackResults.M> FWFALUSWYYH(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x292E090", Offset = "0x292D090", VA = "0x18292E090")]
		public static Id32<DataBackResults.M> BIIOORSSNQZ(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x39F9C10", Offset = "0x39F8C10", VA = "0x1839F9C10")]
		public static Id32<DataBackResults.M> EKEBFHRBZGE<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LSCPVJVXELH> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, GJBEFWGGCMP<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x39F99A0", Offset = "0x39F89A0", VA = "0x1839F99A0")]
		private static Id32<DataBackResults.M> EKEBFHRBZGE<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LSCPVJVXELH> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, GJBEFWGGCMP<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x39FAA80", Offset = "0x39F9A80", VA = "0x1839FAA80")]
		public static Id32<LocalVariables.M> LUREUJRXABC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, GJBEFWGGCMP<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x39FCD40", Offset = "0x39FBD40", VA = "0x1839FCD40")]
		public static void YWNVMFUOGGR<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, GJBEFWGGCMP<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<IPPVCHRMOTE<OEBZQFUZUXL>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<IPPVCHRMOTE<OEBZQFUZUXL>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
		public LiveInterval(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> firstUse, Id32<IPPVCHRMOTE<OEBZQFUZUXL>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x292D190", Offset = "0x292C190", VA = "0x18292D190")]
		public static LiveInterval New(Id32<IPPVCHRMOTE<OEBZQFUZUXL>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class YRZDZDEXTLH : IHEUWTVOAES
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
			[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class DOIMVDTLCGL : IHEUWTVOAES
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class NYQBQJPZQXG : IHEUWTVOAES
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
			[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
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
		public abstract class IHEUWTVOAES
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
			public Id32<IHEUWTVOAES> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x292D170", Offset = "0x292C170", VA = "0x18292D170")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<IHEUWTVOAES> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class LFKAPLOFJZT : IHEUWTVOAES
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<YRZDZDEXTLH, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<NYQBQJPZQXG, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<LFKAPLOFJZT, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<DOIMVDTLCGL, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x292D390", Offset = "0x292C390", VA = "0x18292D390")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<YRZDZDEXTLH, ArgumentInst> argumentVariables, [In] SOAId32Field<NYQBQJPZQXG, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<LFKAPLOFJZT, ParameterInst> parameterVariables, [In] SOAId32Field<DOIMVDTLCGL, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x292D1A0", Offset = "0x292C1A0", VA = "0x18292D1A0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class CCWDHLLXXKW
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x292BB70", Offset = "0x292AB70", VA = "0x18292BB70")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class NOLPGIZZCSO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x292D4C0", Offset = "0x292C4C0", VA = "0x18292D4C0")]
		public static void LQQMVHZWOPS(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.DSWGFYHFFKO, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x292BA60", Offset = "0x292AA60", VA = "0x18292BA60")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.DSWGFYHFFKO, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x292B9F0", Offset = "0x292A9F0", VA = "0x18292B9F0")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x292B7D0", Offset = "0x292A7D0", VA = "0x18292B7D0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x33A1F20", Offset = "0x33A0F20", VA = "0x1833A1F20")]
		public static void LQQMVHZWOPS<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<YHQFEYRJQPY> graphId) where TDeps : notnull, GJBEFWGGCMP<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class RDGXHCPQEZV
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2932EC0", Offset = "0x2931EC0", VA = "0x182932EC0")]
		public static void LQQMVHZWOPS(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface LVHWXJWXCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void XHUMEOXAUAP(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : LVHWXJWXCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x292D890", Offset = "0x292C890", VA = "0x18292D890", Slot = "4")]
			public void XHUMEOXAUAP(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : LVHWXJWXCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x292D920", Offset = "0x292C920", VA = "0x18292D920", Slot = "4")]
			public void XHUMEOXAUAP(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : LVHWXJWXCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x292D750", Offset = "0x292C750", VA = "0x18292D750", Slot = "4")]
			public void XHUMEOXAUAP(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : LVHWXJWXCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x292D7E0", Offset = "0x292C7E0", VA = "0x18292D7E0", Slot = "4")]
			public void XHUMEOXAUAP(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class CAHGJPQGFGO<c> where c : struct, LVHWXJWXCIE
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c USEUOEMXTCW;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3481B00", Offset = "0x3480B00", VA = "0x183481B00")]
			public static int LQQMVHZWOPS<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : GJBEFWGGCMP<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<FunctionCalls.DSWGFYHFFKO>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x292D120", Offset = "0x292C120", VA = "0x18292D120")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<FunctionCalls.DSWGFYHFFKO>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x292D070", Offset = "0x292C070", VA = "0x18292D070")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x292D030", Offset = "0x292C030", VA = "0x18292D030")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x37CA090", Offset = "0x37C9090", VA = "0x1837CA090")]
		public static void LQQMVHZWOPS<b, a>(FunctionCompileState a, b b, a c) where b : GJBEFWGGCMP<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class UFFGLWFMEDK
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
		private static int YXTLDLDYDLI;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int QSSVCAJYOUQ;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2933C80", Offset = "0x2932C80", VA = "0x182933C80")]
		public static void LQQMVHZWOPS(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2933910", Offset = "0x2932910", VA = "0x182933910")]
		private static void ADGEGZKDZKJ([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x29337D0", Offset = "0x29327D0", VA = "0x1829337D0")]
		private static void ADGEGZKDZKJ(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2933B20", Offset = "0x2932B20", VA = "0x182933B20")]
		private static void GWSCUUZYPMG(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class ZQFRXQLKTNS<a, b, c> where a : struct, JJDVEOUVVTQ<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a USEUOEMXTCW;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A250", Offset = "0x3F49250", VA = "0x183F4A250")]
		public static void LQQMVHZWOPS([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface JJDVEOUVVTQ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> LGDXSMFIRCA(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IRMBQBLWBHG(a a, b b, Id32<IPPVCHRMOTE<WFYGDDOIHYI>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface KJWKINQKTWD<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a QPWNYNSHFHF(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VYXWMQGBPPT(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<IPPVCHRMOTE<WFYGDDOIHYI>> JXOTYZAPSPW(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class YRQGSGPSYOF<a, b, c> where a : struct, KJWKINQKTWD<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a USEUOEMXTCW;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A510", Offset = "0x3F29510", VA = "0x183F2A510")]
		public static UnsafeList<b> LQQMVHZWOPS(int a, [In] c values)
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
