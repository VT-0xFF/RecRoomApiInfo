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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC8930", Offset = "0x2BC7330", VA = "0x182BC8930")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		public readonly Id32<EWICTHMTERF<CEGVXPWDZCF>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		public ByteCodeAdjustment(Id32<EWICTHMTERF<CEGVXPWDZCF>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class WHXMCTYCFCN : ZFRRPWWWWFT
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2B528F0", Offset = "0x2B512F0", VA = "0x182B528F0")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF0D0", Offset = "0x2BBDAD0", VA = "0x182BBF0D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class GOIBBORECEA : ZFRRPWWWWFT
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<EWICTHMTERF<QIRCDDDMPGO>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
			public DeadEnd(Id32<EWICTHMTERF<QIRCDDDMPGO>> nextByteCodePtr)
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
		public abstract class ZFRRPWWWWFT
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
			public readonly Id32<ZFRRPWWWWFT> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
			public Inst(Def def, Id32<ZFRRPWWWWFT> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class DPNFMHMYBMF : ZFRRPWWWWFT
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class AWRCOSUAMWD : ZFRRPWWWWFT
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x23C8FC0", Offset = "0x23C79C0", VA = "0x1823C8FC0", Slot = "3")]
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
		internal IdUnsafeList<WHXMCTYCFCN, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<GOIBBORECEA, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<DPNFMHMYBMF, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<AWRCOSUAMWD, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF280", Offset = "0x2BBDC80", VA = "0x182BBF280")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<WHXMCTYCFCN, BytesImmediate> bytesImmediates, [In] IdUnsafeList<GOIBBORECEA, DeadEnd> deadEnds, [In] IdUnsafeList<DPNFMHMYBMF, Variable> variables, [In] IdUnsafeList<AWRCOSUAMWD, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF140", Offset = "0x2BBDB40", VA = "0x182BBF140")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MZHOJTMHXEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8880", Offset = "0x2BC7280", VA = "0x182BC8880")]
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
		public sealed class OOXSWJOIWEI : ZFRRPWWWWFT
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
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
		public abstract class ZFRRPWWWWFT
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
			public readonly Id32<ZFRRPWWWWFT> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
			public Inst(Def def, Id32<ZFRRPWWWWFT> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<OOXSWJOIWEI, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF500", Offset = "0x2BBDF00", VA = "0x182BBF500")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<OOXSWJOIWEI, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF470", Offset = "0x2BBDE70", VA = "0x182BBF470")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class PUNYYWYJKXH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BC89B0", Offset = "0x2BC73B0", VA = "0x182BC89B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBF630", Offset = "0x2BBE030", VA = "0x182BBF630")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF590", Offset = "0x2BBDF90", VA = "0x182BBF590")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class FWMNYFNRDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF540", Offset = "0x2BBDF40", VA = "0x182BBF540")]
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
		public sealed class VPVBBXZDMJY : ZFRRPWWWWFT
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<CKVBEOXUDGV> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
			public ExternalCall(Id32<CKVBEOXUDGV> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class ZFRRPWWWWFT
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
			public readonly Id32<ZFRRPWWWWFT> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
			private Inst(Def def, Id32<ZFRRPWWWWFT> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8520", Offset = "0x2BC6F20", VA = "0x182BC8520")]
			public static Inst New(Def def, Id32<ZFRRPWWWWFT> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class HHZBSZSKBMQ : ZFRRPWWWWFT
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<CKVBEOXUDGV> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
			public InternalCall(Id32<CKVBEOXUDGV> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class CKVBEOXUDGV
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
			[Cpp2IlInjected.Address(RVA = "0x2BBF500", Offset = "0x2BBDF00", VA = "0x182BBF500")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8370", Offset = "0x2BC6D70", VA = "0x182BC8370")]
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
		internal IdUnsafeList<HHZBSZSKBMQ, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<VPVBBXZDMJY, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<CKVBEOXUDGV> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<CKVBEOXUDGV, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF830", Offset = "0x2BBE230", VA = "0x182BBF830")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<HHZBSZSKBMQ, InternalCall> internalCalls, [In] IdUnsafeList<VPVBBXZDMJY, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<CKVBEOXUDGV> IOId)> callsWithIO, [In] IdUnsafeList<CKVBEOXUDGV, IO> io, [In] SOAField<CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> ioModifyingCallLocations, [In] SOAField<CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF690", Offset = "0x2BBE090", VA = "0x182BBF690")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class HYUXPBIXRXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8320", Offset = "0x2BC6D20", VA = "0x182BC8320")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8110", Offset = "0x2BC6B10", VA = "0x182BC8110")]
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
		internal SOAField<SYPXNPTSRKI, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<SYPXNPTSRKI>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0280", Offset = "0x2BBEC80", VA = "0x182BC0280")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<SYPXNPTSRKI, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<SYPXNPTSRKI>> generatedOutputsForExpression, [In] SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF8F0", Offset = "0x2BBE2F0", VA = "0x182BBF8F0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class GKWVSNGHRSX
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : REGHEVDCKXU<Id32<FunctionCalls.CKVBEOXUDGV>, SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8CD0", Offset = "0x2BC76D0", VA = "0x182BC8CD0")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8C90", Offset = "0x2BC7690", VA = "0x182BC8C90", Slot = "4")]
			public Id32<FunctionCalls.CKVBEOXUDGV> IFBAKMDRWMG(int a)
			{
				return default(Id32<FunctionCalls.CKVBEOXUDGV>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
			public bool BEQLPLYQXAE(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "5")]
			private bool BKVEIJRXYBY(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8D50", Offset = "0x2BC7750", VA = "0x182BC8D50", Slot = "6")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> QQRZSEUVEZJ(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : BDYKWFWXNKP<Id32<FunctionCalls.CKVBEOXUDGV>, SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE260", Offset = "0x2BBCC60", VA = "0x182BBE260")]
			public UnsafeList<Id32<FunctionCalls.CKVBEOXUDGV>> FDBCVOORAIP(int a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.CKVBEOXUDGV>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE2D0", Offset = "0x2BBCCD0", VA = "0x182BBE2D0")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE360", Offset = "0x2BBCD60", VA = "0x182BBE360", Slot = "6")]
			public void WBAGNFNWQMV(Id32<FunctionCalls.CKVBEOXUDGV> a, SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> b, Id32<EWICTHMTERF<CEGVXPWDZCF>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE260", Offset = "0x2BBCC60", VA = "0x182BBE260", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.CKVBEOXUDGV>> SFVDCVBXHYC(int a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.CKVBEOXUDGV>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE350", Offset = "0x2BBCD50", VA = "0x182BBE350", Slot = "5")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> RIZUZWLJISW(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<QIRCDDDMPGO>>> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : REGHEVDCKXU<Id32<FunctionCalls.CKVBEOXUDGV>, SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8DB0", Offset = "0x2BC77B0", VA = "0x182BC8DB0")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8D60", Offset = "0x2BC7760", VA = "0x182BC8D60", Slot = "4")]
			public Id32<FunctionCalls.CKVBEOXUDGV> IFBAKMDRWMG(int a)
			{
				return default(Id32<FunctionCalls.CKVBEOXUDGV>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
			public bool BEQLPLYQXAE(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "5")]
			private bool RSWPDIWPWPF(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8DA0", Offset = "0x2BC77A0", VA = "0x182BC8DA0", Slot = "6")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> LHOLJVTOMXU(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : BDYKWFWXNKP<Id32<FunctionCalls.CKVBEOXUDGV>, SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE400", Offset = "0x2BBCE00", VA = "0x182BBE400")]
			public UnsafeList<Id32<FunctionCalls.CKVBEOXUDGV>> FDBCVOORAIP(int a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.CKVBEOXUDGV>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE480", Offset = "0x2BBCE80", VA = "0x182BBE480")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE500", Offset = "0x2BBCF00", VA = "0x182BBE500", Slot = "6")]
			public void WBAGNFNWQMV(Id32<FunctionCalls.CKVBEOXUDGV> a, SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> b, Id32<EWICTHMTERF<CEGVXPWDZCF>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE400", Offset = "0x2BBCE00", VA = "0x182BBE400", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.CKVBEOXUDGV>> DAQLFRNYNML(int a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.CKVBEOXUDGV>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE470", Offset = "0x2BBCE70", VA = "0x182BBE470", Slot = "5")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> KIRQEPBCDSJ(Id32<FunctionCalls.CKVBEOXUDGV> a, [In] SOAField<FunctionCalls.CKVBEOXUDGV, Id32<EWICTHMTERF<RBMWJAHCKAJ>>> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : REGHEVDCKXU<Id32<QHFBBKDJWVN>, SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8EE0", Offset = "0x2BC78E0", VA = "0x182BC8EE0")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(Id32<QHFBBKDJWVN> a, [In] SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8EA0", Offset = "0x2BC78A0", VA = "0x182BC8EA0", Slot = "4")]
			public Id32<QHFBBKDJWVN> IFBAKMDRWMG(int a)
			{
				return default(Id32<QHFBBKDJWVN>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8E30", Offset = "0x2BC7830", VA = "0x182BC8E30")]
			public bool BEQLPLYQXAE(Id32<QHFBBKDJWVN> a, [In] SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8E30", Offset = "0x2BC7830", VA = "0x182BC8E30", Slot = "5")]
			private bool OWWHQPQRDTP(Id32<QHFBBKDJWVN> a, [In] SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8E90", Offset = "0x2BC7890", VA = "0x182BC8E90", Slot = "6")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> BSPQYKOLOSE(Id32<QHFBBKDJWVN> a, [In] SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : BDYKWFWXNKP<Id32<QHFBBKDJWVN>, SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE5B0", Offset = "0x2BBCFB0", VA = "0x182BBE5B0")]
			public UnsafeList<Id32<QHFBBKDJWVN>> FDBCVOORAIP(int a, [In] SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> values)
			{
				return default(UnsafeList<Id32<QHFBBKDJWVN>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE620", Offset = "0x2BBD020", VA = "0x182BBE620")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(Id32<QHFBBKDJWVN> a, [In] SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE6D0", Offset = "0x2BBD0D0", VA = "0x182BBE6D0", Slot = "6")]
			public void WBAGNFNWQMV(Id32<QHFBBKDJWVN> a, SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> b, Id32<EWICTHMTERF<CEGVXPWDZCF>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE5B0", Offset = "0x2BBCFB0", VA = "0x182BBE5B0", Slot = "4")]
			private UnsafeList<Id32<QHFBBKDJWVN>> MAOHIXQNCCB(int a, [In] SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> values)
			{
				return default(UnsafeList<Id32<QHFBBKDJWVN>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE5A0", Offset = "0x2BBCFA0", VA = "0x182BBE5A0", Slot = "5")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> DZVGLASMUGL(Id32<QHFBBKDJWVN> a, [In] SOAField<QHFBBKDJWVN, Id32<EWICTHMTERF<QIRCDDDMPGO>>?> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : REGHEVDCKXU<int, UnsafeList<(Id32<LocalVariables.M>, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC90D0", Offset = "0x2BC7AD0", VA = "0x182BC90D0")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD76900", Offset = "0xD75300", VA = "0x180D76900", Slot = "4")]
			public int IFBAKMDRWMG(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
			public bool BEQLPLYQXAE(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "5")]
			private bool RMJTALFWYCA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9160", Offset = "0x2BC7B60", VA = "0x182BC9160", Slot = "6")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> ZKEKACVXYBD(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : BDYKWFWXNKP<int, UnsafeList<(Id32<LocalVariables.M>, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2BBEBF0", Offset = "0x2BBD5F0", VA = "0x182BBEBF0")]
			public UnsafeList<int> FDBCVOORAIP(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BBEC60", Offset = "0x2BBD660", VA = "0x182BBEC60")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2BBED00", Offset = "0x2BBD700", VA = "0x182BBED00", Slot = "6")]
			public void WBAGNFNWQMV(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> values, Id32<EWICTHMTERF<CEGVXPWDZCF>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2BBEBF0", Offset = "0x2BBD5F0", VA = "0x182BBEBF0", Slot = "4")]
			private UnsafeList<int> XOEXONFRORA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2BBECF0", Offset = "0x2BBD6F0", VA = "0x182BBECF0", Slot = "5")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> VYASQUDYYPI(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<EWICTHMTERF<OXBJHRVWJBD<CEGVXPWDZCF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : REGHEVDCKXU<int, UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9030", Offset = "0x2BC7A30", VA = "0x182BC9030")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD76900", Offset = "0xD75300", VA = "0x180D76900", Slot = "4")]
			public int IFBAKMDRWMG(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
			public bool BEQLPLYQXAE(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "5")]
			private bool RWUEFIHFFVV(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2BC90C0", Offset = "0x2BC7AC0", VA = "0x182BC90C0", Slot = "6")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> XMXRSLPKZCK(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : BDYKWFWXNKP<int, UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE9F0", Offset = "0x2BBD3F0", VA = "0x182BBE9F0")]
			public UnsafeList<int> FDBCVOORAIP(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2BBEA60", Offset = "0x2BBD460", VA = "0x182BBEA60")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2BBEAF0", Offset = "0x2BBD4F0", VA = "0x182BBEAF0", Slot = "6")]
			public void WBAGNFNWQMV(int a, UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values, Id32<EWICTHMTERF<CEGVXPWDZCF>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE9F0", Offset = "0x2BBD3F0", VA = "0x182BBE9F0", Slot = "4")]
			private UnsafeList<int> OUGMENOXQON(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE9E0", Offset = "0x2BBD3E0", VA = "0x182BBE9E0", Slot = "5")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> BLWRKSNJRJF(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : REGHEVDCKXU<int, UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8F90", Offset = "0x2BC7990", VA = "0x182BC8F90")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD76900", Offset = "0xD75300", VA = "0x180D76900", Slot = "4")]
			public int IFBAKMDRWMG(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
			public bool BEQLPLYQXAE(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "5")]
			private bool RWUEFIHFFVV(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9020", Offset = "0x2BC7A20", VA = "0x182BC9020", Slot = "6")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> XMXRSLPKZCK(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : BDYKWFWXNKP<int, UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE7E0", Offset = "0x2BBD1E0", VA = "0x182BBE7E0")]
			public UnsafeList<int> FDBCVOORAIP(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE850", Offset = "0x2BBD250", VA = "0x182BBE850")]
			public Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE8E0", Offset = "0x2BBD2E0", VA = "0x182BBE8E0", Slot = "6")]
			public void WBAGNFNWQMV(int a, UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values, Id32<EWICTHMTERF<CEGVXPWDZCF>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE7E0", Offset = "0x2BBD1E0", VA = "0x182BBE7E0", Slot = "4")]
			private UnsafeList<int> OUGMENOXQON(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE7D0", Offset = "0x2BBD1D0", VA = "0x182BBE7D0", Slot = "5")]
			private Id32<EWICTHMTERF<CEGVXPWDZCF>> BLWRKSNJRJF(int a, [In] UnsafeList<(Id32<EWICTHMTERF<QIRCDDDMPGO>> Target, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1CF3530", Offset = "0x1CF1F30", VA = "0x181CF3530")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2C10", Offset = "0x2BC1610", VA = "0x182BC2C10")]
			public void EBEXHOFOLIC([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<QHFBBKDJWVN> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2BF0", Offset = "0x2BC15F0", VA = "0x182BC2BF0")]
			public GenerateDataBackFromInputIndexResult(Id32<QHFBBKDJWVN> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2BC0", Offset = "0x2BC15C0", VA = "0x182BC2BC0")]
			public void EBEXHOFOLIC([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2BD0", Offset = "0x2BC15D0", VA = "0x182BC2BD0")]
			public void EBEXHOFOLIC([Out] Id32<DataBackResults.M> a, [Out] Id32<QHFBBKDJWVN> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<QHFBBKDJWVN> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
			public GenerateDataBackFromInputIndicesResult(Id32<QHFBBKDJWVN> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2C00", Offset = "0x2BC1600", VA = "0x182BC2C00")]
			public void EBEXHOFOLIC([Out] Id32<DataBackResults.M> a, [Out] Id32<QHFBBKDJWVN> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BC07C0", Offset = "0x2BBF1C0", VA = "0x182BC07C0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2BC18D0", Offset = "0x2BC02D0", VA = "0x182BC18D0")]
		public static void OLNKKTNGVTF(this FunctionCompileState a, Id32<SYPXNPTSRKI> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BC16F0", Offset = "0x2BC00F0", VA = "0x182BC16F0")]
		public static void NGWTDBIZQFL(this FunctionCompileState a, Id32<SYPXNPTSRKI> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2480", Offset = "0x2BC0E80", VA = "0x182BC2480")]
		public static Id32<DataBackResults.M>? UYUITWYGGLY([In] this FunctionCompileState self, Id32<SYPXNPTSRKI> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2040", Offset = "0x2BC0A40", VA = "0x182BC2040")]
		public static Id32<EWICTHMTERF<QIRCDDDMPGO>> PUXSAQQKLHM([In] this FunctionCompileState self)
		{
			return default(Id32<EWICTHMTERF<QIRCDDDMPGO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1D50", Offset = "0x2BC0750", VA = "0x182BC1D50")]
		private static void PEDZDSCCSMN(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1850", Offset = "0x2BC0250", VA = "0x182BC1850")]
		private static Id32<EWICTHMTERF<QIRCDDDMPGO>>? OHCJJJJUQBI([In] this FunctionCompileState self, Id32<QHFBBKDJWVN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1400", Offset = "0x2BBFE00", VA = "0x182BC1400")]
		public static void MQUYGSLLXRQ(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2A50", Offset = "0x2BC1450", VA = "0x182BC2A50")]
		public static DataBackResults.Def XPBAFEDHTEE([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0F20", Offset = "0x2BBF920", VA = "0x182BC0F20")]
		public static ReadOnlyArray<byte> GKOKIEYRNTG([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2500", Offset = "0x2BC0F00", VA = "0x182BC2500")]
		public static Id32<LocalVariables.M> VCTNDBKXPZW([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0C10", Offset = "0x2BBF610", VA = "0x182BC0C10")]
		public static Union32 FEGYTLJOPHE([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3B075E0", Offset = "0x3B05FE0", VA = "0x183B075E0")]
		private static Id32<DataBackResults.M> WJLHBHXAURV<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.ZFRRPWWWWFT
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0620", Offset = "0x2BBF020", VA = "0x182BC0620")]
		public static Id32<DataBackResults.M> CALJBAVSOCX(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2BC22D0", Offset = "0x2BC0CD0", VA = "0x182BC22D0")]
		public static Id32<DataBackResults.M> SOCDSRANJZA(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1240", Offset = "0x2BBFC40", VA = "0x182BC1240")]
		public static Id32<DataBackResults.M> KRUIQJVCMVD(this FunctionCompileState a, Id32<EWICTHMTERF<QIRCDDDMPGO>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0D40", Offset = "0x2BBF740", VA = "0x182BC0D40")]
		public static Id32<DataBackResults.M> FMFNCYKEQNP(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BC11C0", Offset = "0x2BBFBC0", VA = "0x182BC11C0")]
		public static Id32<DataBackResults.M> KIQGIUQWDMW(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3B07060", Offset = "0x3B05A60", VA = "0x183B07060")]
		private static Id32<ExecForwardResults.M> TNGOSVKNYXS<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.ZFRRPWWWWFT
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0780", Offset = "0x2BBF180", VA = "0x182BC0780")]
		public static Id32<ExecForwardResults.M> DGQEPFLHFQY(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2BC05D0", Offset = "0x2BBEFD0", VA = "0x182BC05D0")]
		public static Id32<ExecForwardResults.M> BJZACZXBXWB(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1CD0", Offset = "0x2BC06D0", VA = "0x182BC1CD0")]
		public static Id32<ExecForwardResults.M> PCNVZBWYIRP(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0DC0", Offset = "0x2BBF7C0", VA = "0x182BC0DC0")]
		public static Id32<ExecForwardResults.M> FOZQFTNYTLU(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2AC0", Offset = "0x2BC14C0", VA = "0x182BC2AC0")]
		public static Id32<ExecForwardResults.M> ZHLWINHFBYY(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1000", Offset = "0x2BBFA00", VA = "0x182BC1000")]
		public static FunctionCalls.Def HFIJAKTKKAN([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1EF0", Offset = "0x2BC08F0", VA = "0x182BC1EF0")]
		public static CopyEnumerable<Id32<FunctionCalls.CKVBEOXUDGV>, Id32Enumerator<FunctionCalls.CKVBEOXUDGV>> PLVPKULZAIY([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.CKVBEOXUDGV>, Id32Enumerator<FunctionCalls.CKVBEOXUDGV>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC20A0", Offset = "0x2BC0AA0", VA = "0x182BC20A0")]
		public static Id32<FunctionCalls.CKVBEOXUDGV> RNNXJUOMXLZ([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.CKVBEOXUDGV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1570", Offset = "0x2BBFF70", VA = "0x182BC1570")]
		public static FunctionCalls.IO MRJGVYZVGPY([In] this FunctionCompileState self, Id32<FunctionCalls.CKVBEOXUDGV> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1100", Offset = "0x2BBFB00", VA = "0x182BC1100")]
		public static FunctionCalls.IO JRPBXPHWSPC(this FunctionCompileState a, Id32<FunctionCalls.CKVBEOXUDGV> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B07550", Offset = "0x3B05F50", VA = "0x183B07550")]
		private static Id32<FunctionCalls.M> VTQVEWFDAMX<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.ZFRRPWWWWFT
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2790", Offset = "0x2BC1190", VA = "0x182BC2790")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.CKVBEOXUDGV>) VQCJBCHINSO(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.CKVBEOXUDGV>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1960", Offset = "0x2BC0360", VA = "0x182BC1960")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.CKVBEOXUDGV>) ORIJPYTKVKY(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.CKVBEOXUDGV>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0CF0", Offset = "0x2BBF6F0", VA = "0x182BC0CF0")]
		public static Id32<FunctionCalls.M> FGLBTWEBOMB(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1070", Offset = "0x2BBFA70", VA = "0x182BC1070")]
		public static void HPZEYCHTTEQ(this FunctionCompileState a, Id32<FunctionCalls.CKVBEOXUDGV> b, Id32<EWICTHMTERF<QIRCDDDMPGO>> c, Id32<EWICTHMTERF<RBMWJAHCKAJ>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B05470", Offset = "0x3B03E70", VA = "0x183B05470")]
		public static GenerateDataBackResult IQVIXWADNGG<d, e>(this FunctionCompileState a, d b, e c, Id32<JNHEPOTZQDV> d, Id32<QHFBBKDJWVN> e) where d : SWOGATQYSMU<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3B07100", Offset = "0x3B05B00", VA = "0x183B07100")]
		public static GenerateDataBackFromInputIndexResult UKBQLUOICHE<f, g>(this FunctionCompileState a, f b, g c, Id32<JNHEPOTZQDV> d, Id32<CEDSPQRYDBL> e, int f) where f : SWOGATQYSMU<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3B06B00", Offset = "0x3B05500", VA = "0x183B06B00")]
		public static Id32<DataBackResults.M>? LFXQPUOMOXV<h, i>(this FunctionCompileState a, h b, i c, Id32<JNHEPOTZQDV> d, Id32<CEDSPQRYDBL> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : SWOGATQYSMU<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3B04C50", Offset = "0x3B03650", VA = "0x183B04C50")]
		public static Id32<ExecForwardResults.M> GPWGFHYPBSV<j, k>(this FunctionCompileState a, j b, k c, Id32<JNHEPOTZQDV> d, Id32<SYPXNPTSRKI> e) where j : SWOGATQYSMU<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1B10", Offset = "0x2BC0510", VA = "0x182BC1B10")]
		public static LocalVariables.ArgumentInst OTOAPWJXFDL([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1F30", Offset = "0x2BC0930", VA = "0x182BC1F30")]
		public static LocalVariables.CalleeReturnValueInst PSLURRKKQOL([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2940", Offset = "0x2BC1340", VA = "0x182BC2940")]
		public static LocalVariables.CallerReturnValueInst XKXTJHMWGBO([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC25E0", Offset = "0x2BC0FE0", VA = "0x182BC25E0")]
		public static Id32<LocalVariables.M> VLTEGNIKJEU(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC15E0", Offset = "0x2BBFFE0", VA = "0x182BC15E0")]
		public static LocalVariables.ParameterInst NGJZPLNDBCN([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1170", Offset = "0x2BBFB70", VA = "0x182BC1170")]
		public static LocalVariables.Def JYHBSUHUKRD([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0730", Offset = "0x2BBF130", VA = "0x182BC0730")]
		public static int? DDRHEHFGSMP([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3B04B50", Offset = "0x3B03550", VA = "0x183B04B50")]
		private static Id32<LocalVariables.M> CPTBEVVCLFF<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.ZFRRPWWWWFT
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1C20", Offset = "0x2BC0620", VA = "0x182BC1C20")]
		public static Id32<LocalVariables.M> PAVGHJUSRID(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BC13A0", Offset = "0x2BBFDA0", VA = "0x182BC13A0")]
		public static Id32<LocalVariables.M> MQJLAHOCTPS(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0A90", Offset = "0x2BBF490", VA = "0x182BC0A90")]
		public static Id32<LocalVariables.M> EYITACRCXVO(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2BC06A0", Offset = "0x2BBF0A0", VA = "0x182BC06A0")]
		public static Id32<LocalVariables.M> CRZXHCDTMFA(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2270", Offset = "0x2BC0C70", VA = "0x182BC2270")]
		public static Id32<LocalVariables.M> SHBKZLIXCJA(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2360", Offset = "0x2BC0D60", VA = "0x182BC2360")]
		public static void THOHDDOIAKX(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0E10", Offset = "0x2BBF810", VA = "0x182BC0E10")]
		public static void GHBOHVGNKKZ(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2B10", Offset = "0x2BC1510", VA = "0x182BC2B10")]
		public static void ZHONCWCMSFH(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC17C0", Offset = "0x2BC01C0", VA = "0x182BC17C0")]
		public static void OBGGMVPYWXU(this FunctionCompileState a, Id32<EWICTHMTERF<QIRCDDDMPGO>> b, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC12C0", Offset = "0x2BBFCC0", VA = "0x182BC12C0")]
		public static void LXAGNSTPHFQ(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<EWICTHMTERF<QWGNENKBSZV>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3B06A20", Offset = "0x3B05420", VA = "0x183B06A20")]
		public static void JGJWPBSJITN<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<EWICTHMTERF<OXBJHRVWJBD<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface SWOGATQYSMU<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<AWGGZWOVPWP> TVGNNBFZDLB(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<AWGGZWOVPWP> MVCHACISSTA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<AWGGZWOVPWP> MKARIUYEFOH(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<AWGGZWOVPWP> YXOXZRQUYAU(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> GFYSDBCYUMW(a a, FunctionCompileState b, Id32<JNHEPOTZQDV> c, Id32<QHFBBKDJWVN> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> YKDYEQQISSG(a a, FunctionCompileState b, Id32<JNHEPOTZQDV> c, Id32<SYPXNPTSRKI> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int DYRJEENUPNG(a a, Id32<JNHEPOTZQDV> b, Id32<QHFBBKDJWVN> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<SYPXNPTSRKI> CXPIADJRUUH(a a, Id32<JNHEPOTZQDV> b, Id32<QHFBBKDJWVN> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind TOJXXZMUSPU(a a, Id32<JNHEPOTZQDV> b, Id32<QHFBBKDJWVN> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool MYFIGHAIDEH(a a, Id32<JNHEPOTZQDV> b, Id32<QHFBBKDJWVN> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int SQHIVFDTHIQ(a a, Id32<JNHEPOTZQDV> b, Id32<QHFBBKDJWVN> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> SFLEYJHDTLY(a a, Id32<JNHEPOTZQDV> b, Id32<QHFBBKDJWVN> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<AWGGZWOVPWP>) YXWLMMKQILK(a a, Id32<JNHEPOTZQDV> b, Id32<QHFBBKDJWVN> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int FVNKNSBXDHQ(a a, Id32<JNHEPOTZQDV> b, Id32<SYPXNPTSRKI> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<QHFBBKDJWVN> OAFXIFBJCDZ(a a, Id32<JNHEPOTZQDV> b, Id32<SYPXNPTSRKI> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<QHFBBKDJWVN> HFGHUHQJLVU(a a, Id32<JNHEPOTZQDV> b, Id32<CEDSPQRYDBL> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int RCADWYNNICG(a a, Id32<JNHEPOTZQDV> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? GDCVYSOYKHO(a a, Id32<JNHEPOTZQDV> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int WQNTASCVCSM(a a, Id32<JNHEPOTZQDV> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? YMLFEAXKXBE(a a, Id32<JNHEPOTZQDV> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class HBXTCEZCMZT
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A6D0", Offset = "0x3B190D0", VA = "0x183B1A6D0")]
		public static Id32<LocalVariables.M?> ENCUOQRWICI<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DC80", Offset = "0x3B1C680", VA = "0x183B1DC80")]
		public static Id32<LocalVariables.M?> YREXDDPDUIJ<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A8C0", Offset = "0x3B192C0", VA = "0x183B1A8C0")]
		public static Id32<LocalVariables.M?> GZVMFTHUVAE<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4D90", Offset = "0x2BC3790", VA = "0x182BC4D90")]
		public static Id32<LocalVariables.M> LHSZZYRKXIU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5970", Offset = "0x2BC4370", VA = "0x182BC5970")]
		public static Id32<LocalVariables.M> NHFNAXBMGPR(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC74E0", Offset = "0x2BC5EE0", VA = "0x182BC74E0")]
		public static Id32<LocalVariables.M> WMXQLGQMVSO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6B00", Offset = "0x2BC5500", VA = "0x182BC6B00")]
		public static Id32<LocalVariables.M> TJLKSDSKNPM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC62B0", Offset = "0x2BC4CB0", VA = "0x182BC62B0")]
		public static Id32<LocalVariables.M> RHQJXCDRHZT(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7BB0", Offset = "0x2BC65B0", VA = "0x182BC7BB0")]
		public static Id32<LocalVariables.M> YKFSQKYWFEM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC76A0", Offset = "0x2BC60A0", VA = "0x182BC76A0")]
		public static Id32<LocalVariables.M> WSBAFYYVPYU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7FF0", Offset = "0x2BC69F0", VA = "0x182BC7FF0")]
		public static Id32<LocalVariables.M> ZQTSUEMEKNN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC65F0", Offset = "0x2BC4FF0", VA = "0x182BC65F0")]
		public static Id32<LocalVariables.M> SCHFBVFIGIS(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6D70", Offset = "0x2BC5770", VA = "0x182BC6D70")]
		public static Id32<LocalVariables.M> UBHSHZOJJZB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2F30", Offset = "0x2BC1930", VA = "0x182BC2F30")]
		public static Id32<LocalVariables.M> CUTKRPSIVXO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7150", Offset = "0x2BC5B50", VA = "0x182BC7150")]
		public static Id32<LocalVariables.M> VSEBYGXDYSV(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC32D0", Offset = "0x2BC1CD0", VA = "0x182BC32D0")]
		public static Id32<LocalVariables.M> DVUUDWUMMYO(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC36D0", Offset = "0x2BC20D0", VA = "0x182BC36D0")]
		public static Id32<LocalVariables.M> EYLJLIZKMEB(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2CA0", Offset = "0x2BC16A0", VA = "0x182BC2CA0")]
		public static Id32<LocalVariables.M> BYCKZSJMYHK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3AC0", Offset = "0x2BC24C0", VA = "0x182BC3AC0")]
		public static Id32<LocalVariables.M> FZPSUBPPSTC(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6450", Offset = "0x2BC4E50", VA = "0x182BC6450")]
		public static Id32<LocalVariables.M> RQSKEYJRCOD(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC33D0", Offset = "0x2BC1DD0", VA = "0x182BC33D0")]
		public static Id32<LocalVariables.M> EIFQVRHIDQG(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3CC0", Offset = "0x2BC26C0", VA = "0x182BC3CC0")]
		public static Id32<LocalVariables.M> GJSICVEAVRH(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6C00", Offset = "0x2BC5600", VA = "0x182BC6C00")]
		public static Id32<LocalVariables.M> TLJSYSPDRPY(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6FB0", Offset = "0x2BC59B0", VA = "0x182BC6FB0")]
		public static Id32<LocalVariables.M> ULYCHXDTEZF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6980", Offset = "0x2BC5380", VA = "0x182BC6980")]
		public static Id32<LocalVariables.M> SKQXMTMWINL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC63D0", Offset = "0x2BC4DD0", VA = "0x182BC63D0")]
		public static Id32<LocalVariables.M> ROMQMXTXHXY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3550", Offset = "0x2BC1F50", VA = "0x182BC3550")]
		public static Id32<LocalVariables.M> EPYSIEMVWZV(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7CF0", Offset = "0x2BC66F0", VA = "0x182BC7CF0")]
		public static Id32<LocalVariables.M> YREPUEZFBRK(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2C20", Offset = "0x2BC1620", VA = "0x182BC2C20")]
		public static Id32<LocalVariables.M> BEMRCCWLZJJ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4D10", Offset = "0x2BC3710", VA = "0x182BC4D10")]
		public static Id32<LocalVariables.M> LFVDCKPAVNM(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC30D0", Offset = "0x2BC1AD0", VA = "0x182BC30D0")]
		public static Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> DNCKSKXWNNA(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7030", Offset = "0x2BC5A30", VA = "0x182BC7030")]
		public static Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> UONLEARSCYG(this FunctionCompileState a, int b)
		{
			return default(Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5BB0", Offset = "0x2BC45B0", VA = "0x182BC5BB0")]
		public static Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> NVURHZJFHVP(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4E90", Offset = "0x2BC3890", VA = "0x182BC4E90")]
		public static Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> LWCMOUMUEQP(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3B40", Offset = "0x2BC2540", VA = "0x182BC3B40")]
		public static Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> FZVLJSJVQDV(this FunctionCompileState a, int b)
		{
			return default(Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC70B0", Offset = "0x2BC5AB0", VA = "0x182BC70B0")]
		public static Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> VMKWIJOHTXG(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4870", Offset = "0x2BC3270", VA = "0x182BC4870")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.CKVBEOXUDGV>) KVDIHMJBRHX(this FunctionCompileState a, Id32<PSFHTYHJPFE> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.CKVBEOXUDGV>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5410", Offset = "0x2BC3E10", VA = "0x182BC5410")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.CKVBEOXUDGV>) MWTGIUYTTIL(this FunctionCompileState a, Id32<THWZKYKDWOE> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.CKVBEOXUDGV>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A410", Offset = "0x3B18E10", VA = "0x183B1A410")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<AWGGZWOVPWP>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<TMarker>>, Id32<FunctionCalls.M>) EIMSTPADMRW<TMarker>(this FunctionCompileState a, Id32<AWGGZWOVPWP> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<AWGGZWOVPWP>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC58B0", Offset = "0x2BC42B0", VA = "0x182BC58B0")]
		public static Id32<LocalVariables.M> NFBVIQZYBDA(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6C80", Offset = "0x2BC5680", VA = "0x182BC6C80")]
		public static Id32<LocalVariables.M> TXCANKGQWBL(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4300", Offset = "0x2BC2D00", VA = "0x182BC4300")]
		public static Id32<LocalVariables.M> IIWMTCGWOXY(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3EB0", Offset = "0x2BC28B0", VA = "0x182BC3EB0")]
		public static Id32<LocalVariables.M> IDFTPNJBGLH(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5C50", Offset = "0x2BC4650", VA = "0x182BC5C50")]
		public static Id32<LocalVariables.M> NXAIYSAWXZI(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5A90", Offset = "0x2BC4490", VA = "0x182BC5A90")]
		public static Id32<LocalVariables.M> NLAFBXJCDUV(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3900", Offset = "0x2BC2300", VA = "0x182BC3900")]
		public static Id32<LocalVariables.M> FJCWYXFPUDW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5E50", Offset = "0x2BC4850", VA = "0x182BC5E50")]
		public static Id32<LocalVariables.M> PGMTNZBZTFW(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC52F0", Offset = "0x2BC3CF0", VA = "0x182BC52F0")]
		public static Id32<LocalVariables.M> MQFYCXVVIQD(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7EB0", Offset = "0x2BC68B0", VA = "0x182BC7EB0")]
		public static Id32<LocalVariables.M> ZHHVFNBIBRA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3A40", Offset = "0x2BC2440", VA = "0x182BC3A40")]
		public static Id32<LocalVariables.M> FTBFKIQVQHX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7620", Offset = "0x2BC6020", VA = "0x182BC7620")]
		public static Id32<LocalVariables.M> WPOFMFFWGLU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3050", Offset = "0x2BC1A50", VA = "0x182BC3050")]
		public static Id32<LocalVariables.M> DEWXBWMBSYH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3800", Offset = "0x2BC2200", VA = "0x182BC3800")]
		public static Id32<LocalVariables.M> FGQTDCGMCKV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6730", Offset = "0x2BC5130", VA = "0x182BC6730")]
		public static Id32<LocalVariables.M> SCVCSHJVHRY(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC44F0", Offset = "0x2BC2EF0", VA = "0x182BC44F0")]
		public static Id32<LocalVariables.M> JZGRRBDWZPJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC61B0", Offset = "0x2BC4BB0", VA = "0x182BC61B0")]
		public static Id32<LocalVariables.M> QNSKQITWIPO(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4750", Offset = "0x2BC3150", VA = "0x182BC4750")]
		public static Id32<LocalVariables.M> KUFNUJRKQCP(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6E70", Offset = "0x2BC5870", VA = "0x182BC6E70")]
		public static Id32<LocalVariables.M> UIVKEWGPIRU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3E80", Offset = "0x2BC2880", VA = "0x182BC3E80")]
		public static Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>> HORCPVBPTGW(this FunctionCompileState a)
		{
			return default(Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC35D0", Offset = "0x2BC1FD0", VA = "0x182BC35D0")]
		public static Id32<LocalVariables.M> EYFBPRZJGCP(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC51D0", Offset = "0x2BC3BD0", VA = "0x182BC51D0")]
		public static Id32<LocalVariables.M> MEUFISDHXXK(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7D70", Offset = "0x2BC6770", VA = "0x182BC7D70")]
		public static Id32<LocalVariables.M> ZDACSRVGZCJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5D50", Offset = "0x2BC4750", VA = "0x182BC5D50")]
		public static Id32<LocalVariables.M> ONTEBSGHPNT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6090", Offset = "0x2BC4A90", VA = "0x182BC6090")]
		public static Id32<LocalVariables.M> QIDBWNCPDRQ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5090", Offset = "0x2BC3A90", VA = "0x182BC5090")]
		public static Id32<LocalVariables.M> LYCKXCOFUTV(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC43F0", Offset = "0x2BC2DF0", VA = "0x182BC43F0")]
		public static Id32<LocalVariables.M> JHNLWIEVFSS(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7290", Offset = "0x2BC5C90", VA = "0x182BC7290")]
		public static Id32<LocalVariables.M> VUXTLOQIWBL(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3EA0", Offset = "0x2BC28A0", VA = "0x182BC3EA0")]
		public static void HUQMOFJIWTO(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6A00", Offset = "0x2BC5400", VA = "0x182BC6A00")]
		public static Id32<LocalVariables.M> SVYWYRNIZBR(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4630", Offset = "0x2BC3030", VA = "0x182BC4630")]
		public static Id32<LocalVariables.M> KASLPVGKZMU(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5F50", Offset = "0x2BC4950", VA = "0x182BC5F50")]
		public static Id32<LocalVariables.M> PMDFIZERGPH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3450", Offset = "0x2BC1E50", VA = "0x182BC3450")]
		public static Id32<LocalVariables.M> EIYIERJRPYB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6860", Offset = "0x2BC5260", VA = "0x182BC6860")]
		public static Id32<LocalVariables.M> SFRSWVKKZTY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC73A0", Offset = "0x2BC5DA0", VA = "0x182BC73A0")]
		public static Id32<LocalVariables.M> WITRSMWPZOP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC77A0", Offset = "0x2BC61A0", VA = "0x182BC77A0")]
		public static Id32<LocalVariables.M> XUQWSTSGNBJ(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3BC0", Offset = "0x2BC25C0", VA = "0x182BC3BC0")]
		public static Id32<LocalVariables.M> GFKKQBMGDRS(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2BC64D0", Offset = "0x2BC4ED0", VA = "0x182BC64D0")]
		public static Id32<LocalVariables.M> RZSYMUUMMHB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3D40", Offset = "0x2BC2740", VA = "0x182BC3D40")]
		public static Id32<LocalVariables.M> GTUIRYIFVKK(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3B1BFE0", Offset = "0x3B1A9E0", VA = "0x183B1BFE0")]
		public static void RMICSNOPKXN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<PSFHTYHJPFE> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, SWOGATQYSMU<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3B1AD30", Offset = "0x3B19730", VA = "0x183B1AD30")]
		public static void KPIDNOGMFUN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<THWZKYKDWOE> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, SWOGATQYSMU<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B9D0", Offset = "0x3B1A3D0", VA = "0x183B1B9D0")]
		public static Id32<LocalVariables.M> OYWBTNAVXHZ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, SWOGATQYSMU<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B4C0", Offset = "0x3B19EC0", VA = "0x183B1B4C0")]
		public static Id32<LocalVariables.M> NLTEFWEYOGE<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, SWOGATQYSMU<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3B19FC0", Offset = "0x3B189C0", VA = "0x183B19FC0")]
		public static Id32<DataBackResults.M> BWUYWSSPOEN<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, SWOGATQYSMU<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3B1BCE0", Offset = "0x3B1A6E0", VA = "0x183B1BCE0")]
		public static Id32<ExecForwardResults.M> QJGUDDNRFTM<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, SWOGATQYSMU<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2DE0", Offset = "0x2BC17E0", VA = "0x182BC2DE0")]
		public static Id32<DataBackResults.M> CLHUANVYGVU(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3FD0", Offset = "0x2BC29D0", VA = "0x182BC3FD0")]
		public static Id32<DataBackResults.M> IGDJZPFHNMQ(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D190", Offset = "0x3B1BB90", VA = "0x183B1D190")]
		public static Id32<DataBackResults.M> XVASQQGBQXZ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<PSFHTYHJPFE> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, SWOGATQYSMU<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3B1CF20", Offset = "0x3B1B920", VA = "0x183B1CF20")]
		private static Id32<DataBackResults.M> XVASQQGBQXZ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<PSFHTYHJPFE> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, SWOGATQYSMU<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C770", Offset = "0x3B1B170", VA = "0x183B1C770")]
		public static Id32<LocalVariables.M> VNSJVEGTQOT<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, SWOGATQYSMU<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3B1CBC0", Offset = "0x3B1B5C0", VA = "0x183B1CBC0")]
		public static void VROMJKCIAFY<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, SWOGATQYSMU<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<EWICTHMTERF<QIRCDDDMPGO>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<EWICTHMTERF<QIRCDDDMPGO>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		public LiveInterval(Id32<EWICTHMTERF<QIRCDDDMPGO>> firstUse, Id32<EWICTHMTERF<QIRCDDDMPGO>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8550", Offset = "0x2BC6F50", VA = "0x182BC8550")]
		public static LiveInterval New(Id32<EWICTHMTERF<QIRCDDDMPGO>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class GIVDNFSBPHQ : ZFRRPWWWWFT
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
			[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class YHORRCZCYVI : ZFRRPWWWWFT
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class FPAERQIUWBH : ZFRRPWWWWFT
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
			[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
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
		public abstract class ZFRRPWWWWFT
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
			public Id32<ZFRRPWWWWFT> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8530", Offset = "0x2BC6F30", VA = "0x182BC8530")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<ZFRRPWWWWFT> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class SZOJBMMGWZK : ZFRRPWWWWFT
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<GIVDNFSBPHQ, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<FPAERQIUWBH, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<SZOJBMMGWZK, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<YHORRCZCYVI, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8750", Offset = "0x2BC7150", VA = "0x182BC8750")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<GIVDNFSBPHQ, ArgumentInst> argumentVariables, [In] SOAId32Field<FPAERQIUWBH, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<SZOJBMMGWZK, ParameterInst> parameterVariables, [In] SOAId32Field<YHORRCZCYVI, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8560", Offset = "0x2BC6F60", VA = "0x182BC8560")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class ZDBYHKOTKER
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BE0", Offset = "0x2BC85E0", VA = "0x182BC9BE0")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class EKQYXZQXDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF310", Offset = "0x2BBDD10", VA = "0x182BBF310")]
		public static void RAMOSTMOAVV(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.CKVBEOXUDGV, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF090", Offset = "0x2BBDA90", VA = "0x182BBF090")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.CKVBEOXUDGV, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF020", Offset = "0x2BBDA20", VA = "0x182BBF020")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2BBEE00", Offset = "0x2BBD800", VA = "0x182BBEE00")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x36D6700", Offset = "0x36D5100", VA = "0x1836D6700")]
		public static void RAMOSTMOAVV<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<JNHEPOTZQDV> graphId) where TDeps : notnull, SWOGATQYSMU<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class ZEDKJKNJWVQ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9C90", Offset = "0x2BC8690", VA = "0x182BC9C90")]
		public static void RAMOSTMOAVV(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface TCTDQVAUZMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void OBQWJMDPPRQ(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : TCTDQVAUZMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8B50", Offset = "0x2BC7550", VA = "0x182BC8B50", Slot = "4")]
			public void OBQWJMDPPRQ(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : TCTDQVAUZMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8BE0", Offset = "0x2BC75E0", VA = "0x182BC8BE0", Slot = "4")]
			public void OBQWJMDPPRQ(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : TCTDQVAUZMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8A10", Offset = "0x2BC7410", VA = "0x182BC8A10", Slot = "4")]
			public void OBQWJMDPPRQ(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : TCTDQVAUZMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8AA0", Offset = "0x2BC74A0", VA = "0x182BC8AA0", Slot = "4")]
			public void OBQWJMDPPRQ(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class WDAISOGTVFL<c> where c : struct, TCTDQVAUZMF
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c FHQCWCTTOJP;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x41C4520", Offset = "0x41C2F20", VA = "0x1841C4520")]
			public static int RAMOSTMOAVV<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : SWOGATQYSMU<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<FunctionCalls.CKVBEOXUDGV>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC84E0", Offset = "0x2BC6EE0", VA = "0x182BC84E0")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<FunctionCalls.CKVBEOXUDGV>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8430", Offset = "0x2BC6E30", VA = "0x182BC8430")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2BC83F0", Offset = "0x2BC6DF0", VA = "0x182BC83F0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B84C00", Offset = "0x3B83600", VA = "0x183B84C00")]
		public static void RAMOSTMOAVV<b, a>(FunctionCompileState a, b b, a c) where b : SWOGATQYSMU<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class VWFZEHUMYOH
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
		private static int TJHYOKLJYPN;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int IEWKQEZSBOR;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2BC94D0", Offset = "0x2BC7ED0", VA = "0x182BC94D0")]
		public static void RAMOSTMOAVV(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9170", Offset = "0x2BC7B70", VA = "0x182BC9170")]
		private static void OSWNHOWJETM([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9390", Offset = "0x2BC7D90", VA = "0x182BC9390")]
		private static void OSWNHOWJETM(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9A30", Offset = "0x2BC8430", VA = "0x182BC9A30")]
		private static void UTIDJUJNBVL(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class PQIXUQTPHNF<a, b, c> where a : struct, BDYKWFWXNKP<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a FHQCWCTTOJP;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x73EDC60", Offset = "0x73EC660", VA = "0x1873EDC60")]
		public static void RAMOSTMOAVV([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface BDYKWFWXNKP<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> FDBCVOORAIP(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WBAGNFNWQMV(a a, b b, Id32<EWICTHMTERF<CEGVXPWDZCF>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface REGHEVDCKXU<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a IFBAKMDRWMG(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BEQLPLYQXAE(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<EWICTHMTERF<CEGVXPWDZCF>> MNPQXFRGSAB(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class JEBOQXDBXLQ<a, b, c> where a : struct, REGHEVDCKXU<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a FHQCWCTTOJP;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x66D0060", Offset = "0x66CEA60", VA = "0x1866D0060")]
		public static UnsafeList<b> RAMOSTMOAVV(int a, [In] c values)
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
