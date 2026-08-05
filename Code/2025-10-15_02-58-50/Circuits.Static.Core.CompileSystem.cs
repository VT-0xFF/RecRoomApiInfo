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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B262F0", Offset = "0x2B250F0", VA = "0x182B262F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
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
		public readonly Id32<PWFCKDZBCDU<CJHMTIIQUWA>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
		public ByteCodeAdjustment(Id32<PWFCKDZBCDU<CJHMTIIQUWA>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class BTWHLUYAIDE : VXJZPZAXIFY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2AC58F0", Offset = "0x2AC46F0", VA = "0x182AC58F0")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B24600", Offset = "0x2B23400", VA = "0x182B24600", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class IIJKLQRMDBD : VXJZPZAXIFY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<PWFCKDZBCDU<XVONRNCPECF>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
			public DeadEnd(Id32<PWFCKDZBCDU<XVONRNCPECF>> nextByteCodePtr)
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
		public abstract class VXJZPZAXIFY
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
			public readonly Id32<VXJZPZAXIFY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
			public Inst(Def def, Id32<VXJZPZAXIFY> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class ETZRCRENALM : VXJZPZAXIFY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class EKVKOPRQVNW : VXJZPZAXIFY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x255E180", Offset = "0x255CF80", VA = "0x18255E180", Slot = "3")]
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
		internal IdUnsafeList<BTWHLUYAIDE, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<IIJKLQRMDBD, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<ETZRCRENALM, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<EKVKOPRQVNW, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B247B0", Offset = "0x2B235B0", VA = "0x182B247B0")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<BTWHLUYAIDE, BytesImmediate> bytesImmediates, [In] IdUnsafeList<IIJKLQRMDBD, DeadEnd> deadEnds, [In] IdUnsafeList<ETZRCRENALM, Variable> variables, [In] IdUnsafeList<EKVKOPRQVNW, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B24670", Offset = "0x2B23470", VA = "0x182B24670")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class RLKHGKPRMRX
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BAE0", Offset = "0x2B2A8E0", VA = "0x182B2BAE0")]
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
		public sealed class URGMDVZMOAB : VXJZPZAXIFY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
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
		public abstract class VXJZPZAXIFY
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
			public readonly Id32<VXJZPZAXIFY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
			public Inst(Def def, Id32<VXJZPZAXIFY> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<URGMDVZMOAB, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B248D0", Offset = "0x2B236D0", VA = "0x182B248D0")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<URGMDVZMOAB, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B24840", Offset = "0x2B23640", VA = "0x182B24840")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class SBOJFPQWCSG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BB90", Offset = "0x2B2A990", VA = "0x182B2BB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B249B0", Offset = "0x2B237B0", VA = "0x182B249B0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B24910", Offset = "0x2B23710", VA = "0x182B24910")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class WCDRFFPGZVT
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F330", Offset = "0x2B2E130", VA = "0x182B2F330")]
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
		public sealed class DNCFTQVOOIB : VXJZPZAXIFY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<LNTDOTXDLWG> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
			public ExternalCall(Id32<LNTDOTXDLWG> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class VXJZPZAXIFY
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
			public readonly Id32<VXJZPZAXIFY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
			private Inst(Def def, Id32<VXJZPZAXIFY> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B25B60", Offset = "0x2B24960", VA = "0x182B25B60")]
			public static Inst New(Def def, Id32<VXJZPZAXIFY> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class JEUAPIKWCTF : VXJZPZAXIFY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<LNTDOTXDLWG> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
			public InternalCall(Id32<LNTDOTXDLWG> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class LNTDOTXDLWG
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
			[Cpp2IlInjected.Address(RVA = "0x2B248D0", Offset = "0x2B236D0", VA = "0x182B248D0")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B259B0", Offset = "0x2B247B0", VA = "0x182B259B0")]
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
		internal IdUnsafeList<JEUAPIKWCTF, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<DNCFTQVOOIB, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<LNTDOTXDLWG> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<LNTDOTXDLWG, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B24BB0", Offset = "0x2B239B0", VA = "0x182B24BB0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<JEUAPIKWCTF, InternalCall> internalCalls, [In] IdUnsafeList<DNCFTQVOOIB, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<LNTDOTXDLWG> IOId)> callsWithIO, [In] IdUnsafeList<LNTDOTXDLWG, IO> io, [In] SOAField<LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> ioModifyingCallLocations, [In] SOAField<LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B24A10", Offset = "0x2B23810", VA = "0x182B24A10")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class KYSUSHMSSVF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B25DA0", Offset = "0x2B24BA0", VA = "0x182B25DA0")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B25B90", Offset = "0x2B24990", VA = "0x182B25B90")]
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
		internal SOAField<GXAJUPUXNOX, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<GXAJUPUXNOX>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B25600", Offset = "0x2B24400", VA = "0x182B25600")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<GXAJUPUXNOX, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<GXAJUPUXNOX>> generatedOutputsForExpression, [In] SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B24C70", Offset = "0x2B23A70", VA = "0x182B24C70")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class UISRXANSTVC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : QWEOVWWUXEP<Id32<FunctionCalls.LNTDOTXDLWG>, SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BC30", Offset = "0x2B2AA30", VA = "0x182B2BC30")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BBF0", Offset = "0x2B2A9F0", VA = "0x182B2BBF0", Slot = "4")]
			public Id32<FunctionCalls.LNTDOTXDLWG> QMASQXSUEWT(int a)
			{
				return default(Id32<FunctionCalls.LNTDOTXDLWG>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990")]
			public bool AAKKKCXKMAF(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "5")]
			private bool MNDIVMLNQMF(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BCB0", Offset = "0x2B2AAB0", VA = "0x182B2BCB0", Slot = "6")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> VOCYWJXQJUY(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : IPYMYHNQVWS<Id32<FunctionCalls.LNTDOTXDLWG>, SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B23830", Offset = "0x2B22630", VA = "0x182B23830")]
			public UnsafeList<Id32<FunctionCalls.LNTDOTXDLWG>> QQDFHINEHOI(int a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.LNTDOTXDLWG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B238A0", Offset = "0x2B226A0", VA = "0x182B238A0")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B23790", Offset = "0x2B22590", VA = "0x182B23790", Slot = "6")]
			public void NTPHVBTMKDS(Id32<FunctionCalls.LNTDOTXDLWG> a, SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> b, Id32<PWFCKDZBCDU<CJHMTIIQUWA>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B23830", Offset = "0x2B22630", VA = "0x182B23830", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.LNTDOTXDLWG>> PGUOWBQDISP(int a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.LNTDOTXDLWG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B23920", Offset = "0x2B22720", VA = "0x182B23920", Slot = "5")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> YASSSQNUJTT(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<XVONRNCPECF>>> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : QWEOVWWUXEP<Id32<FunctionCalls.LNTDOTXDLWG>, SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BD10", Offset = "0x2B2AB10", VA = "0x182B2BD10")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BCD0", Offset = "0x2B2AAD0", VA = "0x182B2BCD0", Slot = "4")]
			public Id32<FunctionCalls.LNTDOTXDLWG> QMASQXSUEWT(int a)
			{
				return default(Id32<FunctionCalls.LNTDOTXDLWG>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990")]
			public bool AAKKKCXKMAF(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "5")]
			private bool SSLEKETOZLI(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BCC0", Offset = "0x2B2AAC0", VA = "0x182B2BCC0", Slot = "6")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> NEFQYONWHYP(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : IPYMYHNQVWS<Id32<FunctionCalls.LNTDOTXDLWG>, SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B239D0", Offset = "0x2B227D0", VA = "0x182B239D0")]
			public UnsafeList<Id32<FunctionCalls.LNTDOTXDLWG>> QQDFHINEHOI(int a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.LNTDOTXDLWG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B23A50", Offset = "0x2B22850", VA = "0x182B23A50")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B23930", Offset = "0x2B22730", VA = "0x182B23930", Slot = "6")]
			public void NTPHVBTMKDS(Id32<FunctionCalls.LNTDOTXDLWG> a, SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> b, Id32<PWFCKDZBCDU<CJHMTIIQUWA>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B239D0", Offset = "0x2B227D0", VA = "0x182B239D0", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.LNTDOTXDLWG>> RCUJEFFMETK(int a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.LNTDOTXDLWG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B23A40", Offset = "0x2B22840", VA = "0x182B23A40", Slot = "5")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> RFGDZVYGTUI(Id32<FunctionCalls.LNTDOTXDLWG> a, [In] SOAField<FunctionCalls.LNTDOTXDLWG, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : QWEOVWWUXEP<Id32<WFLMXHQDTIG>, SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BE40", Offset = "0x2B2AC40", VA = "0x182B2BE40")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(Id32<WFLMXHQDTIG> a, [In] SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BE00", Offset = "0x2B2AC00", VA = "0x182B2BE00", Slot = "4")]
			public Id32<WFLMXHQDTIG> QMASQXSUEWT(int a)
			{
				return default(Id32<WFLMXHQDTIG>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BD90", Offset = "0x2B2AB90", VA = "0x182B2BD90")]
			public bool AAKKKCXKMAF(Id32<WFLMXHQDTIG> a, [In] SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BD90", Offset = "0x2B2AB90", VA = "0x182B2BD90", Slot = "5")]
			private bool XVTPAXJHACM(Id32<WFLMXHQDTIG> a, [In] SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BDF0", Offset = "0x2B2ABF0", VA = "0x182B2BDF0", Slot = "6")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> IVBLCDSPQTL(Id32<WFLMXHQDTIG> a, [In] SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : IPYMYHNQVWS<Id32<WFLMXHQDTIG>, SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2B23AE0", Offset = "0x2B228E0", VA = "0x182B23AE0")]
			public UnsafeList<Id32<WFLMXHQDTIG>> QQDFHINEHOI(int a, [In] SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> values)
			{
				return default(UnsafeList<Id32<WFLMXHQDTIG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B23C50", Offset = "0x2B22A50", VA = "0x182B23C50")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(Id32<WFLMXHQDTIG> a, [In] SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B23B50", Offset = "0x2B22950", VA = "0x182B23B50", Slot = "6")]
			public void NTPHVBTMKDS(Id32<WFLMXHQDTIG> a, SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> b, Id32<PWFCKDZBCDU<CJHMTIIQUWA>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B23AE0", Offset = "0x2B228E0", VA = "0x182B23AE0", Slot = "4")]
			private UnsafeList<Id32<WFLMXHQDTIG>> NREDZOJEDDM(int a, [In] SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> values)
			{
				return default(UnsafeList<Id32<WFLMXHQDTIG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B23AD0", Offset = "0x2B228D0", VA = "0x182B23AD0", Slot = "5")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> BZJOTDCJWQC(Id32<WFLMXHQDTIG> a, [In] SOAField<WFLMXHQDTIG, Id32<PWFCKDZBCDU<XVONRNCPECF>>?> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : QWEOVWWUXEP<int, UnsafeList<(Id32<LocalVariables.M>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2B2C040", Offset = "0x2B2AE40", VA = "0x182B2C040")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xC34580", Offset = "0xC33380", VA = "0x180C34580", Slot = "4")]
			public int QMASQXSUEWT(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990")]
			public bool AAKKKCXKMAF(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "5")]
			private bool LQHVOFSGSDD(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B2C030", Offset = "0x2B2AE30", VA = "0x182B2C030", Slot = "6")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> NPGGYUMGVBC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : IPYMYHNQVWS<int, UnsafeList<(Id32<LocalVariables.M>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B24120", Offset = "0x2B22F20", VA = "0x182B24120")]
			public UnsafeList<int> QQDFHINEHOI(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B242A0", Offset = "0x2B230A0", VA = "0x182B242A0")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B24190", Offset = "0x2B22F90", VA = "0x182B24190", Slot = "6")]
			public void NTPHVBTMKDS(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> values, Id32<PWFCKDZBCDU<CJHMTIIQUWA>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B24120", Offset = "0x2B22F20", VA = "0x182B24120", Slot = "4")]
			private UnsafeList<int> HIPSWUOUADH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B24290", Offset = "0x2B23090", VA = "0x182B24290", Slot = "5")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> RDLYWNEEIMP(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<PWFCKDZBCDU<MTKWVKXUIVO<CJHMTIIQUWA>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : QWEOVWWUXEP<int, UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BF90", Offset = "0x2B2AD90", VA = "0x182B2BF90")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xC34580", Offset = "0xC33380", VA = "0x180C34580", Slot = "4")]
			public int QMASQXSUEWT(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990")]
			public bool AAKKKCXKMAF(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "5")]
			private bool PMEUJZSBFYA(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B2C020", Offset = "0x2B2AE20", VA = "0x182B2C020", Slot = "6")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> YDYVIGUTLJP(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : IPYMYHNQVWS<int, UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2B24020", Offset = "0x2B22E20", VA = "0x182B24020")]
			public UnsafeList<int> QQDFHINEHOI(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B24090", Offset = "0x2B22E90", VA = "0x182B24090")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B23F20", Offset = "0x2B22D20", VA = "0x182B23F20", Slot = "6")]
			public void NTPHVBTMKDS(int a, UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values, Id32<PWFCKDZBCDU<CJHMTIIQUWA>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B24020", Offset = "0x2B22E20", VA = "0x182B24020", Slot = "4")]
			private UnsafeList<int> WJCZQUBNUMA(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B23F10", Offset = "0x2B22D10", VA = "0x182B23F10", Slot = "5")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> KUKZVMBDQXW(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : QWEOVWWUXEP<int, UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BEF0", Offset = "0x2B2ACF0", VA = "0x182B2BEF0")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC34580", Offset = "0xC33380", VA = "0x180C34580", Slot = "4")]
			public int QMASQXSUEWT(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990")]
			public bool AAKKKCXKMAF(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "5")]
			private bool PMEUJZSBFYA(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BF80", Offset = "0x2B2AD80", VA = "0x182B2BF80", Slot = "6")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> YDYVIGUTLJP(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : IPYMYHNQVWS<int, UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2B23E10", Offset = "0x2B22C10", VA = "0x182B23E10")]
			public UnsafeList<int> QQDFHINEHOI(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B23E80", Offset = "0x2B22C80", VA = "0x182B23E80")]
			public Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B23D10", Offset = "0x2B22B10", VA = "0x182B23D10", Slot = "6")]
			public void NTPHVBTMKDS(int a, UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values, Id32<PWFCKDZBCDU<CJHMTIIQUWA>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B23E10", Offset = "0x2B22C10", VA = "0x182B23E10", Slot = "4")]
			private UnsafeList<int> WJCZQUBNUMA(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B23D00", Offset = "0x2B22B00", VA = "0x182B23D00", Slot = "5")]
			private Id32<PWFCKDZBCDU<CJHMTIIQUWA>> KUKZVMBDQXW(int a, [In] UnsafeList<(Id32<PWFCKDZBCDU<XVONRNCPECF>> Target, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
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
			[Cpp2IlInjected.Address(RVA = "0x21F4120", Offset = "0x21F2F20", VA = "0x1821F4120")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B259A0", Offset = "0x2B247A0", VA = "0x182B259A0")]
			public void ZCUPQIFTYKF([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<WFLMXHQDTIG> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B25980", Offset = "0x2B24780", VA = "0x182B25980")]
			public GenerateDataBackFromInputIndexResult(Id32<WFLMXHQDTIG> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B25950", Offset = "0x2B24750", VA = "0x182B25950")]
			public void ZCUPQIFTYKF([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B25960", Offset = "0x2B24760", VA = "0x182B25960")]
			public void ZCUPQIFTYKF([Out] Id32<DataBackResults.M> a, [Out] Id32<WFLMXHQDTIG> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<WFLMXHQDTIG> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
			public GenerateDataBackFromInputIndicesResult(Id32<WFLMXHQDTIG> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B25990", Offset = "0x2B24790", VA = "0x182B25990")]
			public void ZCUPQIFTYKF([Out] Id32<DataBackResults.M> a, [Out] Id32<WFLMXHQDTIG> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C9A0", Offset = "0x2B2B7A0", VA = "0x182B2C9A0")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CEA0", Offset = "0x2B2BCA0", VA = "0x182B2CEA0")]
		public static void FVXUMHYYPGG(this FunctionCompileState a, Id32<GXAJUPUXNOX> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D790", Offset = "0x2B2C590", VA = "0x182B2D790")]
		public static void NKKOJMHJVRC(this FunctionCompileState a, Id32<GXAJUPUXNOX> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C2C0", Offset = "0x2B2B0C0", VA = "0x182B2C2C0")]
		public static Id32<DataBackResults.M>? ATPRERFXUJL([In] this FunctionCompileState self, Id32<GXAJUPUXNOX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DAE0", Offset = "0x2B2C8E0", VA = "0x182B2DAE0")]
		public static Id32<PWFCKDZBCDU<XVONRNCPECF>> QSGOCIAGMCR([In] this FunctionCompileState self)
		{
			return default(Id32<PWFCKDZBCDU<XVONRNCPECF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DBB0", Offset = "0x2B2C9B0", VA = "0x182B2DBB0")]
		private static void QVUINENXMAW(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D120", Offset = "0x2B2BF20", VA = "0x182B2D120")]
		private static Id32<PWFCKDZBCDU<XVONRNCPECF>>? JVEBTIMGTRT([In] this FunctionCompileState self, Id32<WFLMXHQDTIG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E600", Offset = "0x2B2D400", VA = "0x182B2E600")]
		public static void ZWWFJWHKRBL(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D9C0", Offset = "0x2B2C7C0", VA = "0x182B2D9C0")]
		public static DataBackResults.Def PSJHTVSQAXH([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E200", Offset = "0x2B2D000", VA = "0x182B2E200")]
		public static ReadOnlyArray<byte> VNARQXIKJXT([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D2A0", Offset = "0x2B2C0A0", VA = "0x182B2D2A0")]
		public static Id32<LocalVariables.M> KYDPBJBNBJJ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E0E0", Offset = "0x2B2CEE0", VA = "0x182B2E0E0")]
		public static Union32 TIBLTFTFABZ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E490F0", Offset = "0x3E47EF0", VA = "0x183E490F0")]
		private static Id32<DataBackResults.M> KWWMLSPXEVW<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.VXJZPZAXIFY
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D220", Offset = "0x2B2C020", VA = "0x182B2D220")]
		public static Id32<DataBackResults.M> KQGKYBXGIGS(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C5C0", Offset = "0x2B2B3C0", VA = "0x182B2C5C0")]
		public static Id32<DataBackResults.M> CEBKRYCOKND(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CC70", Offset = "0x2B2BA70", VA = "0x182B2CC70")]
		public static Id32<DataBackResults.M> FBBDEOHYCOI(this FunctionCompileState a, Id32<PWFCKDZBCDU<XVONRNCPECF>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DEB0", Offset = "0x2B2CCB0", VA = "0x182B2DEB0")]
		public static Id32<DataBackResults.M> RRFFMHQCKXY(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D1A0", Offset = "0x2B2BFA0", VA = "0x182B2D1A0")]
		public static Id32<DataBackResults.M> KKFRQJHISMF(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A1D0", Offset = "0x3E48FD0", VA = "0x183E4A1D0")]
		private static Id32<ExecForwardResults.M> WUJBMIKIKRZ<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.VXJZPZAXIFY
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C210", Offset = "0x2B2B010", VA = "0x182B2C210")]
		public static Id32<ExecForwardResults.M> ANHCIMDIKRD(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D970", Offset = "0x2B2C770", VA = "0x182B2D970")]
		public static Id32<ExecForwardResults.M> POQYMNSLLKC(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C7D0", Offset = "0x2B2B5D0", VA = "0x182B2C7D0")]
		public static Id32<ExecForwardResults.M> CEPYFYKLMFA(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E030", Offset = "0x2B2CE30", VA = "0x182B2E030")]
		public static Id32<ExecForwardResults.M> SAWUWQQQCDZ(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DD50", Offset = "0x2B2CB50", VA = "0x182B2DD50")]
		public static Id32<ExecForwardResults.M> QWRVHIWISLZ(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C250", Offset = "0x2B2B050", VA = "0x182B2C250")]
		public static FunctionCalls.Def AOCKUEQKWGA([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E1C0", Offset = "0x2B2CFC0", VA = "0x182B2E1C0")]
		public static CopyEnumerable<Id32<FunctionCalls.LNTDOTXDLWG>, Id32Enumerator<FunctionCalls.LNTDOTXDLWG>> UINZSNNUWJL([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.LNTDOTXDLWG>, Id32Enumerator<FunctionCalls.LNTDOTXDLWG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D380", Offset = "0x2B2C180", VA = "0x182B2D380")]
		public static Id32<FunctionCalls.LNTDOTXDLWG> LACRWYHRGVK([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.LNTDOTXDLWG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C930", Offset = "0x2B2B730", VA = "0x182B2C930")]
		public static FunctionCalls.IO DHXDXIWDIHL([In] this FunctionCompileState self, Id32<FunctionCalls.LNTDOTXDLWG> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DB40", Offset = "0x2B2C940", VA = "0x182B2DB40")]
		public static FunctionCalls.IO QTFQHTTYQBD(this FunctionCompileState a, Id32<FunctionCalls.LNTDOTXDLWG> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E49060", Offset = "0x3E47E60", VA = "0x183E49060")]
		private static Id32<FunctionCalls.M> JIRHSLNTPIG<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.VXJZPZAXIFY
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CCF0", Offset = "0x2B2BAF0", VA = "0x182B2CCF0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.LNTDOTXDLWG>) FLSISBGXAXF(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.LNTDOTXDLWG>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E2E0", Offset = "0x2B2D0E0", VA = "0x182B2E2E0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.LNTDOTXDLWG>) WAPNSTNXWIR(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.LNTDOTXDLWG>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C340", Offset = "0x2B2B140", VA = "0x182B2C340")]
		public static Id32<FunctionCalls.M> BOAUZHHPNGC(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D090", Offset = "0x2B2BE90", VA = "0x182B2D090")]
		public static void JRJHISUUEUP(this FunctionCompileState a, Id32<FunctionCalls.LNTDOTXDLWG> b, Id32<PWFCKDZBCDU<XVONRNCPECF>> c, Id32<PWFCKDZBCDU<GSPYYKIKJJK>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E47810", Offset = "0x3E46610", VA = "0x183E47810")]
		public static GenerateDataBackResult EDNFMYSHNUH<d, e>(this FunctionCompileState a, d b, e c, Id32<TROAQNNIZMC> d, Id32<WFLMXHQDTIG> e) where d : YTUDMBCVPQT<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3E48C10", Offset = "0x3E47A10", VA = "0x183E48C10")]
		public static GenerateDataBackFromInputIndexResult IOMCJZXKVAH<f, g>(this FunctionCompileState a, f b, g c, Id32<TROAQNNIZMC> d, Id32<LQPAJNJDNAW> e, int f) where f : YTUDMBCVPQT<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3E49290", Offset = "0x3E48090", VA = "0x183E49290")]
		public static Id32<DataBackResults.M>? QMKHJDQYJWC<h, i>(this FunctionCompileState a, h b, i c, Id32<TROAQNNIZMC> d, Id32<LQPAJNJDNAW> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : YTUDMBCVPQT<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E499B0", Offset = "0x3E487B0", VA = "0x183E499B0")]
		public static Id32<ExecForwardResults.M> VXBBLBTZZIC<j, k>(this FunctionCompileState a, j b, k c, Id32<TROAQNNIZMC> d, Id32<GXAJUPUXNOX> e) where j : YTUDMBCVPQT<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E4F0", Offset = "0x2B2D2F0", VA = "0x182B2E4F0")]
		public static LocalVariables.ArgumentInst WQUNQTJLBAS([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C390", Offset = "0x2B2B190", VA = "0x182B2C390")]
		public static LocalVariables.CalleeReturnValueInst BWYDFSIRCPI([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D860", Offset = "0x2B2C660", VA = "0x182B2D860")]
		public static LocalVariables.CallerReturnValueInst PAREVSSQAIB([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D5E0", Offset = "0x2B2C3E0", VA = "0x182B2D5E0")]
		public static Id32<LocalVariables.M> MUCWYBOOJHN(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CF30", Offset = "0x2B2BD30", VA = "0x182B2CF30")]
		public static LocalVariables.ParameterInst GHCOJHXDCUM([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DFE0", Offset = "0x2B2CDE0", VA = "0x182B2DFE0")]
		public static LocalVariables.Def SAULRGUZGUA([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D040", Offset = "0x2B2BE40", VA = "0x182B2D040")]
		public static int? HGTWWETPFWK([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3E49190", Offset = "0x3E47F90", VA = "0x183E49190")]
		private static Id32<LocalVariables.M> MJVZWQLVRCS<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.VXJZPZAXIFY
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DF30", Offset = "0x2B2CD30", VA = "0x182B2DF30")]
		public static Id32<LocalVariables.M> RRJLDKIFZKE(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E080", Offset = "0x2B2CE80", VA = "0x182B2E080")]
		public static Id32<LocalVariables.M> SSAOGBTMVVF(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C650", Offset = "0x2B2B450", VA = "0x182B2C650")]
		public static Id32<LocalVariables.M> CEKYBEQQJWN(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C180", Offset = "0x2B2AF80", VA = "0x182B2C180")]
		public static Id32<LocalVariables.M> ABWMCLDRTFD(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E490", Offset = "0x2B2D290", VA = "0x182B2E490")]
		public static Id32<LocalVariables.M> WHNPFCPZDSV(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C4A0", Offset = "0x2B2B2A0", VA = "0x182B2C4A0")]
		public static void CCJVUBVGJFI(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DDA0", Offset = "0x2B2CBA0", VA = "0x182B2DDA0")]
		public static void RCHDEROJTQS(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DA30", Offset = "0x2B2C830", VA = "0x182B2DA30")]
		public static void PXAKWJVRPHI(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D550", Offset = "0x2B2C350", VA = "0x182B2D550")]
		public static void LNCKCCCRXEV(this FunctionCompileState a, Id32<PWFCKDZBCDU<XVONRNCPECF>> b, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C850", Offset = "0x2B2B650", VA = "0x182B2C850")]
		public static void CEUYDJVPKYR(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<PWFCKDZBCDU<BSPEMJYUXAE>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3E498D0", Offset = "0x3E486D0", VA = "0x183E498D0")]
		public static void SPZCAAECDSC<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<PWFCKDZBCDU<MTKWVKXUIVO<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface YTUDMBCVPQT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<VHIMMWYWAFQ> UHYRMYAQWOY(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<VHIMMWYWAFQ> PJVYSADGLLT(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<VHIMMWYWAFQ> ZIDIUMBYQRQ(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<VHIMMWYWAFQ> HDUIGGMNQVX(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> YRRYHGPIVWH(a a, FunctionCompileState b, Id32<TROAQNNIZMC> c, Id32<WFLMXHQDTIG> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> MCUBPAISFMB(a a, FunctionCompileState b, Id32<TROAQNNIZMC> c, Id32<GXAJUPUXNOX> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int NZTEMXFFTLL(a a, Id32<TROAQNNIZMC> b, Id32<WFLMXHQDTIG> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<GXAJUPUXNOX> NWMLXQGPOOW(a a, Id32<TROAQNNIZMC> b, Id32<WFLMXHQDTIG> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind FQENOCUFGST(a a, Id32<TROAQNNIZMC> b, Id32<WFLMXHQDTIG> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool CYMTSMBTAWU(a a, Id32<TROAQNNIZMC> b, Id32<WFLMXHQDTIG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int PPOKQMURVKB(a a, Id32<TROAQNNIZMC> b, Id32<WFLMXHQDTIG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> DDAMMGLWFPZ(a a, Id32<TROAQNNIZMC> b, Id32<WFLMXHQDTIG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<VHIMMWYWAFQ>) NIMGVHDSTUR(a a, Id32<TROAQNNIZMC> b, Id32<WFLMXHQDTIG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int RBTUPMTSYAL(a a, Id32<TROAQNNIZMC> b, Id32<GXAJUPUXNOX> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<WFLMXHQDTIG> LPYGRBSFIXU(a a, Id32<TROAQNNIZMC> b, Id32<GXAJUPUXNOX> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<WFLMXHQDTIG> QOAPIHRSQTB(a a, Id32<TROAQNNIZMC> b, Id32<LQPAJNJDNAW> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int OUEATPTFDTZ(a a, Id32<TROAQNNIZMC> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? CCCTQFINNBZ(a a, Id32<TROAQNNIZMC> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int WQHARGZKNKN(a a, Id32<TROAQNNIZMC> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? ZPAFTXIJKQJ(a a, Id32<TROAQNNIZMC> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class PZIMTNDIQGW
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B130", Offset = "0x3B29F30", VA = "0x183B2B130")]
		public static Id32<LocalVariables.M?> CDVHZKLPSYV<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B2A5C0", Offset = "0x3B293C0", VA = "0x183B2A5C0")]
		public static Id32<LocalVariables.M?> ATIAPIELVCQ<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D480", Offset = "0x3B2C280", VA = "0x183B2D480")]
		public static Id32<LocalVariables.M?> TMMJMJXONTH<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B28C50", Offset = "0x2B27A50", VA = "0x182B28C50")]
		public static Id32<LocalVariables.M> MVHPGFXSGFR(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B274B0", Offset = "0x2B262B0", VA = "0x182B274B0")]
		public static Id32<LocalVariables.M> FHKUFZLGPOE(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A940", Offset = "0x2B29740", VA = "0x182B2A940")]
		public static Id32<LocalVariables.M> WLFWLUYTCON(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B283F0", Offset = "0x2B271F0", VA = "0x182B283F0")]
		public static Id32<LocalVariables.M> KFEMDBRGLTX(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B288F0", Offset = "0x2B276F0", VA = "0x182B288F0")]
		public static Id32<LocalVariables.M> MGZMYDFZRJQ(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B470", Offset = "0x2B2A270", VA = "0x182B2B470")]
		public static Id32<LocalVariables.M> YLTTYFBYRDR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B29A30", Offset = "0x2B28830", VA = "0x182B29A30")]
		public static Id32<LocalVariables.M> RSATFQKIQBV(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A2B0", Offset = "0x2B290B0", VA = "0x182B2A2B0")]
		public static Id32<LocalVariables.M> SZOHDRQZMPC(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A3D0", Offset = "0x2B291D0", VA = "0x182B2A3D0")]
		public static Id32<LocalVariables.M> TFGQQDTFTCR(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B370", Offset = "0x2B2A170", VA = "0x182B2B370")]
		public static Id32<LocalVariables.M> XRJNUVUWNIM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B5B0", Offset = "0x2B2A3B0", VA = "0x182B2B5B0")]
		public static Id32<LocalVariables.M> ZGWMZBPLEEP(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B27BA0", Offset = "0x2B269A0", VA = "0x182B27BA0")]
		public static Id32<LocalVariables.M> HNXQQTCIYLE(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B26370", Offset = "0x2B25170", VA = "0x182B26370")]
		public static Id32<LocalVariables.M> AJUBPEGTTOF(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B27380", Offset = "0x2B26180", VA = "0x182B27380")]
		public static Id32<LocalVariables.M> EZLXGJSUMHE(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B29B30", Offset = "0x2B28930", VA = "0x182B29B30")]
		public static Id32<LocalVariables.M> RXDYLOVDHHN(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A8C0", Offset = "0x2B296C0", VA = "0x182B2A8C0")]
		public static Id32<LocalVariables.M> VRZWXFOMION(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B276D0", Offset = "0x2B264D0", VA = "0x182B276D0")]
		public static Id32<LocalVariables.M> FWBYVEHBMTY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B29890", Offset = "0x2B28690", VA = "0x182B29890")]
		public static Id32<LocalVariables.M> QHZOQIAJGJR(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A630", Offset = "0x2B29430", VA = "0x182B2A630")]
		public static Id32<LocalVariables.M> UDAGNEXJHHK(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B28FD0", Offset = "0x2B27DD0", VA = "0x182B28FD0")]
		public static Id32<LocalVariables.M> OJNJRFUXOUL(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A730", Offset = "0x2B29530", VA = "0x182B2A730")]
		public static Id32<LocalVariables.M> VAZYAUKCJQC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B28770", Offset = "0x2B27570", VA = "0x182B28770")]
		public static Id32<LocalVariables.M> LPVHGRDLASO(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A6B0", Offset = "0x2B294B0", VA = "0x182B2A6B0")]
		public static Id32<LocalVariables.M> UTIHEUOKKOR(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B7E0", Offset = "0x2B2A5E0", VA = "0x182B2B7E0")]
		public static Id32<LocalVariables.M> ZXLUXBYRCUE(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A5B0", Offset = "0x2B293B0", VA = "0x182B2A5B0")]
		public static Id32<LocalVariables.M> UBZPGUPCLPB(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B26CA0", Offset = "0x2B25AA0", VA = "0x182B26CA0")]
		public static Id32<LocalVariables.M> BYBNDJYMQRK(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B27CE0", Offset = "0x2B26AE0", VA = "0x182B27CE0")]
		public static Id32<LocalVariables.M> HODDKLIVVMJ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AB20", Offset = "0x2B29920", VA = "0x182B2AB20")]
		public static Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> WUZUZDRSHIT(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B280C0", Offset = "0x2B26EC0", VA = "0x182B280C0")]
		public static Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> HVFVEFFYPTB(this FunctionCompileState a, int b)
		{
			return default(Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AA80", Offset = "0x2B29880", VA = "0x182B2AA80")]
		public static Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> WSXNSAGEEWU(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B28570", Offset = "0x2B27370", VA = "0x182B28570")]
		public static Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> KRYQLOFJZIM(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A110", Offset = "0x2B28F10", VA = "0x182B2A110")]
		public static Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> SAAKIXHPHMU(this FunctionCompileState a, int b)
		{
			return default(Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A510", Offset = "0x2B29310", VA = "0x182B2A510")]
		public static Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> TYZSQIDTKZR(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B26800", Offset = "0x2B25600", VA = "0x182B26800")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.LNTDOTXDLWG>) BTKCRGFJNXC(this FunctionCompileState a, Id32<HJVJIQEFSCR> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.LNTDOTXDLWG>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B29C70", Offset = "0x2B28A70", VA = "0x182B29C70")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.LNTDOTXDLWG>) RZSZDTCFSEO(this FunctionCompileState a, Id32<HPBIAVPMDDB> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.LNTDOTXDLWG>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B460", Offset = "0x3B2A260", VA = "0x183B2B460")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<VHIMMWYWAFQ>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<TMarker>>, Id32<FunctionCalls.M>) ESMFVQUSZQN<TMarker>(this FunctionCompileState a, Id32<VHIMMWYWAFQ> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<VHIMMWYWAFQ>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B29150", Offset = "0x2B27F50", VA = "0x182B29150")]
		public static Id32<LocalVariables.M> PHCYYEVHHQN(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B28140", Offset = "0x2B26F40", VA = "0x182B28140")]
		public static Id32<LocalVariables.M> INTACFZJOYW(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B280", Offset = "0x2B2A080", VA = "0x182B2B280")]
		public static Id32<LocalVariables.M> XMLSIHCPHKX(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B26470", Offset = "0x2B25270", VA = "0x182B26470")]
		public static Id32<LocalVariables.M> AUTUYWJWZDK(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B27280", Offset = "0x2B26080", VA = "0x182B27280")]
		public static Id32<LocalVariables.M> EYQGZBXTDNZ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B27060", Offset = "0x2B25E60", VA = "0x182B27060")]
		public static Id32<LocalVariables.M> ENBZTJNCUAQ(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B28B10", Offset = "0x2B27910", VA = "0x182B28B10")]
		public static Id32<LocalVariables.M> MSWIOVHKIOB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B26D20", Offset = "0x2B25B20", VA = "0x182B26D20")]
		public static Id32<LocalVariables.M> DHTVRZWOBUJ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B28D50", Offset = "0x2B27B50", VA = "0x182B28D50")]
		public static Id32<LocalVariables.M> MVKKVJOQUAK(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B294D0", Offset = "0x2B282D0", VA = "0x182B294D0")]
		public static Id32<LocalVariables.M> PPOQZFMRZLN(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B284F0", Offset = "0x2B272F0", VA = "0x182B284F0")]
		public static Id32<LocalVariables.M> KQDIXPEFZPI(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B28370", Offset = "0x2B27170", VA = "0x182B28370")]
		public static Id32<LocalVariables.M> JYCPCTHAVJX(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B29310", Offset = "0x2B28110", VA = "0x182B29310")]
		public static Id32<LocalVariables.M> PIDRSRYIAWQ(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B29050", Offset = "0x2B27E50", VA = "0x182B29050")]
		public static Id32<LocalVariables.M> PEGVNVUBDVK(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B26590", Offset = "0x2B25390", VA = "0x182B26590")]
		public static Id32<LocalVariables.M> AVJMYSOCNQL(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B29610", Offset = "0x2B28410", VA = "0x182B29610")]
		public static Id32<LocalVariables.M> PRCLSHGYPYW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B29210", Offset = "0x2B28010", VA = "0x182B29210")]
		public static Id32<LocalVariables.M> PHHAMDQLIYF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A190", Offset = "0x2B28F90", VA = "0x182B2A190")]
		public static Id32<LocalVariables.M> SJJFPGRHIXU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B28230", Offset = "0x2B27030", VA = "0x182B28230")]
		public static Id32<LocalVariables.M> JOIZFWUKVFZ(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B28E70", Offset = "0x2B27C70", VA = "0x182B28E70")]
		public static Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>> MZGAADVUJIF(this FunctionCompileState a)
		{
			return default(Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B28A10", Offset = "0x2B27810", VA = "0x182B28A10")]
		public static Id32<LocalVariables.M> MMKTNRTBBTU(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B29910", Offset = "0x2B28710", VA = "0x182B29910")]
		public static Id32<LocalVariables.M> QLJIOKBWUSF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B27D60", Offset = "0x2B26B60", VA = "0x182B27D60")]
		public static Id32<LocalVariables.M> HONLHAYBDHS(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B27EA0", Offset = "0x2B26CA0", VA = "0x182B27EA0")]
		public static Id32<LocalVariables.M> HQGOGLCCEZS(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B27FA0", Offset = "0x2B26DA0", VA = "0x182B27FA0")]
		public static Id32<LocalVariables.M> HSWUCGKRHFV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B29750", Offset = "0x2B28550", VA = "0x182B29750")]
		public static Id32<LocalVariables.M> PRWHBGPNOOS(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B287F0", Offset = "0x2B275F0", VA = "0x182B287F0")]
		public static Id32<LocalVariables.M> LRUBRBHTEHF(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B6D0", Offset = "0x2B2A4D0", VA = "0x182B2B6D0")]
		public static Id32<LocalVariables.M> ZWUSDAXUYSA(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A7B0", Offset = "0x2B295B0", VA = "0x182B2A7B0")]
		public static void VEDBIVDJQRD(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A7C0", Offset = "0x2B295C0", VA = "0x182B2A7C0")]
		public static Id32<LocalVariables.M> VIPWGMCOMGW(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B26E20", Offset = "0x2B25C20", VA = "0x182B26E20")]
		public static Id32<LocalVariables.M> EGMUVSMFPCF(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B266C0", Offset = "0x2B254C0", VA = "0x182B266C0")]
		public static Id32<LocalVariables.M> AVVBSAZEWBO(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B275D0", Offset = "0x2B263D0", VA = "0x182B275D0")]
		public static Id32<LocalVariables.M> FIFZUFYFTDO(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B26F40", Offset = "0x2B25D40", VA = "0x182B26F40")]
		public static Id32<LocalVariables.M> EJWUNBIPMOL(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B28E90", Offset = "0x2B27C90", VA = "0x182B28E90")]
		public static Id32<LocalVariables.M> NEXAWLFMAGG(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AE70", Offset = "0x2B29C70", VA = "0x182B2AE70")]
		public static Id32<LocalVariables.M> XKSYGKSRBFE(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B27180", Offset = "0x2B25F80", VA = "0x182B27180")]
		public static Id32<LocalVariables.M> ERTHPAWSKFZ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B27A80", Offset = "0x2B26880", VA = "0x182B27A80")]
		public static Id32<LocalVariables.M> HCXMIFXQXAY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B29390", Offset = "0x2B28190", VA = "0x182B29390")]
		public static Id32<LocalVariables.M> PJZDWWKEZXT(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3B2A7F0", Offset = "0x3B295F0", VA = "0x183B2A7F0")]
		public static void CACSKQGBWWE<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<HJVJIQEFSCR> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, YTUDMBCVPQT<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3B2CBB0", Offset = "0x3B2B9B0", VA = "0x183B2CBB0")]
		public static void NTXWMLRDQDE<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<HPBIAVPMDDB> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, YTUDMBCVPQT<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3B2BCD0", Offset = "0x3B2AAD0", VA = "0x183B2BCD0")]
		public static Id32<LocalVariables.M> LGURWUFPRQU<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, YTUDMBCVPQT<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D8B0", Offset = "0x3B2C6B0", VA = "0x183B2D8B0")]
		public static Id32<LocalVariables.M> WBRUGLZLLGB<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, YTUDMBCVPQT<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B9C0", Offset = "0x3B2A7C0", VA = "0x183B2B9C0")]
		public static Id32<DataBackResults.M> JIJALSEQJTM<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, YTUDMBCVPQT<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D5B0", Offset = "0x3B2C3B0", VA = "0x183B2D5B0")]
		public static Id32<ExecForwardResults.M> TWMYLELCZVP<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, YTUDMBCVPQT<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AD20", Offset = "0x2B29B20", VA = "0x182B2AD20")]
		public static Id32<DataBackResults.M> XCKDRCRPRTV(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B27750", Offset = "0x2B26550", VA = "0x182B27750")]
		public static Id32<DataBackResults.M> HAAEJQVMQTH(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3B2BFE0", Offset = "0x3B2ADE0", VA = "0x183B2BFE0")]
		public static Id32<DataBackResults.M> LOAOHDKKSEE<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<HJVJIQEFSCR> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, YTUDMBCVPQT<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3B2C1C0", Offset = "0x3B2AFC0", VA = "0x183B2C1C0")]
		private static Id32<DataBackResults.M> LOAOHDKKSEE<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<HJVJIQEFSCR> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, YTUDMBCVPQT<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B570", Offset = "0x3B2A370", VA = "0x183B2B570")]
		public static Id32<LocalVariables.M> GDLTENCHPOM<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, YTUDMBCVPQT<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3B2DDC0", Offset = "0x3B2CBC0", VA = "0x183B2DDC0")]
		public static void ZCWQRKFZDFX<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, YTUDMBCVPQT<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<PWFCKDZBCDU<XVONRNCPECF>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<PWFCKDZBCDU<XVONRNCPECF>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
		public LiveInterval(Id32<PWFCKDZBCDU<XVONRNCPECF>> firstUse, Id32<PWFCKDZBCDU<XVONRNCPECF>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B25DF0", Offset = "0x2B24BF0", VA = "0x182B25DF0")]
		public static LiveInterval New(Id32<PWFCKDZBCDU<XVONRNCPECF>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class VLBWQCCVHHH : VXJZPZAXIFY
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
			[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class CQEBPJHNCXJ : VXJZPZAXIFY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class ADMLFVVOPUY : VXJZPZAXIFY
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
			[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
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
		public abstract class VXJZPZAXIFY
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
			public Id32<VXJZPZAXIFY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2B25B70", Offset = "0x2B24970", VA = "0x182B25B70")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<VXJZPZAXIFY> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class SBPXTQNRHPH : VXJZPZAXIFY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<VLBWQCCVHHH, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<ADMLFVVOPUY, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<SBPXTQNRHPH, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<CQEBPJHNCXJ, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B25FF0", Offset = "0x2B24DF0", VA = "0x182B25FF0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<VLBWQCCVHHH, ArgumentInst> argumentVariables, [In] SOAId32Field<ADMLFVVOPUY, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<SBPXTQNRHPH, ParameterInst> parameterVariables, [In] SOAId32Field<CQEBPJHNCXJ, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B25E00", Offset = "0x2B24C00", VA = "0x182B25E00")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class TBJNJYHVTJY
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C0D0", Offset = "0x2B2AED0", VA = "0x182B2C0D0")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class VMKXYTNYLWS
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E770", Offset = "0x2B2D570", VA = "0x182B2E770")]
		public static void YEYQFACLXEM(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.LNTDOTXDLWG, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B245C0", Offset = "0x2B233C0", VA = "0x182B245C0")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.LNTDOTXDLWG, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B24550", Offset = "0x2B23350", VA = "0x182B24550")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B24330", Offset = "0x2B23130", VA = "0x182B24330")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3577770", Offset = "0x3576570", VA = "0x183577770")]
		public static void YEYQFACLXEM<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<TROAQNNIZMC> graphId) where TDeps : notnull, YTUDMBCVPQT<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class NFTHHMRARZZ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B26120", Offset = "0x2B24F20", VA = "0x182B26120")]
		public static void YEYQFACLXEM(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface JHEXZCQIIGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void IYKNZZBMZRJ(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : JHEXZCQIIGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2B2B9A0", Offset = "0x2B2A7A0", VA = "0x182B2B9A0", Slot = "4")]
			public void IYKNZZBMZRJ(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : JHEXZCQIIGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BA30", Offset = "0x2B2A830", VA = "0x182B2BA30", Slot = "4")]
			public void IYKNZZBMZRJ(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : JHEXZCQIIGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2B2B860", Offset = "0x2B2A660", VA = "0x182B2B860", Slot = "4")]
			public void IYKNZZBMZRJ(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : JHEXZCQIIGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2B2B8F0", Offset = "0x2B2A6F0", VA = "0x182B2B8F0", Slot = "4")]
			public void IYKNZZBMZRJ(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class CWFBYFKVNRA<c> where c : struct, JHEXZCQIIGA
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c RHEDUJJJYXY;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x391D550", Offset = "0x391C350", VA = "0x18391D550")]
			public static int YEYQFACLXEM<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : YTUDMBCVPQT<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<FunctionCalls.LNTDOTXDLWG>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B25B20", Offset = "0x2B24920", VA = "0x182B25B20")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<FunctionCalls.LNTDOTXDLWG>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B25A70", Offset = "0x2B24870", VA = "0x182B25A70")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B25A30", Offset = "0x2B24830", VA = "0x182B25A30")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x397C870", Offset = "0x397B670", VA = "0x18397C870")]
		public static void YEYQFACLXEM<b, a>(FunctionCompileState a, b b, a c) where b : YTUDMBCVPQT<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class VYMLFVFYCMQ
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
		private static int VDNPRXSQXBE;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int MUXEWDCWXIM;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B2ED80", Offset = "0x2B2DB80", VA = "0x182B2ED80")]
		public static void YEYQFACLXEM(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E8D0", Offset = "0x2B2D6D0", VA = "0x182B2E8D0")]
		private static void GSPKNIZFBTH([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EAE0", Offset = "0x2B2D8E0", VA = "0x182B2EAE0")]
		private static void GSPKNIZFBTH(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EC20", Offset = "0x2B2DA20", VA = "0x182B2EC20")]
		private static void QNWFWAJOVUW(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class NQMHRDNTDCA<a, b, c> where a : struct, IPYMYHNQVWS<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a RHEDUJJJYXY;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5A31760", Offset = "0x5A30560", VA = "0x185A31760")]
		public static void YEYQFACLXEM([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface IPYMYHNQVWS<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> QQDFHINEHOI(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NTPHVBTMKDS(a a, b b, Id32<PWFCKDZBCDU<CJHMTIIQUWA>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface QWEOVWWUXEP<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a QMASQXSUEWT(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AAKKKCXKMAF(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<PWFCKDZBCDU<CJHMTIIQUWA>> UQHNBMIUSZC(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class EYUGBQIFLND<a, b, c> where a : struct, QWEOVWWUXEP<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a RHEDUJJJYXY;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4964820", Offset = "0x4963620", VA = "0x184964820")]
		public static UnsafeList<b> YEYQFACLXEM(int a, [In] c values)
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
