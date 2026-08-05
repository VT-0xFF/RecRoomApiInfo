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
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		public static readonly ReadOnlyIdArray<WXKPXITHDLK<WFSWBPUBAOK>, byte> EndHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<GQSCCKHWVOV> InternalFnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<WXKPXITHDLK<WFSWBPUBAOK>> InstructionPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<IXKHGZWDMFU<WFSWBPUBAOK>> RegisterPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IdArray<IXKHGZWDMFU<WFSWBPUBAOK>, byte> _registers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly IdArray<IXKHGZWDMFU<WFSWBPUBAOK>, byte> WTWJWSDZIRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return default(IdArray<IXKHGZWDMFU<WFSWBPUBAOK>, byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F490", Offset = "0x2B5E290", VA = "0x182B5F490")]
		private static ReadOnlyIdArray<WXKPXITHDLK<WFSWBPUBAOK>, byte> JHLEVUGCBBQ()
		{
			return default(ReadOnlyIdArray<WXKPXITHDLK<WFSWBPUBAOK>, byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B62B30", Offset = "0x2B61930", VA = "0x182B62B30")]
		private Evvm(Id32<GQSCCKHWVOV> internalFnPtr, Id32<WXKPXITHDLK<WFSWBPUBAOK>> instructionPtr, Id32<IXKHGZWDMFU<WFSWBPUBAOK>> registerPtr, IdArray<IXKHGZWDMFU<WFSWBPUBAOK>, byte> registers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F740", Offset = "0x2B5E540", VA = "0x182B5F740")]
		public static Evvm New()
		{
			return default(Evvm);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F3F0", Offset = "0x2B5E1F0", VA = "0x182B5F3F0")]
		public bool FBJCURGPKQE(int a = 1024000)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F0C0", Offset = "0x2B5DEC0", VA = "0x182B5F0C0")]
		public void DJGLMHVBZYM(Id32<GQSCCKHWVOV> internalFn, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F540", Offset = "0x2B5E340", VA = "0x182B5F540")]
		public void LVSMVTZOBCO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F870", Offset = "0x2B5E670", VA = "0x182B5F870")]
		public void YFLRTADXTVQ([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, [In] ReadOnlyIdSpan<GQSCCKHWVOV, ReadOnlyIdArray<WXKPXITHDLK<WFSWBPUBAOK>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F980", Offset = "0x2B5E780", VA = "0x182B5F980")]
		public static void YFLRTADXTVQ([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, Id32<GQSCCKHWVOV> internalFnPtr, Id32<WXKPXITHDLK<WFSWBPUBAOK>> instructionPtr, Id32<IXKHGZWDMFU<WFSWBPUBAOK>> registerPtr, [In] IdSpan<IXKHGZWDMFU<WFSWBPUBAOK>, byte> registers, [In] ReadOnlyIdSpan<GQSCCKHWVOV, ReadOnlyIdArray<WXKPXITHDLK<WFSWBPUBAOK>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
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
