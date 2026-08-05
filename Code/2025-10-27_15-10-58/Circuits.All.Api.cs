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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AEE690", Offset = "0x2AED690", VA = "0x182AEE690")]
		private DebugExecutionResult([In] DebugExecutionResultData data, DebugExecutionResultKind debugExecutionResultKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE630", Offset = "0x2AED630", VA = "0x182AEE630")]
		public static DebugExecutionResult IJOXNVFOZER([In] Id128<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<JVDRBUQTLFY> inputIndex)
		{
			return default(DebugExecutionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE660", Offset = "0x2AED660", VA = "0x182AEE660")]
		public static DebugExecutionResult UFSXZCFJVVU([In] Id128<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<XCMFJIKKBWV> outputIndex)
		{
			return default(DebugExecutionResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct DebugExecutionResultCompleteAtInputData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly Id128<GOPNEBMAEKM> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly Id32<MMFHTWDPFRA> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly Id32<JVDRBUQTLFY> InputIndex;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE600", Offset = "0x2AED600", VA = "0x182AEE600")]
		internal DebugExecutionResultCompleteAtInputData([In] Id128<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<JVDRBUQTLFY> inputIndex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct DebugExecutionResultCompleteAtOutputData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Id128<GOPNEBMAEKM> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Id32<MMFHTWDPFRA> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly Id32<XCMFJIKKBWV> OutputIndex;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE600", Offset = "0x2AED600", VA = "0x182AEE600")]
		internal DebugExecutionResultCompleteAtOutputData([In] Id128<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<XCMFJIKKBWV> outputIndex)
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
		[Cpp2IlInjected.Address(RVA = "0x2AEE610", Offset = "0x2AED610", VA = "0x182AEE610")]
		internal DebugExecutionResultData([In] DebugExecutionResultCompleteAtInputData completeAtInputData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE610", Offset = "0x2AED610", VA = "0x182AEE610")]
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
	public interface GGGEADYYYIT
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		MIWITNJLDRS? HNQVBJEYTYC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface MIWITNJLDRS
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Result<DebugExecutionResult, XNAQAPEZRTQ> STOTFNKXUNV(Id128<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<JVDRBUQTLFY> inputId);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Result<DebugExecutionResult, XNAQAPEZRTQ> AGSFKTQJVOK(Id128<GOPNEBMAEKM> nodeId, Id32<MMFHTWDPFRA> portGroupId, Id32<XCMFJIKKBWV> outputId);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface XNAQAPEZRTQ : TBKCGNLOMPR
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id128<GOPNEBMAEKM>? VBQUCLXVVJH
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
