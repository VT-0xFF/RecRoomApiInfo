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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B895C0", Offset = "0x2B883C0", VA = "0x182B895C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
		public readonly Id32<WXKPXITHDLK<WFSWBPUBAOK>> Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly int Offset;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
		public ByteCodeAdjustment(Id32<WXKPXITHDLK<WFSWBPUBAOK>> location, int offset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct DataBackResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class RNCGSOCBGJO : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct BytesImmediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly ReadOnlyArray<byte> Bytes;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2B22660", Offset = "0x2B21460", VA = "0x182B22660")]
			public BytesImmediate(ReadOnlyArray<byte> bytes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B80000", Offset = "0x2B7EE00", VA = "0x182B80000", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public sealed class FZPRUFTYCXR : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct DeadEnd
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Id32<WXKPXITHDLK<VABZENOIJNF>> NextByteCodePtr;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
			public DeadEnd(Id32<WXKPXITHDLK<VABZENOIJNF>> nextByteCodePtr)
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
		public abstract class SJADMLYUAKY
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
			public readonly Id32<SJADMLYUAKY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
			public Inst(Def def, Id32<SJADMLYUAKY> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class UBARBXGPNHS : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct Variable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly Id32<LocalVariables.M> VariableId;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
			public Variable(Id32<LocalVariables.M> variableId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class STJWYORDNIG : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public readonly struct X32Immediate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Union32 X32;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
			public X32Immediate(Union32 x32)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2383710", Offset = "0x2382510", VA = "0x182383710", Slot = "3")]
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
		internal IdUnsafeList<RNCGSOCBGJO, BytesImmediate> _bytesImmediates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal IdUnsafeList<FZPRUFTYCXR, DeadEnd> _deadEnds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal IdUnsafeList<UBARBXGPNHS, Variable> _variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal IdUnsafeList<STJWYORDNIG, X32Immediate> _x32Immediates;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B801B0", Offset = "0x2B7EFB0", VA = "0x182B801B0")]
		private DataBackResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<RNCGSOCBGJO, BytesImmediate> bytesImmediates, [In] IdUnsafeList<FZPRUFTYCXR, DeadEnd> deadEnds, [In] IdUnsafeList<UBARBXGPNHS, Variable> variables, [In] IdUnsafeList<STJWYORDNIG, X32Immediate> x32Immediates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B80070", Offset = "0x2B7EE70", VA = "0x182B80070")]
		public static DataBackResults New()
		{
			return default(DataBackResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class VVUNBUVWEOT
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A270", Offset = "0x2B89070", VA = "0x182B8A270")]
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
		public sealed class MHKGAZVGOGT : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public readonly struct DeadEndData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Id32<DataBackResults.M> DataBackId;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
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
		public abstract class SJADMLYUAKY
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
			public readonly Id32<SJADMLYUAKY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
			public Inst(Def def, Id32<SJADMLYUAKY> joinId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal IdUnsafeList<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IdUnsafeList<MHKGAZVGOGT, DeadEndData> _deadEndBacks;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B802D0", Offset = "0x2B7F0D0", VA = "0x182B802D0")]
		private ExecForwardResults([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<MHKGAZVGOGT, DeadEndData> deadEndBacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B80240", Offset = "0x2B7F040", VA = "0x182B80240")]
		public static ExecForwardResults New()
		{
			return default(ExecForwardResults);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class UWVLDHBNKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B89FB0", Offset = "0x2B88DB0", VA = "0x182B89FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B803B0", Offset = "0x2B7F1B0", VA = "0x182B803B0")]
		private FunctionCallRegisterOffsets([In] UnsafeList<int> returnValueOffsets, [In] UnsafeList<int> argumentOffsets, int sizeBeforeUnmanagedRegisterPointer, int sizeBeforeManagedRegisterPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B80310", Offset = "0x2B7F110", VA = "0x182B80310")]
		public static FunctionCallRegisterOffsets New()
		{
			return default(FunctionCallRegisterOffsets);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class LSRUPEQRHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B81760", Offset = "0x2B80560", VA = "0x182B81760")]
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
		public sealed class PHDBOBFMAQL : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public readonly struct ExternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public readonly Id32<JBPPZEYKYJG> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
			public ExternalCall(Id32<JBPPZEYKYJG> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public abstract class SJADMLYUAKY
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
			public readonly Id32<SJADMLYUAKY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
			private Inst(Def def, Id32<SJADMLYUAKY> joinId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B81560", Offset = "0x2B80360", VA = "0x182B81560")]
			public static Inst New(Def def, Id32<SJADMLYUAKY> joinId)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public sealed class QIHZGXQRTZL : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public readonly struct InternalCall
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public readonly Id32<JBPPZEYKYJG> IOId;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
			public InternalCall(Id32<JBPPZEYKYJG> ioId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public sealed class JBPPZEYKYJG
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
			[Cpp2IlInjected.Address(RVA = "0x2B802D0", Offset = "0x2B7F0D0", VA = "0x182B802D0")]
			private IO([In] UnsafeList<Id32<LocalVariables.M>> arguments, [In] UnsafeList<Id32<LocalVariables.M>> returnValues)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B813B0", Offset = "0x2B801B0", VA = "0x182B813B0")]
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
		internal IdUnsafeList<QIHZGXQRTZL, InternalCall> _internalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal IdUnsafeList<PHDBOBFMAQL, ExternalCall> _externalCalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal UnsafeList<(Id32<M> CallId, Id32<JBPPZEYKYJG> IOId)> _callsWithIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<JBPPZEYKYJG, IO> _io;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal SOAField<JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> _ioModifyingCallLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal SOAField<JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> _stackOffsetWriteLocations;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B805B0", Offset = "0x2B7F3B0", VA = "0x182B805B0")]
		private FunctionCalls([In] IdUnsafeList<M, Inst> instances, [In] IdUnsafeList<QIHZGXQRTZL, InternalCall> internalCalls, [In] IdUnsafeList<PHDBOBFMAQL, ExternalCall> externalCalls, [In] UnsafeList<(Id32<M> CallId, Id32<JBPPZEYKYJG> IOId)> callsWithIO, [In] IdUnsafeList<JBPPZEYKYJG, IO> io, [In] SOAField<JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> ioModifyingCallLocations, [In] SOAField<JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> stackOffsetWriteLocations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B80410", Offset = "0x2B7F210", VA = "0x182B80410")]
		public static FunctionCalls New()
		{
			return default(FunctionCalls);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class VHSFWGTIYBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A220", Offset = "0x2B89020", VA = "0x182B8A220")]
		private static void Destroy(this FunctionCalls.IO self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A010", Offset = "0x2B88E10", VA = "0x182B8A010")]
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
		internal SOAField<ADNWLQIRYCV, Id32<DataBackResults.M>?> _generatedOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal UnsafeList<Id32<ADNWLQIRYCV>> _generatedOutputsForExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> _inputJumpAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> _queuedRegisterWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> _queuedJumpAddressWrites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal AssignRegistersPass _assignRegistersPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal InsertOffsetManagedObjectStackCallsPass _insertOffsetManagedObjectStackCallsPass;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B81000", Offset = "0x2B7FE00", VA = "0x182B81000")]
		private FunctionCompileState([In] UnsafeList<byte> byteCode, [In] FunctionCalls functionCalls, [In] LocalVariables localVariables, [In] DataBackResults dataBackResults, [In] ExecForwardResults execForwardResults, [In] SOAField<ADNWLQIRYCV, Id32<DataBackResults.M>?> generatedOutputs, [In] UnsafeList<Id32<ADNWLQIRYCV>> generatedOutputsForExpression, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> inputJumpAddresses, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> queuedRegisterWrites, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> queuedJumpAddressWrites, [In] AssignRegistersPass assignRegistersPass, [In] InsertOffsetManagedObjectStackCallsPass insertOffsetManagedObjectStackCallsPass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B80670", Offset = "0x2B7F470", VA = "0x182B80670")]
		public static FunctionCompileState New()
		{
			return default(FunctionCompileState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class MFBKOKREUQW
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private readonly struct SortFunctionCallsByIOModifyingCallLocationDeps : FCHXAOXANFH<Id32<FunctionCalls.JBPPZEYKYJG>, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B89A70", Offset = "0x2B88870", VA = "0x182B89A70")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B89A20", Offset = "0x2B88820", VA = "0x182B89A20", Slot = "4")]
			public Id32<FunctionCalls.JBPPZEYKYJG> KECGMKFBPXL(int a)
			{
				return default(Id32<FunctionCalls.JBPPZEYKYJG>);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10")]
			public bool FNGNUPUAPOT(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "5")]
			private bool COVECNUXTIH(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B89A60", Offset = "0x2B88860", VA = "0x182B89A60", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> STBRDZEWRTY(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct AdjustFunctionCallsIOModifyingCallLocations : KFITFPEAZWY<Id32<FunctionCalls.JBPPZEYKYJG>, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F190", Offset = "0x2B7DF90", VA = "0x182B7F190")]
			public UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>> GWRKSQGDBQS(int a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F2B0", Offset = "0x2B7E0B0", VA = "0x182B7F2B0")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F210", Offset = "0x2B7E010", VA = "0x182B7F210", Slot = "6")]
			public void SJJLUJOAAPQ(Id32<FunctionCalls.JBPPZEYKYJG> a, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> b, Id32<WXKPXITHDLK<WFSWBPUBAOK>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F190", Offset = "0x2B7DF90", VA = "0x182B7F190", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>> XMFUTKZFBRP(int a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F200", Offset = "0x2B7E000", VA = "0x182B7F200", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> HUAUFKLZRPV(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<VABZENOIJNF>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private readonly struct SortFunctionCallsByStackOffsetWriteLocationDeps : FCHXAOXANFH<Id32<FunctionCalls.JBPPZEYKYJG>, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B89B40", Offset = "0x2B88940", VA = "0x182B89B40")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B89B00", Offset = "0x2B88900", VA = "0x182B89B00", Slot = "4")]
			public Id32<FunctionCalls.JBPPZEYKYJG> KECGMKFBPXL(int a)
			{
				return default(Id32<FunctionCalls.JBPPZEYKYJG>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10")]
			public bool FNGNUPUAPOT(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "5")]
			private bool NAPOXIQDJWQ(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B89AF0", Offset = "0x2B888F0", VA = "0x182B89AF0", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> DXZMKOJLSAB(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private readonly struct AdjustFunctionCallsStackOffsetWriteLocations : KFITFPEAZWY<Id32<FunctionCalls.JBPPZEYKYJG>, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>>>
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F330", Offset = "0x2B7E130", VA = "0x182B7F330")]
			public UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>> GWRKSQGDBQS(int a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F450", Offset = "0x2B7E250", VA = "0x182B7F450")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F3B0", Offset = "0x2B7E1B0", VA = "0x182B7F3B0", Slot = "6")]
			public void SJJLUJOAAPQ(Id32<FunctionCalls.JBPPZEYKYJG> a, SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> b, Id32<WXKPXITHDLK<WFSWBPUBAOK>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F330", Offset = "0x2B7E130", VA = "0x182B7F330", Slot = "4")]
			private UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>> IYOKVHDWASO(int a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(UnsafeList<Id32<FunctionCalls.JBPPZEYKYJG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F3A0", Offset = "0x2B7E1A0", VA = "0x182B7F3A0", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> NEXCQOVQKTQ(Id32<FunctionCalls.JBPPZEYKYJG> a, [In] SOAField<FunctionCalls.JBPPZEYKYJG, Id32<WXKPXITHDLK<CXMCVELPQUC>>> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct SortInputJumpAddressesByValue : FCHXAOXANFH<Id32<QLUJOYTGVHG>, SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2B89C70", Offset = "0x2B88A70", VA = "0x182B89C70")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2B89C30", Offset = "0x2B88A30", VA = "0x182B89C30", Slot = "4")]
			public Id32<QLUJOYTGVHG> KECGMKFBPXL(int a)
			{
				return default(Id32<QLUJOYTGVHG>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B89BC0", Offset = "0x2B889C0", VA = "0x182B89BC0")]
			public bool FNGNUPUAPOT(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B89BC0", Offset = "0x2B889C0", VA = "0x182B89BC0", Slot = "5")]
			private bool ZWNDEMQDCHA(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2B89C20", Offset = "0x2B88A20", VA = "0x182B89C20", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> FWWTHKPHJWH(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private readonly struct AdjustInputJumpAddresses : KFITFPEAZWY<Id32<QLUJOYTGVHG>, SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F4E0", Offset = "0x2B7E2E0", VA = "0x182B7F4E0")]
			public UnsafeList<Id32<QLUJOYTGVHG>> GWRKSQGDBQS(int a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(UnsafeList<Id32<QLUJOYTGVHG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F650", Offset = "0x2B7E450", VA = "0x182B7F650")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F550", Offset = "0x2B7E350", VA = "0x182B7F550", Slot = "6")]
			public void SJJLUJOAAPQ(Id32<QLUJOYTGVHG> a, SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> b, Id32<WXKPXITHDLK<WFSWBPUBAOK>> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F4E0", Offset = "0x2B7E2E0", VA = "0x182B7F4E0", Slot = "4")]
			private UnsafeList<Id32<QLUJOYTGVHG>> EXMLRXMAUUI(int a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(UnsafeList<Id32<QLUJOYTGVHG>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F4D0", Offset = "0x2B7E2D0", VA = "0x182B7F4D0", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> DAKIASEDMOA(Id32<QLUJOYTGVHG> a, [In] SOAField<QLUJOYTGVHG, Id32<WXKPXITHDLK<VABZENOIJNF>>?> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private readonly struct SortQueuedRegisterWritesByByteCodeWriteLocation : FCHXAOXANFH<int, UnsafeList<(Id32<LocalVariables.M>, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2B89E70", Offset = "0x2B88C70", VA = "0x182B89E70")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD4BB70", Offset = "0xD4A970", VA = "0x180D4BB70", Slot = "4")]
			public int KECGMKFBPXL(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10")]
			public bool FNGNUPUAPOT(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "5")]
			private bool HPASLXSANJR(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B89E60", Offset = "0x2B88C60", VA = "0x182B89E60", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> JWKISGIELSG(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct AdjustQueuedRegisterWritesByByteCodeWriteLocation : KFITFPEAZWY<int, UnsafeList<(Id32<LocalVariables.M>, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B7FB30", Offset = "0x2B7E930", VA = "0x182B7FB30")]
			public UnsafeList<int> GWRKSQGDBQS(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B7FCA0", Offset = "0x2B7EAA0", VA = "0x182B7FCA0")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2B7FBA0", Offset = "0x2B7E9A0", VA = "0x182B7FBA0", Slot = "6")]
			public void SJJLUJOAAPQ(int a, UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values, Id32<WXKPXITHDLK<WFSWBPUBAOK>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2B7FB30", Offset = "0x2B7E930", VA = "0x182B7FB30", Slot = "4")]
			private UnsafeList<int> SIJNDRLNQYH(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2B7FB20", Offset = "0x2B7E920", VA = "0x182B7FB20", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> BUFGLBJGCYZ(int a, [In] UnsafeList<(Id32<LocalVariables.M> VariableId, Id32<WXKPXITHDLK<IXKHGZWDMFU<WFSWBPUBAOK>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private readonly struct SortQueuedJumpAddressWritesByTarget : FCHXAOXANFH<int, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2B89DC0", Offset = "0x2B88BC0", VA = "0x182B89DC0")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD4BB70", Offset = "0xD4A970", VA = "0x180D4BB70", Slot = "4")]
			public int KECGMKFBPXL(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10")]
			public bool FNGNUPUAPOT(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "5")]
			private bool VUSHHLLLXFM(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B89E50", Offset = "0x2B88C50", VA = "0x182B89E50", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> XTMAIRYPOPN(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct AdjustQueuedJumpAddressWritesByTarget : KFITFPEAZWY<int, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F910", Offset = "0x2B7E710", VA = "0x182B7F910")]
			public UnsafeList<int> GWRKSQGDBQS(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B7FA90", Offset = "0x2B7E890", VA = "0x182B7FA90")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F990", Offset = "0x2B7E790", VA = "0x182B7F990", Slot = "6")]
			public void SJJLUJOAAPQ(int a, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values, Id32<WXKPXITHDLK<WFSWBPUBAOK>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F910", Offset = "0x2B7E710", VA = "0x182B7F910", Slot = "4")]
			private UnsafeList<int> SEGSIUTHCKO(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F980", Offset = "0x2B7E780", VA = "0x182B7F980", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> PKJEPMGCETI(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private readonly struct SortQueuedJumpAddressWritesByByteCodeWriteLocation : FCHXAOXANFH<int, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2B89D20", Offset = "0x2B88B20", VA = "0x182B89D20")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD4BB70", Offset = "0xD4A970", VA = "0x180D4BB70", Slot = "4")]
			public int KECGMKFBPXL(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10")]
			public bool FNGNUPUAPOT(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "5")]
			private bool VUSHHLLLXFM(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2B89DB0", Offset = "0x2B88BB0", VA = "0x182B89DB0", Slot = "6")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> XTMAIRYPOPN(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private readonly struct AdjustQueuedJumpAddressWritesByByteCodeWriteLocation : KFITFPEAZWY<int, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>)>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F700", Offset = "0x2B7E500", VA = "0x182B7F700")]
			public UnsafeList<int> GWRKSQGDBQS(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F880", Offset = "0x2B7E680", VA = "0x182B7F880")]
			public Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F780", Offset = "0x2B7E580", VA = "0x182B7F780", Slot = "6")]
			public void SJJLUJOAAPQ(int a, UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values, Id32<WXKPXITHDLK<WFSWBPUBAOK>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F700", Offset = "0x2B7E500", VA = "0x182B7F700", Slot = "4")]
			private UnsafeList<int> SEGSIUTHCKO(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(UnsafeList<int>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F770", Offset = "0x2B7E570", VA = "0x182B7F770", Slot = "5")]
			private Id32<WXKPXITHDLK<WFSWBPUBAOK>> PKJEPMGCETI(int a, [In] UnsafeList<(Id32<WXKPXITHDLK<VABZENOIJNF>> Target, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ByteCodeWriteLocation)> values)
			{
				return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
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
			[Cpp2IlInjected.Address(RVA = "0x1CBA430", Offset = "0x1CB9230", VA = "0x181CBA430")]
			public GenerateDataBackResult(Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B813A0", Offset = "0x2B801A0", VA = "0x182B813A0")]
			public void OGNPAZKLJRJ([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public readonly struct GenerateDataBackFromInputIndexResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public readonly Id32<QLUJOYTGVHG> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public readonly bool IsDeadEnd;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B81380", Offset = "0x2B80180", VA = "0x182B81380")]
			public GenerateDataBackFromInputIndexResult(Id32<QLUJOYTGVHG> inputId, Id32<DataBackResults.M> dataBackResultId, bool isDeadEnd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B81370", Offset = "0x2B80170", VA = "0x182B81370")]
			public void OGNPAZKLJRJ([Out] Id32<DataBackResults.M> a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B81350", Offset = "0x2B80150", VA = "0x182B81350")]
			public void OGNPAZKLJRJ([Out] Id32<DataBackResults.M> a, [Out] Id32<QLUJOYTGVHG> b, [Out] bool c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct GenerateDataBackFromInputIndicesResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public readonly Id32<QLUJOYTGVHG> InputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly Id32<DataBackResults.M> DataBackResultId;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
			public GenerateDataBackFromInputIndicesResult(Id32<QLUJOYTGVHG> inputId, Id32<DataBackResults.M> dataBackResultId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B81390", Offset = "0x2B80190", VA = "0x182B81390")]
			public void OGNPAZKLJRJ([Out] Id32<DataBackResults.M> a, [Out] Id32<QLUJOYTGVHG> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B82450", Offset = "0x2B81250", VA = "0x182B82450")]
		public static void Destroy(this FunctionCompileState self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B833B0", Offset = "0x2B821B0", VA = "0x182B833B0")]
		public static void NVWBHOTLECY(this FunctionCompileState a, Id32<ADNWLQIRYCV> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B83700", Offset = "0x2B82500", VA = "0x182B83700")]
		public static void QATSXLHUZFM(this FunctionCompileState a, Id32<ADNWLQIRYCV> b, Id32<DataBackResults.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B83330", Offset = "0x2B82130", VA = "0x182B83330")]
		public static Id32<DataBackResults.M>? MALIWTSNDSX([In] this FunctionCompileState self, Id32<ADNWLQIRYCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B83DE0", Offset = "0x2B82BE0", VA = "0x182B83DE0")]
		public static Id32<WXKPXITHDLK<VABZENOIJNF>> WVEKWJSTWBV([In] this FunctionCompileState self)
		{
			return default(Id32<WXKPXITHDLK<VABZENOIJNF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B81C90", Offset = "0x2B80A90", VA = "0x182B81C90")]
		private static void BMOCKWXBAFC(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B83E40", Offset = "0x2B82C40", VA = "0x182B83E40")]
		private static Id32<WXKPXITHDLK<VABZENOIJNF>>? XHYWZKFIUTZ([In] this FunctionCompileState self, Id32<QLUJOYTGVHG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B81F10", Offset = "0x2B80D10", VA = "0x182B81F10")]
		public static void CZBYYUSJKOX(this FunctionCompileState a, [In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B83AA0", Offset = "0x2B828A0", VA = "0x182B83AA0")]
		public static DataBackResults.Def RZTGBCWYIBZ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(DataBackResults.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B839C0", Offset = "0x2B827C0", VA = "0x182B839C0")]
		public static ReadOnlyArray<byte> RLBFHSXRENV([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(ReadOnlyArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B822E0", Offset = "0x2B810E0", VA = "0x182B822E0")]
		public static Id32<LocalVariables.M> DTQLIMHIROJ([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B838E0", Offset = "0x2B826E0", VA = "0x182B838E0")]
		public static Union32 RATGTPUQWRL([In] this FunctionCompileState self, Id32<DataBackResults.M> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C01D90", Offset = "0x3C00B90", VA = "0x183C01D90")]
		private static Id32<DataBackResults.M> NCJAOVMJLAW<a>(this FunctionCompileState a, DataBackResults.Def b, Id32<a> c) where a : DataBackResults.SJADMLYUAKY
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B83C10", Offset = "0x2B82A10", VA = "0x182B83C10")]
		public static Id32<DataBackResults.M> VKVVQRQNVGY(this FunctionCompileState a, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B823C0", Offset = "0x2B811C0", VA = "0x182B823C0")]
		public static Id32<DataBackResults.M> DUZZSZFPAVN(this FunctionCompileState a, ReadOnlyArray<byte> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B83B90", Offset = "0x2B82990", VA = "0x182B83B90")]
		public static Id32<DataBackResults.M> ULIVWZTNKNU(this FunctionCompileState a, Id32<WXKPXITHDLK<VABZENOIJNF>> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B83F10", Offset = "0x2B82D10", VA = "0x182B83F10")]
		public static Id32<DataBackResults.M> YQUWBQSOQCE(this FunctionCompileState a, int b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B82BA0", Offset = "0x2B819A0", VA = "0x182B82BA0")]
		public static Id32<DataBackResults.M> HVFYHQBZKIL(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C033F0", Offset = "0x3C021F0", VA = "0x183C033F0")]
		private static Id32<ExecForwardResults.M> UWBUBWOGYWJ<b>(this FunctionCompileState a, ExecForwardResults.Def b, Id32<b> c) where b : ExecForwardResults.SJADMLYUAKY
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B822A0", Offset = "0x2B810A0", VA = "0x182B822A0")]
		public static Id32<ExecForwardResults.M> DLPRTPYNWDV(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B828F0", Offset = "0x2B816F0", VA = "0x182B828F0")]
		public static Id32<ExecForwardResults.M> FLEIQSYUSTC(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B83B10", Offset = "0x2B82910", VA = "0x182B83B10")]
		public static Id32<ExecForwardResults.M> TWRSVHGNZFC(this FunctionCompileState a, Id32<DataBackResults.M> b)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B83D00", Offset = "0x2B82B00", VA = "0x182B83D00")]
		public static Id32<ExecForwardResults.M> WQROPHSMGLL(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B83050", Offset = "0x2B81E50", VA = "0x182B83050")]
		public static Id32<ExecForwardResults.M> KHVWOZIYGCJ(this FunctionCompileState a)
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B82FE0", Offset = "0x2B81DE0", VA = "0x182B82FE0")]
		public static FunctionCalls.Def JVMBRVWEXPI([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(FunctionCalls.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B830A0", Offset = "0x2B81EA0", VA = "0x182B830A0")]
		public static CopyEnumerable<Id32<FunctionCalls.JBPPZEYKYJG>, Id32Enumerator<FunctionCalls.JBPPZEYKYJG>> KRVUHEWRJML([In] this FunctionCompileState self)
		{
			return default(CopyEnumerable<Id32<FunctionCalls.JBPPZEYKYJG>, Id32Enumerator<FunctionCalls.JBPPZEYKYJG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B82D30", Offset = "0x2B81B30", VA = "0x182B82D30")]
		public static Id32<FunctionCalls.JBPPZEYKYJG> IWETUUNIWSK([In] this FunctionCompileState self, Id32<FunctionCalls.M> a)
		{
			return default(Id32<FunctionCalls.JBPPZEYKYJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B83C90", Offset = "0x2B82A90", VA = "0x182B83C90")]
		public static FunctionCalls.IO WQQOTRYZHXR([In] this FunctionCompileState self, Id32<FunctionCalls.JBPPZEYKYJG> a)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B830E0", Offset = "0x2B81EE0", VA = "0x182B830E0")]
		public static FunctionCalls.IO KTEEOLSMRJV(this FunctionCompileState a, Id32<FunctionCalls.JBPPZEYKYJG> b)
		{
			return default(FunctionCalls.IO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C01D00", Offset = "0x3C00B00", VA = "0x183C01D00")]
		private static Id32<FunctionCalls.M> MJDDORZLQIA<c>(this FunctionCompileState a, FunctionCalls.Def b, Id32<c> c) where c : FunctionCalls.SJADMLYUAKY
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B81AE0", Offset = "0x2B808E0", VA = "0x182B81AE0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>) AGBPNQJBQIF(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B83550", Offset = "0x2B82350", VA = "0x182B83550")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>) PWIUONWKBDN(this FunctionCompileState a)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B828A0", Offset = "0x2B816A0", VA = "0x182B828A0")]
		public static Id32<FunctionCalls.M> ERQBQAAYHJW(this FunctionCompileState a)
		{
			return default(Id32<FunctionCalls.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B81E30", Offset = "0x2B80C30", VA = "0x182B81E30")]
		public static void COENMYHJLSF(this FunctionCompileState a, Id32<FunctionCalls.JBPPZEYKYJG> b, Id32<WXKPXITHDLK<VABZENOIJNF>> c, Id32<WXKPXITHDLK<CXMCVELPQUC>> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C01E30", Offset = "0x3C00C30", VA = "0x183C01E30")]
		public static GenerateDataBackResult NDVTJOTHBUB<d, e>(this FunctionCompileState a, d b, e c, Id32<VFKNGTPUEMY> d, Id32<QLUJOYTGVHG> e) where d : EXZIFHHHFWB<e>
		{
			return default(GenerateDataBackResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C018B0", Offset = "0x3C006B0", VA = "0x183C018B0")]
		public static GenerateDataBackFromInputIndexResult LYMPVEQBQRP<f, g>(this FunctionCompileState a, f b, g c, Id32<VFKNGTPUEMY> d, Id32<MVBOYPURKWM> e, int f) where f : EXZIFHHHFWB<g>
		{
			return default(GenerateDataBackFromInputIndexResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3C03490", Offset = "0x3C02290", VA = "0x183C03490")]
		public static Id32<DataBackResults.M>? YYPLHKZDDWI<h, i>(this FunctionCompileState a, h b, i c, Id32<VFKNGTPUEMY> d, Id32<MVBOYPURKWM> e, [In] ReadOnlySpan<int> inputIndices, [In] Span<GenerateDataBackFromInputIndicesResult> generateDataBackResults) where h : EXZIFHHHFWB<i>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C01090", Offset = "0x3BFFE90", VA = "0x183C01090")]
		public static Id32<ExecForwardResults.M> JBJFRQZIZOY<j, k>(this FunctionCompileState a, j b, k c, Id32<VFKNGTPUEMY> d, Id32<ADNWLQIRYCV> e) where j : EXZIFHHHFWB<k>
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B82080", Offset = "0x2B80E80", VA = "0x182B82080")]
		public static LocalVariables.ArgumentInst CZRKRVLCCFO([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ArgumentInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B83440", Offset = "0x2B82240", VA = "0x182B83440")]
		public static LocalVariables.CalleeReturnValueInst OQBOCRKESMU([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CalleeReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B82190", Offset = "0x2B80F90", VA = "0x182B82190")]
		public static LocalVariables.CallerReturnValueInst DFJNRKJQQDV([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.CallerReturnValueInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B82940", Offset = "0x2B81740", VA = "0x182B82940")]
		public static Id32<LocalVariables.M> GSUOLPIXGLX(this FunctionCompileState a, int? b, string c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B837D0", Offset = "0x2B825D0", VA = "0x182B837D0")]
		public static LocalVariables.ParameterInst QICVOMVDQTQ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.ParameterInst);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B81EC0", Offset = "0x2B80CC0", VA = "0x182B81EC0")]
		public static LocalVariables.Def CSNRTICWXRQ([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return default(LocalVariables.Def);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B83EC0", Offset = "0x2B82CC0", VA = "0x182B83EC0")]
		public static int? YLJWYGTOFHG([In] this FunctionCompileState self, Id32<LocalVariables.M> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C00F90", Offset = "0x3BFFD90", VA = "0x183C00F90")]
		private static Id32<LocalVariables.M> IPWZAYFXQLS<l>(this FunctionCompileState a, int? b, LocalVariables.Def c, Id32<l> d) where l : LocalVariables.SJADMLYUAKY
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B82AF0", Offset = "0x2B818F0", VA = "0x182B82AF0")]
		public static Id32<LocalVariables.M> HLKQZZNECMS(this FunctionCompileState a, int? b, Id32<FunctionCalls.M> c, int d)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B83150", Offset = "0x2B81F50", VA = "0x182B83150")]
		public static Id32<LocalVariables.M> LFJKXTEVROF(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B82720", Offset = "0x2B81520", VA = "0x182B82720")]
		public static Id32<LocalVariables.M> EIMSLLQDDBV(this FunctionCompileState a, Id32<LocalVariables.M>? b, int? c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B83D50", Offset = "0x2B82B50", VA = "0x182B83D50")]
		public static Id32<LocalVariables.M> WSPJGYUDGKD(this FunctionCompileState a, int? b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B832D0", Offset = "0x2B820D0", VA = "0x182B832D0")]
		public static Id32<LocalVariables.M> LXKBIDQQXTF(this FunctionCompileState a, int? b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B831B0", Offset = "0x2B81FB0", VA = "0x182B831B0")]
		public static void LTJAPHOKNKU(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<FunctionCalls.M> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B82C20", Offset = "0x2B81A20", VA = "0x182B82C20")]
		public static void ITXWSLUFBVK(this FunctionCompileState a, Id32<LocalVariables.M> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B84020", Offset = "0x2B82E20", VA = "0x182B84020")]
		public static void ZNXPQPSDJTG(this FunctionCompileState a, Id32<LocalVariables.M> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B83F90", Offset = "0x2B82D90", VA = "0x182B83F90")]
		public static void ZNDBNZAWEXZ(this FunctionCompileState a, Id32<WXKPXITHDLK<VABZENOIJNF>> b, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B82F00", Offset = "0x2B81D00", VA = "0x182B82F00")]
		public static void JKKXRUAXRKH(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<WXKPXITHDLK<PFWNNIRWZZM>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3C03310", Offset = "0x3C02110", VA = "0x183C03310")]
		public static void RQSKTLDNJUQ<m>(this FunctionCompileState a, Id32<LocalVariables.M> b, Id32<WXKPXITHDLK<IXKHGZWDMFU<m>>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface EXZIFHHHFWB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<IUBIECDJGSA> BBBCYFXAQKO(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<IUBIECDJGSA> OIOWZEBVGIH(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<IUBIECDJGSA> HNEJKNDKPWA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Id32<IUBIECDJGSA> VJOZMNTHWIX(a a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Id32<ExecForwardResults.M> FONCFOJGNND(a a, FunctionCompileState b, Id32<VFKNGTPUEMY> c, Id32<QLUJOYTGVHG> d);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Id32<DataBackResults.M> FCASEMJJNAL(a a, FunctionCompileState b, Id32<VFKNGTPUEMY> c, Id32<ADNWLQIRYCV> d);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int VGYEJTKADNN(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Id32<ADNWLQIRYCV> CBZUWVCHZUM(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DefaultValueKind QWJZPIJDCIZ(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HZAQGYKKCJU(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int RZDLJYEGGED(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ReadOnlyArray<byte> QQRYZZGFDJD(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		(ReadOnlyArray<byte>, Id32<IUBIECDJGSA>) VSQISJNNPQP(a a, Id32<VFKNGTPUEMY> b, Id32<QLUJOYTGVHG> c);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int REARDYVAZKR(a a, Id32<VFKNGTPUEMY> b, Id32<ADNWLQIRYCV> c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Id32<QLUJOYTGVHG> DEUICNATHHW(a a, Id32<VFKNGTPUEMY> b, Id32<ADNWLQIRYCV> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Id32<QLUJOYTGVHG> DOESMTLHEMB(a a, Id32<VFKNGTPUEMY> b, Id32<MVBOYPURKWM> c, int d);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		int QTXIWKJKDIN(a a, Id32<VFKNGTPUEMY> b);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		int? STWWOJECUWJ(a a, Id32<VFKNGTPUEMY> b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		int UXIWTLZVYGL(a a, Id32<VFKNGTPUEMY> b);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int? VELANUUGKPN(a a, Id32<VFKNGTPUEMY> b, int c);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class MURXNLTJXMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C11220", Offset = "0x3C10020", VA = "0x183C11220")]
		public static Id32<LocalVariables.M?> CDGAJSFPVVB<a, b, c>(this FunctionCompileState a, a lhs, a rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C14B30", Offset = "0x3C13930", VA = "0x183C14B30")]
		public static Id32<LocalVariables.M?> WFAEWJRFXIK<d, e, f>(this FunctionCompileState a, d lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C13F10", Offset = "0x3C12D10", VA = "0x183C13F10")]
		public static Id32<LocalVariables.M?> OQELPZFYHBF<g, h>(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs, int b, IntPtr op)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B855B0", Offset = "0x2B843B0", VA = "0x182B855B0")]
		public static Id32<LocalVariables.M> GRQWXGOASKJ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B87BF0", Offset = "0x2B869F0", VA = "0x182B87BF0")]
		public static Id32<LocalVariables.M> SINOEXLVUJI(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B858B0", Offset = "0x2B846B0", VA = "0x182B858B0")]
		public static Id32<LocalVariables.M> IKAFSZQBHLB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B856B0", Offset = "0x2B844B0", VA = "0x182B856B0")]
		public static Id32<LocalVariables.M> HBPUYIUQTEP(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B84B00", Offset = "0x2B83900", VA = "0x182B84B00")]
		public static Id32<LocalVariables.M> DZMWLUCEXQY(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B86690", Offset = "0x2B85490", VA = "0x182B86690")]
		public static Id32<LocalVariables.M> MFAISFRBLCF(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B84C20", Offset = "0x2B83A20", VA = "0x182B84C20")]
		public static Id32<LocalVariables.M> ECHFHLXTSGZ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B84E60", Offset = "0x2B83C60", VA = "0x182B84E60")]
		public static Id32<LocalVariables.M> EUHZCHUYWMK(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B88CB0", Offset = "0x2B87AB0", VA = "0x182B88CB0")]
		public static Id32<LocalVariables.M> XZTKTWJHGKT(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B87AF0", Offset = "0x2B868F0", VA = "0x182B87AF0")]
		public static Id32<LocalVariables.M> RWUOLPMGBJY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B86BA0", Offset = "0x2B859A0", VA = "0x182B86BA0")]
		public static Id32<LocalVariables.M> MXZAOGWHIKV(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B87FD0", Offset = "0x2B86DD0", VA = "0x182B87FD0")]
		public static Id32<LocalVariables.M> UAOJHPRMFPO(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B84500", Offset = "0x2B83300", VA = "0x182B84500")]
		public static Id32<LocalVariables.M> ATGMFSIIWQP(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B86FB0", Offset = "0x2B85DB0", VA = "0x182B86FB0")]
		public static Id32<LocalVariables.M> OYXYIZACOBG(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B89240", Offset = "0x2B88040", VA = "0x182B89240")]
		public static Id32<LocalVariables.M> YSDXEAIIYBH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B88C30", Offset = "0x2B87A30", VA = "0x182B88C30")]
		public static Id32<LocalVariables.M> XSWAWPHAUZF(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B894A0", Offset = "0x2B882A0", VA = "0x182B894A0")]
		public static Id32<LocalVariables.M> ZIYJTUIBDMU(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B86DE0", Offset = "0x2B85BE0", VA = "0x182B86DE0")]
		public static Id32<LocalVariables.M> NXMQGEFSXUF(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B851B0", Offset = "0x2B83FB0", VA = "0x182B851B0")]
		public static Id32<LocalVariables.M> FOOVXCBWJAS(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B870E0", Offset = "0x2B85EE0", VA = "0x182B870E0")]
		public static Id32<LocalVariables.M> PEZHVHYZPBT(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B86980", Offset = "0x2B85780", VA = "0x182B86980")]
		public static Id32<LocalVariables.M> MODBDGYCBAE(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B88330", Offset = "0x2B87130", VA = "0x182B88330")]
		public static Id32<LocalVariables.M> ULOQSHXMVXC(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B883B0", Offset = "0x2B871B0", VA = "0x182B883B0")]
		public static Id32<LocalVariables.M> UOEWODGBYDF(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B84940", Offset = "0x2B83740", VA = "0x182B84940")]
		public static Id32<LocalVariables.M> CNEJNDKYFMC(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B862A0", Offset = "0x2B850A0", VA = "0x182B862A0")]
		public static Id32<LocalVariables.M> JFECNYJPAAR(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B87F30", Offset = "0x2B86D30", VA = "0x182B87F30")]
		public static Id32<LocalVariables.M> TJGELXCEEGC(this FunctionCompileState a, float b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B86B20", Offset = "0x2B85920", VA = "0x182B86B20")]
		public static Id32<LocalVariables.M> MXPZFIWENYH(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B89040", Offset = "0x2B87E40", VA = "0x182B89040")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> YRNCSUPJNHL(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B886F0", Offset = "0x2B874F0", VA = "0x182B886F0")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> WSEVYTNUNDH(this FunctionCompileState a, int b)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B89520", Offset = "0x2B88320", VA = "0x182B89520")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> ZQNASLNIOVI(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B88770", Offset = "0x2B87570", VA = "0x182B88770")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> XBYFCGUGOSW(this FunctionCompileState a, Id32<DataBackResults.M> dataBackResultId)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B88430", Offset = "0x2B87230", VA = "0x182B88430")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> VHLVCFUZBNM(this FunctionCompileState a, int b)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B88970", Offset = "0x2B87770", VA = "0x182B88970")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> XELEKGWNSWV(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B87650", Offset = "0x2B86450", VA = "0x182B87650")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>) RONQUSROTPE(this FunctionCompileState a, Id32<OYXCYVSZNSL> externalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B859F0", Offset = "0x2B847F0", VA = "0x182B859F0")]
		public static (Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>) IVOPVAEGJFW(this FunctionCompileState a, Id32<GQSCCKHWVOV> internalFnId, [In] ReadOnlySpan<Id32<LocalVariables.M>> arguments, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut)
		{
			return default((Id32<FunctionCalls.M>, Id32<FunctionCalls.JBPPZEYKYJG>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C11550", Offset = "0x3C10350", VA = "0x183C11550")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IUBIECDJGSA>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<TMarker>>, Id32<FunctionCalls.M>) EZWGIYNAQNF<TMarker>(this FunctionCompileState a, Id32<IUBIECDJGSA> runtimeFnId, [In] ReadOnlySpan<byte> data)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IUBIECDJGSA>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<TMarker>>, Id32<FunctionCalls.M>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B867D0", Offset = "0x2B855D0", VA = "0x182B867D0")]
		public static Id32<LocalVariables.M> MGCMIKUUOVF(this FunctionCompileState a, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B850C0", Offset = "0x2B83EC0", VA = "0x182B850C0")]
		public static Id32<LocalVariables.M> FJFSEMHPCHK(this FunctionCompileState a, Id32<LocalVariables.M> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B86890", Offset = "0x2B85690", VA = "0x182B86890")]
		public static Id32<LocalVariables.M> MIOIPNLESCZ(this FunctionCompileState a, [In] ReadOnlySpan<byte> from, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B885D0", Offset = "0x2B873D0", VA = "0x182B885D0")]
		public static Id32<LocalVariables.M> VOKSXTHBLOG(this FunctionCompileState a, Id32<LocalVariables.M> from, int b, [Optional] Id32<LocalVariables.M>? to)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B87D10", Offset = "0x2B86B10", VA = "0x182B87D10")]
		public static Id32<LocalVariables.M> SVEMGVTFFLP(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B884B0", Offset = "0x2B872B0", VA = "0x182B884B0")]
		public static Id32<LocalVariables.M> VJTXFPOZDRA(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B86550", Offset = "0x2B85350", VA = "0x182B86550")]
		public static Id32<LocalVariables.M> LWPFBOMUIST(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B85370", Offset = "0x2B84170", VA = "0x182B85370")]
		public static Id32<LocalVariables.M> FVOFLCCKXNJ(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B88110", Offset = "0x2B86F10", VA = "0x182B88110")]
		public static Id32<LocalVariables.M> UBFROIUEOYA(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B849C0", Offset = "0x2B837C0", VA = "0x182B849C0")]
		public static Id32<LocalVariables.M> CVGMZFMKZFL(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B857B0", Offset = "0x2B845B0", VA = "0x182B857B0")]
		public static Id32<LocalVariables.M> IEEICNJQOWY(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B85830", Offset = "0x2B84630", VA = "0x182B85830")]
		public static Id32<LocalVariables.M> IGUNYISFRDB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B874D0", Offset = "0x2B862D0", VA = "0x182B874D0")]
		public static Id32<LocalVariables.M> QFUAXIXBYLY(this FunctionCompileState a, Id32<LocalVariables.M> lhs, Id32<LocalVariables.M> rhs)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B88230", Offset = "0x2B87030", VA = "0x182B88230")]
		public static Id32<LocalVariables.M> ULMTWYGDPJY(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B87260", Offset = "0x2B86060", VA = "0x182B87260")]
		public static Id32<LocalVariables.M> PMRFZPQEWKV(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B87390", Offset = "0x2B86190", VA = "0x182B87390")]
		public static Id32<LocalVariables.M> PWIFBVZUWYA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B87160", Offset = "0x2B85F60", VA = "0x182B87160")]
		public static Id32<LocalVariables.M> PGYRCXZZYZN(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B86A00", Offset = "0x2B85800", VA = "0x182B86A00")]
		public static Id32<LocalVariables.M> MTQPVACTBHO(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B84D20", Offset = "0x2B83B20", VA = "0x182B84D20")]
		public static Id32<LocalVariables.M> ENRPDHLFPSB(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B87FB0", Offset = "0x2B86DB0", VA = "0x182B87FB0")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>> TPGGIZKFHTZ(this FunctionCompileState a)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B88A10", Offset = "0x2B87810", VA = "0x182B88A10")]
		public static Id32<LocalVariables.M> XHGXTUMSTUQ(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B89380", Offset = "0x2B88180", VA = "0x182B89380")]
		public static Id32<LocalVariables.M> ZBTACJZQHUP(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B84F80", Offset = "0x2B83D80", VA = "0x182B84F80")]
		public static Id32<LocalVariables.M> EYUQPPMSOWW(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B84400", Offset = "0x2B83200", VA = "0x182B84400")]
		public static Id32<LocalVariables.M> AKVNOVGYNJM(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B87E10", Offset = "0x2B86C10", VA = "0x182B87E10")]
		public static Id32<LocalVariables.M> SXMSTHUEQCB(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B85470", Offset = "0x2B84270", VA = "0x182B85470")]
		public static Id32<LocalVariables.M> GRILZIPUAQM(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B86440", Offset = "0x2B85240", VA = "0x182B86440")]
		public static Id32<LocalVariables.M> KMKENRMZICJ(this FunctionCompileState a, int b)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B88F30", Offset = "0x2B87D30", VA = "0x182B88F30")]
		public static Id32<LocalVariables.M> YJDPFVNSRYG(this FunctionCompileState a, Id32<LocalVariables.M> value)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B86540", Offset = "0x2B85340", VA = "0x182B86540")]
		public static void KXWDEBSCRJZ(this FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B84600", Offset = "0x2B83400", VA = "0x182B84600")]
		public static Id32<LocalVariables.M> ATOKEPVQLXW(this FunctionCompileState a, float b, float c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B86CC0", Offset = "0x2B85AC0", VA = "0x182B86CC0")]
		public static Id32<LocalVariables.M> NLWTIWFNMQP(this FunctionCompileState a, float b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B88DF0", Offset = "0x2B87BF0", VA = "0x182B88DF0")]
		public static Id32<LocalVariables.M> YJAXLIRIIHY(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B84700", Offset = "0x2B83500", VA = "0x182B84700")]
		public static Id32<LocalVariables.M> BHYKYDUKLTU(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B88B10", Offset = "0x2B87910", VA = "0x182B88B10")]
		public static Id32<LocalVariables.M> XKZMCSRELAN(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B85230", Offset = "0x2B84030", VA = "0x182B85230")]
		public static Id32<LocalVariables.M> FQYMULIRWQA(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B85E90", Offset = "0x2B84C90", VA = "0x182B85E90")]
		public static Id32<LocalVariables.M> IXBQJEQIZCA(this FunctionCompileState a, Id32<DataBackResults.M> leftHandSideId, Id32<DataBackResults.M> rightHandSideId)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B87550", Offset = "0x2B86350", VA = "0x182B87550")]
		public static Id32<LocalVariables.M> QNJLSQSKQBT(this FunctionCompileState a, int b, int c)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B86320", Offset = "0x2B85120", VA = "0x182B86320")]
		public static Id32<LocalVariables.M> JVJGNXLRVDI(this FunctionCompileState a, int b, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B84800", Offset = "0x2B83600", VA = "0x182B84800")]
		public static Id32<LocalVariables.M> BOICWFYUAWT(this FunctionCompileState a, Id32<LocalVariables.M> leftHandSide, Id32<LocalVariables.M> rightHandSide)
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3C12540", Offset = "0x3C11340", VA = "0x183C12540")]
		public static void GVMKBFSRBUW<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<OYXCYVSZNSL> externalFnId, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackResults, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3C12FD0", Offset = "0x3C11DD0", VA = "0x183C12FD0")]
		public static void JLPEDWECTJC<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<GQSCCKHWVOV> function, [In] ReadOnlySpan<Id32<DataBackResults.M>> inputDataBackIds, [In] ReadOnlySpan<int?> returnSizes, [In] Span<Id32<LocalVariables.M>> returnValuesOut, [In] Span<Id32<LocalVariables.M>> returnValueCopiesOut, [In] ReadOnlySpan<Id32<LocalVariables.M>?> existingOutputPortVariables) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3C13AC0", Offset = "0x3C128C0", VA = "0x183C13AC0")]
		public static Id32<LocalVariables.M> LQYBBFKQFXU<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> variable, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3C14490", Offset = "0x3C13290", VA = "0x183C14490")]
		public static Id32<LocalVariables.M> VQMHUWVLVQD<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<DataBackResults.M> dataBackId, [Optional] Id32<LocalVariables.M>? to) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3C11660", Offset = "0x3C10460", VA = "0x183C11660")]
		public static Id32<DataBackResults.M> FJTBXVIMSDG<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, EXZIFHHHFWB<TStateSys> where TStateSys : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3C12CD0", Offset = "0x3C11AD0", VA = "0x183C12CD0")]
		public static Id32<ExecForwardResults.M> IJHRFABWAXB<TDeps, TStateSys>(this FunctionCompileState a, TDeps b, TStateSys c) where TDeps : notnull, EXZIFHHHFWB<TStateSys> where TStateSys : notnull
		{
			return default(Id32<ExecForwardResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B86E60", Offset = "0x2B85C60", VA = "0x182B86E60")]
		public static Id32<DataBackResults.M> ORBLYRXEKXP(this FunctionCompileState a, Id32<DataBackResults.M> argId, IntPtr op_i_r, IntPtr op_r_r)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B840D0", Offset = "0x2B82ED0", VA = "0x182B840D0")]
		public static Id32<DataBackResults.M> AKHENBHHHWD(this FunctionCompileState a, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, IntPtr op_i_i_r, IntPtr op_i_r_r, IntPtr op_r_r_r, bool b)
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3C11970", Offset = "0x3C10770", VA = "0x183C11970")]
		public static Id32<DataBackResults.M> FNHJSBGFURM<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<OYXCYVSZNSL> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d, [Optional] IntPtr op_i_i_i) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3C11B50", Offset = "0x3C10950", VA = "0x183C11B50")]
		private static Id32<DataBackResults.M> FNHJSBGFURM<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<OYXCYVSZNSL> externalCallId, Id32<DataBackResults.M> lhsBackId, Id32<DataBackResults.M> rhsBackId, int? d) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
			return default(Id32<DataBackResults.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3C14040", Offset = "0x3C12E40", VA = "0x183C14040")]
		public static Id32<LocalVariables.M> PLWXDQDDVCG<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, Id32<LocalVariables.M> from, Id32<LocalVariables.M>? to) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
			return default(Id32<LocalVariables.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3C13760", Offset = "0x3C12560", VA = "0x183C13760")]
		public static void KBWRIOLFAZN<TDeps, TState>(this FunctionCompileState a, TDeps b, TState c, int d) where TDeps : notnull, EXZIFHHHFWB<TState> where TState : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct LiveInterval
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<WXKPXITHDLK<VABZENOIJNF>> FirstUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<WXKPXITHDLK<VABZENOIJNF>> LastUse;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
		public LiveInterval(Id32<WXKPXITHDLK<VABZENOIJNF>> firstUse, Id32<WXKPXITHDLK<VABZENOIJNF>> lastUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B817B0", Offset = "0x2B805B0", VA = "0x182B817B0")]
		public static LiveInterval New(Id32<WXKPXITHDLK<VABZENOIJNF>> firstUse)
		{
			return default(LiveInterval);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct LocalVariables
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class LZUDEBLVSOP : SJADMLYUAKY
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
			[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
			public ArgumentInst(Id32<FunctionCalls.M> callId, int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class PTBBHQMCPZX : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CalleeReturnValueInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
			public CalleeReturnValueInst(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class NUHWKFDQOWC : SJADMLYUAKY
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
			[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
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
		public abstract class SJADMLYUAKY
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
			public Id32<SJADMLYUAKY> JoinId;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2B81570", Offset = "0x2B80370", VA = "0x182B81570")]
			public Inst(int? unmanagedSize, [In] LiveInterval liveInterval, Def def, Id32<SJADMLYUAKY> joinId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class OAPJQCNVVVV : SJADMLYUAKY
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct ParameterInst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int Index;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
			public ParameterInst(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal SOAId32Field<M, Inst> _instances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal SOAId32Field<LZUDEBLVSOP, ArgumentInst> _argumentVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal SOAId32Field<NUHWKFDQOWC, CallerReturnValueInst> _callerReturnValueVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal SOAId32Field<OAPJQCNVVVV, ParameterInst> _parameterVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal SOAId32Field<PTBBHQMCPZX, CalleeReturnValueInst> _calleeReturnValueVariables;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B819B0", Offset = "0x2B807B0", VA = "0x182B819B0")]
		private LocalVariables([In] SOAId32Field<M, Inst> instances, [In] SOAId32Field<LZUDEBLVSOP, ArgumentInst> argumentVariables, [In] SOAId32Field<NUHWKFDQOWC, CallerReturnValueInst> callerReturnValueVariables, [In] SOAId32Field<OAPJQCNVVVV, ParameterInst> parameterVariables, [In] SOAId32Field<PTBBHQMCPZX, CalleeReturnValueInst> calleeReturnValueVariables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B817C0", Offset = "0x2B805C0", VA = "0x182B817C0")]
		public static LocalVariables New()
		{
			return default(LocalVariables);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class UFMIWPMHYQM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B89F00", Offset = "0x2B88D00", VA = "0x182B89F00")]
		public static void Destroy(this LocalVariables self)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Passes
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class PYACYBOAGZO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B89640", Offset = "0x2B88440", VA = "0x182B89640")]
		public static void YFLRTADXTVQ(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct AssignRegistersPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal SOAField<FunctionCalls.JBPPZEYKYJG, FunctionCallRegisterOffsets> _functionCallRegisterOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal int _startOfManagedCallSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal int _startOfUnmanagedCallSection;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B7FFC0", Offset = "0x2B7EDC0", VA = "0x182B7FFC0")]
		private AssignRegistersPass([In] SOAField<FunctionCalls.JBPPZEYKYJG, FunctionCallRegisterOffsets> functionCallRegisterOffsets, int startOfManagedCallSection, int startOfUnanagedCallSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7FF50", Offset = "0x2B7ED50", VA = "0x182B7FF50")]
		public static AssignRegistersPass New()
		{
			return default(AssignRegistersPass);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B7FD30", Offset = "0x2B7EB30", VA = "0x182B7FD30")]
		public void Destroy([In] FunctionCompileState ctx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x368A1A0", Offset = "0x3688FA0", VA = "0x18368A1A0")]
		public static void YFLRTADXTVQ<TDeps, TStateSys>(FunctionCompileState a, TDeps b, TStateSys c, Id32<VFKNGTPUEMY> graphId) where TDeps : notnull, EXZIFHHHFWB<TStateSys> where TStateSys : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class KTCFINWVMKV
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B81590", Offset = "0x2B80390", VA = "0x182B81590")]
		public static void YFLRTADXTVQ(FunctionCompileState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InsertOffsetManagedObjectStackCallsPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private interface DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void QJYEQNDSTIV(UnsafeList<byte> a, int b);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private readonly struct ProcessCallInternal_I32i_I32i : DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2B898E0", Offset = "0x2B886E0", VA = "0x182B898E0", Slot = "4")]
			public void QJYEQNDSTIV(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private readonly struct ProcessCallInternal_I32i_I32r : DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2B89970", Offset = "0x2B88770", VA = "0x182B89970", Slot = "4")]
			public void QJYEQNDSTIV(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct ProcessCallExternal_I32i_I32i : DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2B897A0", Offset = "0x2B885A0", VA = "0x182B897A0", Slot = "4")]
			public void QJYEQNDSTIV(UnsafeList<byte> a, int b)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private readonly struct ProcessCallExternal_I32i_I32r : DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2B89830", Offset = "0x2B88630", VA = "0x182B89830", Slot = "4")]
			public void QJYEQNDSTIV(UnsafeList<byte> a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class SUAUUQZUCGQ<c> where c : struct, DZZVBOJAEDU
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly c BJEOXILCYDG;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3E459C0", Offset = "0x3E447C0", VA = "0x183E459C0")]
			public static int YFLRTADXTVQ<b, a>(b a, a b, FunctionCompileState c, [In] UnsafeList<byte> fromByteCode, int d) where b : EXZIFHHHFWB<a>
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private UnsafeList<ByteCodeAdjustment> _byteCodeAdjustments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<FunctionCalls.JBPPZEYKYJG>> _ioCallsByAddress;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B81520", Offset = "0x2B80320", VA = "0x182B81520")]
		private InsertOffsetManagedObjectStackCallsPass([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, Dictionary<Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<FunctionCalls.JBPPZEYKYJG>> ioCallsByAddress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B81470", Offset = "0x2B80270", VA = "0x182B81470")]
		public static InsertOffsetManagedObjectStackCallsPass New()
		{
			return default(InsertOffsetManagedObjectStackCallsPass);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B81430", Offset = "0x2B80230", VA = "0x182B81430")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B37BB0", Offset = "0x3B369B0", VA = "0x183B37BB0")]
		public static void YFLRTADXTVQ<b, a>(FunctionCompileState a, b b, a c) where b : EXZIFHHHFWB<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class ZUSBMIAUGOG
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
		private static int TGPRTTMIKRK;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int VBJIUOHZHES;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A7D0", Offset = "0x2B895D0", VA = "0x182B8A7D0")]
		public static void YFLRTADXTVQ(FunctionCompileState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A460", Offset = "0x2B89260", VA = "0x182B8A460")]
		private static void FGUJHLNHJDJ([In] FunctionCompileState self, Id32<LocalVariables.M> id, UnsafeList<byte> a, List<QueuedWrite> queuedWrites)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A320", Offset = "0x2B89120", VA = "0x182B8A320")]
		private static void FGUJHLNHJDJ(UnsafeList<byte> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A670", Offset = "0x2B89470", VA = "0x182B8A670")]
		private static void VMPSASQABNO(FunctionCompileState a, List<QueuedWrite> b)
		{
		}
	}
}
namespace Circuits.Static.Core.CompileSystem.Helpers
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class LLHWVGBMEHY<a, b, c> where a : struct, KFITFPEAZWY<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly a BJEOXILCYDG;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x68BA840", Offset = "0x68B9640", VA = "0x1868BA840")]
		public static void YFLRTADXTVQ([In] UnsafeList<ByteCodeAdjustment> byteCodeAdjustments, int a, c b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface KFITFPEAZWY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UnsafeList<a> GWRKSQGDBQS(int a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SJJLUJOAAPQ(a a, b b, Id32<WXKPXITHDLK<WFSWBPUBAOK>> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface FCHXAOXANFH<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a KECGMKFBPXL(int a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FNGNUPUAPOT(a a, [In] b values);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Id32<WXKPXITHDLK<WFSWBPUBAOK>> WVZBKHIXNOC(a a, [In] b values);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class HBZTXIWYOAD<a, b, c> where a : struct, FCHXAOXANFH<b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly a BJEOXILCYDG;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x64612F0", Offset = "0x64600F0", VA = "0x1864612F0")]
		public static UnsafeList<b> YFLRTADXTVQ(int a, [In] c values)
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
