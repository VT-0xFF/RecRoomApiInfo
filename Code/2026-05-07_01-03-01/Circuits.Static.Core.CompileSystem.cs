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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B89730", Offset = "0x2B88130", VA = "0x182B89730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
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
		public readonly Id32<TVAMPUAMYRD<RTIMFYESSKP>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
		public ByteCodeAdjustment(Id32<TVAMPUAMYRD<RTIMFYESSKP>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class BTJMIJOVXWH : MQOQGPXNKPF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2B28E50", Offset = "0x2B27850", VA = "0x182B28E50")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B879E0", Offset = "0x2B863E0", VA = "0x182B879E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class YZRLYJZJPBU : MQOQGPXNKPF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<TVAMPUAMYRD<NODNFPCIRRW>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0")]
			public DeadEnd(Id32<TVAMPUAMYRD<NODNFPCIRRW>> nextByteCodePtr)
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
		public abstract class MQOQGPXNKPF
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
			public readonly Id32<MQOQGPXNKPF> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
			public Inst(Def def, Id32<MQOQGPXNKPF> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class XXCNDSJFXDV : MQOQGPXNKPF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class TZFHEJPOSHD : MQOQGPXNKPF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x238B600", Offset = "0x238A000", VA = "0x18238B600", Slot = "3")]
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
		internal IdUnsafeList<BTJMIJOVXWH, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<YZRLYJZJPBU, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<XXCNDSJFXDV, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<TZFHEJPOSHD, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B87D60", Offset = "0x2B86760", VA = "0x182B87D60")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<BTJMIJOVXWH, BytesImmediate> bytesImmediates, [In] IdUnsafeList<YZRLYJZJPBU, DeadEnd> deadEnds, [In] IdUnsafeList<XXCNDSJFXDV, Variable> variables, [In] IdUnsafeList<TZFHEJPOSHD, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B87C20", Offset = "0x2B86620", VA = "0x182B87C20")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class VXQHKYPJTUA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B91A40", Offset = "0x2B90440", VA = "0x182B91A40")]
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
		public sealed class CFHUVULLRYW : MQOQGPXNKPF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0")]
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
		public abstract class MQOQGPXNKPF
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
			public readonly Id32<MQOQGPXNKPF> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
			public Inst(Def def, Id32<MQOQGPXNKPF> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<CFHUVULLRYW, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B87EE0", Offset = "0x2B868E0", VA = "0x182B87EE0")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<CFHUVULLRYW, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B87E50", Offset = "0x2B86850", VA = "0x182B87E50")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class EDHDVLSEQNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B87DF0", Offset = "0x2B867F0", VA = "0x182B87DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B87FC0", Offset = "0x2B869C0", VA = "0x182B87FC0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B87F20", Offset = "0x2B86920", VA = "0x182B87F20")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class TSOACCCQCWS
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B919F0", Offset = "0x2B903F0", VA = "0x182B919F0")]
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
		public sealed class NWSSIUZMQNW : MQOQGPXNKPF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<ZQREIDAFJOT> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0")]
			public ExternalCall(Id32<ZQREIDAFJOT> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class MQOQGPXNKPF
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
			public readonly Id32<MQOQGPXNKPF> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
			private Inst(Def def, Id32<MQOQGPXNKPF> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B89170", Offset = "0x2B87B70", VA = "0x182B89170")]
			public static Inst New(Def def, Id32<MQOQGPXNKPF> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class XTEOILVIZQK : MQOQGPXNKPF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<ZQREIDAFJOT> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0")]
			public InternalCall(Id32<ZQREIDAFJOT> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class ZQREIDAFJOT
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
			[Cpp2IlInjected.Address(RVA = "0x2B87EE0", Offset = "0x2B868E0", VA = "0x182B87EE0")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B88FC0", Offset = "0x2B879C0", VA = "0x182B88FC0")]
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
		internal IdUnsafeList<XTEOILVIZQK, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<NWSSIUZMQNW, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<ZQREIDAFJOT> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<ZQREIDAFJOT, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B881C0", Offset = "0x2B86BC0", VA = "0x182B881C0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<XTEOILVIZQK, InternalCall> internalCalls, [In] IdUnsafeList<NWSSIUZMQNW, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<ZQREIDAFJOT> IOId)> callsWithIO, [In] IdUnsafeList<ZQREIDAFJOT, IO> io, [In] SOAField<ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> ioModifyingCallLocations, [In] SOAField<ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B88020", Offset = "0x2B86A20", VA = "0x182B88020")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class JGOVLRTQDEY
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B891A0", Offset = "0x2B87BA0", VA = "0x182B891A0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B891F0", Offset = "0x2B87BF0", VA = "0x182B891F0")]
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
		internal SOAField<TCUAKPZLGNE, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<TCUAKPZLGNE>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B88C10", Offset = "0x2B87610", VA = "0x182B88C10")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<TCUAKPZLGNE, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<TCUAKPZLGNE>> generatedOutputsForExpression, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B88280", Offset = "0x2B86C80", VA = "0x182B88280")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class PCYIFIIHMPD
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : EGRXONDTOFW<Id32<FunctionCalls.ZQREIDAFJOT>, SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B91560", Offset = "0x2B8FF60", VA = "0x182B91560")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B91520", Offset = "0x2B8FF20", VA = "0x182B91520", Slot = "4")]
			public Id32<FunctionCalls.ZQREIDAFJOT> FUSWKJXUYYI(int a)
			{
				return default(Id32<FunctionCalls.ZQREIDAFJOT>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90")]
			public bool EVCXBYAUHFU(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "5")]
			private bool EMRJQVWZQCA(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B91510", Offset = "0x2B8FF10", VA = "0x182B91510", Slot = "6")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> EOUBUIRKCCR(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : WZJUIOKQXHX<Id32<FunctionCalls.ZQREIDAFJOT>, SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B86A20", Offset = "0x2B85420", VA = "0x182B86A20")]
			public UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>> OTQFHEWOHCJ(int a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B86B30", Offset = "0x2B85530", VA = "0x182B86B30")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B86A90", Offset = "0x2B85490", VA = "0x182B86A90", Slot = "6")]
			public void XROOKYXGFAD(Id32<FunctionCalls.ZQREIDAFJOT> a, SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> b, Id32<TVAMPUAMYRD<RTIMFYESSKP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B86A20", Offset = "0x2B85420", VA = "0x182B86A20", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>> SYKBHUGCFIY(int a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B86A10", Offset = "0x2B85410", VA = "0x182B86A10", Slot = "5")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> KQZBCDGRZUU(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : EGRXONDTOFW<Id32<FunctionCalls.ZQREIDAFJOT>, SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B91630", Offset = "0x2B90030", VA = "0x182B91630")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B915E0", Offset = "0x2B8FFE0", VA = "0x182B915E0", Slot = "4")]
			public Id32<FunctionCalls.ZQREIDAFJOT> FUSWKJXUYYI(int a)
			{
				return default(Id32<FunctionCalls.ZQREIDAFJOT>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90")]
			public bool EVCXBYAUHFU(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "5")]
			private bool IHWWKZRATIJ(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B91620", Offset = "0x2B90020", VA = "0x182B91620", Slot = "6")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> KIIWYCENEKY(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : WZJUIOKQXHX<Id32<FunctionCalls.ZQREIDAFJOT>, SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B86BC0", Offset = "0x2B855C0", VA = "0x182B86BC0")]
			public UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>> OTQFHEWOHCJ(int a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B86CD0", Offset = "0x2B856D0", VA = "0x182B86CD0")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B86C30", Offset = "0x2B85630", VA = "0x182B86C30", Slot = "6")]
			public void XROOKYXGFAD(Id32<FunctionCalls.ZQREIDAFJOT> a, SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> b, Id32<TVAMPUAMYRD<RTIMFYESSKP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B86BC0", Offset = "0x2B855C0", VA = "0x182B86BC0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>> HOIYFYFPRSN(int a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B86BB0", Offset = "0x2B855B0", VA = "0x182B86BB0", Slot = "5")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> GUPJSOPIHEL(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : EGRXONDTOFW<Id32<TMHZGRJSWQB>, SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2B91760", Offset = "0x2B90160", VA = "0x182B91760")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<TMHZGRJSWQB> a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2B91710", Offset = "0x2B90110", VA = "0x182B91710", Slot = "4")]
			public Id32<TMHZGRJSWQB> FUSWKJXUYYI(int a)
			{
				return default(Id32<TMHZGRJSWQB>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B916B0", Offset = "0x2B900B0", VA = "0x182B916B0")]
			public bool EVCXBYAUHFU(Id32<TMHZGRJSWQB> a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B916B0", Offset = "0x2B900B0", VA = "0x182B916B0", Slot = "5")]
			private bool VPJLVXDTIGX(Id32<TMHZGRJSWQB> a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B91750", Offset = "0x2B90150", VA = "0x182B91750", Slot = "6")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> QFQBRFUHOVI(Id32<TMHZGRJSWQB> a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : WZJUIOKQXHX<Id32<TMHZGRJSWQB>, SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2B86D50", Offset = "0x2B85750", VA = "0x182B86D50")]
			public UnsafeList<Id32<TMHZGRJSWQB>> OTQFHEWOHCJ(int a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(UnsafeList<Id32<TMHZGRJSWQB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B86ED0", Offset = "0x2B858D0", VA = "0x182B86ED0")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<TMHZGRJSWQB> a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B86DD0", Offset = "0x2B857D0", VA = "0x182B86DD0", Slot = "6")]
			public void XROOKYXGFAD(Id32<TMHZGRJSWQB> a, SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> b, Id32<TVAMPUAMYRD<RTIMFYESSKP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B86D50", Offset = "0x2B85750", VA = "0x182B86D50", Slot = "4")]
			private UnsafeList<Id32<TMHZGRJSWQB>> CTOKWJVSOCP(int a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(UnsafeList<Id32<TMHZGRJSWQB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B86DC0", Offset = "0x2B857C0", VA = "0x182B86DC0", Slot = "5")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> QFVWOAUGBRH(Id32<TMHZGRJSWQB> a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : EGRXONDTOFW<int, UnsafeList<(Id32<LocalVariables.M>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2B91960", Offset = "0x2B90360", VA = "0x182B91960")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD361D0", Offset = "0xD34BD0", VA = "0x180D361D0", Slot = "4")]
			public int FUSWKJXUYYI(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90")]
			public bool EVCXBYAUHFU(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "5")]
			private bool YOKZYUZULBA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B91950", Offset = "0x2B90350", VA = "0x182B91950", Slot = "6")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> BCVRUVDADJJ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : WZJUIOKQXHX<int, UnsafeList<(Id32<LocalVariables.M>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B873A0", Offset = "0x2B85DA0", VA = "0x182B873A0")]
			public UnsafeList<int> OTQFHEWOHCJ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B87520", Offset = "0x2B85F20", VA = "0x182B87520")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B87420", Offset = "0x2B85E20", VA = "0x182B87420", Slot = "6")]
			public void XROOKYXGFAD(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values, Id32<TVAMPUAMYRD<RTIMFYESSKP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B873A0", Offset = "0x2B85DA0", VA = "0x182B873A0", Slot = "4")]
			private UnsafeList<int> ALNITWNWVJC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B87410", Offset = "0x2B85E10", VA = "0x182B87410", Slot = "5")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> UIXFWWTWJWU(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : EGRXONDTOFW<int, UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2B918C0", Offset = "0x2B902C0", VA = "0x182B918C0")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD361D0", Offset = "0xD34BD0", VA = "0x180D361D0", Slot = "4")]
			public int FUSWKJXUYYI(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90")]
			public bool EVCXBYAUHFU(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "5")]
			private bool LPEFFVLUJZP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B918B0", Offset = "0x2B902B0", VA = "0x182B918B0", Slot = "6")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> CWTOWERFBFO(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : WZJUIOKQXHX<int, UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2B871A0", Offset = "0x2B85BA0", VA = "0x182B871A0")]
			public UnsafeList<int> OTQFHEWOHCJ(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B87310", Offset = "0x2B85D10", VA = "0x182B87310")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B87210", Offset = "0x2B85C10", VA = "0x182B87210", Slot = "6")]
			public void XROOKYXGFAD(int a, UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values, Id32<TVAMPUAMYRD<RTIMFYESSKP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B871A0", Offset = "0x2B85BA0", VA = "0x182B871A0", Slot = "4")]
			private UnsafeList<int> TBYORFQBRET(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B87190", Offset = "0x2B85B90", VA = "0x182B87190", Slot = "5")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> BMIEWIQUJFD(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : EGRXONDTOFW<int, UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2B91820", Offset = "0x2B90220", VA = "0x182B91820")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD361D0", Offset = "0xD34BD0", VA = "0x180D361D0", Slot = "4")]
			public int FUSWKJXUYYI(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90")]
			public bool EVCXBYAUHFU(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "5")]
			private bool LPEFFVLUJZP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2B91810", Offset = "0x2B90210", VA = "0x182B91810", Slot = "6")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> CWTOWERFBFO(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : WZJUIOKQXHX<int, UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2B86F90", Offset = "0x2B85990", VA = "0x182B86F90")]
			public UnsafeList<int> OTQFHEWOHCJ(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B87100", Offset = "0x2B85B00", VA = "0x182B87100")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B87000", Offset = "0x2B85A00", VA = "0x182B87000", Slot = "6")]
			public void XROOKYXGFAD(int a, UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values, Id32<TVAMPUAMYRD<RTIMFYESSKP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B86F90", Offset = "0x2B85990", VA = "0x182B86F90", Slot = "4")]
			private UnsafeList<int> TBYORFQBRET(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B86F80", Offset = "0x2B85980", VA = "0x182B86F80", Slot = "5")]
			private Id32<TVAMPUAMYRD<RTIMFYESSKP>> BMIEWIQUJFD(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1CB72C0", Offset = "0x1CB5CC0", VA = "0x181CB72C0")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B88FB0", Offset = "0x2B879B0", VA = "0x182B88FB0")]
			public void EVYASMPCYUQ([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<TMHZGRJSWQB> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B88F90", Offset = "0x2B87990", VA = "0x182B88F90")]
			public GenerateDataBackFromInputIndexResult(Id32<TMHZGRJSWQB> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B88F80", Offset = "0x2B87980", VA = "0x182B88F80")]
			public void EVYASMPCYUQ([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B88F60", Offset = "0x2B87960", VA = "0x182B88F60")]
			public void EVYASMPCYUQ([Out] Id32<DataBackResults.M> a, [Out] Id32<TMHZGRJSWQB> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<TMHZGRJSWQB> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
			public GenerateDataBackFromInputIndicesResult(Id32<TMHZGRJSWQB> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B88FA0", Offset = "0x2B879A0", VA = "0x182B88FA0")]
			public void EVYASMPCYUQ([Out] Id32<DataBackResults.M> a, [Out] Id32<TMHZGRJSWQB> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B89CF0", Offset = "0x2B886F0", VA = "0x182B89CF0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A630", Offset = "0x2B89030", VA = "0x182B8A630")]
		public static void HBPHGIALOFH(this FunctionCompileState a, Id32<TCUAKPZLGNE> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B89BC0", Offset = "0x2B885C0", VA = "0x182B89BC0")]
		public static void DDVWGJLUAWP(this FunctionCompileState a, Id32<TCUAKPZLGNE> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B080", Offset = "0x2B89A80", VA = "0x182B8B080")]
		public static Id32<DataBackResults.M>? NDPQSEYSPBO([In] this FunctionCompileState self, Id32<TCUAKPZLGNE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B89C90", Offset = "0x2B88690", VA = "0x182B89C90")]
		public static Id32<TVAMPUAMYRD<NODNFPCIRRW>> DKUUMUOGBDS([In] this FunctionCompileState self)
		{
			return default(Id32<TVAMPUAMYRD<NODNFPCIRRW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B100", Offset = "0x2B89B00", VA = "0x182B8B100")]
		private static void NWTOMCLVUAH(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B89960", Offset = "0x2B88360", VA = "0x182B89960")]
		private static Id32<TVAMPUAMYRD<NODNFPCIRRW>>? APBMEBRLLOE([In] this FunctionCompileState self, Id32<TMHZGRJSWQB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AB90", Offset = "0x2B89590", VA = "0x182B8AB90")]
		public static void KPMAITYCGTO(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A910", Offset = "0x2B89310", VA = "0x182B8A910")]
		public static DataBackResults.Def IIHAKUQJXTQ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A6C0", Offset = "0x2B890C0", VA = "0x182B8A6C0")]
		public static ReadOnlyArray<byte> HDBGXOICHRA([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AFA0", Offset = "0x2B899A0", VA = "0x182B8AFA0")]
		public static Id32<LocalVariables.M> MKSYIWZUITU([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AAB0", Offset = "0x2B894B0", VA = "0x182B8AAB0")]
		public static Union32 KKKMRKVTDIY([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D68A50", Offset = "0x3D67450", VA = "0x183D68A50")]
		private static Id32<DataBackResults.M> KNUJJFFAKEF<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.MQOQGPXNKPF
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BB20", Offset = "0x2B8A520", VA = "0x182B8BB20")]
		public static Id32<DataBackResults.M> XCVWHHHPNSJ(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B810", Offset = "0x2B8A210", VA = "0x182B8B810")]
		public static Id32<DataBackResults.M> TBQIVYBGWSQ(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BA30", Offset = "0x2B8A430", VA = "0x182B8BA30")]
		public static Id32<DataBackResults.M> VZUJDGDRTXJ(this FunctionCompileState a, Id32<TVAMPUAMYRD<NODNFPCIRRW>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A540", Offset = "0x2B88F40", VA = "0x182B8A540")]
		public static Id32<DataBackResults.M> GYLMFYAXMVV(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AA30", Offset = "0x2B89430", VA = "0x182B8AA30")]
		public static Id32<DataBackResults.M> KBFYJJBQYQE(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D69F40", Offset = "0x3D68940", VA = "0x183D69F40")]
		private static Id32<ExecForwardResults.M> LOAIKZWAGJM<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.MQOQGPXNKPF
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B89AF0", Offset = "0x2B884F0", VA = "0x182B89AF0")]
		public static Id32<ExecForwardResults.M> BRHJCOZVOVM(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B8F0", Offset = "0x2B8A2F0", VA = "0x182B8B8F0")]
		public static Id32<ExecForwardResults.M> UCKYOVETFQP(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B470", Offset = "0x2B89E70", VA = "0x182B8B470")]
		public static Id32<ExecForwardResults.M> OWTDQMJICIT(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B8A0", Offset = "0x2B8A2A0", VA = "0x182B8B8A0")]
		public static Id32<ExecForwardResults.M> UCINXSKTAME(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B940", Offset = "0x2B8A340", VA = "0x182B8B940")]
		public static Id32<ExecForwardResults.M> URLEPUGJJVY(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A5C0", Offset = "0x2B88FC0", VA = "0x182B8A5C0")]
		public static FunctionCalls.Def HADMZDBATZR([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B990", Offset = "0x2B8A390", VA = "0x182B8B990")]
		public static CopyEnumerable<Id32<FunctionCalls.ZQREIDAFJOT>, Id32Enumerator<FunctionCalls.ZQREIDAFJOT>> VDXQWHMYPCG([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.ZQREIDAFJOT>, Id32Enumerator<FunctionCalls.ZQREIDAFJOT>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B2A0", Offset = "0x2B89CA0", VA = "0x182B8B2A0")]
		public static Id32<FunctionCalls.ZQREIDAFJOT> OHWSMNFFCYR([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.ZQREIDAFJOT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B7A0", Offset = "0x2B8A1A0", VA = "0x182B8B7A0")]
		public static FunctionCalls.IO SPKMJLQIPBW([In] this FunctionCompileState self, Id32<FunctionCalls.ZQREIDAFJOT> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BAB0", Offset = "0x2B8A4B0", VA = "0x182B8BAB0")]
		public static FunctionCalls.IO WSZDUQXHXUG(this FunctionCompileState a, Id32<FunctionCalls.ZQREIDAFJOT> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D67FF0", Offset = "0x3D669F0", VA = "0x183D67FF0")]
		private static Id32<FunctionCalls.M> EYAOHFJXQAZ<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.MQOQGPXNKPF
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A0D0", Offset = "0x2B88AD0", VA = "0x182B8A0D0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>) FDHKUWIMUKY(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B897B0", Offset = "0x2B881B0", VA = "0x182B897B0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>) ABRFOCLMRPQ(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AD90", Offset = "0x2B89790", VA = "0x182B8AD90")]
		public static Id32<FunctionCalls.M> LHPATDLPWGD(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B89B30", Offset = "0x2B88530", VA = "0x182B89B30")]
		public static void BRYRGXEYEUO(this FunctionCompileState a, Id32<FunctionCalls.ZQREIDAFJOT> b, Id32<TVAMPUAMYRD<NODNFPCIRRW>> c, Id32<TVAMPUAMYRD<VFMZCREDNZR>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D68AF0", Offset = "0x3D674F0", VA = "0x183D68AF0")]
		public static GenerateDataBackResult KUYIBVMTNCE<d, e>(this FunctionCompileState a, d b, e c, Id32<MHARATWVONH> d, Id32<TMHZGRJSWQB> e) where d : ZFMZEQYTVOK<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D68080", Offset = "0x3D66A80", VA = "0x183D68080")]
		public static GenerateDataBackFromInputIndexResult FAAKGEAZBTC<f, g>(this FunctionCompileState a, f b, g c, Id32<MHARATWVONH> d, Id32<TOXCFTIABCD> e, int f) where f : ZFMZEQYTVOK<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3D684E0", Offset = "0x3D66EE0", VA = "0x183D684E0")]
		public static Id32<DataBackResults.M>? GGQWMDZWNPT<h, i>(this FunctionCompileState a, h b, i c, Id32<MHARATWVONH> d, Id32<TOXCFTIABCD> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : ZFMZEQYTVOK<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A2A0", Offset = "0x3D68CA0", VA = "0x183D6A2A0")]
		public static Id32<ExecForwardResults.M> UVXAWHXBYEL<j, k>(this FunctionCompileState a, j b, k c, Id32<MHARATWVONH> d, Id32<TCUAKPZLGNE> e) where j : ZFMZEQYTVOK<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ADE0", Offset = "0x2B897E0", VA = "0x182B8ADE0")]
		public static LocalVariables.ArgumentInst LPEKVPSGMOX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B899E0", Offset = "0x2B883E0", VA = "0x182B899E0")]
		public static LocalVariables.CalleeReturnValueInst AZLBMDEXYRP([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B89FC0", Offset = "0x2B889C0", VA = "0x182B89FC0")]
		public static LocalVariables.CallerReturnValueInst ELHKXSYTAAW([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A390", Offset = "0x2B88D90", VA = "0x182B8A390")]
		public static Id32<LocalVariables.M> GXIUYFODNAW(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BBA0", Offset = "0x2B8A5A0", VA = "0x182B8BBA0")]
		public static LocalVariables.ParameterInst XWPXLTWKMDV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B750", Offset = "0x2B8A150", VA = "0x182B8B750")]
		public static LocalVariables.Def RFVVAUXTGFV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A8C0", Offset = "0x2B892C0", VA = "0x182B8A8C0")]
		public static int? IGTWYJPOIRX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3D69FE0", Offset = "0x3D689E0", VA = "0x183D69FE0")]
		private static Id32<LocalVariables.M> PNVBTPIMJMJ<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.MQOQGPXNKPF
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A980", Offset = "0x2B89380", VA = "0x182B8A980")]
		public static Id32<LocalVariables.M> JVVSSLOEQMR(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B9D0", Offset = "0x2B8A3D0", VA = "0x182B8B9D0")]
		public static Id32<LocalVariables.M> VHNUNDDCYPM(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B5D0", Offset = "0x2B89FD0", VA = "0x182B8B5D0")]
		public static Id32<LocalVariables.M> RDNVTYQLDES(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AD00", Offset = "0x2B89700", VA = "0x182B8AD00")]
		public static Id32<LocalVariables.M> LDUPCZCLKQM(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BD40", Offset = "0x2B8A740", VA = "0x182B8BD40")]
		public static Id32<LocalVariables.M> ZTGDYEAPQAQ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A7A0", Offset = "0x2B891A0", VA = "0x182B8A7A0")]
		public static void HRGJCYPNUZT(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A280", Offset = "0x2B88C80", VA = "0x182B8A280")]
		public static void GGKKLIJQTWT(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AEF0", Offset = "0x2B898F0", VA = "0x182B8AEF0")]
		public static void MFYWKNMAVFN(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BCB0", Offset = "0x2B8A6B0", VA = "0x182B8BCB0")]
		public static void ZCREGJWQOPO(this FunctionCompileState a, Id32<TVAMPUAMYRD<NODNFPCIRRW>> b, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B4F0", Offset = "0x2B89EF0", VA = "0x182B8B4F0")]
		public static void PDUFXUNYNSQ(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<TVAMPUAMYRD<ETDEUPYEIAF>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A1C0", Offset = "0x3D68BC0", VA = "0x183D6A1C0")]
		public static void RMHWSZJWWJH<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<TVAMPUAMYRD<XSPVEGMZPQH<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface ZFMZEQYTVOK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<PLGQQUCWUUF> SMRZGIQVGYV(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<PLGQQUCWUUF> KCBRSDDSTIA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<PLGQQUCWUUF> CZBDUMTALXX(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<PLGQQUCWUUF> PXAKUEFUIPQ(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> QQHWSMTCXIY(a a, FunctionCompileState b, Id32<MHARATWVONH> c, Id32<TMHZGRJSWQB> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> GQFLAYMKIOU(a a, FunctionCompileState b, Id32<MHARATWVONH> c, Id32<TCUAKPZLGNE> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int TXHIEOYUQTA(a a, Id32<MHARATWVONH> b, Id32<TMHZGRJSWQB> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<TCUAKPZLGNE> NQPGJBEIOEZ(a a, Id32<MHARATWVONH> b, Id32<TMHZGRJSWQB> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind LAAGJHXYPJC(a a, Id32<MHARATWVONH> b, Id32<TMHZGRJSWQB> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool VPUGWFRSPVH(a a, Id32<MHARATWVONH> b, Id32<TMHZGRJSWQB> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int GVMADWQBVQW(a a, Id32<MHARATWVONH> b, Id32<TMHZGRJSWQB> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> KVXYVFYZKSI(a a, Id32<MHARATWVONH> b, Id32<TMHZGRJSWQB> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<PLGQQUCWUUF>) DZKXPMUNSNQ(a a, Id32<MHARATWVONH> b, Id32<TMHZGRJSWQB> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int AAYWWHCZAAM(a a, Id32<MHARATWVONH> b, Id32<TCUAKPZLGNE> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<TMHZGRJSWQB> FFNONBRGWZX(a a, Id32<MHARATWVONH> b, Id32<TCUAKPZLGNE> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<TMHZGRJSWQB> CQAZPJTVTPG(a a, Id32<MHARATWVONH> b, Id32<TOXCFTIABCD> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int XFWOFXPXAGY(a a, Id32<MHARATWVONH> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? XVIRVJBMVOG(a a, Id32<MHARATWVONH> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int SUBDTBBFOUO(a a, Id32<MHARATWVONH> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? FNMUSQHDCLS(a a, Id32<MHARATWVONH> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class QUKQJPNHYEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E27EE0", Offset = "0x3E268E0", VA = "0x183E27EE0")]
		public static Id32<LocalVariables.M?> KRDLAEDHHEG<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E290A0", Offset = "0x3E27AA0", VA = "0x183E290A0")]
		public static Id32<LocalVariables.M?> ZYYNCIOEKSX<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E256A0", Offset = "0x3E240A0", VA = "0x183E256A0")]
		public static Id32<LocalVariables.M?> BPFMJJHDUWS<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B90F50", Offset = "0x2B8F950", VA = "0x182B90F50")]
		public static Id32<LocalVariables.M> ZEEASFPTOFU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B90DA0", Offset = "0x2B8F7A0", VA = "0x182B90DA0")]
		public static Id32<LocalVariables.M> XYUFOMMNJOZ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E5A0", Offset = "0x2B8CFA0", VA = "0x182B8E5A0")]
		public static Id32<LocalVariables.M> KYUFKKQVBYY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FC70", Offset = "0x2B8E670", VA = "0x182B8FC70")]
		public static Id32<LocalVariables.M> SZZFHRAKUAU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EAF0", Offset = "0x2B8D4F0", VA = "0x182B8EAF0")]
		public static Id32<LocalVariables.M> NGMILRXZBNV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FE70", Offset = "0x2B8E870", VA = "0x182B8FE70")]
		public static Id32<LocalVariables.M> TYBRTXLYGTQ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FB70", Offset = "0x2B8E570", VA = "0x182B8FB70")]
		public static Id32<LocalVariables.M> SHCHONPMUWG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B912D0", Offset = "0x2B8FCD0", VA = "0x182B912D0")]
		public static Id32<LocalVariables.M> ZWHCUXZKFLL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C260", Offset = "0x2B8AC60", VA = "0x182B8C260")]
		public static Id32<LocalVariables.M> AUNLVJKCBRG(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D860", Offset = "0x2B8C260", VA = "0x182B8D860")]
		public static Id32<LocalVariables.M> HMPYBRYNVLH(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F230", Offset = "0x2B8DC30", VA = "0x182B8F230")]
		public static Id32<LocalVariables.M> OSWTHTLYANE(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D310", Offset = "0x2B8BD10", VA = "0x182B8D310")]
		public static Id32<LocalVariables.M> FEGWXGWTHXZ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D960", Offset = "0x2B8C360", VA = "0x182B8D960")]
		public static Id32<LocalVariables.M> HRFJATDKQZC(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E8A0", Offset = "0x2B8D2A0", VA = "0x182B8E8A0")]
		public static Id32<LocalVariables.M> MEVJJUJRNUX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C660", Offset = "0x2B8B060", VA = "0x182B8C660")]
		public static Id32<LocalVariables.M> CBHGQEMTBZI(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F600", Offset = "0x2B8E000", VA = "0x182B8F600")]
		public static Id32<LocalVariables.M> QGBXJYLGESG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F1B0", Offset = "0x2B8DBB0", VA = "0x182B8F1B0")]
		public static Id32<LocalVariables.M> ONKOVAAKZIR(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F780", Offset = "0x2B8E180", VA = "0x182B8F780")]
		public static Id32<LocalVariables.M> QZXETOYZPHC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D290", Offset = "0x2B8BC90", VA = "0x182B8D290")]
		public static Id32<LocalVariables.M> ETERVEBPKBJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DEB0", Offset = "0x2B8C8B0", VA = "0x182B8DEB0")]
		public static Id32<LocalVariables.M> JEETOZAOUOY(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F3D0", Offset = "0x2B8DDD0", VA = "0x182B8F3D0")]
		public static Id32<LocalVariables.M> PCBHDRAVUHP(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D7E0", Offset = "0x2B8C1E0", VA = "0x182B8D7E0")]
		public static Id32<LocalVariables.M> HKVYBFWSUBR(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D760", Offset = "0x2B8C160", VA = "0x182B8D760")]
		public static Id32<LocalVariables.M> GJYSUMEDNTS(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D210", Offset = "0x2B8BC10", VA = "0x182B8D210")]
		public static Id32<LocalVariables.M> EJBLZEPBBVH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C7A0", Offset = "0x2B8B1A0", VA = "0x182B8C7A0")]
		public static Id32<LocalVariables.M> CJHPVKRVRTQ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C5E0", Offset = "0x2B8AFE0", VA = "0x182B8C5E0")]
		public static Id32<LocalVariables.M> BRGWAOUQNOF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DCF0", Offset = "0x2B8C6F0", VA = "0x182B8DCF0")]
		public static Id32<LocalVariables.M> IOJAJDLLVZW(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EF90", Offset = "0x2B8D990", VA = "0x182B8EF90")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> OJEOAOGEQUY(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E520", Offset = "0x2B8CF20", VA = "0x182B8E520")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> JXSLMLTNYYQ(this FunctionCompileState a, int b)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F560", Offset = "0x2B8DF60", VA = "0x182B8F560")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> PRTEOFZSXPB(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CF10", Offset = "0x2B8B910", VA = "0x182B8CF10")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> DUPBTHQMIFL(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B90EC0", Offset = "0x2B8F8C0", VA = "0x182B90EC0")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> YLQQYWEFHEN(this FunctionCompileState a, int b)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E800", Offset = "0x2B8D200", VA = "0x182B8E800")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> LTMWWHYBWQS(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FFB0", Offset = "0x2B8E9B0", VA = "0x182B8FFB0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>) VKRUGICKJPF(this FunctionCompileState a, Id32<JIFIDYBYJAI> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B90450", Offset = "0x2B8EE50", VA = "0x182B90450")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>) WNEUJSYEGMJ(this FunctionCompileState a, Id32<AUNNIJUAVXE> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E289B0", Offset = "0x3E273B0", VA = "0x183E289B0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<PLGQQUCWUUF>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<TMarker>>, Id32<FunctionCalls.M>) TNQGSSNGJIO<TMarker>(this FunctionCompileState a, Id32<PLGQQUCWUUF> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<PLGQQUCWUUF>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF30", Offset = "0x2B8C930", VA = "0x182B8DF30")]
		public static Id32<LocalVariables.M> JRSUBITUHLC(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F800", Offset = "0x2B8E200", VA = "0x182B8F800")]
		public static Id32<LocalVariables.M> RCJHMRBGRQH(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D670", Offset = "0x2B8C070", VA = "0x182B8D670")]
		public static Id32<LocalVariables.M> GHPXRKUXNAE(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B913F0", Offset = "0x2B8FDF0", VA = "0x182B913F0")]
		public static Id32<LocalVariables.M> ZYZCLRSHOVR(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FD70", Offset = "0x2B8E770", VA = "0x182B8FD70")]
		public static Id32<LocalVariables.M> TLIJHBKFXBW(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ED30", Offset = "0x2B8D730", VA = "0x182B8ED30")]
		public static Id32<LocalVariables.M> NMWARFOTWZJ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B90C60", Offset = "0x2B8F660", VA = "0x182B90C60")]
		public static Id32<LocalVariables.M> XLJJDDKOJXQ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B91150", Offset = "0x2B8FB50", VA = "0x182B91150")]
		public static Id32<LocalVariables.M> ZPJLGYSRPHQ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E9D0", Offset = "0x2B8D3D0", VA = "0x182B8E9D0")]
		public static Id32<LocalVariables.M> MNSALBHOTIZ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C820", Offset = "0x2B8B220", VA = "0x182B8C820")]
		public static Id32<LocalVariables.M> CSYFRXVOTWU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F350", Offset = "0x2B8DD50", VA = "0x182B8F350")]
		public static Id32<LocalVariables.M> PBYQERFWCMT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F9F0", Offset = "0x2B8E3F0", VA = "0x182B8F9F0")]
		public static Id32<LocalVariables.M> RNCUXWGUPHS(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B91250", Offset = "0x2B8FC50", VA = "0x182B91250")]
		public static Id32<LocalVariables.M> ZUEMMMTISEN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B90A20", Offset = "0x2B8F420", VA = "0x182B90A20")]
		public static Id32<LocalVariables.M> WVTILJANOHF(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B908F0", Offset = "0x2B8F2F0", VA = "0x182B908F0")]
		public static Id32<LocalVariables.M> WTDCPNRYMBC(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C4A0", Offset = "0x2B8AEA0", VA = "0x182B8C4A0")]
		public static Id32<LocalVariables.M> BREJGICKAJL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C3A0", Offset = "0x2B8ADA0", VA = "0x182B8C3A0")]
		public static Id32<LocalVariables.M> BMCZYTCUIYS(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E6E0", Offset = "0x2B8D0E0", VA = "0x182B8E6E0")]
		public static Id32<LocalVariables.M> LBDSFTKSRGN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C960", Offset = "0x2B8B360", VA = "0x182B8C960")]
		public static Id32<LocalVariables.M> CVQFZHVWDVG(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F190", Offset = "0x2B8DB90", VA = "0x182B8F190")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> OLJVOZWUCZK(this FunctionCompileState a)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FA70", Offset = "0x2B8E470", VA = "0x182B8FA70")]
		public static Id32<LocalVariables.M> SASCCROACZT(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C020", Offset = "0x2B8AA20", VA = "0x182B8C020")]
		public static Id32<LocalVariables.M> AJQBGOFHPNU(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA60", Offset = "0x2B8C460", VA = "0x182B8DA60")]
		public static Id32<LocalVariables.M> HWCITTJPTLB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B91050", Offset = "0x2B8FA50", VA = "0x182B91050")]
		public static Id32<LocalVariables.M> ZHOSUMCQDKD(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EC10", Offset = "0x2B8D610", VA = "0x182B8EC10")]
		public static Id32<LocalVariables.M> NMPJGLSRXUY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CDD0", Offset = "0x2B8B7D0", VA = "0x182B8CDD0")]
		public static Id32<LocalVariables.M> DCMWIZILYWZ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F680", Offset = "0x2B8E080", VA = "0x182B8F680")]
		public static Id32<LocalVariables.M> QOEQZBNEVME(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F450", Offset = "0x2B8DE50", VA = "0x182B8F450")]
		public static Id32<LocalVariables.M> PGRDBAGNYYX(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B90F40", Offset = "0x2B8F940", VA = "0x182B90F40")]
		public static void YWDEGVDFTOK(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D110", Offset = "0x2B8BB10", VA = "0x182B8D110")]
		public static Id32<LocalVariables.M> EHOBWQUHUDD(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DFF0", Offset = "0x2B8C9F0", VA = "0x182B8DFF0")]
		public static Id32<LocalVariables.M> JTDZXRRHFRY(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B90B20", Offset = "0x2B8F520", VA = "0x182B90B20")]
		public static Id32<LocalVariables.M> XIYURJNWXKH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F8F0", Offset = "0x2B8E2F0", VA = "0x182B8F8F0")]
		public static Id32<LocalVariables.M> RHXVAXDNMEX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D450", Offset = "0x2B8BE50", VA = "0x182B8D450")]
		public static Id32<LocalVariables.M> FNPHEDVHDPO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EE50", Offset = "0x2B8D850", VA = "0x182B8EE50")]
		public static Id32<LocalVariables.M> OHQCPANNNWZ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E110", Offset = "0x2B8CB10", VA = "0x182B8E110")]
		public static Id32<LocalVariables.M> JVOKLLQMCJP(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D570", Offset = "0x2B8BF70", VA = "0x182B8D570")]
		public static Id32<LocalVariables.M> GBNSTKMLGDA(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C140", Offset = "0x2B8AB40", VA = "0x182B8C140")]
		public static Id32<LocalVariables.M> ALDTUIAKVIV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DD70", Offset = "0x2B8C770", VA = "0x182B8DD70")]
		public static Id32<LocalVariables.M> IZPAFRBNNSA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3E27590", Offset = "0x3E25F90", VA = "0x183E27590")]
		public static void KPXDHXVWBTX<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<JIFIDYBYJAI> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3E280D0", Offset = "0x3E26AD0", VA = "0x183E280D0")]
		public static void NPPHWRXOOHF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<AUNNIJUAVXE> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3E269E0", Offset = "0x3E253E0", VA = "0x183E269E0")]
		public static Id32<LocalVariables.M> GNDXKYLPFSF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3E27070", Offset = "0x3E25A70", VA = "0x183E27070")]
		public static Id32<LocalVariables.M> KMOBGQNYCKW<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3E257D0", Offset = "0x3E241D0", VA = "0x183E257D0")]
		public static Id32<DataBackResults.M> CKOAELEKLVR<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, ZFMZEQYTVOK<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3E25AF0", Offset = "0x3E244F0", VA = "0x183E25AF0")]
		public static Id32<ExecForwardResults.M> DBWCJUAQQME<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, ZFMZEQYTVOK<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DBA0", Offset = "0x2B8C5A0", VA = "0x182B8DBA0")]
		public static Id32<DataBackResults.M> ILXEYLYEGPC(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CAA0", Offset = "0x2B8B4A0", VA = "0x182B8CAA0")]
		public static Id32<DataBackResults.M> CZQBPQJEILY(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3E25DF0", Offset = "0x3E247F0", VA = "0x183E25DF0")]
		public static Id32<DataBackResults.M> EFQCVEYFAYF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<JIFIDYBYJAI> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3E25FD0", Offset = "0x3E249D0", VA = "0x183E25FD0")]
		private static Id32<DataBackResults.M> EFQCVEYFAYF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<JIFIDYBYJAI> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3E28AC0", Offset = "0x3E274C0", VA = "0x183E28AC0")]
		public static Id32<LocalVariables.M> TXQQBJSEUAV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3E26D00", Offset = "0x3E25700", VA = "0x183E26D00")]
		public static void KISWJJLPLIM<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<TVAMPUAMYRD<NODNFPCIRRW>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<TVAMPUAMYRD<NODNFPCIRRW>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
		public LiveInterval(Id32<TVAMPUAMYRD<NODNFPCIRRW>> firstUse, Id32<TVAMPUAMYRD<NODNFPCIRRW>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B89400", Offset = "0x2B87E00", VA = "0x182B89400")]
		public static LiveInterval New(Id32<TVAMPUAMYRD<NODNFPCIRRW>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class KTGRMQGGNGI : MQOQGPXNKPF
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
			[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class EOHMMELFEBK : MQOQGPXNKPF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class NCQFOUDIIXJ : MQOQGPXNKPF
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
			[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
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
		public abstract class MQOQGPXNKPF
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
			public Id32<MQOQGPXNKPF> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2B89180", Offset = "0x2B87B80", VA = "0x182B89180")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<MQOQGPXNKPF> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class LUZAOGOIWKW : MQOQGPXNKPF
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<KTGRMQGGNGI, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<NCQFOUDIIXJ, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<LUZAOGOIWKW, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<EOHMMELFEBK, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B89600", Offset = "0x2B88000", VA = "0x182B89600")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<KTGRMQGGNGI, ArgumentInst> argumentVariables, [In] SOAId32Field<NCQFOUDIIXJ, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<LUZAOGOIWKW, ParameterInst> parameterVariables, [In] SOAId32Field<EOHMMELFEBK, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B89410", Offset = "0x2B87E10", VA = "0x182B89410")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class AYTYIGOXZAX
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B86960", Offset = "0x2B85360", VA = "0x182B86960")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class BYURTYLJPSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B87880", Offset = "0x2B86280", VA = "0x182B87880")]
		public static void EKJSQNSQNQN(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.ZQREIDAFJOT, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B87840", Offset = "0x2B86240", VA = "0x182B87840")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.ZQREIDAFJOT, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B877D0", Offset = "0x2B861D0", VA = "0x182B877D0")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B875B0", Offset = "0x2B85FB0", VA = "0x182B875B0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x368D7B0", Offset = "0x368C1B0", VA = "0x18368D7B0")]
		public static void EKJSQNSQNQN<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<MHARATWVONH> graphId) where TDeps : notnull, ZFMZEQYTVOK<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class DJUPHBFTKXC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B87A50", Offset = "0x2B86450", VA = "0x182B87A50")]
		public static void EKJSQNSQNQN(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface EILJYZHYSBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void URQJWNBESUE(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : EILJYZHYSBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BEE0", Offset = "0x2B8A8E0", VA = "0x182B8BEE0", Slot = "4")]
			public void URQJWNBESUE(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : EILJYZHYSBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BF70", Offset = "0x2B8A970", VA = "0x182B8BF70", Slot = "4")]
			public void URQJWNBESUE(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : EILJYZHYSBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BDA0", Offset = "0x2B8A7A0", VA = "0x182B8BDA0", Slot = "4")]
			public void URQJWNBESUE(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : EILJYZHYSBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BE30", Offset = "0x2B8A830", VA = "0x182B8BE30", Slot = "4")]
			public void URQJWNBESUE(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class QCABFMTYSMD<c> where c : struct, EILJYZHYSBB
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c ANTAOVGZRYP;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3E819F0", Offset = "0x3E803F0", VA = "0x183E819F0")]
			public static int EKJSQNSQNQN<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : ZFMZEQYTVOK<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<FunctionCalls.ZQREIDAFJOT>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B89130", Offset = "0x2B87B30", VA = "0x182B89130")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<FunctionCalls.ZQREIDAFJOT>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B89080", Offset = "0x2B87A80", VA = "0x182B89080")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B89040", Offset = "0x2B87A40", VA = "0x182B89040")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4F40", Offset = "0x3BB3940", VA = "0x183BB4F40")]
		public static void EKJSQNSQNQN<b, a>(FunctionCompileState a, b b, a c) where b : ZFMZEQYTVOK<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class AKOVPLRKSBH
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
		private static int ILJFNDDQCJX;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int YJJMEDNMUKP;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B863B0", Offset = "0x2B84DB0", VA = "0x182B863B0")]
		public static void EKJSQNSQNQN(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B86040", Offset = "0x2B84A40", VA = "0x182B86040")]
		private static void BTIDIWDXFVC([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B85F00", Offset = "0x2B84900", VA = "0x182B85F00")]
		private static void BTIDIWDXFVC(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B86250", Offset = "0x2B84C50", VA = "0x182B86250")]
		private static void DDUYJLIPGTJ(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class LCUYHUISUUF<a, b, c> where a : struct, WZJUIOKQXHX<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a ANTAOVGZRYP;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x693EBA0", Offset = "0x693D5A0", VA = "0x18693EBA0")]
		public static void EKJSQNSQNQN([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface WZJUIOKQXHX<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> OTQFHEWOHCJ(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XROOKYXGFAD(a a, b b, Id32<TVAMPUAMYRD<RTIMFYESSKP>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface EGRXONDTOFW<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a FUSWKJXUYYI(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool EVCXBYAUHFU(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class IVNIMASPWYI<a, b, c> where a : struct, EGRXONDTOFW<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a ANTAOVGZRYP;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6604060", Offset = "0x6602A60", VA = "0x186604060")]
		public static UnsafeList<b> EKJSQNSQNQN(int a, [In] c values)
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
