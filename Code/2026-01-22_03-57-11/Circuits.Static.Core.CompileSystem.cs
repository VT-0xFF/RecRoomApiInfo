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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x28F0710", Offset = "0x28EEF10", VA = "0x1828F0710")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		public readonly Id32<BMUDIFIQDFI<JRUSPVYOFZC>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
		public ByteCodeAdjustment(Id32<BMUDIFIQDFI<JRUSPVYOFZC>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class OYYUDDUCUNM : YMEXNENWPCO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x28829D0", Offset = "0x28811D0", VA = "0x1828829D0")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x28EC320", Offset = "0x28EAB20", VA = "0x1828EC320", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class LSPNIUEZRUJ : YMEXNENWPCO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<BMUDIFIQDFI<GMQAJYKQXXD>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
			public DeadEnd(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> nextByteCodePtr)
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
		public abstract class YMEXNENWPCO
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
			public readonly Id32<YMEXNENWPCO> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
			public Inst(Def def, Id32<YMEXNENWPCO> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class GTQQQKIAKGS : YMEXNENWPCO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class LNNWYFJGZEM : YMEXNENWPCO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x20C9E80", Offset = "0x20C8680", VA = "0x1820C9E80", Slot = "3")]
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
		internal IdUnsafeList<OYYUDDUCUNM, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<LSPNIUEZRUJ, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<GTQQQKIAKGS, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<LNNWYFJGZEM, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28EC700", Offset = "0x28EAF00", VA = "0x1828EC700")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<OYYUDDUCUNM, BytesImmediate> bytesImmediates, [In] IdUnsafeList<LSPNIUEZRUJ, DeadEnd> deadEnds, [In] IdUnsafeList<GTQQQKIAKGS, Variable> variables, [In] IdUnsafeList<LNNWYFJGZEM, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28EC5C0", Offset = "0x28EADC0", VA = "0x1828EC5C0")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class LGIZCLLFOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28F0330", Offset = "0x28EEB30", VA = "0x1828F0330")]
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
		public sealed class HANGLAEVNBH : YMEXNENWPCO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
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
		public abstract class YMEXNENWPCO
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
			public readonly Id32<YMEXNENWPCO> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
			public Inst(Def def, Id32<YMEXNENWPCO> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<HANGLAEVNBH, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28EEE10", Offset = "0x28ED610", VA = "0x1828EEE10")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<HANGLAEVNBH, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28EED80", Offset = "0x28ED580", VA = "0x1828EED80")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class DHVILKONWOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28EC560", Offset = "0x28EAD60", VA = "0x1828EC560")]
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
		[Cpp2IlInjected.Address(RVA = "0x28EEEF0", Offset = "0x28ED6F0", VA = "0x1828EEEF0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28EEE50", Offset = "0x28ED650", VA = "0x1828EEE50")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class RLGDLGJXQCR
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28F0A10", Offset = "0x28EF210", VA = "0x1828F0A10")]
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
		public sealed class ZOMKOUJIMIN : YMEXNENWPCO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<SREILBZNGDM> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
			public ExternalCall(Id32<SREILBZNGDM> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class YMEXNENWPCO
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
			public readonly Id32<YMEXNENWPCO> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
			private Inst(Def def, Id32<YMEXNENWPCO> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28F0300", Offset = "0x28EEB00", VA = "0x1828F0300")]
			public static Inst New(Def def, Id32<YMEXNENWPCO> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class ZLMNTILGRAL : YMEXNENWPCO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<SREILBZNGDM> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
			public InternalCall(Id32<SREILBZNGDM> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class SREILBZNGDM
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
			[Cpp2IlInjected.Address(RVA = "0x28EEE10", Offset = "0x28ED610", VA = "0x1828EEE10")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x28F0150", Offset = "0x28EE950", VA = "0x1828F0150")]
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
		internal IdUnsafeList<ZLMNTILGRAL, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<ZOMKOUJIMIN, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<SREILBZNGDM> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<SREILBZNGDM, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28EF0F0", Offset = "0x28ED8F0", VA = "0x1828EF0F0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<ZLMNTILGRAL, InternalCall> internalCalls, [In] IdUnsafeList<ZOMKOUJIMIN, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<SREILBZNGDM> IOId)> callsWithIO, [In] IdUnsafeList<SREILBZNGDM, IO> io, [In] SOAField<SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> ioModifyingCallLocations, [In] SOAField<SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28EEF50", Offset = "0x28ED750", VA = "0x1828EEF50")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class HLEZBLCHWXV
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28F0100", Offset = "0x28EE900", VA = "0x1828F0100")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28EFEF0", Offset = "0x28EE6F0", VA = "0x1828EFEF0")]
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
		internal SOAField<NNBWOXGQYLV, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<NNBWOXGQYLV>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28EFB40", Offset = "0x28EE340", VA = "0x1828EFB40")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<NNBWOXGQYLV, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<NNBWOXGQYLV>> generatedOutputsForExpression, [In] SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28EF1B0", Offset = "0x28ED9B0", VA = "0x1828EF1B0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class ECBZJONNTBO
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : VZVSAWMHLVR<Id32<FunctionCalls.SREILBZNGDM>, SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x28F0BC0", Offset = "0x28EF3C0", VA = "0x1828F0BC0")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x28F0C40", Offset = "0x28EF440", VA = "0x1828F0C40", Slot = "4")]
			public Id32<FunctionCalls.SREILBZNGDM> QBZUYOEERXZ(int a)
			{
				return default(Id32<FunctionCalls.SREILBZNGDM>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0")]
			public bool WSWNRVQKMJH(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "5")]
			private bool ICMZDYEVFWZ(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x28F0C80", Offset = "0x28EF480", VA = "0x1828F0C80", Slot = "6")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> TVNGBBBYLKI(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : ZPLQWAFRHEC<Id32<FunctionCalls.SREILBZNGDM>, SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28EB410", Offset = "0x28E9C10", VA = "0x1828EB410")]
			public UnsafeList<Id32<FunctionCalls.SREILBZNGDM>> AMOBJJCCQTO(int a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.SREILBZNGDM>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x28EB480", Offset = "0x28E9C80", VA = "0x1828EB480")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x28EB500", Offset = "0x28E9D00", VA = "0x1828EB500", Slot = "6")]
			public void YKZDASJTHBG(Id32<FunctionCalls.SREILBZNGDM> a, SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> b, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x28EB410", Offset = "0x28E9C10", VA = "0x1828EB410", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.SREILBZNGDM>> ITUVHCUTQWL(int a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.SREILBZNGDM>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x28EB400", Offset = "0x28E9C00", VA = "0x1828EB400", Slot = "5")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> AERAGNAIQHL(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : VZVSAWMHLVR<Id32<FunctionCalls.SREILBZNGDM>, SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x28F0CA0", Offset = "0x28EF4A0", VA = "0x1828F0CA0")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x28F0D20", Offset = "0x28EF520", VA = "0x1828F0D20", Slot = "4")]
			public Id32<FunctionCalls.SREILBZNGDM> QBZUYOEERXZ(int a)
			{
				return default(Id32<FunctionCalls.SREILBZNGDM>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0")]
			public bool WSWNRVQKMJH(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "5")]
			private bool QCGBBJZSIFE(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x28F0C90", Offset = "0x28EF490", VA = "0x1828F0C90", Slot = "6")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> CITDCZEWFPV(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : ZPLQWAFRHEC<Id32<FunctionCalls.SREILBZNGDM>, SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x28EB5A0", Offset = "0x28E9DA0", VA = "0x1828EB5A0")]
			public UnsafeList<Id32<FunctionCalls.SREILBZNGDM>> AMOBJJCCQTO(int a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.SREILBZNGDM>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x28EB620", Offset = "0x28E9E20", VA = "0x1828EB620")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x28EB6A0", Offset = "0x28E9EA0", VA = "0x1828EB6A0", Slot = "6")]
			public void YKZDASJTHBG(Id32<FunctionCalls.SREILBZNGDM> a, SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> b, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x28EB5A0", Offset = "0x28E9DA0", VA = "0x1828EB5A0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.SREILBZNGDM>> ZJLFDMETUAU(int a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.SREILBZNGDM>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x28EB610", Offset = "0x28E9E10", VA = "0x1828EB610", Slot = "5")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> GMDIPLLBMLS(Id32<FunctionCalls.SREILBZNGDM> a, [In] SOAField<FunctionCalls.SREILBZNGDM, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : VZVSAWMHLVR<Id32<WZTXETPFGMO>, SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x28F0D60", Offset = "0x28EF560", VA = "0x1828F0D60")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(Id32<WZTXETPFGMO> a, [In] SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x28F0E10", Offset = "0x28EF610", VA = "0x1828F0E10", Slot = "4")]
			public Id32<WZTXETPFGMO> QBZUYOEERXZ(int a)
			{
				return default(Id32<WZTXETPFGMO>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x28F0E60", Offset = "0x28EF660", VA = "0x1828F0E60")]
			public bool WSWNRVQKMJH(Id32<WZTXETPFGMO> a, [In] SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x28F0E60", Offset = "0x28EF660", VA = "0x1828F0E60", Slot = "5")]
			private bool WYWTXMZXABC(Id32<WZTXETPFGMO> a, [In] SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x28F0E50", Offset = "0x28EF650", VA = "0x1828F0E50", Slot = "6")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> UWMTUYTWHVX(Id32<WZTXETPFGMO> a, [In] SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : ZPLQWAFRHEC<Id32<WZTXETPFGMO>, SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x28EB740", Offset = "0x28E9F40", VA = "0x1828EB740")]
			public UnsafeList<Id32<WZTXETPFGMO>> AMOBJJCCQTO(int a, [In] SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> values)
			{
				return default(UnsafeList<Id32<WZTXETPFGMO>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x28EB7B0", Offset = "0x28E9FB0", VA = "0x1828EB7B0")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(Id32<WZTXETPFGMO> a, [In] SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x28EB870", Offset = "0x28EA070", VA = "0x1828EB870", Slot = "6")]
			public void YKZDASJTHBG(Id32<WZTXETPFGMO> a, SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> b, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x28EB740", Offset = "0x28E9F40", VA = "0x1828EB740", Slot = "4")]
			private UnsafeList<Id32<WZTXETPFGMO>> OGOFWICETJE(int a, [In] SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> values)
			{
				return default(UnsafeList<Id32<WZTXETPFGMO>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x28EB860", Offset = "0x28EA060", VA = "0x1828EB860", Slot = "5")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> RMBHEYWWVNY(Id32<WZTXETPFGMO> a, [In] SOAField<WZTXETPFGMO, Id32<BMUDIFIQDFI<GMQAJYKQXXD>>?> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : VZVSAWMHLVR<int, UnsafeList<(Id32<LocalVariables.M>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x28F1010", Offset = "0x28EF810", VA = "0x1828F1010")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB10190", Offset = "0xB0E990", VA = "0x180B10190", Slot = "4")]
			public int QBZUYOEERXZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0")]
			public bool WSWNRVQKMJH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "5")]
			private bool VYRQTTJYJJX(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x28F1000", Offset = "0x28EF800", VA = "0x1828F1000", Slot = "6")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> CXVNADOMDLK(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : ZPLQWAFRHEC<int, UnsafeList<(Id32<LocalVariables.M>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x28EBD90", Offset = "0x28EA590", VA = "0x1828EBD90")]
			public UnsafeList<int> AMOBJJCCQTO(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28EBE00", Offset = "0x28EA600", VA = "0x1828EBE00")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x28EBEA0", Offset = "0x28EA6A0", VA = "0x1828EBEA0", Slot = "6")]
			public void YKZDASJTHBG(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> values, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x28EBD90", Offset = "0x28EA590", VA = "0x1828EBD90", Slot = "4")]
			private UnsafeList<int> IWNZUBULMBX(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x28EBE90", Offset = "0x28EA690", VA = "0x1828EBE90", Slot = "5")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> LAQCRKGCWWP(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JRUSPVYOFZC>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : VZVSAWMHLVR<int, UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x28F0F70", Offset = "0x28EF770", VA = "0x1828F0F70")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB10190", Offset = "0xB0E990", VA = "0x180B10190", Slot = "4")]
			public int QBZUYOEERXZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0")]
			public bool WSWNRVQKMJH(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "5")]
			private bool CNVBVNPFQCU(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x28F0F60", Offset = "0x28EF760", VA = "0x1828F0F60", Slot = "6")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> JOVZBXNWUJP(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : ZPLQWAFRHEC<int, UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x28EBB80", Offset = "0x28EA380", VA = "0x1828EBB80")]
			public UnsafeList<int> AMOBJJCCQTO(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x28EBBF0", Offset = "0x28EA3F0", VA = "0x1828EBBF0")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x28EBC90", Offset = "0x28EA490", VA = "0x1828EBC90", Slot = "6")]
			public void YKZDASJTHBG(int a, UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x28EBB80", Offset = "0x28EA380", VA = "0x1828EBB80", Slot = "4")]
			private UnsafeList<int> NZIOKKZSNQY(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x28EBC80", Offset = "0x28EA480", VA = "0x1828EBC80", Slot = "5")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> WYFKBOQVERW(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : VZVSAWMHLVR<int, UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x28F0ED0", Offset = "0x28EF6D0", VA = "0x1828F0ED0")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB10190", Offset = "0xB0E990", VA = "0x180B10190", Slot = "4")]
			public int QBZUYOEERXZ(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0")]
			public bool WSWNRVQKMJH(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "5")]
			private bool CNVBVNPFQCU(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x28F0EC0", Offset = "0x28EF6C0", VA = "0x1828F0EC0", Slot = "6")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> JOVZBXNWUJP(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : ZPLQWAFRHEC<int, UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x28EB970", Offset = "0x28EA170", VA = "0x1828EB970")]
			public UnsafeList<int> AMOBJJCCQTO(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x28EB9E0", Offset = "0x28EA1E0", VA = "0x1828EB9E0")]
			public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x28EBA80", Offset = "0x28EA280", VA = "0x1828EBA80", Slot = "6")]
			public void YKZDASJTHBG(int a, UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x28EB970", Offset = "0x28EA170", VA = "0x1828EB970", Slot = "4")]
			private UnsafeList<int> NZIOKKZSNQY(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x28EBA70", Offset = "0x28EA270", VA = "0x1828EBA70", Slot = "5")]
			private Id32<BMUDIFIQDFI<JRUSPVYOFZC>> WYFKBOQVERW(int a, [In] UnsafeList<(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> Target, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1A82640", Offset = "0x1A80E40", VA = "0x181A82640")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x28EFEE0", Offset = "0x28EE6E0", VA = "0x1828EFEE0")]
			public void BYKHRBFUYXH([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<WZTXETPFGMO> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x28EFEC0", Offset = "0x28EE6C0", VA = "0x1828EFEC0")]
			public GenerateDataBackFromInputIndexResult(Id32<WZTXETPFGMO> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28EFE90", Offset = "0x28EE690", VA = "0x1828EFE90")]
			public void BYKHRBFUYXH([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28EFEA0", Offset = "0x28EE6A0", VA = "0x1828EFEA0")]
			public void BYKHRBFUYXH([Out] Id32<DataBackResults.M> a, [Out] Id32<WZTXETPFGMO> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<WZTXETPFGMO> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
			public GenerateDataBackFromInputIndicesResult(Id32<WZTXETPFGMO> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x28EFED0", Offset = "0x28EE6D0", VA = "0x1828EFED0")]
			public void BYKHRBFUYXH([Out] Id32<DataBackResults.M> a, [Out] Id32<WZTXETPFGMO> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28ECB80", Offset = "0x28EB380", VA = "0x1828ECB80")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28EE890", Offset = "0x28ED090", VA = "0x1828EE890")]
		public static void XCDWIECZEAC(this FunctionCompileState a, Id32<NNBWOXGQYLV> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28EE970", Offset = "0x28ED170", VA = "0x1828EE970")]
		public static void YMVTRGDCWGQ(this FunctionCompileState a, Id32<NNBWOXGQYLV> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28ECB00", Offset = "0x28EB300", VA = "0x1828ECB00")]
		public static Id32<DataBackResults.M>? DRKEIAWAUAB([In] this FunctionCompileState self, Id32<NNBWOXGQYLV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28ED910", Offset = "0x28EC110", VA = "0x1828ED910")]
		public static Id32<BMUDIFIQDFI<GMQAJYKQXXD>> NLVDXPSEGCV([In] this FunctionCompileState self)
		{
			return default(Id32<BMUDIFIQDFI<GMQAJYKQXXD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28EE040", Offset = "0x28EC840", VA = "0x1828EE040")]
		private static void USEYICNDPQW(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28EC830", Offset = "0x28EB030", VA = "0x1828EC830")]
		private static Id32<BMUDIFIQDFI<GMQAJYKQXXD>>? BFVWFSRQLYZ([In] this FunctionCompileState self, Id32<WZTXETPFGMO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28ECEE0", Offset = "0x28EB6E0", VA = "0x1828ECEE0")]
		public static void FFKJMEYSPZX(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28ED0C0", Offset = "0x28EB8C0", VA = "0x1828ED0C0")]
		public static DataBackResults.Def FYRTQUGJBMF([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28EE1E0", Offset = "0x28EC9E0", VA = "0x1828EE1E0")]
		public static ReadOnlyArray<byte> VDJTTAYXPSZ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28EDEE0", Offset = "0x28EC6E0", VA = "0x1828EDEE0")]
		public static Id32<LocalVariables.M> UEHMOMCQGYT([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28ED1B0", Offset = "0x28EB9B0", VA = "0x1828ED1B0")]
		public static Union32 HYNGRXUQDYT([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x35CC850", Offset = "0x35CB050", VA = "0x1835CC850")]
		private static Id32<DataBackResults.M> MANWTORUXBG<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.YMEXNENWPCO
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28ED130", Offset = "0x28EB930", VA = "0x1828ED130")]
		public static Id32<DataBackResults.M> GOXOOVUSYPU(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28ED290", Offset = "0x28EBA90", VA = "0x1828ED290")]
		public static Id32<DataBackResults.M> KCCBEGKMDHX(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28EDE60", Offset = "0x28EC660", VA = "0x1828EDE60")]
		public static Id32<DataBackResults.M> SZUQUFUYBSI(this FunctionCompileState a, Id32<BMUDIFIQDFI<GMQAJYKQXXD>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28EE550", Offset = "0x28ECD50", VA = "0x1828EE550")]
		public static Id32<DataBackResults.M> WDPAABSXUWO(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28EDBD0", Offset = "0x28EC3D0", VA = "0x1828EDBD0")]
		public static Id32<DataBackResults.M> RKNDEAHKEDL(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x35B9DB0", Offset = "0x35B85B0", VA = "0x1835B9DB0")]
		private static Id32<ExecForwardResults.M> LIFVJPHOEVF<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.YMEXNENWPCO
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28EDA80", Offset = "0x28EC280", VA = "0x1828EDA80")]
		public static Id32<ExecForwardResults.M> QMLOPKFDUVH(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28EC790", Offset = "0x28EAF90", VA = "0x1828EC790")]
		public static Id32<ExecForwardResults.M> AANNZWJWURM(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28EDFC0", Offset = "0x28EC7C0", VA = "0x1828EDFC0")]
		public static Id32<ExecForwardResults.M> UOSXWDAIGEG(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28ED7B0", Offset = "0x28EBFB0", VA = "0x1828ED7B0")]
		public static Id32<ExecForwardResults.M> MWBOVJRTRHJ(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28EE920", Offset = "0x28ED120", VA = "0x1828EE920")]
		public static Id32<ExecForwardResults.M> XWBNBPWHUXV(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28ED050", Offset = "0x28EB850", VA = "0x1828ED050")]
		public static FunctionCalls.Def FOVKTETCXIE([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28ECA30", Offset = "0x28EB230", VA = "0x1828ECA30")]
		public static CopyEnumerable<Id32<FunctionCalls.SREILBZNGDM>, Id32Enumerator<FunctionCalls.SREILBZNGDM>> DDWLGHGJFDX([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.SREILBZNGDM>, Id32Enumerator<FunctionCalls.SREILBZNGDM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28EEB40", Offset = "0x28ED340", VA = "0x1828EEB40")]
		public static Id32<FunctionCalls.SREILBZNGDM> YZMETPPWMKU([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.SREILBZNGDM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28EED10", Offset = "0x28ED510", VA = "0x1828EED10")]
		public static FunctionCalls.IO ZMSUPZOLKYN([In] this FunctionCompileState self, Id32<FunctionCalls.SREILBZNGDM> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28ED370", Offset = "0x28EBB70", VA = "0x1828ED370")]
		public static FunctionCalls.IO LKOBQDULOQB(this FunctionCompileState a, Id32<FunctionCalls.SREILBZNGDM> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x35B9D20", Offset = "0x35B8520", VA = "0x1835B9D20")]
		private static Id32<FunctionCalls.M> KUJLJOLPHKW<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.YMEXNENWPCO
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28EE3A0", Offset = "0x28ECBA0", VA = "0x1828EE3A0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.SREILBZNGDM>) WCUCHCXKKXR(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.SREILBZNGDM>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28EE5D0", Offset = "0x28ECDD0", VA = "0x1828EE5D0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.SREILBZNGDM>) WFTZCOVMGFT(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.SREILBZNGDM>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28EC7E0", Offset = "0x28EAFE0", VA = "0x1828EC7E0")]
		public static Id32<FunctionCalls.M> AULELJTHDBA(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28ECE50", Offset = "0x28EB650", VA = "0x1828ECE50")]
		public static void EIWGQOWFWOH(this FunctionCompileState a, Id32<FunctionCalls.SREILBZNGDM> b, Id32<BMUDIFIQDFI<GMQAJYKQXXD>> c, Id32<BMUDIFIQDFI<MYAKJBUXDCU>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x35B9E50", Offset = "0x35B8650", VA = "0x1835B9E50")]
		public static GenerateDataBackResult LJYZGBUFAUX<d, e>(this FunctionCompileState a, d b, e c, Id32<VAEORNAZREW> d, Id32<WZTXETPFGMO> e) where d : BZPGNHHMTGT<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x35CD3F0", Offset = "0x35CBBF0", VA = "0x1835CD3F0")]
		public static GenerateDataBackFromInputIndexResult VPUCXIXHLPF<f, g>(this FunctionCompileState a, f b, g c, Id32<VAEORNAZREW> d, Id32<CATHGSEFVUK> e, int f) where f : BZPGNHHMTGT<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x35B97D0", Offset = "0x35B7FD0", VA = "0x1835B97D0")]
		public static Id32<DataBackResults.M>? HTMQTKHJBXU<h, i>(this FunctionCompileState a, h b, i c, Id32<VAEORNAZREW> d, Id32<CATHGSEFVUK> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : BZPGNHHMTGT<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x35CCAB0", Offset = "0x35CB2B0", VA = "0x1835CCAB0")]
		public static Id32<ExecForwardResults.M> SQNUORFTCLU<j, k>(this FunctionCompileState a, j b, k c, Id32<VAEORNAZREW> d, Id32<NNBWOXGQYLV> e) where j : BZPGNHHMTGT<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x28ED5F0", Offset = "0x28EBDF0", VA = "0x1828ED5F0")]
		public static LocalVariables.ArgumentInst MRUHLWRAOVY([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28ED970", Offset = "0x28EC170", VA = "0x1828ED970")]
		public static LocalVariables.CalleeReturnValueInst OJPDIUDHJLA([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28ED800", Offset = "0x28EC000", VA = "0x1828ED800")]
		public static LocalVariables.CallerReturnValueInst MYHRDEHWDDL([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28ED3E0", Offset = "0x28EBBE0", VA = "0x1828ED3E0")]
		public static Id32<LocalVariables.M> LPDFLEXGSNZ(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28EDAC0", Offset = "0x28EC2C0", VA = "0x1828EDAC0")]
		public static LocalVariables.ParameterInst QOWTJCHREAI([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28ED320", Offset = "0x28EBB20", VA = "0x1828ED320")]
		public static LocalVariables.Def KVRVNISREGY([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28EEAF0", Offset = "0x28ED2F0", VA = "0x1828EEAF0")]
		public static int? YQOWVZVEVQK([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x35CD2F0", Offset = "0x35CBAF0", VA = "0x1835CD2F0")]
		private static Id32<LocalVariables.M> USWJXONTDGO<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.YMEXNENWPCO
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28EEA40", Offset = "0x28ED240", VA = "0x1828EEA40")]
		public static Id32<LocalVariables.M> YPEPHNWUVRK(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28ED590", Offset = "0x28EBD90", VA = "0x1828ED590")]
		public static Id32<LocalVariables.M> MGYNSVTITUD(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28EC8B0", Offset = "0x28EB0B0", VA = "0x1828EC8B0")]
		public static Id32<LocalVariables.M> BNRYQNMRZFD(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28EDC50", Offset = "0x28EC450", VA = "0x1828EDC50")]
		public static Id32<LocalVariables.M> RWKBZKUYSBD(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28EDE00", Offset = "0x28EC600", VA = "0x1828EDE00")]
		public static Id32<LocalVariables.M> SSSSNQPKHLP(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28EDCE0", Offset = "0x28EC4E0", VA = "0x1828EDCE0")]
		public static void SFQWHHCWPEW(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28EE780", Offset = "0x28ECF80", VA = "0x1828EE780")]
		public static void WOMJPQDIMRQ(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28ED700", Offset = "0x28EBF00", VA = "0x1828ED700")]
		public static void MSDQDHCHAZM(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28ECA70", Offset = "0x28EB270", VA = "0x1828ECA70")]
		public static void DEVFXQTSVAR(this FunctionCompileState a, Id32<BMUDIFIQDFI<GMQAJYKQXXD>> b, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28EE2C0", Offset = "0x28ECAC0", VA = "0x1828EE2C0")]
		public static void VFPEFQURNXT(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<BMUDIFIQDFI<NWXWONCHIFS>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x35CC9D0", Offset = "0x35CB1D0", VA = "0x1835CC9D0")]
		public static void RDBMIVJTTBI<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<BMUDIFIQDFI<GZQXHQYHYRK<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface BZPGNHHMTGT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<PBOKRPYDFLU> KQHWPMEDJKY(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<PBOKRPYDFLU> SQPSVIIAKLT(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<PBOKRPYDFLU> NSPFQRWKVGO(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<PBOKRPYDFLU> EZSBYIICQQF(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> YSJLCZNTQRB(a a, FunctionCompileState b, Id32<VAEORNAZREW> c, Id32<WZTXETPFGMO> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> AKEVZETUMTD(a a, FunctionCompileState b, Id32<VAEORNAZREW> c, Id32<NNBWOXGQYLV> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int UNKUUESOOYB(a a, Id32<VAEORNAZREW> b, Id32<WZTXETPFGMO> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<NNBWOXGQYLV> RKYQDYYKQSC(a a, Id32<VAEORNAZREW> b, Id32<WZTXETPFGMO> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind AQLFMAVYCHV(a a, Id32<VAEORNAZREW> b, Id32<WZTXETPFGMO> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HBTZYGGZMKY(a a, Id32<VAEORNAZREW> b, Id32<WZTXETPFGMO> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int VXNIGFZECSB(a a, Id32<VAEORNAZREW> b, Id32<WZTXETPFGMO> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> FNRXBNPDYHR(a a, Id32<VAEORNAZREW> b, Id32<WZTXETPFGMO> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<PBOKRPYDFLU>) LROBEMVWJGJ(a a, Id32<VAEORNAZREW> b, Id32<WZTXETPFGMO> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int GKASNSYJJJR(a a, Id32<VAEORNAZREW> b, Id32<NNBWOXGQYLV> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<WZTXETPFGMO> FUOIEGKDBOO(a a, Id32<VAEORNAZREW> b, Id32<NNBWOXGQYLV> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<WZTXETPFGMO> FEMVWNBBRFN(a a, Id32<VAEORNAZREW> b, Id32<CATHGSEFVUK> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int IFMADKVHRCX(a a, Id32<VAEORNAZREW> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? JQZNNGBXVRF(a a, Id32<VAEORNAZREW> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int PJFKZQBMVTH(a a, Id32<VAEORNAZREW> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? XLSJBGINVDT(a a, Id32<VAEORNAZREW> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class TXPBKNPEIGS
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A81B80", Offset = "0x3A80380", VA = "0x183A81B80")]
		public static Id32<LocalVariables.M?> MGRPPAJRWRP<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A80D10", Offset = "0x3A7F510", VA = "0x183A80D10")]
		public static Id32<LocalVariables.M?> IZMTCACQVIQ<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A80750", Offset = "0x3A7EF50", VA = "0x183A80750")]
		public static Id32<LocalVariables.M?> DZSEDBPDJOV<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x28F1750", Offset = "0x28EFF50", VA = "0x1828F1750")]
		public static Id32<LocalVariables.M> BNGEDJQZFID(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x28F3050", Offset = "0x28F1850", VA = "0x1828F3050")]
		public static Id32<LocalVariables.M> HWZXYIVXOWU(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x28F4700", Offset = "0x28F2F00", VA = "0x1828F4700")]
		public static Id32<LocalVariables.M> PFKFCFHOBHD(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x28F22C0", Offset = "0x28F0AC0", VA = "0x1828F22C0")]
		public static Id32<LocalVariables.M> FCRWRBOSRXL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x28F5C20", Offset = "0x28F4420", VA = "0x1828F5C20")]
		public static Id32<LocalVariables.M> VZEWSYDTIBI(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28F6450", Offset = "0x28F4C50", VA = "0x1828F6450")]
		public static Id32<LocalVariables.M> ZRNBGIITHEL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x28F5D40", Offset = "0x28F4540", VA = "0x1828F5D40")]
		public static Id32<LocalVariables.M> WCXNSMTFOML(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x28F11C0", Offset = "0x28EF9C0", VA = "0x1828F11C0")]
		public static Id32<LocalVariables.M> ANXPMHSEZAA(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x28F5530", Offset = "0x28F3D30", VA = "0x1828F5530")]
		public static Id32<LocalVariables.M> VMLMTWLSYRT(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x28F4210", Offset = "0x28F2A10", VA = "0x1828F4210")]
		public static Id32<LocalVariables.M> OLUXPMSZKKA(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x28F4CA0", Offset = "0x28F34A0", VA = "0x1828F4CA0")]
		public static Id32<LocalVariables.M> RNXWCBLLFXR(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28F1610", Offset = "0x28EFE10", VA = "0x1828F1610")]
		public static Id32<LocalVariables.M> BGGRCJJGLBA(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28F34D0", Offset = "0x28F1CD0", VA = "0x1828F34D0")]
		public static Id32<LocalVariables.M> IVCTLLRFZTX(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28F4840", Offset = "0x28F3040", VA = "0x1828F4840")]
		public static Id32<LocalVariables.M> QBJORNEQEVU(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28F3910", Offset = "0x28F2110", VA = "0x1828F3910")]
		public static Id32<LocalVariables.M> KWWAHXXDRFF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28F5F80", Offset = "0x28F4780", VA = "0x1828F5F80")]
		public static Id32<LocalVariables.M> WLUDMFMJSCB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28F3750", Offset = "0x28F1F50", VA = "0x1828F3750")]
		public static Id32<LocalVariables.M> JWPWYZONDYW(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28F4970", Offset = "0x28F3170", VA = "0x1828F4970")]
		public static Id32<LocalVariables.M> QKZAYXWRRFJ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28F3E10", Offset = "0x28F2610", VA = "0x1828F3E10")]
		public static Id32<LocalVariables.M> LWRYHFUUQRO(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28F6080", Offset = "0x28F4880", VA = "0x1828F6080")]
		public static Id32<LocalVariables.M> XRAMDZDAZGX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28F32B0", Offset = "0x28F1AB0", VA = "0x1828F32B0")]
		public static Id32<LocalVariables.M> IJPYVKTGXLQ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28F4DC0", Offset = "0x28F35C0", VA = "0x1828F4DC0")]
		public static Id32<LocalVariables.M> SWFQUMTLMJM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28F3450", Offset = "0x28F1C50", VA = "0x1828F3450")]
		public static Id32<LocalVariables.M> ISDOWOAWIEB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28F53B0", Offset = "0x28F3BB0", VA = "0x1828F53B0")]
		public static Id32<LocalVariables.M> VKBTCKVJCMY(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28F6000", Offset = "0x28F4800", VA = "0x1828F6000")]
		public static Id32<LocalVariables.M> XCOKZSOCEBV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28F3C90", Offset = "0x28F2490", VA = "0x1828F3C90")]
		public static Id32<LocalVariables.M> LLLTOVUAUGU(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28F5670", Offset = "0x28F3E70", VA = "0x1828F5670")]
		public static Id32<LocalVariables.M> VUGATOOLIBX(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28F6100", Offset = "0x28F4900", VA = "0x1828F6100")]
		public static Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> XRHKVWNASCP(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28F50F0", Offset = "0x28F38F0", VA = "0x1828F50F0")]
		public static Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> UXRRIUVMWKL(this FunctionCompileState a, int b)
		{
			return default(Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28F2FB0", Offset = "0x28F17B0", VA = "0x1828F2FB0")]
		public static Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> HNXRLRZPOWA(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28F1980", Offset = "0x28F0180", VA = "0x1828F1980")]
		public static Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> BQAEYQAMKTO(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28F2120", Offset = "0x28F0920", VA = "0x1828F2120")]
		public static Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> DNMKYEGGFKU(this FunctionCompileState a, int b)
		{
			return default(Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28F4F30", Offset = "0x28F3730", VA = "0x1828F4F30")]
		public static Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> TVQADNFSVAD(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28F1C80", Offset = "0x28F0480", VA = "0x1828F1C80")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.SREILBZNGDM>) CFFWOMFPHOQ(this FunctionCompileState a, Id32<ULSOTBCMXIN> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.SREILBZNGDM>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28F2A10", Offset = "0x28F1210", VA = "0x1828F2A10")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.SREILBZNGDM>) HDPUHHPOMDE(this FunctionCompileState a, Id32<JVDVMJBLEIH> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.SREILBZNGDM>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3A818C0", Offset = "0x3A800C0", VA = "0x183A818C0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<PBOKRPYDFLU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<TMarker>>, Id32<FunctionCalls.M>) LGSKQSMPMRD<TMarker>(this FunctionCompileState a, Id32<PBOKRPYDFLU> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<PBOKRPYDFLU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28F2710", Offset = "0x28F0F10", VA = "0x1828F2710")]
		public static Id32<LocalVariables.M> FZAHNTPMCIN(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28F4E40", Offset = "0x28F3640", VA = "0x1828F4E40")]
		public static Id32<LocalVariables.M> TARSJRAOYHE(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28F49F0", Offset = "0x28F31F0", VA = "0x1828F49F0")]
		public static Id32<LocalVariables.M> QPQWAOBDHVN(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28F45E0", Offset = "0x28F2DE0", VA = "0x1828F45E0")]
		public static Id32<LocalVariables.M> PAICOPOIMOU(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x28F35D0", Offset = "0x28F1DD0", VA = "0x1828F35D0")]
		public static Id32<LocalVariables.M> JHTLQWOTFSL(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28F3330", Offset = "0x28F1B30", VA = "0x1828F3330")]
		public static Id32<LocalVariables.M> IQRWSCIYMHG(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28F4310", Offset = "0x28F2B10", VA = "0x1828F4310")]
		public static Id32<LocalVariables.M> ONDVQLZKERP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28F4450", Offset = "0x28F2C50", VA = "0x1828F4450")]
		public static Id32<LocalVariables.M> OOIKEPMFXQN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28F21A0", Offset = "0x28F09A0", VA = "0x1828F21A0")]
		public static Id32<LocalVariables.M> EXXYGJPCRPM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28F3A50", Offset = "0x28F2250", VA = "0x1828F3A50")]
		public static Id32<LocalVariables.M> KZXCYPCZNXB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28F4550", Offset = "0x28F2D50", VA = "0x1828F4550")]
		public static Id32<LocalVariables.M> OPGNWPHKEYW(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28F36D0", Offset = "0x28F1ED0", VA = "0x1828F36D0")]
		public static Id32<LocalVariables.M> JQKZZGRLLZT(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28F4AE0", Offset = "0x28F32E0", VA = "0x1828F4AE0")]
		public static Id32<LocalVariables.M> QTAISPMQJEM(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28F2EB0", Offset = "0x28F16B0", VA = "0x1828F2EB0")]
		public static Id32<LocalVariables.M> HHGYYZDOXPS(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28F1850", Offset = "0x28F0050", VA = "0x1828F1850")]
		public static Id32<LocalVariables.M> BNUCDABDFCT(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28F3170", Offset = "0x28F1970", VA = "0x1828F3170")]
		public static Id32<LocalVariables.M> IFGQMOQHZYK(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x28F3D10", Offset = "0x28F2510", VA = "0x1828F3D10")]
		public static Id32<LocalVariables.M> LTHCLGVXMGF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x28F5B00", Offset = "0x28F4300", VA = "0x1828F5B00")]
		public static Id32<LocalVariables.M> VXJEJFOMQLQ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28F27D0", Offset = "0x28F0FD0", VA = "0x1828F27D0")]
		public static Id32<LocalVariables.M> GJGUEJHUKBJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28F3FB0", Offset = "0x28F27B0", VA = "0x1828F3FB0")]
		public static Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>> MUEASPKCEHX(this FunctionCompileState a)
		{
			return default(Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x28F23C0", Offset = "0x28F0BC0", VA = "0x1828F23C0")]
		public static Id32<LocalVariables.M> FNWVVFCKENA(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x28F40F0", Offset = "0x28F28F0", VA = "0x1828F40F0")]
		public static Id32<LocalVariables.M> MZRLXYEQDBX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28F24C0", Offset = "0x28F0CC0", VA = "0x1828F24C0")]
		public static Id32<LocalVariables.M> FRHEUBSZQRO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x28F3B90", Offset = "0x28F2390", VA = "0x1828F3B90")]
		public static Id32<LocalVariables.M> LDFXAGTNFOY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28F3E90", Offset = "0x28F2690", VA = "0x1828F3E90")]
		public static Id32<LocalVariables.M> MESOTSBXWSL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x28F5270", Offset = "0x28F3A70", VA = "0x1828F5270")]
		public static Id32<LocalVariables.M> UZSVDBYUKKG(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28F2910", Offset = "0x28F1110", VA = "0x1828F2910")]
		public static Id32<LocalVariables.M> GWOKEWMAWAH(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28F2600", Offset = "0x28F0E00", VA = "0x1828F2600")]
		public static Id32<LocalVariables.M> FVBSLLDQEWU(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28F45D0", Offset = "0x28F2DD0", VA = "0x1828F45D0")]
		public static void OUAMDYNDKRP(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28F1B80", Offset = "0x28F0380", VA = "0x1828F1B80")]
		public static Id32<LocalVariables.M> BQMGQXYVULA(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x28F10A0", Offset = "0x28EF8A0", VA = "0x1828F10A0")]
		public static Id32<LocalVariables.M> ALCLNEVPPUF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x28F37D0", Offset = "0x28F1FD0", VA = "0x1828F37D0")]
		public static Id32<LocalVariables.M> KOBYGVYRUUU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x28F5430", Offset = "0x28F3C30", VA = "0x1828F5430")]
		public static Id32<LocalVariables.M> VMHLGJJNAGA(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28F3FD0", Offset = "0x28F27D0", VA = "0x1828F3FD0")]
		public static Id32<LocalVariables.M> MVUBIDFVUJR(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28F5E40", Offset = "0x28F4640", VA = "0x1828F5E40")]
		public static Id32<LocalVariables.M> WKJXSPVAMYW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28F56F0", Offset = "0x28F3EF0", VA = "0x1828F56F0")]
		public static Id32<LocalVariables.M> VWYBVHAJTUS(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28F5170", Offset = "0x28F3970", VA = "0x1828F5170")]
		public static Id32<LocalVariables.M> UYPUGFDQHNB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28F4FD0", Offset = "0x28F37D0", VA = "0x1828F4FD0")]
		public static Id32<LocalVariables.M> TXDCMTVFQJO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28F4B60", Offset = "0x28F3360", VA = "0x1828F4B60")]
		public static Id32<LocalVariables.M> RLFVDGUOHXX(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3A82530", Offset = "0x3A80D30", VA = "0x183A82530")]
		public static void UFYQIXXZCKI<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<ULSOTBCMXIN> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, BZPGNHHMTGT<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FE60", Offset = "0x3A7E660", VA = "0x183A7FE60")]
		public static void BRLPJKOFSAW<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<JVDVMJBLEIH> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, BZPGNHHMTGT<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3A81460", Offset = "0x3A7FC60", VA = "0x183A81460")]
		public static Id32<LocalVariables.M> JVTONKGXJTK<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, BZPGNHHMTGT<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3A80F40", Offset = "0x3A7F740", VA = "0x183A80F40")]
		public static Id32<LocalVariables.M> JTPUECLIBCF<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, BZPGNHHMTGT<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FB40", Offset = "0x3A7E340", VA = "0x183A7FB40")]
		public static Id32<DataBackResults.M> BDKVXFBQCYC<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, BZPGNHHMTGT<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3A80880", Offset = "0x3A7F080", VA = "0x183A80880")]
		public static Id32<ExecForwardResults.M> GXKSAXICXXP<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, BZPGNHHMTGT<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28F6300", Offset = "0x28F4B00", VA = "0x1828F6300")]
		public static Id32<DataBackResults.M> ZOVAEYYCUAL(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28F12E0", Offset = "0x28EFAE0", VA = "0x1828F12E0")]
		public static Id32<DataBackResults.M> ARDMONWXCBX(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3A82CE0", Offset = "0x3A814E0", VA = "0x183A82CE0")]
		public static Id32<DataBackResults.M> XXQOMISXIIA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<ULSOTBCMXIN> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, BZPGNHHMTGT<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3A82EC0", Offset = "0x3A816C0", VA = "0x183A82EC0")]
		private static Id32<DataBackResults.M> XXQOMISXIIA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<ULSOTBCMXIN> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, BZPGNHHMTGT<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3A820E0", Offset = "0x3A808E0", VA = "0x183A820E0")]
		public static Id32<LocalVariables.M> SNVWDSVARPO<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, BZPGNHHMTGT<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3A81D70", Offset = "0x3A80570", VA = "0x183A81D70")]
		public static void PFPFUFXTKHD<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, BZPGNHHMTGT<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<BMUDIFIQDFI<GMQAJYKQXXD>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<BMUDIFIQDFI<GMQAJYKQXXD>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
		public LiveInterval(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> firstUse, Id32<BMUDIFIQDFI<GMQAJYKQXXD>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28F03E0", Offset = "0x28EEBE0", VA = "0x1828F03E0")]
		public static LiveInterval New(Id32<BMUDIFIQDFI<GMQAJYKQXXD>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class XULQIQAURGN : YMEXNENWPCO
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
			[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class QKBFXTTQREH : YMEXNENWPCO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class OENLXRBDNSI : YMEXNENWPCO
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
			[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
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
		public abstract class YMEXNENWPCO
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
			public Id32<YMEXNENWPCO> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x28F0310", Offset = "0x28EEB10", VA = "0x1828F0310")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<YMEXNENWPCO> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class HQKABQTGWVL : YMEXNENWPCO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<XULQIQAURGN, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<OENLXRBDNSI, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<HQKABQTGWVL, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<QKBFXTTQREH, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28F05E0", Offset = "0x28EEDE0", VA = "0x1828F05E0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<XULQIQAURGN, ArgumentInst> argumentVariables, [In] SOAId32Field<OENLXRBDNSI, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<HQKABQTGWVL, ParameterInst> parameterVariables, [In] SOAId32Field<QKBFXTTQREH, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28F03F0", Offset = "0x28EEBF0", VA = "0x1828F03F0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class BCCRLONBLZM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28EC270", Offset = "0x28EAA70", VA = "0x1828EC270")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class RVXFTJQTGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28F0A60", Offset = "0x28EF260", VA = "0x1828F0A60")]
		public static void WCEBZPFQAIM(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.SREILBZNGDM, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28EC230", Offset = "0x28EAA30", VA = "0x1828EC230")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.SREILBZNGDM, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28EC1C0", Offset = "0x28EA9C0", VA = "0x1828EC1C0")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28EBFA0", Offset = "0x28EA7A0", VA = "0x1828EBFA0")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x334EE50", Offset = "0x334D650", VA = "0x18334EE50")]
		public static void WCEBZPFQAIM<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<VAEORNAZREW> graphId) where TDeps : notnull, BZPGNHHMTGT<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class CRSHQLRQKVZ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28EC390", Offset = "0x28EAB90", VA = "0x1828EC390")]
		public static void WCEBZPFQAIM(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface OESRMCITSIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void XNQWXJULWKH(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : OESRMCITSIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x28F08D0", Offset = "0x28EF0D0", VA = "0x1828F08D0", Slot = "4")]
			public void XNQWXJULWKH(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : OESRMCITSIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x28F0960", Offset = "0x28EF160", VA = "0x1828F0960", Slot = "4")]
			public void XNQWXJULWKH(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : OESRMCITSIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x28F0790", Offset = "0x28EEF90", VA = "0x1828F0790", Slot = "4")]
			public void XNQWXJULWKH(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : OESRMCITSIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x28F0820", Offset = "0x28EF020", VA = "0x1828F0820", Slot = "4")]
			public void XNQWXJULWKH(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class WICWADDYAVA<c> where c : struct, OESRMCITSIA
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c FPRKQLVLHLA;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3C96CC0", Offset = "0x3C954C0", VA = "0x183C96CC0")]
			public static int WCEBZPFQAIM<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : BZPGNHHMTGT<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<FunctionCalls.SREILBZNGDM>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28F02C0", Offset = "0x28EEAC0", VA = "0x1828F02C0")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<FunctionCalls.SREILBZNGDM>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28F0210", Offset = "0x28EEA10", VA = "0x1828F0210")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28F01D0", Offset = "0x28EE9D0", VA = "0x1828F01D0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x37639D0", Offset = "0x37621D0", VA = "0x1837639D0")]
		public static void WCEBZPFQAIM<b, a>(FunctionCompileState a, b b, a c) where b : BZPGNHHMTGT<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class WGPTTFANMLG
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
		private static int XXGWMBBACIG;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int MVKTAPQWRXS;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x28F6A40", Offset = "0x28F5240", VA = "0x1828F6A40")]
		public static void WCEBZPFQAIM(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28F66F0", Offset = "0x28F4EF0", VA = "0x1828F66F0")]
		private static void UQTWBCMBUSB([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28F6900", Offset = "0x28F5100", VA = "0x1828F6900")]
		private static void UQTWBCMBUSB(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28F6590", Offset = "0x28F4D90", VA = "0x1828F6590")]
		private static void DJHSCWGMSCC(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class DAGTAVGHMKA<a, b, c> where a : struct, ZPLQWAFRHEC<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a FPRKQLVLHLA;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4110610", Offset = "0x410EE10", VA = "0x184110610")]
		public static void WCEBZPFQAIM([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface ZPLQWAFRHEC<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> AMOBJJCCQTO(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void YKZDASJTHBG(a a, b b, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface VZVSAWMHLVR<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a QBZUYOEERXZ(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WSWNRVQKMJH(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<BMUDIFIQDFI<JRUSPVYOFZC>> KODMJNWTPCA(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class OIPTOWRCTQJ<a, b, c> where a : struct, VZVSAWMHLVR<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a FPRKQLVLHLA;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x59D9260", Offset = "0x59D7A60", VA = "0x1859D9260")]
		public static UnsafeList<b> WCEBZPFQAIM(int a, [In] c values)
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
