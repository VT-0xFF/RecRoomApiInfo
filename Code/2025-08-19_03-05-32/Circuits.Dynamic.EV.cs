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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		public static readonly ReadOnlyIdArray<DXZFAYBWXNM<NLAXFVYHLZG>, byte> EndHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<RFIESXCFEKH> InternalFnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<DXZFAYBWXNM<NLAXFVYHLZG>> InstructionPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<CIAGZBHOAUA<NLAXFVYHLZG>> RegisterPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IdArray<CIAGZBHOAUA<NLAXFVYHLZG>, byte> _registers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly IdArray<CIAGZBHOAUA<NLAXFVYHLZG>, byte> IYDKSEMEQZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			get
			{
				return default(IdArray<CIAGZBHOAUA<NLAXFVYHLZG>, byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2AD1E70", Offset = "0x2AD0C70", VA = "0x182AD1E70")]
		private static ReadOnlyIdArray<DXZFAYBWXNM<NLAXFVYHLZG>, byte> AGRFHJIPKFO()
		{
			return default(ReadOnlyIdArray<DXZFAYBWXNM<NLAXFVYHLZG>, byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AD58D0", Offset = "0x2AD46D0", VA = "0x182AD58D0")]
		private Evvm(Id32<RFIESXCFEKH> internalFnPtr, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> instructionPtr, Id32<CIAGZBHOAUA<NLAXFVYHLZG>> registerPtr, IdArray<CIAGZBHOAUA<NLAXFVYHLZG>, byte> registers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2450", Offset = "0x2AD1250", VA = "0x182AD2450")]
		public static Evvm New()
		{
			return default(Evvm);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5740", Offset = "0x2AD4540", VA = "0x182AD5740")]
		public bool WXFKOSPZVBY(int a = 1024000)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AD1F20", Offset = "0x2AD0D20", VA = "0x182AD1F20")]
		public void BSQDGCFTXCK(Id32<RFIESXCFEKH> internalFn, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2250", Offset = "0x2AD1050", VA = "0x182AD2250")]
		public void NNMFGKXLNYE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2580", Offset = "0x2AD1380", VA = "0x182AD2580")]
		public void SMBNSVPWLRK([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, [In] ReadOnlyIdSpan<RFIESXCFEKH, ReadOnlyIdArray<DXZFAYBWXNM<NLAXFVYHLZG>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2690", Offset = "0x2AD1490", VA = "0x182AD2690")]
		public static void SMBNSVPWLRK([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, Id32<RFIESXCFEKH> internalFnPtr, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> instructionPtr, Id32<CIAGZBHOAUA<NLAXFVYHLZG>> registerPtr, [In] IdSpan<CIAGZBHOAUA<NLAXFVYHLZG>, byte> registers, [In] ReadOnlyIdSpan<RFIESXCFEKH, ReadOnlyIdArray<DXZFAYBWXNM<NLAXFVYHLZG>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
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
