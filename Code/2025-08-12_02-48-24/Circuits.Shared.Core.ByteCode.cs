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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AEA370", Offset = "0x2AE8970", VA = "0x182AEA370")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OOHPNGCHOKM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B310", Offset = "0x3B09910", VA = "0x183B0B310")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<M>> KJOOPHMCJKH<M>(this int CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA3F0", Offset = "0x2AE89F0", VA = "0x182AEA3F0")]
	public static AEOJKNGHIFP<MBCCODFIKOD> BAIPDFINECI(this int CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<MBCCODFIKOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B310", Offset = "0x3B09910", VA = "0x183B0B310")]
	public static AEOJKNGHIFP<GHGPBDJNHMJ<M>> KKCNNFGEKKO<M>(this int CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<GHGPBDJNHMJ<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class LBEDHGCJEFE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class MPPEFCGBKFI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class JCJHMLMKFCL
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MBCCODFIKOD
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class JPAECFFFFJC
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class AGHKNNLMFIM
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GCKDJNIGHFP
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
public static class EGGBBGEIPFH
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HHLFKFPGDMO<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr KHLLEJJMKOB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB0F30", VA = "0x180EB2930")]
		public HHLFKFPGDMO(IntPtr FCFHEFKEJPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x50B7D30", Offset = "0x50B6330", VA = "0x1850B7D30")]
		public int JKGEGDFKKNG(TDeps AIJNNPIBFLN, TContext KOPCCOFFNGJ, TCompileState BOEMGECGEJI, [In] OEFGLPCMBJB<byte> KCCCIJKLCMA, int MLNMINDHPEJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B300", Offset = "0x3C09900", VA = "0x183C0B300")]
	public static void MDNIAHEPMCA<TDeps, TContext, TCompileState>(TDeps AIJNNPIBFLN, TContext KOPCCOFFNGJ, TCompileState BOEMGECGEJI, [In] OEFGLPCMBJB<byte> EDEJHLEDBJK, OEFGLPCMBJB<byte> BBPGOOALCED, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? ALIPKAGEKMD, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? NKHLGIPMEHG, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? CANFFDPPMED, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? KNACJLHPKBJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? MIBMFEOOCOC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GMNOHOCJGEA, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? AGIMENHGFPC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? ELHNBBNDKBG, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? DNKKBILAHFD, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? ICPGJNKFAKF, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? KECPMKJNNHB, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? KLBDLPKBKLH, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? OAPMHKCMFJP, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? LPOOJEFCMBG, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? JPNBKONOPJC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? OBKHOAHGEOP, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? DODIPBFPNAO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? AFBDAEGNDPG, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? MBJPEDOMNNC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? NNDLEPPGAAK, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? HDCCIDOOGCD, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? CMHGDDAHCNB, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? ACFHOAANDBM, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? FMNOPDHALLE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? KEGJAHAAJNI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GGPDFGLFPCD, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? HEJGMKOIMCG, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? FALAPMIEOHJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? JJPBPEKOPEO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? BMHIFCEALGF, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GCBEMOFOKIJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? AGLFPFEOPII, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? AKAALHMAGCE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? FCKKIEPGEJO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GDKJLNFIIJH, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? IAKIKIJKGNJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? LDNNIGOKKJK, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GLONPKIGELJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? FFPMAFJJODA, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GMNGLJKJMKJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? BJAOLGBBGHP, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? IGALJLPNCHC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? EHJBGGLHEOI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? BOJOGDJHIOO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GBDHDNGLNHO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? DGGOJOCPBNK, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? BCADJFKCABM, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? OAHJPHDNELK, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? NBCJDNMENAL, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? FIEOABLIAPE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? BLMALBBBBGJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? CIFAKGKOAIJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? MMLLLLGBLOO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? PBDCBIPMPAC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? HGCIIGPHIJI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? LFLMGJGPPJB, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? PHBEHALLCGO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? HFPNBBBHFLH, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? AMCEEMOGEGA, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? IMNIMMEGCHI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? JPANACJJHDC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? IKAPLNBFGDL, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? MCJGFNLMFMJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GGGLBNCEPHB, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? BJKIJGAHJPB, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? DPDACPGMJAA, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? HEAJENJKLIE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? MILCBLMDMCM, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? PFDEDAMEAAB, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? EAALJGFNOPH, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? NMCDGMFGMEP, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? APMKCJMKLOM, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? PHNMDHGEOHO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? KJCFMCJCLNB, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? AMBHPCMAEEL, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? DMAMCGKAGHE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? JFECMOIDECC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? PBBHLCCKADF, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? CHKEDJEANFC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? LPEDNHBIIDK, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? NGGHLCNAPFI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? LBNIONHOCNL, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? MGFHAHCAGCJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? JBEMLAMNDCC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? CINMHOBBALJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? LNFFLGFALGK, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? OAMLDOLJBCO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? CIDOIJNGAMK, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? JBDHLPBKLDE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? JAAMOFEEHHJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? PKIDLKAEEEO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? OCKCHJLHANL, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? NKFAOOCJLOA, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? IPOBNOCOPGE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? MOGHKJFAEFM, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? PHNOOCGJEFN, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? MMPNFANGBGE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? JFGPBBGPFJD, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GNDIBHGKCHA, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? KGFIGJCNLCD, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? HHDBELDFIHF, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? DCOBIPDLIKI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? JNKJKAOCKGE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? EFAHAELKDLF, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? NMBMBENCPKI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? DHDMLOFMGAE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? AHCBONGPEJO, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? DGHLFMECMDM, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? AFJENAEKHJE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GLBDOECECOE, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? LPAAKDEANBB, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? BOGOEGJCJFP, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? HANALCEIJFP, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? EIJNEDLKIPJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? LFCLNPNIHEN, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? OCCECNGNBJG, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? OGBBOGDGFOI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? NGMLEIMMION, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? EIPIJOLFAHH, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? MCIJPFPDADI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? HANPFNEPEGN, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? GOCIAMEHBDK, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? OFKDOHKEENB, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? IDOFKMBEGAN, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? NOCDGPHILCL, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? PAMAMKEEKPI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? LLMJMCOHNPH, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? OMMGPLKOGOM, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? AJCEFAAKBPJ, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? CNINPHDNPJC, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? EOBHKBKBHOM, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? AFALIBHMOKI, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? BDDPJAGFHGD, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? HIBPNLADAEH, [Optional] HHLFKFPGDMO<TContext, TDeps, TCompileState>? KODKCNOALGI) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4950", Offset = "0x2AE2F50", VA = "0x182AE4950")]
	private static int AKKCFGNMBPN([In] OEFGLPCMBJB<byte> BEDGCBJMDED, OEFGLPCMBJB<byte> IKOPHEOIONA, int NEIBMENBNPA, int FEEKNNBMJMM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DFEBIFDHHIO
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int JLNHMAGPABH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1DA0", Offset = "0x3BD03A0", VA = "0x183BD1DA0")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<T>> FHLCNNFEKOO<T>([In] this OEFGLPCMBJB<byte> CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1DF0", Offset = "0x3BD03F0", VA = "0x183BD1DF0")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<T>>> PICEFFDNPBM<T>(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<LBEDHGCJEFE<T>>? FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE44E0", Offset = "0x2AE2AE0", VA = "0x182AE44E0")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<HGHHPBFOBDA>> GKNGMNJDNAK(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<HGHHPBFOBDA>? FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<HGHHPBFOBDA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4340", Offset = "0x2AE2940", VA = "0x182AE4340")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>> DECHNMAGPCO(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] float? FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4770", Offset = "0x2AE2D70", VA = "0x182AE4770")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>> NEKNLNHOFPA(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] int? FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4410", Offset = "0x2AE2A10", VA = "0x182AE4410")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<CMEPPNMKNHN>> FAOKJPEOPPI(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<CMEPPNMKNHN>? FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<CMEPPNMKNHN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2AE45B0", Offset = "0x2AE2BB0", VA = "0x182AE45B0")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<AGHKNNLMFIM>> HNGJNBJOEOM(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] byte? FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<AGHKNNLMFIM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2AE46A0", Offset = "0x2AE2CA0", VA = "0x182AE46A0")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<MBCCODFIKOD>> KIHGOIMODGH(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<MBCCODFIKOD>? FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<MBCCODFIKOD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4840", Offset = "0x2AE2E40", VA = "0x182AE4840")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> NOGLCBBFCIB(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] GCKDJNIGHFP? FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1CE0", Offset = "0x3BD02E0", VA = "0x183BD1CE0")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<T>>> FECDDEDLBHK<T>(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<T>>? FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3EF0", Offset = "0x2AE24F0", VA = "0x182AE3EF0")]
	public static void MIHCHFEDJIM(this OEFGLPCMBJB<byte> CCKLBDLJPNG, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>> KLPLNCDGCBC, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1CD0", Offset = "0x3BD02D0", VA = "0x183BD1CD0")]
	public static void OEFKABPFGKK<T>(this OEFGLPCMBJB<byte> CCKLBDLJPNG, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<T>>> MLNMINDHPEJ, AEOJKNGHIFP<LBEDHGCJEFE<T>> FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1CD0", Offset = "0x3BD02D0", VA = "0x183BD1CD0")]
	public static void BEJOOCGDENH<T>(this OEFGLPCMBJB<byte> CCKLBDLJPNG, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<T>>> DKLFKLBPAHM, AEOJKNGHIFP<GHGPBDJNHMJ<T>> FKMNCAKIOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PGMIPIMBLOA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA420", Offset = "0x2AE8A20", VA = "0x182AEA420")]
	public static NCIHCFDNMCG KLFCMKNMILL([In] this ReadOnlySpan<byte> NCMOHOAIBBB, int GOOIAGHPJCD)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA490", Offset = "0x2AE8A90", VA = "0x182AEA490")]
	public static NCIHCFDNMCG KLFCMKNMILL([In] this OEFGLPCMBJB<byte> NCMOHOAIBBB, int GOOIAGHPJCD)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F69490", Offset = "0x3F67A90", VA = "0x183F69490")]
	public static NCIHCFDNMCG KLFCMKNMILL<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F695A0", Offset = "0x3F67BA0", VA = "0x183F695A0")]
	public static NCIHCFDNMCG KLFCMKNMILL<M>([In] this NKODHLJKINE<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3F69090", Offset = "0x3F67690", VA = "0x183F69090")]
	public static NCIHCFDNMCG KLFCMKNMILL<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3F68FA0", Offset = "0x3F675A0", VA = "0x183F68FA0")]
	public static NCIHCFDNMCG KLFCMKNMILL<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3F696B0", Offset = "0x3F67CB0", VA = "0x183F696B0")]
	public static NCIHCFDNMCG KLFCMKNMILL<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA420", Offset = "0x2AE8A20", VA = "0x182AEA420")]
	public static int KLBEIKEFGKC([In] this ReadOnlySpan<byte> NCMOHOAIBBB, int GOOIAGHPJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3F30", Offset = "0x2AE2530", VA = "0x182AE3F30")]
	public static int KLBEIKEFGKC([In] this OEFGLPCMBJB<byte> NCMOHOAIBBB, int GOOIAGHPJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3DA3C40", Offset = "0x3DA2240", VA = "0x183DA3C40")]
	public static int KLBEIKEFGKC<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3DA3C40", Offset = "0x3DA2240", VA = "0x183DA3C40")]
	public static int KLBEIKEFGKC<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DA3C40", Offset = "0x3DA2240", VA = "0x183DA3C40")]
	public static int KLBEIKEFGKC<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3DA3C40", Offset = "0x3DA2240", VA = "0x183DA3C40")]
	public static int KLBEIKEFGKC<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3F692F0", Offset = "0x3F678F0", VA = "0x183F692F0")]
	public static float HLJJKIKLDLJ<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3F692F0", Offset = "0x3F678F0", VA = "0x183F692F0")]
	public static float HLJJKIKLDLJ<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3F692F0", Offset = "0x3F678F0", VA = "0x183F692F0")]
	public static float HLJJKIKLDLJ<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F690E0", Offset = "0x3F676E0", VA = "0x183F690E0")]
	public static byte DKAHIALOGGF<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3F69000", Offset = "0x3F67600", VA = "0x183F69000")]
	public static byte DKAHIALOGGF<M>([In] this NKODHLJKINE<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F69090", Offset = "0x3F67690", VA = "0x183F69090")]
	public static byte DKAHIALOGGF<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3F68FA0", Offset = "0x3F675A0", VA = "0x183F68FA0")]
	public static byte DKAHIALOGGF<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3F69020", Offset = "0x3F67620", VA = "0x183F69020")]
	public static byte DKAHIALOGGF<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3F30", Offset = "0x2AE2530", VA = "0x182AE3F30")]
	public static GCKDJNIGHFP HJFKKDDGMDE([In] this OEFGLPCMBJB<byte> NCMOHOAIBBB, int GOOIAGHPJCD)
	{
		return default(GCKDJNIGHFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3DA3C40", Offset = "0x3DA2240", VA = "0x183DA3C40")]
	public static GCKDJNIGHFP HJFKKDDGMDE<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(GCKDJNIGHFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3F69370", Offset = "0x3F67970", VA = "0x183F69370")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> JIKHEBIDEBG<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3F693D0", Offset = "0x3F679D0", VA = "0x183F693D0")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> JIKHEBIDEBG<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3F69430", Offset = "0x3F67A30", VA = "0x183F69430")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> JIKHEBIDEBG<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3F68F40", Offset = "0x3F67540", VA = "0x183F68F40")]
	public static AEOJKNGHIFP<GHGPBDJNHMJ<EAKMKPIPACI>> CACFJKILPLE<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(AEOJKNGHIFP<GHGPBDJNHMJ<EAKMKPIPACI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3F69230", Offset = "0x3F67830", VA = "0x183F69230")]
	public static AEOJKNGHIFP<MBCCODFIKOD> FHBOCJGBBNI<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(AEOJKNGHIFP<MBCCODFIKOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3F691D0", Offset = "0x3F677D0", VA = "0x183F691D0")]
	public static AEOJKNGHIFP<MBCCODFIKOD> FHBOCJGBBNI<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(AEOJKNGHIFP<MBCCODFIKOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3F69290", Offset = "0x3F67890", VA = "0x183F69290")]
	public static AEOJKNGHIFP<MBCCODFIKOD> FHBOCJGBBNI<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(AEOJKNGHIFP<MBCCODFIKOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F69170", Offset = "0x3F67770", VA = "0x183F69170")]
	public static AEOJKNGHIFP<HGHHPBFOBDA> DOHIAOAPHKD<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(AEOJKNGHIFP<HGHHPBFOBDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3F69110", Offset = "0x3F67710", VA = "0x183F69110")]
	public static AEOJKNGHIFP<HGHHPBFOBDA> DOHIAOAPHKD<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(AEOJKNGHIFP<HGHHPBFOBDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3F69310", Offset = "0x3F67910", VA = "0x183F69310")]
	public static AEOJKNGHIFP<CMEPPNMKNHN> IAHAKAFICCH<M>(this AOLHCLMMPFP<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD)
	{
		return default(AEOJKNGHIFP<CMEPPNMKNHN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CEBMBOEKAGI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE40D0", Offset = "0x2AE26D0", VA = "0x182AE40D0")]
	public static void AMKENBILDGM(this OEFGLPCMBJB<byte> NCMOHOAIBBB, int GOOIAGHPJCD, NCIHCFDNMCG FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3FE0", Offset = "0x2AE25E0", VA = "0x182AE3FE0")]
	public static void AMKENBILDGM(this byte[] NCMOHOAIBBB, int GOOIAGHPJCD, NCIHCFDNMCG FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4050", Offset = "0x2AE2650", VA = "0x182AE4050")]
	public static void AMKENBILDGM([In] this Span<byte> NCMOHOAIBBB, int GOOIAGHPJCD, NCIHCFDNMCG FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B812A0", Offset = "0x3B7F8A0", VA = "0x183B812A0")]
	public static void AMKENBILDGM<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, NCIHCFDNMCG FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B81390", Offset = "0x3B7F990", VA = "0x183B81390")]
	public static void AMKENBILDGM<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, NCIHCFDNMCG FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3EF0", Offset = "0x2AE24F0", VA = "0x182AE3EF0")]
	public static void MIHCHFEDJIM(this OEFGLPCMBJB<byte> NCMOHOAIBBB, int GOOIAGHPJCD, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4240", Offset = "0x2AE2840", VA = "0x182AE4240")]
	public static void MIHCHFEDJIM(this byte[] NCMOHOAIBBB, int GOOIAGHPJCD, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2AE42C0", Offset = "0x2AE28C0", VA = "0x182AE42C0")]
	public static void MIHCHFEDJIM([In] this Span<byte> NCMOHOAIBBB, int GOOIAGHPJCD, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B815E0", Offset = "0x3B7FBE0", VA = "0x183B815E0")]
	public static void MIHCHFEDJIM<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B81590", Offset = "0x3B7FB90", VA = "0x183B81590")]
	public static void MIHCHFEDJIM<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4200", Offset = "0x2AE2800", VA = "0x182AE4200")]
	public static void LIJDAPAEBCA(this OEFGLPCMBJB<byte> NCMOHOAIBBB, int GOOIAGHPJCD, float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B814F0", Offset = "0x3B7FAF0", VA = "0x183B814F0")]
	public static void LIJDAPAEBCA<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B81540", Offset = "0x3B7FB40", VA = "0x183B81540")]
	public static void LIJDAPAEBCA<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4190", Offset = "0x2AE2790", VA = "0x182AE4190")]
	public static void HPIKAKLJOFJ(this OEFGLPCMBJB<byte> NCMOHOAIBBB, int GOOIAGHPJCD, byte FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B81490", Offset = "0x3B7FA90", VA = "0x183B81490")]
	public static void HPIKAKLJOFJ<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, byte FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B814C0", Offset = "0x3B7FAC0", VA = "0x183B814C0")]
	public static void HPIKAKLJOFJ<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, byte FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B81480", Offset = "0x3B7FA80", VA = "0x183B81480")]
	public static void OEFKABPFGKK<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B81480", Offset = "0x3B7FA80", VA = "0x183B81480")]
	public static void OEFKABPFGKK<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B81480", Offset = "0x3B7FA80", VA = "0x183B81480")]
	public static void CBOKAKHLFIH<M>(this EODGFOPIDDI<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, AEOJKNGHIFP<MBCCODFIKOD> FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3B81480", Offset = "0x3B7FA80", VA = "0x183B81480")]
	public static void CBOKAKHLFIH<M>([In] this IHNCGEMLCOG<M, byte> NCMOHOAIBBB, AEOJKNGHIFP<M> GOOIAGHPJCD, AEOJKNGHIFP<MBCCODFIKOD> FKMNCAKIOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FDEFBJLMOBB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6DD0", Offset = "0x2AE53D0", VA = "0x182AE6DD0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) GELBHFHEAAK(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2AE83E0", Offset = "0x2AE69E0", VA = "0x182AE83E0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) JNIMMKNKLFE(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7A20", Offset = "0x2AE6020", VA = "0x182AE7A20")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) HJODFIDJNNA(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7200", Offset = "0x2AE5800", VA = "0x182AE7200")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) GLFABDEKMBA(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9650", Offset = "0x2AE7C50", VA = "0x182AE9650")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) NEFHOLOGBEL(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5070", Offset = "0x2AE3670", VA = "0x182AE5070")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) BALIANGAOGE(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5560", Offset = "0x2AE3B60", VA = "0x182AE5560")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) BMCGBHGLILD(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7EC0", Offset = "0x2AE64C0", VA = "0x182AE7EC0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) JGACEPMHCBN(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6910", Offset = "0x2AE4F10", VA = "0x182AE6910")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) FIFHIHFNMAO(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA260", Offset = "0x2AE8860", VA = "0x182AEA260")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>) PJJIHFCPEAD(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] int? FKMNCAKIOFK, [Optional] AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>? OHFOHPBMHKE)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2AE65A0", Offset = "0x2AE4BA0", VA = "0x182AE65A0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>) FAOBOKBAKOI(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? FKMNCAKIOFK, [Optional] AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>? OHFOHPBMHKE)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9D20", Offset = "0x2AE8320", VA = "0x182AE9D20")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>) OHKGGKAJCPO(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] int? FKMNCAKIOFK, [Optional] AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>? OHFOHPBMHKE)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7360", Offset = "0x2AE5960", VA = "0x182AE7360")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>) GODHAHMJOPO(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? FKMNCAKIOFK, [Optional] AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>? OHFOHPBMHKE)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8840", Offset = "0x2AE6E40", VA = "0x182AE8840")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<HGHHPBFOBDA>>) KGPOGEELJCC(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] int? OKGCAAOEDAO, [Optional] AEOJKNGHIFP<HGHHPBFOBDA>? MGENEOADHDD)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<HGHHPBFOBDA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7480", Offset = "0x2AE5A80", VA = "0x182AE7480")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<HGHHPBFOBDA>>>) GOKHMMGCLAD(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] int? OKGCAAOEDAO, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<HGHHPBFOBDA>>? MGENEOADHDD)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<HGHHPBFOBDA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE62F0", Offset = "0x2AE48F0", VA = "0x182AE62F0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<MBCCODFIKOD>>) EMOKFEHELOA(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] int? OKGCAAOEDAO, [Optional] AEOJKNGHIFP<MBCCODFIKOD>? MGENEOADHDD)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<MBCCODFIKOD>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7800", Offset = "0x2AE5E00", VA = "0x182AE7800")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MBCCODFIKOD>>>) HBGHMCLBCIH(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] int? OKGCAAOEDAO, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MBCCODFIKOD>>? MGENEOADHDD)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MBCCODFIKOD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D86B00", Offset = "0x3D85100", VA = "0x183D86B00")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<CMEPPNMKNHN>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<TMarker>>) IGKMGJKPPLC<TMarker>(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<CMEPPNMKNHN>? MGENEOADHDD, [Optional][In] ReadOnlySpan<byte> DAJAOHIJHHL)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<CMEPPNMKNHN>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7B40", Offset = "0x2AE6140", VA = "0x182AE7B40")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) HKCMJCJEHGM(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int BEDGCBJMDED, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? IKOPHEOIONA)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8730", Offset = "0x2AE6D30", VA = "0x182AE8730")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) KGAHEDNKMLE(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? BEDGCBJMDED, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? IKOPHEOIONA)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3D86920", Offset = "0x3D84F20", VA = "0x183D86920")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<TMarker>>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<TMarker>>) CIGKDBEFEIM<TMarker>(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<TMarker>>? IKOPHEOIONA, [Optional] int? MLMBLBFOLPC, [Optional][In] ReadOnlySpan<byte> BEDGCBJMDED)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<TMarker>>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3D86CF0", Offset = "0x3D852F0", VA = "0x183D86CF0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<TMarker>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<TMarker>>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>) LPGEPDKHMBG<TMarker>(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<TMarker>>? BEDGCBJMDED, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<TMarker>>? IKOPHEOIONA, [Optional] int? MLMBLBFOLPC)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<TMarker>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<TMarker>>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5980", Offset = "0x2AE3F80", VA = "0x182AE5980")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) BOMNMGABLKB(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2AE76B0", Offset = "0x2AE5CB0", VA = "0x182AE76B0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) HADHBFAMAOH(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8C20", Offset = "0x2AE7220", VA = "0x182AE8C20")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) KLFMFCDEKHE(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2AE94F0", Offset = "0x2AE7AF0", VA = "0x182AE94F0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) NBGDAHDOLBP(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4F20", Offset = "0x2AE3520", VA = "0x182AE4F20")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) AMGFKKMPAAF(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE61D0", Offset = "0x2AE47D0", VA = "0x182AE61D0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) EHCECDLGPMG(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5400", Offset = "0x2AE3A00", VA = "0x182AE5400")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) BKLDNHPGNDI(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6080", Offset = "0x2AE4680", VA = "0x182AE6080")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) EGLJHMDDGFE(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6B50", Offset = "0x2AE5150", VA = "0x182AE6B50")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) FPLFJLJDHGN(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6820", Offset = "0x2AE4E20", VA = "0x182AE6820")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>) FHAAODCKEIB(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>? PPNJKOLCMGE)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5DB0", Offset = "0x2AE43B0", VA = "0x182AE5DB0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) ECILIBBPLKA(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9390", Offset = "0x2AE7990", VA = "0x182AE9390")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) MFOLKOOPJKD(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2AE90E0", Offset = "0x2AE76E0", VA = "0x182AE90E0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) LPJINJGJGAK(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5820", Offset = "0x2AE3E20", VA = "0x182AE5820")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) BOAPHPOCHHE(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2AE49F0", Offset = "0x2AE2FF0", VA = "0x182AE49F0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) ABCHOOFKIBK(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8B00", Offset = "0x2AE7100", VA = "0x182AE8B00")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) KJFAMBFEFHP(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9F60", Offset = "0x2AE8560", VA = "0x182AE9F60")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) PBIAPENDCLO(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4B40", Offset = "0x2AE3140", VA = "0x182AE4B40")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) ADABIALDGPN(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8FB0", Offset = "0x2AE75B0", VA = "0x182AE8FB0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) LOJAMMMHBHO(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6C70", Offset = "0x2AE5270", VA = "0x182AE6C70")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) GAPIEJHJIMJ(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9A50", Offset = "0x2AE8050", VA = "0x182AE9A50")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) OAHAKMJDKKB(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6A30", Offset = "0x2AE5030", VA = "0x182AE6A30")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) FMMCAEBLCNC(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8530", Offset = "0x2AE6B30", VA = "0x182AE8530")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) JOOGCFFJKFF(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE97A0", Offset = "0x2AE7DA0", VA = "0x182AE97A0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) NMKAJLLHCEE(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7D90", Offset = "0x2AE6390", VA = "0x182AE7D90")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) INGHPGOIOPC(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE56C0", Offset = "0x2AE3CC0", VA = "0x182AE56C0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) BNPODBHIKDA(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE70B0", Offset = "0x2AE56B0", VA = "0x182AE70B0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) GKBACKAAILJ(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7590", Offset = "0x2AE5B90", VA = "0x182AE7590")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) GPBMAKFDJOG(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9210", Offset = "0x2AE7810", VA = "0x182AE9210")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) MBPNCPOGGFM(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8160", Offset = "0x2AE6760", VA = "0x182AE8160")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) JKENMLDJEBP(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9E30", Offset = "0x2AE8430", VA = "0x182AE9E30")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) OLOIJPILBNJ(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4CA0", Offset = "0x2AE32A0", VA = "0x182AE4CA0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) AJCHBMDKGON(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9900", Offset = "0x2AE7F00", VA = "0x182AE9900")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) NNFDDDKBJCO(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2AE82C0", Offset = "0x2AE68C0", VA = "0x182AE82C0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) JMEOODHCOCB(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA0E0", Offset = "0x2AE86E0", VA = "0x182AEA0E0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) PDBOKLDKMID(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5190", Offset = "0x2AE3790", VA = "0x182AE5190")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) BDLDBGEGCIJ(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2AE89E0", Offset = "0x2AE6FE0", VA = "0x182AE89E0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) KIFMHMKDNNB(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE66C0", Offset = "0x2AE4CC0", VA = "0x182AE66C0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) FDAEOILBBFK(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5C60", Offset = "0x2AE4260", VA = "0x182AE5C60")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) DFDAEJPIGPP(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7C70", Offset = "0x2AE6270", VA = "0x182AE7C70")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) IBHGODJMDHO(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6490", Offset = "0x2AE4A90", VA = "0x182AE6490")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) FADFPHGGJOI(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] int? BKIBDNLMELJ, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7910", Offset = "0x2AE5F10", VA = "0x182AE7910")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) HGFILIKCKCF(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? BKIBDNLMELJ, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE86B0", Offset = "0x2AE6CB0", VA = "0x182AE86B0")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> KABPJGAABKC(this OEFGLPCMBJB<byte> CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9BA0", Offset = "0x2AE81A0", VA = "0x182AE9BA0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) OCOHEGCIEKC(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5F30", Offset = "0x2AE4530", VA = "0x182AE5F30")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) EDMGBFNNFBI(this OEFGLPCMBJB<byte> CCKLBDLJPNG, float HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<MPPEFCGBKFI>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8E90", Offset = "0x2AE7490", VA = "0x182AE8E90")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>) LMPIHAFPFPF(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<MPPEFCGBKFI>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<MPPEFCGBKFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5B00", Offset = "0x2AE4100", VA = "0x182AE5B00")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) DCPDMKOGEHL(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8010", Offset = "0x2AE6610", VA = "0x182AE8010")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) JIDKKJKGGBL(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4E00", Offset = "0x2AE3400", VA = "0x182AE4E00")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) AMDMFCHNKHF(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6F50", Offset = "0x2AE5550", VA = "0x182AE6F50")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) GFMDIIDOFEP(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8D40", Offset = "0x2AE7340", VA = "0x182AE8D40")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) LHNEFOMPEMH(this OEFGLPCMBJB<byte> CCKLBDLJPNG, int HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2AE52E0", Offset = "0x2AE38E0", VA = "0x182AE52E0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>) BIPHBOEMECA(this OEFGLPCMBJB<byte> CCKLBDLJPNG, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? HJOOONLCNPC, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? LFDKOFAPJII, [Optional] AEOJKNGHIFP<GHGPBDJNHMJ<JCJHMLMKFCL>>? KMLDHDNIIHN)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<JCJHMLMKFCL>>>));
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
