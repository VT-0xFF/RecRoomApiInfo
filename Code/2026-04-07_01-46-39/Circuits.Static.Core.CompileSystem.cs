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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B91290", Offset = "0x2B90290", VA = "0x182B91290")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		public readonly Id32<IUSFABQMYST<BJYQQFZJRSF>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		public ByteCodeAdjustment(Id32<IUSFABQMYST<BJYQQFZJRSF>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class CKZFXXOHBCV : PRISDEAPYQF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2B29AF0", Offset = "0x2B28AF0", VA = "0x182B29AF0")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B8A320", Offset = "0x2B89320", VA = "0x182B8A320", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class JWHMJGQOVPW : PRISDEAPYQF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<IUSFABQMYST<KSOYRRRMEVU>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
			public DeadEnd(Id32<IUSFABQMYST<KSOYRRRMEVU>> nextByteCodePtr)
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
		public abstract class PRISDEAPYQF
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
			public readonly Id32<PRISDEAPYQF> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
			public Inst(Def def, Id32<PRISDEAPYQF> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class DYUSHCPWRPX : PRISDEAPYQF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class SLYEWFELTZB : PRISDEAPYQF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2394D50", Offset = "0x2393D50", VA = "0x182394D50", Slot = "3")]
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
		internal IdUnsafeList<CKZFXXOHBCV, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<JWHMJGQOVPW, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<DYUSHCPWRPX, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<SLYEWFELTZB, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A4D0", Offset = "0x2B894D0", VA = "0x182B8A4D0")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<CKZFXXOHBCV, BytesImmediate> bytesImmediates, [In] IdUnsafeList<JWHMJGQOVPW, DeadEnd> deadEnds, [In] IdUnsafeList<DYUSHCPWRPX, Variable> variables, [In] IdUnsafeList<SLYEWFELTZB, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A390", Offset = "0x2B89390", VA = "0x182B8A390")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class KESLKVHPPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B8B0", Offset = "0x2B8A8B0", VA = "0x182B8B8B0")]
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
		public sealed class XDXNRSWSHRC : PRISDEAPYQF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
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
		public abstract class PRISDEAPYQF
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
			public readonly Id32<PRISDEAPYQF> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
			public Inst(Def def, Id32<PRISDEAPYQF> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<XDXNRSWSHRC, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A5F0", Offset = "0x2B895F0", VA = "0x182B8A5F0")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<XDXNRSWSHRC, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A560", Offset = "0x2B89560", VA = "0x182B8A560")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class NJTZBBUNRJX
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B91180", Offset = "0x2B90180", VA = "0x182B91180")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8A6D0", Offset = "0x2B896D0", VA = "0x182B8A6D0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A630", Offset = "0x2B89630", VA = "0x182B8A630")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class VEDUZANWLWM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B91BD0", Offset = "0x2B90BD0", VA = "0x182B91BD0")]
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
		public sealed class SIYUMMBORAW : PRISDEAPYQF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<XHRWZULGYUF> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
			public ExternalCall(Id32<XHRWZULGYUF> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class PRISDEAPYQF
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
			public readonly Id32<PRISDEAPYQF> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
			private Inst(Def def, Id32<PRISDEAPYQF> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B880", Offset = "0x2B8A880", VA = "0x182B8B880")]
			public static Inst New(Def def, Id32<PRISDEAPYQF> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class LBAIABMOJHS : PRISDEAPYQF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<XHRWZULGYUF> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
			public InternalCall(Id32<XHRWZULGYUF> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class XHRWZULGYUF
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
			[Cpp2IlInjected.Address(RVA = "0x2B8A5F0", Offset = "0x2B895F0", VA = "0x182B8A5F0")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B6D0", Offset = "0x2B8A6D0", VA = "0x182B8B6D0")]
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
		internal IdUnsafeList<LBAIABMOJHS, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<SIYUMMBORAW, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<XHRWZULGYUF> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<XHRWZULGYUF, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A8D0", Offset = "0x2B898D0", VA = "0x182B8A8D0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<LBAIABMOJHS, InternalCall> internalCalls, [In] IdUnsafeList<SIYUMMBORAW, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<XHRWZULGYUF> IOId)> callsWithIO, [In] IdUnsafeList<XHRWZULGYUF, IO> io, [In] SOAField<XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> ioModifyingCallLocations, [In] SOAField<XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A730", Offset = "0x2B89730", VA = "0x182B8A730")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class WHTFVQJPQQK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B91E30", Offset = "0x2B90E30", VA = "0x182B91E30")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B91C20", Offset = "0x2B90C20", VA = "0x182B91C20")]
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
		internal SOAField<METWAAXGTBK, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<METWAAXGTBK>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B320", Offset = "0x2B8A320", VA = "0x182B8B320")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<METWAAXGTBK, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<METWAAXGTBK>> generatedOutputsForExpression, [In] SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A990", Offset = "0x2B89990", VA = "0x182B8A990")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class XFDIZKFKGDB
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : SZCVJXDQIZY<Id32<FunctionCalls.XHRWZULGYUF>, SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B916F0", Offset = "0x2B906F0", VA = "0x182B916F0")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B91780", Offset = "0x2B90780", VA = "0x182B91780", Slot = "4")]
			public Id32<FunctionCalls.XHRWZULGYUF> TXQYQJEHQSC(int a)
			{
				return default(Id32<FunctionCalls.XHRWZULGYUF>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
			public bool UGYWTIFFAEA(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "5")]
			private bool UGWBRJBVZHI(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B91770", Offset = "0x2B90770", VA = "0x182B91770", Slot = "6")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> SLPYQDDUQFZ(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : FVRUVVDMUIP<Id32<FunctionCalls.XHRWZULGYUF>, SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B88AF0", Offset = "0x2B87AF0", VA = "0x182B88AF0")]
			public UnsafeList<Id32<FunctionCalls.XHRWZULGYUF>> YODQSNHGGGT(int a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.XHRWZULGYUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B88B60", Offset = "0x2B87B60", VA = "0x182B88B60")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B88A50", Offset = "0x2B87A50", VA = "0x182B88A50", Slot = "6")]
			public void FSUTTKHIWTX(Id32<FunctionCalls.XHRWZULGYUF> a, SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> b, Id32<IUSFABQMYST<BJYQQFZJRSF>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B88AF0", Offset = "0x2B87AF0", VA = "0x182B88AF0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.XHRWZULGYUF>> LZGVNHDLURE(int a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.XHRWZULGYUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B88A40", Offset = "0x2B87A40", VA = "0x182B88A40", Slot = "5")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> CKYNWDJMOHE(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<KSOYRRRMEVU>>> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : SZCVJXDQIZY<Id32<FunctionCalls.XHRWZULGYUF>, SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B917C0", Offset = "0x2B907C0", VA = "0x182B917C0")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B91840", Offset = "0x2B90840", VA = "0x182B91840", Slot = "4")]
			public Id32<FunctionCalls.XHRWZULGYUF> TXQYQJEHQSC(int a)
			{
				return default(Id32<FunctionCalls.XHRWZULGYUF>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
			public bool UGYWTIFFAEA(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "5")]
			private bool BDVOQTIBNSL(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B91880", Offset = "0x2B90880", VA = "0x182B91880", Slot = "6")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> UPJLIKOWEUS(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : FVRUVVDMUIP<Id32<FunctionCalls.XHRWZULGYUF>, SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B88D10", Offset = "0x2B87D10", VA = "0x182B88D10")]
			public UnsafeList<Id32<FunctionCalls.XHRWZULGYUF>> YODQSNHGGGT(int a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.XHRWZULGYUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B88C90", Offset = "0x2B87C90", VA = "0x182B88C90")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B88BF0", Offset = "0x2B87BF0", VA = "0x182B88BF0", Slot = "6")]
			public void FSUTTKHIWTX(Id32<FunctionCalls.XHRWZULGYUF> a, SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> b, Id32<IUSFABQMYST<BJYQQFZJRSF>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B88D10", Offset = "0x2B87D10", VA = "0x182B88D10", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.XHRWZULGYUF>> RFOMGLTDBHF(int a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.XHRWZULGYUF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B88BE0", Offset = "0x2B87BE0", VA = "0x182B88BE0", Slot = "5")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> CGFJWDWZJJT(Id32<FunctionCalls.XHRWZULGYUF> a, [In] SOAField<FunctionCalls.XHRWZULGYUF, Id32<IUSFABQMYST<XDHGRWMIQRX>>> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : SZCVJXDQIZY<Id32<EXUEQGJGLLV>, SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2B918A0", Offset = "0x2B908A0", VA = "0x182B918A0")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(Id32<EXUEQGJGLLV> a, [In] SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2B91950", Offset = "0x2B90950", VA = "0x182B91950", Slot = "4")]
			public Id32<EXUEQGJGLLV> TXQYQJEHQSC(int a)
			{
				return default(Id32<EXUEQGJGLLV>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B91990", Offset = "0x2B90990", VA = "0x182B91990")]
			public bool UGYWTIFFAEA(Id32<EXUEQGJGLLV> a, [In] SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B91990", Offset = "0x2B90990", VA = "0x182B91990", Slot = "5")]
			private bool XPTPQHYKWPD(Id32<EXUEQGJGLLV> a, [In] SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B91890", Offset = "0x2B90890", VA = "0x182B91890", Slot = "6")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> LRJYWXOPOJO(Id32<EXUEQGJGLLV> a, [In] SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : FVRUVVDMUIP<Id32<EXUEQGJGLLV>, SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2B88F40", Offset = "0x2B87F40", VA = "0x182B88F40")]
			public UnsafeList<Id32<EXUEQGJGLLV>> YODQSNHGGGT(int a, [In] SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> values)
			{
				return default(UnsafeList<Id32<EXUEQGJGLLV>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B88E90", Offset = "0x2B87E90", VA = "0x182B88E90")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(Id32<EXUEQGJGLLV> a, [In] SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B88D90", Offset = "0x2B87D90", VA = "0x182B88D90", Slot = "6")]
			public void FSUTTKHIWTX(Id32<EXUEQGJGLLV> a, SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> b, Id32<IUSFABQMYST<BJYQQFZJRSF>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B88F40", Offset = "0x2B87F40", VA = "0x182B88F40", Slot = "4")]
			private UnsafeList<Id32<EXUEQGJGLLV>> RZJVMWDXQTP(int a, [In] SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> values)
			{
				return default(UnsafeList<Id32<EXUEQGJGLLV>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B88D80", Offset = "0x2B87D80", VA = "0x182B88D80", Slot = "5")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> ALYZKAKBWLZ(Id32<EXUEQGJGLLV> a, [In] SOAField<EXUEQGJGLLV, Id32<IUSFABQMYST<KSOYRRRMEVU>>?> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : SZCVJXDQIZY<int, UnsafeList<(Id32<LocalVariables.M>, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2B91B30", Offset = "0x2B90B30", VA = "0x182B91B30")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD5A6D0", Offset = "0xD596D0", VA = "0x180D5A6D0", Slot = "4")]
			public int TXQYQJEHQSC(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
			public bool UGYWTIFFAEA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "5")]
			private bool FKYAJUNMAXO(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B91BC0", Offset = "0x2B90BC0", VA = "0x182B91BC0", Slot = "6")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> MTFDVYUCIFT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : FVRUVVDMUIP<int, UnsafeList<(Id32<LocalVariables.M>, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B893D0", Offset = "0x2B883D0", VA = "0x182B893D0")]
			public UnsafeList<int> YODQSNHGGGT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B89550", Offset = "0x2B88550", VA = "0x182B89550")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B89450", Offset = "0x2B88450", VA = "0x182B89450", Slot = "6")]
			public void FSUTTKHIWTX(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> values, Id32<IUSFABQMYST<BJYQQFZJRSF>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B893D0", Offset = "0x2B883D0", VA = "0x182B893D0", Slot = "4")]
			private UnsafeList<int> BDBQLBWECOW(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B89440", Offset = "0x2B88440", VA = "0x182B89440", Slot = "5")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> DLHYUHWZQSC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IUSFABQMYST<LFNQUYKKBAN<BJYQQFZJRSF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : SZCVJXDQIZY<int, UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2B91A90", Offset = "0x2B90A90", VA = "0x182B91A90")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD5A6D0", Offset = "0xD596D0", VA = "0x180D5A6D0", Slot = "4")]
			public int TXQYQJEHQSC(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
			public bool UGYWTIFFAEA(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "5")]
			private bool AYYOAWJKWPF(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B91B20", Offset = "0x2B90B20", VA = "0x182B91B20", Slot = "6")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> TNQWQXIEATU(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : FVRUVVDMUIP<int, UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2B89360", Offset = "0x2B88360", VA = "0x182B89360")]
			public UnsafeList<int> YODQSNHGGGT(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B892D0", Offset = "0x2B882D0", VA = "0x182B892D0")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B891C0", Offset = "0x2B881C0", VA = "0x182B891C0", Slot = "6")]
			public void FSUTTKHIWTX(int a, UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values, Id32<IUSFABQMYST<BJYQQFZJRSF>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B89360", Offset = "0x2B88360", VA = "0x182B89360", Slot = "4")]
			private UnsafeList<int> MDEBYCOWCIJ(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B892C0", Offset = "0x2B882C0", VA = "0x182B892C0", Slot = "5")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> LKKVXIXBSHV(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : SZCVJXDQIZY<int, UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2B919F0", Offset = "0x2B909F0", VA = "0x182B919F0")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD5A6D0", Offset = "0xD596D0", VA = "0x180D5A6D0", Slot = "4")]
			public int TXQYQJEHQSC(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
			public bool UGYWTIFFAEA(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "5")]
			private bool AYYOAWJKWPF(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2B91A80", Offset = "0x2B90A80", VA = "0x182B91A80", Slot = "6")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> TNQWQXIEATU(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : FVRUVVDMUIP<int, UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2B89150", Offset = "0x2B88150", VA = "0x182B89150")]
			public UnsafeList<int> YODQSNHGGGT(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B890C0", Offset = "0x2B880C0", VA = "0x182B890C0")]
			public Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B88FB0", Offset = "0x2B87FB0", VA = "0x182B88FB0", Slot = "6")]
			public void FSUTTKHIWTX(int a, UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values, Id32<IUSFABQMYST<BJYQQFZJRSF>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B89150", Offset = "0x2B88150", VA = "0x182B89150", Slot = "4")]
			private UnsafeList<int> MDEBYCOWCIJ(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B890B0", Offset = "0x2B880B0", VA = "0x182B890B0", Slot = "5")]
			private Id32<IUSFABQMYST<BJYQQFZJRSF>> LKKVXIXBSHV(int a, [In] UnsafeList<(Id32<IUSFABQMYST<KSOYRRRMEVU>> Target, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1CC92A0", Offset = "0x1CC82A0", VA = "0x181CC92A0")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B6C0", Offset = "0x2B8A6C0", VA = "0x182B8B6C0")]
			public void URCAFVCDNTE([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<EXUEQGJGLLV> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B6A0", Offset = "0x2B8A6A0", VA = "0x182B8B6A0")]
			public GenerateDataBackFromInputIndexResult(Id32<EXUEQGJGLLV> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B690", Offset = "0x2B8A690", VA = "0x182B8B690")]
			public void URCAFVCDNTE([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B670", Offset = "0x2B8A670", VA = "0x182B8B670")]
			public void URCAFVCDNTE([Out] Id32<DataBackResults.M> a, [Out] Id32<EXUEQGJGLLV> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<EXUEQGJGLLV> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
			public GenerateDataBackFromInputIndicesResult(Id32<EXUEQGJGLLV> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B6B0", Offset = "0x2B8A6B0", VA = "0x182B8B6B0")]
			public void URCAFVCDNTE([Out] Id32<DataBackResults.M> a, [Out] Id32<EXUEQGJGLLV> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B91F00", Offset = "0x2B90F00", VA = "0x182B91F00")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B92900", Offset = "0x2B91900", VA = "0x182B92900")]
		public static void JIALMEDESFN(this FunctionCompileState a, Id32<METWAAXGTBK> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B93AA0", Offset = "0x2B92AA0", VA = "0x182B93AA0")]
		public static void TEGWGGUNIPH(this FunctionCompileState a, Id32<METWAAXGTBK> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B939E0", Offset = "0x2B929E0", VA = "0x182B939E0")]
		public static Id32<DataBackResults.M>? SYWYGRUOAFM([In] this FunctionCompileState self, Id32<METWAAXGTBK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B936A0", Offset = "0x2B926A0", VA = "0x182B936A0")]
		public static Id32<IUSFABQMYST<KSOYRRRMEVU>> QPFOCGUIJJQ([In] this FunctionCompileState self)
		{
			return default(Id32<IUSFABQMYST<KSOYRRRMEVU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B942D0", Offset = "0x2B932D0", VA = "0x182B942D0")]
		private static void ZYQFLRPDCWR(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B94250", Offset = "0x2B93250", VA = "0x182B94250")]
		private static Id32<IUSFABQMYST<KSOYRRRMEVU>>? ZOWHTOEQOSG([In] this FunctionCompileState self, Id32<EXUEQGJGLLV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B93050", Offset = "0x2B92050", VA = "0x182B93050")]
		public static void OABPBQMURWO(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B93EF0", Offset = "0x2B92EF0", VA = "0x182B93EF0")]
		public static DataBackResults.Def WWULAITAVBC([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B93F60", Offset = "0x2B92F60", VA = "0x182B93F60")]
		public static ReadOnlyArray<byte> YEASBQQZMMA([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B934D0", Offset = "0x2B924D0", VA = "0x182B934D0")]
		public static Id32<LocalVariables.M> QCBGPCPYXWM([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B92F70", Offset = "0x2B91F70", VA = "0x182B92F70")]
		public static Union32 NVEOUZBOKAO([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4105220", Offset = "0x4104220", VA = "0x184105220")]
		private static Id32<DataBackResults.M> NHRHXEEQYOD<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.PRISDEAPYQF
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B93960", Offset = "0x2B92960", VA = "0x182B93960")]
		public static Id32<DataBackResults.M> SUZEYLXNEFZ(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B92A30", Offset = "0x2B91A30", VA = "0x182B92A30")]
		public static Id32<DataBackResults.M> KGZPLKPMOPI(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B932A0", Offset = "0x2B922A0", VA = "0x182B932A0")]
		public static Id32<DataBackResults.M> PJCVSCCUOJT(this FunctionCompileState a, Id32<IUSFABQMYST<KSOYRRRMEVU>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B91E80", Offset = "0x2B90E80", VA = "0x182B91E80")]
		public static Id32<DataBackResults.M> DQDKZMGNEAJ(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B92C50", Offset = "0x2B91C50", VA = "0x182B92C50")]
		public static Id32<DataBackResults.M> LMKDNYLVVZU(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4104960", Offset = "0x4103960", VA = "0x184104960")]
		private static Id32<ExecForwardResults.M> LBSBNYKUSQI<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.PRISDEAPYQF
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B93A60", Offset = "0x2B92A60", VA = "0x182B93A60")]
		public static Id32<ExecForwardResults.M> TCLYBDLCHKU(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B93910", Offset = "0x2B92910", VA = "0x182B93910")]
		public static Id32<ExecForwardResults.M> SQJKXHTNFOZ(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B92EF0", Offset = "0x2B91EF0", VA = "0x182B92EF0")]
		public static Id32<ExecForwardResults.M> MPNOIHJITGR(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B92990", Offset = "0x2B91990", VA = "0x182B92990")]
		public static Id32<ExecForwardResults.M> JZKKOYNUEQO(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B929E0", Offset = "0x2B919E0", VA = "0x182B929E0")]
		public static Id32<ExecForwardResults.M> KARHBDFRYOA(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B92890", Offset = "0x2B91890", VA = "0x182B92890")]
		public static FunctionCalls.Def JHCCDINIKZT([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B93700", Offset = "0x2B92700", VA = "0x182B93700")]
		public static CopyEnumerable<Id32<FunctionCalls.XHRWZULGYUF>, Id32Enumerator<FunctionCalls.XHRWZULGYUF>> QPFQMLQJWEY([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.XHRWZULGYUF>, Id32Enumerator<FunctionCalls.XHRWZULGYUF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B93740", Offset = "0x2B92740", VA = "0x182B93740")]
		public static Id32<FunctionCalls.XHRWZULGYUF> RLANPGLMLHB([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.XHRWZULGYUF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B93B70", Offset = "0x2B92B70", VA = "0x182B93B70")]
		public static FunctionCalls.IO TVCKLQBWWDI([In] this FunctionCompileState self, Id32<FunctionCalls.XHRWZULGYUF> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B92AC0", Offset = "0x2B91AC0", VA = "0x182B92AC0")]
		public static FunctionCalls.IO KUZCZGMHOLC(this FunctionCompileState a, Id32<FunctionCalls.XHRWZULGYUF> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4104480", Offset = "0x4103480", VA = "0x184104480")]
		private static Id32<FunctionCalls.M> HUITFKWYKVN<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.PRISDEAPYQF
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B92380", Offset = "0x2B91380", VA = "0x182B92380")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.XHRWZULGYUF>) FTBABDYNHVA(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.XHRWZULGYUF>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B93C30", Offset = "0x2B92C30", VA = "0x182B93C30")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.XHRWZULGYUF>) UCQHBHJKJXW(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.XHRWZULGYUF>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B92730", Offset = "0x2B91730", VA = "0x182B92730")]
		public static Id32<FunctionCalls.M> HQNQCSQTTUN(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B926A0", Offset = "0x2B916A0", VA = "0x182B926A0")]
		public static void HQGOTNARWHW(this FunctionCompileState a, Id32<FunctionCalls.XHRWZULGYUF> b, Id32<IUSFABQMYST<KSOYRRRMEVU>> c, Id32<IUSFABQMYST<XDHGRWMIQRX>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x41059E0", Offset = "0x41049E0", VA = "0x1841059E0")]
		public static GenerateDataBackResult XVFZDQHHLYK<d, e>(this FunctionCompileState a, d b, e c, Id32<YUFXTHDQAZB> d, Id32<EXUEQGJGLLV> e) where d : IUAMOHWSHKE<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4104510", Offset = "0x4103510", VA = "0x184104510")]
		public static GenerateDataBackFromInputIndexResult JEFNBSCPBNU<f, g>(this FunctionCompileState a, f b, g c, Id32<YUFXTHDQAZB> d, Id32<ISSDUATOTVT> e, int f) where f : IUAMOHWSHKE<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x41052C0", Offset = "0x41042C0", VA = "0x1841052C0")]
		public static Id32<DataBackResults.M>? QQTYCGVCEPN<h, i>(this FunctionCompileState a, h b, i c, Id32<YUFXTHDQAZB> d, Id32<ISSDUATOTVT> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : IUAMOHWSHKE<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4104A00", Offset = "0x4103A00", VA = "0x184104A00")]
		public static Id32<ExecForwardResults.M> MXWQYOSWPON<j, k>(this FunctionCompileState a, j b, k c, Id32<YUFXTHDQAZB> d, Id32<METWAAXGTBK> e) where j : IUAMOHWSHKE<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B92CD0", Offset = "0x2B91CD0", VA = "0x182B92CD0")]
		public static LocalVariables.ArgumentInst MBIXVQRBRQZ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B93DE0", Offset = "0x2B92DE0", VA = "0x182B93DE0")]
		public static LocalVariables.CalleeReturnValueInst UNNKZPDEBAT([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B92590", Offset = "0x2B91590", VA = "0x182B92590")]
		public static LocalVariables.CallerReturnValueInst HJUBBEGSVCY([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B93320", Offset = "0x2B92320", VA = "0x182B93320")]
		public static Id32<LocalVariables.M> POYDKLAXWTS(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B92780", Offset = "0x2B91780", VA = "0x182B92780")]
		public static LocalVariables.ParameterInst IDNCWWINANT([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B93BE0", Offset = "0x2B92BE0", VA = "0x182B93BE0")]
		public static LocalVariables.Def TYNILEHVOQF([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B92280", Offset = "0x2B91280", VA = "0x182B92280")]
		public static int? ERJXLPEPVDV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4104380", Offset = "0x4103380", VA = "0x184104380")]
		private static Id32<LocalVariables.M> CAYTJXZODDZ<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.PRISDEAPYQF
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B921D0", Offset = "0x2B911D0", VA = "0x182B921D0")]
		public static Id32<LocalVariables.M> EOHEGOXBYKL(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B92530", Offset = "0x2B91530", VA = "0x182B92530")]
		public static Id32<LocalVariables.M> GVQGYHIEIDG(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B940D0", Offset = "0x2B930D0", VA = "0x182B940D0")]
		public static Id32<LocalVariables.M> YYEBDXLHOAM(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B93610", Offset = "0x2B92610", VA = "0x182B93610")]
		public static Id32<LocalVariables.M> QFVSSKLYAWO(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B935B0", Offset = "0x2B925B0", VA = "0x182B935B0")]
		public static Id32<LocalVariables.M> QELHONLKEUS(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B92B30", Offset = "0x2B91B30", VA = "0x182B92B30")]
		public static void LIFIHGYQOTV(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B92DE0", Offset = "0x2B91DE0", VA = "0x182B92DE0")]
		public static void MKEJJIHJDEB(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B922D0", Offset = "0x2B912D0", VA = "0x182B922D0")]
		public static void FPSJORCMPGZ(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B94040", Offset = "0x2B93040", VA = "0x182B94040")]
		public static void YLBWVSEBAUC(this FunctionCompileState a, Id32<IUSFABQMYST<KSOYRRRMEVU>> b, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B931C0", Offset = "0x2B921C0", VA = "0x182B931C0")]
		public static void OBELIJIIXZQ(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<IUSFABQMYST<GGHNXIEUGCD>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4105900", Offset = "0x4104900", VA = "0x184105900")]
		public static void XTFHAVJIMWH<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<IUSFABQMYST<LFNQUYKKBAN<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface IUAMOHWSHKE<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<ASCDINNYFPF> FGZYETKDYGP(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<ASCDINNYFPF> JJEHPJNEOLA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<ASCDINNYFPF> CUTGGBZDKDJ(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<ASCDINNYFPF> QAXBAPZZMFK(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> KNCQECSMOFE(a a, FunctionCompileState b, Id32<YUFXTHDQAZB> c, Id32<EXUEQGJGLLV> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> QHIGVVAYIWG(a a, FunctionCompileState b, Id32<YUFXTHDQAZB> c, Id32<METWAAXGTBK> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int KHPLLVIPODG(a a, Id32<YUFXTHDQAZB> b, Id32<EXUEQGJGLLV> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<METWAAXGTBK> OZVUINSRLSP(a a, Id32<YUFXTHDQAZB> b, Id32<EXUEQGJGLLV> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind PUCHYIPVVUO(a a, Id32<YUFXTHDQAZB> b, Id32<EXUEQGJGLLV> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool EGKKEUOYDZF(a a, Id32<YUFXTHDQAZB> b, Id32<EXUEQGJGLLV> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int KZCETUYVFHS(a a, Id32<YUFXTHDQAZB> b, Id32<EXUEQGJGLLV> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> VHIERUMFFUG(a a, Id32<YUFXTHDQAZB> b, Id32<EXUEQGJGLLV> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<ASCDINNYFPF>) GUMIDTZBVHG(a a, Id32<YUFXTHDQAZB> b, Id32<EXUEQGJGLLV> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int UXJYZOZVSPU(a a, Id32<YUFXTHDQAZB> b, Id32<METWAAXGTBK> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<EXUEQGJGLLV> OUQAMRSSZKP(a a, Id32<YUFXTHDQAZB> b, Id32<METWAAXGTBK> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<EXUEQGJGLLV> FOFWEXJUXUW(a a, Id32<YUFXTHDQAZB> b, Id32<ISSDUATOTVT> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int KCSBUQMIWHE(a a, Id32<YUFXTHDQAZB> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? OFLPMZAOPAA(a a, Id32<YUFXTHDQAZB> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int EJUKWMYHZKQ(a a, Id32<YUFXTHDQAZB> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? NKFLPPPNUAS(a a, Id32<YUFXTHDQAZB> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class LKLOBRFFAWZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB580", Offset = "0x3BEA580", VA = "0x183BEB580")]
		public static Id32<LocalVariables.M?> UTCTDLPBQCQ<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3BEA2D0", Offset = "0x3BE92D0", VA = "0x183BEA2D0")]
		public static Id32<LocalVariables.M?> OXEVRYMJCIR<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3BE9120", Offset = "0x3BE8120", VA = "0x183BE9120")]
		public static Id32<LocalVariables.M?> FYQAMBDMZSA<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C020", Offset = "0x2B8B020", VA = "0x182B8C020")]
		public static Id32<LocalVariables.M> BLCNICWVPNK(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C560", Offset = "0x2B8B560", VA = "0x182B8C560")]
		public static Id32<LocalVariables.M> BWQUNVHLZAT(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E3A0", Offset = "0x2B8D3A0", VA = "0x182B8E3A0")]
		public static Id32<LocalVariables.M> KISCRBAGRSO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E0F0", Offset = "0x2B8D0F0", VA = "0x182B8E0F0")]
		public static Id32<LocalVariables.M> IXUYIYIXLLU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBB0", Offset = "0x2B8DBB0", VA = "0x182B8EBB0")]
		public static Id32<LocalVariables.M> PREXEXEVEDL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F670", Offset = "0x2B8E670", VA = "0x182B8F670")]
		public static Id32<LocalVariables.M> VJTLPEXWGCM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BD20", Offset = "0x2B8AD20", VA = "0x182B8BD20")]
		public static Id32<LocalVariables.M> AYSBCYXKLYM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E870", Offset = "0x2B8D870", VA = "0x182B8E870")]
		public static Id32<LocalVariables.M> MTAOZSFQUNV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C120", Offset = "0x2B8B120", VA = "0x182B8C120")]
		public static Id32<LocalVariables.M> BNBZEVTKDRE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BF20", Offset = "0x2B8AF20", VA = "0x182B8BF20")]
		public static Id32<LocalVariables.M> BJHYEZEAYUP(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B906A0", Offset = "0x2B8F6A0", VA = "0x182B906A0")]
		public static Id32<LocalVariables.M> ZPWTEPJLLAE(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F0F0", Offset = "0x2B8E0F0", VA = "0x182B8F0F0")]
		public static Id32<LocalVariables.M> TXIEUHQKJBD(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D420", Offset = "0x2B8C420", VA = "0x182B8D420")]
		public static Id32<LocalVariables.M> FQGLVLXCGEO(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F540", Offset = "0x2B8E540", VA = "0x182B8F540")]
		public static Id32<LocalVariables.M> VGUUUCZAVFT(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F400", Offset = "0x2B8E400", VA = "0x182B8F400")]
		public static Id32<LocalVariables.M> UXBDXXVHXGQ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EB30", Offset = "0x2B8DB30", VA = "0x182B8EB30")]
		public static Id32<LocalVariables.M> PIOTLCRIKFG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EE30", Offset = "0x2B8DE30", VA = "0x182B8EE30")]
		public static Id32<LocalVariables.M> RVWUTAOPHXF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B960", Offset = "0x2B8A960", VA = "0x182B8B960")]
		public static Id32<LocalVariables.M> ACXYKSBNCDU(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D520", Offset = "0x2B8C520", VA = "0x182B8D520")]
		public static Id32<LocalVariables.M> FZIVUEYTSTH(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E990", Offset = "0x2B8D990", VA = "0x182B8E990")]
		public static Id32<LocalVariables.M> NMRQPSLNQAS(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C8D0", Offset = "0x2B8B8D0", VA = "0x182B8C8D0")]
		public static Id32<LocalVariables.M> CUCDYGVHRVZ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D7C0", Offset = "0x2B8C7C0", VA = "0x182B8D7C0")]
		public static Id32<LocalVariables.M> GLDWZHSGEQN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F380", Offset = "0x2B8E380", VA = "0x182B8F380")]
		public static Id32<LocalVariables.M> UUPFJWQCZGC(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E700", Offset = "0x2B8D700", VA = "0x182B8E700")]
		public static Id32<LocalVariables.M> LZOZAMTGLOH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C950", Offset = "0x2B8B950", VA = "0x182B8C950")]
		public static Id32<LocalVariables.M> CURBDQHIRMU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BE20", Offset = "0x2B8AE20", VA = "0x182B8BE20")]
		public static Id32<LocalVariables.M> BEOSGLGIIZF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D840", Offset = "0x2B8C840", VA = "0x182B8D840")]
		public static Id32<LocalVariables.M> GTJCDSTOPIW(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C260", Offset = "0x2B8B260", VA = "0x182B8C260")]
		public static Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> BTHHFSXXSSC(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E320", Offset = "0x2B8D320", VA = "0x182B8E320")]
		public static Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> KDJFARQMTZI(this FunctionCompileState a, int b)
		{
			return default(Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D8C0", Offset = "0x2B8C8C0", VA = "0x182B8D8C0")]
		public static Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> GYKOAMFLWIV(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FC50", Offset = "0x2B8EC50", VA = "0x182B8FC50")]
		public static Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> VZLLLFLVTOP(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BEA0", Offset = "0x2B8AEA0", VA = "0x182B8BEA0")]
		public static Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> BGNBPKFEVEP(this FunctionCompileState a, int b)
		{
			return default(Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA10", Offset = "0x2B8DA10", VA = "0x182B8EA10")]
		public static Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> OAFLHEUXMCE(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CAE0", Offset = "0x2B8BAE0", VA = "0x182B8CAE0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.XHRWZULGYUF>) DYQVTFYZTPP(this FunctionCompileState a, Id32<CINWVLLIKQC> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.XHRWZULGYUF>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F7B0", Offset = "0x2B8E7B0", VA = "0x182B8F7B0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.XHRWZULGYUF>) VLWXHCBOFXV(this FunctionCompileState a, Id32<RGDVWPILPWQ> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.XHRWZULGYUF>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3BEBC10", Offset = "0x3BEAC10", VA = "0x183BEBC10")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<ASCDINNYFPF>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<TMarker>>, Id32<FunctionCalls.M>) WYRIOVPQUUQ<TMarker>(this FunctionCompileState a, Id32<ASCDINNYFPF> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<ASCDINNYFPF>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B9E0", Offset = "0x2B8A9E0", VA = "0x182B8B9E0")]
		public static Id32<LocalVariables.M> ADXRNWEKMZY(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E780", Offset = "0x2B8D780", VA = "0x182B8E780")]
		public static Id32<LocalVariables.M> MRHZDCPYDIR(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E000", Offset = "0x2B8D000", VA = "0x182B8E000")]
		public static Id32<LocalVariables.M> IWWXCSNKRUK(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CF80", Offset = "0x2B8BF80", VA = "0x182B8CF80")]
		public static Id32<LocalVariables.M> EEJCQYPUSDP(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D1E0", Offset = "0x2B8C1E0", VA = "0x182B8D1E0")]
		public static Id32<LocalVariables.M> EPZOWYKWJUC(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DEE0", Offset = "0x2B8CEE0", VA = "0x182B8DEE0")]
		public static Id32<LocalVariables.M> IOYDXQTSCSN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B907C0", Offset = "0x2B8F7C0", VA = "0x182B907C0")]
		public static Id32<LocalVariables.M> ZSCGQHPWLIA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B90900", Offset = "0x2B8F900", VA = "0x182B90900")]
		public static Id32<LocalVariables.M> ZTVJPRTXNAA(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B90A00", Offset = "0x2B8FA00", VA = "0x182B90A00")]
		public static Id32<LocalVariables.M> ZWLPLNCMPGD(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DBA0", Offset = "0x2B8CBA0", VA = "0x182B8DBA0")]
		public static Id32<LocalVariables.M> HVLCKNHIWPA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EAB0", Offset = "0x2B8DAB0", VA = "0x182B8EAB0")]
		public static Id32<LocalVariables.M> ORNSHOVWYAV(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F070", Offset = "0x2B8E070", VA = "0x182B8F070")]
		public static Id32<LocalVariables.M> THFNYUHXQTU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EFF0", Offset = "0x2B8DFF0", VA = "0x182B8EFF0")]
		public static Id32<LocalVariables.M> SRNUDJSKPPV(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C7D0", Offset = "0x2B8B7D0", VA = "0x182B8C7D0")]
		public static Id32<LocalVariables.M> CSJTFCMFTWR(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E1F0", Offset = "0x2B8D1F0", VA = "0x182B8E1F0")]
		public static Id32<LocalVariables.M> JYQOLDZPYYO(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C680", Offset = "0x2B8B680", VA = "0x182B8C680")]
		public static Id32<LocalVariables.M> BXCMZHQXXYP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DDE0", Offset = "0x2B8CDE0", VA = "0x182B8DDE0")]
		public static Id32<LocalVariables.M> IJBXJDNZEMU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E5E0", Offset = "0x2B8D5E0", VA = "0x182B8E5E0")]
		public static Id32<LocalVariables.M> LLEVVSGLAAL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EEB0", Offset = "0x2B8DEB0", VA = "0x182B8EEB0")]
		public static Id32<LocalVariables.M> SGNDTTDARUK(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ECD0", Offset = "0x2B8DCD0", VA = "0x182B8ECD0")]
		public static Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>> QNNPTZRBMTQ(this FunctionCompileState a)
		{
			return default(Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C460", Offset = "0x2B8B460", VA = "0x182B8C460")]
		public static Id32<LocalVariables.M> BUTFFTSFZMP(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B90360", Offset = "0x2B8F360", VA = "0x182B90360")]
		public static Id32<LocalVariables.M> XANFTNYERUY(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BBE0", Offset = "0x2B8ABE0", VA = "0x182B8BBE0")]
		public static Id32<LocalVariables.M> ALLQPMZWSQZ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B90260", Offset = "0x2B8F260", VA = "0x182B90260")]
		public static Id32<LocalVariables.M> WWXQRLTXGFX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA80", Offset = "0x2B8CA80", VA = "0x182B8DA80")]
		public static Id32<LocalVariables.M> HGJHSURYRES(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D0A0", Offset = "0x2B8C0A0", VA = "0x182B8D0A0")]
		public static Id32<LocalVariables.M> EOTGBLVGVFF(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B905A0", Offset = "0x2B8F5A0", VA = "0x182B905A0")]
		public static Id32<LocalVariables.M> ZBCLFDGKCVI(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C9D0", Offset = "0x2B8B9D0", VA = "0x182B8C9D0")]
		public static Id32<LocalVariables.M> DTGTJGPCABD(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C7C0", Offset = "0x2B8B7C0", VA = "0x182B8C7C0")]
		public static void BXEEAKQPLTS(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DCE0", Offset = "0x2B8CCE0", VA = "0x182B8DCE0")]
		public static Id32<LocalVariables.M> IHTSLKENLNZ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D6A0", Offset = "0x2B8C6A0", VA = "0x182B8D6A0")]
		public static Id32<LocalVariables.M> GIHFKLUMCHC(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D2E0", Offset = "0x2B8C2E0", VA = "0x182B8D2E0")]
		public static Id32<LocalVariables.M> EYYOEYAYEYN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D5A0", Offset = "0x2B8C5A0", VA = "0x182B8D5A0")]
		public static Id32<LocalVariables.M> GHKCNTXRURD(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D960", Offset = "0x2B8C960", VA = "0x182B8D960")]
		public static Id32<LocalVariables.M> GZKWIPUWYWO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BAA0", Offset = "0x2B8AAA0", VA = "0x182B8BAA0")]
		public static Id32<LocalVariables.M> AEWIAEJFIUX(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FE50", Offset = "0x2B8EE50", VA = "0x182B8FE50")]
		public static Id32<LocalVariables.M> WWEXLPFVJMT(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E4E0", Offset = "0x2B8D4E0", VA = "0x182B8E4E0")]
		public static Id32<LocalVariables.M> LBSYOQADTHO(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B90480", Offset = "0x2B8F480", VA = "0x182B90480")]
		public static Id32<LocalVariables.M> YJZSGPHVBQL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ECF0", Offset = "0x2B8DCF0", VA = "0x182B8ECF0")]
		public static Id32<LocalVariables.M> RURAQYBPPDY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3BE99B0", Offset = "0x3BE89B0", VA = "0x183BE99B0")]
		public static void ONQKNWRHXXJ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CINWVLLIKQC> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, IUAMOHWSHKE<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3BE8850", Offset = "0x3BE7850", VA = "0x183BE8850")]
		public static void FVLDQSNRCGN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<RGDVWPILPWQ> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, IUAMOHWSHKE<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3BEBD20", Offset = "0x3BEAD20", VA = "0x183BEBD20")]
		public static Id32<LocalVariables.M> XNJMGLBLXOD<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, IUAMOHWSHKE<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC030", Offset = "0x3BEB030", VA = "0x183BEC030")]
		public static Id32<LocalVariables.M> YOGHFAKVDBK<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, IUAMOHWSHKE<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3BE9250", Offset = "0x3BE8250", VA = "0x183BE9250")]
		public static Id32<DataBackResults.M> HWRWJLRHULP<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, IUAMOHWSHKE<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB0D0", Offset = "0x3BEA0D0", VA = "0x183BEB0D0")]
		public static Id32<ExecForwardResults.M> SYMZLOQQRAC<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, IUAMOHWSHKE<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F230", Offset = "0x2B8E230", VA = "0x182B8F230")]
		public static Id32<DataBackResults.M> UFCDNFGGFCG(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B90B20", Offset = "0x2B8FB20", VA = "0x182B90B20")]
		public static Id32<DataBackResults.M> ZZXTMGPPLTC(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3BEA500", Offset = "0x3BE9500", VA = "0x183BEA500")]
		public static Id32<DataBackResults.M> QBYKWNTQOFN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CINWVLLIKQC> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, IUAMOHWSHKE<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3BEA6E0", Offset = "0x3BE96E0", VA = "0x183BEA6E0")]
		private static Id32<DataBackResults.M> QBYKWNTQOFN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<CINWVLLIKQC> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, IUAMOHWSHKE<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3BE9560", Offset = "0x3BE8560", VA = "0x183BE9560")]
		public static Id32<LocalVariables.M> LMVBOLUYAAX<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, IUAMOHWSHKE<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB770", Offset = "0x3BEA770", VA = "0x183BEB770")]
		public static void WAVREZWOTMG<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, IUAMOHWSHKE<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<IUSFABQMYST<KSOYRRRMEVU>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<IUSFABQMYST<KSOYRRRMEVU>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		public LiveInterval(Id32<IUSFABQMYST<KSOYRRRMEVU>> firstUse, Id32<IUSFABQMYST<KSOYRRRMEVU>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B90E50", Offset = "0x2B8FE50", VA = "0x182B90E50")]
		public static LiveInterval New(Id32<IUSFABQMYST<KSOYRRRMEVU>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class OQDVKEUGPXI : PRISDEAPYQF
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
			[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class DVXFPOICYIK : PRISDEAPYQF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class FFFKABSAZTH : PRISDEAPYQF
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
			[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
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
		public abstract class PRISDEAPYQF
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
			public Id32<PRISDEAPYQF> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B890", Offset = "0x2B8A890", VA = "0x182B8B890")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<PRISDEAPYQF> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class JJJNDROCAQM : PRISDEAPYQF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<OQDVKEUGPXI, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<FFFKABSAZTH, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<JJJNDROCAQM, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<DVXFPOICYIK, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B91050", Offset = "0x2B90050", VA = "0x182B91050")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<OQDVKEUGPXI, ArgumentInst> argumentVariables, [In] SOAId32Field<FFFKABSAZTH, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<JJJNDROCAQM, ParameterInst> parameterVariables, [In] SOAId32Field<DVXFPOICYIK, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B90E60", Offset = "0x2B8FE60", VA = "0x182B90E60")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class NUCYTTNTMYR
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B911E0", Offset = "0x2B901E0", VA = "0x182B911E0")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class OISVBXIIPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B91310", Offset = "0x2B90310", VA = "0x182B91310")]
		public static void EBXMKUNRLSP(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.XHRWZULGYUF, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B89870", Offset = "0x2B88870", VA = "0x182B89870")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.XHRWZULGYUF, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B89800", Offset = "0x2B88800", VA = "0x182B89800")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B895E0", Offset = "0x2B885E0", VA = "0x182B895E0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x369A8B0", Offset = "0x36998B0", VA = "0x18369A8B0")]
		public static void EBXMKUNRLSP<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<YUFXTHDQAZB> graphId) where TDeps : notnull, IUAMOHWSHKE<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class ZCATBJWUHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B94470", Offset = "0x2B93470", VA = "0x182B94470")]
		public static void EBXMKUNRLSP(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface MXOJYSDJMFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ZBYWQURWSMO(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : MXOJYSDJMFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2B915B0", Offset = "0x2B905B0", VA = "0x182B915B0", Slot = "4")]
			public void ZBYWQURWSMO(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : MXOJYSDJMFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2B91640", Offset = "0x2B90640", VA = "0x182B91640", Slot = "4")]
			public void ZBYWQURWSMO(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : MXOJYSDJMFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2B91470", Offset = "0x2B90470", VA = "0x182B91470", Slot = "4")]
			public void ZBYWQURWSMO(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : MXOJYSDJMFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2B91500", Offset = "0x2B90500", VA = "0x182B91500", Slot = "4")]
			public void ZBYWQURWSMO(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class DHYWMFKRDIV<c> where c : struct, MXOJYSDJMFX
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c BIQCNNIQICF;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x37D1EA0", Offset = "0x37D0EA0", VA = "0x1837D1EA0")]
			public static int EBXMKUNRLSP<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : IUAMOHWSHKE<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<FunctionCalls.XHRWZULGYUF>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B840", Offset = "0x2B8A840", VA = "0x182B8B840")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<FunctionCalls.XHRWZULGYUF>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B790", Offset = "0x2B8A790", VA = "0x182B8B790")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B750", Offset = "0x2B8A750", VA = "0x182B8B750")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B5AA70", Offset = "0x3B59A70", VA = "0x183B5AA70")]
		public static void EBXMKUNRLSP<b, a>(FunctionCompileState a, b b, a c) where b : IUAMOHWSHKE<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class BVIBMHPXTZV
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
		private static int RNSVLJCJAYT;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int TLQDAXVWCCF;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B898B0", Offset = "0x2B888B0", VA = "0x182B898B0")]
		public static void EBXMKUNRLSP(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A0B0", Offset = "0x2B890B0", VA = "0x182B8A0B0")]
		private static void XNNCQBGZORY([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B89F70", Offset = "0x2B88F70", VA = "0x182B89F70")]
		private static void XNNCQBGZORY(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B89E10", Offset = "0x2B88E10", VA = "0x182B89E10")]
		private static void UCCFOTFDAQB(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class WHNTDXWWGQT<a, b, c> where a : struct, FVRUVVDMUIP<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a BIQCNNIQICF;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8721510", Offset = "0x8720510", VA = "0x188721510")]
		public static void EBXMKUNRLSP([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface FVRUVVDMUIP<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> YODQSNHGGGT(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FSUTTKHIWTX(a a, b b, Id32<IUSFABQMYST<BJYQQFZJRSF>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface SZCVJXDQIZY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a TXQYQJEHQSC(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UGYWTIFFAEA(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<IUSFABQMYST<BJYQQFZJRSF>> MCDJDEEOUYZ(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class RYIDIMYVTHY<a, b, c> where a : struct, SZCVJXDQIZY<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a BIQCNNIQICF;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7847970", Offset = "0x7846970", VA = "0x187847970")]
		public static UnsafeList<b> EBXMKUNRLSP(int a, [In] c values)
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
