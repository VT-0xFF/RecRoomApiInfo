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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		public static readonly ReadOnlyIdArray<FXJTAPCMHIX<VVFCXQSNTUF>, byte> EndHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<RPGMTDOAAUE> InternalFnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<FXJTAPCMHIX<VVFCXQSNTUF>> InstructionPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<DLSISDAFEUV<VVFCXQSNTUF>> RegisterPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IdArray<DLSISDAFEUV<VVFCXQSNTUF>, byte> _registers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly IdArray<DLSISDAFEUV<VVFCXQSNTUF>, byte> OYQNZXFINOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			get
			{
				return default(IdArray<DLSISDAFEUV<VVFCXQSNTUF>, byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28AC920", Offset = "0x28ABD20", VA = "0x1828AC920")]
		private static ReadOnlyIdArray<FXJTAPCMHIX<VVFCXQSNTUF>, byte> JVJMAVOOWKJ()
		{
			return default(ReadOnlyIdArray<FXJTAPCMHIX<VVFCXQSNTUF>, byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE90", Offset = "0x28AC290", VA = "0x1828ACE90")]
		private Evvm(Id32<RPGMTDOAAUE> internalFnPtr, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> instructionPtr, Id32<DLSISDAFEUV<VVFCXQSNTUF>> registerPtr, IdArray<DLSISDAFEUV<VVFCXQSNTUF>, byte> registers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28ACA70", Offset = "0x28ABE70", VA = "0x1828ACA70")]
		public static Evvm New()
		{
			return default(Evvm);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28AC9D0", Offset = "0x28ABDD0", VA = "0x1828AC9D0")]
		public bool MVZEBMUUCVF(int a = 1024000)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28A9430", Offset = "0x28A8830", VA = "0x1828A9430")]
		public void CALEQRYDXHP(Id32<RPGMTDOAAUE> internalFn, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28ACBA0", Offset = "0x28ABFA0", VA = "0x1828ACBA0")]
		public void WVGTARAZPYJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28AC810", Offset = "0x28ABC10", VA = "0x1828AC810")]
		public void EKQJYIVBPEX([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, [In] ReadOnlyIdSpan<RPGMTDOAAUE, ReadOnlyIdArray<FXJTAPCMHIX<VVFCXQSNTUF>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28A9760", Offset = "0x28A8B60", VA = "0x1828A9760")]
		public static void EKQJYIVBPEX([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, Id32<RPGMTDOAAUE> internalFnPtr, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> instructionPtr, Id32<DLSISDAFEUV<VVFCXQSNTUF>> registerPtr, [In] IdSpan<DLSISDAFEUV<VVFCXQSNTUF>, byte> registers, [In] ReadOnlyIdSpan<RPGMTDOAAUE, ReadOnlyIdArray<FXJTAPCMHIX<VVFCXQSNTUF>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
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
