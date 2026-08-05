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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x2950700", Offset = "0x294F500", VA = "0x182950700")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
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
		public readonly Id32<XTKEAPQLAYR<HIVQMCLTDUL>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
		public ByteCodeAdjustment(Id32<XTKEAPQLAYR<HIVQMCLTDUL>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class MKPQRANEMED : UGKVOHCIPXN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x28E8680", Offset = "0x28E7480", VA = "0x1828E8680")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2946470", Offset = "0x2945270", VA = "0x182946470", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class ZHUZETGCDGW : UGKVOHCIPXN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<XTKEAPQLAYR<YMMBJBIAQGE>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
			public DeadEnd(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> nextByteCodePtr)
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
		public abstract class UGKVOHCIPXN
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
			public readonly Id32<UGKVOHCIPXN> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
			public Inst(Def def, Id32<UGKVOHCIPXN> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class KRHXIALFAXF : UGKVOHCIPXN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class MUHXCHINRVX : UGKVOHCIPXN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x215AD00", Offset = "0x2159B00", VA = "0x18215AD00", Slot = "3")]
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
		internal IdUnsafeList<MKPQRANEMED, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<ZHUZETGCDGW, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<KRHXIALFAXF, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<MUHXCHINRVX, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2946620", Offset = "0x2945420", VA = "0x182946620")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<MKPQRANEMED, BytesImmediate> bytesImmediates, [In] IdUnsafeList<ZHUZETGCDGW, DeadEnd> deadEnds, [In] IdUnsafeList<KRHXIALFAXF, Variable> variables, [In] IdUnsafeList<MUHXCHINRVX, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29464E0", Offset = "0x29452E0", VA = "0x1829464E0")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class SOJXYFWEAFW
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2950A00", Offset = "0x294F800", VA = "0x182950A00")]
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
		public sealed class CPFUBSLFURM : UGKVOHCIPXN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
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
		public abstract class UGKVOHCIPXN
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
			public readonly Id32<UGKVOHCIPXN> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
			public Inst(Def def, Id32<UGKVOHCIPXN> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<CPFUBSLFURM, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2946910", Offset = "0x2945710", VA = "0x182946910")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<CPFUBSLFURM, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2946880", Offset = "0x2945680", VA = "0x182946880")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class ZVSRWIONZSH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x29511A0", Offset = "0x294FFA0", VA = "0x1829511A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x29469F0", Offset = "0x29457F0", VA = "0x1829469F0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2946950", Offset = "0x2945750", VA = "0x182946950")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class GFOJBOHWLQG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2947BF0", Offset = "0x29469F0", VA = "0x182947BF0")]
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
		public sealed class TBIWPQKRYXG : UGKVOHCIPXN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<MPOZOJLCNOX> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
			public ExternalCall(Id32<MPOZOJLCNOX> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class UGKVOHCIPXN
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
			public readonly Id32<UGKVOHCIPXN> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
			private Inst(Def def, Id32<UGKVOHCIPXN> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x294A440", Offset = "0x2949240", VA = "0x18294A440")]
			public static Inst New(Def def, Id32<UGKVOHCIPXN> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class YGFZWDBMOPM : UGKVOHCIPXN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<MPOZOJLCNOX> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
			public InternalCall(Id32<MPOZOJLCNOX> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class MPOZOJLCNOX
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
			[Cpp2IlInjected.Address(RVA = "0x2946910", Offset = "0x2945710", VA = "0x182946910")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x294A290", Offset = "0x2949090", VA = "0x18294A290")]
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
		internal IdUnsafeList<YGFZWDBMOPM, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<TBIWPQKRYXG, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<MPOZOJLCNOX> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<MPOZOJLCNOX, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2946BF0", Offset = "0x29459F0", VA = "0x182946BF0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<YGFZWDBMOPM, InternalCall> internalCalls, [In] IdUnsafeList<TBIWPQKRYXG, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<MPOZOJLCNOX> IOId)> callsWithIO, [In] IdUnsafeList<MPOZOJLCNOX, IO> io, [In] SOAField<MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> ioModifyingCallLocations, [In] SOAField<MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2946A50", Offset = "0x2945850", VA = "0x182946A50")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class GAYTIPRFHUU
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2947BA0", Offset = "0x29469A0", VA = "0x182947BA0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2947990", Offset = "0x2946790", VA = "0x182947990")]
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
		internal SOAField<ORAOIMYUXDI, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<ORAOIMYUXDI>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2947640", Offset = "0x2946440", VA = "0x182947640")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<ORAOIMYUXDI, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<ORAOIMYUXDI>> generatedOutputsForExpression, [In] SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2946CB0", Offset = "0x2945AB0", VA = "0x182946CB0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class HPDXAGQEGWR
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : BWRNSHZGVIQ<Id32<FunctionCalls.MPOZOJLCNOX>, SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2950AC0", Offset = "0x294F8C0", VA = "0x182950AC0")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2950B40", Offset = "0x294F940", VA = "0x182950B40", Slot = "4")]
			public Id32<FunctionCalls.MPOZOJLCNOX> SBHPZPIIYVS(int a)
			{
				return default(Id32<FunctionCalls.MPOZOJLCNOX>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0")]
			public bool KVTNSPSRJZA(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "5")]
			private bool HZENZFROTAU(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2950AB0", Offset = "0x294F8B0", VA = "0x182950AB0", Slot = "6")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> CYEDDHEOYER(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : OWKIQMGPIFD<Id32<FunctionCalls.MPOZOJLCNOX>, SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x29456A0", Offset = "0x29444A0", VA = "0x1829456A0")]
			public UnsafeList<Id32<FunctionCalls.MPOZOJLCNOX>> BPQILWRQWYF(int a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.MPOZOJLCNOX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2945720", Offset = "0x2944520", VA = "0x182945720")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2945600", Offset = "0x2944400", VA = "0x182945600", Slot = "6")]
			public void ALKWPBKKABR(Id32<FunctionCalls.MPOZOJLCNOX> a, SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> b, Id32<XTKEAPQLAYR<HIVQMCLTDUL>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x29456A0", Offset = "0x29444A0", VA = "0x1829456A0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.MPOZOJLCNOX>> HBVZQVKPKKU(int a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.MPOZOJLCNOX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2945710", Offset = "0x2944510", VA = "0x182945710", Slot = "5")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> IHZCAGHBDAI(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : BWRNSHZGVIQ<Id32<FunctionCalls.MPOZOJLCNOX>, SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2950B90", Offset = "0x294F990", VA = "0x182950B90")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2950C10", Offset = "0x294FA10", VA = "0x182950C10", Slot = "4")]
			public Id32<FunctionCalls.MPOZOJLCNOX> SBHPZPIIYVS(int a)
			{
				return default(Id32<FunctionCalls.MPOZOJLCNOX>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0")]
			public bool KVTNSPSRJZA(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "5")]
			private bool XMSPJEJSGGF(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2950B80", Offset = "0x294F980", VA = "0x182950B80", Slot = "6")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> HOVMSIQHNWI(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : OWKIQMGPIFD<Id32<FunctionCalls.MPOZOJLCNOX>, SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2945840", Offset = "0x2944640", VA = "0x182945840")]
			public UnsafeList<Id32<FunctionCalls.MPOZOJLCNOX>> BPQILWRQWYF(int a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.MPOZOJLCNOX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x29458B0", Offset = "0x29446B0", VA = "0x1829458B0")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x29457A0", Offset = "0x29445A0", VA = "0x1829457A0", Slot = "6")]
			public void ALKWPBKKABR(Id32<FunctionCalls.MPOZOJLCNOX> a, SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> b, Id32<XTKEAPQLAYR<HIVQMCLTDUL>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2945840", Offset = "0x2944640", VA = "0x182945840", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.MPOZOJLCNOX>> KQSHVSVHIIR(int a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.MPOZOJLCNOX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2945930", Offset = "0x2944730", VA = "0x182945930", Slot = "5")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> KUQJVZMWMYT(Id32<FunctionCalls.MPOZOJLCNOX> a, [In] SOAField<FunctionCalls.MPOZOJLCNOX, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : BWRNSHZGVIQ<Id32<UJRAVMRBCHX>, SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2950CC0", Offset = "0x294FAC0", VA = "0x182950CC0")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(Id32<UJRAVMRBCHX> a, [In] SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2950D70", Offset = "0x294FB70", VA = "0x182950D70", Slot = "4")]
			public Id32<UJRAVMRBCHX> SBHPZPIIYVS(int a)
			{
				return default(Id32<UJRAVMRBCHX>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2950C50", Offset = "0x294FA50", VA = "0x182950C50")]
			public bool KVTNSPSRJZA(Id32<UJRAVMRBCHX> a, [In] SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2950C50", Offset = "0x294FA50", VA = "0x182950C50", Slot = "5")]
			private bool BQIXEPTWNPF(Id32<UJRAVMRBCHX> a, [In] SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2950CB0", Offset = "0x294FAB0", VA = "0x182950CB0", Slot = "6")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> FTTVAIMXJXE(Id32<UJRAVMRBCHX> a, [In] SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : OWKIQMGPIFD<Id32<UJRAVMRBCHX>, SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2945A40", Offset = "0x2944840", VA = "0x182945A40")]
			public UnsafeList<Id32<UJRAVMRBCHX>> BPQILWRQWYF(int a, [In] SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> values)
			{
				return default(UnsafeList<Id32<UJRAVMRBCHX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2945AB0", Offset = "0x29448B0", VA = "0x182945AB0")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(Id32<UJRAVMRBCHX> a, [In] SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2945940", Offset = "0x2944740", VA = "0x182945940", Slot = "6")]
			public void ALKWPBKKABR(Id32<UJRAVMRBCHX> a, SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> b, Id32<XTKEAPQLAYR<HIVQMCLTDUL>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2945A40", Offset = "0x2944840", VA = "0x182945A40", Slot = "4")]
			private UnsafeList<Id32<UJRAVMRBCHX>> LDEBAUAWRYD(int a, [In] SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> values)
			{
				return default(UnsafeList<Id32<UJRAVMRBCHX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2945B60", Offset = "0x2944960", VA = "0x182945B60", Slot = "5")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> PUEONKBHPAF(Id32<UJRAVMRBCHX> a, [In] SOAField<UJRAVMRBCHX, Id32<XTKEAPQLAYR<YMMBJBIAQGE>>?> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : BWRNSHZGVIQ<int, UnsafeList<(Id32<LocalVariables.M>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2950F00", Offset = "0x294FD00", VA = "0x182950F00")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB2C810", Offset = "0xB2B610", VA = "0x180B2C810", Slot = "4")]
			public int SBHPZPIIYVS(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0")]
			public bool KVTNSPSRJZA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "5")]
			private bool JAZADILBIJY(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2950EF0", Offset = "0x294FCF0", VA = "0x182950EF0", Slot = "6")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> CGEZUQURPHR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : OWKIQMGPIFD<int, UnsafeList<(Id32<LocalVariables.M>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2946090", Offset = "0x2944E90", VA = "0x182946090")]
			public UnsafeList<int> BPQILWRQWYF(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2946100", Offset = "0x2944F00", VA = "0x182946100")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2945F90", Offset = "0x2944D90", VA = "0x182945F90", Slot = "6")]
			public void ALKWPBKKABR(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> values, Id32<XTKEAPQLAYR<HIVQMCLTDUL>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2946090", Offset = "0x2944E90", VA = "0x182946090", Slot = "4")]
			private UnsafeList<int> PDCNHHHVXAY(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2946190", Offset = "0x2944F90", VA = "0x182946190", Slot = "5")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> OJEMXAOUQGM(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<XTKEAPQLAYR<BPTUUJZBQIH<HIVQMCLTDUL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : BWRNSHZGVIQ<int, UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2950E60", Offset = "0x294FC60", VA = "0x182950E60")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB2C810", Offset = "0xB2B610", VA = "0x180B2C810", Slot = "4")]
			public int SBHPZPIIYVS(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0")]
			public bool KVTNSPSRJZA(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "5")]
			private bool OWIWYEZYQWN(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2950E50", Offset = "0x294FC50", VA = "0x182950E50", Slot = "6")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> ATJQCTWVSSM(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : OWKIQMGPIFD<int, UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2945E80", Offset = "0x2944C80", VA = "0x182945E80")]
			public UnsafeList<int> BPQILWRQWYF(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2945F00", Offset = "0x2944D00", VA = "0x182945F00")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2945D80", Offset = "0x2944B80", VA = "0x182945D80", Slot = "6")]
			public void ALKWPBKKABR(int a, UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values, Id32<XTKEAPQLAYR<HIVQMCLTDUL>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2945E80", Offset = "0x2944C80", VA = "0x182945E80", Slot = "4")]
			private UnsafeList<int> YAGERVMIQVZ(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2945EF0", Offset = "0x2944CF0", VA = "0x182945EF0", Slot = "5")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> FWRPYUGTAKZ(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : BWRNSHZGVIQ<int, UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2950DC0", Offset = "0x294FBC0", VA = "0x182950DC0")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB2C810", Offset = "0xB2B610", VA = "0x180B2C810", Slot = "4")]
			public int SBHPZPIIYVS(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0")]
			public bool KVTNSPSRJZA(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "5")]
			private bool OWIWYEZYQWN(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2950DB0", Offset = "0x294FBB0", VA = "0x182950DB0", Slot = "6")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> ATJQCTWVSSM(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : OWKIQMGPIFD<int, UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2945C70", Offset = "0x2944A70", VA = "0x182945C70")]
			public UnsafeList<int> BPQILWRQWYF(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2945CF0", Offset = "0x2944AF0", VA = "0x182945CF0")]
			public Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2945B70", Offset = "0x2944970", VA = "0x182945B70", Slot = "6")]
			public void ALKWPBKKABR(int a, UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values, Id32<XTKEAPQLAYR<HIVQMCLTDUL>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2945C70", Offset = "0x2944A70", VA = "0x182945C70", Slot = "4")]
			private UnsafeList<int> YAGERVMIQVZ(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2945CE0", Offset = "0x2944AE0", VA = "0x182945CE0", Slot = "5")]
			private Id32<XTKEAPQLAYR<HIVQMCLTDUL>> FWRPYUGTAKZ(int a, [In] UnsafeList<(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> Target, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1A97950", Offset = "0x1A96750", VA = "0x181A97950")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2947C90", Offset = "0x2946A90", VA = "0x182947C90")]
			public void RBUETEQJKHW([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<UJRAVMRBCHX> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2947C70", Offset = "0x2946A70", VA = "0x182947C70")]
			public GenerateDataBackFromInputIndexResult(Id32<UJRAVMRBCHX> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2947C40", Offset = "0x2946A40", VA = "0x182947C40")]
			public void RBUETEQJKHW([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2947C50", Offset = "0x2946A50", VA = "0x182947C50")]
			public void RBUETEQJKHW([Out] Id32<DataBackResults.M> a, [Out] Id32<UJRAVMRBCHX> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<UJRAVMRBCHX> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
			public GenerateDataBackFromInputIndicesResult(Id32<UJRAVMRBCHX> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2947C80", Offset = "0x2946A80", VA = "0x182947C80")]
			public void RBUETEQJKHW([Out] Id32<DataBackResults.M> a, [Out] Id32<UJRAVMRBCHX> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x29482F0", Offset = "0x29470F0", VA = "0x1829482F0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2949AF0", Offset = "0x29488F0", VA = "0x182949AF0")]
		public static void RGNNQMAHNFP(this FunctionCompileState a, Id32<ORAOIMYUXDI> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x29487B0", Offset = "0x29475B0", VA = "0x1829487B0")]
		public static void FVCNGLWVRJJ(this FunctionCompileState a, Id32<ORAOIMYUXDI> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2949C90", Offset = "0x2948A90", VA = "0x182949C90")]
		public static Id32<DataBackResults.M>? TXQDPYSHVZK([In] this FunctionCompileState self, Id32<ORAOIMYUXDI> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x29486D0", Offset = "0x29474D0", VA = "0x1829486D0")]
		public static Id32<XTKEAPQLAYR<YMMBJBIAQGE>> FBPBAMBGZIE([In] this FunctionCompileState self)
		{
			return default(Id32<XTKEAPQLAYR<YMMBJBIAQGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2949210", Offset = "0x2948010", VA = "0x182949210")]
		private static void OIHTEVXQNJF(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x294A1A0", Offset = "0x2948FA0", VA = "0x18294A1A0")]
		private static Id32<XTKEAPQLAYR<YMMBJBIAQGE>>? YQDMGYCGXJS([In] this FunctionCompileState self, Id32<UJRAVMRBCHX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x29496F0", Offset = "0x29484F0", VA = "0x1829496F0")]
		public static void PSVCOFZCGEA(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2948E70", Offset = "0x2947C70", VA = "0x182948E70")]
		public static DataBackResults.Def KWADJYKNUDA([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2948D00", Offset = "0x2947B00", VA = "0x182948D00")]
		public static ReadOnlyArray<byte> JLUJCBGUSMC([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2949D60", Offset = "0x2948B60", VA = "0x182949D60")]
		public static Id32<LocalVariables.M> UWKZAOADOJM([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2948130", Offset = "0x2946F30", VA = "0x182948130")]
		public static Union32 DHPGKYWSHWA([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3794020", Offset = "0x3792E20", VA = "0x183794020")]
		private static Id32<DataBackResults.M> KTDAEUZSSBH<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.UGKVOHCIPXN
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2949E40", Offset = "0x2948C40", VA = "0x182949E40")]
		public static Id32<DataBackResults.M> UYZAYXVOEOB(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2948DE0", Offset = "0x2947BE0", VA = "0x182948DE0")]
		public static Id32<DataBackResults.M> KNNMSAMYQRG(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2949430", Offset = "0x2948230", VA = "0x182949430")]
		public static Id32<DataBackResults.M> OVOLIJQHXXV(this FunctionCompileState a, Id32<XTKEAPQLAYR<YMMBJBIAQGE>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2947D50", Offset = "0x2946B50", VA = "0x182947D50")]
		public static Id32<DataBackResults.M> BPEPJNHJZRN(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2949C10", Offset = "0x2948A10", VA = "0x182949C10")]
		public static Id32<DataBackResults.M> TUUDYWTPWJW(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37939F0", Offset = "0x37927F0", VA = "0x1837939F0")]
		private static Id32<ExecForwardResults.M> FQDOPHFDCTU<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.UGKVOHCIPXN
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x29493F0", Offset = "0x29481F0", VA = "0x1829493F0")]
		public static Id32<ExecForwardResults.M> OPZIMUKDNRM(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2948C60", Offset = "0x2947A60", VA = "0x182948C60")]
		public static Id32<ExecForwardResults.M> ISKILZNRDNZ(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2948730", Offset = "0x2947530", VA = "0x182948730")]
		public static Id32<ExecForwardResults.M> FIRGXQCZIKT(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2948C10", Offset = "0x2947A10", VA = "0x182948C10")]
		public static Id32<ExecForwardResults.M> IDBPSLOCAMQ(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2948EE0", Offset = "0x2947CE0", VA = "0x182948EE0")]
		public static Id32<ExecForwardResults.M> LIPQWKHZRQG(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x294A220", Offset = "0x2949020", VA = "0x18294A220")]
		public static FunctionCalls.Def ZLKFLOQMERB([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x29493B0", Offset = "0x29481B0", VA = "0x1829493B0")]
		public static CopyEnumerable<Id32<FunctionCalls.MPOZOJLCNOX>, Id32Enumerator<FunctionCalls.MPOZOJLCNOX>> OLDCRAEWSZA([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.MPOZOJLCNOX>, Id32Enumerator<FunctionCalls.MPOZOJLCNOX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2948F30", Offset = "0x2947D30", VA = "0x182948F30")]
		public static Id32<FunctionCalls.MPOZOJLCNOX> MNGNNZWMXLL([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.MPOZOJLCNOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x294A130", Offset = "0x2948F30", VA = "0x18294A130")]
		public static FunctionCalls.IO YCNAYEQWYXS([In] this FunctionCompileState self, Id32<FunctionCalls.MPOZOJLCNOX> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2948880", Offset = "0x2947680", VA = "0x182948880")]
		public static FunctionCalls.IO GIMUEIYTQFU(this FunctionCompileState a, Id32<FunctionCalls.MPOZOJLCNOX> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3792560", Offset = "0x3791360", VA = "0x183792560")]
		private static Id32<FunctionCalls.M> CKNUUHHSJSF<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.UGKVOHCIPXN
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x29494B0", Offset = "0x29482B0", VA = "0x1829494B0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.MPOZOJLCNOX>) OYNYUAEHGUI(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.MPOZOJLCNOX>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2947DD0", Offset = "0x2946BD0", VA = "0x182947DD0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.MPOZOJLCNOX>) BTYXDDZQYHI(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.MPOZOJLCNOX>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2948CB0", Offset = "0x2947AB0", VA = "0x182948CB0")]
		public static Id32<FunctionCalls.M> JJPORSJZKSH(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2949B80", Offset = "0x2948980", VA = "0x182949B80")]
		public static void THHYZTDPFUW(this FunctionCompileState a, Id32<FunctionCalls.MPOZOJLCNOX> b, Id32<XTKEAPQLAYR<YMMBJBIAQGE>> c, Id32<XTKEAPQLAYR<WEGIHCAWWIL>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x37925F0", Offset = "0x37913F0", VA = "0x1837925F0")]
		public static GenerateDataBackResult DZOQDRVTAKM<d, e>(this FunctionCompileState a, d b, e c, Id32<VTHPCPYYILP> d, Id32<UJRAVMRBCHX> e) where d : ZSLKVIHDTZQ<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x37942B0", Offset = "0x37930B0", VA = "0x1837942B0")]
		public static GenerateDataBackFromInputIndexResult WCMIJSZFUQQ<f, g>(this FunctionCompileState a, f b, g c, Id32<VTHPCPYYILP> d, Id32<DERVXWIACXB> e, int f) where f : ZSLKVIHDTZQ<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3793AC0", Offset = "0x37928C0", VA = "0x183793AC0")]
		public static Id32<DataBackResults.M>? GTLHMQXEBNT<h, i>(this FunctionCompileState a, h b, i c, Id32<VTHPCPYYILP> d, Id32<DERVXWIACXB> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : ZSLKVIHDTZQ<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3791D40", Offset = "0x3790B40", VA = "0x183791D40")]
		public static Id32<ExecForwardResults.M> BZBUXNOEWYP<j, k>(this FunctionCompileState a, j b, k c, Id32<VTHPCPYYILP> d, Id32<ORAOIMYUXDI> e) where j : ZSLKVIHDTZQ<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x29499E0", Offset = "0x29487E0", VA = "0x1829499E0")]
		public static LocalVariables.ArgumentInst QPWOPZNVDBB([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2948AB0", Offset = "0x29478B0", VA = "0x182948AB0")]
		public static LocalVariables.CalleeReturnValueInst HIQHTKFVGXP([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x29489A0", Offset = "0x29477A0", VA = "0x1829489A0")]
		public static LocalVariables.CallerReturnValueInst HEIPFGFFPWK([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2949F80", Offset = "0x2948D80", VA = "0x182949F80")]
		public static Id32<LocalVariables.M> XSRCDWGXCJM(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2949100", Offset = "0x2947F00", VA = "0x182949100")]
		public static LocalVariables.ParameterInst OGOAXYUACEX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2948BC0", Offset = "0x29479C0", VA = "0x182948BC0")]
		public static LocalVariables.Def ICJJFHRPPEH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2949D10", Offset = "0x2948B10", VA = "0x182949D10")]
		public static int? UUIXFGOHZQZ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3794700", Offset = "0x3793500", VA = "0x183794700")]
		private static Id32<LocalVariables.M> WHYSTNXINYF<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.UGKVOHCIPXN
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2947CA0", Offset = "0x2946AA0", VA = "0x182947CA0")]
		public static Id32<LocalVariables.M> ANGWDJJQQDH(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2949F20", Offset = "0x2948D20", VA = "0x182949F20")]
		public static Id32<LocalVariables.M> WVDQLIDAXRA(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2949860", Offset = "0x2948660", VA = "0x182949860")]
		public static Id32<LocalVariables.M> QGQDMRLERLI(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2949660", Offset = "0x2948460", VA = "0x182949660")]
		public static Id32<LocalVariables.M> PJDEPOMNIEA(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2949EC0", Offset = "0x2948CC0", VA = "0x182949EC0")]
		public static Id32<LocalVariables.M> VRXJKEAZOME(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2948010", Offset = "0x2946E10", VA = "0x182948010")]
		public static void CETJWXQRLKB(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x29485C0", Offset = "0x29473C0", VA = "0x1829485C0")]
		public static void EPNHSJPZOKT(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x29488F0", Offset = "0x29476F0", VA = "0x1829488F0")]
		public static void GSAIOTIUMTJ(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2947F80", Offset = "0x2946D80", VA = "0x182947F80")]
		public static void CDTSVSKIPRS(this FunctionCompileState a, Id32<XTKEAPQLAYR<YMMBJBIAQGE>> b, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2948210", Offset = "0x2947010", VA = "0x182948210")]
		public static void DNKEEQCALMA(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<XTKEAPQLAYR<QWYEGVFWMNH>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x37941D0", Offset = "0x3792FD0", VA = "0x1837941D0")]
		public static void TRHMLHLUTSF<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<XTKEAPQLAYR<BPTUUJZBQIH<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface ZSLKVIHDTZQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<TMYLYEFQLQF> ZDZWEXJUNQV(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<TMYLYEFQLQF> GNPQTCSRTYM(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<TMYLYEFQLQF> CZQIIBSFGDH(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<TMYLYEFQLQF> HHVUQBQQRYO(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> VAUDWWQUNIU(a a, FunctionCompileState b, Id32<VTHPCPYYILP> c, Id32<UJRAVMRBCHX> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> IXFIZMCLZDS(a a, FunctionCompileState b, Id32<VTHPCPYYILP> c, Id32<ORAOIMYUXDI> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int MYMSGONBNYW(a a, Id32<VTHPCPYYILP> b, Id32<UJRAVMRBCHX> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<ORAOIMYUXDI> XNHWIHEAXUB(a a, Id32<VTHPCPYYILP> b, Id32<UJRAVMRBCHX> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind BEWYRVITDHS(a a, Id32<VTHPCPYYILP> b, Id32<UJRAVMRBCHX> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool TCYZCYLEYJP(a a, Id32<VTHPCPYYILP> b, Id32<UJRAVMRBCHX> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int MBBTOJDVMGS(a a, Id32<VTHPCPYYILP> b, Id32<UJRAVMRBCHX> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> ZKCOQYNPHPG(a a, Id32<VTHPCPYYILP> b, Id32<UJRAVMRBCHX> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<TMYLYEFQLQF>) LBCJLVZCCDY(a a, Id32<VTHPCPYYILP> b, Id32<UJRAVMRBCHX> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int QRNTJODHDIU(a a, Id32<VTHPCPYYILP> b, Id32<ORAOIMYUXDI> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<UJRAVMRBCHX> BVIZAPUSIVD(a a, Id32<VTHPCPYYILP> b, Id32<ORAOIMYUXDI> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<UJRAVMRBCHX> WLGJVSBAWOA(a a, Id32<VTHPCPYYILP> b, Id32<DERVXWIACXB> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int ALTPFDEGJBC(a a, Id32<VTHPCPYYILP> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? TQQTTDDZYFQ(a a, Id32<VTHPCPYYILP> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int TMVZHMXTIMC(a a, Id32<VTHPCPYYILP> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? KGAEOCNMSYE(a a, Id32<VTHPCPYYILP> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class KKFLQRSUJFZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x383F9A0", Offset = "0x383E7A0", VA = "0x18383F9A0")]
		public static Id32<LocalVariables.M?> QQLVPACVPUS<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x38404B0", Offset = "0x383F2B0", VA = "0x1838404B0")]
		public static Id32<LocalVariables.M?> TUDZJMNGGFV<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x383F6C0", Offset = "0x383E4C0", VA = "0x18383F6C0")]
		public static Id32<LocalVariables.M?> PHFTNVPYCSG<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x294FD20", Offset = "0x294EB20", VA = "0x18294FD20")]
		public static Id32<LocalVariables.M> XRVLNGREYTE(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x294EEE0", Offset = "0x294DCE0", VA = "0x18294EEE0")]
		public static Id32<LocalVariables.M> QHNHQGJUNKF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x294F2A0", Offset = "0x294E0A0", VA = "0x18294F2A0")]
		public static Id32<LocalVariables.M> RQVYVUDIKSU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x294F1A0", Offset = "0x294DFA0", VA = "0x18294F1A0")]
		public static Id32<LocalVariables.M> RGGJTQBJPQM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x294EC20", Offset = "0x294DA20", VA = "0x18294EC20")]
		public static Id32<LocalVariables.M> PYSVVOUSTDF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x29500F0", Offset = "0x294EEF0", VA = "0x1829500F0")]
		public static Id32<LocalVariables.M> YFTZNGHQNJU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x294D300", Offset = "0x294C100", VA = "0x18294D300")]
		public static Id32<LocalVariables.M> KXSXGLZVMCC(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x294B860", Offset = "0x294A660", VA = "0x18294B860")]
		public static Id32<LocalVariables.M> FHIYHJNVBHX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x294E490", Offset = "0x294D290", VA = "0x18294E490")]
		public static Id32<LocalVariables.M> NVUESSOXTRC(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x294C8B0", Offset = "0x294B6B0", VA = "0x18294C8B0")]
		public static Id32<LocalVariables.M> IHYLPMGMODX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x294AF60", Offset = "0x2949D60", VA = "0x18294AF60")]
		public static Id32<LocalVariables.M> ASTQJBWPDOS(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x294F640", Offset = "0x294E440", VA = "0x18294F640")]
		public static Id32<LocalVariables.M> SLSMRKJRJID(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x294FA80", Offset = "0x294E880", VA = "0x18294FA80")]
		public static Id32<LocalVariables.M> VRRYZSAYQZG(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x294E1C0", Offset = "0x294CFC0", VA = "0x18294E1C0")]
		public static Id32<LocalVariables.M> MYCUHKIMRHF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x294BEB0", Offset = "0x294ACB0", VA = "0x18294BEB0")]
		public static Id32<LocalVariables.M> FOCUDBXLAMS(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2950350", Offset = "0x294F150", VA = "0x182950350")]
		public static Id32<LocalVariables.M> ZOTNLLJFJVQ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x294EE60", Offset = "0x294DC60", VA = "0x18294EE60")]
		public static Id32<LocalVariables.M> QCMMLTOIONP(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x294EA60", Offset = "0x294D860", VA = "0x18294EA60")]
		public static Id32<LocalVariables.M> PJXXRRSCJIM(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x294FB80", Offset = "0x294E980", VA = "0x18294FB80")]
		public static Id32<LocalVariables.M> VTGQXVKICWL(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x294F940", Offset = "0x294E740", VA = "0x18294F940")]
		public static Id32<LocalVariables.M> TFYPPXNBFEM(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2950250", Offset = "0x294F050", VA = "0x182950250")]
		public static Id32<LocalVariables.M> YUKAQDFJGDL(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x29502D0", Offset = "0x294F0D0", VA = "0x1829502D0")]
		public static Id32<LocalVariables.M> YWFLCTRAETJ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x294C520", Offset = "0x294B320", VA = "0x18294C520")]
		public static Id32<LocalVariables.M> HPRDMJUZQRW(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x294AEE0", Offset = "0x2949CE0", VA = "0x18294AEE0")]
		public static Id32<LocalVariables.M> ANBUTAZUTND(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x294CC30", Offset = "0x294BA30", VA = "0x18294CC30")]
		public static Id32<LocalVariables.M> IQSMYQXDHSW(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x294C4A0", Offset = "0x294B2A0", VA = "0x18294C4A0")]
		public static Id32<LocalVariables.M> GWIPDWAVTOZ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x294C420", Offset = "0x294B220", VA = "0x18294C420")]
		public static Id32<LocalVariables.M> GTADUMMDTBS(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x294D100", Offset = "0x294BF00", VA = "0x18294D100")]
		public static Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> KWPVTZEOFPK(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x294E2F0", Offset = "0x294D0F0", VA = "0x18294E2F0")]
		public static Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> NDSTXNNDKKY(this FunctionCompileState a, int b)
		{
			return default(Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x294E120", Offset = "0x294CF20", VA = "0x18294E120")]
		public static Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> MRRTQSBCNQT(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x294CDF0", Offset = "0x294BBF0", VA = "0x18294CDF0")]
		public static Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> KFFFCWBWGER(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x294F8C0", Offset = "0x294E6C0", VA = "0x18294F8C0")]
		public static Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> TFAWPCXKZFX(this FunctionCompileState a, int b)
		{
			return default(Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x294F100", Offset = "0x294DF00", VA = "0x18294F100")]
		public static Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> QLDHBJXCATY(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x294B200", Offset = "0x294A000", VA = "0x18294B200")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.MPOZOJLCNOX>) BWPGJYFZBUP(this FunctionCompileState a, Id32<CGBEZEBPUAA> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.MPOZOJLCNOX>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x294D940", Offset = "0x294C740", VA = "0x18294D940")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.MPOZOJLCNOX>) LKBHGJQZJUJ(this FunctionCompileState a, Id32<PIICLSZAHGS> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.MPOZOJLCNOX>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3840D30", Offset = "0x383FB30", VA = "0x183840D30")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<TMYLYEFQLQF>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<TMarker>>, Id32<FunctionCalls.M>) XJIMNIJAOGK<TMarker>(this FunctionCompileState a, Id32<TMYLYEFQLQF> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<TMYLYEFQLQF>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x294F9C0", Offset = "0x294E7C0", VA = "0x18294F9C0")]
		public static Id32<LocalVariables.M> UQGGWSVYLLO(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x294C330", Offset = "0x294B130", VA = "0x18294C330")]
		public static Id32<LocalVariables.M> GKOUTMEEUAX(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x294C7C0", Offset = "0x294B5C0", VA = "0x18294C7C0")]
		public static Id32<LocalVariables.M> IDPASAAZTCU(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x294BD90", Offset = "0x294AB90", VA = "0x18294BD90")]
		public static Id32<LocalVariables.M> FLMJYVRFEOL(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x294D520", Offset = "0x294C320", VA = "0x18294D520")]
		public static Id32<LocalVariables.M> KZMYADFKAEA(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x294FC00", Offset = "0x294EA00", VA = "0x18294FC00")]
		public static Id32<LocalVariables.M> XRVHEJPHAWT(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x294CAF0", Offset = "0x294B8F0", VA = "0x18294CAF0")]
		public static Id32<LocalVariables.M> IOZLGWBBWOC(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x294DDE0", Offset = "0x294CBE0", VA = "0x18294DDE0")]
		public static Id32<LocalVariables.M> LNWYTREDZZY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x294C5A0", Offset = "0x294B3A0", VA = "0x18294C5A0")]
		public static Id32<LocalVariables.M> HQXZYGAXZGR(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x294EAE0", Offset = "0x294D8E0", VA = "0x18294EAE0")]
		public static Id32<LocalVariables.M> PWXAPYSLKWE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2950070", Offset = "0x294EE70", VA = "0x182950070")]
		public static Id32<LocalVariables.M> XXCPFXTABML(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x294B180", Offset = "0x2949F80", VA = "0x18294B180")]
		public static Id32<LocalVariables.M> BTRXMQXTCIY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x294B7E0", Offset = "0x294A5E0", VA = "0x18294B7E0")]
		public static Id32<LocalVariables.M> DSJJHHIGPTX(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x294D720", Offset = "0x294C520", VA = "0x18294D720")]
		public static Id32<LocalVariables.M> LCNXWMNTBYL(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x294FE20", Offset = "0x294EC20", VA = "0x18294FE20")]
		public static Id32<LocalVariables.M> XUHEENGBTPO(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x294DEE0", Offset = "0x294CCE0", VA = "0x18294DEE0")]
		public static Id32<LocalVariables.M> LQSRVHRISGN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x294B080", Offset = "0x2949E80", VA = "0x18294B080")]
		public static Id32<LocalVariables.M> BRCALACSMJM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x294D820", Offset = "0x294C620", VA = "0x18294D820")]
		public static Id32<LocalVariables.M> LHMMJFZVSKN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x294E820", Offset = "0x294D620", VA = "0x18294E820")]
		public static Id32<LocalVariables.M> ODANRGRRHAE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2950230", Offset = "0x294F030", VA = "0x182950230")]
		public static Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>> YJXJQGXORCQ(this FunctionCompileState a)
		{
			return default(Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x294E960", Offset = "0x294D760", VA = "0x18294E960")]
		public static Id32<LocalVariables.M> OUGJSYWDSYB(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x294ED40", Offset = "0x294DB40", VA = "0x18294ED40")]
		public static Id32<LocalVariables.M> PZQEWRZJXOW(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x294B6A0", Offset = "0x294A4A0", VA = "0x18294B6A0")]
		public static Id32<LocalVariables.M> DNILHRRDINF(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x294E020", Offset = "0x294CE20", VA = "0x18294E020")]
		public static Id32<LocalVariables.M> LZXWRPZYFET(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x294D400", Offset = "0x294C200", VA = "0x18294D400")]
		public static Id32<LocalVariables.M> KYLEYERNOBG(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x294C9B0", Offset = "0x294B7B0", VA = "0x18294C9B0")]
		public static Id32<LocalVariables.M> IMNXORQWFPP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x294F000", Offset = "0x294DE00", VA = "0x18294F000")]
		public static Id32<LocalVariables.M> QLDGCBXUXNW(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x294CFF0", Offset = "0x294BDF0", VA = "0x18294CFF0")]
		public static Id32<LocalVariables.M> KRQJGCVJFAX(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x294C320", Offset = "0x294B120", VA = "0x18294C320")]
		public static void GFPHBFALDIC(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x294E5D0", Offset = "0x294D3D0", VA = "0x18294E5D0")]
		public static Id32<LocalVariables.M> NZZAUAPMXCV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x294FF50", Offset = "0x294ED50", VA = "0x18294FF50")]
		public static Id32<LocalVariables.M> XWJKELUTICO(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x294F500", Offset = "0x294E300", VA = "0x18294F500")]
		public static Id32<LocalVariables.M> RZHTRGHRBAH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x294C6C0", Offset = "0x294B4C0", VA = "0x18294C6C0")]
		public static Id32<LocalVariables.M> HRGVVIUBPEX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x294E370", Offset = "0x294D170", VA = "0x18294E370")]
		public static Id32<LocalVariables.M> NKTSRHWNHRW(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x294F780", Offset = "0x294E580", VA = "0x18294F780")]
		public static Id32<LocalVariables.M> SMEMCXPEYQN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x294B980", Offset = "0x294A780", VA = "0x18294B980")]
		public static Id32<LocalVariables.M> FIZHIPBFKFD(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x294D620", Offset = "0x294C420", VA = "0x18294D620")]
		public static Id32<LocalVariables.M> LBZNNVKCEXM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x294F3E0", Offset = "0x294E1E0", VA = "0x18294F3E0")]
		public static Id32<LocalVariables.M> RTZSSOQUZVX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x294CCB0", Offset = "0x294BAB0", VA = "0x18294CCB0")]
		public static Id32<LocalVariables.M> JOMGMDBYMKQ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x383FB90", Offset = "0x383E990", VA = "0x18383FB90")]
		public static void SXVCMPAWPQR<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CGBEZEBPUAA> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, ZSLKVIHDTZQ<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x383D5A0", Offset = "0x383C3A0", VA = "0x18383D5A0")]
		public static void DYBWXQQLUYP<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<PIICLSZAHGS> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, ZSLKVIHDTZQ<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x383DD30", Offset = "0x383CB30", VA = "0x18383DD30")]
		public static Id32<LocalVariables.M> GUHBCXCGMIB<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, ZSLKVIHDTZQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x38406E0", Offset = "0x383F4E0", VA = "0x1838406E0")]
		public static Id32<LocalVariables.M> VZWAVLRLFTM<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, ZSLKVIHDTZQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x383F270", Offset = "0x383E070", VA = "0x18383F270")]
		public static Id32<DataBackResults.M> KMVLKMHLCYD<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, ZSLKVIHDTZQ<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x383EF70", Offset = "0x383DD70", VA = "0x18383EF70")]
		public static Id32<ExecForwardResults.M> JBTWQUEHZIE<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, ZSLKVIHDTZQ<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x294E6D0", Offset = "0x294D4D0", VA = "0x18294E6D0")]
		public static Id32<DataBackResults.M> OCSJWJLBVQI(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x294BFF0", Offset = "0x294ADF0", VA = "0x18294BFF0")]
		public static Id32<DataBackResults.M> FWJYXFCEEWO(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x383E040", Offset = "0x383CE40", VA = "0x18383E040")]
		public static Id32<DataBackResults.M> INSPZRTPWCV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CGBEZEBPUAA> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, ZSLKVIHDTZQ<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x383E220", Offset = "0x383D020", VA = "0x18383E220")]
		private static Id32<DataBackResults.M> INSPZRTPWCV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CGBEZEBPUAA> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, ZSLKVIHDTZQ<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x383D150", Offset = "0x383BF50", VA = "0x18383D150")]
		public static Id32<LocalVariables.M> DBNMXRXISOV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, ZSLKVIHDTZQ<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x383EC10", Offset = "0x383DA10", VA = "0x18383EC10")]
		public static void IRYDJXIKUGY<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, ZSLKVIHDTZQ<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<XTKEAPQLAYR<YMMBJBIAQGE>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<XTKEAPQLAYR<YMMBJBIAQGE>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
		public LiveInterval(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> firstUse, Id32<XTKEAPQLAYR<YMMBJBIAQGE>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x29503D0", Offset = "0x294F1D0", VA = "0x1829503D0")]
		public static LiveInterval New(Id32<XTKEAPQLAYR<YMMBJBIAQGE>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class QLOTQEKSUSI : UGKVOHCIPXN
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
			[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class RXQXEDRWGGE : UGKVOHCIPXN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class LQBDOZWOUXN : UGKVOHCIPXN
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
			[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
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
		public abstract class UGKVOHCIPXN
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
			public Id32<UGKVOHCIPXN> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x294A450", Offset = "0x2949250", VA = "0x18294A450")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<UGKVOHCIPXN> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class EJURMXHDUWK : UGKVOHCIPXN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<QLOTQEKSUSI, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<LQBDOZWOUXN, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<EJURMXHDUWK, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<RXQXEDRWGGE, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x29505D0", Offset = "0x294F3D0", VA = "0x1829505D0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<QLOTQEKSUSI, ArgumentInst> argumentVariables, [In] SOAId32Field<LQBDOZWOUXN, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<EJURMXHDUWK, ParameterInst> parameterVariables, [In] SOAId32Field<RXQXEDRWGGE, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x29503E0", Offset = "0x294F1E0", VA = "0x1829503E0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class UXPNTFDTFAT
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2950F90", Offset = "0x294FD90", VA = "0x182950F90")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class VFCLDLCPVKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2951040", Offset = "0x294FE40", VA = "0x182951040")]
		public static void GUADFWAVHIJ(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.MPOZOJLCNOX, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2946430", Offset = "0x2945230", VA = "0x182946430")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.MPOZOJLCNOX, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x29463C0", Offset = "0x29451C0", VA = "0x1829463C0")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x29461A0", Offset = "0x2944FA0", VA = "0x1829461A0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x33B97F0", Offset = "0x33B85F0", VA = "0x1833B97F0")]
		public static void GUADFWAVHIJ<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<VTHPCPYYILP> graphId) where TDeps : notnull, ZSLKVIHDTZQ<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class EQMATMZNPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x29466B0", Offset = "0x29454B0", VA = "0x1829466B0")]
		public static void GUADFWAVHIJ(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface GRSUSZOKBSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void GKQMBGGVGBW(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : GRSUSZOKBSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x29508C0", Offset = "0x294F6C0", VA = "0x1829508C0", Slot = "4")]
			public void GKQMBGGVGBW(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : GRSUSZOKBSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2950950", Offset = "0x294F750", VA = "0x182950950", Slot = "4")]
			public void GKQMBGGVGBW(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : GRSUSZOKBSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2950780", Offset = "0x294F580", VA = "0x182950780", Slot = "4")]
			public void GKQMBGGVGBW(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : GRSUSZOKBSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2950810", Offset = "0x294F610", VA = "0x182950810", Slot = "4")]
			public void GKQMBGGVGBW(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class RYCHIRDVSHR<c> where c : struct, GRSUSZOKBSX
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c PDDKCLIEEXJ;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x394C980", Offset = "0x394B780", VA = "0x18394C980")]
			public static int GUADFWAVHIJ<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : ZSLKVIHDTZQ<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<FunctionCalls.MPOZOJLCNOX>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x294A400", Offset = "0x2949200", VA = "0x18294A400")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<FunctionCalls.MPOZOJLCNOX>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x294A350", Offset = "0x2949150", VA = "0x18294A350")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x294A310", Offset = "0x2949110", VA = "0x18294A310")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x37FAA00", Offset = "0x37F9800", VA = "0x1837FAA00")]
		public static void GUADFWAVHIJ<b, a>(FunctionCompileState a, b b, a c) where b : ZSLKVIHDTZQ<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class JSPDCVUZVTD
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
		private static int PYIJKLCJZGN;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int KIDDMMFQDOH;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x294A5D0", Offset = "0x29493D0", VA = "0x18294A5D0")]
		public static void GUADFWAVHIJ(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x294AC70", Offset = "0x2949A70", VA = "0x18294AC70")]
		private static void ORBFUQXUWBS([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x294AB30", Offset = "0x2949930", VA = "0x18294AB30")]
		private static void ORBFUQXUWBS(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x294A470", Offset = "0x2949270", VA = "0x18294A470")]
		private static void DVKTMNRXMBZ(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class BICKSIGIAXT<a, b, c> where a : struct, OWKIQMGPIFD<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a PDDKCLIEEXJ;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7143D30", Offset = "0x7142B30", VA = "0x187143D30")]
		public static void GUADFWAVHIJ([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface OWKIQMGPIFD<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> BPQILWRQWYF(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ALKWPBKKABR(a a, b b, Id32<XTKEAPQLAYR<HIVQMCLTDUL>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface BWRNSHZGVIQ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a SBHPZPIIYVS(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KVTNSPSRJZA(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<XTKEAPQLAYR<HIVQMCLTDUL>> INLLDCAYDIT(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class QMRDKWKAJKU<a, b, c> where a : struct, BWRNSHZGVIQ<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a PDDKCLIEEXJ;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CA00", Offset = "0x5D2B800", VA = "0x185D2CA00")]
		public static UnsafeList<b> GUADFWAVHIJ(int a, [In] c values)
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
