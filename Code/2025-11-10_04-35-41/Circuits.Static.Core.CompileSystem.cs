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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2883B10", Offset = "0x2882F10", VA = "0x182883B10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		public readonly Id32<SDWTKKVDDYT<FVPAIKKPAFL>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
		public ByteCodeAdjustment(Id32<SDWTKKVDDYT<FVPAIKKPAFL>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class UWCVBWJAEYF : FPMZCSHTCRD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x281DB50", Offset = "0x281CF50", VA = "0x18281DB50")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2881460", Offset = "0x2880860", VA = "0x182881460", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class EZWPFYIZDDO : FPMZCSHTCRD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<SDWTKKVDDYT<IDPQTAFRJWO>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			public DeadEnd(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> nextByteCodePtr)
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
		public abstract class FPMZCSHTCRD
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
			public readonly Id32<FPMZCSHTCRD> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
			public Inst(Def def, Id32<FPMZCSHTCRD> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class BHJISPOEVKZ : FPMZCSHTCRD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class XJJWUWHQYRV : FPMZCSHTCRD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1FE5C30", Offset = "0x1FE5030", VA = "0x181FE5C30", Slot = "3")]
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
		internal IdUnsafeList<UWCVBWJAEYF, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<EZWPFYIZDDO, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<BHJISPOEVKZ, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<XJJWUWHQYRV, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2881610", Offset = "0x2880A10", VA = "0x182881610")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<UWCVBWJAEYF, BytesImmediate> bytesImmediates, [In] IdUnsafeList<EZWPFYIZDDO, DeadEnd> deadEnds, [In] IdUnsafeList<BHJISPOEVKZ, Variable> variables, [In] IdUnsafeList<XJJWUWHQYRV, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28814D0", Offset = "0x28808D0", VA = "0x1828814D0")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class WRQRQUEVGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x288BE20", Offset = "0x288B220", VA = "0x18288BE20")]
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
		public sealed class CIIIDACSOUI : FPMZCSHTCRD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
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
		public abstract class FPMZCSHTCRD
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
			public readonly Id32<FPMZCSHTCRD> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
			public Inst(Def def, Id32<FPMZCSHTCRD> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<CIIIDACSOUI, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2881730", Offset = "0x2880B30", VA = "0x182881730")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<CIIIDACSOUI, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28816A0", Offset = "0x2880AA0", VA = "0x1828816A0")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class HCGACNAVUHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2882970", Offset = "0x2881D70", VA = "0x182882970")]
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
		[Cpp2IlInjected.Address(RVA = "0x2881970", Offset = "0x2880D70", VA = "0x182881970")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28818D0", Offset = "0x2880CD0", VA = "0x1828818D0")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class UVJMVZXZZEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28897E0", Offset = "0x2888BE0", VA = "0x1828897E0")]
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
		public sealed class ZGTXMCUIQSW : FPMZCSHTCRD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<UMGCKUMSNVX> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			public ExternalCall(Id32<UMGCKUMSNVX> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class FPMZCSHTCRD
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
			public readonly Id32<FPMZCSHTCRD> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
			private Inst(Def def, Id32<FPMZCSHTCRD> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2882B80", Offset = "0x2881F80", VA = "0x182882B80")]
			public static Inst New(Def def, Id32<FPMZCSHTCRD> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class QVYVUDDVZIA : FPMZCSHTCRD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<UMGCKUMSNVX> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			public InternalCall(Id32<UMGCKUMSNVX> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class UMGCKUMSNVX
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
			[Cpp2IlInjected.Address(RVA = "0x2881730", Offset = "0x2880B30", VA = "0x182881730")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x28829D0", Offset = "0x2881DD0", VA = "0x1828829D0")]
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
		internal IdUnsafeList<QVYVUDDVZIA, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<ZGTXMCUIQSW, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<UMGCKUMSNVX> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<UMGCKUMSNVX, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2881B70", Offset = "0x2880F70", VA = "0x182881B70")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<QVYVUDDVZIA, InternalCall> internalCalls, [In] IdUnsafeList<ZGTXMCUIQSW, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<UMGCKUMSNVX> IOId)> callsWithIO, [In] IdUnsafeList<UMGCKUMSNVX, IO> io, [In] SOAField<UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> ioModifyingCallLocations, [In] SOAField<UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28819D0", Offset = "0x2880DD0", VA = "0x1828819D0")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class XGPKNVJBTZU
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x288BF80", Offset = "0x288B380", VA = "0x18288BF80")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x288BFD0", Offset = "0x288B3D0", VA = "0x18288BFD0")]
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
		internal SOAField<DTGDQHKOFYM, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<DTGDQHKOFYM>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28825C0", Offset = "0x28819C0", VA = "0x1828825C0")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<DTGDQHKOFYM, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<DTGDQHKOFYM>> generatedOutputsForExpression, [In] SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2881C30", Offset = "0x2881030", VA = "0x182881C30")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class WQHXYCBBNUD
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : EGHODWMFDZE<Id32<FunctionCalls.UMGCKUMSNVX>, SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2889340", Offset = "0x2888740", VA = "0x182889340")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2889300", Offset = "0x2888700", VA = "0x182889300", Slot = "4")]
			public Id32<FunctionCalls.UMGCKUMSNVX> PSUMOWREDJY(int a)
			{
				return default(Id32<FunctionCalls.UMGCKUMSNVX>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0")]
			public bool LDCWZZRDNUM(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "5")]
			private bool TBPUKBQZABI(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x28893C0", Offset = "0x28887C0", VA = "0x1828893C0", Slot = "6")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> WTIISVTFMAT(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : FQLUWDIQIAP<Id32<FunctionCalls.UMGCKUMSNVX>, SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28805F0", Offset = "0x287F9F0", VA = "0x1828805F0")]
			public UnsafeList<Id32<FunctionCalls.UMGCKUMSNVX>> SVCIRVORAWT(int a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UMGCKUMSNVX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2880670", Offset = "0x287FA70", VA = "0x182880670")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x28806F0", Offset = "0x287FAF0", VA = "0x1828806F0", Slot = "6")]
			public void VMUMDBDVRSN(Id32<FunctionCalls.UMGCKUMSNVX> a, SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> b, Id32<SDWTKKVDDYT<FVPAIKKPAFL>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x28805F0", Offset = "0x287F9F0", VA = "0x1828805F0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UMGCKUMSNVX>> IPIYNCCKZYC(int a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UMGCKUMSNVX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2880660", Offset = "0x287FA60", VA = "0x182880660", Slot = "5")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> OVIXZDURAPE(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : EGHODWMFDZE<Id32<FunctionCalls.UMGCKUMSNVX>, SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2889420", Offset = "0x2888820", VA = "0x182889420")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x28893E0", Offset = "0x28887E0", VA = "0x1828893E0", Slot = "4")]
			public Id32<FunctionCalls.UMGCKUMSNVX> PSUMOWREDJY(int a)
			{
				return default(Id32<FunctionCalls.UMGCKUMSNVX>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0")]
			public bool LDCWZZRDNUM(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "5")]
			private bool ULMLHEINUDF(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x28893D0", Offset = "0x28887D0", VA = "0x1828893D0", Slot = "6")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> HAQWAUEXHJM(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : FQLUWDIQIAP<Id32<FunctionCalls.UMGCKUMSNVX>, SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2880790", Offset = "0x287FB90", VA = "0x182880790")]
			public UnsafeList<Id32<FunctionCalls.UMGCKUMSNVX>> SVCIRVORAWT(int a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UMGCKUMSNVX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2880800", Offset = "0x287FC00", VA = "0x182880800")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2880880", Offset = "0x287FC80", VA = "0x182880880", Slot = "6")]
			public void VMUMDBDVRSN(Id32<FunctionCalls.UMGCKUMSNVX> a, SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> b, Id32<SDWTKKVDDYT<FVPAIKKPAFL>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2880790", Offset = "0x287FB90", VA = "0x182880790", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.UMGCKUMSNVX>> QWZUUHGNHBZ(int a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.UMGCKUMSNVX>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2880920", Offset = "0x287FD20", VA = "0x182880920", Slot = "5")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> XBXKJUBBACN(Id32<FunctionCalls.UMGCKUMSNVX> a, [In] SOAField<FunctionCalls.UMGCKUMSNVX, Id32<SDWTKKVDDYT<GKDKIYQIDND>>> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : EGHODWMFDZE<Id32<AINMIFOSACL>, SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2889540", Offset = "0x2888940", VA = "0x182889540")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(Id32<AINMIFOSACL> a, [In] SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2889500", Offset = "0x2888900", VA = "0x182889500", Slot = "4")]
			public Id32<AINMIFOSACL> PSUMOWREDJY(int a)
			{
				return default(Id32<AINMIFOSACL>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x28894A0", Offset = "0x28888A0", VA = "0x1828894A0")]
			public bool LDCWZZRDNUM(Id32<AINMIFOSACL> a, [In] SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x28894A0", Offset = "0x28888A0", VA = "0x1828894A0", Slot = "5")]
			private bool APDZPMARWWF(Id32<AINMIFOSACL> a, [In] SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x28895F0", Offset = "0x28889F0", VA = "0x1828895F0", Slot = "6")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> ZUVFHNJTWPS(Id32<AINMIFOSACL> a, [In] SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : FQLUWDIQIAP<Id32<AINMIFOSACL>, SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2880940", Offset = "0x287FD40", VA = "0x182880940")]
			public UnsafeList<Id32<AINMIFOSACL>> SVCIRVORAWT(int a, [In] SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> values)
			{
				return default(UnsafeList<Id32<AINMIFOSACL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x28809B0", Offset = "0x287FDB0", VA = "0x1828809B0")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(Id32<AINMIFOSACL> a, [In] SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2880A60", Offset = "0x287FE60", VA = "0x182880A60", Slot = "6")]
			public void VMUMDBDVRSN(Id32<AINMIFOSACL> a, SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> b, Id32<SDWTKKVDDYT<FVPAIKKPAFL>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2880940", Offset = "0x287FD40", VA = "0x182880940", Slot = "4")]
			private UnsafeList<Id32<AINMIFOSACL>> PIKTZUDWVEZ(int a, [In] SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> values)
			{
				return default(UnsafeList<Id32<AINMIFOSACL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2880930", Offset = "0x287FD30", VA = "0x182880930", Slot = "5")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> GWPYDKHAATJ(Id32<AINMIFOSACL> a, [In] SOAField<AINMIFOSACL, Id32<SDWTKKVDDYT<IDPQTAFRJWO>>?> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : EGHODWMFDZE<int, UnsafeList<(Id32<LocalVariables.M>, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2889750", Offset = "0x2888B50", VA = "0x182889750")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xC34310", Offset = "0xC33710", VA = "0x180C34310", Slot = "4")]
			public int PSUMOWREDJY(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0")]
			public bool LDCWZZRDNUM(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "5")]
			private bool XSCXGKUNHYQ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2889740", Offset = "0x2888B40", VA = "0x182889740", Slot = "6")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> ITBVBFRWSEF(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : FQLUWDIQIAP<int, UnsafeList<(Id32<LocalVariables.M>, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2880F80", Offset = "0x2880380", VA = "0x182880F80")]
			public UnsafeList<int> SVCIRVORAWT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2881000", Offset = "0x2880400", VA = "0x182881000")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2881090", Offset = "0x2880490", VA = "0x182881090", Slot = "6")]
			public void VMUMDBDVRSN(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> values, Id32<SDWTKKVDDYT<FVPAIKKPAFL>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2880F80", Offset = "0x2880380", VA = "0x182880F80", Slot = "4")]
			private UnsafeList<int> CRYJENWDXRM(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2880FF0", Offset = "0x28803F0", VA = "0x182880FF0", Slot = "5")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> GQOWTVNXQCS(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<SDWTKKVDDYT<IMFYYDLBECV<FVPAIKKPAFL>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : EGHODWMFDZE<int, UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x28896A0", Offset = "0x2888AA0", VA = "0x1828896A0")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xC34310", Offset = "0xC33710", VA = "0x180C34310", Slot = "4")]
			public int PSUMOWREDJY(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0")]
			public bool LDCWZZRDNUM(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "5")]
			private bool YBPKSNQPWML(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2889730", Offset = "0x2888B30", VA = "0x182889730", Slot = "6")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> WDJQAMRJAHE(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : FQLUWDIQIAP<int, UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2880D80", Offset = "0x2880180", VA = "0x182880D80")]
			public UnsafeList<int> SVCIRVORAWT(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2880DF0", Offset = "0x28801F0", VA = "0x182880DF0")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2880E80", Offset = "0x2880280", VA = "0x182880E80", Slot = "6")]
			public void VMUMDBDVRSN(int a, UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values, Id32<SDWTKKVDDYT<FVPAIKKPAFL>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2880D80", Offset = "0x2880180", VA = "0x182880D80", Slot = "4")]
			private UnsafeList<int> IVDZZIDCSKV(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2880D70", Offset = "0x2880170", VA = "0x182880D70", Slot = "5")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> IOWUCLPFGBR(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : EGHODWMFDZE<int, UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2889600", Offset = "0x2888A00", VA = "0x182889600")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC34310", Offset = "0xC33710", VA = "0x180C34310", Slot = "4")]
			public int PSUMOWREDJY(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0")]
			public bool LDCWZZRDNUM(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "5")]
			private bool YBPKSNQPWML(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2889690", Offset = "0x2888A90", VA = "0x182889690", Slot = "6")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> WDJQAMRJAHE(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : FQLUWDIQIAP<int, UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2880B70", Offset = "0x287FF70", VA = "0x182880B70")]
			public UnsafeList<int> SVCIRVORAWT(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2880BE0", Offset = "0x287FFE0", VA = "0x182880BE0")]
			public Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2880C70", Offset = "0x2880070", VA = "0x182880C70", Slot = "6")]
			public void VMUMDBDVRSN(int a, UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values, Id32<SDWTKKVDDYT<FVPAIKKPAFL>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2880B70", Offset = "0x287FF70", VA = "0x182880B70", Slot = "4")]
			private UnsafeList<int> IVDZZIDCSKV(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2880B60", Offset = "0x287FF60", VA = "0x182880B60", Slot = "5")]
			private Id32<SDWTKKVDDYT<FVPAIKKPAFL>> IOWUCLPFGBR(int a, [In] UnsafeList<(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> Target, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1A7F100", Offset = "0x1A7E500", VA = "0x181A7F100")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2882960", Offset = "0x2881D60", VA = "0x182882960")]
			public void HYZXLOOBRHM([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<AINMIFOSACL> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2882940", Offset = "0x2881D40", VA = "0x182882940")]
			public GenerateDataBackFromInputIndexResult(Id32<AINMIFOSACL> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2882910", Offset = "0x2881D10", VA = "0x182882910")]
			public void HYZXLOOBRHM([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2882920", Offset = "0x2881D20", VA = "0x182882920")]
			public void HYZXLOOBRHM([Out] Id32<DataBackResults.M> a, [Out] Id32<AINMIFOSACL> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<AINMIFOSACL> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
			public GenerateDataBackFromInputIndicesResult(Id32<AINMIFOSACL> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2882950", Offset = "0x2881D50", VA = "0x182882950")]
			public void HYZXLOOBRHM([Out] Id32<DataBackResults.M> a, [Out] Id32<AINMIFOSACL> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2889A90", Offset = "0x2888E90", VA = "0x182889A90")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x288A470", Offset = "0x2889870", VA = "0x18288A470")]
		public static void IOXTXCTZVVJ(this FunctionCompileState a, Id32<DTGDQHKOFYM> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2889EE0", Offset = "0x28892E0", VA = "0x182889EE0")]
		public static void FRACOEGDLEZ(this FunctionCompileState a, Id32<DTGDQHKOFYM> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x288BB10", Offset = "0x288AF10", VA = "0x18288BB10")]
		public static Id32<DataBackResults.M>? YQJZBUOCDPM([In] this FunctionCompileState self, Id32<DTGDQHKOFYM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x288B790", Offset = "0x288AB90", VA = "0x18288B790")]
		public static Id32<SDWTKKVDDYT<IDPQTAFRJWO>> WPFOHDSKDVQ([In] this FunctionCompileState self)
		{
			return default(Id32<SDWTKKVDDYT<IDPQTAFRJWO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x288A020", Offset = "0x2889420", VA = "0x18288A020")]
		private static void GAUDTPEOWSR(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x288B450", Offset = "0x288A850", VA = "0x18288B450")]
		private static Id32<SDWTKKVDDYT<IDPQTAFRJWO>>? VFAUJWGIZNM([In] this FunctionCompileState self, Id32<AINMIFOSACL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x288B950", Offset = "0x288AD50", VA = "0x18288B950")]
		public static void YMFCCQIUNKG(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x288A930", Offset = "0x2889D30", VA = "0x18288A930")]
		public static DataBackResults.Def LIXWTQMDBNC([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x288A9A0", Offset = "0x2889DA0", VA = "0x18288A9A0")]
		public static ReadOnlyArray<byte> NRPNHVAUURW([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x288AB30", Offset = "0x2889F30", VA = "0x18288AB30")]
		public static Id32<LocalVariables.M> OGTSOMOEIBK([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x288BD40", Offset = "0x288B140", VA = "0x18288BD40")]
		public static Union32 ZGSNWRZPNRQ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC810", Offset = "0x3BFBC10", VA = "0x183BFC810")]
		private static Id32<DataBackResults.M> ZQKZCJQHFEL<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.FPMZCSHTCRD
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x288A200", Offset = "0x2889600", VA = "0x18288A200")]
		public static Id32<DataBackResults.M> GSRPWJLASPV(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x288B170", Offset = "0x288A570", VA = "0x18288B170")]
		public static Id32<DataBackResults.M> TNYWTIGTHEK(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2889960", Offset = "0x2888D60", VA = "0x182889960")]
		public static Id32<DataBackResults.M> BWZYEXBBYAN(this FunctionCompileState a, Id32<SDWTKKVDDYT<IDPQTAFRJWO>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x288A3F0", Offset = "0x28897F0", VA = "0x18288A3F0")]
		public static Id32<DataBackResults.M> IJPBJJASLSB(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x288B060", Offset = "0x288A460", VA = "0x18288B060")]
		public static Id32<DataBackResults.M> TIUMZAMWTDQ(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB220", Offset = "0x3BFA620", VA = "0x183BFB220")]
		private static Id32<ExecForwardResults.M> GRPFUPRIGHC<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.FPMZCSHTCRD
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x288B020", Offset = "0x288A420", VA = "0x18288B020")]
		public static Id32<ExecForwardResults.M> SFPNSGTHOOY(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x288B900", Offset = "0x288AD00", VA = "0x18288B900")]
		public static Id32<ExecForwardResults.M> XYAHTSQBGIR(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x288B200", Offset = "0x288A600", VA = "0x18288B200")]
		public static Id32<ExecForwardResults.M> TXYCDBVLGTL(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x288A280", Offset = "0x2889680", VA = "0x18288A280")]
		public static Id32<ExecForwardResults.M> HFDSVLGHUPQ(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2889910", Offset = "0x2888D10", VA = "0x182889910")]
		public static Id32<ExecForwardResults.M> BDYADCPHXJG(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x288A810", Offset = "0x2889C10", VA = "0x18288A810")]
		public static FunctionCalls.Def KAYHWBZDDWV([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x288A1C0", Offset = "0x28895C0", VA = "0x18288A1C0")]
		public static CopyEnumerable<Id32<FunctionCalls.UMGCKUMSNVX>, Id32Enumerator<FunctionCalls.UMGCKUMSNVX>> GNKZPQAYVIM([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.UMGCKUMSNVX>, Id32Enumerator<FunctionCalls.UMGCKUMSNVX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x288B280", Offset = "0x288A680", VA = "0x18288B280")]
		public static Id32<FunctionCalls.UMGCKUMSNVX> UAVSTBGTYNZ([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.UMGCKUMSNVX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2889FB0", Offset = "0x28893B0", VA = "0x182889FB0")]
		public static FunctionCalls.IO FXILCHRHVSO([In] this FunctionCompileState self, Id32<FunctionCalls.UMGCKUMSNVX> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x288ACA0", Offset = "0x288A0A0", VA = "0x18288ACA0")]
		public static FunctionCalls.IO PKPBNBSGSFG(this FunctionCompileState a, Id32<FunctionCalls.UMGCKUMSNVX> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9DC0", Offset = "0x3BF91C0", VA = "0x183BF9DC0")]
		private static Id32<FunctionCalls.M> CIQTKDDLTGX<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.FPMZCSHTCRD
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x288A550", Offset = "0x2889950", VA = "0x18288A550")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UMGCKUMSNVX>) JMRYVAHNZES(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UMGCKUMSNVX>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x288BB90", Offset = "0x288AF90", VA = "0x18288BB90")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UMGCKUMSNVX>) YXZWOANYPZK(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UMGCKUMSNVX>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x288BAC0", Offset = "0x288AEC0", VA = "0x18288BAC0")]
		public static Id32<FunctionCalls.M> YNZQZRZUFIV(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x288B0E0", Offset = "0x288A4E0", VA = "0x18288B0E0")]
		public static void TNROZOYEWCQ(this FunctionCompileState a, Id32<FunctionCalls.UMGCKUMSNVX> b, Id32<SDWTKKVDDYT<IDPQTAFRJWO>> c, Id32<SDWTKKVDDYT<GKDKIYQIDND>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB2C0", Offset = "0x3BFA6C0", VA = "0x183BFB2C0")]
		public static GenerateDataBackResult OOSAAMACTBI<d, e>(this FunctionCompileState a, d b, e c, Id32<HUXETNCTSFJ> d, Id32<AINMIFOSACL> e) where d : GHQHUOGIKCI<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3BFADC0", Offset = "0x3BFA1C0", VA = "0x183BFADC0")]
		public static GenerateDataBackFromInputIndexResult GOQCIARLIHU<f, g>(this FunctionCompileState a, f b, g c, Id32<HUXETNCTSFJ> d, Id32<FRZIQAPUPIV> e, int f) where f : GHQHUOGIKCI<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA850", Offset = "0x3BF9C50", VA = "0x183BFA850")]
		public static Id32<DataBackResults.M>? FOJCDYUUXDJ<h, i>(this FunctionCompileState a, h b, i c, Id32<HUXETNCTSFJ> d, Id32<FRZIQAPUPIV> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : GHQHUOGIKCI<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9E50", Offset = "0x3BF9250", VA = "0x183BF9E50")]
		public static Id32<ExecForwardResults.M> EWTWTVSZFFX<j, k>(this FunctionCompileState a, j b, k c, Id32<HUXETNCTSFJ> d, Id32<DTGDQHKOFYM> e) where j : GHQHUOGIKCI<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x288AE80", Offset = "0x288A280", VA = "0x18288AE80")]
		public static LocalVariables.ArgumentInst RAVBHANQRBX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x288A700", Offset = "0x2889B00", VA = "0x18288A700")]
		public static LocalVariables.CalleeReturnValueInst KAGMHBTJHFB([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x288B680", Offset = "0x288AA80", VA = "0x18288B680")]
		public static LocalVariables.CallerReturnValueInst WEPMYHCDSZW([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x288B4D0", Offset = "0x288A8D0", VA = "0x18288B4D0")]
		public static Id32<LocalVariables.M> VGCJWZNUMCM(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x288B7F0", Offset = "0x288ABF0", VA = "0x18288B7F0")]
		public static LocalVariables.ParameterInst XNZJFVZXNUZ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x288A500", Offset = "0x2889900", VA = "0x18288A500")]
		public static LocalVariables.Def ISWOIKCMADX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28899E0", Offset = "0x2888DE0", VA = "0x1828899E0")]
		public static int? CHLLUDMBVOX([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC710", Offset = "0x3BFBB10", VA = "0x183BFC710")]
		private static Id32<LocalVariables.M> QPOSRGMQRMH<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.FPMZCSHTCRD
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x288AA80", Offset = "0x2889E80", VA = "0x18288AA80")]
		public static Id32<LocalVariables.M> OBXHYROKNRZ(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2889A30", Offset = "0x2888E30", VA = "0x182889A30")]
		public static Id32<LocalVariables.M> DCYEPNTHUWQ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2889D60", Offset = "0x2889160", VA = "0x182889D60")]
		public static Id32<LocalVariables.M> FOMXVRGRYNC(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x288AF90", Offset = "0x288A390", VA = "0x18288AF90")]
		public static Id32<LocalVariables.M> RZBMUXOLXAW(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x288AE20", Offset = "0x288A220", VA = "0x18288AE20")]
		public static Id32<LocalVariables.M> RAMXRRTDWZQ(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x288A2D0", Offset = "0x28896D0", VA = "0x18288A2D0")]
		public static void HIQHHOQUWOH(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x288AD10", Offset = "0x288A110", VA = "0x18288AD10")]
		public static void PQGGMZVOVFH(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x288A880", Offset = "0x2889C80", VA = "0x18288A880")]
		public static void KSHLWPFMGFX(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x288AC10", Offset = "0x288A010", VA = "0x18288AC10")]
		public static void OIIWZOPORLA(this FunctionCompileState a, Id32<SDWTKKVDDYT<IDPQTAFRJWO>> b, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2889830", Offset = "0x2888C30", VA = "0x182889830")]
		public static void BAGFEVICAFU(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<SDWTKKVDDYT<TVYIBYSHUKT>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA770", Offset = "0x3BF9B70", VA = "0x183BFA770")]
		public static void EZQFVSMGNRV<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<SDWTKKVDDYT<IMFYYDLBECV<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface GHQHUOGIKCI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<NTOQNIRTTPF> BVNIGFJCVCL(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<NTOQNIRTTPF> RRGEBWPQXGO(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<NTOQNIRTTPF> GVHLJEMDISL(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<NTOQNIRTTPF> PREVNUSZFEA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> DRXPQSOQRUC(a a, FunctionCompileState b, Id32<HUXETNCTSFJ> c, Id32<AINMIFOSACL> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> EIDJZKBGHLY(a a, FunctionCompileState b, Id32<HUXETNCTSFJ> c, Id32<DTGDQHKOFYM> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int XIBJBBDKUIU(a a, Id32<HUXETNCTSFJ> b, Id32<AINMIFOSACL> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<DTGDQHKOFYM> EMOHTITPITR(a a, Id32<HUXETNCTSFJ> b, Id32<AINMIFOSACL> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind SXBNTDSBJYW(a a, Id32<HUXETNCTSFJ> b, Id32<AINMIFOSACL> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HZVPKKKFPGL(a a, Id32<HUXETNCTSFJ> b, Id32<AINMIFOSACL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int MHONJSQRBPC(a a, Id32<HUXETNCTSFJ> b, Id32<AINMIFOSACL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> IIFMKVZVLSC(a a, Id32<HUXETNCTSFJ> b, Id32<AINMIFOSACL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<NTOQNIRTTPF>) BXYWOXJBPYU(a a, Id32<HUXETNCTSFJ> b, Id32<AINMIFOSACL> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int MVQLVPGASHM(a a, Id32<HUXETNCTSFJ> b, Id32<DTGDQHKOFYM> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<AINMIFOSACL> QSUXMMNYNID(a a, Id32<HUXETNCTSFJ> b, Id32<DTGDQHKOFYM> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<AINMIFOSACL> WYDHGQHTDHQ(a a, Id32<HUXETNCTSFJ> b, Id32<FRZIQAPUPIV> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int XIEIUYKXFEO(a a, Id32<HUXETNCTSFJ> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? GUPQSVNYUTO(a a, Id32<HUXETNCTSFJ> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int NLTUFTSJMXS(a a, Id32<HUXETNCTSFJ> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? HIYYJKJWVFU(a a, Id32<HUXETNCTSFJ> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class SLCVCILDUYV
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A61230", Offset = "0x3A60630", VA = "0x183A61230")]
		public static Id32<LocalVariables.M?> STUGBSZJTLK<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EEE0", Offset = "0x3A5E2E0", VA = "0x183A5EEE0")]
		public static Id32<LocalVariables.M?> DXPGJCKUBGB<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A60800", Offset = "0x3A5FC00", VA = "0x183A60800")]
		public static Id32<LocalVariables.M?> PPMUURJLRMU<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x28865C0", Offset = "0x28859C0", VA = "0x1828865C0")]
		public static Id32<LocalVariables.M> KILLLVTLHEE(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2884F60", Offset = "0x2884360", VA = "0x182884F60")]
		public static Id32<LocalVariables.M> DYRRQWOMXPN(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x28890C0", Offset = "0x28884C0", VA = "0x1828890C0")]
		public static Id32<LocalVariables.M> ZBVDCSPPGTY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2888280", Offset = "0x2887680", VA = "0x182888280")]
		public static Id32<LocalVariables.M> UFZDJYAFTLU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2886AE0", Offset = "0x2885EE0", VA = "0x182886AE0")]
		public static Id32<LocalVariables.M> MZSIDWMVOJX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2886480", Offset = "0x2885880", VA = "0x182886480")]
		public static Id32<LocalVariables.M> KFRESUJLNJC(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x28889E0", Offset = "0x2887DE0", VA = "0x1828889E0")]
		public static Id32<LocalVariables.M> WSNPSWIYDOA(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2887A40", Offset = "0x2886E40", VA = "0x182887A40")]
		public static Id32<LocalVariables.M> QWCKLNGEEYX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2887B60", Offset = "0x2886F60", VA = "0x182887B60")]
		public static Id32<LocalVariables.M> QYYRJYJIMXE(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2885620", Offset = "0x2884A20", VA = "0x182885620")]
		public static Id32<LocalVariables.M> GOWGOZBAPOP(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2888380", Offset = "0x2887780", VA = "0x182888380")]
		public static Id32<LocalVariables.M> UUNSSFSUGZG(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2884C90", Offset = "0x2884090", VA = "0x182884C90")]
		public static Id32<LocalVariables.M> DOOODCLARGR(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28869E0", Offset = "0x2885DE0", VA = "0x1828869E0")]
		public static Id32<LocalVariables.M> LQXDWYUSNVY(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28852A0", Offset = "0x28846A0", VA = "0x1828852A0")]
		public static Id32<LocalVariables.M> GANEXWISDBT(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2888560", Offset = "0x2887960", VA = "0x182888560")]
		public static Id32<LocalVariables.M> VRSXTDOHPGQ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28874A0", Offset = "0x28868A0", VA = "0x1828874A0")]
		public static Id32<LocalVariables.M> QBPHUDZBDBS(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2887CA0", Offset = "0x28870A0", VA = "0x182887CA0")]
		public static Id32<LocalVariables.M> RDBZNPHLUFF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2889280", Offset = "0x2888680", VA = "0x182889280")]
		public static Id32<LocalVariables.M> ZYCFWZEIHXA(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2885720", Offset = "0x2884B20", VA = "0x182885720")]
		public static Id32<LocalVariables.M> GTBSPUDZZCV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2887520", Offset = "0x2886920", VA = "0x182887520")]
		public static Id32<LocalVariables.M> QGSHTDWCRIW(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28846E0", Offset = "0x2883AE0", VA = "0x1828846E0")]
		public static Id32<LocalVariables.M> BNUYAGVPZRR(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28886A0", Offset = "0x2887AA0", VA = "0x1828886A0")]
		public static Id32<LocalVariables.M> WCJBKXFWPDT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28871B0", Offset = "0x28865B0", VA = "0x1828871B0")]
		public static Id32<LocalVariables.M> PKIWGDZDUFI(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28858C0", Offset = "0x2884CC0", VA = "0x1828858C0")]
		public static Id32<LocalVariables.M> HDHSOMMFZYT(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2887130", Offset = "0x2886530", VA = "0x182887130")]
		public static Id32<LocalVariables.M> PIFJKRDOXAU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2888860", Offset = "0x2887C60", VA = "0x182888860")]
		public static Id32<LocalVariables.M> WFCDOPQUJOP(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2886E70", Offset = "0x2886270", VA = "0x182886E70")]
		public static Id32<LocalVariables.M> OEWGYLUGJCK(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2884860", Offset = "0x2883C60", VA = "0x182884860")]
		public static Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> BQAURWYAWWC(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2889200", Offset = "0x2888600", VA = "0x182889200")]
		public static Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> ZKPJMCPNDFI(this FunctionCompileState a, int b)
		{
			return default(Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2884DD0", Offset = "0x28841D0", VA = "0x182884DD0")]
		public static Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> DSTSSGVXLQB(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2887F80", Offset = "0x2887380", VA = "0x182887F80")]
		public static Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> THJJITJCOEP(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2884660", Offset = "0x2883A60", VA = "0x182884660")]
		public static Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> BNJEBHEOOTV(this FunctionCompileState a, int b)
		{
			return default(Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2886940", Offset = "0x2885D40", VA = "0x182886940")]
		public static Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> LGPINDUGWXS(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2883F80", Offset = "0x2883380", VA = "0x182883F80")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UMGCKUMSNVX>) BDRHRBSDOSV(this FunctionCompileState a, Id32<IZXQRWKUWLU> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UMGCKUMSNVX>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28875A0", Offset = "0x28869A0", VA = "0x1828875A0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.UMGCKUMSNVX>) QHYRCYFYHCP(this FunctionCompileState a, Id32<AKFVBWYPZLW> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.UMGCKUMSNVX>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EAC0", Offset = "0x3A5DEC0", VA = "0x183A5EAC0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<NTOQNIRTTPF>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<TMarker>>, Id32<FunctionCalls.M>) DALGHHKHOCE<TMarker>(this FunctionCompileState a, Id32<NTOQNIRTTPF> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<NTOQNIRTTPF>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28884A0", Offset = "0x28878A0", VA = "0x1828884A0")]
		public static Id32<LocalVariables.M> VPVMDUDGSJA(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2884E70", Offset = "0x2884270", VA = "0x182884E70")]
		public static Id32<LocalVariables.M> DYNHFCPITJH(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2883E10", Offset = "0x2883210", VA = "0x182883E10")]
		public static Id32<LocalVariables.M> AIBJLWBTDBY(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2885500", Offset = "0x2884900", VA = "0x182885500")]
		public static Id32<LocalVariables.M> GGWLALQFPSN(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x28888E0", Offset = "0x2887CE0", VA = "0x1828888E0")]
		public static Id32<LocalVariables.M> WGIZNXGZYDY(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2886C10", Offset = "0x2886010", VA = "0x182886C10")]
		public static Id32<LocalVariables.M> NIAGKOWIWBH(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28866C0", Offset = "0x2885AC0", VA = "0x1828866C0")]
		public static Id32<LocalVariables.M> KVNGYHNXDOM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2887030", Offset = "0x2886430", VA = "0x182887030")]
		public static Id32<LocalVariables.M> PAKFHSRJREI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2887D20", Offset = "0x2887120", VA = "0x182887D20")]
		public static Id32<LocalVariables.M> SAMVNBIMDZV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2886800", Offset = "0x2885C00", VA = "0x182886800")]
		public static Id32<LocalVariables.M> LFZCRXEUYUW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2885FF0", Offset = "0x28853F0", VA = "0x182885FF0")]
		public static Id32<LocalVariables.M> JRSQUSZXFNX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2888AE0", Offset = "0x2887EE0", VA = "0x182888AE0")]
		public static Id32<LocalVariables.M> XCOKHNCARKS(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2883F00", Offset = "0x2883300", VA = "0x182883F00")]
		public static Id32<LocalVariables.M> ATXBFEIZRHV(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2884B90", Offset = "0x2883F90", VA = "0x182884B90")]
		public static Id32<LocalVariables.M> DCIACXWBKSN(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28853D0", Offset = "0x28847D0", VA = "0x1828853D0")]
		public static Id32<LocalVariables.M> GGDVUXGDHFA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2887E40", Offset = "0x2887240", VA = "0x182887E40")]
		public static Id32<LocalVariables.M> SWRWYWKEYHN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2885940", Offset = "0x2884D40", VA = "0x182885940")]
		public static Id32<LocalVariables.M> HNROQGOMSXG(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2885080", Offset = "0x2884480", VA = "0x182885080")]
		public static Id32<LocalVariables.M> FCNJXBNOGCH(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2886EF0", Offset = "0x28862F0", VA = "0x182886EF0")]
		public static Id32<LocalVariables.M> OPZBHFGWZOW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2884A60", Offset = "0x2883E60", VA = "0x182884A60")]
		public static Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>> CGLFZIHJKOK(this FunctionCompileState a)
		{
			return default(Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2888FC0", Offset = "0x28883C0", VA = "0x182888FC0")]
		public static Id32<LocalVariables.M> ZALUGYNVSQD(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2888B60", Offset = "0x2887F60", VA = "0x182888B60")]
		public static Id32<LocalVariables.M> XFZRYJAYEQE(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2888C80", Offset = "0x2888080", VA = "0x182888C80")]
		public static Id32<LocalVariables.M> XMVHUPXSTLH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2888DC0", Offset = "0x28881C0", VA = "0x182888DC0")]
		public static Id32<LocalVariables.M> XNXOSXJNLAF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2884420", Offset = "0x2883820", VA = "0x182884420")]
		public static Id32<LocalVariables.M> BKWNOIMTLTM(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2885D70", Offset = "0x2885170", VA = "0x182885D70")]
		public static Id32<LocalVariables.M> IPIQDSFYQHF(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2888180", Offset = "0x2887580", VA = "0x182888180")]
		public static Id32<LocalVariables.M> TTQFJZSPYMC(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2884A80", Offset = "0x2883E80", VA = "0x182884A80")]
		public static Id32<LocalVariables.M> CNEJXDTNQND(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2886C00", Offset = "0x2886000", VA = "0x182886C00")]
		public static void NAQDWGYPLVO(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2888EC0", Offset = "0x28882C0", VA = "0x182888EC0")]
		public static Id32<LocalVariables.M> XZMPKVXFEDZ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2884540", Offset = "0x2883940", VA = "0x182884540")]
		public static Id32<LocalVariables.M> BMFWDOAYAJG(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2885EB0", Offset = "0x28852B0", VA = "0x182885EB0")]
		public static Id32<LocalVariables.M> IUQDHKMOMTP(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2884760", Offset = "0x2883B60", VA = "0x182884760")]
		public static Id32<LocalVariables.M> BOYHYNUYQTH(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2887230", Offset = "0x2886630", VA = "0x182887230")]
		public static Id32<LocalVariables.M> POKUYDITTNU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2888720", Offset = "0x2887B20", VA = "0x182888720")]
		public static Id32<LocalVariables.M> WDTMNUOZGAH(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2886070", Offset = "0x2885470", VA = "0x182886070")]
		public static Id32<LocalVariables.M> KBIHPAENBKH(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28851A0", Offset = "0x28845A0", VA = "0x1828851A0")]
		public static Id32<LocalVariables.M> FGEGOXIBBWQ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28857A0", Offset = "0x2884BA0", VA = "0x1828857A0")]
		public static Id32<LocalVariables.M> GZPLPHCQPRB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2886D30", Offset = "0x2886130", VA = "0x182886D30")]
		public static Id32<LocalVariables.M> NUDZXSOIFSS(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F8C0", Offset = "0x3A5ECC0", VA = "0x183A5F8C0")]
		public static void HVYXTUUYKBR<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<IZXQRWKUWLU> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, GHQHUOGIKCI<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F110", Offset = "0x3A5E510", VA = "0x183A5F110")]
		public static void GEWMXGCHVQN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<AKFVBWYPZLW> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, GHQHUOGIKCI<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3A60930", Offset = "0x3A5FD30", VA = "0x183A60930")]
		public static Id32<LocalVariables.M> QCFSAOXQZBV<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, GHQHUOGIKCI<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E460", Offset = "0x3A5D860", VA = "0x183A5E460")]
		public static Id32<LocalVariables.M> CFDLVBTOIUA<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, GHQHUOGIKCI<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3A61420", Offset = "0x3A60820", VA = "0x183A61420")]
		public static Id32<DataBackResults.M> URGIKMHXOOJ<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, GHQHUOGIKCI<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3A603D0", Offset = "0x3A5F7D0", VA = "0x183A603D0")]
		public static Id32<ExecForwardResults.M> PIRXFLBUVFQ<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, GHQHUOGIKCI<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2887350", Offset = "0x2886750", VA = "0x182887350")]
		public static Id32<DataBackResults.M> PQQAWREGNFI(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2885A40", Offset = "0x2884E40", VA = "0x182885A40")]
		public static Id32<DataBackResults.M> HYCYXWTSRRW(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3A61720", Offset = "0x3A60B20", VA = "0x183A61720")]
		public static Id32<DataBackResults.M> YEUEYPXOFZJ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<IZXQRWKUWLU> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, GHQHUOGIKCI<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3A61900", Offset = "0x3A60D00", VA = "0x183A61900")]
		private static Id32<DataBackResults.M> YEUEYPXOFZJ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<IZXQRWKUWLU> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, GHQHUOGIKCI<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3A60C50", Offset = "0x3A60050", VA = "0x183A60C50")]
		public static Id32<LocalVariables.M> SMEGKGBDZVZ<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, GHQHUOGIKCI<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3A60070", Offset = "0x3A5F470", VA = "0x183A60070")]
		public static void LRXFYKKTPOK<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, GHQHUOGIKCI<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<SDWTKKVDDYT<IDPQTAFRJWO>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<SDWTKKVDDYT<IDPQTAFRJWO>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
		public LiveInterval(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> firstUse, Id32<SDWTKKVDDYT<IDPQTAFRJWO>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2882D80", Offset = "0x2882180", VA = "0x182882D80")]
		public static LiveInterval New(Id32<SDWTKKVDDYT<IDPQTAFRJWO>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class GHGALWMVZFM : FPMZCSHTCRD
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
			[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class EREFKLPONBM : FPMZCSHTCRD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class EYXSFBGHJVL : FPMZCSHTCRD
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
			[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
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
		public abstract class FPMZCSHTCRD
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
			public Id32<FPMZCSHTCRD> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2882B90", Offset = "0x2881F90", VA = "0x182882B90")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<FPMZCSHTCRD> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class DVMQLPDBHOM : FPMZCSHTCRD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<GHGALWMVZFM, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<EYXSFBGHJVL, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<DVMQLPDBHOM, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<EREFKLPONBM, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2882F80", Offset = "0x2882380", VA = "0x182882F80")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<GHGALWMVZFM, ArgumentInst> argumentVariables, [In] SOAId32Field<EYXSFBGHJVL, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<DVMQLPDBHOM, ParameterInst> parameterVariables, [In] SOAId32Field<EREFKLPONBM, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2882D90", Offset = "0x2882190", VA = "0x182882D90")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class XFWJYZGJFQN
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x288BED0", Offset = "0x288B2D0", VA = "0x18288BED0")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class FZLMUYRGBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2881770", Offset = "0x2880B70", VA = "0x182881770")]
		public static void ZCWYKYGUMCT(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.UMGCKUMSNVX, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2881420", Offset = "0x2880820", VA = "0x182881420")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.UMGCKUMSNVX, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28813B0", Offset = "0x28807B0", VA = "0x1828813B0")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2881190", Offset = "0x2880590", VA = "0x182881190")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x32D9F70", Offset = "0x32D9370", VA = "0x1832D9F70")]
		public static void ZCWYKYGUMCT<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<HUXETNCTSFJ> graphId) where TDeps : notnull, GHQHUOGIKCI<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class KPDBWTMECKG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2882BB0", Offset = "0x2881FB0", VA = "0x182882BB0")]
		public static void ZCWYKYGUMCT(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface ZMZHYXRIVUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void YJROEFFJJGG(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : ZMZHYXRIVUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2883CD0", Offset = "0x28830D0", VA = "0x182883CD0", Slot = "4")]
			public void YJROEFFJJGG(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : ZMZHYXRIVUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2883D60", Offset = "0x2883160", VA = "0x182883D60", Slot = "4")]
			public void YJROEFFJJGG(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : ZMZHYXRIVUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2883B90", Offset = "0x2882F90", VA = "0x182883B90", Slot = "4")]
			public void YJROEFFJJGG(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : ZMZHYXRIVUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2883C20", Offset = "0x2883020", VA = "0x182883C20", Slot = "4")]
			public void YJROEFFJJGG(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class FSLDAEIQYGN<c> where c : struct, ZMZHYXRIVUF
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c MKZWHJKZWXT;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x35C2340", Offset = "0x35C1740", VA = "0x1835C2340")]
			public static int ZCWYKYGUMCT<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : GHQHUOGIKCI<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<FunctionCalls.UMGCKUMSNVX>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2882B40", Offset = "0x2881F40", VA = "0x182882B40")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<FunctionCalls.UMGCKUMSNVX>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2882A90", Offset = "0x2881E90", VA = "0x182882A90")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2882A50", Offset = "0x2881E50", VA = "0x182882A50")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x36BF570", Offset = "0x36BE970", VA = "0x1836BF570")]
		public static void ZCWYKYGUMCT<b, a>(FunctionCompileState a, b b, a c) where b : GHQHUOGIKCI<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class MPUWSKCJYRB
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
		private static int NWJLAYXOUAL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int PZQFDLPHBBL;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2883560", Offset = "0x2882960", VA = "0x182883560")]
		public static void ZCWYKYGUMCT(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2883210", Offset = "0x2882610", VA = "0x182883210")]
		private static void UANZPMIWXXA([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2883420", Offset = "0x2882820", VA = "0x182883420")]
		private static void UANZPMIWXXA(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28830B0", Offset = "0x28824B0", VA = "0x1828830B0")]
		private static void FLBOBCNKYHD(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class IKNQBESKOBJ<a, b, c> where a : struct, FQLUWDIQIAP<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a MKZWHJKZWXT;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7FE0", Offset = "0x4FF73E0", VA = "0x184FF7FE0")]
		public static void ZCWYKYGUMCT([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface FQLUWDIQIAP<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> SVCIRVORAWT(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VMUMDBDVRSN(a a, b b, Id32<SDWTKKVDDYT<FVPAIKKPAFL>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface EGHODWMFDZE<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a PSUMOWREDJY(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool LDCWZZRDNUM(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<SDWTKKVDDYT<FVPAIKKPAFL>> RHCFKKKIGYR(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class WAGLCQMXKAS<a, b, c> where a : struct, EGHODWMFDZE<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a MKZWHJKZWXT;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x65A2E60", Offset = "0x65A2260", VA = "0x1865A2E60")]
		public static UnsafeList<b> ZCWYKYGUMCT(int a, [In] c values)
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
