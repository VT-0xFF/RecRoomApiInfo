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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC7600", Offset = "0x2BC6000", VA = "0x182BC7600")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
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
		public readonly Id32<WXKPXITHDLK<WFSWBPUBAOK>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
		public ByteCodeAdjustment(Id32<WXKPXITHDLK<WFSWBPUBAOK>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class RNCGSOCBGJO : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2B60510", Offset = "0x2B5EF10", VA = "0x182B60510")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE040", Offset = "0x2BBCA40", VA = "0x182BBE040", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class FZPRUFTYCXR : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<WXKPXITHDLK<VABZENOIJNF>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
			public DeadEnd(Id32<WXKPXITHDLK<VABZENOIJNF>> nextByteCodePtr)
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
		public abstract class SJADMLYUAKY
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
			public readonly Id32<SJADMLYUAKY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
			public Inst(Def def, Id32<SJADMLYUAKY> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class UBARBXGPNHS : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class STJWYORDNIG : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x23C6480", Offset = "0x23C4E80", VA = "0x1823C6480", Slot = "3")]
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
		internal IdUnsafeList<RNCGSOCBGJO, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<FZPRUFTYCXR, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<UBARBXGPNHS, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<STJWYORDNIG, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE1F0", Offset = "0x2BBCBF0", VA = "0x182BBE1F0")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<RNCGSOCBGJO, BytesImmediate> bytesImmediates, [In] IdUnsafeList<FZPRUFTYCXR, DeadEnd> deadEnds, [In] IdUnsafeList<UBARBXGPNHS, Variable> variables, [In] IdUnsafeList<STJWYORDNIG, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE0B0", Offset = "0x2BBCAB0", VA = "0x182BBE0B0")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class VVUNBUVWEOT
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC82B0", Offset = "0x2BC6CB0", VA = "0x182BC82B0")]
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
		public sealed class MHKGAZVGOGT : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
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
		public abstract class SJADMLYUAKY
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
			public readonly Id32<SJADMLYUAKY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
			public Inst(Def def, Id32<SJADMLYUAKY> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<MHKGAZVGOGT, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE310", Offset = "0x2BBCD10", VA = "0x182BBE310")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<MHKGAZVGOGT, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE280", Offset = "0x2BBCC80", VA = "0x182BBE280")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class UWVLDHBNKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7FF0", Offset = "0x2BC69F0", VA = "0x182BC7FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBE3F0", Offset = "0x2BBCDF0", VA = "0x182BBE3F0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE350", Offset = "0x2BBCD50", VA = "0x182BBE350")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class LSRUPEQRHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF7A0", Offset = "0x2BBE1A0", VA = "0x182BBF7A0")]
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
		public sealed class PHDBOBFMAQL : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<JBPPZEYKYJG> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
			public ExternalCall(Id32<JBPPZEYKYJG> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class SJADMLYUAKY
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
			public readonly Id32<SJADMLYUAKY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
			private Inst(Def def, Id32<SJADMLYUAKY> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF5A0", Offset = "0x2BBDFA0", VA = "0x182BBF5A0")]
			public static Inst New(Def def, Id32<SJADMLYUAKY> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class QIHZGXQRTZL : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<JBPPZEYKYJG> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
			public InternalCall(Id32<JBPPZEYKYJG> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class JBPPZEYKYJG
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
			[Cpp2IlInjected.Address(RVA = "0x2BBE310", Offset = "0x2BBCD10", VA = "0x182BBE310")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF3F0", Offset = "0x2BBDDF0", VA = "0x182BBF3F0")]
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
		internal IdUnsafeList<QIHZGXQRTZL, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<PHDBOBFMAQL, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<JBPPZEYKYJG> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<JBPPZEYKYJG, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE5F0", Offset = "0x2BBCFF0", VA = "0x182BBE5F0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<QIHZGXQRTZL, InternalCall> internalCalls, [In] IdUnsafeList<PHDBOBFMAQL, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<JBPPZEYKYJG> IOId)> callsWithIO, [In] IdUnsafeList<JBPPZEYKYJG, IO> io, [In] SOAField<JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> ioModifyingCallLocations, [In] SOAField<JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE450", Offset = "0x2BBCE50", VA = "0x182BBE450")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class VHSFWGTIYBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8260", Offset = "0x2BC6C60", VA = "0x182BC8260")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8050", Offset = "0x2BC6A50", VA = "0x182BC8050")]
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
		internal SOAField<ADNWLQIRYCV, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<ADNWLQIRYCV>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF040", Offset = "0x2BBDA40", VA = "0x182BBF040")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<ADNWLQIRYCV, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<ADNWLQIRYCV>> generatedOutputsForExpression, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE6B0", Offset = "0x2BBD0B0", VA = "0x182BBE6B0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class MFBKOKREUQW
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : FCHXAOXANFH<Id32<FunctionCalls.JBPPZEYKYJG>, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7AB0", Offset = "0x2BC64B0", VA = "0x182BC7AB0")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7A60", Offset = "0x2BC6460", VA = "0x182BC7A60", Slot = "4")]
			public Id32<FunctionCalls.JBPPZEYKYJG> KECGMKFBPXL(int a)
			{
				return default(Id32<FunctionCalls.JBPPZEYKYJG>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70")]
			public bool FNGNUPUAPOT(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "5")]
			private bool COVECNUXTIH(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7AA0", Offset = "0x2BC64A0", VA = "0x182BC7AA0", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> STBRDZEWRTY(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : KFITFPEAZWY<Id32<FunctionCalls.JBPPZEYKYJG>, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD1D0", Offset = "0x2BBBBD0", VA = "0x182BBD1D0")]
			public UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>> GWRKSQGDBQS(int a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD2F0", Offset = "0x2BBBCF0", VA = "0x182BBD2F0")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD250", Offset = "0x2BBBC50", VA = "0x182BBD250", Slot = "6")]
			public void SJJLUJOAAPQ(Id32<FunctionCalls.JBPPZEYKYJG> a, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> b, Id32<WXKPXITHDLK<WFSWBPUBAOK>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD1D0", Offset = "0x2BBBBD0", VA = "0x182BBD1D0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>> XMFUTKZFBRP(int a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD240", Offset = "0x2BBBC40", VA = "0x182BBD240", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> HUAUFKLZRPV(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : FCHXAOXANFH<Id32<FunctionCalls.JBPPZEYKYJG>, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7B80", Offset = "0x2BC6580", VA = "0x182BC7B80")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7B40", Offset = "0x2BC6540", VA = "0x182BC7B40", Slot = "4")]
			public Id32<FunctionCalls.JBPPZEYKYJG> KECGMKFBPXL(int a)
			{
				return default(Id32<FunctionCalls.JBPPZEYKYJG>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70")]
			public bool FNGNUPUAPOT(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "5")]
			private bool NAPOXIQDJWQ(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7B30", Offset = "0x2BC6530", VA = "0x182BC7B30", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> DXZMKOJLSAB(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : KFITFPEAZWY<Id32<FunctionCalls.JBPPZEYKYJG>, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD370", Offset = "0x2BBBD70", VA = "0x182BBD370")]
			public UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>> GWRKSQGDBQS(int a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD490", Offset = "0x2BBBE90", VA = "0x182BBD490")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD3F0", Offset = "0x2BBBDF0", VA = "0x182BBD3F0", Slot = "6")]
			public void SJJLUJOAAPQ(Id32<FunctionCalls.JBPPZEYKYJG> a, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> b, Id32<WXKPXITHDLK<WFSWBPUBAOK>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD370", Offset = "0x2BBBD70", VA = "0x182BBD370", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>> IYOKVHDWASO(int a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD3E0", Offset = "0x2BBBDE0", VA = "0x182BBD3E0", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> NEXCQOVQKTQ(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : FCHXAOXANFH<Id32<QLUJOYTGVHG>, SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7CB0", Offset = "0x2BC66B0", VA = "0x182BC7CB0")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7C70", Offset = "0x2BC6670", VA = "0x182BC7C70", Slot = "4")]
			public Id32<QLUJOYTGVHG> KECGMKFBPXL(int a)
			{
				return default(Id32<QLUJOYTGVHG>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7C00", Offset = "0x2BC6600", VA = "0x182BC7C00")]
			public bool FNGNUPUAPOT(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7C00", Offset = "0x2BC6600", VA = "0x182BC7C00", Slot = "5")]
			private bool ZWNDEMQDCHA(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7C60", Offset = "0x2BC6660", VA = "0x182BC7C60", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> FWWTHKPHJWH(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : KFITFPEAZWY<Id32<QLUJOYTGVHG>, SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD520", Offset = "0x2BBBF20", VA = "0x182BBD520")]
			public UnsafeList<Id32<QLUJOYTGVHG>> GWRKSQGDBQS(int a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(UnsafeList<Id32<QLUJOYTGVHG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD690", Offset = "0x2BBC090", VA = "0x182BBD690")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD590", Offset = "0x2BBBF90", VA = "0x182BBD590", Slot = "6")]
			public void SJJLUJOAAPQ(Id32<QLUJOYTGVHG> a, SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> b, Id32<WXKPXITHDLK<WFSWBPUBAOK>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD520", Offset = "0x2BBBF20", VA = "0x182BBD520", Slot = "4")]
			private UnsafeList<Id32<QLUJOYTGVHG>> EXMLRXMAUUI(int a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(UnsafeList<Id32<QLUJOYTGVHG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD510", Offset = "0x2BBBF10", VA = "0x182BBD510", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> DAKIASEDMOA(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : FCHXAOXANFH<int, UnsafeList<(Id32<LocalVariables.M>, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7EB0", Offset = "0x2BC68B0", VA = "0x182BC7EB0")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD75DC0", Offset = "0xD747C0", VA = "0x180D75DC0", Slot = "4")]
			public int KECGMKFBPXL(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70")]
			public bool FNGNUPUAPOT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "5")]
			private bool HPASLXSANJR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7EA0", Offset = "0x2BC68A0", VA = "0x182BC7EA0", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> JWKISGIELSG(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : KFITFPEAZWY<int, UnsafeList<(Id32<LocalVariables.M>, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDB70", Offset = "0x2BBC570", VA = "0x182BBDB70")]
			public UnsafeList<int> GWRKSQGDBQS(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDCE0", Offset = "0x2BBC6E0", VA = "0x182BBDCE0")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDBE0", Offset = "0x2BBC5E0", VA = "0x182BBDBE0", Slot = "6")]
			public void SJJLUJOAAPQ(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values, Id32<WXKPXITHDLK<WFSWBPUBAOK>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDB70", Offset = "0x2BBC570", VA = "0x182BBDB70", Slot = "4")]
			private UnsafeList<int> SIJNDRLNQYH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDB60", Offset = "0x2BBC560", VA = "0x182BBDB60", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> BUFGLBJGCYZ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : FCHXAOXANFH<int, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7E00", Offset = "0x2BC6800", VA = "0x182BC7E00")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD75DC0", Offset = "0xD747C0", VA = "0x180D75DC0", Slot = "4")]
			public int KECGMKFBPXL(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70")]
			public bool FNGNUPUAPOT(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "5")]
			private bool VUSHHLLLXFM(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7E90", Offset = "0x2BC6890", VA = "0x182BC7E90", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> XTMAIRYPOPN(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : KFITFPEAZWY<int, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD950", Offset = "0x2BBC350", VA = "0x182BBD950")]
			public UnsafeList<int> GWRKSQGDBQS(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDAD0", Offset = "0x2BBC4D0", VA = "0x182BBDAD0")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD9D0", Offset = "0x2BBC3D0", VA = "0x182BBD9D0", Slot = "6")]
			public void SJJLUJOAAPQ(int a, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values, Id32<WXKPXITHDLK<WFSWBPUBAOK>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD950", Offset = "0x2BBC350", VA = "0x182BBD950", Slot = "4")]
			private UnsafeList<int> SEGSIUTHCKO(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD9C0", Offset = "0x2BBC3C0", VA = "0x182BBD9C0", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> PKJEPMGCETI(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : FCHXAOXANFH<int, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7D60", Offset = "0x2BC6760", VA = "0x182BC7D60")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD75DC0", Offset = "0xD747C0", VA = "0x180D75DC0", Slot = "4")]
			public int KECGMKFBPXL(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70")]
			public bool FNGNUPUAPOT(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "5")]
			private bool VUSHHLLLXFM(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7DF0", Offset = "0x2BC67F0", VA = "0x182BC7DF0", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> XTMAIRYPOPN(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : KFITFPEAZWY<int, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD740", Offset = "0x2BBC140", VA = "0x182BBD740")]
			public UnsafeList<int> GWRKSQGDBQS(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD8C0", Offset = "0x2BBC2C0", VA = "0x182BBD8C0")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD7C0", Offset = "0x2BBC1C0", VA = "0x182BBD7C0", Slot = "6")]
			public void SJJLUJOAAPQ(int a, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values, Id32<WXKPXITHDLK<WFSWBPUBAOK>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD740", Offset = "0x2BBC140", VA = "0x182BBD740", Slot = "4")]
			private UnsafeList<int> SEGSIUTHCKO(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD7B0", Offset = "0x2BBC1B0", VA = "0x182BBD7B0", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> PKJEPMGCETI(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1CF27F0", Offset = "0x1CF11F0", VA = "0x181CF27F0")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF3E0", Offset = "0x2BBDDE0", VA = "0x182BBF3E0")]
			public void OGNPAZKLJRJ([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<QLUJOYTGVHG> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF3C0", Offset = "0x2BBDDC0", VA = "0x182BBF3C0")]
			public GenerateDataBackFromInputIndexResult(Id32<QLUJOYTGVHG> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF3B0", Offset = "0x2BBDDB0", VA = "0x182BBF3B0")]
			public void OGNPAZKLJRJ([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF390", Offset = "0x2BBDD90", VA = "0x182BBF390")]
			public void OGNPAZKLJRJ([Out] Id32<DataBackResults.M> a, [Out] Id32<QLUJOYTGVHG> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<QLUJOYTGVHG> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
			public GenerateDataBackFromInputIndicesResult(Id32<QLUJOYTGVHG> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF3D0", Offset = "0x2BBDDD0", VA = "0x182BBF3D0")]
			public void OGNPAZKLJRJ([Out] Id32<DataBackResults.M> a, [Out] Id32<QLUJOYTGVHG> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0490", Offset = "0x2BBEE90", VA = "0x182BC0490")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2BC13F0", Offset = "0x2BBFDF0", VA = "0x182BC13F0")]
		public static void NVWBHOTLECY(this FunctionCompileState a, Id32<ADNWLQIRYCV> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1740", Offset = "0x2BC0140", VA = "0x182BC1740")]
		public static void QATSXLHUZFM(this FunctionCompileState a, Id32<ADNWLQIRYCV> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1370", Offset = "0x2BBFD70", VA = "0x182BC1370")]
		public static Id32<DataBackResults.M>? MALIWTSNDSX([In] this FunctionCompileState self, Id32<ADNWLQIRYCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1E20", Offset = "0x2BC0820", VA = "0x182BC1E20")]
		public static Id32<WXKPXITHDLK<VABZENOIJNF>> WVEKWJSTWBV([In] this FunctionCompileState self)
		{
			return default(Id32<WXKPXITHDLK<VABZENOIJNF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFCD0", Offset = "0x2BBE6D0", VA = "0x182BBFCD0")]
		private static void BMOCKWXBAFC(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1E80", Offset = "0x2BC0880", VA = "0x182BC1E80")]
		private static Id32<WXKPXITHDLK<VABZENOIJNF>>? XHYWZKFIUTZ([In] this FunctionCompileState self, Id32<QLUJOYTGVHG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFF50", Offset = "0x2BBE950", VA = "0x182BBFF50")]
		public static void CZBYYUSJKOX(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1AE0", Offset = "0x2BC04E0", VA = "0x182BC1AE0")]
		public static DataBackResults.Def RZTGBCWYIBZ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1A00", Offset = "0x2BC0400", VA = "0x182BC1A00")]
		public static ReadOnlyArray<byte> RLBFHSXRENV([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0320", Offset = "0x2BBED20", VA = "0x182BC0320")]
		public static Id32<LocalVariables.M> DTQLIMHIROJ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1920", Offset = "0x2BC0320", VA = "0x182BC1920")]
		public static Union32 RATGTPUQWRL([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C49760", Offset = "0x3C48160", VA = "0x183C49760")]
		private static Id32<DataBackResults.M> NCJAOVMJLAW<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.SJADMLYUAKY
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1C50", Offset = "0x2BC0650", VA = "0x182BC1C50")]
		public static Id32<DataBackResults.M> VKVVQRQNVGY(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0400", Offset = "0x2BBEE00", VA = "0x182BC0400")]
		public static Id32<DataBackResults.M> DUZZSZFPAVN(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1BD0", Offset = "0x2BC05D0", VA = "0x182BC1BD0")]
		public static Id32<DataBackResults.M> ULIVWZTNKNU(this FunctionCompileState a, Id32<WXKPXITHDLK<VABZENOIJNF>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1F50", Offset = "0x2BC0950", VA = "0x182BC1F50")]
		public static Id32<DataBackResults.M> YQUWBQSOQCE(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0BE0", Offset = "0x2BBF5E0", VA = "0x182BC0BE0")]
		public static Id32<DataBackResults.M> HVFYHQBZKIL(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C4ADC0", Offset = "0x3C497C0", VA = "0x183C4ADC0")]
		private static Id32<ExecForwardResults.M> UWBUBWOGYWJ<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.SJADMLYUAKY
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BC02E0", Offset = "0x2BBECE0", VA = "0x182BC02E0")]
		public static Id32<ExecForwardResults.M> DLPRTPYNWDV(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0930", Offset = "0x2BBF330", VA = "0x182BC0930")]
		public static Id32<ExecForwardResults.M> FLEIQSYUSTC(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1B50", Offset = "0x2BC0550", VA = "0x182BC1B50")]
		public static Id32<ExecForwardResults.M> TWRSVHGNZFC(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1D40", Offset = "0x2BC0740", VA = "0x182BC1D40")]
		public static Id32<ExecForwardResults.M> WQROPHSMGLL(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1090", Offset = "0x2BBFA90", VA = "0x182BC1090")]
		public static Id32<ExecForwardResults.M> KHVWOZIYGCJ(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1020", Offset = "0x2BBFA20", VA = "0x182BC1020")]
		public static FunctionCalls.Def JVMBRVWEXPI([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC10E0", Offset = "0x2BBFAE0", VA = "0x182BC10E0")]
		public static CopyEnumerable<Id32<FunctionCalls.JBPPZEYKYJG>, Id32Enumerator<FunctionCalls.JBPPZEYKYJG>> KRVUHEWRJML([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.JBPPZEYKYJG>, Id32Enumerator<FunctionCalls.JBPPZEYKYJG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0D70", Offset = "0x2BBF770", VA = "0x182BC0D70")]
		public static Id32<FunctionCalls.JBPPZEYKYJG> IWETUUNIWSK([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.JBPPZEYKYJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1CD0", Offset = "0x2BC06D0", VA = "0x182BC1CD0")]
		public static FunctionCalls.IO WQQOTRYZHXR([In] this FunctionCompileState self, Id32<FunctionCalls.JBPPZEYKYJG> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1120", Offset = "0x2BBFB20", VA = "0x182BC1120")]
		public static FunctionCalls.IO KTEEOLSMRJV(this FunctionCompileState a, Id32<FunctionCalls.JBPPZEYKYJG> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C496D0", Offset = "0x3C480D0", VA = "0x183C496D0")]
		private static Id32<FunctionCalls.M> MJDDORZLQIA<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.SJADMLYUAKY
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFB20", Offset = "0x2BBE520", VA = "0x182BBFB20")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>) AGBPNQJBQIF(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1590", Offset = "0x2BBFF90", VA = "0x182BC1590")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>) PWIUONWKBDN(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2BC08E0", Offset = "0x2BBF2E0", VA = "0x182BC08E0")]
		public static Id32<FunctionCalls.M> ERQBQAAYHJW(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFE70", Offset = "0x2BBE870", VA = "0x182BBFE70")]
		public static void COENMYHJLSF(this FunctionCompileState a, Id32<FunctionCalls.JBPPZEYKYJG> b, Id32<WXKPXITHDLK<VABZENOIJNF>> c, Id32<WXKPXITHDLK<CXMCVELPQUC>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C49800", Offset = "0x3C48200", VA = "0x183C49800")]
		public static GenerateDataBackResult NDVTJOTHBUB<d, e>(this FunctionCompileState a, d b, e c, Id32<VFKNGTPUEMY> d, Id32<QLUJOYTGVHG> e) where d : EXZIFHHHFWB<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C49280", Offset = "0x3C47C80", VA = "0x183C49280")]
		public static GenerateDataBackFromInputIndexResult LYMPVEQBQRP<f, g>(this FunctionCompileState a, f b, g c, Id32<VFKNGTPUEMY> d, Id32<MVBOYPURKWM> e, int f) where f : EXZIFHHHFWB<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3C4AE60", Offset = "0x3C49860", VA = "0x183C4AE60")]
		public static Id32<DataBackResults.M>? YYPLHKZDDWI<h, i>(this FunctionCompileState a, h b, i c, Id32<VFKNGTPUEMY> d, Id32<MVBOYPURKWM> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : EXZIFHHHFWB<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C48A60", Offset = "0x3C47460", VA = "0x183C48A60")]
		public static Id32<ExecForwardResults.M> JBJFRQZIZOY<j, k>(this FunctionCompileState a, j b, k c, Id32<VFKNGTPUEMY> d, Id32<ADNWLQIRYCV> e) where j : EXZIFHHHFWB<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC00C0", Offset = "0x2BBEAC0", VA = "0x182BC00C0")]
		public static LocalVariables.ArgumentInst CZRKRVLCCFO([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1480", Offset = "0x2BBFE80", VA = "0x182BC1480")]
		public static LocalVariables.CalleeReturnValueInst OQBOCRKESMU([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC01D0", Offset = "0x2BBEBD0", VA = "0x182BC01D0")]
		public static LocalVariables.CallerReturnValueInst DFJNRKJQQDV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0980", Offset = "0x2BBF380", VA = "0x182BC0980")]
		public static Id32<LocalVariables.M> GSUOLPIXGLX(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1810", Offset = "0x2BC0210", VA = "0x182BC1810")]
		public static LocalVariables.ParameterInst QICVOMVDQTQ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFF00", Offset = "0x2BBE900", VA = "0x182BBFF00")]
		public static LocalVariables.Def CSNRTICWXRQ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1F00", Offset = "0x2BC0900", VA = "0x182BC1F00")]
		public static int? YLJWYGTOFHG([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C48960", Offset = "0x3C47360", VA = "0x183C48960")]
		private static Id32<LocalVariables.M> IPWZAYFXQLS<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.SJADMLYUAKY
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0B30", Offset = "0x2BBF530", VA = "0x182BC0B30")]
		public static Id32<LocalVariables.M> HLKQZZNECMS(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1190", Offset = "0x2BBFB90", VA = "0x182BC1190")]
		public static Id32<LocalVariables.M> LFJKXTEVROF(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0760", Offset = "0x2BBF160", VA = "0x182BC0760")]
		public static Id32<LocalVariables.M> EIMSLLQDDBV(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1D90", Offset = "0x2BC0790", VA = "0x182BC1D90")]
		public static Id32<LocalVariables.M> WSPJGYUDGKD(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1310", Offset = "0x2BBFD10", VA = "0x182BC1310")]
		public static Id32<LocalVariables.M> LXKBIDQQXTF(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2BC11F0", Offset = "0x2BBFBF0", VA = "0x182BC11F0")]
		public static void LTJAPHOKNKU(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0C60", Offset = "0x2BBF660", VA = "0x182BC0C60")]
		public static void ITXWSLUFBVK(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2060", Offset = "0x2BC0A60", VA = "0x182BC2060")]
		public static void ZNXPQPSDJTG(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1FD0", Offset = "0x2BC09D0", VA = "0x182BC1FD0")]
		public static void ZNDBNZAWEXZ(this FunctionCompileState a, Id32<WXKPXITHDLK<VABZENOIJNF>> b, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0F40", Offset = "0x2BBF940", VA = "0x182BC0F40")]
		public static void JKKXRUAXRKH(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<WXKPXITHDLK<PFWNNIRWZZM>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3C4ACE0", Offset = "0x3C496E0", VA = "0x183C4ACE0")]
		public static void RQSKTLDNJUQ<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<WXKPXITHDLK<IXKHGZWDMFU<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface EXZIFHHHFWB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<IUBIECDJGSA> BBBCYFXAQKO(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<IUBIECDJGSA> OIOWZEBVGIH(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<IUBIECDJGSA> HNEJKNDKPWA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<IUBIECDJGSA> VJOZMNTHWIX(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> FONCFOJGNND(a a, FunctionCompileState b, Id32<VFKNGTPUEMY> c, Id32<QLUJOYTGVHG> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> FCASEMJJNAL(a a, FunctionCompileState b, Id32<VFKNGTPUEMY> c, Id32<ADNWLQIRYCV> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int VGYEJTKADNN(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<ADNWLQIRYCV> CBZUWVCHZUM(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind QWJZPIJDCIZ(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HZAQGYKKCJU(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int RZDLJYEGGED(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> QQRYZZGFDJD(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<IUBIECDJGSA>) VSQISJNNPQP(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int REARDYVAZKR(a a, Id32<VFKNGTPUEMY> b, Id32<ADNWLQIRYCV> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<QLUJOYTGVHG> DEUICNATHHW(a a, Id32<VFKNGTPUEMY> b, Id32<ADNWLQIRYCV> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<QLUJOYTGVHG> DOESMTLHEMB(a a, Id32<VFKNGTPUEMY> b, Id32<MVBOYPURKWM> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int QTXIWKJKDIN(a a, Id32<VFKNGTPUEMY> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? STWWOJECUWJ(a a, Id32<VFKNGTPUEMY> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int UXIWTLZVYGL(a a, Id32<VFKNGTPUEMY> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? VELANUUGKPN(a a, Id32<VFKNGTPUEMY> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class MURXNLTJXMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C58C10", Offset = "0x3C57610", VA = "0x183C58C10")]
		public static Id32<LocalVariables.M?> CDGAJSFPVVB<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C5C520", Offset = "0x3C5AF20", VA = "0x183C5C520")]
		public static Id32<LocalVariables.M?> WFAEWJRFXIK<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B900", Offset = "0x3C5A300", VA = "0x183C5B900")]
		public static Id32<LocalVariables.M?> OQELPZFYHBF<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC35F0", Offset = "0x2BC1FF0", VA = "0x182BC35F0")]
		public static Id32<LocalVariables.M> GRQWXGOASKJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5C30", Offset = "0x2BC4630", VA = "0x182BC5C30")]
		public static Id32<LocalVariables.M> SINOEXLVUJI(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC38F0", Offset = "0x2BC22F0", VA = "0x182BC38F0")]
		public static Id32<LocalVariables.M> IKAFSZQBHLB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC36F0", Offset = "0x2BC20F0", VA = "0x182BC36F0")]
		public static Id32<LocalVariables.M> HBPUYIUQTEP(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2B40", Offset = "0x2BC1540", VA = "0x182BC2B40")]
		public static Id32<LocalVariables.M> DZMWLUCEXQY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC46D0", Offset = "0x2BC30D0", VA = "0x182BC46D0")]
		public static Id32<LocalVariables.M> MFAISFRBLCF(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2C60", Offset = "0x2BC1660", VA = "0x182BC2C60")]
		public static Id32<LocalVariables.M> ECHFHLXTSGZ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2EA0", Offset = "0x2BC18A0", VA = "0x182BC2EA0")]
		public static Id32<LocalVariables.M> EUHZCHUYWMK(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6CF0", Offset = "0x2BC56F0", VA = "0x182BC6CF0")]
		public static Id32<LocalVariables.M> XZTKTWJHGKT(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5B30", Offset = "0x2BC4530", VA = "0x182BC5B30")]
		public static Id32<LocalVariables.M> RWUOLPMGBJY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4BE0", Offset = "0x2BC35E0", VA = "0x182BC4BE0")]
		public static Id32<LocalVariables.M> MXZAOGWHIKV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6010", Offset = "0x2BC4A10", VA = "0x182BC6010")]
		public static Id32<LocalVariables.M> UAOJHPRMFPO(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2540", Offset = "0x2BC0F40", VA = "0x182BC2540")]
		public static Id32<LocalVariables.M> ATGMFSIIWQP(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4FF0", Offset = "0x2BC39F0", VA = "0x182BC4FF0")]
		public static Id32<LocalVariables.M> OYXYIZACOBG(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7280", Offset = "0x2BC5C80", VA = "0x182BC7280")]
		public static Id32<LocalVariables.M> YSDXEAIIYBH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6C70", Offset = "0x2BC5670", VA = "0x182BC6C70")]
		public static Id32<LocalVariables.M> XSWAWPHAUZF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC74E0", Offset = "0x2BC5EE0", VA = "0x182BC74E0")]
		public static Id32<LocalVariables.M> ZIYJTUIBDMU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4E20", Offset = "0x2BC3820", VA = "0x182BC4E20")]
		public static Id32<LocalVariables.M> NXMQGEFSXUF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC31F0", Offset = "0x2BC1BF0", VA = "0x182BC31F0")]
		public static Id32<LocalVariables.M> FOOVXCBWJAS(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5120", Offset = "0x2BC3B20", VA = "0x182BC5120")]
		public static Id32<LocalVariables.M> PEZHVHYZPBT(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC49C0", Offset = "0x2BC33C0", VA = "0x182BC49C0")]
		public static Id32<LocalVariables.M> MODBDGYCBAE(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6370", Offset = "0x2BC4D70", VA = "0x182BC6370")]
		public static Id32<LocalVariables.M> ULOQSHXMVXC(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC63F0", Offset = "0x2BC4DF0", VA = "0x182BC63F0")]
		public static Id32<LocalVariables.M> UOEWODGBYDF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2980", Offset = "0x2BC1380", VA = "0x182BC2980")]
		public static Id32<LocalVariables.M> CNEJNDKYFMC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC42E0", Offset = "0x2BC2CE0", VA = "0x182BC42E0")]
		public static Id32<LocalVariables.M> JFECNYJPAAR(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5F70", Offset = "0x2BC4970", VA = "0x182BC5F70")]
		public static Id32<LocalVariables.M> TJGELXCEEGC(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4B60", Offset = "0x2BC3560", VA = "0x182BC4B60")]
		public static Id32<LocalVariables.M> MXPZFIWENYH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7080", Offset = "0x2BC5A80", VA = "0x182BC7080")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> YRNCSUPJNHL(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6730", Offset = "0x2BC5130", VA = "0x182BC6730")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> WSEVYTNUNDH(this FunctionCompileState a, int b)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7560", Offset = "0x2BC5F60", VA = "0x182BC7560")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ZQNASLNIOVI(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC67B0", Offset = "0x2BC51B0", VA = "0x182BC67B0")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> XBYFCGUGOSW(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6470", Offset = "0x2BC4E70", VA = "0x182BC6470")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> VHLVCFUZBNM(this FunctionCompileState a, int b)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC69B0", Offset = "0x2BC53B0", VA = "0x182BC69B0")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> XELEKGWNSWV(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5690", Offset = "0x2BC4090", VA = "0x182BC5690")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>) RONQUSROTPE(this FunctionCompileState a, Id32<OYXCYVSZNSL> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3A30", Offset = "0x2BC2430", VA = "0x182BC3A30")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>) IVOPVAEGJFW(this FunctionCompileState a, Id32<GQSCCKHWVOV> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C58F40", Offset = "0x3C57940", VA = "0x183C58F40")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IUBIECDJGSA>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<TMarker>>, Id32<FunctionCalls.M>) EZWGIYNAQNF<TMarker>(this FunctionCompileState a, Id32<IUBIECDJGSA> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IUBIECDJGSA>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4810", Offset = "0x2BC3210", VA = "0x182BC4810")]
		public static Id32<LocalVariables.M> MGCMIKUUOVF(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3100", Offset = "0x2BC1B00", VA = "0x182BC3100")]
		public static Id32<LocalVariables.M> FJFSEMHPCHK(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC48D0", Offset = "0x2BC32D0", VA = "0x182BC48D0")]
		public static Id32<LocalVariables.M> MIOIPNLESCZ(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6610", Offset = "0x2BC5010", VA = "0x182BC6610")]
		public static Id32<LocalVariables.M> VOKSXTHBLOG(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5D50", Offset = "0x2BC4750", VA = "0x182BC5D50")]
		public static Id32<LocalVariables.M> SVEMGVTFFLP(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC64F0", Offset = "0x2BC4EF0", VA = "0x182BC64F0")]
		public static Id32<LocalVariables.M> VJTXFPOZDRA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4590", Offset = "0x2BC2F90", VA = "0x182BC4590")]
		public static Id32<LocalVariables.M> LWPFBOMUIST(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC33B0", Offset = "0x2BC1DB0", VA = "0x182BC33B0")]
		public static Id32<LocalVariables.M> FVOFLCCKXNJ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6150", Offset = "0x2BC4B50", VA = "0x182BC6150")]
		public static Id32<LocalVariables.M> UBFROIUEOYA(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2A00", Offset = "0x2BC1400", VA = "0x182BC2A00")]
		public static Id32<LocalVariables.M> CVGMZFMKZFL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC37F0", Offset = "0x2BC21F0", VA = "0x182BC37F0")]
		public static Id32<LocalVariables.M> IEEICNJQOWY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3870", Offset = "0x2BC2270", VA = "0x182BC3870")]
		public static Id32<LocalVariables.M> IGUNYISFRDB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5510", Offset = "0x2BC3F10", VA = "0x182BC5510")]
		public static Id32<LocalVariables.M> QFUAXIXBYLY(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6270", Offset = "0x2BC4C70", VA = "0x182BC6270")]
		public static Id32<LocalVariables.M> ULMTWYGDPJY(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC52A0", Offset = "0x2BC3CA0", VA = "0x182BC52A0")]
		public static Id32<LocalVariables.M> PMRFZPQEWKV(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC53D0", Offset = "0x2BC3DD0", VA = "0x182BC53D0")]
		public static Id32<LocalVariables.M> PWIFBVZUWYA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC51A0", Offset = "0x2BC3BA0", VA = "0x182BC51A0")]
		public static Id32<LocalVariables.M> PGYRCXZZYZN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4A40", Offset = "0x2BC3440", VA = "0x182BC4A40")]
		public static Id32<LocalVariables.M> MTQPVACTBHO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2D60", Offset = "0x2BC1760", VA = "0x182BC2D60")]
		public static Id32<LocalVariables.M> ENRPDHLFPSB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5FF0", Offset = "0x2BC49F0", VA = "0x182BC5FF0")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> TPGGIZKFHTZ(this FunctionCompileState a)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6A50", Offset = "0x2BC5450", VA = "0x182BC6A50")]
		public static Id32<LocalVariables.M> XHGXTUMSTUQ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC73C0", Offset = "0x2BC5DC0", VA = "0x182BC73C0")]
		public static Id32<LocalVariables.M> ZBTACJZQHUP(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2FC0", Offset = "0x2BC19C0", VA = "0x182BC2FC0")]
		public static Id32<LocalVariables.M> EYUQPPMSOWW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2440", Offset = "0x2BC0E40", VA = "0x182BC2440")]
		public static Id32<LocalVariables.M> AKVNOVGYNJM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5E50", Offset = "0x2BC4850", VA = "0x182BC5E50")]
		public static Id32<LocalVariables.M> SXMSTHUEQCB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC34B0", Offset = "0x2BC1EB0", VA = "0x182BC34B0")]
		public static Id32<LocalVariables.M> GRILZIPUAQM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4480", Offset = "0x2BC2E80", VA = "0x182BC4480")]
		public static Id32<LocalVariables.M> KMKENRMZICJ(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6F70", Offset = "0x2BC5970", VA = "0x182BC6F70")]
		public static Id32<LocalVariables.M> YJDPFVNSRYG(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4580", Offset = "0x2BC2F80", VA = "0x182BC4580")]
		public static void KXWDEBSCRJZ(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2640", Offset = "0x2BC1040", VA = "0x182BC2640")]
		public static Id32<LocalVariables.M> ATOKEPVQLXW(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4D00", Offset = "0x2BC3700", VA = "0x182BC4D00")]
		public static Id32<LocalVariables.M> NLWTIWFNMQP(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6E30", Offset = "0x2BC5830", VA = "0x182BC6E30")]
		public static Id32<LocalVariables.M> YJAXLIRIIHY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2740", Offset = "0x2BC1140", VA = "0x182BC2740")]
		public static Id32<LocalVariables.M> BHYKYDUKLTU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6B50", Offset = "0x2BC5550", VA = "0x182BC6B50")]
		public static Id32<LocalVariables.M> XKZMCSRELAN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3270", Offset = "0x2BC1C70", VA = "0x182BC3270")]
		public static Id32<LocalVariables.M> FQYMULIRWQA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3ED0", Offset = "0x2BC28D0", VA = "0x182BC3ED0")]
		public static Id32<LocalVariables.M> IXBQJEQIZCA(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5590", Offset = "0x2BC3F90", VA = "0x182BC5590")]
		public static Id32<LocalVariables.M> QNJLSQSKQBT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4360", Offset = "0x2BC2D60", VA = "0x182BC4360")]
		public static Id32<LocalVariables.M> JVJGNXLRVDI(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2840", Offset = "0x2BC1240", VA = "0x182BC2840")]
		public static Id32<LocalVariables.M> BOICWFYUAWT(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3C59F30", Offset = "0x3C58930", VA = "0x183C59F30")]
		public static void GVMKBFSRBUW<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<OYXCYVSZNSL> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3C5A9C0", Offset = "0x3C593C0", VA = "0x183C5A9C0")]
		public static void JLPEDWECTJC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<GQSCCKHWVOV> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B4B0", Offset = "0x3C59EB0", VA = "0x183C5B4B0")]
		public static Id32<LocalVariables.M> LQYBBFKQFXU<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BE80", Offset = "0x3C5A880", VA = "0x183C5BE80")]
		public static Id32<LocalVariables.M> VQMHUWVLVQD<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3C59050", Offset = "0x3C57A50", VA = "0x183C59050")]
		public static Id32<DataBackResults.M> FJTBXVIMSDG<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, EXZIFHHHFWB<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3C5A6C0", Offset = "0x3C590C0", VA = "0x183C5A6C0")]
		public static Id32<ExecForwardResults.M> IJHRFABWAXB<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, EXZIFHHHFWB<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4EA0", Offset = "0x2BC38A0", VA = "0x182BC4EA0")]
		public static Id32<DataBackResults.M> ORBLYRXEKXP(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2110", Offset = "0x2BC0B10", VA = "0x182BC2110")]
		public static Id32<DataBackResults.M> AKHENBHHHWD(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3C59360", Offset = "0x3C57D60", VA = "0x183C59360")]
		public static Id32<DataBackResults.M> FNHJSBGFURM<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<OYXCYVSZNSL> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3C59540", Offset = "0x3C57F40", VA = "0x183C59540")]
		private static Id32<DataBackResults.M> FNHJSBGFURM<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<OYXCYVSZNSL> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BA30", Offset = "0x3C5A430", VA = "0x183C5BA30")]
		public static Id32<LocalVariables.M> PLWXDQDDVCG<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B150", Offset = "0x3C59B50", VA = "0x183C5B150")]
		public static void KBWRIOLFAZN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<WXKPXITHDLK<VABZENOIJNF>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<WXKPXITHDLK<VABZENOIJNF>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
		public LiveInterval(Id32<WXKPXITHDLK<VABZENOIJNF>> firstUse, Id32<WXKPXITHDLK<VABZENOIJNF>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF7F0", Offset = "0x2BBE1F0", VA = "0x182BBF7F0")]
		public static LiveInterval New(Id32<WXKPXITHDLK<VABZENOIJNF>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class LZUDEBLVSOP : SJADMLYUAKY
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
			[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class PTBBHQMCPZX : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class NUHWKFDQOWC : SJADMLYUAKY
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
			[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
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
		public abstract class SJADMLYUAKY
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
			public Id32<SJADMLYUAKY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF5B0", Offset = "0x2BBDFB0", VA = "0x182BBF5B0")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<SJADMLYUAKY> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class OAPJQCNVVVV : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<LZUDEBLVSOP, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<NUHWKFDQOWC, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<OAPJQCNVVVV, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<PTBBHQMCPZX, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF9F0", Offset = "0x2BBE3F0", VA = "0x182BBF9F0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<LZUDEBLVSOP, ArgumentInst> argumentVariables, [In] SOAId32Field<NUHWKFDQOWC, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<OAPJQCNVVVV, ParameterInst> parameterVariables, [In] SOAId32Field<PTBBHQMCPZX, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF800", Offset = "0x2BBE200", VA = "0x182BBF800")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class UFMIWPMHYQM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7F40", Offset = "0x2BC6940", VA = "0x182BC7F40")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class PYACYBOAGZO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7680", Offset = "0x2BC6080", VA = "0x182BC7680")]
		public static void YFLRTADXTVQ(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.JBPPZEYKYJG, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE000", Offset = "0x2BBCA00", VA = "0x182BBE000")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.JBPPZEYKYJG, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBDF90", Offset = "0x2BBC990", VA = "0x182BBDF90")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2BBDD70", Offset = "0x2BBC770", VA = "0x182BBDD70")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x36CEDD0", Offset = "0x36CD7D0", VA = "0x1836CEDD0")]
		public static void YFLRTADXTVQ<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<VFKNGTPUEMY> graphId) where TDeps : notnull, EXZIFHHHFWB<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class KTCFINWVMKV
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF5D0", Offset = "0x2BBDFD0", VA = "0x182BBF5D0")]
		public static void YFLRTADXTVQ(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void QJYEQNDSTIV(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7920", Offset = "0x2BC6320", VA = "0x182BC7920", Slot = "4")]
			public void QJYEQNDSTIV(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2BC79B0", Offset = "0x2BC63B0", VA = "0x182BC79B0", Slot = "4")]
			public void QJYEQNDSTIV(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2BC77E0", Offset = "0x2BC61E0", VA = "0x182BC77E0", Slot = "4")]
			public void QJYEQNDSTIV(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7870", Offset = "0x2BC6270", VA = "0x182BC7870", Slot = "4")]
			public void QJYEQNDSTIV(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class SUAUUQZUCGQ<c> where c : struct, DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c BJEOXILCYDG;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3E95680", Offset = "0x3E94080", VA = "0x183E95680")]
			public static int YFLRTADXTVQ<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : EXZIFHHHFWB<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<FunctionCalls.JBPPZEYKYJG>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF560", Offset = "0x2BBDF60", VA = "0x182BBF560")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<FunctionCalls.JBPPZEYKYJG>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF4B0", Offset = "0x2BBDEB0", VA = "0x182BBF4B0")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF470", Offset = "0x2BBDE70", VA = "0x182BBF470")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D910", Offset = "0x3B7C310", VA = "0x183B7D910")]
		public static void YFLRTADXTVQ<b, a>(FunctionCompileState a, b b, a c) where b : EXZIFHHHFWB<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class ZUSBMIAUGOG
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
		private static int TGPRTTMIKRK;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int VBJIUOHZHES;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8820", Offset = "0x2BC7220", VA = "0x182BC8820")]
		public static void YFLRTADXTVQ(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BC84A0", Offset = "0x2BC6EA0", VA = "0x182BC84A0")]
		private static void FGUJHLNHJDJ([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8360", Offset = "0x2BC6D60", VA = "0x182BC8360")]
		private static void FGUJHLNHJDJ(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC86C0", Offset = "0x2BC70C0", VA = "0x182BC86C0")]
		private static void VMPSASQABNO(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class LLHWVGBMEHY<a, b, c> where a : struct, KFITFPEAZWY<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a BJEOXILCYDG;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x699BAD0", Offset = "0x699A4D0", VA = "0x18699BAD0")]
		public static void YFLRTADXTVQ([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface KFITFPEAZWY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> GWRKSQGDBQS(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SJJLUJOAAPQ(a a, b b, Id32<WXKPXITHDLK<WFSWBPUBAOK>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface FCHXAOXANFH<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a KECGMKFBPXL(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FNGNUPUAPOT(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class HBZTXIWYOAD<a, b, c> where a : struct, FCHXAOXANFH<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a BJEOXILCYDG;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x65286D0", Offset = "0x65270D0", VA = "0x1865286D0")]
		public static UnsafeList<b> YFLRTADXTVQ(int a, [In] c values)
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
