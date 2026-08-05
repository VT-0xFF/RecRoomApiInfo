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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		public static readonly ReadOnlyIdArray<GAIDVDAKGEP<JPZFXDVMDNP>, byte> EndHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<BHDVXGKWBTW> InternalFnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<GAIDVDAKGEP<JPZFXDVMDNP>> InstructionPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<WHMLTPZNLLH<JPZFXDVMDNP>> RegisterPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IdArray<WHMLTPZNLLH<JPZFXDVMDNP>, byte> _registers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly IdArray<WHMLTPZNLLH<JPZFXDVMDNP>, byte> GPGTUGBDMVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return default(IdArray<WHMLTPZNLLH<JPZFXDVMDNP>, byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B5B0", Offset = "0x2B6A9B0", VA = "0x182B6B5B0")]
		private static ReadOnlyIdArray<GAIDVDAKGEP<JPZFXDVMDNP>, byte> JRDVKYEUHXH()
		{
			return default(ReadOnlyIdArray<GAIDVDAKGEP<JPZFXDVMDNP>, byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B6ECE0", Offset = "0x2B6E0E0", VA = "0x182B6ECE0")]
		private Evvm(Id32<BHDVXGKWBTW> internalFnPtr, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> instructionPtr, Id32<WHMLTPZNLLH<JPZFXDVMDNP>> registerPtr, IdArray<WHMLTPZNLLH<JPZFXDVMDNP>, byte> registers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EAC0", Offset = "0x2B6DEC0", VA = "0x182B6EAC0")]
		public static Evvm New()
		{
			return default(Evvm);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B660", Offset = "0x2B6AA60", VA = "0x182B6B660")]
		public bool KFFSXCOXJUH(int a = 1024000)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B280", Offset = "0x2B6A680", VA = "0x182B6B280")]
		public void GKSKOQNDSKB(Id32<BHDVXGKWBTW> internalFn, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E8C0", Offset = "0x2B6DCC0", VA = "0x182B6E8C0")]
		public void MKGNZJAONTP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E7B0", Offset = "0x2B6DBB0", VA = "0x182B6E7B0")]
		public void KJOHUMGZAWL([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, [In] ReadOnlyIdSpan<BHDVXGKWBTW, ReadOnlyIdArray<GAIDVDAKGEP<JPZFXDVMDNP>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B700", Offset = "0x2B6AB00", VA = "0x182B6B700")]
		public static void KJOHUMGZAWL([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, Id32<BHDVXGKWBTW> internalFnPtr, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> instructionPtr, Id32<WHMLTPZNLLH<JPZFXDVMDNP>> registerPtr, [In] IdSpan<WHMLTPZNLLH<JPZFXDVMDNP>, byte> registers, [In] ReadOnlyIdSpan<BHDVXGKWBTW, ReadOnlyIdArray<GAIDVDAKGEP<JPZFXDVMDNP>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
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
