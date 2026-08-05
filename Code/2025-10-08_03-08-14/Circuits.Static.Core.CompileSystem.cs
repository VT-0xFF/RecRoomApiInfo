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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AFAB20", Offset = "0x2AF9920", VA = "0x182AFAB20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		public readonly Id32<DXZFAYBWXNM<NLAXFVYHLZG>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
		public ByteCodeAdjustment(Id32<DXZFAYBWXNM<NLAXFVYHLZG>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class FCTOHJQWDZE : GLVUCTICSAC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2A85B30", Offset = "0x2A84930", VA = "0x182A85B30")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2DA0", Offset = "0x2AF1BA0", VA = "0x182AF2DA0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class AYRJKHXHVWJ : GLVUCTICSAC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<DXZFAYBWXNM<JPROXOTIKYR>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			public DeadEnd(Id32<DXZFAYBWXNM<JPROXOTIKYR>> nextByteCodePtr)
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
		public abstract class GLVUCTICSAC
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
			public readonly Id32<GLVUCTICSAC> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
			public Inst(Def def, Id32<GLVUCTICSAC> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class BVFULNRSANI : GLVUCTICSAC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class NEZHEVFHJDK : GLVUCTICSAC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x24D7D60", Offset = "0x24D6B60", VA = "0x1824D7D60", Slot = "3")]
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
		internal IdUnsafeList<FCTOHJQWDZE, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<AYRJKHXHVWJ, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<BVFULNRSANI, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<NEZHEVFHJDK, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2FA0", Offset = "0x2AF1DA0", VA = "0x182AF2FA0")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<FCTOHJQWDZE, BytesImmediate> bytesImmediates, [In] IdUnsafeList<AYRJKHXHVWJ, DeadEnd> deadEnds, [In] IdUnsafeList<BVFULNRSANI, Variable> variables, [In] IdUnsafeList<NEZHEVFHJDK, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2E60", Offset = "0x2AF1C60", VA = "0x182AF2E60")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class JFFROJRHFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9A80", Offset = "0x2AF8880", VA = "0x182AF9A80")]
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
		public sealed class OETXJYRFWOV : GLVUCTICSAC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
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
		public abstract class GLVUCTICSAC
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
			public readonly Id32<GLVUCTICSAC> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
			public Inst(Def def, Id32<GLVUCTICSAC> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<OETXJYRFWOV, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3220", Offset = "0x2AF2020", VA = "0x182AF3220")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<OETXJYRFWOV, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3190", Offset = "0x2AF1F90", VA = "0x182AF3190")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class BVTEZVIAVZM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2D40", Offset = "0x2AF1B40", VA = "0x182AF2D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AF3300", Offset = "0x2AF2100", VA = "0x182AF3300")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3260", Offset = "0x2AF2060", VA = "0x182AF3260")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class CPGOWDWXZSB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2E10", Offset = "0x2AF1C10", VA = "0x182AF2E10")]
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
		public sealed class OUITYWVXEEB : GLVUCTICSAC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<XROXTIHADRI> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			public ExternalCall(Id32<XROXTIHADRI> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class GLVUCTICSAC
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
			public readonly Id32<GLVUCTICSAC> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
			private Inst(Def def, Id32<GLVUCTICSAC> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9A50", Offset = "0x2AF8850", VA = "0x182AF9A50")]
			public static Inst New(Def def, Id32<GLVUCTICSAC> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class RWFMOFWUMOX : GLVUCTICSAC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<XROXTIHADRI> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			public InternalCall(Id32<XROXTIHADRI> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class XROXTIHADRI
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
			[Cpp2IlInjected.Address(RVA = "0x2AF3220", Offset = "0x2AF2020", VA = "0x182AF3220")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF97F0", Offset = "0x2AF85F0", VA = "0x182AF97F0")]
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
		internal IdUnsafeList<RWFMOFWUMOX, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<OUITYWVXEEB, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<XROXTIHADRI> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<XROXTIHADRI, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3500", Offset = "0x2AF2300", VA = "0x182AF3500")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<RWFMOFWUMOX, InternalCall> internalCalls, [In] IdUnsafeList<OUITYWVXEEB, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<XROXTIHADRI> IOId)> callsWithIO, [In] IdUnsafeList<XROXTIHADRI, IO> io, [In] SOAField<XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> ioModifyingCallLocations, [In] SOAField<XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3360", Offset = "0x2AF2160", VA = "0x182AF3360")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class JMLJZHVZOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9B30", Offset = "0x2AF8930", VA = "0x182AF9B30")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9B80", Offset = "0x2AF8980", VA = "0x182AF9B80")]
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
		internal SOAField<LQRVDHOTVET, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<LQRVDHOTVET>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3F50", Offset = "0x2AF2D50", VA = "0x182AF3F50")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<LQRVDHOTVET, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<LQRVDHOTVET>> generatedOutputsForExpression, [In] SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2AF35C0", Offset = "0x2AF23C0", VA = "0x182AF35C0")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class TIOOWDATXVC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : GEBPMYXZGRR<Id32<FunctionCalls.XROXTIHADRI>, SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAE30", Offset = "0x2AF9C30", VA = "0x182AFAE30")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAEB0", Offset = "0x2AF9CB0", VA = "0x182AFAEB0", Slot = "4")]
			public Id32<FunctionCalls.XROXTIHADRI> TXCYXFDQLCX(int a)
			{
				return default(Id32<FunctionCalls.XROXTIHADRI>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0")]
			public bool LOZMZEPHJWV(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "5")]
			private bool NEVZAEQQWWZ(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAE20", Offset = "0x2AF9C20", VA = "0x182AFAE20", Slot = "6")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SQRNDDPMGDW(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : OWINMMJJZPY<Id32<FunctionCalls.XROXTIHADRI>, SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1ED0", Offset = "0x2AF0CD0", VA = "0x182AF1ED0")]
			public UnsafeList<Id32<FunctionCalls.XROXTIHADRI>> CSBKNNACGAA(int a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.XROXTIHADRI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1FF0", Offset = "0x2AF0DF0", VA = "0x182AF1FF0")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1F50", Offset = "0x2AF0D50", VA = "0x182AF1F50", Slot = "6")]
			public void DVDXHBLEZRS(Id32<FunctionCalls.XROXTIHADRI> a, SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> b, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1ED0", Offset = "0x2AF0CD0", VA = "0x182AF1ED0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.XROXTIHADRI>> VFWEILLXUTN(int a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.XROXTIHADRI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1F40", Offset = "0x2AF0D40", VA = "0x182AF1F40", Slot = "5")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> DOQAHUMPDVH(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<JPROXOTIKYR>>> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : GEBPMYXZGRR<Id32<FunctionCalls.XROXTIHADRI>, SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAF00", Offset = "0x2AF9D00", VA = "0x182AFAF00")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAF80", Offset = "0x2AF9D80", VA = "0x182AFAF80", Slot = "4")]
			public Id32<FunctionCalls.XROXTIHADRI> TXCYXFDQLCX(int a)
			{
				return default(Id32<FunctionCalls.XROXTIHADRI>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0")]
			public bool LOZMZEPHJWV(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "5")]
			private bool HPZRLEFJJYG(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAEF0", Offset = "0x2AF9CF0", VA = "0x182AFAEF0", Slot = "6")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> EOCKZIUJSQT(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : OWINMMJJZPY<Id32<FunctionCalls.XROXTIHADRI>, SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2070", Offset = "0x2AF0E70", VA = "0x182AF2070")]
			public UnsafeList<Id32<FunctionCalls.XROXTIHADRI>> CSBKNNACGAA(int a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.XROXTIHADRI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2190", Offset = "0x2AF0F90", VA = "0x182AF2190")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2AF20E0", Offset = "0x2AF0EE0", VA = "0x182AF20E0", Slot = "6")]
			public void DVDXHBLEZRS(Id32<FunctionCalls.XROXTIHADRI> a, SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> b, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2070", Offset = "0x2AF0E70", VA = "0x182AF2070", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.XROXTIHADRI>> DNRVOYKLDIM(int a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.XROXTIHADRI>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2180", Offset = "0x2AF0F80", VA = "0x182AF2180", Slot = "5")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> NWAWMPBLDDS(Id32<FunctionCalls.XROXTIHADRI> a, [In] SOAField<FunctionCalls.XROXTIHADRI, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : GEBPMYXZGRR<Id32<UTWGPDLERGC>, SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB030", Offset = "0x2AF9E30", VA = "0x182AFB030")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(Id32<UTWGPDLERGC> a, [In] SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB0E0", Offset = "0x2AF9EE0", VA = "0x182AFB0E0", Slot = "4")]
			public Id32<UTWGPDLERGC> TXCYXFDQLCX(int a)
			{
				return default(Id32<UTWGPDLERGC>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAFD0", Offset = "0x2AF9DD0", VA = "0x182AFAFD0")]
			public bool LOZMZEPHJWV(Id32<UTWGPDLERGC> a, [In] SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAFD0", Offset = "0x2AF9DD0", VA = "0x182AFAFD0", Slot = "5")]
			private bool TBYZNRCFVXO(Id32<UTWGPDLERGC> a, [In] SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAFC0", Offset = "0x2AF9DC0", VA = "0x182AFAFC0", Slot = "6")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> EXVCPCSWAPT(Id32<UTWGPDLERGC> a, [In] SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : OWINMMJJZPY<Id32<UTWGPDLERGC>, SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2210", Offset = "0x2AF1010", VA = "0x182AF2210")]
			public UnsafeList<Id32<UTWGPDLERGC>> CSBKNNACGAA(int a, [In] SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> values)
			{
				return default(UnsafeList<Id32<UTWGPDLERGC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2380", Offset = "0x2AF1180", VA = "0x182AF2380")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(Id32<UTWGPDLERGC> a, [In] SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2280", Offset = "0x2AF1080", VA = "0x182AF2280", Slot = "6")]
			public void DVDXHBLEZRS(Id32<UTWGPDLERGC> a, SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> b, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2210", Offset = "0x2AF1010", VA = "0x182AF2210", Slot = "4")]
			private UnsafeList<Id32<UTWGPDLERGC>> IOYETWIMFOO(int a, [In] SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> values)
			{
				return default(UnsafeList<Id32<UTWGPDLERGC>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2430", Offset = "0x2AF1230", VA = "0x182AF2430", Slot = "5")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> WYTRLNNNDTI(Id32<UTWGPDLERGC> a, [In] SOAField<UTWGPDLERGC, Id32<DXZFAYBWXNM<JPROXOTIKYR>>?> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : GEBPMYXZGRR<int, UnsafeList<(Id32<LocalVariables.M>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB270", Offset = "0x2AFA070", VA = "0x182AFB270")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xBD0E60", Offset = "0xBCFC60", VA = "0x180BD0E60", Slot = "4")]
			public int TXCYXFDQLCX(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0")]
			public bool LOZMZEPHJWV(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "5")]
			private bool JOYFWXUCDLX(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB260", Offset = "0x2AFA060", VA = "0x182AFB260", Slot = "6")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> IZQPSIETDXO(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : OWINMMJJZPY<int, UnsafeList<(Id32<LocalVariables.M>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2860", Offset = "0x2AF1660", VA = "0x182AF2860")]
			public UnsafeList<int> CSBKNNACGAA(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2AF29E0", Offset = "0x2AF17E0", VA = "0x182AF29E0")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2AF28D0", Offset = "0x2AF16D0", VA = "0x182AF28D0", Slot = "6")]
			public void DVDXHBLEZRS(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> values, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2860", Offset = "0x2AF1660", VA = "0x182AF2860", Slot = "4")]
			private UnsafeList<int> GOQYABPEDIR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2AF29D0", Offset = "0x2AF17D0", VA = "0x182AF29D0", Slot = "5")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> GYSVHVLSOFV(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<DXZFAYBWXNM<CIAGZBHOAUA<NLAXFVYHLZG>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : GEBPMYXZGRR<int, UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB1D0", Offset = "0x2AF9FD0", VA = "0x182AFB1D0")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xBD0E60", Offset = "0xBCFC60", VA = "0x180BD0E60", Slot = "4")]
			public int TXCYXFDQLCX(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0")]
			public bool LOZMZEPHJWV(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "5")]
			private bool RBGVYKXPBII(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB1C0", Offset = "0x2AF9FC0", VA = "0x182AFB1C0", Slot = "6")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> RRKSWBMTAOR(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : OWINMMJJZPY<int, UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2650", Offset = "0x2AF1450", VA = "0x182AF2650")]
			public UnsafeList<int> CSBKNNACGAA(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF27C0", Offset = "0x2AF15C0", VA = "0x182AF27C0")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF26C0", Offset = "0x2AF14C0", VA = "0x182AF26C0", Slot = "6")]
			public void DVDXHBLEZRS(int a, UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2650", Offset = "0x2AF1450", VA = "0x182AF2650", Slot = "4")]
			private UnsafeList<int> TTKOWNBTLDW(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2850", Offset = "0x2AF1650", VA = "0x182AF2850", Slot = "5")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> ZBBWOKMOPOU(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : GEBPMYXZGRR<int, UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB130", Offset = "0x2AF9F30", VA = "0x182AFB130")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xBD0E60", Offset = "0xBCFC60", VA = "0x180BD0E60", Slot = "4")]
			public int TXCYXFDQLCX(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0")]
			public bool LOZMZEPHJWV(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "5")]
			private bool RBGVYKXPBII(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB120", Offset = "0x2AF9F20", VA = "0x182AFB120", Slot = "6")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> RRKSWBMTAOR(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : OWINMMJJZPY<int, UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2440", Offset = "0x2AF1240", VA = "0x182AF2440")]
			public UnsafeList<int> CSBKNNACGAA(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2AF25B0", Offset = "0x2AF13B0", VA = "0x182AF25B0")]
			public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2AF24B0", Offset = "0x2AF12B0", VA = "0x182AF24B0", Slot = "6")]
			public void DVDXHBLEZRS(int a, UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2440", Offset = "0x2AF1240", VA = "0x182AF2440", Slot = "4")]
			private UnsafeList<int> TTKOWNBTLDW(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2640", Offset = "0x2AF1440", VA = "0x182AF2640", Slot = "5")]
			private Id32<DXZFAYBWXNM<NLAXFVYHLZG>> ZBBWOKMOPOU(int a, [In] UnsafeList<(Id32<DXZFAYBWXNM<JPROXOTIKYR>> Target, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
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
			[Cpp2IlInjected.Address(RVA = "0x218E830", Offset = "0x218D630", VA = "0x18218E830")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF97E0", Offset = "0x2AF85E0", VA = "0x182AF97E0")]
			public void KAKPPNOMYGN([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<UTWGPDLERGC> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF97C0", Offset = "0x2AF85C0", VA = "0x182AF97C0")]
			public GenerateDataBackFromInputIndexResult(Id32<UTWGPDLERGC> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF97B0", Offset = "0x2AF85B0", VA = "0x182AF97B0")]
			public void KAKPPNOMYGN([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9790", Offset = "0x2AF8590", VA = "0x182AF9790")]
			public void KAKPPNOMYGN([Out] Id32<DataBackResults.M> a, [Out] Id32<UTWGPDLERGC> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<UTWGPDLERGC> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
			public GenerateDataBackFromInputIndicesResult(Id32<UTWGPDLERGC> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF97D0", Offset = "0x2AF85D0", VA = "0x182AF97D0")]
			public void KAKPPNOMYGN([Out] Id32<DataBackResults.M> a, [Out] Id32<UTWGPDLERGC> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB8B0", Offset = "0x2AFA6B0", VA = "0x182AFB8B0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC600", Offset = "0x2AFB400", VA = "0x182AFC600")]
		public static void OVVIXMWAVWW(this FunctionCompileState a, Id32<LQRVDHOTVET> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCAE0", Offset = "0x2AFB8E0", VA = "0x182AFCAE0")]
		public static void RGETLEVXTYM(this FunctionCompileState a, Id32<LQRVDHOTVET> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC80", Offset = "0x2AFBA80", VA = "0x182AFCC80")]
		public static Id32<DataBackResults.M>? TYLUKNLFOIF([In] this FunctionCompileState self, Id32<LQRVDHOTVET> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC20", Offset = "0x2AFBA20", VA = "0x182AFCC20")]
		public static Id32<DXZFAYBWXNM<JPROXOTIKYR>> TBMMMGQWDOV([In] this FunctionCompileState self)
		{
			return default(Id32<DXZFAYBWXNM<JPROXOTIKYR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC790", Offset = "0x2AFB590", VA = "0x182AFC790")]
		private static void PZWKOIPLFCG(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB680", Offset = "0x2AFA480", VA = "0x182AFB680")]
		private static Id32<DXZFAYBWXNM<JPROXOTIKYR>>? CQBROWIGSQJ([In] this FunctionCompileState self, Id32<UTWGPDLERGC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC320", Offset = "0x2AFB120", VA = "0x182AFC320")]
		public static void KODKLYOFRVD(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCE50", Offset = "0x2AFBC50", VA = "0x182AFCE50")]
		public static DataBackResults.Def WERDJFFYCHH([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD170", Offset = "0x2AFBF70", VA = "0x182AFD170")]
		public static ReadOnlyArray<byte> XZFGOFJLZIJ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBB80", Offset = "0x2AFA980", VA = "0x182AFBB80")]
		public static Id32<LocalVariables.M> EGFOQNFREYP([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBF90", Offset = "0x2AFAD90", VA = "0x182AFBF90")]
		public static Union32 HUFYBECQIZJ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D33290", Offset = "0x3D32090", VA = "0x183D33290")]
		private static Id32<DataBackResults.M> UDDYBVMOPHG<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.GLVUCTICSAC
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC530", Offset = "0x2AFB330", VA = "0x182AFC530")]
		public static Id32<DataBackResults.M> OPKLRSTHDBI(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD420", Offset = "0x2AFC220", VA = "0x182AFD420")]
		public static Id32<DataBackResults.M> YKXSJNOXQBT(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBC60", Offset = "0x2AFAA60", VA = "0x182AFBC60")]
		public static Id32<DataBackResults.M> FCSXHSHNRNG(this FunctionCompileState a, Id32<DXZFAYBWXNM<JPROXOTIKYR>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBE00", Offset = "0x2AFAC00", VA = "0x182AFBE00")]
		public static Id32<DataBackResults.M> HFBNPEZBLXE(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB600", Offset = "0x2AFA400", VA = "0x182AFB600")]
		public static Id32<DataBackResults.M> CDTQBMZORTL(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D33330", Offset = "0x3D32130", VA = "0x183D33330")]
		private static Id32<ExecForwardResults.M> XLBKQWSYKPV<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.GLVUCTICSAC
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC4F0", Offset = "0x2AFB2F0", VA = "0x182AFC4F0")]
		public static Id32<ExecForwardResults.M> NIVALQSSHCN(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB810", Offset = "0x2AFA610", VA = "0x182AFB810")]
		public static Id32<ExecForwardResults.M> DABYSTTDVTY(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC070", Offset = "0x2AFAE70", VA = "0x182AFC070")]
		public static Id32<ExecForwardResults.M> HVPDAYLTWZY(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC690", Offset = "0x2AFB490", VA = "0x182AFC690")]
		public static Id32<ExecForwardResults.M> PJGGGDCYMYH(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCD00", Offset = "0x2AFBB00", VA = "0x182AFCD00")]
		public static Id32<ExecForwardResults.M> VCNGEKOBKYX(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCBB0", Offset = "0x2AFB9B0", VA = "0x182AFCBB0")]
		public static FunctionCalls.Def RXLHNJCFEOI([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBDC0", Offset = "0x2AFABC0", VA = "0x182AFBDC0")]
		public static CopyEnumerable<Id32<FunctionCalls.XROXTIHADRI>, Id32Enumerator<FunctionCalls.XROXTIHADRI>> HBDQWDBDKVD([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.XROXTIHADRI>, Id32Enumerator<FunctionCalls.XROXTIHADRI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD250", Offset = "0x2AFC050", VA = "0x182AFD250")]
		public static Id32<FunctionCalls.XROXTIHADRI> YDFDZAMQMKQ([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.XROXTIHADRI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB590", Offset = "0x2AFA390", VA = "0x182AFB590")]
		public static FunctionCalls.IO CAKIZQEGWCV([In] this FunctionCompileState self, Id32<FunctionCalls.XROXTIHADRI> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCDE0", Offset = "0x2AFBBE0", VA = "0x182AFCDE0")]
		public static FunctionCalls.IO WEDRYBLUQFT(this FunctionCompileState a, Id32<FunctionCalls.XROXTIHADRI> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D31D00", Offset = "0x3D30B00", VA = "0x183D31D00")]
		private static Id32<FunctionCalls.M> JZQIYOJLURQ<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.GLVUCTICSAC
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC930", Offset = "0x2AFB730", VA = "0x182AFC930")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.XROXTIHADRI>) RBCDUSPWCLV(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.XROXTIHADRI>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD500", Offset = "0x2AFC300", VA = "0x182AFD500")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.XROXTIHADRI>) YZVZISSRFOR(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.XROXTIHADRI>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC5B0", Offset = "0x2AFB3B0", VA = "0x182AFC5B0")]
		public static Id32<FunctionCalls.M> OTDZEGNMCZA(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCD50", Offset = "0x2AFBB50", VA = "0x182AFCD50")]
		public static void VKXVMAQWVHF(this FunctionCompileState a, Id32<FunctionCalls.XROXTIHADRI> b, Id32<DXZFAYBWXNM<JPROXOTIKYR>> c, Id32<DXZFAYBWXNM<OAUMMLHDYFG>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D31D90", Offset = "0x3D30B90", VA = "0x183D31D90")]
		public static GenerateDataBackResult OAENHLEHWVR<d, e>(this FunctionCompileState a, d b, e c, Id32<DINEWLJZVXU> d, Id32<UTWGPDLERGC> e) where d : XZBYKVFOQNN<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D318B0", Offset = "0x3D306B0", VA = "0x183D318B0")]
		public static GenerateDataBackFromInputIndexResult HRJQBNHGJKL<f, g>(this FunctionCompileState a, f b, g c, Id32<DINEWLJZVXU> d, Id32<KSHTGNRFKHE> e, int f) where f : XZBYKVFOQNN<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3D333D0", Offset = "0x3D321D0", VA = "0x183D333D0")]
		public static Id32<DataBackResults.M>? YEDQUCISHOC<h, i>(this FunctionCompileState a, h b, i c, Id32<DINEWLJZVXU> d, Id32<KSHTGNRFKHE> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : XZBYKVFOQNN<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3D31090", Offset = "0x3D2FE90", VA = "0x183D31090")]
		public static Id32<ExecForwardResults.M> HFSZHNNWUSS<j, k>(this FunctionCompileState a, j b, k c, Id32<DINEWLJZVXU> d, Id32<LQRVDHOTVET> e) where j : XZBYKVFOQNN<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBE80", Offset = "0x2AFAC80", VA = "0x182AFBE80")]
		public static LocalVariables.ArgumentInst HHJHJSIFGVU([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB700", Offset = "0x2AFA500", VA = "0x182AFB700")]
		public static LocalVariables.CalleeReturnValueInst CRGPEYBEUQG([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC0F0", Offset = "0x2AFAEF0", VA = "0x182AFC0F0")]
		public static LocalVariables.CallerReturnValueInst JUIOJXTKQON([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD740", Offset = "0x2AFC540", VA = "0x182AFD740")]
		public static Id32<LocalVariables.M> ZJVFAZSDHFZ(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCFD0", Offset = "0x2AFBDD0", VA = "0x182AFCFD0")]
		public static LocalVariables.ParameterInst XIVFLLACAJC([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB860", Offset = "0x2AFA660", VA = "0x182AFB860")]
		public static LocalVariables.Def DJFKUSBLETK([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD4B0", Offset = "0x2AFC2B0", VA = "0x182AFD4B0")]
		public static int? YMNASDUQFVE([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3D33190", Offset = "0x3D31F90", VA = "0x183D33190")]
		private static Id32<LocalVariables.M> OTZJKJDISAS<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.GLVUCTICSAC
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCEC0", Offset = "0x2AFBCC0", VA = "0x182AFCEC0")]
		public static Id32<LocalVariables.M> WRNGCPFZTQI(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCF70", Offset = "0x2AFBD70", VA = "0x182AFCF70")]
		public static Id32<LocalVariables.M> XBYADCPJONB(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB300", Offset = "0x2AFA100", VA = "0x182AFB300")]
		public static Id32<LocalVariables.M> BCVPALLUWAN(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD6B0", Offset = "0x2AFC4B0", VA = "0x182AFD6B0")]
		public static Id32<LocalVariables.M> ZCJEAJSBLJT(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC490", Offset = "0x2AFB290", VA = "0x182AFC490")]
		public static Id32<LocalVariables.M> LGQPPZVINKN(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC200", Offset = "0x2AFB000", VA = "0x182AFC200")]
		public static void KKBLSURAHKG(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB480", Offset = "0x2AFA280", VA = "0x182AFB480")]
		public static void BGSZYWLTWBE(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC6E0", Offset = "0x2AFB4E0", VA = "0x182AFC6E0")]
		public static void PJGJFJZLLOK(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD0E0", Offset = "0x2AFBEE0", VA = "0x182AFD0E0")]
		public static void XQNJSJVLCYJ(this FunctionCompileState a, Id32<DXZFAYBWXNM<JPROXOTIKYR>> b, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBCE0", Offset = "0x2AFAAE0", VA = "0x182AFBCE0")]
		public static void GKJRLQIQWTD(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<DXZFAYBWXNM<FBGFJIJTVUU>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3D33A10", Offset = "0x3D32810", VA = "0x183D33A10")]
		public static void YVKXXXHHPFU<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<DXZFAYBWXNM<CIAGZBHOAUA<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface XZBYKVFOQNN<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<NLLDXUHMLOS> RUCXZOFDLCM(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<NLLDXUHMLOS> GEVCOAYMEJL(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<NLLDXUHMLOS> MFVDKQXKXLY(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<NLLDXUHMLOS> CRPCUIGQKFP(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> DWQDTAXGCRN(a a, FunctionCompileState b, Id32<DINEWLJZVXU> c, Id32<UTWGPDLERGC> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> RWENYQMKUZL(a a, FunctionCompileState b, Id32<DINEWLJZVXU> c, Id32<LQRVDHOTVET> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int EYGADNMOZRX(a a, Id32<DINEWLJZVXU> b, Id32<UTWGPDLERGC> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<LQRVDHOTVET> LBXXAKONCYK(a a, Id32<DINEWLJZVXU> b, Id32<UTWGPDLERGC> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind ZADPKAZLKAP(a a, Id32<DINEWLJZVXU> b, Id32<UTWGPDLERGC> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool SHIJUVBGRUE(a a, Id32<DINEWLJZVXU> b, Id32<UTWGPDLERGC> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int OJOTLYRCEXT(a a, Id32<DINEWLJZVXU> b, Id32<UTWGPDLERGC> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> IQBRHQWKKTV(a a, Id32<DINEWLJZVXU> b, Id32<UTWGPDLERGC> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<NLLDXUHMLOS>) WQOHWBWIRIJ(a a, Id32<DINEWLJZVXU> b, Id32<UTWGPDLERGC> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int FTWYNJGUCSH(a a, Id32<DINEWLJZVXU> b, Id32<LQRVDHOTVET> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<UTWGPDLERGC> IHPRSGHODNM(a a, Id32<DINEWLJZVXU> b, Id32<LQRVDHOTVET> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<UTWGPDLERGC> ROBVZWJKXVZ(a a, Id32<DINEWLJZVXU> b, Id32<KSHTGNRFKHE> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int WDMSIKTVLDB(a a, Id32<DINEWLJZVXU> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? APTYICNMDKX(a a, Id32<DINEWLJZVXU> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int XPNQVHFHXSF(a a, Id32<DINEWLJZVXU> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? WXMEEEGMVNL(a a, Id32<DINEWLJZVXU> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class GZXCTVEYYKW
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3917420", Offset = "0x3916220", VA = "0x183917420")]
		public static Id32<LocalVariables.M?> BUMJLPEMFDL<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x39177A0", Offset = "0x39165A0", VA = "0x1839177A0")]
		public static Id32<LocalVariables.M?> CWWBMVWODOQ<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3919420", Offset = "0x3918220", VA = "0x183919420")]
		public static Id32<LocalVariables.M?> REYNBGXWNHX<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8FE0", Offset = "0x2AF7DE0", VA = "0x182AF8FE0")]
		public static Id32<LocalVariables.M> XOLNWQOLNHB(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF51B0", Offset = "0x2AF3FB0", VA = "0x182AF51B0")]
		public static Id32<LocalVariables.M> FWEVAQUNHGU(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF85E0", Offset = "0x2AF73E0", VA = "0x182AF85E0")]
		public static Id32<LocalVariables.M> UJMDWVIIAEJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7480", Offset = "0x2AF6280", VA = "0x182AF7480")]
		public static Id32<LocalVariables.M> PYMSUAKQSWF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8A50", Offset = "0x2AF7850", VA = "0x182AF8A50")]
		public static Id32<LocalVariables.M> VOWRTCWRDQK(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5530", Offset = "0x2AF4330", VA = "0x182AF5530")]
		public static Id32<LocalVariables.M> GZXSBDPYWTV(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4420", Offset = "0x2AF3220", VA = "0x182AF4420")]
		public static Id32<LocalVariables.M> BFXOBZIBBLN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9400", Offset = "0x2AF8200", VA = "0x182AF9400")]
		public static Id32<LocalVariables.M> ZMMJBPNLNRC(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D80", Offset = "0x2AF7B80", VA = "0x182AF8D80")]
		public static Id32<LocalVariables.M> WQYHTOVPZBL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5FC0", Offset = "0x2AF4DC0", VA = "0x182AF5FC0")]
		public static Id32<LocalVariables.M> IPFNLPNGQUQ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6C30", Offset = "0x2AF5A30", VA = "0x182AF6C30")]
		public static Id32<LocalVariables.M> KIQSLZHWEPB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4C50", Offset = "0x2AF3A50", VA = "0x182AF4C50")]
		public static Id32<LocalVariables.M> DUHOMAZRRIO(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9160", Offset = "0x2AF7F60", VA = "0x182AF9160")]
		public static Id32<LocalVariables.M> YTKYMUCFWCJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9660", Offset = "0x2AF8460", VA = "0x182AF9660")]
		public static Id32<LocalVariables.M> ZWQSTDYIUGW(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7CE0", Offset = "0x2AF6AE0", VA = "0x182AF7CE0")]
		public static Id32<LocalVariables.M> RKVVTPJXANV(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4950", Offset = "0x2AF3750", VA = "0x182AF4950")]
		public static Id32<LocalVariables.M> DBZRZJJWLKB(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5130", Offset = "0x2AF3F30", VA = "0x182AF5130")]
		public static Id32<LocalVariables.M> FDUSUKYPQZU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7C60", Offset = "0x2AF6A60", VA = "0x182AF7C60")]
		public static Id32<LocalVariables.M> RIOZUMUOQTV(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7150", Offset = "0x2AF5F50", VA = "0x182AF7150")]
		public static Id32<LocalVariables.M> NEIJQCNPMCQ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6D50", Offset = "0x2AF5B50", VA = "0x182AF6D50")]
		public static Id32<LocalVariables.M> KOBOFBHLBMX(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6BB0", Offset = "0x2AF59B0", VA = "0x182AF6BB0")]
		public static Id32<LocalVariables.M> KHMFWPVMFXE(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF72F0", Offset = "0x2AF60F0", VA = "0x182AF72F0")]
		public static Id32<LocalVariables.M> PHFJZQVZGQC(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF43A0", Offset = "0x2AF31A0", VA = "0x182AF43A0")]
		public static Id32<LocalVariables.M> AXUBPBYCMAN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8160", Offset = "0x2AF6F60", VA = "0x182AF8160")]
		public static Id32<LocalVariables.M> SQSKALLOJDS(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF52D0", Offset = "0x2AF40D0", VA = "0x182AF52D0")]
		public static Id32<LocalVariables.M> GQXZYMFADPJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4BD0", Offset = "0x2AF39D0", VA = "0x182AF4BD0")]
		public static Id32<LocalVariables.M> DQVJTDNXQTW(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6590", Offset = "0x2AF5390", VA = "0x182AF6590")]
		public static Id32<LocalVariables.M> JOOHWZBMACR(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF49D0", Offset = "0x2AF37D0", VA = "0x182AF49D0")]
		public static Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> DKLGCPCJOXB(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5AA0", Offset = "0x2AF48A0", VA = "0x182AF5AA0")]
		public static Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> IHQQXMWQWUT(this FunctionCompileState a, int b)
		{
			return default(Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5490", Offset = "0x2AF4290", VA = "0x182AF5490")]
		public static Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> GWOYGRFSASU(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4650", Offset = "0x2AF3450", VA = "0x182AF4650")]
		public static Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> CKCJNAPVQPC(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF70D0", Offset = "0x2AF5ED0", VA = "0x182AF70D0")]
		public static Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> MZASPAMEXME(this FunctionCompileState a, int b)
		{
			return default(Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7580", Offset = "0x2AF6380", VA = "0x182AF7580")]
		public static Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> QBVJJLGXFFV(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6610", Offset = "0x2AF5410", VA = "0x182AF6610")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.XROXTIHADRI>) JQGXWGXWPYA(this FunctionCompileState a, Id32<YVHVHYLYUBD> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.XROXTIHADRI>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5B20", Offset = "0x2AF4920", VA = "0x182AF5B20")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.XROXTIHADRI>) ILBHZSBHZRY(this FunctionCompileState a, Id32<RFIESXCFEKH> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.XROXTIHADRI>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x39191D0", Offset = "0x3917FD0", VA = "0x1839191D0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<NLLDXUHMLOS>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<TMarker>>, Id32<FunctionCalls.M>) OVMJAFUFFCJ<TMarker>(this FunctionCompileState a, Id32<NLLDXUHMLOS> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<NLLDXUHMLOS>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7010", Offset = "0x2AF5E10", VA = "0x182AF7010")]
		public static Id32<LocalVariables.M> MLLZGKIKIQJ(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8B70", Offset = "0x2AF7970", VA = "0x182AF8B70")]
		public static Id32<LocalVariables.M> VXTAGCDHDYK(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8820", Offset = "0x2AF7620", VA = "0x182AF8820")]
		public static Id32<LocalVariables.M> VCQRXGUTTLV(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF60C0", Offset = "0x2AF4EC0", VA = "0x182AF60C0")]
		public static Id32<LocalVariables.M> IQHHZOWQODO(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7380", Offset = "0x2AF6180", VA = "0x182AF7380")]
		public static Id32<LocalVariables.M> PVOUTIIDEJV(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4ED0", Offset = "0x2AF3CD0", VA = "0x182AF4ED0")]
		public static Id32<LocalVariables.M> EPBVDONCKFO(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5350", Offset = "0x2AF4150", VA = "0x182AF5350")]
		public static Id32<LocalVariables.M> GVRVOGTTUEV(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8060", Offset = "0x2AF6E60", VA = "0x182AF8060")]
		public static Id32<LocalVariables.M> RTSDXXVNKBT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7B40", Offset = "0x2AF6940", VA = "0x182AF7B40")]
		public static Id32<LocalVariables.M> QXNWYCCOJMG(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4D90", Offset = "0x2AF3B90", VA = "0x182AF4D90")]
		public static Id32<LocalVariables.M> DYZYTIVMYOD(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8420", Offset = "0x2AF7220", VA = "0x182AF8420")]
		public static Id32<LocalVariables.M> TDPRCDLRLHI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF90E0", Offset = "0x2AF7EE0", VA = "0x182AF90E0")]
		public static Id32<LocalVariables.M> XVTZGGUJIND(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9260", Offset = "0x2AF8060", VA = "0x182AF9260")]
		public static Id32<LocalVariables.M> YUAIGSFBESY(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF59A0", Offset = "0x2AF47A0", VA = "0x182AF59A0")]
		public static Id32<LocalVariables.M> HWFNOBODNAM(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4520", Offset = "0x2AF3320", VA = "0x182AF4520")]
		public static Id32<LocalVariables.M> BZUIGSLJOLJ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7F20", Offset = "0x2AF6D20", VA = "0x182AF7F20")]
		public static Id32<LocalVariables.M> RRVOCHMMXUW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6AB0", Offset = "0x2AF58B0", VA = "0x182AF6AB0")]
		public static Id32<LocalVariables.M> KFQUNMKNCDX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8EC0", Offset = "0x2AF7CC0", VA = "0x182AF8EC0")]
		public static Id32<LocalVariables.M> XHIFJJVPYCO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4FF0", Offset = "0x2AF3DF0", VA = "0x182AF4FF0")]
		public static Id32<LocalVariables.M> EVUTBTCMCHJ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6DD0", Offset = "0x2AF5BD0", VA = "0x182AF6DD0")]
		public static Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>> LQRVVBKJHDP(this FunctionCompileState a)
		{
			return default(Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF42A0", Offset = "0x2AF30A0", VA = "0x182AF42A0")]
		public static Id32<LocalVariables.M> ANOJFHRDOYG(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8C60", Offset = "0x2AF7A60", VA = "0x182AF8C60")]
		public static Id32<LocalVariables.M> WLEAZHMRWYB(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6450", Offset = "0x2AF5250", VA = "0x182AF6450")]
		public static Id32<LocalVariables.M> JLEAVFQZPIA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7E20", Offset = "0x2AF6C20", VA = "0x182AF7E20")]
		public static Id32<LocalVariables.M> RMJASMAPHJW(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6DF0", Offset = "0x2AF5BF0", VA = "0x182AF6DF0")]
		public static Id32<LocalVariables.M> LSWDWMYDOWX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8910", Offset = "0x2AF7710", VA = "0x182AF8910")]
		public static Id32<LocalVariables.M> VHMAGZNIHMC(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8720", Offset = "0x2AF7520", VA = "0x182AF8720")]
		public static Id32<LocalVariables.M> UXKSYNCHZUH(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7620", Offset = "0x2AF6420", VA = "0x182AF7620")]
		public static Id32<LocalVariables.M> QJUSPLWBCYM(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7370", Offset = "0x2AF6170", VA = "0x182AF7370")]
		public static void PJAWMZVBYDX(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF81E0", Offset = "0x2AF6FE0", VA = "0x182AF81E0")]
		public static Id32<LocalVariables.M> SUHMKQGDIOW(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6330", Offset = "0x2AF5130", VA = "0x182AF6330")]
		public static Id32<LocalVariables.M> IXXDAFAWXPD(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF82E0", Offset = "0x2AF70E0", VA = "0x182AF82E0")]
		public static Id32<LocalVariables.M> TBQUSKRNHIU(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6F10", Offset = "0x2AF5D10", VA = "0x182AF6F10")]
		public static Id32<LocalVariables.M> LTZMOWMZHAU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF71D0", Offset = "0x2AF5FD0", VA = "0x182AF71D0")]
		public static Id32<LocalVariables.M> NNKRPGHOUVF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF84A0", Offset = "0x2AF72A0", VA = "0x182AF84A0")]
		public static Id32<LocalVariables.M> UHZFXRTGKWW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7730", Offset = "0x2AF6530", VA = "0x182AF7730")]
		public static Id32<LocalVariables.M> QVAVUXMQKFQ(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4850", Offset = "0x2AF3650", VA = "0x182AF4850")]
		public static Id32<LocalVariables.M> CWDKDAPWEIL(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AF92E0", Offset = "0x2AF80E0", VA = "0x182AF92E0")]
		public static Id32<LocalVariables.M> YYFRTZWBKRC(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9520", Offset = "0x2AF8320", VA = "0x182AF9520")]
		public static Id32<LocalVariables.M> ZUIYAZIEMCB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x391A7D0", Offset = "0x39195D0", VA = "0x18391A7D0")]
		public static void YDOWFWHZLIU<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<YVHVHYLYUBD> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, XZBYKVFOQNN<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x39179D0", Offset = "0x39167D0", VA = "0x1839179D0")]
		public static void ETFHMCVHJWK<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<RFIESXCFEKH> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, XZBYKVFOQNN<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3919FB0", Offset = "0x3918DB0", VA = "0x183919FB0")]
		public static Id32<LocalVariables.M> WOZGXSXRIUY<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, XZBYKVFOQNN<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x391A2C0", Offset = "0x39190C0", VA = "0x18391A2C0")]
		public static Id32<LocalVariables.M> XDCPGVZQDDP<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, XZBYKVFOQNN<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3919CA0", Offset = "0x3918AA0", VA = "0x183919CA0")]
		public static Id32<DataBackResults.M> WIBSFBJPMMG<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, XZBYKVFOQNN<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3919550", Offset = "0x3918350", VA = "0x183919550")]
		public static Id32<ExecForwardResults.M> TAGIJGVVZNP<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, XZBYKVFOQNN<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2AF61E0", Offset = "0x2AF4FE0", VA = "0x182AF61E0")]
		public static Id32<DataBackResults.M> IXTMPESFLUL(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5670", Offset = "0x2AF4470", VA = "0x182AF5670")]
		public static Id32<DataBackResults.M> HGXNUITGNWN(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3918730", Offset = "0x3917530", VA = "0x183918730")]
		public static Id32<DataBackResults.M> JPOOFJPIQKI<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<YVHVHYLYUBD> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, XZBYKVFOQNN<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x39184C0", Offset = "0x39172C0", VA = "0x1839184C0")]
		private static Id32<DataBackResults.M> JPOOFJPIQKI<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<YVHVHYLYUBD> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, XZBYKVFOQNN<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3919850", Offset = "0x3918650", VA = "0x183919850")]
		public static Id32<LocalVariables.M> USWCQQKNMXW<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, XZBYKVFOQNN<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3918160", Offset = "0x3916F60", VA = "0x183918160")]
		public static void FQLJHNZMCIN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, XZBYKVFOQNN<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<DXZFAYBWXNM<JPROXOTIKYR>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<DXZFAYBWXNM<JPROXOTIKYR>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
		public LiveInterval(Id32<DXZFAYBWXNM<JPROXOTIKYR>> firstUse, Id32<DXZFAYBWXNM<JPROXOTIKYR>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA7F0", Offset = "0x2AF95F0", VA = "0x182AFA7F0")]
		public static LiveInterval New(Id32<DXZFAYBWXNM<JPROXOTIKYR>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class BGMAIPBAQTL : GLVUCTICSAC
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
			[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class GUTZGLPRXLF : GLVUCTICSAC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class EWVWRFPUOUE : GLVUCTICSAC
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
			[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
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
		public abstract class GLVUCTICSAC
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
			public Id32<GLVUCTICSAC> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9A60", Offset = "0x2AF8860", VA = "0x182AF9A60")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<GLVUCTICSAC> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class SRLBDNSIBGJ : GLVUCTICSAC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<BGMAIPBAQTL, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<EWVWRFPUOUE, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<SRLBDNSIBGJ, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<GUTZGLPRXLF, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA9F0", Offset = "0x2AF97F0", VA = "0x182AFA9F0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<BGMAIPBAQTL, ArgumentInst> argumentVariables, [In] SOAId32Field<EWVWRFPUOUE, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<SRLBDNSIBGJ, ParameterInst> parameterVariables, [In] SOAId32Field<GUTZGLPRXLF, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA800", Offset = "0x2AF9600", VA = "0x182AFA800")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class IVTHJPKKRBQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9870", Offset = "0x2AF8670", VA = "0x182AF9870")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class EVZNUXMHPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3030", Offset = "0x2AF1E30", VA = "0x182AF3030")]
		public static void SMBNSVPWLRK(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.XROXTIHADRI, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2D00", Offset = "0x2AF1B00", VA = "0x182AF2D00")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.XROXTIHADRI, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2C90", Offset = "0x2AF1A90", VA = "0x182AF2C90")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2A70", Offset = "0x2AF1870", VA = "0x182AF2A70")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x355B060", Offset = "0x3559E60", VA = "0x18355B060")]
		public static void SMBNSVPWLRK<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<DINEWLJZVXU> graphId) where TDeps : notnull, XZBYKVFOQNN<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class VXEMXTANDJB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD8F0", Offset = "0x2AFC6F0", VA = "0x182AFD8F0")]
		public static void SMBNSVPWLRK(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface TPJLYPSOIOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void CVJNCXLLHVJ(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : TPJLYPSOIOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2AFACE0", Offset = "0x2AF9AE0", VA = "0x182AFACE0", Slot = "4")]
			public void CVJNCXLLHVJ(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : TPJLYPSOIOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAD70", Offset = "0x2AF9B70", VA = "0x182AFAD70", Slot = "4")]
			public void CVJNCXLLHVJ(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : TPJLYPSOIOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2AFABA0", Offset = "0x2AF99A0", VA = "0x182AFABA0", Slot = "4")]
			public void CVJNCXLLHVJ(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : TPJLYPSOIOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAC30", Offset = "0x2AF9A30", VA = "0x182AFAC30", Slot = "4")]
			public void CVJNCXLLHVJ(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class ORDXJHEGIXI<c> where c : struct, TPJLYPSOIOY
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c JGLYIVPXDNI;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3AF2F20", Offset = "0x3AF1D20", VA = "0x183AF2F20")]
			public static int SMBNSVPWLRK<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : XZBYKVFOQNN<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<FunctionCalls.XROXTIHADRI>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9A10", Offset = "0x2AF8810", VA = "0x182AF9A10")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<FunctionCalls.XROXTIHADRI>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9960", Offset = "0x2AF8760", VA = "0x182AF9960")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9920", Offset = "0x2AF8720", VA = "0x182AF9920")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x39AB4A0", Offset = "0x39AA2A0", VA = "0x1839AB4A0")]
		public static void SMBNSVPWLRK<b, a>(FunctionCompileState a, b b, a c) where b : XZBYKVFOQNN<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class LCYZRVRLKGM
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
		private static int EKQWNZFQCPE;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int QFABGZZLMQI;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA0E0", Offset = "0x2AF8EE0", VA = "0x182AFA0E0")]
		public static void SMBNSVPWLRK(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9ED0", Offset = "0x2AF8CD0", VA = "0x182AF9ED0")]
		private static void CMXEOQAZBSJ([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9D90", Offset = "0x2AF8B90", VA = "0x182AF9D90")]
		private static void CMXEOQAZBSJ(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA640", Offset = "0x2AF9440", VA = "0x182AFA640")]
		private static void UXUOJORDJCK(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class BNLXMWGSZEU<a, b, c> where a : struct, OWINMMJJZPY<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a JGLYIVPXDNI;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x70F3CE0", Offset = "0x70F2AE0", VA = "0x1870F3CE0")]
		public static void SMBNSVPWLRK([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface OWINMMJJZPY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> CSBKNNACGAA(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DVDXHBLEZRS(a a, b b, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface GEBPMYXZGRR<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a TXCYXFDQLCX(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool LOZMZEPHJWV(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<DXZFAYBWXNM<NLAXFVYHLZG>> SWSKVAZOYUU(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class IGUOZFBDIVH<a, b, c> where a : struct, GEBPMYXZGRR<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a JGLYIVPXDNI;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x52D7F20", Offset = "0x52D6D20", VA = "0x1852D7F20")]
		public static UnsafeList<b> SMBNSVPWLRK(int a, [In] c values)
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
