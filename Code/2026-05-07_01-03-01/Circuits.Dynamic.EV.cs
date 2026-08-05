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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		public static readonly ReadOnlyIdArray<TVAMPUAMYRD<RTIMFYESSKP>, byte> EndHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<AUNNIJUAVXE> InternalFnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<TVAMPUAMYRD<RTIMFYESSKP>> InstructionPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<XSPVEGMZPQH<RTIMFYESSKP>> RegisterPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IdArray<XSPVEGMZPQH<RTIMFYESSKP>, byte> _registers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly IdArray<XSPVEGMZPQH<RTIMFYESSKP>, byte> BKNJSPSHQCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			get
			{
				return default(IdArray<XSPVEGMZPQH<RTIMFYESSKP>, byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B69270", Offset = "0x2B67C70", VA = "0x182B69270")]
		private static ReadOnlyIdArray<TVAMPUAMYRD<RTIMFYESSKP>, byte> EYVHVGQULCD()
		{
			return default(ReadOnlyIdArray<TVAMPUAMYRD<RTIMFYESSKP>, byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B697F0", Offset = "0x2B681F0", VA = "0x182B697F0")]
		private Evvm(Id32<AUNNIJUAVXE> internalFnPtr, Id32<TVAMPUAMYRD<RTIMFYESSKP>> instructionPtr, Id32<XSPVEGMZPQH<RTIMFYESSKP>> registerPtr, IdArray<XSPVEGMZPQH<RTIMFYESSKP>, byte> registers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B693C0", Offset = "0x2B67DC0", VA = "0x182B693C0")]
		public static Evvm New()
		{
			return default(Evvm);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B69320", Offset = "0x2B67D20", VA = "0x182B69320")]
		public bool KHGZICVZVVH(int a = 1024000)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B65D80", Offset = "0x2B64780", VA = "0x182B65D80")]
		public void CBOXVYFNNRJ(Id32<AUNNIJUAVXE> internalFn, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B694F0", Offset = "0x2B67EF0", VA = "0x182B694F0")]
		public void OLMVNCYNJKD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B660B0", Offset = "0x2B64AB0", VA = "0x182B660B0")]
		public void EKJSQNSQNQN([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, [In] ReadOnlyIdSpan<AUNNIJUAVXE, ReadOnlyIdArray<TVAMPUAMYRD<RTIMFYESSKP>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B661C0", Offset = "0x2B64BC0", VA = "0x182B661C0")]
		public static void EKJSQNSQNQN([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, Id32<AUNNIJUAVXE> internalFnPtr, Id32<TVAMPUAMYRD<RTIMFYESSKP>> instructionPtr, Id32<XSPVEGMZPQH<RTIMFYESSKP>> registerPtr, [In] IdSpan<XSPVEGMZPQH<RTIMFYESSKP>, byte> registers, [In] ReadOnlyIdSpan<AUNNIJUAVXE, ReadOnlyIdArray<TVAMPUAMYRD<RTIMFYESSKP>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
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
