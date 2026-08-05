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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x28BBDC0", Offset = "0x28BA9C0", VA = "0x1828BBDC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
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
		public readonly Id32<IMGRICEYMPU<EJGGWQPBGFS>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
		public ByteCodeAdjustment(Id32<IMGRICEYMPU<EJGGWQPBGFS>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class ZZNPTLVUJCS : XTZSILDTTXA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2856560", Offset = "0x2855160", VA = "0x182856560")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x28BA450", Offset = "0x28B9050", VA = "0x1828BA450", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class QJTYDIMUMTT : XTZSILDTTXA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<IMGRICEYMPU<FFTLZZJTBOR>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
			public DeadEnd(Id32<IMGRICEYMPU<FFTLZZJTBOR>> nextByteCodePtr)
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
		public abstract class XTZSILDTTXA
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
			public readonly Id32<XTZSILDTTXA> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
			public Inst(Def def, Id32<XTZSILDTTXA> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class GGODQIWODJE : XTZSILDTTXA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class BWSTJKBDNDK : XTZSILDTTXA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x20267D0", Offset = "0x20253D0", VA = "0x1820267D0", Slot = "3")]
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
		internal IdUnsafeList<ZZNPTLVUJCS, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<QJTYDIMUMTT, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<GGODQIWODJE, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<BWSTJKBDNDK, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28BA600", Offset = "0x28B9200", VA = "0x1828BA600")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<ZZNPTLVUJCS, BytesImmediate> bytesImmediates, [In] IdUnsafeList<QJTYDIMUMTT, DeadEnd> deadEnds, [In] IdUnsafeList<GGODQIWODJE, Variable> variables, [In] IdUnsafeList<BWSTJKBDNDK, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28BA4C0", Offset = "0x28B90C0", VA = "0x1828BA4C0")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FBRSODXMDYV
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28BA760", Offset = "0x28B9360", VA = "0x1828BA760")]
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
		public sealed class FSNYTMRWMZH : XTZSILDTTXA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
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
		public abstract class XTZSILDTTXA
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
			public readonly Id32<XTZSILDTTXA> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
			public Inst(Def def, Id32<XTZSILDTTXA> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<FSNYTMRWMZH, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28BA720", Offset = "0x28B9320", VA = "0x1828BA720")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<FSNYTMRWMZH, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28BA690", Offset = "0x28B9290", VA = "0x1828BA690")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class BATOAJGENQG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28B7E00", Offset = "0x28B6A00", VA = "0x1828B7E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x28BA8B0", Offset = "0x28B94B0", VA = "0x1828BA8B0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28BA810", Offset = "0x28B9410", VA = "0x1828BA810")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class TVPZHJSYETD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28BD590", Offset = "0x28BC190", VA = "0x1828BD590")]
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
		public sealed class SFZAHFMTDPH : XTZSILDTTXA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<TBEIFKKREIG> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
			public ExternalCall(Id32<TBEIFKKREIG> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class XTZSILDTTXA
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
			public readonly Id32<XTZSILDTTXA> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
			private Inst(Def def, Id32<XTZSILDTTXA> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28BBA60", Offset = "0x28BA660", VA = "0x1828BBA60")]
			public static Inst New(Def def, Id32<XTZSILDTTXA> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class QNCRXRSZDKL : XTZSILDTTXA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<TBEIFKKREIG> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
			public InternalCall(Id32<TBEIFKKREIG> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class TBEIFKKREIG
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
			[Cpp2IlInjected.Address(RVA = "0x28BA720", Offset = "0x28B9320", VA = "0x1828BA720")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x28BB8B0", Offset = "0x28BA4B0", VA = "0x1828BB8B0")]
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
		internal IdUnsafeList<QNCRXRSZDKL, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<SFZAHFMTDPH, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<TBEIFKKREIG> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<TBEIFKKREIG, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28BAAB0", Offset = "0x28B96B0", VA = "0x1828BAAB0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<QNCRXRSZDKL, InternalCall> internalCalls, [In] IdUnsafeList<SFZAHFMTDPH, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<TBEIFKKREIG> IOId)> callsWithIO, [In] IdUnsafeList<TBEIFKKREIG, IO> io, [In] SOAField<TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> ioModifyingCallLocations, [In] SOAField<TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28BA910", Offset = "0x28B9510", VA = "0x1828BA910")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class OVURZQZBSAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28BC220", Offset = "0x28BAE20", VA = "0x1828BC220")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28BC010", Offset = "0x28BAC10", VA = "0x1828BC010")]
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
		internal SOAField<QOGVDVXCRZJ, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<QOGVDVXCRZJ>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28BB500", Offset = "0x28BA100", VA = "0x1828BB500")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<QOGVDVXCRZJ, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<QOGVDVXCRZJ>> generatedOutputsForExpression, [In] SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28BAB70", Offset = "0x28B9770", VA = "0x1828BAB70")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class BVTKYBRHSQY
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : RWJEYBFOPOD<Id32<FunctionCalls.TBEIFKKREIG>, SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x28BD100", Offset = "0x28BBD00", VA = "0x1828BD100")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x28BD0B0", Offset = "0x28BBCB0", VA = "0x1828BD0B0", Slot = "4")]
			public Id32<FunctionCalls.TBEIFKKREIG> KUCKHOEFXYD(int a)
			{
				return default(Id32<FunctionCalls.TBEIFKKREIG>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0")]
			public bool RUDUUPWHLUB(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "5")]
			private bool FMNGHTCDKOR(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x28BD0F0", Offset = "0x28BBCF0", VA = "0x1828BD0F0", Slot = "6")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> SLMKPUEXUNC(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : ADIILXSHJEG<Id32<FunctionCalls.TBEIFKKREIG>, SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28B7040", Offset = "0x28B5C40", VA = "0x1828B7040")]
			public UnsafeList<Id32<FunctionCalls.TBEIFKKREIG>> WYEIVPDXYGU(int a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TBEIFKKREIG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x28B70B0", Offset = "0x28B5CB0", VA = "0x1828B70B0")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x28B6F90", Offset = "0x28B5B90", VA = "0x1828B6F90", Slot = "6")]
			public void NQCPSCSTRZK(Id32<FunctionCalls.TBEIFKKREIG> a, SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> b, Id32<IMGRICEYMPU<EJGGWQPBGFS>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x28B7040", Offset = "0x28B5C40", VA = "0x1828B7040", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.TBEIFKKREIG>> VFVIFNJNXRV(int a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TBEIFKKREIG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x28B7030", Offset = "0x28B5C30", VA = "0x1828B7030", Slot = "5")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> UMMJRINZEEN(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<FFTLZZJTBOR>>> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : RWJEYBFOPOD<Id32<FunctionCalls.TBEIFKKREIG>, SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x28BD1D0", Offset = "0x28BBDD0", VA = "0x1828BD1D0")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x28BD180", Offset = "0x28BBD80", VA = "0x1828BD180", Slot = "4")]
			public Id32<FunctionCalls.TBEIFKKREIG> KUCKHOEFXYD(int a)
			{
				return default(Id32<FunctionCalls.TBEIFKKREIG>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0")]
			public bool RUDUUPWHLUB(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "5")]
			private bool VIWWABMBABA(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x28BD1C0", Offset = "0x28BBDC0", VA = "0x1828BD1C0", Slot = "6")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> PHSJXQEWMUL(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : ADIILXSHJEG<Id32<FunctionCalls.TBEIFKKREIG>, SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x28B7140", Offset = "0x28B5D40", VA = "0x1828B7140")]
			public UnsafeList<Id32<FunctionCalls.TBEIFKKREIG>> WYEIVPDXYGU(int a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TBEIFKKREIG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x28B7250", Offset = "0x28B5E50", VA = "0x1828B7250")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x28B71B0", Offset = "0x28B5DB0", VA = "0x1828B71B0", Slot = "6")]
			public void NQCPSCSTRZK(Id32<FunctionCalls.TBEIFKKREIG> a, SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> b, Id32<IMGRICEYMPU<EJGGWQPBGFS>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x28B7140", Offset = "0x28B5D40", VA = "0x1828B7140", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.TBEIFKKREIG>> JTMQSSAIMJW(int a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.TBEIFKKREIG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x28B7130", Offset = "0x28B5D30", VA = "0x1828B7130", Slot = "5")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> DXNKKRDRWQU(Id32<FunctionCalls.TBEIFKKREIG> a, [In] SOAField<FunctionCalls.TBEIFKKREIG, Id32<IMGRICEYMPU<JBNFXJGCZAM>>> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : RWJEYBFOPOD<Id32<WTGBYXZBMTM>, SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x28BD2F0", Offset = "0x28BBEF0", VA = "0x1828BD2F0")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(Id32<WTGBYXZBMTM> a, [In] SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x28BD2B0", Offset = "0x28BBEB0", VA = "0x1828BD2B0", Slot = "4")]
			public Id32<WTGBYXZBMTM> KUCKHOEFXYD(int a)
			{
				return default(Id32<WTGBYXZBMTM>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x28BD250", Offset = "0x28BBE50", VA = "0x1828BD250")]
			public bool RUDUUPWHLUB(Id32<WTGBYXZBMTM> a, [In] SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x28BD250", Offset = "0x28BBE50", VA = "0x1828BD250", Slot = "5")]
			private bool GIAGHARNKPK(Id32<WTGBYXZBMTM> a, [In] SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x28BD3A0", Offset = "0x28BBFA0", VA = "0x1828BD3A0", Slot = "6")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> ZJMMQRJCJCB(Id32<WTGBYXZBMTM> a, [In] SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : ADIILXSHJEG<Id32<WTGBYXZBMTM>, SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x28B72D0", Offset = "0x28B5ED0", VA = "0x1828B72D0")]
			public UnsafeList<Id32<WTGBYXZBMTM>> WYEIVPDXYGU(int a, [In] SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> values)
			{
				return default(UnsafeList<Id32<WTGBYXZBMTM>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x28B7450", Offset = "0x28B6050", VA = "0x1828B7450")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(Id32<WTGBYXZBMTM> a, [In] SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x28B7350", Offset = "0x28B5F50", VA = "0x1828B7350", Slot = "6")]
			public void NQCPSCSTRZK(Id32<WTGBYXZBMTM> a, SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> b, Id32<IMGRICEYMPU<EJGGWQPBGFS>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x28B72D0", Offset = "0x28B5ED0", VA = "0x1828B72D0", Slot = "4")]
			private UnsafeList<Id32<WTGBYXZBMTM>> JCQRNYNLONM(int a, [In] SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> values)
			{
				return default(UnsafeList<Id32<WTGBYXZBMTM>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x28B7340", Offset = "0x28B5F40", VA = "0x1828B7340", Slot = "5")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> MWELIMQBRIO(Id32<WTGBYXZBMTM> a, [In] SOAField<WTGBYXZBMTM, Id32<IMGRICEYMPU<FFTLZZJTBOR>>?> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : RWJEYBFOPOD<int, UnsafeList<(Id32<LocalVariables.M>, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x28BD500", Offset = "0x28BC100", VA = "0x1828BD500")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAF7520", Offset = "0xAF6120", VA = "0x180AF7520", Slot = "4")]
			public int KUCKHOEFXYD(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0")]
			public bool RUDUUPWHLUB(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "5")]
			private bool UKEBQBDFNDH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x28BD4F0", Offset = "0x28BC0F0", VA = "0x1828BD4F0", Slot = "6")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> RUMLOIWDHMM(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : ADIILXSHJEG<int, UnsafeList<(Id32<LocalVariables.M>, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x28B7920", Offset = "0x28B6520", VA = "0x1828B7920")]
			public UnsafeList<int> WYEIVPDXYGU(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28B7AA0", Offset = "0x28B66A0", VA = "0x1828B7AA0")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x28B79A0", Offset = "0x28B65A0", VA = "0x1828B79A0", Slot = "6")]
			public void NQCPSCSTRZK(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> values, Id32<IMGRICEYMPU<EJGGWQPBGFS>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x28B7920", Offset = "0x28B6520", VA = "0x1828B7920", Slot = "4")]
			private UnsafeList<int> CJXDAULXZJX(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x28B7990", Offset = "0x28B6590", VA = "0x1828B7990", Slot = "5")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> MZYTNZXTDRR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<IMGRICEYMPU<IMAAHXSZDBK<EJGGWQPBGFS>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : RWJEYBFOPOD<int, UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x28BD460", Offset = "0x28BC060", VA = "0x1828BD460")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAF7520", Offset = "0xAF6120", VA = "0x180AF7520", Slot = "4")]
			public int KUCKHOEFXYD(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0")]
			public bool RUDUUPWHLUB(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "5")]
			private bool GIMCYCDBSJK(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x28BD450", Offset = "0x28BC050", VA = "0x1828BD450", Slot = "6")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> RTOONMKIKRD(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : ADIILXSHJEG<int, UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x28B7820", Offset = "0x28B6420", VA = "0x1828B7820")]
			public UnsafeList<int> WYEIVPDXYGU(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x28B7890", Offset = "0x28B6490", VA = "0x1828B7890")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x28B7720", Offset = "0x28B6320", VA = "0x1828B7720", Slot = "6")]
			public void NQCPSCSTRZK(int a, UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values, Id32<IMGRICEYMPU<EJGGWQPBGFS>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x28B7820", Offset = "0x28B6420", VA = "0x1828B7820", Slot = "4")]
			private UnsafeList<int> WPTDXNKOWHK(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x28B7710", Offset = "0x28B6310", VA = "0x1828B7710", Slot = "5")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> KHLVINQVPTK(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : RWJEYBFOPOD<int, UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x28BD3C0", Offset = "0x28BBFC0", VA = "0x1828BD3C0")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAF7520", Offset = "0xAF6120", VA = "0x180AF7520", Slot = "4")]
			public int KUCKHOEFXYD(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0")]
			public bool RUDUUPWHLUB(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "5")]
			private bool GIMCYCDBSJK(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x28BD3B0", Offset = "0x28BBFB0", VA = "0x1828BD3B0", Slot = "6")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> RTOONMKIKRD(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : ADIILXSHJEG<int, UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x28B7610", Offset = "0x28B6210", VA = "0x1828B7610")]
			public UnsafeList<int> WYEIVPDXYGU(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x28B7680", Offset = "0x28B6280", VA = "0x1828B7680")]
			public Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x28B7510", Offset = "0x28B6110", VA = "0x1828B7510", Slot = "6")]
			public void NQCPSCSTRZK(int a, UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values, Id32<IMGRICEYMPU<EJGGWQPBGFS>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x28B7610", Offset = "0x28B6210", VA = "0x1828B7610", Slot = "4")]
			private UnsafeList<int> WPTDXNKOWHK(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x28B7500", Offset = "0x28B6100", VA = "0x1828B7500", Slot = "5")]
			private Id32<IMGRICEYMPU<EJGGWQPBGFS>> KHLVINQVPTK(int a, [In] UnsafeList<(Id32<IMGRICEYMPU<FFTLZZJTBOR>> Target, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1A638F0", Offset = "0x1A624F0", VA = "0x181A638F0")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x28BB8A0", Offset = "0x28BA4A0", VA = "0x1828BB8A0")]
			public void QWOWOOZCIPT([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<WTGBYXZBMTM> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x28BB880", Offset = "0x28BA480", VA = "0x1828BB880")]
			public GenerateDataBackFromInputIndexResult(Id32<WTGBYXZBMTM> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28BB850", Offset = "0x28BA450", VA = "0x1828BB850")]
			public void QWOWOOZCIPT([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28BB860", Offset = "0x28BA460", VA = "0x1828BB860")]
			public void QWOWOOZCIPT([Out] Id32<DataBackResults.M> a, [Out] Id32<WTGBYXZBMTM> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<WTGBYXZBMTM> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
			public GenerateDataBackFromInputIndicesResult(Id32<WTGBYXZBMTM> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x28BB890", Offset = "0x28BA490", VA = "0x1828BB890")]
			public void QWOWOOZCIPT([Out] Id32<DataBackResults.M> a, [Out] Id32<WTGBYXZBMTM> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28B8510", Offset = "0x28B7110", VA = "0x1828B8510")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28B9350", Offset = "0x28B7F50", VA = "0x1828B9350")]
		public static void KKIAGATPGIG(this FunctionCompileState a, Id32<QOGVDVXCRZJ> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28B8F70", Offset = "0x28B7B70", VA = "0x1828B8F70")]
		public static void JHHVEHMHVIE(this FunctionCompileState a, Id32<QOGVDVXCRZJ> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28BA1F0", Offset = "0x28B8DF0", VA = "0x1828BA1F0")]
		public static Id32<DataBackResults.M>? WPIKETCAYFT([In] this FunctionCompileState self, Id32<QOGVDVXCRZJ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28B9930", Offset = "0x28B8530", VA = "0x1828B9930")]
		public static Id32<IMGRICEYMPU<FFTLZZJTBOR>> QTIIHVJDGMV([In] this FunctionCompileState self)
		{
			return default(Id32<IMGRICEYMPU<FFTLZZJTBOR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28B8DD0", Offset = "0x28B79D0", VA = "0x1828B8DD0")]
		private static void JFFVLKMWAFU(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28B82C0", Offset = "0x28B6EC0", VA = "0x1828B82C0")]
		private static Id32<IMGRICEYMPU<FFTLZZJTBOR>>? BQMJYHHKEQB([In] this FunctionCompileState self, Id32<WTGBYXZBMTM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28B9150", Offset = "0x28B7D50", VA = "0x1828B9150")]
		public static void JUPQKFYFTHX(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28B7E60", Offset = "0x28B6A60", VA = "0x1828B7E60")]
		public static DataBackResults.Def AFJIBZBFKCR([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28B8B00", Offset = "0x28B7700", VA = "0x1828B8B00")]
		public static ReadOnlyArray<byte> HQNAENDKLXT([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28B9590", Offset = "0x28B8190", VA = "0x1828B9590")]
		public static Id32<LocalVariables.M> NPCUZFXSEYX([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28B89D0", Offset = "0x28B75D0", VA = "0x1828B89D0")]
		public static Union32 EWQMXZICTAH([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x33A31C0", Offset = "0x33A1DC0", VA = "0x1833A31C0")]
		private static Id32<DataBackResults.M> XIDOYMSZENO<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.XTZSILDTTXA
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28B8240", Offset = "0x28B6E40", VA = "0x1828B8240")]
		public static Id32<DataBackResults.M> BOBPELWNVKG(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28B92C0", Offset = "0x28B7EC0", VA = "0x1828B92C0")]
		public static Id32<DataBackResults.M> KHXZTDDABJX(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28B83B0", Offset = "0x28B6FB0", VA = "0x1828B83B0")]
		public static Id32<DataBackResults.M> CURHUYHKAKA(this FunctionCompileState a, Id32<IMGRICEYMPU<FFTLZZJTBOR>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28BA270", Offset = "0x28B8E70", VA = "0x1828BA270")]
		public static Id32<DataBackResults.M> WPTTEWPPMJM(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28B9C70", Offset = "0x28B8870", VA = "0x1828B9C70")]
		public static Id32<DataBackResults.M> THAUCEBQEJD(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x33A3120", Offset = "0x33A1D20", VA = "0x1833A3120")]
		private static Id32<ExecForwardResults.M> UKWLNHOAMTV<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.XTZSILDTTXA
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28B8D90", Offset = "0x28B7990", VA = "0x1828B8D90")]
		public static Id32<ExecForwardResults.M> IISSEFNDSFL(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28B9990", Offset = "0x28B8590", VA = "0x1828B9990")]
		public static Id32<ExecForwardResults.M> QYSATJVMKNI(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28B9B90", Offset = "0x28B8790", VA = "0x1828B9B90")]
		public static Id32<ExecForwardResults.M> ROYYXSCJXUG(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28BA2F0", Offset = "0x28B8EF0", VA = "0x1828BA2F0")]
		public static Id32<ExecForwardResults.M> XRUOQXGKPPF(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28B93E0", Offset = "0x28B7FE0", VA = "0x1828B93E0")]
		public static Id32<ExecForwardResults.M> KLCFJZYDDHN(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28B8340", Offset = "0x28B6F40", VA = "0x1828B8340")]
		public static FunctionCalls.Def BYDFAICKIKI([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28B9550", Offset = "0x28B8150", VA = "0x1828B9550")]
		public static CopyEnumerable<Id32<FunctionCalls.TBEIFKKREIG>, Id32Enumerator<FunctionCalls.TBEIFKKREIG>> NHERCHTNKXP([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.TBEIFKKREIG>, Id32Enumerator<FunctionCalls.TBEIFKKREIG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28BA020", Offset = "0x28B8C20", VA = "0x1828BA020")]
		public static Id32<FunctionCalls.TBEIFKKREIG> WHNEZFHJWQE([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.TBEIFKKREIG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28B94E0", Offset = "0x28B80E0", VA = "0x1828B94E0")]
		public static FunctionCalls.IO MCIVKLKCFEV([In] this FunctionCompileState self, Id32<FunctionCalls.TBEIFKKREIG> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28B9F20", Offset = "0x28B8B20", VA = "0x1828B9F20")]
		public static FunctionCalls.IO VBHBQCVQQKB(this FunctionCompileState a, Id32<FunctionCalls.TBEIFKKREIG> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x33A2130", Offset = "0x33A0D30", VA = "0x1833A2130")]
		private static Id32<FunctionCalls.M> JLIWIGMUHCC<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.XTZSILDTTXA
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28B9670", Offset = "0x28B8270", VA = "0x1828B9670")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TBEIFKKREIG>) NTLFLZQKFST(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TBEIFKKREIG>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28B8BE0", Offset = "0x28B77E0", VA = "0x1828B8BE0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TBEIFKKREIG>) IBTKQIBCRHP(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TBEIFKKREIG>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28B84C0", Offset = "0x28B70C0", VA = "0x1828B84C0")]
		public static Id32<FunctionCalls.M> DQGYWPCWZYO(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28B9F90", Offset = "0x28B8B90", VA = "0x1828B9F90")]
		public static void VQXFHMQLFHN(this FunctionCompileState a, Id32<FunctionCalls.TBEIFKKREIG> b, Id32<IMGRICEYMPU<FFTLZZJTBOR>> c, Id32<IMGRICEYMPU<JBNFXJGCZAM>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x33A0760", Offset = "0x339F360", VA = "0x1833A0760")]
		public static GenerateDataBackResult DDXNKMYJDTR<d, e>(this FunctionCompileState a, d b, e c, Id32<LJKQDQDPBOO> d, Id32<WTGBYXZBMTM> e) where d : LGJNITTFOIP<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x33A2380", Offset = "0x33A0F80", VA = "0x1833A2380")]
		public static GenerateDataBackFromInputIndexResult MBUAOFGXIKH<f, g>(this FunctionCompileState a, f b, g c, Id32<LJKQDQDPBOO> d, Id32<YNBOVCHXCPU> e, int f) where f : LGJNITTFOIP<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x33A1BC0", Offset = "0x33A07C0", VA = "0x1833A1BC0")]
		public static Id32<DataBackResults.M>? FEZBOZGQZSS<h, i>(this FunctionCompileState a, h b, i c, Id32<LJKQDQDPBOO> d, Id32<YNBOVCHXCPU> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : LGJNITTFOIP<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x33A28E0", Offset = "0x33A14E0", VA = "0x1833A28E0")]
		public static Id32<ExecForwardResults.M> RLSAOUTEGWC<j, k>(this FunctionCompileState a, j b, k c, Id32<LJKQDQDPBOO> d, Id32<QOGVDVXCRZJ> e) where j : LGJNITTFOIP<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x28B8080", Offset = "0x28B6C80", VA = "0x1828B8080")]
		public static LocalVariables.ArgumentInst AWIYOXPMOJU([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28B87E0", Offset = "0x28B73E0", VA = "0x1828B87E0")]
		public static LocalVariables.CalleeReturnValueInst EIMBYIJLYKK([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28BA340", Offset = "0x28B8F40", VA = "0x1828BA340")]
		public static LocalVariables.CallerReturnValueInst XSQTGPDODXH([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28B7ED0", Offset = "0x28B6AD0", VA = "0x1828B7ED0")]
		public static Id32<LocalVariables.M> AWEJCBVQEMH(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28B9040", Offset = "0x28B7C40", VA = "0x1828B9040")]
		public static LocalVariables.ParameterInst JUKJEIVGYZC([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28B9CF0", Offset = "0x28B88F0", VA = "0x1828B9CF0")]
		public static LocalVariables.Def TNHEPWQNMNW([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28B8AB0", Offset = "0x28B76B0", VA = "0x1828B8AB0")]
		public static int? FKTWNGGTQKO([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x33A27E0", Offset = "0x33A13E0", VA = "0x1833A27E0")]
		private static Id32<LocalVariables.M> NKNUOBDHVRE<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.XTZSILDTTXA
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28B9430", Offset = "0x28B8030", VA = "0x1828B9430")]
		public static Id32<LocalVariables.M> LXVCIBWBATG(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28B9C10", Offset = "0x28B8810", VA = "0x1828B9C10")]
		public static Id32<LocalVariables.M> TELHJMGPHRF(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28B9D40", Offset = "0x28B8940", VA = "0x1828B9D40")]
		public static Id32<LocalVariables.M> TXPKQFKKJOF(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28B9B00", Offset = "0x28B8700", VA = "0x1828B9B00")]
		public static Id32<LocalVariables.M> RIIRSUWMNGR(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28B9EC0", Offset = "0x28B8AC0", VA = "0x1828B9EC0")]
		public static Id32<LocalVariables.M> UIXCCZWWEHP(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28B99E0", Offset = "0x28B85E0", VA = "0x1828B99E0")]
		public static void RDIPNCBEDSW(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28B9820", Offset = "0x28B8420", VA = "0x1828B9820")]
		public static void QDLVNBQLLBQ(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28B8190", Offset = "0x28B6D90", VA = "0x1828B8190")]
		public static void BLKZDSUXVVM(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28B8430", Offset = "0x28B7030", VA = "0x1828B8430")]
		public static void CWNYGTKAKGV(this FunctionCompileState a, Id32<IMGRICEYMPU<FFTLZZJTBOR>> b, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28B88F0", Offset = "0x28B74F0", VA = "0x1828B88F0")]
		public static void ELUJAWKNGNH(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<IMGRICEYMPU<WZBOOXZMVOY>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x33A22A0", Offset = "0x33A0EA0", VA = "0x1833A22A0")]
		public static void JNRJEOCEKNQ<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<IMGRICEYMPU<IMAAHXSZDBK<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface LGJNITTFOIP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<BPIYIPOBZCK> TSMXRPKLCOY(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<BPIYIPOBZCK> MJGRYWEDLUJ(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<BPIYIPOBZCK> IBKIFULIXXA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<BPIYIPOBZCK> SNQJKFQMQXT(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> MSYJWHADCXJ(a a, FunctionCompileState b, Id32<LJKQDQDPBOO> c, Id32<WTGBYXZBMTM> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> BURPZGIZIBD(a a, FunctionCompileState b, Id32<LJKQDQDPBOO> c, Id32<QOGVDVXCRZJ> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int GCCQWMFKMNT(a a, Id32<LJKQDQDPBOO> b, Id32<WTGBYXZBMTM> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<QOGVDVXCRZJ> ZREHWQKZSJA(a a, Id32<LJKQDQDPBOO> b, Id32<WTGBYXZBMTM> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind KSYAOOJGVOP(a a, Id32<LJKQDQDPBOO> b, Id32<WTGBYXZBMTM> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool GIEGUKLOQAA(a a, Id32<LJKQDQDPBOO> b, Id32<WTGBYXZBMTM> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int BTHXVMOTEJX(a a, Id32<LJKQDQDPBOO> b, Id32<WTGBYXZBMTM> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> GRBRDRGFADV(a a, Id32<LJKQDQDPBOO> b, Id32<WTGBYXZBMTM> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<BPIYIPOBZCK>) QJQDPILNGNL(a a, Id32<LJKQDQDPBOO> b, Id32<WTGBYXZBMTM> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int MDSTMRDHGID(a a, Id32<LJKQDQDPBOO> b, Id32<QOGVDVXCRZJ> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<WTGBYXZBMTM> LBCGILINUAC(a a, Id32<LJKQDQDPBOO> b, Id32<QOGVDVXCRZJ> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<WTGBYXZBMTM> BROAFGQECIP(a a, Id32<LJKQDQDPBOO> b, Id32<YNBOVCHXCPU> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int VOQKKGPQMWH(a a, Id32<LJKQDQDPBOO> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? IMDXJVZBBHV(a a, Id32<LJKQDQDPBOO> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int CGICAQUZEOJ(a a, Id32<LJKQDQDPBOO> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? MYWLKRGLMTL(a a, Id32<LJKQDQDPBOO> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class AEZRYIROPQO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x304A7C0", Offset = "0x30493C0", VA = "0x18304A7C0")]
		public static Id32<LocalVariables.M?> WDAOHFDQAZD<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x304AD90", Offset = "0x3049990", VA = "0x18304AD90")]
		public static Id32<LocalVariables.M?> ZZCOSCIHRAM<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x304A170", Offset = "0x3048D70", VA = "0x18304A170")]
		public static Id32<LocalVariables.M?> SFEWLXKRFQV<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x28B2A90", Offset = "0x28B1690", VA = "0x1828B2A90")]
		public static Id32<LocalVariables.M> FXVNFIUGEQT(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x28B2300", Offset = "0x28B0F00", VA = "0x1828B2300")]
		public static Id32<LocalVariables.M> CUWPUPDWIRK(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x28B2420", Offset = "0x28B1020", VA = "0x1828B2420")]
		public static Id32<LocalVariables.M> CXADKQMFFBL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x28B6E90", Offset = "0x28B5A90", VA = "0x1828B6E90")]
		public static Id32<LocalVariables.M> ZWCZHTSOPLP(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x28B3A00", Offset = "0x28B2600", VA = "0x1828B3A00")]
		public static Id32<LocalVariables.M> KAFBFSLDTRA(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28B6490", Offset = "0x28B5090", VA = "0x1828B6490")]
		public static Id32<LocalVariables.M> UMCRAWELNGT(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x28B5380", Offset = "0x28B3F80", VA = "0x1828B5380")]
		public static Id32<LocalVariables.M> RZJQNCXILBR(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x28B28F0", Offset = "0x28B14F0", VA = "0x1828B28F0")]
		public static Id32<LocalVariables.M> ERCWVDPRCSU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x28B1D80", Offset = "0x28B0980", VA = "0x1828B1D80")]
		public static Id32<LocalVariables.M> ARXXZBFUWJP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x28B2E50", Offset = "0x28B1A50", VA = "0x1828B2E50")]
		public static Id32<LocalVariables.M> GQISCRMDAAQ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x28B6010", Offset = "0x28B4C10", VA = "0x1828B6010")]
		public static Id32<LocalVariables.M> TYPLUQTUIJN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28B4CA0", Offset = "0x28B38A0", VA = "0x1828B4CA0")]
		public static Id32<LocalVariables.M> QGHHHGOUJGK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28B3370", Offset = "0x28B1F70", VA = "0x1828B3370")]
		public static Id32<LocalVariables.M> HVQHMFBGZFH(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28B3D50", Offset = "0x28B2950", VA = "0x1828B3D50")]
		public static Id32<LocalVariables.M> KXSMPICCZEW(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28B1B20", Offset = "0x28B0720", VA = "0x1828B1B20")]
		public static Id32<LocalVariables.M> AIKXXHZPJPN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28B6C50", Offset = "0x28B5850", VA = "0x1828B6C50")]
		public static Id32<LocalVariables.M> XSAKBELOFZD(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28B31F0", Offset = "0x28B1DF0", VA = "0x1828B31F0")]
		public static Id32<LocalVariables.M> HREGOCNRXWW(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28B6CD0", Offset = "0x28B58D0", VA = "0x1828B6CD0")]
		public static Id32<LocalVariables.M> XYVLNUPWSTN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28B3E80", Offset = "0x28B2A80", VA = "0x1828B3E80")]
		public static Id32<LocalVariables.M> KZNMORJFMVC(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28B3F00", Offset = "0x28B2B00", VA = "0x1828B3F00")]
		public static Id32<LocalVariables.M> LCPPRSZCMHF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28B2A10", Offset = "0x28B1610", VA = "0x1828B2A10")]
		public static Id32<LocalVariables.M> FARXUPVSNYK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28B3B20", Offset = "0x28B2720", VA = "0x1828B3B20")]
		public static Id32<LocalVariables.M> KIOPPZONODU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28B6990", Offset = "0x28B5590", VA = "0x1828B6990")]
		public static Id32<LocalVariables.M> WVYXFGABEMN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28B5300", Offset = "0x28B3F00", VA = "0x1828B5300")]
		public static Id32<LocalVariables.M> RUODTQHJNNW(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28B66D0", Offset = "0x28B52D0", VA = "0x1828B66D0")]
		public static Id32<LocalVariables.M> VBNBDXWBQUL(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28B6BD0", Offset = "0x28B57D0", VA = "0x1828B6BD0")]
		public static Id32<LocalVariables.M> XRTWOZCGBKE(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28B5F90", Offset = "0x28B4B90", VA = "0x1828B5F90")]
		public static Id32<LocalVariables.M> TSIRKSMDXMZ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28B4960", Offset = "0x28B3560", VA = "0x1828B4960")]
		public static Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> OKWWQFYEGMX(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28B2B90", Offset = "0x28B1790", VA = "0x1828B2B90")]
		public static Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> GCZZCVNSOWP(this FunctionCompileState a, int b)
		{
			return default(Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28B6B30", Offset = "0x28B5730", VA = "0x1828B6B30")]
		public static Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> XLYSYUGICWU(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28B2F50", Offset = "0x28B1B50", VA = "0x1828B2F50")]
		public static Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> GWJCZYUELYU(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28B1AA0", Offset = "0x28B06A0", VA = "0x1828B1AA0")]
		public static Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> AFRZUFUHSUA(this FunctionCompileState a, int b)
		{
			return default(Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28B3150", Offset = "0x28B1D50", VA = "0x1828B3150")]
		public static Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> HIUYPILUYHN(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28B55A0", Offset = "0x28B41A0", VA = "0x1828B55A0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TBEIFKKREIG>) SLLMDFKZMQE(this FunctionCompileState a, Id32<NFQUWHUKAZT> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TBEIFKKREIG>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28B44C0", Offset = "0x28B30C0", VA = "0x1828B44C0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.TBEIFKKREIG>) OKPNTFZYPSO(this FunctionCompileState a, Id32<HDOGPWGYNWD> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.TBEIFKKREIG>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x304AAF0", Offset = "0x30496F0", VA = "0x18304AAF0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<BPIYIPOBZCK>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<TMarker>>, Id32<FunctionCalls.M>) YQMWVWJCDNL<TMarker>(this FunctionCompileState a, Id32<BPIYIPOBZCK> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<BPIYIPOBZCK>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28B3BA0", Offset = "0x28B27A0", VA = "0x1828B3BA0")]
		public static Id32<LocalVariables.M> KNFRKSOTDHP(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28B3C60", Offset = "0x28B2860", VA = "0x1828B3C60")]
		public static Id32<LocalVariables.M> KPJBAEOBJVQ(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28B68A0", Offset = "0x28B54A0", VA = "0x1828B68A0")]
		public static Id32<LocalVariables.M> WKJHGVSWEGL(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28B6270", Offset = "0x28B4E70", VA = "0x1828B6270")]
		public static Id32<LocalVariables.M> UHYLEXXZWIE(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x28B42C0", Offset = "0x28B2EC0", VA = "0x1828B42C0")]
		public static Id32<LocalVariables.M> NYJZXVRVPCP(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28B21E0", Offset = "0x28B0DE0", VA = "0x1828B21E0")]
		public static Id32<LocalVariables.M> CTZWOVHJODK(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28B4B60", Offset = "0x28B3760", VA = "0x1828B4B60")]
		public static Id32<LocalVariables.M> OMMAWONPAUV(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28B65D0", Offset = "0x28B51D0", VA = "0x1828B65D0")]
		public static Id32<LocalVariables.M> UZMGIHAORIZ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28B4DE0", Offset = "0x28B39E0", VA = "0x1828B4DE0")]
		public static Id32<LocalVariables.M> QHHYEDRWUDE(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28B3470", Offset = "0x28B2070", VA = "0x1828B3470")]
		public static Id32<LocalVariables.M> IAGUMMEYZWP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28B5180", Offset = "0x28B3D80", VA = "0x1828B5180")]
		public static Id32<LocalVariables.M> RMBWYAFBHIO(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28B2160", Offset = "0x28B0D60", VA = "0x1828B2160")]
		public static Id32<LocalVariables.M> CRUFBPSIVSF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28B20E0", Offset = "0x28B0CE0", VA = "0x1828B20E0")]
		public static Id32<LocalVariables.M> CKSKESOJLQQ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28B5200", Offset = "0x28B3E00", VA = "0x1828B5200")]
		public static Id32<LocalVariables.M> RQWBSDGKXJS(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28B2680", Offset = "0x28B1280", VA = "0x1828B2680")]
		public static Id32<LocalVariables.M> DLEPOWORFZB(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28B5040", Offset = "0x28B3C40", VA = "0x1828B5040")]
		public static Id32<LocalVariables.M> QNMOJRMIKYS(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x28B3F90", Offset = "0x28B2B90", VA = "0x1828B3F90")]
		public static Id32<LocalVariables.M> MMDEFWUUMVT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x28B41A0", Offset = "0x28B2DA0", VA = "0x1828B41A0")]
		public static Id32<LocalVariables.M> NEDYASRZRBE(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28B2C10", Offset = "0x28B1810", VA = "0x1828B2C10")]
		public static Id32<LocalVariables.M> GJPJSHGIAZN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28B38E0", Offset = "0x28B24E0", VA = "0x1828B38E0")]
		public static Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>> JKWZQYTASER(this FunctionCompileState a)
		{
			return default(Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x28B1EC0", Offset = "0x28B0AC0", VA = "0x1828B1EC0")]
		public static Id32<LocalVariables.M> BCEVRKLPLOG(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x28B2560", Offset = "0x28B1160", VA = "0x1828B2560")]
		public static Id32<LocalVariables.M> DKGFAGHWVPH(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28B4F00", Offset = "0x28B3B00", VA = "0x1828B4F00")]
		public static Id32<LocalVariables.M> QMAHQGPXUKI(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x28B3270", Offset = "0x28B1E70", VA = "0x1828B3270")]
		public static Id32<LocalVariables.M> HTOALJLDSGY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28B6A10", Offset = "0x28B5610", VA = "0x1828B6A10")]
		public static Id32<LocalVariables.M> XALPMNANZVF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x28B27B0", Offset = "0x28B13B0", VA = "0x1828B27B0")]
		public static Id32<LocalVariables.M> DSPONEYVGHA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28B3900", Offset = "0x28B2500", VA = "0x1828B3900")]
		public static Id32<LocalVariables.M> JUJQRRIXNZF(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28B4090", Offset = "0x28B2C90", VA = "0x1828B4090")]
		public static Id32<LocalVariables.M> NDRQIZFUNSE(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28B3F80", Offset = "0x28B2B80", VA = "0x1828B3F80")]
		public static void MHWSGFSWCPP(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28B43C0", Offset = "0x28B2FC0", VA = "0x1828B43C0")]
		public static Id32<LocalVariables.M> OHSOXQYLJHY(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x28B1FC0", Offset = "0x28B0BC0", VA = "0x1828B1FC0")]
		public static Id32<LocalVariables.M> CISYLGPFUHH(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x28B6130", Offset = "0x28B4D30", VA = "0x1828B6130")]
		public static Id32<LocalVariables.M> UDNDRPVSEQY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x28B2D50", Offset = "0x28B1950", VA = "0x1828B2D50")]
		public static Id32<LocalVariables.M> GNGPZCFKKEY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28B5480", Offset = "0x28B4080", VA = "0x1828B5480")]
		public static Id32<LocalVariables.M> SHPDVVNQSUH(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28B5A40", Offset = "0x28B4640", VA = "0x1828B5A40")]
		public static Id32<LocalVariables.M> SXGXRGDDTYG(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28B5B80", Offset = "0x28B4780", VA = "0x1828B5B80")]
		public static Id32<LocalVariables.M> TKFTFPUBWNY(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28B6390", Offset = "0x28B4F90", VA = "0x1828B6390")]
		public static Id32<LocalVariables.M> UJLVRFZXIGX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28B1C60", Offset = "0x28B0860", VA = "0x1828B1C60")]
		public static Id32<LocalVariables.M> APUIKUXZVJG(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28B6D50", Offset = "0x28B5950", VA = "0x1828B6D50")]
		public static Id32<LocalVariables.M> YDHSMFZLFKV(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3048E10", Offset = "0x3047A10", VA = "0x183048E10")]
		public static void PTSPVDREWJG<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<NFQUWHUKAZT> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, LGJNITTFOIP<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3047A70", Offset = "0x3046670", VA = "0x183047A70")]
		public static void IPORXLXXQVY<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<HDOGPWGYNWD> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, LGJNITTFOIP<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3049D10", Offset = "0x3048910", VA = "0x183049D10")]
		public static Id32<LocalVariables.M> RDDJSFUBZZS<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, LGJNITTFOIP<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3047550", Offset = "0x3046150", VA = "0x183047550")]
		public static Id32<LocalVariables.M> HHYYAVLHHHP<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, LGJNITTFOIP<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3047230", Offset = "0x3045E30", VA = "0x183047230")]
		public static Id32<DataBackResults.M> ERHQMJTXNGO<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, LGJNITTFOIP<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3049A10", Offset = "0x3048610", VA = "0x183049A10")]
		public static Id32<ExecForwardResults.M> QXYTFBNXTON<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, LGJNITTFOIP<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28B6750", Offset = "0x28B5350", VA = "0x1828B6750")]
		public static Id32<DataBackResults.M> VVSUJIHSKTB(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28B35B0", Offset = "0x28B21B0", VA = "0x1828B35B0")]
		public static Id32<DataBackResults.M> JKODVMMZLYJ(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3048220", Offset = "0x3046E20", VA = "0x183048220")]
		public static Id32<DataBackResults.M> JLZLVXOSIDO<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<NFQUWHUKAZT> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, LGJNITTFOIP<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3048400", Offset = "0x3047000", VA = "0x183048400")]
		private static Id32<DataBackResults.M> JLZLVXOSIDO<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<NFQUWHUKAZT> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, LGJNITTFOIP<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x30495C0", Offset = "0x30481C0", VA = "0x1830495C0")]
		public static Id32<LocalVariables.M> QUFJCRQVWWY<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, LGJNITTFOIP<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x304A2A0", Offset = "0x3048EA0", VA = "0x18304A2A0")]
		public static void SLPAYMCQJBH<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, LGJNITTFOIP<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<IMGRICEYMPU<FFTLZZJTBOR>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<IMGRICEYMPU<FFTLZZJTBOR>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
		public LiveInterval(Id32<IMGRICEYMPU<FFTLZZJTBOR>> firstUse, Id32<IMGRICEYMPU<FFTLZZJTBOR>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28BBA90", Offset = "0x28BA690", VA = "0x1828BBA90")]
		public static LiveInterval New(Id32<IMGRICEYMPU<FFTLZZJTBOR>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class QJZZCQWKQVH : XTZSILDTTXA
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
			[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class YEHHMPUFAXJ : XTZSILDTTXA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class TQZFXYHDEFK : XTZSILDTTXA
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
			[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
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
		public abstract class XTZSILDTTXA
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
			public Id32<XTZSILDTTXA> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x28BBA70", Offset = "0x28BA670", VA = "0x1828BBA70")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<XTZSILDTTXA> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class AHQLZUUTOHT : XTZSILDTTXA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<QJZZCQWKQVH, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<TQZFXYHDEFK, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<AHQLZUUTOHT, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<YEHHMPUFAXJ, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28BBC90", Offset = "0x28BA890", VA = "0x1828BBC90")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<QJZZCQWKQVH, ArgumentInst> argumentVariables, [In] SOAId32Field<TQZFXYHDEFK, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<AHQLZUUTOHT, ParameterInst> parameterVariables, [In] SOAId32Field<YEHHMPUFAXJ, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28BBAA0", Offset = "0x28BA6A0", VA = "0x1828BBAA0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class ZZPLDSZKVTM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28BD5E0", Offset = "0x28BC1E0", VA = "0x1828BD5E0")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class RWANAMFAFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28BCF50", Offset = "0x28BBB50", VA = "0x1828BCF50")]
		public static void BSJSXIIZGQA(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.TBEIFKKREIG, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28B7DC0", Offset = "0x28B69C0", VA = "0x1828B7DC0")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.TBEIFKKREIG, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28B7D50", Offset = "0x28B6950", VA = "0x1828B7D50")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28B7B30", Offset = "0x28B6730", VA = "0x1828B7B30")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3318A50", Offset = "0x3317650", VA = "0x183318A50")]
		public static void BSJSXIIZGQA<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<LJKQDQDPBOO> graphId) where TDeps : notnull, LGJNITTFOIP<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class OCWSRTAXCLR
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28BBE40", Offset = "0x28BAA40", VA = "0x1828BBE40")]
		public static void BSJSXIIZGQA(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface FSBDVIBXJEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void MPHHQPJHXPV(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : FSBDVIBXJEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x28BC3B0", Offset = "0x28BAFB0", VA = "0x1828BC3B0", Slot = "4")]
			public void MPHHQPJHXPV(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : FSBDVIBXJEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x28BC440", Offset = "0x28BB040", VA = "0x1828BC440", Slot = "4")]
			public void MPHHQPJHXPV(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : FSBDVIBXJEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x28BC270", Offset = "0x28BAE70", VA = "0x1828BC270", Slot = "4")]
			public void MPHHQPJHXPV(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : FSBDVIBXJEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x28BC300", Offset = "0x28BAF00", VA = "0x1828BC300", Slot = "4")]
			public void MPHHQPJHXPV(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class NEAWVWGXLSG<c> where c : struct, FSBDVIBXJEQ
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c GSCBNDREEJU;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x37DDE40", Offset = "0x37DCA40", VA = "0x1837DDE40")]
			public static int BSJSXIIZGQA<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : LGJNITTFOIP<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<FunctionCalls.TBEIFKKREIG>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28BBA20", Offset = "0x28BA620", VA = "0x1828BBA20")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<FunctionCalls.TBEIFKKREIG>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28BB970", Offset = "0x28BA570", VA = "0x1828BB970")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28BB930", Offset = "0x28BA530", VA = "0x1828BB930")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x371A150", Offset = "0x3718D50", VA = "0x18371A150")]
		public static void BSJSXIIZGQA<b, a>(FunctionCompileState a, b b, a c) where b : LGJNITTFOIP<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class QEKKJVHPLCA
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
		private static int VQNIQJZSRQO;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int DRGGJLZYGUA;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x28BC4F0", Offset = "0x28BB0F0", VA = "0x1828BC4F0")]
		public static void BSJSXIIZGQA(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28BCA50", Offset = "0x28BB650", VA = "0x1828BCA50")]
		private static void LFEAMEKQCFP([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28BCC60", Offset = "0x28BB860", VA = "0x1828BCC60")]
		private static void LFEAMEKQCFP(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28BCDA0", Offset = "0x28BB9A0", VA = "0x1828BCDA0")]
		private static void VDHFVDNBMQS(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class KOERPMZVBHO<a, b, c> where a : struct, ADIILXSHJEG<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a GSCBNDREEJU;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5168FE0", Offset = "0x5167BE0", VA = "0x185168FE0")]
		public static void BSJSXIIZGQA([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface ADIILXSHJEG<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> WYEIVPDXYGU(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NQCPSCSTRZK(a a, b b, Id32<IMGRICEYMPU<EJGGWQPBGFS>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface RWJEYBFOPOD<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a KUCKHOEFXYD(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RUDUUPWHLUB(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<IMGRICEYMPU<EJGGWQPBGFS>> YNICWTKUEJS(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class WXEIDCLIUCN<a, b, c> where a : struct, RWJEYBFOPOD<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a GSCBNDREEJU;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x65ADA70", Offset = "0x65AC670", VA = "0x1865ADA70")]
		public static UnsafeList<b> BSJSXIIZGQA(int a, [In] c values)
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
