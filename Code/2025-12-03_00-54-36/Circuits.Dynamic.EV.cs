using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Dynamic.Api;
using Circuits.Shared.Api;
using Circuits.Shared.Core.ByteCode;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
}
namespace Circuits.Dynamic.EV
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct Evvm
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const int MaxInstructionsToRun = 100000;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly ReadOnlyIdArray<IMGRICEYMPU<EJGGWQPBGFS>, byte> EndHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<HDOGPWGYNWD> InternalFnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<IMGRICEYMPU<EJGGWQPBGFS>> InstructionPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<IMAAHXSZDBK<EJGGWQPBGFS>> RegisterPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IdArray<IMAAHXSZDBK<EJGGWQPBGFS>, byte> _registers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly IdArray<IMAAHXSZDBK<EJGGWQPBGFS>, byte> CPAHJILOAJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			get
			{
				return default(IdArray<IMAAHXSZDBK<EJGGWQPBGFS>, byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2894BE0", Offset = "0x28937E0", VA = "0x182894BE0")]
		private static ReadOnlyIdArray<IMGRICEYMPU<EJGGWQPBGFS>, byte> FCUCZZTIOCE()
		{
			return default(ReadOnlyIdArray<IMGRICEYMPU<EJGGWQPBGFS>, byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28953F0", Offset = "0x2893FF0", VA = "0x1828953F0")]
		private Evvm(Id32<HDOGPWGYNWD> internalFnPtr, Id32<IMGRICEYMPU<EJGGWQPBGFS>> instructionPtr, Id32<IMAAHXSZDBK<EJGGWQPBGFS>> registerPtr, IdArray<IMAAHXSZDBK<EJGGWQPBGFS>, byte> registers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2894FC0", Offset = "0x2893BC0", VA = "0x182894FC0")]
		public static Evvm New()
		{
			return default(Evvm);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2891980", Offset = "0x2890580", VA = "0x182891980")]
		public bool ANZCKOBQEJE(int a = 1024000)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2894C90", Offset = "0x2893890", VA = "0x182894C90")]
		public void IPTENGKGMPM(Id32<HDOGPWGYNWD> internalFn, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28950F0", Offset = "0x2893CF0", VA = "0x1828950F0")]
		public void SSREQBLPEHS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2894AD0", Offset = "0x28936D0", VA = "0x182894AD0")]
		public void BSJSXIIZGQA([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, [In] ReadOnlyIdSpan<HDOGPWGYNWD, ReadOnlyIdArray<IMGRICEYMPU<EJGGWQPBGFS>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2891A20", Offset = "0x2890620", VA = "0x182891A20")]
		public static void BSJSXIIZGQA([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, Id32<HDOGPWGYNWD> internalFnPtr, Id32<IMGRICEYMPU<EJGGWQPBGFS>> instructionPtr, Id32<IMAAHXSZDBK<EJGGWQPBGFS>> registerPtr, [In] IdSpan<IMAAHXSZDBK<EJGGWQPBGFS>, byte> registers, [In] ReadOnlyIdSpan<HDOGPWGYNWD, ReadOnlyIdArray<IMGRICEYMPU<EJGGWQPBGFS>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
		{
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
