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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B880D0", Offset = "0x2B870D0", VA = "0x182B880D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		public readonly Id32<NJHHKJCVQUE<SKRYMZOWBYC>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
		public ByteCodeAdjustment(Id32<NJHHKJCVQUE<SKRYMZOWBYC>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class ZQWSMXDQXOY : GXOJHSGVHBG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2B208D0", Offset = "0x2B1F8D0", VA = "0x182B208D0")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B86760", Offset = "0x2B85760", VA = "0x182B86760", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class HOWWESTMEKD : GXOJHSGVHBG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			public DeadEnd(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> nextByteCodePtr)
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
		public abstract class GXOJHSGVHBG
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
			public readonly Id32<GXOJHSGVHBG> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
			public Inst(Def def, Id32<GXOJHSGVHBG> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class VKORTVDHNDS : GXOJHSGVHBG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class HXFNPEWEFOK : GXOJHSGVHBG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x25DA170", Offset = "0x25D9170", VA = "0x1825DA170", Slot = "3")]
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
		internal IdUnsafeList<ZQWSMXDQXOY, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<HOWWESTMEKD, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<VKORTVDHNDS, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<HXFNPEWEFOK, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B869C0", Offset = "0x2B859C0", VA = "0x182B869C0")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<ZQWSMXDQXOY, BytesImmediate> bytesImmediates, [In] IdUnsafeList<HOWWESTMEKD, DeadEnd> deadEnds, [In] IdUnsafeList<VKORTVDHNDS, Variable> variables, [In] IdUnsafeList<HXFNPEWEFOK, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B86880", Offset = "0x2B85880", VA = "0x182B86880")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class CSGKMOSQMPR
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B867D0", Offset = "0x2B857D0", VA = "0x182B867D0")]
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
		public sealed class GVABHLIHCQP : GXOJHSGVHBG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
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
		public abstract class GXOJHSGVHBG
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
			public readonly Id32<GXOJHSGVHBG> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
			public Inst(Def def, Id32<GXOJHSGVHBG> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<GVABHLIHCQP, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B86AE0", Offset = "0x2B85AE0", VA = "0x182B86AE0")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<GVABHLIHCQP, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B86A50", Offset = "0x2B85A50", VA = "0x182B86A50")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class BAACWTMBMOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B86700", Offset = "0x2B85700", VA = "0x182B86700")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B86BC0", Offset = "0x2B85BC0", VA = "0x182B86BC0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B86B20", Offset = "0x2B85B20", VA = "0x182B86B20")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class WECCIJJBFYD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BD80", Offset = "0x2B8AD80", VA = "0x182B8BD80")]
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
		public sealed class OEJIVUTSNEX : GXOJHSGVHBG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<IZEHGWKFPMM> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			public ExternalCall(Id32<IZEHGWKFPMM> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class GXOJHSGVHBG
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
			public readonly Id32<GXOJHSGVHBG> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
			private Inst(Def def, Id32<GXOJHSGVHBG> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B87D70", Offset = "0x2B86D70", VA = "0x182B87D70")]
			public static Inst New(Def def, Id32<GXOJHSGVHBG> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class VJIOONLWAJH : GXOJHSGVHBG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<IZEHGWKFPMM> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			public InternalCall(Id32<IZEHGWKFPMM> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class IZEHGWKFPMM
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
			[Cpp2IlInjected.Address(RVA = "0x2B86AE0", Offset = "0x2B85AE0", VA = "0x182B86AE0")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B87BC0", Offset = "0x2B86BC0", VA = "0x182B87BC0")]
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
		internal IdUnsafeList<VJIOONLWAJH, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<OEJIVUTSNEX, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<IZEHGWKFPMM> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<IZEHGWKFPMM, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B86DC0", Offset = "0x2B85DC0", VA = "0x182B86DC0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<VJIOONLWAJH, InternalCall> internalCalls, [In] IdUnsafeList<OEJIVUTSNEX, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<IZEHGWKFPMM> IOId)> callsWithIO, [In] IdUnsafeList<IZEHGWKFPMM, IO> io, [In] SOAField<IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> ioModifyingCallLocations, [In] SOAField<IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B86C20", Offset = "0x2B85C20", VA = "0x182B86C20")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class QPCJLOFHVVP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B88FA0", Offset = "0x2B87FA0", VA = "0x182B88FA0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B88FF0", Offset = "0x2B87FF0", VA = "0x182B88FF0")]
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
		internal SOAField<GVZPIOKFAXL, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<GVZPIOKFAXL>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B87810", Offset = "0x2B86810", VA = "0x182B87810")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<GVZPIOKFAXL, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<GVZPIOKFAXL>> generatedOutputsForExpression, [In] SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B86E80", Offset = "0x2B85E80", VA = "0x182B86E80")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class UYSLZIRDRKO
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : QJTQATQNDOV<Id32<FunctionCalls.IZEHGWKFPMM>, SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B892B0", Offset = "0x2B882B0", VA = "0x182B892B0")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B89340", Offset = "0x2B88340", VA = "0x182B89340", Slot = "4")]
			public Id32<FunctionCalls.IZEHGWKFPMM> PGAHLLZHPJP(int a)
			{
				return default(Id32<FunctionCalls.IZEHGWKFPMM>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210")]
			public bool FUICVJEQTKT(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "5")]
			private bool KJGNDQYHFVF(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B89330", Offset = "0x2B88330", VA = "0x182B89330", Slot = "6")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> OXCWQLYNOEK(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : PTQDBBOFQEQ<Id32<FunctionCalls.IZEHGWKFPMM>, SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B85890", Offset = "0x2B84890", VA = "0x182B85890")]
			public UnsafeList<Id32<FunctionCalls.IZEHGWKFPMM>> CUBLTLICNOG(int a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.IZEHGWKFPMM>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B85900", Offset = "0x2B84900", VA = "0x182B85900")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B85980", Offset = "0x2B84980", VA = "0x182B85980", Slot = "6")]
			public void EVUABQUWWDI(Id32<FunctionCalls.IZEHGWKFPMM> a, SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> b, Id32<NJHHKJCVQUE<SKRYMZOWBYC>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B85890", Offset = "0x2B84890", VA = "0x182B85890", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.IZEHGWKFPMM>> XYHJSBNZLVX(int a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.IZEHGWKFPMM>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B85A20", Offset = "0x2B84A20", VA = "0x182B85A20", Slot = "5")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> UCLPEDSUBWP(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : QJTQATQNDOV<Id32<FunctionCalls.IZEHGWKFPMM>, SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B89380", Offset = "0x2B88380", VA = "0x182B89380")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B89410", Offset = "0x2B88410", VA = "0x182B89410", Slot = "4")]
			public Id32<FunctionCalls.IZEHGWKFPMM> PGAHLLZHPJP(int a)
			{
				return default(Id32<FunctionCalls.IZEHGWKFPMM>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210")]
			public bool FUICVJEQTKT(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "5")]
			private bool YKJPEBPTFZK(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B89400", Offset = "0x2B88400", VA = "0x182B89400", Slot = "6")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> KTGQFCRCSKN(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : PTQDBBOFQEQ<Id32<FunctionCalls.IZEHGWKFPMM>, SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B85A30", Offset = "0x2B84A30", VA = "0x182B85A30")]
			public UnsafeList<Id32<FunctionCalls.IZEHGWKFPMM>> CUBLTLICNOG(int a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.IZEHGWKFPMM>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B85AA0", Offset = "0x2B84AA0", VA = "0x182B85AA0")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B85B20", Offset = "0x2B84B20", VA = "0x182B85B20", Slot = "6")]
			public void EVUABQUWWDI(Id32<FunctionCalls.IZEHGWKFPMM> a, SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> b, Id32<NJHHKJCVQUE<SKRYMZOWBYC>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B85A30", Offset = "0x2B84A30", VA = "0x182B85A30", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.IZEHGWKFPMM>> SVGIMYZNFDQ(int a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.IZEHGWKFPMM>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B85BC0", Offset = "0x2B84BC0", VA = "0x182B85BC0", Slot = "5")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> XZCBWIMHYKC(Id32<FunctionCalls.IZEHGWKFPMM> a, [In] SOAField<FunctionCalls.IZEHGWKFPMM, Id32<NJHHKJCVQUE<RXCTQXXFICO>>> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : QJTQATQNDOV<Id32<DRWFHSZKMVW>, SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2B89450", Offset = "0x2B88450", VA = "0x182B89450")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(Id32<DRWFHSZKMVW> a, [In] SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2B89560", Offset = "0x2B88560", VA = "0x182B89560", Slot = "4")]
			public Id32<DRWFHSZKMVW> PGAHLLZHPJP(int a)
			{
				return default(Id32<DRWFHSZKMVW>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B89500", Offset = "0x2B88500", VA = "0x182B89500")]
			public bool FUICVJEQTKT(Id32<DRWFHSZKMVW> a, [In] SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B89500", Offset = "0x2B88500", VA = "0x182B89500", Slot = "5")]
			private bool RBTMNWVJLAK(Id32<DRWFHSZKMVW> a, [In] SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B895A0", Offset = "0x2B885A0", VA = "0x182B895A0", Slot = "6")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> VNRTSJDQBGX(Id32<DRWFHSZKMVW> a, [In] SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : PTQDBBOFQEQ<Id32<DRWFHSZKMVW>, SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2B85BD0", Offset = "0x2B84BD0", VA = "0x182B85BD0")]
			public UnsafeList<Id32<DRWFHSZKMVW>> CUBLTLICNOG(int a, [In] SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> values)
			{
				return default(UnsafeList<Id32<DRWFHSZKMVW>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B85C40", Offset = "0x2B84C40", VA = "0x182B85C40")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(Id32<DRWFHSZKMVW> a, [In] SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B85CF0", Offset = "0x2B84CF0", VA = "0x182B85CF0", Slot = "6")]
			public void EVUABQUWWDI(Id32<DRWFHSZKMVW> a, SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> b, Id32<NJHHKJCVQUE<SKRYMZOWBYC>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B85BD0", Offset = "0x2B84BD0", VA = "0x182B85BD0", Slot = "4")]
			private UnsafeList<Id32<DRWFHSZKMVW>> JETTUIPTKMQ(int a, [In] SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> values)
			{
				return default(UnsafeList<Id32<DRWFHSZKMVW>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B85DF0", Offset = "0x2B84DF0", VA = "0x182B85DF0", Slot = "5")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> KVALPQUJIMM(Id32<DRWFHSZKMVW> a, [In] SOAField<DRWFHSZKMVW, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>?> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : QJTQATQNDOV<int, UnsafeList<(Id32<LocalVariables.M>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2B896F0", Offset = "0x2B886F0", VA = "0x182B896F0")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xCAD580", Offset = "0xCAC580", VA = "0x180CAD580", Slot = "4")]
			public int PGAHLLZHPJP(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210")]
			public bool FUICVJEQTKT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "5")]
			private bool SBUGGBGYSTB(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B89780", Offset = "0x2B88780", VA = "0x182B89780", Slot = "6")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> VJYHXKRZLFI(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : PTQDBBOFQEQ<int, UnsafeList<(Id32<LocalVariables.M>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B86220", Offset = "0x2B85220", VA = "0x182B86220")]
			public UnsafeList<int> CUBLTLICNOG(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B86290", Offset = "0x2B85290", VA = "0x182B86290")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B86320", Offset = "0x2B85320", VA = "0x182B86320", Slot = "6")]
			public void EVUABQUWWDI(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> values, Id32<NJHHKJCVQUE<SKRYMZOWBYC>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B86220", Offset = "0x2B85220", VA = "0x182B86220", Slot = "4")]
			private UnsafeList<int> MJXXDUMTJIL(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B86420", Offset = "0x2B85420", VA = "0x182B86420", Slot = "5")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> WXFZBKJEMER(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<NJHHKJCVQUE<XPYIVJGMLOO<SKRYMZOWBYC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : QJTQATQNDOV<int, UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2B89650", Offset = "0x2B88650", VA = "0x182B89650")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCAD580", Offset = "0xCAC580", VA = "0x180CAD580", Slot = "4")]
			public int PGAHLLZHPJP(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210")]
			public bool FUICVJEQTKT(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "5")]
			private bool HDSIJQOJWKG(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B896E0", Offset = "0x2B886E0", VA = "0x182B896E0", Slot = "6")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> MPUIQEQLAGH(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : PTQDBBOFQEQ<int, UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2B86010", Offset = "0x2B85010", VA = "0x182B86010")]
			public UnsafeList<int> CUBLTLICNOG(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B86080", Offset = "0x2B85080", VA = "0x182B86080")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B86110", Offset = "0x2B85110", VA = "0x182B86110", Slot = "6")]
			public void EVUABQUWWDI(int a, UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values, Id32<NJHHKJCVQUE<SKRYMZOWBYC>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B86010", Offset = "0x2B85010", VA = "0x182B86010", Slot = "4")]
			private UnsafeList<int> XGJQEPCCEPU(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B86210", Offset = "0x2B85210", VA = "0x182B86210", Slot = "5")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> SQJSMPOCILA(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : QJTQATQNDOV<int, UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2B895B0", Offset = "0x2B885B0", VA = "0x182B895B0")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xCAD580", Offset = "0xCAC580", VA = "0x180CAD580", Slot = "4")]
			public int PGAHLLZHPJP(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210")]
			public bool FUICVJEQTKT(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "5")]
			private bool HDSIJQOJWKG(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2B89640", Offset = "0x2B88640", VA = "0x182B89640", Slot = "6")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> MPUIQEQLAGH(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : PTQDBBOFQEQ<int, UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2B85E00", Offset = "0x2B84E00", VA = "0x182B85E00")]
			public UnsafeList<int> CUBLTLICNOG(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B85E70", Offset = "0x2B84E70", VA = "0x182B85E70")]
			public Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B85F00", Offset = "0x2B84F00", VA = "0x182B85F00", Slot = "6")]
			public void EVUABQUWWDI(int a, UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values, Id32<NJHHKJCVQUE<SKRYMZOWBYC>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B85E00", Offset = "0x2B84E00", VA = "0x182B85E00", Slot = "4")]
			private UnsafeList<int> XGJQEPCCEPU(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B86000", Offset = "0x2B85000", VA = "0x182B86000", Slot = "5")]
			private Id32<NJHHKJCVQUE<SKRYMZOWBYC>> SQJSMPOCILA(int a, [In] UnsafeList<(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> Target, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
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
			[Cpp2IlInjected.Address(RVA = "0x2269D80", Offset = "0x2268D80", VA = "0x182269D80")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B87BB0", Offset = "0x2B86BB0", VA = "0x182B87BB0")]
			public void ZFXAJJHVNLN([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<DRWFHSZKMVW> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B87B90", Offset = "0x2B86B90", VA = "0x182B87B90")]
			public GenerateDataBackFromInputIndexResult(Id32<DRWFHSZKMVW> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B87B80", Offset = "0x2B86B80", VA = "0x182B87B80")]
			public void ZFXAJJHVNLN([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B87B60", Offset = "0x2B86B60", VA = "0x182B87B60")]
			public void ZFXAJJHVNLN([Out] Id32<DataBackResults.M> a, [Out] Id32<DRWFHSZKMVW> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<DRWFHSZKMVW> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
			public GenerateDataBackFromInputIndicesResult(Id32<DRWFHSZKMVW> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B87BA0", Offset = "0x2B86BA0", VA = "0x182B87BA0")]
			public void ZFXAJJHVNLN([Out] Id32<DataBackResults.M> a, [Out] Id32<DRWFHSZKMVW> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B89CC0", Offset = "0x2B88CC0", VA = "0x182B89CC0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BAA0", Offset = "0x2B8AAA0", VA = "0x182B8BAA0")]
		public static void VPGVVBBISDG(this FunctionCompileState a, Id32<GVZPIOKFAXL> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B2A0", Offset = "0x2B8A2A0", VA = "0x182B8B2A0")]
		public static void RYJAWSPRGSG(this FunctionCompileState a, Id32<GVZPIOKFAXL> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B899C0", Offset = "0x2B889C0", VA = "0x182B899C0")]
		public static Id32<DataBackResults.M>? BLDSDAXRYPZ([In] this FunctionCompileState self, Id32<GVZPIOKFAXL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AD40", Offset = "0x2B89D40", VA = "0x182B8AD40")]
		public static Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> ONPWTRLCTPF([In] this FunctionCompileState self)
		{
			return default(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B650", Offset = "0x2B8A650", VA = "0x182B8B650")]
		private static void UTFQKZDZVUQ(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B89B50", Offset = "0x2B88B50", VA = "0x182B89B50")]
		private static Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>? CSPUBWKFOIP([In] this FunctionCompileState self, Id32<DRWFHSZKMVW> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B830", Offset = "0x2B8A830", VA = "0x182B8B830")]
		public static void UZSDLBCZEML(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B89BD0", Offset = "0x2B88BD0", VA = "0x182B89BD0")]
		public static DataBackResults.Def CZYHRGTGFKT([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A450", Offset = "0x2B89450", VA = "0x182B8A450")]
		public static ReadOnlyArray<byte> HYSEVNNUSUX([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A8F0", Offset = "0x2B898F0", VA = "0x182B8A8F0")]
		public static Id32<LocalVariables.M> LZXTNJDMIAR([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B89F90", Offset = "0x2B88F90", VA = "0x182B89F90")]
		public static Union32 EQFYDZTUOTP([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5B40", Offset = "0x3EF4B40", VA = "0x183EF5B40")]
		private static Id32<DataBackResults.M> JEZVYABAMMK<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.GXOJHSGVHBG
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B89AD0", Offset = "0x2B88AD0", VA = "0x182B89AD0")]
		public static Id32<DataBackResults.M> CQLFUXLZYLC(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A3C0", Offset = "0x2B893C0", VA = "0x182B8A3C0")]
		public static Id32<DataBackResults.M> HRLHLHECBKX(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BA20", Offset = "0x2B8AA20", VA = "0x182B8BA20")]
		public static Id32<DataBackResults.M> VPCVAABILGW(this FunctionCompileState a, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B9A0", Offset = "0x2B8A9A0", VA = "0x182B8B9A0")]
		public static Id32<DataBackResults.M> VHRWNAOGPYE(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B89C40", Offset = "0x2B88C40", VA = "0x182B89C40")]
		public static Id32<DataBackResults.M> DOYDSIIXAHV(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7AC0", Offset = "0x3EF6AC0", VA = "0x183EF7AC0")]
		private static Id32<ExecForwardResults.M> TCOLIMCXLNH<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.GXOJHSGVHBG
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BB30", Offset = "0x2B8AB30", VA = "0x182B8BB30")]
		public static Id32<ExecForwardResults.M> VXEQIYWVIQT(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A6E0", Offset = "0x2B896E0", VA = "0x182B8A6E0")]
		public static Id32<ExecForwardResults.M> KHXIFFBYSDK(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B540", Offset = "0x2B8A540", VA = "0x182B8B540")]
		public static Id32<ExecForwardResults.M> UJRXOKUWAQY(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ACF0", Offset = "0x2B89CF0", VA = "0x182B8ACF0")]
		public static Id32<ExecForwardResults.M> NWBSRJYENXP(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BD30", Offset = "0x2B8AD30", VA = "0x182B8BD30")]
		public static Id32<ExecForwardResults.M> YSEAJXNNYYF(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B370", Offset = "0x2B8A370", VA = "0x182B8B370")]
		public static FunctionCalls.Def STZTYPYBVUO([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B7F0", Offset = "0x2B8A7F0", VA = "0x182B8B7F0")]
		public static CopyEnumerable<Id32<FunctionCalls.IZEHGWKFPMM>, Id32Enumerator<FunctionCalls.IZEHGWKFPMM>> UYGJIHSMIRN([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.IZEHGWKFPMM>, Id32Enumerator<FunctionCalls.IZEHGWKFPMM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B897F0", Offset = "0x2B887F0", VA = "0x182B897F0")]
		public static Id32<FunctionCalls.IZEHGWKFPMM> BEDPETQNULY([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.IZEHGWKFPMM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AA20", Offset = "0x2B89A20", VA = "0x182B8AA20")]
		public static FunctionCalls.IO MQMENZIPACX([In] this FunctionCompileState self, Id32<FunctionCalls.IZEHGWKFPMM> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A0C0", Offset = "0x2B890C0", VA = "0x182B8A0C0")]
		public static FunctionCalls.IO GIZNODKHCJR(this FunctionCompileState a, Id32<FunctionCalls.IZEHGWKFPMM> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5BE0", Offset = "0x3EF4BE0", VA = "0x183EF5BE0")]
		private static Id32<FunctionCalls.M> JTQHYKOUZBC<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.GXOJHSGVHBG
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A530", Offset = "0x2B89530", VA = "0x182B8A530")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.IZEHGWKFPMM>) KCCXVWFMNMZ(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.IZEHGWKFPMM>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ADA0", Offset = "0x2B89DA0", VA = "0x182B8ADA0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.IZEHGWKFPMM>) REMIGQINHQD(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.IZEHGWKFPMM>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A070", Offset = "0x2B89070", VA = "0x182B8A070")]
		public static Id32<FunctionCalls.M> EUHWYBYJCAU(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B060", Offset = "0x2B8A060", VA = "0x182B8B060")]
		public static void RSEECNUNRLL(this FunctionCompileState a, Id32<FunctionCalls.IZEHGWKFPMM> b, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> c, Id32<NJHHKJCVQUE<RXCTQXXFICO>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5C70", Offset = "0x3EF4C70", VA = "0x183EF5C70")]
		public static GenerateDataBackResult MWIOJAYCCCR<d, e>(this FunctionCompileState a, d b, e c, Id32<LNVRVOESCOU> d, Id32<DRWFHSZKMVW> e) where d : XSBPVWOYINP<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3EF56E0", Offset = "0x3EF46E0", VA = "0x183EF56E0")]
		public static GenerateDataBackFromInputIndexResult HFWIYAOOPBD<f, g>(this FunctionCompileState a, f b, g c, Id32<LNVRVOESCOU> d, Id32<GOPNEBMAEKM> e, int f) where f : XSBPVWOYINP<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7B60", Offset = "0x3EF6B60", VA = "0x183EF7B60")]
		public static Id32<DataBackResults.M>? TMPVJXHFHGA<h, i>(this FunctionCompileState a, h b, i c, Id32<LNVRVOESCOU> d, Id32<GOPNEBMAEKM> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : XSBPVWOYINP<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7280", Offset = "0x3EF6280", VA = "0x183EF7280")]
		public static Id32<ExecForwardResults.M> RLMMYPNJCXK<j, k>(this FunctionCompileState a, j b, k c, Id32<LNVRVOESCOU> d, Id32<GVZPIOKFAXL> e) where j : XSBPVWOYINP<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B430", Offset = "0x2B8A430", VA = "0x182B8B430")]
		public static LocalVariables.ArgumentInst TYQWQCAWFAM([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A130", Offset = "0x2B89130", VA = "0x182B8A130")]
		public static LocalVariables.CalleeReturnValueInst GOSKDOYNJZG([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A7E0", Offset = "0x2B897E0", VA = "0x182B8A7E0")]
		public static LocalVariables.CallerReturnValueInst KYDTEJROPMH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B0F0", Offset = "0x2B8A0F0", VA = "0x182B8B0F0")]
		public static Id32<LocalVariables.M> RUULAFFLCBT(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AF50", Offset = "0x2B89F50", VA = "0x182B8AF50")]
		public static LocalVariables.ParameterInst RHSWYFRIUBE([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A9D0", Offset = "0x2B899D0", VA = "0x182B8A9D0")]
		public static LocalVariables.Def MMDXJDCTEJM([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B3E0", Offset = "0x2B8A3E0", VA = "0x182B8B3E0")]
		public static int? TNTZLPDLEJG([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3EF80D0", Offset = "0x3EF70D0", VA = "0x183EF80D0")]
		private static Id32<LocalVariables.M> YBBFLBVLSUI<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.GXOJHSGVHBG
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A730", Offset = "0x2B89730", VA = "0x182B8A730")]
		public static Id32<LocalVariables.M> KYBOYLFLQEK(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B89790", Offset = "0x2B88790", VA = "0x182B89790")]
		public static Id32<LocalVariables.M> AVMZDCYFXJH(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AA90", Offset = "0x2B89A90", VA = "0x182B8AA90")]
		public static Id32<LocalVariables.M> MSZOVRVLTGL(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B5C0", Offset = "0x2B8A5C0", VA = "0x182B8B5C0")]
		public static Id32<LocalVariables.M> URVGJINAHVR(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A360", Offset = "0x2B89360", VA = "0x182B8A360")]
		public static Id32<LocalVariables.M> HQCUKBFUHNZ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A240", Offset = "0x2B89240", VA = "0x182B8A240")]
		public static void GXOUMMIARBG(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BC20", Offset = "0x2B8AC20", VA = "0x182B8BC20")]
		public static void XBQUUQWKTLW(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BB70", Offset = "0x2B8AB70", VA = "0x182B8BB70")]
		public static void WLISUBNPXLG(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B89A40", Offset = "0x2B88A40", VA = "0x182B89A40")]
		public static void BNIMGYTOKMX(this FunctionCompileState a, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> b, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AC10", Offset = "0x2B89C10", VA = "0x182B8AC10")]
		public static void NPZRIHXWDKP(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<NJHHKJCVQUE<DPDSUAEABLQ>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF71A0", Offset = "0x3EF61A0", VA = "0x183EF71A0")]
		public static void RIRVCYWRISA<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<NJHHKJCVQUE<XPYIVJGMLOO<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface XSBPVWOYINP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<BFTZGTVHZPK> CQTCNIASZTY(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<BFTZGTVHZPK> OULHQQAOUAP(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<BFTZGTVHZPK> CWSEJILEHVC(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<BFTZGTVHZPK> ADAHTKAEOTZ(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> CKQNTVDSNOR(a a, FunctionCompileState b, Id32<LNVRVOESCOU> c, Id32<DRWFHSZKMVW> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> MWKLBHGVYAH(a a, FunctionCompileState b, Id32<LNVRVOESCOU> c, Id32<GVZPIOKFAXL> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int HAWRFRENKWX(a a, Id32<LNVRVOESCOU> b, Id32<DRWFHSZKMVW> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<GVZPIOKFAXL> ZOZBHCQELWA(a a, Id32<LNVRVOESCOU> b, Id32<DRWFHSZKMVW> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind PCWAEACVXBT(a a, Id32<LNVRVOESCOU> b, Id32<DRWFHSZKMVW> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool NBSTOHJHSWC(a a, Id32<LNVRVOESCOU> b, Id32<DRWFHSZKMVW> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int RQTOPXJPMYD(a a, Id32<LNVRVOESCOU> b, Id32<DRWFHSZKMVW> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> IUYNXYKQLZT(a a, Id32<LNVRVOESCOU> b, Id32<DRWFHSZKMVW> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<BFTZGTVHZPK>) CHEKMEZUWBZ(a a, Id32<LNVRVOESCOU> b, Id32<DRWFHSZKMVW> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int SCTATVVEZCZ(a a, Id32<LNVRVOESCOU> b, Id32<GVZPIOKFAXL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<DRWFHSZKMVW> YTICVZGXEEI(a a, Id32<LNVRVOESCOU> b, Id32<GVZPIOKFAXL> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<DRWFHSZKMVW> RPCOJQQXHSR(a a, Id32<LNVRVOESCOU> b, Id32<GOPNEBMAEKM> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int UPWIDATUGWN(a a, Id32<LNVRVOESCOU> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? USIEMWXKZVH(a a, Id32<LNVRVOESCOU> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int TTWVRFTSBYD(a a, Id32<LNVRVOESCOU> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? XTVSCDQRZCD(a a, Id32<LNVRVOESCOU> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class XXGXRMYBVKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BB50", Offset = "0x3F5AB50", VA = "0x183F5BB50")]
		public static Id32<LocalVariables.M?> QIPNRJXAOLR<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B770", Offset = "0x3F5A770", VA = "0x183F5B770")]
		public static Id32<LocalVariables.M?> PTJQHXYCCIO<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F5AB40", Offset = "0x3F59B40", VA = "0x183F5AB40")]
		public static Id32<LocalVariables.M?> LNDQCKCIZHJ<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EDA0", Offset = "0x2B8DDA0", VA = "0x182B8EDA0")]
		public static Id32<LocalVariables.M> OIVORMJTITX(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B90690", Offset = "0x2B8F690", VA = "0x182B90690")]
		public static Id32<LocalVariables.M> UVIQKUOLNHA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA10", Offset = "0x2B8DA10", VA = "0x182B8EA10")]
		public static Id32<LocalVariables.M> NQCRWVWZCZB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D150", Offset = "0x2B8C150", VA = "0x182B8D150")]
		public static Id32<LocalVariables.M> GHSIJZUZXJN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D950", Offset = "0x2B8C950", VA = "0x182B8D950")]
		public static Id32<LocalVariables.M> IXZDVBBEHZG(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F400", Offset = "0x2B8E400", VA = "0x182B8F400")]
		public static Id32<LocalVariables.M> PVSLLXLYUCB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E7E0", Offset = "0x2B8D7E0", VA = "0x182B8E7E0")]
		public static Id32<LocalVariables.M> MQBRBVRSXTD(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C250", Offset = "0x2B8B250", VA = "0x182B8C250")]
		public static Id32<LocalVariables.M> AZMZMKPPSIS(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B90110", Offset = "0x2B8F110", VA = "0x182B90110")]
		public static Id32<LocalVariables.M> SEMTDASTEQX(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C010", Offset = "0x2B8B010", VA = "0x182B8C010")]
		public static Id32<LocalVariables.M> ALTODZFIDLU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FB90", Offset = "0x2B8EB90", VA = "0x182B8FB90")]
		public static Id32<LocalVariables.M> QHRMGAMSZGJ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BDD0", Offset = "0x2B8ADD0", VA = "0x182B8BDD0")]
		public static Id32<LocalVariables.M> ACPDJQGAGFW(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D050", Offset = "0x2B8C050", VA = "0x182B8D050")]
		public static Id32<LocalVariables.M> ESCIJEZYVED(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F540", Offset = "0x2B8E540", VA = "0x182B8F540")]
		public static Id32<LocalVariables.M> QDZDWBERXZS(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CB40", Offset = "0x2B8BB40", VA = "0x182B8CB40")]
		public static Id32<LocalVariables.M> DJTYDBAHZEF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CC80", Offset = "0x2B8BC80", VA = "0x182B8CC80")]
		public static Id32<LocalVariables.M> DMWOYHGUMNF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FB10", Offset = "0x2B8EB10", VA = "0x182B8FB10")]
		public static Id32<LocalVariables.M> QEPVGHZDEEI(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F2E0", Offset = "0x2B8E2E0", VA = "0x182B8F2E0")]
		public static Id32<LocalVariables.M> PCLJMMQMLEN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D690", Offset = "0x2B8C690", VA = "0x182B8D690")]
		public static Id32<LocalVariables.M> IFMURZSPCPY(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CF50", Offset = "0x2B8BF50", VA = "0x182B8CF50")]
		public static Id32<LocalVariables.M> EINVWOPJBWR(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E010", Offset = "0x2B8D010", VA = "0x182B8E010")]
		public static Id32<LocalVariables.M> JQIXPRIQIAA(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C880", Offset = "0x2B8B880", VA = "0x182B8C880")]
		public static Id32<LocalVariables.M> CSTMMFTUSUE(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EFA0", Offset = "0x2B8DFA0", VA = "0x182B8EFA0")]
		public static Id32<LocalVariables.M> ONSWAGDSYJJ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D790", Offset = "0x2B8C790", VA = "0x182B8D790")]
		public static Id32<LocalVariables.M> ILTRIAPWCBU(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B907B0", Offset = "0x2B8F7B0", VA = "0x182B907B0")]
		public static Id32<LocalVariables.M> UXCMGHTUVQN(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E250", Offset = "0x2B8D250", VA = "0x182B8E250")]
		public static Id32<LocalVariables.M> LGSAIBWRPPM(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CFD0", Offset = "0x2B8BFD0", VA = "0x182B8CFD0")]
		public static Id32<LocalVariables.M> EPFLYNHMUTV(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C470", Offset = "0x2B8B470", VA = "0x182B8C470")]
		public static Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> BKYBODDNWVT(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D710", Offset = "0x2B8C710", VA = "0x182B8D710")]
		public static Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> IGUTXEWJLWB(this FunctionCompileState a, int b)
		{
			return default(Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F360", Offset = "0x2B8E360", VA = "0x182B8F360")]
		public static Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> PJTMWYINVMG(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D370", Offset = "0x2B8C370", VA = "0x182B8D370")]
		public static Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> HQLFPHYYOIS(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B91150", Offset = "0x2B90150", VA = "0x182B91150")]
		public static Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> ZGJOAHGWHXQ(this FunctionCompileState a, int b)
		{
			return default(Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B90A40", Offset = "0x2B8FA40", VA = "0x182B90A40")]
		public static Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> WIBJGPHIGFP(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F670", Offset = "0x2B8E670", VA = "0x182B8F670")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.IZEHGWKFPMM>) QEBWWZKJCMW(this FunctionCompileState a, Id32<DMXLEVIULSD> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.IZEHGWKFPMM>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA70", Offset = "0x2B8CA70", VA = "0x182B8DA70")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.IZEHGWKFPMM>) JGODAKLKEEM(this FunctionCompileState a, Id32<MCZYZSSYBNX> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.IZEHGWKFPMM>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D540", Offset = "0x3F5C540", VA = "0x183F5D540")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<BFTZGTVHZPK>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<TMarker>>, Id32<FunctionCalls.M>) YPKCONDJNGX<TMarker>(this FunctionCompileState a, Id32<BFTZGTVHZPK> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<BFTZGTVHZPK>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E2D0", Offset = "0x2B8D2D0", VA = "0x182B8E2D0")]
		public static Id32<LocalVariables.M> LRYYIWJQCTB(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B911D0", Offset = "0x2B901D0", VA = "0x182B911D0")]
		public static Id32<LocalVariables.M> ZXQKMDBJUDS(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C790", Offset = "0x2B8B790", VA = "0x182B8C790")]
		public static Id32<LocalVariables.M> BXFEFGRWOVT(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D250", Offset = "0x2B8C250", VA = "0x182B8D250")]
		public static Id32<LocalVariables.M> HDXSBAZFNBI(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F020", Offset = "0x2B8E020", VA = "0x182B8F020")]
		public static Id32<LocalVariables.M> ORBAGPVYUQB(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E6C0", Offset = "0x2B8D6C0", VA = "0x182B8E6C0")]
		public static Id32<LocalVariables.M> MIZQXTZRKPA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CA00", Offset = "0x2B8BA00", VA = "0x182B8CA00")]
		public static Id32<LocalVariables.M> CWIXKRNTWGT(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BF10", Offset = "0x2B8AF10", VA = "0x182B8BF10")]
		public static Id32<LocalVariables.M> AGKPEOBXEQX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C670", Offset = "0x2B8B670", VA = "0x182B8C670")]
		public static Id32<LocalVariables.M> BWMYBTCXNEM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FDB0", Offset = "0x2B8EDB0", VA = "0x182B8FDB0")]
		public static Id32<LocalVariables.M> QLBEODAPHLX(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B90390", Offset = "0x2B8F390", VA = "0x182B90390")]
		public static Id32<LocalVariables.M> SZTKWZDCEUM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E1D0", Offset = "0x2B8D1D0", VA = "0x182B8E1D0")]
		public static Id32<LocalVariables.M> LDRNAJTRZSD(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F260", Offset = "0x2B8E260", VA = "0x182B8F260")]
		public static Id32<LocalVariables.M> OYUYYUQTSUO(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EB50", Offset = "0x2B8DB50", VA = "0x182B8EB50")]
		public static Id32<LocalVariables.M> NQCUTEPGXKO(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CE20", Offset = "0x2B8BE20", VA = "0x182B8CE20")]
		public static Id32<LocalVariables.M> EDVTTMUKCCN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C110", Offset = "0x2B8B110", VA = "0x182B8C110")]
		public static Id32<LocalVariables.M> AXBPVAPLQUA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B90830", Offset = "0x2B8F830", VA = "0x182B90830")]
		public static Id32<LocalVariables.M> VYBRTGATBET(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B90410", Offset = "0x2B8F410", VA = "0x182B90410")]
		public static Id32<LocalVariables.M> UEQMSWGDNKI(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B90250", Offset = "0x2B8F250", VA = "0x182B90250")]
		public static Id32<LocalVariables.M> SSOPJBFIPYV(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B90530", Offset = "0x2B8F530", VA = "0x182B90530")]
		public static Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>> UHJNQRIVUZB(this FunctionCompileState a)
		{
			return default(Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EEA0", Offset = "0x2B8DEA0", VA = "0x182B8EEA0")]
		public static Id32<LocalVariables.M> OJBJEGLGFKU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E8E0", Offset = "0x2B8D8E0", VA = "0x182B8E8E0")]
		public static Id32<LocalVariables.M> MQVZOWGLEYT(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B90550", Offset = "0x2B8F550", VA = "0x182B90550")]
		public static Id32<LocalVariables.M> UIHTNVSZZFE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FCB0", Offset = "0x2B8ECB0", VA = "0x182B8FCB0")]
		public static Id32<LocalVariables.M> QKBWGYPMEXM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B90EF0", Offset = "0x2B8FEF0", VA = "0x182B90EF0")]
		public static Id32<LocalVariables.M> XCCBLRWEZVX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F120", Offset = "0x2B8E120", VA = "0x182B8F120")]
		public static Id32<LocalVariables.M> OWOPFGHIMKQ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C900", Offset = "0x2B8B900", VA = "0x182B8C900")]
		public static Id32<LocalVariables.M> CULPIDMELIB(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B90930", Offset = "0x2B8F930", VA = "0x182B90930")]
		public static Id32<LocalVariables.M> WCLKDKFLQJQ(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA00", Offset = "0x2B8DA00", VA = "0x182B8EA00")]
		public static void NOIYGBZTAJN(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF10", Offset = "0x2B8CF10", VA = "0x182B8DF10")]
		public static Id32<LocalVariables.M> JIGBDNAMONG(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CD00", Offset = "0x2B8BD00", VA = "0x182B8CD00")]
		public static Id32<LocalVariables.M> DVQXKEYSUPJ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E090", Offset = "0x2B8D090", VA = "0x182B8E090")]
		public static Id32<LocalVariables.M> KLHDVAJKVOG(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FEF0", Offset = "0x2B8EEF0", VA = "0x182B8FEF0")]
		public static Id32<LocalVariables.M> RSUMHAQBGFE(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D570", Offset = "0x2B8C570", VA = "0x182B8D570")]
		public static Id32<LocalVariables.M> HTQPUCNXOHL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D810", Offset = "0x2B8C810", VA = "0x182B8D810")]
		public static Id32<LocalVariables.M> IVVBNXWOHHG(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B90AE0", Offset = "0x2B8FAE0", VA = "0x182B90AE0")]
		public static Id32<LocalVariables.M> WQOLHFGJDVK(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C370", Offset = "0x2B8B370", VA = "0x182B8C370")]
		public static Id32<LocalVariables.M> BHZNJRZNAXH(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FFF0", Offset = "0x2B8EFF0", VA = "0x182B8FFF0")]
		public static Id32<LocalVariables.M> SEMNLOONRBE(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B91010", Offset = "0x2B90010", VA = "0x182B91010")]
		public static Id32<LocalVariables.M> YTVFBFUTDNR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F59F30", Offset = "0x3F58F30", VA = "0x183F59F30")]
		public static void ITLFUIXGDGK<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DMXLEVIULSD> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, XSBPVWOYINP<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BD40", Offset = "0x3F5AD40", VA = "0x183F5BD40")]
		public static void RWLAANRCZRC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<MCZYZSSYBNX> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, XSBPVWOYINP<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A6E0", Offset = "0x3F596E0", VA = "0x183F5A6E0")]
		public static Id32<LocalVariables.M> LFPACRMFWCC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, XSBPVWOYINP<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B0C0", Offset = "0x3F5A0C0", VA = "0x183F5B0C0")]
		public static Id32<LocalVariables.M> PRSIWBYOKJF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, XSBPVWOYINP<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C4F0", Offset = "0x3F5B4F0", VA = "0x183F5C4F0")]
		public static Id32<DataBackResults.M> VXTGVFLWKOA<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, XSBPVWOYINP<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3F59C30", Offset = "0x3F58C30", VA = "0x183F59C30")]
		public static Id32<ExecForwardResults.M> BOVEAVAKWLZ<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, XSBPVWOYINP<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EC50", Offset = "0x2B8DC50", VA = "0x182B8EC50")]
		public static Id32<DataBackResults.M> OAPXYBPKPZP(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E390", Offset = "0x2B8D390", VA = "0x182B8E390")]
		public static Id32<DataBackResults.M> MHVEPYMIDGT(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3F5CA80", Offset = "0x3F5BA80", VA = "0x183F5CA80")]
		public static Id32<DataBackResults.M> XPGJDWGFLYS<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DMXLEVIULSD> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, XSBPVWOYINP<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C810", Offset = "0x3F5B810", VA = "0x183F5C810")]
		private static Id32<DataBackResults.M> XPGJDWGFLYS<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DMXLEVIULSD> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, XSBPVWOYINP<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F5AC70", Offset = "0x3F59C70", VA = "0x183F5AC70")]
		public static Id32<LocalVariables.M> MKFONOFTKOS<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, XSBPVWOYINP<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D650", Offset = "0x3F5C650", VA = "0x183F5D650")]
		public static void ZEVXENPVEGD<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, XSBPVWOYINP<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
		public LiveInterval(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> firstUse, Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B87DA0", Offset = "0x2B86DA0", VA = "0x182B87DA0")]
		public static LiveInterval New(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class SSDIBIAAKFZ : GXOJHSGVHBG
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
			[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class MYCAKPKKQWZ : GXOJHSGVHBG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class PHAQIJKCEYO : GXOJHSGVHBG
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
			[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
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
		public abstract class GXOJHSGVHBG
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
			public Id32<GXOJHSGVHBG> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2B87D80", Offset = "0x2B86D80", VA = "0x182B87D80")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<GXOJHSGVHBG> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class IYAGYMLZAID : GXOJHSGVHBG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<SSDIBIAAKFZ, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<PHAQIJKCEYO, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<IYAGYMLZAID, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<MYCAKPKKQWZ, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B87FA0", Offset = "0x2B86FA0", VA = "0x182B87FA0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<SSDIBIAAKFZ, ArgumentInst> argumentVariables, [In] SOAId32Field<PHAQIJKCEYO, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<IYAGYMLZAID, ParameterInst> parameterVariables, [In] SOAId32Field<MYCAKPKKQWZ, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B87DB0", Offset = "0x2B86DB0", VA = "0x182B87DB0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class SKOPNGYTYVC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B89200", Offset = "0x2B88200", VA = "0x182B89200")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class PHQIIZTKKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B88BC0", Offset = "0x2B87BC0", VA = "0x182B88BC0")]
		public static void IUKOSOXMDUK(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.IZEHGWKFPMM, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B866C0", Offset = "0x2B856C0", VA = "0x182B866C0")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.IZEHGWKFPMM, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B86650", Offset = "0x2B85650", VA = "0x182B86650")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B86430", Offset = "0x2B85430", VA = "0x182B86430")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x35EFAA0", Offset = "0x35EEAA0", VA = "0x1835EFAA0")]
		public static void IUKOSOXMDUK<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<LNVRVOESCOU> graphId) where TDeps : notnull, XSBPVWOYINP<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class XYBNJHBJOCV
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B912C0", Offset = "0x2B902C0", VA = "0x182B912C0")]
		public static void IUKOSOXMDUK(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface ZDZIAKLNOGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void QXDXUFAYHPH(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : ZDZIAKLNOGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2B88E60", Offset = "0x2B87E60", VA = "0x182B88E60", Slot = "4")]
			public void QXDXUFAYHPH(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : ZDZIAKLNOGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2B88EF0", Offset = "0x2B87EF0", VA = "0x182B88EF0", Slot = "4")]
			public void QXDXUFAYHPH(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : ZDZIAKLNOGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2B88D20", Offset = "0x2B87D20", VA = "0x182B88D20", Slot = "4")]
			public void QXDXUFAYHPH(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : ZDZIAKLNOGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2B88DB0", Offset = "0x2B87DB0", VA = "0x182B88DB0", Slot = "4")]
			public void QXDXUFAYHPH(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class PWGGTYOHVQQ<c> where c : struct, ZDZIAKLNOGO
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c RAESGKCNHZO;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3C82810", Offset = "0x3C81810", VA = "0x183C82810")]
			public static int IUKOSOXMDUK<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : XSBPVWOYINP<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<FunctionCalls.IZEHGWKFPMM>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B87D30", Offset = "0x2B86D30", VA = "0x182B87D30")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<FunctionCalls.IZEHGWKFPMM>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B87C80", Offset = "0x2B86C80", VA = "0x182B87C80")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B87C40", Offset = "0x2B86C40", VA = "0x182B87C40")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3A0EDF0", Offset = "0x3A0DDF0", VA = "0x183A0EDF0")]
		public static void IUKOSOXMDUK<b, a>(FunctionCompileState a, b b, a c) where b : XSBPVWOYINP<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class PBCRZYIFGVA
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
		private static int ZVXTUJHXLBG;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int SCXHTHNBQOC;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B884B0", Offset = "0x2B874B0", VA = "0x182B884B0")]
		public static void IUKOSOXMDUK(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B88290", Offset = "0x2B87290", VA = "0x182B88290")]
		private static void DZKYLYAQVVF([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B88150", Offset = "0x2B87150", VA = "0x182B88150")]
		private static void DZKYLYAQVVF(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B88A10", Offset = "0x2B87A10", VA = "0x182B88A10")]
		private static void IWRZJGQUNUA(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class AYREQTGBLBI<a, b, c> where a : struct, PTQDBBOFQEQ<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a RAESGKCNHZO;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x589E910", Offset = "0x589D910", VA = "0x18589E910")]
		public static void IUKOSOXMDUK([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface PTQDBBOFQEQ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> CUBLTLICNOG(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EVUABQUWWDI(a a, b b, Id32<NJHHKJCVQUE<SKRYMZOWBYC>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface QJTQATQNDOV<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a PGAHLLZHPJP(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FUICVJEQTKT(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<NJHHKJCVQUE<SKRYMZOWBYC>> EPCEHLMPVOK(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class BJIYWRLSXTZ<a, b, c> where a : struct, QJTQATQNDOV<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a RAESGKCNHZO;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x746C440", Offset = "0x746B440", VA = "0x18746C440")]
		public static UnsafeList<b> IUKOSOXMDUK(int a, [In] c values)
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
