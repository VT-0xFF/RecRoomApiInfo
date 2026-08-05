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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		public static readonly ReadOnlyIdArray<BMUDIFIQDFI<JRUSPVYOFZC>, byte> EndHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<JVDVMJBLEIH> InternalFnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<BMUDIFIQDFI<JRUSPVYOFZC>> InstructionPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<GZQXHQYHYRK<JRUSPVYOFZC>> RegisterPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IdArray<GZQXHQYHYRK<JRUSPVYOFZC>, byte> _registers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly IdArray<GZQXHQYHYRK<JRUSPVYOFZC>, byte> RMPZIVWIYLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return default(IdArray<GZQXHQYHYRK<JRUSPVYOFZC>, byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28CB7A0", Offset = "0x28C9FA0", VA = "0x1828CB7A0")]
		private static ReadOnlyIdArray<BMUDIFIQDFI<JRUSPVYOFZC>, byte> QKPQEYJOFAQ()
		{
			return default(ReadOnlyIdArray<BMUDIFIQDFI<JRUSPVYOFZC>, byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28CEE30", Offset = "0x28CD630", VA = "0x1828CEE30")]
		private Evvm(Id32<JVDVMJBLEIH> internalFnPtr, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> instructionPtr, Id32<GZQXHQYHYRK<JRUSPVYOFZC>> registerPtr, IdArray<GZQXHQYHYRK<JRUSPVYOFZC>, byte> registers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28CB470", Offset = "0x28C9C70", VA = "0x1828CB470")]
		public static Evvm New()
		{
			return default(Evvm);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28CB3D0", Offset = "0x28C9BD0", VA = "0x1828CB3D0")]
		public bool GTAZIUIBAWG(int a = 1024000)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28CB850", Offset = "0x28CA050", VA = "0x1828CB850")]
		public void SMMGHHRPFXM(Id32<JVDVMJBLEIH> internalFn, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28CB5A0", Offset = "0x28C9DA0", VA = "0x1828CB5A0")]
		public void ODCBNWFURXK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28CEC30", Offset = "0x28CD430", VA = "0x1828CEC30")]
		public void WCEBZPFQAIM([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, [In] ReadOnlyIdSpan<JVDVMJBLEIH, ReadOnlyIdArray<BMUDIFIQDFI<JRUSPVYOFZC>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28CBB80", Offset = "0x28CA380", VA = "0x1828CBB80")]
		public static void WCEBZPFQAIM([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, Id32<JVDVMJBLEIH> internalFnPtr, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> instructionPtr, Id32<GZQXHQYHYRK<JRUSPVYOFZC>> registerPtr, [In] IdSpan<GZQXHQYHYRK<JRUSPVYOFZC>, byte> registers, [In] ReadOnlyIdSpan<JVDVMJBLEIH, ReadOnlyIdArray<BMUDIFIQDFI<JRUSPVYOFZC>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
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
