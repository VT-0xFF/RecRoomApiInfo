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
}
namespace Circuits.Dynamic.EV
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct Evvm
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const int MaxInstructionsToRun = 100000;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly ReadOnlyIdArray<DNQUXCYLSXY<WBZFYOYOFGY>, byte> EndHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<JQFETOMIQRN> InternalFnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<DNQUXCYLSXY<WBZFYOYOFGY>> InstructionPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<ASDRXZXCACQ<WBZFYOYOFGY>> RegisterPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IdArray<ASDRXZXCACQ<WBZFYOYOFGY>, byte> _registers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly IdArray<ASDRXZXCACQ<WBZFYOYOFGY>, byte> NIMHCHMNZXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			get
			{
				return default(IdArray<ASDRXZXCACQ<WBZFYOYOFGY>, byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28A4030", Offset = "0x28A2830", VA = "0x1828A4030")]
		private static ReadOnlyIdArray<DNQUXCYLSXY<WBZFYOYOFGY>, byte> NJBISGVDQKA()
		{
			return default(ReadOnlyIdArray<DNQUXCYLSXY<WBZFYOYOFGY>, byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28A77F0", Offset = "0x28A5FF0", VA = "0x1828A77F0")]
		private Evvm(Id32<JQFETOMIQRN> internalFnPtr, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> instructionPtr, Id32<ASDRXZXCACQ<WBZFYOYOFGY>> registerPtr, IdArray<ASDRXZXCACQ<WBZFYOYOFGY>, byte> registers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28A40E0", Offset = "0x28A28E0", VA = "0x1828A40E0")]
		public static Evvm New()
		{
			return default(Evvm);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28A3F90", Offset = "0x28A2790", VA = "0x1828A3F90")]
		public bool GDYISUGOLVU(int a = 1024000)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28A4210", Offset = "0x28A2A10", VA = "0x1828A4210")]
		public void RPLWDEXYNKO(Id32<JQFETOMIQRN> internalFn, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28A3D90", Offset = "0x28A2590", VA = "0x1828A3D90")]
		public void CDRNPHFZKTO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28A75F0", Offset = "0x28A5DF0", VA = "0x1828A75F0")]
		public void UGAONVMMAWY([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, [In] ReadOnlyIdSpan<JQFETOMIQRN, ReadOnlyIdArray<DNQUXCYLSXY<WBZFYOYOFGY>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28A4540", Offset = "0x28A2D40", VA = "0x1828A4540")]
		public static void UGAONVMMAWY([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, Id32<JQFETOMIQRN> internalFnPtr, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> instructionPtr, Id32<ASDRXZXCACQ<WBZFYOYOFGY>> registerPtr, [In] IdSpan<ASDRXZXCACQ<WBZFYOYOFGY>, byte> registers, [In] ReadOnlyIdSpan<JQFETOMIQRN, ReadOnlyIdArray<DNQUXCYLSXY<WBZFYOYOFGY>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
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
