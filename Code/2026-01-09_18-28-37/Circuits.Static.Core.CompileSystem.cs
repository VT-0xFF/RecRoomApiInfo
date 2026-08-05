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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D3900", Offset = "0x28D2D00", VA = "0x1828D3900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
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
		public readonly Id32<FXJTAPCMHIX<VVFCXQSNTUF>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
		public ByteCodeAdjustment(Id32<FXJTAPCMHIX<VVFCXQSNTUF>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class PSTMFICRYUZ : MHPUDTFEWYJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x28635B0", Offset = "0x28629B0", VA = "0x1828635B0")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x28CA180", Offset = "0x28C9580", VA = "0x1828CA180", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class LPIWHBMRGPW : MHPUDTFEWYJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<FXJTAPCMHIX<KGGAHYYTTGC>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
			public DeadEnd(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> nextByteCodePtr)
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
		public abstract class MHPUDTFEWYJ
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
			public readonly Id32<MHPUDTFEWYJ> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
			public Inst(Def def, Id32<MHPUDTFEWYJ> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class WNJFJMNERER : MHPUDTFEWYJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class DHWLMKZTVKD : MHPUDTFEWYJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2083EF0", Offset = "0x20832F0", VA = "0x182083EF0", Slot = "3")]
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
		internal IdUnsafeList<PSTMFICRYUZ, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<LPIWHBMRGPW, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<WNJFJMNERER, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<DHWLMKZTVKD, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28CA330", Offset = "0x28C9730", VA = "0x1828CA330")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<PSTMFICRYUZ, BytesImmediate> bytesImmediates, [In] IdUnsafeList<LPIWHBMRGPW, DeadEnd> deadEnds, [In] IdUnsafeList<WNJFJMNERER, Variable> variables, [In] IdUnsafeList<DHWLMKZTVKD, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28CA1F0", Offset = "0x28C95F0", VA = "0x1828CA1F0")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class IWGQHDACWJU
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28D3190", Offset = "0x28D2590", VA = "0x1828D3190")]
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
		public sealed class DCPYBUORTPK : MHPUDTFEWYJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
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
		public abstract class MHPUDTFEWYJ
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
			public readonly Id32<MHPUDTFEWYJ> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
			public Inst(Def def, Id32<MHPUDTFEWYJ> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<DCPYBUORTPK, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28CCA40", Offset = "0x28CBE40", VA = "0x1828CCA40")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<DCPYBUORTPK, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28CC9B0", Offset = "0x28CBDB0", VA = "0x1828CC9B0")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class NDPYFVOZNHX
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28D38A0", Offset = "0x28D2CA0", VA = "0x1828D38A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28CCB20", Offset = "0x28CBF20", VA = "0x1828CCB20")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28CCA80", Offset = "0x28CBE80", VA = "0x1828CCA80")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class GOFVKBTPFSQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28CDB70", Offset = "0x28CCF70", VA = "0x1828CDB70")]
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
		public sealed class YBPCFOVSLJQ : MHPUDTFEWYJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<WJDJLPAFOZP> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
			public ExternalCall(Id32<WJDJLPAFOZP> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class MHPUDTFEWYJ
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
			public readonly Id32<MHPUDTFEWYJ> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
			private Inst(Def def, Id32<MHPUDTFEWYJ> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28D3370", Offset = "0x28D2770", VA = "0x1828D3370")]
			public static Inst New(Def def, Id32<MHPUDTFEWYJ> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class JKOWSKLKDNK : MHPUDTFEWYJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<WJDJLPAFOZP> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
			public InternalCall(Id32<WJDJLPAFOZP> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class WJDJLPAFOZP
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
			[Cpp2IlInjected.Address(RVA = "0x28CCA40", Offset = "0x28CBE40", VA = "0x1828CCA40")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x28CDC20", Offset = "0x28CD020", VA = "0x1828CDC20")]
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
		internal IdUnsafeList<JKOWSKLKDNK, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<YBPCFOVSLJQ, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<WJDJLPAFOZP> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<WJDJLPAFOZP, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28CCD20", Offset = "0x28CC120", VA = "0x1828CCD20")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<JKOWSKLKDNK, InternalCall> internalCalls, [In] IdUnsafeList<YBPCFOVSLJQ, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<WJDJLPAFOZP> IOId)> callsWithIO, [In] IdUnsafeList<WJDJLPAFOZP, IO> io, [In] SOAField<WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> ioModifyingCallLocations, [In] SOAField<WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28CCB80", Offset = "0x28CBF80", VA = "0x1828CCB80")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class XSJPJEEGVVQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28D4EB0", Offset = "0x28D42B0", VA = "0x1828D4EB0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28D4CA0", Offset = "0x28D40A0", VA = "0x1828D4CA0")]
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
		internal SOAField<ICQMRPVUNHC, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<ICQMRPVUNHC>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28CD770", Offset = "0x28CCB70", VA = "0x1828CD770")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<ICQMRPVUNHC, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<ICQMRPVUNHC>> generatedOutputsForExpression, [In] SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28CCDE0", Offset = "0x28CC1E0", VA = "0x1828CCDE0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class ENBEWOATYDV
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : NXTEZROZYFE<Id32<FunctionCalls.WJDJLPAFOZP>, SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x28D4660", Offset = "0x28D3A60", VA = "0x1828D4660")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x28D46E0", Offset = "0x28D3AE0", VA = "0x1828D46E0", Slot = "4")]
			public Id32<FunctionCalls.WJDJLPAFOZP> WOAMPJIKQIK(int a)
			{
				return default(Id32<FunctionCalls.WJDJLPAFOZP>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90")]
			public bool QNEGVOFZGOY(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "5")]
			private bool OLDDSNWKOYW(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x28D4720", Offset = "0x28D3B20", VA = "0x1828D4720", Slot = "6")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> WVNZJSGJXIT(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : ZXZXXAIGJFN<Id32<FunctionCalls.WJDJLPAFOZP>, SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28C9390", Offset = "0x28C8790", VA = "0x1828C9390")]
			public UnsafeList<Id32<FunctionCalls.WJDJLPAFOZP>> MWKESFSWESX(int a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.WJDJLPAFOZP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x28C9310", Offset = "0x28C8710", VA = "0x1828C9310")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x28C9400", Offset = "0x28C8800", VA = "0x1828C9400", Slot = "6")]
			public void USLKZYCBIPT(Id32<FunctionCalls.WJDJLPAFOZP> a, SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> b, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x28C9390", Offset = "0x28C8790", VA = "0x1828C9390", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.WJDJLPAFOZP>> NZCIJHSXYWO(int a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.WJDJLPAFOZP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x28C94A0", Offset = "0x28C88A0", VA = "0x1828C94A0", Slot = "5")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> XIPZXZWBVYK(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : NXTEZROZYFE<Id32<FunctionCalls.WJDJLPAFOZP>, SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x28D4740", Offset = "0x28D3B40", VA = "0x1828D4740")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x28D47C0", Offset = "0x28D3BC0", VA = "0x1828D47C0", Slot = "4")]
			public Id32<FunctionCalls.WJDJLPAFOZP> WOAMPJIKQIK(int a)
			{
				return default(Id32<FunctionCalls.WJDJLPAFOZP>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90")]
			public bool QNEGVOFZGOY(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "5")]
			private bool COVJSRHCNZR(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x28D4730", Offset = "0x28D3B30", VA = "0x1828D4730", Slot = "6")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> FBEBDHMLIMW(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : ZXZXXAIGJFN<Id32<FunctionCalls.WJDJLPAFOZP>, SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x28C9540", Offset = "0x28C8940", VA = "0x1828C9540")]
			public UnsafeList<Id32<FunctionCalls.WJDJLPAFOZP>> MWKESFSWESX(int a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.WJDJLPAFOZP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x28C94C0", Offset = "0x28C88C0", VA = "0x1828C94C0")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x28C95B0", Offset = "0x28C89B0", VA = "0x1828C95B0", Slot = "6")]
			public void USLKZYCBIPT(Id32<FunctionCalls.WJDJLPAFOZP> a, SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> b, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x28C9540", Offset = "0x28C8940", VA = "0x1828C9540", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.WJDJLPAFOZP>> IJOVEOMWZQP(int a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.WJDJLPAFOZP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x28C94B0", Offset = "0x28C88B0", VA = "0x1828C94B0", Slot = "5")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> GYUPHBTTFDT(Id32<FunctionCalls.WJDJLPAFOZP> a, [In] SOAField<FunctionCalls.WJDJLPAFOZP, Id32<FXJTAPCMHIX<WOIICPNDKNL>>> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : NXTEZROZYFE<Id32<MSJVWGLYDQX>, SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x28D4800", Offset = "0x28D3C00", VA = "0x1828D4800")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(Id32<MSJVWGLYDQX> a, [In] SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x28D4920", Offset = "0x28D3D20", VA = "0x1828D4920", Slot = "4")]
			public Id32<MSJVWGLYDQX> WOAMPJIKQIK(int a)
			{
				return default(Id32<MSJVWGLYDQX>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x28D48C0", Offset = "0x28D3CC0", VA = "0x1828D48C0")]
			public bool QNEGVOFZGOY(Id32<MSJVWGLYDQX> a, [In] SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x28D48C0", Offset = "0x28D3CC0", VA = "0x1828D48C0", Slot = "5")]
			private bool OMUVPULAZKN(Id32<MSJVWGLYDQX> a, [In] SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x28D48B0", Offset = "0x28D3CB0", VA = "0x1828D48B0", Slot = "6")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> JFMFMYOOAUM(Id32<MSJVWGLYDQX> a, [In] SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : ZXZXXAIGJFN<Id32<MSJVWGLYDQX>, SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x28C9710", Offset = "0x28C8B10", VA = "0x1828C9710")]
			public UnsafeList<Id32<MSJVWGLYDQX>> MWKESFSWESX(int a, [In] SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> values)
			{
				return default(UnsafeList<Id32<MSJVWGLYDQX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x28C9660", Offset = "0x28C8A60", VA = "0x1828C9660")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(Id32<MSJVWGLYDQX> a, [In] SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x28C9780", Offset = "0x28C8B80", VA = "0x1828C9780", Slot = "6")]
			public void USLKZYCBIPT(Id32<MSJVWGLYDQX> a, SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> b, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x28C9710", Offset = "0x28C8B10", VA = "0x1828C9710", Slot = "4")]
			private UnsafeList<Id32<MSJVWGLYDQX>> WYEVLMLODIF(int a, [In] SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> values)
			{
				return default(UnsafeList<Id32<MSJVWGLYDQX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x28C9650", Offset = "0x28C8A50", VA = "0x1828C9650", Slot = "5")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> BNSAXZFPOZR(Id32<MSJVWGLYDQX> a, [In] SOAField<MSJVWGLYDQX, Id32<FXJTAPCMHIX<KGGAHYYTTGC>>?> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : NXTEZROZYFE<int, UnsafeList<(Id32<LocalVariables.M>, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x28D4AA0", Offset = "0x28D3EA0", VA = "0x1828D4AA0")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB04E40", Offset = "0xB04240", VA = "0x180B04E40", Slot = "4")]
			public int WOAMPJIKQIK(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90")]
			public bool QNEGVOFZGOY(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "5")]
			private bool CVMWFTPHOMA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x28D4B30", Offset = "0x28D3F30", VA = "0x1828D4B30", Slot = "6")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> NDIORHTDSGV(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : ZXZXXAIGJFN<int, UnsafeList<(Id32<LocalVariables.M>, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x28C9D40", Offset = "0x28C9140", VA = "0x1828C9D40")]
			public UnsafeList<int> MWKESFSWESX(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28C9CB0", Offset = "0x28C90B0", VA = "0x1828C9CB0")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x28C9DB0", Offset = "0x28C91B0", VA = "0x1828C9DB0", Slot = "6")]
			public void USLKZYCBIPT(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> values, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x28C9D40", Offset = "0x28C9140", VA = "0x1828C9D40", Slot = "4")]
			private UnsafeList<int> LVDSGOYUUVE(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x28C9CA0", Offset = "0x28C90A0", VA = "0x1828C9CA0", Slot = "5")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> BLTSCLLBCRI(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<FXJTAPCMHIX<DLSISDAFEUV<VVFCXQSNTUF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : NXTEZROZYFE<int, UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x28D4A00", Offset = "0x28D3E00", VA = "0x1828D4A00")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB04E40", Offset = "0xB04240", VA = "0x180B04E40", Slot = "4")]
			public int WOAMPJIKQIK(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90")]
			public bool QNEGVOFZGOY(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "5")]
			private bool BJDTAXIDSWT(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x28D4A90", Offset = "0x28D3E90", VA = "0x1828D4A90", Slot = "6")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> URSZOBVPEDA(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : ZXZXXAIGJFN<int, UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x28C9B20", Offset = "0x28C8F20", VA = "0x1828C9B20")]
			public UnsafeList<int> MWKESFSWESX(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x28C9A90", Offset = "0x28C8E90", VA = "0x1828C9A90")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x28C9BA0", Offset = "0x28C8FA0", VA = "0x1828C9BA0", Slot = "6")]
			public void USLKZYCBIPT(int a, UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x28C9B20", Offset = "0x28C8F20", VA = "0x1828C9B20", Slot = "4")]
			private UnsafeList<int> MVPHDKAMIFT(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x28C9B90", Offset = "0x28C8F90", VA = "0x1828C9B90", Slot = "5")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> QGMFGGAZCCD(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : NXTEZROZYFE<int, UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x28D4960", Offset = "0x28D3D60", VA = "0x1828D4960")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB04E40", Offset = "0xB04240", VA = "0x180B04E40", Slot = "4")]
			public int WOAMPJIKQIK(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90")]
			public bool QNEGVOFZGOY(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "5")]
			private bool BJDTAXIDSWT(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x28D49F0", Offset = "0x28D3DF0", VA = "0x1828D49F0", Slot = "6")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> URSZOBVPEDA(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : ZXZXXAIGJFN<int, UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x28C9910", Offset = "0x28C8D10", VA = "0x1828C9910")]
			public UnsafeList<int> MWKESFSWESX(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x28C9880", Offset = "0x28C8C80", VA = "0x1828C9880")]
			public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x28C9990", Offset = "0x28C8D90", VA = "0x1828C9990", Slot = "6")]
			public void USLKZYCBIPT(int a, UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x28C9910", Offset = "0x28C8D10", VA = "0x1828C9910", Slot = "4")]
			private UnsafeList<int> MVPHDKAMIFT(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x28C9980", Offset = "0x28C8D80", VA = "0x1828C9980", Slot = "5")]
			private Id32<FXJTAPCMHIX<VVFCXQSNTUF>> QGMFGGAZCCD(int a, [In] UnsafeList<(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> Target, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1A6EE10", Offset = "0x1A6E210", VA = "0x181A6EE10")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x28CDC10", Offset = "0x28CD010", VA = "0x1828CDC10")]
			public void CVMUYZWMJUG([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<MSJVWGLYDQX> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x28CDBF0", Offset = "0x28CCFF0", VA = "0x1828CDBF0")]
			public GenerateDataBackFromInputIndexResult(Id32<MSJVWGLYDQX> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28CDBC0", Offset = "0x28CCFC0", VA = "0x1828CDBC0")]
			public void CVMUYZWMJUG([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28CDBD0", Offset = "0x28CCFD0", VA = "0x1828CDBD0")]
			public void CVMUYZWMJUG([Out] Id32<DataBackResults.M> a, [Out] Id32<MSJVWGLYDQX> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<MSJVWGLYDQX> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
			public GenerateDataBackFromInputIndicesResult(Id32<MSJVWGLYDQX> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x28CDC00", Offset = "0x28CD000", VA = "0x1828CDC00")]
			public void CVMUYZWMJUG([Out] Id32<DataBackResults.M> a, [Out] Id32<MSJVWGLYDQX> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28CA490", Offset = "0x28C9890", VA = "0x1828CA490")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28CB140", Offset = "0x28CA540", VA = "0x1828CB140")]
		public static void IRTKASZILOT(this FunctionCompileState a, Id32<ICQMRPVUNHC> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28CAD70", Offset = "0x28CA170", VA = "0x1828CAD70")]
		public static void HPWARQEEGYB(this FunctionCompileState a, Id32<ICQMRPVUNHC> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28CC340", Offset = "0x28CB740", VA = "0x1828CC340")]
		public static Id32<DataBackResults.M>? WLQCETESWAS([In] this FunctionCompileState self, Id32<ICQMRPVUNHC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28CAD10", Offset = "0x28CA110", VA = "0x1828CAD10")]
		public static Id32<FXJTAPCMHIX<KGGAHYYTTGC>> HMKULPOONJE([In] this FunctionCompileState self)
		{
			return default(Id32<FXJTAPCMHIX<KGGAHYYTTGC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28CA980", Offset = "0x28C9D80", VA = "0x1828CA980")]
		private static void FIBDXMYNTEF(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28CA760", Offset = "0x28C9B60", VA = "0x1828CA760")]
		private static Id32<FXJTAPCMHIX<KGGAHYYTTGC>>? EGOQHDPROAW([In] this FunctionCompileState self, Id32<MSJVWGLYDQX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28CAB20", Offset = "0x28C9F20", VA = "0x1828CAB20")]
		public static void FNPXPWLEICW(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28CB980", Offset = "0x28CAD80", VA = "0x1828CB980")]
		public static DataBackResults.Def OUHFJYGICWQ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28CB330", Offset = "0x28CA730", VA = "0x1828CB330")]
		public static ReadOnlyArray<byte> JNUMPLNZZCM([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28CBD30", Offset = "0x28CB130", VA = "0x1828CBD30")]
		public static Id32<LocalVariables.M> UGILZMWHBOA([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28CAEB0", Offset = "0x28CA2B0", VA = "0x1828CAEB0")]
		public static Union32 HVRENQGLRYW([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x35C44F0", Offset = "0x35C38F0", VA = "0x1835C44F0")]
		private static Id32<DataBackResults.M> XVSPMJDGKJR<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.MHPUDTFEWYJ
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28CAC90", Offset = "0x28CA090", VA = "0x1828CAC90")]
		public static Id32<DataBackResults.M> GIMDVWZMQFF(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28CB720", Offset = "0x28CAB20", VA = "0x1828CB720")]
		public static Id32<DataBackResults.M> OKAPQLVDTUO(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28CB650", Offset = "0x28CAA50", VA = "0x1828CB650")]
		public static Id32<DataBackResults.M> NEOMKZAPUDL(this FunctionCompileState a, Id32<FXJTAPCMHIX<KGGAHYYTTGC>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28CB410", Offset = "0x28CA810", VA = "0x1828CB410")]
		public static Id32<DataBackResults.M> JSGBPIDYNUJ(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28CBA60", Offset = "0x28CAE60", VA = "0x1828CBA60")]
		public static Id32<DataBackResults.M> PQVKQIEMRLE(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x35C3480", Offset = "0x35C2880", VA = "0x1835C3480")]
		private static Id32<ExecForwardResults.M> RFKEBHGMOGA<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.MHPUDTFEWYJ
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28CA450", Offset = "0x28C9850", VA = "0x1828CA450")]
		public static Id32<ExecForwardResults.M> BWEVUOXMGEY(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28CB7B0", Offset = "0x28CABB0", VA = "0x1828CB7B0")]
		public static Id32<ExecForwardResults.M> OMNFLUMVGQV(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28CC250", Offset = "0x28CB650", VA = "0x1828CC250")]
		public static Id32<ExecForwardResults.M> WEWEDUJBGSJ(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28CB6D0", Offset = "0x28CAAD0", VA = "0x1828CB6D0")]
		public static Id32<ExecForwardResults.M> NKVVUUNMWMC(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28CB490", Offset = "0x28CA890", VA = "0x1828CB490")]
		public static Id32<ExecForwardResults.M> KEZAIYPKHAE(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28CC2D0", Offset = "0x28CB6D0", VA = "0x1828CC2D0")]
		public static FunctionCalls.Def WKSPBAQVTFT([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28CA830", Offset = "0x28C9C30", VA = "0x1828CA830")]
		public static CopyEnumerable<Id32<FunctionCalls.WJDJLPAFOZP>, Id32Enumerator<FunctionCalls.WJDJLPAFOZP>> ERCNFXHMBUQ([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.WJDJLPAFOZP>, Id32Enumerator<FunctionCalls.WJDJLPAFOZP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28CC080", Offset = "0x28CB480", VA = "0x1828CC080")]
		public static Id32<FunctionCalls.WJDJLPAFOZP> WBTWGSNUQXR([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.WJDJLPAFOZP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28CAE40", Offset = "0x28CA240", VA = "0x1828CAE40")]
		public static FunctionCalls.IO HTDLHCHVMAS([In] this FunctionCompileState self, Id32<FunctionCalls.WJDJLPAFOZP> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28CB9F0", Offset = "0x28CADF0", VA = "0x1828CB9F0")]
		public static FunctionCalls.IO PBNGHXKVSKI(this FunctionCompileState a, Id32<FunctionCalls.WJDJLPAFOZP> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x35C4460", Offset = "0x35C3860", VA = "0x1835C4460")]
		private static Id32<FunctionCalls.M> TWNFFTRFHNN<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.MHPUDTFEWYJ
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28CC800", Offset = "0x28CBC00", VA = "0x1828CC800")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.WJDJLPAFOZP>) ZRKDTDPLWEC(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.WJDJLPAFOZP>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28CAF90", Offset = "0x28CA390", VA = "0x1828CAF90")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.WJDJLPAFOZP>) IBWDMYEEDMQ(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.WJDJLPAFOZP>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28CA7E0", Offset = "0x28C9BE0", VA = "0x1828CA7E0")]
		public static Id32<FunctionCalls.M> EHCRAKBTWNT(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28CC3C0", Offset = "0x28CB7C0", VA = "0x1828CC3C0")]
		public static void XSBIJAHDTGQ(this FunctionCompileState a, Id32<FunctionCalls.WJDJLPAFOZP> b, Id32<FXJTAPCMHIX<KGGAHYYTTGC>> c, Id32<FXJTAPCMHIX<WOIICPNDKNL>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x35C1B30", Offset = "0x35C0F30", VA = "0x1835C1B30")]
		public static GenerateDataBackResult BYSFREFDAFI<d, e>(this FunctionCompileState a, d b, e c, Id32<LVEMYDMRMXB> d, Id32<MSJVWGLYDQX> e) where d : UCJKCVUMNSY<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x35C2F30", Offset = "0x35C2330", VA = "0x1835C2F30")]
		public static GenerateDataBackFromInputIndexResult FHNHHCCPGDA<f, g>(this FunctionCompileState a, f b, g c, Id32<LVEMYDMRMXB> d, Id32<YAEGQIMTQZT> e, int f) where f : UCJKCVUMNSY<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x35C3F00", Offset = "0x35C3300", VA = "0x1835C3F00")]
		public static Id32<DataBackResults.M>? TTXTLQHNHMD<h, i>(this FunctionCompileState a, h b, i c, Id32<LVEMYDMRMXB> d, Id32<YAEGQIMTQZT> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : UCJKCVUMNSY<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x35C3520", Offset = "0x35C2920", VA = "0x1835C3520")]
		public static Id32<ExecForwardResults.M> RJXUWAZKXPP<j, k>(this FunctionCompileState a, j b, k c, Id32<LVEMYDMRMXB> d, Id32<ICQMRPVUNHC> e) where j : UCJKCVUMNSY<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x28CB220", Offset = "0x28CA620", VA = "0x1828CB220")]
		public static LocalVariables.ArgumentInst JKKRTGRDSEJ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28CC450", Offset = "0x28CB850", VA = "0x1828CC450")]
		public static LocalVariables.CalleeReturnValueInst XVJBYZYUBYH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28CBF70", Offset = "0x28CB370", VA = "0x1828CBF70")]
		public static LocalVariables.CallerReturnValueInst VEOIZJZNIIU([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28CC560", Offset = "0x28CB960", VA = "0x1828CC560")]
		public static Id32<LocalVariables.M> YXUIHPKWBGU(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28CB4E0", Offset = "0x28CA8E0", VA = "0x1828CB4E0")]
		public static LocalVariables.ParameterInst LYOURKCNWSN([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28CB1D0", Offset = "0x28CA5D0", VA = "0x1828CB1D0")]
		public static LocalVariables.Def ITNWKKOPRIV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28CBAE0", Offset = "0x28CAEE0", VA = "0x1828CBAE0")]
		public static int? SCCARZYYPST([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x35C3380", Offset = "0x35C2780", VA = "0x1835C3380")]
		private static Id32<LocalVariables.M> LZDJOWZJJJR<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.MHPUDTFEWYJ
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28CBEC0", Offset = "0x28CB2C0", VA = "0x1828CBEC0")]
		public static Id32<LocalVariables.M> UVTPWPRNBTJ(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28CC710", Offset = "0x28CBB10", VA = "0x1828CC710")]
		public static Id32<LocalVariables.M> YZZCMHKDICM(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28CB800", Offset = "0x28CAC00", VA = "0x1828CB800")]
		public static Id32<LocalVariables.M> OTAUTPVUKJG(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28CC770", Offset = "0x28CBB70", VA = "0x1828CC770")]
		public static Id32<LocalVariables.M> ZNQRZCFLQGK(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28CB5F0", Offset = "0x28CA9F0", VA = "0x1828CB5F0")]
		public static Id32<LocalVariables.M> MJWLXGUUQFM(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28CBB30", Offset = "0x28CAF30", VA = "0x1828CBB30")]
		public static void SIEILCVDAST(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28CA870", Offset = "0x28C9C70", VA = "0x1828CA870")]
		public static void FDTOZTJNCIJ(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28CBE10", Offset = "0x28CB210", VA = "0x1828CBE10")]
		public static void UVMUHEUWCLP(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28CA3C0", Offset = "0x28C97C0", VA = "0x1828CA3C0")]
		public static void BEGKWGYXXES(this FunctionCompileState a, Id32<FXJTAPCMHIX<KGGAHYYTTGC>> b, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28CBC50", Offset = "0x28CB050", VA = "0x1828CBC50")]
		public static void TFGCXMPVICG(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FXJTAPCMHIX<WVIUJJDMZXJ>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x35C3E20", Offset = "0x35C3220", VA = "0x1835C3E20")]
		public static void SKUGSUJLDQL<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FXJTAPCMHIX<DLSISDAFEUV<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface UCJKCVUMNSY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<ILIKHFFEBDR> EGAAYYFILMD(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<ILIKHFFEBDR> LFWWTMTGTFM(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<ILIKHFFEBDR> RYSULWYDIVJ(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<ILIKHFFEBDR> NBSQRYTEJVK(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> XJGVDPVZRJM(a a, FunctionCompileState b, Id32<LVEMYDMRMXB> c, Id32<MSJVWGLYDQX> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> HDZVGNHJUTI(a a, FunctionCompileState b, Id32<LVEMYDMRMXB> c, Id32<ICQMRPVUNHC> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int NIXEASLDYIQ(a a, Id32<LVEMYDMRMXB> b, Id32<MSJVWGLYDQX> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<ICQMRPVUNHC> EQHPANACVGT(a a, Id32<LVEMYDMRMXB> b, Id32<MSJVWGLYDQX> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind RJTWPVRWIBM(a a, Id32<LVEMYDMRMXB> b, Id32<MSJVWGLYDQX> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool SWAWXUAZYJN(a a, Id32<LVEMYDMRMXB> b, Id32<MSJVWGLYDQX> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int SCOOAQRRCGM(a a, Id32<LVEMYDMRMXB> b, Id32<MSJVWGLYDQX> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> BYCBUGORLWO(a a, Id32<LVEMYDMRMXB> b, Id32<MSJVWGLYDQX> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<ILIKHFFEBDR>) FVJUNORNXTS(a a, Id32<LVEMYDMRMXB> b, Id32<MSJVWGLYDQX> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int RNIDZCFTJWG(a a, Id32<LVEMYDMRMXB> b, Id32<ICQMRPVUNHC> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<MSJVWGLYDQX> WDAWKSPYUIT(a a, Id32<LVEMYDMRMXB> b, Id32<ICQMRPVUNHC> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<MSJVWGLYDQX> CSCSFARDASS(a a, Id32<LVEMYDMRMXB> b, Id32<YAEGQIMTQZT> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int EARRRBZRNBA(a a, Id32<LVEMYDMRMXB> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? WTUWSTQKXHO(a a, Id32<LVEMYDMRMXB> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int DXZPVNPNCEE(a a, Id32<LVEMYDMRMXB> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? JXAKKRDTIKK(a a, Id32<LVEMYDMRMXB> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class IRQFCHCKGYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x371AD20", Offset = "0x371A120", VA = "0x18371AD20")]
		public static Id32<LocalVariables.M?> HVSOWJAIOGE<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x371BF90", Offset = "0x371B390", VA = "0x18371BF90")]
		public static Id32<LocalVariables.M?> QZRSDCNRYIF<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x371C550", Offset = "0x371B950", VA = "0x18371C550")]
		public static Id32<LocalVariables.M?> TNZLALGDGTW<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x28D2BF0", Offset = "0x28D1FF0", VA = "0x1828D2BF0")]
		public static Id32<LocalVariables.M> YRLJKLAHHII(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x28CEFA0", Offset = "0x28CE3A0", VA = "0x1828CEFA0")]
		public static Id32<LocalVariables.M> IFEBLHKTVSL(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x28CF400", Offset = "0x28CE800", VA = "0x1828CF400")]
		public static Id32<LocalVariables.M> JQLMNITYJBE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x28D1500", Offset = "0x28D0900", VA = "0x1828D1500")]
		public static Id32<LocalVariables.M> TELECFSLGPM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x28D10A0", Offset = "0x28D04A0", VA = "0x1828D10A0")]
		public static Id32<LocalVariables.M> SBFJVVWIIKZ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28D0F60", Offset = "0x28D0360", VA = "0x1828D0F60")]
		public static Id32<LocalVariables.M> RPDXRXFOVJW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x28CE180", Offset = "0x28CD580", VA = "0x1828CE180")]
		public static Id32<LocalVariables.M> DONNXHTWEDW(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x28CE860", Offset = "0x28CDC60", VA = "0x1828CE860")]
		public static Id32<LocalVariables.M> GQQMJWMHZRN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x28D0720", Offset = "0x28CFB20", VA = "0x1828D0720")]
		public static Id32<LocalVariables.M> QIZHKEKDEUW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x28CDF80", Offset = "0x28CD380", VA = "0x1828CDF80")]
		public static Id32<LocalVariables.M> CHNPNMIWISP(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x28CE980", Offset = "0x28CDD80", VA = "0x1828CE980")]
		public static Id32<LocalVariables.M> GSNRHHHVTGE(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28CDE40", Offset = "0x28CD240", VA = "0x1828CDE40")]
		public static Id32<LocalVariables.M> BRBOOWBJSXX(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28CFEC0", Offset = "0x28CF2C0", VA = "0x1828CFEC0")]
		public static Id32<LocalVariables.M> MWBLXTEGVZE(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28D2AC0", Offset = "0x28D1EC0", VA = "0x1828D2AC0")]
		public static Id32<LocalVariables.M> YBTUBIROKIV(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28D1A90", Offset = "0x28D0E90", VA = "0x1828D1A90")]
		public static Id32<LocalVariables.M> TPCOXMHQCPW(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28CE560", Offset = "0x28CD960", VA = "0x1828CE560")]
		public static Id32<LocalVariables.M> ETWYENOTWJK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28D09A0", Offset = "0x28CFDA0", VA = "0x1828D09A0")]
		public static Id32<LocalVariables.M> QOWHSNYSBYP(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28CF540", Offset = "0x28CE940", VA = "0x1828CF540")]
		public static Id32<LocalVariables.M> KMXDAIKVFRA(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28D2700", Offset = "0x28D1B00", VA = "0x1828D2700")]
		public static Id32<LocalVariables.M> WYFXYPOTZFT(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28D01B0", Offset = "0x28CF5B0", VA = "0x1828D01B0")]
		public static Id32<LocalVariables.M> NHVMAJRQTES(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28CE7E0", Offset = "0x28CDBE0", VA = "0x1828CE7E0")]
		public static Id32<LocalVariables.M> GQIXQVCLYJB(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28CFD40", Offset = "0x28CF140", VA = "0x1828CFD40")]
		public static Id32<LocalVariables.M> MNJXXGTMTZD(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28D0560", Offset = "0x28CF960", VA = "0x1828D0560")]
		public static Id32<LocalVariables.M> PMNUOZUANWO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28D1A10", Offset = "0x28D0E10", VA = "0x1828D1A10")]
		public static Id32<LocalVariables.M> TKBAHWWMFSD(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28CEF20", Offset = "0x28CE320", VA = "0x1828CEF20")]
		public static Id32<LocalVariables.M> HVWZSUEQOJC(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28CE080", Offset = "0x28CD480", VA = "0x1828CE080")]
		public static Id32<LocalVariables.M> DKWXYZFRDVN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28D04E0", Offset = "0x28CF8E0", VA = "0x1828D04E0")]
		public static Id32<LocalVariables.M> PIHOSEJJGDI(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28D1300", Offset = "0x28D0700", VA = "0x1828D1300")]
		public static Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> STZYTSCUJVU(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28CE100", Offset = "0x28CD500", VA = "0x1828CE100")]
		public static Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> DNXWVDTEZZU(this FunctionCompileState a, int b)
		{
			return default(Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28CDDA0", Offset = "0x28CD1A0", VA = "0x1828CDDA0")]
		public static Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> APPSBLTQYHT(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28CF0C0", Offset = "0x28CE4C0", VA = "0x1828CF0C0")]
		public static Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> JHAXKFVKCXV(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28CE280", Offset = "0x28CD680", VA = "0x1828CE280")]
		public static Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> DVMPAXWDZNB(this FunctionCompileState a, int b)
		{
			return default(Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28D0A20", Offset = "0x28CFE20", VA = "0x1828D0A20")]
		public static Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> QQEKCIQWPSE(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28CF820", Offset = "0x28CEC20", VA = "0x1828CF820")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.WJDJLPAFOZP>) LSBISJNLTLL(this FunctionCompileState a, Id32<RIYHSWPESUG> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.WJDJLPAFOZP>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28D0AC0", Offset = "0x28CFEC0", VA = "0x1828D0AC0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.WJDJLPAFOZP>) QQWZBHCIEQT(this FunctionCompileState a, Id32<RPGMTDOAAUE> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.WJDJLPAFOZP>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x371C300", Offset = "0x371B700", VA = "0x18371C300")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<ILIKHFFEBDR>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<TMarker>>, Id32<FunctionCalls.M>) SQEHCBVKSSY<TMarker>(this FunctionCompileState a, Id32<ILIKHFFEBDR> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<ILIKHFFEBDR>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28D2180", Offset = "0x28D1580", VA = "0x1828D2180")]
		public static Id32<LocalVariables.M> VOIAMJIGOZM(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28D00C0", Offset = "0x28CF4C0", VA = "0x1828D00C0")]
		public static Id32<LocalVariables.M> NAXOKZVAQVX(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28CEE30", Offset = "0x28CE230", VA = "0x1828CEE30")]
		public static Id32<LocalVariables.M> HLWSRLXNHXI(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28D2E30", Offset = "0x28D2230", VA = "0x1828D2E30")]
		public static Id32<LocalVariables.M> ZAWJWPMELCR(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x28CDCA0", Offset = "0x28CD0A0", VA = "0x1828CDCA0")]
		public static Id32<LocalVariables.M> AFMDJUTFKQS(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28D3070", Offset = "0x28D2470", VA = "0x1828D3070")]
		public static Id32<LocalVariables.M> ZIHFNIBZWQN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28D05E0", Offset = "0x28CF9E0", VA = "0x1828D05E0")]
		public static Id32<LocalVariables.M> PSYIJGXVXUU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28CE5E0", Offset = "0x28CD9E0", VA = "0x1828CE5E0")]
		public static Id32<LocalVariables.M> FCPFBWWHTJC(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28D2F50", Offset = "0x28D2350", VA = "0x1828D2F50")]
		public static Id32<LocalVariables.M> ZGANLWFBHAL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28D0860", Offset = "0x28CFC60", VA = "0x1828D0860")]
		public static Id32<LocalVariables.M> QLROTDDWNRE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28CFCC0", Offset = "0x28CF0C0", VA = "0x1828CFCC0")]
		public static Id32<LocalVariables.M> MIJIMLXXKYJ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28D0460", Offset = "0x28CF860", VA = "0x1828D0460")]
		public static Id32<LocalVariables.M> PHNFEEYLEVU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28D2240", Offset = "0x28D1640", VA = "0x1828D2240")]
		public static Id32<LocalVariables.M> WCAXZJCCKAT(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28CE6E0", Offset = "0x28CDAE0", VA = "0x1828CE6E0")]
		public static Id32<LocalVariables.M> GBKRODOAUVL(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28CEBC0", Offset = "0x28CDFC0", VA = "0x1828CEBC0")]
		public static Id32<LocalVariables.M> HEQLUNKDSZY(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28D2CF0", Offset = "0x28D20F0", VA = "0x1828D2CF0")]
		public static Id32<LocalVariables.M> YSVOUYVRZGX(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x28CFFC0", Offset = "0x28CF3C0", VA = "0x1828CFFC0")]
		public static Id32<LocalVariables.M> NAETKRXWCEI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x28D0230", Offset = "0x28CF630", VA = "0x1828D0230")]
		public static Id32<LocalVariables.M> OTPYLBSLPYT(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28CF5C0", Offset = "0x28CE9C0", VA = "0x1828CF5C0")]
		public static Id32<LocalVariables.M> LCHHNKLMQBQ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28D24E0", Offset = "0x28D18E0", VA = "0x1828D24E0")]
		public static Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>> WMJMTIDXSBI(this FunctionCompileState a)
		{
			return default(Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x28D2600", Offset = "0x28D1A00", VA = "0x1828D2600")]
		public static Id32<LocalVariables.M> WQOZIEKMABF(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x28D22C0", Offset = "0x28D16C0", VA = "0x1828D22C0")]
		public static Id32<LocalVariables.M> WFASCLZVQNW(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28CE300", Offset = "0x28CD700", VA = "0x1828CE300")]
		public static Id32<LocalVariables.M> EKVAXXUDFBH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x28D2080", Offset = "0x28D1480", VA = "0x1828D2080")]
		public static Id32<LocalVariables.M> UZSOBCJGYHP(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28CE440", Offset = "0x28CD840", VA = "0x1828CE440")]
		public static Id32<LocalVariables.M> ENJDEMBJQNQ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x28CECF0", Offset = "0x28CE0F0", VA = "0x1828CECF0")]
		public static Id32<LocalVariables.M> HHNJIHZKVYT(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28D23E0", Offset = "0x28D17E0", VA = "0x1828D23E0")]
		public static Id32<LocalVariables.M> WIBEFODXPJY(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28D0350", Offset = "0x28CF750", VA = "0x1828D0350")]
		public static Id32<LocalVariables.M> PBUIZMQNKIB(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28D2AB0", Offset = "0x28D1EB0", VA = "0x1828D2AB0")]
		public static void XZWWJVIFNGI(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28CFDC0", Offset = "0x28CF1C0", VA = "0x1828CFDC0")]
		public static Id32<LocalVariables.M> MRSZJSAEXLB(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x28CF700", Offset = "0x28CEB00", VA = "0x1828CF700")]
		public static Id32<LocalVariables.M> LSASDNNSLAQ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x28D1F40", Offset = "0x28D1340", VA = "0x1828D1F40")]
		public static Id32<LocalVariables.M> UOWPKWROCLD(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x28D1E40", Offset = "0x28D1240", VA = "0x1828D1E40")]
		public static Id32<LocalVariables.M> UGUQGTOJVFD(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28CEAA0", Offset = "0x28CDEA0", VA = "0x1828CEAA0")]
		public static Id32<LocalVariables.M> HCYZVYRTAMG(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28D11C0", Offset = "0x28D05C0", VA = "0x1828D11C0")]
		public static Id32<LocalVariables.M> SGMIYNKHQWP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28D1600", Offset = "0x28D0A00", VA = "0x1828D1600")]
		public static Id32<LocalVariables.M> THXCGTVPMTV(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28D2500", Offset = "0x28D1900", VA = "0x1828D2500")]
		public static Id32<LocalVariables.M> WOXUHXHLNOU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28D1BD0", Offset = "0x28D0FD0", VA = "0x1828D1BD0")]
		public static Id32<LocalVariables.M> TYQYWWBHCZB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28CF2C0", Offset = "0x28CE6C0", VA = "0x1828CF2C0")]
		public static Id32<LocalVariables.M> JMTJBSHZJJI(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3719ED0", Offset = "0x37192D0", VA = "0x183719ED0")]
		public static void FMJILAYHAMX<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<RIYHSWPESUG> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, UCJKCVUMNSY<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x371B670", Offset = "0x371AA70", VA = "0x18371B670")]
		public static void QOAAJKHGAAN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<RPGMTDOAAUE> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, UCJKCVUMNSY<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x371C680", Offset = "0x371BA80", VA = "0x18371C680")]
		public static Id32<LocalVariables.M> UGBCRDXIZJR<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, UCJKCVUMNSY<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x371A660", Offset = "0x3719A60", VA = "0x18371A660")]
		public static Id32<LocalVariables.M> GCCULMYITTS<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, UCJKCVUMNSY<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x371AF10", Offset = "0x371A310", VA = "0x18371AF10")]
		public static Id32<DataBackResults.M> MYQLOQWHDXP<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, UCJKCVUMNSY<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x371D560", Offset = "0x371C960", VA = "0x18371D560")]
		public static Id32<ExecForwardResults.M> XLQEZVNBPXQ<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, UCJKCVUMNSY<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28D1CF0", Offset = "0x28D10F0", VA = "0x1828D1CF0")]
		public static Id32<DataBackResults.M> TZRXEULUKFY(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28D2780", Offset = "0x28D1B80", VA = "0x1828D2780")]
		public static Id32<DataBackResults.M> XUIRQUECOTS(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x371CC00", Offset = "0x371C000", VA = "0x18371CC00")]
		public static Id32<DataBackResults.M> XKWLKNOGVJV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<RIYHSWPESUG> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, UCJKCVUMNSY<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x371C990", Offset = "0x371BD90", VA = "0x18371C990")]
		private static Id32<DataBackResults.M> XKWLKNOGVJV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<RIYHSWPESUG> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, UCJKCVUMNSY<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x371B220", Offset = "0x371A620", VA = "0x18371B220")]
		public static Id32<LocalVariables.M> OFGAHVDIOJJ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, UCJKCVUMNSY<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3719B70", Offset = "0x3718F70", VA = "0x183719B70")]
		public static void DQOTZPOCTFA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, UCJKCVUMNSY<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<FXJTAPCMHIX<KGGAHYYTTGC>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<FXJTAPCMHIX<KGGAHYYTTGC>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
		public LiveInterval(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> firstUse, Id32<FXJTAPCMHIX<KGGAHYYTTGC>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28D3570", Offset = "0x28D2970", VA = "0x1828D3570")]
		public static LiveInterval New(Id32<FXJTAPCMHIX<KGGAHYYTTGC>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class SAKZYWSKRQK : MHPUDTFEWYJ
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
			[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class EAABXIOXPTU : MHPUDTFEWYJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class QXQAMPZPGPX : MHPUDTFEWYJ
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
			[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
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
		public abstract class MHPUDTFEWYJ
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
			public Id32<MHPUDTFEWYJ> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x28D3380", Offset = "0x28D2780", VA = "0x1828D3380")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<MHPUDTFEWYJ> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class JEOXKONEUJO : MHPUDTFEWYJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<SAKZYWSKRQK, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<QXQAMPZPGPX, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<JEOXKONEUJO, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<EAABXIOXPTU, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28D3770", Offset = "0x28D2B70", VA = "0x1828D3770")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<SAKZYWSKRQK, ArgumentInst> argumentVariables, [In] SOAId32Field<QXQAMPZPGPX, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<JEOXKONEUJO, ParameterInst> parameterVariables, [In] SOAId32Field<EAABXIOXPTU, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28D3580", Offset = "0x28D2980", VA = "0x1828D3580")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class GBXDDKSXEWB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28CDAC0", Offset = "0x28CCEC0", VA = "0x1828CDAC0")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class VXTGEYGWUCR
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28D4B40", Offset = "0x28D3F40", VA = "0x1828D4B40")]
		public static void EKQJYIVBPEX(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.WJDJLPAFOZP, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28CA140", Offset = "0x28C9540", VA = "0x1828CA140")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.WJDJLPAFOZP, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28CA0D0", Offset = "0x28C94D0", VA = "0x1828CA0D0")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28C9EB0", Offset = "0x28C92B0", VA = "0x1828C9EB0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3325330", Offset = "0x3324730", VA = "0x183325330")]
		public static void EKQJYIVBPEX<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<LVEMYDMRMXB> graphId) where TDeps : notnull, UCJKCVUMNSY<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class KDCQHKGOXKW
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28D33A0", Offset = "0x28D27A0", VA = "0x1828D33A0")]
		public static void EKQJYIVBPEX(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface DGAQWHAVKOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void HBRJXRTSTMW(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : DGAQWHAVKOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x28D3AC0", Offset = "0x28D2EC0", VA = "0x1828D3AC0", Slot = "4")]
			public void HBRJXRTSTMW(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : DGAQWHAVKOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x28D3B50", Offset = "0x28D2F50", VA = "0x1828D3B50", Slot = "4")]
			public void HBRJXRTSTMW(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : DGAQWHAVKOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x28D3980", Offset = "0x28D2D80", VA = "0x1828D3980", Slot = "4")]
			public void HBRJXRTSTMW(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : DGAQWHAVKOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x28D3A10", Offset = "0x28D2E10", VA = "0x1828D3A10", Slot = "4")]
			public void HBRJXRTSTMW(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class PUIVOOIJVBX<c> where c : struct, DGAQWHAVKOR
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c GOSNOUTRNRX;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x363C1D0", Offset = "0x363B5D0", VA = "0x18363C1D0")]
			public static int EKQJYIVBPEX<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : UCJKCVUMNSY<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FunctionCalls.WJDJLPAFOZP>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28D3330", Offset = "0x28D2730", VA = "0x1828D3330")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FunctionCalls.WJDJLPAFOZP>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28D3280", Offset = "0x28D2680", VA = "0x1828D3280")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28D3240", Offset = "0x28D2640", VA = "0x1828D3240")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3733B50", Offset = "0x3732F50", VA = "0x183733B50")]
		public static void EKQJYIVBPEX<b, a>(FunctionCompileState a, b b, a c) where b : UCJKCVUMNSY<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class RMYMROBBPQD
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
		private static int QNXGHCUKASD;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int AJULGSSPTIZ;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x28D3C00", Offset = "0x28D3000", VA = "0x1828D3C00")]
		public static void EKQJYIVBPEX(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28D4160", Offset = "0x28D3560", VA = "0x1828D4160")]
		private static void NEYIOXWYTNI([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28D4370", Offset = "0x28D3770", VA = "0x1828D4370")]
		private static void NEYIOXWYTNI(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28D44B0", Offset = "0x28D38B0", VA = "0x1828D44B0")]
		private static void SLZXBHTUVGN(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class JAEDRQTABEL<a, b, c> where a : struct, ZXZXXAIGJFN<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a GOSNOUTRNRX;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x50DDE30", Offset = "0x50DD230", VA = "0x1850DDE30")]
		public static void EKQJYIVBPEX([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface ZXZXXAIGJFN<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> MWKESFSWESX(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void USLKZYCBIPT(a a, b b, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface NXTEZROZYFE<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a WOAMPJIKQIK(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool QNEGVOFZGOY(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<FXJTAPCMHIX<VVFCXQSNTUF>> IFJATIFYTMR(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class DEFZCHKRWDY<a, b, c> where a : struct, NXTEZROZYFE<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a GOSNOUTRNRX;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x406C120", Offset = "0x406B520", VA = "0x18406C120")]
		public static UnsafeList<b> EKQJYIVBPEX(int a, [In] c values)
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
