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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x2912C50", Offset = "0x2911E50", VA = "0x182912C50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		public readonly Id32<VNZZUSDPSXP<FQPBODQMINB>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
		public ByteCodeAdjustment(Id32<VNZZUSDPSXP<FQPBODQMINB>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class ZJKTLVIBULJ : PTYDUYLYTIH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x28B1F70", Offset = "0x28B1170", VA = "0x1828B1F70")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2910650", Offset = "0x290F850", VA = "0x182910650", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class KGMHZVQFJSK : PTYDUYLYTIH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<VNZZUSDPSXP<MMYRGMCMOOI>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
			public DeadEnd(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> nextByteCodePtr)
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
		public abstract class PTYDUYLYTIH
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
			public readonly Id32<PTYDUYLYTIH> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
			public Inst(Def def, Id32<PTYDUYLYTIH> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class WDCONMZQTBJ : PTYDUYLYTIH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class JSEJGHRDXND : PTYDUYLYTIH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x21175F0", Offset = "0x21167F0", VA = "0x1821175F0", Slot = "3")]
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
		internal IdUnsafeList<ZJKTLVIBULJ, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<KGMHZVQFJSK, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<WDCONMZQTBJ, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<JSEJGHRDXND, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2911260", Offset = "0x2910460", VA = "0x182911260")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<ZJKTLVIBULJ, BytesImmediate> bytesImmediates, [In] IdUnsafeList<KGMHZVQFJSK, DeadEnd> deadEnds, [In] IdUnsafeList<WDCONMZQTBJ, Variable> variables, [In] IdUnsafeList<JSEJGHRDXND, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2911120", Offset = "0x2910320", VA = "0x182911120")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class VWDWTILLTPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x291B1C0", Offset = "0x291A3C0", VA = "0x18291B1C0")]
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
		public sealed class PIERAEOAVCS : PTYDUYLYTIH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
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
		public abstract class PTYDUYLYTIH
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
			public readonly Id32<PTYDUYLYTIH> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
			public Inst(Def def, Id32<PTYDUYLYTIH> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<PIERAEOAVCS, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2911380", Offset = "0x2910580", VA = "0x182911380")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<PIERAEOAVCS, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29112F0", Offset = "0x29104F0", VA = "0x1829112F0")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class MSAYYFWBWEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2912BF0", Offset = "0x2911DF0", VA = "0x182912BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2911460", Offset = "0x2910660", VA = "0x182911460")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x29113C0", Offset = "0x29105C0", VA = "0x1829113C0")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class SWJXQNUYKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x291AC90", Offset = "0x2919E90", VA = "0x18291AC90")]
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
		public sealed class ZVINWDZCTXO : PTYDUYLYTIH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<YSSOREGTBKT> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
			public ExternalCall(Id32<YSSOREGTBKT> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class PTYDUYLYTIH
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
			public readonly Id32<PTYDUYLYTIH> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
			private Inst(Def def, Id32<PTYDUYLYTIH> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2912610", Offset = "0x2911810", VA = "0x182912610")]
			public static Inst New(Def def, Id32<PTYDUYLYTIH> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class DOMONTKEDXE : PTYDUYLYTIH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<YSSOREGTBKT> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
			public InternalCall(Id32<YSSOREGTBKT> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class YSSOREGTBKT
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
			[Cpp2IlInjected.Address(RVA = "0x2911380", Offset = "0x2910580", VA = "0x182911380")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2912460", Offset = "0x2911660", VA = "0x182912460")]
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
		internal IdUnsafeList<DOMONTKEDXE, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<ZVINWDZCTXO, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<YSSOREGTBKT> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<YSSOREGTBKT, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2911660", Offset = "0x2910860", VA = "0x182911660")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<DOMONTKEDXE, InternalCall> internalCalls, [In] IdUnsafeList<ZVINWDZCTXO, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<YSSOREGTBKT> IOId)> callsWithIO, [In] IdUnsafeList<YSSOREGTBKT, IO> io, [In] SOAField<YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> ioModifyingCallLocations, [In] SOAField<YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x29114C0", Offset = "0x29106C0", VA = "0x1829114C0")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class QXGJBZBQVEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2915750", Offset = "0x2914950", VA = "0x182915750")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2915540", Offset = "0x2914740", VA = "0x182915540")]
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
		internal SOAField<HCYBYNYIFYK, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<HCYBYNYIFYK>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x29120B0", Offset = "0x29112B0", VA = "0x1829120B0")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<HCYBYNYIFYK, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<HCYBYNYIFYK>> generatedOutputsForExpression, [In] SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2911720", Offset = "0x2910920", VA = "0x182911720")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class PHOHCIVPADD
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : NYTLYROSEJW<Id32<FunctionCalls.YSSOREGTBKT>, SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x291AD20", Offset = "0x2919F20", VA = "0x18291AD20")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x291ACE0", Offset = "0x2919EE0", VA = "0x18291ACE0", Slot = "4")]
			public Id32<FunctionCalls.YSSOREGTBKT> IQGVKUDUDYE(int a)
			{
				return default(Id32<FunctionCalls.YSSOREGTBKT>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330")]
			public bool JQLSLJVJTPQ(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "5")]
			private bool ZXXAHZWIAJK(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x291ADA0", Offset = "0x2919FA0", VA = "0x18291ADA0", Slot = "6")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> PQJDFHVBMPX(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : TJRQHGJNIHD<Id32<FunctionCalls.YSSOREGTBKT>, SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x290F7F0", Offset = "0x290E9F0", VA = "0x18290F7F0")]
			public UnsafeList<Id32<FunctionCalls.YSSOREGTBKT>> NQABRUPIGSV(int a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.YSSOREGTBKT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x290F860", Offset = "0x290EA60", VA = "0x18290F860")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x290F8E0", Offset = "0x290EAE0", VA = "0x18290F8E0", Slot = "6")]
			public void QCAGYRKYBOP(Id32<FunctionCalls.YSSOREGTBKT> a, SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> b, Id32<VNZZUSDPSXP<FQPBODQMINB>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x290F7F0", Offset = "0x290E9F0", VA = "0x18290F7F0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.YSSOREGTBKT>> LMDWHSLAIDG(int a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.YSSOREGTBKT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x290F7E0", Offset = "0x290E9E0", VA = "0x18290F7E0", Slot = "5")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> FBYGENTTDLO(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : NYTLYROSEJW<Id32<FunctionCalls.YSSOREGTBKT>, SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x291ADF0", Offset = "0x2919FF0", VA = "0x18291ADF0")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x291ADB0", Offset = "0x2919FB0", VA = "0x18291ADB0", Slot = "4")]
			public Id32<FunctionCalls.YSSOREGTBKT> IQGVKUDUDYE(int a)
			{
				return default(Id32<FunctionCalls.YSSOREGTBKT>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330")]
			public bool JQLSLJVJTPQ(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "5")]
			private bool ANNXKBOYLFP(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x291AE70", Offset = "0x291A070", VA = "0x18291AE70", Slot = "6")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> RURRPMRLYFS(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : TJRQHGJNIHD<Id32<FunctionCalls.YSSOREGTBKT>, SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x290F990", Offset = "0x290EB90", VA = "0x18290F990")]
			public UnsafeList<Id32<FunctionCalls.YSSOREGTBKT>> NQABRUPIGSV(int a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.YSSOREGTBKT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x290FA00", Offset = "0x290EC00", VA = "0x18290FA00")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x290FA80", Offset = "0x290EC80", VA = "0x18290FA80", Slot = "6")]
			public void QCAGYRKYBOP(Id32<FunctionCalls.YSSOREGTBKT> a, SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> b, Id32<VNZZUSDPSXP<FQPBODQMINB>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x290F990", Offset = "0x290EB90", VA = "0x18290F990", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.YSSOREGTBKT>> BYMBYRHLLYR(int a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.YSSOREGTBKT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x290F980", Offset = "0x290EB80", VA = "0x18290F980", Slot = "5")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> AFORYQJQCKL(Id32<FunctionCalls.YSSOREGTBKT> a, [In] SOAField<FunctionCalls.YSSOREGTBKT, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : NYTLYROSEJW<Id32<KWIEUHKUXJL>, SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x291AF30", Offset = "0x291A130", VA = "0x18291AF30")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(Id32<KWIEUHKUXJL> a, [In] SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x291AEF0", Offset = "0x291A0F0", VA = "0x18291AEF0", Slot = "4")]
			public Id32<KWIEUHKUXJL> IQGVKUDUDYE(int a)
			{
				return default(Id32<KWIEUHKUXJL>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x291AE80", Offset = "0x291A080", VA = "0x18291AE80")]
			public bool JQLSLJVJTPQ(Id32<KWIEUHKUXJL> a, [In] SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x291AE80", Offset = "0x291A080", VA = "0x18291AE80", Slot = "5")]
			private bool BCCNEWKJFHB(Id32<KWIEUHKUXJL> a, [In] SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x291AEE0", Offset = "0x291A0E0", VA = "0x18291AEE0", Slot = "6")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> GTCODAWBTNM(Id32<KWIEUHKUXJL> a, [In] SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : TJRQHGJNIHD<Id32<KWIEUHKUXJL>, SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x290FB30", Offset = "0x290ED30", VA = "0x18290FB30")]
			public UnsafeList<Id32<KWIEUHKUXJL>> NQABRUPIGSV(int a, [In] SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> values)
			{
				return default(UnsafeList<Id32<KWIEUHKUXJL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x290FBA0", Offset = "0x290EDA0", VA = "0x18290FBA0")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(Id32<KWIEUHKUXJL> a, [In] SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x290FC50", Offset = "0x290EE50", VA = "0x18290FC50", Slot = "6")]
			public void QCAGYRKYBOP(Id32<KWIEUHKUXJL> a, SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> b, Id32<VNZZUSDPSXP<FQPBODQMINB>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x290FB30", Offset = "0x290ED30", VA = "0x18290FB30", Slot = "4")]
			private UnsafeList<Id32<KWIEUHKUXJL>> IOMZEKDCKWP(int a, [In] SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> values)
			{
				return default(UnsafeList<Id32<KWIEUHKUXJL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x290FB20", Offset = "0x290ED20", VA = "0x18290FB20", Slot = "5")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> HTCCOSXIPDT(Id32<KWIEUHKUXJL> a, [In] SOAField<KWIEUHKUXJL, Id32<VNZZUSDPSXP<MMYRGMCMOOI>>?> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : NYTLYROSEJW<int, UnsafeList<(Id32<LocalVariables.M>, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x291B130", Offset = "0x291A330", VA = "0x18291B130")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB19EF0", Offset = "0xB190F0", VA = "0x180B19EF0", Slot = "4")]
			public int IQGVKUDUDYE(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330")]
			public bool JQLSLJVJTPQ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "5")]
			private bool ABFCBOLCUFM(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x291B120", Offset = "0x291A320", VA = "0x18291B120", Slot = "6")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> KDKIXCNGOPZ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : TJRQHGJNIHD<int, UnsafeList<(Id32<LocalVariables.M>, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2910170", Offset = "0x290F370", VA = "0x182910170")]
			public UnsafeList<int> NQABRUPIGSV(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x29101E0", Offset = "0x290F3E0", VA = "0x1829101E0")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2910270", Offset = "0x290F470", VA = "0x182910270", Slot = "6")]
			public void QCAGYRKYBOP(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> values, Id32<VNZZUSDPSXP<FQPBODQMINB>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2910170", Offset = "0x290F370", VA = "0x182910170", Slot = "4")]
			private UnsafeList<int> QIJKJJTSIAI(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2910370", Offset = "0x290F570", VA = "0x182910370", Slot = "5")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> ZAZFVJICJUA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<VNZZUSDPSXP<MVLILCSWAQD<FQPBODQMINB>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : NYTLYROSEJW<int, UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x291B090", Offset = "0x291A290", VA = "0x18291B090")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB19EF0", Offset = "0xB190F0", VA = "0x180B19EF0", Slot = "4")]
			public int IQGVKUDUDYE(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330")]
			public bool JQLSLJVJTPQ(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "5")]
			private bool EIPNSPMJUMV(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x291B080", Offset = "0x291A280", VA = "0x18291B080", Slot = "6")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> LGYTNBHRZPC(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : TJRQHGJNIHD<int, UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x290FF60", Offset = "0x290F160", VA = "0x18290FF60")]
			public UnsafeList<int> NQABRUPIGSV(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x290FFD0", Offset = "0x290F1D0", VA = "0x18290FFD0")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2910060", Offset = "0x290F260", VA = "0x182910060", Slot = "6")]
			public void QCAGYRKYBOP(int a, UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values, Id32<VNZZUSDPSXP<FQPBODQMINB>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x290FF60", Offset = "0x290F160", VA = "0x18290FF60", Slot = "4")]
			private UnsafeList<int> LXEHYDJACXR(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2910160", Offset = "0x290F360", VA = "0x182910160", Slot = "5")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> TBJMVJASGCF(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : NYTLYROSEJW<int, UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x291AFF0", Offset = "0x291A1F0", VA = "0x18291AFF0")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB19EF0", Offset = "0xB190F0", VA = "0x180B19EF0", Slot = "4")]
			public int IQGVKUDUDYE(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330")]
			public bool JQLSLJVJTPQ(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "5")]
			private bool EIPNSPMJUMV(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x291AFE0", Offset = "0x291A1E0", VA = "0x18291AFE0", Slot = "6")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> LGYTNBHRZPC(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : TJRQHGJNIHD<int, UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x290FD50", Offset = "0x290EF50", VA = "0x18290FD50")]
			public UnsafeList<int> NQABRUPIGSV(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x290FDC0", Offset = "0x290EFC0", VA = "0x18290FDC0")]
			public Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x290FE50", Offset = "0x290F050", VA = "0x18290FE50", Slot = "6")]
			public void QCAGYRKYBOP(int a, UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values, Id32<VNZZUSDPSXP<FQPBODQMINB>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x290FD50", Offset = "0x290EF50", VA = "0x18290FD50", Slot = "4")]
			private UnsafeList<int> LXEHYDJACXR(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x290FF50", Offset = "0x290F150", VA = "0x18290FF50", Slot = "5")]
			private Id32<VNZZUSDPSXP<FQPBODQMINB>> TBJMVJASGCF(int a, [In] UnsafeList<(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> Target, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1A727F0", Offset = "0x1A719F0", VA = "0x181A727F0")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2912450", Offset = "0x2911650", VA = "0x182912450")]
			public void WKVVACUCCMA([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<KWIEUHKUXJL> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2912430", Offset = "0x2911630", VA = "0x182912430")]
			public GenerateDataBackFromInputIndexResult(Id32<KWIEUHKUXJL> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2912420", Offset = "0x2911620", VA = "0x182912420")]
			public void WKVVACUCCMA([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2912400", Offset = "0x2911600", VA = "0x182912400")]
			public void WKVVACUCCMA([Out] Id32<DataBackResults.M> a, [Out] Id32<KWIEUHKUXJL> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<KWIEUHKUXJL> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
			public GenerateDataBackFromInputIndicesResult(Id32<KWIEUHKUXJL> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2912440", Offset = "0x2911640", VA = "0x182912440")]
			public void WKVVACUCCMA([Out] Id32<DataBackResults.M> a, [Out] Id32<KWIEUHKUXJL> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2913300", Offset = "0x2912500", VA = "0x182913300")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x29151A0", Offset = "0x29143A0", VA = "0x1829151A0")]
		public static void ZRRZICQVZQV(this FunctionCompileState a, Id32<HCYBYNYIFYK> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2914300", Offset = "0x2913500", VA = "0x182914300")]
		public static void RYLCNNHBSRJ(this FunctionCompileState a, Id32<HCYBYNYIFYK> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2913B70", Offset = "0x2912D70", VA = "0x182913B70")]
		public static Id32<DataBackResults.M>? LNYYMAQUPAQ([In] this FunctionCompileState self, Id32<HCYBYNYIFYK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2914220", Offset = "0x2913420", VA = "0x182914220")]
		public static Id32<VNZZUSDPSXP<MMYRGMCMOOI>> RHEPERLCQJC([In] this FunctionCompileState self)
		{
			return default(Id32<VNZZUSDPSXP<MMYRGMCMOOI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2913F70", Offset = "0x2913170", VA = "0x182913F70")]
		private static void PVJPMZXEMJN(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2914E10", Offset = "0x2914010", VA = "0x182914E10")]
		private static Id32<VNZZUSDPSXP<MMYRGMCMOOI>>? YRCESJNLENS([In] this FunctionCompileState self, Id32<KWIEUHKUXJL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2913C30", Offset = "0x2912E30", VA = "0x182913C30")]
		public static void NZVXRCDOCVC(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2912DF0", Offset = "0x2911FF0", VA = "0x182912DF0")]
		public static DataBackResults.Def COSYLVBRQBI([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2914610", Offset = "0x2913810", VA = "0x182914610")]
		public static ReadOnlyArray<byte> TNYKDCYTILY([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x29143D0", Offset = "0x29135D0", VA = "0x1829143D0")]
		public static Id32<LocalVariables.M> SXWFLMIUAXU([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x29148F0", Offset = "0x2913AF0", VA = "0x1829148F0")]
		public static Union32 VGBDCTXMEXO([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3957120", Offset = "0x3956320", VA = "0x183957120")]
		private static Id32<DataBackResults.M> XCZBEXPWICJ<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.PTYDUYLYTIH
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x29136D0", Offset = "0x29128D0", VA = "0x1829136D0")]
		public static Id32<DataBackResults.M> FNETGKAOTYV(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2912D60", Offset = "0x2911F60", VA = "0x182912D60")]
		public static Id32<DataBackResults.M> CDUSGEWNUYM(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2913860", Offset = "0x2912A60", VA = "0x182913860")]
		public static Id32<DataBackResults.M> FWBVXRARXAH(this FunctionCompileState a, Id32<VNZZUSDPSXP<MMYRGMCMOOI>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2913280", Offset = "0x2912480", VA = "0x182913280")]
		public static Id32<DataBackResults.M> DKVZEWMLHRJ(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2914280", Offset = "0x2913480", VA = "0x182914280")]
		public static Id32<DataBackResults.M> RTOBWHWUWKA(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3955D70", Offset = "0x3954F70", VA = "0x183955D70")]
		private static Id32<ExecForwardResults.M> LHBEYJBNGQG<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.PTYDUYLYTIH
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2913BF0", Offset = "0x2912DF0", VA = "0x182913BF0")]
		public static Id32<ExecForwardResults.M> MGWJDOGLJIK(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x29138E0", Offset = "0x2912AE0", VA = "0x1829138E0")]
		public static Id32<ExecForwardResults.M> JTAVEUCXXLB(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2913930", Offset = "0x2912B30", VA = "0x182913930")]
		public static Id32<ExecForwardResults.M> KEOPDIQPHUX(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2912E60", Offset = "0x2912060", VA = "0x182912E60")]
		public static Id32<ExecForwardResults.M> CVGRJAPTFTC(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x29145C0", Offset = "0x29137C0", VA = "0x1829145C0")]
		public static Id32<ExecForwardResults.M> TMZXVJEAPFA(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2914DA0", Offset = "0x2913FA0", VA = "0x182914DA0")]
		public static FunctionCalls.Def YIAIQTAEQGD([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2914B80", Offset = "0x2913D80", VA = "0x182914B80")]
		public static CopyEnumerable<Id32<FunctionCalls.YSSOREGTBKT>, Id32Enumerator<FunctionCalls.YSSOREGTBKT>> VZFILUPXMYG([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.YSSOREGTBKT>, Id32Enumerator<FunctionCalls.YSSOREGTBKT>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2913DA0", Offset = "0x2912FA0", VA = "0x182913DA0")]
		public static Id32<FunctionCalls.YSSOREGTBKT> OSFMKAWVLTH([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.YSSOREGTBKT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x29135D0", Offset = "0x29127D0", VA = "0x1829135D0")]
		public static FunctionCalls.IO EFHZFTUHSYU([In] this FunctionCompileState self, Id32<FunctionCalls.YSSOREGTBKT> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2915130", Offset = "0x2914330", VA = "0x182915130")]
		public static FunctionCalls.IO ZPITLPLJEZY(this FunctionCompileState a, Id32<FunctionCalls.YSSOREGTBKT> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3955CE0", Offset = "0x3954EE0", VA = "0x183955CE0")]
		private static Id32<FunctionCalls.M> KTHAYRGVLVT<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.PTYDUYLYTIH
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x29146F0", Offset = "0x29138F0", VA = "0x1829146F0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.YSSOREGTBKT>) TWLIRXSNHJG(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.YSSOREGTBKT>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2912FC0", Offset = "0x29121C0", VA = "0x182912FC0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.YSSOREGTBKT>) DEEZDDMMEBY(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.YSSOREGTBKT>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x29148A0", Offset = "0x2913AA0", VA = "0x1829148A0")]
		public static Id32<FunctionCalls.M> UWHRFQHVNCH(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2913640", Offset = "0x2912840", VA = "0x182913640")]
		public static void EGFKSFEYHGG(this FunctionCompileState a, Id32<FunctionCalls.YSSOREGTBKT> b, Id32<VNZZUSDPSXP<MMYRGMCMOOI>> c, Id32<VNZZUSDPSXP<NFLUJZJCFXF>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x39546D0", Offset = "0x39538D0", VA = "0x1839546D0")]
		public static GenerateDataBackResult HHDFDQYGKWY<d, e>(this FunctionCompileState a, d b, e c, Id32<NZKBDZMUQMJ> d, Id32<KWIEUHKUXJL> e) where d : IRREUTSWWRI<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3956CC0", Offset = "0x3955EC0", VA = "0x183956CC0")]
		public static GenerateDataBackFromInputIndexResult XAYUCKQTCOI<f, g>(this FunctionCompileState a, f b, g c, Id32<NZKBDZMUQMJ> d, Id32<FAVTMLJIUOX> e, int f) where f : IRREUTSWWRI<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3955E10", Offset = "0x3955010", VA = "0x183955E10")]
		public static Id32<DataBackResults.M>? LIYRRVCUGGR<h, i>(this FunctionCompileState a, h b, i c, Id32<NZKBDZMUQMJ> d, Id32<FAVTMLJIUOX> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : IRREUTSWWRI<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3956480", Offset = "0x3955680", VA = "0x183956480")]
		public static Id32<ExecForwardResults.M> VSXFCGNSXVV<j, k>(this FunctionCompileState a, j b, k c, Id32<NZKBDZMUQMJ> d, Id32<HCYBYNYIFYK> e) where j : IRREUTSWWRI<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2913750", Offset = "0x2912950", VA = "0x182913750")]
		public static LocalVariables.ArgumentInst FNUNMFVUMTN([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2914110", Offset = "0x2913310", VA = "0x182914110")]
		public static LocalVariables.CalleeReturnValueInst PZHSKZLEOZX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2915020", Offset = "0x2914220", VA = "0x182915020")]
		public static LocalVariables.CallerReturnValueInst ZMDOEZSHWWK([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x29149D0", Offset = "0x2913BD0", VA = "0x1829149D0")]
		public static Id32<LocalVariables.M> VWBOSNZSUXU(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x29144B0", Offset = "0x29136B0", VA = "0x1829144B0")]
		public static LocalVariables.ParameterInst TDTCIIQYRNF([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2913A00", Offset = "0x2912C00", VA = "0x182913A00")]
		public static LocalVariables.Def KUEWERKVNVB([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x29139B0", Offset = "0x2912BB0", VA = "0x1829139B0")]
		public static int? KOJMAYXTEQR([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3956380", Offset = "0x3955580", VA = "0x183956380")]
		private static Id32<LocalVariables.M> OBGKZJYDHFX<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.PTYDUYLYTIH
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x29131D0", Offset = "0x29123D0", VA = "0x1829131D0")]
		public static Id32<LocalVariables.M> DKCKVULVUVX(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2914D40", Offset = "0x2913F40", VA = "0x182914D40")]
		public static Id32<LocalVariables.M> YGHGIRBWHVM(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2914BC0", Offset = "0x2913DC0", VA = "0x182914BC0")]
		public static Id32<LocalVariables.M> YEQBIWRWTOO(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2912CD0", Offset = "0x2911ED0", VA = "0x182912CD0")]
		public static Id32<LocalVariables.M> AOUBETHPDBG(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2913170", Offset = "0x2912370", VA = "0x182913170")]
		public static Id32<LocalVariables.M> DHKZOZCBHRS(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2913A50", Offset = "0x2912C50", VA = "0x182913A50")]
		public static void LFLEGQUHFJX(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2912EB0", Offset = "0x29120B0", VA = "0x182912EB0")]
		public static void DCPMAZZMGFZ(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2914F70", Offset = "0x2914170", VA = "0x182914F70")]
		public static void ZLXTPBTQGFR(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2915230", Offset = "0x2914430", VA = "0x182915230")]
		public static void ZSXGQNTEEKQ(this FunctionCompileState a, Id32<VNZZUSDPSXP<MMYRGMCMOOI>> b, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2914E90", Offset = "0x2914090", VA = "0x182914E90")]
		public static void ZIEKXMUXUII(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<VNZZUSDPSXP<SFAPMBZNZYR>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3955C00", Offset = "0x3954E00", VA = "0x183955C00")]
		public static void IYMKBNTTJCR<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<VNZZUSDPSXP<MVLILCSWAQD<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface IRREUTSWWRI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<OTRYTJZBOPP> AIJIHPCXRTT(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<OTRYTJZBOPP> RTKXGYVZHYA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<OTRYTJZBOPP> FCRLLRFAZBT(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<OTRYTJZBOPP> XLUIIGJKQDQ(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> TGHPQLSKCKQ(a a, FunctionCompileState b, Id32<NZKBDZMUQMJ> c, Id32<KWIEUHKUXJL> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> UEGKOAUNKXC(a a, FunctionCompileState b, Id32<NZKBDZMUQMJ> c, Id32<HCYBYNYIFYK> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int PMBCUOWHUOS(a a, Id32<NZKBDZMUQMJ> b, Id32<KWIEUHKUXJL> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<HCYBYNYIFYK> PYYGYJSWVFL(a a, Id32<NZKBDZMUQMJ> b, Id32<KWIEUHKUXJL> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind MVEVYOIAFSI(a a, Id32<NZKBDZMUQMJ> b, Id32<KWIEUHKUXJL> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool MPKOHDYGZIZ(a a, Id32<NZKBDZMUQMJ> b, Id32<KWIEUHKUXJL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int HTACVWPLNEG(a a, Id32<NZKBDZMUQMJ> b, Id32<KWIEUHKUXJL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> GKLNXLRWLXS(a a, Id32<NZKBDZMUQMJ> b, Id32<KWIEUHKUXJL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<OTRYTJZBOPP>) QXTICPKPCKG(a a, Id32<NZKBDZMUQMJ> b, Id32<KWIEUHKUXJL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int FWLUPGOSRSE(a a, Id32<NZKBDZMUQMJ> b, Id32<HCYBYNYIFYK> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<KWIEUHKUXJL> BOHDZFSVNEN(a a, Id32<NZKBDZMUQMJ> b, Id32<HCYBYNYIFYK> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<KWIEUHKUXJL> WOXGDKXKJYE(a a, Id32<NZKBDZMUQMJ> b, Id32<FAVTMLJIUOX> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int MJBTELQXPFO(a a, Id32<NZKBDZMUQMJ> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? EQLGRHQWNIK(a a, Id32<NZKBDZMUQMJ> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int QTMXDAONMMO(a a, Id32<NZKBDZMUQMJ> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? NOUKYRDFCFW(a a, Id32<NZKBDZMUQMJ> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class SNXVNMRKCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D870", Offset = "0x3A9CA70", VA = "0x183A9D870")]
		public static Id32<LocalVariables.M?> EBNJFYRVNZU<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F5A0", Offset = "0x3A9E7A0", VA = "0x183A9F5A0")]
		public static Id32<LocalVariables.M?> ONSLWYPCJDJ<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3AA0550", Offset = "0x3A9F750", VA = "0x183AA0550")]
		public static Id32<LocalVariables.M?> SQBZYQFMEOS<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2919210", Offset = "0x2918410", VA = "0x182919210")]
		public static Id32<LocalVariables.M> PMCXFAEINBA(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2917220", Offset = "0x2916420", VA = "0x182917220")]
		public static Id32<LocalVariables.M> GNUEBRTRKYJ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x29167E0", Offset = "0x29159E0", VA = "0x1829167E0")]
		public static Id32<LocalVariables.M> EBHEPKLFSLO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2917680", Offset = "0x2916880", VA = "0x182917680")]
		public static Id32<LocalVariables.M> IGECYVOSGBK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x29183B0", Offset = "0x29175B0", VA = "0x1829183B0")]
		public static Id32<LocalVariables.M> LGGTEEFUSWX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2916BA0", Offset = "0x2915DA0", VA = "0x182916BA0")]
		public static Id32<LocalVariables.M> ELTAJACDNRY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x29194A0", Offset = "0x29186A0", VA = "0x1829194A0")]
		public static Id32<LocalVariables.M> RRVUNMOPOYK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2916640", Offset = "0x2915840", VA = "0x182916640")]
		public static Id32<LocalVariables.M> DSJHNXAUMDX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2917C20", Offset = "0x2916E20", VA = "0x182917C20")]
		public static Id32<LocalVariables.M> IWMVGELBEJK(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x29160E0", Offset = "0x29152E0", VA = "0x1829160E0")]
		public static Id32<LocalVariables.M> BUZMBPXUCCN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2918550", Offset = "0x2917750", VA = "0x182918550")]
		public static Id32<LocalVariables.M> LZBNZOQJGHY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x291A890", Offset = "0x2919A90", VA = "0x18291A890")]
		public static Id32<LocalVariables.M> WKZDUSJQZXR(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2915C40", Offset = "0x2914E40", VA = "0x182915C40")]
		public static Id32<LocalVariables.M> AFZVRPGRAVK(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x291A250", Offset = "0x2919450", VA = "0x18291A250")]
		public static Id32<LocalVariables.M> UMMYVQEFIIL(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2915D40", Offset = "0x2914F40", VA = "0x182915D40")]
		public static Id32<LocalVariables.M> BDZNFETKDEC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x291AA50", Offset = "0x2919C50", VA = "0x18291AA50")]
		public static Id32<LocalVariables.M> XBRCFLWMLSC(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2916760", Offset = "0x2915960", VA = "0x182916760")]
		public static Id32<LocalVariables.M> DTRHKFDFGQN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x291A6C0", Offset = "0x29198C0", VA = "0x18291A6C0")]
		public static Id32<LocalVariables.M> VODVDTOITFG(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2919310", Offset = "0x2918510", VA = "0x182919310")]
		public static Id32<LocalVariables.M> POGXPUTADRF(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2919190", Offset = "0x2918390", VA = "0x182919190")]
		public static Id32<LocalVariables.M> PLQRTZKLBLC(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x291AAD0", Offset = "0x2919CD0", VA = "0x18291AAD0")]
		public static Id32<LocalVariables.M> XGSLNAWCDCV(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2919820", Offset = "0x2918A20", VA = "0x182919820")]
		public static Id32<LocalVariables.M> SJWWXGMEPCD(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x291A9D0", Offset = "0x2919BD0", VA = "0x18291A9D0")]
		public static Id32<LocalVariables.M> WUWYRBLDZPS(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x29195A0", Offset = "0x29187A0", VA = "0x1829195A0")]
		public static Id32<LocalVariables.M> RTKVYQERZHL(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x29164E0", Offset = "0x29156E0", VA = "0x1829164E0")]
		public static Id32<LocalVariables.M> CYKTHNHPCIS(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2918BB0", Offset = "0x2917DB0", VA = "0x182918BB0")]
		public static Id32<LocalVariables.M> OEDBLCUWQSJ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2918190", Offset = "0x2917390", VA = "0x182918190")]
		public static Id32<LocalVariables.M> JRLWHGKYIZK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2918C30", Offset = "0x2917E30", VA = "0x182918C30")]
		public static Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> OGRSPQHTJOA(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2917340", Offset = "0x2916540", VA = "0x182917340")]
		public static Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> GVPLJKZQHVC(this FunctionCompileState a, int b)
		{
			return default(Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2918210", Offset = "0x2917410", VA = "0x182918210")]
		public static Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> JWPONTRDCET(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x29162E0", Offset = "0x29154E0", VA = "0x1829162E0")]
		public static Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> CTTOCWYNPUJ(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x29184D0", Offset = "0x29176D0", VA = "0x1829184D0")]
		public static Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> LICVUJKJOHL(this FunctionCompileState a, int b)
		{
			return default(Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2918890", Offset = "0x2917A90", VA = "0x182918890")]
		public static Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> MQSUNTEJWHU(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2917780", Offset = "0x2916980", VA = "0x182917780")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.YSSOREGTBKT>) IUKFZPJMJNB(this FunctionCompileState a, Id32<FDGPVGVZFUQ> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.YSSOREGTBKT>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x29157A0", Offset = "0x29149A0", VA = "0x1829157A0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.YSSOREGTBKT>) AFKSIKZIPOZ(this FunctionCompileState a, Id32<SYLDEMURFRQ> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.YSSOREGTBKT>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F300", Offset = "0x3A9E500", VA = "0x183A9F300")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<OTRYTJZBOPP>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<TMarker>>, Id32<FunctionCalls.M>) LOAKYAQOCOW<TMarker>(this FunctionCompileState a, Id32<OTRYTJZBOPP> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<OTRYTJZBOPP>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2916560", Offset = "0x2915760", VA = "0x182916560")]
		public static Id32<LocalVariables.M> DJKDWBFRQNK(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2917130", Offset = "0x2916330", VA = "0x182917130")]
		public static Id32<LocalVariables.M> GLNCIPYDMBB(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2917E80", Offset = "0x2917080", VA = "0x182917E80")]
		public static Id32<LocalVariables.M> JFOINCSBVUU(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2917010", Offset = "0x2916210", VA = "0x182917010")]
		public static Id32<LocalVariables.M> FGMIOPEMDEH(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2917580", Offset = "0x2916780", VA = "0x182917580")]
		public static Id32<LocalVariables.M> IESJSPAFGIM(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2918670", Offset = "0x2917870", VA = "0x182918670")]
		public static Id32<LocalVariables.M> MCBQDBNKXHJ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x29198A0", Offset = "0x2918AA0", VA = "0x1829198A0")]
		public static Id32<LocalVariables.M> THHORAEXHPI(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2917F70", Offset = "0x2917170", VA = "0x182917F70")]
		public static Id32<LocalVariables.M> JIUFGETXDCK(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x291A4A0", Offset = "0x29196A0", VA = "0x18291A4A0")]
		public static Id32<LocalVariables.M> UZIWVPWAIMV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2918930", Offset = "0x2917B30", VA = "0x182918930")]
		public static Id32<LocalVariables.M> MSHFGZJMFQA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x291A640", Offset = "0x2919840", VA = "0x18291A640")]
		public static Id32<LocalVariables.M> VGIEUUWMASH(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x291A5C0", Offset = "0x29197C0", VA = "0x18291A5C0")]
		public static Id32<LocalVariables.M> VDRYYZNWYME(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2917500", Offset = "0x2916700", VA = "0x182917500")]
		public static Id32<LocalVariables.M> HJWFSYSHNXT(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x29199E0", Offset = "0x2918BE0", VA = "0x1829199E0")]
		public static Id32<LocalVariables.M> TPBODHXGERJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2915FB0", Offset = "0x29151B0", VA = "0x182915FB0")]
		public static Id32<LocalVariables.M> BLDLZXGQJTS(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2916A60", Offset = "0x2915C60", VA = "0x182916A60")]
		public static Id32<LocalVariables.M> EEEPERPUBFH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x29182B0", Offset = "0x29174B0", VA = "0x1829182B0")]
		public static Id32<LocalVariables.M> LCXGDELOTUW(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2919FF0", Offset = "0x29191F0", VA = "0x182919FF0")]
		public static Id32<LocalVariables.M> UGKGBHWODQZ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x291AB50", Offset = "0x2919D50", VA = "0x18291AB50")]
		public static Id32<LocalVariables.M> ZKNTTPGUVWM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2916620", Offset = "0x2915820", VA = "0x182916620")]
		public static Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>> DOMCFPIXYBC(this FunctionCompileState a)
		{
			return default(Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2919AE0", Offset = "0x2918CE0", VA = "0x182919AE0")]
		public static Id32<LocalVariables.M> TXITEIBYVCF(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x291A380", Offset = "0x2919580", VA = "0x18291A380")]
		public static Id32<LocalVariables.M> UUNRAUTEJCK(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2918A70", Offset = "0x2917C70", VA = "0x182918A70")]
		public static Id32<LocalVariables.M> NOOTSEIBDVV(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2918790", Offset = "0x2917990", VA = "0x182918790")]
		public static Id32<LocalVariables.M> MCUYYSMHFJV(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2917D60", Offset = "0x2916F60", VA = "0x182917D60")]
		public static Id32<LocalVariables.M> JCSITJVESOI(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x291A110", Offset = "0x2919310", VA = "0x18291A110")]
		public static Id32<LocalVariables.M> UIJQEDBQHTL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2918F70", Offset = "0x2918170", VA = "0x182918F70")]
		public static Id32<LocalVariables.M> PBGSGEQFMMI(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2919390", Offset = "0x2918590", VA = "0x182919390")]
		public static Id32<LocalVariables.M> QURXGOKVAGT(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2915E80", Offset = "0x2915080", VA = "0x182915E80")]
		public static void BJLDNIWDUTM(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x29161E0", Offset = "0x29153E0", VA = "0x1829161E0")]
		public static Id32<LocalVariables.M> CPWXVAFJXRT(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2918070", Offset = "0x2917270", VA = "0x182918070")]
		public static Id32<LocalVariables.M> JKOWVOWCSVM(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2918E30", Offset = "0x2918030", VA = "0x182918E30")]
		public static Id32<LocalVariables.M> OHLLJSVAJRB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2919620", Offset = "0x2918820", VA = "0x182919620")]
		public static Id32<LocalVariables.M> RTPVBCDEVAL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2919070", Offset = "0x2918270", VA = "0x182919070")]
		public static Id32<LocalVariables.M> PGHTTEFXXIM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2916920", Offset = "0x2915B20", VA = "0x182916920")]
		public static Id32<LocalVariables.M> EDIFZENEYJP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2919BE0", Offset = "0x2918DE0", VA = "0x182919BE0")]
		public static Id32<LocalVariables.M> UBWRHHTJQGV(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2919720", Offset = "0x2918920", VA = "0x182919720")]
		public static Id32<LocalVariables.M> RUMHKAKJWCC(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2915E90", Offset = "0x2915090", VA = "0x182915E90")]
		public static Id32<LocalVariables.M> BKWTIGHNCDD(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x29173C0", Offset = "0x29165C0", VA = "0x1829173C0")]
		public static Id32<LocalVariables.M> HDLHSOAOECE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3A9EA10", Offset = "0x3A9DC10", VA = "0x183A9EA10")]
		public static void KRGBWIFQDOJ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<FDGPVGVZFUQ> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, IRREUTSWWRI<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3AA0980", Offset = "0x3A9FB80", VA = "0x183AA0980")]
		public static void WVBWCWAPPNF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<SYLDEMURFRQ> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, IRREUTSWWRI<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E6F0", Offset = "0x3A9D8F0", VA = "0x183A9E6F0")]
		public static Id32<LocalVariables.M> JOZJDFBPPXT<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, IRREUTSWWRI<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3A9DEB0", Offset = "0x3A9D0B0", VA = "0x183A9DEB0")]
		public static Id32<LocalVariables.M> GOIKZZESBKC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, IRREUTSWWRI<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E3D0", Offset = "0x3A9D5D0", VA = "0x183A9E3D0")]
		public static Id32<DataBackResults.M> IYQLBVXRIPJ<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, IRREUTSWWRI<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3AA0680", Offset = "0x3A9F880", VA = "0x183AA0680")]
		public static Id32<ExecForwardResults.M> WTUYSYZWLKU<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, IRREUTSWWRI<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x291A740", Offset = "0x2919940", VA = "0x18291A740")]
		public static Id32<DataBackResults.M> VXSFKULHYUI(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2916CE0", Offset = "0x2915EE0", VA = "0x182916CE0")]
		public static Id32<DataBackResults.M> EUBNZAXYKAG(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3A9FA90", Offset = "0x3A9EC90", VA = "0x183A9FA90")]
		public static Id32<DataBackResults.M> PMKMWIJXCGJ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<FDGPVGVZFUQ> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, IRREUTSWWRI<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F7D0", Offset = "0x3A9E9D0", VA = "0x183A9F7D0")]
		private static Id32<DataBackResults.M> PMKMWIJXCGJ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<FDGPVGVZFUQ> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, IRREUTSWWRI<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3A9DA60", Offset = "0x3A9CC60", VA = "0x183A9DA60")]
		public static Id32<LocalVariables.M> ESJNAWJRPPD<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, IRREUTSWWRI<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3AA10B0", Offset = "0x3AA02B0", VA = "0x183AA10B0")]
		public static void XCGNFWCJKNG<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, IRREUTSWWRI<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<VNZZUSDPSXP<MMYRGMCMOOI>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<VNZZUSDPSXP<MMYRGMCMOOI>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
		public LiveInterval(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> firstUse, Id32<VNZZUSDPSXP<MMYRGMCMOOI>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x29128C0", Offset = "0x2911AC0", VA = "0x1829128C0")]
		public static LiveInterval New(Id32<VNZZUSDPSXP<MMYRGMCMOOI>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class XIXVDTVABOQ : PTYDUYLYTIH
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
			[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class FRNVKWYWNNO : PTYDUYLYTIH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class EMDJGLUCHTN : PTYDUYLYTIH
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
			[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
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
		public abstract class PTYDUYLYTIH
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
			public Id32<PTYDUYLYTIH> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2912620", Offset = "0x2911820", VA = "0x182912620")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<PTYDUYLYTIH> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class HVBUOMVKQTM : PTYDUYLYTIH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<XIXVDTVABOQ, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<EMDJGLUCHTN, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<HVBUOMVKQTM, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<FRNVKWYWNNO, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2912AC0", Offset = "0x2911CC0", VA = "0x182912AC0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<XIXVDTVABOQ, ArgumentInst> argumentVariables, [In] SOAId32Field<EMDJGLUCHTN, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<HVBUOMVKQTM, ParameterInst> parameterVariables, [In] SOAId32Field<FRNVKWYWNNO, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x29128D0", Offset = "0x2911AD0", VA = "0x1829128D0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class KWGYKVFGUSH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2912810", Offset = "0x2911A10", VA = "0x182912810")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class ZAMCDENAAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x291B270", Offset = "0x291A470", VA = "0x18291B270")]
		public static void SOOCWXYATXH(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.YSSOREGTBKT, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2910610", Offset = "0x290F810", VA = "0x182910610")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.YSSOREGTBKT, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x29105A0", Offset = "0x290F7A0", VA = "0x1829105A0")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2910380", Offset = "0x290F580", VA = "0x182910380")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x337AFB0", Offset = "0x337A1B0", VA = "0x18337AFB0")]
		public static void SOOCWXYATXH<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<NZKBDZMUQMJ> graphId) where TDeps : notnull, IRREUTSWWRI<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class JPLMLRTEKPS
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2912640", Offset = "0x2911840", VA = "0x182912640")]
		public static void SOOCWXYATXH(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface SAMDSCMXYAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BGROZSDKTFO(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : SAMDSCMXYAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2915400", Offset = "0x2914600", VA = "0x182915400", Slot = "4")]
			public void BGROZSDKTFO(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : SAMDSCMXYAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2915490", Offset = "0x2914690", VA = "0x182915490", Slot = "4")]
			public void BGROZSDKTFO(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : SAMDSCMXYAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x29152C0", Offset = "0x29144C0", VA = "0x1829152C0", Slot = "4")]
			public void BGROZSDKTFO(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : SAMDSCMXYAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2915350", Offset = "0x2914550", VA = "0x182915350", Slot = "4")]
			public void BGROZSDKTFO(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class GKTBYNGJCET<c> where c : struct, SAMDSCMXYAT
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c SNMLORCJSFB;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x35E9670", Offset = "0x35E8870", VA = "0x1835E9670")]
			public static int SOOCWXYATXH<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : IRREUTSWWRI<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<FunctionCalls.YSSOREGTBKT>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x29125D0", Offset = "0x29117D0", VA = "0x1829125D0")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<FunctionCalls.YSSOREGTBKT>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2912520", Offset = "0x2911720", VA = "0x182912520")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x29124E0", Offset = "0x29116E0", VA = "0x1829124E0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x37B9B60", Offset = "0x37B8D60", VA = "0x1837B9B60")]
		public static void SOOCWXYATXH<b, a>(FunctionCompileState a, b b, a c) where b : IRREUTSWWRI<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class CZSGJBKHEVX
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
		private static int KLNXXGSKXDH;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int JEALYVEQZWL;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2910820", Offset = "0x290FA20", VA = "0x182910820")]
		public static void SOOCWXYATXH(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2910D80", Offset = "0x290FF80", VA = "0x182910D80")]
		private static void SVATDRWNTFC([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2910F90", Offset = "0x2910190", VA = "0x182910F90")]
		private static void SVATDRWNTFC(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x29106C0", Offset = "0x290F8C0", VA = "0x1829106C0")]
		private static void MTVIPFWQPXN(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class CUOUMJXZRSF<a, b, c> where a : struct, TJRQHGJNIHD<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a SNMLORCJSFB;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE780", Offset = "0x3DBD980", VA = "0x183DBE780")]
		public static void SOOCWXYATXH([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface TJRQHGJNIHD<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> NQABRUPIGSV(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QCAGYRKYBOP(a a, b b, Id32<VNZZUSDPSXP<FQPBODQMINB>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface NYTLYROSEJW<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a IQGVKUDUDYE(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool JQLSLJVJTPQ(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<VNZZUSDPSXP<FQPBODQMINB>> OMLTMKYGWDV(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class CTNLSLACCVW<a, b, c> where a : struct, NYTLYROSEJW<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a SNMLORCJSFB;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3DA8D70", Offset = "0x3DA7F70", VA = "0x183DA8D70")]
		public static UnsafeList<b> SOOCWXYATXH(int a, [In] c values)
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
