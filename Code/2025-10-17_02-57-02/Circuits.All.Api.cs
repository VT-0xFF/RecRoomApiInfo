using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.All.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct DebugExecutionResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly DebugExecutionResultData Data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly DebugExecutionResultKind Kind;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A788D0", Offset = "0x2A76ED0", VA = "0x182A788D0")]
		private DebugExecutionResult([In] DebugExecutionResultData data, DebugExecutionResultKind debugExecutionResultKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A788A0", Offset = "0x2A76EA0", VA = "0x182A788A0")]
		public static DebugExecutionResult TYHCFVVRHYA([In] Id128<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<RSMVXMQQIAP> inputIndex)
		{
			return default(DebugExecutionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A78870", Offset = "0x2A76E70", VA = "0x182A78870")]
		public static DebugExecutionResult JZORUXTVRMZ([In] Id128<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<EKZRYTEBJRU> outputIndex)
		{
			return default(DebugExecutionResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct DebugExecutionResultCompleteAtInputData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly Id128<BZFRCGZKOVF> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly Id32<QKZKTYBWUBB> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly Id32<RSMVXMQQIAP> InputIndex;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A78840", Offset = "0x2A76E40", VA = "0x182A78840")]
		internal DebugExecutionResultCompleteAtInputData([In] Id128<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<RSMVXMQQIAP> inputIndex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct DebugExecutionResultCompleteAtOutputData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Id128<BZFRCGZKOVF> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Id32<QKZKTYBWUBB> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly Id32<EKZRYTEBJRU> OutputIndex;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A78840", Offset = "0x2A76E40", VA = "0x182A78840")]
		internal DebugExecutionResultCompleteAtOutputData([In] Id128<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<EKZRYTEBJRU> outputIndex)
		{
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct DebugExecutionResultData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly DebugExecutionResultCompleteAtInputData CompleteAtInputData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly DebugExecutionResultCompleteAtOutputData CompleteAtOutputData;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2A78850", Offset = "0x2A76E50", VA = "0x182A78850")]
		internal DebugExecutionResultData([In] DebugExecutionResultCompleteAtInputData completeAtInputData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2A78850", Offset = "0x2A76E50", VA = "0x182A78850")]
		internal DebugExecutionResultData([In] DebugExecutionResultCompleteAtOutputData completeAtOutputData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum DebugExecutionResultKind
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		ExecutionCompleteAtInput,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		ExecutionCompleteAtOutput
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface FUCNVLLMCPQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		FQWDVUUVPYF? ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface FQWDVUUVPYF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Result<DebugExecutionResult, RNJMJJJPABV> KWZLXZSSWIC(Id128<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<RSMVXMQQIAP> inputId);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Result<DebugExecutionResult, RNJMJJJPABV> OULZXHJNGCV(Id128<BZFRCGZKOVF> nodeId, Id32<QKZKTYBWUBB> portGroupId, Id32<EKZRYTEBJRU> outputId);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface RNJMJJJPABV : OYBEQJHIRPM
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id128<BZFRCGZKOVF>? ZXJRKCACYKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
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
