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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		public static readonly ReadOnlyIdArray<URLPKZCBIQI<PCOBNQTLDEG>, byte> EndHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<KZBLUFSWXZT> InternalFnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<URLPKZCBIQI<PCOBNQTLDEG>> InstructionPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<NZMKZPVTOGO<PCOBNQTLDEG>> RegisterPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IdArray<NZMKZPVTOGO<PCOBNQTLDEG>, byte> _registers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly IdArray<NZMKZPVTOGO<PCOBNQTLDEG>, byte> LBKARJCWIPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return default(IdArray<NZMKZPVTOGO<PCOBNQTLDEG>, byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2DC08E0", Offset = "0x2DBF4E0", VA = "0x182DC08E0")]
		private static ReadOnlyIdArray<URLPKZCBIQI<PCOBNQTLDEG>, byte> OWJUWLKFUYS()
		{
			return default(ReadOnlyIdArray<URLPKZCBIQI<PCOBNQTLDEG>, byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3E50", Offset = "0x2DC2A50", VA = "0x182DC3E50")]
		private Evvm(Id32<KZBLUFSWXZT> internalFnPtr, Id32<URLPKZCBIQI<PCOBNQTLDEG>> instructionPtr, Id32<NZMKZPVTOGO<PCOBNQTLDEG>> registerPtr, IdArray<NZMKZPVTOGO<PCOBNQTLDEG>, byte> registers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2DC07B0", Offset = "0x2DBF3B0", VA = "0x182DC07B0")]
		public static Evvm New()
		{
			return default(Evvm);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2DC03E0", Offset = "0x2DBEFE0", VA = "0x182DC03E0")]
		public bool KDLUNBSUFTG(int a = 1024000)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2DC0480", Offset = "0x2DBF080", VA = "0x182DC0480")]
		public void KTNLDDXBFTS(Id32<KZBLUFSWXZT> internalFn, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3B50", Offset = "0x2DC2750", VA = "0x182DC3B50")]
		public void SBJHABZEWMC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2DC0990", Offset = "0x2DBF590", VA = "0x182DC0990")]
		public void Run([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr ctx, [In] ReadOnlyIdSpan<KZBLUFSWXZT, ReadOnlyIdArray<URLPKZCBIQI<PCOBNQTLDEG>, byte>> internalFns, RuntimeFns runtimeFns, ExternalFns externalFns, DynamicCircuitsErrDefs dynamicCircuitsErrDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2DC0AA0", Offset = "0x2DBF6A0", VA = "0x182DC0AA0")]
		public static void Run([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr ctx, Id32<KZBLUFSWXZT> internalFnPtr, Id32<URLPKZCBIQI<PCOBNQTLDEG>> instructionPtr, Id32<NZMKZPVTOGO<PCOBNQTLDEG>> registerPtr, [In] IdSpan<NZMKZPVTOGO<PCOBNQTLDEG>, byte> registers, [In] ReadOnlyIdSpan<KZBLUFSWXZT, ReadOnlyIdArray<URLPKZCBIQI<PCOBNQTLDEG>, byte>> internalFns, RuntimeFns runtimeFns, ExternalFns externalFns, DynamicCircuitsErrDefs dynamicCircuitsErrDefs)
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
