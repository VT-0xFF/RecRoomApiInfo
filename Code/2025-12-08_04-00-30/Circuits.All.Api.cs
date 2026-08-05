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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x282D760", Offset = "0x282BF60", VA = "0x18282D760")]
		private DebugExecutionResult([In] DebugExecutionResultData data, DebugExecutionResultKind debugExecutionResultKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x282D730", Offset = "0x282BF30", VA = "0x18282D730")]
		public static DebugExecutionResult PWNGRZRCMKH([In] Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ROIJDLVWFAY> inputIndex)
		{
			return default(DebugExecutionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x282D700", Offset = "0x282BF00", VA = "0x18282D700")]
		public static DebugExecutionResult IQXJADFYSGQ([In] Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ACVPQTFYCHZ> outputIndex)
		{
			return default(DebugExecutionResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct DebugExecutionResultCompleteAtInputData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly Id128<XEUKGISKBDU> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly Id32<MZMEHEUCWDG> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly Id32<ROIJDLVWFAY> InputIndex;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x282D6D0", Offset = "0x282BED0", VA = "0x18282D6D0")]
		internal DebugExecutionResultCompleteAtInputData([In] Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ROIJDLVWFAY> inputIndex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct DebugExecutionResultCompleteAtOutputData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Id128<XEUKGISKBDU> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Id32<MZMEHEUCWDG> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly Id32<ACVPQTFYCHZ> OutputIndex;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x282D6D0", Offset = "0x282BED0", VA = "0x18282D6D0")]
		internal DebugExecutionResultCompleteAtOutputData([In] Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ACVPQTFYCHZ> outputIndex)
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
		[Cpp2IlInjected.Address(RVA = "0x282D6E0", Offset = "0x282BEE0", VA = "0x18282D6E0")]
		internal DebugExecutionResultData([In] DebugExecutionResultCompleteAtInputData completeAtInputData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x282D6E0", Offset = "0x282BEE0", VA = "0x18282D6E0")]
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
	public interface QJOFFGEQHGF
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		BZVURPLYZAG? GUPHEVFTUDK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface BZVURPLYZAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Result<DebugExecutionResult, KFAYAJBOPHW> ONRJAVVHGKZ(Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ROIJDLVWFAY> inputId);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Result<DebugExecutionResult, KFAYAJBOPHW> THJIESGWWSQ(Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ACVPQTFYCHZ> outputId);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface KFAYAJBOPHW : PWKRFVXRRZL
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id128<XEUKGISKBDU>? SMMBIYSPPXZ
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
