using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x267A190", Offset = "0x2679590", VA = "0x18267A190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MLIMKPCDCFG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x338C560", Offset = "0x338B960", VA = "0x18338C560")]
	public static IJOGBJOFPED<JAHELGAGFCI<M>> MLDLLKAJCMP<M>(this int JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x267A160", Offset = "0x2679560", VA = "0x18267A160")]
	public static IJOGBJOFPED<DCGBFPGIBOL> KDFFLIFIPAI(this int JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<DCGBFPGIBOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x338C560", Offset = "0x338B960", VA = "0x18338C560")]
	public static IJOGBJOFPED<KGFODMDJAKK<M>> EKOFBCGJCKN<M>(this int JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<KGFODMDJAKK<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JAHELGAGFCI<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NIIKNDFOBBN
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class NEBCLJMKMGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DCGBFPGIBOL
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class MIEINCILBCI
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HLINKEPHAEC
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum MMOIHINOCDC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	AddF32_F32i_F32i_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	AddF32_F32i_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	AddF32_F32r_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AddI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	AddI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	AddI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	AndI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AndI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	AndI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	BranchIfEqualF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	BranchIfEqualF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	BranchIfEqualF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	BranchIfEqualI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	BranchIfEqualI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	BranchIfEqualI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	BranchIfGreaterF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	BranchIfGreaterF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	BranchIfGreaterF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	BranchIfGreaterI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	BranchIfGreaterI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	BranchIfGreaterI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	BranchIfGreaterOrEqualF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	BranchIfGreaterOrEqualF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	BranchIfGreaterOrEqualF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	BranchIfGreaterOrEqualI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	BranchIfGreaterOrEqualI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BranchIfGreaterOrEqualI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BranchIfLessF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BranchIfLessF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BranchIfLessF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BranchIfLessI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BranchIfLessI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BranchIfLessI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BranchIfLessOrEqualF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BranchIfLessOrEqualF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BranchIfLessOrEqualF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BranchIfLessOrEqualI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BranchIfLessOrEqualI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BranchIfLessOrEqualI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BranchIfNotEqualF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BranchIfNotEqualF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BranchIfNotEqualF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BranchIfNotEqualI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BranchIfNotEqualI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BranchIfNotEqualI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BranchIfNotZeroF32_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	BranchIfNotZeroF32_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	BranchIfNotZeroI32_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	BranchIfNotZeroI32_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	BranchIfZeroF32_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	BranchIfZeroF32_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	BranchIfZeroI32_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	BranchIfZeroI32_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CallInternal_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CallInternal_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CallExternal_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CallExternal_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CallRuntime_I32i_I32i_Xi,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CopyI32_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CopyI32_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CopyX_Xr_I32i_Xi,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CopyX_Xr_Xr_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	DivideF32_F32i_F32i_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	DivideF32_F32i_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	DivideF32_F32r_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DivideI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DivideI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	DivideI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	EqualF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	EqualF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	EqualF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	EqualI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	EqualI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	EqualI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	GreaterF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	GreaterF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	GreaterF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	GreaterI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	GreaterI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GreaterI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	GreaterOrEqualF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	GreaterOrEqualF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	GreaterOrEqualF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	GreaterOrEqualI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	GreaterOrEqualI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	GreaterOrEqualI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Jump_I32i,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Jump_I32r,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	LessF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	LessF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	LessF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	LessI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	LessI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	LessI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	LessOrEqualF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	LessOrEqualF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	LessOrEqualF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	LessOrEqualI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	LessOrEqualI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	LessOrEqualI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	ModI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	ModI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ModI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MultiplyF32_F32i_F32i_F32r,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	MultiplyF32_F32i_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	MultiplyF32_F32r_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	MultiplyI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	MultiplyI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	MultiplyI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	NegateF32_F32i_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NegateF32_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	NegateF32_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	NegateI32_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	NegateI32_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	NegateI32_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	NoOp,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	NotEqualF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	NotEqualF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	NotEqualF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	NotEqualI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	NotEqualI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	NotEqualI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	NotI32_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	NotI32_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	NotI32_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	OrI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	OrI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	OrI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Return,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	StaticCastF32I32_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	StaticCastI32F32_I32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	SubtractF32_F32i_F32i_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	SubtractF32_F32i_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	SubtractF32_F32r_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	SubtractI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	SubtractI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	SubtractI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	XorI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	XorI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	XorI32_I32r_I32r_I32r
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HMLNGAMGFEK
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct DNAKNDHOFLA<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr FOBLOMCENPC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
		public DNAKNDHOFLA(IntPtr BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x66FABD0", Offset = "0x66F9FD0", VA = "0x1866FABD0")]
		public int HKANHPMMIAO(TDeps OHJFEHDLOHB, TContext PDBOIKJNMKA, TCompileState CIBBJHMCOIJ, [In] AJFCGHOLDCP<byte> BEAIPLNCIOD, int NAFKDGMKBON)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x360F610", Offset = "0x360EA10", VA = "0x18360F610")]
	public static void PANFCFJMOHO<TDeps, TContext, TCompileState>(TDeps OHJFEHDLOHB, TContext PDBOIKJNMKA, TCompileState CIBBJHMCOIJ, [In] AJFCGHOLDCP<byte> DPBGHLMBKLC, AJFCGHOLDCP<byte> PFKOJELINBA, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FHCFIJEJHGF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KCKEEEIIBGB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NLJCOGIADOG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? JOPOMNEEDCC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CEGHLGOPPCF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GGGFJNNIILJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OLMJDNOEBCH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EBNFLAIGJPG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? AELHOLNBNNA, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KMFMJHKIJFD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FEGOOFIHGFK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LCDKIJBJPGM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NINFCOOPKBO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BOODNHGKLKO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KHPDEFAAIFH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KMMCHHPKHJF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HDAKDICCEDI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IBNOIGOKJHN, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CEJFIMEJFGB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MFJGNPOICLG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LEOFDECFCJG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HOGPPFLFNHC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PNGGBNDPGCN, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OPHFMMHDGFD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EFOFBCNNMPH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PFEDKHPEBFB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CHECIKAANCK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NGDHJDCKAOE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KCAAOKBAIML, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CGPHGPMEJDA, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HGKNIPBMHLD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DHHBPHLGMFF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BNBPEGDCNGD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EHLLHLLCMCG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? AKBMBEABAGJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PPOFGFLMIMP, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GLEPBGKAECC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? AFFEBMGHHAA, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PCIKCBOABDB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? INBKNOOMBLD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PFOOILABILL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IKDABBMKMEL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KOEJHCFHKJD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EIELNBJFHAE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? ANOPHMBKJDB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DKMFNIGMNOE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EEPICJKKBOL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? AHIIDMJCIMC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CKFDDHCAHMO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MBAKMDNEGKJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GFLJEKIABGE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MHFDECFDOGG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MPBIKOAILAG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KEDEMPMDJDC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MMCELBHJLNL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KHOIFIHHGCG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OABPDBOCFFO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EFHHDEOEMPB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NACMICKKJOA, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NMDHLNIANMG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MIPKIFFICAJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DCOPCLEFALD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PJOMIGCPBII, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OGAKOHLLIDO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FDGIACADFMG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MEIFPDDCEAH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OJMNOKJMEOK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HDFGAFMICGM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KJAHHLLLGOO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FGEGGFJKAOK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? AEKBIIECMDF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LLKPJBPHFCO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BJEKABNAKAB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BNPCBDGMDFL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OIGCADIKLDC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? COBEGPHCIJM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HCNCFGGDDKD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FFJKNNEFCFF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FLAPPLLPBED, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DHPOFILIEMM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HGABLPLMEHD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DFKKLBNFIBI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MEPOMJEHMBO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IFBIKCCOGAE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BJFPBHKAPAK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BFNJAADEHHL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LMLJADMCECI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LEEBGINBOFN, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EEBIBAMKILG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? ENEPOLJLKEI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EPECADBBDLK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MPPPDGEFHBC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IFMCMGALLEG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DNBMDOABDNH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CKBLKHPMDJH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HPOFLINFHJM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HKKCLJBINJD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? ENJJEEMEHKG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GHBAMHBKPPG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PMEEFGKEGGK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? COFCIFLBHPG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EJHPIDBOGML, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OLHMNLDHAPL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HMBPEKBOJDE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OADFGADDKBM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FDFFFGHOBKL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MMAKJMPAOFH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BIMHFFENIJJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? ONPACNACKFB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IOGIEAAEDHM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CCLHLCCOBLI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LCODMCKKIIJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OILFCCILKOI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FABCHLPGKPL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KFELNOJOFLC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IBHIONJBFDG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PLDMCJCDEDH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LGEMAOCBAJH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HMAFOEPAEJF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GCHKCOOFNPG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OJPKMCCKAFE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MNMAPOKEPGL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? APMMAEFFBBP, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CJLHPBJLFAO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MIIJEBHAAMI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NDIDLLDIKKH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MNJFHPDPJEL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GBFKKJJIMFB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MHLKMIKMBFK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IMGHLPDIPOG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DLDPNHOAPJL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IGJFPGILGAO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LDJLLAHIPHP, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FIAPMLEACOJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OLIOGFHIEJA) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2673D40", Offset = "0x2673140", VA = "0x182673D40")]
	private static int PGGEMKNCLFF([In] AJFCGHOLDCP<byte> FJONCPGPEAA, AJFCGHOLDCP<byte> DECLPGCFODA, int HCJENEHBBIC, int ECKHNAPCKGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JKCMJPLICBA
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int BNKHPLKFJAM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x368F650", Offset = "0x368EA50", VA = "0x18368F650")]
	public static IJOGBJOFPED<JAHELGAGFCI<T>> MKHHGOFPDDB<T>([In] this AJFCGHOLDCP<byte> JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x368F590", Offset = "0x368E990", VA = "0x18368F590")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<T>>> DNOCBFCIDAJ<T>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<JAHELGAGFCI<T>>? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2673ED0", Offset = "0x26732D0", VA = "0x182673ED0")]
	public static IJOGBJOFPED<JAHELGAGFCI<GFMPOBJPFLN>> BKHIFFPJMFM(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<GFMPOBJPFLN>? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<GFMPOBJPFLN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2674270", Offset = "0x2673670", VA = "0x182674270")]
	public static IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>> KBIBHOLNNPK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] float? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2674360", Offset = "0x2673760", VA = "0x182674360")]
	public static IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>> PPLHJLBPAID(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2674190", Offset = "0x2673590", VA = "0x182674190")]
	public static IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>> JLODKFIGCAG(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<FNOIGLEFPAM>? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2673FB0", Offset = "0x26733B0", VA = "0x182673FB0")]
	public static IJOGBJOFPED<JAHELGAGFCI<HLINKEPHAEC>> CFFPKDCOPKO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] byte? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<HLINKEPHAEC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26740B0", Offset = "0x26734B0", VA = "0x1826740B0")]
	public static IJOGBJOFPED<JAHELGAGFCI<DCGBFPGIBOL>> GIMMJFJIMPL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<DCGBFPGIBOL>? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<DCGBFPGIBOL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2673DE0", Offset = "0x26731E0", VA = "0x182673DE0")]
	public static IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> AJDBFKFDEPE(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] MMOIHINOCDC? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x368F6B0", Offset = "0x368EAB0", VA = "0x18368F6B0")]
	public static IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<T>>> PEJICIFNOLK<T>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<T>>? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2673BF0", Offset = "0x2672FF0", VA = "0x182673BF0")]
	public static void MNDHDKKOOFK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>> GHEEEKBPNJN, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x368F580", Offset = "0x368E980", VA = "0x18368F580")]
	public static void CBOLANDLOIB<T>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<T>>> NAFKDGMKBON, IJOGBJOFPED<JAHELGAGFCI<T>> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x368F580", Offset = "0x368E980", VA = "0x18368F580")]
	public static void NLIHOGDCAPK<T>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<T>>> FIOJHHMNFOB, IJOGBJOFPED<KGFODMDJAKK<T>> FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EMMMMGPKIGO
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2673C30", Offset = "0x2673030", VA = "0x182673C30")]
	public static AKBOPDOBDEE ALPCFNMOJFB([In] this ReadOnlySpan<byte> DHHEGLJJIIE, int KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2673CA0", Offset = "0x26730A0", VA = "0x182673CA0")]
	public static AKBOPDOBDEE ALPCFNMOJFB([In] this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3487CA0", Offset = "0x34870A0", VA = "0x183487CA0")]
	public static AKBOPDOBDEE ALPCFNMOJFB<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3487B40", Offset = "0x3486F40", VA = "0x183487B40")]
	public static AKBOPDOBDEE ALPCFNMOJFB<M>([In] this LMHBKDKBDNL<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3487EB0", Offset = "0x34872B0", VA = "0x183487EB0")]
	public static AKBOPDOBDEE ALPCFNMOJFB<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3487F10", Offset = "0x3487310", VA = "0x183487F10")]
	public static AKBOPDOBDEE ALPCFNMOJFB<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3487DF0", Offset = "0x34871F0", VA = "0x183487DF0")]
	public static AKBOPDOBDEE ALPCFNMOJFB<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2673C30", Offset = "0x2673030", VA = "0x182673C30")]
	public static int JACLBCCGBGP([In] this ReadOnlySpan<byte> DHHEGLJJIIE, int KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2673B20", Offset = "0x2672F20", VA = "0x182673B20")]
	public static int JACLBCCGBGP([In] this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3401420", Offset = "0x3400820", VA = "0x183401420")]
	public static int JACLBCCGBGP<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3401420", Offset = "0x3400820", VA = "0x183401420")]
	public static int JACLBCCGBGP<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3401420", Offset = "0x3400820", VA = "0x183401420")]
	public static int JACLBCCGBGP<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3401420", Offset = "0x3400820", VA = "0x183401420")]
	public static int JACLBCCGBGP<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34883E0", Offset = "0x34877E0", VA = "0x1834883E0")]
	public static float MIHKIMGPIJE<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34883E0", Offset = "0x34877E0", VA = "0x1834883E0")]
	public static float MIHKIMGPIJE<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34883E0", Offset = "0x34877E0", VA = "0x1834883E0")]
	public static float MIHKIMGPIJE<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3488500", Offset = "0x3487900", VA = "0x183488500")]
	public static byte PGIDMAPDEFF<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3488420", Offset = "0x3487820", VA = "0x183488420")]
	public static byte PGIDMAPDEFF<M>([In] this LMHBKDKBDNL<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3487EB0", Offset = "0x34872B0", VA = "0x183487EB0")]
	public static byte PGIDMAPDEFF<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3487F10", Offset = "0x3487310", VA = "0x183487F10")]
	public static byte PGIDMAPDEFF<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3488440", Offset = "0x3487840", VA = "0x183488440")]
	public static byte PGIDMAPDEFF<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2673B20", Offset = "0x2672F20", VA = "0x182673B20")]
	public static MMOIHINOCDC JDFCGIMLONH([In] this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA)
	{
		return default(MMOIHINOCDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3401420", Offset = "0x3400820", VA = "0x183401420")]
	public static MMOIHINOCDC JDFCGIMLONH<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(MMOIHINOCDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3488220", Offset = "0x3487620", VA = "0x183488220")]
	public static IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> KEKKLBPIJAL<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3488300", Offset = "0x3487700", VA = "0x183488300")]
	public static IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> KEKKLBPIJAL<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3488290", Offset = "0x3487690", VA = "0x183488290")]
	public static IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> KEKKLBPIJAL<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3487F80", Offset = "0x3487380", VA = "0x183487F80")]
	public static IJOGBJOFPED<KGFODMDJAKK<JCKHHCNOCBD>> BEJAHFCKDGF<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<KGFODMDJAKK<JCKHHCNOCBD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x34881B0", Offset = "0x34875B0", VA = "0x1834881B0")]
	public static IJOGBJOFPED<DCGBFPGIBOL> CNECAEKGIEM<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<DCGBFPGIBOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3488140", Offset = "0x3487540", VA = "0x183488140")]
	public static IJOGBJOFPED<DCGBFPGIBOL> CNECAEKGIEM<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<DCGBFPGIBOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34880D0", Offset = "0x34874D0", VA = "0x1834880D0")]
	public static IJOGBJOFPED<DCGBFPGIBOL> CNECAEKGIEM<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<DCGBFPGIBOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3487FF0", Offset = "0x34873F0", VA = "0x183487FF0")]
	public static IJOGBJOFPED<GFMPOBJPFLN> BOFAFDDGPIG<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<GFMPOBJPFLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3488060", Offset = "0x3487460", VA = "0x183488060")]
	public static IJOGBJOFPED<GFMPOBJPFLN> BOFAFDDGPIG<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<GFMPOBJPFLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3488370", Offset = "0x3487770", VA = "0x183488370")]
	public static IJOGBJOFPED<FNOIGLEFPAM> KHMIAEJNOPE<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<FNOIGLEFPAM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MFIEINBENKK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x26745E0", Offset = "0x26739E0", VA = "0x1826745E0")]
	public static void FMDEOFFPGIP(this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA, AKBOPDOBDEE FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2674570", Offset = "0x2673970", VA = "0x182674570")]
	public static void FMDEOFFPGIP(this byte[] DHHEGLJJIIE, int KHGADHNAFJA, AKBOPDOBDEE FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x26744F0", Offset = "0x26738F0", VA = "0x1826744F0")]
	public static void FMDEOFFPGIP([In] this Span<byte> DHHEGLJJIIE, int KHGADHNAFJA, AKBOPDOBDEE FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x372DC30", Offset = "0x372D030", VA = "0x18372DC30")]
	public static void FMDEOFFPGIP<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, AKBOPDOBDEE FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x372DDD0", Offset = "0x372D1D0", VA = "0x18372DDD0")]
	public static void FMDEOFFPGIP<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, AKBOPDOBDEE FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2673BF0", Offset = "0x2672FF0", VA = "0x182673BF0")]
	public static void MNDHDKKOOFK(this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2674760", Offset = "0x2673B60", VA = "0x182674760")]
	public static void MNDHDKKOOFK(this byte[] DHHEGLJJIIE, int KHGADHNAFJA, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26746E0", Offset = "0x2673AE0", VA = "0x1826746E0")]
	public static void MNDHDKKOOFK([In] this Span<byte> DHHEGLJJIIE, int KHGADHNAFJA, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x372E030", Offset = "0x372D430", VA = "0x18372E030")]
	public static void MNDHDKKOOFK<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x372E090", Offset = "0x372D490", VA = "0x18372E090")]
	public static void MNDHDKKOOFK<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x26746A0", Offset = "0x2673AA0", VA = "0x1826746A0")]
	public static void IPBOAGFJABP(this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x372DF70", Offset = "0x372D370", VA = "0x18372DF70")]
	public static void IPBOAGFJABP<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x372DFD0", Offset = "0x372D3D0", VA = "0x18372DFD0")]
	public static void IPBOAGFJABP<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2674480", Offset = "0x2673880", VA = "0x182674480")]
	public static void ACBPPLJIEGE(this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA, byte FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x372DB90", Offset = "0x372CF90", VA = "0x18372DB90")]
	public static void ACBPPLJIEGE<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, byte FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x372DBE0", Offset = "0x372CFE0", VA = "0x18372DBE0")]
	public static void ACBPPLJIEGE<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, byte FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3401480", Offset = "0x3400880", VA = "0x183401480")]
	public static void CBOLANDLOIB<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3401480", Offset = "0x3400880", VA = "0x183401480")]
	public static void CBOLANDLOIB<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3401480", Offset = "0x3400880", VA = "0x183401480")]
	public static void PJCODPKFNEK<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, IJOGBJOFPED<DCGBFPGIBOL> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3401480", Offset = "0x3400880", VA = "0x183401480")]
	public static void PJCODPKFNEK<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, IJOGBJOFPED<DCGBFPGIBOL> FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MJGNEJEHNHH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2675840", Offset = "0x2674C40", VA = "0x182675840")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) DAMNAACPOMB(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2677280", Offset = "0x2676680", VA = "0x182677280")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) HHEAMEACOIL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26755F0", Offset = "0x26749F0", VA = "0x1826755F0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) CJDMJALBHAN(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2674FB0", Offset = "0x26743B0", VA = "0x182674FB0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) BMBCDNIIJNC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26798E0", Offset = "0x2678CE0", VA = "0x1826798E0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) OOCMMMFLOGP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x26773D0", Offset = "0x26767D0", VA = "0x1826773D0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) IBOJHJLHODP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2678370", Offset = "0x2677770", VA = "0x182678370")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) LBNCDPNBMDB(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2679DD0", Offset = "0x26791D0", VA = "0x182679DD0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PHOEJBOPBNE(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2678B40", Offset = "0x2677F40", VA = "0x182678B40")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) NGJAGLIBCOC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2675260", Offset = "0x2674660", VA = "0x182675260")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>) CELJLDADEBA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? FFOEEMKIKJO, [Optional] IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? MHNMJHBLJNF)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2675D50", Offset = "0x2675150", VA = "0x182675D50")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>) ECAPPNGKHHA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? FFOEEMKIKJO, [Optional] IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? MHNMJHBLJNF)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2677170", Offset = "0x2676570", VA = "0x182677170")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>) HGKFGNEDGCO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? FFOEEMKIKJO, [Optional] IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? MHNMJHBLJNF)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2676F60", Offset = "0x2676360", VA = "0x182676F60")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>) HDNJCICJGAH(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? FFOEEMKIKJO, [Optional] IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? MHNMJHBLJNF)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2676750", Offset = "0x2675B50", VA = "0x182676750")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<GFMPOBJPFLN>>) FKHICOOPDPN(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? JIOJGMLCCPJ, [Optional] IJOGBJOFPED<GFMPOBJPFLN>? MOIIPMBKBLO)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<GFMPOBJPFLN>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2674930", Offset = "0x2673D30", VA = "0x182674930")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<GFMPOBJPFLN>>>) ALBMGJILBNC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? JIOJGMLCCPJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<GFMPOBJPFLN>>? MOIIPMBKBLO)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<GFMPOBJPFLN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2679740", Offset = "0x2678B40", VA = "0x182679740")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<DCGBFPGIBOL>>) OMMGLKFNBPL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? JIOJGMLCCPJ, [Optional] IJOGBJOFPED<DCGBFPGIBOL>? MOIIPMBKBLO)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<DCGBFPGIBOL>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2676240", Offset = "0x2675640", VA = "0x182676240")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<DCGBFPGIBOL>>>) FBJHAMKCAAL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? JIOJGMLCCPJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<DCGBFPGIBOL>>? MOIIPMBKBLO)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<DCGBFPGIBOL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3738A60", Offset = "0x3737E60", VA = "0x183738A60")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>) GONHHDDEJDE<TMarker>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<FNOIGLEFPAM>? MOIIPMBKBLO, [Optional][In] ReadOnlySpan<byte> HPMNBNLACCC)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x26764A0", Offset = "0x26758A0", VA = "0x1826764A0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) FKFLNCICGLC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int FJONCPGPEAA, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DECLPGCFODA)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2678A30", Offset = "0x2677E30", VA = "0x182678A30")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) NBPIGBPECID(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? FJONCPGPEAA, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DECLPGCFODA)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3738DB0", Offset = "0x37381B0", VA = "0x183738DB0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>) NOMHEBBIEKA<TMarker>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<TMarker>>? DECLPGCFODA, [Optional] int? MNDMOIHIBEI, [Optional][In] ReadOnlySpan<byte> FJONCPGPEAA)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3738C60", Offset = "0x3738060", VA = "0x183738C60")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>) HDOGJCJALJC<TMarker>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<TMarker>>? FJONCPGPEAA, [Optional] IJOGBJOFPED<KGFODMDJAKK<TMarker>>? DECLPGCFODA, [Optional] int? MNDMOIHIBEI)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2674E30", Offset = "0x2674230", VA = "0x182674E30")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) BDFEOPEADBK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2676350", Offset = "0x2675750", VA = "0x182676350")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) FDLHNNIHBAA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x26780F0", Offset = "0x26774F0", VA = "0x1826780F0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) KMAOIEBEECH(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2676A00", Offset = "0x2675E00", VA = "0x182676A00")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) FMKHIOIKNFL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2674B90", Offset = "0x2673F90", VA = "0x182674B90")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) AOIOKJOBMFM(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26787B0", Offset = "0x2677BB0", VA = "0x1826787B0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) MIIDIMJCILL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2678C60", Offset = "0x2678060", VA = "0x182678C60")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) NIFADNPFPEJ(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2674CE0", Offset = "0x26740E0", VA = "0x182674CE0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) APOCGKJELEN(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2679A30", Offset = "0x2678E30", VA = "0x182679A30")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PBFMOKJFHEA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2677080", Offset = "0x2676480", VA = "0x182677080")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>) HFOOOBIKGDI(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? KCECGLFNMNJ)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2677E20", Offset = "0x2677220", VA = "0x182677E20")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) KFLHFOJCNBE(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2678650", Offset = "0x2677A50", VA = "0x182678650")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) MIHNBGLOCDO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2679F20", Offset = "0x2679320", VA = "0x182679F20")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PILINANMNFC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26779F0", Offset = "0x2676DF0", VA = "0x1826779F0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) JLEMNGPNFCB(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2674A40", Offset = "0x2673E40", VA = "0x182674A40")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) AMAMPDPCCKK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26759C0", Offset = "0x2674DC0", VA = "0x1826759C0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) DCDIPCLEOPJ(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2677870", Offset = "0x2676C70", VA = "0x182677870")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) JKLAKODMOAC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2675370", Offset = "0x2674770", VA = "0x182675370")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) CHBEJOLGKCA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2675710", Offset = "0x2674B10", VA = "0x182675710")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) CLCKBBDGDIF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26788D0", Offset = "0x2677CD0", VA = "0x1826788D0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) MPLIELCDNDF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2676E10", Offset = "0x2676210", VA = "0x182676E10")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) GLLGGKFNCCA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2675E70", Offset = "0x2675270", VA = "0x182675E70")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) EELAAEFLNMK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2679260", Offset = "0x2678660", VA = "0x182679260")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) OGIIFIPFNDF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2679C70", Offset = "0x2679070", VA = "0x182679C70")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PEOMNIDFMEC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x26774F0", Offset = "0x26768F0", VA = "0x1826774F0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) IEGIMHFAMHL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2678E40", Offset = "0x2678240", VA = "0x182678E40")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) NMDNAMAEGPJ(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2675110", Offset = "0x2674510", VA = "0x182675110")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) BMKEJHMDHAL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26793E0", Offset = "0x26787E0", VA = "0x1826793E0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) OGIILFMNLFP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26765D0", Offset = "0x26759D0", VA = "0x1826765D0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) FKGNJNOMOEP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x26760E0", Offset = "0x26754E0", VA = "0x1826760E0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) ELKJMOBNDKA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2677740", Offset = "0x2676B40", VA = "0x182677740")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) JEKCIAKAJFC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2676B60", Offset = "0x2675F60", VA = "0x182676B60")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) GGFMAOCNPGE(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2677CD0", Offset = "0x26770D0", VA = "0x182677CD0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) KEEALCFEBPI(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2675C30", Offset = "0x2675030", VA = "0x182675C30")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) DOEDGMDJEGF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x26784D0", Offset = "0x26778D0", VA = "0x1826784D0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) LPKJLCGPLMP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2677FA0", Offset = "0x26773A0", VA = "0x182677FA0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) KLGHOPHCBCF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2679500", Offset = "0x2678900", VA = "0x182679500")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) OHFACKLMLEN(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2678210", Offset = "0x2677610", VA = "0x182678210")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) KOEEFDPKMNH(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2675AE0", Offset = "0x2674EE0", VA = "0x182675AE0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) DKMCINFOKKG(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2677620", Offset = "0x2676A20", VA = "0x182677620")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) JCIAGDIDPMF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x267A050", Offset = "0x2679450", VA = "0x18267A050")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PKOPGHAEJLI(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? KINLKKILGMJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x26768F0", Offset = "0x2675CF0", VA = "0x1826768F0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) FLLLFGDPNFF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? KINLKKILGMJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2678DC0", Offset = "0x26781C0", VA = "0x182678DC0")]
	public static IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> NJDOCPNPPIO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2677B50", Offset = "0x2676F50", VA = "0x182677B50")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) KBAALKCLKGP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x26747E0", Offset = "0x2673BE0", VA = "0x1826747E0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) ACEKPMDNCCE(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2679620", Offset = "0x2678A20", VA = "0x182679620")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) OMKGMDDIEPK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2679100", Offset = "0x2678500", VA = "0x182679100")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) OGAIGFDCDBM(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2675F90", Offset = "0x2675390", VA = "0x182675F90")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) EJJBPAACIAJ(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2679B50", Offset = "0x2678F50", VA = "0x182679B50")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PBLNKCALNMF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2678FA0", Offset = "0x26783A0", VA = "0x182678FA0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) NOALDOFHLGO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2676CC0", Offset = "0x26760C0", VA = "0x182676CC0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) GJCHODJKFJO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26754D0", Offset = "0x26748D0", VA = "0x1826754D0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) CIPDEIHPELB(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
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
