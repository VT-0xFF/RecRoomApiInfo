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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B90E30", Offset = "0x2B90230", VA = "0x182B90E30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B22620", Offset = "0x2B21A20", VA = "0x182B22620")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B8C1C0", Offset = "0x2B8B5C0", VA = "0x182B8C1C0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x23978B0", Offset = "0x2396CB0", VA = "0x1823978B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8C370", Offset = "0x2B8B770", VA = "0x182B8C370")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<ZJSOGHREJFH, BytesImmediate> bytesImmediates, [In] IdUnsafeList<ILKCXZTLSHC, DeadEnd> deadEnds, [In] IdUnsafeList<ZEMYMOTVRVL, Variable> variables, [In] IdUnsafeList<USUSTTMPXGX, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C230", Offset = "0x2B8B630", VA = "0x182B8C230")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class KUTEFZDPFCS
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D7A0", Offset = "0x2B8CBA0", VA = "0x182B8D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8C4E0", Offset = "0x2B8B8E0", VA = "0x182B8C4E0")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<GJNVTMORZNS, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C450", Offset = "0x2B8B850", VA = "0x182B8C450")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class OZGBIEUZFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B96570", Offset = "0x2B95970", VA = "0x182B96570")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8C5C0", Offset = "0x2B8B9C0", VA = "0x182B8C5C0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C520", Offset = "0x2B8B920", VA = "0x182B8C520")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class EBOUGKJLLQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C400", Offset = "0x2B8B800", VA = "0x182B8C400")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
			private Inst(Def def, Id32<ILNIRALUQAV> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D770", Offset = "0x2B8CB70", VA = "0x182B8D770")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8C4E0", Offset = "0x2B8B8E0", VA = "0x182B8C4E0")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D5C0", Offset = "0x2B8C9C0", VA = "0x182B8D5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8C7C0", Offset = "0x2B8BBC0", VA = "0x182B8C7C0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<FILGLFIIENC, InternalCall> internalCalls, [In] IdUnsafeList<SSPBABIAAIC, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<UIVDZVGUGWB> IOId)> callsWithIO, [In] IdUnsafeList<UIVDZVGUGWB, IO> io, [In] SOAField<UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> ioModifyingCallLocations, [In] SOAField<UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C620", Offset = "0x2B8BA20", VA = "0x182B8C620")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class NXNOLLLBEWG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B90BD0", Offset = "0x2B8FFD0", VA = "0x182B90BD0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B90C20", Offset = "0x2B90020", VA = "0x182B90C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8D210", Offset = "0x2B8C610", VA = "0x182B8D210")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<FOQLRVXTRHG, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<FOQLRVXTRHG>> generatedOutputsForExpression, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C880", Offset = "0x2B8BC80", VA = "0x182B8C880")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B968A0", Offset = "0x2B95CA0", VA = "0x182B968A0")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B96860", Offset = "0x2B95C60", VA = "0x182B96860", Slot = "4")]
			public Id32<FunctionCalls.UIVDZVGUGWB> ECYWKNAVARU(int a)
			{
				return default(Id32<FunctionCalls.UIVDZVGUGWB>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0")]
			public bool MZLDUKZDFCY(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "5")]
			private bool GWKBYYJKFGC(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B96850", Offset = "0x2B95C50", VA = "0x182B96850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8B360", Offset = "0x2B8A760", VA = "0x182B8B360")]
			public UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>> DPDPVSGTEHR(int a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B470", Offset = "0x2B8A870", VA = "0x182B8B470")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B3D0", Offset = "0x2B8A7D0", VA = "0x182B8B3D0", Slot = "6")]
			public void LICSDUNWKKJ(Id32<FunctionCalls.UIVDZVGUGWB> a, SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> b, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B360", Offset = "0x2B8A760", VA = "0x182B8B360", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>> GWTVHLOVGKK(int a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B350", Offset = "0x2B8A750", VA = "0x182B8B350", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B96960", Offset = "0x2B95D60", VA = "0x182B96960")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B96920", Offset = "0x2B95D20", VA = "0x182B96920", Slot = "4")]
			public Id32<FunctionCalls.UIVDZVGUGWB> ECYWKNAVARU(int a)
			{
				return default(Id32<FunctionCalls.UIVDZVGUGWB>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0")]
			public bool MZLDUKZDFCY(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "5")]
			private bool KLLKWECEOXV(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B969E0", Offset = "0x2B95DE0", VA = "0x182B969E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8B4F0", Offset = "0x2B8A8F0", VA = "0x182B8B4F0")]
			public UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>> DPDPVSGTEHR(int a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B600", Offset = "0x2B8AA00", VA = "0x182B8B600")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<FunctionCalls.UIVDZVGUGWB> a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B560", Offset = "0x2B8A960", VA = "0x182B8B560", Slot = "6")]
			public void LICSDUNWKKJ(Id32<FunctionCalls.UIVDZVGUGWB> a, SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> b, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B4F0", Offset = "0x2B8A8F0", VA = "0x182B8B4F0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>> TJANVZTLZBJ(int a, [In] SOAField<FunctionCalls.UIVDZVGUGWB, Id32<GAIDVDAKGEP<KEENRFCLFXX>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UIVDZVGUGWB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B680", Offset = "0x2B8AA80", VA = "0x182B8B680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B96AA0", Offset = "0x2B95EA0", VA = "0x182B96AA0")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<NTSCAYGKXQL> a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2B969F0", Offset = "0x2B95DF0", VA = "0x182B969F0", Slot = "4")]
			public Id32<NTSCAYGKXQL> ECYWKNAVARU(int a)
			{
				return default(Id32<NTSCAYGKXQL>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B96A40", Offset = "0x2B95E40", VA = "0x182B96A40")]
			public bool MZLDUKZDFCY(Id32<NTSCAYGKXQL> a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B96A40", Offset = "0x2B95E40", VA = "0x182B96A40", Slot = "5")]
			private bool UVGCVJRGDMF(Id32<NTSCAYGKXQL> a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B96A30", Offset = "0x2B95E30", VA = "0x182B96A30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8B690", Offset = "0x2B8AA90", VA = "0x182B8B690")]
			public UnsafeList<Id32<NTSCAYGKXQL>> DPDPVSGTEHR(int a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(UnsafeList<Id32<NTSCAYGKXQL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B810", Offset = "0x2B8AC10", VA = "0x182B8B810")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(Id32<NTSCAYGKXQL> a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B700", Offset = "0x2B8AB00", VA = "0x182B8B700", Slot = "6")]
			public void LICSDUNWKKJ(Id32<NTSCAYGKXQL> a, SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> b, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B690", Offset = "0x2B8AA90", VA = "0x182B8B690", Slot = "4")]
			private UnsafeList<Id32<NTSCAYGKXQL>> GPDHWCTWULP(int a, [In] SOAField<NTSCAYGKXQL, Id32<GAIDVDAKGEP<JWUJAMRKFPU>>?> values)
			{
				return default(UnsafeList<Id32<NTSCAYGKXQL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B800", Offset = "0x2B8AC00", VA = "0x182B8B800", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B96CA0", Offset = "0x2B960A0", VA = "0x182B96CA0")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD59D60", Offset = "0xD59160", VA = "0x180D59D60", Slot = "4")]
			public int ECYWKNAVARU(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0")]
			public bool MZLDUKZDFCY(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "5")]
			private bool HFTJVQGGOUM(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B96C90", Offset = "0x2B96090", VA = "0x182B96C90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8BCE0", Offset = "0x2B8B0E0", VA = "0x182B8BCE0")]
			public UnsafeList<int> DPDPVSGTEHR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BE50", Offset = "0x2B8B250", VA = "0x182B8BE50")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BD50", Offset = "0x2B8B150", VA = "0x182B8BD50", Slot = "6")]
			public void LICSDUNWKKJ(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BCE0", Offset = "0x2B8B0E0", VA = "0x182B8BCE0", Slot = "4")]
			private UnsafeList<int> HIVMRVDOWUS(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<GAIDVDAKGEP<WHMLTPZNLLH<JPZFXDVMDNP>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BEE0", Offset = "0x2B8B2E0", VA = "0x182B8BEE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B96BF0", Offset = "0x2B95FF0", VA = "0x182B96BF0")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD59D60", Offset = "0xD59160", VA = "0x180D59D60", Slot = "4")]
			public int ECYWKNAVARU(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0")]
			public bool MZLDUKZDFCY(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "5")]
			private bool EPZTNWBFXCT(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B96C80", Offset = "0x2B96080", VA = "0x182B96C80", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8BAE0", Offset = "0x2B8AEE0", VA = "0x182B8BAE0")]
			public UnsafeList<int> DPDPVSGTEHR(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BC50", Offset = "0x2B8B050", VA = "0x182B8BC50")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BB50", Offset = "0x2B8AF50", VA = "0x182B8BB50", Slot = "6")]
			public void LICSDUNWKKJ(int a, UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BAE0", Offset = "0x2B8AEE0", VA = "0x182B8BAE0", Slot = "4")]
			private UnsafeList<int> QUXERYXZODL(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BAD0", Offset = "0x2B8AED0", VA = "0x182B8BAD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B96B50", Offset = "0x2B95F50", VA = "0x182B96B50")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD59D60", Offset = "0xD59160", VA = "0x180D59D60", Slot = "4")]
			public int ECYWKNAVARU(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0")]
			public bool MZLDUKZDFCY(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "5")]
			private bool EPZTNWBFXCT(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2B96BE0", Offset = "0x2B95FE0", VA = "0x182B96BE0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8B8D0", Offset = "0x2B8ACD0", VA = "0x182B8B8D0")]
			public UnsafeList<int> DPDPVSGTEHR(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BA40", Offset = "0x2B8AE40", VA = "0x182B8BA40")]
			public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> TCUGSCWCHGJ(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B940", Offset = "0x2B8AD40", VA = "0x182B8B940", Slot = "6")]
			public void LICSDUNWKKJ(int a, UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B8D0", Offset = "0x2B8ACD0", VA = "0x182B8B8D0", Slot = "4")]
			private UnsafeList<int> QUXERYXZODL(int a, [In] UnsafeList<(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> Target, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B8C0", Offset = "0x2B8ACC0", VA = "0x182B8B8C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1CC64E0", Offset = "0x1CC58E0", VA = "0x181CC64E0")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D5B0", Offset = "0x2B8C9B0", VA = "0x182B8D5B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8D590", Offset = "0x2B8C990", VA = "0x182B8D590")]
			public GenerateDataBackFromInputIndexResult(Id32<NTSCAYGKXQL> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D560", Offset = "0x2B8C960", VA = "0x182B8D560")]
			public void PUDYXZFHDAC([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D570", Offset = "0x2B8C970", VA = "0x182B8D570")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
			public GenerateDataBackFromInputIndicesResult(Id32<NTSCAYGKXQL> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D5A0", Offset = "0x2B8C9A0", VA = "0x182B8D5A0")]
			public void PUDYXZFHDAC([Out] Id32<DataBackResults.M> a, [Out] Id32<NTSCAYGKXQL> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF90", Offset = "0x2B8D390", VA = "0x182B8DF90")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF00", Offset = "0x2B8D300", VA = "0x182B8DF00")]
		public static void DLKDMWAGTUL(this FunctionCompileState a, Id32<FOQLRVXTRHG> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F4F0", Offset = "0x2B8E8F0", VA = "0x182B8F4F0")]
		public static void RQRUJTYRGUV(this FunctionCompileState a, Id32<FOQLRVXTRHG> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FDC0", Offset = "0x2B8F1C0", VA = "0x182B8FDC0")]
		public static Id32<DataBackResults.M>? XRFLVGKBMBE([In] this FunctionCompileState self, Id32<FOQLRVXTRHG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E370", Offset = "0x2B8D770", VA = "0x182B8E370")]
		public static Id32<GAIDVDAKGEP<JWUJAMRKFPU>> FDKNIIDFRUS([In] this FunctionCompileState self)
		{
			return default(Id32<GAIDVDAKGEP<JWUJAMRKFPU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FFD0", Offset = "0x2B8F3D0", VA = "0x182B8FFD0")]
		private static void ZZBYROGYWZD(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EFA0", Offset = "0x2B8E3A0", VA = "0x182B8EFA0")]
		private static Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? OHMHAIGEFSC([In] this FunctionCompileState self, Id32<NTSCAYGKXQL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E3D0", Offset = "0x2B8D7D0", VA = "0x182B8E3D0")]
		public static void FHMPMJFAVWW(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DB80", Offset = "0x2B8CF80", VA = "0x182B8DB80")]
		public static DataBackResults.Def AFMODARDQIA([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EEC0", Offset = "0x2B8E2C0", VA = "0x182B8EEC0")]
		public static ReadOnlyArray<byte> OCQXKCVNOMQ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DBF0", Offset = "0x2B8CFF0", VA = "0x182B8DBF0")]
		public static Id32<LocalVariables.M> BHWGEGKLNDS([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E990", Offset = "0x2B8DD90", VA = "0x182B8E990")]
		public static Union32 HDINAVHNGVM([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C00370", Offset = "0x3BFF770", VA = "0x183C00370")]
		private static Id32<DataBackResults.M> FYCCRBATWYH<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.ILNIRALUQAV
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FE40", Offset = "0x2B8F240", VA = "0x182B8FE40")]
		public static Id32<DataBackResults.M> XZFHQNCLBAP(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EC80", Offset = "0x2B8E080", VA = "0x182B8EC80")]
		public static Id32<DataBackResults.M> JLIBDRASCVU(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FA10", Offset = "0x2B8EE10", VA = "0x182B8FA10")]
		public static Id32<DataBackResults.M> TFADVYOJUYV(this FunctionCompileState a, Id32<GAIDVDAKGEP<JWUJAMRKFPU>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F020", Offset = "0x2B8E420", VA = "0x182B8F020")]
		public static Id32<DataBackResults.M> OJDHBSSEBUN(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FEC0", Offset = "0x2B8F2C0", VA = "0x182B8FEC0")]
		public static Id32<DataBackResults.M> YTXJDSDQEEK(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C002D0", Offset = "0x3BFF6D0", VA = "0x183C002D0")]
		private static Id32<ExecForwardResults.M> FNQZUXJXZFK<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.ILNIRALUQAV
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DCD0", Offset = "0x2B8D0D0", VA = "0x182B8DCD0")]
		public static Id32<ExecForwardResults.M> BNWMXUHWXIA(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EE70", Offset = "0x2B8E270", VA = "0x182B8EE70")]
		public static Id32<ExecForwardResults.M> MVAUGABMTAN(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FC30", Offset = "0x2B8F030", VA = "0x182B8FC30")]
		public static Id32<ExecForwardResults.M> WVCFWQZAZCZ(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E5B0", Offset = "0x2B8D9B0", VA = "0x182B8E5B0")]
		public static Id32<ExecForwardResults.M> GBZMHPFIMYW(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EE20", Offset = "0x2B8E220", VA = "0x182B8EE20")]
		public static Id32<ExecForwardResults.M> LPKUDIZZFTC(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FB30", Offset = "0x2B8EF30", VA = "0x182B8FB30")]
		public static FunctionCalls.Def UYXRMDLUTAB([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F4B0", Offset = "0x2B8E8B0", VA = "0x182B8F4B0")]
		public static CopyEnumerable<Id32<FunctionCalls.UIVDZVGUGWB>, Id32Enumerator<FunctionCalls.UIVDZVGUGWB>> RDSUSHIWSDS([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.UIVDZVGUGWB>, Id32Enumerator<FunctionCalls.UIVDZVGUGWB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E600", Offset = "0x2B8DA00", VA = "0x182B8E600")]
		public static Id32<FunctionCalls.UIVDZVGUGWB> GCHAASIXAWH([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.UIVDZVGUGWB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E540", Offset = "0x2B8D940", VA = "0x182B8E540")]
		public static FunctionCalls.IO FTLHKBMOPJQ([In] this FunctionCompileState self, Id32<FunctionCalls.UIVDZVGUGWB> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F820", Offset = "0x2B8EC20", VA = "0x182B8F820")]
		public static FunctionCalls.IO SRZGBPRQPCI(this FunctionCompileState a, Id32<FunctionCalls.UIVDZVGUGWB> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C00240", Offset = "0x3BFF640", VA = "0x183C00240")]
		private static Id32<FunctionCalls.M> ETLLRBLOOBN<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.ILNIRALUQAV
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F300", Offset = "0x2B8E700", VA = "0x182B8F300")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>) QYMHZHVFYZM(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA70", Offset = "0x2B8DE70", VA = "0x182B8EA70")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>) IDVXBCWOFCQ(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FA90", Offset = "0x2B8EE90", VA = "0x182B8FA90")]
		public static Id32<FunctionCalls.M> TXRBLIYCLLH(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FF40", Offset = "0x2B8F340", VA = "0x182B8FF40")]
		public static void ZPWNTFNQYPO(this FunctionCompileState a, Id32<FunctionCalls.UIVDZVGUGWB> b, Id32<GAIDVDAKGEP<JWUJAMRKFPU>> c, Id32<GAIDVDAKGEP<KEENRFCLFXX>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C00A20", Offset = "0x3BFFE20", VA = "0x183C00A20")]
		public static GenerateDataBackResult JBIBWHZJJNI<d, e>(this FunctionCompileState a, d b, e c, Id32<EVDWFGHNUCH> d, Id32<NTSCAYGKXQL> e) where d : MCUQWFOUSFS<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C005D0", Offset = "0x3BFF9D0", VA = "0x183C005D0")]
		public static GenerateDataBackFromInputIndexResult IMOLEXXDXVU<f, g>(this FunctionCompileState a, f b, g c, Id32<EVDWFGHNUCH> d, Id32<IHXSJTKSKEJ> e, int f) where f : MCUQWFOUSFS<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3C01E20", Offset = "0x3C01220", VA = "0x183C01E20")]
		public static Id32<DataBackResults.M>? MPCLIXOPTZN<h, i>(this FunctionCompileState a, h b, i c, Id32<EVDWFGHNUCH> d, Id32<IHXSJTKSKEJ> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : MCUQWFOUSFS<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3BFFA20", Offset = "0x3BFEE20", VA = "0x183BFFA20")]
		public static Id32<ExecForwardResults.M> DGZPATLDGAN<j, k>(this FunctionCompileState a, j b, k c, Id32<EVDWFGHNUCH> d, Id32<FOQLRVXTRHG> e) where j : MCUQWFOUSFS<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FCB0", Offset = "0x2B8F0B0", VA = "0x182B8FCB0")]
		public static LocalVariables.ArgumentInst WWHMWUKEBCV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E7D0", Offset = "0x2B8DBD0", VA = "0x182B8E7D0")]
		public static LocalVariables.CalleeReturnValueInst GHUPUGZFKUH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E260", Offset = "0x2B8D660", VA = "0x182B8E260")]
		public static LocalVariables.CallerReturnValueInst ESLOYOYLXWI([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F0F0", Offset = "0x2B8E4F0", VA = "0x182B8F0F0")]
		public static Id32<LocalVariables.M> OMQXUQUTVOQ(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ED10", Offset = "0x2B8E110", VA = "0x182B8ED10")]
		public static LocalVariables.ParameterInst LNWXDCJKAQF([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F0A0", Offset = "0x2B8E4A0", VA = "0x182B8F0A0")]
		public static LocalVariables.Def OLIOWBFFHNX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FAE0", Offset = "0x2B8EEE0", VA = "0x182B8FAE0")]
		public static int? UUQYIRKAGLR([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C02380", Offset = "0x3C01780", VA = "0x183C02380")]
		private static Id32<LocalVariables.M> VQLYPPMJIFR<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.ILNIRALUQAV
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F5C0", Offset = "0x2B8E9C0", VA = "0x182B8F5C0")]
		public static Id32<LocalVariables.M> SMQTZQYOYGT(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EC20", Offset = "0x2B8E020", VA = "0x182B8EC20")]
		public static Id32<LocalVariables.M> JKZRRBYZLEQ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F890", Offset = "0x2B8EC90", VA = "0x182B8F890")]
		public static Id32<LocalVariables.M> SZQGJQQHOKA(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F670", Offset = "0x2B8EA70", VA = "0x182B8F670")]
		public static Id32<LocalVariables.M> SQAKARXCJNM(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F2A0", Offset = "0x2B8E6A0", VA = "0x182B8F2A0")]
		public static Id32<LocalVariables.M> QFNYJLCYVOS(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F700", Offset = "0x2B8EB00", VA = "0x182B8F700")]
		public static void SQAQDFMZLPJ(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DD10", Offset = "0x2B8D110", VA = "0x182B8DD10")]
		public static void CBQEOASDGKR(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E8E0", Offset = "0x2B8DCE0", VA = "0x182B8E8E0")]
		public static void GUCIOQTTUVP(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FBA0", Offset = "0x2B8EFA0", VA = "0x182B8FBA0")]
		public static void VMCIMSONJZE(this FunctionCompileState a, Id32<GAIDVDAKGEP<JWUJAMRKFPU>> b, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DE20", Offset = "0x2B8D220", VA = "0x182B8DE20")]
		public static void CINWMCPCRCW(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<GAIDVDAKGEP<YVGHOMRCUTJ>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3C004F0", Offset = "0x3BFF8F0", VA = "0x183C004F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D47340", Offset = "0x3D46740", VA = "0x183D47340")]
		public static Id32<LocalVariables.M?> CMLCLGXDOFS<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D476C0", Offset = "0x3D46AC0", VA = "0x183D476C0")]
		public static Id32<LocalVariables.M?> CWPLWACZCFH<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AD50", Offset = "0x3D4A150", VA = "0x183D4AD50")]
		public static Id32<LocalVariables.M?> YOFRRQYKUWE<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B94120", Offset = "0x2B93520", VA = "0x182B94120")]
		public static Id32<LocalVariables.M> PACIOOPDWKU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B913B0", Offset = "0x2B907B0", VA = "0x182B913B0")]
		public static Id32<LocalVariables.M> BEKKIAMWXKX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B93E40", Offset = "0x2B93240", VA = "0x182B93E40")]
		public static Id32<LocalVariables.M> NLDJGNEAMBE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B92A90", Offset = "0x2B91E90", VA = "0x182B92A90")]
		public static Id32<LocalVariables.M> IUGOVAGPBZI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B914D0", Offset = "0x2B908D0", VA = "0x182B914D0")]
		public static Id32<LocalVariables.M> BHVKVYJTEJX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B91270", Offset = "0x2B90670", VA = "0x182B91270")]
		public static Id32<LocalVariables.M> AWSFDEJEZME(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B93D40", Offset = "0x2B93140", VA = "0x182B93D40")]
		public static Id32<LocalVariables.M> NEOJDPPBNMM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B95380", Offset = "0x2B94780", VA = "0x182B95380")]
		public static Id32<LocalVariables.M> UBLDHOCHAAH(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B92400", Offset = "0x2B91800", VA = "0x182B92400")]
		public static Id32<LocalVariables.M> GZZBMHJIKYK(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B95CB0", Offset = "0x2B950B0", VA = "0x182B95CB0")]
		public static Id32<LocalVariables.M> XOGMGSHYMZF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B96040", Offset = "0x2B95440", VA = "0x182B96040")]
		public static Id32<LocalVariables.M> ZEIVDXIYVMU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B94530", Offset = "0x2B93930", VA = "0x182B94530")]
		public static Id32<LocalVariables.M> QPXOSOHWDDP(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B92990", Offset = "0x2B91D90", VA = "0x182B92990")]
		public static Id32<LocalVariables.M> IGZUJMDZOKC(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B94780", Offset = "0x2B93B80", VA = "0x182B94780")]
		public static Id32<LocalVariables.M> RXKGHSBCULD(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B93C00", Offset = "0x2B93000", VA = "0x182B93C00")]
		public static Id32<LocalVariables.M> MJNMNJYZTAE(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B92280", Offset = "0x2B91680", VA = "0x182B92280")]
		public static Id32<LocalVariables.M> FTGJAIREGEI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B92870", Offset = "0x2B91C70", VA = "0x182B92870")]
		public static Id32<LocalVariables.M> HMROASLTTYT(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B94080", Offset = "0x2B93480", VA = "0x182B94080")]
		public static Id32<LocalVariables.M> OHGCJDXLKAK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B91710", Offset = "0x2B90B10", VA = "0x182B91710")]
		public static Id32<LocalVariables.M> CESFMDUXKSJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B942A0", Offset = "0x2B936A0", VA = "0x182B942A0")]
		public static Id32<LocalVariables.M> PRHXWXJJUJQ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B911F0", Offset = "0x2B905F0", VA = "0x182B911F0")]
		public static Id32<LocalVariables.M> AVOZDIQNSBF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B954A0", Offset = "0x2B948A0", VA = "0x182B954A0")]
		public static Id32<LocalVariables.M> UMZPZKUZBKF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B93500", Offset = "0x2B92900", VA = "0x182B93500")]
		public static Id32<LocalVariables.M> LJMQBHJZROC(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B94220", Offset = "0x2B93620", VA = "0x182B94220")]
		public static Id32<LocalVariables.M> PBUUOROZQRF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B948B0", Offset = "0x2B93CB0", VA = "0x182B948B0")]
		public static Id32<LocalVariables.M> SCBHZTDZKTK(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B94000", Offset = "0x2B93400", VA = "0x182B94000")]
		public static Id32<LocalVariables.M> OFLZSZZGJWX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B91890", Offset = "0x2B90C90", VA = "0x182B91890")]
		public static Id32<LocalVariables.M> CYJJLWZTBOC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B95740", Offset = "0x2B94B40", VA = "0x182B95740")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> VSBCFSQNKPI(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B92380", Offset = "0x2B91780", VA = "0x182B92380")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> GCQIBQABWQW(this FunctionCompileState a, int b)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B95EB0", Offset = "0x2B952B0", VA = "0x182B95EB0")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> YVQOSZMUAHX(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B93680", Offset = "0x2B92A80", VA = "0x182B93680")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> LUDKRMTPOXR(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B93F80", Offset = "0x2B93380", VA = "0x182B93F80")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> NQEEFYCWQGX(this FunctionCompileState a, int b)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B928F0", Offset = "0x2B91CF0", VA = "0x182B928F0")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> HWDLEDWRRQM(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B94DC0", Offset = "0x2B941C0", VA = "0x182B94DC0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>) SPPRYPVPTUV(this FunctionCompileState a, Id32<KXFBWSJODNE> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B91C60", Offset = "0x2B91060", VA = "0x182B91C60")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>) EKPUXYAPKNF(this FunctionCompileState a, Id32<BHDVXGKWBTW> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UIVDZVGUGWB>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D493A0", Offset = "0x3D487A0", VA = "0x183D493A0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<UXTEGGEVDNB>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<TMarker>>, Id32<FunctionCalls.M>) LJHELQBJJQU<TMarker>(this FunctionCompileState a, Id32<UXTEGGEVDNB> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<UXTEGGEVDNB>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B94320", Offset = "0x2B93720", VA = "0x182B94320")]
		public static Id32<LocalVariables.M> PYRFRXKBAOW(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B95F50", Offset = "0x2B95350", VA = "0x182B95F50")]
		public static Id32<LocalVariables.M> ZCEFQAVAKKZ(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B932D0", Offset = "0x2B926D0", VA = "0x182B932D0")]
		public static Id32<LocalVariables.M> KZOHGYVLZDE(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B92E10", Offset = "0x2B92210", VA = "0x182B92E10")]
		public static Id32<LocalVariables.M> KHCJDNYGDGV(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B90EB0", Offset = "0x2B902B0", VA = "0x182B90EB0")]
		public static Id32<LocalVariables.M> AEZOYBXNNOO(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B95260", Offset = "0x2B94660", VA = "0x182B95260")]
		public static Id32<LocalVariables.M> TKHPXNGUSKV(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B943E0", Offset = "0x2B937E0", VA = "0x182B943E0")]
		public static Id32<LocalVariables.M> PZJFBOFCROU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B95DB0", Offset = "0x2B951B0", VA = "0x182B95DB0")]
		public static Id32<LocalVariables.M> XTEBSCUQYHO(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B95940", Offset = "0x2B94D40", VA = "0x182B95940")]
		public static Id32<LocalVariables.M> WFENAOWXBDJ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B92CD0", Offset = "0x2B920D0", VA = "0x182B92CD0")]
		public static Id32<LocalVariables.M> KAKGANAYBJI(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B92200", Offset = "0x2B91600", VA = "0x182B92200")]
		public static Id32<LocalVariables.M> EYXATNRJMJL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B94D40", Offset = "0x2B94140", VA = "0x182B94D40")]
		public static Id32<LocalVariables.M> SLMTEHFVWAS(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B92300", Offset = "0x2B91700", VA = "0x182B92300")]
		public static Id32<LocalVariables.M> FTZMNOIEUYP(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B95640", Offset = "0x2B94A40", VA = "0x182B95640")]
		public static Id32<LocalVariables.M> VRSFDWJMYNX(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B91910", Offset = "0x2B90D10", VA = "0x182B91910")]
		public static Id32<LocalVariables.M> CYTTZOAWPJY(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B96160", Offset = "0x2B95560", VA = "0x182B96160")]
		public static Id32<LocalVariables.M> ZKEBVGWCMLN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B91A40", Offset = "0x2B90E40", VA = "0x182B91A40")]
		public static Id32<LocalVariables.M> EBCGFYWFHAY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B91B40", Offset = "0x2B90F40", VA = "0x182B91B40")]
		public static Id32<LocalVariables.M> EDSMBUEUJHB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B939C0", Offset = "0x2B92DC0", VA = "0x182B939C0")]
		public static Id32<LocalVariables.M> MCRZAUJQQPY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B94100", Offset = "0x2B93500", VA = "0x182B94100")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>> OWTLTYNEEDQ(this FunctionCompileState a)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B91790", Offset = "0x2B90B90", VA = "0x182B91790")]
		public static Id32<LocalVariables.M> CEYLNTHUITN(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B95520", Offset = "0x2B94920", VA = "0x182B95520")]
		public static Id32<LocalVariables.M> URBQNMVISCA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B93880", Offset = "0x2B92C80", VA = "0x182B93880")]
		public static Id32<LocalVariables.M> LUWSTIIVFCJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B962A0", Offset = "0x2B956A0", VA = "0x182B962A0")]
		public static Id32<LocalVariables.M> ZOVIKPBIOHT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B915F0", Offset = "0x2B909F0", VA = "0x182B915F0")]
		public static Id32<LocalVariables.M> BQQJFQQBTXM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B93190", Offset = "0x2B92590", VA = "0x182B93190")]
		public static Id32<LocalVariables.M> KYKDDLKVGID(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B92100", Offset = "0x2B91500", VA = "0x182B92100")]
		public static Id32<LocalVariables.M> EXIOXQLBTQW(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B94670", Offset = "0x2B93A70", VA = "0x182B94670")]
		public static Id32<LocalVariables.M> RMMVKWIYHUB(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B94520", Offset = "0x2B93920", VA = "0x182B94520")]
		public static void QJLRSWNIJCE(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B95BB0", Offset = "0x2B94FB0", VA = "0x182B95BB0")]
		public static Id32<LocalVariables.M> WZMPPIRGXUD(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B93070", Offset = "0x2B92470", VA = "0x182B93070")]
		public static Id32<LocalVariables.M> KVENVWTNWUA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B933C0", Offset = "0x2B927C0", VA = "0x182B933C0")]
		public static Id32<LocalVariables.M> LBYRFZCEJAR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B93580", Offset = "0x2B92980", VA = "0x182B93580")]
		public static Id32<LocalVariables.M> LRDXSOQSXTT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B90FB0", Offset = "0x2B903B0", VA = "0x182B90FB0")]
		public static Id32<LocalVariables.M> ALLPOZDLJKC(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B92B90", Offset = "0x2B91F90", VA = "0x182B92B90")]
		public static Id32<LocalVariables.M> JFUOHSEQCTJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B94930", Offset = "0x2B93D30", VA = "0x182B94930")]
		public static Id32<LocalVariables.M> SCWUEJBYCKT(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B93B00", Offset = "0x2B92F00", VA = "0x182B93B00")]
		public static Id32<LocalVariables.M> MCXVKGPQNNK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B910D0", Offset = "0x2B904D0", VA = "0x182B910D0")]
		public static Id32<LocalVariables.M> ARAZXKKXKRV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B92F30", Offset = "0x2B92330", VA = "0x182B92F30")]
		public static Id32<LocalVariables.M> KLNTLWHIYKO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A120", Offset = "0x3D49520", VA = "0x183D4A120")]
		public static void SEAJJUONSMD<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<KXFBWSJODNE> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3D48AD0", Offset = "0x3D47ED0", VA = "0x183D48AD0")]
		public static void LFCWXHKSLFD<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<BHDVXGKWBTW> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3D494B0", Offset = "0x3D488B0", VA = "0x183D494B0")]
		public static Id32<LocalVariables.M> PAHPXZQVSOP<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3D49C10", Offset = "0x3D49010", VA = "0x183D49C10")]
		public static Id32<LocalVariables.M> RQRFLMDVZTW<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3D484C0", Offset = "0x3D478C0", VA = "0x183D484C0")]
		public static Id32<DataBackResults.M> HAZOPOVXFEZ<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, MCUQWFOUSFS<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3D487D0", Offset = "0x3D47BD0", VA = "0x183D487D0")]
		public static Id32<ExecForwardResults.M> KVGLDJDOGCC<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, MCUQWFOUSFS<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B95A60", Offset = "0x2B94E60", VA = "0x182B95A60")]
		public static Id32<DataBackResults.M> WMMYFXDNBNI(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B92540", Offset = "0x2B91940", VA = "0x182B92540")]
		public static Id32<DataBackResults.M> HGIQVQABDVG(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3D47B60", Offset = "0x3D46F60", VA = "0x183D47B60")]
		public static Id32<DataBackResults.M> ECBZCPPKJKH<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<KXFBWSJODNE> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3D478F0", Offset = "0x3D46CF0", VA = "0x183D478F0")]
		private static Id32<DataBackResults.M> ECBZCPPKJKH<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<KXFBWSJODNE> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3D497C0", Offset = "0x3D48BC0", VA = "0x183D497C0")]
		public static Id32<LocalVariables.M> POGOJVEXZRZ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, MCUQWFOUSFS<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A8B0", Offset = "0x3D49CB0", VA = "0x183D4A8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
		public LiveInterval(Id32<GAIDVDAKGEP<JWUJAMRKFPU>> firstUse, Id32<GAIDVDAKGEP<JWUJAMRKFPU>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D850", Offset = "0x2B8CC50", VA = "0x182B8D850")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8D780", Offset = "0x2B8CB80", VA = "0x182B8D780")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8DA50", Offset = "0x2B8CE50", VA = "0x182B8DA50")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<OGCJXIXVULM, ArgumentInst> argumentVariables, [In] SOAId32Field<KPWZCZWQRBT, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<IDLVZEAPUOQ, ParameterInst> parameterVariables, [In] SOAId32Field<BGYWGCPOMTE, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D860", Offset = "0x2B8CC60", VA = "0x182B8D860")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class AQAWQGUSCYJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B2A0", Offset = "0x2B8A6A0", VA = "0x182B8B2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B96D30", Offset = "0x2B96130", VA = "0x182B96D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8C180", Offset = "0x2B8B580", VA = "0x182B8C180")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.UIVDZVGUGWB, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C110", Offset = "0x2B8B510", VA = "0x182B8C110")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BEF0", Offset = "0x2B8B2F0", VA = "0x182B8BEF0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3684B60", Offset = "0x3683F60", VA = "0x183684B60")]
		public static void KJOHUMGZAWL<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<EVDWFGHNUCH> graphId) where TDeps : notnull, MCUQWFOUSFS<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class OTQQIQRDHTY
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B963A0", Offset = "0x2B957A0", VA = "0x182B963A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B96710", Offset = "0x2B95B10", VA = "0x182B96710", Slot = "4")]
			public void POWKRSSBPHM(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : BOTFITQCLOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2B967A0", Offset = "0x2B95BA0", VA = "0x182B967A0", Slot = "4")]
			public void POWKRSSBPHM(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : BOTFITQCLOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2B965D0", Offset = "0x2B959D0", VA = "0x182B965D0", Slot = "4")]
			public void POWKRSSBPHM(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : BOTFITQCLOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2B96660", Offset = "0x2B95A60", VA = "0x182B96660", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x394BBA0", Offset = "0x394AFA0", VA = "0x18394BBA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8D730", Offset = "0x2B8CB30", VA = "0x182B8D730")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<FunctionCalls.UIVDZVGUGWB>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D680", Offset = "0x2B8CA80", VA = "0x182B8D680")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D640", Offset = "0x2B8CA40", VA = "0x182B8D640")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B3BC70", Offset = "0x3B3B070", VA = "0x183B3BC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B90170", Offset = "0x2B8F570", VA = "0x182B90170")]
		public static void KJOHUMGZAWL(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B90970", Offset = "0x2B8FD70", VA = "0x182B90970")]
		private static void SJPKNSHQCQS([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B90830", Offset = "0x2B8FC30", VA = "0x182B90830")]
		private static void SJPKNSHQCQS(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B906D0", Offset = "0x2B8FAD0", VA = "0x182B906D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7257920", Offset = "0x7256D20", VA = "0x187257920")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F845F0", Offset = "0x6F839F0", VA = "0x186F845F0")]
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
