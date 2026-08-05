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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
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
		public static readonly ReadOnlyIdArray<KGMTAGLYNTP<RRRVXHRUCXR>, byte> EndHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<BVTCYCWYPSS> InternalFnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<KGMTAGLYNTP<RRRVXHRUCXR>> InstructionPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<UTDLMYHANGH<RRRVXHRUCXR>> RegisterPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IdArray<UTDLMYHANGH<RRRVXHRUCXR>, byte> _registers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly IdArray<UTDLMYHANGH<RRRVXHRUCXR>, byte> TQGVKLKXSUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return default(IdArray<UTDLMYHANGH<RRRVXHRUCXR>, byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E2C0", Offset = "0x2B7D2C0", VA = "0x182B7E2C0")]
		private static ReadOnlyIdArray<KGMTAGLYNTP<RRRVXHRUCXR>, byte> CLPGEJJQLAD()
		{
			return default(ReadOnlyIdArray<KGMTAGLYNTP<RRRVXHRUCXR>, byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B81D30", Offset = "0x2B80D30", VA = "0x182B81D30")]
		private Evvm(Id32<BVTCYCWYPSS> internalFnPtr, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> instructionPtr, Id32<UTDLMYHANGH<RRRVXHRUCXR>> registerPtr, IdArray<UTDLMYHANGH<RRRVXHRUCXR>, byte> registers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E410", Offset = "0x2B7D410", VA = "0x182B7E410")]
		public static Evvm New()
		{
			return default(Evvm);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E370", Offset = "0x2B7D370", VA = "0x182B7E370")]
		public bool LPXUEJURDQV(int a = 1024000)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E540", Offset = "0x2B7D540", VA = "0x182B7E540")]
		public void TQFPJBXTXKL(Id32<BVTCYCWYPSS> internalFn, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B81A30", Offset = "0x2B80A30", VA = "0x182B81A30")]
		public void YZISAFOAUMH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B81920", Offset = "0x2B80920", VA = "0x182B81920")]
		public void XTRREELNPZX([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, [In] ReadOnlyIdSpan<BVTCYCWYPSS, ReadOnlyIdArray<KGMTAGLYNTP<RRRVXHRUCXR>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E870", Offset = "0x2B7D870", VA = "0x182B7E870")]
		public static void XTRREELNPZX([In] RuntimeFnDeps runtimeFnDeps, [In] ExternalFnDeps externalFnDeps, IntPtr a, Id32<BVTCYCWYPSS> internalFnPtr, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> instructionPtr, Id32<UTDLMYHANGH<RRRVXHRUCXR>> registerPtr, [In] IdSpan<UTDLMYHANGH<RRRVXHRUCXR>, byte> registers, [In] ReadOnlyIdSpan<BVTCYCWYPSS, ReadOnlyIdArray<KGMTAGLYNTP<RRRVXHRUCXR>, byte>> internalFns, RuntimeFns b, ExternalFns c, DynamicCircuitsErrDefs d)
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
