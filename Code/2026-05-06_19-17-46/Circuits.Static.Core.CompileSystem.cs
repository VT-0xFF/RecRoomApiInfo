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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B90A50", Offset = "0x2B8F450", VA = "0x182B90A50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
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
		public readonly Id32<GAIDVDAKGEP<JPZFXDVMDNP>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
		public ByteCodeAdjustment(Id32<GAIDVDAKGEP<JPZFXDVMDNP>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class ZJSOGHREJFH : ILNIRALUQAV
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2B21E40", Offset = "0x2B20840", VA = "0x182B21E40")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BDE0", Offset = "0x2B8A7E0", VA = "0x182B8BDE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class ILKCXZTLSHC : ILNIRALUQAV
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<GAIDVDAKGEP<JWUJAMRKFPU>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
			public DeadEnd(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> nextByteCodePtr)
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
		public abstract class ILNIRALUQAV
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
			public readonly Id32<ILNIRALUQAV> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
			public Inst(Def def, Id32<ILNIRALUQAV> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class ZEMYMOTVRVL : ILNIRALUQAV
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class USUSTTMPXGX : ILNIRALUQAV
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2391E00", Offset = "0x2390800", VA = "0x182391E00", Slot = "3")]
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
		internal IdUnsafeList<ZJSOGHREJFH, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<ILKCXZTLSHC, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<ZEMYMOTVRVL, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<USUSTTMPXGX, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BF90", Offset = "0x2B8A990", VA = "0x182B8BF90")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<ZJSOGHREJFH, BytesImmediate> bytesImmediates, [In] IdUnsafeList<ILKCXZTLSHC, DeadEnd> deadEnds, [In] IdUnsafeList<ZEMYMOTVRVL, Variable> variables, [In] IdUnsafeList<USUSTTMPXGX, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BE50", Offset = "0x2B8A850", VA = "0x182B8BE50")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class KUTEFZDPFCS
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D3C0", Offset = "0x2B8BDC0", VA = "0x182B8D3C0")]
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
		public sealed class GJNVTMORZNS : ILNIRALUQAV
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
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
		public abstract class ILNIRALUQAV
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
			public readonly Id32<ILNIRALUQAV> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
			public Inst(Def def, Id32<ILNIRALUQAV> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<GJNVTMORZNS, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C100", Offset = "0x2B8AB00", VA = "0x182B8C100")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<GJNVTMORZNS, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C070", Offset = "0x2B8AA70", VA = "0x182B8C070")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class OZGBIEUZFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B96190", Offset = "0x2B94B90", VA = "0x182B96190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8C1E0", Offset = "0x2B8ABE0", VA = "0x182B8C1E0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C140", Offset = "0x2B8AB40", VA = "0x182B8C140")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class EBOUGKJLLQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C020", Offset = "0x2B8AA20", VA = "0x182B8C020")]
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
		public sealed class SSPBABIAAIC : ILNIRALUQAV
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<UIVDZVGUGWB> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
			public ExternalCall(Id32<UIVDZVGUGWB> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class ILNIRALUQAV
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
			public readonly Id32<ILNIRALUQAV> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
			private Inst(Def def, Id32<ILNIRALUQAV> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D390", Offset = "0x2B8BD90", VA = "0x182B8D390")]
			public static Inst New(Def def, Id32<ILNIRALUQAV> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class FILGLFIIENC : ILNIRALUQAV
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<UIVDZVGUGWB> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
			public InternalCall(Id32<UIVDZVGUGWB> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class UIVDZVGUGWB
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
			[Cpp2IlInjected.Address(RVA = "0x2B8C100", Offset = "0x2B8AB00", VA = "0x182B8C100")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D1E0", Offset = "0x2B8BBE0", VA = "0x182B8D1E0")]
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
		internal IdUnsafeList<FILGLFIIENC, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<SSPBABIAAIC, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<UIVDZVGUGWB> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<UIVDZVGUGWB, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C3E0", Offset = "0x2B8ADE0", VA = "0x182B8C3E0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<FILGLFIIENC, InternalCall> internalCalls, [In] IdUnsafeList<SSPBABIAAIC, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<UIVDZVGUGWB> IOId)> callsWithIO, [In] IdUnsafeList<UIVDZVGUGWB, IO> io, [In] SOAField<UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> ioModifyingCallLocations, [In] SOAField<UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C240", Offset = "0x2B8AC40", VA = "0x182B8C240")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class NXNOLLLBEWG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B907F0", Offset = "0x2B8F1F0", VA = "0x182B907F0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B90840", Offset = "0x2B8F240", VA = "0x182B90840")]
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
		internal SOAField<FOQLRVXTRHG, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<FOQLRVXTRHG>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CE30", Offset = "0x2B8B830", VA = "0x182B8CE30")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<FOQLRVXTRHG, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<FOQLRVXTRHG>> generatedOutputsForExpression, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C4A0", Offset = "0x2B8AEA0", VA = "0x182B8C4A0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class MMOAWZELDNZ
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : ELJVRPYFVIO<Id32<FunctionCalls.UIVDZVGUGWB>, SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B964C0", Offset = "0x2B94EC0", VA = "0x182B964C0")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B96480", Offset = "0x2B94E80", VA = "0x182B96480", Slot = "4")]
			public Id32<FunctionCalls.UIVDZVGUGWB> ECYWKNAVARU(int a)
			{
				return default(Id32<FunctionCalls.UIVDZVGUGWB>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20")]
			public bool MZLDUKZDFCY(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "5")]
			private bool GWKBYYJKFGC(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B96470", Offset = "0x2B94E70", VA = "0x182B96470", Slot = "6")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> BUUHESHZTBF(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : HSIFALXGUYH<Id32<FunctionCalls.UIVDZVGUGWB>, SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B8AF80", Offset = "0x2B89980", VA = "0x182B8AF80")]
			public UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>> DPDPVSGTEHR(int a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B090", Offset = "0x2B89A90", VA = "0x182B8B090")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B8AFF0", Offset = "0x2B899F0", VA = "0x182B8AFF0", Slot = "6")]
			public void LICSDUNWKKJ(Id32<FunctionCalls.UIVDZVGUGWB> a, SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> b, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B8AF80", Offset = "0x2B89980", VA = "0x182B8AF80", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>> GWTVHLOVGKK(int a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B8AF70", Offset = "0x2B89970", VA = "0x182B8AF70", Slot = "5")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> AFNFRBZORLY(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : ELJVRPYFVIO<Id32<FunctionCalls.UIVDZVGUGWB>, SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B96580", Offset = "0x2B94F80", VA = "0x182B96580")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B96540", Offset = "0x2B94F40", VA = "0x182B96540", Slot = "4")]
			public Id32<FunctionCalls.UIVDZVGUGWB> ECYWKNAVARU(int a)
			{
				return default(Id32<FunctionCalls.UIVDZVGUGWB>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20")]
			public bool MZLDUKZDFCY(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "5")]
			private bool KLLKWECEOXV(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B96600", Offset = "0x2B95000", VA = "0x182B96600", Slot = "6")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> YBSYOIOJGMK(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : HSIFALXGUYH<Id32<FunctionCalls.UIVDZVGUGWB>, SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B110", Offset = "0x2B89B10", VA = "0x182B8B110")]
			public UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>> DPDPVSGTEHR(int a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B220", Offset = "0x2B89C20", VA = "0x182B8B220")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B180", Offset = "0x2B89B80", VA = "0x182B8B180", Slot = "6")]
			public void LICSDUNWKKJ(Id32<FunctionCalls.UIVDZVGUGWB> a, SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> b, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B110", Offset = "0x2B89B10", VA = "0x182B8B110", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>> TJANVZTLZBJ(int a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B2A0", Offset = "0x2B89CA0", VA = "0x182B8B2A0", Slot = "5")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> XINTKHNFJUN(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : ELJVRPYFVIO<Id32<NTSCAYGKXQL>, SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2B966C0", Offset = "0x2B950C0", VA = "0x182B966C0")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<NTSCAYGKXQL> a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2B96610", Offset = "0x2B95010", VA = "0x182B96610", Slot = "4")]
			public Id32<NTSCAYGKXQL> ECYWKNAVARU(int a)
			{
				return default(Id32<NTSCAYGKXQL>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B96660", Offset = "0x2B95060", VA = "0x182B96660")]
			public bool MZLDUKZDFCY(Id32<NTSCAYGKXQL> a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B96660", Offset = "0x2B95060", VA = "0x182B96660", Slot = "5")]
			private bool UVGCVJRGDMF(Id32<NTSCAYGKXQL> a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B96650", Offset = "0x2B95050", VA = "0x182B96650", Slot = "6")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> KPDLXGRFQBO(Id32<NTSCAYGKXQL> a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : HSIFALXGUYH<Id32<NTSCAYGKXQL>, SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B2B0", Offset = "0x2B89CB0", VA = "0x182B8B2B0")]
			public UnsafeList<Id32<NTSCAYGKXQL>> DPDPVSGTEHR(int a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(UnsafeList<Id32<NTSCAYGKXQL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B430", Offset = "0x2B89E30", VA = "0x182B8B430")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<NTSCAYGKXQL> a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B320", Offset = "0x2B89D20", VA = "0x182B8B320", Slot = "6")]
			public void LICSDUNWKKJ(Id32<NTSCAYGKXQL> a, SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> b, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B2B0", Offset = "0x2B89CB0", VA = "0x182B8B2B0", Slot = "4")]
			private UnsafeList<Id32<NTSCAYGKXQL>> GPDHWCTWULP(int a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(UnsafeList<Id32<NTSCAYGKXQL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B420", Offset = "0x2B89E20", VA = "0x182B8B420", Slot = "5")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> NBYQLNPIAWD(Id32<NTSCAYGKXQL> a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : ELJVRPYFVIO<int, UnsafeList<(Id32<LocalVariables.M>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2B968C0", Offset = "0x2B952C0", VA = "0x182B968C0")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD3BC30", Offset = "0xD3A630", VA = "0x180D3BC30", Slot = "4")]
			public int ECYWKNAVARU(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20")]
			public bool MZLDUKZDFCY(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "5")]
			private bool HFTJVQGGOUM(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B968B0", Offset = "0x2B952B0", VA = "0x182B968B0", Slot = "6")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> FPFWUEVCFPT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : HSIFALXGUYH<int, UnsafeList<(Id32<LocalVariables.M>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B900", Offset = "0x2B8A300", VA = "0x182B8B900")]
			public UnsafeList<int> DPDPVSGTEHR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BA70", Offset = "0x2B8A470", VA = "0x182B8BA70")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B970", Offset = "0x2B8A370", VA = "0x182B8B970", Slot = "6")]
			public void LICSDUNWKKJ(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B900", Offset = "0x2B8A300", VA = "0x182B8B900", Slot = "4")]
			private UnsafeList<int> HIVMRVDOWUS(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BB00", Offset = "0x2B8A500", VA = "0x182B8BB00", Slot = "5")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TFNMPWDZQLQ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : ELJVRPYFVIO<int, UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2B96810", Offset = "0x2B95210", VA = "0x182B96810")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD3BC30", Offset = "0xD3A630", VA = "0x180D3BC30", Slot = "4")]
			public int ECYWKNAVARU(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20")]
			public bool MZLDUKZDFCY(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "5")]
			private bool EPZTNWBFXCT(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B968A0", Offset = "0x2B952A0", VA = "0x182B968A0", Slot = "6")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> YQUIHIRCZJM(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : HSIFALXGUYH<int, UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B700", Offset = "0x2B8A100", VA = "0x182B8B700")]
			public UnsafeList<int> DPDPVSGTEHR(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B870", Offset = "0x2B8A270", VA = "0x182B8B870")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B770", Offset = "0x2B8A170", VA = "0x182B8B770", Slot = "6")]
			public void LICSDUNWKKJ(int a, UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B700", Offset = "0x2B8A100", VA = "0x182B8B700", Slot = "4")]
			private UnsafeList<int> QUXERYXZODL(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B6F0", Offset = "0x2B8A0F0", VA = "0x182B8B6F0", Slot = "5")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> AJIDBBWTKZZ(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : ELJVRPYFVIO<int, UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2B96770", Offset = "0x2B95170", VA = "0x182B96770")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD3BC30", Offset = "0xD3A630", VA = "0x180D3BC30", Slot = "4")]
			public int ECYWKNAVARU(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20")]
			public bool MZLDUKZDFCY(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "5")]
			private bool EPZTNWBFXCT(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2B96800", Offset = "0x2B95200", VA = "0x182B96800", Slot = "6")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> YQUIHIRCZJM(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : HSIFALXGUYH<int, UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B4F0", Offset = "0x2B89EF0", VA = "0x182B8B4F0")]
			public UnsafeList<int> DPDPVSGTEHR(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B660", Offset = "0x2B8A060", VA = "0x182B8B660")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B560", Offset = "0x2B89F60", VA = "0x182B8B560", Slot = "6")]
			public void LICSDUNWKKJ(int a, UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B4F0", Offset = "0x2B89EF0", VA = "0x182B8B4F0", Slot = "4")]
			private UnsafeList<int> QUXERYXZODL(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B4E0", Offset = "0x2B89EE0", VA = "0x182B8B4E0", Slot = "5")]
			private Id32<GAIDVDAKGEP<JPZFXDVMDNP>> AJIDBBWTKZZ(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1CBBDF0", Offset = "0x1CBA7F0", VA = "0x181CBBDF0")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D1D0", Offset = "0x2B8BBD0", VA = "0x182B8D1D0")]
			public void PUDYXZFHDAC([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<NTSCAYGKXQL> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D1B0", Offset = "0x2B8BBB0", VA = "0x182B8D1B0")]
			public GenerateDataBackFromInputIndexResult(Id32<NTSCAYGKXQL> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D180", Offset = "0x2B8BB80", VA = "0x182B8D180")]
			public void PUDYXZFHDAC([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D190", Offset = "0x2B8BB90", VA = "0x182B8D190")]
			public void PUDYXZFHDAC([Out] Id32<DataBackResults.M> a, [Out] Id32<NTSCAYGKXQL> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<NTSCAYGKXQL> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
			public GenerateDataBackFromInputIndicesResult(Id32<NTSCAYGKXQL> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D1C0", Offset = "0x2B8BBC0", VA = "0x182B8D1C0")]
			public void PUDYXZFHDAC([Out] Id32<DataBackResults.M> a, [Out] Id32<NTSCAYGKXQL> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DBB0", Offset = "0x2B8C5B0", VA = "0x182B8DBB0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DB20", Offset = "0x2B8C520", VA = "0x182B8DB20")]
		public static void DLKDMWAGTUL(this FunctionCompileState a, Id32<FOQLRVXTRHG> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F110", Offset = "0x2B8DB10", VA = "0x182B8F110")]
		public static void RQRUJTYRGUV(this FunctionCompileState a, Id32<FOQLRVXTRHG> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F9E0", Offset = "0x2B8E3E0", VA = "0x182B8F9E0")]
		public static Id32<DataBackResults.M>? XRFLVGKBMBE([In] this FunctionCompileState self, Id32<FOQLRVXTRHG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF90", Offset = "0x2B8C990", VA = "0x182B8DF90")]
		public static Id32<GAIDVDAKGEP<JWUJAMRKFPU>> FDKNIIDFRUS([In] this FunctionCompileState self)
		{
			return default(Id32<GAIDVDAKGEP<JWUJAMRKFPU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FBF0", Offset = "0x2B8E5F0", VA = "0x182B8FBF0")]
		private static void ZZBYROGYWZD(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBC0", Offset = "0x2B8D5C0", VA = "0x182B8EBC0")]
		private static Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? OHMHAIGEFSC([In] this FunctionCompileState self, Id32<NTSCAYGKXQL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DFF0", Offset = "0x2B8C9F0", VA = "0x182B8DFF0")]
		public static void FHMPMJFAVWW(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D7A0", Offset = "0x2B8C1A0", VA = "0x182B8D7A0")]
		public static DataBackResults.Def AFMODARDQIA([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EAE0", Offset = "0x2B8D4E0", VA = "0x182B8EAE0")]
		public static ReadOnlyArray<byte> OCQXKCVNOMQ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D810", Offset = "0x2B8C210", VA = "0x182B8D810")]
		public static Id32<LocalVariables.M> BHWGEGKLNDS([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E5B0", Offset = "0x2B8CFB0", VA = "0x182B8E5B0")]
		public static Union32 HDINAVHNGVM([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BFF0", Offset = "0x3C0A9F0", VA = "0x183C0BFF0")]
		private static Id32<DataBackResults.M> FYCCRBATWYH<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.ILNIRALUQAV
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FA60", Offset = "0x2B8E460", VA = "0x182B8FA60")]
		public static Id32<DataBackResults.M> XZFHQNCLBAP(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E8A0", Offset = "0x2B8D2A0", VA = "0x182B8E8A0")]
		public static Id32<DataBackResults.M> JLIBDRASCVU(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F630", Offset = "0x2B8E030", VA = "0x182B8F630")]
		public static Id32<DataBackResults.M> TFADVYOJUYV(this FunctionCompileState a, Id32<GAIDVDAKGEP<JWUJAMRKFPU>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EC40", Offset = "0x2B8D640", VA = "0x182B8EC40")]
		public static Id32<DataBackResults.M> OJDHBSSEBUN(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FAE0", Offset = "0x2B8E4E0", VA = "0x182B8FAE0")]
		public static Id32<DataBackResults.M> YTXJDSDQEEK(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BF50", Offset = "0x3C0A950", VA = "0x183C0BF50")]
		private static Id32<ExecForwardResults.M> FNQZUXJXZFK<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.ILNIRALUQAV
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D8F0", Offset = "0x2B8C2F0", VA = "0x182B8D8F0")]
		public static Id32<ExecForwardResults.M> BNWMXUHWXIA(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA90", Offset = "0x2B8D490", VA = "0x182B8EA90")]
		public static Id32<ExecForwardResults.M> MVAUGABMTAN(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F850", Offset = "0x2B8E250", VA = "0x182B8F850")]
		public static Id32<ExecForwardResults.M> WVCFWQZAZCZ(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E1D0", Offset = "0x2B8CBD0", VA = "0x182B8E1D0")]
		public static Id32<ExecForwardResults.M> GBZMHPFIMYW(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA40", Offset = "0x2B8D440", VA = "0x182B8EA40")]
		public static Id32<ExecForwardResults.M> LPKUDIZZFTC(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F750", Offset = "0x2B8E150", VA = "0x182B8F750")]
		public static FunctionCalls.Def UYXRMDLUTAB([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F0D0", Offset = "0x2B8DAD0", VA = "0x182B8F0D0")]
		public static CopyEnumerable<Id32<FunctionCalls.UIVDZVGUGWB>, Id32Enumerator<FunctionCalls.UIVDZVGUGWB>> RDSUSHIWSDS([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.UIVDZVGUGWB>, Id32Enumerator<FunctionCalls.UIVDZVGUGWB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E220", Offset = "0x2B8CC20", VA = "0x182B8E220")]
		public static Id32<FunctionCalls.UIVDZVGUGWB> GCHAASIXAWH([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.UIVDZVGUGWB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E160", Offset = "0x2B8CB60", VA = "0x182B8E160")]
		public static FunctionCalls.IO FTLHKBMOPJQ([In] this FunctionCompileState self, Id32<FunctionCalls.UIVDZVGUGWB> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F440", Offset = "0x2B8DE40", VA = "0x182B8F440")]
		public static FunctionCalls.IO SRZGBPRQPCI(this FunctionCompileState a, Id32<FunctionCalls.UIVDZVGUGWB> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BEC0", Offset = "0x3C0A8C0", VA = "0x183C0BEC0")]
		private static Id32<FunctionCalls.M> ETLLRBLOOBN<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.ILNIRALUQAV
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EF20", Offset = "0x2B8D920", VA = "0x182B8EF20")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>) QYMHZHVFYZM(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E690", Offset = "0x2B8D090", VA = "0x182B8E690")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>) IDVXBCWOFCQ(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F6B0", Offset = "0x2B8E0B0", VA = "0x182B8F6B0")]
		public static Id32<FunctionCalls.M> TXRBLIYCLLH(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FB60", Offset = "0x2B8E560", VA = "0x182B8FB60")]
		public static void ZPWNTFNQYPO(this FunctionCompileState a, Id32<FunctionCalls.UIVDZVGUGWB> b, Id32<GAIDVDAKGEP<JWUJAMRKFPU>> c, Id32<GAIDVDAKGEP<KEENRFCLFXX>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C6B0", Offset = "0x3C0B0B0", VA = "0x183C0C6B0")]
		public static GenerateDataBackResult JBIBWHZJJNI<d, e>(this FunctionCompileState a, d b, e c, Id32<EVDWFGHNUCH> d, Id32<NTSCAYGKXQL> e) where d : MCUQWFOUSFS<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C250", Offset = "0x3C0AC50", VA = "0x183C0C250")]
		public static GenerateDataBackFromInputIndexResult IMOLEXXDXVU<f, g>(this FunctionCompileState a, f b, g c, Id32<EVDWFGHNUCH> d, Id32<IHXSJTKSKEJ> e, int f) where f : MCUQWFOUSFS<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DB00", Offset = "0x3C0C500", VA = "0x183C0DB00")]
		public static Id32<DataBackResults.M>? MPCLIXOPTZN<h, i>(this FunctionCompileState a, h b, i c, Id32<EVDWFGHNUCH> d, Id32<IHXSJTKSKEJ> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : MCUQWFOUSFS<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B680", Offset = "0x3C0A080", VA = "0x183C0B680")]
		public static Id32<ExecForwardResults.M> DGZPATLDGAN<j, k>(this FunctionCompileState a, j b, k c, Id32<EVDWFGHNUCH> d, Id32<FOQLRVXTRHG> e) where j : MCUQWFOUSFS<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F8D0", Offset = "0x2B8E2D0", VA = "0x182B8F8D0")]
		public static LocalVariables.ArgumentInst WWHMWUKEBCV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E3F0", Offset = "0x2B8CDF0", VA = "0x182B8E3F0")]
		public static LocalVariables.CalleeReturnValueInst GHUPUGZFKUH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DE80", Offset = "0x2B8C880", VA = "0x182B8DE80")]
		public static LocalVariables.CallerReturnValueInst ESLOYOYLXWI([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ED10", Offset = "0x2B8D710", VA = "0x182B8ED10")]
		public static Id32<LocalVariables.M> OMQXUQUTVOQ(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E930", Offset = "0x2B8D330", VA = "0x182B8E930")]
		public static LocalVariables.ParameterInst LNWXDCJKAQF([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ECC0", Offset = "0x2B8D6C0", VA = "0x182B8ECC0")]
		public static LocalVariables.Def OLIOWBFFHNX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F700", Offset = "0x2B8E100", VA = "0x182B8F700")]
		public static int? UUQYIRKAGLR([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E070", Offset = "0x3C0CA70", VA = "0x183C0E070")]
		private static Id32<LocalVariables.M> VQLYPPMJIFR<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.ILNIRALUQAV
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F1E0", Offset = "0x2B8DBE0", VA = "0x182B8F1E0")]
		public static Id32<LocalVariables.M> SMQTZQYOYGT(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E840", Offset = "0x2B8D240", VA = "0x182B8E840")]
		public static Id32<LocalVariables.M> JKZRRBYZLEQ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F4B0", Offset = "0x2B8DEB0", VA = "0x182B8F4B0")]
		public static Id32<LocalVariables.M> SZQGJQQHOKA(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F290", Offset = "0x2B8DC90", VA = "0x182B8F290")]
		public static Id32<LocalVariables.M> SQAKARXCJNM(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EEC0", Offset = "0x2B8D8C0", VA = "0x182B8EEC0")]
		public static Id32<LocalVariables.M> QFNYJLCYVOS(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F320", Offset = "0x2B8DD20", VA = "0x182B8F320")]
		public static void SQAQDFMZLPJ(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D930", Offset = "0x2B8C330", VA = "0x182B8D930")]
		public static void CBQEOASDGKR(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E500", Offset = "0x2B8CF00", VA = "0x182B8E500")]
		public static void GUCIOQTTUVP(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F7C0", Offset = "0x2B8E1C0", VA = "0x182B8F7C0")]
		public static void VMCIMSONJZE(this FunctionCompileState a, Id32<GAIDVDAKGEP<JWUJAMRKFPU>> b, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA40", Offset = "0x2B8C440", VA = "0x182B8DA40")]
		public static void CINWMCPCRCW(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<GAIDVDAKGEP<YVGHOMRCUTJ>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C170", Offset = "0x3C0AB70", VA = "0x183C0C170")]
		public static void IGIRELFHBSL<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<GAIDVDAKGEP<WHMLTPZNLLH<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface MCUQWFOUSFS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<UXTEGGEVDNB> NJRQXAYLCJR(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<UXTEGGEVDNB> NQUYTMSKALA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<UXTEGGEVDNB> JMHLNKNBKGD(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<UXTEGGEVDNB> QKNUHYKYEPW(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> UNECZHDSAPA(a a, FunctionCompileState b, Id32<EVDWFGHNUCH> c, Id32<NTSCAYGKXQL> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> QEZJNJGENSS(a a, FunctionCompileState b, Id32<EVDWFGHNUCH> c, Id32<FOQLRVXTRHG> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int POHCJKTISFC(a a, Id32<EVDWFGHNUCH> b, Id32<NTSCAYGKXQL> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<FOQLRVXTRHG> EADAPMCBVZJ(a a, Id32<EVDWFGHNUCH> b, Id32<NTSCAYGKXQL> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind UPWTSHLZQHM(a a, Id32<EVDWFGHNUCH> b, Id32<NTSCAYGKXQL> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool LKSUYVFQKJR(a a, Id32<EVDWFGHNUCH> b, Id32<NTSCAYGKXQL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int NMPPOLKMDLS(a a, Id32<EVDWFGHNUCH> b, Id32<NTSCAYGKXQL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> TTSJAOZIZYO(a a, Id32<EVDWFGHNUCH> b, Id32<NTSCAYGKXQL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<UXTEGGEVDNB>) GYSRUKWDVOI(a a, Id32<EVDWFGHNUCH> b, Id32<NTSCAYGKXQL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int OKVMKOOLUVI(a a, Id32<EVDWFGHNUCH> b, Id32<FOQLRVXTRHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<NTSCAYGKXQL> JPTYFKPUULB(a a, Id32<EVDWFGHNUCH> b, Id32<FOQLRVXTRHG> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<NTSCAYGKXQL> MMILYYRGLTY(a a, Id32<EVDWFGHNUCH> b, Id32<IHXSJTKSKEJ> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int FDJWDRXMUJQ(a a, Id32<EVDWFGHNUCH> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? LCCQLLPLBWM(a a, Id32<EVDWFGHNUCH> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int NKJBDSNETBS(a a, Id32<EVDWFGHNUCH> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? AUQRVYUIXKS(a a, Id32<EVDWFGHNUCH> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class ORVWYXORQKZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D4EAF0", Offset = "0x3D4D4F0", VA = "0x183D4EAF0")]
		public static Id32<LocalVariables.M?> CMLCLGXDOFS<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D4EE70", Offset = "0x3D4D870", VA = "0x183D4EE70")]
		public static Id32<LocalVariables.M?> CWPLWACZCFH<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D52580", Offset = "0x3D50F80", VA = "0x183D52580")]
		public static Id32<LocalVariables.M?> YOFRRQYKUWE<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B93D40", Offset = "0x2B92740", VA = "0x182B93D40")]
		public static Id32<LocalVariables.M> PACIOOPDWKU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B90FD0", Offset = "0x2B8F9D0", VA = "0x182B90FD0")]
		public static Id32<LocalVariables.M> BEKKIAMWXKX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B93A60", Offset = "0x2B92460", VA = "0x182B93A60")]
		public static Id32<LocalVariables.M> NLDJGNEAMBE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B926B0", Offset = "0x2B910B0", VA = "0x182B926B0")]
		public static Id32<LocalVariables.M> IUGOVAGPBZI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B910F0", Offset = "0x2B8FAF0", VA = "0x182B910F0")]
		public static Id32<LocalVariables.M> BHVKVYJTEJX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B90E90", Offset = "0x2B8F890", VA = "0x182B90E90")]
		public static Id32<LocalVariables.M> AWSFDEJEZME(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B93960", Offset = "0x2B92360", VA = "0x182B93960")]
		public static Id32<LocalVariables.M> NEOJDPPBNMM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B94FA0", Offset = "0x2B939A0", VA = "0x182B94FA0")]
		public static Id32<LocalVariables.M> UBLDHOCHAAH(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B92020", Offset = "0x2B90A20", VA = "0x182B92020")]
		public static Id32<LocalVariables.M> GZZBMHJIKYK(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B958D0", Offset = "0x2B942D0", VA = "0x182B958D0")]
		public static Id32<LocalVariables.M> XOGMGSHYMZF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B95C60", Offset = "0x2B94660", VA = "0x182B95C60")]
		public static Id32<LocalVariables.M> ZEIVDXIYVMU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B94150", Offset = "0x2B92B50", VA = "0x182B94150")]
		public static Id32<LocalVariables.M> QPXOSOHWDDP(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B925B0", Offset = "0x2B90FB0", VA = "0x182B925B0")]
		public static Id32<LocalVariables.M> IGZUJMDZOKC(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B943A0", Offset = "0x2B92DA0", VA = "0x182B943A0")]
		public static Id32<LocalVariables.M> RXKGHSBCULD(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B93820", Offset = "0x2B92220", VA = "0x182B93820")]
		public static Id32<LocalVariables.M> MJNMNJYZTAE(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B91EA0", Offset = "0x2B908A0", VA = "0x182B91EA0")]
		public static Id32<LocalVariables.M> FTGJAIREGEI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B92490", Offset = "0x2B90E90", VA = "0x182B92490")]
		public static Id32<LocalVariables.M> HMROASLTTYT(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B93CA0", Offset = "0x2B926A0", VA = "0x182B93CA0")]
		public static Id32<LocalVariables.M> OHGCJDXLKAK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B91330", Offset = "0x2B8FD30", VA = "0x182B91330")]
		public static Id32<LocalVariables.M> CESFMDUXKSJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B93EC0", Offset = "0x2B928C0", VA = "0x182B93EC0")]
		public static Id32<LocalVariables.M> PRHXWXJJUJQ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B90E10", Offset = "0x2B8F810", VA = "0x182B90E10")]
		public static Id32<LocalVariables.M> AVOZDIQNSBF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B950C0", Offset = "0x2B93AC0", VA = "0x182B950C0")]
		public static Id32<LocalVariables.M> UMZPZKUZBKF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B93120", Offset = "0x2B91B20", VA = "0x182B93120")]
		public static Id32<LocalVariables.M> LJMQBHJZROC(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B93E40", Offset = "0x2B92840", VA = "0x182B93E40")]
		public static Id32<LocalVariables.M> PBUUOROZQRF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B944D0", Offset = "0x2B92ED0", VA = "0x182B944D0")]
		public static Id32<LocalVariables.M> SCBHZTDZKTK(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B93C20", Offset = "0x2B92620", VA = "0x182B93C20")]
		public static Id32<LocalVariables.M> OFLZSZZGJWX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B914B0", Offset = "0x2B8FEB0", VA = "0x182B914B0")]
		public static Id32<LocalVariables.M> CYJJLWZTBOC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B95360", Offset = "0x2B93D60", VA = "0x182B95360")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> VSBCFSQNKPI(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B91FA0", Offset = "0x2B909A0", VA = "0x182B91FA0")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> GCQIBQABWQW(this FunctionCompileState a, int b)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B95AD0", Offset = "0x2B944D0", VA = "0x182B95AD0")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> YVQOSZMUAHX(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B932A0", Offset = "0x2B91CA0", VA = "0x182B932A0")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> LUDKRMTPOXR(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B93BA0", Offset = "0x2B925A0", VA = "0x182B93BA0")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> NQEEFYCWQGX(this FunctionCompileState a, int b)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B92510", Offset = "0x2B90F10", VA = "0x182B92510")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> HWDLEDWRRQM(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B949E0", Offset = "0x2B933E0", VA = "0x182B949E0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>) SPPRYPVPTUV(this FunctionCompileState a, Id32<KXFBWSJODNE> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B91880", Offset = "0x2B90280", VA = "0x182B91880")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>) EKPUXYAPKNF(this FunctionCompileState a, Id32<BHDVXGKWBTW> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D50B90", Offset = "0x3D4F590", VA = "0x183D50B90")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<UXTEGGEVDNB>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<TMarker>>, Id32<FunctionCalls.M>) LJHELQBJJQU<TMarker>(this FunctionCompileState a, Id32<UXTEGGEVDNB> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<UXTEGGEVDNB>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B93F40", Offset = "0x2B92940", VA = "0x182B93F40")]
		public static Id32<LocalVariables.M> PYRFRXKBAOW(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B95B70", Offset = "0x2B94570", VA = "0x182B95B70")]
		public static Id32<LocalVariables.M> ZCEFQAVAKKZ(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B92EF0", Offset = "0x2B918F0", VA = "0x182B92EF0")]
		public static Id32<LocalVariables.M> KZOHGYVLZDE(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B92A30", Offset = "0x2B91430", VA = "0x182B92A30")]
		public static Id32<LocalVariables.M> KHCJDNYGDGV(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B90AD0", Offset = "0x2B8F4D0", VA = "0x182B90AD0")]
		public static Id32<LocalVariables.M> AEZOYBXNNOO(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B94E80", Offset = "0x2B93880", VA = "0x182B94E80")]
		public static Id32<LocalVariables.M> TKHPXNGUSKV(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B94000", Offset = "0x2B92A00", VA = "0x182B94000")]
		public static Id32<LocalVariables.M> PZJFBOFCROU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B959D0", Offset = "0x2B943D0", VA = "0x182B959D0")]
		public static Id32<LocalVariables.M> XTEBSCUQYHO(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B95560", Offset = "0x2B93F60", VA = "0x182B95560")]
		public static Id32<LocalVariables.M> WFENAOWXBDJ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B928F0", Offset = "0x2B912F0", VA = "0x182B928F0")]
		public static Id32<LocalVariables.M> KAKGANAYBJI(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B91E20", Offset = "0x2B90820", VA = "0x182B91E20")]
		public static Id32<LocalVariables.M> EYXATNRJMJL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B94960", Offset = "0x2B93360", VA = "0x182B94960")]
		public static Id32<LocalVariables.M> SLMTEHFVWAS(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B91F20", Offset = "0x2B90920", VA = "0x182B91F20")]
		public static Id32<LocalVariables.M> FTZMNOIEUYP(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B95260", Offset = "0x2B93C60", VA = "0x182B95260")]
		public static Id32<LocalVariables.M> VRSFDWJMYNX(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B91530", Offset = "0x2B8FF30", VA = "0x182B91530")]
		public static Id32<LocalVariables.M> CYTTZOAWPJY(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B95D80", Offset = "0x2B94780", VA = "0x182B95D80")]
		public static Id32<LocalVariables.M> ZKEBVGWCMLN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B91660", Offset = "0x2B90060", VA = "0x182B91660")]
		public static Id32<LocalVariables.M> EBCGFYWFHAY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B91760", Offset = "0x2B90160", VA = "0x182B91760")]
		public static Id32<LocalVariables.M> EDSMBUEUJHB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B935E0", Offset = "0x2B91FE0", VA = "0x182B935E0")]
		public static Id32<LocalVariables.M> MCRZAUJQQPY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B93D20", Offset = "0x2B92720", VA = "0x182B93D20")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> OWTLTYNEEDQ(this FunctionCompileState a)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B913B0", Offset = "0x2B8FDB0", VA = "0x182B913B0")]
		public static Id32<LocalVariables.M> CEYLNTHUITN(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B95140", Offset = "0x2B93B40", VA = "0x182B95140")]
		public static Id32<LocalVariables.M> URBQNMVISCA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B934A0", Offset = "0x2B91EA0", VA = "0x182B934A0")]
		public static Id32<LocalVariables.M> LUWSTIIVFCJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B95EC0", Offset = "0x2B948C0", VA = "0x182B95EC0")]
		public static Id32<LocalVariables.M> ZOVIKPBIOHT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B91210", Offset = "0x2B8FC10", VA = "0x182B91210")]
		public static Id32<LocalVariables.M> BQQJFQQBTXM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B92DB0", Offset = "0x2B917B0", VA = "0x182B92DB0")]
		public static Id32<LocalVariables.M> KYKDDLKVGID(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B91D20", Offset = "0x2B90720", VA = "0x182B91D20")]
		public static Id32<LocalVariables.M> EXIOXQLBTQW(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B94290", Offset = "0x2B92C90", VA = "0x182B94290")]
		public static Id32<LocalVariables.M> RMMVKWIYHUB(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B94140", Offset = "0x2B92B40", VA = "0x182B94140")]
		public static void QJLRSWNIJCE(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B957D0", Offset = "0x2B941D0", VA = "0x182B957D0")]
		public static Id32<LocalVariables.M> WZMPPIRGXUD(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B92C90", Offset = "0x2B91690", VA = "0x182B92C90")]
		public static Id32<LocalVariables.M> KVENVWTNWUA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B92FE0", Offset = "0x2B919E0", VA = "0x182B92FE0")]
		public static Id32<LocalVariables.M> LBYRFZCEJAR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B931A0", Offset = "0x2B91BA0", VA = "0x182B931A0")]
		public static Id32<LocalVariables.M> LRDXSOQSXTT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B90BD0", Offset = "0x2B8F5D0", VA = "0x182B90BD0")]
		public static Id32<LocalVariables.M> ALLPOZDLJKC(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B927B0", Offset = "0x2B911B0", VA = "0x182B927B0")]
		public static Id32<LocalVariables.M> JFUOHSEQCTJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B94550", Offset = "0x2B92F50", VA = "0x182B94550")]
		public static Id32<LocalVariables.M> SCWUEJBYCKT(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B93720", Offset = "0x2B92120", VA = "0x182B93720")]
		public static Id32<LocalVariables.M> MCXVKGPQNNK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B90CF0", Offset = "0x2B8F6F0", VA = "0x182B90CF0")]
		public static Id32<LocalVariables.M> ARAZXKKXKRV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B92B50", Offset = "0x2B91550", VA = "0x182B92B50")]
		public static Id32<LocalVariables.M> KLNTLWHIYKO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3D51930", Offset = "0x3D50330", VA = "0x183D51930")]
		public static void SEAJJUONSMD<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<KXFBWSJODNE> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3D502B0", Offset = "0x3D4ECB0", VA = "0x183D502B0")]
		public static void LFCWXHKSLFD<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<BHDVXGKWBTW> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3D50CA0", Offset = "0x3D4F6A0", VA = "0x183D50CA0")]
		public static Id32<LocalVariables.M> PAHPXZQVSOP<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3D51410", Offset = "0x3D4FE10", VA = "0x183D51410")]
		public static Id32<LocalVariables.M> RQRFLMDVZTW<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3D4FC90", Offset = "0x3D4E690", VA = "0x183D4FC90")]
		public static Id32<DataBackResults.M> HAZOPOVXFEZ<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, MCUQWFOUSFS<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3D4FFB0", Offset = "0x3D4E9B0", VA = "0x183D4FFB0")]
		public static Id32<ExecForwardResults.M> KVGLDJDOGCC<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, MCUQWFOUSFS<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B95680", Offset = "0x2B94080", VA = "0x182B95680")]
		public static Id32<DataBackResults.M> WMMYFXDNBNI(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B92160", Offset = "0x2B90B60", VA = "0x182B92160")]
		public static Id32<DataBackResults.M> HGIQVQABDVG(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3D4F310", Offset = "0x3D4DD10", VA = "0x183D4F310")]
		public static Id32<DataBackResults.M> ECBZCPPKJKH<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<KXFBWSJODNE> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3D4F0A0", Offset = "0x3D4DAA0", VA = "0x183D4F0A0")]
		private static Id32<DataBackResults.M> ECBZCPPKJKH<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<KXFBWSJODNE> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3D50FC0", Offset = "0x3D4F9C0", VA = "0x183D50FC0")]
		public static Id32<LocalVariables.M> POGOJVEXZRZ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3D520D0", Offset = "0x3D50AD0", VA = "0x183D520D0")]
		public static void TJQDCNSXJUO<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<GAIDVDAKGEP<JWUJAMRKFPU>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<GAIDVDAKGEP<JWUJAMRKFPU>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
		public LiveInterval(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> firstUse, Id32<GAIDVDAKGEP<JWUJAMRKFPU>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D470", Offset = "0x2B8BE70", VA = "0x182B8D470")]
		public static LiveInterval New(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class OGCJXIXVULM : ILNIRALUQAV
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
			[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class BGYWGCPOMTE : ILNIRALUQAV
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class KPWZCZWQRBT : ILNIRALUQAV
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
			[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
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
		public abstract class ILNIRALUQAV
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
			public Id32<ILNIRALUQAV> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D3A0", Offset = "0x2B8BDA0", VA = "0x182B8D3A0")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<ILNIRALUQAV> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class IDLVZEAPUOQ : ILNIRALUQAV
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<OGCJXIXVULM, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<KPWZCZWQRBT, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<IDLVZEAPUOQ, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<BGYWGCPOMTE, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D670", Offset = "0x2B8C070", VA = "0x182B8D670")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<OGCJXIXVULM, ArgumentInst> argumentVariables, [In] SOAId32Field<KPWZCZWQRBT, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<IDLVZEAPUOQ, ParameterInst> parameterVariables, [In] SOAId32Field<BGYWGCPOMTE, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D480", Offset = "0x2B8BE80", VA = "0x182B8D480")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class AQAWQGUSCYJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AEC0", Offset = "0x2B898C0", VA = "0x182B8AEC0")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class UYZDAKZHRZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B96950", Offset = "0x2B95350", VA = "0x182B96950")]
		public static void KJOHUMGZAWL(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.UIVDZVGUGWB, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BDA0", Offset = "0x2B8A7A0", VA = "0x182B8BDA0")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.UIVDZVGUGWB, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BD30", Offset = "0x2B8A730", VA = "0x182B8BD30")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BB10", Offset = "0x2B8A510", VA = "0x182B8BB10")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x36906A0", Offset = "0x368F0A0", VA = "0x1836906A0")]
		public static void KJOHUMGZAWL<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<EVDWFGHNUCH> graphId) where TDeps : notnull, MCUQWFOUSFS<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class OTQQIQRDHTY
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B95FC0", Offset = "0x2B949C0", VA = "0x182B95FC0")]
		public static void KJOHUMGZAWL(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface BOTFITQCLOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void POWKRSSBPHM(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : BOTFITQCLOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2B96330", Offset = "0x2B94D30", VA = "0x182B96330", Slot = "4")]
			public void POWKRSSBPHM(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : BOTFITQCLOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2B963C0", Offset = "0x2B94DC0", VA = "0x182B963C0", Slot = "4")]
			public void POWKRSSBPHM(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : BOTFITQCLOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2B961F0", Offset = "0x2B94BF0", VA = "0x182B961F0", Slot = "4")]
			public void POWKRSSBPHM(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : BOTFITQCLOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2B96280", Offset = "0x2B94C80", VA = "0x182B96280", Slot = "4")]
			public void POWKRSSBPHM(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class KPRQOMNXLJT<c> where c : struct, BOTFITQCLOR
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c RATSQORCBWB;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x395A1C0", Offset = "0x3958BC0", VA = "0x18395A1C0")]
			public static int KJOHUMGZAWL<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : MCUQWFOUSFS<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<FunctionCalls.UIVDZVGUGWB>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D350", Offset = "0x2B8BD50", VA = "0x182B8D350")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<FunctionCalls.UIVDZVGUGWB>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D2A0", Offset = "0x2B8BCA0", VA = "0x182B8D2A0")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D260", Offset = "0x2B8BC60", VA = "0x182B8D260")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B48D10", Offset = "0x3B47710", VA = "0x183B48D10")]
		public static void KJOHUMGZAWL<b, a>(FunctionCompileState a, b b, a c) where b : MCUQWFOUSFS<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class NOSWDFCUOVR
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
		private static int PIUEWUADFCT;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int CTXMTILDPOJ;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FD90", Offset = "0x2B8E790", VA = "0x182B8FD90")]
		public static void KJOHUMGZAWL(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B90590", Offset = "0x2B8EF90", VA = "0x182B90590")]
		private static void SJPKNSHQCQS([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B90450", Offset = "0x2B8EE50", VA = "0x182B90450")]
		private static void SJPKNSHQCQS(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B902F0", Offset = "0x2B8ECF0", VA = "0x182B902F0")]
		private static void PFXRKHKNAHD(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class ALVXZWJPPNN<a, b, c> where a : struct, HSIFALXGUYH<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a RATSQORCBWB;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x72E9E80", Offset = "0x72E8880", VA = "0x1872E9E80")]
		public static void KJOHUMGZAWL([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface HSIFALXGUYH<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> DPDPVSGTEHR(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LICSDUNWKKJ(a a, b b, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface ELJVRPYFVIO<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a ECYWKNAVARU(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MZLDUKZDFCY(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class MBAWRWFOMPU<a, b, c> where a : struct, ELJVRPYFVIO<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a RATSQORCBWB;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x70154E0", Offset = "0x7013EE0", VA = "0x1870154E0")]
		public static UnsafeList<b> KJOHUMGZAWL(int a, [In] c values)
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
