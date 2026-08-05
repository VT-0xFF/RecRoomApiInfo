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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA84F0", Offset = "0x2BA6EF0", VA = "0x182BA84F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEE1960", Offset = "0xEE0360", VA = "0x180EE1960")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B48210", Offset = "0x2B46C10", VA = "0x182B48210")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2BA67A0", Offset = "0x2BA51A0", VA = "0x182BA67A0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x15FBC00", Offset = "0x15FA600", VA = "0x1815FBC00")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE1960", Offset = "0xEE0360", VA = "0x180EE1960")]
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
			[Cpp2IlInjected.Address(RVA = "0x15FBC00", Offset = "0x15FA600", VA = "0x1815FBC00")]
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
			[Cpp2IlInjected.Address(RVA = "0x15FBC00", Offset = "0x15FA600", VA = "0x1815FBC00")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x23A6F10", Offset = "0x23A5910", VA = "0x1823A6F10", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA6B20", Offset = "0x2BA5520", VA = "0x182BA6B20")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<BTJMIJOVXWH, BytesImmediate> bytesImmediates, [In] IdUnsafeList<YZRLYJZJPBU, DeadEnd> deadEnds, [In] IdUnsafeList<XXCNDSJFXDV, Variable> variables, [In] IdUnsafeList<TZFHEJPOSHD, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BA69E0", Offset = "0x2BA53E0", VA = "0x182BA69E0")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class VXQHKYPJTUA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0800", Offset = "0x2BAF200", VA = "0x182BB0800")]
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
			[Cpp2IlInjected.Address(RVA = "0x15FBC00", Offset = "0x15FA600", VA = "0x1815FBC00")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE1960", Offset = "0xEE0360", VA = "0x180EE1960")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA6CA0", Offset = "0x2BA56A0", VA = "0x182BA6CA0")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<CFHUVULLRYW, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6C10", Offset = "0x2BA5610", VA = "0x182BA6C10")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class EDHDVLSEQNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6BB0", Offset = "0x2BA55B0", VA = "0x182BA6BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA6D80", Offset = "0x2BA5780", VA = "0x182BA6D80")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6CE0", Offset = "0x2BA56E0", VA = "0x182BA6CE0")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class TSOACCCQCWS
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BB07B0", Offset = "0x2BAF1B0", VA = "0x182BB07B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15FBC00", Offset = "0x15FA600", VA = "0x1815FBC00")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE1960", Offset = "0xEE0360", VA = "0x180EE1960")]
			private Inst(Def def, Id32<MQOQGPXNKPF> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7F30", Offset = "0x2BA6930", VA = "0x182BA7F30")]
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
			[Cpp2IlInjected.Address(RVA = "0x15FBC00", Offset = "0x15FA600", VA = "0x1815FBC00")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA6CA0", Offset = "0x2BA56A0", VA = "0x182BA6CA0")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7D80", Offset = "0x2BA6780", VA = "0x182BA7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA6F80", Offset = "0x2BA5980", VA = "0x182BA6F80")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<XTEOILVIZQK, InternalCall> internalCalls, [In] IdUnsafeList<NWSSIUZMQNW, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<ZQREIDAFJOT> IOId)> callsWithIO, [In] IdUnsafeList<ZQREIDAFJOT, IO> io, [In] SOAField<ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> ioModifyingCallLocations, [In] SOAField<ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6DE0", Offset = "0x2BA57E0", VA = "0x182BA6DE0")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class JGOVLRTQDEY
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7F60", Offset = "0x2BA6960", VA = "0x182BA7F60")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7FB0", Offset = "0x2BA69B0", VA = "0x182BA7FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA79D0", Offset = "0x2BA63D0", VA = "0x182BA79D0")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<TCUAKPZLGNE, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<TCUAKPZLGNE>> generatedOutputsForExpression, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7040", Offset = "0x2BA5A40", VA = "0x182BA7040")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BB0320", Offset = "0x2BAED20", VA = "0x182BB0320")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB02E0", Offset = "0x2BAECE0", VA = "0x182BB02E0", Slot = "4")]
			public Id32<FunctionCalls.ZQREIDAFJOT> FUSWKJXUYYI(int a)
			{
				return default(Id32<FunctionCalls.ZQREIDAFJOT>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80")]
			public bool EVCXBYAUHFU(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "5")]
			private bool EMRJQVWZQCA(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2BB02D0", Offset = "0x2BAECD0", VA = "0x182BB02D0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA57E0", Offset = "0x2BA41E0", VA = "0x182BA57E0")]
			public UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>> OTQFHEWOHCJ(int a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2BA58F0", Offset = "0x2BA42F0", VA = "0x182BA58F0")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5850", Offset = "0x2BA4250", VA = "0x182BA5850", Slot = "6")]
			public void XROOKYXGFAD(Id32<FunctionCalls.ZQREIDAFJOT> a, SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> b, Id32<TVAMPUAMYRD<RTIMFYESSKP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2BA57E0", Offset = "0x2BA41E0", VA = "0x182BA57E0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>> SYKBHUGCFIY(int a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<NODNFPCIRRW>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2BA57D0", Offset = "0x2BA41D0", VA = "0x182BA57D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BB03F0", Offset = "0x2BAEDF0", VA = "0x182BB03F0")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2BB03A0", Offset = "0x2BAEDA0", VA = "0x182BB03A0", Slot = "4")]
			public Id32<FunctionCalls.ZQREIDAFJOT> FUSWKJXUYYI(int a)
			{
				return default(Id32<FunctionCalls.ZQREIDAFJOT>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80")]
			public bool EVCXBYAUHFU(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "5")]
			private bool IHWWKZRATIJ(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2BB03E0", Offset = "0x2BAEDE0", VA = "0x182BB03E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA5980", Offset = "0x2BA4380", VA = "0x182BA5980")]
			public UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>> OTQFHEWOHCJ(int a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5A90", Offset = "0x2BA4490", VA = "0x182BA5A90")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<FunctionCalls.ZQREIDAFJOT> a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2BA59F0", Offset = "0x2BA43F0", VA = "0x182BA59F0", Slot = "6")]
			public void XROOKYXGFAD(Id32<FunctionCalls.ZQREIDAFJOT> a, SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> b, Id32<TVAMPUAMYRD<RTIMFYESSKP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5980", Offset = "0x2BA4380", VA = "0x182BA5980", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>> HOIYFYFPRSN(int a, [In] SOAField<FunctionCalls.ZQREIDAFJOT, Id32<TVAMPUAMYRD<VFMZCREDNZR>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.ZQREIDAFJOT>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5970", Offset = "0x2BA4370", VA = "0x182BA5970", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BB0520", Offset = "0x2BAEF20", VA = "0x182BB0520")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<TMHZGRJSWQB> a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2BB04D0", Offset = "0x2BAEED0", VA = "0x182BB04D0", Slot = "4")]
			public Id32<TMHZGRJSWQB> FUSWKJXUYYI(int a)
			{
				return default(Id32<TMHZGRJSWQB>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0470", Offset = "0x2BAEE70", VA = "0x182BB0470")]
			public bool EVCXBYAUHFU(Id32<TMHZGRJSWQB> a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0470", Offset = "0x2BAEE70", VA = "0x182BB0470", Slot = "5")]
			private bool VPJLVXDTIGX(Id32<TMHZGRJSWQB> a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0510", Offset = "0x2BAEF10", VA = "0x182BB0510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA5B10", Offset = "0x2BA4510", VA = "0x182BA5B10")]
			public UnsafeList<Id32<TMHZGRJSWQB>> OTQFHEWOHCJ(int a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(UnsafeList<Id32<TMHZGRJSWQB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5C90", Offset = "0x2BA4690", VA = "0x182BA5C90")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(Id32<TMHZGRJSWQB> a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5B90", Offset = "0x2BA4590", VA = "0x182BA5B90", Slot = "6")]
			public void XROOKYXGFAD(Id32<TMHZGRJSWQB> a, SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> b, Id32<TVAMPUAMYRD<RTIMFYESSKP>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5B10", Offset = "0x2BA4510", VA = "0x182BA5B10", Slot = "4")]
			private UnsafeList<Id32<TMHZGRJSWQB>> CTOKWJVSOCP(int a, [In] SOAField<TMHZGRJSWQB, Id32<TVAMPUAMYRD<NODNFPCIRRW>>?> values)
			{
				return default(UnsafeList<Id32<TMHZGRJSWQB>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5B80", Offset = "0x2BA4580", VA = "0x182BA5B80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BB0720", Offset = "0x2BAF120", VA = "0x182BB0720")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD6F560", Offset = "0xD6DF60", VA = "0x180D6F560", Slot = "4")]
			public int FUSWKJXUYYI(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80")]
			public bool EVCXBYAUHFU(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "5")]
			private bool YOKZYUZULBA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0710", Offset = "0x2BAF110", VA = "0x182BB0710", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA6160", Offset = "0x2BA4B60", VA = "0x182BA6160")]
			public UnsafeList<int> OTQFHEWOHCJ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BA62E0", Offset = "0x2BA4CE0", VA = "0x182BA62E0")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2BA61E0", Offset = "0x2BA4BE0", VA = "0x182BA61E0", Slot = "6")]
			public void XROOKYXGFAD(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values, Id32<TVAMPUAMYRD<RTIMFYESSKP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2BA6160", Offset = "0x2BA4B60", VA = "0x182BA6160", Slot = "4")]
			private UnsafeList<int> ALNITWNWVJC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<TVAMPUAMYRD<XSPVEGMZPQH<RTIMFYESSKP>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2BA61D0", Offset = "0x2BA4BD0", VA = "0x182BA61D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BB0680", Offset = "0x2BAF080", VA = "0x182BB0680")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD6F560", Offset = "0xD6DF60", VA = "0x180D6F560", Slot = "4")]
			public int FUSWKJXUYYI(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80")]
			public bool EVCXBYAUHFU(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "5")]
			private bool LPEFFVLUJZP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0670", Offset = "0x2BAF070", VA = "0x182BB0670", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA5F60", Offset = "0x2BA4960", VA = "0x182BA5F60")]
			public UnsafeList<int> OTQFHEWOHCJ(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA60D0", Offset = "0x2BA4AD0", VA = "0x182BA60D0")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5FD0", Offset = "0x2BA49D0", VA = "0x182BA5FD0", Slot = "6")]
			public void XROOKYXGFAD(int a, UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values, Id32<TVAMPUAMYRD<RTIMFYESSKP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5F60", Offset = "0x2BA4960", VA = "0x182BA5F60", Slot = "4")]
			private UnsafeList<int> TBYORFQBRET(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5F50", Offset = "0x2BA4950", VA = "0x182BA5F50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BB05E0", Offset = "0x2BAEFE0", VA = "0x182BB05E0")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD6F560", Offset = "0xD6DF60", VA = "0x180D6F560", Slot = "4")]
			public int FUSWKJXUYYI(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80")]
			public bool EVCXBYAUHFU(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "5")]
			private bool LPEFFVLUJZP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2BB05D0", Offset = "0x2BAEFD0", VA = "0x182BB05D0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA5D50", Offset = "0x2BA4750", VA = "0x182BA5D50")]
			public UnsafeList<int> OTQFHEWOHCJ(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5EC0", Offset = "0x2BA48C0", VA = "0x182BA5EC0")]
			public Id32<TVAMPUAMYRD<RTIMFYESSKP>> YUNDGWQDTYP(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5DC0", Offset = "0x2BA47C0", VA = "0x182BA5DC0", Slot = "6")]
			public void XROOKYXGFAD(int a, UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values, Id32<TVAMPUAMYRD<RTIMFYESSKP>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5D50", Offset = "0x2BA4750", VA = "0x182BA5D50", Slot = "4")]
			private UnsafeList<int> TBYORFQBRET(int a, [In] UnsafeList<(Id32<TVAMPUAMYRD<NODNFPCIRRW>> Target, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5D40", Offset = "0x2BA4740", VA = "0x182BA5D40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1CAFD90", Offset = "0x1CAE790", VA = "0x181CAFD90")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7D70", Offset = "0x2BA6770", VA = "0x182BA7D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA7D50", Offset = "0x2BA6750", VA = "0x182BA7D50")]
			public GenerateDataBackFromInputIndexResult(Id32<TMHZGRJSWQB> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7D40", Offset = "0x2BA6740", VA = "0x182BA7D40")]
			public void EVYASMPCYUQ([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7D20", Offset = "0x2BA6720", VA = "0x182BA7D20")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE1960", Offset = "0xEE0360", VA = "0x180EE1960")]
			public GenerateDataBackFromInputIndicesResult(Id32<TMHZGRJSWQB> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7D60", Offset = "0x2BA6760", VA = "0x182BA7D60")]
			public void EVYASMPCYUQ([Out] Id32<DataBackResults.M> a, [Out] Id32<TMHZGRJSWQB> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8AB0", Offset = "0x2BA74B0", VA = "0x182BA8AB0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2BA93F0", Offset = "0x2BA7DF0", VA = "0x182BA93F0")]
		public static void HBPHGIALOFH(this FunctionCompileState a, Id32<TCUAKPZLGNE> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8980", Offset = "0x2BA7380", VA = "0x182BA8980")]
		public static void DDVWGJLUAWP(this FunctionCompileState a, Id32<TCUAKPZLGNE> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9E40", Offset = "0x2BA8840", VA = "0x182BA9E40")]
		public static Id32<DataBackResults.M>? NDPQSEYSPBO([In] this FunctionCompileState self, Id32<TCUAKPZLGNE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8A50", Offset = "0x2BA7450", VA = "0x182BA8A50")]
		public static Id32<TVAMPUAMYRD<NODNFPCIRRW>> DKUUMUOGBDS([In] this FunctionCompileState self)
		{
			return default(Id32<TVAMPUAMYRD<NODNFPCIRRW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9EC0", Offset = "0x2BA88C0", VA = "0x182BA9EC0")]
		private static void NWTOMCLVUAH(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8720", Offset = "0x2BA7120", VA = "0x182BA8720")]
		private static Id32<TVAMPUAMYRD<NODNFPCIRRW>>? APBMEBRLLOE([In] this FunctionCompileState self, Id32<TMHZGRJSWQB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9950", Offset = "0x2BA8350", VA = "0x182BA9950")]
		public static void KPMAITYCGTO(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA96D0", Offset = "0x2BA80D0", VA = "0x182BA96D0")]
		public static DataBackResults.Def IIHAKUQJXTQ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9480", Offset = "0x2BA7E80", VA = "0x182BA9480")]
		public static ReadOnlyArray<byte> HDBGXOICHRA([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9D60", Offset = "0x2BA8760", VA = "0x182BA9D60")]
		public static Id32<LocalVariables.M> MKSYIWZUITU([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9870", Offset = "0x2BA8270", VA = "0x182BA9870")]
		public static Union32 KKKMRKVTDIY([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F200", Offset = "0x3D7DC00", VA = "0x183D7F200")]
		private static Id32<DataBackResults.M> KNUJJFFAKEF<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.MQOQGPXNKPF
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA8E0", Offset = "0x2BA92E0", VA = "0x182BAA8E0")]
		public static Id32<DataBackResults.M> XCVWHHHPNSJ(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA5D0", Offset = "0x2BA8FD0", VA = "0x182BAA5D0")]
		public static Id32<DataBackResults.M> TBQIVYBGWSQ(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA7F0", Offset = "0x2BA91F0", VA = "0x182BAA7F0")]
		public static Id32<DataBackResults.M> VZUJDGDRTXJ(this FunctionCompileState a, Id32<TVAMPUAMYRD<NODNFPCIRRW>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9300", Offset = "0x2BA7D00", VA = "0x182BA9300")]
		public static Id32<DataBackResults.M> GYLMFYAXMVV(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BA97F0", Offset = "0x2BA81F0", VA = "0x182BA97F0")]
		public static Id32<DataBackResults.M> KBFYJJBQYQE(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D806F0", Offset = "0x3D7F0F0", VA = "0x183D806F0")]
		private static Id32<ExecForwardResults.M> LOAIKZWAGJM<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.MQOQGPXNKPF
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BA88B0", Offset = "0x2BA72B0", VA = "0x182BA88B0")]
		public static Id32<ExecForwardResults.M> BRHJCOZVOVM(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA6B0", Offset = "0x2BA90B0", VA = "0x182BAA6B0")]
		public static Id32<ExecForwardResults.M> UCKYOVETFQP(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA230", Offset = "0x2BA8C30", VA = "0x182BAA230")]
		public static Id32<ExecForwardResults.M> OWTDQMJICIT(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA660", Offset = "0x2BA9060", VA = "0x182BAA660")]
		public static Id32<ExecForwardResults.M> UCINXSKTAME(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA700", Offset = "0x2BA9100", VA = "0x182BAA700")]
		public static Id32<ExecForwardResults.M> URLEPUGJJVY(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9380", Offset = "0x2BA7D80", VA = "0x182BA9380")]
		public static FunctionCalls.Def HADMZDBATZR([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA750", Offset = "0x2BA9150", VA = "0x182BAA750")]
		public static CopyEnumerable<Id32<FunctionCalls.ZQREIDAFJOT>, Id32Enumerator<FunctionCalls.ZQREIDAFJOT>> VDXQWHMYPCG([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.ZQREIDAFJOT>, Id32Enumerator<FunctionCalls.ZQREIDAFJOT>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA060", Offset = "0x2BA8A60", VA = "0x182BAA060")]
		public static Id32<FunctionCalls.ZQREIDAFJOT> OHWSMNFFCYR([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.ZQREIDAFJOT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA560", Offset = "0x2BA8F60", VA = "0x182BAA560")]
		public static FunctionCalls.IO SPKMJLQIPBW([In] this FunctionCompileState self, Id32<FunctionCalls.ZQREIDAFJOT> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA870", Offset = "0x2BA9270", VA = "0x182BAA870")]
		public static FunctionCalls.IO WSZDUQXHXUG(this FunctionCompileState a, Id32<FunctionCalls.ZQREIDAFJOT> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E7A0", Offset = "0x3D7D1A0", VA = "0x183D7E7A0")]
		private static Id32<FunctionCalls.M> EYAOHFJXQAZ<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.MQOQGPXNKPF
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8E90", Offset = "0x2BA7890", VA = "0x182BA8E90")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>) FDHKUWIMUKY(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8570", Offset = "0x2BA6F70", VA = "0x182BA8570")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>) ABRFOCLMRPQ(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9B50", Offset = "0x2BA8550", VA = "0x182BA9B50")]
		public static Id32<FunctionCalls.M> LHPATDLPWGD(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BA88F0", Offset = "0x2BA72F0", VA = "0x182BA88F0")]
		public static void BRYRGXEYEUO(this FunctionCompileState a, Id32<FunctionCalls.ZQREIDAFJOT> b, Id32<TVAMPUAMYRD<NODNFPCIRRW>> c, Id32<TVAMPUAMYRD<VFMZCREDNZR>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F2A0", Offset = "0x3D7DCA0", VA = "0x183D7F2A0")]
		public static GenerateDataBackResult KUYIBVMTNCE<d, e>(this FunctionCompileState a, d b, e c, Id32<MHARATWVONH> d, Id32<TMHZGRJSWQB> e) where d : ZFMZEQYTVOK<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E830", Offset = "0x3D7D230", VA = "0x183D7E830")]
		public static GenerateDataBackFromInputIndexResult FAAKGEAZBTC<f, g>(this FunctionCompileState a, f b, g c, Id32<MHARATWVONH> d, Id32<TOXCFTIABCD> e, int f) where f : ZFMZEQYTVOK<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3D7EC90", Offset = "0x3D7D690", VA = "0x183D7EC90")]
		public static Id32<DataBackResults.M>? GGQWMDZWNPT<h, i>(this FunctionCompileState a, h b, i c, Id32<MHARATWVONH> d, Id32<TOXCFTIABCD> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : ZFMZEQYTVOK<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3D80A50", Offset = "0x3D7F450", VA = "0x183D80A50")]
		public static Id32<ExecForwardResults.M> UVXAWHXBYEL<j, k>(this FunctionCompileState a, j b, k c, Id32<MHARATWVONH> d, Id32<TCUAKPZLGNE> e) where j : ZFMZEQYTVOK<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9BA0", Offset = "0x2BA85A0", VA = "0x182BA9BA0")]
		public static LocalVariables.ArgumentInst LPEKVPSGMOX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA87A0", Offset = "0x2BA71A0", VA = "0x182BA87A0")]
		public static LocalVariables.CalleeReturnValueInst AZLBMDEXYRP([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8D80", Offset = "0x2BA7780", VA = "0x182BA8D80")]
		public static LocalVariables.CallerReturnValueInst ELHKXSYTAAW([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9150", Offset = "0x2BA7B50", VA = "0x182BA9150")]
		public static Id32<LocalVariables.M> GXIUYFODNAW(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA960", Offset = "0x2BA9360", VA = "0x182BAA960")]
		public static LocalVariables.ParameterInst XWPXLTWKMDV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA510", Offset = "0x2BA8F10", VA = "0x182BAA510")]
		public static LocalVariables.Def RFVVAUXTGFV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9680", Offset = "0x2BA8080", VA = "0x182BA9680")]
		public static int? IGTWYJPOIRX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3D80790", Offset = "0x3D7F190", VA = "0x183D80790")]
		private static Id32<LocalVariables.M> PNVBTPIMJMJ<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.MQOQGPXNKPF
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9740", Offset = "0x2BA8140", VA = "0x182BA9740")]
		public static Id32<LocalVariables.M> JVVSSLOEQMR(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA790", Offset = "0x2BA9190", VA = "0x182BAA790")]
		public static Id32<LocalVariables.M> VHNUNDDCYPM(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA390", Offset = "0x2BA8D90", VA = "0x182BAA390")]
		public static Id32<LocalVariables.M> RDNVTYQLDES(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9AC0", Offset = "0x2BA84C0", VA = "0x182BA9AC0")]
		public static Id32<LocalVariables.M> LDUPCZCLKQM(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAB00", Offset = "0x2BA9500", VA = "0x182BAAB00")]
		public static Id32<LocalVariables.M> ZTGDYEAPQAQ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9560", Offset = "0x2BA7F60", VA = "0x182BA9560")]
		public static void HRGJCYPNUZT(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9040", Offset = "0x2BA7A40", VA = "0x182BA9040")]
		public static void GGKKLIJQTWT(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9CB0", Offset = "0x2BA86B0", VA = "0x182BA9CB0")]
		public static void MFYWKNMAVFN(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAA70", Offset = "0x2BA9470", VA = "0x182BAAA70")]
		public static void ZCREGJWQOPO(this FunctionCompileState a, Id32<TVAMPUAMYRD<NODNFPCIRRW>> b, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA2B0", Offset = "0x2BA8CB0", VA = "0x182BAA2B0")]
		public static void PDUFXUNYNSQ(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<TVAMPUAMYRD<ETDEUPYEIAF>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3D80970", Offset = "0x3D7F370", VA = "0x183D80970")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E4B610", Offset = "0x3E4A010", VA = "0x183E4B610")]
		public static Id32<LocalVariables.M?> KRDLAEDHHEG<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E4C7E0", Offset = "0x3E4B1E0", VA = "0x183E4C7E0")]
		public static Id32<LocalVariables.M?> ZYYNCIOEKSX<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E48DC0", Offset = "0x3E477C0", VA = "0x183E48DC0")]
		public static Id32<LocalVariables.M?> BPFMJJHDUWS<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFD10", Offset = "0x2BAE710", VA = "0x182BAFD10")]
		public static Id32<LocalVariables.M> ZEEASFPTOFU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFB60", Offset = "0x2BAE560", VA = "0x182BAFB60")]
		public static Id32<LocalVariables.M> XYUFOMMNJOZ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD360", Offset = "0x2BABD60", VA = "0x182BAD360")]
		public static Id32<LocalVariables.M> KYUFKKQVBYY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEA30", Offset = "0x2BAD430", VA = "0x182BAEA30")]
		public static Id32<LocalVariables.M> SZZFHRAKUAU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD8B0", Offset = "0x2BAC2B0", VA = "0x182BAD8B0")]
		public static Id32<LocalVariables.M> NGMILRXZBNV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEC30", Offset = "0x2BAD630", VA = "0x182BAEC30")]
		public static Id32<LocalVariables.M> TYBRTXLYGTQ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE930", Offset = "0x2BAD330", VA = "0x182BAE930")]
		public static Id32<LocalVariables.M> SHCHONPMUWG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0090", Offset = "0x2BAEA90", VA = "0x182BB0090")]
		public static Id32<LocalVariables.M> ZWHCUXZKFLL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB020", Offset = "0x2BA9A20", VA = "0x182BAB020")]
		public static Id32<LocalVariables.M> AUNLVJKCBRG(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC620", Offset = "0x2BAB020", VA = "0x182BAC620")]
		public static Id32<LocalVariables.M> HMPYBRYNVLH(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2BADFF0", Offset = "0x2BAC9F0", VA = "0x182BADFF0")]
		public static Id32<LocalVariables.M> OSWTHTLYANE(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC0D0", Offset = "0x2BAAAD0", VA = "0x182BAC0D0")]
		public static Id32<LocalVariables.M> FEGWXGWTHXZ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC720", Offset = "0x2BAB120", VA = "0x182BAC720")]
		public static Id32<LocalVariables.M> HRFJATDKQZC(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD660", Offset = "0x2BAC060", VA = "0x182BAD660")]
		public static Id32<LocalVariables.M> MEVJJUJRNUX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB420", Offset = "0x2BA9E20", VA = "0x182BAB420")]
		public static Id32<LocalVariables.M> CBHGQEMTBZI(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE3C0", Offset = "0x2BACDC0", VA = "0x182BAE3C0")]
		public static Id32<LocalVariables.M> QGBXJYLGESG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BADF70", Offset = "0x2BAC970", VA = "0x182BADF70")]
		public static Id32<LocalVariables.M> ONKOVAAKZIR(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE540", Offset = "0x2BACF40", VA = "0x182BAE540")]
		public static Id32<LocalVariables.M> QZXETOYZPHC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC050", Offset = "0x2BAAA50", VA = "0x182BAC050")]
		public static Id32<LocalVariables.M> ETERVEBPKBJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BACC70", Offset = "0x2BAB670", VA = "0x182BACC70")]
		public static Id32<LocalVariables.M> JEETOZAOUOY(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE190", Offset = "0x2BACB90", VA = "0x182BAE190")]
		public static Id32<LocalVariables.M> PCBHDRAVUHP(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC5A0", Offset = "0x2BAAFA0", VA = "0x182BAC5A0")]
		public static Id32<LocalVariables.M> HKVYBFWSUBR(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC520", Offset = "0x2BAAF20", VA = "0x182BAC520")]
		public static Id32<LocalVariables.M> GJYSUMEDNTS(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BABFD0", Offset = "0x2BAA9D0", VA = "0x182BABFD0")]
		public static Id32<LocalVariables.M> EJBLZEPBBVH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB560", Offset = "0x2BA9F60", VA = "0x182BAB560")]
		public static Id32<LocalVariables.M> CJHPVKRVRTQ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB3A0", Offset = "0x2BA9DA0", VA = "0x182BAB3A0")]
		public static Id32<LocalVariables.M> BRGWAOUQNOF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BACAB0", Offset = "0x2BAB4B0", VA = "0x182BACAB0")]
		public static Id32<LocalVariables.M> IOJAJDLLVZW(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BADD50", Offset = "0x2BAC750", VA = "0x182BADD50")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> OJEOAOGEQUY(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD2E0", Offset = "0x2BABCE0", VA = "0x182BAD2E0")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> JXSLMLTNYYQ(this FunctionCompileState a, int b)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE320", Offset = "0x2BACD20", VA = "0x182BAE320")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> PRTEOFZSXPB(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BABCD0", Offset = "0x2BAA6D0", VA = "0x182BABCD0")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> DUPBTHQMIFL(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFC80", Offset = "0x2BAE680", VA = "0x182BAFC80")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> YLQQYWEFHEN(this FunctionCompileState a, int b)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD5C0", Offset = "0x2BABFC0", VA = "0x182BAD5C0")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> LTMWWHYBWQS(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BAED70", Offset = "0x2BAD770", VA = "0x182BAED70")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>) VKRUGICKJPF(this FunctionCompileState a, Id32<JIFIDYBYJAI> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF210", Offset = "0x2BADC10", VA = "0x182BAF210")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>) WNEUJSYEGMJ(this FunctionCompileState a, Id32<AUNNIJUAVXE> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.ZQREIDAFJOT>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E4C0F0", Offset = "0x3E4AAF0", VA = "0x183E4C0F0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<PLGQQUCWUUF>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<TMarker>>, Id32<FunctionCalls.M>) TNQGSSNGJIO<TMarker>(this FunctionCompileState a, Id32<PLGQQUCWUUF> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<PLGQQUCWUUF>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2BACCF0", Offset = "0x2BAB6F0", VA = "0x182BACCF0")]
		public static Id32<LocalVariables.M> JRSUBITUHLC(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE5C0", Offset = "0x2BACFC0", VA = "0x182BAE5C0")]
		public static Id32<LocalVariables.M> RCJHMRBGRQH(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC430", Offset = "0x2BAAE30", VA = "0x182BAC430")]
		public static Id32<LocalVariables.M> GHPXRKUXNAE(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2BB01B0", Offset = "0x2BAEBB0", VA = "0x182BB01B0")]
		public static Id32<LocalVariables.M> ZYZCLRSHOVR(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEB30", Offset = "0x2BAD530", VA = "0x182BAEB30")]
		public static Id32<LocalVariables.M> TLIJHBKFXBW(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BADAF0", Offset = "0x2BAC4F0", VA = "0x182BADAF0")]
		public static Id32<LocalVariables.M> NMWARFOTWZJ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFA20", Offset = "0x2BAE420", VA = "0x182BAFA20")]
		public static Id32<LocalVariables.M> XLJJDDKOJXQ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFF10", Offset = "0x2BAE910", VA = "0x182BAFF10")]
		public static Id32<LocalVariables.M> ZPJLGYSRPHQ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD790", Offset = "0x2BAC190", VA = "0x182BAD790")]
		public static Id32<LocalVariables.M> MNSALBHOTIZ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB5E0", Offset = "0x2BA9FE0", VA = "0x182BAB5E0")]
		public static Id32<LocalVariables.M> CSYFRXVOTWU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE110", Offset = "0x2BACB10", VA = "0x182BAE110")]
		public static Id32<LocalVariables.M> PBYQERFWCMT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE7B0", Offset = "0x2BAD1B0", VA = "0x182BAE7B0")]
		public static Id32<LocalVariables.M> RNCUXWGUPHS(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0010", Offset = "0x2BAEA10", VA = "0x182BB0010")]
		public static Id32<LocalVariables.M> ZUEMMMTISEN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF7E0", Offset = "0x2BAE1E0", VA = "0x182BAF7E0")]
		public static Id32<LocalVariables.M> WVTILJANOHF(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF6B0", Offset = "0x2BAE0B0", VA = "0x182BAF6B0")]
		public static Id32<LocalVariables.M> WTDCPNRYMBC(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB260", Offset = "0x2BA9C60", VA = "0x182BAB260")]
		public static Id32<LocalVariables.M> BREJGICKAJL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB160", Offset = "0x2BA9B60", VA = "0x182BAB160")]
		public static Id32<LocalVariables.M> BMCZYTCUIYS(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD4A0", Offset = "0x2BABEA0", VA = "0x182BAD4A0")]
		public static Id32<LocalVariables.M> LBDSFTKSRGN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB720", Offset = "0x2BAA120", VA = "0x182BAB720")]
		public static Id32<LocalVariables.M> CVQFZHVWDVG(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BADF50", Offset = "0x2BAC950", VA = "0x182BADF50")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>> OLJVOZWUCZK(this FunctionCompileState a)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE830", Offset = "0x2BAD230", VA = "0x182BAE830")]
		public static Id32<LocalVariables.M> SASCCROACZT(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BAADE0", Offset = "0x2BA97E0", VA = "0x182BAADE0")]
		public static Id32<LocalVariables.M> AJQBGOFHPNU(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC820", Offset = "0x2BAB220", VA = "0x182BAC820")]
		public static Id32<LocalVariables.M> HWCITTJPTLB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFE10", Offset = "0x2BAE810", VA = "0x182BAFE10")]
		public static Id32<LocalVariables.M> ZHOSUMCQDKD(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD9D0", Offset = "0x2BAC3D0", VA = "0x182BAD9D0")]
		public static Id32<LocalVariables.M> NMPJGLSRXUY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BABB90", Offset = "0x2BAA590", VA = "0x182BABB90")]
		public static Id32<LocalVariables.M> DCMWIZILYWZ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE440", Offset = "0x2BACE40", VA = "0x182BAE440")]
		public static Id32<LocalVariables.M> QOEQZBNEVME(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE210", Offset = "0x2BACC10", VA = "0x182BAE210")]
		public static Id32<LocalVariables.M> PGRDBAGNYYX(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFD00", Offset = "0x2BAE700", VA = "0x182BAFD00")]
		public static void YWDEGVDFTOK(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BABED0", Offset = "0x2BAA8D0", VA = "0x182BABED0")]
		public static Id32<LocalVariables.M> EHOBWQUHUDD(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BACDB0", Offset = "0x2BAB7B0", VA = "0x182BACDB0")]
		public static Id32<LocalVariables.M> JTDZXRRHFRY(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF8E0", Offset = "0x2BAE2E0", VA = "0x182BAF8E0")]
		public static Id32<LocalVariables.M> XIYURJNWXKH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE6B0", Offset = "0x2BAD0B0", VA = "0x182BAE6B0")]
		public static Id32<LocalVariables.M> RHXVAXDNMEX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC210", Offset = "0x2BAAC10", VA = "0x182BAC210")]
		public static Id32<LocalVariables.M> FNPHEDVHDPO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BADC10", Offset = "0x2BAC610", VA = "0x182BADC10")]
		public static Id32<LocalVariables.M> OHQCPANNNWZ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BACED0", Offset = "0x2BAB8D0", VA = "0x182BACED0")]
		public static Id32<LocalVariables.M> JVOKLLQMCJP(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC330", Offset = "0x2BAAD30", VA = "0x182BAC330")]
		public static Id32<LocalVariables.M> GBNSTKMLGDA(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAF00", Offset = "0x2BA9900", VA = "0x182BAAF00")]
		public static Id32<LocalVariables.M> ALDTUIAKVIV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BACB30", Offset = "0x2BAB530", VA = "0x182BACB30")]
		public static Id32<LocalVariables.M> IZPAFRBNNSA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3E4ACB0", Offset = "0x3E496B0", VA = "0x183E4ACB0")]
		public static void KPXDHXVWBTX<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<JIFIDYBYJAI> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B800", Offset = "0x3E4A200", VA = "0x183E4B800")]
		public static void NPPHWRXOOHF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<AUNNIJUAVXE> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A100", Offset = "0x3E48B00", VA = "0x183E4A100")]
		public static Id32<LocalVariables.M> GNDXKYLPFSF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A790", Offset = "0x3E49190", VA = "0x183E4A790")]
		public static Id32<LocalVariables.M> KMOBGQNYCKW<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3E48EF0", Offset = "0x3E478F0", VA = "0x183E48EF0")]
		public static Id32<DataBackResults.M> CKOAELEKLVR<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, ZFMZEQYTVOK<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3E49210", Offset = "0x3E47C10", VA = "0x183E49210")]
		public static Id32<ExecForwardResults.M> DBWCJUAQQME<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, ZFMZEQYTVOK<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC960", Offset = "0x2BAB360", VA = "0x182BAC960")]
		public static Id32<DataBackResults.M> ILXEYLYEGPC(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB860", Offset = "0x2BAA260", VA = "0x182BAB860")]
		public static Id32<DataBackResults.M> CZQBPQJEILY(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3E49510", Offset = "0x3E47F10", VA = "0x183E49510")]
		public static Id32<DataBackResults.M> EFQCVEYFAYF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<JIFIDYBYJAI> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3E496F0", Offset = "0x3E480F0", VA = "0x183E496F0")]
		private static Id32<DataBackResults.M> EFQCVEYFAYF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<JIFIDYBYJAI> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3E4C200", Offset = "0x3E4AC00", VA = "0x183E4C200")]
		public static Id32<LocalVariables.M> TXQQBJSEUAV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, ZFMZEQYTVOK<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A420", Offset = "0x3E48E20", VA = "0x183E4A420")]
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
		[Cpp2IlInjected.Address(RVA = "0xEE1960", Offset = "0xEE0360", VA = "0x180EE1960")]
		public LiveInterval(Id32<TVAMPUAMYRD<NODNFPCIRRW>> firstUse, Id32<TVAMPUAMYRD<NODNFPCIRRW>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA81C0", Offset = "0x2BA6BC0", VA = "0x182BA81C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE1960", Offset = "0xEE0360", VA = "0x180EE1960")]
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
			[Cpp2IlInjected.Address(RVA = "0x15FBC00", Offset = "0x15FA600", VA = "0x1815FBC00")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE1960", Offset = "0xEE0360", VA = "0x180EE1960")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA7F40", Offset = "0x2BA6940", VA = "0x182BA7F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x15FBC00", Offset = "0x15FA600", VA = "0x1815FBC00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA83C0", Offset = "0x2BA6DC0", VA = "0x182BA83C0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<KTGRMQGGNGI, ArgumentInst> argumentVariables, [In] SOAId32Field<NCQFOUDIIXJ, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<LUZAOGOIWKW, ParameterInst> parameterVariables, [In] SOAId32Field<EOHMMELFEBK, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BA81D0", Offset = "0x2BA6BD0", VA = "0x182BA81D0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class AYTYIGOXZAX
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5720", Offset = "0x2BA4120", VA = "0x182BA5720")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA6640", Offset = "0x2BA5040", VA = "0x182BA6640")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA6600", Offset = "0x2BA5000", VA = "0x182BA6600")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.ZQREIDAFJOT, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6590", Offset = "0x2BA4F90", VA = "0x182BA6590")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6370", Offset = "0x2BA4D70", VA = "0x182BA6370")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x36A7100", Offset = "0x36A5B00", VA = "0x1836A7100")]
		public static void EKJSQNSQNQN<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<MHARATWVONH> graphId) where TDeps : notnull, ZFMZEQYTVOK<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class DJUPHBFTKXC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6810", Offset = "0x2BA5210", VA = "0x182BA6810")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BAACA0", Offset = "0x2BA96A0", VA = "0x182BAACA0", Slot = "4")]
			public void URQJWNBESUE(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : EILJYZHYSBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2BAAD30", Offset = "0x2BA9730", VA = "0x182BAAD30", Slot = "4")]
			public void URQJWNBESUE(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : EILJYZHYSBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2BAAB60", Offset = "0x2BA9560", VA = "0x182BAAB60", Slot = "4")]
			public void URQJWNBESUE(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : EILJYZHYSBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2BAABF0", Offset = "0x2BA95F0", VA = "0x182BAABF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E5D490", Offset = "0x3E5BE90", VA = "0x183E5D490")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA7EF0", Offset = "0x2BA68F0", VA = "0x182BA7EF0")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<FunctionCalls.ZQREIDAFJOT>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7E40", Offset = "0x2BA6840", VA = "0x182BA7E40")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7E00", Offset = "0x2BA6800", VA = "0x182BA7E00")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8AE0", Offset = "0x3BC74E0", VA = "0x183BC8AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA5170", Offset = "0x2BA3B70", VA = "0x182BA5170")]
		public static void EKJSQNSQNQN(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4E00", Offset = "0x2BA3800", VA = "0x182BA4E00")]
		private static void BTIDIWDXFVC([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4CC0", Offset = "0x2BA36C0", VA = "0x182BA4CC0")]
		private static void BTIDIWDXFVC(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5010", Offset = "0x2BA3A10", VA = "0x182BA5010")]
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
		[Cpp2IlInjected.Address(RVA = "0x69F8330", Offset = "0x69F6D30", VA = "0x1869F8330")]
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
		[Cpp2IlInjected.Address(RVA = "0x66C6410", Offset = "0x66C4E10", VA = "0x1866C6410")]
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
